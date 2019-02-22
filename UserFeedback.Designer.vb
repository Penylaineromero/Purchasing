<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserFeedback
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserFeedback))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpfeed = New System.Windows.Forms.DateTimePicker()
        Me.txtuserfeed = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbName = New System.Windows.Forms.ComboBox()
        Me.PurtblusersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchasingData = New Purchasing_System_ICT_III_1.PurchasingData()
        Me.cbDept = New System.Windows.Forms.ComboBox()
        Me.Pur_tbl_usersTableAdapter = New Purchasing_System_ICT_III_1.PurchasingDataTableAdapters.pur_tbl_usersTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PurtblusersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(38, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NAME:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(38, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DEPARTMENT:"
        '
        'dtpfeed
        '
        Me.dtpfeed.Font = New System.Drawing.Font("Maiandra GD", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfeed.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfeed.Location = New System.Drawing.Point(489, 12)
        Me.dtpfeed.Name = "dtpfeed"
        Me.dtpfeed.Size = New System.Drawing.Size(107, 25)
        Me.dtpfeed.TabIndex = 6
        '
        'txtuserfeed
        '
        Me.txtuserfeed.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtuserfeed.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuserfeed.Location = New System.Drawing.Point(41, 88)
        Me.txtuserfeed.Multiline = True
        Me.txtuserfeed.Name = "txtuserfeed"
        Me.txtuserfeed.Size = New System.Drawing.Size(555, 176)
        Me.txtuserfeed.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Button1.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(493, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 30)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "SEND"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbName
        '
        Me.cbName.DataSource = Me.PurtblusersBindingSource
        Me.cbName.DisplayMember = "new_user_name"
        Me.cbName.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbName.FormattingEnabled = True
        Me.cbName.Location = New System.Drawing.Point(167, 12)
        Me.cbName.Name = "cbName"
        Me.cbName.Size = New System.Drawing.Size(167, 24)
        Me.cbName.TabIndex = 17
        Me.cbName.ValueMember = "new_user_name"
        '
        'PurtblusersBindingSource
        '
        Me.PurtblusersBindingSource.DataMember = "pur_tbl_users"
        Me.PurtblusersBindingSource.DataSource = Me.PurchasingData
        '
        'PurchasingData
        '
        Me.PurchasingData.DataSetName = "PurchasingData"
        Me.PurchasingData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbDept
        '
        Me.cbDept.DataSource = Me.PurtblusersBindingSource
        Me.cbDept.DisplayMember = "new_user_dept"
        Me.cbDept.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDept.FormattingEnabled = True
        Me.cbDept.Location = New System.Drawing.Point(167, 42)
        Me.cbDept.Name = "cbDept"
        Me.cbDept.Size = New System.Drawing.Size(167, 24)
        Me.cbDept.TabIndex = 18
        Me.cbDept.ValueMember = "new_user_dept"
        '
        'Pur_tbl_usersTableAdapter
        '
        Me.Pur_tbl_usersTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnBack.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(41, 270)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(103, 30)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'UserFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(638, 323)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.cbDept)
        Me.Controls.Add(Me.cbName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtuserfeed)
        Me.Controls.Add(Me.dtpfeed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "UserFeedback"
        Me.Text = "UserFeedback"
        CType(Me.PurtblusersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpfeed As DateTimePicker
    Friend WithEvents txtuserfeed As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cbName As ComboBox
    Friend WithEvents cbDept As ComboBox
    Friend WithEvents PurchasingData As PurchasingData
    Friend WithEvents PurtblusersBindingSource As BindingSource
    Friend WithEvents Pur_tbl_usersTableAdapter As PurchasingDataTableAdapters.pur_tbl_usersTableAdapter
    Friend WithEvents btnBack As Button
End Class
