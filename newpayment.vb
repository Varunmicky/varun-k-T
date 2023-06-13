Imports System.Data.SqlClient

Public Class newpayment

    Dim con As New SqlConnection("Data Source=LAPTOP-BIQP815Q\SQLEXPRESS;Initial Catalog=mini sale and inventory system;Integrated Security=True")
    Private Sub ComboBox1_SelectedIndexChanged_2(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox2.SelectedItem = "Purchase" Then
            itemsp()
        ElseIf ComboBox2.SelectedItem = "Purchase Return" Then
            itemspr()
        ElseIf ComboBox2.SelectedItem = "Sales" Then
            itemss()
        ElseIf ComboBox2.SelectedItem = "Sales Return" Then
            itemssr()
        End If
    End Sub

    Private Sub itemsp()
        Dim cmd As New SqlCommand("select product_id from neworderpurchasevb", con)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox4.DataSource = dt
        ComboBox4.DisplayMember = "product_id"
        con.Close()
    End Sub

    Private Sub itemspr()
        Dim cmd As New SqlCommand("select product_id from newpurchasereturn", con)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox4.DataSource = dt
        ComboBox4.DisplayMember = "product_id"
        con.Close()
    End Sub

    Private Sub itemss()
        Dim cmd As New SqlCommand("select product_id from newsalesorder", con)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox4.DataSource = dt
        ComboBox4.DisplayMember = "product_id"
        con.Close()
    End Sub

    Private Sub itemssr()
        Dim cmd As New SqlCommand("select product_id from salesreturn", con)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox4.DataSource = dt
        ComboBox4.DisplayMember = "product_id"
        con.Close()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox2.SelectedItem = "Purchase" Then
            Try
                Dim cmd As New SqlCommand("select seller,date ,quantity ,rate ,totalamount ,status from neworderpurchasevb where product_type = @1 and product_id = @2", con)
                cmd.Parameters.AddWithValue("@1", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@2", ComboBox4.Text)
                Dim rd As SqlDataReader
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                rd = cmd.ExecuteReader
                If rd.Read Then
                    Label19.Text = rd("seller")
                    Label15.Text = rd("date")
                    Label12.Text = rd("quantity")
                    Label11.Text = rd("rate")
                    Label13.Text = rd("totalamount")
                    Label10.Text = rd("status")
                    con.Close()
                Else
                    Label15.Text = ""
                    Label12.Text = ""
                    Label11.Text = ""
                    Label10.Text = ""
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox("No Entries")
            End Try
            con.Close()
        End If
        If ComboBox2.SelectedItem = "Sales" Then

            Dim cmd As New SqlCommand("select buyer,date,quantity ,rate ,totalamount,status from newsalesorder where product_type = @1 and product_id = @2", con)
            cmd.Parameters.AddWithValue("@1", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@2", ComboBox4.Text)
            Dim rd As SqlDataReader
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            rd = cmd.ExecuteReader
            If rd.Read Then
                Label19.Text = rd("buyer")
                Label15.Text = rd("date")
                Label12.Text = rd("quantity")
                Label11.Text = rd("rate")
                Label13.Text = rd("totalamount")
                Label10.Text = rd("status")
                con.Close()

            Else
                Label15.Text = ""
                Label12.Text = ""
                Label11.Text = ""
                Label10.Text = ""
                Label13.ResetText()
                con.Close()
            End If

            con.Close()
        End If
        If ComboBox2.SelectedItem = "Purchase Return" Then
            Dim cmd As New SqlCommand("select seller ,dateofreturn ,rate ,totalamount,status from newpurchasereturn where productreturn_type = @1 and product_id = @2 ", con)
            cmd.Parameters.AddWithValue("@1", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@2", ComboBox4.Text)
            Dim rd As SqlDataReader
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            rd = cmd.ExecuteReader
            If rd.Read Then
                Label15.Text = rd("dateofreturn")
                Label11.Text = rd("rate")
                Label13.Text = rd("totalamount")
                Label10.Text = rd("status")
                Label19.Text = rd("seller")
                con.Close()

            Else
                Label15.Text = ""
                Label12.Text = ""
                Label11.Text = ""
                Label10.Text = ""
                con.Close()
            End If
            con.Close()
        End If
        If ComboBox2.SelectedItem = "Sales Return" Then
            Dim cmd As New SqlCommand("select buyer,dateofreturn,returnquantity ,rate ,totalamount,status from salesreturn where productreturn_type = @1 and product_id =@2", con)
            cmd.Parameters.AddWithValue("@1", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@2", ComboBox4.Text)
            Dim rd As SqlDataReader
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            rd = cmd.ExecuteReader
            If rd.Read Then
                Label15.Text = rd("dateofreturn")
                Label12.Text = rd("returnquantity")
                Label11.Text = rd("rate")
                Label13.Text = rd("totalamount")
                Label10.Text = rd("status")
                Label19.Text = rd("buyer")
                con.Close()
            Else
                Label15.Text = ""
                Label12.Text = ""
                Label11.Text = ""
                Label10.Text = ""
                con.Close()
            End If
            con.Close()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim cmd As New SqlCommand("select product_type from stock", con)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox1.DataSource = dt
        ComboBox1.DisplayMember = "product_type"
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox3.Text <> Nothing Then
            If ComboBox2.SelectedItem = "Purchase" Then
                purchase()
            ElseIf ComboBox2.SelectedItem = "Purchase Return" Then
                purchaser()
            ElseIf ComboBox2.SelectedItem = "Sales" Then
                salesd()
            ElseIf ComboBox2.SelectedItem = "Sales Return" Then
                salesdr()
            End If
        Else
            MsgBox("Please select Staus Of Payment", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub purchase()
        Dim cmd As New SqlCommand("update neworderpurchasevb set status = @2  where product_id = @1", con)
        cmd.Parameters.AddWithValue("@1", ComboBox4.Text)
        cmd.Parameters.AddWithValue("@2", ComboBox3.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Payment Updated", vbInformation, Title:="Purchase")
        clear()
        con.Close()
    End Sub

    Private Sub purchaser()
        Dim cmd As New SqlCommand("update newpurchasereturn set status = @2  where product_id = @1", con)
        cmd.Parameters.AddWithValue("@1", ComboBox4.Text)
        cmd.Parameters.AddWithValue("@2", ComboBox3.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Payment Updated", vbInformation, Title:="Purchase Return")
        clear()
        con.Close()
    End Sub

    Private Sub salesd()
        Dim cmd As New SqlCommand("update newsalesorder set status = @2  where product_id = @1", con)
        cmd.Parameters.AddWithValue("@1", ComboBox4.Text)
        cmd.Parameters.AddWithValue("@2", ComboBox3.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Payment Updated", vbInformation, Title:="Sales")
        clear()
        con.Close()
    End Sub
    Private Sub salesdr()
        Dim cmd As New SqlCommand("update salesreturn set status = @2  where product_id = @1", con)
        cmd.Parameters.AddWithValue("@1", ComboBox4.Text)
        cmd.Parameters.AddWithValue("@2", ComboBox3.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Payment Updated", vbInformation, Title:="Sales Return")
        clear()
        con.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clear()
    End Sub

    Private Sub clear()
        ComboBox1.ResetText()
        ComboBox4.ResetText()
        ComboBox2.ResetText()
        ComboBox3.ResetText()
        Label19.ResetText()
        Label15.ResetText()
        Label13.ResetText()
        Label12.ResetText()
        Label11.ResetText()
        Label10.ResetText()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label15.Text = Now.Date.ToString("d")
    End Sub

End Class