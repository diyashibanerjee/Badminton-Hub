<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatbotForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChatbotForm))
        Me.rtbChatHistory = New System.Windows.Forms.RichTextBox()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rtbChatHistory
        '
        Me.rtbChatHistory.Location = New System.Drawing.Point(23, 190)
        Me.rtbChatHistory.Name = "rtbChatHistory"
        Me.rtbChatHistory.Size = New System.Drawing.Size(420, 155)
        Me.rtbChatHistory.TabIndex = 0
        Me.rtbChatHistory.Text = ""
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(219, 391)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(100, 22)
        Me.txtUserInput.TabIndex = 1
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(368, 387)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(95, 26)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "SEARCH"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(412, 464)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 3
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 395)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TYPE YOUR QUESTION"
        '
        'ChatbotForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(499, 499)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.rtbChatHistory)
        Me.Controls.Add(Me.btnSend)
        Me.Name = "ChatbotForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChatbotForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbChatHistory As RichTextBox
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Label1 As Label
End Class
