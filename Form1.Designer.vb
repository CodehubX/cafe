<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LiqueurCheckBox = New System.Windows.Forms.CheckBox()
        Me.WhippedCreamCheckBox = New System.Windows.Forms.CheckBox()
        Me.SyrupCheckBox = New System.Windows.Forms.CheckBox()
        Me.DblCheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DeliveryCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PwdTextbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowTotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocationListBox = New System.Windows.Forms.ListBox()
        Me.FormColorDialog = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LiqueurCheckBox)
        Me.GroupBox2.Controls.Add(Me.WhippedCreamCheckBox)
        Me.GroupBox2.Controls.Add(Me.SyrupCheckBox)
        Me.GroupBox2.Controls.Add(Me.DblCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(182, 319)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(131, 130)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose Your Add-Ins"
        '
        'LiqueurCheckBox
        '
        Me.LiqueurCheckBox.AutoSize = True
        Me.LiqueurCheckBox.Location = New System.Drawing.Point(7, 92)
        Me.LiqueurCheckBox.Name = "LiqueurCheckBox"
        Me.LiqueurCheckBox.Size = New System.Drawing.Size(61, 17)
        Me.LiqueurCheckBox.TabIndex = 3
        Me.LiqueurCheckBox.Text = "Liqueur"
        Me.LiqueurCheckBox.UseVisualStyleBackColor = True
        '
        'WhippedCreamCheckBox
        '
        Me.WhippedCreamCheckBox.AutoSize = True
        Me.WhippedCreamCheckBox.Location = New System.Drawing.Point(7, 68)
        Me.WhippedCreamCheckBox.Name = "WhippedCreamCheckBox"
        Me.WhippedCreamCheckBox.Size = New System.Drawing.Size(102, 17)
        Me.WhippedCreamCheckBox.TabIndex = 2
        Me.WhippedCreamCheckBox.Text = "Whipped Cream"
        Me.WhippedCreamCheckBox.UseVisualStyleBackColor = True
        '
        'SyrupCheckBox
        '
        Me.SyrupCheckBox.AutoSize = True
        Me.SyrupCheckBox.Location = New System.Drawing.Point(7, 44)
        Me.SyrupCheckBox.Name = "SyrupCheckBox"
        Me.SyrupCheckBox.Size = New System.Drawing.Size(97, 17)
        Me.SyrupCheckBox.TabIndex = 1
        Me.SyrupCheckBox.Text = "Flavored Syrup"
        Me.SyrupCheckBox.UseVisualStyleBackColor = True
        '
        'DblCheckBox
        '
        Me.DblCheckBox.AutoSize = True
        Me.DblCheckBox.Location = New System.Drawing.Point(7, 20)
        Me.DblCheckBox.Name = "DblCheckBox"
        Me.DblCheckBox.Size = New System.Drawing.Size(85, 17)
        Me.DblCheckBox.TabIndex = 0
        Me.DblCheckBox.Text = "Double Shot"
        Me.DblCheckBox.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.JavaJeans.My.Resources.Resources.CoffeeShop
        Me.PictureBox1.Location = New System.Drawing.Point(423, 178)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'DeliveryCheckBox
        '
        Me.DeliveryCheckBox.AutoSize = True
        Me.DeliveryCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryCheckBox.Location = New System.Drawing.Point(350, 314)
        Me.DeliveryCheckBox.Name = "DeliveryCheckBox"
        Me.DeliveryCheckBox.Size = New System.Drawing.Size(90, 20)
        Me.DeliveryCheckBox.TabIndex = 7
        Me.DeliveryCheckBox.Text = "For Delivery"
        Me.DeliveryCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'NameTextbox
        '
        Me.NameTextbox.Location = New System.Drawing.Point(63, 199)
        Me.NameTextbox.Name = "NameTextbox"
        Me.NameTextbox.Size = New System.Drawing.Size(125, 20)
        Me.NameTextbox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'PwdTextbox
        '
        Me.PwdTextbox.Location = New System.Drawing.Point(283, 203)
        Me.PwdTextbox.Name = "PwdTextbox"
        Me.PwdTextbox.Size = New System.Drawing.Size(100, 20)
        Me.PwdTextbox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Your Order Total:"
        '
        'TotalLabel
        '
        Me.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(350, 372)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(231, 78)
        Me.TotalLabel.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(423, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Java Jean's"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(350, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(211, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Brought to your office for only $1.00!!!"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(98, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(290, 22)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Serving GROB employees since 1978"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.CalcToolStripMenuItem, Me.ShowTotalToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'CalcToolStripMenuItem
        '
        Me.CalcToolStripMenuItem.Enabled = False
        Me.CalcToolStripMenuItem.Name = "CalcToolStripMenuItem"
        Me.CalcToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CalcToolStripMenuItem.Text = "Calculate"
        '
        'ShowTotalToolStripMenuItem
        '
        Me.ShowTotalToolStripMenuItem.Enabled = False
        Me.ShowTotalToolStripMenuItem.Name = "ShowTotalToolStripMenuItem"
        Me.ShowTotalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ShowTotalToolStripMenuItem.Text = "Show Total"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Enabled = False
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FontToolStripMenuItem.Text = "Font.."
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ColorToolStripMenuItem.Text = "Color.."
        '
        'LocationListBox
        '
        Me.LocationListBox.FormattingEnabled = True
        Me.LocationListBox.Location = New System.Drawing.Point(21, 333)
        Me.LocationListBox.Name = "LocationListBox"
        Me.LocationListBox.Size = New System.Drawing.Size(120, 95)
        Me.LocationListBox.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(600, 525)
        Me.Controls.Add(Me.LocationListBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PwdTextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DeliveryCheckBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Java Jeans Coffee"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LiqueurCheckBox As CheckBox
    Friend WithEvents WhippedCreamCheckBox As CheckBox
    Friend WithEvents SyrupCheckBox As CheckBox
    Friend WithEvents DblCheckBox As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DeliveryCheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PwdTextbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowTotalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocationListBox As ListBox
    Friend WithEvents FormColorDialog As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
End Class
