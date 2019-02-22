<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdInbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdInbox))
        Me.AdminGrid = New System.Windows.Forms.DataGridView()
        Me.PurtbladmininboxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchasingData = New Purchasing_System_ICT_III_1.PurchasingData()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Pur_tbl_admin_inboxTableAdapter = New Purchasing_System_ICT_III_1.PurchasingDataTableAdapters.pur_tbl_admin_inboxTableAdapter()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnDelivered = New System.Windows.Forms.Button()
        Me.dgvQty = New System.Windows.Forms.DataGridView()
        Me.PurtblinventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pur_tbl_inventoryTableAdapter = New Purchasing_System_ICT_III_1.PurchasingDataTableAdapters.pur_tbl_inventoryTableAdapter()
        Me.ItemtotalpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItempriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserreqstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UseritemqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UseritemrequestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserdeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.AdminGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurtbladmininboxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurtblinventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminGrid
        '
        Me.AdminGrid.AllowUserToAddRows = False
        Me.AdminGrid.AllowUserToDeleteRows = False
        Me.AdminGrid.AllowUserToResizeColumns = False
        Me.AdminGrid.AllowUserToResizeRows = False
        Me.AdminGrid.AutoGenerateColumns = False
        Me.AdminGrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.AdminGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdminGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UseridDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.UserdeptDataGridViewTextBoxColumn, Me.UseritemrequestDataGridViewTextBoxColumn, Me.UseritemqtyDataGridViewTextBoxColumn, Me.UserreqstatusDataGridViewTextBoxColumn, Me.UserdateDataGridViewTextBoxColumn})
        Me.AdminGrid.DataSource = Me.PurtbladmininboxBindingSource
        Me.AdminGrid.EnableHeadersVisualStyles = False
        Me.AdminGrid.Location = New System.Drawing.Point(18, 48)
        Me.AdminGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.AdminGrid.Name = "AdminGrid"
        Me.AdminGrid.ReadOnly = True
        Me.AdminGrid.RowHeadersVisible = False
        Me.AdminGrid.Size = New System.Drawing.Size(726, 225)
        Me.AdminGrid.TabIndex = 0
        '
        'PurtbladmininboxBindingSource
        '
        Me.PurtbladmininboxBindingSource.DataMember = "pur_tbl_admin_inbox"
        Me.PurtbladmininboxBindingSource.DataSource = Me.PurchasingData
        '
        'PurchasingData
        '
        Me.PurchasingData.DataSetName = "PurchasingData"
        Me.PurchasingData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(18, 10)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(152, 33)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "BACK"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(472, 10)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 33)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "NEW MESSAGE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(363, 315)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 26)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Delivered", "Pending"})
        Me.cmbStatus.Location = New System.Drawing.Point(340, 281)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(143, 26)
        Me.cmbStatus.TabIndex = 11
        Me.cmbStatus.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(313, 10)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(151, 33)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "REFRESH"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Window
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Font = New System.Drawing.Font("Maiandra GD", 12.0!)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(178, 292)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 33)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Pur_tbl_admin_inboxTableAdapter
        '
        Me.Pur_tbl_admin_inboxTableAdapter.ClearBeforeFill = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(18, 284)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(152, 48)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "CHECK INVENTORY"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnDelivered
        '
        Me.btnDelivered.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnDelivered.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDelivered.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelivered.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelivered.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelivered.Location = New System.Drawing.Point(628, 292)
        Me.btnDelivered.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelivered.Name = "btnDelivered"
        Me.btnDelivered.Size = New System.Drawing.Size(116, 33)
        Me.btnDelivered.TabIndex = 19
        Me.btnDelivered.Text = "DELIVERED"
        Me.btnDelivered.UseVisualStyleBackColor = False
        '
        'dgvQty
        '
        Me.dgvQty.AllowUserToAddRows = False
        Me.dgvQty.AllowUserToDeleteRows = False
        Me.dgvQty.AutoGenerateColumns = False
        Me.dgvQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQty.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderidDataGridViewTextBoxColumn, Me.ItemnameDataGridViewTextBoxColumn, Me.ItemdateDataGridViewTextBoxColumn, Me.ItemqtyDataGridViewTextBoxColumn, Me.ItempriceDataGridViewTextBoxColumn, Me.ItemtotalpriceDataGridViewTextBoxColumn})
        Me.dgvQty.DataSource = Me.PurtblinventoryBindingSource
        Me.dgvQty.Location = New System.Drawing.Point(517, 293)
        Me.dgvQty.Name = "dgvQty"
        Me.dgvQty.ReadOnly = True
        Me.dgvQty.RowHeadersVisible = False
        Me.dgvQty.Size = New System.Drawing.Size(104, 32)
        Me.dgvQty.TabIndex = 20
        Me.dgvQty.Visible = False
        '
        'PurtblinventoryBindingSource
        '
        Me.PurtblinventoryBindingSource.DataMember = "pur_tbl_inventory"
        Me.PurtblinventoryBindingSource.DataSource = Me.PurchasingData
        '
        'Pur_tbl_inventoryTableAdapter
        '
        Me.Pur_tbl_inventoryTableAdapter.ClearBeforeFill = True
        '
        'ItemtotalpriceDataGridViewTextBoxColumn
        '
        Me.ItemtotalpriceDataGridViewTextBoxColumn.DataPropertyName = "item_total_price"
        Me.ItemtotalpriceDataGridViewTextBoxColumn.HeaderText = "item_total_price"
        Me.ItemtotalpriceDataGridViewTextBoxColumn.Name = "ItemtotalpriceDataGridViewTextBoxColumn"
        Me.ItemtotalpriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemtotalpriceDataGridViewTextBoxColumn.Visible = False
        '
        'ItempriceDataGridViewTextBoxColumn
        '
        Me.ItempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price"
        Me.ItempriceDataGridViewTextBoxColumn.HeaderText = "item_price"
        Me.ItempriceDataGridViewTextBoxColumn.Name = "ItempriceDataGridViewTextBoxColumn"
        Me.ItempriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItempriceDataGridViewTextBoxColumn.Visible = False
        '
        'ItemqtyDataGridViewTextBoxColumn
        '
        Me.ItemqtyDataGridViewTextBoxColumn.DataPropertyName = "item_qty"
        Me.ItemqtyDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.ItemqtyDataGridViewTextBoxColumn.Name = "ItemqtyDataGridViewTextBoxColumn"
        Me.ItemqtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemdateDataGridViewTextBoxColumn
        '
        Me.ItemdateDataGridViewTextBoxColumn.DataPropertyName = "item_date"
        Me.ItemdateDataGridViewTextBoxColumn.HeaderText = "item_date"
        Me.ItemdateDataGridViewTextBoxColumn.Name = "ItemdateDataGridViewTextBoxColumn"
        Me.ItemdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemdateDataGridViewTextBoxColumn.Visible = False
        '
        'ItemnameDataGridViewTextBoxColumn
        '
        Me.ItemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name"
        Me.ItemnameDataGridViewTextBoxColumn.HeaderText = "item_name"
        Me.ItemnameDataGridViewTextBoxColumn.Name = "ItemnameDataGridViewTextBoxColumn"
        Me.ItemnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemnameDataGridViewTextBoxColumn.Visible = False
        '
        'OrderidDataGridViewTextBoxColumn
        '
        Me.OrderidDataGridViewTextBoxColumn.DataPropertyName = "order_id"
        Me.OrderidDataGridViewTextBoxColumn.HeaderText = "order_id"
        Me.OrderidDataGridViewTextBoxColumn.Name = "OrderidDataGridViewTextBoxColumn"
        Me.OrderidDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderidDataGridViewTextBoxColumn.Visible = False
        '
        'UserdateDataGridViewTextBoxColumn
        '
        Me.UserdateDataGridViewTextBoxColumn.DataPropertyName = "user_date"
        Me.UserdateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.UserdateDataGridViewTextBoxColumn.Name = "UserdateDataGridViewTextBoxColumn"
        Me.UserdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserreqstatusDataGridViewTextBoxColumn
        '
        Me.UserreqstatusDataGridViewTextBoxColumn.DataPropertyName = "user_req_status"
        Me.UserreqstatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.UserreqstatusDataGridViewTextBoxColumn.Name = "UserreqstatusDataGridViewTextBoxColumn"
        Me.UserreqstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserreqstatusDataGridViewTextBoxColumn.Width = 70
        '
        'UseritemqtyDataGridViewTextBoxColumn
        '
        Me.UseritemqtyDataGridViewTextBoxColumn.DataPropertyName = "user_item_qty"
        Me.UseritemqtyDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.UseritemqtyDataGridViewTextBoxColumn.Name = "UseritemqtyDataGridViewTextBoxColumn"
        Me.UseritemqtyDataGridViewTextBoxColumn.ReadOnly = True
        Me.UseritemqtyDataGridViewTextBoxColumn.Width = 70
        '
        'UseritemrequestDataGridViewTextBoxColumn
        '
        Me.UseritemrequestDataGridViewTextBoxColumn.DataPropertyName = "user_item_request"
        Me.UseritemrequestDataGridViewTextBoxColumn.HeaderText = "Item"
        Me.UseritemrequestDataGridViewTextBoxColumn.Name = "UseritemrequestDataGridViewTextBoxColumn"
        Me.UseritemrequestDataGridViewTextBoxColumn.ReadOnly = True
        Me.UseritemrequestDataGridViewTextBoxColumn.Width = 165
        '
        'UserdeptDataGridViewTextBoxColumn
        '
        Me.UserdeptDataGridViewTextBoxColumn.DataPropertyName = "user_dept"
        Me.UserdeptDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.UserdeptDataGridViewTextBoxColumn.Name = "UserdeptDataGridViewTextBoxColumn"
        Me.UserdeptDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserdeptDataGridViewTextBoxColumn.Width = 165
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "user_name"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsernameDataGridViewTextBoxColumn.Width = 150
        '
        'UseridDataGridViewTextBoxColumn
        '
        Me.UseridDataGridViewTextBoxColumn.DataPropertyName = "user_id"
        Me.UseridDataGridViewTextBoxColumn.HeaderText = "user_id"
        Me.UseridDataGridViewTextBoxColumn.Name = "UseridDataGridViewTextBoxColumn"
        Me.UseridDataGridViewTextBoxColumn.ReadOnly = True
        Me.UseridDataGridViewTextBoxColumn.Visible = False
        '
        'AdInbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(771, 348)
        Me.Controls.Add(Me.dgvQty)
        Me.Controls.Add(Me.btnDelivered)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.AdminGrid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdInbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inbox"
        CType(Me.AdminGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurtbladmininboxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurtblinventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdminGrid As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents PurchasingData As PurchasingData
    Friend WithEvents PurtbladmininboxBindingSource As BindingSource
    Friend WithEvents Pur_tbl_admin_inboxTableAdapter As PurchasingDataTableAdapters.pur_tbl_admin_inboxTableAdapter
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents btnDelivered As Button
    Friend WithEvents dgvQty As DataGridView
    Friend WithEvents PurtblinventoryBindingSource As BindingSource
    Friend WithEvents Pur_tbl_inventoryTableAdapter As PurchasingDataTableAdapters.pur_tbl_inventoryTableAdapter
    Friend WithEvents UseridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserdeptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UseritemrequestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UseritemqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserreqstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItempriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemtotalpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
