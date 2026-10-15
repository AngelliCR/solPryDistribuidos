Imports ClaseNegocio

Public Class frmregistrar
    Private Sub frmregistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnumdni.AutoSize = False
        txttelefono.AutoSize = False
        txtnombre.AutoSize = False
        txtapellido.AutoSize = False
        txtcorreo.AutoSize = False
        txtcontrasena.AutoSize = False
        txtconfirmar.AutoSize = False
        txtnumdni.Height = 30
        txttelefono.Height = 30
        txtnombre.Height = 30
        txtapellido.Height = 30
        txtcorreo.Height = 30
        txtcontrasena.Height = 30
        txtconfirmar.Height = 30
        flpIniciarSesion.Controls.SetChildIndex(lblYaTiene, 0)
        flpIniciarSesion.Controls.SetChildIndex(lnkIniciarSesion, 1)
        CentrarTarjeta()
        CentrarMarca()
        flpIniciarSesion.Left = (pnlTarjeta.ClientSize.Width - flpIniciarSesion.Width) \ 2
        txtnumdni.Focus()
        Me.AcceptButton = btnregistrar
    End Sub

    Private Sub CentrarTarjeta()
        Dim x As Integer = pnlMarca.Width + (Me.ClientSize.Width - pnlMarca.Width - pnlTarjeta.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - pnlTarjeta.Height) \ 2
        pnlTarjeta.Location = New Point(x, y)
    End Sub

    ' Logo y texto centrados en el panel azul (el texto queda debajo del logo).
    Private Sub CentrarMarca()
        Dim ancho As Integer = pnlMarca.ClientSize.Width
        Dim altoDisponible As Integer = pnlMarca.ClientSize.Height - lblCopyright.Height
        Dim altoBloque As Integer = picLogo.Height + 8 + lblSistema.Height
        Dim y As Integer = (altoDisponible - altoBloque) \ 2
        If y < 16 Then
            y = 16
        End If
        picLogo.Location = New Point((ancho - picLogo.Width) \ 2, y)
        lblSistema.Location = New Point((ancho - lblSistema.Width) \ 2, y + picLogo.Height + 8)
    End Sub

    Private Sub pnlTarjeta_Paint(sender As Object, e As PaintEventArgs) Handles pnlTarjeta.Paint
        Dim rect As New Rectangle(0, 0, pnlTarjeta.Width - 1, pnlTarjeta.Height - 1)
        Using lapiz As New Pen(Color.FromArgb(220, 221, 225))
            e.Graphics.DrawRectangle(lapiz, rect)
        End Using
    End Sub

    Private Sub SoloDigitos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumdni.KeyPress, txttelefono.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub chkMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrar.CheckedChanged
        txtcontrasena.UseSystemPasswordChar = Not chkMostrar.Checked
        txtconfirmar.UseSystemPasswordChar = Not chkMostrar.Checked
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

            ' Volver al login para que inicie sesión con su nueva cuenta
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al registrar: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Click en "Iniciar sesión": cerrar el registro (FormClosed vuelve a mostrar el login).
    Private Sub lnkIniciarSesion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkIniciarSesion.LinkClicked
        Me.Close()
    End Sub

    ' Al cerrar el registro (por el enlace, tras registrarse o con la X) se vuelve a mostrar el login
    ' que quedó oculto. Si no existiera, se crea uno nuevo.
    Private Sub frmregistrar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is frmLogin Then
                frm.Show()
                frm.Activate()
                Return
            End If
        Next
        Dim nuevoLogin As New frmLogin()
        nuevoLogin.Show()
    End Sub
End Class
