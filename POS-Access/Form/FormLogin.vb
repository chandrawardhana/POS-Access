Imports System.Runtime.InteropServices
Public Class FormLogin

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tU.Text = "" Then
            MessageBox.Show("Username Masih Kosong !!", "Perhatian !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf tP.Text = "" Then
            MessageBox.Show("Password Masih Kosong !!", "Perhatian !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Dim frm As New FormMenu
            frm.Show()
            Me.Hide()

        End If



    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class