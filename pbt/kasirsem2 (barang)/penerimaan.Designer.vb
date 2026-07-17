<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class penerimaan
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
        TextBox6 = New TextBox()
        dg_pms = New DataGridView()
        Button4 = New Button()
        hapus = New Button()
        Button2 = New Button()
        BtnSimpan = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox1 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox5 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        CType(dg_pms, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(349, 188)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(429, 27)
        TextBox6.TabIndex = 76
        ' 
        ' dg_pms
        ' 
        dg_pms.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dg_pms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dg_pms.Location = New Point(146, 380)
        dg_pms.Name = "dg_pms"
        dg_pms.RowHeadersWidth = 51
        dg_pms.RowTemplate.Height = 29
        dg_pms.Size = New Size(858, 188)
        dg_pms.TabIndex = 75
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(887, 264)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 74
        Button4.Text = "KELUAR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' hapus
        ' 
        hapus.Location = New Point(887, 208)
        hapus.Name = "hapus"
        hapus.Size = New Size(94, 29)
        hapus.TabIndex = 73
        hapus.Text = "HAPUS"
        hapus.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(887, 152)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 72
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(887, 95)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(94, 29)
        BtnSimpan.TabIndex = 71
        BtnSimpan.Text = "SIMPAN"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(349, 286)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(429, 27)
        TextBox4.TabIndex = 70
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(349, 238)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(429, 27)
        TextBox3.TabIndex = 69
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(349, 89)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(429, 27)
        TextBox1.TabIndex = 67
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(155, 337)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 20)
        Label8.TabIndex = 66
        Label8.Text = "KODE PEMAKAI"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(155, 286)
        Label7.Name = "Label7"
        Label7.Size = New Size(106, 20)
        Label7.TabIndex = 65
        Label7.Text = "TOTAL TERIMA"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(155, 238)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 20)
        Label6.TabIndex = 64
        Label6.Text = "NOMOR BON"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(155, 238)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 20)
        Label5.TabIndex = 63
        Label5.Text = " "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(155, 191)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 20)
        Label4.TabIndex = 62
        Label4.Text = "KODE PEMASOK"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(155, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 20)
        Label3.TabIndex = 61
        Label3.Text = "TANGGAL PENERIMAAN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(155, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 20)
        Label2.TabIndex = 60
        Label2.Text = "KODE PENERIMAAN"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(537, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 20)
        Label1.TabIndex = 59
        Label1.Text = "FORM DATA PENERIMAAN"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(349, 337)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(429, 27)
        TextBox5.TabIndex = 77
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(349, 137)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(429, 27)
        DateTimePicker1.TabIndex = 78
        ' 
        ' penerimaan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1136, 593)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox6)
        Controls.Add(dg_pms)
        Controls.Add(Button4)
        Controls.Add(hapus)
        Controls.Add(Button2)
        Controls.Add(BtnSimpan)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "penerimaan"
        Text = "penerimaan"
        CType(dg_pms, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents dg_pms As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents hapus As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
