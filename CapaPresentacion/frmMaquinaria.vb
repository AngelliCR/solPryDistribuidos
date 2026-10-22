Imports ClaseNegocio

Public Class frmMaquinaria
    Private idSeleccionado As Integer
    Private cargando As Boolean
    Private listo As Boolean

    Private Sub frmMaquinaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' No se puede en el Diseñador: AutoGenerateColumns está oculta en la ventana Propiedades.
        dgvMaquinaria.AutoGenerateColumns = False
        cbxFiltroEstado.SelectedIndex = 0
        cbxFiltroArea.SelectedIndex = 0

        LimpiarCampos()
        CargarGrilla()
        listo = True
    End Sub

    Private Sub CargarGrilla()
        cargando = True
        Try
            Dim obj As New clsMaquinaria
            dgvMaquinaria.DataSource = obj.listarMaquinaria(txtbuscar.Text, TextoCombo(cbxFiltroEstado), TextoCombo(cbxFiltroArea))
            dgvMaquinaria.ClearSelection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cargando = False
        End Try
        idSeleccionado = 0
        btnActualizar.Enabled = False
        btnEliminar.Enabled = False
        btnBaja.Enabled = False
    End Sub



    Private Sub dgvMaquinaria_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvMaquinaria.CellFormatting
        If e.RowIndex < 0 OrElse dgvMaquinaria.Columns(e.ColumnIndex).Name <> "estado" Then
            Return
        End If
        ' No se puede en el Diseñador: el color del estado depende del valor de la fila.
        Dim colorTexto As Color = ColorEstado(Convert.ToString(e.Value))
        e.CellStyle.ForeColor = colorTexto
        e.CellStyle.SelectionForeColor = colorTexto
    End Sub

    Private Function ColorEstado(estado As String) As Color
        Select Case estado
            Case "Operativo"
                Return Color.FromArgb(39, 174, 96)
            Case "En Mantenimiento"
                Return Color.FromArgb(230, 126, 34)
            Case "Dado de Baja"
                Return Color.FromArgb(192, 57, 43)
            Case Else
                Return Color.FromArgb(138, 153, 170)
        End Select
    End Function

    Private Sub dgvMaquinaria_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMaquinaria.SelectionChanged
        If cargando OrElse dgvMaquinaria.CurrentRow Is Nothing Then
            Return
        End If
        idSeleccionado = Convert.ToInt32(dgvMaquinaria.CurrentRow.Cells("id_maquinaria").Value)
        txtcodigo.Text = TextoCelda("nombre_codigo")
        txttipo.Text = TextoCelda("tipo")
        txtmarca.Text = TextoCelda("marca")
        txtmodelo.Text = TextoCelda("modelo")
        txtobservaciones.Text = TextoCelda("observaciones")
        SeleccionarItem(cbxarea, TextoCelda("area"))
        SeleccionarItem(cbxestado, TextoCelda("estado"))
        Dim dadoDeBaja As Boolean = TextoCelda("estado") = "Dado de Baja"
        btnActualizar.Enabled = True
        btnEliminar.Enabled = Not dadoDeBaja
        btnBaja.Enabled = Not dadoDeBaja
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If Not Validar() Then
            Return
        End If
        Try
            Dim obj As New clsMaquinaria
            If obj.validarCodigo(txtcodigo.Text.Trim().ToUpper(), 0) Then
                MessageBox.Show("El código de maquinaria ya está registrado.", "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtcodigo.Focus()
                Return
            End If
            obj.registrarMaquinaria(txtcodigo.Text, txttipo.Text, txtmarca.Text, txtmodelo.Text, TextoCombo(cbxarea), TextoCombo(cbxestado), txtobservaciones.Text)
            MessageBox.Show("Maquinaria registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarGrilla()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If idSeleccionado = 0 OrElse Not Validar() Then
            Return
        End If
        Try
            Dim obj As New clsMaquinaria
            If obj.validarCodigo(txtcodigo.Text.Trim().ToUpper(), idSeleccionado) Then
                MessageBox.Show("El código de maquinaria ya está registrado.", "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtcodigo.Focus()
                Return
            End If
            obj.actualizarMaquinaria(idSeleccionado, txtcodigo.Text, txttipo.Text, txtmarca.Text, txtmodelo.Text, TextoCombo(cbxarea), TextoCombo(cbxestado), txtobservaciones.Text)
            MessageBox.Show("Maquinaria actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarGrilla()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        If idSeleccionado = 0 Then
            Return
        End If
        If TextoCombo(cbxestado) = "Dado de Baja" Then
            Return
        End If
        If MessageBox.Show("¿Desea dar de baja esta máquina?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If
        Try
            Dim obj As New clsMaquinaria
            obj.darDeBajaMaquinaria(idSeleccionado)
            MessageBox.Show("Maquinaria dada de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If TextoCombo(cbxestado) = "Dado de Baja" Then
            MessageBox.Show("Una máquina dada de baja no se puede eliminar. Se conserva para el historial.", "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show("¿Desea eliminar esta máquina?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If
        Try
            Dim obj As New clsMaquinaria
            If obj.tieneRegistrosMaquinaria(idSeleccionado) Then
                MessageBox.Show("Esta máquina tiene actividades o solicitudes registradas. Use 'Dar de baja' para conservarla en el historial.", "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            obj.eliminarMaquinaria(idSeleccionado)
            MessageBox.Show("Maquinaria eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarGrilla()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
        dgvMaquinaria.ClearSelection()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If listo Then
            CargarGrilla()
        End If
    End Sub

    Private Sub Filtro_Changed(sender As Object, e As EventArgs) Handles cbxFiltroEstado.SelectedIndexChanged, cbxFiltroArea.SelectedIndexChanged
        If listo Then
            CargarGrilla()
        End If
    End Sub

    Private Function Validar() As Boolean
        If String.IsNullOrWhiteSpace(txtcodigo.Text) OrElse String.IsNullOrWhiteSpace(txttipo.Text) Then
            MessageBox.Show("El código y el tipo son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If cbxarea.SelectedIndex < 0 OrElse cbxestado.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione el área y el estado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub LimpiarCampos()
        idSeleccionado = 0
        txtcodigo.Clear()
        txttipo.Clear()
        txtmarca.Clear()
        txtmodelo.Clear()
        txtobservaciones.Clear()
        cbxarea.SelectedIndex = -1
        cbxestado.SelectedIndex = -1
        btnActualizar.Enabled = False
        btnEliminar.Enabled = False
        btnBaja.Enabled = False
    End Sub

    Private Function TextoCelda(columna As String) As String
        Dim valor As Object = dgvMaquinaria.CurrentRow.Cells(columna).Value
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
End Class
