Imports System.Data.OleDb

Module myModule
    Public Cn As OleDbConnection
    Public Adp As OleDbDataAdapter
    Public Dst As DataSet
    Public Cmd As OleDbCommand
    Public Rdr As OleDbDataReader

    Public opt As Boolean = True


    Sub OpenConnection()

        ' Dim AlamatDB As String = "provider=microsoft.jet.oledb.4.0;data source = db_tabungan.mdb"

        Dim AlamatDB As String = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = mydb.accdb")

        Cn = New OleDbConnection(AlamatDB)

        Try
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If

        Catch ex As Exception
            MsgBox("Masukan Database ke Folder Aplikasi ini : " & ex.Message.ToString)
        End Try

    End Sub


    Sub tampilTabel(ByVal tabel As String, ByVal Gird As DataGridView)
        Adp = New OleDbDataAdapter("SELECT * FROM " & tabel & "", Cn)
        Dst = New DataSet
        Dst.Clear()
        Adp.Fill(Dst, "SELECT * FROM " & tabel & "")
        Gird.DataSource = (Dst.Tables("SELECT * FROM " & tabel & ""))
    End Sub


    Function ID_Auto(ByVal tBox As TextBox, ByVal Query As String, ByVal No As String, ByVal ID As String, ByVal NoID As String, ByVal IDPe As String, ByVal NoID1 As String, ByVal NoID2 As String, ByVal NoID3 As String, ByVal plus As Integer)
        Try
            'Cn.Close() : Cn.Open()
            Cmd = New OleDbCommand("" & Query & "", Cn)
            Rdr = Cmd.ExecuteReader
            Rdr.Read()

            If Rdr.HasRows = 0 Then
                tBox.Text = "" & NoID & ""
                Rdr.Close()
            End If

            If Not Rdr.HasRows Then
                tBox.Text = "" & ID & "" + "" & No & ""
                Rdr.Close()
            Else
                tBox.Text = Val(Microsoft.VisualBasic.Mid(Rdr.Item("" & IDPe & "").ToString, 5, 4)) + 1
                If Len(tBox.Text) = 1 Then
                    tBox.Text = "" & NoID1 & "" & tBox.Text & ""
                ElseIf Len(tBox.Text) = 2 Then
                    tBox.Text = "" & NoID2 & "" & tBox.Text & ""
                ElseIf Len(tBox.Text) = 3 Then
                    tBox.Text = "" & NoID3 & "" & tBox.Text & ""
                End If
                Rdr.Close()
            End If
        Catch ex As Exception
            'MsgBox("Maaf Error :" & ex.Message & " Silah Cek Lagi", MsgBoxStyle.Exclamation, "Peringatan")
        End Try
        Return tBox
    End Function


End Module
