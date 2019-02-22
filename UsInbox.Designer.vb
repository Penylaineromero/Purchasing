<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsInbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsInbox))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmbAdStatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.AdminidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminmsgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminmsgstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdmindateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurtbluserinboxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchasingData = New Purchasing_System_ICT_III_1.PurchasingData()
        Me.Pur_tbl_user_inboxTableAdapter = New Purchasing_System_ICT_III_1.PurchasingDataTableAdapters.pur_tbl_user_inboxTableAdapter()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurtbluserinboxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(512, 19)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 24)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "UPDATE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'cmbAdStatus
        '
        Me.cmbAdStatus.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmbAdStatus.FormattingEnabled = True
        Me.cmbAdStatus.Items.AddRange(New Object() {"Unread", "Read"})
        Me.cmbAdStatus.Location = New System.Drawing.Point(371, 19)
        Me.cmbAdStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAdStatus.Name = "cmbAdStatus"
        Me.cmbAdStatus.Size = New System.Drawing.Size(133, 24)
        Me.cmbAdStatus.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(244, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Messages"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Maiandra GD", 12.0!)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(13, 9)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 34)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.AllowUserToResizeColumns = False
        Me.dgvUser.AllowUserToResizeRows = False
        Me.dgvUser.AutoGenerateColumns = False
        Me.dgvUser.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdminidDataGridViewTextBoxColumn, Me.AdminmsgDataGridViewTextBoxColumn, Me.AdminmsgstatusDataGridViewTextBoxColumn, Me.AdmindateDataGridViewTextBoxColumn})
        Me.dgvUser.DataSource = Me.PurtbluserinboxBindingSource
        Me.dgvUser.Location = New System.Drawing.Point(204, 63)
        Me.dgvUser.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.ReadOnly = True
        Me.dgvUser.RowHeadersVisible = False
        Me.dgvUser.Size = New System.Drawing.Size(509, 247)
        Me.dgvUser.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Window
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Maiandra GD", 11.0!)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(29, 103)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 34)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "New Request"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Window
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Maiandra GD", 12.0!)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(29, 145)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 34)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(13, 82)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(167, 165)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.SystemColors.Window
        Me.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refresh.Font = New System.Drawing.Font("Maiandra GD", 12.0!)
        Me.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_refresh.Location = New System.Drawing.Point(29, 187)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(130, 34)
        Me.btn_refresh.TabIndex = 27
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'AdminidDataGridViewTextBoxColumn
        '
        Me.AdminidDataGridViewTextBoxColumn.DataPropertyName = "admin_id"
        Me.AdminidDataGridViewTextBoxColumn.HeaderText = "admin_id"
        Me.AdminidDataGridViewTextBoxColumn.Name = "AdminidDataGridViewTextBoxColumn"
        Me.AdminidDataGridViewTextBoxColumn.ReadOnly = True
        Me.AdminidDataGridViewTextBoxColumn.Visible = False
        '
        'AdminmsgDataGridViewTextBoxColumn
        '
        Me.AdminmsgDataGridViewTextBoxColumn.DataPropertyName = "admin_msg"
        Me.AdminmsgDataGridViewTextBoxColumn.HeaderText = "Message"
        Me.AdminmsgDataGridViewTextBoxColumn.Name = "AdminmsgDataGridViewTextBoxColumn"
        Me.AdminmsgDataGridViewTextBoxColumn.ReadOnly = True
        Me.AdminmsgDataGridViewTextBoxColumn.Width = 304
        '
        'AdminmsgstatusDataGridViewTextBoxColumn
        '
        Me.AdminmsgstatusDataGridViewTextBoxColumn.DataPropertyName = "admin_msg_status"
        Me.AdminmsgstatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.AdminmsgstatusDataGridViewTextBoxColumn.Name = "AdminmsgstatusDataGridViewTextBoxColumn"
        Me.AdminmsgstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdmindateDataGridViewTextBoxColumn
        '
        Me.AdmindateDataGridViewTextBoxColumn.DataPropertyName = "admin_date"
        Me.AdmindateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.AdmindateDataGridViewTextBoxColumn.Name = "AdmindateDataGridViewTextBoxColumn"
        Me.AdmindateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PurtbluserinboxBindingSource
        '
        Me.PurtbluserinboxBindingSource.DataMember = "pur_tbl_user_inbox"
        Me.PurtbluserinboxBindingSource.DataSource = Me.PurchasingData
        '
        'PurchasingData
        '
        Me.PurchasingData.DataSetName = "PurchasingData"
        Me.PurchasingData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pur_tbl_user_inboxTableAdapter
        '
        Me.Pur_tbl_user_inboxTableAdapter.ClearBeforeFill = True
        '
        'UsInbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 323)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgvUser)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbAdStatus)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Maiandra GD", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UsInbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UsInbox"
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurtbluserinboxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents cmbAdStatus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvUser As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_refresh As Button
    Friend WithEvents PurchasingData As PurchasingData
    Friend WithEvents PurtbluserinboxBindingSource As BindingSource
    Friend WithEvents Pur_tbl_user_inboxTableAdapter As PurchasingDataTableAdapters.pur_tbl_user_inboxTableAdapter
    Friend WithEvents AdminidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdminmsgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdminmsgstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdmindateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
