<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainInventory))
        Me.dgv11 = New System.Windows.Forms.DataGridView()
        Me.OrderidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItempriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemtotalpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurtblinventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchasingData = New Purchasing_System_ICT_III_1.PurchasingData()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.shortcutInventory = New System.Windows.Forms.Button()
        Me.Pur_tbl_inventoryTableAdapter = New Purchasing_System_ICT_III_1.PurchasingDataTableAdapters.pur_tbl_inventoryTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PurtbladmininboxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pur_tbl_admin_inboxTableAdapter = New Purchasing_System_ICT_III_1.PurchasingDataTableAdapters.pur_tbl_admin_inboxTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.dgv11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurtblinventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurtbladmininboxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv11
        '
        Me.dgv11.AllowUserToAddRows = False
        Me.dgv11.AllowUserToDeleteRows = False
        Me.dgv11.AllowUserToResizeColumns = False
        Me.dgv11.AllowUserToResizeRows = False
        Me.dgv11.AutoGenerateColumns = False
        Me.dgv11.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.dgv11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv11.ColumnHeadersHeight = 24
        Me.dgv11.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderidDataGridViewTextBoxColumn, Me.ItemnameDataGridViewTextBoxColumn, Me.ItemdateDataGridViewTextBoxColumn, Me.ItemqtyDataGridViewTextBoxColumn, Me.ItempriceDataGridViewTextBoxColumn, Me.ItemtotalpriceDataGridViewTextBoxColumn})
        Me.dgv11.DataSource = Me.PurtblinventoryBindingSource
        Me.dgv11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv11.EnableHeadersVisualStyles = False
        Me.dgv11.GridColor = System.Drawing.SystemColors.InactiveCaption
        Me.dgv11.Location = New System.Drawing.Point(0, 142)
        Me.dgv11.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgv11.Name = "dgv11"
        Me.dgv11.ReadOnly = True
        Me.dgv11.RowHeadersVisible = False
        Me.dgv11.RowHeadersWidth = 45
        Me.dgv11.Size = New System.Drawing.Size(638, 181)
        Me.dgv11.TabIndex = 0
        '
        'OrderidDataGridViewTextBoxColumn
        '
        Me.OrderidDataGridViewTextBoxColumn.DataPropertyName = "order_id"
        Me.OrderidDataGridViewTextBoxColumn.HeaderText = "Order ID"
        Me.OrderidDataGridViewTextBoxColumn.Name = "OrderidDataGridViewTextBoxColumn"
        Me.OrderidDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderidDataGridViewTextBoxColumn.Width = 90
        '
        'ItemnameDataGridViewTextBoxColumn
        '
        Me.ItemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name"
        Me.ItemnameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.ItemnameDataGridViewTextBoxColumn.Name = "ItemnameDataGridViewTextBoxColumn"
        Me.ItemnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemnameDataGridViewTextBoxColumn.Width = 150
        '
        'ItemdateDataGridViewTextBoxColumn
        '
        Me.ItemdateDataGridViewTextBoxColumn.DataPropertyName = "item_date"
        Me.ItemdateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.ItemdateDataGridViewTextBoxColumn.Name = "ItemdateDataGridViewTextBoxColumn"
        Me.ItemdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemdateDataGridViewTextBoxColumn.Width = 110
        '
        'ItemqtyDataGridViewTextBoxColumn
        '
        Me.ItemqtyDataGridViewTextBoxColumn.DataPropertyName = "item_qty"
        Me.ItemqtyDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.ItemqtyDataGridViewTextBoxColumn.Name = "ItemqtyDataGridViewTextBoxColumn"
        Me.ItemqtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItempriceDataGridViewTextBoxColumn
        '
        Me.ItempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price"
        Me.ItempriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.ItempriceDataGridViewTextBoxColumn.Name = "ItempriceDataGridViewTextBoxColumn"
        Me.ItempriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItempriceDataGridViewTextBoxColumn.Width = 90
        '
        'ItemtotalpriceDataGridViewTextBoxColumn
        '
        Me.ItemtotalpriceDataGridViewTextBoxColumn.DataPropertyName = "item_total_price"
        Me.ItemtotalpriceDataGridViewTextBoxColumn.HeaderText = "Total Price"
        Me.ItemtotalpriceDataGridViewTextBoxColumn.Name = "ItemtotalpriceDataGridViewTextBoxColumn"
        Me.ItemtotalpriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemtotalpriceDataGridViewTextBoxColumn.Width = 90
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(475, 8)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ADD NEW ITEM"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(475, 43)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 25)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "REFRESH"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(16, 8)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 36)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "BACK"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(175, 111)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(396, 24)
        Me.txtSearch.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(256, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "INVENTORY"
        '
        'shortcutInventory
        '
        Me.shortcutInventory.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.shortcutInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.shortcutInventory.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shortcutInventory.Location = New System.Drawing.Point(16, 51)
        Me.shortcutInventory.Name = "shortcutInventory"
        Me.shortcutInventory.Size = New System.Drawing.Size(149, 35)
        Me.shortcutInventory.TabIndex = 13
        Me.shortcutInventory.Text = "BACK TO INBOX"
        Me.shortcutInventory.UseVisualStyleBackColor = False
        '
        'Pur_tbl_inventoryTableAdapter
        '
        Me.Pur_tbl_inventoryTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(45, 113)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "SEARCH ITEM:"
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
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Button4.Location = New System.Drawing.Point(475, 75)
        Me.Button4.Name = "Button4"
        Me.Button4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button4.Size = New System.Drawing.Size(149, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'MainInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(638, 323)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.shortcutInventory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv11)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainInventory"
        CType(Me.dgv11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurtblinventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurtbladmininboxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv11 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents shortcutInventory As Button
    Friend WithEvents PurchasingData As PurchasingData
    Friend WithEvents PurtblinventoryBindingSource As BindingSource
    Friend WithEvents Pur_tbl_inventoryTableAdapter As PurchasingDataTableAdapters.pur_tbl_inventoryTableAdapter
    Friend WithEvents OrderidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItempriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemtotalpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents PurtbladmininboxBindingSource As BindingSource
    Friend WithEvents Pur_tbl_admin_inboxTableAdapter As PurchasingDataTableAdapters.pur_tbl_admin_inboxTableAdapter
    Friend WithEvents Button4 As Button
End Class
