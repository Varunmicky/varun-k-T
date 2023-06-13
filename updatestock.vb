Imports System.Data.SqlClient

Public Class updatestock
    Dim con As New SqlConnection("Data Source=LAPTOP-BIQP815Q\SQLEXPRESS;Initial Catalog=mini sale And inventory system;Integrated Security=True")


    Private Sub updatestock_Load(sender As Object, e As EventArgs) Handles Me.Load
        items()
        datagrid()
    End Sub

    Private Sub datagrid()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("select * from stock", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim tb As New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim cmd As New SqlCommand("select available from stock where product_type = @1", con)
        cmd.Parameters.AddWithValue("@1", ComboBox1.Text)
        con.Open()
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.Read Then
            rd.Close()
            con.Close()
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            Dim cmd1 As New SqlCommand("Select * from STOCK where product_type =@1", con)
            cmd1.Parameters.AddWithValue("@1", TextBox1.Text)
            con.Open()
            Dim ad As New SqlDataAdapter(cmd1)
            Dim dt As New DataTable
            ad.Fill(dt)
            If dt.Rows.Count = 0 Then
                con.Close()
                details()
            Else
                con.Close()
                MsgBox("Product Id Exists", vbInformation)
            End If
            con.Close()
        Else
            MsgBox("Please enter Item Name", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub details()
        Dim CMD As New SqlCommand("INSERT INTO STOCK(product_type , available,rate)VALUES(@1,@2,@3)", con)
        CMD.Parameters.AddWithValue("@1", TextBox1.Text)
        CMD.Parameters.AddWithValue("@2", TextBox2.Text)
        CMD.Parameters.AddWithValue("@3", TextBox4.Text)
        con.Open()
        CMD.ExecuteNonQuery()
        MsgBox("Item Added Successfully", vbInformation, Title:="Stock")
        con.Close()
    End Sub

    Private Sub items()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox3.ResetText()
        items()
        datagrid()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox3.Text <> "" Then
            Dim cnd As New SqlCommand("Update stock set available = @1 where product_type = @2", con)
            cnd.Parameters.AddWithValue("@1", TextBox3.Text)
            cnd.Parameters.AddWithValue("@2", ComboBox1.Text)
            con.Open()
            cnd.ExecuteNonQuery()
            MsgBox("Stock Updated", vbInformation, Title:="Stock")
            con.Close()
        Else
            MsgBox("Please fill stock ", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox4.ResetText()
    End Sub

    Private Sub TextBox2_keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox4_keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

End Class