Imports System.Data.SqlClient


Public Class saleshistory
    Dim con As New SqlConnection("Data Source=LAPTOP-BIQP815Q\SQLEXPRESS;Initial Catalog=mini sale And inventory system;Integrated Security=True")

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        datagrid()
    End Sub

    Private Sub datagrid()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("select date,buyer,product_id,product_type,quantity,rate,discount,discountamount,totalamount,payamount from newsalesorder", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim tb As New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
        con.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        datagrids()
    End Sub

    Private Sub datagrids()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("select dateofreturn,buyer,productreturn_type,product_id,returnquantity,rate,discount,paidamt,discountamt,totalamount,payableamt from salesreturn", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim tb As New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
        con.Close()
    End Sub

End Class