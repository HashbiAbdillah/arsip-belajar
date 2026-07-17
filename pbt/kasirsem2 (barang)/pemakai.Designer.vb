<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pemakai
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
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
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
        TextBox6.Location = New Point(375, 195)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(429, 27)
        TextBox6.TabIndex = 57
        ' 
        ' dg_pms
        ' 
        dg_pms.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dg_pms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dg_pms.Location = New Point(181, 321)
        dg_pms.Name = "dg_pms"
        dg_pms.RowHeadersWidth = 51
        dg_pms.RowTemplate.Height = 29
        dg_pms.Size = New Size(826, 188)
        dg_pms.TabIndex = 56
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(884, 224)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 55
        Button4.Text = "KELUAR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' hapus
        ' 
        hapus.Location = New Point(884, 189)
        hapus.Name = "hapus"
        hapus.Size = New Size(94, 29)
        hapus.TabIndex = 54
        hapus.Text = "HAPUS"
        hapus.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(884, 149)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 53
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(884, 114)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(94, 29)
        BtnSimpan.TabIndex = 52
        BtnSimpan.Text = "SIMPAN"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(375, 149)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(429, 27)
        TextBox2.TabIndex = 48
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(375, 96)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(429, 27)
        TextBox1.TabIndex = 47
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(181, 246)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 20)
        Label6.TabIndex = 44
        Label6.Text = "STATUS PEMAKAI"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(181, 246)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 20)
        Label5.TabIndex = 43
        Label5.Text = " "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(181, 198)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 20)
        Label4.TabIndex = 42
        Label4.Text = "PASS PEMAKAI"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(181, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 20)
        Label3.TabIndex = 41
        Label3.Text = "NAMA PEMAKAI"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(181, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 20)
        Label2.TabIndex = 40
        Label2.Text = "KODE PEMAKAI"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(563, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 20)
        Label1.TabIndex = 39
        Label1.Text = "FORM DATA PEMAKAI"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"ADMIN", "KASIR", "PETUGAS"})
        ComboBox1.Location = New Point(375, 246)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(429, 28)
        ComboBox1.TabIndex = 58
        ' 
        ' pemakai
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1189, 607)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox6)
        Controls.Add(dg_pms)
        Controls.Add(Button4)
        Controls.Add(hapus)
        Controls.Add(Button2)
        Controls.Add(BtnSimpan)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "pemakai"
        Text = "Form5"
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
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
