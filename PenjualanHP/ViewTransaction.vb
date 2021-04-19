Public Class ViewTransaction
    Private Sub ViewTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'penjualanDataSet.Pesanans' table. You can move, or remove it, as needed.
        Me.PesanansTableAdapter.Fill(Me.penjualanDataSet.Pesanans)

        Me.rv.RefreshReport()
    End Sub

    Private Sub btnManageBarang_Click_1(sender As Object, e As EventArgs) Handles btnManageBarang.Click
        ManageBarang.Show()
        Me.Hide()
    End Sub

    Private Sub btnManageUser_Click_1(sender As Object, e As EventArgs) Handles btnManageUser.Click
        ManageUser.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MsgBox("Logout berhasil!", MsgBoxStyle.Information, "Information")
        Form1.kosongkanData()
        Form1.Show()
        Me.Hide()
    End Sub
End Class