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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ImageAlign = ContentAlignment.MiddleRight
        Label1.Location = New Point(12, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(230, 32)
        Label1.TabIndex = 0
        Label1.Text = "angka pertama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ImageAlign = ContentAlignment.MiddleRight
        Label2.Location = New Point(12, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(198, 32)
        Label2.TabIndex = 1
        Label2.Text = "angka kedua"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(264, 57)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(524, 27)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(264, 106)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(524, 27)
        TextBox2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ImageAlign = ContentAlignment.MiddleRight
        Label3.Location = New Point(12, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 32)
        Label3.TabIndex = 4
        Label3.Text = "hasil"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(264, 170)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(524, 27)
        TextBox3.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(22, 276)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 83)
        Button2.TabIndex = 7
        Button2.Text = "+"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(135, 276)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 83)
        Button3.TabIndex = 8
        Button3.Text = "-"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(249, 276)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 83)
        Button4.TabIndex = 9
        Button4.Text = "x"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(369, 276)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 83)
        Button5.TabIndex = 10
        Button5.Text = ":"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(766, 276)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 83)
        Button6.TabIndex = 11
        Button6.Text = "C"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(639, 276)
        Button7.Name = "Button7"
        Button7.Size = New Size(94, 83)
        Button7.TabIndex = 13
        Button7.Text = "mod"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(505, 276)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 83)
        Button1.TabIndex = 14
        Button1.Text = "div"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(883, 449)
        Controls.Add(Button1)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button1 As Button
End Class
