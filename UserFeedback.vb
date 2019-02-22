Imports System.Runtime.InteropServices
Imports System.Runtime.CompilerServices

Public Class UserFeedback

    Private Sub UserFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_users' table. You can move, or remove it, as needed.
        Me.Pur_tbl_usersTableAdapter.Fill(Me.PurchasingData.pur_tbl_users)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim db As New PurchasingSystemDataContext
        Dim Newfeed As New pur_tbl_feedback With {.user_name = cbName.Text, .user_dept = cbDept.Text, .feed_date = dtpfeed.Text, .user_feedback = txtuserfeed.Text}
        db.pur_tbl_feedbacks.InsertOnSubmit(Newfeed)
        db.SubmitChanges()
        MsgBox("Sent!")
        cbName.Text = ""
        cbDept.Text = ""
        dtpfeed.Text = ""
        txtuserfeed.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        UserForm.Show()
        Me.Hide()
    End Sub

End Class