Imports System.Data.OleDb
Imports System.IO
Public Class Form5
    Dim quantity As Integer
    Dim price As Integer
    Dim grandtotal As Integer = 0
    Dim totalprice As Integer
    Dim c As Integer = 0
    Dim cnn As New OleDbConnection
    Dim res As New ADODB.Recordset
    Dim sql As String
    Dim cmd As OleDb.OleDbCommand



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("select * from Table1 where ProductName like '%" & ComboBox1.SelectedItem & "%'", cnn)
        da.Fill(dt)
        TextBox1.Text = dt.Rows(0).Item(4)
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        
        cnn.ConnectionString = "provider=microsoft.jet.oledb.4.0; data source=Database1.mdb"
        Dim cmd As New OleDbCommand
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandText = "select ProductName from Table1"

        Dim dr As OleDbDataReader = cmd.ExecuteReader

        While dr.Read
            ComboBox1.Items.Add(dr.Item(0))
        End While
        dr.Close()
        cnn.Close()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        quantity = Val(TextBox2.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'price = TextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c = c + 1
        ListBox1.Items.Add(ComboBox1.SelectedItem)

        totalprice = quantity * Val(TextBox1.Text)
        ListBox2.Items.Add(totalprice)

        grandtotal = grandtotal + totalprice
        Label9.Text = grandtotal
        Label8.Text = c
        ListBox1.Text = ComboBox1.SelectedItem
        Dim x As Integer
        x = Val(TextBox1.Text) * Val(TextBox2.Text)
        'ListBox2.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        ListBox2.ClearSelected()

        ' ListBox2.Items.Add(x)
        ' ListBox2.GetItemText = Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        auto()
    End Sub
    Public Sub auto()
        Dim num As Integer
        Dim cnn As New OleDbConnection
        Dim cmd As OleDb.OleDbCommand

        cnn.ConnectionString = "provider=microsoft.jet.oledb.4.0; data source=Database1.mdb"
        cnn.Open()
        cmd = New OleDbCommand("select max(BillNo) from Table2", cnn)
        cmd.ExecuteNonQuery()

        If IsDBNull(cmd.ExecuteScalar) Then
            num = 1
            TextBox3.Text = num
        Else
            num = cmd.ExecuteScalar + 1
            TextBox3.Text = num

        End If
        cnn.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cnn.ConnectionString = "provider=microsoft.jet.oledb.4.0; data source=Database1.mdb"
        cnn.Open()
        If TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            Form12.Show()
        Else
            cmd = New OleDbCommand("insert into Table2 values('" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + DateTimePicker1.Value + "','" + ListBox1.Text + "','" + Label9.Text + "')", cnn)
        cmd.ExecuteNonQuery()
        'MsgBox("The New Product is Added Successfully")
            Form13.Show()
        End If

        cnn.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

    End Sub

End Class