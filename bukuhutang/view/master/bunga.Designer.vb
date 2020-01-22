<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bunga
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inputBungaAwal = New System.Windows.Forms.TextBox()
        Me.inputPertumbuhanBunga = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bunga Awal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pertumbuhan Bunga Jika Gagal Bayar"
        '
        'inputBungaAwal
        '
        Me.inputBungaAwal.Location = New System.Drawing.Point(12, 29)
        Me.inputBungaAwal.Name = "inputBungaAwal"
        Me.inputBungaAwal.Size = New System.Drawing.Size(187, 20)
        Me.inputBungaAwal.TabIndex = 2
        '
        'inputPertumbuhanBunga
        '
        Me.inputPertumbuhanBunga.Location = New System.Drawing.Point(12, 93)
        Me.inputPertumbuhanBunga.Name = "inputPertumbuhanBunga"
        Me.inputPertumbuhanBunga.Size = New System.Drawing.Size(187, 20)
        Me.inputPertumbuhanBunga.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(124, 135)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'bunga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 184)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.inputPertumbuhanBunga)
        Me.Controls.Add(Me.inputBungaAwal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "bunga"
        Me.Text = "Setting Bunga"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents inputBungaAwal As TextBox
    Friend WithEvents inputPertumbuhanBunga As TextBox
    Friend WithEvents btnSave As Button
End Class
