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
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btn_Clear
        ' 
        btn_Clear.Location = New Point(134, 258)
        btn_Clear.Name = "btn_Clear"
        btn_Clear.Size = New Size(138, 43)
        btn_Clear.TabIndex = 0
        btn_Clear.Text = "Clear"
        btn_Clear.UseVisualStyleBackColor = True
        ' 
        ' btn_Known
        ' 
        btn_Known.Location = New Point(278, 258)
        btn_Known.Name = "btn_Known"
        btn_Known.Size = New Size(186, 43)
        btn_Known.TabIndex = 1
        btn_Known.Text = "Known"
        btn_Known.UseVisualStyleBackColor = True
        ' 
        ' btn_Close
        ' 
        btn_Close.Location = New Point(470, 258)
        btn_Close.Name = "btn_Close"
        btn_Close.Size = New Size(138, 43)
        btn_Close.TabIndex = 2
        btn_Close.Text = "Close"
        btn_Close.UseVisualStyleBackColor = True
        ' 
        ' txt_Input
        ' 
        txt_Input.Location = New Point(134, 187)
        txt_Input.Name = "txt_Input"
        txt_Input.Size = New Size(475, 35)
        txt_Input.TabIndex = 3
        ' 
        ' txt_Output
        ' 
        txt_Output.Location = New Point(134, 384)
        txt_Output.Name = "txt_Output"
        txt_Output.ReadOnly = True
        txt_Output.Size = New Size(475, 35)
        txt_Output.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(327, 154)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 30)
        Label1.TabIndex = 5
        Label1.Text = "Input"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(327, 351)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 30)
        Label2.TabIndex = 6
        Label2.Text = "Output"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.Unknown
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(738, 422)
        Controls.Add(Label2)
        Controls.Add(Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
