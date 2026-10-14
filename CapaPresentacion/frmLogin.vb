Imports ClaseNegocio

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdni.AutoSize = False
        txtcontrasena.AutoSize = False
        txtdni.Height = 32
        txtcontrasena.Height = 32
        flpRegistro.Controls.SetChildIndex(lblNuevo, 0)
        flpRegistro.Controls.SetChildIndex(lnkRegistro, 1)
        CentrarTarjeta()
        CentrarMarca()
        txtdni.Focus()
    End Sub

    Private Sub CentrarTarjeta()
        Dim x As Integer = pnlMarca.Width + (Me.ClientSize.Width - pnlMarca.Width - pnlTarjeta.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - pnlTarjeta.Height) \ 2
        pnlTarjeta.Location = New Point(x, y)
    End Sub

    Private Sub CentrarMarca()
        Dim altoBloque As Integer = lblPomalca.Height + 12 + lblSistema.Height
        Dim y As Integer = (pnlMarca.ClientSize.Height - lblCopyright.Height - altoBloque) \ 2
        If y < 24 Then
            y = 24
        End If
        lblPomalca.Location = New Point(40, y)
        lblSistema.Location = New Point(40, y + lblPomalca.Height + 12)
    End Sub

    Private Sub pnlTarjeta_Paint(sender As Object, e As PaintEventArgs) Handles pnlTarjeta.Paint
        Dim rect As New Rectangle(0, 0, pnlTarjeta.Width - 1, pnlTarjeta.Height - 1)
        Using lapiz As New Pen(Color.FromArgb(220, 221, 225))
            e.Graphics.DrawRectangle(lapiz, rect)
        End Using
    End Sub

    Private Sub txtdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub chkMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrar.CheckedChanged
        txtcontrasena.UseSystemPasswordChar = Not chkMostrar.Checked
    End Sub

    Private Sub btninicio_Click(sender As Object, e As EventArgs) Handles btninicio.Click
        If String.IsNullOrWhiteSpace(txtdni.Text) OrElse String.IsNullOrWhiteSpace(txtcontrasena.Text) Then
            MessageBox.Show("Por favor, ingrese su DNI y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        Me.UseWaitCursor = True
        btninicio.Enabled = False
        Try
            Dim objPersonal As New clsPersonal
            Dim fila As DataRow = objPersonal.obtenerUsuarioLogin(txtdni.Text.Trim(), txtcontrasena.Text.Trim())

            If fila IsNot Nothing Then
                modSesion.UsuarioId = Convert.ToInt32(fila("id_personal"))
                modSesion.UsuarioDni = fila("dni").ToString().Trim()
                modSesion.UsuarioNombre = (fila("nombres").ToString().Trim() & " " & fila("apellidos").ToString().Trim()).Trim()
                modSesion.UsuarioRol = fila("tipo_usuario").ToString().Trim()
                modSesion.UsuarioArea = fila("area").ToString().Trim()

                txtdni.Clear()
                txtcontrasena.Clear()
                chkMostrar.Checked = False

                Dim frmMenu As New frmMenuPrincipal()
                frmMenu.Show()
                Me.Hide()
            Else
                MessageBox.Show("DNI o contraseña incorrectos, o el usuario se encuentra inactivo.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcontrasena.Clear()
                txtdni.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.UseWaitCursor = False
            Me.Cursor = Cursors.Default
            btninicio.Enabled = True
        End Try
    End Sub

    Private Sub lnkRegistro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegistro.LinkClicked
        Dim frmReg As New frmregistrar()
        frmReg.Show()
        Me.Hide()
    End Sub
End Class
