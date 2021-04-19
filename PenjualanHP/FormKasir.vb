Imports System.Data.SqlClient
Public Class FormKasir
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim query As String
    Dim stock As Integer
    Public userId As String

    Sub koneksi()
        conn = New SqlConnection("Server=DESKTOP-88BF2P2;Database=penjualan;Integrated Security=True")
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Sub kosongkanData()
        tbBarangId.Text = ""
        tbHarga.Text = ""
        tbJumlah.Text = ""
        tbTotal.Text = ""
        tbNamaBarang.Text = ""
    End Sub

    Sub kondisiAwal()
        query = "select a.Tanggal, a.customername 'Customer', c.Name, c.Harga, b.Jumlah, a.Total from pesanans a, pesanandetails b, barangs c where a.userid='" & userId & "' and a.id=b.pesananid and b.barangid=c.id  order by a.tanggal desc"
        dgv.DataSource = read(query)
        Call kosongkanData()
    End Sub

    Private Sub tbBarangId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbBarangId.KeyPress
        Dim kunci As Short = Asc(e.KeyChar)
        If e.KeyChar Like "[0-9]" Or kunci = Keys.Back Then
            kunci = 0
        End If
        e.Handled = CBool(kunci)
    End Sub

    Private Sub tbJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbJumlah.KeyPress
        Dim kunci As Short = Asc(e.KeyChar)
        If e.KeyChar Like "[0-9]" Or kunci = Keys.Back Then
            kunci = 0
        End If
        e.Handled = CBool(kunci)
    End Sub

    Private Sub tbJumlah_TextChanged(sender As Object, e As EventArgs) Handles tbJumlah.TextChanged
        If Not tbJumlah.Text = "" Then
            tbTotal.Text = tbHarga.Text * tbJumlah.Text
        End If
    End Sub

    Private Sub tbBarangId_TextChanged(sender As Object, e As EventArgs) Handles tbBarangId.TextChanged
        query = "select * from barangs where id='" & tbBarangId.Text & "'"
        If read(query).Rows.Count > 0 Then
            tbNamaBarang.Text = read(query).Rows(0)("name")
            tbHarga.Text = read(query).Rows(0)("harga")
        Else
            tbNamaBarang.Text = "Barang tidak ada!"
            tbHarga.Text = 0
        End If
    End Sub

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        If tbBarangId.Text = "" Or tbHarga.Text = "" Or tbJumlah.Text = "" Or tbTotal.Text = "" Or tbNamaBarang.Text = "" Or tbCustomerName.Text = "" Then
            MsgBox("Mohon isi data dengan lengkap!", MsgBoxStyle.Critical, "Error")
        Else
            Call koneksi()
            query = "select * from barangs where id='" & tbBarangId.Text & "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then
                stock = dr.Item("stock")
                query = "insert into pesanans(customername,userid,tanggal,status,total) values('{0}','{1}','{2}','Lunas','{3}')"
                query = String.Format(query, tbCustomerName.Text, userId, Date.Now.ToString("yyyy-MM-dd"), tbTotal.Text)
                aksi(query)
                Dim pesananId As Integer
                Call koneksi()
                query = "select top(1) * from pesanans order by id desc"
                cmd = New SqlCommand(query, conn)
                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then
                    pesananId = dr.Item("id")
                End If
                query = "insert into pesanandetails(pesananid,barangid,jumlah,total) values('{0}','{1}','{2}','{3}')"
                query = String.Format(query, pesananId, tbBarangId.Text, tbJumlah.Text, tbTotal.Text)
                aksi(query)
                query = "update barangs set stock='" & stock - tbJumlah.Text & "' where id='" & tbBarangId.Text & "'"
                aksi(query)
                MsgBox("Pembelian barang berhasil!", MsgBoxStyle.Information, "Information")
                Call kondisiAwal()
            End If
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MsgBox("Logout berhasil!", MsgBoxStyle.Information, "Information")
        Form1.kosongkanData()
        Form1.Show()
        Me.Hide()
    End Sub
End Class