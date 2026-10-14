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
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.pnlLineaSuperior = New System.Windows.Forms.Panel()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.pnlLateral = New System.Windows.Forms.Panel()
        Me.flpMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.pnlLineaLateral = New System.Windows.Forms.Panel()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.flpAccesos = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnSolicitudes = New System.Windows.Forms.Button()
        Me.btnTarea = New System.Windows.Forms.Button()
        Me.btnMaquinaria = New System.Windows.Forms.Button()
        Me.btnMantenimiento = New System.Windows.Forms.Button()
        Me.btnActividad = New System.Windows.Forms.Button()
        Me.btnRegistrarSolicitud = New System.Windows.Forms.Button()
        Me.btnMisSolicitudes = New System.Windows.Forms.Button()
        Me.btnFacturacion = New System.Windows.Forms.Button()
        Me.pnlCardUsuarios = New System.Windows.Forms.Panel()
        Me.lblCardUsuarios = New System.Windows.Forms.Label()
        Me.lblDescUsuarios = New System.Windows.Forms.Label()
        Me.pnlCardSolicitudes = New System.Windows.Forms.Panel()
        Me.lblCardSolicitudes = New System.Windows.Forms.Label()
        Me.lblDescSolicitudes = New System.Windows.Forms.Label()
        Me.pnlCardTarea = New System.Windows.Forms.Panel()
        Me.lblCardTarea = New System.Windows.Forms.Label()
        Me.lblDescTarea = New System.Windows.Forms.Label()
        Me.pnlCardMaquinaria = New System.Windows.Forms.Panel()
        Me.lblCardMaquinaria = New System.Windows.Forms.Label()
        Me.lblDescMaquinaria = New System.Windows.Forms.Label()
        Me.pnlCardMantenimiento = New System.Windows.Forms.Panel()
        Me.lblCardMantenimiento = New System.Windows.Forms.Label()
        Me.lblDescMantenimiento = New System.Windows.Forms.Label()
        Me.pnlCardActividad = New System.Windows.Forms.Panel()
        Me.lblCardActividad = New System.Windows.Forms.Label()
        Me.lblDescActividad = New System.Windows.Forms.Label()
        Me.pnlCardRegistrarSolicitud = New System.Windows.Forms.Panel()
        Me.lblCardRegistrarSolicitud = New System.Windows.Forms.Label()
        Me.lblDescRegistrarSolicitud = New System.Windows.Forms.Label()
        Me.pnlCardMisSolicitudes = New System.Windows.Forms.Panel()
        Me.lblCardMisSolicitudes = New System.Windows.Forms.Label()
        Me.lblDescMisSolicitudes = New System.Windows.Forms.Label()
        Me.pnlCardFacturacion = New System.Windows.Forms.Panel()
        Me.lblCardFacturacion = New System.Windows.Forms.Label()
        Me.lblDescFacturacion = New System.Windows.Forms.Label()
        Me.pnlSuperior.SuspendLayout()
        Me.pnlLateral.SuspendLayout()
        Me.pnlContenido.SuspendLayout()
        Me.flpMenu.SuspendLayout()
        Me.flpAccesos.SuspendLayout()
        Me.pnlCardUsuarios.SuspendLayout()
        Me.pnlCardSolicitudes.SuspendLayout()
        Me.pnlCardTarea.SuspendLayout()
        Me.pnlCardMaquinaria.SuspendLayout()
        Me.pnlCardMantenimiento.SuspendLayout()
        Me.pnlCardActividad.SuspendLayout()
        Me.pnlCardRegistrarSolicitud.SuspendLayout()
        Me.pnlCardMisSolicitudes.SuspendLayout()
        Me.pnlCardFacturacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSuperior
        '
        Me.pnlSuperior.BackColor = System.Drawing.Color.White
        Me.pnlSuperior.Controls.Add(Me.lblMarca)
        Me.pnlSuperior.Controls.Add(Me.lblUsuario)
        Me.pnlSuperior.Controls.Add(Me.lblRol)
        Me.pnlSuperior.Controls.Add(Me.pnlLineaSuperior)
        Me.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(1200, 60)
        Me.pnlSuperior.TabIndex = 0
        '
        'pnlLineaSuperior
        '
        Me.pnlLineaSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlLineaSuperior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlLineaSuperior.Location = New System.Drawing.Point(0, 59)
        Me.pnlLineaSuperior.Name = "pnlLineaSuperior"
        Me.pnlLineaSuperior.Size = New System.Drawing.Size(1200, 1)
        Me.pnlLineaSuperior.TabIndex = 3
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.lblMarca.Location = New System.Drawing.Point(24, 16)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(109, 30)
        Me.lblMarca.TabIndex = 0
        Me.lblMarca.Text = "POMALCA"
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblUsuario.Location = New System.Drawing.Point(796, 8)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(380, 22)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuario"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRol
        '
        Me.lblRol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRol.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblRol.Location = New System.Drawing.Point(796, 30)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(380, 18)
        Me.lblRol.TabIndex = 2
        Me.lblRol.Text = "Rol"
        Me.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlLateral
        '
        Me.pnlLateral.BackColor = System.Drawing.Color.White
        Me.pnlLateral.Controls.Add(Me.flpMenu)
        Me.pnlLateral.Controls.Add(Me.btnCerrarSesion)
        Me.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLateral.Location = New System.Drawing.Point(0, 60)
        Me.pnlLateral.Name = "pnlLateral"
        Me.pnlLateral.Size = New System.Drawing.Size(230, 660)
        Me.pnlLateral.TabIndex = 1
        '
        'flpMenu
        '
        Me.flpMenu.AutoScroll = True
        Me.flpMenu.BackColor = System.Drawing.Color.White
        Me.flpMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpMenu.Controls.Add(Me.btnInicio)
        Me.flpMenu.Controls.Add(Me.btnUsuarios)
        Me.flpMenu.Controls.Add(Me.btnSolicitudes)
        Me.flpMenu.Controls.Add(Me.btnTarea)
        Me.flpMenu.Controls.Add(Me.btnMaquinaria)
        Me.flpMenu.Controls.Add(Me.btnMantenimiento)
        Me.flpMenu.Controls.Add(Me.btnActividad)
        Me.flpMenu.Controls.Add(Me.btnRegistrarSolicitud)
        Me.flpMenu.Controls.Add(Me.btnMisSolicitudes)
        Me.flpMenu.Controls.Add(Me.btnFacturacion)
        Me.flpMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMenu.Location = New System.Drawing.Point(0, 0)
        Me.flpMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.flpMenu.Name = "flpMenu"
        Me.flpMenu.Padding = New System.Windows.Forms.Padding(0)
        Me.flpMenu.Size = New System.Drawing.Size(230, 616)
        Me.flpMenu.TabIndex = 0
        Me.flpMenu.WrapContents = False
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.Color.White
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnInicio.Location = New System.Drawing.Point(0, 0)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnInicio.Size = New System.Drawing.Size(230, 44)
        Me.btnInicio.TabIndex = 0
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.White
        Me.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 44)
        Me.btnUsuarios.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnUsuarios.Size = New System.Drawing.Size(230, 44)
        Me.btnUsuarios.TabIndex = 1
        Me.btnUsuarios.Text = "Gestión de usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'btnSolicitudes
        '
        Me.btnSolicitudes.BackColor = System.Drawing.Color.White
        Me.btnSolicitudes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSolicitudes.FlatAppearance.BorderSize = 0
        Me.btnSolicitudes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnSolicitudes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolicitudes.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitudes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnSolicitudes.Location = New System.Drawing.Point(0, 88)
        Me.btnSolicitudes.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSolicitudes.Name = "btnSolicitudes"
        Me.btnSolicitudes.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnSolicitudes.Size = New System.Drawing.Size(230, 44)
        Me.btnSolicitudes.TabIndex = 2
        Me.btnSolicitudes.Text = "Gestión de solicitudes"
        Me.btnSolicitudes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSolicitudes.UseVisualStyleBackColor = False
        '
        'btnTarea
        '
        Me.btnTarea.BackColor = System.Drawing.Color.White
        Me.btnTarea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTarea.FlatAppearance.BorderSize = 0
        Me.btnTarea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnTarea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTarea.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnTarea.Location = New System.Drawing.Point(0, 132)
        Me.btnTarea.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTarea.Name = "btnTarea"
        Me.btnTarea.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnTarea.Size = New System.Drawing.Size(230, 44)
        Me.btnTarea.TabIndex = 3
        Me.btnTarea.Text = "Registrar tarea"
        Me.btnTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTarea.UseVisualStyleBackColor = False
        '
        'btnMaquinaria
        '
        Me.btnMaquinaria.BackColor = System.Drawing.Color.White
        Me.btnMaquinaria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaquinaria.FlatAppearance.BorderSize = 0
        Me.btnMaquinaria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnMaquinaria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnMaquinaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaquinaria.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaquinaria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnMaquinaria.Location = New System.Drawing.Point(0, 176)
        Me.btnMaquinaria.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMaquinaria.Name = "btnMaquinaria"
        Me.btnMaquinaria.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnMaquinaria.Size = New System.Drawing.Size(230, 44)
        Me.btnMaquinaria.TabIndex = 4
        Me.btnMaquinaria.Text = "Maquinaria"
        Me.btnMaquinaria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMaquinaria.UseVisualStyleBackColor = False
        '
        'btnMantenimiento
        '
        Me.btnMantenimiento.BackColor = System.Drawing.Color.White
        Me.btnMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMantenimiento.FlatAppearance.BorderSize = 0
        Me.btnMantenimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnMantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMantenimiento.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMantenimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnMantenimiento.Location = New System.Drawing.Point(0, 220)
        Me.btnMantenimiento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMantenimiento.Name = "btnMantenimiento"
        Me.btnMantenimiento.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnMantenimiento.Size = New System.Drawing.Size(230, 44)
        Me.btnMantenimiento.TabIndex = 5
        Me.btnMantenimiento.Text = "Mantenimiento"
        Me.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMantenimiento.UseVisualStyleBackColor = False
        '
        'btnActividad
        '
        Me.btnActividad.BackColor = System.Drawing.Color.White
        Me.btnActividad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActividad.FlatAppearance.BorderSize = 0
        Me.btnActividad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnActividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActividad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActividad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnActividad.Location = New System.Drawing.Point(0, 264)
        Me.btnActividad.Margin = New System.Windows.Forms.Padding(0)
        Me.btnActividad.Name = "btnActividad"
        Me.btnActividad.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnActividad.Size = New System.Drawing.Size(230, 44)
        Me.btnActividad.TabIndex = 6
        Me.btnActividad.Text = "Actividad de maquinaria"
        Me.btnActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActividad.UseVisualStyleBackColor = False
        '
        'btnRegistrarSolicitud
        '
        Me.btnRegistrarSolicitud.BackColor = System.Drawing.Color.White
        Me.btnRegistrarSolicitud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarSolicitud.FlatAppearance.BorderSize = 0
        Me.btnRegistrarSolicitud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnRegistrarSolicitud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnRegistrarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarSolicitud.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarSolicitud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnRegistrarSolicitud.Location = New System.Drawing.Point(0, 308)
        Me.btnRegistrarSolicitud.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRegistrarSolicitud.Name = "btnRegistrarSolicitud"
        Me.btnRegistrarSolicitud.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnRegistrarSolicitud.Size = New System.Drawing.Size(230, 44)
        Me.btnRegistrarSolicitud.TabIndex = 7
        Me.btnRegistrarSolicitud.Text = "Registrar solicitud"
        Me.btnRegistrarSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarSolicitud.UseVisualStyleBackColor = False
        '
        'btnMisSolicitudes
        '
        Me.btnMisSolicitudes.BackColor = System.Drawing.Color.White
        Me.btnMisSolicitudes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMisSolicitudes.FlatAppearance.BorderSize = 0
        Me.btnMisSolicitudes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnMisSolicitudes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnMisSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMisSolicitudes.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMisSolicitudes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnMisSolicitudes.Location = New System.Drawing.Point(0, 352)
        Me.btnMisSolicitudes.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMisSolicitudes.Name = "btnMisSolicitudes"
        Me.btnMisSolicitudes.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnMisSolicitudes.Size = New System.Drawing.Size(230, 44)
        Me.btnMisSolicitudes.TabIndex = 8
        Me.btnMisSolicitudes.Text = "Mis solicitudes"
        Me.btnMisSolicitudes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMisSolicitudes.UseVisualStyleBackColor = False
        '
        'btnFacturacion
        '
        Me.btnFacturacion.BackColor = System.Drawing.Color.White
        Me.btnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacturacion.FlatAppearance.BorderSize = 0
        Me.btnFacturacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturacion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnFacturacion.Location = New System.Drawing.Point(0, 396)
        Me.btnFacturacion.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFacturacion.Name = "btnFacturacion"
        Me.btnFacturacion.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnFacturacion.Size = New System.Drawing.Size(230, 44)
        Me.btnFacturacion.TabIndex = 9
        Me.btnFacturacion.Text = "Facturación"
        Me.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturacion.UseVisualStyleBackColor = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 616)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnCerrarSesion.Size = New System.Drawing.Size(230, 44)
        Me.btnCerrarSesion.TabIndex = 10
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'pnlLineaLateral
        '
        Me.pnlLineaLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlLineaLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLineaLateral.Location = New System.Drawing.Point(230, 60)
        Me.pnlLineaLateral.Name = "pnlLineaLateral"
        Me.pnlLineaLateral.Size = New System.Drawing.Size(1, 660)
        Me.pnlLineaLateral.TabIndex = 2
        '
        'pnlContenido
        '
        Me.pnlContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnlContenido.Controls.Add(Me.flpAccesos)
        Me.pnlContenido.Controls.Add(Me.lblFecha)
        Me.pnlContenido.Controls.Add(Me.lblBienvenido)
        Me.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenido.Location = New System.Drawing.Point(231, 60)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlContenido.Size = New System.Drawing.Size(969, 660)
        Me.pnlContenido.TabIndex = 3
        '
        'lblBienvenido
        '
        Me.lblBienvenido.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblBienvenido.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblBienvenido.Location = New System.Drawing.Point(30, 30)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(909, 46)
        Me.lblBienvenido.TabIndex = 0
        Me.lblBienvenido.Text = "Bienvenido"
        Me.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(30, 76)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Padding = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.lblFecha.Size = New System.Drawing.Size(909, 32)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'flpAccesos
        '
        Me.flpAccesos.AutoScroll = True
        Me.flpAccesos.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.flpAccesos.Controls.Add(Me.pnlCardUsuarios)
        Me.flpAccesos.Controls.Add(Me.pnlCardSolicitudes)
        Me.flpAccesos.Controls.Add(Me.pnlCardTarea)
        Me.flpAccesos.Controls.Add(Me.pnlCardMaquinaria)
        Me.flpAccesos.Controls.Add(Me.pnlCardMantenimiento)
        Me.flpAccesos.Controls.Add(Me.pnlCardActividad)
        Me.flpAccesos.Controls.Add(Me.pnlCardRegistrarSolicitud)
        Me.flpAccesos.Controls.Add(Me.pnlCardMisSolicitudes)
        Me.flpAccesos.Controls.Add(Me.pnlCardFacturacion)
        Me.flpAccesos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpAccesos.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight
        Me.flpAccesos.Location = New System.Drawing.Point(30, 108)
        Me.flpAccesos.Margin = New System.Windows.Forms.Padding(0)
        Me.flpAccesos.Name = "flpAccesos"
        Me.flpAccesos.Padding = New System.Windows.Forms.Padding(0, 16, 0, 0)
        Me.flpAccesos.Size = New System.Drawing.Size(909, 522)
        Me.flpAccesos.TabIndex = 2
        Me.flpAccesos.WrapContents = True
        '
        'pnlCardUsuarios
        '
        Me.pnlCardUsuarios.BackColor = System.Drawing.Color.White
        Me.pnlCardUsuarios.Controls.Add(Me.lblDescUsuarios)
        Me.pnlCardUsuarios.Controls.Add(Me.lblCardUsuarios)
        Me.pnlCardUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlCardUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.pnlCardUsuarios.Margin = New System.Windows.Forms.Padding(0, 0, 16, 16)
        Me.pnlCardUsuarios.Name = "pnlCardUsuarios"
        Me.pnlCardUsuarios.Size = New System.Drawing.Size(220, 120)
        Me.pnlCardUsuarios.TabIndex = 0
        '
        'lblCardUsuarios
        '
        Me.lblCardUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCardUsuarios.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblCardUsuarios.Location = New System.Drawing.Point(16, 16)
        Me.lblCardUsuarios.Name = "lblCardUsuarios"
        Me.lblCardUsuarios.Size = New System.Drawing.Size(188, 40)
        Me.lblCardUsuarios.TabIndex = 0
        Me.lblCardUsuarios.Text = "Gestión de usuarios"
        '
        'lblDescUsuarios
        '
        Me.lblDescUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDescUsuarios.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDescUsuarios.Location = New System.Drawing.Point(16, 60)
        Me.lblDescUsuarios.Name = "lblDescUsuarios"
        Me.lblDescUsuarios.Size = New System.Drawing.Size(188, 42)
        Me.lblDescUsuarios.TabIndex = 1
        Me.lblDescUsuarios.Text = "Cuentas y roles del personal"
        '
        'pnlCardSolicitudes
        '
        Me.pnlCardSolicitudes.BackColor = System.Drawing.Color.White
        Me.pnlCardSolicitudes.Controls.Add(Me.lblDescSolicitudes)
        Me.pnlCardSolicitudes.Controls.Add(Me.lblCardSolicitudes)
        Me.pnlCardSolicitudes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlCardSolicitudes.Location = New System.Drawing.Point(236, 0)
        Me.pnlCardSolicitudes.Margin = New System.Windows.Forms.Padding(0, 0, 16, 16)
        Me.pnlCardSolicitudes.Name = "pnlCardSolicitudes"
        Me.pnlCardSolicitudes.Size = New System.Drawing.Size(220, 120)
        Me.pnlCardSolicitudes.TabIndex = 1
        '
        'lblCardSolicitudes
        '
        Me.lblCardSolicitudes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCardSolicitudes.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardSolicitudes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblCardSolicitudes.Location = New System.Drawing.Point(16, 16)
        Me.lblCardSolicitudes.Name = "lblCardSolicitudes"
        Me.lblCardSolicitudes.Size = New System.Drawing.Size(188, 40)
        Me.lblCardSolicitudes.TabIndex = 0
        Me.lblCardSolicitudes.Text = "Gestión de solicitudes"
        '
        'lblDescSolicitudes
        '
        Me.lblDescSolicitudes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDescSolicitudes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescSolicitudes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDescSolicitudes.Location = New System.Drawing.Point(16, 60)
        Me.lblDescSolicitudes.Name = "lblDescSolicitudes"
        Me.lblDescSolicitudes.Size = New System.Drawing.Size(188, 42)
        Me.lblDescSolicitudes.TabIndex = 1
        Me.lblDescSolicitudes.Text = "Revisión de solicitudes"
        '
        'pnlCardTarea
        '
        Me.pnlCardTarea.BackColor = System.Drawing.Color.White
        Me.pnlCardTarea.Controls.Add(Me.lblDescTarea)
        Me.pnlCardTarea.Controls.Add(Me.lblCardTarea)
        Me.pnlCardTarea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlCardTarea.Location = New System.Drawing.Point(472, 0)
        Me.pnlCardTarea.Margin = New System.Windows.Forms.Padding(0, 0, 16, 16)
        Me.pnlCardTarea.Name = "pnlCardTarea"
        Me.pnlCardTarea.Size = New System.Drawing.Size(220, 120)
        Me.pnlCardTarea.TabIndex = 2
        '
        'lblCardTarea
        '
        Me.lblCardTarea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCardTarea.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardTarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblCardTarea.Location = New System.Drawing.Point(16, 16)
        Me.lblCardTarea.Name = "lblCardTarea"
        Me.lblCardTarea.Size = New System.Drawing.Size(188, 40)
        Me.lblCardTarea.TabIndex = 0
        Me.lblCardTarea.Text = "Registrar tarea"
        '
        'lblDescTarea
        '
        Me.lblDescTarea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDescTarea.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescTarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDescTarea.Location = New System.Drawing.Point(16, 60)
        Me.lblDescTarea.Name = "lblDescTarea"
        Me.lblDescTarea.Size = New System.Drawing.Size(188, 42)
        Me.lblDescTarea.TabIndex = 1
        Me.lblDescTarea.Text = "Alta de tareas de trabajo"
        '
        'pnlCardMaquinaria
        '
        Me.pnlCardMaquinaria.BackColor = System.Drawing.Color.White
        Me.pnlCardMaquinaria.Controls.Add(Me.lblDescMaquinaria)
        Me.pnlCardMaquinaria.Controls.Add(Me.lblCardMaquinaria)
        Me.pnlCardMaquinaria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlCardMaquinaria.Location = New System.Drawing.Point(708, 0)
        Me.pnlCardMaquinaria.Margin = New System.Windows.Forms.Padding(0, 0, 16, 16)
        Me.pnlCardMaquinaria.Name = "pnlCardMaquinaria"
        Me.pnlCardMaquinaria.Size = New System.Drawing.Size(220, 120)
        Me.pnlCardMaquinaria.TabIndex = 3
        '
        'lblCardMaquinaria
        '
        Me.lblCardMaquinaria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCardMaquinaria.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardMaquinaria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblCardMaquinaria.Location = New System.Drawing.Point(16, 16)
        Me.lblCardMaquinaria.Name = "lblCardMaquinaria"
        Me.lblCardMaquinaria.Size = New System.Drawing.Size(188, 40)
        Me.lblCardMaquinaria.TabIndex = 0
        Me.lblCardMaquinaria.Text = "Maquinaria"
        '
        'lblDescMaquinaria
        '
        Me.lblDescMaquinaria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDescMaquinaria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescMaquinaria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDescMaquinaria.Location = New System.Drawing.Point(16, 60)
        Me.lblDescMaquinaria.Name = "lblDescMaquinaria"
        Me.lblDescMaquinaria.Size = New System.Drawing.Size(188, 42)
        Me.lblDescMaquinaria.TabIndex = 1
        Me.lblDescMaquinaria.Text = "Inventario de maquinaria"
        '
        'pnlCardMantenimiento
        '
        Me.pnlCardMantenimiento.BackColor = System.Drawing.Color.White
        Me.pnlCardMantenimiento.Controls.Add(Me.lblDescMantenimiento)
        Me.pnlCardMantenimiento.Controls.Add(Me.lblCardMantenimiento)
        Me.pnlCardMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlCardMantenimiento.Location = New System.Drawing.Point(0, 136)
        Me.pnlCardMantenimiento.Margin = New System.Windows.Forms.Padding(0, 0, 16, 16)
        Me.pnlCardMantenimiento.Name = "pnlCardMantenimiento"
        Me.pnlCardMantenimiento.Size = New System.Drawing.Size(220, 120)
        Me.pnlCardMantenimiento.TabIndex = 4
        '
        'lblCardMantenimiento
        '
        Me.lblCardMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCardMantenimiento.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardMantenimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblCardMantenimiento.Location = New System.Drawing.Point(16, 16)
        Me.lblCardMantenimiento.Name = "lblCardMantenimiento"
        Me.lblCardMantenimiento.Size = New System.Drawing.Size(188, 40)
        Me.lblCardMantenimiento.TabIndex = 0
        Me.lblCardMantenimiento.Text = "Mantenimiento"
        '
        'lblDescMantenimiento
        '
        Me.lblDescMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDescMantenimiento.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescMantenimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDescMantenimiento.Location = New System.Drawing.Point(16, 60)
        Me.lblDescMantenimiento.Name = "lblDescMantenimiento"
        Me.lblDescMantenimiento.Size = New System.Drawing.Size(188, 42)
        Me.lblDescMantenimiento.TabIndex = 1
        Me.lblDescMantenimiento.Text = "Control de mantenimientos"
        '
        'pnlCardActividad
        '
        Me.pnlCardActividad.BackColor = System.Drawing.Color.White
        Me.pnlCardActividad.Controls.Add(Me.lblDescActividad)
        Me.pnlCardActividad.Controls.Add(Me.lblCardActividad)
        Me.pnlCardActividad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlCardActividad.Location = New System.Drawing.Point(236, 136)
        Me.pnlCardActividad.Margin = New System.Windows.Forms.Padding(0, 0, 16, 16)
        Me.pnlCardActividad.Name = "pnlCardActividad"
        Me.pnlCardActividad.Size = New System.Drawing.Size(220, 120)
        Me.pnlCardActividad.TabIndex = 5
        '
        'lblCardActividad
        '
        Me.lblCardActividad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCardActividad.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardActividad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblCardActividad.Location = New System.Drawing.Point(16, 16)
        Me.lblCardActividad.Name = "lblCardActividad"
        Me.lblCardActividad.Size = New System.Drawing.Size(188, 40)
        Me.lblCardActividad.TabIndex = 0
        Me.lblCardActividad.Text = "Actividad de maquinaria"
        '
        'lblDescActividad
        '
        Me.lblDescActividad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDescActividad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescActividad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDescActividad.Location = New System.Drawing.Point(16, 60)
        Me.lblDescActividad.Name = "lblDescActividad"
        Me.lblDescActividad.Size = New System.Drawing.Size(188, 42)
        Me.lblDescActividad.TabIndex = 1
        Me.lblDescActividad.Text = "Uso de maquinaria en campo"
        '
        'pnlCardRegistrarSolicitud
        '
        Me.pnlCardRegistrarSolicitud.BackColor = System.Drawing.Color.White
        Me.pnlCardRegistrarSolicitud.Controls.Add(Me.lblDescRegistrarSolicitud)
        Me.pnlCardRegistrarSolicitud.Controls.Add(Me.lblCardRegistrarSolicitud)
        Me.pnlCardRegistrarSolicitud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlCardRegistrarSolicitud.Location = New System.Drawing.Point(472, 136)
        Me.pnlCardRegistrarSolicitud.Margin = New System.Windows.Forms.Padding(0, 0, 16, 16)
        Me.pnlCardRegistrarSolicitud.Name = "pnlCardRegistrarSolicitud"
        Me.pnlCardRegistrarSolicitud.Size = New System.Drawing.Size(220, 120)
        Me.pnlCardRegistrarSolicitud.TabIndex = 6
        '
        'lblCardRegistrarSolicitud
        '
        Me.lblCardRegistrarSolicitud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCardRegistrarSolicitud.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardRegistrarSolicitud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblCardRegistrarSolicitud.Location = New System.Drawing.Point(16, 16)
        Me.lblCardRegistrarSolicitud.Name = "lblCardRegistrarSolicitud"
        Me.lblCardRegistrarSolicitud.Size = New System.Drawing.Size(188, 40)
        Me.lblCardRegistrarSolicitud.TabIndex = 0
        Me.lblCardRegistrarSolicitud.Text = "Registrar solicitud"
        '
        'lblDescRegistrarSolicitud
        '
        Me.lblDescRegistrarSolicitud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDescRegistrarSolicitud.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescRegistrarSolicitud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDescRegistrarSolicitud.Location = New System.Drawing.Point(16, 60)
        Me.lblDescRegistrarSolicitud.Name = "lblDescRegistrarSolicitud"
        Me.lblDescRegistrarSolicitud.Size = New System.Drawing.Size(188, 42)
        Me.lblDescRegistrarSolicitud.TabIndex = 1
        Me.lblDescRegistrarSolicitud.Text = "Nueva solicitud de servicio"
        '
        'pnlCardMisSolicitudes
        '
        Me.pnlCardMisSolicitudes.BackColor = System.Drawing.Color.White
        Me.pnlCardMisSolicitudes.Controls.Add(Me.lblDescMisSolicitudes)
        Me.pnlCardMisSolicitudes.Controls.Add(Me.lblCardMisSolicitudes)
        Me.pnlCardMisSolicitudes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlCardMisSolicitudes.Location = New System.Drawing.Point(708, 136)
        Me.pnlCardMisSolicitudes.Margin = New System.Windows.Forms.Padding(0, 0, 16, 16)
        Me.pnlCardMisSolicitudes.Name = "pnlCardMisSolicitudes"
        Me.pnlCardMisSolicitudes.Size = New System.Drawing.Size(220, 120)
        Me.pnlCardMisSolicitudes.TabIndex = 7
        '
        'lblCardMisSolicitudes
        '
        Me.lblCardMisSolicitudes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCardMisSolicitudes.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardMisSolicitudes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblCardMisSolicitudes.Location = New System.Drawing.Point(16, 16)
        Me.lblCardMisSolicitudes.Name = "lblCardMisSolicitudes"
        Me.lblCardMisSolicitudes.Size = New System.Drawing.Size(188, 40)
        Me.lblCardMisSolicitudes.TabIndex = 0
        Me.lblCardMisSolicitudes.Text = "Mis solicitudes"
        '
        'lblDescMisSolicitudes
        '
        Me.lblDescMisSolicitudes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDescMisSolicitudes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescMisSolicitudes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDescMisSolicitudes.Location = New System.Drawing.Point(16, 60)
        Me.lblDescMisSolicitudes.Name = "lblDescMisSolicitudes"
        Me.lblDescMisSolicitudes.Size = New System.Drawing.Size(188, 42)
        Me.lblDescMisSolicitudes.TabIndex = 1
        Me.lblDescMisSolicitudes.Text = "Consulta de sus solicitudes"
        '
        'pnlCardFacturacion
        '
        Me.pnlCardFacturacion.BackColor = System.Drawing.Color.White
        Me.pnlCardFacturacion.Controls.Add(Me.lblDescFacturacion)
        Me.pnlCardFacturacion.Controls.Add(Me.lblCardFacturacion)
        Me.pnlCardFacturacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlCardFacturacion.Location = New System.Drawing.Point(0, 272)
        Me.pnlCardFacturacion.Margin = New System.Windows.Forms.Padding(0, 0, 16, 16)
        Me.pnlCardFacturacion.Name = "pnlCardFacturacion"
        Me.pnlCardFacturacion.Size = New System.Drawing.Size(220, 120)
        Me.pnlCardFacturacion.TabIndex = 8
        '
        'lblCardFacturacion
        '
        Me.lblCardFacturacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCardFacturacion.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardFacturacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblCardFacturacion.Location = New System.Drawing.Point(16, 16)
        Me.lblCardFacturacion.Name = "lblCardFacturacion"
        Me.lblCardFacturacion.Size = New System.Drawing.Size(188, 40)
        Me.lblCardFacturacion.TabIndex = 0
        Me.lblCardFacturacion.Text = "Facturación"
        '
        'lblDescFacturacion
        '
        Me.lblDescFacturacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDescFacturacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescFacturacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDescFacturacion.Location = New System.Drawing.Point(16, 60)
        Me.lblDescFacturacion.Name = "lblDescFacturacion"
        Me.lblDescFacturacion.Size = New System.Drawing.Size(188, 42)
        Me.lblDescFacturacion.TabIndex = 1
        Me.lblDescFacturacion.Text = "Emisión y control de facturas"
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 720)
        Me.Controls.Add(Me.pnlContenido)
        Me.Controls.Add(Me.pnlLineaLateral)
        Me.Controls.Add(Me.pnlLateral)
        Me.Controls.Add(Me.pnlSuperior)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pomalca - Menú principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlCardFacturacion.ResumeLayout(False)
        Me.pnlCardMisSolicitudes.ResumeLayout(False)
        Me.pnlCardRegistrarSolicitud.ResumeLayout(False)
        Me.pnlCardActividad.ResumeLayout(False)
        Me.pnlCardMantenimiento.ResumeLayout(False)
        Me.pnlCardMaquinaria.ResumeLayout(False)
        Me.pnlCardTarea.ResumeLayout(False)
        Me.pnlCardSolicitudes.ResumeLayout(False)
        Me.pnlCardUsuarios.ResumeLayout(False)
        Me.flpAccesos.ResumeLayout(False)
        Me.flpMenu.ResumeLayout(False)
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlLateral.ResumeLayout(False)
        Me.pnlSuperior.ResumeLayout(False)
        Me.pnlSuperior.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents pnlLineaSuperior As Panel
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblRol As Label
    Friend WithEvents pnlLateral As Panel
    Friend WithEvents flpMenu As FlowLayoutPanel
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents pnlLineaLateral As Panel
    Friend WithEvents pnlContenido As Panel
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents flpAccesos As FlowLayoutPanel
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnSolicitudes As Button
    Friend WithEvents btnTarea As Button
    Friend WithEvents btnMaquinaria As Button
    Friend WithEvents btnMantenimiento As Button
    Friend WithEvents btnActividad As Button
    Friend WithEvents btnRegistrarSolicitud As Button
    Friend WithEvents btnMisSolicitudes As Button
    Friend WithEvents btnFacturacion As Button
    Friend WithEvents pnlCardUsuarios As Panel
    Friend WithEvents lblCardUsuarios As Label
    Friend WithEvents lblDescUsuarios As Label
    Friend WithEvents pnlCardSolicitudes As Panel
    Friend WithEvents lblCardSolicitudes As Label
    Friend WithEvents lblDescSolicitudes As Label
    Friend WithEvents pnlCardTarea As Panel
    Friend WithEvents lblCardTarea As Label
    Friend WithEvents lblDescTarea As Label
    Friend WithEvents pnlCardMaquinaria As Panel
    Friend WithEvents lblCardMaquinaria As Label
    Friend WithEvents lblDescMaquinaria As Label
    Friend WithEvents pnlCardMantenimiento As Panel
    Friend WithEvents lblCardMantenimiento As Label
    Friend WithEvents lblDescMantenimiento As Label
    Friend WithEvents pnlCardActividad As Panel
    Friend WithEvents lblCardActividad As Label
    Friend WithEvents lblDescActividad As Label
    Friend WithEvents pnlCardRegistrarSolicitud As Panel
    Friend WithEvents lblCardRegistrarSolicitud As Label
    Friend WithEvents lblDescRegistrarSolicitud As Label
    Friend WithEvents pnlCardMisSolicitudes As Panel
    Friend WithEvents lblCardMisSolicitudes As Label
    Friend WithEvents lblDescMisSolicitudes As Label
    Friend WithEvents pnlCardFacturacion As Panel
    Friend WithEvents lblCardFacturacion As Label
    Friend WithEvents lblDescFacturacion As Label
End Class
