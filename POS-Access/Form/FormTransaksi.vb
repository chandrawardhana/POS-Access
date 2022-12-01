Imports System.Data.OleDb

Public Class FormTransaksi

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetBarang()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub





    Sub GetBarang()

        Try
            Dim Query As String = "SELECT NamaProduk FROM tbl_produk ORDER BY Kode"
            Cmd = New OleDbCommand(Query, Cn)
            Rdr = Cmd.ExecuteReader

            While Rdr.Read
                Cb2.Items.Add(Rdr("NamaProduk"))

            End While


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Cb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb2.SelectedIndexChanged
        Try
            Dim Query As String = "SELECT * FROM tbl_produk WHERE NamaProduk= '" & Cb2.SelectedItem & "'"
            Cmd = New OleDbCommand(Query, Cn)
            Rdr = Cmd.ExecuteReader

            While Rdr.Read
                t3.Text = Rdr.GetValue(4)

            End While
        Catch ex As Exception

        End Try
    End Sub
End Class