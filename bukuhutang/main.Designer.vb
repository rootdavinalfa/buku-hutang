<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuatDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingBungaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HutangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HutangBaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_total_dpinjam = New System.Windows.Forms.Label()
        Me.label_perkiraan = New System.Windows.Forms.Label()
        Me.lbl_saldo_now = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chartBestCredit = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.chartBestCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.HutangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(783, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuatDataToolStripMenuItem, Me.SettingBungaToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'BuatDataToolStripMenuItem
        '
        Me.BuatDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeminjamToolStripMenuItem})
        Me.BuatDataToolStripMenuItem.Name = "BuatDataToolStripMenuItem"
        Me.BuatDataToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.BuatDataToolStripMenuItem.Text = "Buat Data"
        '
        'PeminjamToolStripMenuItem
        '
        Me.PeminjamToolStripMenuItem.Name = "PeminjamToolStripMenuItem"
        Me.PeminjamToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.PeminjamToolStripMenuItem.Text = "Peminjam"
        '
        'SettingBungaToolStripMenuItem
        '
        Me.SettingBungaToolStripMenuItem.Name = "SettingBungaToolStripMenuItem"
        Me.SettingBungaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SettingBungaToolStripMenuItem.Text = "Setting Bunga"
        '
        'HutangToolStripMenuItem
        '
        Me.HutangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HutangBaruToolStripMenuItem})
        Me.HutangToolStripMenuItem.Name = "HutangToolStripMenuItem"
        Me.HutangToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.HutangToolStripMenuItem.Text = "Hutang"
        '
        'HutangBaruToolStripMenuItem
        '
        Me.HutangBaruToolStripMenuItem.Name = "HutangBaruToolStripMenuItem"
        Me.HutangBaruToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.HutangBaruToolStripMenuItem.Text = "Pinjaman"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lbl_total_dpinjam)
        Me.GroupBox1.Controls.Add(Me.label_perkiraan)
        Me.GroupBox1.Controls.Add(Me.lbl_saldo_now)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 189)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Summary"
        '
        'lbl_total_dpinjam
        '
        Me.lbl_total_dpinjam.AutoSize = True
        Me.lbl_total_dpinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_total_dpinjam.Location = New System.Drawing.Point(550, 42)
        Me.lbl_total_dpinjam.Name = "lbl_total_dpinjam"
        Me.lbl_total_dpinjam.Size = New System.Drawing.Size(136, 20)
        Me.lbl_total_dpinjam.TabIndex = 14
        Me.lbl_total_dpinjam.Text = "Rp.1.000.000.000"
        '
        'label_perkiraan
        '
        Me.label_perkiraan.AutoSize = True
        Me.label_perkiraan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label_perkiraan.Location = New System.Drawing.Point(550, 86)
        Me.label_perkiraan.Name = "label_perkiraan"
        Me.label_perkiraan.Size = New System.Drawing.Size(136, 20)
        Me.label_perkiraan.TabIndex = 13
        Me.label_perkiraan.Text = "Rp.1.000.000.000"
        '
        'lbl_saldo_now
        '
        Me.lbl_saldo_now.AutoSize = True
        Me.lbl_saldo_now.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_saldo_now.Location = New System.Drawing.Point(550, 136)
        Me.lbl_saldo_now.Name = "lbl_saldo_now"
        Me.lbl_saldo_now.Size = New System.Drawing.Size(136, 20)
        Me.lbl_saldo_now.TabIndex = 12
        Me.lbl_saldo_now.Text = "Rp.1.000.000.000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Saldo Saat Ini"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(439, 40)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Perkiraan Keuntungan dari bunga 5% " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dengan pertumbuhan 0.2% jika tidak lunas saa" &
    "t jatuh tempo!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Dana Yang Saat Ini Dipinjam"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.chartBestCredit)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(761, 215)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "3 Besar Yang Berhutang"
        '
        'chartBestCredit
        '
        Me.chartBestCredit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.chartBestCredit.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartBestCredit.Legends.Add(Legend1)
        Me.chartBestCredit.Location = New System.Drawing.Point(6, 19)
        Me.chartBestCredit.Name = "chartBestCredit"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartBestCredit.Series.Add(Series1)
        Me.chartBestCredit.Size = New System.Drawing.Size(749, 192)
        Me.chartBestCredit.TabIndex = 5
        Me.chartBestCredit.Text = "Chart1"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 442)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.chartBestCredit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuatDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeminjamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HutangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HutangBaruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingBungaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_total_dpinjam As Label
    Friend WithEvents label_perkiraan As Label
    Friend WithEvents lbl_saldo_now As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chartBestCredit As DataVisualization.Charting.Chart
End Class
