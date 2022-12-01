Imports System.Data.OleDb

Public Class FormAdmintrator

    Dim id As Integer

    Private Sub FormAdministraor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setData()

        PictureBox2.ImageLocation = tUrl.Text
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage

        PictureBox2.Image = POS_Access.My.Resources.administrato

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Sub setData()

        Cmd = New OleDbCommand("select * from tbl_admin where id=1", Cn)
        Rdr = Cmd.ExecuteReader


        If Rdr.Read Then

            tNama.Text = Rdr.GetValue(1)
            tUser.Text = Rdr.GetValue(2)
            tPass.Text = Rdr.GetValue(3)
            tEmail.Text = Rdr.GetValue(4)


            tUrl.Text = Rdr.GetValue(5)



        Else
            MessageBox.Show("Data Masih Kosong !!", "Perhatian !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub

    Sub Bersih()
        PictureBox2.Enabled = False
        t1.Clear()
        t2.Clear()
        t3.Clear()
        t4.Clear()
    End Sub

    Private Sub ubah()
        Try

            Dim Query As String = "update tbl_admin set nama='" & t1.Text & "',username='" & t2.Text & "',pas='" & t3.Text & "',email='" & t4.Text & "',url='" & tUrl.Text & "' where id=1"

            Cmd = New OleDbCommand(Query, Cn)
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.Visible = True
        t1.Text = tNama.Text
        t2.Text = tUser.Text
        t3.Text = tPass.Text
        t4.Text = tEmail.Text

        PictureBox2.Enabled = True


    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click


        If t1.Text = "" Or t2.Text = "" Then
            MessageBox.Show("Data Masih Kosong !!", "Perhatian !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ubah()
            Bersih()
            Panel2.Visible = False
            setData()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        BukaFile.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp"
        BukaFile.FilterIndex = 1
        BukaFile.Title = "Pilih Gambar !"
        'BukaFile.FileName = "Cari File"
        BukaFile.ShowDialog()
        tUrl.Text = BukaFile.FileName

        PictureBox2.ImageLocation = tUrl.Text
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage



    End Sub


End Class