Public Class FormHome
    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tJam.Text = Format(Now, "HH:mm")
        tSec.Text = Format(Now, "ss")
    End Sub
End Class