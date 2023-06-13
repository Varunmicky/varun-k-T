Imports System.Data.SqlClient

Public Class purchasehistory

    Dim con As New SqlConnection("Data Source=LAPTOP-BIQP815Q\SQLEXPRESS;Initial Catalog=mini sale And inventory system;Integrated Security=True")


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        datagrid()
    End Sub
    Private Sub datagrid()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("select date,seller,product_id,product_type,quantity,rate,discount,paid,discountamt,totalamount  from neworderpurchasevb", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim tb As New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
        con.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        datagridp()
    End Sub

    Private Sub datagridp()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("select dateofreturn,seller,product_id,productreturn_type,returnquantity,rate,discount,disamount,paidamt,totalamount,receivableamt from newpurchasereturn", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim tb As New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
        con.Close()
    End Sub

End Class