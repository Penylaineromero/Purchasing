<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewUsers))
        Me.dgvNewUsers = New System.Windows.Forms.DataGridView()
        Me.NewuseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewusernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewuserpassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewconfipassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewuserdeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsertypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurtblusersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchasingData = New Purchasing_System_ICT_III_1.PurchasingData()
        Me.Pur_tbl_usersTableAdapter = New Purchasing_System_ICT_III_1.PurchasingDataTableAdapters.pur_tbl_usersTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBck = New System.Windows.Forms.Button()
        Me.txtDel = New System.Windows.Forms.Button()
        Me.btnRef = New System.Windows.Forms.Button()
        CType(Me.dgvNewUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurtblusersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvNewUsers
        '
        Me.dgvNewUsers.AllowUserToAddRows = False
        Me.dgvNewUsers.AllowUserToDeleteRows = False
        Me.dgvNewUsers.AllowUserToResizeColumns = False
        Me.dgvNewUsers.AllowUserToResizeRows = False
        Me.dgvNewUsers.AutoGenerateColumns = False
        Me.dgvNewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNewUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NewuseridDataGridViewTextBoxColumn, Me.NewusernameDataGridViewTextBoxColumn, Me.NewuserpassDataGridViewTextBoxColumn, Me.NewconfipassDataGridViewTextBoxColumn, Me.NewuserdeptDataGridViewTextBoxColumn, Me.UsertypeDataGridViewTextBoxColumn})
        Me.dgvNewUsers.DataSource = Me.PurtblusersBindingSource
        Me.dgvNewUsers.Location = New System.Drawing.Point(12, 80)
        Me.dgvNewUsers.Name = "dgvNewUsers"
        Me.dgvNewUsers.ReadOnly = True
        Me.dgvNewUsers.RowHeadersVisible = False
        Me.dgvNewUsers.Size = New System.Drawing.Size(614, 231)
        Me.dgvNewUsers.TabIndex = 0
        '
        'NewuseridDataGridViewTextBoxColumn
        '
        Me.NewuseridDataGridViewTextBoxColumn.DataPropertyName = "new_user_id"
        Me.NewuseridDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.NewuseridDataGridViewTextBoxColumn.Name = "NewuseridDataGridViewTextBoxColumn"
        Me.NewuseridDataGridViewTextBoxColumn.ReadOnly = True
        Me.NewuseridDataGridViewTextBoxColumn.Width = 35
        '
        'NewusernameDataGridViewTextBoxColumn
        '
        Me.NewusernameDataGridViewTextBoxColumn.DataPropertyName = "new_user_name"
        Me.NewusernameDataGridViewTextBoxColumn.HeaderText = "USERNAME"
        Me.NewusernameDataGridViewTextBoxColumn.Name = "NewusernameDataGridViewTextBoxColumn"
        Me.NewusernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NewusernameDataGridViewTextBoxColumn.Width = 120
        '
        'NewuserpassDataGridViewTextBoxColumn
        '
        Me.NewuserpassDataGridViewTextBoxColumn.DataPropertyName = "new_user_pass"
        Me.NewuserpassDataGridViewTextBoxColumn.HeaderText = "PASSWORD"
        Me.NewuserpassDataGridViewTextBoxColumn.Name = "NewuserpassDataGridViewTextBoxColumn"
        Me.NewuserpassDataGridViewTextBoxColumn.ReadOnly = True
        Me.NewuserpassDataGridViewTextBoxColumn.Width = 120
        '
        'NewconfipassDataGridViewTextBoxColumn
        '
        Me.NewconfipassDataGridViewTextBoxColumn.DataPropertyName = "new_confi_pass"
        Me.NewconfipassDataGridViewTextBoxColumn.HeaderText = "CONFIRM PASSWORD"
        Me.NewconfipassDataGridViewTextBoxColumn.Name = "NewconfipassDataGridViewTextBoxColumn"
        Me.NewconfipassDataGridViewTextBoxColumn.ReadOnly = True
        Me.NewconfipassDataGridViewTextBoxColumn.Width = 130
        '
        'NewuserdeptDataGridViewTextBoxColumn
        '
        Me.NewuserdeptDataGridViewTextBoxColumn.DataPropertyName = "new_user_dept"
        Me.NewuserdeptDataGridViewTextBoxColumn.HeaderText = "DEPARTMENT"
        Me.NewuserdeptDataGridViewTextBoxColumn.Name = "NewuserdeptDataGridViewTextBoxColumn"
        Me.NewuserdeptDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsertypeDataGridViewTextBoxColumn
        '
        Me.UsertypeDataGridViewTextBoxColumn.DataPropertyName = "user_type"
        Me.UsertypeDataGridViewTextBoxColumn.HeaderText = "USER TYPE"
        Me.UsertypeDataGridViewTextBoxColumn.Name = "UsertypeDataGridViewTextBoxColumn"
        Me.UsertypeDataGridViewTextBoxColumn.ReadOnly = True
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
        'Pur_tbl_usersTableAdapter
        '
        Me.Pur_tbl_usersTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(257, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "VIEW USERS"
        '
        'btnBck
        '
        Me.btnBck.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBck.Location = New System.Drawing.Point(12, 12)
        Me.btnBck.Name = "btnBck"
        Me.btnBck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBck.Size = New System.Drawing.Size(112, 31)
        Me.btnBck.TabIndex = 13
        Me.btnBck.Text = "BACK"
        Me.btnBck.UseVisualStyleBackColor = False
        '
        'txtDel
        '
        Me.txtDel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtDel.Location = New System.Drawing.Point(514, 12)
        Me.txtDel.Name = "txtDel"
        Me.txtDel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDel.Size = New System.Drawing.Size(112, 31)
        Me.txtDel.TabIndex = 14
        Me.txtDel.Text = "DELETE"
        Me.txtDel.UseVisualStyleBackColor = False
        '
        'btnRef
        '
        Me.btnRef.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRef.Location = New System.Drawing.Point(514, 48)
        Me.btnRef.Name = "btnRef"
        Me.btnRef.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnRef.Size = New System.Drawing.Size(112, 26)
        Me.btnRef.TabIndex = 15
        Me.btnRef.Text = "REFRESH"
        Me.btnRef.UseVisualStyleBackColor = False
        '
        'ViewUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(638, 323)
        Me.Controls.Add(Me.btnRef)
        Me.Controls.Add(Me.txtDel)
        Me.Controls.Add(Me.btnBck)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvNewUsers)
        Me.Name = "ViewUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewUsers"
        CType(Me.dgvNewUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurtblusersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvNewUsers As DataGridView
    Friend WithEvents PurchasingData As PurchasingData
    Friend WithEvents PurtblusersBindingSource As BindingSource
    Friend WithEvents Pur_tbl_usersTableAdapter As PurchasingDataTableAdapters.pur_tbl_usersTableAdapter
    Friend WithEvents NewuseridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NewusernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NewuserpassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NewconfipassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NewuserdeptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsertypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBck As Button
    Friend WithEvents txtDel As Button
    Friend WithEvents btnRef As Button
End Class
