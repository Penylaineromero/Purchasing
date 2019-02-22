
Public Class AdInbox
    Dim NewQty As Integer
    Dim iSelectedIndex As Integer
    Private Sub AdInbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_inventory' table. You can move, or remove it, as needed.
        Me.Pur_tbl_inventoryTableAdapter.Fill(Me.PurchasingData.pur_tbl_inventory)
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_admin_inbox' table. You can move, or remove it, as needed.
        Me.Pur_tbl_admin_inboxTableAdapter.Fill(Me.PurchasingData.pur_tbl_admin_inbox)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AdminForm.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim db As New PurchasingSystemDataContext
        'Me.Pur_tbl_admin_inboxTableAdapter.UpdateStatus(cmbStatus.Text, AdminGrid.CurrentRow.Cells(1).Value, AdminGrid.CurrentRow.Cells(2).Value, AdminGrid.CurrentRow.Cells(3).Value, AdminGrid.CurrentRow.Cells(4).Value)
        'MsgBox("Successful")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AdInbox_Load(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewMessageAd.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim db As New PurchasingSystemDataContext
        Dim DeleteRequests = From p In db.pur_tbl_admin_inboxes
                             Where p.user_id = Val(AdminGrid.CurrentRow.Cells(0).Value)
                             Select p

        Select Case MsgBox("Do you really want to delete the current Item?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Delete Request")
            Case MsgBoxResult.Yes

                db.pur_tbl_admin_inboxes.DeleteOnSubmit(DeleteRequests.FirstOrDefault)
                db.SubmitChanges()
                MsgBox("Item Deleted Successfully!")
                AdInbox_Load(sender, e)
        End Select
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MainInventory.Show()
        Me.Hide()
    End Sub

    Private Sub btnDelivered_Click(sender As Object, e As EventArgs) Handles btnDelivered.Click
        If AdminGrid.CurrentRow.Cells(5).Value = "Delivered" Then
            MsgBox("Item already delivered")
            Exit Sub
        End If
        Try
            iSelectedIndex = AdminGrid.CurrentRow.Index
            Dim db As New PurchasingSystemDataContext
            'The below code will get the OldQty of the item where itemName is equal to dgv.CurrentRow.Cells(3).Value
            Dim OldQty = (From p In db.pur_tbl_inventories Where p.item_name = AdminGrid.CurrentRow.Cells(3).Value.ToString Select p).SingleOrDefault
            'This will subtract the requested qty from the old qty and will generate a new qty
            NewQty = Val(OldQty.item_qty) - Val(AdminGrid.CurrentRow.Cells(4).Value)
            'This will update the itemQty in the Invetory table
            Me.Pur_tbl_inventoryTableAdapter.UpdateQtyPerReq(NewQty, AdminGrid.CurrentRow.Cells(3).Value)
            Me.Pur_tbl_admin_inboxTableAdapter.UpdateStatus("Delivered", AdminGrid.CurrentRow.Cells(1).Value, AdminGrid.CurrentRow.Cells(2).Value, AdminGrid.CurrentRow.Cells(3).Value, AdminGrid.CurrentRow.Cells(4).Value)
            'No need for explanatioon here XDD
            MsgBox("Successful")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Just load the inbox table to see if status is changed to delivered or whatever
        Me.Pur_tbl_admin_inboxTableAdapter.Fill(Me.PurchasingData.pur_tbl_admin_inbox)
        'YOu don't need to add this to your main form as I add this just to check if it is working all well
        Me.Pur_tbl_inventoryTableAdapter.FillByItemName(Me.PurchasingData.pur_tbl_inventory, AdminGrid.CurrentRow.Cells(3).Value)
        AdminGrid.Rows(iSelectedIndex).Selected = True
    End Sub
End Class