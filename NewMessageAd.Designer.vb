<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewMessageAd
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewMessageAd))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listNotAvail = New System.Windows.Forms.ListBox()
        Me.shortcutInventory = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtReceived = New System.Windows.Forms.TextBox()
        Me.SEND = New System.Windows.Forms.Button()
        Me.list_item_req = New System.Windows.Forms.ListBox()
        Me.list_user_name = New System.Windows.Forms.ListBox()
        Me.PurchasingData = New Purchasing_System_ICT_III_1.PurchasingData()
        Me.PurtbladmininboxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pur_tbl_admin_inboxTableAdapter = New Purchasing_System_ICT_III_1.PurchasingDataTableAdapters.pur_tbl_admin_inboxTableAdapter()
        Me.dtpNowD = New System.Windows.Forms.DateTimePicker()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurtbladmininboxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(55, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reply:"
        '
        'listNotAvail
        '
        Me.listNotAvail.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.listNotAvail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.listNotAvail.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listNotAvail.FormattingEnabled = True
        Me.listNotAvail.ItemHeight = 20
        Me.listNotAvail.Items.AddRange(New Object() {"Your request is not available at this time. Sorry for the inconvenience.", "We will deliver it soon. Please wait for our next update. Thank you.", "We only have a few items left. Sorry for the inconvenience."})
        Me.listNotAvail.Location = New System.Drawing.Point(45, 93)
        Me.listNotAvail.Name = "listNotAvail"
        Me.listNotAvail.Size = New System.Drawing.Size(543, 64)
        Me.listNotAvail.TabIndex = 2
        '
        'shortcutInventory
        '
        Me.shortcutInventory.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.shortcutInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.shortcutInventory.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shortcutInventory.Location = New System.Drawing.Point(479, 12)
        Me.shortcutInventory.Name = "shortcutInventory"
        Me.shortcutInventory.Size = New System.Drawing.Size(140, 35)
        Me.shortcutInventory.TabIndex = 3
        Me.shortcutInventory.Text = "INVENTORY"
        Me.shortcutInventory.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtReceived
        '
        Me.txtReceived.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtReceived.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceived.Location = New System.Drawing.Point(45, 233)
        Me.txtReceived.Multiline = True
        Me.txtReceived.Name = "txtReceived"
        Me.txtReceived.Size = New System.Drawing.Size(416, 84)
        Me.txtReceived.TabIndex = 5
        '
        'SEND
        '
        Me.SEND.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SEND.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SEND.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEND.Location = New System.Drawing.Point(479, 282)
        Me.SEND.Name = "SEND"
        Me.SEND.Size = New System.Drawing.Size(140, 35)
        Me.SEND.TabIndex = 6
        Me.SEND.Text = "SEND"
        Me.SEND.UseVisualStyleBackColor = False
        '
        'list_item_req
        '
        Me.list_item_req.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.list_item_req.Cursor = System.Windows.Forms.Cursors.Hand
        Me.list_item_req.DataSource = Me.PurtbladmininboxBindingSource
        Me.list_item_req.DisplayMember = "user_item_request"
        Me.list_item_req.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_item_req.FormattingEnabled = True
        Me.list_item_req.ItemHeight = 20
        Me.list_item_req.Location = New System.Drawing.Point(45, 163)
        Me.list_item_req.Name = "list_item_req"
        Me.list_item_req.Size = New System.Drawing.Size(281, 64)
        Me.list_item_req.TabIndex = 7
        Me.list_item_req.ValueMember = "user_item_request"
        '
        'list_user_name
        '
        Me.list_user_name.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.list_user_name.Cursor = System.Windows.Forms.Cursors.Hand
        Me.list_user_name.DataSource = Me.PurtbladmininboxBindingSource
        Me.list_user_name.DisplayMember = "user_name"
        Me.list_user_name.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_user_name.FormattingEnabled = True
        Me.list_user_name.ItemHeight = 20
        Me.list_user_name.Location = New System.Drawing.Point(332, 163)
        Me.list_user_name.Name = "list_user_name"
        Me.list_user_name.Size = New System.Drawing.Size(255, 64)
        Me.list_user_name.TabIndex = 8
        Me.list_user_name.ValueMember = "user_name"
        '
        'PurchasingData
        '
        Me.PurchasingData.DataSetName = "PurchasingData"
        Me.PurchasingData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurtbladmininboxBindingSource
        '
        Me.PurtbladmininboxBindingSource.DataMember = "pur_tbl_admin_inbox"
        Me.PurtbladmininboxBindingSource.DataSource = Me.PurchasingData
        '
        'Pur_tbl_admin_inboxTableAdapter
        '
        Me.Pur_tbl_admin_inboxTableAdapter.ClearBeforeFill = True
        '
        'dtpNowD
        '
        Me.dtpNowD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNowD.Location = New System.Drawing.Point(491, 67)
        Me.dtpNowD.Name = "dtpNowD"
        Me.dtpNowD.Size = New System.Drawing.Size(97, 20)
        Me.dtpNowD.TabIndex = 9
        '
        'NewMessageAd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(631, 339)
        Me.Controls.Add(Me.dtpNowD)
        Me.Controls.Add(Me.list_user_name)
        Me.Controls.Add(Me.list_item_req)
        Me.Controls.Add(Me.SEND)
        Me.Controls.Add(Me.txtReceived)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.shortcutInventory)
        Me.Controls.Add(Me.listNotAvail)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewMessageAd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewMessageAd"
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurtbladmininboxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents listNotAvail As ListBox
    Friend WithEvents shortcutInventory As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtReceived As TextBox
    Friend WithEvents SEND As Button
    Friend WithEvents list_item_req As ListBox
    Friend WithEvents list_user_name As ListBox
    Friend WithEvents PurchasingData As PurchasingData
    Friend WithEvents PurtbladmininboxBindingSource As BindingSource
    Friend WithEvents Pur_tbl_admin_inboxTableAdapter As PurchasingDataTableAdapters.pur_tbl_admin_inboxTableAdapter
    Friend WithEvents dtpNowD As DateTimePicker
End Class
