Public Class CreateNewUser
    ReadOnly AllowedKeys As String =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789,"
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtPass.KeyPress

        Select Case e.KeyChar

            Case Convert.ToChar(Keys.Enter) ' Enter is pressed
                ' Call method here...

            Case Convert.ToChar(Keys.Back) ' Backspace is pressed
                e.Handled = False ' Delete the character

            Case Convert.ToChar(Keys.Capital Or Keys.RButton) ' CTRL+V is pressed
                ' Paste clipboard content only if contains allowed keys
                e.Handled = Not Clipboard.GetText().All(Function(c) AllowedKeys.Contains(c))
                MsgBox("Not allowed Special Characters")


            Case Else ' Other key is pressed
                If Not AllowedKeys.Contains(e.KeyChar) Then
                    MsgBox("Not Allowed Special Characters")
                    e.Handled = Not AllowedKeys.Contains(e.KeyChar)
                End If

        End Select

    End Sub

    ReadOnly Allowed As String =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789,"
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtConpass.KeyPress

        Select Case e.KeyChar

            Case Convert.ToChar(Keys.Enter) ' Enter is pressed
                ' Call method here...

            Case Convert.ToChar(Keys.Back) ' Backspace is pressed
                e.Handled = False ' Delete the character

            Case Convert.ToChar(Keys.Capital Or Keys.RButton) ' CTRL+V is pressed
                ' Paste clipboard content only if contains allowed keys
                e.Handled = Not Clipboard.GetText().All(Function(c) Allowed.Contains(c))
                MsgBox("Not allowed Special Characters")


            Case Else ' Other key is pressed
                If Not Allowed.Contains(e.KeyChar) Then
                    MsgBox("Not Allowed Special Characters")
                    e.Handled = Not Allowed.Contains(e.KeyChar)
                End If

        End Select

    End Sub

    Private Sub btnSEND_Click(sender As Object, e As EventArgs) Handles btnSEND.Click
        Dim db As New PurchasingSystemDataContext
        Dim NewRec As New pur_tbl_user With {.new_user_name = txtName.Text, .new_user_pass = txtPass.Text, .new_confi_pass = txtConpass.Text, .new_user_dept = txtDept.Text, .user_type = txtUstype.Text}
        db.pur_tbl_users.InsertOnSubmit(NewRec)
        db.SubmitChanges()
        MsgBox("Registered!")
        txtName.Text = ""
        txtPass.Text = ""
        txtConpass.Text = ""
        txtDept.Text = ""
        txtUstype.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtName.Text = ""
        txtPass.Text = ""
        txtConpass.Text = ""
        txtDept.Text = ""
        txtUstype.Text = ""
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        AdminForm.Show()
        Me.Hide()
    End Sub

    Private Sub ViewUser_Click(sender As Object, e As EventArgs) Handles ViewUser.Click
        ViewUsers.Show()
        Me.Hide()
    End Sub
End Class