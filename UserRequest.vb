Public Class UserRequest
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtName.Text = ""
        txtDept.Text = ""
        txtItemreq.Text = ""
        txtQty.Text = ""
    End Sub

    Private Sub btnSEND_Click(sender As Object, e As EventArgs) Handles btnSEND.Click
        Dim db As New PurchasingSystemDataContext
        Dim NewReq As New pur_tbl_admin_inbox With {.user_name = txtName.Text, .user_dept = txtDept.Text, .user_item_request = txtItemreq.Text, .user_item_qty = txtQty.Text, .user_req_status = "Pending", .user_date = dtpNow.Value.ToString}
        db.pur_tbl_admin_inboxes.InsertOnSubmit(NewReq)
        db.SubmitChanges()
        MsgBox("Message Sent!")
        txtDept.Text = ""
        txtItemreq.Text = ""
        txtQty.Clear()
        txtName.Clear()
        txtName.Focus()

    End Sub

    Private Sub UserRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_inventory' table. You can move, or remove it, as needed.
        Me.Pur_tbl_inventoryTableAdapter.Fill(Me.PurchasingData.pur_tbl_inventory)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        UsInbox.Show()
        Me.Close()
    End Sub
End Class