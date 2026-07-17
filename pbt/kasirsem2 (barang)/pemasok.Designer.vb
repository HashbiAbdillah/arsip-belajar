<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pemasok
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
        dg_pms = New DataGridView()
        Button4 = New Button()
        hapus = New Button()
        Button2 = New Button()
        BtnSimpan = New Button()
        TextBox5 = New TextBox()
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
        TextBox6 = New TextBox()
        CType(dg_pms, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dg_pms
        ' 
        dg_pms.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dg_pms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dg_pms.Location = New Point(159, 406)
        dg_pms.Name = "dg_pms"
        dg_pms.RowHeadersWidth = 51
        dg_pms.RowTemplate.Height = 29
        dg_pms.Size = New Size(826, 188)
        dg_pms.TabIndex = 37
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(891, 291)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 36
        Button4.Text = "KELUAR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' hapus
        ' 
        hapus.Location = New Point(891, 235)
        hapus.Name = "hapus"
        hapus.Size = New Size(94, 29)
        hapus.TabIndex = 35
        hapus.Text = "HAPUS"
        hapus.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(891, 179)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 34
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(891, 122)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(94, 29)
        BtnSimpan.TabIndex = 33
        BtnSimpan.Text = "SIMPAN"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(353, 364)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(429, 27)
        TextBox5.TabIndex = 31
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(353, 313)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(429, 27)
        TextBox4.TabIndex = 30
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(353, 265)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(429, 27)
        TextBox3.TabIndex = 29
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(353, 169)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(429, 27)
        TextBox2.TabIndex = 28
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(353, 116)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(429, 27)
        TextBox1.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(159, 364)
        Label8.Name = "Label8"
        Label8.Size = New Size(122, 20)
        Label8.TabIndex = 26
        Label8.Text = "EMAIL PEMASOK"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(159, 313)
        Label7.Name = "Label7"
        Label7.Size = New Size(135, 20)
        Label7.TabIndex = 25
        Label7.Text = "PERSON PEMASOK"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(159, 265)
        Label6.Name = "Label6"
        Label6.Size = New Size(141, 20)
        Label6.TabIndex = 24
        Label6.Text = "TELEPON PEMASOK"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(159, 265)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 20)
        Label5.TabIndex = 23
        Label5.Text = " "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(159, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 20)
        Label4.TabIndex = 22
        Label4.Text = "ALAMAT PEMASOK"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(159, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 20)
        Label3.TabIndex = 21
        Label3.Text = "NAMA PEMASOK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(159, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 20)
        Label2.TabIndex = 20
        Label2.Text = "KODE PEMASOK"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(541, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 20)
        Label1.TabIndex = 19
        Label1.Text = "FORM DATA PEMASOK"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(353, 215)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(429, 27)
        TextBox6.TabIndex = 38
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1144, 665)
        Controls.Add(TextBox6)
        Controls.Add(dg_pms)
        Controls.Add(Button4)
        Controls.Add(hapus)
        Controls.Add(Button2)
        Controls.Add(BtnSimpan)
        Controls.Add(TextBox5)
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
        Name = "Form2"
        Text = "Form2"
        CType(dg_pms, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dg_pms As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents hapus As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents TextBox5 As TextBox
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
    Friend WithEvents TextBox6 As TextBox
End Class
