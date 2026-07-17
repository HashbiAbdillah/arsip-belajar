<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pelanggan
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
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        CType(dg_pms, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(346, 220)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(429, 27)
        TextBox6.TabIndex = 57
        ' 
        ' dg_pms
        ' 
        dg_pms.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dg_pms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dg_pms.Location = New Point(152, 411)
        dg_pms.Name = "dg_pms"
        dg_pms.RowHeadersWidth = 51
        dg_pms.RowTemplate.Height = 29
        dg_pms.Size = New Size(826, 188)
        dg_pms.TabIndex = 56
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(884, 296)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 55
        Button4.Text = "KELUAR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' hapus
        ' 
        hapus.Location = New Point(884, 240)
        hapus.Name = "hapus"
        hapus.Size = New Size(94, 29)
        hapus.TabIndex = 54
        hapus.Text = "HAPUS"
        hapus.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(884, 184)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 53
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(884, 127)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(94, 29)
        BtnSimpan.TabIndex = 52
        BtnSimpan.Text = "SIMPAN"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(346, 318)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(429, 27)
        TextBox4.TabIndex = 50
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(346, 270)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(429, 27)
        TextBox3.TabIndex = 49
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(346, 174)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(429, 27)
        TextBox2.TabIndex = 48
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(346, 121)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(429, 27)
        TextBox1.TabIndex = 47
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(152, 369)
        Label8.Name = "Label8"
        Label8.Size = New Size(111, 20)
        Label8.TabIndex = 46
        Label8.Text = "JENIS KELAMIN"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(152, 318)
        Label7.Name = "Label7"
        Label7.Size = New Size(140, 20)
        Label7.TabIndex = 45
        Label7.Text = "EMAIL PELANGGAN"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(152, 270)
        Label6.Name = "Label6"
        Label6.Size = New Size(159, 20)
        Label6.TabIndex = 44
        Label6.Text = "TELEPON PELANGGAN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(152, 270)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 20)
        Label5.TabIndex = 43
        Label5.Text = " "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(152, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 20)
        Label4.TabIndex = 42
        Label4.Text = "ALAMAT PELANGGAN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(152, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 20)
        Label3.TabIndex = 41
        Label3.Text = "NAMA PELANGGAN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(152, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 20)
        Label2.TabIndex = 40
        Label2.Text = "KODE PELANGGAN"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(534, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 20)
        Label1.TabIndex = 39
        Label1.Text = "FORM DATA PELANGGAN"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"CWK", "CWK", "HELIKOPTER"})
        ComboBox1.Location = New Point(346, 366)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(429, 28)
        ComboBox1.TabIndex = 58
        ' 
        ' pelanggan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1130, 656)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox6)
        Controls.Add(dg_pms)
        Controls.Add(Button4)
        Controls.Add(hapus)
        Controls.Add(Button2)
        Controls.Add(BtnSimpan)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "pelanggan"
        Text = "Form4"
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
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
