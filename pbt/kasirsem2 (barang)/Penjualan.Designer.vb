<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan
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
        DateTimePicker1 = New DateTimePicker()
        TextBox6 = New TextBox()
        dg_pms = New DataGridView()
        Button4 = New Button()
        hapus = New Button()
        Button2 = New Button()
        BtnSimpan = New Button()
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
        TextBox2 = New TextBox()
        TextBox7 = New TextBox()
        Label9 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label10 = New Label()
        CType(dg_pms, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(254, 121)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(305, 27)
        DateTimePicker1.TabIndex = 97
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(254, 172)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(305, 27)
        TextBox6.TabIndex = 95
        ' 
        ' dg_pms
        ' 
        dg_pms.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dg_pms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dg_pms.Location = New Point(157, 267)
        dg_pms.Name = "dg_pms"
        dg_pms.RowHeadersWidth = 51
        dg_pms.RowTemplate.Height = 29
        dg_pms.Size = New Size(1003, 188)
        dg_pms.TabIndex = 94
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(983, 515)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 93
        Button4.Text = "KELUAR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' hapus
        ' 
        hapus.Location = New Point(824, 222)
        hapus.Name = "hapus"
        hapus.Size = New Size(94, 29)
        hapus.TabIndex = 92
        hapus.Text = "HAPUS"
        hapus.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(983, 471)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 91
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(960, 222)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(94, 29)
        BtnSimpan.TabIndex = 90
        BtnSimpan.Text = "SIMPAN"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(254, 222)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(305, 27)
        TextBox3.TabIndex = 88
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(254, 73)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(305, 27)
        TextBox1.TabIndex = 87
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(605, 126)
        Label8.Name = "Label8"
        Label8.Size = New Size(136, 20)
        Label8.TabIndex = 86
        Label8.Text = "KODE PELANGGAN"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(605, 73)
        Label7.Name = "Label7"
        Label7.Size = New Size(113, 20)
        Label7.TabIndex = 85
        Label7.Text = "KODE PEMAKAI"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(60, 222)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 20)
        Label6.TabIndex = 84
        Label6.Text = "TOTAL"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(60, 222)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 20)
        Label5.TabIndex = 83
        Label5.Text = " "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(60, 175)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 20)
        Label4.TabIndex = 82
        Label4.Text = "ITEM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 81
        Label3.Text = "TANGGAL "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 20)
        Label2.TabIndex = 80
        Label2.Text = "FAKTUR"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(544, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 20)
        Label1.TabIndex = 79
        Label1.Text = "FORM DATA PENJUALAN"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(489, 473)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(429, 27)
        TextBox2.TabIndex = 98
        ' 
        ' TextBox7
        ' 
        TextBox7.Enabled = False
        TextBox7.Location = New Point(489, 516)
        TextBox7.Name = "TextBox7"
        TextBox7.ReadOnly = True
        TextBox7.Size = New Size(429, 27)
        TextBox7.TabIndex = 100
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(371, 519)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 20)
        Label9.TabIndex = 99
        Label9.Text = "KEMBALI"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(778, 65)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(429, 28)
        ComboBox1.TabIndex = 101
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(778, 121)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(429, 28)
        ComboBox2.TabIndex = 102
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(371, 480)
        Label10.Name = "Label10"
        Label10.Size = New Size(68, 20)
        Label10.TabIndex = 103
        Label10.Text = "DIBAYAR"
        ' 
        ' Penjualan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1305, 574)
        Controls.Add(Label10)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox7)
        Controls.Add(Label9)
        Controls.Add(TextBox2)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox6)
        Controls.Add(dg_pms)
        Controls.Add(Button4)
        Controls.Add(hapus)
        Controls.Add(Button2)
        Controls.Add(BtnSimpan)
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
        Name = "Penjualan"
        Text = "Penjualan"
        CType(dg_pms, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents dg_pms As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents hapus As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnSimpan As Button
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
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label10 As Label
End Class
