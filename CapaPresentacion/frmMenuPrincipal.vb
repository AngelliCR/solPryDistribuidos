Imports System.Globalization

Public Class frmMenuPrincipal
    Private cerrandoSesion As Boolean
    Private opcionActiva As ToolStripMenuItem
    Private formularioAbierto As Form

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' No se puede en el Diseñador: no existe una propiedad para un pintor propio del menú ni de los submenús.
        mnuPrincipal.Renderer = New clsRenderMenu()
        PrepararSubmenu(mnuSolicitudes)
        PrepararSubmenu(mnuUsuarioSesion)

        mnuUsuarioSesion.Text = modSesion.UsuarioNombre & " · " & modSesion.UsuarioRol
        lblBienvenido.Text = "Bienvenido, " & modSesion.UsuarioNombre
        lblFecha.Text = FechaHoy()

        AplicarPermisos()
        MostrarInicio()
    End Sub

    Private Sub PrepararSubmenu(item As ToolStripMenuItem)
        Dim menu As ToolStripDropDownMenu = TryCast(item.DropDown, ToolStripDropDownMenu)
        If menu Is Nothing Then
            Return
        End If
        menu.ShowImageMargin = False
        menu.ShowCheckMargin = False
        menu.BackColor = Color.White
        menu.Renderer = mnuPrincipal.Renderer
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

        ' No se puede en el Diseñador: los menús se muestran u ocultan según el rol.
        mnuInicio.Visible = True
        mnuUsuarios.Visible = esAdmin
        mnuMaquinaria.Visible = esAdmin OrElse esSupervisor
        mnuGestionSolicitudes.Visible = esAdmin OrElse esSupervisor
        mnuRegistrarSolicitud.Visible = esOperario
        mnuMisSolicitudes.Visible = esOperario
        mnuActividad.Visible = esAdmin OrElse esSupervisor OrElse esOperario
        mnuSolicitudes.Visible = esAdmin OrElse esSupervisor OrElse esOperario
    End Sub

    Private Sub MostrarInicio()
        CerrarFormularioAbierto()
        pnlModulo.Visible = False
        MarcarActivo(mnuInicio)
        ' No se puede en el Diseñador: la bienvenida se muestra u oculta según si hay un módulo abierto.
        pnlBienvenida.Visible = True
    End Sub

    Private Sub AbrirFormulario(frm As Form, opcion As ToolStripMenuItem)
        MarcarActivo(opcion)
        CerrarFormularioAbierto()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        ' No se puede en el Diseñador: la bienvenida se muestra u oculta según si hay un módulo abierto.
        pnlBienvenida.Visible = False
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

    Private Sub AbrirSegunOpcion(item As ToolStripMenuItem)
        Select Case item.Name
            Case "mnuUsuarios"
                AbrirFormulario(New frmPersonal(), item)
            Case "mnuMaquinaria"
                AbrirFormulario(New frmMaquinaria(), item)
            Case "mnuRegistrarSolicitud"
                AbrirFormulario(New frmRegistrarSolicitud(), item)
            Case "mnuMisSolicitudes"
                AbrirFormulario(New frmMisSolicitudes(), item)
            Case "mnuGestionSolicitudes"
                AbrirFormulario(New frmGestionSolicitudes(), item)
            Case "mnuActividad"
                AbrirFormulario(New frmActividad(), item)
            Case Else
                AbrirModulo(item.Text, item)
        End Select
    End Sub

    Private Sub MarcarActivo(item As ToolStripMenuItem)
        Dim marcar As ToolStripMenuItem = item
        If item.OwnerItem Is mnuSolicitudes Then
            marcar = mnuSolicitudes
        End If

        ' No se puede en el Diseñador: el color y la fuente cambian según la opción activa.
        If opcionActiva IsNot Nothing AndAlso opcionActiva IsNot marcar Then
            opcionActiva.BackColor = Color.FromArgb(7, 47, 204)
            opcionActiva.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
            opcionActiva.ForeColor = Color.White
        End If

        marcar.BackColor = Color.FromArgb(5, 36, 160)
        marcar.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Regular)
        marcar.ForeColor = Color.White
        opcionActiva = marcar
        mnuPrincipal.Invalidate()
    End Sub

    Private Sub AbrirModulo(nombre As String, opcion As ToolStripMenuItem)
        MarcarActivo(opcion)
        MessageBox.Show("El módulo '" & nombre & "' estará disponible próximamente.", "Módulo en construcción", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub OpcionMenu_Click(sender As Object, e As EventArgs) Handles mnuInicio.Click, mnuUsuarios.Click, mnuMaquinaria.Click, mnuActividad.Click, mnuGestionSolicitudes.Click, mnuRegistrarSolicitud.Click, mnuMisSolicitudes.Click
        Dim item As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
        If item Is mnuInicio Then
            MostrarInicio()
            Return
        End If
        AbrirSegunOpcion(item)
    End Sub

    Private Sub mnuCerrarSesion_Click(sender As Object, e As EventArgs) Handles mnuCerrarSesion.Click
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
