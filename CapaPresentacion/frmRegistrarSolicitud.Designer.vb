<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarSolicitud
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
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.pnlFormulario = New System.Windows.Forms.Panel()
        Me.pnlFormulario.SuspendLayout()
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
        Me.lblTitulo.Text = "Registrar solicitud"
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
        Me.lblSubtitulo.Text = "Registre una solicitud de mantenimiento"
        Me.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaquina
        '
        Me.lblMaquina.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaquina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblMaquina.Location = New System.Drawing.Point(20, 20)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(200, 18)
        Me.lblMaquina.Text = "Máquina"
        '
        'cbxmaquina
        '
        Me.cbxmaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxmaquina.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxmaquina.FormattingEnabled = True
        Me.cbxmaquina.Location = New System.Drawing.Point(20, 42)
        Me.cbxmaquina.Name = "cbxmaquina"
        Me.cbxmaquina.Size = New System.Drawing.Size(460, 28)
        '
        'lblArea
        '
        Me.lblArea.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblArea.Location = New System.Drawing.Point(20, 84)
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
        Me.cbxarea.Location = New System.Drawing.Point(20, 106)
        Me.cbxarea.Name = "cbxarea"
        Me.cbxarea.Size = New System.Drawing.Size(220, 28)
        '
        'lblPrioridad
        '
        Me.lblPrioridad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioridad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblPrioridad.Location = New System.Drawing.Point(260, 84)
        Me.lblPrioridad.Name = "lblPrioridad"
        Me.lblPrioridad.Size = New System.Drawing.Size(200, 18)
        Me.lblPrioridad.Text = "Prioridad"
        '
        'cbxprioridad
        '
        Me.cbxprioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxprioridad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxprioridad.FormattingEnabled = True
        Me.cbxprioridad.Items.AddRange(New Object() {"Alta", "Media", "Baja"})
        Me.cbxprioridad.Location = New System.Drawing.Point(260, 106)
        Me.cbxprioridad.Name = "cbxprioridad"
        Me.cbxprioridad.Size = New System.Drawing.Size(220, 28)
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDescripcion.Location = New System.Drawing.Point(20, 148)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(200, 18)
        Me.lblDescripcion.Text = "Descripción"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.Location = New System.Drawing.Point(20, 170)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(460, 90)
        Me.txtdescripcion.MaxLength = 255
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        '
        'lblContador
        '
        Me.lblContador.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblContador.Location = New System.Drawing.Point(390, 264)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(90, 18)
        Me.lblContador.Text = "0/255"
        Me.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.btnRegistrar.Location = New System.Drawing.Point(20, 300)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(190, 36)
        Me.btnRegistrar.Text = "Registrar solicitud"
        Me.btnRegistrar.UseVisualStyleBackColor = False
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
        Me.btnLimpiar.Location = New System.Drawing.Point(220, 300)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(110, 36)
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'pnlFormulario
        '
        Me.pnlFormulario.BackColor = System.Drawing.Color.White
        Me.pnlFormulario.Controls.Add(Me.lblMaquina)
        Me.pnlFormulario.Controls.Add(Me.cbxmaquina)
        Me.pnlFormulario.Controls.Add(Me.lblArea)
        Me.pnlFormulario.Controls.Add(Me.cbxarea)
        Me.pnlFormulario.Controls.Add(Me.lblPrioridad)
        Me.pnlFormulario.Controls.Add(Me.cbxprioridad)
        Me.pnlFormulario.Controls.Add(Me.lblDescripcion)
        Me.pnlFormulario.Controls.Add(Me.txtdescripcion)
        Me.pnlFormulario.Controls.Add(Me.lblContador)
        Me.pnlFormulario.Controls.Add(Me.btnRegistrar)
        Me.pnlFormulario.Controls.Add(Me.btnLimpiar)
        Me.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFormulario.Location = New System.Drawing.Point(0, 0)
        Me.pnlFormulario.Name = "pnlFormulario"
        Me.pnlFormulario.Size = New System.Drawing.Size(980, 360)
        '
        'frmRegistrarSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 640)
        Me.Controls.Add(Me.pnlFormulario)
        Me.Controls.Add(Me.lblSubtitulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrarSolicitud"
        Me.Text = "Registrar solicitud"
        Me.pnlFormulario.ResumeLayout(False)
        Me.pnlFormulario.PerformLayout()
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
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents pnlFormulario As Panel
End Class
