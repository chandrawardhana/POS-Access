Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Public Class FormProduk
    Public QueryID As String = "Select * From tbl_produk Where Kode in(select max(Kode) from tbl_produk)"
    Public ID As String = "BRG-"
    Public NO As String = "0001"
    Public IDPe As String = "Kode"
    Public NOID As String = "BRG-0001"
    Public NOID1 As String = "BRG-000"
    Public NOID2 As String = "BRG-00"
    Public NOID3 As String = "BRG-0"


    Dim plus As Integer = 1

    Private Sub FormProduk_Load(sender As Object, e As EventArgs) Handles Me.Load
        tampilTabel("tbl_produk", DataGridView1)
        rapikanGrid()

        Call ID_Auto(tVar, QueryID, NO, ID, NOID, IDPe, NOID1, NOID2, NOID3, plus)
        t1.Text = tVar.Text
    End Sub




    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        getDataGrid()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        getDataGrid()
    End Sub

    Private Sub UbahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahToolStripMenuItem.Click
        getDataGrid()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If opt = True Then
            If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Then
                MsgBox("Maaf data kosong !", MsgBoxStyle.Exclamation, "Peringatan")

            Else
                If Val(t5.Text) <= Val(t4.Text) Then
                    MsgBox("Harga Jual lebih kecil !", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    simpan()
                    ClearData()
                End If

            End If

        Else
            If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Then
                MsgBox("Maaf data kosong !", MsgBoxStyle.Exclamation, "Peringatan")

            Else
                If Val(t5.Text) <= Val(t4.Text) Then
                    MsgBox("Harga Jual lebih kecil !", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    ubah()
                    ClearData()
                End If


            End If
        End If
    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        If t1.Text = "" Then
            MsgBox("Pilih Data dulu !", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            hapus()
            ClearData()

        End If
    End Sub

    Private Sub BatalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BatalToolStripMenuItem.Click
        ClearData()
    End Sub

    Sub ClearData()
        t1.Clear()
        t2.Clear()
        t3.Clear()
        t4.Clear()
        t5.Clear()
        t6.Clear()

        opt = True
        tampilTabel("tbl_produk", DataGridView1)
        btnSimpan.Text = "SAVE"
        Call ID_Auto(tVar, QueryID, NO, ID, NOID, IDPe, NOID1, NOID2, NOID3, plus)
        t1.Text = tVar.Text
    End Sub

    Sub rapikanGrid()

        With DataGridView1

            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
            .Columns(3).DefaultCellStyle.Format = "Rp ###,##0"

        End With


    End Sub

    Sub getDataGrid()
        t1.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        t2.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        t3.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        t4.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        t5.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        t6.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        opt = False
        btnSimpan.Text = "UPDATE"
    End Sub


    Private Sub simpan()
        Dim Query As String = "INSERT INTO tbl_produk VALUES ('" & t1.Text & "', '" & t2.Text & "', '" & t3.Text & "', '" & t4.Text & "', '" & t5.Text & "', '" & t6.Text & "')"

        Cmd = New OleDbCommand(Query, Cn)
        Cmd.ExecuteNonQuery()

    End Sub



    Private Sub ubah()
        Dim Query As String = "UPDATE tbl_produk set NamaProduk='" & t2.Text & "',Stok='" & t3.Text & "',HargaBeli='" & t4.Text & "',HargaJual='" & t4.Text & "',Ket='" & t6.Text & "' WHERE Kode='" & t1.Text & "'"

        Cmd = New OleDbCommand(Query, Cn)
        Cmd.ExecuteNonQuery()

    End Sub


    Private Sub hapus()
        Dim Query As String = "DELETE from tbl_produk WHERE Kode='" & t1.Text & "'"
        Cmd = New OleDbCommand(Query, Cn)
        Cmd.ExecuteNonQuery()

    End Sub


    Sub cariData()

        Try
            Using Cmd As New OleDbCommand("Select * from tbl_produk where NamaProduk like '%" & t0.Text & "%' Order By Kode", Cn)
                Using Rdr As OleDbDataReader = Cmd.ExecuteReader
                    Using Tabel As New DataTable
                        Tabel.Load(Rdr)
                        If Tabel.Rows.Count = 0 Then
                            DataGridView1.DataSource = Nothing
                        Else
                            DataGridView1.DataSource = Tabel
                        End If

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Maaf Error :" & ex.Message & " Silah Cek Lagi", MsgBoxStyle.Exclamation, "Peringatan")
        End Try

    End Sub

    Private Sub t0_TextChanged(sender As Object, e As EventArgs) Handles t0.TextChanged
        cariData()
    End Sub


End Class