<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Test001
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
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.UseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserdeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UseritemrequestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UseritemqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserreqstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurtbladmininboxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchasingData = New Purchasing_System_ICT_III_1.PurchasingData()
        Me.Pur_tbl_admin_inboxTableAdapter = New Purchasing_System_ICT_III_1.PurchasingDataTableAdapters.pur_tbl_admin_inboxTableAdapter()
        Me.PurtblinventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pur_tbl_inventoryTableAdapter = New Purchasing_System_ICT_III_1.PurchasingDataTableAdapters.pur_tbl_inventoryTableAdapter()
        Me.ItemtotalpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItempriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.esu = New System.Windows.Forms.Label()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.btnQty = New System.Windows.Forms.Button()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.OrderidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemdateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemqtyDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItempriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemtotalpriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tM = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurtbladmininboxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurtblinventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(577, 233)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(164, 46)
        Me.btnAccept.TabIndex = 0
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UseridDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.UserdeptDataGridViewTextBoxColumn, Me.UseritemrequestDataGridViewTextBoxColumn, Me.UseritemqtyDataGridViewTextBoxColumn, Me.UserreqstatusDataGridViewTextBoxColumn, Me.UserdateDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.PurtbladmininboxBindingSource
        Me.dgv.Location = New System.Drawing.Point(18, 294)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(723, 187)
        Me.dgv.TabIndex = 1
        '
        'UseridDataGridViewTextBoxColumn
        '
        Me.UseridDataGridViewTextBoxColumn.DataPropertyName = "user_id"
        Me.UseridDataGridViewTextBoxColumn.HeaderText = "user_id"
        Me.UseridDataGridViewTextBoxColumn.Name = "UseridDataGridViewTextBoxColumn"
        Me.UseridDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "user_name"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "user_name"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserdeptDataGridViewTextBoxColumn
        '
        Me.UserdeptDataGridViewTextBoxColumn.DataPropertyName = "user_dept"
        Me.UserdeptDataGridViewTextBoxColumn.HeaderText = "user_dept"
        Me.UserdeptDataGridViewTextBoxColumn.Name = "UserdeptDataGridViewTextBoxColumn"
        Me.UserdeptDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UseritemrequestDataGridViewTextBoxColumn
        '
        Me.UseritemrequestDataGridViewTextBoxColumn.DataPropertyName = "user_item_request"
        Me.UseritemrequestDataGridViewTextBoxColumn.HeaderText = "user_item_request"
        Me.UseritemrequestDataGridViewTextBoxColumn.Name = "UseritemrequestDataGridViewTextBoxColumn"
        Me.UseritemrequestDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UseritemqtyDataGridViewTextBoxColumn
        '
        Me.UseritemqtyDataGridViewTextBoxColumn.DataPropertyName = "user_item_qty"
        Me.UseritemqtyDataGridViewTextBoxColumn.HeaderText = "user_item_qty"
        Me.UseritemqtyDataGridViewTextBoxColumn.Name = "UseritemqtyDataGridViewTextBoxColumn"
        Me.UseritemqtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserreqstatusDataGridViewTextBoxColumn
        '
        Me.UserreqstatusDataGridViewTextBoxColumn.DataPropertyName = "user_req_status"
        Me.UserreqstatusDataGridViewTextBoxColumn.HeaderText = "user_req_status"
        Me.UserreqstatusDataGridViewTextBoxColumn.Name = "UserreqstatusDataGridViewTextBoxColumn"
        Me.UserreqstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserdateDataGridViewTextBoxColumn
        '
        Me.UserdateDataGridViewTextBoxColumn.DataPropertyName = "user_date"
        Me.UserdateDataGridViewTextBoxColumn.HeaderText = "user_date"
        Me.UserdateDataGridViewTextBoxColumn.Name = "UserdateDataGridViewTextBoxColumn"
        Me.UserdateDataGridViewTextBoxColumn.ReadOnly = True
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
        'Pur_tbl_admin_inboxTableAdapter
        '
        Me.Pur_tbl_admin_inboxTableAdapter.ClearBeforeFill = True
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
        Me.ItemqtyDataGridViewTextBoxColumn.HeaderText = "item_qty"
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderidDataGridViewTextBoxColumn, Me.ItemnameDataGridViewTextBoxColumn, Me.ItemdateDataGridViewTextBoxColumn, Me.ItemqtyDataGridViewTextBoxColumn, Me.ItempriceDataGridViewTextBoxColumn, Me.ItemtotalpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PurtblinventoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(18, 487)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(236, 50)
        Me.DataGridView1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(596, 498)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 39)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 485)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Number 1"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(331, 501)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(136, 20)
        Me.txt1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(643, 540)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(331, 540)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(136, 20)
        Me.txt2.TabIndex = 6
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(492, 540)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(136, 20)
        Me.txtResult.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(309, 524)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "+"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 524)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Number 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(473, 540)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "="
        '
        'esu
        '
        Me.esu.AutoSize = True
        Me.esu.Location = New System.Drawing.Point(489, 524)
        Me.esu.Name = "esu"
        Me.esu.Size = New System.Drawing.Size(37, 13)
        Me.esu.TabIndex = 12
        Me.esu.Text = "Result"
        '
        'btnPrice
        '
        Me.btnPrice.BackColor = System.Drawing.Color.Yellow
        Me.btnPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrice.Location = New System.Drawing.Point(12, 233)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(164, 46)
        Me.btnPrice.TabIndex = 13
        Me.btnPrice.Text = "Accept"
        Me.btnPrice.UseVisualStyleBackColor = False
        '
        'btnQty
        '
        Me.btnQty.BackColor = System.Drawing.Color.Yellow
        Me.btnQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQty.Location = New System.Drawing.Point(283, 233)
        Me.btnQty.Name = "btnQty"
        Me.btnQty.Size = New System.Drawing.Size(164, 46)
        Me.btnQty.TabIndex = 13
        Me.btnQty.Text = "Accept"
        Me.btnQty.UseVisualStyleBackColor = False
        '
        'dgv2
        '
        Me.dgv2.AllowUserToAddRows = False
        Me.dgv2.AllowUserToDeleteRows = False
        Me.dgv2.AutoGenerateColumns = False
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderidDataGridViewTextBoxColumn1, Me.ItemnameDataGridViewTextBoxColumn1, Me.ItemdateDataGridViewTextBoxColumn1, Me.ItemqtyDataGridViewTextBoxColumn1, Me.ItempriceDataGridViewTextBoxColumn1, Me.ItemtotalpriceDataGridViewTextBoxColumn1})
        Me.dgv2.DataSource = Me.PurtblinventoryBindingSource
        Me.dgv2.Location = New System.Drawing.Point(12, 12)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.ReadOnly = True
        Me.dgv2.Size = New System.Drawing.Size(729, 215)
        Me.dgv2.TabIndex = 14
        '
        'OrderidDataGridViewTextBoxColumn1
        '
        Me.OrderidDataGridViewTextBoxColumn1.DataPropertyName = "order_id"
        Me.OrderidDataGridViewTextBoxColumn1.HeaderText = "order_id"
        Me.OrderidDataGridViewTextBoxColumn1.Name = "OrderidDataGridViewTextBoxColumn1"
        Me.OrderidDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ItemnameDataGridViewTextBoxColumn1
        '
        Me.ItemnameDataGridViewTextBoxColumn1.DataPropertyName = "item_name"
        Me.ItemnameDataGridViewTextBoxColumn1.HeaderText = "item_name"
        Me.ItemnameDataGridViewTextBoxColumn1.Name = "ItemnameDataGridViewTextBoxColumn1"
        Me.ItemnameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ItemdateDataGridViewTextBoxColumn1
        '
        Me.ItemdateDataGridViewTextBoxColumn1.DataPropertyName = "item_date"
        Me.ItemdateDataGridViewTextBoxColumn1.HeaderText = "item_date"
        Me.ItemdateDataGridViewTextBoxColumn1.Name = "ItemdateDataGridViewTextBoxColumn1"
        Me.ItemdateDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ItemqtyDataGridViewTextBoxColumn1
        '
        Me.ItemqtyDataGridViewTextBoxColumn1.DataPropertyName = "item_qty"
        Me.ItemqtyDataGridViewTextBoxColumn1.HeaderText = "item_qty"
        Me.ItemqtyDataGridViewTextBoxColumn1.Name = "ItemqtyDataGridViewTextBoxColumn1"
        Me.ItemqtyDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ItempriceDataGridViewTextBoxColumn1
        '
        Me.ItempriceDataGridViewTextBoxColumn1.DataPropertyName = "item_price"
        Me.ItempriceDataGridViewTextBoxColumn1.HeaderText = "item_price"
        Me.ItempriceDataGridViewTextBoxColumn1.Name = "ItempriceDataGridViewTextBoxColumn1"
        Me.ItempriceDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ItemtotalpriceDataGridViewTextBoxColumn1
        '
        Me.ItemtotalpriceDataGridViewTextBoxColumn1.DataPropertyName = "item_total_price"
        Me.ItemtotalpriceDataGridViewTextBoxColumn1.HeaderText = "item_total_price"
        Me.ItemtotalpriceDataGridViewTextBoxColumn1.Name = "ItemtotalpriceDataGridViewTextBoxColumn1"
        Me.ItemtotalpriceDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'tM
        '
        Me.tM.Enabled = True
        Me.tM.Interval = 1
        '
        'Test001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 572)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.btnQty)
        Me.Controls.Add(Me.btnPrice)
        Me.Controls.Add(Me.esu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnAccept)
        Me.Name = "Test001"
        Me.Text = "Test001"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurtbladmininboxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurtblinventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAccept As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents PurchasingData As PurchasingData
    Friend WithEvents PurtbladmininboxBindingSource As BindingSource
    Friend WithEvents Pur_tbl_admin_inboxTableAdapter As PurchasingDataTableAdapters.pur_tbl_admin_inboxTableAdapter
    Friend WithEvents PurtblinventoryBindingSource As BindingSource
    Friend WithEvents Pur_tbl_inventoryTableAdapter As PurchasingDataTableAdapters.pur_tbl_inventoryTableAdapter
    Friend WithEvents ItemtotalpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItempriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents esu As Label
    Friend WithEvents btnPrice As Button
    Friend WithEvents btnQty As Button
    Friend WithEvents UseridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserdeptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UseritemrequestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UseritemqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserreqstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgv2 As DataGridView
    Friend WithEvents OrderidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemdateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemqtyDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItempriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemtotalpriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents tM As Timer
End Class
