Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then

            ErrorProvider1.SetError(TextBox1, "something missing")
            ErrorProvider2.SetError(TextBox2, "something missing")

            ' MsgBox("something missing")
            Form7.Show()
        Else
            If TextBox1.Text = "store" And TextBox2.Text = "store" Then
                Me.Hide()
                Form2.Show()
                TextBox1.Clear()
                TextBox2.Clear()
            Else
                ErrorProvider1.SetError(TextBox1, "wrong details")
                Form8.Show()
                ' MsgBox("wrong details!!")
            End If
        End If
      
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
