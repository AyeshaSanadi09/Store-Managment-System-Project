<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddNewProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewProductToolStripMenuItem, Me.DeleteProductToolStripMenuItem, Me.UpdateDeleteToolStripMenuItem, Me.SearchProductToolStripMenuItem, Me.BillingReportToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1119, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddNewProductToolStripMenuItem
        '
        Me.AddNewProductToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewProductToolStripMenuItem.Name = "AddNewProductToolStripMenuItem"
        Me.AddNewProductToolStripMenuItem.Size = New System.Drawing.Size(243, 36)
        Me.AddNewProductToolStripMenuItem.Text = "Add New Product"
        '
        'DeleteProductToolStripMenuItem
        '
        Me.DeleteProductToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteProductToolStripMenuItem.Name = "DeleteProductToolStripMenuItem"
        Me.DeleteProductToolStripMenuItem.Size = New System.Drawing.Size(204, 36)
        Me.DeleteProductToolStripMenuItem.Text = "Delete Product"
        '
        'UpdateDeleteToolStripMenuItem
        '
        Me.UpdateDeleteToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateDeleteToolStripMenuItem.Name = "UpdateDeleteToolStripMenuItem"
        Me.UpdateDeleteToolStripMenuItem.Size = New System.Drawing.Size(12, 36)
        '
        'SearchProductToolStripMenuItem
        '
        Me.SearchProductToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchProductToolStripMenuItem.Name = "SearchProductToolStripMenuItem"
        Me.SearchProductToolStripMenuItem.Size = New System.Drawing.Size(209, 36)
        Me.SearchProductToolStripMenuItem.Text = "Search Product"
        '
        'BillingReportToolStripMenuItem
        '
        Me.BillingReportToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillingReportToolStripMenuItem.Name = "BillingReportToolStripMenuItem"
        Me.BillingReportToolStripMenuItem.Size = New System.Drawing.Size(193, 36)
        Me.BillingReportToolStripMenuItem.Text = "Billing Report"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 36)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MenuStrip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1119, 422)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Store_Managment_System.My.Resources.Resources._4493474_hd_wallpapers_1080p
        Me.PictureBox1.Location = New System.Drawing.Point(3, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1113, 376)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 422)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddNewProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateDeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillingReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
