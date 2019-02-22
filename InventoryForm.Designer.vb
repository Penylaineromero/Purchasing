<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.PurtblinventoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchasingData1 = New Purchasing_System_ICT_III_1.PurchasingData()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBACK = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgvInvent = New System.Windows.Forms.DataGridView()
        Me.OrderidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItempriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemtotalpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurtblinventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchasingData = New Purchasing_System_ICT_III_1.PurchasingData()
        Me.txtName = New System.Windows.Forms.ComboBox()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnretrieve = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Pur_tbl_inventoryTableAdapter = New Purchasing_System_ICT_III_1.PurchasingDataTableAdapters.pur_tbl_inventoryTableAdapter()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PurtblinventoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasingData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurtblinventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(37, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 18)
        Me.Label2.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(164, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Item Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(164, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(164, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Quantity:"
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtQty.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PurtblinventoryBindingSource1, "item_qty", True))
        Me.txtQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurtblinventoryBindingSource1, "item_qty", True))
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(265, 155)
        Me.txtQty.Multiline = True
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(141, 24)
        Me.txtQty.TabIndex = 6
        '
        'PurtblinventoryBindingSource1
        '
        Me.PurtblinventoryBindingSource1.DataMember = "pur_tbl_inventory"
        Me.PurtblinventoryBindingSource1.DataSource = Me.PurchasingData1
        '
        'PurchasingData1
        '
        Me.PurchasingData1.DataSetName = "PurchasingData"
        Me.PurchasingData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDate
        '
        Me.txtDate.CalendarForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption
        Me.txtDate.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite
        Me.txtDate.CalendarTitleForeColor = System.Drawing.Color.AntiqueWhite
        Me.txtDate.CalendarTrailingForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDate.CustomFormat = ""
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDate.Location = New System.Drawing.Point(265, 119)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(141, 23)
        Me.txtDate.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(138, 64)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(311, 172)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Maiandra GD", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(205, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ADD NEW ITEM"
        '
        'btnBACK
        '
        Me.btnBACK.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnBACK.Location = New System.Drawing.Point(6, 12)
        Me.btnBACK.Name = "btnBACK"
        Me.btnBACK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBACK.Size = New System.Drawing.Size(112, 29)
        Me.btnBACK.TabIndex = 9
        Me.btnBACK.Text = "BACK"
        Me.btnBACK.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Button3.Location = New System.Drawing.Point(354, 258)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(95, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "CLEAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'dgvInvent
        '
        Me.dgvInvent.AllowUserToResizeColumns = False
        Me.dgvInvent.AllowUserToResizeRows = False
        Me.dgvInvent.AutoGenerateColumns = False
        Me.dgvInvent.BackgroundColor = System.Drawing.Color.AntiqueWhite
        Me.dgvInvent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderidDataGridViewTextBoxColumn, Me.ItemnameDataGridViewTextBoxColumn, Me.ItemdateDataGridViewTextBoxColumn, Me.ItemqtyDataGridViewTextBoxColumn, Me.ItempriceDataGridViewTextBoxColumn, Me.ItemtotalpriceDataGridViewTextBoxColumn})
        Me.dgvInvent.DataSource = Me.PurtblinventoryBindingSource1
        Me.dgvInvent.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgvInvent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvInvent.EnableHeadersVisualStyles = False
        Me.dgvInvent.GridColor = System.Drawing.SystemColors.InactiveCaption
        Me.dgvInvent.Location = New System.Drawing.Point(460, 0)
        Me.dgvInvent.Name = "dgvInvent"
        Me.dgvInvent.ReadOnly = True
        Me.dgvInvent.RowHeadersVisible = False
        Me.dgvInvent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvInvent.Size = New System.Drawing.Size(590, 323)
        Me.dgvInvent.TabIndex = 13
        '
        'OrderidDataGridViewTextBoxColumn
        '
        Me.OrderidDataGridViewTextBoxColumn.DataPropertyName = "order_id"
        Me.OrderidDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.OrderidDataGridViewTextBoxColumn.Name = "OrderidDataGridViewTextBoxColumn"
        Me.OrderidDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderidDataGridViewTextBoxColumn.Width = 80
        '
        'ItemnameDataGridViewTextBoxColumn
        '
        Me.ItemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name"
        Me.ItemnameDataGridViewTextBoxColumn.HeaderText = "Item"
        Me.ItemnameDataGridViewTextBoxColumn.Name = "ItemnameDataGridViewTextBoxColumn"
        Me.ItemnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemnameDataGridViewTextBoxColumn.Width = 130
        '
        'ItemdateDataGridViewTextBoxColumn
        '
        Me.ItemdateDataGridViewTextBoxColumn.DataPropertyName = "item_date"
        Me.ItemdateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.ItemdateDataGridViewTextBoxColumn.Name = "ItemdateDataGridViewTextBoxColumn"
        Me.ItemdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemqtyDataGridViewTextBoxColumn
        '
        Me.ItemqtyDataGridViewTextBoxColumn.DataPropertyName = "item_qty"
        Me.ItemqtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.ItemqtyDataGridViewTextBoxColumn.Name = "ItemqtyDataGridViewTextBoxColumn"
        Me.ItemqtyDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemqtyDataGridViewTextBoxColumn.Width = 80
        '
        'ItempriceDataGridViewTextBoxColumn
        '
        Me.ItempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price"
        Me.ItempriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.ItempriceDataGridViewTextBoxColumn.Name = "ItempriceDataGridViewTextBoxColumn"
        Me.ItempriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemtotalpriceDataGridViewTextBoxColumn
        '
        Me.ItemtotalpriceDataGridViewTextBoxColumn.DataPropertyName = "item_total_price"
        Me.ItemtotalpriceDataGridViewTextBoxColumn.HeaderText = "Total Price"
        Me.ItemtotalpriceDataGridViewTextBoxColumn.Name = "ItemtotalpriceDataGridViewTextBoxColumn"
        Me.ItemtotalpriceDataGridViewTextBoxColumn.ReadOnly = True
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
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtName.DataSource = Me.PurtblinventoryBindingSource1
        Me.txtName.DisplayMember = "item_name"
        Me.txtName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.FormattingEnabled = True
        Me.txtName.Location = New System.Drawing.Point(265, 83)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(141, 24)
        Me.txtName.TabIndex = 2
        Me.txtName.ValueMember = "item_name"
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnADD.Location = New System.Drawing.Point(149, 258)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(95, 23)
        Me.btnADD.TabIndex = 11
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'btnretrieve
        '
        Me.btnretrieve.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnretrieve.Location = New System.Drawing.Point(6, 47)
        Me.btnretrieve.Name = "btnretrieve"
        Me.btnretrieve.Size = New System.Drawing.Size(112, 32)
        Me.btnretrieve.TabIndex = 12
        Me.btnretrieve.Text = "Refresh"
        Me.btnretrieve.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Button4.Location = New System.Drawing.Point(253, 258)
        Me.Button4.Name = "Button4"
        Me.Button4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button4.Size = New System.Drawing.Size(95, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "UPDATE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Pur_tbl_inventoryTableAdapter
        '
        Me.Pur_tbl_inventoryTableAdapter.ClearBeforeFill = True
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PurtblinventoryBindingSource1, "item_price", True))
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurtblinventoryBindingSource1, "item_price", True))
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(265, 192)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(141, 24)
        Me.txtPrice.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(164, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Price:"
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1050, 323)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnretrieve)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.dgvInvent)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnBACK)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "InventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventoryForm"
        CType(Me.PurtblinventoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasingData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurtblinventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBACK As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents dgvInvent As DataGridView
    Friend WithEvents txtName As ComboBox
    Friend WithEvents btnADD As Button
    Friend WithEvents btnretrieve As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PurchasingData As PurchasingData
    Friend WithEvents PurtblinventoryBindingSource As BindingSource
    Friend WithEvents Pur_tbl_inventoryTableAdapter As PurchasingDataTableAdapters.pur_tbl_inventoryTableAdapter
    Friend WithEvents PurchasingData1 As PurchasingData
    Friend WithEvents PurtblinventoryBindingSource1 As BindingSource
    Friend WithEvents OrderidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItempriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemtotalpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label1 As Label
End Class
