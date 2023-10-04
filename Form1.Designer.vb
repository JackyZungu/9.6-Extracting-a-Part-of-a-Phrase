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
        lbEnterStrtPos = New Label()
        lbNoCharExtract = New Label()
        lbTxtExtracted = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        lbEnterPhrase = New Label()
        btnExtract = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' lbEnterStrtPos
        ' 
        lbEnterStrtPos.AutoSize = True
        lbEnterStrtPos.Location = New Point(33, 105)
        lbEnterStrtPos.Name = "lbEnterStrtPos"
        lbEnterStrtPos.Size = New Size(180, 20)
        lbEnterStrtPos.TabIndex = 0
        lbEnterStrtPos.Text = "Enter the Starting Position"
        ' 
        ' lbNoCharExtract
        ' 
        lbNoCharExtract.AutoSize = True
        lbNoCharExtract.Location = New Point(10, 141)
        lbNoCharExtract.Name = "lbNoCharExtract"
        lbNoCharExtract.Size = New Size(203, 20)
        lbNoCharExtract.TabIndex = 0
        lbNoCharExtract.Text = "Number Characters to Extract"
        ' 
        ' lbTxtExtracted
        ' 
        lbTxtExtracted.AutoSize = True
        lbTxtExtracted.Location = New Point(47, 185)
        lbTxtExtracted.Name = "lbTxtExtracted"
        lbTxtExtracted.Size = New Size(102, 20)
        lbTxtExtracted.TabIndex = 0
        lbTxtExtracted.Text = "Text Extracted"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(219, 54)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(208, 27)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(219, 98)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(208, 27)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(219, 134)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(208, 27)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(219, 178)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(208, 27)
        TextBox4.TabIndex = 4
        ' 
        ' lbEnterPhrase
        ' 
        lbEnterPhrase.AutoSize = True
        lbEnterPhrase.Location = New Point(47, 61)
        lbEnterPhrase.Name = "lbEnterPhrase"
        lbEnterPhrase.Size = New Size(106, 20)
        lbEnterPhrase.TabIndex = 0
        lbEnterPhrase.Text = "Enter a Phrase "
        ' 
        ' btnExtract
        ' 
        btnExtract.Location = New Point(247, 272)
        btnExtract.Name = "btnExtract"
        btnExtract.Size = New Size(94, 29)
        btnExtract.TabIndex = 5
        btnExtract.Text = "Extract"
        btnExtract.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExtract)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(lbTxtExtracted)
        Controls.Add(lbNoCharExtract)
        Controls.Add(lbEnterPhrase)
        Controls.Add(lbEnterStrtPos)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Extracting a Part of a Phrase"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbEnterStrtPos As Label
    Friend WithEvents lbNoCharExtract As Label
    Friend WithEvents lbTxtExtracted As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lbEnterPhrase As Label
    Friend WithEvents btnExtract As Button
End Class
