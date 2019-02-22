<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateNewUser))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUstype = New System.Windows.Forms.ComboBox()
        Me.txtDept = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSEND = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ViewUser = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(31, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(384, 248)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(197, 62)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(167, 24)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(62, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "USERNAME:"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(197, 100)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(167, 24)
        Me.txtPass.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(62, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PASSWORD:"
        '
        'txtConpass
        '
        Me.txtConpass.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtConpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConpass.Location = New System.Drawing.Point(197, 146)
        Me.txtConpass.Multiline = True
        Me.txtConpass.Name = "txtConpass"
        Me.txtConpass.Size = New System.Drawing.Size(167, 24)
        Me.txtConpass.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(62, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 36)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CONFIRM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PASSWORD:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(62, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DEPARTMENT:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(62, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "USER TYPE:"
        '
        'txtUstype
        '
        Me.txtUstype.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtUstype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUstype.FormattingEnabled = True
        Me.txtUstype.Items.AddRange(New Object() {"admin", "user"})
        Me.txtUstype.Location = New System.Drawing.Point(197, 234)
        Me.txtUstype.Name = "txtUstype"
        Me.txtUstype.Size = New System.Drawing.Size(167, 24)
        Me.txtUstype.TabIndex = 9
        '
        'txtDept
        '
        Me.txtDept.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDept.FormattingEnabled = True
        Me.txtDept.Items.AddRange(New Object() {"Purchasing Department", "IT Department", "HR Department", "Production Department", "Accounting and Finance Department", "Marketing Department"})
        Me.txtDept.Location = New System.Drawing.Point(197, 196)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(167, 24)
        Me.txtDept.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(482, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(112, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSEND
        '
        Me.btnSEND.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSEND.Location = New System.Drawing.Point(482, 106)
        Me.btnSEND.Name = "btnSEND"
        Me.btnSEND.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSEND.Size = New System.Drawing.Size(112, 23)
        Me.btnSEND.TabIndex = 10
        Me.btnSEND.Text = "ADD"
        Me.btnSEND.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(482, 174)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDelete.Size = New System.Drawing.Size(112, 23)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "CANCEL"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(443, 78)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(183, 158)
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'ViewUser
        '
        Me.ViewUser.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ViewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewUser.Location = New System.Drawing.Point(464, 12)
        Me.ViewUser.Name = "ViewUser"
        Me.ViewUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ViewUser.Size = New System.Drawing.Size(144, 34)
        Me.ViewUser.TabIndex = 41
        Me.ViewUser.Text = "VIEW USERS"
        Me.ViewUser.UseVisualStyleBackColor = False
        '
        'CreateNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(638, 323)
        Me.Controls.Add(Me.ViewUser)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSEND)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.txtUstype)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtConpass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "CreateNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateNewUser"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtConpass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUstype As ComboBox
    Friend WithEvents txtDept As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSEND As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ViewUser As Button
End Class
