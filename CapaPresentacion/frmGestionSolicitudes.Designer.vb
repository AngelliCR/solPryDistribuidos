<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionSolicitudes
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
        Me.lblFiltroEstado = New System.Windows.Forms.Label()
        Me.cbxFiltroEstado = New System.Windows.Forms.ComboBox()
        Me.lblFiltroArea = New System.Windows.Forms.Label()
        Me.cbxFiltroArea = New System.Windows.Forms.ComboBox()
        Me.lblFiltroPrioridad = New System.Windows.Forms.Label()
        Me.cbxFiltroPrioridad = New System.Windows.Forms.ComboBox()
        Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.lblRevision = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.lblNuevoEstado = New System.Windows.Forms.Label()
        Me.cbxNuevoEstado = New System.Windows.Forms.ComboBox()
        Me.lblComentario = New System.Windows.Forms.Label()
        Me.txtcomentario = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pnlRevision = New System.Windows.Forms.Panel()
        Me.dgvGestion = New System.Windows.Forms.DataGridView()
        Me.id_solicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_personal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_maquinaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_registro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prioridad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_solicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trabajador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maquina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlFiltros.SuspendLayout()
        Me.pnlRevision.SuspendLayout()
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
        Me.lblTitulo.Text = "Gestión de solicitudes"
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
        Me.lblSubtitulo.Text = "Revise y actualice el estado de las solicitudes"
        Me.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFiltroEstado
        '
        Me.lblFiltroEstado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltroEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblFiltroEstado.Location = New System.Drawing.Point(16, 16)
        Me.lblFiltroEstado.Name = "lblFiltroEstado"
        Me.lblFiltroEstado.Size = New System.Drawing.Size(50, 18)
        Me.lblFiltroEstado.Text = "Estado"
        '
        'cbxFiltroEstado
        '
        Me.cbxFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFiltroEstado.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFiltroEstado.FormattingEnabled = True
        Me.cbxFiltroEstado.Items.AddRange(New Object() {"Todos", "Pendiente", "En revisión", "Aprobado", "Rechazado"})
        Me.cbxFiltroEstado.Location = New System.Drawing.Point(70, 12)
        Me.cbxFiltroEstado.Name = "cbxFiltroEstado"
        Me.cbxFiltroEstado.Size = New System.Drawing.Size(130, 28)
        '
        'lblFiltroArea
        '
        Me.lblFiltroArea.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltroArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblFiltroArea.Location = New System.Drawing.Point(210, 16)
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
        Me.cbxFiltroArea.Location = New System.Drawing.Point(250, 12)
        Me.cbxFiltroArea.Name = "cbxFiltroArea"
        Me.cbxFiltroArea.Size = New System.Drawing.Size(140, 28)
        '
        'lblFiltroPrioridad
        '
        Me.lblFiltroPrioridad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltroPrioridad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblFiltroPrioridad.Location = New System.Drawing.Point(402, 16)
        Me.lblFiltroPrioridad.Name = "lblFiltroPrioridad"
        Me.lblFiltroPrioridad.Size = New System.Drawing.Size(70, 18)
        Me.lblFiltroPrioridad.Text = "Prioridad"
        '
        'cbxFiltroPrioridad
        '
        Me.cbxFiltroPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFiltroPrioridad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFiltroPrioridad.FormattingEnabled = True
        Me.cbxFiltroPrioridad.Items.AddRange(New Object() {"Todos", "Alta", "Media", "Baja"})
        Me.cbxFiltroPrioridad.Location = New System.Drawing.Point(472, 12)
        Me.cbxFiltroPrioridad.Name = "cbxFiltroPrioridad"
        Me.cbxFiltroPrioridad.Size = New System.Drawing.Size(130, 28)
        '
        'btnLimpiarFiltros
        '
        Me.btnLimpiarFiltros.BackColor = System.Drawing.Color.White
        Me.btnLimpiarFiltros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiarFiltros.FlatAppearance.BorderSize = 1
        Me.btnLimpiarFiltros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btnLimpiarFiltros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnLimpiarFiltros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnLimpiarFiltros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarFiltros.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarFiltros.Location = New System.Drawing.Point(16, 48)
        Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
        Me.btnLimpiarFiltros.Size = New System.Drawing.Size(150, 36)
        Me.btnLimpiarFiltros.Text = "Limpiar filtros"
        Me.btnLimpiarFiltros.UseVisualStyleBackColor = False
        '
        'pnlFiltros
        '
        Me.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnlFiltros.Controls.Add(Me.lblFiltroEstado)
        Me.pnlFiltros.Controls.Add(Me.cbxFiltroEstado)
        Me.pnlFiltros.Controls.Add(Me.lblFiltroArea)
        Me.pnlFiltros.Controls.Add(Me.cbxFiltroArea)
        Me.pnlFiltros.Controls.Add(Me.lblFiltroPrioridad)
        Me.pnlFiltros.Controls.Add(Me.cbxFiltroPrioridad)
        Me.pnlFiltros.Controls.Add(Me.btnLimpiarFiltros)
        Me.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltros.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New System.Drawing.Size(980, 96)
        '
        'lblRevision
        '
        Me.lblRevision.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevision.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblRevision.Location = New System.Drawing.Point(16, 10)
        Me.lblRevision.Name = "lblRevision"
        Me.lblRevision.Size = New System.Drawing.Size(200, 22)
        Me.lblRevision.Text = "Revisión"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDescripcion.Location = New System.Drawing.Point(16, 36)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(120, 18)
        Me.lblDescripcion.Text = "Descripción"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.Location = New System.Drawing.Point(16, 56)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(280, 90)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.ReadOnly = True
        Me.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        '
        'lblNuevoEstado
        '
        Me.lblNuevoEstado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblNuevoEstado.Location = New System.Drawing.Point(312, 36)
        Me.lblNuevoEstado.Name = "lblNuevoEstado"
        Me.lblNuevoEstado.Size = New System.Drawing.Size(160, 18)
        Me.lblNuevoEstado.Text = "Nuevo estado"
        '
        'cbxNuevoEstado
        '
        Me.cbxNuevoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNuevoEstado.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxNuevoEstado.FormattingEnabled = True
        Me.cbxNuevoEstado.Items.AddRange(New Object() {"Pendiente", "En revisión", "Aprobado", "Rechazado"})
        Me.cbxNuevoEstado.Location = New System.Drawing.Point(312, 56)
        Me.cbxNuevoEstado.Name = "cbxNuevoEstado"
        Me.cbxNuevoEstado.Size = New System.Drawing.Size(160, 28)
        '
        'lblComentario
        '
        Me.lblComentario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComentario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblComentario.Location = New System.Drawing.Point(488, 36)
        Me.lblComentario.Name = "lblComentario"
        Me.lblComentario.Size = New System.Drawing.Size(160, 18)
        Me.lblComentario.Text = "Comentario"
        '
        'txtcomentario
        '
        Me.txtcomentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcomentario.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomentario.Location = New System.Drawing.Point(488, 56)
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.Size = New System.Drawing.Size(170, 70)
        Me.txtcomentario.Multiline = True
        Me.txtcomentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(312, 136)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(160, 36)
        Me.btnGuardar.Text = "Guardar cambios"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'pnlRevision
        '
        Me.pnlRevision.BackColor = System.Drawing.Color.White
        Me.pnlRevision.Controls.Add(Me.lblRevision)
        Me.pnlRevision.Controls.Add(Me.lblDescripcion)
        Me.pnlRevision.Controls.Add(Me.txtdescripcion)
        Me.pnlRevision.Controls.Add(Me.lblNuevoEstado)
        Me.pnlRevision.Controls.Add(Me.cbxNuevoEstado)
        Me.pnlRevision.Controls.Add(Me.lblComentario)
        Me.pnlRevision.Controls.Add(Me.txtcomentario)
        Me.pnlRevision.Controls.Add(Me.btnGuardar)
        Me.pnlRevision.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlRevision.Location = New System.Drawing.Point(0, 0)
        Me.pnlRevision.Name = "pnlRevision"
        Me.pnlRevision.Size = New System.Drawing.Size(980, 184)
        '
        CType(Me.dgvGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'dgvGestion
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
        Me.dgvGestion.AllowUserToAddRows = False
        Me.dgvGestion.AllowUserToDeleteRows = False
        Me.dgvGestion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGestion.BackgroundColor = System.Drawing.Color.White
        Me.dgvGestion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGestion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvGestion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGestion.ColumnHeadersHeight = 36
        Me.dgvGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvGestion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_solicitud, Me.id_personal, Me.id_maquinaria, Me.fecha_registro, Me.descripcion, Me.area, Me.prioridad, Me.estado, Me.comentario, Me.tipo_solicitud, Me.trabajador, Me.maquina})
        Me.dgvGestion.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGestion.EnableHeadersVisualStyles = False
        Me.dgvGestion.GridColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvGestion.Location = New System.Drawing.Point(0, 0)
        Me.dgvGestion.MultiSelect = False
        Me.dgvGestion.Name = "dgvGestion"
        Me.dgvGestion.ReadOnly = True
        Me.dgvGestion.RowHeadersVisible = False
        Me.dgvGestion.RowTemplate.Height = 30
        Me.dgvGestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGestion.Size = New System.Drawing.Size(980, 200)
        '
        'id_solicitud
        '
        Me.id_solicitud.DataPropertyName = "id_solicitud"
        Me.id_solicitud.HeaderText = "id_solicitud"
        Me.id_solicitud.Name = "id_solicitud"
        Me.id_solicitud.Visible = False
        '
        'id_personal
        '
        Me.id_personal.DataPropertyName = "id_personal"
        Me.id_personal.HeaderText = "id_personal"
        Me.id_personal.Name = "id_personal"
        Me.id_personal.Visible = False
        '
        'id_maquinaria
        '
        Me.id_maquinaria.DataPropertyName = "id_maquinaria"
        Me.id_maquinaria.HeaderText = "id_maquinaria"
        Me.id_maquinaria.Name = "id_maquinaria"
        Me.id_maquinaria.Visible = False
        '
        'fecha_registro
        '
        Me.fecha_registro.DataPropertyName = "fecha_registro"
        Me.fecha_registro.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
        Me.fecha_registro.HeaderText = "Fecha"
        Me.fecha_registro.Name = "fecha_registro"
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        '
        'area
        '
        Me.area.DataPropertyName = "area"
        Me.area.HeaderText = "Área"
        Me.area.Name = "area"
        '
        'prioridad
        '
        Me.prioridad.DataPropertyName = "prioridad"
        Me.prioridad.HeaderText = "Prioridad"
        Me.prioridad.Name = "prioridad"
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        '
        'comentario
        '
        Me.comentario.DataPropertyName = "comentario"
        Me.comentario.HeaderText = "Comentario"
        Me.comentario.Name = "comentario"
        '
        'tipo_solicitud
        '
        Me.tipo_solicitud.DataPropertyName = "tipo_solicitud"
        Me.tipo_solicitud.HeaderText = "Tipo"
        Me.tipo_solicitud.Name = "tipo_solicitud"
        Me.tipo_solicitud.Visible = False
        '
        'trabajador
        '
        Me.trabajador.DataPropertyName = "trabajador"
        Me.trabajador.HeaderText = "Trabajador"
        Me.trabajador.Name = "trabajador"
        '
        'maquina
        '
        Me.maquina.DataPropertyName = "maquina"
        Me.maquina.HeaderText = "Máquina"
        Me.maquina.Name = "maquina"
        CType(Me.dgvGestion, System.ComponentModel.ISupportInitialize).EndInit()
        '
        'frmGestionSolicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 640)
        Me.Controls.Add(Me.dgvGestion)
        Me.Controls.Add(Me.pnlRevision)
        Me.Controls.Add(Me.pnlFiltros)
        Me.Controls.Add(Me.lblSubtitulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGestionSolicitudes"
        Me.Text = "Gestión de solicitudes"
        Me.pnlRevision.ResumeLayout(False)
        Me.pnlRevision.PerformLayout()
        Me.pnlFiltros.ResumeLayout(False)
        Me.pnlFiltros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents lblFiltroEstado As Label
    Friend WithEvents cbxFiltroEstado As ComboBox
    Friend WithEvents lblFiltroArea As Label
    Friend WithEvents cbxFiltroArea As ComboBox
    Friend WithEvents lblFiltroPrioridad As Label
    Friend WithEvents cbxFiltroPrioridad As ComboBox
    Friend WithEvents btnLimpiarFiltros As Button
    Friend WithEvents pnlFiltros As Panel
    Friend WithEvents lblRevision As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents lblNuevoEstado As Label
    Friend WithEvents cbxNuevoEstado As ComboBox
    Friend WithEvents lblComentario As Label
    Friend WithEvents txtcomentario As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents pnlRevision As Panel
    Friend WithEvents dgvGestion As DataGridView
    Friend WithEvents id_solicitud As DataGridViewTextBoxColumn
    Friend WithEvents id_personal As DataGridViewTextBoxColumn
    Friend WithEvents id_maquinaria As DataGridViewTextBoxColumn
    Friend WithEvents fecha_registro As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents area As DataGridViewTextBoxColumn
    Friend WithEvents prioridad As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents comentario As DataGridViewTextBoxColumn
    Friend WithEvents tipo_solicitud As DataGridViewTextBoxColumn
    Friend WithEvents trabajador As DataGridViewTextBoxColumn
    Friend WithEvents maquina As DataGridViewTextBoxColumn
End Class
