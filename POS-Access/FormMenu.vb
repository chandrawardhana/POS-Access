Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class FormMenu
    Private currentChildForm As Form

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub


    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
        OpenChildForm(New FormHome)


    End Sub



    Private Sub PanelBar_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelBody_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBody.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()

    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub btnMinimeze_Click(sender As Object, e As EventArgs) Handles btnMinimeze.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelBody.Controls.Add(childForm)
        PanelBody.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        OpenChildForm(New FormHome)
    End Sub

    Private Sub btnProdak_Click(sender As Object, e As EventArgs) Handles btnProdak.Click
        OpenChildForm(New FormProduk)
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        OpenChildForm(New FormTransaksi)
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click

    End Sub

    Private Sub btnAminstrator_Click(sender As Object, e As EventArgs) Handles btnAminstrator.Click
        OpenChildForm(New FormAdmintrator)
    End Sub

    Private Sub SlideRight_Click(sender As Object, e As EventArgs) Handles SlideRight.Click
        If PanelMenu.Width <= 60 Then
            Me.PanelMenu.Width = PanelMenu.Width + 100
        End If

        btnHome.TextImageRelation = TextImageRelation.ImageBeforeText
        btnHome.Width = 160
        btnHome.Text = "Home"

        btnProdak.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProdak.Width = 160
        btnProdak.Text = "Prodak"

        btnTransaksi.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTransaksi.Width = 160
        btnTransaksi.Text = "Transaksi"

        btnLaporan.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLaporan.Width = 160
        btnLaporan.Text = "Laporan"

        btnAminstrator.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAminstrator.Width = 160
        btnAminstrator.Text = "Administrator"


        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogout.Width = 160
        btnLogout.Text = "Logout"

    End Sub

    Private Sub SlideLeft_Click(sender As Object, e As EventArgs) Handles SlideLeft.Click
        If PanelMenu.Width > 60 Then
            Me.PanelMenu.Width = PanelMenu.Width - 100
        End If

        btnHome.TextImageRelation = TextImageRelation.ImageAboveText
        btnHome.Width = 57
        btnHome.Text = ""

        btnProdak.TextImageRelation = TextImageRelation.ImageAboveText
        btnProdak.Width = 57
        btnProdak.Text = ""

        btnTransaksi.TextImageRelation = TextImageRelation.ImageAboveText
        btnTransaksi.Width = 57
        btnTransaksi.Text = ""

        btnLaporan.TextImageRelation = TextImageRelation.ImageAboveText
        btnLaporan.Width = 57
        btnLaporan.Text = ""

        btnAminstrator.TextImageRelation = TextImageRelation.ImageAboveText
        btnAminstrator.Width = 57
        btnAminstrator.Text = ""

        btnLogout.TextImageRelation = TextImageRelation.ImageAboveText
        btnLogout.Width = 57
        btnLogout.Text = ""


    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim frm As New FormLogin
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click

    End Sub

    Sub costumColor1()
        PanelBar.BackColor = Color.FromArgb(64, 64, 64)
        PanelMenu.BackColor = Color.FromArgb(64, 64, 64)

        'Panel1.BackColor = Color.FromArgb(224, 224, 224)

    End Sub

    Sub costumColor2()
        PanelBar.BackColor = Color.FromArgb(10, 10, 10)
        PanelMenu.BackColor = Color.FromArgb(10, 10, 10)
        'Panel1.BackColor = Color.FromArgb(31, 31, 31)

        'btnHome.IconColor = Color.LightYellow
    End Sub

    Private Sub ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles ToggleSwitch1.CheckedChanged
        If ToggleSwitch1.Checked = True Then
            costumColor1()

        Else
            costumColor2()
        End If
    End Sub
End Class
