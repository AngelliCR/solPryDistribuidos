Imports System.Globalization

Public Class frmMenuPrincipal
    Private cerrandoSesion As Boolean
    Private botonActivo As Button
    Private ajustandoMenu As Boolean
    Private formularioAbierto As Form

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcomodarControles()
        lblUsuario.Text = modSesion.UsuarioNombre
        lblRol.Text = modSesion.UsuarioRol
        lblBienvenido.Text = "Bienvenido, " & modSesion.UsuarioNombre
        lblFecha.Text = FechaHoy()

        AplicarPermisos()
        AjustarAnchoMenu()
        MostrarInicio()
    End Sub

    ' El contenido con Dock = Fill queda en el índice 0 para que no tape la barra ni el menú.
    Private Sub AcomodarControles()
        Me.Controls.SetChildIndex(pnlContenido, 0)
        Me.Controls.SetChildIndex(pnlLineaLateral, 1)
        Me.Controls.SetChildIndex(pnlLateral, 2)
        Me.Controls.SetChildIndex(pnlSuperior, 3)

        pnlLateral.Controls.SetChildIndex(flpMenu, 0)
        pnlLateral.Controls.SetChildIndex(btnCerrarSesion, 1)

        pnlContenido.Controls.SetChildIndex(pnlModulo, 0)
        pnlContenido.Controls.SetChildIndex(flpAccesos, 1)
        pnlContenido.Controls.SetChildIndex(lblFecha, 2)
        pnlContenido.Controls.SetChildIndex(lblBienvenido, 3)

        Dim menu() As Control = {btnInicio, btnUsuarios, btnSolicitudes, btnTarea, btnMaquinaria, btnMantenimiento, btnActividad, btnRegistrarSolicitud, btnMisSolicitudes, btnFacturacion}
        Dim tarjetas() As Control = {pnlCardUsuarios, pnlCardSolicitudes, pnlCardTarea, pnlCardMaquinaria, pnlCardMantenimiento, pnlCardActividad, pnlCardRegistrarSolicitud, pnlCardMisSolicitudes, pnlCardFacturacion}
        Dim i As Integer
        For i = 0 To menu.Length - 1
            flpMenu.Controls.SetChildIndex(menu(i), i)
        Next
        For i = 0 To tarjetas.Length - 1
            flpAccesos.Controls.SetChildIndex(tarjetas(i), i)
        Next
    End Sub

    Private Sub AjustarAnchoMenu()
        If ajustandoMenu OrElse flpMenu Is Nothing Then
            Return
        End If
        Dim ancho As Integer = flpMenu.ClientSize.Width
        If ancho < 1 Then
            Return
        End If
        ajustandoMenu = True
        Try
            For Each ctrl As Control In flpMenu.Controls
                If ctrl.Width <> ancho Then
                    ctrl.Width = ancho
                End If
            Next
        Finally
            ajustandoMenu = False
        End Try
    End Sub

    Private Sub flpMenu_Resize(sender As Object, e As EventArgs) Handles flpMenu.Resize
        AjustarAnchoMenu()
    End Sub

    Private Function FechaHoy() As String
        Dim cultura As New CultureInfo("es-PE")
        Dim texto As String = DateTime.Now.ToString("dddd, d 'de' MMMM 'de' yyyy", cultura)
        If texto.Length > 0 Then
            texto = Char.ToUpper(texto(0), cultura) & texto.Substring(1)
        End If
        Return texto
    End Function

    Private Sub AplicarPermisos()
        Dim rol As String = ""
        If modSesion.UsuarioRol IsNot Nothing Then
            rol = modSesion.UsuarioRol.Trim()
        End If

        Dim esAdmin As Boolean = (rol = "Administrador")
        Dim esSupervisor As Boolean = (rol = "Supervisor")
        Dim esOperario As Boolean = (rol = "Operario")

        btnInicio.Visible = True
        EstablecerOpcion(btnUsuarios, pnlCardUsuarios, esAdmin)
        EstablecerOpcion(btnSolicitudes, pnlCardSolicitudes, esAdmin OrElse esSupervisor)
        EstablecerOpcion(btnTarea, pnlCardTarea, esAdmin OrElse esSupervisor)
        EstablecerOpcion(btnMaquinaria, pnlCardMaquinaria, esAdmin OrElse esSupervisor)
        EstablecerOpcion(btnMantenimiento, pnlCardMantenimiento, esAdmin OrElse esSupervisor)
        EstablecerOpcion(btnActividad, pnlCardActividad, esAdmin OrElse esSupervisor OrElse esOperario)
        EstablecerOpcion(btnRegistrarSolicitud, pnlCardRegistrarSolicitud, esOperario)
        EstablecerOpcion(btnMisSolicitudes, pnlCardMisSolicitudes, esOperario)
        EstablecerOpcion(btnFacturacion, pnlCardFacturacion, esAdmin)
    End Sub

    Private Sub EstablecerOpcion(boton As Button, tarjeta As Panel, visible As Boolean)
        boton.Visible = visible
        tarjeta.Visible = visible
    End Sub

    Private Sub MostrarInicio()
        CerrarFormularioAbierto()
        pnlModulo.Visible = False
        MarcarActivo(btnInicio)
        lblBienvenido.Visible = True
        lblFecha.Visible = True
        flpAccesos.Visible = True
    End Sub

    Private Sub AbrirFormulario(frm As Form, boton As Button)
        MarcarActivo(boton)
        CerrarFormularioAbierto()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        lblBienvenido.Visible = False
        lblFecha.Visible = False
        flpAccesos.Visible = False
        pnlModulo.Visible = True
        pnlModulo.Controls.Add(frm)
        formularioAbierto = frm
        frm.Show()
    End Sub

    Private Sub CerrarFormularioAbierto()
        If formularioAbierto Is Nothing Then
            Return
        End If
        pnlModulo.Controls.Remove(formularioAbierto)
        formularioAbierto.Dispose()
        formularioAbierto = Nothing
    End Sub

    Private Sub AbrirSegunBoton(boton As Button)
        Select Case boton.Name
            Case "btnUsuarios"
                AbrirFormulario(New frmPersonal(), boton)
            Case "btnMaquinaria"
                AbrirFormulario(New frmMaquinaria(), boton)
            Case "btnRegistrarSolicitud"
                AbrirFormulario(New frmRegistrarSolicitud(), boton)
            Case "btnMisSolicitudes"
                AbrirFormulario(New frmMisSolicitudes(), boton)
            Case "btnSolicitudes"
                AbrirFormulario(New frmGestionSolicitudes(), boton)
            Case Else
                AbrirModulo(boton.Text, boton)
        End Select
    End Sub

    Private Sub MarcarActivo(boton As Button)
        If botonActivo IsNot Nothing Then
            botonActivo.BackColor = Color.White
            botonActivo.ForeColor = Color.FromArgb(45, 52, 54)
        End If

        boton.BackColor = Color.FromArgb(238, 243, 251)
        boton.ForeColor = Color.FromArgb(91, 127, 177)
        botonActivo = boton
    End Sub

    Private Sub AbrirModulo(nombre As String, boton As Button)
        MarcarActivo(boton)
        MessageBox.Show("El módulo '" & nombre & "' estará disponible próximamente.", "Módulo en construcción", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        MostrarInicio()
    End Sub

    Private Sub OpcionMenu_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click, btnSolicitudes.Click, btnTarea.Click, btnMaquinaria.Click, btnMantenimiento.Click, btnActividad.Click, btnRegistrarSolicitud.Click, btnMisSolicitudes.Click, btnFacturacion.Click
        Dim boton As Button = DirectCast(sender, Button)
        AbrirSegunBoton(boton)
    End Sub

    Private Sub Tarjeta_Click(sender As Object, e As EventArgs) Handles pnlCardUsuarios.Click, lblCardUsuarios.Click, lblDescUsuarios.Click, pnlCardSolicitudes.Click, lblCardSolicitudes.Click, lblDescSolicitudes.Click, pnlCardTarea.Click, lblCardTarea.Click, lblDescTarea.Click, pnlCardMaquinaria.Click, lblCardMaquinaria.Click, lblDescMaquinaria.Click, pnlCardMantenimiento.Click, lblCardMantenimiento.Click, lblDescMantenimiento.Click, pnlCardActividad.Click, lblCardActividad.Click, lblDescActividad.Click, pnlCardRegistrarSolicitud.Click, lblCardRegistrarSolicitud.Click, lblDescRegistrarSolicitud.Click, pnlCardMisSolicitudes.Click, lblCardMisSolicitudes.Click, lblDescMisSolicitudes.Click, pnlCardFacturacion.Click, lblCardFacturacion.Click, lblDescFacturacion.Click
        Dim boton As Button = BotonDeTarjeta(DirectCast(sender, Control))
        If boton IsNot Nothing Then
            AbrirSegunBoton(boton)
        End If
    End Sub

    Private Function BotonDeTarjeta(ctrl As Control) As Button
        Dim tarjeta As Control = ctrl
        If Not tarjeta.Name.StartsWith("pnlCard") AndAlso tarjeta.Parent IsNot Nothing Then
            tarjeta = tarjeta.Parent
        End If

        Select Case tarjeta.Name
            Case "pnlCardUsuarios"
                Return btnUsuarios
            Case "pnlCardSolicitudes"
                Return btnSolicitudes
            Case "pnlCardTarea"
                Return btnTarea
            Case "pnlCardMaquinaria"
                Return btnMaquinaria
            Case "pnlCardMantenimiento"
                Return btnMantenimiento
            Case "pnlCardActividad"
                Return btnActividad
            Case "pnlCardRegistrarSolicitud"
                Return btnRegistrarSolicitud
            Case "pnlCardMisSolicitudes"
                Return btnMisSolicitudes
            Case "pnlCardFacturacion"
                Return btnFacturacion
            Case Else
                Return Nothing
        End Select
    End Function

    Private Sub PintarBordeTarjeta(sender As Object, e As PaintEventArgs) Handles pnlCardUsuarios.Paint, pnlCardSolicitudes.Paint, pnlCardTarea.Paint, pnlCardMaquinaria.Paint, pnlCardMantenimiento.Paint, pnlCardActividad.Paint, pnlCardRegistrarSolicitud.Paint, pnlCardMisSolicitudes.Paint, pnlCardFacturacion.Paint
        Dim pnl As Panel = DirectCast(sender, Panel)
        Dim rect As New Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1)
        Using lapiz As New Pen(Color.FromArgb(220, 221, 225))
            e.Graphics.DrawRectangle(lapiz, rect)
        End Using
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta <> DialogResult.Yes Then
            Return
        End If

        cerrandoSesion = True
        modSesion.CerrarSesion()

        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is frmLogin Then
                frm.Show()
                frm.Activate()
                Exit For
            End If
        Next

        Me.Close()
    End Sub

    Private Sub frmMenuPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Not cerrandoSesion Then
            Application.Exit()
        End If
    End Sub
End Class
