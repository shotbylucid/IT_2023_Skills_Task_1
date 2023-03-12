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
        btnClear = New Button()
        btnKnown = New Button()
        btnClose = New Button()
        txtInput = New TextBox()
        txtOutput = New TextBox()
        SuspendLayout()
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(145, 208)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(150, 46)
        btnClear.TabIndex = 0
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnKnown
        ' 
        btnKnown.Location = New Point(328, 208)
        btnKnown.Name = "btnKnown"
        btnKnown.Size = New Size(150, 46)
        btnKnown.TabIndex = 1
        btnKnown.Text = "Known"
        btnKnown.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(509, 208)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(150, 46)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(145, 130)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(514, 39)
        txtInput.TabIndex = 3
        ' 
        ' txtOutput
        ' 
        txtOutput.Location = New Point(145, 289)
        txtOutput.Name = "txtOutput"
        txtOutput.ReadOnly = True
        txtOutput.Size = New Size(514, 39)
        txtOutput.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtOutput)
        Controls.Add(txtInput)
        Controls.Add(btnClose)
        Controls.Add(btnKnown)
        Controls.Add(btnClear)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnKnown As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtOutput As TextBox
End Class
