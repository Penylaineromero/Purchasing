Public Class UserForm
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
        WForm.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub UserReq_Tick(sender As Object, e As EventArgs) Handles UserReq.Tick
        Dim db As New PurchasingSystemDataContext
        Dim sCount = From p In db.pur_tbl_user_inboxes
                     Where p.admin_msg_status = "Unread"
                     Select p
        btnReqNotif1.Text = sCount.Count.ToString
        If Val(btnReqNotif1.Text) > 0 Then
            btnReqNotif1.BackColor = Color.Red
        Else
            btnReqNotif1.BackColor = Color.Green
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        UsInbox.Show()
        Me.Hide()
    End Sub

    Private Sub btnReqNotif1_Click(sender As Object, e As EventArgs) Handles btnReqNotif1.Click
        UsInbox.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        UserFeedback.Show()
        Me.Hide()
    End Sub
End Class