<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class peminjam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.inputKTP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBuat = New System.Windows.Forms.Button()
        Me.lblIDPeminjam = New System.Windows.Forms.Label()
        Me.inputTelepon = New System.Windows.Forms.TextBox()
        Me.inputAlamat = New System.Windows.Forms.TextBox()
        Me.inputNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvDataPeminjam = New System.Windows.Forms.DataGridView()
        Me.inputFind = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDataPeminjam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.inputKTP)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnBuat)
        Me.GroupBox1.Controls.Add(Me.lblIDPeminjam)
        Me.GroupBox1.Controls.Add(Me.inputTelepon)
        Me.GroupBox1.Controls.Add(Me.inputAlamat)
        Me.GroupBox1.Controls.Add(Me.inputNama)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 238)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buat Data Peminjam"
        '
        'inputKTP
        '
        Me.inputKTP.Location = New System.Drawing.Point(100, 49)
        Me.inputKTP.Name = "inputKTP"
        Me.inputKTP.Size = New System.Drawing.Size(207, 20)
        Me.inputKTP.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "NO KTP"
        '
        'btnBuat
        '
        Me.btnBuat.Location = New System.Drawing.Point(100, 210)
        Me.btnBuat.Name = "btnBuat"
        Me.btnBuat.Size = New System.Drawing.Size(207, 23)
        Me.btnBuat.TabIndex = 5
        Me.btnBuat.Text = "Buat Peminjam Baru"
        Me.btnBuat.UseVisualStyleBackColor = True
        '
        'lblIDPeminjam
        '
        Me.lblIDPeminjam.AutoSize = True
        Me.lblIDPeminjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblIDPeminjam.Location = New System.Drawing.Point(97, 16)
        Me.lblIDPeminjam.Name = "lblIDPeminjam"
        Me.lblIDPeminjam.Size = New System.Drawing.Size(99, 24)
        Me.lblIDPeminjam.TabIndex = 15
        Me.lblIDPeminjam.Text = "%%IDS%%"
        '
        'inputTelepon
        '
        Me.inputTelepon.Location = New System.Drawing.Point(100, 182)
        Me.inputTelepon.Name = "inputTelepon"
        Me.inputTelepon.Size = New System.Drawing.Size(207, 20)
        Me.inputTelepon.TabIndex = 4
        '
        'inputAlamat
        '
        Me.inputAlamat.Location = New System.Drawing.Point(100, 99)
        Me.inputAlamat.Multiline = True
        Me.inputAlamat.Name = "inputAlamat"
        Me.inputAlamat.Size = New System.Drawing.Size(207, 74)
        Me.inputAlamat.TabIndex = 3
        '
        'inputNama
        '
        Me.inputNama.Location = New System.Drawing.Point(100, 74)
        Me.inputNama.Name = "inputNama"
        Me.inputNama.Size = New System.Drawing.Size(207, 20)
        Me.inputNama.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nomor Telepon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID Peminjam"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dgvDataPeminjam)
        Me.GroupBox2.Controls.Add(Me.inputFind)
        Me.GroupBox2.Controls.Add(Me.btnFind)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 255)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Peminjam"
        '
        'dgvDataPeminjam
        '
        Me.dgvDataPeminjam.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDataPeminjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataPeminjam.Location = New System.Drawing.Point(9, 50)
        Me.dgvDataPeminjam.Name = "dgvDataPeminjam"
        Me.dgvDataPeminjam.Size = New System.Drawing.Size(557, 205)
        Me.dgvDataPeminjam.TabIndex = 18
        '
        'inputFind
        '
        Me.inputFind.Location = New System.Drawing.Point(302, 22)
        Me.inputFind.Name = "inputFind"
        Me.inputFind.Size = New System.Drawing.Size(212, 20)
        Me.inputFind.TabIndex = 17
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(520, 20)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(52, 23)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(100, 20)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(9, 20)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(181, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "No KTP / ID Peminjam"
        '
        'peminjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 507)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "peminjam"
        Me.Text = "1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvDataPeminjam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblIDPeminjam As Label
    Friend WithEvents inputTelepon As TextBox
    Friend WithEvents inputAlamat As TextBox
    Friend WithEvents inputNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBuat As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents inputFind As TextBox
    Friend WithEvents dgvDataPeminjam As DataGridView
    Friend WithEvents inputKTP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
