Imports ClaseNegocio

Public Class frmregistrar
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxtipo.SelectedIndexChanged

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        ' 1. Validar que los campos obligatorios no estén vacíos
        If String.IsNullOrWhiteSpace(txtnumdni.Text) OrElse
       String.IsNullOrWhiteSpace(txtnombre.Text) OrElse
       String.IsNullOrWhiteSpace(txtapellido.Text) OrElse
       String.IsNullOrWhiteSpace(txtcontrasena.Text) OrElse
       String.IsNullOrWhiteSpace(txtconfirmar.Text) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Validar que las contraseñas coincidan
        If txtcontrasena.Text <> txtconfirmar.Text Then
            MessageBox.Show("Las contraseñas no coinciden. Por favor, verifíquelas.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcontrasena.Clear()
            txtconfirmar.Clear()
            txtcontrasena.Focus()
            Return
        End If

        Try
            ' 3. Instanciar la clase clsPersonal
            Dim objPersonal As New clsPersonal

            ' 4. Validar si el DNI ya existe registrado
            If objPersonal.validarDNI(txtnumdni.Text.Trim()) Then
                MessageBox.Show("El número de DNI ingresado ya se encuentra registrado en el sistema.", "DNI Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtnumdni.Focus()
                Return
            End If

            ' 5. Obtener valores de los ComboBox y estado (Ya no necesitamos generar ID manual)
            Dim tipoUsuario As String = If(cbxtipo.SelectedItem IsNot Nothing, cbxtipo.SelectedItem.ToString(), "Usuario")
            Dim area As String = If(cbxarea.SelectedItem IsNot Nothing, cbxarea.SelectedItem.ToString(), "General")
            Dim estado As String = "Activo"

            ' 6. Ejecutar el registro (enviando solo los 9 datos que la tabla espera)
            objPersonal.registrarPersonal(
            txtnumdni.Text.Trim(),
            txtnombre.Text.Trim(),
            txtapellido.Text.Trim(),
            txttelefono.Text.Trim(),
            txtcorreo.Text.Trim(),
            txtcontrasena.Text.Trim(),
            tipoUsuario,
            area,
            estado
        )

            MessageBox.Show("¡Cuenta creada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Opcional: Regresar al login o limpiar formulario
            ' Dim frmLog As New frmLogin()
            ' frmLog.Show()
            ' Me.Close()

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al registrar: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class