Imports System.Data.SqlClient

Public Class salesreturn
    Dim con As New SqlConnection("Data Source=LAPTOP-BIQP815Q\SQLEXPRESS;Initial Catalog=mini sale And inventory system;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text <> "" And TextBox1.Text <> "" Then
            stock()
            Dim cmd As New SqlCommand("insert into salesreturn(dateofreturn,buyer,product_id,productreturn_type,returnquantity,rate,discountamt,totalamount,paidamt,discount,payableamt,status)values(@dateofreturn,@buyer,@product_id,@productreturn_type,@returnquantity,@rate,@discount,@totalamount,@paidamt,@discountamt,@payableamt,'Not Paid')", con)
            cmd.Parameters.AddWithValue("@dateofreturn", Label12.Text)
            cmd.Parameters.AddWithValue("@buyer", TextBox1.Text)
            cmd.Parameters.AddWithValue("@product_id", TextBox2.Text)
            cmd.Parameters.AddWithValue("@rate", Label19.Text)
            cmd.Parameters.AddWithValue("@discount", Label18.Text)
            cmd.Parameters.AddWithValue("@totalamount", Label13.Text)
            cmd.Parameters.AddWithValue("@productreturn_type", Label20.Text)
            cmd.Parameters.AddWithValue("@returnquantity", ComboBox2.Text)
            cmd.Parameters.AddWithValue("@paidamt", Label15.Text)
            cmd.Parameters.AddWithValue("@discountamt", Label17.Text)
            cmd.Parameters.AddWithValue("@payableamt", Label15.Text)
            con.Open()
            If cmd.ExecuteNonQuery().Equals(1) Then
                MsgBox("DATA INSERTED SUCCESSFULLY", vbInformation, Title:="ADD")
                con.Close()
            Else
                con.Close()
                MsgBox("something went to wrong", MessageBoxIcon.Error, Title:="ADD")
            End If
            con.Close()
        Else
            MsgBox("Please Fill All Details", MessageBoxIcon.Error)
        End If
    End Sub

    Dim quantity As String

    Private Sub stock()
        quantity = Val(Label10.Text) - Val(ComboBox2.Text)
        Dim cmd As New SqlCommand("update stock set available = @1 where product_type = @2", con)
        cmd.Parameters.AddWithValue("@1", quantity)
        cmd.Parameters.AddWithValue("@2", Label20.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd As New SqlCommand("delete  from  salesreturn where product_id = @product_id ", con)
        cmd.Parameters.AddWithValue("@product_id", TextBox3.Text)
        con.Open()
        If cmd.ExecuteNonQuery().Equals(1) Then
            MsgBox("dATA deleted SUCCESSFULLY", vbInformation, Title:="ADD")
            con.Close()
        Else
            con.Close()
            MsgBox("something went to wrong", MessageBoxIcon.Error, Title:="ADD")
        End If
        con.Close()
    End Sub

    Private Sub datagrid()
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Dim cmd As New SqlCommand("select dateofreturn,buyer,product_id,productreturn_type,returnquantity,rate,discount,totalamount,payableamt from salesreturn", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim tb As New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
        con.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox3.ResetText()
        Label20.ResetText()
        Label12.ResetText()
        Label19.ResetText()
        Label13.ResetText()
        Label22.ResetText()
        Label13.ResetText()
        Label15.ResetText()
        ComboBox2.ResetText()
        Label10.ResetText()
        Label17.ResetText()
        Label18.ResetText()
    End Sub

    Private Sub salesreturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagrid()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        datagrid()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If TextBox3.Text <> "" Then
            loads()
            selectt()
            availa()
        End If
    End Sub

    Private Sub loads()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("select * from salesreturn where product_id = @1", con)
        cmd.Parameters.AddWithValue("@1", TextBox3.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim tb As New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
        con.Close()
    End Sub
    Private Sub selectt()
        con.Open()
        Dim cmd As New SqlCommand("select buyer,product_type,rate,discount,date,product_id,totalamount from newsalesorder where product_id = @1", con)
        cmd.Parameters.AddWithValue("@1", TextBox3.Text)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.Read Then
            TextBox1.Text = rd("buyer")
            Label20.Text = rd("product_type")
            Label12.Text = rd("date")
            Label19.Text = rd("rate")
            Label18.Text = rd("discount")
            Label22.Text = rd("totalamount")
            TextBox2.Text = rd("product_id")
            rd.Close()
            con.Close()
        End If
        con.Close()
    End Sub

    Private Sub availa()
        Dim cmd As New SqlCommand("select available from stock where product_type = @1", con)
        cmd.Parameters.AddWithValue("@1", Label20.Text)
        con.Open()
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.Read() Then
            Label10.Text = rd("available")
            rd.Close()
            con.Close()
        End If
        con.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Label13.Text = Val(Label19.Text) * Val(ComboBox2.Text)
        Label17.Text = Val(Label13.Text) * (Val(Label18.Text) / 100)
        Label15.Text = Val(Label13.Text) - Val(Label17.Text)
        If Val(ComboBox2.SelectedItem) > Val(Label10.Text) Then
            ComboBox2.Text = Label10.Text
        End If
    End Sub

End Class