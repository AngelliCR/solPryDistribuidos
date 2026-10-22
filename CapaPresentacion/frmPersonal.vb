Imports ClaseNegocio

Public Class frmPersonal
    Private idSeleccionado As Integer
    Private cargando As Boolean
    Private listo As Boolean

    Private Sub frmPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' No se puede en el Diseñador: AutoGenerateColumns está oculta en la ventana Propiedades.
        dgvPersonal.AutoGenerateColumns = False
        cbxFiltroRol.SelectedIndex = 0
        cbxFiltroEstado.SelectedIndex = 0

        LimpiarCampos()
        CargarGrilla()
        listo = True
    End Sub

    Private Sub CargarGrilla()
        cargando = True
        Try
            Dim obj As New clsPersonal
            dgvPersonal.DataSource = obj.listarPersonalFiltrado(txtbuscar.Text, TextoCombo(cbxFiltroRol), TextoCombo(cbxFiltroEstado))
            dgvPersonal.ClearSelection()
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



    Private Sub dgvPersonal_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPersonal.SelectionChanged
        If cargando OrElse dgvPersonal.CurrentRow Is Nothing Then
            Return
        End If
        idSeleccionado = Convert.ToInt32(dgvPersonal.CurrentRow.Cells("id_personal").Value)
        txtdni.Text = TextoCelda("dni")
        txtnombres.Text = TextoCelda("nombres")
        txtapellidos.Text = TextoCelda("apellidos")
        txttelefono.Text = TextoCelda("telefono")
        txtcorreo.Text = TextoCelda("correo")
        txtcontrasena.Clear()
        SeleccionarItem(cbxtipo, TextoCelda("tipo_usuario"))
        SeleccionarItem(cbxarea, TextoCelda("area"))
        lblEstado.Text = TextoCelda("estado")
        ActualizarBotonBaja()
        btnActualizar.Enabled = True
        btnEliminar.Enabled = True
        btnBaja.Enabled = True
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If Not Validar(True) Then
            Return
        End If
        Try
            Dim obj As New clsPersonal
            If obj.validarDNI(txtdni.Text.Trim()) Then
                MessageBox.Show("El número de DNI ya se encuentra registrado.", "DNI duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtdni.Focus()
                Return
            End If
            obj.registrarPersonalAdmin(txtdni.Text, txtnombres.Text, txtapellidos.Text, txttelefono.Text, txtcorreo.Text, txtcontrasena.Text, TextoCombo(cbxtipo), TextoCombo(cbxarea), "Activo")
            MessageBox.Show("Personal registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarGrilla()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If idSeleccionado = 0 Then
            Return
        End If
        If Not Validar(False) Then
            Return
        End If
        Try
            Dim obj As New clsPersonal
            If obj.validarDNIOtro(txtdni.Text.Trim(), idSeleccionado) Then
                MessageBox.Show("El número de DNI ya se encuentra registrado.", "DNI duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtdni.Focus()
                Return
            End If
            obj.actualizarPersonal(idSeleccionado, txtdni.Text, txtnombres.Text, txtapellidos.Text, txttelefono.Text, txtcorreo.Text, txtcontrasena.Text, TextoCombo(cbxtipo), TextoCombo(cbxarea))
            MessageBox.Show("Personal actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If idSeleccionado = modSesion.UsuarioId Then
            MessageBox.Show("No puede darse de baja ni eliminarse a sí mismo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim esActivo As Boolean = lblEstado.Text = "Activo"
        Dim pregunta As String = If(esActivo, "¿Desea dar de baja a este usuario?", "¿Desea reactivar a este usuario?")
        If MessageBox.Show(pregunta, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If
        Try
            Dim obj As New clsPersonal
            If esActivo Then
                obj.darDeBajaPersonal(idSeleccionado)
                MessageBox.Show("Personal dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                obj.reactivarPersonal(idSeleccionado)
                MessageBox.Show("Personal reactivado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
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
        If idSeleccionado = modSesion.UsuarioId Then
            MessageBox.Show("No puede darse de baja ni eliminarse a sí mismo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show("¿Desea eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If
        Try
            Dim obj As New clsPersonal
            If obj.tieneRegistrosPersonal(idSeleccionado) Then
                MessageBox.Show("Este usuario tiene solicitudes o actividades registradas. Use 'Dar de baja' para desactivarlo.", "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            obj.eliminarPersonalDefinitivo(idSeleccionado)
            MessageBox.Show("Personal eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarGrilla()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
        dgvPersonal.ClearSelection()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If listo Then
            CargarGrilla()
        End If
    End Sub

    Private Sub Filtro_Changed(sender As Object, e As EventArgs) Handles cbxFiltroRol.SelectedIndexChanged, cbxFiltroEstado.SelectedIndexChanged
        If listo Then
            CargarGrilla()
        End If
    End Sub

    Private Sub SoloNumeros(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress, txttelefono.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Function Validar(esNuevo As Boolean) As Boolean
        If txtdni.Text.Trim().Length <> 8 Then
            MessageBox.Show("El DNI debe tener 8 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtdni.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtnombres.Text) OrElse String.IsNullOrWhiteSpace(txtapellidos.Text) Then
            MessageBox.Show("Los nombres y apellidos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If cbxtipo.SelectedIndex < 0 OrElse cbxarea.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione el tipo de usuario y el área.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If esNuevo AndAlso txtcontrasena.Text.Trim().Length < 4 Then
            MessageBox.Show("La contraseña es obligatoria y debe tener al menos 4 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcontrasena.Focus()
            Return False
        End If
        If Not esNuevo AndAlso txtcontrasena.Text.Trim() <> "" AndAlso txtcontrasena.Text.Trim().Length < 4 Then
            MessageBox.Show("La contraseña debe tener al menos 4 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcontrasena.Focus()
            Return False
        End If
        If Not CorreoValido(txtcorreo.Text) Then
            MessageBox.Show("Ingrese un correo electrónico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcorreo.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function CorreoValido(correo As String) As Boolean
        Dim texto As String = correo.Trim()
        If texto = "" Then
            Return True
        End If
        Dim arroba As Integer = texto.IndexOf("@"c)
        If arroba <= 0 OrElse arroba <> texto.LastIndexOf("@"c) Then
            Return False
        End If
        Dim punto As Integer = texto.IndexOf("."c, arroba)
        Return punto > arroba + 1 AndAlso punto < texto.Length - 1 AndAlso Not texto.Contains(" ")
    End Function

    Private Sub LimpiarCampos()
        idSeleccionado = 0
        txtdni.Clear()
        txtnombres.Clear()
        txtapellidos.Clear()
        txttelefono.Clear()
        txtcorreo.Clear()
        txtcontrasena.Clear()
        cbxtipo.SelectedIndex = -1
        cbxarea.SelectedIndex = -1
        lblEstado.Text = "Nuevo"
        btnActualizar.Enabled = False
        btnEliminar.Enabled = False
        btnBaja.Enabled = False
        btnBaja.Text = "Dar de baja"
        ' No se puede en el Diseñador: el color cambia según el estado del usuario.
        btnBaja.BackColor = Color.FromArgb(192, 57, 43)
        btnBaja.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 45, 35)
        btnBaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 45, 35)
    End Sub

    Private Sub ActualizarBotonBaja()
        If lblEstado.Text = "Inactivo" Then
            btnBaja.Text = "Reactivar"
            ' No se puede en el Diseñador: el color cambia según el estado del usuario.
            btnBaja.BackColor = Color.FromArgb(39, 174, 96)
            btnBaja.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 148, 82)
            btnBaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 148, 82)
        Else
            btnBaja.Text = "Dar de baja"
            ' No se puede en el Diseñador: el color cambia según el estado del usuario.
            btnBaja.BackColor = Color.FromArgb(192, 57, 43)
            btnBaja.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 45, 35)
            btnBaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 45, 35)
        End If
    End Sub

    Private Function TextoCelda(columna As String) As String
        Dim valor As Object = dgvPersonal.CurrentRow.Cells(columna).Value
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
