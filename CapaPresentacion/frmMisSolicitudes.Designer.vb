<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMisSolicitudes
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
        Me.lblMaquina = New System.Windows.Forms.Label()
        Me.cbxmaquina = New System.Windows.Forms.ComboBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.cbxarea = New System.Windows.Forms.ComboBox()
        Me.lblPrioridad = New System.Windows.Forms.Label()
        Me.cbxprioridad = New System.Windows.Forms.ComboBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.lblContador = New System.Windows.Forms.Label()
        Me.lblAviso = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.pnlEdicion = New System.Windows.Forms.Panel()
        Me.dgvSolicitudes = New System.Windows.Forms.DataGridView()
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
        Me.pnlEdicion.SuspendLayout()
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
        Me.lblTitulo.Text = "Mis solicitudes"
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
        Me.lblSubtitulo.Text = "Consulte y actualice sus solicitudes pendientes"
        Me.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaquina
        '
        Me.lblMaquina.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaquina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblMaquina.Location = New System.Drawing.Point(16, 12)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(200, 18)
        Me.lblMaquina.Text = "Máquina"
        '
        'cbxmaquina
        '
        Me.cbxmaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxmaquina.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxmaquina.FormattingEnabled = True
        Me.cbxmaquina.Location = New System.Drawing.Point(16, 32)
        Me.cbxmaquina.Name = "cbxmaquina"
        Me.cbxmaquina.Size = New System.Drawing.Size(280, 28)
        '
        'lblArea
        '
        Me.lblArea.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblArea.Location = New System.Drawing.Point(312, 12)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(160, 18)
        Me.lblArea.Text = "Área"
        '
        'cbxarea
        '
        Me.cbxarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxarea.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxarea.FormattingEnabled = True
        Me.cbxarea.Items.AddRange(New Object() {"Campo", "Fábrica", "Logística", "Mantenimiento", "Administración", "Recursos humanos", "Sistemas"})
        Me.cbxarea.Location = New System.Drawing.Point(312, 32)
        Me.cbxarea.Name = "cbxarea"
        Me.cbxarea.Size = New System.Drawing.Size(150, 28)
        '
        'lblPrioridad
        '
        Me.lblPrioridad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioridad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblPrioridad.Location = New System.Drawing.Point(478, 12)
        Me.lblPrioridad.Name = "lblPrioridad"
        Me.lblPrioridad.Size = New System.Drawing.Size(160, 18)
        Me.lblPrioridad.Text = "Prioridad"
        '
        'cbxprioridad
        '
        Me.cbxprioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxprioridad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxprioridad.FormattingEnabled = True
        Me.cbxprioridad.Items.AddRange(New Object() {"Alta", "Media", "Baja"})
        Me.cbxprioridad.Location = New System.Drawing.Point(478, 32)
        Me.cbxprioridad.Name = "cbxprioridad"
        Me.cbxprioridad.Size = New System.Drawing.Size(160, 28)
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDescripcion.Location = New System.Drawing.Point(16, 72)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(200, 18)
        Me.lblDescripcion.Text = "Descripción"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.Location = New System.Drawing.Point(16, 92)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(420, 70)
        Me.txtdescripcion.MaxLength = 255
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        '
        'lblContador
        '
        Me.lblContador.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblContador.Location = New System.Drawing.Point(346, 166)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(90, 18)
        Me.lblContador.Text = "0/255"
        Me.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAviso
        '
        Me.lblAviso.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAviso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblAviso.Location = New System.Drawing.Point(456, 92)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(190, 70)
        Me.lblAviso.Text = ""
        Me.lblAviso.Visible = False
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
        Me.btnActualizar.Location = New System.Drawing.Point(16, 196)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(120, 36)
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
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
        Me.btnEliminar.Location = New System.Drawing.Point(144, 196)
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
        Me.btnLimpiar.Location = New System.Drawing.Point(262, 196)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 36)
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'pnlEdicion
        '
        Me.pnlEdicion.BackColor = System.Drawing.Color.White
        Me.pnlEdicion.Controls.Add(Me.lblMaquina)
        Me.pnlEdicion.Controls.Add(Me.cbxmaquina)
        Me.pnlEdicion.Controls.Add(Me.lblArea)
        Me.pnlEdicion.Controls.Add(Me.cbxarea)
        Me.pnlEdicion.Controls.Add(Me.lblPrioridad)
        Me.pnlEdicion.Controls.Add(Me.cbxprioridad)
        Me.pnlEdicion.Controls.Add(Me.lblDescripcion)
        Me.pnlEdicion.Controls.Add(Me.txtdescripcion)
        Me.pnlEdicion.Controls.Add(Me.lblContador)
        Me.pnlEdicion.Controls.Add(Me.lblAviso)
        Me.pnlEdicion.Controls.Add(Me.btnActualizar)
        Me.pnlEdicion.Controls.Add(Me.btnEliminar)
        Me.pnlEdicion.Controls.Add(Me.btnLimpiar)
        Me.pnlEdicion.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEdicion.Location = New System.Drawing.Point(0, 0)
        Me.pnlEdicion.Name = "pnlEdicion"
        Me.pnlEdicion.Size = New System.Drawing.Size(980, 248)
        '
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'dgvSolicitudes
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
        Me.dgvSolicitudes.AllowUserToAddRows = False
        Me.dgvSolicitudes.AllowUserToDeleteRows = False
        Me.dgvSolicitudes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSolicitudes.BackgroundColor = System.Drawing.Color.White
        Me.dgvSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSolicitudes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSolicitudes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSolicitudes.ColumnHeadersHeight = 36
        Me.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_solicitud, Me.id_personal, Me.id_maquinaria, Me.fecha_registro, Me.descripcion, Me.area, Me.prioridad, Me.estado, Me.comentario, Me.tipo_solicitud, Me.trabajador, Me.maquina})
        Me.dgvSolicitudes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSolicitudes.EnableHeadersVisualStyles = False
        Me.dgvSolicitudes.GridColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvSolicitudes.Location = New System.Drawing.Point(0, 0)
        Me.dgvSolicitudes.MultiSelect = False
        Me.dgvSolicitudes.Name = "dgvSolicitudes"
        Me.dgvSolicitudes.ReadOnly = True
        Me.dgvSolicitudes.RowHeadersVisible = False
        Me.dgvSolicitudes.RowTemplate.Height = 30
        Me.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSolicitudes.Size = New System.Drawing.Size(980, 200)
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
        Me.trabajador.Visible = False
        '
        'maquina
        '
        Me.maquina.DataPropertyName = "maquina"
        Me.maquina.HeaderText = "Máquina"
        Me.maquina.Name = "maquina"
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        '
        'frmMisSolicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 640)
        Me.Controls.Add(Me.dgvSolicitudes)
        Me.Controls.Add(Me.pnlEdicion)
        Me.Controls.Add(Me.lblSubtitulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMisSolicitudes"
        Me.Text = "Mis solicitudes"
        Me.pnlEdicion.ResumeLayout(False)
        Me.pnlEdicion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents lblMaquina As Label
    Friend WithEvents cbxmaquina As ComboBox
    Friend WithEvents lblArea As Label
    Friend WithEvents cbxarea As ComboBox
    Friend WithEvents lblPrioridad As Label
    Friend WithEvents cbxprioridad As ComboBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents lblContador As Label
    Friend WithEvents lblAviso As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents pnlEdicion As Panel
    Friend WithEvents dgvSolicitudes As DataGridView
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
