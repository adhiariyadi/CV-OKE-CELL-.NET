Public Class FormAdmin
    Private Sub btnManageUser_Click(sender As Object, e As EventArgs)
        ManageUser.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MsgBox("Logout berhasil!", MsgBoxStyle.Information, "Information")
        Form1.kosongkanData()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnManageBarang_Click(sender As Object, e As EventArgs)
        ManageBarang.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewTransaction_Click(sender As Object, e As EventArgs)
        ViewTransaction.Show()
        Me.Hide()
    End Sub

    Private Sub btnManageBarang_Click_1(sender As Object, e As EventArgs) Handles btnManageBarang.Click
        ManageBarang.Show()
        Me.Hide()
    End Sub

    Private Sub btnManageUser_Click_1(sender As Object, e As EventArgs) Handles btnManageUser.Click
        ManageUser.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewTransaction_Click_1(sender As Object, e As EventArgs) Handles btnViewTransaction.Click
        ViewTransaction.Show()
        Me.Hide()
    End Sub
End Class