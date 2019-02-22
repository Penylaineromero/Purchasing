<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminReports))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRequestsFD = New System.Windows.Forms.Button()
        Me.btnDelPen = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Turquoise
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(89, 29)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnRequestsFD
        '
        Me.btnRequestsFD.BackColor = System.Drawing.Color.MistyRose
        Me.btnRequestsFD.Location = New System.Drawing.Point(89, 80)
        Me.btnRequestsFD.Name = "btnRequestsFD"
        Me.btnRequestsFD.Size = New System.Drawing.Size(381, 42)
        Me.btnRequestsFD.TabIndex = 1
        Me.btnRequestsFD.Text = "REQUESTED ITEMS FROM THE DEPARTMENT"
        Me.btnRequestsFD.UseVisualStyleBackColor = False
        '
        'btnDelPen
        '
        Me.btnDelPen.BackColor = System.Drawing.Color.MistyRose
        Me.btnDelPen.Location = New System.Drawing.Point(150, 138)
        Me.btnDelPen.Name = "btnDelPen"
        Me.btnDelPen.Size = New System.Drawing.Size(264, 43)
        Me.btnDelPen.TabIndex = 3
        Me.btnDelPen.Text = "DELIVERED AND PENDING ITEMS"
        Me.btnDelPen.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(235, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "REPORTS"
        '
        'AdminReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(612, 272)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDelPen)
        Me.Controls.Add(Me.btnRequestsFD)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "AdminReports"
        Me.Text = "AdminReports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnRequestsFD As Button
    Friend WithEvents btnDelPen As Button
    Friend WithEvents Label2 As Label
End Class
