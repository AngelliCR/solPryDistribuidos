<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonal
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.txtnombres = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.txtcontrasena = New System.Windows.Forms.TextBox()
        Me.lblPista = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cbxtipo = New System.Windows.Forms.ComboBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.cbxarea = New System.Windows.Forms.ComboBox()
        Me.lblEstadoTitulo = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.pnlFormulario = New System.Windows.Forms.Panel()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.lblFiltroRol = New System.Windows.Forms.Label()
        Me.cbxFiltroRol = New System.Windows.Forms.ComboBox()
        Me.lblFiltroEstado = New System.Windows.Forms.Label()
        Me.cbxFiltroEstado = New System.Windows.Forms.ComboBox()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.dgvPersonal = New System.Windows.Forms.DataGridView()
        Me.id_personal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlFormulario.SuspendLayout()
        Me.pnlFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(980, 36)
        Me.lblTitulo.Text = "Gestión de usuarios"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSubtitulo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblSubtitulo.Location = New System.Drawing.Point(0, 36)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(980, 28)
        Me.lblSubtitulo.Text = "Registre y administre el personal del sistema"
        Me.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDni
        '
        Me.lblDni.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDni.Location = New System.Drawing.Point(16, 12)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(180, 18)
        Me.lblDni.Text = "DNI"
        '
        'txtdni
        '
        Me.txtdni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdni.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdni.Location = New System.Drawing.Point(16, 32)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(200, 28)
        Me.txtdni.MaxLength = 8
        '
        'lblNombres
        '
        Me.lblNombres.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblNombres.Location = New System.Drawing.Point(236, 12)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(200, 18)
        Me.lblNombres.Text = "Nombres"
        '
        'txtnombres
        '
        Me.txtnombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombres.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombres.Location = New System.Drawing.Point(236, 32)
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(220, 28)
        '
        'lblApellidos
        '
        Me.lblApellidos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblApellidos.Location = New System.Drawing.Point(476, 12)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(200, 18)
        Me.lblApellidos.Text = "Apellidos"
        '
        'txtapellidos
        '
        Me.txtapellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtapellidos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellidos.Location = New System.Drawing.Point(476, 32)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(180, 28)
        '
        'lblTelefono
        '
        Me.lblTelefono.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblTelefono.Location = New System.Drawing.Point(16, 72)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(180, 18)
        Me.lblTelefono.Text = "Teléfono"
        '
        'txttelefono
        '
        Me.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttelefono.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(16, 92)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(200, 28)
        Me.txttelefono.MaxLength = 9
        '
        'lblCorreo
        '
        Me.lblCorreo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblCorreo.Location = New System.Drawing.Point(236, 72)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(200, 18)
        Me.lblCorreo.Text = "Correo"
        '
        'txtcorreo
        '
        Me.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcorreo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcorreo.Location = New System.Drawing.Point(236, 92)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(220, 28)
        '
        'lblContrasena
        '
        Me.lblContrasena.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblContrasena.Location = New System.Drawing.Point(476, 72)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(200, 18)
        Me.lblContrasena.Text = "Contraseña"
        '
        'txtcontrasena
        '
        Me.txtcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcontrasena.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontrasena.Location = New System.Drawing.Point(476, 92)
        Me.txtcontrasena.Name = "txtcontrasena"
        Me.txtcontrasena.Size = New System.Drawing.Size(180, 28)
        Me.txtcontrasena.UseSystemPasswordChar = True
        '
        'lblPista
        '
        Me.lblPista.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPista.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblPista.Location = New System.Drawing.Point(16, 188)
        Me.lblPista.Name = "lblPista"
        Me.lblPista.Size = New System.Drawing.Size(620, 18)
        Me.lblPista.Text = "Si deja la contraseña vacía, se conserva la actual."
        '
        'lblTipo
        '
        Me.lblTipo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblTipo.Location = New System.Drawing.Point(16, 132)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(180, 18)
        Me.lblTipo.Text = "Tipo de usuario"
        '
        'cbxtipo
        '
        Me.cbxtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxtipo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxtipo.FormattingEnabled = True
        Me.cbxtipo.Items.AddRange(New Object() {"Operario", "Supervisor", "Administrador"})
        Me.cbxtipo.Location = New System.Drawing.Point(16, 152)
        Me.cbxtipo.Name = "cbxtipo"
        Me.cbxtipo.Size = New System.Drawing.Size(200, 28)
        '
        'lblArea
        '
        Me.lblArea.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblArea.Location = New System.Drawing.Point(236, 132)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(200, 18)
        Me.lblArea.Text = "Área"
        '
        'cbxarea
        '
        Me.cbxarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxarea.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxarea.FormattingEnabled = True
        Me.cbxarea.Items.AddRange(New Object() {"Campo", "Fábrica", "Logística", "Mantenimiento", "Administración", "Recursos humanos", "Sistemas"})
        Me.cbxarea.Location = New System.Drawing.Point(236, 152)
        Me.cbxarea.Name = "cbxarea"
        Me.cbxarea.Size = New System.Drawing.Size(220, 28)
        '
        'lblEstadoTitulo
        '
        Me.lblEstadoTitulo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblEstadoTitulo.Location = New System.Drawing.Point(476, 132)
        Me.lblEstadoTitulo.Name = "lblEstadoTitulo"
        Me.lblEstadoTitulo.Size = New System.Drawing.Size(180, 18)
        Me.lblEstadoTitulo.Text = "Estado"
        '
        'lblEstado
        '
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblEstado.Location = New System.Drawing.Point(476, 156)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(200, 24)
        Me.lblEstado.Text = "Nuevo"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.FlatAppearance.BorderSize = 0
        Me.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(16, 214)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(120, 36)
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(144, 214)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(120, 36)
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnBaja
        '
        Me.btnBaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnBaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBaja.FlatAppearance.BorderSize = 0
        Me.btnBaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnBaja.ForeColor = System.Drawing.Color.White
        Me.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaja.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaja.Location = New System.Drawing.Point(272, 214)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(150, 36)
        Me.btnBaja.Text = "Dar de baja"
        Me.btnBaja.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(430, 214)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(110, 36)
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.White
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.FlatAppearance.BorderSize = 1
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(548, 214)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'pnlFormulario
        '
        Me.pnlFormulario.BackColor = System.Drawing.Color.White
        Me.pnlFormulario.Controls.Add(Me.lblDni)
        Me.pnlFormulario.Controls.Add(Me.txtdni)
        Me.pnlFormulario.Controls.Add(Me.lblNombres)
        Me.pnlFormulario.Controls.Add(Me.txtnombres)
        Me.pnlFormulario.Controls.Add(Me.lblApellidos)
        Me.pnlFormulario.Controls.Add(Me.txtapellidos)
        Me.pnlFormulario.Controls.Add(Me.lblTelefono)
        Me.pnlFormulario.Controls.Add(Me.txttelefono)
        Me.pnlFormulario.Controls.Add(Me.lblCorreo)
        Me.pnlFormulario.Controls.Add(Me.txtcorreo)
        Me.pnlFormulario.Controls.Add(Me.lblContrasena)
        Me.pnlFormulario.Controls.Add(Me.txtcontrasena)
        Me.pnlFormulario.Controls.Add(Me.lblPista)
        Me.pnlFormulario.Controls.Add(Me.lblTipo)
        Me.pnlFormulario.Controls.Add(Me.cbxtipo)
        Me.pnlFormulario.Controls.Add(Me.lblArea)
        Me.pnlFormulario.Controls.Add(Me.cbxarea)
        Me.pnlFormulario.Controls.Add(Me.lblEstadoTitulo)
        Me.pnlFormulario.Controls.Add(Me.lblEstado)
        Me.pnlFormulario.Controls.Add(Me.btnRegistrar)
        Me.pnlFormulario.Controls.Add(Me.btnActualizar)
        Me.pnlFormulario.Controls.Add(Me.btnBaja)
        Me.pnlFormulario.Controls.Add(Me.btnEliminar)
        Me.pnlFormulario.Controls.Add(Me.btnLimpiar)
        Me.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFormulario.Location = New System.Drawing.Point(0, 0)
        Me.pnlFormulario.Name = "pnlFormulario"
        Me.pnlFormulario.Size = New System.Drawing.Size(980, 268)
        '
        'lblBuscar
        '
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblBuscar.Location = New System.Drawing.Point(16, 16)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(50, 18)
        Me.lblBuscar.Text = "Buscar"
        '
        'txtbuscar
        '
        Me.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.Location = New System.Drawing.Point(72, 12)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(240, 28)
        '
        'lblFiltroRol
        '
        Me.lblFiltroRol.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltroRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblFiltroRol.Location = New System.Drawing.Point(330, 16)
        Me.lblFiltroRol.Name = "lblFiltroRol"
        Me.lblFiltroRol.Size = New System.Drawing.Size(30, 18)
        Me.lblFiltroRol.Text = "Rol"
        '
        'cbxFiltroRol
        '
        Me.cbxFiltroRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFiltroRol.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFiltroRol.FormattingEnabled = True
        Me.cbxFiltroRol.Items.AddRange(New Object() {"Todos", "Operario", "Supervisor", "Administrador"})
        Me.cbxFiltroRol.Location = New System.Drawing.Point(364, 12)
        Me.cbxFiltroRol.Name = "cbxFiltroRol"
        Me.cbxFiltroRol.Size = New System.Drawing.Size(140, 28)
        '
        'lblFiltroEstado
        '
        Me.lblFiltroEstado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltroEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblFiltroEstado.Location = New System.Drawing.Point(516, 16)
        Me.lblFiltroEstado.Name = "lblFiltroEstado"
        Me.lblFiltroEstado.Size = New System.Drawing.Size(50, 18)
        Me.lblFiltroEstado.Text = "Estado"
        '
        'cbxFiltroEstado
        '
        Me.cbxFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFiltroEstado.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFiltroEstado.FormattingEnabled = True
        Me.cbxFiltroEstado.Items.AddRange(New Object() {"Todos", "Activo", "Inactivo"})
        Me.cbxFiltroEstado.Location = New System.Drawing.Point(570, 12)
        Me.cbxFiltroEstado.Name = "cbxFiltroEstado"
        Me.cbxFiltroEstado.Size = New System.Drawing.Size(110, 28)
        '
        'pnlFiltros
        '
        Me.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnlFiltros.Controls.Add(Me.lblBuscar)
        Me.pnlFiltros.Controls.Add(Me.txtbuscar)
        Me.pnlFiltros.Controls.Add(Me.lblFiltroRol)
        Me.pnlFiltros.Controls.Add(Me.cbxFiltroRol)
        Me.pnlFiltros.Controls.Add(Me.lblFiltroEstado)
        Me.pnlFiltros.Controls.Add(Me.cbxFiltroEstado)
        Me.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltros.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New System.Drawing.Size(980, 52)
        '
        CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'dgvPersonal
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvPersonal.AllowUserToAddRows = False
        Me.dgvPersonal.AllowUserToDeleteRows = False
        Me.dgvPersonal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPersonal.BackgroundColor = System.Drawing.Color.White
        Me.dgvPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPersonal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPersonal.ColumnHeadersHeight = 36
        Me.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPersonal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_personal, Me.dni, Me.nombres, Me.apellidos, Me.telefono, Me.correo, Me.tipo_usuario, Me.area, Me.fecha_ingreso, Me.estado})
        Me.dgvPersonal.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPersonal.EnableHeadersVisualStyles = False
        Me.dgvPersonal.GridColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvPersonal.Location = New System.Drawing.Point(0, 0)
        Me.dgvPersonal.MultiSelect = False
        Me.dgvPersonal.Name = "dgvPersonal"
        Me.dgvPersonal.ReadOnly = True
        Me.dgvPersonal.RowHeadersVisible = False
        Me.dgvPersonal.RowTemplate.Height = 30
        Me.dgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPersonal.Size = New System.Drawing.Size(980, 200)
        '
        'id_personal
        '
        Me.id_personal.DataPropertyName = "id_personal"
        Me.id_personal.HeaderText = "id_personal"
        Me.id_personal.Name = "id_personal"
        Me.id_personal.Visible = False
        '
        'dni
        '
        Me.dni.DataPropertyName = "dni"
        Me.dni.HeaderText = "DNI"
        Me.dni.Name = "dni"
        '
        'nombres
        '
        Me.nombres.DataPropertyName = "nombres"
        Me.nombres.HeaderText = "Nombres"
        Me.nombres.Name = "nombres"
        '
        'apellidos
        '
        Me.apellidos.DataPropertyName = "apellidos"
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.Name = "apellidos"
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.Name = "telefono"
        '
        'correo
        '
        Me.correo.DataPropertyName = "correo"
        Me.correo.HeaderText = "Correo"
        Me.correo.Name = "correo"
        '
        'tipo_usuario
        '
        Me.tipo_usuario.DataPropertyName = "tipo_usuario"
        Me.tipo_usuario.HeaderText = "Tipo"
        Me.tipo_usuario.Name = "tipo_usuario"
        '
        'area
        '
        Me.area.DataPropertyName = "area"
        Me.area.HeaderText = "Área"
        Me.area.Name = "area"
        '
        'fecha_ingreso
        '
        Me.fecha_ingreso.DataPropertyName = "fecha_ingreso"
        Me.fecha_ingreso.DefaultCellStyle.Format = "dd/MM/yyyy"
        Me.fecha_ingreso.HeaderText = "Fecha de ingreso"
        Me.fecha_ingreso.Name = "fecha_ingreso"
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        '
        'frmPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 640)
        Me.Controls.Add(Me.dgvPersonal)
        Me.Controls.Add(Me.pnlFiltros)
        Me.Controls.Add(Me.pnlFormulario)
        Me.Controls.Add(Me.lblSubtitulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPersonal"
        Me.Text = "Gestión de usuarios"
        Me.pnlFiltros.ResumeLayout(False)
        Me.pnlFiltros.PerformLayout()
        Me.pnlFormulario.ResumeLayout(False)
        Me.pnlFormulario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents txtdni As TextBox
    Friend WithEvents lblNombres As Label
    Friend WithEvents txtnombres As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents lblContrasena As Label
    Friend WithEvents txtcontrasena As TextBox
    Friend WithEvents lblPista As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents cbxtipo As ComboBox
    Friend WithEvents lblArea As Label
    Friend WithEvents cbxarea As ComboBox
    Friend WithEvents lblEstadoTitulo As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents pnlFormulario As Panel
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents lblFiltroRol As Label
    Friend WithEvents cbxFiltroRol As ComboBox
    Friend WithEvents lblFiltroEstado As Label
    Friend WithEvents cbxFiltroEstado As ComboBox
    Friend WithEvents pnlFiltros As Panel
    Friend WithEvents dgvPersonal As DataGridView
    Friend WithEvents id_personal As DataGridViewTextBoxColumn
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents nombres As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents correo As DataGridViewTextBoxColumn
    Friend WithEvents tipo_usuario As DataGridViewTextBoxColumn
    Friend WithEvents area As DataGridViewTextBoxColumn
    Friend WithEvents fecha_ingreso As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
End Class
