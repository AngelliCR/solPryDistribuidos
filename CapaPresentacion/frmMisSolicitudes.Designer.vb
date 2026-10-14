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
        'dgvSolicitudes
        '
        Me.dgvSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSolicitudes.Location = New System.Drawing.Point(0, 0)
        Me.dgvSolicitudes.Name = "dgvSolicitudes"
        Me.dgvSolicitudes.Size = New System.Drawing.Size(980, 200)
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
End Class
