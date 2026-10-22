<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaquinaria
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
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.cbxarea = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cbxestado = New System.Windows.Forms.ComboBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.pnlFormulario = New System.Windows.Forms.Panel()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.lblFiltroEstado = New System.Windows.Forms.Label()
        Me.cbxFiltroEstado = New System.Windows.Forms.ComboBox()
        Me.lblFiltroArea = New System.Windows.Forms.Label()
        Me.cbxFiltroArea = New System.Windows.Forms.ComboBox()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.dgvMaquinaria = New System.Windows.Forms.DataGridView()
        Me.id_maquinaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_registro = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.lblTitulo.Text = "Maquinaria"
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
        Me.lblSubtitulo.Text = "Registre y administre la maquinaria agrícola"
        Me.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigo
        '
        Me.lblCodigo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblCodigo.Location = New System.Drawing.Point(16, 12)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(180, 18)
        Me.lblCodigo.Text = "Código"
        '
        'txtcodigo
        '
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(16, 32)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(200, 28)
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        'lblTipo
        '
        Me.lblTipo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblTipo.Location = New System.Drawing.Point(236, 12)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(200, 18)
        Me.lblTipo.Text = "Tipo"
        '
        'txttipo
        '
        Me.txttipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttipo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipo.Location = New System.Drawing.Point(236, 32)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(220, 28)
        '
        'lblMarca
        '
        Me.lblMarca.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblMarca.Location = New System.Drawing.Point(476, 12)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(200, 18)
        Me.lblMarca.Text = "Marca"
        '
        'txtmarca
        '
        Me.txtmarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmarca.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmarca.Location = New System.Drawing.Point(476, 32)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(180, 28)
        '
        'lblModelo
        '
        Me.lblModelo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblModelo.Location = New System.Drawing.Point(16, 72)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(180, 18)
        Me.lblModelo.Text = "Modelo"
        '
        'txtmodelo
        '
        Me.txtmodelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmodelo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodelo.Location = New System.Drawing.Point(16, 92)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(200, 28)
        '
        'lblArea
        '
        Me.lblArea.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblArea.Location = New System.Drawing.Point(236, 72)
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
        Me.cbxarea.Location = New System.Drawing.Point(236, 92)
        Me.cbxarea.Name = "cbxarea"
        Me.cbxarea.Size = New System.Drawing.Size(220, 28)
        '
        'lblEstado
        '
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblEstado.Location = New System.Drawing.Point(476, 72)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(200, 18)
        Me.lblEstado.Text = "Estado"
        '
        'cbxestado
        '
        Me.cbxestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxestado.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxestado.FormattingEnabled = True
        Me.cbxestado.Items.AddRange(New Object() {"Operativo", "En Mantenimiento", "Sin Tarea", "Dado de Baja"})
        Me.cbxestado.Location = New System.Drawing.Point(476, 92)
        Me.cbxestado.Name = "cbxestado"
        Me.cbxestado.Size = New System.Drawing.Size(180, 28)
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblObservaciones.Location = New System.Drawing.Point(16, 132)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(200, 18)
        Me.lblObservaciones.Text = "Observaciones"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtobservaciones.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservaciones.Location = New System.Drawing.Point(16, 152)
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(620, 56)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
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
        Me.btnRegistrar.Location = New System.Drawing.Point(16, 220)
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
        Me.btnActualizar.Location = New System.Drawing.Point(144, 220)
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
        Me.btnBaja.Location = New System.Drawing.Point(272, 220)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(140, 36)
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
        Me.btnEliminar.Location = New System.Drawing.Point(420, 220)
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
        Me.btnLimpiar.Location = New System.Drawing.Point(538, 220)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'pnlFormulario
        '
        Me.pnlFormulario.BackColor = System.Drawing.Color.White
        Me.pnlFormulario.Controls.Add(Me.lblCodigo)
        Me.pnlFormulario.Controls.Add(Me.txtcodigo)
        Me.pnlFormulario.Controls.Add(Me.lblTipo)
        Me.pnlFormulario.Controls.Add(Me.txttipo)
        Me.pnlFormulario.Controls.Add(Me.lblMarca)
        Me.pnlFormulario.Controls.Add(Me.txtmarca)
        Me.pnlFormulario.Controls.Add(Me.lblModelo)
        Me.pnlFormulario.Controls.Add(Me.txtmodelo)
        Me.pnlFormulario.Controls.Add(Me.lblArea)
        Me.pnlFormulario.Controls.Add(Me.cbxarea)
        Me.pnlFormulario.Controls.Add(Me.lblEstado)
        Me.pnlFormulario.Controls.Add(Me.cbxestado)
        Me.pnlFormulario.Controls.Add(Me.lblObservaciones)
        Me.pnlFormulario.Controls.Add(Me.txtobservaciones)
        Me.pnlFormulario.Controls.Add(Me.btnRegistrar)
        Me.pnlFormulario.Controls.Add(Me.btnActualizar)
        Me.pnlFormulario.Controls.Add(Me.btnBaja)
        Me.pnlFormulario.Controls.Add(Me.btnEliminar)
        Me.pnlFormulario.Controls.Add(Me.btnLimpiar)
        Me.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFormulario.Location = New System.Drawing.Point(0, 0)
        Me.pnlFormulario.Name = "pnlFormulario"
        Me.pnlFormulario.Size = New System.Drawing.Size(980, 272)
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
        Me.txtbuscar.Size = New System.Drawing.Size(220, 28)
        '
        'lblFiltroEstado
        '
        Me.lblFiltroEstado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltroEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblFiltroEstado.Location = New System.Drawing.Point(310, 16)
        Me.lblFiltroEstado.Name = "lblFiltroEstado"
        Me.lblFiltroEstado.Size = New System.Drawing.Size(50, 18)
        Me.lblFiltroEstado.Text = "Estado"
        '
        'cbxFiltroEstado
        '
        Me.cbxFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFiltroEstado.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFiltroEstado.FormattingEnabled = True
        Me.cbxFiltroEstado.Items.AddRange(New Object() {"Todos", "Operativo", "En Mantenimiento", "Sin Tarea", "Dado de Baja"})
        Me.cbxFiltroEstado.Location = New System.Drawing.Point(364, 12)
        Me.cbxFiltroEstado.Name = "cbxFiltroEstado"
        Me.cbxFiltroEstado.Size = New System.Drawing.Size(140, 28)
        '
        'lblFiltroArea
        '
        Me.lblFiltroArea.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltroArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblFiltroArea.Location = New System.Drawing.Point(516, 16)
        Me.lblFiltroArea.Name = "lblFiltroArea"
        Me.lblFiltroArea.Size = New System.Drawing.Size(40, 18)
        Me.lblFiltroArea.Text = "Área"
        '
        'cbxFiltroArea
        '
        Me.cbxFiltroArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFiltroArea.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFiltroArea.FormattingEnabled = True
        Me.cbxFiltroArea.Items.AddRange(New Object() {"Todos", "Campo", "Fábrica", "Logística", "Mantenimiento", "Administración", "Recursos humanos", "Sistemas"})
        Me.cbxFiltroArea.Location = New System.Drawing.Point(556, 12)
        Me.cbxFiltroArea.Name = "cbxFiltroArea"
        Me.cbxFiltroArea.Size = New System.Drawing.Size(140, 28)
        '
        'pnlFiltros
        '
        Me.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnlFiltros.Controls.Add(Me.lblBuscar)
        Me.pnlFiltros.Controls.Add(Me.txtbuscar)
        Me.pnlFiltros.Controls.Add(Me.lblFiltroEstado)
        Me.pnlFiltros.Controls.Add(Me.cbxFiltroEstado)
        Me.pnlFiltros.Controls.Add(Me.lblFiltroArea)
        Me.pnlFiltros.Controls.Add(Me.cbxFiltroArea)
        Me.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltros.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New System.Drawing.Size(980, 52)
        '
        CType(Me.dgvMaquinaria, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'dgvMaquinaria
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
        Me.dgvMaquinaria.AllowUserToAddRows = False
        Me.dgvMaquinaria.AllowUserToDeleteRows = False
        Me.dgvMaquinaria.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMaquinaria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMaquinaria.BackgroundColor = System.Drawing.Color.White
        Me.dgvMaquinaria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMaquinaria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvMaquinaria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMaquinaria.ColumnHeadersHeight = 36
        Me.dgvMaquinaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMaquinaria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_maquinaria, Me.nombre_codigo, Me.tipo, Me.marca, Me.modelo, Me.area, Me.estado, Me.observaciones, Me.fecha_registro})
        Me.dgvMaquinaria.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMaquinaria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMaquinaria.EnableHeadersVisualStyles = False
        Me.dgvMaquinaria.GridColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvMaquinaria.Location = New System.Drawing.Point(0, 0)
        Me.dgvMaquinaria.MultiSelect = False
        Me.dgvMaquinaria.Name = "dgvMaquinaria"
        Me.dgvMaquinaria.ReadOnly = True
        Me.dgvMaquinaria.RowHeadersVisible = False
        Me.dgvMaquinaria.RowTemplate.Height = 30
        Me.dgvMaquinaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMaquinaria.Size = New System.Drawing.Size(980, 200)
        '
        'id_maquinaria
        '
        Me.id_maquinaria.DataPropertyName = "id_maquinaria"
        Me.id_maquinaria.HeaderText = "id_maquinaria"
        Me.id_maquinaria.Name = "id_maquinaria"
        Me.id_maquinaria.Visible = False
        '
        'nombre_codigo
        '
        Me.nombre_codigo.DataPropertyName = "nombre_codigo"
        Me.nombre_codigo.HeaderText = "Código"
        Me.nombre_codigo.Name = "nombre_codigo"
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "tipo"
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        '
        'marca
        '
        Me.marca.DataPropertyName = "marca"
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        '
        'modelo
        '
        Me.modelo.DataPropertyName = "modelo"
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        '
        'area
        '
        Me.area.DataPropertyName = "area"
        Me.area.HeaderText = "Área"
        Me.area.Name = "area"
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        '
        'observaciones
        '
        Me.observaciones.DataPropertyName = "observaciones"
        Me.observaciones.HeaderText = "Observaciones"
        Me.observaciones.Name = "observaciones"
        '
        'fecha_registro
        '
        Me.fecha_registro.DataPropertyName = "fecha_registro"
        Me.fecha_registro.DefaultCellStyle.Format = "dd/MM/yyyy"
        Me.fecha_registro.HeaderText = "Fecha de registro"
        Me.fecha_registro.Name = "fecha_registro"
        CType(Me.dgvMaquinaria, System.ComponentModel.ISupportInitialize).EndInit()
        '
        'frmMaquinaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 640)
        Me.Controls.Add(Me.dgvMaquinaria)
        Me.Controls.Add(Me.pnlFiltros)
        Me.Controls.Add(Me.pnlFormulario)
        Me.Controls.Add(Me.lblSubtitulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMaquinaria"
        Me.Text = "Maquinaria"
        Me.pnlFiltros.ResumeLayout(False)
        Me.pnlFiltros.PerformLayout()
        Me.pnlFormulario.ResumeLayout(False)
        Me.pnlFormulario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents txttipo As TextBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents lblModelo As Label
    Friend WithEvents txtmodelo As TextBox
    Friend WithEvents lblArea As Label
    Friend WithEvents cbxarea As ComboBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents cbxestado As ComboBox
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents txtobservaciones As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents pnlFormulario As Panel
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents lblFiltroEstado As Label
    Friend WithEvents cbxFiltroEstado As ComboBox
    Friend WithEvents lblFiltroArea As Label
    Friend WithEvents cbxFiltroArea As ComboBox
    Friend WithEvents pnlFiltros As Panel
    Friend WithEvents dgvMaquinaria As DataGridView
    Friend WithEvents id_maquinaria As DataGridViewTextBoxColumn
    Friend WithEvents nombre_codigo As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents modelo As DataGridViewTextBoxColumn
    Friend WithEvents area As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents observaciones As DataGridViewTextBoxColumn
    Friend WithEvents fecha_registro As DataGridViewTextBoxColumn
End Class
