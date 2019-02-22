Public Class LoginForm
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim db As New PurchasingSystemDataContext
        Dim CheckUser = From p In db.pur_tbl_users
                        Where p.new_user_name = txtUsername.Text And p.new_user_pass = txtPass.Text
                        Select p
        Dim CheckAdmin = From p In db.pur_tbl_users
                         Where p.new_user_name = txtUsername.Text And p.user_type = "admin"
                         Select p
        If CheckUser.Count <> 0 Then
            If CheckAdmin.Count <> 0 Then
                AdminForm.Show()
            Else
                UserForm.Show()
            End If
            Me.Close()
        Else
            MsgBox("Username and Password are invalid!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtUsername.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        WForm.Show()
    End Sub
End Class