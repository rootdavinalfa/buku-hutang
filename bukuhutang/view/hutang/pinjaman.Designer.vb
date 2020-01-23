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
        Me.components = New System.ComponentModel.Container()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblStatusPembayaran = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.inputBayarIDH = New System.Windows.Forms.TextBox()
        Me.inputBayarNama = New System.Windows.Forms.TextBox()
        Me.inputBayarIDKTP = New System.Windows.Forms.TextBox()
        Me.lblBayarTglTransaksi = New System.Windows.Forms.Label()
        Me.lblBayarNominal = New System.Windows.Forms.Label()
        Me.lblBungaBase = New System.Windows.Forms.Label()
        Me.lblExtraBunga = New System.Windows.Forms.Label()
        Me.lblTotalBunga = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblTotalTagihan = New System.Windows.Forms.Label()
        Me.lblTimeNow = New System.Windows.Forms.Label()
        Me.lblStatusLunas = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.inputBayar = New System.Windows.Forms.TextBox()
        Me.lblBayarTglHrsLunas = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.oneSec = New System.Windows.Forms.Timer(Me.components)
        Me.lblBayarSisa = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(786, 432)
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
        Me.TabPage1.Size = New System.Drawing.Size(778, 406)
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
        Me.TabPage3.Controls.Add(Me.lblBayarSisa)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.btnBayar)
        Me.TabPage3.Controls.Add(Me.lblBayarTglHrsLunas)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Controls.Add(Me.inputBayar)
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Controls.Add(Me.lblStatusLunas)
        Me.TabPage3.Controls.Add(Me.lblTimeNow)
        Me.TabPage3.Controls.Add(Me.lblTotalTagihan)
        Me.TabPage3.Controls.Add(Me.lblTotalBunga)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.lblExtraBunga)
        Me.TabPage3.Controls.Add(Me.lblBungaBase)
        Me.TabPage3.Controls.Add(Me.lblBayarNominal)
        Me.TabPage3.Controls.Add(Me.lblBayarTglTransaksi)
        Me.TabPage3.Controls.Add(Me.inputBayarIDKTP)
        Me.TabPage3.Controls.Add(Me.inputBayarNama)
        Me.TabPage3.Controls.Add(Me.inputBayarIDH)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.lblStatusPembayaran)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(778, 406)
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
        Me.TabPage2.Size = New System.Drawing.Size(778, 406)
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
        Me.dgvDataHutang.Size = New System.Drawing.Size(765, 312)
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
        Me.GroupBox2.Size = New System.Drawing.Size(656, 80)
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
        Me.GroupBox1.Size = New System.Drawing.Size(103, 80)
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ID Hutang"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Tanggal Transaksi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Nama Peminjam"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "ID Peminjam / KTP"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(447, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Nominal Pinjam"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(447, 171)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Bunga"
        '
        'lblStatusPembayaran
        '
        Me.lblStatusPembayaran.AutoSize = True
        Me.lblStatusPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblStatusPembayaran.Location = New System.Drawing.Point(611, 14)
        Me.lblStatusPembayaran.Name = "lblStatusPembayaran"
        Me.lblStatusPembayaran.Size = New System.Drawing.Size(161, 26)
        Me.lblStatusPembayaran.TabIndex = 6
        Me.lblStatusPembayaran.Text = "TELAT BAYAR"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 338)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Total Tagihan Pinjaman"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(447, 223)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Pertumbuhan Bunga"
        '
        'inputBayarIDH
        '
        Me.inputBayarIDH.Location = New System.Drawing.Point(130, 49)
        Me.inputBayarIDH.Name = "inputBayarIDH"
        Me.inputBayarIDH.Size = New System.Drawing.Size(285, 20)
        Me.inputBayarIDH.TabIndex = 0
        '
        'inputBayarNama
        '
        Me.inputBayarNama.Enabled = False
        Me.inputBayarNama.Location = New System.Drawing.Point(130, 85)
        Me.inputBayarNama.Name = "inputBayarNama"
        Me.inputBayarNama.Size = New System.Drawing.Size(285, 20)
        Me.inputBayarNama.TabIndex = 1
        '
        'inputBayarIDKTP
        '
        Me.inputBayarIDKTP.Enabled = False
        Me.inputBayarIDKTP.Location = New System.Drawing.Point(130, 125)
        Me.inputBayarIDKTP.Name = "inputBayarIDKTP"
        Me.inputBayarIDKTP.Size = New System.Drawing.Size(285, 20)
        Me.inputBayarIDKTP.TabIndex = 2
        '
        'lblBayarTglTransaksi
        '
        Me.lblBayarTglTransaksi.AutoSize = True
        Me.lblBayarTglTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBayarTglTransaksi.Location = New System.Drawing.Point(125, 159)
        Me.lblBayarTglTransaksi.Name = "lblBayarTglTransaksi"
        Me.lblBayarTglTransaksi.Size = New System.Drawing.Size(120, 26)
        Me.lblBayarTglTransaksi.TabIndex = 12
        Me.lblBayarTglTransaksi.Text = "2020/01/22"
        '
        'lblBayarNominal
        '
        Me.lblBayarNominal.AutoSize = True
        Me.lblBayarNominal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBayarNominal.Location = New System.Drawing.Point(445, 76)
        Me.lblBayarNominal.Name = "lblBayarNominal"
        Me.lblBayarNominal.Size = New System.Drawing.Size(154, 26)
        Me.lblBayarNominal.TabIndex = 13
        Me.lblBayarNominal.Text = "Rp.000.000,00"
        '
        'lblBungaBase
        '
        Me.lblBungaBase.AutoSize = True
        Me.lblBungaBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBungaBase.Location = New System.Drawing.Point(445, 190)
        Me.lblBungaBase.Name = "lblBungaBase"
        Me.lblBungaBase.Size = New System.Drawing.Size(74, 26)
        Me.lblBungaBase.TabIndex = 14
        Me.lblBungaBase.Text = "0.00%"
        '
        'lblExtraBunga
        '
        Me.lblExtraBunga.AutoSize = True
        Me.lblExtraBunga.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblExtraBunga.Location = New System.Drawing.Point(445, 247)
        Me.lblExtraBunga.Name = "lblExtraBunga"
        Me.lblExtraBunga.Size = New System.Drawing.Size(74, 26)
        Me.lblExtraBunga.TabIndex = 15
        Me.lblExtraBunga.Text = "0.00%"
        '
        'lblTotalBunga
        '
        Me.lblTotalBunga.AutoSize = True
        Me.lblTotalBunga.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTotalBunga.Location = New System.Drawing.Point(445, 306)
        Me.lblTotalBunga.Name = "lblTotalBunga"
        Me.lblTotalBunga.Size = New System.Drawing.Size(234, 26)
        Me.lblTotalBunga.TabIndex = 17
        Me.lblTotalBunga.Text = "0.00% / Rp.000.000,00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(447, 282)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 13)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Total Bunga"
        '
        'lblTotalTagihan
        '
        Me.lblTotalTagihan.AutoSize = True
        Me.lblTotalTagihan.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTotalTagihan.Location = New System.Drawing.Point(12, 362)
        Me.lblTotalTagihan.Name = "lblTotalTagihan"
        Me.lblTotalTagihan.Size = New System.Drawing.Size(154, 26)
        Me.lblTotalTagihan.TabIndex = 18
        Me.lblTotalTagihan.Text = "Rp.000.000,00"
        '
        'lblTimeNow
        '
        Me.lblTimeNow.AutoSize = True
        Me.lblTimeNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTimeNow.Location = New System.Drawing.Point(6, 3)
        Me.lblTimeNow.Name = "lblTimeNow"
        Me.lblTimeNow.Size = New System.Drawing.Size(120, 26)
        Me.lblTimeNow.TabIndex = 19
        Me.lblTimeNow.Text = "2020/01/22"
        '
        'lblStatusLunas
        '
        Me.lblStatusLunas.AutoSize = True
        Me.lblStatusLunas.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblStatusLunas.Location = New System.Drawing.Point(125, 252)
        Me.lblStatusLunas.Name = "lblStatusLunas"
        Me.lblStatusLunas.Size = New System.Drawing.Size(168, 26)
        Me.lblStatusLunas.TabIndex = 20
        Me.lblStatusLunas.Text = "BELUM LUNAS"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(201, 338)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 13)
        Me.Label24.TabIndex = 21
        Me.Label24.Text = "Dibayar"
        '
        'inputBayar
        '
        Me.inputBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.inputBayar.Location = New System.Drawing.Point(204, 362)
        Me.inputBayar.Name = "inputBayar"
        Me.inputBayar.Size = New System.Drawing.Size(322, 32)
        Me.inputBayar.TabIndex = 3
        '
        'lblBayarTglHrsLunas
        '
        Me.lblBayarTglHrsLunas.AutoSize = True
        Me.lblBayarTglHrsLunas.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBayarTglHrsLunas.Location = New System.Drawing.Point(125, 197)
        Me.lblBayarTglHrsLunas.Name = "lblBayarTglHrsLunas"
        Me.lblBayarTglHrsLunas.Size = New System.Drawing.Size(120, 26)
        Me.lblBayarTglHrsLunas.TabIndex = 24
        Me.lblBayarTglHrsLunas.Text = "2020/01/22"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 206)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(109, 13)
        Me.Label26.TabIndex = 23
        Me.Label26.Text = "Tanggal Harus Lunas"
        '
        'btnBayar
        '
        Me.btnBayar.Location = New System.Drawing.Point(532, 362)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(87, 32)
        Me.btnBayar.TabIndex = 4
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = True
        '
        'oneSec
        '
        '
        'lblBayarSisa
        '
        Me.lblBayarSisa.AutoSize = True
        Me.lblBayarSisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBayarSisa.Location = New System.Drawing.Point(445, 137)
        Me.lblBayarSisa.Name = "lblBayarSisa"
        Me.lblBayarSisa.Size = New System.Drawing.Size(154, 26)
        Me.lblBayarSisa.TabIndex = 26
        Me.lblBayarSisa.Text = "Rp.000.000,00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(447, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Sisa Hutang"
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
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
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
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblStatusPembayaran As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents inputBayarIDKTP As TextBox
    Friend WithEvents inputBayarNama As TextBox
    Friend WithEvents inputBayarIDH As TextBox
    Friend WithEvents lblBayarTglTransaksi As Label
    Friend WithEvents lblBayarNominal As Label
    Friend WithEvents lblBungaBase As Label
    Friend WithEvents lblExtraBunga As Label
    Friend WithEvents lblTotalTagihan As Label
    Friend WithEvents lblTotalBunga As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblTimeNow As Label
    Friend WithEvents lblStatusLunas As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents inputBayar As TextBox
    Friend WithEvents lblBayarTglHrsLunas As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents btnBayar As Button
    Friend WithEvents oneSec As Timer
    Friend WithEvents lblBayarSisa As Label
    Friend WithEvents Label17 As Label
End Class
