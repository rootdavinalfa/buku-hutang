<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pinjaman
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnBuatHutang = New System.Windows.Forms.Button()
        Me.inputSaldo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.inputTarget = New System.Windows.Forms.DateTimePicker()
        Me.inputNote = New System.Windows.Forms.TextBox()
        Me.inputNominal = New System.Windows.Forms.TextBox()
        Me.inputKTPID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvDataHutang = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbFind = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.inputIDHPminjam = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDataHutang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(786, 426)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnBuatHutang)
        Me.TabPage1.Controls.Add(Me.inputSaldo)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lblNama)
        Me.TabPage1.Controls.Add(Me.inputTarget)
        Me.TabPage1.Controls.Add(Me.inputNote)
        Me.TabPage1.Controls.Add(Me.inputNominal)
        Me.TabPage1.Controls.Add(Me.inputKTPID)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(778, 400)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Buat Hutang Baru"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnBuatHutang
        '
        Me.btnBuatHutang.Location = New System.Drawing.Point(141, 322)
        Me.btnBuatHutang.Name = "btnBuatHutang"
        Me.btnBuatHutang.Size = New System.Drawing.Size(75, 23)
        Me.btnBuatHutang.TabIndex = 12
        Me.btnBuatHutang.Text = "Buat Hutang"
        Me.btnBuatHutang.UseVisualStyleBackColor = True
        '
        'inputSaldo
        '
        Me.inputSaldo.Enabled = False
        Me.inputSaldo.Location = New System.Drawing.Point(141, 141)
        Me.inputSaldo.Name = "inputSaldo"
        Me.inputSaldo.Size = New System.Drawing.Size(266, 20)
        Me.inputSaldo.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Saldo Tersisa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Nama"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblNama.ForeColor = System.Drawing.Color.Red
        Me.lblNama.Location = New System.Drawing.Point(137, 48)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(21, 24)
        Me.lblNama.TabIndex = 8
        Me.lblNama.Text = """'"
        '
        'inputTarget
        '
        Me.inputTarget.Location = New System.Drawing.Point(141, 98)
        Me.inputTarget.Name = "inputTarget"
        Me.inputTarget.Size = New System.Drawing.Size(266, 20)
        Me.inputTarget.TabIndex = 7
        '
        'inputNote
        '
        Me.inputNote.Location = New System.Drawing.Point(141, 220)
        Me.inputNote.Name = "inputNote"
        Me.inputNote.Size = New System.Drawing.Size(266, 20)
        Me.inputNote.TabIndex = 6
        '
        'inputNominal
        '
        Me.inputNominal.Location = New System.Drawing.Point(141, 180)
        Me.inputNominal.Name = "inputNominal"
        Me.inputNominal.Size = New System.Drawing.Size(266, 20)
        Me.inputNominal.TabIndex = 5
        '
        'inputKTPID
        '
        Me.inputKTPID.Location = New System.Drawing.Point(141, 13)
        Me.inputKTPID.Name = "inputKTPID"
        Me.inputKTPID.Size = New System.Drawing.Size(266, 20)
        Me.inputKTPID.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Note"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nominal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Target Tanggal Bayar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No KTP / ID Peminjam"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(778, 400)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Bayar Hutang"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvDataHutang)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(778, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Data Hutang"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvDataHutang
        '
        Me.dgvDataHutang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDataHutang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataHutang.Location = New System.Drawing.Point(7, 88)
        Me.dgvDataHutang.Name = "dgvDataHutang"
        Me.dgvDataHutang.Size = New System.Drawing.Size(765, 306)
        Me.dgvDataHutang.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cbFind)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnShow)
        Me.GroupBox2.Controls.Add(Me.inputIDHPminjam)
        Me.GroupBox2.Location = New System.Drawing.Point(116, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 74)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Table"
        '
        'cbFind
        '
        Me.cbFind.AutoSize = True
        Me.cbFind.Location = New System.Drawing.Point(10, 20)
        Me.cbFind.Name = "cbFind"
        Me.cbFind.Size = New System.Drawing.Size(70, 17)
        Me.cbFind.TabIndex = 6
        Me.cbFind.Text = "Cari Data"
        Me.cbFind.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Cari Data (ID Hutang / ID Peminjam /KTP)"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(575, 20)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Find"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'inputIDHPminjam
        '
        Me.inputIDHPminjam.Location = New System.Drawing.Point(221, 45)
        Me.inputIDHPminjam.Name = "inputIDHPminjam"
        Me.inputIDHPminjam.Size = New System.Drawing.Size(294, 20)
        Me.inputIDHPminjam.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 74)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(6, 20)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'pinjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "pinjaman"
        Me.Text = "pinjaman"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvDataHutang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents inputNote As TextBox
    Friend WithEvents inputNominal As TextBox
    Friend WithEvents inputKTPID As TextBox
    Friend WithEvents inputTarget As DateTimePicker
    Friend WithEvents lblNama As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents inputIDHPminjam As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvDataHutang As DataGridView
    Friend WithEvents cbFind As CheckBox
    Friend WithEvents inputSaldo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuatHutang As Button
    Friend WithEvents TabPage3 As TabPage
End Class
