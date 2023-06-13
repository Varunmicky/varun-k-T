Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class home
    Dim con As New SqlConnection("Data Source=LAPTOP-BIQP815Q\SQLEXPRESS;Initial Catalog=mini sale And inventory system;Integrated Security=True ")
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        If TextBox1.Text = "" Then
            MsgBox("Enter USER NAME.", MessageBoxIcon.Error)
            Return
        ElseIf TextBox2.Text = "" Then
            MsgBox("Enter PASSWORD.", MessageBoxIcon.Error)
            Return
        End If


        con.Open()
        Dim cmd1 As New SqlCommand(" select username from home where username=@1", con)
        cmd1.Parameters.AddWithValue("@1", TextBox1.Text)
        Dim ad1 As New SqlDataAdapter(cmd1)
        Dim dt1 As New DataTable
        ad1.Fill(dt1)
        If dt1.Rows.Count = 0 Then
            MsgBox("Incorrect Username", vbInformation)
            con.Close()
        Else
            con.Close()
            Dim cmd As New SqlCommand("select username,password from home where username= @1 and password=@2 ", con)
            cmd.Parameters.AddWithValue("@1", TextBox1.Text)
            cmd.Parameters.AddWithValue("@2", TextBox2.Text)
            Dim ad As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            ad.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("INCORRECT PASSWORD", vbInformation)
                con.Close()
            Else
                con.Close()
                dashboard.Show()
            End If
            con.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If TextBox1.Text <> "" Then
            Dim cmd As New SqlCommand(" select username from home where username=@1", con)
            cmd.Parameters.AddWithValue("@1", TextBox1.Text)
            Dim ad As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            ad.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("No Username Found", vbInformation)
            Else
                forgotpassword.Show()
                Me.Hide()
                forgotpassword.Label3.Text = TextBox1.Text
            End If
        Else
            MsgBox("ENTER VALID USERNAME", MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TextBox1_keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        reg.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
