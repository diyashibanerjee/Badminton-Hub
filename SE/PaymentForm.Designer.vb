<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbtnUPI = New System.Windows.Forms.RadioButton()
        Me.rbtnCard = New System.Windows.Forms.RadioButton()
        Me.rbtnCash = New System.Windows.Forms.RadioButton()
        Me.btnConfirmPayment = New System.Windows.Forms.Button()
        Me.txtFeedback = New System.Windows.Forms.TextBox()
        Me.btnSubmitFeedback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CHOOSE YOUR PAYMENT METHOD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(237, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PLEASE ENTER YOUR FEEDBACK"
        '
        'rbtnUPI
        '
        Me.rbtnUPI.AutoSize = True
        Me.rbtnUPI.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUPI.Location = New System.Drawing.Point(22, 111)
        Me.rbtnUPI.Name = "rbtnUPI"
        Me.rbtnUPI.Size = New System.Drawing.Size(53, 21)
        Me.rbtnUPI.TabIndex = 2
        Me.rbtnUPI.TabStop = True
        Me.rbtnUPI.Text = "UPI"
        Me.rbtnUPI.UseVisualStyleBackColor = True
        '
        'rbtnCard
        '
        Me.rbtnCard.AutoSize = True
        Me.rbtnCard.BackColor = System.Drawing.SystemColors.ControlLight
        Me.rbtnCard.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCard.Location = New System.Drawing.Point(107, 111)
        Me.rbtnCard.Name = "rbtnCard"
        Me.rbtnCard.Size = New System.Drawing.Size(172, 21)
        Me.rbtnCard.TabIndex = 3
        Me.rbtnCard.TabStop = True
        Me.rbtnCard.Text = "CASH ON DELIVERY"
        Me.rbtnCard.UseVisualStyleBackColor = False
        '
        'rbtnCash
        '
        Me.rbtnCash.AutoSize = True
        Me.rbtnCash.BackColor = System.Drawing.SystemColors.ControlLight
        Me.rbtnCash.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCash.Location = New System.Drawing.Point(316, 111)
        Me.rbtnCash.Name = "rbtnCash"
        Me.rbtnCash.Size = New System.Drawing.Size(70, 21)
        Me.rbtnCash.TabIndex = 4
        Me.rbtnCash.TabStop = True
        Me.rbtnCash.Text = "CARD"
        Me.rbtnCash.UseVisualStyleBackColor = False
        '
        'btnConfirmPayment
        '
        Me.btnConfirmPayment.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnConfirmPayment.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmPayment.Location = New System.Drawing.Point(93, 176)
        Me.btnConfirmPayment.Name = "btnConfirmPayment"
        Me.btnConfirmPayment.Size = New System.Drawing.Size(228, 31)
        Me.btnConfirmPayment.TabIndex = 5
        Me.btnConfirmPayment.Text = "CONFIRM PAYMENT"
        Me.btnConfirmPayment.UseVisualStyleBackColor = False
        '
        'txtFeedback
        '
        Me.txtFeedback.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeedback.Location = New System.Drawing.Point(150, 284)
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.Size = New System.Drawing.Size(100, 25)
        Me.txtFeedback.TabIndex = 6
        '
        'btnSubmitFeedback
        '
        Me.btnSubmitFeedback.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitFeedback.Location = New System.Drawing.Point(150, 343)
        Me.btnSubmitFeedback.Name = "btnSubmitFeedback"
        Me.btnSubmitFeedback.Size = New System.Drawing.Size(100, 28)
        Me.btnSubmitFeedback.TabIndex = 7
        Me.btnSubmitFeedback.Text = "SUBMIT"
        Me.btnSubmitFeedback.UseVisualStyleBackColor = True
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(451, 404)
        Me.Controls.Add(Me.btnSubmitFeedback)
        Me.Controls.Add(Me.txtFeedback)
        Me.Controls.Add(Me.btnConfirmPayment)
        Me.Controls.Add(Me.rbtnCash)
        Me.Controls.Add(Me.rbtnCard)
        Me.Controls.Add(Me.rbtnUPI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaymentForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rbtnUPI As RadioButton
    Friend WithEvents rbtnCard As RadioButton
    Friend WithEvents rbtnCash As RadioButton
    Friend WithEvents btnConfirmPayment As Button
    Friend WithEvents txtFeedback As TextBox
    Friend WithEvents btnSubmitFeedback As Button
End Class
