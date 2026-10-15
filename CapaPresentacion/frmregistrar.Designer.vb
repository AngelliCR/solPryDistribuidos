<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregistrar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmregistrar))
        Me.pnlMarca = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.pnlTarjeta = New System.Windows.Forms.Panel()
        Me.flpIniciarSesion = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblYaTiene = New System.Windows.Forms.Label()
        Me.lnkIniciarSesion = New System.Windows.Forms.LinkLabel()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.chkMostrar = New System.Windows.Forms.CheckBox()
        Me.txtconfirmar = New System.Windows.Forms.TextBox()
        Me.lblConfirmar = New System.Windows.Forms.Label()
        Me.txtcontrasena = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.pnlLineaAcceso = New System.Windows.Forms.Panel()
        Me.lblSecAcceso = New System.Windows.Forms.Label()
        Me.cbxarea = New System.Windows.Forms.ComboBox()
        Me.cbxtipo = New System.Windows.Forms.ComboBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.pnlLineaCargo = New System.Windows.Forms.Panel()
        Me.lblSecCargo = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtnumdni = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.pnlLineaPersonales = New System.Windows.Forms.Panel()
        Me.lblSecPersonales = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlMarca.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpIniciarSesion.SuspendLayout()
        Me.pnlTarjeta.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMarca
        '
        Me.pnlMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pnlMarca.Controls.Add(Me.lblCopyright)
        Me.pnlMarca.Controls.Add(Me.lblSistema)
        Me.pnlMarca.Controls.Add(Me.picLogo)
        Me.pnlMarca.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMarca.Location = New System.Drawing.Point(0, 0)
        Me.pnlMarca.Name = "pnlMarca"
        Me.pnlMarca.Size = New System.Drawing.Size(340, 640)
        Me.pnlMarca.TabIndex = 0
        '
        'lblCopyright
        '
        Me.lblCopyright.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblCopyright.Location = New System.Drawing.Point(0, 584)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Padding = New System.Windows.Forms.Padding(40, 0, 16, 12)
        Me.lblCopyright.Size = New System.Drawing.Size(340, 56)
        Me.lblCopyright.TabIndex = 2
        Me.lblCopyright.Text = "© 2026 - Grupo 2"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSistema
        '
        Me.lblSistema.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSistema.ForeColor = System.Drawing.Color.White
        Me.lblSistema.Location = New System.Drawing.Point(30, 396)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(280, 56)
        Me.lblSistema.TabIndex = 1
        Me.lblSistema.Text = "Sistema de Gestión de Maquinaria Agrícola"
        Me.lblSistema.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(40, 132)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(260, 256)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 3
        Me.picLogo.TabStop = False
        '
        'pnlTarjeta
        '
        Me.pnlTarjeta.BackColor = System.Drawing.Color.White
        Me.pnlTarjeta.Controls.Add(Me.flpIniciarSesion)
        Me.pnlTarjeta.Controls.Add(Me.btnregistrar)
        Me.pnlTarjeta.Controls.Add(Me.chkMostrar)
        Me.pnlTarjeta.Controls.Add(Me.txtconfirmar)
        Me.pnlTarjeta.Controls.Add(Me.lblConfirmar)
        Me.pnlTarjeta.Controls.Add(Me.txtcontrasena)
        Me.pnlTarjeta.Controls.Add(Me.lblContrasena)
        Me.pnlTarjeta.Controls.Add(Me.pnlLineaAcceso)
        Me.pnlTarjeta.Controls.Add(Me.lblSecAcceso)
        Me.pnlTarjeta.Controls.Add(Me.cbxarea)
        Me.pnlTarjeta.Controls.Add(Me.cbxtipo)
        Me.pnlTarjeta.Controls.Add(Me.lblArea)
        Me.pnlTarjeta.Controls.Add(Me.lblTipo)
        Me.pnlTarjeta.Controls.Add(Me.pnlLineaCargo)
        Me.pnlTarjeta.Controls.Add(Me.lblSecCargo)
        Me.pnlTarjeta.Controls.Add(Me.txtcorreo)
        Me.pnlTarjeta.Controls.Add(Me.lblCorreo)
        Me.pnlTarjeta.Controls.Add(Me.txtapellido)
        Me.pnlTarjeta.Controls.Add(Me.txtnombre)
        Me.pnlTarjeta.Controls.Add(Me.lblApellidos)
        Me.pnlTarjeta.Controls.Add(Me.lblNombres)
        Me.pnlTarjeta.Controls.Add(Me.txttelefono)
        Me.pnlTarjeta.Controls.Add(Me.txtnumdni)
        Me.pnlTarjeta.Controls.Add(Me.lblTelefono)
        Me.pnlTarjeta.Controls.Add(Me.lblDni)
        Me.pnlTarjeta.Controls.Add(Me.pnlLineaPersonales)
        Me.pnlTarjeta.Controls.Add(Me.lblSecPersonales)
        Me.pnlTarjeta.Controls.Add(Me.lblSubtitulo)
        Me.pnlTarjeta.Controls.Add(Me.lblTitulo)
        Me.pnlTarjeta.Location = New System.Drawing.Point(380, 40)
        Me.pnlTarjeta.Name = "pnlTarjeta"
        Me.pnlTarjeta.Size = New System.Drawing.Size(580, 560)
        Me.pnlTarjeta.TabIndex = 1
        '
        'flpIniciarSesion
        '
        Me.flpIniciarSesion.AutoSize = True
        Me.flpIniciarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpIniciarSesion.BackColor = System.Drawing.Color.White
        Me.flpIniciarSesion.Controls.Add(Me.lblYaTiene)
        Me.flpIniciarSesion.Controls.Add(Me.lnkIniciarSesion)
        Me.flpIniciarSesion.Location = New System.Drawing.Point(166, 517)
        Me.flpIniciarSesion.Name = "flpIniciarSesion"
        Me.flpIniciarSesion.Size = New System.Drawing.Size(248, 24)
        Me.flpIniciarSesion.TabIndex = 11
        Me.flpIniciarSesion.WrapContents = False
        '
        'lblYaTiene
        '
        Me.lblYaTiene.AutoSize = True
        Me.lblYaTiene.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYaTiene.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblYaTiene.Location = New System.Drawing.Point(0, 3)
        Me.lblYaTiene.Margin = New System.Windows.Forms.Padding(0, 3, 8, 0)
        Me.lblYaTiene.Name = "lblYaTiene"
        Me.lblYaTiene.Size = New System.Drawing.Size(145, 15)
        Me.lblYaTiene.TabIndex = 12
        Me.lblYaTiene.Text = "¿Ya tiene una cuenta?"
        '
        'lnkIniciarSesion
        '
        Me.lnkIniciarSesion.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lnkIniciarSesion.AutoSize = True
        Me.lnkIniciarSesion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkIniciarSesion.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkIniciarSesion.LinkColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lnkIniciarSesion.Location = New System.Drawing.Point(153, 3)
        Me.lnkIniciarSesion.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.lnkIniciarSesion.Name = "lnkIniciarSesion"
        Me.lnkIniciarSesion.Size = New System.Drawing.Size(91, 15)
        Me.lnkIniciarSesion.TabIndex = 11
        Me.lnkIniciarSesion.TabStop = True
        Me.lnkIniciarSesion.Text = "Iniciar sesión"
        Me.lnkIniciarSesion.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        '
        'btnregistrar
        '
        Me.btnregistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnregistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregistrar.FlatAppearance.BorderSize = 0
        Me.btnregistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnregistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregistrar.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregistrar.ForeColor = System.Drawing.Color.White
        Me.btnregistrar.Location = New System.Drawing.Point(30, 467)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(520, 42)
        Me.btnregistrar.TabIndex = 10
        Me.btnregistrar.Text = "Crear cuenta"
        Me.btnregistrar.UseVisualStyleBackColor = False
        '
        'chkMostrar
        '
        Me.chkMostrar.AutoSize = True
        Me.chkMostrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.chkMostrar.Location = New System.Drawing.Point(30, 440)
        Me.chkMostrar.Name = "chkMostrar"
        Me.chkMostrar.Size = New System.Drawing.Size(148, 19)
        Me.chkMostrar.TabIndex = 9
        Me.chkMostrar.Text = "Mostrar contraseñas"
        Me.chkMostrar.UseVisualStyleBackColor = True
        '
        'txtconfirmar
        '
        Me.txtconfirmar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtconfirmar.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmar.Location = New System.Drawing.Point(300, 404)
        Me.txtconfirmar.MinimumSize = New System.Drawing.Size(250, 30)
        Me.txtconfirmar.Name = "txtconfirmar"
        Me.txtconfirmar.Size = New System.Drawing.Size(250, 30)
        Me.txtconfirmar.TabIndex = 8
        Me.txtconfirmar.UseSystemPasswordChar = True
        '
        'lblConfirmar
        '
        Me.lblConfirmar.AutoSize = True
        Me.lblConfirmar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblConfirmar.Location = New System.Drawing.Point(300, 385)
        Me.lblConfirmar.Name = "lblConfirmar"
        Me.lblConfirmar.Size = New System.Drawing.Size(128, 15)
        Me.lblConfirmar.TabIndex = 28
        Me.lblConfirmar.Text = "Confirmar contraseña"
        '
        'txtcontrasena
        '
        Me.txtcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcontrasena.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontrasena.Location = New System.Drawing.Point(30, 404)
        Me.txtcontrasena.MinimumSize = New System.Drawing.Size(250, 30)
        Me.txtcontrasena.Name = "txtcontrasena"
        Me.txtcontrasena.Size = New System.Drawing.Size(250, 30)
        Me.txtcontrasena.TabIndex = 7
        Me.txtcontrasena.UseSystemPasswordChar = True
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblContrasena.Location = New System.Drawing.Point(30, 385)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(69, 15)
        Me.lblContrasena.TabIndex = 27
        Me.lblContrasena.Text = "Contraseña"
        '
        'pnlLineaAcceso
        '
        Me.pnlLineaAcceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlLineaAcceso.Location = New System.Drawing.Point(30, 378)
        Me.pnlLineaAcceso.Name = "pnlLineaAcceso"
        Me.pnlLineaAcceso.Size = New System.Drawing.Size(520, 1)
        Me.pnlLineaAcceso.TabIndex = 26
        '
        'lblSecAcceso
        '
        Me.lblSecAcceso.AutoSize = True
        Me.lblSecAcceso.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecAcceso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSecAcceso.Location = New System.Drawing.Point(30, 357)
        Me.lblSecAcceso.Name = "lblSecAcceso"
        Me.lblSecAcceso.Size = New System.Drawing.Size(128, 19)
        Me.lblSecAcceso.TabIndex = 25
        Me.lblSecAcceso.Text = "Acceso al sistema"
        '
        'cbxarea
        '
        Me.cbxarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxarea.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxarea.FormattingEnabled = True
        Me.cbxarea.Items.AddRange(New Object() {"Campo", "Fábrica", "Logística", "Mantenimiento", "Administración", "Recursos humanos", "Sistemas"})
        Me.cbxarea.Location = New System.Drawing.Point(300, 319)
        Me.cbxarea.Name = "cbxarea"
        Me.cbxarea.Size = New System.Drawing.Size(250, 30)
        Me.cbxarea.TabIndex = 6
        '
        'cbxtipo
        '
        Me.cbxtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxtipo.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxtipo.FormattingEnabled = True
        Me.cbxtipo.Items.AddRange(New Object() {"Operario", "Supervisor", "Administrador"})
        Me.cbxtipo.Location = New System.Drawing.Point(30, 319)
        Me.cbxtipo.Name = "cbxtipo"
        Me.cbxtipo.Size = New System.Drawing.Size(250, 30)
        Me.cbxtipo.TabIndex = 5
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblArea.Location = New System.Drawing.Point(300, 300)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(32, 15)
        Me.lblArea.TabIndex = 24
        Me.lblArea.Text = "Área"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblTipo.Location = New System.Drawing.Point(30, 300)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(96, 15)
        Me.lblTipo.TabIndex = 23
        Me.lblTipo.Text = "Tipo de usuario"
        '
        'pnlLineaCargo
        '
        Me.pnlLineaCargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlLineaCargo.Location = New System.Drawing.Point(30, 293)
        Me.pnlLineaCargo.Name = "pnlLineaCargo"
        Me.pnlLineaCargo.Size = New System.Drawing.Size(520, 1)
        Me.pnlLineaCargo.TabIndex = 22
        '
        'lblSecCargo
        '
        Me.lblSecCargo.AutoSize = True
        Me.lblSecCargo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecCargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSecCargo.Location = New System.Drawing.Point(30, 272)
        Me.lblSecCargo.Name = "lblSecCargo"
        Me.lblSecCargo.Size = New System.Drawing.Size(92, 19)
        Me.lblSecCargo.TabIndex = 21
        Me.lblSecCargo.Text = "Cargo y área"
        '
        'txtcorreo
        '
        Me.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcorreo.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcorreo.Location = New System.Drawing.Point(30, 234)
        Me.txtcorreo.MinimumSize = New System.Drawing.Size(520, 30)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(520, 30)
        Me.txtcorreo.TabIndex = 4
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblCorreo.Location = New System.Drawing.Point(30, 215)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(111, 15)
        Me.lblCorreo.TabIndex = 20
        Me.lblCorreo.Text = "Correo electrónico"
        '
        'txtapellido
        '
        Me.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtapellido.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(300, 179)
        Me.txtapellido.MinimumSize = New System.Drawing.Size(250, 30)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(250, 30)
        Me.txtapellido.TabIndex = 3
        '
        'txtnombre
        '
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombre.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(30, 179)
        Me.txtnombre.MinimumSize = New System.Drawing.Size(250, 30)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(250, 30)
        Me.txtnombre.TabIndex = 2
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblApellidos.Location = New System.Drawing.Point(300, 160)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(58, 15)
        Me.lblApellidos.TabIndex = 19
        Me.lblApellidos.Text = "Apellidos"
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblNombres.Location = New System.Drawing.Point(30, 160)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(55, 15)
        Me.lblNombres.TabIndex = 18
        Me.lblNombres.Text = "Nombres"
        '
        'txttelefono
        '
        Me.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttelefono.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(300, 124)
        Me.txttelefono.MaxLength = 9
        Me.txttelefono.MinimumSize = New System.Drawing.Size(250, 30)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(250, 30)
        Me.txttelefono.TabIndex = 1
        '
        'txtnumdni
        '
        Me.txtnumdni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumdni.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumdni.Location = New System.Drawing.Point(30, 124)
        Me.txtnumdni.MaxLength = 8
        Me.txtnumdni.MinimumSize = New System.Drawing.Size(250, 30)
        Me.txtnumdni.Name = "txtnumdni"
        Me.txtnumdni.Size = New System.Drawing.Size(250, 30)
        Me.txtnumdni.TabIndex = 0
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblTelefono.Location = New System.Drawing.Point(300, 105)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(55, 15)
        Me.lblTelefono.TabIndex = 17
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDni.Location = New System.Drawing.Point(30, 105)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(28, 15)
        Me.lblDni.TabIndex = 16
        Me.lblDni.Text = "DNI"
        '
        'pnlLineaPersonales
        '
        Me.pnlLineaPersonales.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlLineaPersonales.Location = New System.Drawing.Point(30, 98)
        Me.pnlLineaPersonales.Name = "pnlLineaPersonales"
        Me.pnlLineaPersonales.Size = New System.Drawing.Size(520, 1)
        Me.pnlLineaPersonales.TabIndex = 15
        '
        'lblSecPersonales
        '
        Me.lblSecPersonales.AutoSize = True
        Me.lblSecPersonales.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecPersonales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSecPersonales.Location = New System.Drawing.Point(30, 77)
        Me.lblSecPersonales.Name = "lblSecPersonales"
        Me.lblSecPersonales.Size = New System.Drawing.Size(118, 19)
        Me.lblSecPersonales.TabIndex = 14
        Me.lblSecPersonales.Text = "Datos personales"
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.AutoSize = True
        Me.lblSubtitulo.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblSubtitulo.Location = New System.Drawing.Point(30, 52)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(310, 17)
        Me.lblSubtitulo.TabIndex = 13
        Me.lblSubtitulo.Text = "Complete sus datos para registrarse en el sistema"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(30, 16)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(139, 32)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Crear cuenta"
        '
        'frmregistrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 640)
        Me.Controls.Add(Me.pnlMarca)
        Me.Controls.Add(Me.pnlTarjeta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmregistrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pomalca - Crear cuenta"
        Me.pnlMarca.ResumeLayout(False)
        Me.pnlMarca.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpIniciarSesion.ResumeLayout(False)
        Me.flpIniciarSesion.PerformLayout()
        Me.pnlTarjeta.ResumeLayout(False)
        Me.pnlTarjeta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlMarca As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblSistema As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents pnlTarjeta As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents lblSecPersonales As Label
    Friend WithEvents pnlLineaPersonales As Panel
    Friend WithEvents lblDni As Label
    Friend WithEvents txtnumdni As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents lblNombres As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents lblSecCargo As Label
    Friend WithEvents pnlLineaCargo As Panel
    Friend WithEvents lblTipo As Label
    Friend WithEvents cbxtipo As ComboBox
    Friend WithEvents lblArea As Label
    Friend WithEvents cbxarea As ComboBox
    Friend WithEvents lblSecAcceso As Label
    Friend WithEvents pnlLineaAcceso As Panel
    Friend WithEvents lblContrasena As Label
    Friend WithEvents txtcontrasena As TextBox
    Friend WithEvents lblConfirmar As Label
    Friend WithEvents txtconfirmar As TextBox
    Friend WithEvents chkMostrar As CheckBox
    Friend WithEvents btnregistrar As Button
    Friend WithEvents flpIniciarSesion As FlowLayoutPanel
    Friend WithEvents lblYaTiene As Label
    Friend WithEvents lnkIniciarSesion As LinkLabel
End Class
