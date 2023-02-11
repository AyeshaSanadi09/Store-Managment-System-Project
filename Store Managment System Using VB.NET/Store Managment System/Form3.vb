Imports System.Data.OleDb
Public Class Form3
    Dim cnn As New ADODB.Connection
    Dim res As New ADODB.Recordset
    Dim sql As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            Form12.Show()
        Else
            sql = "insert into Table1 values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Value & "','" & TextBox4.Text & "')"
            cnn.Execute(sql)
            Form9.Show()
        End If

        ' MsgBox("The New Product is Added Successfully")
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        DateTimePicker1.Enabled = False

        cnn.ConnectionString = "provider=microsoft.jet.oledb.4.0; data source=Database1.mdb"
        cnn.Open()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Enabled = True

        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub
End Class