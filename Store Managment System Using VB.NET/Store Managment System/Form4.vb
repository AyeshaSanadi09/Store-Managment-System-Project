Imports System.Data.OleDb

Public Class Form4
    Dim cnn As New OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim provider As String
    Dim datafile As String
    Dim connstring As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            Form12.Show()
        Else
            cnn.ConnectionString = "provider=microsoft.jet.oledb.4.0; data source=Database1.mdb"
            cnn.Open()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter("select * from Table1 where ProductName like '%" & TextBox1.Text & "%'", cnn)
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
            cnn.Close()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
       
        cnn.ConnectionString = "provider=microsoft.jet.oledb.4.0; data source=Database1.mdb"
        cnn.Open()
        Dim dt As New DataTable
        Dim ds As New DataSet
        da = New OleDbDataAdapter("select * from Table1", cnn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        cnn.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
    End Sub



    Private Sub TableLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel4.Paint

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class