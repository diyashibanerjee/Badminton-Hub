<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnChatBot = New System.Windows.Forms.Button()
        Me.btnStore = New System.Windows.Forms.Button()
        Me.btnBookSlot = New System.Windows.Forms.Button()
        Me.lblWelcone = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(402, 464)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(85, 23)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnProfile
        '
        Me.btnProfile.BackgroundImage = CType(resources.GetObject("btnProfile.BackgroundImage"), System.Drawing.Image)
        Me.btnProfile.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.Location = New System.Drawing.Point(55, 152)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(146, 96)
        Me.btnProfile.TabIndex = 1
        Me.btnProfile.Text = "PROFILE"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnChatBot
        '
        Me.btnChatBot.BackgroundImage = CType(resources.GetObject("btnChatBot.BackgroundImage"), System.Drawing.Image)
        Me.btnChatBot.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChatBot.Location = New System.Drawing.Point(55, 318)
        Me.btnChatBot.Name = "btnChatBot"
        Me.btnChatBot.Size = New System.Drawing.Size(146, 96)
        Me.btnChatBot.TabIndex = 2
        Me.btnChatBot.Text = "CHATBOT"
        Me.btnChatBot.UseVisualStyleBackColor = True
        '
        'btnStore
        '
        Me.btnStore.BackgroundImage = CType(resources.GetObject("btnStore.BackgroundImage"), System.Drawing.Image)
        Me.btnStore.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStore.Location = New System.Drawing.Point(271, 318)
        Me.btnStore.Name = "btnStore"
        Me.btnStore.Size = New System.Drawing.Size(146, 96)
        Me.btnStore.TabIndex = 3
        Me.btnStore.Text = "STORE"
        Me.btnStore.UseVisualStyleBackColor = True
        '
        'btnBookSlot
        '
        Me.btnBookSlot.BackgroundImage = CType(resources.GetObject("btnBookSlot.BackgroundImage"), System.Drawing.Image)
        Me.btnBookSlot.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookSlot.Location = New System.Drawing.Point(271, 152)
        Me.btnBookSlot.Name = "btnBookSlot"
        Me.btnBookSlot.Size = New System.Drawing.Size(146, 96)
        Me.btnBookSlot.TabIndex = 4
        Me.btnBookSlot.Text = "BOOK YOUR SLOT"
        Me.btnBookSlot.UseVisualStyleBackColor = True
        '
        'lblWelcone
        '
        Me.lblWelcone.AutoSize = True
        Me.lblWelcone.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcone.Location = New System.Drawing.Point(165, 105)
        Me.lblWelcone.Name = "lblWelcone"
        Me.lblWelcone.Size = New System.Drawing.Size(58, 18)
        Me.lblWelcone.TabIndex = 5
        Me.lblWelcone.Text = "Label1"
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(499, 499)
        Me.Controls.Add(Me.lblWelcone)
        Me.Controls.Add(Me.btnBookSlot)
        Me.Controls.Add(Me.btnStore)
        Me.Controls.Add(Me.btnChatBot)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.btnLogout)
        Me.Name = "HomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "homeform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnChatBot As Button
    Friend WithEvents btnStore As Button
    Friend WithEvents btnBookSlot As Button
    Friend WithEvents lblWelcone As Label
End Class
