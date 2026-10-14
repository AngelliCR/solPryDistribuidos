Imports CapaNegocio
Imports ClaseNegocio

Public Class frmLogin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtdni.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btninicio_Click(sender As Object, e As EventArgs) Handles btninicio.Click
        If String.IsNullOrWhiteSpace(txtdni.Text) OrElse String.IsNullOrWhiteSpace(txtdni.Text) Then
            MessageBox.Show("Por favor, ingrese su DNI y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' 2. Instanciar la clase clsPersonal
            Dim objPersonal As New clsPersonal

            ' 3. Llamar al método iniciarSesion pasando los datos de los TextBox
            Dim respuesta As Boolean = objPersonal.iniciarSesion(txtdni.Text.Trim(), txtcontrasena.Text.Trim())

            ' 4. Evaluar el resultado
            If respuesta Then
                MessageBox.Show("¡Bienvenido al Portal de Personal!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Aquí puedes abrir tu siguiente formulario (ej. el menú principal)
                ' Dim frmMenu As New frmMenuPrincipal()
                ' frmMenu.Show()
                ' Me.Hide() ' Oculta el formulario de login actual
            Else
                MessageBox.Show("DNI o contraseña incorrectos, o el usuario se encuentra inactivo.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcontrasena.Clear()
                txtdni.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim frmReg As New frmregistrar()


        frmReg.Show()


        Me.Hide()
    End Sub
End Class
