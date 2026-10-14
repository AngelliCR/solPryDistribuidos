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
        'dgvMaquinaria
        '
        Me.dgvMaquinaria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMaquinaria.Location = New System.Drawing.Point(0, 0)
        Me.dgvMaquinaria.Name = "dgvMaquinaria"
        Me.dgvMaquinaria.Size = New System.Drawing.Size(980, 200)
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
End Class
