Imports System.Data.SqlClient
Public Class ManageUser
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim query, roleId As String

    Sub koneksi()
        conn = New SqlConnection("Server=DESKTOP-88BF2P2;Database=penjualan;Integrated Security=True")
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Sub kosongkanData()
        tbUserId.Text = ""
        tbName.Text = ""
        tbUsername.Text = ""
        tbNoHP.Text = ""
        tbAlamat.Text = ""
        tbPassword.Text = ""
        tbConfirmPassword.Text = ""
    End Sub

    Sub addButton()
        Dim btnEdit, btnDelete As New DataGridViewButtonColumn()
        btnEdit.HeaderText = "Edit"
        btnEdit.Text = "Edit"
        btnEdit.Name = "Edit"
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.UseColumnTextForButtonValue = True
        dgv.Columns.Add(btnEdit)
        btnDelete.HeaderText = "Delete"
        btnDelete.Text = "Delete"
        btnDelete.Name = "Delete"
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.UseColumnTextForButtonValue = True
        dgv.Columns.Add(btnDelete)
    End Sub

    Sub kondisiAwal()
        query = "select a.Id, a.Name, a.Username, a.Alamat, a.nohp 'No Hp', b.name 'Role' from users a, roles b where a.roleid=b.id"
        dgv.AutoGenerateColumns = True
        dgv.DataSource = read(query)
        Call addButton()
        Call kosongkanData()
    End Sub

    Sub roleTitle()
        query = "select * from roles"
        selectRole.DataSource = read(query)
        selectRole.DisplayMember = "name"
        selectRole.ValueMember = "name"
    End Sub

    Private Sub ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
        Call roleTitle()
    End Sub

    Private Sub selectRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectRole.SelectedIndexChanged
        Call koneksi()
        query = "select * from roles where name='" & selectRole.Text & "'"
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            roleId = dr.Item("id")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If tbName.Text = "" Or tbUsername.Text = "" Or tbNoHP.Text = "" Or tbAlamat.Text = "" Or tbPassword.Text = "" Or tbConfirmPassword.Text = "" Then
            MsgBox("Mohon isi data dengan lengkap!", MsgBoxStyle.Critical, "Error")
        Else
            If tbPassword.Text <> tbConfirmPassword.Text Then
                MsgBox("Password tidak sama!", MsgBoxStyle.Critical, "Error")
            Else
                If tbUserId.Text = "" Then
                    query = "insert into users(name,username,alamat,nohp,password,roleid) values('{0}','{1}','{2}','{3}','{4}','{5}')"
                    query = String.Format(query, tbName.Text, tbUsername.Text, tbAlamat.Text, tbNoHP.Text, tbPassword.Text, roleId)
                    aksi(query)
                    MsgBox("data user berhasil dibuat!", MsgBoxStyle.Information, "Information")
                    dgv.Columns.RemoveAt(7)
                    dgv.Columns.RemoveAt(6)
                    Call kondisiAwal()
                Else
                    query = "update users set name='" & tbName.Text & "',username='" & tbUsername.Text & "',alamat='" & tbAlamat.Text & "',nohp='" & tbNoHP.Text & "',password='" & tbPassword.Text & "',roleid='" & roleId & "' where id='" & tbUserId.Text & "'"
                    aksi(query)
                    MsgBox("data user berhasil diubah!", MsgBoxStyle.Information, "Information")
                    dgv.Columns.RemoveAt(7)
                    dgv.Columns.RemoveAt(6)
                    Call kondisiAwal()
                End If
            End If
        End If
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If e.ColumnIndex = 6 Then
            tbUserId.Text = dgv.CurrentRow.Cells(0).Value
            tbName.Text = dgv.CurrentRow.Cells(1).Value
            tbUsername.Text = dgv.CurrentRow.Cells(2).Value
            tbAlamat.Text = dgv.CurrentRow.Cells(3).Value
            tbNoHP.Text = dgv.CurrentRow.Cells(4).Value
        ElseIf e.ColumnIndex = 7 Then
            tbUserId.Text = dgv.CurrentRow.Cells(0).Value
            If MessageBox.Show("Yakin mau hapus?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                query = "delete from users where id='" & tbUserId.Text & "'"
                aksi(query)
                MsgBox("data user berhasil dihapus!", MsgBoxStyle.Information, "Information")
                dgv.Columns.RemoveAt(7)
                dgv.Columns.RemoveAt(6)
                Call kondisiAwal()
            Else
                MsgBox("data user gagal dihapus!", MsgBoxStyle.Information, "Information")
                dgv.Columns.RemoveAt(7)
                dgv.Columns.RemoveAt(6)
                Call kondisiAwal()
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call kosongkanData()
    End Sub

    Private Sub tbNoHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNoHP.KeyPress
        Dim kunci As Short = Asc(e.KeyChar)
        If e.KeyChar Like "[0-9]" Or kunci = Keys.Back Then
            kunci = 0
        End If
        e.Handled = CBool(kunci)
    End Sub

    Private Sub btnManageBarang_Click_1(sender As Object, e As EventArgs) Handles btnManageBarang.Click
        ManageBarang.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewTransaction_Click_1(sender As Object, e As EventArgs) Handles btnViewTransaction.Click
        ViewTransaction.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MsgBox("Logout berhasil!", MsgBoxStyle.Information, "Information")
        Form1.kosongkanData()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub tbSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            dgv.Columns.RemoveAt(7)
            dgv.Columns.RemoveAt(6)
            query = "select a.Id, a.Name, a.Username, a.Alamat, a.nohp 'No Hp', b.name 'Role' from users a, roles b where a.roleid=b.id and a.name like '%" & tbSearch.Text & "%'"
            dgv.AutoGenerateColumns = True
            dgv.DataSource = read(query)
            Call addButton()
        End If
    End Sub
End Class