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
        TxtNim = New TextBox()
        TxtNama = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        ListView1 = New ListView()
        CMBJK = New ComboBox()
        Label4 = New Label()
        CMBPRODI = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(69, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 20)
        Label1.TabIndex = 0
        Label1.Text = "NIM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(69, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 1
        Label2.Text = "NAMA"
        ' 
        ' TxtNim
        ' 
        TxtNim.Location = New Point(211, 61)
        TxtNim.Name = "TxtNim"
        TxtNim.Size = New Size(514, 27)
        TxtNim.TabIndex = 2
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(211, 140)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(514, 27)
        TxtNama.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(69, 219)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 20)
        Label3.TabIndex = 5
        Label3.Text = "PRODI"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(631, 296)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 6
        Button1.Text = "TAMBAH"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(69, 355)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(656, 226)
        ListView1.TabIndex = 7
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' CMBJK
        ' 
        CMBJK.FormattingEnabled = True
        CMBJK.Location = New Point(211, 296)
        CMBJK.Name = "CMBJK"
        CMBJK.Size = New Size(151, 28)
        CMBJK.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(69, 296)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 20)
        Label4.TabIndex = 10
        Label4.Text = "JENIS KELAMIN"
        ' 
        ' CMBPRODI
        ' 
        CMBPRODI.FormattingEnabled = True
        CMBPRODI.Location = New Point(211, 219)
        CMBPRODI.Name = "CMBPRODI"
        CMBPRODI.Size = New Size(151, 28)
        CMBPRODI.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 775)
        Controls.Add(CMBPRODI)
        Controls.Add(Label4)
        Controls.Add(CMBJK)
        Controls.Add(ListView1)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(TxtNama)
        Controls.Add(TxtNim)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNim As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents CMBJK As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CMBPRODI As ComboBox
End Class
