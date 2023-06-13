
Imports System.Data.SqlClient

Public Class dashboard
    Dim con As New SqlConnection("Data Source=LAPTOP-BIQP815Q\SQLEXPRESS;Initial Catalog=mini sale And inventory system;Integrated Security=True")

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        cp()
        cst()
        cs()
    End Sub

    Private Sub cp()
        Dim cmd As New SqlCommand("select count(product_id) from neworderpurchasevb", con)
        con.Open()
        Dim count1 = Convert.ToString(cmd.ExecuteScalar)
        Label3.Text = count1
        con.Close()
    End Sub

    Private Sub cst()
        Dim cmd As New SqlCommand("select sum(available) as st from stock", con)
        con.Open()
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.Read Then
            Label8.Text = rd("st")
            con.Close()
        End If
        con.Close()
    End Sub

    Private Sub cs()
        Dim cmd As New SqlCommand("select count(product_id) from newsalesorder", con)
        con.Open()
        Dim count1 = Convert.ToString(cmd.ExecuteScalar)
        Label6.Text = count1
        con.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        purchase.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        sales.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        stock.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        payments.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        reports.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class