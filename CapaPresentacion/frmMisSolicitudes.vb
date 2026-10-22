Imports ClaseNegocio

Public Class frmMisSolicitudes
    Private idSeleccionado As Integer
    Private cargando As Boolean

    Private Sub frmMisSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' No se puede en el Diseñador: AutoGenerateColumns está oculta en la ventana Propiedades.
        dgvSolicitudes.AutoGenerateColumns = False
        CargarMaquinas(0)
        LimpiarCampos()
        CargarGrilla()
    End Sub

    Private Sub CargarMaquinas(idActual As Integer)
        Dim obj As New clsMaquinaria
        Dim tabla As DataTable
        Try
            tabla = obj.listarMaquinariaDisponible()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        Dim fila As DataRow = tabla.NewRow()
        fila("id_maquinaria") = 0
        fila("maquina") = "Seleccione una máquina"
        tabla.Rows.InsertAt(fila, 0)
        cbxmaquina.DataSource = tabla
        cbxmaquina.DisplayMember = "maquina"
        cbxmaquina.ValueMember = "id_maquinaria"
        If idActual > 0 Then
            cbxmaquina.SelectedValue = idActual
            If cbxmaquina.SelectedIndex < 0 Then
                cbxmaquina.SelectedIndex = 0
            End If
        Else
            cbxmaquina.SelectedIndex = 0
        End If
    End Sub

    Private Sub CargarGrilla()
        cargando = True
        Try
            Dim obj As New clsSolicitud
            dgvSolicitudes.DataSource = obj.listarMisSolicitudes(modSesion.UsuarioId)
            dgvSolicitudes.ClearSelection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cargando = False
        End Try
    End Sub




    Private Sub dgvSolicitudes_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSolicitudes.CellFormatting
        If e.RowIndex < 0 OrElse dgvSolicitudes.Columns(e.ColumnIndex).Name <> "estado" Then
            Return
        End If
        ' No se puede en el Diseñador: el color del estado depende del valor de la fila.
        Dim colorTexto As Color = ColorEstado(Convert.ToString(e.Value))
        e.CellStyle.ForeColor = colorTexto
        e.CellStyle.SelectionForeColor = colorTexto
    End Sub

    Private Sub dgvSolicitudes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSolicitudes.SelectionChanged
        If cargando OrElse dgvSolicitudes.CurrentRow Is Nothing Then
            Return
        End If
        idSeleccionado = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells("id_solicitud").Value)
        Dim idMaquina As Integer = 0
        If Not IsDBNull(dgvSolicitudes.CurrentRow.Cells("id_maquinaria").Value) AndAlso dgvSolicitudes.CurrentRow.Cells("id_maquinaria").Value IsNot Nothing Then
            idMaquina = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells("id_maquinaria").Value)
        End If
        CargarMaquinas(idMaquina)
        SeleccionarItem(cbxarea, TextoCelda("area"))
        SeleccionarItem(cbxprioridad, TextoCelda("prioridad"))
        txtdescripcion.Text = TextoCelda("descripcion")
        Dim pendiente As Boolean = TextoCelda("estado") = "Pendiente"
        btnActualizar.Enabled = pendiente
        btnEliminar.Enabled = pendiente
        lblAviso.Visible = Not pendiente
        If Not pendiente Then
            lblAviso.Text = "Solo puede modificar solicitudes en estado Pendiente."
        End If
    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged
        lblContador.Text = txtdescripcion.Text.Length.ToString() & "/255"
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If idSeleccionado = 0 OrElse Not Validar() Then
            Return
        End If
        Try
            Dim obj As New clsSolicitud
            If obj.obtenerEstado(idSeleccionado) <> "Pendiente" Then
                MessageBox.Show("Solo puede modificar solicitudes en estado Pendiente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarGrilla()
                LimpiarCampos()
                Return
            End If
            obj.actualizarSolicitudOperario(idSeleccionado, txtdescripcion.Text, TextoCombo(cbxarea), TextoCombo(cbxprioridad), IdMaquina())
            MessageBox.Show("Solicitud actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarGrilla()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idSeleccionado = 0 Then
            Return
        End If
        If MessageBox.Show("¿Desea eliminar esta solicitud?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If
        Try
            Dim obj As New clsSolicitud
            If obj.obtenerEstado(idSeleccionado) <> "Pendiente" Then
                MessageBox.Show("Solo puede modificar solicitudes en estado Pendiente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarGrilla()
                LimpiarCampos()
                Return
            End If
            obj.eliminarSolicitud(idSeleccionado)
            MessageBox.Show("Solicitud eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarGrilla()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
        dgvSolicitudes.ClearSelection()
    End Sub

    Private Function Validar() As Boolean
        If IdMaquina() <= 0 Then
            MessageBox.Show("Seleccione una máquina.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If cbxarea.SelectedIndex < 0 OrElse cbxprioridad.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione el área y la prioridad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtdescripcion.Text) Then
            MessageBox.Show("Ingrese la descripción de la solicitud.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub LimpiarCampos()
        idSeleccionado = 0
        CargarMaquinas(0)
        cbxarea.SelectedIndex = -1
        cbxprioridad.SelectedIndex = -1
        txtdescripcion.Clear()
        lblContador.Text = "0/255"
        lblAviso.Visible = False
        btnActualizar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Function IdMaquina() As Integer
        If cbxmaquina.SelectedValue Is Nothing OrElse IsDBNull(cbxmaquina.SelectedValue) Then
            Return 0
        End If
        Return Convert.ToInt32(cbxmaquina.SelectedValue)
    End Function

    Private Function TextoCelda(columna As String) As String
        Dim valor As Object = dgvSolicitudes.CurrentRow.Cells(columna).Value
        If valor Is Nothing OrElse IsDBNull(valor) Then
            Return ""
        End If
        Return valor.ToString().Trim()
    End Function

    Private Function TextoCombo(cbx As ComboBox) As String
        If cbx.SelectedItem Is Nothing Then
            Return ""
        End If
        Return cbx.SelectedItem.ToString()
    End Function

    Private Sub SeleccionarItem(cbx As ComboBox, texto As String)
        Dim indice As Integer = cbx.FindStringExact(texto)
        If indice >= 0 Then
            cbx.SelectedIndex = indice
        Else
            cbx.SelectedIndex = -1
        End If
    End Sub

    Private Function ColorEstado(estado As String) As Color
        Select Case estado
            Case "Pendiente"
                Return Color.FromArgb(230, 126, 34)
            Case "En revisión"
                Return Color.FromArgb(91, 127, 177)
            Case "Aprobado"
                Return Color.FromArgb(39, 174, 96)
            Case "Rechazado"
                Return Color.FromArgb(192, 57, 43)
            Case Else
                Return Color.FromArgb(45, 52, 54)
        End Select
    End Function
End Class
