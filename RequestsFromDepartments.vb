Public Class RequestsFromDepartments
    Private Sub RequestsFromDepartments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_admin_inbox' table. You can move, or remove it, as needed.
        Me.Pur_tbl_admin_inboxTableAdapter.Fill(Me.PurchasingData.pur_tbl_admin_inbox)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminReports.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.PurtbladmininboxBindingSource.Filter = "user_dept = '" & ComboBox1.Text & "'"
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RequestsFromDepartments_Load(sender, e)
    End Sub
End Class