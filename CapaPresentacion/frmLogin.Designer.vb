<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.pnlMarca = New System.Windows.Forms.Panel()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.pnlTarjeta = New System.Windows.Forms.Panel()
        Me.pnlBordeTarjeta = New System.Windows.Forms.Panel()
        Me.flpRegistro = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblNuevo = New System.Windows.Forms.Label()
        Me.lnkRegistro = New System.Windows.Forms.LinkLabel()
        Me.btninicio = New System.Windows.Forms.Button()
        Me.chkMostrar = New System.Windows.Forms.CheckBox()
        Me.txtcontrasena = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlMarca.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBordeTarjeta.SuspendLayout()
        Me.pnlTarjeta.SuspendLayout()
        Me.flpRegistro.SuspendLayout()
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
        Me.pnlMarca.Size = New System.Drawing.Size(380, 560)
        Me.pnlMarca.TabIndex = 0
        '
        'lblCopyright
        '
        Me.lblCopyright.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblCopyright.Location = New System.Drawing.Point(0, 504)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Padding = New System.Windows.Forms.Padding(40, 0, 16, 12)
        Me.lblCopyright.Size = New System.Drawing.Size(380, 56)
        Me.lblCopyright.TabIndex = 2
        Me.lblCopyright.Text = "© 2026 - Grupo 2"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSistema
        '
        Me.lblSistema.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSistema.ForeColor = System.Drawing.Color.White
        Me.lblSistema.Location = New System.Drawing.Point(40, 376)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(300, 56)
        Me.lblSistema.TabIndex = 1
        Me.lblSistema.Text = "Sistema de Gestión de Maquinaria Agrícola"
        Me.lblSistema.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(40, 72)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(300, 296)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 3
        Me.picLogo.TabStop = False
        '
        'pnlBordeTarjeta
        '
        Me.pnlBordeTarjeta.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlBordeTarjeta.Controls.Add(Me.pnlTarjeta)
        Me.pnlBordeTarjeta.Location = New System.Drawing.Point(450, 70)
        Me.pnlBordeTarjeta.Name = "pnlBordeTarjeta"
        Me.pnlBordeTarjeta.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.pnlBordeTarjeta.Size = New System.Drawing.Size(380, 420)
        Me.pnlBordeTarjeta.TabIndex = 1
        '
        'pnlTarjeta
        '
        Me.pnlTarjeta.BackColor = System.Drawing.Color.White
        Me.pnlTarjeta.Controls.Add(Me.flpRegistro)
        Me.pnlTarjeta.Controls.Add(Me.btninicio)
        Me.pnlTarjeta.Controls.Add(Me.chkMostrar)
        Me.pnlTarjeta.Controls.Add(Me.txtcontrasena)
        Me.pnlTarjeta.Controls.Add(Me.lblContrasena)
        Me.pnlTarjeta.Controls.Add(Me.txtdni)
        Me.pnlTarjeta.Controls.Add(Me.lblDni)
        Me.pnlTarjeta.Controls.Add(Me.lblSubtitulo)
        Me.pnlTarjeta.Controls.Add(Me.lblTitulo)
        Me.pnlTarjeta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTarjeta.Location = New System.Drawing.Point(1, 1)
        Me.pnlTarjeta.Name = "pnlTarjeta"
        Me.pnlTarjeta.Size = New System.Drawing.Size(378, 418)
        Me.pnlTarjeta.TabIndex = 0
        '
        'flpRegistro
        '
        Me.flpRegistro.AutoSize = True
        Me.flpRegistro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpRegistro.BackColor = System.Drawing.Color.White
        Me.flpRegistro.Controls.Add(Me.lblNuevo)
        Me.flpRegistro.Controls.Add(Me.lnkRegistro)
        Me.flpRegistro.Location = New System.Drawing.Point(32, 346)
        Me.flpRegistro.Name = "flpRegistro"
        Me.flpRegistro.Size = New System.Drawing.Size(291, 23)
        Me.flpRegistro.TabIndex = 9
        Me.flpRegistro.WrapContents = False
        '
        'lblNuevo
        '
        Me.lblNuevo.AutoSize = True
        Me.lblNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblNuevo.Location = New System.Drawing.Point(0, 3)
        Me.lblNuevo.Margin = New System.Windows.Forms.Padding(0, 3, 8, 0)
        Me.lblNuevo.Name = "lblNuevo"
        Me.lblNuevo.Size = New System.Drawing.Size(171, 20)
        Me.lblNuevo.TabIndex = 8
        Me.lblNuevo.Text = "¿Es nuevo en el sistema?"
        '
        'lnkRegistro
        '
        Me.lnkRegistro.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lnkRegistro.AutoSize = True
        Me.lnkRegistro.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkRegistro.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkRegistro.LinkColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lnkRegistro.Location = New System.Drawing.Point(179, 3)
        Me.lnkRegistro.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.lnkRegistro.Name = "lnkRegistro"
        Me.lnkRegistro.Size = New System.Drawing.Size(112, 20)
        Me.lnkRegistro.TabIndex = 4
        Me.lnkRegistro.TabStop = True
        Me.lnkRegistro.Text = "Regístrese aquí"
        Me.lnkRegistro.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        '
        'btninicio
        '
        Me.btninicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btninicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninicio.FlatAppearance.BorderSize = 0
        Me.btninicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btninicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btninicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninicio.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninicio.ForeColor = System.Drawing.Color.White
        Me.btninicio.Location = New System.Drawing.Point(32, 286)
        Me.btninicio.Name = "btninicio"
        Me.btninicio.Size = New System.Drawing.Size(316, 42)
        Me.btninicio.TabIndex = 3
        Me.btninicio.Text = "Iniciar sesión"
        Me.btninicio.UseVisualStyleBackColor = False
        '
        'chkMostrar
        '
        Me.chkMostrar.AutoSize = True
        Me.chkMostrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.chkMostrar.Location = New System.Drawing.Point(32, 248)
        Me.chkMostrar.Name = "chkMostrar"
        Me.chkMostrar.Size = New System.Drawing.Size(158, 24)
        Me.chkMostrar.TabIndex = 2
        Me.chkMostrar.Text = "Mostrar contraseña"
        Me.chkMostrar.UseVisualStyleBackColor = True
        '
        'txtcontrasena
        '
        Me.txtcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcontrasena.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontrasena.Location = New System.Drawing.Point(32, 206)
        Me.txtcontrasena.MinimumSize = New System.Drawing.Size(316, 30)
        Me.txtcontrasena.Name = "txtcontrasena"
        Me.txtcontrasena.Size = New System.Drawing.Size(316, 30)
        Me.txtcontrasena.TabIndex = 1
        Me.txtcontrasena.UseSystemPasswordChar = True
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblContrasena.Location = New System.Drawing.Point(32, 184)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(83, 20)
        Me.lblContrasena.TabIndex = 7
        Me.lblContrasena.Text = "Contraseña"
        '
        'txtdni
        '
        Me.txtdni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdni.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdni.Location = New System.Drawing.Point(32, 140)
        Me.txtdni.MaxLength = 8
        Me.txtdni.MinimumSize = New System.Drawing.Size(316, 30)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(316, 30)
        Me.txtdni.TabIndex = 0
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDni.Location = New System.Drawing.Point(32, 118)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(114, 20)
        Me.lblDni.TabIndex = 6
        Me.lblDni.Text = "Número de DNI"
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.AutoSize = True
        Me.lblSubtitulo.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblSubtitulo.Location = New System.Drawing.Point(32, 74)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(282, 21)
        Me.lblSubtitulo.TabIndex = 5
        Me.lblSubtitulo.Text = "Ingrese sus credenciales para continuar"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(32, 36)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(267, 41)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Portal de Personal"
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btninicio
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 560)
        Me.Controls.Add(Me.pnlMarca)
        Me.Controls.Add(Me.pnlBordeTarjeta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pomalca - Iniciar sesión"
        Me.pnlMarca.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTarjeta.ResumeLayout(False)
        Me.pnlTarjeta.PerformLayout()
        Me.pnlBordeTarjeta.ResumeLayout(False)
        Me.flpRegistro.ResumeLayout(False)
        Me.flpRegistro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMarca As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblSistema As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents pnlBordeTarjeta As Panel
    Friend WithEvents pnlTarjeta As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents txtdni As TextBox
    Friend WithEvents lblContrasena As Label
    Friend WithEvents txtcontrasena As TextBox
    Friend WithEvents chkMostrar As CheckBox
    Friend WithEvents btninicio As Button
    Friend WithEvents flpRegistro As FlowLayoutPanel
    Friend WithEvents lblNuevo As Label
    Friend WithEvents lnkRegistro As LinkLabel
End Class
