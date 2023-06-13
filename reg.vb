Imports System.Data.SqlClient

Public Class reg
    Dim con As New SqlConnection("Data Source=LAPTOP-BIQP815Q\SQLEXPRESS;Initial Catalog=mini sale And inventory system;Integrated Security=True ")

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        If txtcpass.Text <> "" And txtname.Text <> "" And txtpass.Text <> "" Then
            prim()
        Else
            MsgBox("Please Fill All Details", MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub prim()
        Dim cmd As New SqlCommand("select * From home where username =@1 ", con)
        cmd.Parameters.AddWithValue("@1", txtname.Text)
        con.Open()
        Dim ad As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        ad.Fill(dt)
        If dt.Rows.Count = 0 Then
            con.Close()
            create()
        Else
            con.Close()
            MsgBox("User Already Exists", vbInformation)
        End If
        con.Close()
    End Sub
    Private Sub create()
        con.Open()
        Dim cmd As New SqlCommand("insert into  home ( username,Password,confirmpassword)values(@username,@password,@confirmpassword)", con)
        cmd.Parameters.AddWithValue("@username", txtname.Text)
        cmd.Parameters.AddWithValue("@password", txtpass.Text)
        cmd.Parameters.AddWithValue("@confirmpassword", txtcpass.Text)
        cmd.ExecuteNonQuery()
        MsgBox("SUCESSFULLY REGISTER", vbInformation)
        home.Show()
        Me.Hide()
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_keypress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_keypress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox3_keypress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtname_keypress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub


    Private Sub Txtpass_keypress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Txtxpass_keypress(sender As Object, e As KeyPressEventArgs) Handles txtcpass.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class