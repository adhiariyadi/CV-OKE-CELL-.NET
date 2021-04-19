Public Class ManageBarang
    Dim query As String

    Sub kosongkanData()
        tbBarangId.Text = ""
        tbName.Text = ""
        tbKeterangan.Text = ""
        tbHarga.Text = ""
        tbStock.Text = ""
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
        query = "select * from barangs order by name"
        dgv.AutoGenerateColumns = True
        dgv.DataSource = read(query)
        Call addButton()
        Call kosongkanData()
    End Sub

    Private Sub ManageBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Private Sub tbHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbHarga.KeyPress
        Dim kunci As Short = Asc(e.KeyChar)
        If e.KeyChar Like "[0-9]" Or kunci = Keys.Back Then
            kunci = 0
        End If
        e.Handled = CBool(kunci)
    End Sub

    Private Sub tbStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStock.KeyPress
        Dim kunci As Short = Asc(e.KeyChar)
        If e.KeyChar Like "[0-9]" Or kunci = Keys.Back Then
            kunci = 0
        End If
        e.Handled = CBool(kunci)
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If e.ColumnIndex = 5 Then
            tbBarangId.Text = dgv.CurrentRow.Cells(0).Value
            tbName.Text = dgv.CurrentRow.Cells(1).Value
            tbKeterangan.Text = dgv.CurrentRow.Cells(4).Value
            tbHarga.Text = dgv.CurrentRow.Cells(2).Value
            tbStock.Text = dgv.CurrentRow.Cells(3).Value
        ElseIf e.ColumnIndex = 6 Then
            tbBarangId.Text = dgv.CurrentRow.Cells(0).Value
            If MessageBox.Show("Yakin mau hapus?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                query = "delete from barangs where id='" & tbBarangId.Text & "'"
                aksi(query)
                MsgBox("data barangs berhasil dihapus!", MsgBoxStyle.Information, "Information")
                dgv.Columns.RemoveAt(6)
                dgv.Columns.RemoveAt(5)
                Call kondisiAwal()
            Else
                MsgBox("data barangs gagal dihapus!", MsgBoxStyle.Information, "Information")
                dgv.Columns.RemoveAt(6)
                dgv.Columns.RemoveAt(5)
                Call kondisiAwal()
            End If
        End If
    End Sub

    Private Sub tbSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            dgv.Columns.RemoveAt(6)
            dgv.Columns.RemoveAt(5)
            query = "select * from barangs where name like '%" & tbSearch.Text & "%'"
            dgv.AutoGenerateColumns = True
            dgv.DataSource = read(query)
            Call addButton()
        End If
    End Sub

    Private Sub btnManageUser_Click_1(sender As Object, e As EventArgs) Handles btnManageUser.Click
        ManageUser.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewTransaction_Click_1(sender As Object, e As EventArgs) Handles btnViewTransaction.Click
        ViewTransaction.Show()
        Me.Hide()
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        If tbName.Text = "" Or tbKeterangan.Text = "" Or tbHarga.Text = "" Or tbStock.Text = "" Then
            MsgBox("Mohon isi data dengan lengkap!", MsgBoxStyle.Critical, "Error")
        Else
            If tbBarangId.Text = "" Then
                query = "insert into barangs(name,keterangan,harga,stock) values('{0}','{1}','{2}','{3}')"
                query = String.Format(query, tbName.Text, tbKeterangan.Text, tbHarga.Text, tbStock.Text)
                aksi(query)
                MsgBox("data barangs berhasil dibuat!", MsgBoxStyle.Information, "Information")
                dgv.Columns.RemoveAt(6)
                dgv.Columns.RemoveAt(5)
                Call kondisiAwal()
            Else
                query = "update barangs set name='" & tbName.Text & "',keterangan='" & tbKeterangan.Text & "',harga='" & tbHarga.Text & "',stock='" & tbStock.Text & "' where id='" & tbBarangId.Text & "'"
                aksi(query)
                MsgBox("data barangs berhasil diubah!", MsgBoxStyle.Information, "Information")
                dgv.Columns.RemoveAt(6)
                dgv.Columns.RemoveAt(5)
                Call kondisiAwal()
            End If
        End If
    End Sub

    Private Sub btnReset_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        Call kosongkanData()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MsgBox("Logout berhasil!", MsgBoxStyle.Information, "Information")
        Form1.kosongkanData()
        Form1.Show()
        Me.Hide()
    End Sub
End Class