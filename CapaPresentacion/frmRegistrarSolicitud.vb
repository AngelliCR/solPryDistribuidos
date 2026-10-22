Imports ClaseNegocio

Public Class frmRegistrarSolicitud
    Private Sub frmRegistrarSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMaquinas()
        Dim indiceArea As Integer = cbxarea.FindStringExact(If(modSesion.UsuarioArea, ""))
        If indiceArea >= 0 Then
            cbxarea.SelectedIndex = indiceArea
        End If
        lblContador.Text = "0/255"
    End Sub

    Private Sub CargarMaquinas()
        Try
            Dim obj As New clsMaquinaria
            Dim tabla As DataTable = obj.listarMaquinariaDisponible()
            Dim fila As DataRow = tabla.NewRow()
            fila("id_maquinaria") = 0
            fila("maquina") = "Seleccione una máquina"
            tabla.Rows.InsertAt(fila, 0)
            cbxmaquina.DataSource = tabla
            cbxmaquina.DisplayMember = "maquina"
            cbxmaquina.ValueMember = "id_maquinaria"
            cbxmaquina.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            obj.registrarSolicitud(modSesion.UsuarioId, txtdescripcion.Text, TextoCombo(cbxarea), TextoCombo(cbxprioridad), IdMaquina())
            MessageBox.Show("Solicitud registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Function Validar() As Boolean
        If IdMaquina() <= 0 Then
            MessageBox.Show("Seleccione una máquina.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If cbxarea.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione el área.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If cbxprioridad.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione la prioridad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtdescripcion.Text) Then
            MessageBox.Show("Ingrese la descripción de la solicitud.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtdescripcion.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub LimpiarCampos()
        If cbxmaquina.Items.Count > 0 Then
            cbxmaquina.SelectedIndex = 0
        End If
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

    Private Function IdMaquina() As Integer
        If cbxmaquina.SelectedValue Is Nothing OrElse IsDBNull(cbxmaquina.SelectedValue) Then
            Return 0
        End If
        Return Convert.ToInt32(cbxmaquina.SelectedValue)
    End Function

    Private Function TextoCombo(cbx As ComboBox) As String
        If cbx.SelectedItem Is Nothing Then
            Return ""
        End If
        Return cbx.SelectedItem.ToString()
    End Function
End Class
