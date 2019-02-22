Public Class ViewFeedback
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AdminForm.Show()
        Me.Hide()
    End Sub

    Private Sub ViewFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_feedback' table. You can move, or remove it, as needed.
        Me.Pur_tbl_feedbackTableAdapter.Fill(Me.PurchasingData.pur_tbl_feedback)
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_feedback' table. You can move, or remove it, as needed.
        Me.Pur_tbl_feedbackTableAdapter.Fill(Me.PurchasingData.pur_tbl_feedback)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim db As New PurchasingSystemDataContext
        Me.Pur_tbl_feedbackTableAdapter.UpdateFeedStat("Read", dgvFEED.CurrentRow.Cells(1).Value, dgvFEED.CurrentRow.Cells(2).Value)
        MsgBox("Successful")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ViewFeedback_Load(sender, e)
    End Sub
End Class