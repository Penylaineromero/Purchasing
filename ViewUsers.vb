Public Class ViewUsers
    Private Sub ViewUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_users' table. You can move, or remove it, as needed.
        Me.Pur_tbl_usersTableAdapter.Fill(Me.PurchasingData.pur_tbl_users)

    End Sub

    Private Sub txtDel_Click(sender As Object, e As EventArgs) Handles txtDel.Click
        Dim db As New PurchasingSystemDataContext
        Dim DeleteRequests = From p In db.pur_tbl_users
                             Where p.new_user_id = Val(dgvNewUsers.CurrentRow.Cells(0).Value)
                             Select p

        Select Case MsgBox("Do you really want to delete the current Item?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Delete Request")
            Case MsgBoxResult.Yes

                db.pur_tbl_users.DeleteOnSubmit(DeleteRequests.FirstOrDefault)
                db.SubmitChanges()
                MsgBox("Item Deleted Successfully!")
                ViewUsers_Load(sender, e)
        End Select
    End Sub

    Private Sub btnRef_Click(sender As Object, e As EventArgs) Handles btnRef.Click
        ViewUsers_Load(sender, e)
    End Sub

    Private Sub btnBck_Click(sender As Object, e As EventArgs) Handles btnBck.Click
        CreateNewUser.Show()
        Me.Hide()
    End Sub
End Class