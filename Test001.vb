Public Class Test001
    Dim NewQty As Integer
    Dim iSelectedIndex As Integer
    Private Sub Test001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_inventory' table. You can move, or remove it, as needed.
        Me.Pur_tbl_inventoryTableAdapter.Fill(Me.PurchasingData.pur_tbl_inventory)
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_admin_inbox' table. You can move, or remove it, as needed.
        Me.Pur_tbl_admin_inboxTableAdapter.Fill(Me.PurchasingData.pur_tbl_admin_inbox)
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        If dgv.CurrentRow.Cells(5).Value = "Delivered" Then
            MsgBox("Item already delivered")
            Exit Sub
        End If
        Try
            iSelectedIndex = dgv.CurrentRow.Index
            Dim db As New PurchasingSystemDataContext
            'The below code will get the OldQty of the item where itemName is equal to dgv.CurrentRow.Cells(3).Value
            Dim OldQty = (From p In db.pur_tbl_inventories Where p.item_name = dgv.CurrentRow.Cells(3).Value.ToString Select p).SingleOrDefault
            'This will subtract the requested qty from the old qty and will generate a new qty
            NewQty = Val(OldQty.item_qty) - Val(dgv.CurrentRow.Cells(4).Value)
            'This will update the itemQty in the Invetory table
            Me.Pur_tbl_inventoryTableAdapter.UpdateQtyPerReq(NewQty, dgv.CurrentRow.Cells(3).Value)
            Me.Pur_tbl_admin_inboxTableAdapter.UpdateStatus("Delivered", dgv.CurrentRow.Cells(1).Value, dgv.CurrentRow.Cells(2).Value, dgv.CurrentRow.Cells(3).Value, dgv.CurrentRow.Cells(4).Value)
            'No need for explanatioon here XDD
            MsgBox("Successful")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Just load the inbox table to see if status is changed to delivered or whatever
        Me.Pur_tbl_admin_inboxTableAdapter.Fill(Me.PurchasingData.pur_tbl_admin_inbox)
        'YOu don't need to add this to your main form as I add this just to check if it is working all well
        Me.Pur_tbl_inventoryTableAdapter.FillByItemName(Me.PurchasingData.pur_tbl_inventory, dgv.CurrentRow.Cells(3).Value)
        dgv.Rows(iSelectedIndex).Selected = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, dgv.CellContentClick
        'Same thing!
        Me.Pur_tbl_inventoryTableAdapter.FillByItemName(Me.PurchasingData.pur_tbl_inventory, dgv.CurrentRow.Cells(3).Value)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim db As New PurchasingSystemDataContext
        Dim shwms = (From p In db.pur_tbl_inventories).Count
        'Button3.Text = shwms
        MsgBox(shwms) 'lets try this!
        'txtResult.Text = Val(txt1.Text) + Val(txt2.Text)
    End Sub

    Private Sub tM_Tick(sender As Object, e As EventArgs) Handles tM.Tick
        'For each ro As datagrid
    End Sub

    Private Sub dgv2_Paint(sender As Object, e As PaintEventArgs) Handles dgv2.Paint
        btnPrice.Text = "0"
        btnQty.Text = "0"
        For i As Integer = 0 To dgv2.RowCount - 1
            btnPrice.Text = Val(btnPrice.Text) + Val(dgv2.Rows(i).Cells(4).Value.ToString)
            btnQty.Text = Val(btnQty.Text) + Val(dgv2.Rows(i).Cells(3).Value.ToString)
        Next
    End Sub
End Class