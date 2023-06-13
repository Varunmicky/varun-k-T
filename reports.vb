Public Class reports
    Private Sub switch(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        switch(salesreport)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        switch(purchasereport)
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        home.Show()
        Me.Hide()
    End Sub
End Class