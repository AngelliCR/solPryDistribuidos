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
        Me.cbxFiltroPrioridad.Location = New System.Drawing.Point(472, 12)
        Me.cbxFiltroPrioridad.Name = "cbxFiltroPrioridad"
        Me.cbxFiltroPrioridad.Size = New System.Drawing.Size(130, 28)
        '
        'btnLimpiarFiltros
        '
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
        'dgvGestion
        '
        Me.dgvGestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGestion.Location = New System.Drawing.Point(0, 0)
        Me.dgvGestion.Name = "dgvGestion"
        Me.dgvGestion.Size = New System.Drawing.Size(980, 200)
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
End Class
