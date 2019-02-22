<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DelPenItems
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
        Me.dgv123 = New System.Windows.Forms.DataGridView()
        Me.PurtbladmininboxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchasingData = New Purchasing_System_ICT_III_1.PurchasingData()
        Me.Pur_tbl_admin_inboxTableAdapter = New Purchasing_System_ICT_III_1.PurchasingDataTableAdapters.pur_tbl_admin_inboxTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.UseritemrequestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UseritemqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserreqstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv123, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurtbladmininboxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv123
        '
        Me.dgv123.AutoGenerateColumns = False
        Me.dgv123.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv123.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UseritemrequestDataGridViewTextBoxColumn, Me.UseritemqtyDataGridViewTextBoxColumn, Me.UserreqstatusDataGridViewTextBoxColumn, Me.UserdateDataGridViewTextBoxColumn})
        Me.dgv123.DataSource = Me.PurtbladmininboxBindingSource
        Me.dgv123.Location = New System.Drawing.Point(158, 72)
        Me.dgv123.Name = "dgv123"
        Me.dgv123.RowHeadersVisible = False
        Me.dgv123.Size = New System.Drawing.Size(404, 176)
        Me.dgv123.TabIndex = 0
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(326, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "TOTAL:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(183, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "STATUS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(310, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "LIST OF ITEMS"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Delivered", "Pending"})
        Me.ComboBox1.Location = New System.Drawing.Point(272, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(226, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(549, 254)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(98, 31)
        Me.btnTotal.TabIndex = 18
        Me.btnTotal.Text = "COMPUTE"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(98, 31)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(399, 260)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 20
        '
        'UseritemrequestDataGridViewTextBoxColumn
        '
        Me.UseritemrequestDataGridViewTextBoxColumn.DataPropertyName = "user_item_request"
        Me.UseritemrequestDataGridViewTextBoxColumn.HeaderText = "Item"
        Me.UseritemrequestDataGridViewTextBoxColumn.Name = "UseritemrequestDataGridViewTextBoxColumn"
        '
        'UseritemqtyDataGridViewTextBoxColumn
        '
        Me.UseritemqtyDataGridViewTextBoxColumn.DataPropertyName = "user_item_qty"
        Me.UseritemqtyDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.UseritemqtyDataGridViewTextBoxColumn.Name = "UseritemqtyDataGridViewTextBoxColumn"
        '
        'UserreqstatusDataGridViewTextBoxColumn
        '
        Me.UserreqstatusDataGridViewTextBoxColumn.DataPropertyName = "user_req_status"
        Me.UserreqstatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.UserreqstatusDataGridViewTextBoxColumn.Name = "UserreqstatusDataGridViewTextBoxColumn"
        '
        'UserdateDataGridViewTextBoxColumn
        '
        Me.UserdateDataGridViewTextBoxColumn.DataPropertyName = "user_date"
        Me.UserdateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.UserdateDataGridViewTextBoxColumn.Name = "UserdateDataGridViewTextBoxColumn"
        '
        'DelPenItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 295)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv123)
        Me.Name = "DelPenItems"
        Me.Text = "DelPenItems"
        CType(Me.dgv123, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurtbladmininboxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv123 As DataGridView
    Friend WithEvents PurchasingData As PurchasingData
    Friend WithEvents PurtbladmininboxBindingSource As BindingSource
    Friend WithEvents Pur_tbl_admin_inboxTableAdapter As PurchasingDataTableAdapters.pur_tbl_admin_inboxTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents UseritemrequestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UseritemqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserreqstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
