<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class barang
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        ComboBox1 = New ComboBox()
        BtnSimpan = New Button()
        Button2 = New Button()
        hapus = New Button()
        Button4 = New Button()
        dg_barang = New DataGridView()
        CType(dg_barang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(477, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 20)
        Label1.TabIndex = 0
        Label1.Text = "FORM DATA BARANG"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(95, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 20)
        Label2.TabIndex = 1
        Label2.Text = "KODE BARANG"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(95, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 20)
        Label3.TabIndex = 2
        Label3.Text = "NAMA BARANG"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(95, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 20)
        Label4.TabIndex = 3
        Label4.Text = "SATUAN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(95, 243)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 20)
        Label5.TabIndex = 4
        Label5.Text = " "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(95, 243)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 20)
        Label6.TabIndex = 5
        Label6.Text = "JUMLAH BARANG"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(95, 291)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 20)
        Label7.TabIndex = 6
        Label7.Text = "STOK MINIMAL"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(95, 342)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 20)
        Label8.TabIndex = 7
        Label8.Text = "HARGA"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(289, 94)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(429, 27)
        TextBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(289, 147)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(429, 27)
        TextBox2.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(289, 243)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(429, 27)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(289, 291)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(429, 27)
        TextBox4.TabIndex = 11
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(289, 342)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(429, 27)
        TextBox5.TabIndex = 12
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"PCS", "PAKET"})
        ComboBox1.Location = New Point(289, 196)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(429, 28)
        ComboBox1.TabIndex = 13
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(827, 100)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(94, 29)
        BtnSimpan.TabIndex = 14
        BtnSimpan.Text = "SIMPAN"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(827, 157)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 15
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' hapus
        ' 
        hapus.Location = New Point(827, 213)
        hapus.Name = "hapus"
        hapus.Size = New Size(94, 29)
        hapus.TabIndex = 16
        hapus.Text = "HAPUS"
        hapus.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(827, 269)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 17
        Button4.Text = "KELUAR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' dg_barang
        ' 
        dg_barang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dg_barang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dg_barang.Location = New Point(95, 375)
        dg_barang.Name = "dg_barang"
        dg_barang.RowHeadersWidth = 51
        dg_barang.RowTemplate.Height = 29
        dg_barang.Size = New Size(826, 188)
        dg_barang.TabIndex = 18
        ' 
        ' barang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 647)
        Controls.Add(dg_barang)
        Controls.Add(Button4)
        Controls.Add(hapus)
        Controls.Add(Button2)
        Controls.Add(BtnSimpan)
        Controls.Add(ComboBox1)
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
        Name = "barang"
        Text = "Form1"
        CType(dg_barang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents hapus As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents dg_barang As DataGridView
End Class
