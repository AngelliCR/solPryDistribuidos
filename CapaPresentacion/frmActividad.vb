Imports ClaseNegocio

Public Class frmActividad
    Private cargando As Boolean
    Private idActividadActiva As Integer
    Private fechaInicioActiva As DateTime
    Private horasEstimadasActiva As Decimal
    Private maquinaActiva As String
    Private zonaActiva As String

    Private Sub frmActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstilizarBotonPrimario(btnIniciar)
        EstilizarBotonPrimario(btnActualizar)
        EstilizarBotonExito(btnFinalizar)
        EstilizarBotonPeligro(btnAveria)
        EstilizarGrilla(dgvActividades)
        dgvActividades.MinimumSize = New Size(0, 220)
        Me.AutoScroll = True
        ConfigurarNumericos()
        cbxZona.Items.AddRange(modListas.Zonas)
        cbxCombustibleFinal.Items.AddRange(modListas.NivelesCombustible)
        If Not EsOperario() Then
            cbxFiltroEstado.Items.Add("Todos")
            cbxFiltroEstado.Items.Add("ACTIVO")
            cbxFiltroEstado.Items.Add("FINALIZADO")
            cbxFiltroEstado.Items.Add("AVERIADO")
            cbxFiltroEstado.SelectedIndex = 0
            dtpHasta.Value = Date.Today
            dtpDesde.Value = Date.Today.AddDays(-30)
        End If
        AplicarRol()
        CargarTodo()
    End Sub

    Private Sub frmActividad_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        tmrTranscurrido.Stop()
        tmrTranscurrido.Dispose()
    End Sub

    Private Sub AplicarRol()
        Dim operario As Boolean = EsOperario()
        pnlResumen.Visible = Not operario
        pnlFiltros.Visible = Not operario
        pnlDetalle.Visible = Not operario
        If operario Then
            lblGrilla.Text = "Mis jornadas"
        Else
            lblGrilla.Text = "Jornadas"
            pnlCheckin.Visible = False
            pnlControl.Visible = False
        End If
    End Sub

    Private Sub CargarTodo()
        tmrTranscurrido.Stop()
        If EsOperario() Then
            CargarOperario()
        Else
            CargarSupervision()
        End If
    End Sub

    Private Sub CargarOperario()
        pnlCheckin.Visible = True
        pnlControl.Visible = False
        idActividadActiva = 0
        Try
            Dim obj As New clsActividad
            If obj.tieneJornadaActiva(modSesion.UsuarioId) Then
                pnlCheckin.Visible = False
                pnlControl.Visible = True
                MostrarJornadaActiva(obj)
            Else
                PrepararCheckin(obj)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        CargarGrilla(modSesion.UsuarioId, "", New Date(2000, 1, 1), New Date(2099, 12, 31))
    End Sub

    Private Sub PrepararCheckin(obj As clsActividad)
        CargarMaquinasCheckin(obj)
        cbxZona.SelectedIndex = -1
        nudHorasEstimadas.Value = 8D
    End Sub

    Private Sub CargarMaquinasCheckin(obj As clsActividad)
        Dim tabla As DataTable = obj.listarMaquinasParaCheckin()
        cbxMaquina.DataSource = Nothing
        cbxMaquina.DisplayMember = "maquina"
        cbxMaquina.ValueMember = "id_maquinaria"
        cbxMaquina.DataSource = tabla
        Dim hay As Boolean = tabla.Rows.Count > 0
        btnIniciar.Enabled = hay
        lblSinMaquinas.Visible = Not hay
        If hay Then
            cbxMaquina.SelectedIndex = 0
        End If
    End Sub

    Private Sub MostrarJornadaActiva(obj As clsActividad)
        Dim tabla As DataTable = obj.listarActividades(modSesion.UsuarioId, "ACTIVO", New Date(2000, 1, 1), New Date(2099, 12, 31))
        If tabla.Rows.Count = 0 Then
            pnlCheckin.Visible = True
            pnlControl.Visible = False
            idActividadActiva = 0
            PrepararCheckin(obj)
            Return
        End If
        Dim fila As DataRow = tabla.Rows(0)
        idActividadActiva = Convert.ToInt32(fila("id_actividad"))
        maquinaActiva = Convert.ToString(fila("maquina")).Trim()
        zonaActiva = Convert.ToString(fila("zona")).Trim()
        fechaInicioActiva = Convert.ToDateTime(fila("fecha_inicio"))
        horasEstimadasActiva = Convert.ToDecimal(fila("horas_estimadas"))
        cbxCombustibleFinal.SelectedIndex = -1
        lblAlerta.Visible = False
        txtMotivo.Clear()
        txtFalla.Clear()
        nudHorasReales.Value = HorasRedondeadas(fechaInicioActiva)
        MostrarEncabezado()
        tmrTranscurrido.Start()
    End Sub

    Private Sub tmrTranscurrido_Tick(sender As Object, e As EventArgs) Handles tmrTranscurrido.Tick
        If idActividadActiva = 0 Then
            Return
        End If
        MostrarEncabezado()
    End Sub

    Private Sub MostrarEncabezado()
        lblDatosJornada.Text = "Máquina: " & maquinaActiva & "    Zona: " & zonaActiva & "    Inicio: " & fechaInicioActiva.ToString("HH:mm") & "    Horas estimadas: " & horasEstimadasActiva.ToString("0.0") & "    Tiempo transcurrido: " & TextoTranscurrido(fechaInicioActiva)
    End Sub

    Private Sub CargarSupervision()
        If dtpDesde.Value.Date > dtpHasta.Value.Date Then
            MessageBox.Show("La fecha desde no puede ser mayor que la fecha hasta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        CargarGrilla(0, TextoCombo(cbxFiltroEstado), dtpDesde.Value.Date, dtpHasta.Value.Date)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CargarSupervision()
    End Sub

    Private Sub CargarGrilla(idPersonal As Integer, estado As String, desde As Date, hasta As Date)
        cargando = True
        Try
            Dim obj As New clsActividad
            Dim tabla As DataTable = obj.listarActividades(idPersonal, estado, desde, hasta)
            AgregarObservacion(tabla)
            dgvActividades.DataSource = tabla
            ConfigurarColumnas()
            dgvActividades.ClearSelection()
            If tabla.Rows.Count = 0 Then
                If EsOperario() Then
                    lblSinDatos.Text = "Aún no tiene jornadas registradas."
                Else
                    lblSinDatos.Text = "No hay jornadas registradas en el rango seleccionado."
                End If
                lblSinDatos.Width = Math.Max(200, dgvActividades.Width - 24)
                lblSinDatos.Left = dgvActividades.Left + Math.Max(0, (dgvActividades.Width - lblSinDatos.Width) \ 2)
                lblSinDatos.Top = dgvActividades.Top + Math.Max(0, (dgvActividades.Height - lblSinDatos.Height) \ 2)
                lblSinDatos.Visible = True
                lblSinDatos.BringToFront()
            Else
                lblSinDatos.Visible = False
            End If
            If Not EsOperario() Then
                ActualizarTarjetas(tabla)
                LimpiarDetalle()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cargando = False
        End Try
    End Sub

    Private Sub AgregarObservacion(tabla As DataTable)
        tabla.Columns.Add("observacion", GetType(String))
        For Each fila As DataRow In tabla.Rows
            If Convert.ToString(fila("estado")).Trim() = "AVERIADO" Then
                fila("observacion") = TextoBd(fila("observacion_falla"))
            Else
                fila("observacion") = TextoBd(fila("motivo_retraso"))
            End If
        Next
    End Sub

    Private Sub ConfigurarColumnas()
        PonerEncabezado("fecha_inicio", "Inicio")
        PonerEncabezado("maquina", "Máquina")
        PonerEncabezado("zona", "Zona")
        PonerEncabezado("horas_estimadas", "Horas estimadas")
        PonerEncabezado("horas_reales", "Horas reales")
        PonerEncabezado("combustible_final", "Combustible final")
        PonerEncabezado("estado", "Estado")
        PonerEncabezado("fecha_fin", "Fin")
        PonerEncabezado("observacion", "Observación")
        PonerEncabezado("operario", "Operario")
        If dgvActividades.Columns.Contains("fecha_inicio") Then
            dgvActividades.Columns("fecha_inicio").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
        End If
        If dgvActividades.Columns.Contains("fecha_fin") Then
            dgvActividades.Columns("fecha_fin").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
        End If
        If dgvActividades.Columns.Contains("horas_estimadas") Then
            dgvActividades.Columns("horas_estimadas").DefaultCellStyle.Format = "0.0"
        End If
        If dgvActividades.Columns.Contains("horas_reales") Then
            dgvActividades.Columns("horas_reales").DefaultCellStyle.Format = "0.0"
        End If
        Ocultar("id_actividad")
        Ocultar("id_maquinaria")
        Ocultar("id_personal")
        Ocultar("combustible_inicial")
        Ocultar("motivo_retraso")
        Ocultar("observacion_falla")
        If EsOperario() Then
            Ocultar("operario")
        End If
    End Sub

    Private Sub PonerEncabezado(columna As String, titulo As String)
        If dgvActividades.Columns.Contains(columna) Then
            dgvActividades.Columns(columna).HeaderText = titulo
        End If
    End Sub

    Private Sub Ocultar(columna As String)
        If dgvActividades.Columns.Contains(columna) Then
            dgvActividades.Columns(columna).Visible = False
        End If
    End Sub

    Private Sub ActualizarTarjetas(tabla As DataTable)
        Dim activas As Integer = 0
        Dim finalizadas As Integer = 0
        Dim averias As Integer = 0
        For Each fila As DataRow In tabla.Rows
            Dim estado As String = Convert.ToString(fila("estado")).Trim()
            If estado = "ACTIVO" Then
                activas += 1
            ElseIf estado = "FINALIZADO" AndAlso EsHoy(fila("fecha_fin")) Then
                finalizadas += 1
            ElseIf estado = "AVERIADO" AndAlso EsHoy(fila("fecha_fin")) Then
                averias += 1
            End If
        Next
        lblNumActivas.Text = activas.ToString()
        lblNumFinalizadas.Text = finalizadas.ToString()
        lblNumAverias.Text = averias.ToString()
    End Sub

    Private Sub dgvActividades_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvActividades.CellFormatting
        If e.RowIndex < 0 Then
            Return
        End If
        Dim nombre As String = dgvActividades.Columns(e.ColumnIndex).Name
        If nombre = "estado" Then
            Dim colorTexto As Color = ColorEstado(Convert.ToString(e.Value))
            e.CellStyle.ForeColor = colorTexto
            e.CellStyle.SelectionForeColor = colorTexto
        ElseIf nombre = "combustible_final" Then
            e.Value = modListas.CombustibleATexto(e.Value)
            e.FormattingApplied = True
        End If
    End Sub

    Private Sub dgvActividades_SelectionChanged(sender As Object, e As EventArgs) Handles dgvActividades.SelectionChanged
        If EsOperario() OrElse cargando Then
            Return
        End If
        If dgvActividades.CurrentRow Is Nothing Then
            LimpiarDetalle()
            Return
        End If
        MostrarDetalle()
    End Sub

    Private Sub MostrarDetalle()
        lblDetOperario.Text = TextoOGuion("operario")
        lblDetMaquina.Text = TextoOGuion("maquina")
        lblDetZona.Text = TextoOGuion("zona")
        lblDetEstado.Text = TextoOGuion("estado")
        lblDetEstado.ForeColor = ColorEstado(lblDetEstado.Text)
        lblDetInicio.Text = FechaCelda("fecha_inicio")
        lblDetFin.Text = FechaCelda("fecha_fin")
        lblDetHorasEst.Text = NumeroCelda("horas_estimadas")
        lblDetHorasReales.Text = NumeroCelda("horas_reales")
        lblDetCombIni.Text = modListas.CombustibleATexto(dgvActividades.CurrentRow.Cells("combustible_inicial").Value)
        lblDetCombFin.Text = modListas.CombustibleATexto(dgvActividades.CurrentRow.Cells("combustible_final").Value)
        txtDetMotivo.Text = TextoCelda("motivo_retraso")
        txtDetFalla.Text = TextoCelda("observacion_falla")
    End Sub

    Private Sub LimpiarDetalle()
        lblDetOperario.Text = "-"
        lblDetMaquina.Text = "-"
        lblDetZona.Text = "-"
        lblDetEstado.Text = "-"
        lblDetEstado.ForeColor = Color.FromArgb(45, 52, 54)
        lblDetInicio.Text = "-"
        lblDetFin.Text = "-"
        lblDetHorasEst.Text = "-"
        lblDetHorasReales.Text = "-"
        lblDetCombIni.Text = "-"
        lblDetCombFin.Text = "-"
        txtDetMotivo.Clear()
        txtDetFalla.Clear()
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If IdMaquina() <= 0 Then
            MessageBox.Show("Seleccione una máquina.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cbxZona.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione la zona.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            Dim obj As New clsActividad
            Dim idMaquinaria As Integer = IdMaquina()
            If obj.tieneJornadaActiva(modSesion.UsuarioId) Then
                MessageBox.Show("Ya tiene una jornada activa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTodo()
                Return
            End If
            If obj.maquinaOcupada(idMaquinaria) Then
                MessageBox.Show("Esa máquina acaba de ser tomada por otro operario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTodo()
                Return
            End If
            obj.iniciarJornada(idMaquinaria, modSesion.UsuarioId, TextoCombo(cbxZona), nudHorasEstimadas.Value)
            MessageBox.Show("Jornada iniciada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarTodo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbxCombustibleFinal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCombustibleFinal.SelectedIndexChanged
        lblAlerta.Visible = TextoCombo(cbxCombustibleFinal) = "Reserva"
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If idActividadActiva = 0 Then
            Return
        End If
        If cbxCombustibleFinal.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione el combustible final.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If nudHorasReales.Value > horasEstimadasActiva AndAlso String.IsNullOrWhiteSpace(txtMotivo.Text) Then
            MessageBox.Show("Superó las horas estimadas. Indique el motivo del retraso.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMotivo.Focus()
            Return
        End If
        If MessageBox.Show("¿Desea finalizar la jornada y liberar la máquina?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If
        Try
            Dim obj As New clsActividad
            If obj.obtenerEstado(idActividadActiva) <> "ACTIVO" Then
                MessageBox.Show("La jornada ya no está activa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTodo()
                Return
            End If
            obj.finalizarJornada(idActividadActiva, modListas.CombustibleANumero(TextoCombo(cbxCombustibleFinal)), nudHorasReales.Value, txtMotivo.Text)
            MessageBox.Show("Jornada finalizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarTodo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAveria_Click(sender As Object, e As EventArgs) Handles btnAveria.Click
        If idActividadActiva = 0 Then
            Return
        End If
        If txtFalla.Text.Trim().Length < 5 Then
            MessageBox.Show("Ingrese la descripción de la falla (mínimo 5 caracteres).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFalla.Focus()
            Return
        End If
        If MessageBox.Show("Se cerrará la jornada y la máquina pasará a 'En Mantenimiento'. ¿Continuar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If
        Try
            Dim obj As New clsActividad
            If obj.obtenerEstado(idActividadActiva) <> "ACTIVO" Then
                MessageBox.Show("La jornada ya no está activa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTodo()
                Return
            End If
            obj.reportarAveria(idActividadActiva, txtFalla.Text.Trim())
            MessageBox.Show("Avería reportada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarTodo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PintarTarjeta(sender As Object, e As PaintEventArgs) Handles pnlCardActivas.Paint, pnlCardFinalizadas.Paint, pnlCardAverias.Paint
        Dim pnl As Panel = DirectCast(sender, Panel)
        Dim rect As New Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1)
        Using lapiz As New Pen(Color.FromArgb(220, 221, 225))
            e.Graphics.DrawRectangle(lapiz, rect)
        End Using
        Dim colorBarra As Color = Color.FromArgb(91, 127, 177)
        If pnl Is pnlCardFinalizadas Then
            colorBarra = Color.FromArgb(39, 174, 96)
        ElseIf pnl Is pnlCardAverias Then
            colorBarra = Color.FromArgb(192, 57, 43)
        End If
        Using brocha As New SolidBrush(colorBarra)
            e.Graphics.FillRectangle(brocha, 0, 0, pnl.Width, 4)
        End Using
    End Sub

    Private Sub PintarBordeIncidente(sender As Object, e As PaintEventArgs) Handles pnlIncidente.Paint
        Dim pnl As Panel = DirectCast(sender, Panel)
        Dim rect As New Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1)
        Using lapiz As New Pen(Color.FromArgb(231, 76, 60))
            e.Graphics.DrawRectangle(lapiz, rect)
        End Using
    End Sub

    Private Sub ConfigurarNumericos()
        nudHorasEstimadas.DecimalPlaces = 1
        nudHorasEstimadas.Increment = 0.5D
        nudHorasEstimadas.Minimum = 1D
        nudHorasEstimadas.Maximum = 24D
        nudHorasEstimadas.Value = 8D
        nudHorasReales.DecimalPlaces = 1
        nudHorasReales.Increment = 0.5D
        nudHorasReales.Minimum = 0.5D
        nudHorasReales.Maximum = 24D
        nudHorasReales.Value = 0.5D
    End Sub

    Private Function HorasRedondeadas(inicio As DateTime) As Decimal
        Dim totalHoras As Decimal = CDec((DateTime.Now - inicio).TotalHours)
        If totalHoras < 0D Then
            totalHoras = 0D
        End If
        Dim redondeado As Decimal = Math.Round(totalHoras * 2D, 0, MidpointRounding.AwayFromZero) / 2D
        If redondeado < 0.5D Then
            redondeado = 0.5D
        End If
        If redondeado > 24D Then
            redondeado = 24D
        End If
        Return redondeado
    End Function

    Private Function TextoTranscurrido(inicio As DateTime) As String
        Dim span As TimeSpan = DateTime.Now - inicio
        If span.TotalMinutes < 0 Then
            span = TimeSpan.Zero
        End If
        Dim horas As Integer = CInt(Math.Floor(span.TotalHours))
        Return horas.ToString() & " h " & span.Minutes.ToString("00") & " min"
    End Function

    Private Function EsHoy(valor As Object) As Boolean
        If valor Is Nothing OrElse IsDBNull(valor) Then
            Return False
        End If
        Return Convert.ToDateTime(valor).Date = Date.Today
    End Function

    Private Function EsOperario() As Boolean
        Return If(modSesion.UsuarioRol, "").Trim() = "Operario"
    End Function

    Private Function IdMaquina() As Integer
        If cbxMaquina.SelectedValue Is Nothing OrElse IsDBNull(cbxMaquina.SelectedValue) OrElse TypeOf cbxMaquina.SelectedValue Is DataRowView Then
            Return 0
        End If
        Return Convert.ToInt32(cbxMaquina.SelectedValue)
    End Function

    Private Function TextoCombo(cbx As ComboBox) As String
        If cbx.SelectedItem Is Nothing Then
            Return ""
        End If
        Return cbx.SelectedItem.ToString()
    End Function

    Private Function TextoCelda(columna As String) As String
        Dim valor As Object = dgvActividades.CurrentRow.Cells(columna).Value
        Return TextoBd(valor)
    End Function

    Private Function TextoOGuion(columna As String) As String
        Dim texto As String = TextoCelda(columna)
        If texto = "" Then
            Return "-"
        End If
        Return texto
    End Function

    Private Function TextoBd(valor As Object) As String
        If valor Is Nothing OrElse IsDBNull(valor) Then
            Return ""
        End If
        Return valor.ToString().Trim()
    End Function

    Private Function FechaCelda(columna As String) As String
        Dim valor As Object = dgvActividades.CurrentRow.Cells(columna).Value
        If valor Is Nothing OrElse IsDBNull(valor) Then
            Return "-"
        End If
        Return Convert.ToDateTime(valor).ToString("dd/MM/yyyy HH:mm")
    End Function

    Private Function NumeroCelda(columna As String) As String
        Dim valor As Object = dgvActividades.CurrentRow.Cells(columna).Value
        If valor Is Nothing OrElse IsDBNull(valor) Then
            Return "-"
        End If
        Return Convert.ToDecimal(valor).ToString("0.0")
    End Function

    Private Function ColorEstado(estado As String) As Color
        Select Case estado
            Case "ACTIVO"
                Return Color.FromArgb(91, 127, 177)
            Case "FINALIZADO"
                Return Color.FromArgb(39, 174, 96)
            Case "AVERIADO"
                Return Color.FromArgb(192, 57, 43)
            Case Else
                Return Color.FromArgb(45, 52, 54)
        End Select
    End Function
End Class
