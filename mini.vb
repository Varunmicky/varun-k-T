Public Class mini

    Private Sub Timer1_mini_Tick(sender As Object, e As EventArgs) Handles Timer1_mini.Tick

        ProgressBar1.Increment(1)
        Label6.Text = ProgressBar1.Value
        If (ProgressBar1.Value = 100) Then
            Timer1_mini.Stop()
            home.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub loading_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1_mini.Enabled = True
        Timer1_mini.Start()

    End Sub
End Class