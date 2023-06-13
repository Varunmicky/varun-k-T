Imports System.Data.SqlClient


Public Class sphistory
    Dim con As New SqlConnection("Data Source=LAPTOP-BIQP815Q\SQLEXPRESS;Initial Catalog=mini sale And inventory system;Integrated Security=True")


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim cmd As New SqlCommand("select * from newsalesorder", con)
        con.Open()
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim cmd As New SqlCommand("select * from salesreturn", con)
        con.Open()
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.Text = Now.Date.ToString("d")
    End Sub

End Class