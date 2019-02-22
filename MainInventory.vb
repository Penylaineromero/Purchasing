Public Class MainInventory
    Dim dbDataSet As New DataTable


    Private Sub MainInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_admin_inbox' table. You can move, or remove it, as needed.
        Me.Pur_tbl_admin_inboxTableAdapter.Fill(Me.PurchasingData.pur_tbl_admin_inbox)
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_inventory' table. You can move, or remove it, as needed.
        Me.Pur_tbl_inventoryTableAdapter.Fill(Me.PurchasingData.pur_tbl_inventory)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InventoryForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MainInventory_Load(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AdminForm.Show()
        Me.Close()

    End Sub

    Private Sub shortcutInventory_Click(sender As Object, e As EventArgs) Handles shortcutInventory.Click
        AdInbox.Show()
        Me.Hide()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Me.PurtblinventoryBindingSource.Filter = "item_name like '%" & txtSearch.Text & "%'"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim db As New PurchasingSystemDataContext
        Dim DeleteRequests = From p In db.pur_tbl_inventories
                             Where p.order_id = Val(dgv11.CurrentRow.Cells(0).Value)
                             Select p

        Select Case MsgBox("Do you really want to delete the current Item?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Delete Request")
            Case MsgBoxResult.Yes

                db.pur_tbl_inventories.DeleteOnSubmit(DeleteRequests.FirstOrDefault)
                db.SubmitChanges()
                MsgBox("Item Deleted Successfully!")
                MainInventory_Load(sender, e)
        End Select
    End Sub
End Class