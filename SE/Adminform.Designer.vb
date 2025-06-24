<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.dgvSlots = New System.Windows.Forms.DataGridView()
        Me.btnAddCourt = New System.Windows.Forms.Button()
        Me.txtNewSlotTime = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvCourt = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvSlots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCourt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSlots
        '
        Me.dgvSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSlots.Location = New System.Drawing.Point(-7, 66)
        Me.dgvSlots.Name = "dgvSlots"
        Me.dgvSlots.RowHeadersWidth = 51
        Me.dgvSlots.RowTemplate.Height = 24
        Me.dgvSlots.Size = New System.Drawing.Size(633, 150)
        Me.dgvSlots.TabIndex = 0
        '
        'btnAddCourt
        '
        Me.btnAddCourt.Location = New System.Drawing.Point(260, 37)
        Me.btnAddCourt.Name = "btnAddCourt"
        Me.btnAddCourt.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCourt.TabIndex = 2
        Me.btnAddCourt.Text = "add court"
        Me.btnAddCourt.UseVisualStyleBackColor = True
        '
        'txtNewSlotTime
        '
        Me.txtNewSlotTime.Location = New System.Drawing.Point(37, 38)
        Me.txtNewSlotTime.Name = "txtNewSlotTime"
        Me.txtNewSlotTime.Size = New System.Drawing.Size(100, 22)
        Me.txtNewSlotTime.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "add new time"
        '
        'dgvCourt
        '
        Me.dgvCourt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCourt.Location = New System.Drawing.Point(-7, 211)
        Me.dgvCourt.Name = "dgvCourt"
        Me.dgvCourt.RowHeadersWidth = 51
        Me.dgvCourt.RowTemplate.Height = 24
        Me.dgvCourt.Size = New System.Drawing.Size(633, 150)
        Me.dgvCourt.TabIndex = 10
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(702, 411)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "LOGOUT"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvCourt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNewSlotTime)
        Me.Controls.Add(Me.btnAddCourt)
        Me.Controls.Add(Me.dgvSlots)
        Me.Name = "AdminForm"
        Me.Text = "Adminform"
        CType(Me.dgvSlots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCourt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSlots As DataGridView
    Friend WithEvents btnAddCourt As Button
    Friend WithEvents txtNewSlotTime As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvCourt As DataGridView
    Friend WithEvents btnBack As Button
End Class
