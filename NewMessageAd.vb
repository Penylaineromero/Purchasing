Public Class NewMessageAd
    Private Sub shortcutInventory_Click(sender As Object, e As EventArgs) Handles shortcutInventory.Click
        MainInventory.Show()
        Me.Close()
    End Sub

    Private Sub NewMessageAd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_admin_inbox' table. You can move, or remove it, as needed.
        Me.Pur_tbl_admin_inboxTableAdapter.Fill(Me.PurchasingData.pur_tbl_admin_inbox)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminForm.Show()
        Me.Close()
    End Sub

    Private Sub SEND_Click(sender As Object, e As EventArgs) Handles SEND.Click
        Dim db As New PurchasingSystemDataContext
        Dim RepAdmin As New pur_tbl_user_inbox With {.admin_msg = txtReceived.Text, .admin_msg_status = "Unread", .admin_date = dtpNowD.Value.ToString}
        db.pur_tbl_user_inboxes.InsertOnSubmit(RepAdmin)
        db.SubmitChanges()
        MsgBox("Message Sent!")
        txtReceived.Text = ""
    End Sub

    Private Sub listNotAvail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listNotAvail.SelectedIndexChanged
        txtReceived.Text = list_user_name.Text + "," + listNotAvail.Text + "(" + list_item_req.Text + ")"
    End Sub
End Class