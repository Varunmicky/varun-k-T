Imports System.Data.SqlClient
Public Class forgotpassword
    Dim con As New SqlConnection("Data Source=LAPTOP-BIQP815Q\SQLEXPRESS;Initial Catalog=mini sale And inventory system;Integrated Security=True ")
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.PasswordChar = ""
        Else
            TextBox1.PasswordChar = "*"
        End If
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        If Val(textbox2.Text) = Val(TextBox1.Text) And textbox2.Text <> "" And TextBox1.Text <> "" Then
            If textbox2.TextLength > 4 Then
                Dim cmd As New SqlCommand("update home set password =@1 ,confirmpassword=@3 where username=@2 ", con)
                cmd.Parameters.AddWithValue("@1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@2", Label3.Text)
                cmd.Parameters.AddWithValue("@3", textbox2.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Updated Successfully", vbInformation)
            Else
                MsgBox("Password Length Must Be Greater Than 8", vbInformation)
            End If
        Else
            MsgBox("PASSWORD MISS MATCH", vbInformation)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_keypress(sender As Object, e As KeyPressEventArgs) Handles textbox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textbox2_TextChanged(sender As Object, e As EventArgs) Handles textbox2.TextChanged

    End Sub
End Class