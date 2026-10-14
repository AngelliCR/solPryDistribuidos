Imports ClaseNegocio

Public Class frmRegistrarTarea
    Private Sub frmRegistrarTarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstilizarBotonPrimario(btnRegistrar)
        EstilizarBotonSecundario(btnLimpiar)
        cbxarea.Items.AddRange(modListas.Areas)
        cbxprioridad.Items.AddRange(modListas.Prioridades)
        Dim indiceArea As Integer = cbxarea.FindStringExact(If(modSesion.UsuarioArea, ""))
        If indiceArea >= 0 Then
            cbxarea.SelectedIndex = indiceArea
        End If
        lblContador.Text = "0/255"
    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged
        lblContador.Text = txtdescripcion.Text.Length.ToString() & "/255"
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If Not Validar() Then
            Return
        End If
        Try
            Dim obj As New clsSolicitud
            obj.registrarTarea(modSesion.UsuarioId, txtdescripcion.Text, TextoCombo(cbxarea), TextoCombo(cbxprioridad))
            MessageBox.Show("Tarea registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Function Validar() As Boolean
        If cbxarea.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione el área.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If cbxprioridad.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione la prioridad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtdescripcion.Text) Then
            MessageBox.Show("Ingrese la descripción de la tarea.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtdescripcion.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub LimpiarCampos()
        cbxprioridad.SelectedIndex = -1
        txtdescripcion.Clear()
        Dim indiceArea As Integer = cbxarea.FindStringExact(If(modSesion.UsuarioArea, ""))
        If indiceArea >= 0 Then
            cbxarea.SelectedIndex = indiceArea
        Else
            cbxarea.SelectedIndex = -1
        End If
        lblContador.Text = "0/255"
    End Sub

    Private Function TextoCombo(cbx As ComboBox) As String
        If cbx.SelectedItem Is Nothing Then
            Return ""
        End If
        Return cbx.SelectedItem.ToString()
    End Function
End Class
