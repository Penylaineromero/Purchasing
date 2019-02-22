Public Class DelPenItems
    Private Sub DelPenItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_admin_inbox' table. You can move, or remove it, as needed.
        Me.Pur_tbl_admin_inboxTableAdapter.Fill(Me.PurchasingData.pur_tbl_admin_inbox)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminReports.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.PurtbladmininboxBindingSource.Filter = "user_req_status = '" & ComboBox1.Text & "'"
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim total As String = 0
        For i As Integer = 0 To dgv123.RowCount - 1
            total += dgv123.Rows(i).Cells(1).Value

        Next
        TextBox1.Text = total
    End Sub
End Class