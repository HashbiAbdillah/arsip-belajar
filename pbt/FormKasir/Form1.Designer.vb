<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox5 = New TextBox()
        Label6 = New Label()
        TextBox6 = New TextBox()
        Label7 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        dg_barang = New DataGridView()
        ComboBox1 = New ComboBox()
        CType(dg_barang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(110, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 20)
        Label1.TabIndex = 0
        Label1.Text = "KODE BARANG"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(278, 90)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(362, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(110, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 20)
        Label2.TabIndex = 0
        Label2.Text = "NAMA BARANG"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(110, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 0
        Label3.Text = "SATUAN"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(278, 134)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(362, 27)
        TextBox2.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(110, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 20)
        Label4.TabIndex = 0
        Label4.Text = "JUMLAH BARANG"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(278, 226)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(362, 27)
        TextBox4.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(110, 279)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 20)
        Label5.TabIndex = 0
        Label5.Text = "STOK MINIMAL"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(278, 272)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(362, 27)
        TextBox5.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(110, 332)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 20)
        Label6.TabIndex = 0
        Label6.Text = "HARGA"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(278, 325)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(362, 27)
        TextBox6.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(509, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(131, 23)
        Label7.TabIndex = 0
        Label7.Text = "DATA BARANG"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.GradientActiveCaption
        Button1.Location = New Point(761, 109)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 30)
        Button1.TabIndex = 2
        Button1.Text = "save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonFace
        Button2.Location = New Point(761, 163)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 30)
        Button2.TabIndex = 3
        Button2.Text = "edit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(761, 223)
        Button3.Name = "Button3"
        Button3.Size = New Size(108, 30)
        Button3.TabIndex = 4
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ScrollBar
        Button4.Location = New Point(761, 279)
        Button4.Name = "Button4"
        Button4.Size = New Size(108, 30)
        Button4.TabIndex = 5
        Button4.Text = "exit"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' dg_barang
        ' 
        dg_barang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dg_barang.Location = New Point(110, 379)
        dg_barang.Name = "dg_barang"
        dg_barang.RowHeadersWidth = 51
        dg_barang.RowTemplate.Height = 29
        dg_barang.Size = New Size(759, 269)
        dg_barang.TabIndex = 6
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"PCS", "PACK"})
        ComboBox1.Location = New Point(278, 181)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(362, 28)
        ComboBox1.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1065, 672)
        Controls.Add(ComboBox1)
        Controls.Add(dg_barang)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dg_barang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents dg_barang As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
End Class
