Public Class AdminReports
    Private Sub btnRequestsFD_Click(sender As Object, e As EventArgs) Handles btnRequestsFD.Click
        Me.Hide()
        RequestsFromDepartments.Show()


    End Sub

    Private Sub btnDeliveredItems_Click(sender As Object, e As EventArgs) Handles btnDelPen.Click
        Me.Hide()
        DelPenItems.Show()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        AdminForm.Show()

    End Sub
End Class