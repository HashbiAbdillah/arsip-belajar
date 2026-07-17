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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 20)
        Label1.TabIndex = 0
        Label1.Text = "KODE BARANG"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 20)
        Label2.TabIndex = 1
        Label2.Text = "NAMA BARANG"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(48, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 2
        Label3.Text = "SATUAN"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(48, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 20)
        Label4.TabIndex = 3
        Label4.Text = "HARGA SATUAN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(48, 282)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 20)
        Label5.TabIndex = 4
        Label5.Text = "JUMLAH"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(48, 342)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 20)
        Label6.TabIndex = 5
        Label6.Text = "TOTAL HARGA"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(178, 56)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(521, 27)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(178, 109)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(521, 27)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(178, 171)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(521, 27)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(178, 226)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(521, 27)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(178, 282)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(521, 27)
        TextBox5.TabIndex = 10
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(178, 342)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(521, 27)
        TextBox6.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(178, 416)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 80)
        Button1.TabIndex = 12
        Button1.Text = "HITUNG"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(317, 416)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 80)
        Button2.TabIndex = 13
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(550, 416)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 80)
        Button3.TabIndex = 14
        Button3.Text = "EXIT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 551)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
