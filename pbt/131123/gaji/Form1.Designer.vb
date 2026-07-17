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
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(67, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 0
        Label1.Text = "NAMA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(67, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 1
        Label2.Text = "GAJI POKOK"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(67, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 20)
        Label3.TabIndex = 2
        Label3.Text = "STATUS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(67, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 20)
        Label4.TabIndex = 3
        Label4.Text = "JUMLAH ANAK"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(67, 204)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 20)
        Label5.TabIndex = 4
        Label5.Text = "TUNJANGAN ISTRI"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(67, 246)
        Label6.Name = "Label6"
        Label6.Size = New Size(139, 20)
        Label6.TabIndex = 5
        Label6.Text = "TUNJANGAN ANAK"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(68, 284)
        Label7.Name = "Label7"
        Label7.Size = New Size(58, 20)
        Label7.TabIndex = 6
        Label7.Text = "BONUS"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(68, 332)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 20)
        Label8.TabIndex = 7
        Label8.Text = "TOTAL GAJI"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(68, 375)
        Label9.Name = "Label9"
        Label9.Size = New Size(36, 20)
        Label9.TabIndex = 8
        Label9.Text = "PPH"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(68, 421)
        Label10.Name = "Label10"
        Label10.Size = New Size(92, 20)
        Label10.TabIndex = 9
        Label10.Text = "GAJI BERSIH"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(239, 42)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(147, 27)
        TextBox1.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(239, 85)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(147, 27)
        TextBox2.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(239, 162)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(147, 27)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(239, 204)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(147, 27)
        TextBox4.TabIndex = 13
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(239, 243)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(147, 27)
        TextBox5.TabIndex = 14
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(239, 284)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(147, 27)
        TextBox6.TabIndex = 15
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(239, 325)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(147, 27)
        TextBox7.TabIndex = 16
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(239, 375)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(147, 27)
        TextBox8.TabIndex = 17
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(239, 421)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(147, 27)
        TextBox9.TabIndex = 18
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"menikah", "belum menikah"})
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"menikah", "belum menikah"})
        ComboBox1.Location = New Point(235, 130)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 19
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(148, 487)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 20
        Button1.Text = "HITUNG"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(282, 487)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 21
        Button2.Text = "SAVE"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 544)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
