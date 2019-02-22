Public Class AdminForm
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub Requests_Tick(sender As Object, e As EventArgs) Handles Requests.Tick
        Dim db As New PurchasingSystemDataContext
        Dim rCount = From p In db.pur_tbl_admin_inboxes
                     Where p.user_req_status = "Pending"
                     Select p
        btnReqNotif.Text = rCount.Count.ToString
        If Val(btnReqNotif.Text) > 0 Then
            btnReqNotif.BackColor = Color.Red
        Else
            btnReqNotif.BackColor = Color.Green
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        AdInbox.Show()
        Me.Hide()
    End Sub

    Private Sub btnNotif_Click(sender As Object, e As EventArgs) Handles btnReqNotif.Click
        AdInbox.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MainInventory.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        CreateNewUser.Show()
        Me.Hide()
    End Sub

    Private Sub Feedbacks_Tick(sender As Object, e As EventArgs) Handles Feedbacks.Tick
        Dim db As New PurchasingSystemDataContext
        Dim rCt = From p In db.pur_tbl_feedbacks
                  Where p.feed_status = "Unread"
                  Select p
        btnF.Text = rCt.Count.ToString
        If Val(btnF.Text) > 0 Then
            btnReqNotif.BackColor = Color.Red
        Else
            btnF.BackColor = Color.Green
        End If
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        ViewFeedback.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ViewFeedback.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        AdminReports.Show()
        Me.Hide()

    End Sub
End Class