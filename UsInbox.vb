Public Class UsInbox
    Private Sub UsInbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_user_inbox' table. You can move, or remove it, as needed.
        Me.Pur_tbl_user_inboxTableAdapter.Fill(Me.PurchasingData.pur_tbl_user_inbox)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserRequest.Show()
        Me.Hide()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        UsInbox_Load(sender, e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim db As New PurchasingSystemDataContext
        Dim DeleteRequests = From p In db.pur_tbl_user_inboxes
                             Where p.admin_id = Val(dgvUser.CurrentRow.Cells(0).Value)
                             Select p

        Select Case MsgBox("Do you really want to delete the current Item?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Delete Request")
            Case MsgBoxResult.Yes

                db.pur_tbl_user_inboxes.DeleteOnSubmit(DeleteRequests.FirstOrDefault)
                db.SubmitChanges()
                MsgBox("Item Deleted Successfully!")
                UsInbox_Load(sender, e)
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim db As New PurchasingSystemDataContext
        Me.Pur_tbl_user_inboxTableAdapter.UpdateAdStatus(cmbAdStatus.Text, dgvUser.CurrentRow.Cells(1).Value, dgvUser.CurrentRow.Cells(3).Value)
        MsgBox("Successful")
        UsInbox_Load(sender, e)
    End Sub
End Class