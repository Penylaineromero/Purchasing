Imports System.Data.SqlClient
Public Class InventoryForm

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchasingData1.pur_tbl_inventory' table. You can move, or remove it, as needed.
        Me.Pur_tbl_inventoryTableAdapter.Fill(Me.PurchasingData1.pur_tbl_inventory)
        'TODO: This line of code loads data into the 'PurchasingData.pur_tbl_inventory' table. You can move, or remove it, as needed.
        Me.Pur_tbl_inventoryTableAdapter.Fill(Me.PurchasingData.pur_tbl_inventory)
        '
        For i As Integer = 0 To dgvInvent.RowCount - 2
            dgvInvent.Rows(i).Cells(5).Value = $"PHP{(Val(dgvInvent.Rows(i).Cells(3).Value.ToString) * Val(dgvInvent.Rows(i).Cells(4).Value.ToString)).ToString("0.00")}"
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim db As New PurchasingSystemDataContext
        Me.Pur_tbl_inventoryTableAdapter.UpdateDate(txtDate.Text, dgvInvent.CurrentRow.Cells(0).Value, dgvInvent.CurrentRow.Cells(3).Value, dgvInvent.CurrentRow.Cells(1).Value)
        Me.Pur_tbl_inventoryTableAdapter.UpdateQuantity(txtQty.Text, dgvInvent.CurrentRow.Cells(1).Value, dgvInvent.CurrentRow.Cells(0).Value)
        Me.Pur_tbl_inventoryTableAdapter.UpdateName(txtName.Text, dgvInvent.CurrentRow.Cells(2).Value, dgvInvent.CurrentRow.Cells(0).Value)
        Me.Pur_tbl_inventoryTableAdapter.UpdatePrice(txtPrice.Text, dgvInvent.CurrentRow.Cells(2).Value, dgvInvent.CurrentRow.Cells(0).Value)
        MsgBox("Successful")
        InventoryForm_Load(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtName.Text = ""
        txtDate.Text = ""
        txtQty.Text = ""
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim db As New PurchasingSystemDataContext
        Dim NewRecord As New pur_tbl_inventory With {.item_name = txtName.Text, .item_date = txtDate.Text, .item_qty = txtQty.Text, .item_price = txtPrice.Text}
        db.pur_tbl_inventories.InsertOnSubmit(NewRecord)
        db.SubmitChanges()
        MsgBox("Item Added Successfully!")
        txtName.Text = ""
        txtDate.Text = ""
        txtQty.Clear()
        InventoryForm_Load(sender, e)
    End Sub
    Private Sub btnBACK_Click(sender As Object, e As EventArgs) Handles btnBACK.Click
        MainInventory.Show()
        Me.Close()
    End Sub

    Private Sub dgvInvent_Paint(sender As Object, e As PaintEventArgs) Handles dgvInvent.Paint
        'For i As Integer = 0 To dgvInvent.RowCount - 2
        'If Not IsNothing(ro.Cells(3).Value) And Not IsNothing(ro.Cells(4).Value) Then
        'dgvInvent.Rows(i).Cells(5).Value = $"PHP{(Val(dgvInvent.Rows(i).Cells(3).Value.ToString) * Val(dgvInvent.Rows(i).Cells(4).Value.ToString)).ToString("0.00")}"
        'ro.Cells(5).Value = $"PHP{(Val(ro.Cells(3).Value.ToString) * Val(ro.Cells(4).Value.ToString)).ToString("0.00")}"
        'ro.Cells(5).Value = $"PHP{(Val(IIf(ro.Cells(3).Value <> "", ro.Cells(3).Value, 0)) * Val(IIf(ro.Cells(4).Value <> "", ro.Cells(4).Value, 0))).ToString("0.00")}"
        'End If
        'Next
        dgvInvent.CurrentRow.Cells(5).Value = $"PHP{(Val(dgvInvent.CurrentRow.Cells(3).Value.ToString) * Val(dgvInvent.CurrentRow.Cells(4).Value.ToString)).ToString("0.00")}"
    End Sub
End Class