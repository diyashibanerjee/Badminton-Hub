<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EquipmentTypeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EquipmentTypeForm))
        Me.btnShuttle = New System.Windows.Forms.Button()
        Me.btnRaquet = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShuttle
        '
        Me.btnShuttle.BackgroundImage = CType(resources.GetObject("btnShuttle.BackgroundImage"), System.Drawing.Image)
        Me.btnShuttle.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShuttle.Location = New System.Drawing.Point(39, 233)
        Me.btnShuttle.Name = "btnShuttle"
        Me.btnShuttle.Size = New System.Drawing.Size(196, 91)
        Me.btnShuttle.TabIndex = 0
        Me.btnShuttle.UseVisualStyleBackColor = True
        '
        'btnRaquet
        '
        Me.btnRaquet.BackgroundImage = CType(resources.GetObject("btnRaquet.BackgroundImage"), System.Drawing.Image)
        Me.btnRaquet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRaquet.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaquet.Location = New System.Drawing.Point(282, 233)
        Me.btnRaquet.Name = "btnRaquet"
        Me.btnRaquet.Size = New System.Drawing.Size(173, 91)
        Me.btnRaquet.TabIndex = 1
        Me.btnRaquet.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CHOOSE YOUR EQUIPMENT!"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MistyRose
        Me.btnBack.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(408, 457)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "HOME"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'EquipmentTypeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(499, 499)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRaquet)
        Me.Controls.Add(Me.btnShuttle)
        Me.Name = "EquipmentTypeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EquipmentTypeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShuttle As Button
    Friend WithEvents btnRaquet As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
End Class
