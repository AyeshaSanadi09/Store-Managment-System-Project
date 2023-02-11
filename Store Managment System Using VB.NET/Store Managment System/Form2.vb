Public Class Form2
    Private Sub AddNewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewProductToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub DeleteProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteProductToolStripMenuItem.Click
        Me.Hide()
        Form6.Show()

    End Sub

    Private Sub SearchProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchProductToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub BillingReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillingReportToolStripMenuItem.Click
        Me.Hide()
        Form5.show()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size

    End Sub

End Class