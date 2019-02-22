<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequestsFromDepartments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RequestsFromDepartments))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PurtbladmininboxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchasingData = New Purchasing_System_ICT_III_1.PurchasingData()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserdeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UseritemrequestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UseritemqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserreqstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pur_tbl_admin_inboxTableAdapter = New Purchasing_System_ICT_III_1.PurchasingDataTableAdapters.pur_tbl_admin_inboxTableAdapter()
        CType(Me.PurtbladmininboxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MistyRose
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(98, 31)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.MistyRose
        Me.btnRefresh.Location = New System.Drawing.Point(525, 45)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(98, 24)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Purchasing Department", "IT Department", "HR Department", "Production Department", "Accounting and Finance Department", "Marketing Department"})
        Me.ComboBox1.Location = New System.Drawing.Point(269, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(250, 24)
        Me.ComboBox1.TabIndex = 2
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UseridDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.UserdeptDataGridViewTextBoxColumn, Me.UseritemrequestDataGridViewTextBoxColumn, Me.UseritemqtyDataGridViewTextBoxColumn, Me.UserreqstatusDataGridViewTextBoxColumn, Me.UserdateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PurtbladmininboxBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(119, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(504, 197)
        Me.DataGridView1.TabIndex = 3
        '
        'UseridDataGridViewTextBoxColumn
        '
        Me.UseridDataGridViewTextBoxColumn.DataPropertyName = "user_id"
        Me.UseridDataGridViewTextBoxColumn.HeaderText = "user_id"
        Me.UseridDataGridViewTextBoxColumn.Name = "UseridDataGridViewTextBoxColumn"
        Me.UseridDataGridViewTextBoxColumn.ReadOnly = True
        Me.UseridDataGridViewTextBoxColumn.Visible = False
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "user_name"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'UserdeptDataGridViewTextBoxColumn
        '
        Me.UserdeptDataGridViewTextBoxColumn.DataPropertyName = "user_dept"
        Me.UserdeptDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.UserdeptDataGridViewTextBoxColumn.Name = "UserdeptDataGridViewTextBoxColumn"
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
        Me.UserreqstatusDataGridViewTextBoxColumn.Visible = False
        '
        'UserdateDataGridViewTextBoxColumn
        '
        Me.UserdateDataGridViewTextBoxColumn.DataPropertyName = "user_date"
        Me.UserdateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.UserdateDataGridViewTextBoxColumn.Name = "UserdateDataGridViewTextBoxColumn"
        '
        'Pur_tbl_admin_inboxTableAdapter
        '
        Me.Pur_tbl_admin_inboxTableAdapter.ClearBeforeFill = True
        '
        'RequestsFromDepartments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(739, 301)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "RequestsFromDepartments"
        Me.Text = "RequestsFromDepartments"
        CType(Me.PurtbladmininboxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PurchasingData As PurchasingData
    Friend WithEvents PurtbladmininboxBindingSource As BindingSource
    Friend WithEvents Pur_tbl_admin_inboxTableAdapter As PurchasingDataTableAdapters.pur_tbl_admin_inboxTableAdapter
    Friend WithEvents UseridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserdeptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UseritemrequestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UseritemqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserreqstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
