Imports System.Data.SqlClient

Public Class newsalesorder
    Dim con As New SqlConnection("Data Source=LAPTOP-BIQP815Q\SQLEXPRESS;Initial Catalog=mini sale And inventory system;Integrated Security=True")
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox2.Text <> "" And TextBox1.Text <> "" And TextBox4.Text <> "" Then
            Dim cmd As New SqlCommand("UPDATE newsalesorder SET date = @date,buyer = @buyer,product_type = @product_type ,quantity = @quantity ,rate = @rate,discount = @discount,totalamount=@totalamount where product_id = @product_id ", con)
            cmd.Parameters.AddWithValue("@date", Label12.Text)
            cmd.Parameters.AddWithValue("@buyer", TextBox1.Text)
            cmd.Parameters.AddWithValue("@product_id", TextBox2.Text)
            cmd.Parameters.AddWithValue("@rate", TextBox4.Text)
            cmd.Parameters.AddWithValue("@discount", TextBox5.Text)
            cmd.Parameters.AddWithValue("@totalamount", Label10.Text)
            cmd.Parameters.AddWithValue("@product_type", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@quantity", ComboBox2.Text)

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If cmd.ExecuteNonQuery().Equals(1) Then
                MsgBox("dATA updated SUCCESSFULLY", vbInformation, Title:="ADD")
            Else
                MsgBox("something went to wrong", MessageBoxIcon.Error, Title:="ADD")
            End If
            con.Close()
        Else
            MsgBox("Please Fill All Details", vbInformation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text <> "" Then
            Dim cmd1 As New SqlCommand("Select * from newsalesorder where product_id =@1", con)
            cmd1.Parameters.AddWithValue("@1", TextBox2.Text)
            con.Open()
            Dim ad As New SqlDataAdapter(cmd1)
            Dim dt As New DataTable
            ad.Fill(dt)
            If dt.Rows.Count = 0 Then
                con.Close()
                detailsinsert()
            Else
                con.Close()
                MsgBox("Product Id Exists", vbInformation)
            End If
            con.Close()
        Else
            MsgBox("Please enter Valid Product Id", vbInformation)
        End If
    End Sub
    Private Sub detailsinsert()
        Dim st As String = "Pending"
        If ComboBox1.Text <> "" And TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" Then
            stock()
            Dim cmd As New SqlCommand("insert into newsalesorder(date,buyer,product_id,product_type,quantity,rate,discount,discountamount,totalamount,payamount,status)values(@date,@buyer,@product_id,@product_type,@quantity,@rate,@discount,@totalamount,@payamount,@discountamount,@status)", con)
            cmd.Parameters.AddWithValue("@date", Label12.Text)
            cmd.Parameters.AddWithValue("@buyer", TextBox1.Text)
            cmd.Parameters.AddWithValue("@product_id", TextBox2.Text)
            cmd.Parameters.AddWithValue("@rate", TextBox4.Text)
            cmd.Parameters.AddWithValue("@discount", TextBox5.Text)
            cmd.Parameters.AddWithValue("@totalamount", Label13.Text)
            cmd.Parameters.AddWithValue("@product_type", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@quantity", ComboBox2.Text)
            cmd.Parameters.AddWithValue("@payamount", Label15.Text)
            cmd.Parameters.AddWithValue("@discountamount", Label17.Text)
            cmd.Parameters.AddWithValue("@status", st)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If cmd.ExecuteNonQuery().Equals(1) Then
                MsgBox("DATA INSERTED SUCCESSFULLY", vbInformation, Title:="ADD")
            Else
                MsgBox("something went to wrong", MessageBoxIcon.Error, Title:="ADD")
            End If
            con.Close()
        Else
            MsgBox("Please Fill All Details", vbInformation)
        End If
    End Sub
    Dim total1 As String
    Private Sub stock()

        total1 = Val(Label10.Text) - Val(ComboBox2.Text)
        Dim cmd As New SqlCommand("update stock set available = @1 where product_type = @2", con)
        cmd.Parameters.AddWithValue("@1", total1)
        cmd.Parameters.AddWithValue("@2", ComboBox1.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text <> "" Then
            Dim cmd As New SqlCommand("delete  from  newsalesorder where product_id = @product_id ", con)
            cmd.Parameters.AddWithValue("@product_id", TextBox2.Text)
            con.Open()
            If cmd.ExecuteNonQuery().Equals(1) Then
                MsgBox("DATA deleted SUCCESSFULLY", vbInformation, Title:="ADD")
            Else
                MsgBox("something went to wrong", MessageBoxIcon.Error, Title:="ADD")
            End If
            con.Close()
        Else
            MsgBox("Please Fill Product Id", vbInformation)
        End If
    End Sub
    Private Sub datagrid()
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        Dim cmd As New SqlCommand("select date,buyer,product_id,product_type,quantity,rate,discount,payamount,totalamount from newsalesorder", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim tb As New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
        con.Close()
    End Sub

    Private Sub newosalesorder_Load(sender As Object, e As EventArgs) Handles Me.Load
        items()
        Timer1.Start()
        datagrid()
    End Sub

    Private Sub items()
        Dim cmd As New SqlCommand("select Product_type from stock", con)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox1.DataSource = dt
        ComboBox1.DisplayMember = "Product_type"
        con.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox4.ResetText()
        TextBox5.ResetText()
        TextBox3.ResetText()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        Label10.ResetText()
        Label15.ResetText()
        Label13.ResetText()
        Label17.ResetText()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If TextBox3.Text <> "" Then
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim cmd As New SqlCommand("select * from newsalesorder where product_id = @1", con)
            cmd.Parameters.AddWithValue("@1", TextBox3.Text)
            Dim da As New SqlDataAdapter(cmd)
            Dim tb As New DataTable
            da.Fill(tb)
            DataGridView1.DataSource = tb
            con.Close()
        Else
            MsgBox("Invalid ID", vbInformation)
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Label13.Text = Val(ComboBox2.Text) * Val(TextBox4.Text)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextBox5.ResetText()
        Label17.ResetText()
        Label15.ResetText()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Label17.Text = Val(Label13.Text) * (Val(TextBox5.Text) / 100)
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label12.Text = Now.Date.ToString("d")
    End Sub

    Private Sub purchase()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("select available from stock where product_type = @1", con)
        cmd.Parameters.AddWithValue("@1", ComboBox1.Text)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.Read Then
            Label10.Text = rd("available")
            rd.Close()
        End If
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        purchase()
    End Sub

    Private Sub Label17_TextChanged(sender As Object, e As EventArgs) Handles Label17.TextChanged
        Label15.Text = Val(Label13.Text) - Val(Label17.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        datagrid()
    End Sub

    Private Sub TextBox4_keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

End Class