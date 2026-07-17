<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detailterima
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
        TextBox5 = New TextBox()
        dg_barang = New DataGridView()
        Button4 = New Button()
        hapus = New Button()
        Button2 = New Button()
        BtnSimpan = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        CType(dg_barang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox5
        ' 
        TextBox5.Enabled = False
        TextBox5.Location = New Point(397, 204)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(429, 27)
        TextBox5.TabIndex = 55
        ' 
        ' dg_barang
        ' 
        dg_barang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dg_barang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dg_barang.Location = New Point(203, 363)
        dg_barang.Name = "dg_barang"
        dg_barang.RowHeadersWidth = 51
        dg_barang.RowTemplate.Height = 29
        dg_barang.Size = New Size(826, 188)
        dg_barang.TabIndex = 54
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(935, 280)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 53
        Button4.Text = "KELUAR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' hapus
        ' 
        hapus.Location = New Point(935, 224)
        hapus.Name = "hapus"
        hapus.Size = New Size(94, 29)
        hapus.TabIndex = 52
        hapus.Text = "HAPUS"
        hapus.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(935, 168)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 51
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(935, 111)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(94, 29)
        BtnSimpan.TabIndex = 50
        BtnSimpan.Text = "SIMPAN"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(397, 302)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(429, 27)
        TextBox4.TabIndex = 49
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(397, 254)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(429, 27)
        TextBox3.TabIndex = 48
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(203, 302)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 20)
        Label7.TabIndex = 46
        Label7.Text = "STOK AKHIR"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(203, 254)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 20)
        Label6.TabIndex = 45
        Label6.Text = "QTY TERIMA"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(203, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 20)
        Label5.TabIndex = 44
        Label5.Text = " "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(203, 207)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 43
        Label4.Text = "STOK AWAL"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(203, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 20)
        Label3.TabIndex = 42
        Label3.Text = "KODE BARANG"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(203, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 20)
        Label2.TabIndex = 41
        Label2.Text = "NOMOR TERIMA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(527, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 20)
        Label1.TabIndex = 40
        Label1.Text = "INFORMASI DETAIL TERIMA"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {""})
        ComboBox1.Location = New Point(397, 150)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(429, 28)
        ComboBox1.TabIndex = 58
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(397, 98)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(429, 28)
        ComboBox2.TabIndex = 59
        ' 
        ' detailterima
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1233, 588)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox5)
        Controls.Add(dg_barang)
        Controls.Add(Button4)
        Controls.Add(hapus)
        Controls.Add(Button2)
        Controls.Add(BtnSimpan)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "detailterima"
        Text = "detailterima"
        CType(dg_barang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents dg_barang As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents hapus As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
