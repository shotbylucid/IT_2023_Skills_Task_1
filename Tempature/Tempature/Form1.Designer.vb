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
        btn_Clear = New Button()
        btn_Known = New Button()
        btn_Close = New Button()
        txt_Input = New TextBox()
        txt_Output = New TextBox()
        SuspendLayout()
        ' 
        ' btn_Clear
        ' 
        btn_Clear.Location = New Point(145, 275)
        btn_Clear.Name = "btn_Clear"
        btn_Clear.Size = New Size(150, 46)
        btn_Clear.TabIndex = 0
        btn_Clear.Text = "Clear"
        btn_Clear.UseVisualStyleBackColor = True
        ' 
        ' btn_Known
        ' 
        btn_Known.Location = New Point(301, 275)
        btn_Known.Name = "btn_Known"
        btn_Known.Size = New Size(202, 46)
        btn_Known.TabIndex = 1
        btn_Known.Text = "Known"
        btn_Known.UseVisualStyleBackColor = True
        ' 
        ' btn_Close
        ' 
        btn_Close.Location = New Point(509, 275)
        btn_Close.Name = "btn_Close"
        btn_Close.Size = New Size(150, 46)
        btn_Close.TabIndex = 2
        btn_Close.Text = "Close"
        btn_Close.UseVisualStyleBackColor = True
        ' 
        ' txt_Input
        ' 
        txt_Input.Location = New Point(145, 199)
        txt_Input.Name = "txt_Input"
        txt_Input.Size = New Size(514, 39)
        txt_Input.TabIndex = 3
        ' 
        ' txt_Output
        ' 
        txt_Output.Location = New Point(145, 410)
        txt_Output.Name = "txt_Output"
        txt_Output.ReadOnly = True
        txt_Output.Size = New Size(514, 39)
        txt_Output.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.Unknown
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(800, 450)
        Controls.Add(txt_Output)
        Controls.Add(txt_Input)
        Controls.Add(btn_Close)
        Controls.Add(btn_Known)
        Controls.Add(btn_Clear)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Known As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents txt_Input As TextBox
    Friend WithEvents txt_Output As TextBox
End Class
