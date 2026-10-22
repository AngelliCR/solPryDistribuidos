Imports ClaseNegocio

Public Class frmGestionSolicitudes
    Private idSeleccionado As Integer
    Private cargando As Boolean
    Private listo As Boolean

    Private Sub frmGestionSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' No se puede en el Diseñador: AutoGenerateColumns está oculta en la ventana Propiedades.
        dgvGestion.AutoGenerateColumns = False
        cbxFiltroEstado.SelectedIndex = 0
        cbxFiltroArea.SelectedIndex = 0
        cbxFiltroPrioridad.SelectedIndex = 0
        LimpiarRevision()
        CargarGrilla()
        listo = True
    End Sub


    Private Sub CargarGrilla()
        cargando = True
        Try
            Dim obj As New clsSolicitud
            dgvGestion.DataSource = obj.listarSolicitudes(TextoCombo(cbxFiltroEstado), TextoCombo(cbxFiltroArea), TextoCombo(cbxFiltroPrioridad))
            dgvGestion.ClearSelection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cargando = False
        End Try
        idSeleccionado = 0
        btnGuardar.Enabled = False
    End Sub




    Private Sub dgvGestion_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvGestion.CellFormatting
        If e.RowIndex < 0 OrElse dgvGestion.Columns(e.ColumnIndex).Name <> "estado" Then
            Return
        End If
        ' No se puede en el Diseñador: el color del estado depende del valor de la fila.
        Dim colorTexto As Color = ColorEstado(Convert.ToString(e.Value))
        e.CellStyle.ForeColor = colorTexto
        e.CellStyle.SelectionForeColor = colorTexto
    End Sub

    Private Sub dgvGestion_SelectionChanged(sender As Object, e As EventArgs) Handles dgvGestion.SelectionChanged
        If cargando OrElse dgvGestion.CurrentRow Is Nothing Then
            Return
        End If
        idSeleccionado = Convert.ToInt32(dgvGestion.CurrentRow.Cells("id_solicitud").Value)
        txtdescripcion.Text = TextoCelda("descripcion")
        txtcomentario.Text = TextoCelda("comentario")
        SeleccionarItem(cbxNuevoEstado, TextoCelda("estado"))
        btnGuardar.Enabled = True
    End Sub

    Private Sub Filtro_Changed(sender As Object, e As EventArgs) Handles cbxFiltroEstado.SelectedIndexChanged, cbxFiltroArea.SelectedIndexChanged, cbxFiltroPrioridad.SelectedIndexChanged
        If listo Then
            CargarGrilla()
            LimpiarRevision()
        End If
    End Sub

    Private Sub btnLimpiarFiltros_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltros.Click
        listo = False
        cbxFiltroEstado.SelectedIndex = 0
        cbxFiltroArea.SelectedIndex = 0
        cbxFiltroPrioridad.SelectedIndex = 0
        listo = True
        CargarGrilla()
        LimpiarRevision()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If idSeleccionado = 0 Then
            Return
        End If
        If cbxNuevoEstado.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione el nuevo estado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If TextoCombo(cbxNuevoEstado) = "Rechazado" AndAlso String.IsNullOrWhiteSpace(txtcomentario.Text) Then
            MessageBox.Show("El comentario es obligatorio cuando el estado es Rechazado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcomentario.Focus()
            Return
        End If
        Try
            Dim obj As New clsSolicitud
            obj.cambiarEstadoSolicitud(idSeleccionado, TextoCombo(cbxNuevoEstado), txtcomentario.Text)
            MessageBox.Show("Estado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarGrilla()
            LimpiarRevision()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarRevision()
        idSeleccionado = 0
        txtdescripcion.Clear()
        txtcomentario.Clear()
        cbxNuevoEstado.SelectedIndex = -1
        btnGuardar.Enabled = False
    End Sub

    Private Function TextoCelda(columna As String) As String
        Dim valor As Object = dgvGestion.CurrentRow.Cells(columna).Value
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
