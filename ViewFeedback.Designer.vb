<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewFeedback
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewFeedback))
        Me.dgvFEED = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserdeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeeddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserfeedbackDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeedstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurtblfeedbackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchasingData = New Purchasing_System_ICT_III_1.PurchasingData()
        Me.Pur_tbl_feedbackTableAdapter = New Purchasing_System_ICT_III_1.PurchasingDataTableAdapters.pur_tbl_feedbackTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgvFEED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurtblfeedbackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFEED
        '
        Me.dgvFEED.AutoGenerateColumns = False
        Me.dgvFEED.BackgroundColor = System.Drawing.Color.MistyRose
        Me.dgvFEED.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvFEED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFEED.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UseridDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.UserdeptDataGridViewTextBoxColumn, Me.FeeddateDataGridViewTextBoxColumn, Me.UserfeedbackDataGridViewTextBoxColumn, Me.FeedstatusDataGridViewTextBoxColumn})
        Me.dgvFEED.DataSource = Me.PurtblfeedbackBindingSource
        Me.dgvFEED.EnableHeadersVisualStyles = False
        Me.dgvFEED.GridColor = System.Drawing.Color.Maroon
        Me.dgvFEED.Location = New System.Drawing.Point(13, 69)
        Me.dgvFEED.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvFEED.Name = "dgvFEED"
        Me.dgvFEED.RowHeadersVisible = False
        Me.dgvFEED.Size = New System.Drawing.Size(771, 240)
        Me.dgvFEED.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(13, 14)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 32)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "BACK"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(312, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 21)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "VIEW FEEDBACKS"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MistyRose
        Me.Button1.Location = New System.Drawing.Point(688, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 34)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Read"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.UserdeptDataGridViewTextBoxColumn.Width = 150
        '
        'FeeddateDataGridViewTextBoxColumn
        '
        Me.FeeddateDataGridViewTextBoxColumn.DataPropertyName = "feed_date"
        Me.FeeddateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.FeeddateDataGridViewTextBoxColumn.Name = "FeeddateDataGridViewTextBoxColumn"
        '
        'UserfeedbackDataGridViewTextBoxColumn
        '
        Me.UserfeedbackDataGridViewTextBoxColumn.DataPropertyName = "user_feedback"
        Me.UserfeedbackDataGridViewTextBoxColumn.HeaderText = "Feedback"
        Me.UserfeedbackDataGridViewTextBoxColumn.Name = "UserfeedbackDataGridViewTextBoxColumn"
        Me.UserfeedbackDataGridViewTextBoxColumn.Width = 800
        '
        'FeedstatusDataGridViewTextBoxColumn
        '
        Me.FeedstatusDataGridViewTextBoxColumn.DataPropertyName = "feed_status"
        Me.FeedstatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.FeedstatusDataGridViewTextBoxColumn.Name = "FeedstatusDataGridViewTextBoxColumn"
        Me.FeedstatusDataGridViewTextBoxColumn.Width = 20
        '
        'PurtblfeedbackBindingSource
        '
        Me.PurtblfeedbackBindingSource.DataMember = "pur_tbl_feedback"
        Me.PurtblfeedbackBindingSource.DataSource = Me.PurchasingData
        '
        'PurchasingData
        '
        Me.PurchasingData.DataSetName = "PurchasingData"
        Me.PurchasingData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pur_tbl_feedbackTableAdapter
        '
        Me.Pur_tbl_feedbackTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MistyRose
        Me.Button2.Location = New System.Drawing.Point(585, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 34)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ViewFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(797, 323)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgvFEED)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ViewFeedback"
        Me.Text = "ViewFeedback"
        CType(Me.dgvFEED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurtblfeedbackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasingData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvFEED As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PurchasingData As PurchasingData
    Friend WithEvents PurtblfeedbackBindingSource As BindingSource
    Friend WithEvents Pur_tbl_feedbackTableAdapter As PurchasingDataTableAdapters.pur_tbl_feedbackTableAdapter
    Friend WithEvents UseridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserdeptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeeddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserfeedbackDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeedstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
