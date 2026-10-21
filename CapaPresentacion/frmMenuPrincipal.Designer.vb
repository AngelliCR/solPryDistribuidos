<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.mnuMarca = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMaquinaria = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSolicitudes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGestionSolicitudes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegistrarSolicitud = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMisSolicitudes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuActividad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUsuarioSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.pnlModulo = New System.Windows.Forms.Panel()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.mnuPrincipal.SuspendLayout()
        Me.pnlContenido.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.AutoSize = False
        Me.mnuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.mnuPrincipal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuPrincipal.ForeColor = System.Drawing.Color.White
        Me.mnuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMarca, Me.mnuInicio, Me.mnuUsuarios, Me.mnuMaquinaria, Me.mnuSolicitudes, Me.mnuActividad, Me.mnuUsuarioSesion})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Padding = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.mnuPrincipal.Size = New System.Drawing.Size(1200, 40)
        Me.mnuPrincipal.TabIndex = 1
        Me.mnuPrincipal.Text = "mnuPrincipal"
        '
        'mnuMarca
        '
        Me.mnuMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.mnuMarca.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMarca.ForeColor = System.Drawing.Color.White
        Me.mnuMarca.Name = "mnuMarca"
        Me.mnuMarca.Padding = New System.Windows.Forms.Padding(8, 0, 20, 0)
        Me.mnuMarca.Size = New System.Drawing.Size(133, 28)
        Me.mnuMarca.Text = "POMALCA"
        '
        'mnuInicio
        '
        Me.mnuInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.mnuInicio.ForeColor = System.Drawing.Color.White
        Me.mnuInicio.Name = "mnuInicio"
        Me.mnuInicio.Size = New System.Drawing.Size(65, 28)
        Me.mnuInicio.Text = "Inicio"
        '
        'mnuUsuarios
        '
        Me.mnuUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.mnuUsuarios.ForeColor = System.Drawing.Color.White
        Me.mnuUsuarios.Name = "mnuUsuarios"
        Me.mnuUsuarios.Size = New System.Drawing.Size(174, 28)
        Me.mnuUsuarios.Text = "Gestión de usuarios"
        '
        'mnuMaquinaria
        '
        Me.mnuMaquinaria.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.mnuMaquinaria.ForeColor = System.Drawing.Color.White
        Me.mnuMaquinaria.Name = "mnuMaquinaria"
        Me.mnuMaquinaria.Size = New System.Drawing.Size(110, 28)
        Me.mnuMaquinaria.Text = "Maquinaria"
        '
        'mnuSolicitudes
        '
        Me.mnuSolicitudes.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.mnuSolicitudes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGestionSolicitudes, Me.mnuRegistrarSolicitud, Me.mnuMisSolicitudes})
        Me.mnuSolicitudes.ForeColor = System.Drawing.Color.White
        Me.mnuSolicitudes.Name = "mnuSolicitudes"
        Me.mnuSolicitudes.Size = New System.Drawing.Size(125, 28)
        Me.mnuSolicitudes.Text = "Solicitudes ▾"
        '
        'mnuGestionSolicitudes
        '
        Me.mnuGestionSolicitudes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.mnuGestionSolicitudes.Name = "mnuGestionSolicitudes"
        Me.mnuGestionSolicitudes.Size = New System.Drawing.Size(260, 28)
        Me.mnuGestionSolicitudes.Text = "Gestión de solicitudes"
        '
        'mnuRegistrarSolicitud
        '
        Me.mnuRegistrarSolicitud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.mnuRegistrarSolicitud.Name = "mnuRegistrarSolicitud"
        Me.mnuRegistrarSolicitud.Size = New System.Drawing.Size(260, 28)
        Me.mnuRegistrarSolicitud.Text = "Registrar solicitud"
        '
        'mnuMisSolicitudes
        '
        Me.mnuMisSolicitudes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.mnuMisSolicitudes.Name = "mnuMisSolicitudes"
        Me.mnuMisSolicitudes.Size = New System.Drawing.Size(260, 28)
        Me.mnuMisSolicitudes.Text = "Mis solicitudes"
        '
        'mnuActividad
        '
        Me.mnuActividad.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.mnuActividad.ForeColor = System.Drawing.Color.White
        Me.mnuActividad.Name = "mnuActividad"
        Me.mnuActividad.Size = New System.Drawing.Size(209, 28)
        Me.mnuActividad.Text = "Actividad de maquinaria"
        '
        'mnuUsuarioSesion
        '
        Me.mnuUsuarioSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuUsuarioSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.mnuUsuarioSesion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCerrarSesion})
        Me.mnuUsuarioSesion.ForeColor = System.Drawing.Color.White
        Me.mnuUsuarioSesion.Name = "mnuUsuarioSesion"
        Me.mnuUsuarioSesion.Size = New System.Drawing.Size(120, 28)
        Me.mnuUsuarioSesion.Text = "Usuario · Rol"
        '
        'mnuCerrarSesion
        '
        Me.mnuCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.mnuCerrarSesion.Name = "mnuCerrarSesion"
        Me.mnuCerrarSesion.Size = New System.Drawing.Size(193, 28)
        Me.mnuCerrarSesion.Text = "Cerrar sesión"
        '
        'pnlContenido
        '
        Me.pnlContenido.BackColor = System.Drawing.Color.Black
        Me.pnlContenido.BackgroundImage = CType(resources.GetObject("pnlContenido.BackgroundImage"), System.Drawing.Image)
        Me.pnlContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlContenido.Controls.Add(Me.pnlModulo)
        Me.pnlContenido.Controls.Add(Me.lblBienvenido)
        Me.pnlContenido.Controls.Add(Me.lblFecha)
        Me.pnlContenido.Controls.Add(Me.lblSistema)
        Me.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenido.Location = New System.Drawing.Point(0, 40)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(1200, 680)
        Me.pnlContenido.TabIndex = 0
        '
        'pnlModulo
        '
        Me.pnlModulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnlModulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlModulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlModulo.Name = "pnlModulo"
        Me.pnlModulo.Size = New System.Drawing.Size(1200, 680)
        Me.pnlModulo.TabIndex = 0
        Me.pnlModulo.Visible = False
        '
        'lblBienvenido
        '
        Me.lblBienvenido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenido.Font = New System.Drawing.Font("Segoe UI Semibold", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.ForeColor = System.Drawing.Color.White
        Me.lblBienvenido.Location = New System.Drawing.Point(48, 520)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(263, 62)
        Me.lblBienvenido.TabIndex = 1
        Me.lblBienvenido.Text = "Bienvenido"
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(48, 575)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(62, 28)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha"
        '
        'lblSistema
        '
        Me.lblSistema.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSistema.AutoSize = True
        Me.lblSistema.BackColor = System.Drawing.Color.Transparent
        Me.lblSistema.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSistema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lblSistema.Location = New System.Drawing.Point(48, 602)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(460, 25)
        Me.lblSistema.TabIndex = 3
        Me.lblSistema.Text = "Sistema de Gestión de Maquinaria Agrícola · Pomalca"
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 720)
        Me.Controls.Add(Me.pnlContenido)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pomalca - Menú principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlContenido.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents mnuMarca As ToolStripMenuItem
    Friend WithEvents mnuInicio As ToolStripMenuItem
    Friend WithEvents mnuUsuarios As ToolStripMenuItem
    Friend WithEvents mnuMaquinaria As ToolStripMenuItem
    Friend WithEvents mnuSolicitudes As ToolStripMenuItem
    Friend WithEvents mnuGestionSolicitudes As ToolStripMenuItem
    Friend WithEvents mnuRegistrarSolicitud As ToolStripMenuItem
    Friend WithEvents mnuMisSolicitudes As ToolStripMenuItem
    Friend WithEvents mnuActividad As ToolStripMenuItem
    Friend WithEvents mnuUsuarioSesion As ToolStripMenuItem
    Friend WithEvents mnuCerrarSesion As ToolStripMenuItem
    Friend WithEvents pnlContenido As Panel
    Friend WithEvents pnlModulo As Panel
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblSistema As Label
End Class
