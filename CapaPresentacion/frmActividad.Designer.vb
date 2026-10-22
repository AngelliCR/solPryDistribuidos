<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActividad
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrTranscurrido = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.pnlCheckin = New System.Windows.Forms.Panel()
        Me.lblMiJornada = New System.Windows.Forms.Label()
        Me.lblMaquina = New System.Windows.Forms.Label()
        Me.cbxMaquina = New System.Windows.Forms.ComboBox()
        Me.lblZona = New System.Windows.Forms.Label()
        Me.cbxZona = New System.Windows.Forms.ComboBox()
        Me.lblCombustibleInicial = New System.Windows.Forms.Label()
        Me.lblTanque = New System.Windows.Forms.Label()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.lblHorasEstimadas = New System.Windows.Forms.Label()
        Me.nudHorasEstimadas = New System.Windows.Forms.NumericUpDown()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.lblSinMaquinas = New System.Windows.Forms.Label()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.lblMiJornadaControl = New System.Windows.Forms.Label()
        Me.lblDatosJornada = New System.Windows.Forms.Label()
        Me.pnlFinalizar = New System.Windows.Forms.Panel()
        Me.lblFinalizar = New System.Windows.Forms.Label()
        Me.lblCombustibleFinal = New System.Windows.Forms.Label()
        Me.cbxCombustibleFinal = New System.Windows.Forms.ComboBox()
        Me.lblAlerta = New System.Windows.Forms.Label()
        Me.lblHorasReales = New System.Windows.Forms.Label()
        Me.nudHorasReales = New System.Windows.Forms.NumericUpDown()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.pnlBordeIncidente = New System.Windows.Forms.Panel()
        Me.pnlIncidente = New System.Windows.Forms.Panel()
        Me.lblIncidente = New System.Windows.Forms.Label()
        Me.lblFalla = New System.Windows.Forms.Label()
        Me.txtFalla = New System.Windows.Forms.TextBox()
        Me.btnAveria = New System.Windows.Forms.Button()
        Me.pnlResumen = New System.Windows.Forms.Panel()
        Me.pnlBordeCardActivas = New System.Windows.Forms.Panel()
        Me.pnlBarraActivas = New System.Windows.Forms.Panel()
        Me.pnlCardActivas = New System.Windows.Forms.Panel()
        Me.lblNumActivas = New System.Windows.Forms.Label()
        Me.lblTxtActivas = New System.Windows.Forms.Label()
        Me.pnlBordeCardFinalizadas = New System.Windows.Forms.Panel()
        Me.pnlBarraFinalizadas = New System.Windows.Forms.Panel()
        Me.pnlCardFinalizadas = New System.Windows.Forms.Panel()
        Me.lblNumFinalizadas = New System.Windows.Forms.Label()
        Me.lblTxtFinalizadas = New System.Windows.Forms.Label()
        Me.pnlBordeCardAverias = New System.Windows.Forms.Panel()
        Me.pnlBarraAverias = New System.Windows.Forms.Panel()
        Me.pnlCardAverias = New System.Windows.Forms.Panel()
        Me.lblNumAverias = New System.Windows.Forms.Label()
        Me.lblTxtAverias = New System.Windows.Forms.Label()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.lblFiltroEstado = New System.Windows.Forms.Label()
        Me.cbxFiltroEstado = New System.Windows.Forms.ComboBox()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lblGrilla = New System.Windows.Forms.Label()
        Me.dgvActividades = New System.Windows.Forms.DataGridView()
        Me.operario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maquina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.zona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horas_estimadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horas_reales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.combustible_final = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_maquinaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_personal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.combustible_inicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motivo_retraso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observacion_falla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSinDatos = New System.Windows.Forms.Label()
        Me.pnlDetalle = New System.Windows.Forms.Panel()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.lblCapOperario = New System.Windows.Forms.Label()
        Me.lblDetOperario = New System.Windows.Forms.Label()
        Me.lblCapMaquina = New System.Windows.Forms.Label()
        Me.lblDetMaquina = New System.Windows.Forms.Label()
        Me.lblCapZona = New System.Windows.Forms.Label()
        Me.lblDetZona = New System.Windows.Forms.Label()
        Me.lblCapEstado = New System.Windows.Forms.Label()
        Me.lblDetEstado = New System.Windows.Forms.Label()
        Me.lblCapInicio = New System.Windows.Forms.Label()
        Me.lblDetInicio = New System.Windows.Forms.Label()
        Me.lblCapFin = New System.Windows.Forms.Label()
        Me.lblDetFin = New System.Windows.Forms.Label()
        Me.lblCapHorasEst = New System.Windows.Forms.Label()
        Me.lblDetHorasEst = New System.Windows.Forms.Label()
        Me.lblCapHorasReales = New System.Windows.Forms.Label()
        Me.lblDetHorasReales = New System.Windows.Forms.Label()
        Me.lblCapCombIni = New System.Windows.Forms.Label()
        Me.lblDetCombIni = New System.Windows.Forms.Label()
        Me.lblCapCombFin = New System.Windows.Forms.Label()
        Me.lblDetCombFin = New System.Windows.Forms.Label()
        Me.lblCapMotivo = New System.Windows.Forms.Label()
        Me.txtDetMotivo = New System.Windows.Forms.TextBox()
        Me.lblCapFalla = New System.Windows.Forms.Label()
        Me.txtDetFalla = New System.Windows.Forms.TextBox()
        CType(Me.nudHorasEstimadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHorasReales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCheckin.SuspendLayout()
        Me.pnlFinalizar.SuspendLayout()
        Me.pnlBordeIncidente.SuspendLayout()
        Me.pnlIncidente.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.pnlBordeCardActivas.SuspendLayout()
        Me.pnlCardActivas.SuspendLayout()
        Me.pnlBordeCardFinalizadas.SuspendLayout()
        Me.pnlCardFinalizadas.SuspendLayout()
        Me.pnlBordeCardAverias.SuspendLayout()
        Me.pnlCardAverias.SuspendLayout()
        Me.pnlResumen.SuspendLayout()
        Me.pnlFiltros.SuspendLayout()
        Me.pnlDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrTranscurrido
        '
        Me.tmrTranscurrido.Interval = 60000
        '
        'lblTitulo
        '
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(980, 36)
        Me.lblTitulo.Text = "Actividad de maquinaria"
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
        Me.lblSubtitulo.Text = "Control de jornadas en campo"
        Me.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlCheckin
        '
        Me.pnlCheckin.BackColor = System.Drawing.Color.White
        Me.pnlCheckin.Controls.Add(Me.lblSinMaquinas)
        Me.pnlCheckin.Controls.Add(Me.btnIniciar)
        Me.pnlCheckin.Controls.Add(Me.nudHorasEstimadas)
        Me.pnlCheckin.Controls.Add(Me.lblHorasEstimadas)
        Me.pnlCheckin.Controls.Add(Me.lblNota)
        Me.pnlCheckin.Controls.Add(Me.lblTanque)
        Me.pnlCheckin.Controls.Add(Me.lblCombustibleInicial)
        Me.pnlCheckin.Controls.Add(Me.cbxZona)
        Me.pnlCheckin.Controls.Add(Me.lblZona)
        Me.pnlCheckin.Controls.Add(Me.cbxMaquina)
        Me.pnlCheckin.Controls.Add(Me.lblMaquina)
        Me.pnlCheckin.Controls.Add(Me.lblMiJornada)
        Me.pnlCheckin.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCheckin.Location = New System.Drawing.Point(0, 64)
        Me.pnlCheckin.Name = "pnlCheckin"
        Me.pnlCheckin.Size = New System.Drawing.Size(980, 300)
        '
        'lblMiJornada
        '
        Me.lblMiJornada.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiJornada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblMiJornada.Location = New System.Drawing.Point(16, 12)
        Me.lblMiJornada.Name = "lblMiJornada"
        Me.lblMiJornada.Size = New System.Drawing.Size(400, 24)
        Me.lblMiJornada.Text = "Mi jornada"
        '
        'lblMaquina
        '
        Me.lblMaquina.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaquina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblMaquina.Location = New System.Drawing.Point(16, 44)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(200, 18)
        Me.lblMaquina.Text = "Máquina"
        '
        'cbxMaquina
        '
        Me.cbxMaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMaquina.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMaquina.FormattingEnabled = True
        Me.cbxMaquina.Location = New System.Drawing.Point(16, 64)
        Me.cbxMaquina.Name = "cbxMaquina"
        Me.cbxMaquina.Size = New System.Drawing.Size(440, 28)
        '
        'lblZona
        '
        Me.lblZona.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZona.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblZona.Location = New System.Drawing.Point(16, 104)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.Size = New System.Drawing.Size(200, 18)
        Me.lblZona.Text = "Zona"
        '
        'cbxZona
        '
        Me.cbxZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxZona.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxZona.FormattingEnabled = True
        Me.cbxZona.Items.AddRange(New Object() {"Anexo Pampagrande", "Anexo Saltur", "Sipán Lote 4"})
        Me.cbxZona.Location = New System.Drawing.Point(16, 124)
        Me.cbxZona.Name = "cbxZona"
        Me.cbxZona.Size = New System.Drawing.Size(280, 28)
        '
        'lblCombustibleInicial
        '
        Me.lblCombustibleInicial.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCombustibleInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblCombustibleInicial.Location = New System.Drawing.Point(16, 164)
        Me.lblCombustibleInicial.Name = "lblCombustibleInicial"
        Me.lblCombustibleInicial.Size = New System.Drawing.Size(200, 18)
        Me.lblCombustibleInicial.Text = "Combustible inicial"
        '
        'lblTanque
        '
        Me.lblTanque.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.lblTanque.Location = New System.Drawing.Point(16, 184)
        Me.lblTanque.Name = "lblTanque"
        Me.lblTanque.Size = New System.Drawing.Size(280, 22)
        Me.lblTanque.Text = "100% (tanque lleno)"
        '
        'lblNota
        '
        Me.lblNota.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblNota.Location = New System.Drawing.Point(16, 208)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(440, 32)
        Me.lblNota.Text = "Las jornadas siempre inician con tanque lleno (reglamento interno)."
        '
        'lblHorasEstimadas
        '
        Me.lblHorasEstimadas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorasEstimadas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblHorasEstimadas.Location = New System.Drawing.Point(480, 164)
        Me.lblHorasEstimadas.Name = "lblHorasEstimadas"
        Me.lblHorasEstimadas.Size = New System.Drawing.Size(140, 18)
        Me.lblHorasEstimadas.Text = "Horas estimadas"
        '
        'nudHorasEstimadas
        '
        Me.nudHorasEstimadas.DecimalPlaces = 1
        Me.nudHorasEstimadas.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudHorasEstimadas.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.nudHorasEstimadas.Location = New System.Drawing.Point(480, 186)
        Me.nudHorasEstimadas.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.nudHorasEstimadas.Name = "nudHorasEstimadas"
        Me.nudHorasEstimadas.Size = New System.Drawing.Size(100, 25)
        Me.nudHorasEstimadas.Value = New Decimal(New Integer() {8, 0, 0, 0})
        Me.nudHorasEstimadas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIniciar.FlatAppearance.BorderSize = 0
        Me.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnIniciar.ForeColor = System.Drawing.Color.White
        Me.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Location = New System.Drawing.Point(16, 250)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(170, 36)
        Me.btnIniciar.Text = "Iniciar jornada"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'lblSinMaquinas
        '
        Me.lblSinMaquinas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinMaquinas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblSinMaquinas.Location = New System.Drawing.Point(200, 258)
        Me.lblSinMaquinas.Name = "lblSinMaquinas"
        Me.lblSinMaquinas.Size = New System.Drawing.Size(420, 22)
        Me.lblSinMaquinas.Text = "No hay máquinas disponibles en este momento."
        Me.lblSinMaquinas.Visible = False
        '
        'pnlControl
        '
        Me.pnlControl.BackColor = System.Drawing.Color.White
        Me.pnlControl.Controls.Add(Me.pnlBordeIncidente)
        Me.pnlControl.Controls.Add(Me.pnlFinalizar)
        Me.pnlControl.Controls.Add(Me.lblDatosJornada)
        Me.pnlControl.Controls.Add(Me.lblMiJornadaControl)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControl.Location = New System.Drawing.Point(0, 64)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(980, 330)
        Me.pnlControl.Visible = False
        '
        'lblMiJornadaControl
        '
        Me.lblMiJornadaControl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiJornadaControl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblMiJornadaControl.Location = New System.Drawing.Point(16, 8)
        Me.lblMiJornadaControl.Name = "lblMiJornadaControl"
        Me.lblMiJornadaControl.Size = New System.Drawing.Size(400, 24)
        Me.lblMiJornadaControl.Text = "Mi jornada"
        '
        'lblDatosJornada
        '
        Me.lblDatosJornada.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosJornada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDatosJornada.Location = New System.Drawing.Point(16, 36)
        Me.lblDatosJornada.Name = "lblDatosJornada"
        Me.lblDatosJornada.Size = New System.Drawing.Size(680, 44)
        '
        'pnlFinalizar
        '
        Me.pnlFinalizar.BackColor = System.Drawing.Color.White
        Me.pnlFinalizar.Controls.Add(Me.btnFinalizar)
        Me.pnlFinalizar.Controls.Add(Me.txtMotivo)
        Me.pnlFinalizar.Controls.Add(Me.lblMotivo)
        Me.pnlFinalizar.Controls.Add(Me.nudHorasReales)
        Me.pnlFinalizar.Controls.Add(Me.lblHorasReales)
        Me.pnlFinalizar.Controls.Add(Me.lblAlerta)
        Me.pnlFinalizar.Controls.Add(Me.cbxCombustibleFinal)
        Me.pnlFinalizar.Controls.Add(Me.lblCombustibleFinal)
        Me.pnlFinalizar.Controls.Add(Me.lblFinalizar)
        Me.pnlFinalizar.Location = New System.Drawing.Point(16, 84)
        Me.pnlFinalizar.Name = "pnlFinalizar"
        Me.pnlFinalizar.Size = New System.Drawing.Size(330, 230)
        '
        'lblFinalizar
        '
        Me.lblFinalizar.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblFinalizar.Location = New System.Drawing.Point(0, 0)
        Me.lblFinalizar.Name = "lblFinalizar"
        Me.lblFinalizar.Size = New System.Drawing.Size(300, 22)
        Me.lblFinalizar.Text = "Finalizar jornada"
        '
        'lblCombustibleFinal
        '
        Me.lblCombustibleFinal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCombustibleFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblCombustibleFinal.Location = New System.Drawing.Point(0, 28)
        Me.lblCombustibleFinal.Name = "lblCombustibleFinal"
        Me.lblCombustibleFinal.Size = New System.Drawing.Size(200, 18)
        Me.lblCombustibleFinal.Text = "Combustible final"
        '
        'cbxCombustibleFinal
        '
        Me.cbxCombustibleFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCombustibleFinal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCombustibleFinal.FormattingEnabled = True
        Me.cbxCombustibleFinal.Items.AddRange(New Object() {"75%", "50%", "25%", "Reserva"})
        Me.cbxCombustibleFinal.Location = New System.Drawing.Point(0, 48)
        Me.cbxCombustibleFinal.Name = "cbxCombustibleFinal"
        Me.cbxCombustibleFinal.Size = New System.Drawing.Size(200, 28)
        '
        'lblAlerta
        '
        Me.lblAlerta.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlerta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblAlerta.Location = New System.Drawing.Point(0, 80)
        Me.lblAlerta.Name = "lblAlerta"
        Me.lblAlerta.Size = New System.Drawing.Size(320, 20)
        Me.lblAlerta.Text = "¡Alerta! Combustible en reserva"
        Me.lblAlerta.Visible = False
        '
        'lblHorasReales
        '
        Me.lblHorasReales.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorasReales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblHorasReales.Location = New System.Drawing.Point(0, 108)
        Me.lblHorasReales.Name = "lblHorasReales"
        Me.lblHorasReales.Size = New System.Drawing.Size(110, 18)
        Me.lblHorasReales.Text = "Horas reales"
        '
        'nudHorasReales
        '
        Me.nudHorasReales.DecimalPlaces = 1
        Me.nudHorasReales.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudHorasReales.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.nudHorasReales.Location = New System.Drawing.Point(0, 128)
        Me.nudHorasReales.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.nudHorasReales.Name = "nudHorasReales"
        Me.nudHorasReales.Size = New System.Drawing.Size(100, 25)
        Me.nudHorasReales.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.nudHorasReales.Minimum = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'lblMotivo
        '
        Me.lblMotivo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblMotivo.Location = New System.Drawing.Point(116, 108)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(180, 18)
        Me.lblMotivo.Text = "Motivo de retraso"
        '
        'txtMotivo
        '
        Me.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMotivo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivo.Location = New System.Drawing.Point(116, 128)
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivo.Size = New System.Drawing.Size(200, 60)
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizar.FlatAppearance.BorderSize = 0
        Me.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnFinalizar.ForeColor = System.Drawing.Color.White
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.Location = New System.Drawing.Point(0, 196)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(200, 36)
        Me.btnFinalizar.Text = "Finalizar y liberar"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'pnlIncidente
        '
        Me.pnlIncidente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.pnlIncidente.Controls.Add(Me.btnAveria)
        Me.pnlIncidente.Controls.Add(Me.txtFalla)
        Me.pnlIncidente.Controls.Add(Me.lblFalla)
        Me.pnlIncidente.Controls.Add(Me.lblIncidente)
        Me.pnlIncidente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlIncidente.Location = New System.Drawing.Point(1, 1)
        Me.pnlIncidente.Name = "pnlIncidente"
        Me.pnlIncidente.Size = New System.Drawing.Size(328, 228)
        Me.pnlIncidente.TabIndex = 0
        '
        'pnlBordeIncidente
        '
        Me.pnlBordeIncidente.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlBordeIncidente.Controls.Add(Me.pnlIncidente)
        Me.pnlBordeIncidente.Location = New System.Drawing.Point(360, 84)
        Me.pnlBordeIncidente.Name = "pnlBordeIncidente"
        Me.pnlBordeIncidente.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.pnlBordeIncidente.Size = New System.Drawing.Size(330, 230)
        Me.pnlBordeIncidente.TabIndex = 1
        '
        'lblIncidente
        '
        Me.lblIncidente.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncidente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblIncidente.Location = New System.Drawing.Point(12, 10)
        Me.lblIncidente.Name = "lblIncidente"
        Me.lblIncidente.Size = New System.Drawing.Size(300, 22)
        Me.lblIncidente.Text = "¿Ocurrió un incidente?"
        '
        'lblFalla
        '
        Me.lblFalla.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFalla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblFalla.Location = New System.Drawing.Point(12, 38)
        Me.lblFalla.Name = "lblFalla"
        Me.lblFalla.Size = New System.Drawing.Size(280, 18)
        Me.lblFalla.Text = "Descripción de la falla"
        '
        'txtFalla
        '
        Me.txtFalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFalla.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFalla.Location = New System.Drawing.Point(12, 58)
        Me.txtFalla.Multiline = True
        Me.txtFalla.Name = "txtFalla"
        Me.txtFalla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFalla.Size = New System.Drawing.Size(306, 90)
        '
        'btnAveria
        '
        Me.btnAveria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnAveria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAveria.FlatAppearance.BorderSize = 0
        Me.btnAveria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAveria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAveria.ForeColor = System.Drawing.Color.White
        Me.btnAveria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAveria.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAveria.Location = New System.Drawing.Point(12, 164)
        Me.btnAveria.Name = "btnAveria"
        Me.btnAveria.Size = New System.Drawing.Size(180, 36)
        Me.btnAveria.Text = "Reportar avería"
        Me.btnAveria.UseVisualStyleBackColor = False
        '
        'pnlResumen
        '
        Me.pnlResumen.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnlResumen.Controls.Add(Me.pnlBordeCardAverias)
        Me.pnlResumen.Controls.Add(Me.pnlBordeCardFinalizadas)
        Me.pnlResumen.Controls.Add(Me.pnlBordeCardActivas)
        Me.pnlResumen.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlResumen.Location = New System.Drawing.Point(0, 64)
        Me.pnlResumen.Name = "pnlResumen"
        Me.pnlResumen.Size = New System.Drawing.Size(980, 90)
        Me.pnlResumen.Visible = False
        '
        'pnlBordeCardActivas
        '
        Me.pnlBordeCardActivas.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlBordeCardActivas.Controls.Add(Me.pnlBarraActivas)
        Me.pnlBordeCardActivas.Controls.Add(Me.pnlCardActivas)
        Me.pnlBordeCardActivas.Location = New System.Drawing.Point(0, 8)
        Me.pnlBordeCardActivas.Name = "pnlBordeCardActivas"
        Me.pnlBordeCardActivas.Padding = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.pnlBordeCardActivas.Size = New System.Drawing.Size(210, 74)
        Me.pnlBordeCardActivas.TabIndex = 0
        '
        'pnlBarraActivas
        '
        Me.pnlBarraActivas.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.pnlBarraActivas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBarraActivas.Location = New System.Drawing.Point(1, 0)
        Me.pnlBarraActivas.Name = "pnlBarraActivas"
        Me.pnlBarraActivas.Size = New System.Drawing.Size(208, 4)
        Me.pnlBarraActivas.TabIndex = 0
        '
        'pnlCardActivas
        '
        Me.pnlCardActivas.BackColor = System.Drawing.Color.White
        Me.pnlCardActivas.Controls.Add(Me.lblTxtActivas)
        Me.pnlCardActivas.Controls.Add(Me.lblNumActivas)
        Me.pnlCardActivas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCardActivas.Location = New System.Drawing.Point(1, 4)
        Me.pnlCardActivas.Name = "pnlCardActivas"
        Me.pnlCardActivas.Size = New System.Drawing.Size(208, 69)
        Me.pnlCardActivas.TabIndex = 1
        '
        'lblNumActivas
        '
        Me.lblNumActivas.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumActivas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.lblNumActivas.Location = New System.Drawing.Point(16, 0)
        Me.lblNumActivas.Name = "lblNumActivas"
        Me.lblNumActivas.Size = New System.Drawing.Size(178, 36)
        Me.lblNumActivas.Text = "0"
        '
        'lblTxtActivas
        '
        Me.lblTxtActivas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTxtActivas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblTxtActivas.Location = New System.Drawing.Point(16, 38)
        Me.lblTxtActivas.Name = "lblTxtActivas"
        Me.lblTxtActivas.Size = New System.Drawing.Size(178, 24)
        Me.lblTxtActivas.Text = "Jornadas activas"
        '
        'pnlBordeCardFinalizadas
        '
        Me.pnlBordeCardFinalizadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlBordeCardFinalizadas.Controls.Add(Me.pnlBarraFinalizadas)
        Me.pnlBordeCardFinalizadas.Controls.Add(Me.pnlCardFinalizadas)
        Me.pnlBordeCardFinalizadas.Location = New System.Drawing.Point(226, 8)
        Me.pnlBordeCardFinalizadas.Name = "pnlBordeCardFinalizadas"
        Me.pnlBordeCardFinalizadas.Padding = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.pnlBordeCardFinalizadas.Size = New System.Drawing.Size(210, 74)
        Me.pnlBordeCardFinalizadas.TabIndex = 0
        '
        'pnlBarraFinalizadas
        '
        Me.pnlBarraFinalizadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pnlBarraFinalizadas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBarraFinalizadas.Location = New System.Drawing.Point(1, 0)
        Me.pnlBarraFinalizadas.Name = "pnlBarraFinalizadas"
        Me.pnlBarraFinalizadas.Size = New System.Drawing.Size(208, 4)
        Me.pnlBarraFinalizadas.TabIndex = 0
        '
        'pnlCardFinalizadas
        '
        Me.pnlCardFinalizadas.BackColor = System.Drawing.Color.White
        Me.pnlCardFinalizadas.Controls.Add(Me.lblTxtFinalizadas)
        Me.pnlCardFinalizadas.Controls.Add(Me.lblNumFinalizadas)
        Me.pnlCardFinalizadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCardFinalizadas.Location = New System.Drawing.Point(1, 4)
        Me.pnlCardFinalizadas.Name = "pnlCardFinalizadas"
        Me.pnlCardFinalizadas.Size = New System.Drawing.Size(208, 69)
        Me.pnlCardFinalizadas.TabIndex = 1
        '
        'lblNumFinalizadas
        '
        Me.lblNumFinalizadas.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumFinalizadas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblNumFinalizadas.Location = New System.Drawing.Point(16, 0)
        Me.lblNumFinalizadas.Name = "lblNumFinalizadas"
        Me.lblNumFinalizadas.Size = New System.Drawing.Size(178, 36)
        Me.lblNumFinalizadas.Text = "0"
        '
        'lblTxtFinalizadas
        '
        Me.lblTxtFinalizadas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTxtFinalizadas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblTxtFinalizadas.Location = New System.Drawing.Point(16, 38)
        Me.lblTxtFinalizadas.Name = "lblTxtFinalizadas"
        Me.lblTxtFinalizadas.Size = New System.Drawing.Size(178, 24)
        Me.lblTxtFinalizadas.Text = "Finalizadas hoy"
        '
        'pnlBordeCardAverias
        '
        Me.pnlBordeCardAverias.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlBordeCardAverias.Controls.Add(Me.pnlBarraAverias)
        Me.pnlBordeCardAverias.Controls.Add(Me.pnlCardAverias)
        Me.pnlBordeCardAverias.Location = New System.Drawing.Point(452, 8)
        Me.pnlBordeCardAverias.Name = "pnlBordeCardAverias"
        Me.pnlBordeCardAverias.Padding = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.pnlBordeCardAverias.Size = New System.Drawing.Size(210, 74)
        Me.pnlBordeCardAverias.TabIndex = 0
        '
        'pnlBarraAverias
        '
        Me.pnlBarraAverias.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pnlBarraAverias.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBarraAverias.Location = New System.Drawing.Point(1, 0)
        Me.pnlBarraAverias.Name = "pnlBarraAverias"
        Me.pnlBarraAverias.Size = New System.Drawing.Size(208, 4)
        Me.pnlBarraAverias.TabIndex = 0
        '
        'pnlCardAverias
        '
        Me.pnlCardAverias.BackColor = System.Drawing.Color.White
        Me.pnlCardAverias.Controls.Add(Me.lblTxtAverias)
        Me.pnlCardAverias.Controls.Add(Me.lblNumAverias)
        Me.pnlCardAverias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCardAverias.Location = New System.Drawing.Point(1, 4)
        Me.pnlCardAverias.Name = "pnlCardAverias"
        Me.pnlCardAverias.Size = New System.Drawing.Size(208, 69)
        Me.pnlCardAverias.TabIndex = 1
        '
        'lblNumAverias
        '
        Me.lblNumAverias.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumAverias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblNumAverias.Location = New System.Drawing.Point(16, 0)
        Me.lblNumAverias.Name = "lblNumAverias"
        Me.lblNumAverias.Size = New System.Drawing.Size(178, 36)
        Me.lblNumAverias.Text = "0"
        '
        'lblTxtAverias
        '
        Me.lblTxtAverias.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTxtAverias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblTxtAverias.Location = New System.Drawing.Point(16, 38)
        Me.lblTxtAverias.Name = "lblTxtAverias"
        Me.lblTxtAverias.Size = New System.Drawing.Size(178, 24)
        Me.lblTxtAverias.Text = "Averías hoy"
        '
        'pnlFiltros
        '
        Me.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnlFiltros.Controls.Add(Me.btnActualizar)
        Me.pnlFiltros.Controls.Add(Me.dtpHasta)
        Me.pnlFiltros.Controls.Add(Me.lblHasta)
        Me.pnlFiltros.Controls.Add(Me.dtpDesde)
        Me.pnlFiltros.Controls.Add(Me.lblDesde)
        Me.pnlFiltros.Controls.Add(Me.cbxFiltroEstado)
        Me.pnlFiltros.Controls.Add(Me.lblFiltroEstado)
        Me.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltros.Location = New System.Drawing.Point(0, 176)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New System.Drawing.Size(980, 56)
        Me.pnlFiltros.Visible = False
        '
        'lblFiltroEstado
        '
        Me.lblFiltroEstado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltroEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblFiltroEstado.Location = New System.Drawing.Point(0, 16)
        Me.lblFiltroEstado.Name = "lblFiltroEstado"
        Me.lblFiltroEstado.Size = New System.Drawing.Size(50, 18)
        Me.lblFiltroEstado.Text = "Estado"
        '
        'cbxFiltroEstado
        '
        Me.cbxFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFiltroEstado.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFiltroEstado.FormattingEnabled = True
        Me.cbxFiltroEstado.Items.AddRange(New Object() {"Todos", "ACTIVO", "FINALIZADO", "AVERIADO"})
        Me.cbxFiltroEstado.Location = New System.Drawing.Point(54, 12)
        Me.cbxFiltroEstado.Name = "cbxFiltroEstado"
        Me.cbxFiltroEstado.Size = New System.Drawing.Size(140, 28)
        '
        'lblDesde
        '
        Me.lblDesde.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDesde.Location = New System.Drawing.Point(210, 16)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(50, 18)
        Me.lblDesde.Text = "Desde"
        '
        'dtpDesde
        '
        Me.dtpDesde.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(260, 12)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(120, 25)
        '
        'lblHasta
        '
        Me.lblHasta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblHasta.Location = New System.Drawing.Point(396, 16)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(46, 18)
        Me.lblHasta.Text = "Hasta"
        '
        'dtpHasta
        '
        Me.dtpHasta.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(444, 12)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(120, 25)
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
        Me.btnActualizar.Location = New System.Drawing.Point(580, 8)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(120, 36)
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'lblGrilla
        '
        Me.lblGrilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblGrilla.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGrilla.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrilla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblGrilla.Location = New System.Drawing.Point(0, 232)
        Me.lblGrilla.Name = "lblGrilla"
        Me.lblGrilla.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.lblGrilla.Size = New System.Drawing.Size(980, 32)
        Me.lblGrilla.Text = "Mis jornadas"
        '
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'dgvActividades
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
        Me.dgvActividades.AllowUserToAddRows = False
        Me.dgvActividades.AllowUserToDeleteRows = False
        Me.dgvActividades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvActividades.BackgroundColor = System.Drawing.Color.White
        Me.dgvActividades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvActividades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvActividades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvActividades.ColumnHeadersHeight = 36
        Me.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvActividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.operario, Me.fecha_inicio, Me.maquina, Me.zona, Me.horas_estimadas, Me.horas_reales, Me.combustible_final, Me.estado, Me.fecha_fin, Me.id_actividad, Me.id_maquinaria, Me.id_personal, Me.combustible_inicial, Me.motivo_retraso, Me.observacion_falla, Me.observacion})
        Me.dgvActividades.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvActividades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvActividades.EnableHeadersVisualStyles = False
        Me.dgvActividades.GridColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvActividades.Location = New System.Drawing.Point(0, 264)
        Me.dgvActividades.MinimumSize = New System.Drawing.Size(0, 220)
        Me.dgvActividades.MultiSelect = False
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.ReadOnly = True
        Me.dgvActividades.RowHeadersVisible = False
        Me.dgvActividades.RowTemplate.Height = 30
        Me.dgvActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActividades.Size = New System.Drawing.Size(640, 376)
        '
        'operario
        '
        Me.operario.DataPropertyName = "operario"
        Me.operario.HeaderText = "Operario"
        Me.operario.Name = "operario"
        '
        'fecha_inicio
        '
        Me.fecha_inicio.DataPropertyName = "fecha_inicio"
        Me.fecha_inicio.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
        Me.fecha_inicio.HeaderText = "Inicio"
        Me.fecha_inicio.Name = "fecha_inicio"
        '
        'maquina
        '
        Me.maquina.DataPropertyName = "maquina"
        Me.maquina.HeaderText = "Máquina"
        Me.maquina.Name = "maquina"
        '
        'zona
        '
        Me.zona.DataPropertyName = "zona"
        Me.zona.HeaderText = "Zona"
        Me.zona.Name = "zona"
        '
        'horas_estimadas
        '
        Me.horas_estimadas.DataPropertyName = "horas_estimadas"
        Me.horas_estimadas.DefaultCellStyle.Format = "0.0"
        Me.horas_estimadas.HeaderText = "Horas estimadas"
        Me.horas_estimadas.Name = "horas_estimadas"
        '
        'horas_reales
        '
        Me.horas_reales.DataPropertyName = "horas_reales"
        Me.horas_reales.DefaultCellStyle.Format = "0.0"
        Me.horas_reales.HeaderText = "Horas reales"
        Me.horas_reales.Name = "horas_reales"
        '
        'combustible_final
        '
        Me.combustible_final.DataPropertyName = "combustible_final"
        Me.combustible_final.HeaderText = "Combustible final"
        Me.combustible_final.Name = "combustible_final"
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        '
        'fecha_fin
        '
        Me.fecha_fin.DataPropertyName = "fecha_fin"
        Me.fecha_fin.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
        Me.fecha_fin.HeaderText = "Fin"
        Me.fecha_fin.Name = "fecha_fin"
        '
        'id_actividad
        '
        Me.id_actividad.DataPropertyName = "id_actividad"
        Me.id_actividad.HeaderText = "id_actividad"
        Me.id_actividad.Name = "id_actividad"
        Me.id_actividad.Visible = False
        '
        'id_maquinaria
        '
        Me.id_maquinaria.DataPropertyName = "id_maquinaria"
        Me.id_maquinaria.HeaderText = "id_maquinaria"
        Me.id_maquinaria.Name = "id_maquinaria"
        Me.id_maquinaria.Visible = False
        '
        'id_personal
        '
        Me.id_personal.DataPropertyName = "id_personal"
        Me.id_personal.HeaderText = "id_personal"
        Me.id_personal.Name = "id_personal"
        Me.id_personal.Visible = False
        '
        'combustible_inicial
        '
        Me.combustible_inicial.DataPropertyName = "combustible_inicial"
        Me.combustible_inicial.HeaderText = "combustible_inicial"
        Me.combustible_inicial.Name = "combustible_inicial"
        Me.combustible_inicial.Visible = False
        '
        'motivo_retraso
        '
        Me.motivo_retraso.DataPropertyName = "motivo_retraso"
        Me.motivo_retraso.HeaderText = "motivo_retraso"
        Me.motivo_retraso.Name = "motivo_retraso"
        Me.motivo_retraso.Visible = False
        '
        'observacion_falla
        '
        Me.observacion_falla.DataPropertyName = "observacion_falla"
        Me.observacion_falla.HeaderText = "observacion_falla"
        Me.observacion_falla.Name = "observacion_falla"
        Me.observacion_falla.Visible = False
        '
        'observacion
        '
        Me.observacion.DataPropertyName = "observacion"
        Me.observacion.HeaderText = "Observación"
        Me.observacion.Name = "observacion"
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).EndInit()
        '
        'lblSinDatos
        '
        Me.lblSinDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSinDatos.BackColor = System.Drawing.Color.White
        Me.lblSinDatos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinDatos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblSinDatos.Location = New System.Drawing.Point(0, 264)
        Me.lblSinDatos.Name = "lblSinDatos"
        Me.lblSinDatos.Size = New System.Drawing.Size(640, 376)
        Me.lblSinDatos.Text = "No hay jornadas registradas en el rango seleccionado."
        Me.lblSinDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSinDatos.Visible = False
        '
        'pnlDetalle
        '
        Me.pnlDetalle.AutoScroll = True
        Me.pnlDetalle.BackColor = System.Drawing.Color.White
        Me.pnlDetalle.Controls.Add(Me.txtDetFalla)
        Me.pnlDetalle.Controls.Add(Me.lblCapFalla)
        Me.pnlDetalle.Controls.Add(Me.txtDetMotivo)
        Me.pnlDetalle.Controls.Add(Me.lblCapMotivo)
        Me.pnlDetalle.Controls.Add(Me.lblDetCombFin)
        Me.pnlDetalle.Controls.Add(Me.lblCapCombFin)
        Me.pnlDetalle.Controls.Add(Me.lblDetCombIni)
        Me.pnlDetalle.Controls.Add(Me.lblCapCombIni)
        Me.pnlDetalle.Controls.Add(Me.lblDetHorasReales)
        Me.pnlDetalle.Controls.Add(Me.lblCapHorasReales)
        Me.pnlDetalle.Controls.Add(Me.lblDetHorasEst)
        Me.pnlDetalle.Controls.Add(Me.lblCapHorasEst)
        Me.pnlDetalle.Controls.Add(Me.lblDetFin)
        Me.pnlDetalle.Controls.Add(Me.lblCapFin)
        Me.pnlDetalle.Controls.Add(Me.lblDetInicio)
        Me.pnlDetalle.Controls.Add(Me.lblCapInicio)
        Me.pnlDetalle.Controls.Add(Me.lblDetEstado)
        Me.pnlDetalle.Controls.Add(Me.lblCapEstado)
        Me.pnlDetalle.Controls.Add(Me.lblDetZona)
        Me.pnlDetalle.Controls.Add(Me.lblCapZona)
        Me.pnlDetalle.Controls.Add(Me.lblDetMaquina)
        Me.pnlDetalle.Controls.Add(Me.lblCapMaquina)
        Me.pnlDetalle.Controls.Add(Me.lblDetOperario)
        Me.pnlDetalle.Controls.Add(Me.lblCapOperario)
        Me.pnlDetalle.Controls.Add(Me.lblDetalle)
        Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlDetalle.Location = New System.Drawing.Point(640, 64)
        Me.pnlDetalle.Name = "pnlDetalle"
        Me.pnlDetalle.Size = New System.Drawing.Size(340, 576)
        Me.pnlDetalle.Visible = False
        '
        'lblDetalle
        '
        Me.lblDetalle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetalle.Location = New System.Drawing.Point(16, 8)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(300, 24)
        Me.lblDetalle.Text = "Detalle de la jornada"
        '
        'lblCapOperario
        '
        Me.lblCapOperario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapOperario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblCapOperario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCapOperario.Location = New System.Drawing.Point(16, 40)
        Me.lblCapOperario.Name = "lblCapOperario"
        Me.lblCapOperario.Size = New System.Drawing.Size(300, 16)
        Me.lblCapOperario.Text = "Operario"
        '
        'lblDetOperario
        '
        Me.lblDetOperario.AutoEllipsis = True
        Me.lblDetOperario.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetOperario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDetOperario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetOperario.Location = New System.Drawing.Point(16, 56)
        Me.lblDetOperario.Name = "lblDetOperario"
        Me.lblDetOperario.Size = New System.Drawing.Size(300, 20)
        Me.lblDetOperario.Text = "-"
        '
        'lblCapMaquina
        '
        Me.lblCapMaquina.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapMaquina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblCapMaquina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCapMaquina.Location = New System.Drawing.Point(16, 84)
        Me.lblCapMaquina.Name = "lblCapMaquina"
        Me.lblCapMaquina.Size = New System.Drawing.Size(300, 16)
        Me.lblCapMaquina.Text = "Máquina"
        '
        'lblDetMaquina
        '
        Me.lblDetMaquina.AutoEllipsis = True
        Me.lblDetMaquina.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetMaquina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDetMaquina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetMaquina.Location = New System.Drawing.Point(16, 100)
        Me.lblDetMaquina.Name = "lblDetMaquina"
        Me.lblDetMaquina.Size = New System.Drawing.Size(300, 20)
        Me.lblDetMaquina.Text = "-"
        '
        'lblCapZona
        '
        Me.lblCapZona.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapZona.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblCapZona.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCapZona.Location = New System.Drawing.Point(16, 128)
        Me.lblCapZona.Name = "lblCapZona"
        Me.lblCapZona.Size = New System.Drawing.Size(300, 16)
        Me.lblCapZona.Text = "Zona"
        '
        'lblDetZona
        '
        Me.lblDetZona.AutoEllipsis = True
        Me.lblDetZona.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetZona.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDetZona.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetZona.Location = New System.Drawing.Point(16, 144)
        Me.lblDetZona.Name = "lblDetZona"
        Me.lblDetZona.Size = New System.Drawing.Size(300, 20)
        Me.lblDetZona.Text = "-"
        '
        'lblCapEstado
        '
        Me.lblCapEstado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblCapEstado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCapEstado.Location = New System.Drawing.Point(16, 172)
        Me.lblCapEstado.Name = "lblCapEstado"
        Me.lblCapEstado.Size = New System.Drawing.Size(300, 16)
        Me.lblCapEstado.Text = "Estado"
        '
        'lblDetEstado
        '
        Me.lblDetEstado.AutoEllipsis = True
        Me.lblDetEstado.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDetEstado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetEstado.Location = New System.Drawing.Point(16, 188)
        Me.lblDetEstado.Name = "lblDetEstado"
        Me.lblDetEstado.Size = New System.Drawing.Size(300, 20)
        Me.lblDetEstado.Text = "-"
        '
        'lblCapInicio
        '
        Me.lblCapInicio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblCapInicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCapInicio.Location = New System.Drawing.Point(16, 216)
        Me.lblCapInicio.Name = "lblCapInicio"
        Me.lblCapInicio.Size = New System.Drawing.Size(300, 16)
        Me.lblCapInicio.Text = "Inicio"
        '
        'lblDetInicio
        '
        Me.lblDetInicio.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDetInicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetInicio.Location = New System.Drawing.Point(16, 232)
        Me.lblDetInicio.Name = "lblDetInicio"
        Me.lblDetInicio.Size = New System.Drawing.Size(300, 20)
        Me.lblDetInicio.Text = "-"
        '
        'lblCapFin
        '
        Me.lblCapFin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapFin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblCapFin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCapFin.Location = New System.Drawing.Point(16, 260)
        Me.lblCapFin.Name = "lblCapFin"
        Me.lblCapFin.Size = New System.Drawing.Size(300, 16)
        Me.lblCapFin.Text = "Fin"
        '
        'lblDetFin
        '
        Me.lblDetFin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetFin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDetFin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetFin.Location = New System.Drawing.Point(16, 276)
        Me.lblDetFin.Name = "lblDetFin"
        Me.lblDetFin.Size = New System.Drawing.Size(300, 20)
        Me.lblDetFin.Text = "-"
        '
        'lblCapHorasEst
        '
        Me.lblCapHorasEst.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapHorasEst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblCapHorasEst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCapHorasEst.Location = New System.Drawing.Point(16, 304)
        Me.lblCapHorasEst.Name = "lblCapHorasEst"
        Me.lblCapHorasEst.Size = New System.Drawing.Size(300, 16)
        Me.lblCapHorasEst.Text = "Horas estimadas"
        '
        'lblDetHorasEst
        '
        Me.lblDetHorasEst.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetHorasEst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDetHorasEst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetHorasEst.Location = New System.Drawing.Point(16, 320)
        Me.lblDetHorasEst.Name = "lblDetHorasEst"
        Me.lblDetHorasEst.Size = New System.Drawing.Size(300, 20)
        Me.lblDetHorasEst.Text = "-"
        '
        'lblCapHorasReales
        '
        Me.lblCapHorasReales.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapHorasReales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblCapHorasReales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCapHorasReales.Location = New System.Drawing.Point(16, 348)
        Me.lblCapHorasReales.Name = "lblCapHorasReales"
        Me.lblCapHorasReales.Size = New System.Drawing.Size(300, 16)
        Me.lblCapHorasReales.Text = "Horas reales"
        '
        'lblDetHorasReales
        '
        Me.lblDetHorasReales.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetHorasReales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDetHorasReales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetHorasReales.Location = New System.Drawing.Point(16, 364)
        Me.lblDetHorasReales.Name = "lblDetHorasReales"
        Me.lblDetHorasReales.Size = New System.Drawing.Size(300, 20)
        Me.lblDetHorasReales.Text = "-"
        '
        'lblCapCombIni
        '
        Me.lblCapCombIni.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapCombIni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblCapCombIni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCapCombIni.Location = New System.Drawing.Point(16, 392)
        Me.lblCapCombIni.Name = "lblCapCombIni"
        Me.lblCapCombIni.Size = New System.Drawing.Size(300, 16)
        Me.lblCapCombIni.Text = "Comb. inicial"
        '
        'lblDetCombIni
        '
        Me.lblDetCombIni.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetCombIni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDetCombIni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetCombIni.Location = New System.Drawing.Point(16, 408)
        Me.lblDetCombIni.Name = "lblDetCombIni"
        Me.lblDetCombIni.Size = New System.Drawing.Size(300, 20)
        Me.lblDetCombIni.Text = "-"
        '
        'lblCapCombFin
        '
        Me.lblCapCombFin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapCombFin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblCapCombFin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCapCombFin.Location = New System.Drawing.Point(16, 436)
        Me.lblCapCombFin.Name = "lblCapCombFin"
        Me.lblCapCombFin.Size = New System.Drawing.Size(300, 16)
        Me.lblCapCombFin.Text = "Comb. final"
        '
        'lblDetCombFin
        '
        Me.lblDetCombFin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetCombFin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblDetCombFin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetCombFin.Location = New System.Drawing.Point(16, 452)
        Me.lblDetCombFin.Name = "lblDetCombFin"
        Me.lblDetCombFin.Size = New System.Drawing.Size(300, 20)
        Me.lblDetCombFin.Text = "-"
        '
        'lblCapMotivo
        '
        Me.lblCapMotivo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapMotivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblCapMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCapMotivo.Location = New System.Drawing.Point(16, 480)
        Me.lblCapMotivo.Name = "lblCapMotivo"
        Me.lblCapMotivo.Size = New System.Drawing.Size(300, 16)
        Me.lblCapMotivo.Text = "Motivo de retraso"
        '
        'txtDetMotivo
        '
        Me.txtDetMotivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtDetMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetMotivo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDetMotivo.Location = New System.Drawing.Point(16, 496)
        Me.txtDetMotivo.Multiline = True
        Me.txtDetMotivo.Name = "txtDetMotivo"
        Me.txtDetMotivo.ReadOnly = True
        Me.txtDetMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetMotivo.Size = New System.Drawing.Size(300, 70)
        '
        'lblCapFalla
        '
        Me.lblCapFalla.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapFalla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblCapFalla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCapFalla.Location = New System.Drawing.Point(16, 574)
        Me.lblCapFalla.Name = "lblCapFalla"
        Me.lblCapFalla.Size = New System.Drawing.Size(300, 16)
        Me.lblCapFalla.Text = "Observación de falla"
        '
        'txtDetFalla
        '
        Me.txtDetFalla.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtDetFalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetFalla.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetFalla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDetFalla.Location = New System.Drawing.Point(16, 590)
        Me.txtDetFalla.Multiline = True
        Me.txtDetFalla.Name = "txtDetFalla"
        Me.txtDetFalla.ReadOnly = True
        Me.txtDetFalla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetFalla.Size = New System.Drawing.Size(300, 70)
        '
        'frmActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 640)
        Me.Controls.Add(Me.dgvActividades)
        Me.Controls.Add(Me.lblSinDatos)
        Me.Controls.Add(Me.pnlDetalle)
        Me.Controls.Add(Me.lblGrilla)
        Me.Controls.Add(Me.pnlFiltros)
        Me.Controls.Add(Me.pnlResumen)
        Me.Controls.Add(Me.pnlControl)
        Me.Controls.Add(Me.pnlCheckin)
        Me.Controls.Add(Me.lblSubtitulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmActividad"
        Me.Text = "Actividad de maquinaria"
        CType(Me.nudHorasEstimadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHorasReales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCheckin.ResumeLayout(False)
        Me.pnlFinalizar.ResumeLayout(False)
        Me.pnlFinalizar.PerformLayout()
        Me.pnlIncidente.ResumeLayout(False)
        Me.pnlIncidente.PerformLayout()
        Me.pnlBordeIncidente.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.pnlCardActivas.ResumeLayout(False)
        Me.pnlBordeCardActivas.ResumeLayout(False)
        Me.pnlCardFinalizadas.ResumeLayout(False)
        Me.pnlBordeCardFinalizadas.ResumeLayout(False)
        Me.pnlCardAverias.ResumeLayout(False)
        Me.pnlBordeCardAverias.ResumeLayout(False)
        Me.pnlResumen.ResumeLayout(False)
        Me.pnlFiltros.ResumeLayout(False)
        Me.pnlDetalle.ResumeLayout(False)
        Me.pnlDetalle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tmrTranscurrido As Timer
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents pnlCheckin As Panel
    Friend WithEvents lblMiJornada As Label
    Friend WithEvents lblMaquina As Label
    Friend WithEvents cbxMaquina As ComboBox
    Friend WithEvents lblZona As Label
    Friend WithEvents cbxZona As ComboBox
    Friend WithEvents lblCombustibleInicial As Label
    Friend WithEvents lblTanque As Label
    Friend WithEvents lblNota As Label
    Friend WithEvents lblHorasEstimadas As Label
    Friend WithEvents nudHorasEstimadas As NumericUpDown
    Friend WithEvents btnIniciar As Button
    Friend WithEvents lblSinMaquinas As Label
    Friend WithEvents pnlControl As Panel
    Friend WithEvents lblMiJornadaControl As Label
    Friend WithEvents lblDatosJornada As Label
    Friend WithEvents pnlFinalizar As Panel
    Friend WithEvents lblFinalizar As Label
    Friend WithEvents lblCombustibleFinal As Label
    Friend WithEvents cbxCombustibleFinal As ComboBox
    Friend WithEvents lblAlerta As Label
    Friend WithEvents lblHorasReales As Label
    Friend WithEvents nudHorasReales As NumericUpDown
    Friend WithEvents lblMotivo As Label
    Friend WithEvents txtMotivo As TextBox
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents pnlBordeIncidente As Panel
    Friend WithEvents pnlIncidente As Panel
    Friend WithEvents lblIncidente As Label
    Friend WithEvents lblFalla As Label
    Friend WithEvents txtFalla As TextBox
    Friend WithEvents btnAveria As Button
    Friend WithEvents pnlResumen As Panel
    Friend WithEvents pnlBordeCardActivas As Panel
    Friend WithEvents pnlBarraActivas As Panel
    Friend WithEvents pnlCardActivas As Panel
    Friend WithEvents lblNumActivas As Label
    Friend WithEvents lblTxtActivas As Label
    Friend WithEvents pnlBordeCardFinalizadas As Panel
    Friend WithEvents pnlBarraFinalizadas As Panel
    Friend WithEvents pnlCardFinalizadas As Panel
    Friend WithEvents lblNumFinalizadas As Label
    Friend WithEvents lblTxtFinalizadas As Label
    Friend WithEvents pnlBordeCardAverias As Panel
    Friend WithEvents pnlBarraAverias As Panel
    Friend WithEvents pnlCardAverias As Panel
    Friend WithEvents lblNumAverias As Label
    Friend WithEvents lblTxtAverias As Label
    Friend WithEvents pnlFiltros As Panel
    Friend WithEvents lblFiltroEstado As Label
    Friend WithEvents cbxFiltroEstado As ComboBox
    Friend WithEvents lblDesde As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents lblHasta As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents btnActualizar As Button
    Friend WithEvents lblGrilla As Label
    Friend WithEvents dgvActividades As DataGridView
    Friend WithEvents lblSinDatos As Label
    Friend WithEvents pnlDetalle As Panel
    Friend WithEvents lblDetalle As Label
    Friend WithEvents lblCapOperario As Label
    Friend WithEvents lblDetOperario As Label
    Friend WithEvents lblCapMaquina As Label
    Friend WithEvents lblDetMaquina As Label
    Friend WithEvents lblCapZona As Label
    Friend WithEvents lblDetZona As Label
    Friend WithEvents lblCapEstado As Label
    Friend WithEvents lblDetEstado As Label
    Friend WithEvents lblCapInicio As Label
    Friend WithEvents lblDetInicio As Label
    Friend WithEvents lblCapFin As Label
    Friend WithEvents lblDetFin As Label
    Friend WithEvents lblCapHorasEst As Label
    Friend WithEvents lblDetHorasEst As Label
    Friend WithEvents lblCapHorasReales As Label
    Friend WithEvents lblDetHorasReales As Label
    Friend WithEvents lblCapCombIni As Label
    Friend WithEvents lblDetCombIni As Label
    Friend WithEvents lblCapCombFin As Label
    Friend WithEvents lblDetCombFin As Label
    Friend WithEvents lblCapMotivo As Label
    Friend WithEvents txtDetMotivo As TextBox
    Friend WithEvents lblCapFalla As Label
    Friend WithEvents txtDetFalla As TextBox
    Friend WithEvents operario As DataGridViewTextBoxColumn
    Friend WithEvents fecha_inicio As DataGridViewTextBoxColumn
    Friend WithEvents maquina As DataGridViewTextBoxColumn
    Friend WithEvents zona As DataGridViewTextBoxColumn
    Friend WithEvents horas_estimadas As DataGridViewTextBoxColumn
    Friend WithEvents horas_reales As DataGridViewTextBoxColumn
    Friend WithEvents combustible_final As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents fecha_fin As DataGridViewTextBoxColumn
    Friend WithEvents id_actividad As DataGridViewTextBoxColumn
    Friend WithEvents id_maquinaria As DataGridViewTextBoxColumn
    Friend WithEvents id_personal As DataGridViewTextBoxColumn
    Friend WithEvents combustible_inicial As DataGridViewTextBoxColumn
    Friend WithEvents motivo_retraso As DataGridViewTextBoxColumn
    Friend WithEvents observacion_falla As DataGridViewTextBoxColumn
    Friend WithEvents observacion As DataGridViewTextBoxColumn
End Class
