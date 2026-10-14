Public Module modEstilos
    Public Sub EstilizarGrilla(dgv As DataGridView)
        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.RowHeadersVisible = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.MultiSelect = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.BorderStyle = BorderStyle.None
        dgv.BackgroundColor = Color.White
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgv.ColumnHeadersHeight = 36
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(91, 127, 177)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 10.0!)
        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(91, 127, 177)
        dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        dgv.RowTemplate.Height = 30
        dgv.DefaultCellStyle.Font = New Font("Segoe UI", 10.0!)
        dgv.DefaultCellStyle.ForeColor = Color.FromArgb(45, 52, 54)
        dgv.DefaultCellStyle.BackColor = Color.White
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(238, 243, 251)
        dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(45, 52, 54)
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251)
        dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(238, 243, 251)
        dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(45, 52, 54)
        dgv.GridColor = Color.FromArgb(220, 221, 225)
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
    End Sub

    Public Sub EstilizarBotonPrimario(btn As Button)
        AplicarBase(btn)
        btn.BackColor = Color.FromArgb(91, 127, 177)
        btn.ForeColor = Color.White
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 106, 153)
        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 106, 153)
    End Sub

    Public Sub EstilizarBotonPeligro(btn As Button)
        AplicarBase(btn)
        btn.BackColor = Color.FromArgb(192, 57, 43)
        btn.ForeColor = Color.White
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 45, 35)
        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 45, 35)
    End Sub

    Public Sub EstilizarBotonExito(btn As Button)
        AplicarBase(btn)
        btn.BackColor = Color.FromArgb(39, 174, 96)
        btn.ForeColor = Color.White
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 148, 82)
        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 148, 82)
    End Sub

    Public Sub EstilizarBotonSecundario(btn As Button)
        AplicarBase(btn)
        btn.BackColor = Color.White
        btn.ForeColor = Color.FromArgb(45, 52, 54)
        btn.FlatAppearance.BorderSize = 1
        btn.FlatAppearance.BorderColor = Color.FromArgb(220, 221, 225)
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 246, 249)
        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(244, 246, 249)
    End Sub

    Private Sub AplicarBase(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.Cursor = Cursors.Hand
        btn.Height = 36
        btn.Font = New Font("Segoe UI Semibold", 10.0!)
        btn.UseVisualStyleBackColor = False
    End Sub
End Module
