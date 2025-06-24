<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlotBookingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SlotBookingForm))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbCourt = New System.Windows.Forms.ComboBox()
        Me.cmbSlot = New System.Windows.Forms.ComboBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCancelBookings = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblLoggedInUser = New System.Windows.Forms.Label()
        Me.dgvBookings = New System.Windows.Forms.DataGridView()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(68, 157)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(113, 18)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "SELECT SLOT"
        '
        'cmbCourt
        '
        Me.cmbCourt.FormattingEnabled = True
        Me.cmbCourt.Location = New System.Drawing.Point(185, 149)
        Me.cmbCourt.Name = "cmbCourt"
        Me.cmbCourt.Size = New System.Drawing.Size(121, 24)
        Me.cmbCourt.TabIndex = 1
        '
        'cmbSlot
        '
        Me.cmbSlot.FormattingEnabled = True
        Me.cmbSlot.Location = New System.Drawing.Point(334, 149)
        Me.cmbSlot.Name = "cmbSlot"
        Me.cmbSlot.Size = New System.Drawing.Size(121, 24)
        Me.cmbSlot.TabIndex = 2
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(234, 191)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpDate.TabIndex = 3
        '
        'btnCancelBookings
        '
        Me.btnCancelBookings.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelBookings.Location = New System.Drawing.Point(278, 497)
        Me.btnCancelBookings.Name = "btnCancelBookings"
        Me.btnCancelBookings.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelBookings.TabIndex = 4
        Me.btnCancelBookings.Text = "DELETE"
        Me.btnCancelBookings.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(30, 307)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(105, 18)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "YOUR SLOTS"
        '
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(289, 238)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(75, 23)
        Me.btnBook.TabIndex = 7
        Me.btnBook.Text = "SELECT"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(587, 526)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 8
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'lblLoggedInUser
        '
        Me.lblLoggedInUser.AutoSize = True
        Me.lblLoggedInUser.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoggedInUser.Location = New System.Drawing.Point(230, 66)
        Me.lblLoggedInUser.Name = "lblLoggedInUser"
        Me.lblLoggedInUser.Size = New System.Drawing.Size(179, 22)
        Me.lblLoggedInUser.TabIndex = 9
        Me.lblLoggedInUser.Text = "BOOK YOUR SLOT"
        '
        'dgvBookings
        '
        Me.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookings.Location = New System.Drawing.Point(12, 341)
        Me.dgvBookings.Name = "dgvBookings"
        Me.dgvBookings.RowHeadersWidth = 51
        Me.dgvBookings.RowTemplate.Height = 24
        Me.dgvBookings.Size = New System.Drawing.Size(659, 150)
        Me.dgvBookings.TabIndex = 10
        '
        'SlotBookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(674, 561)
        Me.Controls.Add(Me.dgvBookings)
        Me.Controls.Add(Me.lblLoggedInUser)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCancelBookings)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.cmbSlot)
        Me.Controls.Add(Me.cmbCourt)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "SlotBookingForm"
        Me.Text = "SlotBookingForm"
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents cmbCourt As ComboBox
    Friend WithEvents cmbSlot As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnCancelBookings As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnBook As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents lblLoggedInUser As Label
    Friend WithEvents dgvBookings As DataGridView
End Class
