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
        Me.pnlMarca = New System.Windows.Forms.Panel()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.lblPomalca = New System.Windows.Forms.Label()
        Me.pnlTarjeta = New System.Windows.Forms.Panel()
        Me.flpRegistro = New System.Windows.Forms.FlowLayoutPanel()
        Me.lnkRegistro = New System.Windows.Forms.LinkLabel()
        Me.lblNuevo = New System.Windows.Forms.Label()
        Me.btninicio = New System.Windows.Forms.Button()
        Me.chkMostrar = New System.Windows.Forms.CheckBox()
        Me.txtcontrasena = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlMarca.SuspendLayout()
        Me.flpRegistro.SuspendLayout()
        Me.pnlTarjeta.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMarca
        '
        Me.pnlMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.pnlMarca.Controls.Add(Me.lblCopyright)
        Me.pnlMarca.Controls.Add(Me.lblSistema)
        Me.pnlMarca.Controls.Add(Me.lblPomalca)
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
        Me.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(235, Byte), Integer))
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
        Me.lblSistema.Location = New System.Drawing.Point(40, 242)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(300, 56)
        Me.lblSistema.TabIndex = 1
        Me.lblSistema.Text = "Sistema de Gestión de Maquinaria Agrícola"
        '
        'lblPomalca
        '
        Me.lblPomalca.AutoSize = True
        Me.lblPomalca.Font = New System.Drawing.Font("Segoe UI Semibold", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPomalca.ForeColor = System.Drawing.Color.White
        Me.lblPomalca.Location = New System.Drawing.Point(40, 188)
        Me.lblPomalca.Name = "lblPomalca"
        Me.lblPomalca.Size = New System.Drawing.Size(176, 47)
        Me.lblPomalca.TabIndex = 0
        Me.lblPomalca.Text = "POMALCA"
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
        Me.pnlTarjeta.Location = New System.Drawing.Point(450, 70)
        Me.pnlTarjeta.Name = "pnlTarjeta"
        Me.pnlTarjeta.Size = New System.Drawing.Size(380, 420)
        Me.pnlTarjeta.TabIndex = 1
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
        Me.flpRegistro.Size = New System.Drawing.Size(280, 24)
        Me.flpRegistro.TabIndex = 9
        Me.flpRegistro.WrapContents = False
        '
        'lnkRegistro
        '
        Me.lnkRegistro.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lnkRegistro.AutoSize = True
        Me.lnkRegistro.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkRegistro.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkRegistro.LinkColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.lnkRegistro.Location = New System.Drawing.Point(166, 3)
        Me.lnkRegistro.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.lnkRegistro.Name = "lnkRegistro"
        Me.lnkRegistro.Size = New System.Drawing.Size(99, 15)
        Me.lnkRegistro.TabIndex = 4
        Me.lnkRegistro.TabStop = True
        Me.lnkRegistro.Text = "Regístrese aquí"
        Me.lnkRegistro.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'lblNuevo
        '
        Me.lblNuevo.AutoSize = True
        Me.lblNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblNuevo.Location = New System.Drawing.Point(0, 3)
        Me.lblNuevo.Margin = New System.Windows.Forms.Padding(0, 3, 8, 0)
        Me.lblNuevo.Name = "lblNuevo"
        Me.lblNuevo.Size = New System.Drawing.Size(158, 15)
        Me.lblNuevo.TabIndex = 8
        Me.lblNuevo.Text = "¿Es nuevo en el sistema?"
        '
        'btninicio
        '
        Me.btninicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btninicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninicio.FlatAppearance.BorderSize = 0
        Me.btninicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btninicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer))
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
        Me.chkMostrar.Size = New System.Drawing.Size(139, 19)
        Me.chkMostrar.TabIndex = 2
        Me.chkMostrar.Text = "Mostrar contraseña"
        Me.chkMostrar.UseVisualStyleBackColor = True
        '
        'txtcontrasena
        '
        Me.txtcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcontrasena.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontrasena.Location = New System.Drawing.Point(32, 206)
        Me.txtcontrasena.MinimumSize = New System.Drawing.Size(316, 30)
        Me.txtcontrasena.Name = "txtcontrasena"
        Me.txtcontrasena.Size = New System.Drawing.Size(316, 32)
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
        Me.lblContrasena.Size = New System.Drawing.Size(69, 15)
        Me.lblContrasena.TabIndex = 7
        Me.lblContrasena.Text = "Contraseña"
        '
        'txtdni
        '
        Me.txtdni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdni.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdni.Location = New System.Drawing.Point(32, 140)
        Me.txtdni.MaxLength = 8
        Me.txtdni.MinimumSize = New System.Drawing.Size(316, 30)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(316, 32)
        Me.txtdni.TabIndex = 0
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDni.Location = New System.Drawing.Point(32, 118)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(88, 15)
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
        Me.lblSubtitulo.Size = New System.Drawing.Size(230, 17)
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
        Me.lblTitulo.Size = New System.Drawing.Size(196, 32)
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
        Me.Controls.Add(Me.pnlTarjeta)
        Me.ControlBox = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pomalca - Iniciar sesión"
        Me.pnlMarca.ResumeLayout(False)
        Me.pnlMarca.PerformLayout()
        Me.flpRegistro.ResumeLayout(False)
        Me.flpRegistro.PerformLayout()
        Me.pnlTarjeta.ResumeLayout(False)
        Me.pnlTarjeta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlMarca As Panel
    Friend WithEvents lblPomalca As Label
    Friend WithEvents lblSistema As Label
    Friend WithEvents lblCopyright As Label
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
