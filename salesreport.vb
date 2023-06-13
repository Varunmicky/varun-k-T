Imports System.Data.SqlClient

Public Class salesreport
    Dim con As New SqlConnection("Data Source=LAPTOP-BIQP815Q\SQLEXPRESS;Initial Catalog=mini sale And inventory system;Integrated Security=True")
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        DateTimePicker2.MaxDate = Now.Date.ToString("d")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.MaxDate = Now.Date.ToString("d")
    End Sub

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If RadioButton1.Checked = True Then
            Dim cmd As New SqlCommand("select * from newsalesorder where date between @1 and @2", con)
            cmd.Parameters.AddWithValue("@1", DateTimePicker1.Value.ToString("d"))
            cmd.Parameters.AddWithValue("@2", DateTimePicker2.Value.ToString("d"))
            con.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            con.Close()
        ElseIf RadioButton2.Checked = True Then
            Dim cmd As New SqlCommand("select * from salesreturn where dateofreturn between @1 and  @2", con)
            cmd.Parameters.AddWithValue("@1", DateTimePicker1.Value.ToString("d"))
            cmd.Parameters.AddWithValue("@2", DateTimePicker2.Value.ToString("d"))
            con.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            con.Close()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Dim cmd As New SqlCommand("select * from newsalesorder", con)
            con.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            con.Close()
        ElseIf RadioButton2.Checked = True Then
            Dim cmd As New SqlCommand("select * from salesreturn", con)
            con.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            con.Close()
        End If
        DateTimePicker1.Value = Now.Date.ToString("d")
        DateTimePicker2.Value = Now.Date.ToString("d")
    End Sub
End Class