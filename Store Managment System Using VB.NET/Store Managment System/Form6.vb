Imports System.Data.OleDb


Public Class Form6
    Dim cnn As New OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim provider As String
    ' Dim datafile As String
    Dim connstring As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cnn.ConnectionString = "provider=microsoft.jet.oledb.4.0; data source=Database1.mdb"
        cnn.Open()
        Dim dt As New DataTable
        Dim ds As New DataSet
        da = New OleDbDataAdapter("select * from Table1", cnn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        cnn.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text = "" Then
            Form14.Show()
        Else
            Dim dt As New DataTable
            provider = "Provider=Microsoft.jet.oledb.4.0; data source=Database1.mdb"
            ' datafile = "E:\Ki & Ka (2016) 1CD DvDrip XviD MP3 MSubs -DDR\Store Managment System\Store Managment System\bin\Debug\Database1.mdb"
            connstring = provider
            cnn.ConnectionString = connstring
            cnn.Open()
            Dim str As String


            str = "Delete from [Table1] where [BatchNo]=" & TextBox1.Text & ""
            Dim cmd As OleDbCommand = New OleDbCommand(str, cnn)
            Try
                If cmd.ExecuteNonQuery() Then
                    cmd.Dispose()
                    da = New OleDbDataAdapter("select * from Table1", cnn)
                    da.Fill(dt)
                    DataGridView1.DataSource = dt.DefaultView
                    Form10.Show()
                    ' MsgBox("The Record is successfully deleted")
                    cnn.Close()
                Else
                    cmd.Dispose()
                    MsgBox("The Record is not found")
                    cnn.Close()
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
    End Sub

    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel5.Paint

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub
End Class