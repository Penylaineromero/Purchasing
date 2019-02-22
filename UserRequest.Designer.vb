<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserRequest))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtItemreq = New System.Windows.Forms.ComboBox()
        Me.PurtblinventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchasingData = New Purchasing_System_ICT_III_1.PurchasingData()
        Me.txtDept = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSEND = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Pur_tbl_inventoryTableAdapter = New Purchasing_System_ICT_III_1.PurchasingDataTableAdapters.pur_tbl_inventoryTableAdapter()
        Me.dtpNow = New System.Windows.Forms.DateTimePicker()
        CType(Me.PurtblinventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(256, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NAME:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(256, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DEPARTMENT:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(256, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ITEM REQUEST:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(256, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ITEM QUANTITY:"
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtQty.Location = New System.Drawing.Point(422, 210)
        Me.txtQty.Multiline = True
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(167, 24)
        Me.txtQty.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtName.Location = New System.Drawing.Point(422, 78)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(167, 24)
        Me.txtName.TabIndex = 1
        '
        'txtItemreq
        '
        Me.txtItemreq.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtItemreq.DataSource = Me.PurtblinventoryBindingSource
        Me.txtItemreq.DisplayMember = "item_name"
        Me.txtItemreq.FormattingEnabled = True
        Me.txtItemreq.Location = New System.Drawing.Point(422, 170)
        Me.txtItemreq.Name = "txtItemreq"
        Me.txtItemreq.Size = New System.Drawing.Size(167, 21)
        Me.txtItemreq.TabIndex = 5
        Me.txtItemreq.ValueMember = "item_name"
        '
        'PurtblinventoryBindingSource
        '
        Me.PurtblinventoryBindingSource.DataMember = "pur_tbl_inventory"
        Me.PurtblinventoryBindingSource.DataSource = Me.PurchasingData
        '
        'PurchasingData
        '
        Me.PurchasingData.DataSetName = "PurchasingData"
        Me.PurchasingData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDept
        '
        Me.txtDept.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtDept.FormattingEnabled = True
        Me.txtDept.Items.AddRange(New Object() {"Purchasing Department", "IT Department", "HR Department", "Production Department", "Accounting and Finance Department", "Marketing Department"})
        Me.txtDept.Location = New System.Drawing.Point(422, 126)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(167, 21)
        Me.txtDept.TabIndex = 3
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(65, 136)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDelete.Size = New System.Drawing.Size(112, 23)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "CANCEL"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSEND
        '
        Me.btnSEND.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSEND.Location = New System.Drawing.Point(65, 68)
        Me.btnSEND.Name = "btnSEND"
        Me.btnSEND.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSEND.Size = New System.Drawing.Size(112, 23)
        Me.btnSEND.TabIndex = 8
        Me.btnSEND.Text = "SEND"
        Me.btnSEND.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(65, 102)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(112, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(231, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(390, 233)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(43, 46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(156, 134)
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'Pur_tbl_inventoryTableAdapter
        '
        Me.Pur_tbl_inventoryTableAdapter.ClearBeforeFill = True
        '
        'dtpNow
        '
        Me.dtpNow.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNow.Location = New System.Drawing.Point(523, 12)
        Me.dtpNow.Name = "dtpNow"
        Me.dtpNow.Size = New System.Drawing.Size(98, 20)
        Me.dtpNow.TabIndex = 26
        Me.dtpNow.Value = New Date(2017, 11, 1, 12, 24, 58, 0)
        '
        'UserRequest
        '
        Me.AcceptButton = Me.btnSEND
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(638, 323)
        Me.Controls.Add(Me.dtpNow)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSEND)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.txtItemreq)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "UserRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserRequest"
        CType(Me.PurtblinventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtItemreq As ComboBox
    Friend WithEvents txtDept As ComboBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSEND As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PurchasingData As PurchasingData
    Friend WithEvents PurtblinventoryBindingSource As BindingSource
    Friend WithEvents Pur_tbl_inventoryTableAdapter As PurchasingDataTableAdapters.pur_tbl_inventoryTableAdapter
    Friend WithEvents dtpNow As DateTimePicker
End Class
