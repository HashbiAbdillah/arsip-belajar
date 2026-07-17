<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lojin
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(lojin))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(67, 103)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(446, 484)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Akira Expanded", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(708, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(295, 36)
        Label1.TabIndex = 1
        Label1.Text = "LOGIN DULU"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(561, 232)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 2
        Label2.Text = "USERNAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(561, 342)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 3
        Label3.Text = "PASSWORD"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(682, 229)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(460, 34)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(682, 328)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(460, 34)
        TextBox2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(620, 454)
        Button1.Name = "Button1"
        Button1.Size = New Size(230, 102)
        Button1.TabIndex = 6
        Button1.Text = "MASOK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(912, 454)
        Button2.Name = "Button2"
        Button2.Size = New Size(230, 102)
        Button2.TabIndex = 7
        Button2.Text = "KELUAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' lojin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1245, 697)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "lojin"
        Text = "login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
