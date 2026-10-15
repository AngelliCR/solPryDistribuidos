Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports System.Reflection

Public Class frmMenuPrincipal
    Private cerrandoSesion As Boolean
    Private opcionActiva As ToolStripMenuItem
    Private formularioAbierto As Form
    Private imagenFondo As Image
    Private acomodandoTextos As Boolean

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' DoubleBuffered está declarado en Control; en Panel no se encuentra con reflexión.
        Dim dobleBuffer As PropertyInfo = GetType(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic Or BindingFlags.Instance)
        dobleBuffer.SetValue(pnlContenido, True, Nothing)
        dobleBuffer.SetValue(lblBienvenido, True, Nothing)
        dobleBuffer.SetValue(lblFecha, True, Nothing)
        dobleBuffer.SetValue(lblSistema, True, Nothing)

        imagenFondo = pnlContenido.BackgroundImage
        pnlContenido.BackgroundImage = Nothing
        mnuPrincipal.Renderer = New clsRenderMenu()
        PrepararSubmenu(mnuSolicitudes)
        PrepararSubmenu(mnuUsuarioSesion)

        mnuUsuarioSesion.Text = modSesion.UsuarioNombre & " · " & modSesion.UsuarioRol
        lblBienvenido.Text = "Bienvenido, " & modSesion.UsuarioNombre
        lblFecha.Text = FechaHoy()

        pnlContenido.Controls.SetChildIndex(pnlModulo, 0)
        AplicarPermisos()
        AcomodarTextos()
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

        mnuInicio.Visible = True
        mnuUsuarios.Visible = esAdmin
        mnuMaquinaria.Visible = esAdmin OrElse esSupervisor
        mnuGestionSolicitudes.Visible = esAdmin OrElse esSupervisor
        mnuRegistrarSolicitud.Visible = esOperario
        mnuMisSolicitudes.Visible = esOperario
        mnuActividad.Visible = esAdmin OrElse esSupervisor OrElse esOperario
        mnuSolicitudes.Visible = mnuGestionSolicitudes.Visible OrElse mnuRegistrarSolicitud.Visible OrElse mnuMisSolicitudes.Visible
    End Sub

    Private Sub MostrarInicio()
        CerrarFormularioAbierto()
        pnlModulo.Visible = False
        MarcarActivo(mnuInicio)
        lblBienvenido.Visible = True
        lblFecha.Visible = True
        lblSistema.Visible = True
        pnlContenido.Invalidate()
    End Sub

    Private Sub AbrirFormulario(frm As Form, opcion As ToolStripMenuItem)
        MarcarActivo(opcion)
        CerrarFormularioAbierto()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        lblBienvenido.Visible = False
        lblFecha.Visible = False
        lblSistema.Visible = False
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

    Private Sub pnlContenido_Resize(sender As Object, e As EventArgs) Handles pnlContenido.Resize
        AcomodarTextos()
        pnlContenido.Invalidate()
    End Sub

    Private Sub AcomodarTextos()
        If acomodandoTextos OrElse pnlContenido.ClientSize.Height < 1 Then
            Return
        End If
        acomodandoTextos = True
        Try
            Dim margen As Integer = 48
            Dim y As Integer = pnlContenido.ClientSize.Height - margen - lblSistema.Height
            Colocar(lblSistema, margen, y)
            y -= 6 + lblFecha.Height
            Colocar(lblFecha, margen, y)
            y -= 4 + lblBienvenido.Height
            Colocar(lblBienvenido, margen, y)
        Finally
            acomodandoTextos = False
        End Try
    End Sub

    Private Sub Colocar(lbl As Label, x As Integer, y As Integer)
        If lbl.Left <> x OrElse lbl.Top <> y Then
            lbl.Location = New Point(x, y)
        End If
    End Sub

    Private Sub pnlContenido_Paint(sender As Object, e As PaintEventArgs) Handles pnlContenido.Paint
        DibujarFondo(e.Graphics)
    End Sub

    Private Sub Etiqueta_Paint(sender As Object, e As PaintEventArgs) Handles lblBienvenido.Paint, lblFecha.Paint, lblSistema.Paint
        Dim lbl As Label = DirectCast(sender, Label)
        Dim estado As GraphicsState = e.Graphics.Save()
        Try
            e.Graphics.TranslateTransform(-lbl.Left, -lbl.Top)
            e.Graphics.SetClip(New Rectangle(lbl.Left, lbl.Top, lbl.Width, lbl.Height))
            DibujarFondo(e.Graphics)
        Finally
            e.Graphics.Restore(estado)
        End Try
        TextRenderer.DrawText(e.Graphics, lbl.Text, lbl.Font, lbl.ClientRectangle, lbl.ForeColor, TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.NoPrefix)
    End Sub

    Private Sub DibujarFondo(g As Graphics)
        If imagenFondo Is Nothing Then
            Return
        End If
        Dim anchoPanel As Integer = pnlContenido.ClientSize.Width
        Dim altoPanel As Integer = pnlContenido.ClientSize.Height
        If anchoPanel < 1 OrElse altoPanel < 1 OrElse imagenFondo.Width < 1 OrElse imagenFondo.Height < 1 Then
            Return
        End If

        Dim escala As Single = Math.Max(anchoPanel / CSng(imagenFondo.Width), altoPanel / CSng(imagenFondo.Height))
        Dim anchoDibujo As Single = imagenFondo.Width * escala
        Dim altoDibujo As Single = imagenFondo.Height * escala
        Dim x As Single = (anchoPanel - anchoDibujo) / 2.0F
        Dim y As Single = (altoPanel - altoDibujo) / 2.0F

        g.InterpolationMode = InterpolationMode.HighQualityBicubic
        g.PixelOffsetMode = PixelOffsetMode.HighQuality
        g.DrawImage(imagenFondo, x, y, anchoDibujo, altoDibujo)

        Dim altoBanda As Integer = CInt(altoPanel * 0.35F)
        If altoBanda > 0 Then
            Dim rect As New Rectangle(0, altoPanel - altoBanda, anchoPanel, altoBanda)
            Using brocha As New LinearGradientBrush(rect, Color.FromArgb(0, 0, 0, 0), Color.FromArgb(170, 0, 0, 0), LinearGradientMode.Vertical)
                g.FillRectangle(brocha, rect)
            End Using
        End If
    End Sub
End Class
