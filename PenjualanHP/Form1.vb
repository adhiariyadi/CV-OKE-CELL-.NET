Public Class Form1
    Dim query As String

    Public Sub kosongkanData()
        tbUsername.Text = ""
        tbPassword.Text = ""
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbUsername.Text = "" Or tbPassword.Text = "" Then
            MsgBox("Mohon isi data dengan lengkap!", MsgBoxStyle.Critical, "Error")
        Else
            query = "select * from users where username='" & tbUsername.Text & "'"
            If read(query).Rows.Count > 0 Then
                query = "select * from users where username='" & tbUsername.Text & "' and password='" & tbPassword.Text & "'"
                If read(query).Rows.Count > 0 Then
                    MsgBox("Selemat datang " + read(query).Rows(0)("name"), MsgBoxStyle.Information, "Information")
                    If read(query).Rows(0)("roleid") = 1 Then
                        FormAdmin.Label2.Text = "Hallo, " + read(query).Rows(0)("name")
                        ManageUser.Label2.Text = "Hallo, " + read(query).Rows(0)("name")
                        ManageBarang.Label2.Text = "Hallo, " + read(query).Rows(0)("name")
                        ViewTransaction.Label2.Text = "Hallo, " + read(query).Rows(0)("name")
                        FormAdmin.Show()
                    ElseIf read(query).Rows(0)("roleid") = 2 Then
                        FormKasir.userId = read(query).Rows(0)("id")
                        FormKasir.Label2.Text = "Hallo, " + read(query).Rows(0)("name")
                        FormKasir.kondisiAwal()
                        FormKasir.Show()
                    End If
                    Me.Hide()
                Else
                    MsgBox("Password anda salah!", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("Users tidak ditemukan!", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub btnReset_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        Call kosongkanData()
    End Sub
End Class
