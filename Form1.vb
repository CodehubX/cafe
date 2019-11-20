'Name:      Shazam Zafar
'Class:     Visual Basic
'Project:   Java Jeans Coffee Shop Menu, Dialogboxes and List box 
'Date:      November 7, 2018
Option Strict On

Public Class Form1
    'Class Level Variables
    Const Small_Cup As Decimal = 1D
    Const Medium_Cup As Decimal = 2.5D
    Const Large_Cup As Decimal = 3D
    Const Extra_Large_Cup As Decimal = 3.5D

    'Add in Prices
    Const Double_Shot As Decimal = 1.5D
    Const Syrup As Decimal = 0.75D
    Const Wipped_Cream As Decimal = 0.5D
    Const Liqueur As Decimal = 2D
    Const Delivery As Decimal = 1D

    Private Total As Decimal



    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        'Local Variabke
        Dim CustomerName As String = NameTextbox.Text
        Dim CustomerPassword As String = PwdTextbox.Text
        ' if correct username and password execute this 
        If CustomerName.ToUpper.Trim = "JAVAJEANS" AndAlso CustomerPassword = "CoffeeBeans" Then
            NameTextbox.Enabled = False
            PwdTextbox.Enabled = False
            LoginToolStripMenuItem.Enabled = False

            CalcToolStripMenuItem.Enabled = True
            ClearToolStripMenuItem.Enabled = True
            ShowTotalToolStripMenuItem.Enabled = True
            'let the user know he is putting wrong username or password
        Else
            MessageBox.Show("Sorry you are not vaildated.")

        End If
    End Sub

    Private Sub CalcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcToolStripMenuItem.Click
        'local variable
        Dim Price As Decimal
        Dim AddIn As Decimal
        Dim DeliveryCost As Decimal

        'If LocationListBox.SelectedIndex = 0 Then
        '    Price = Small_Cup
        'ElseIf LocationListBox.SelectedIndex = 1 Then
        '    Price = Medium_Cup
        'ElseIf LocationListBox.SelectedIndex = 2 Then
        '    Price = Large_Cup
        'ElseIf LocationListBox.SelectedIndex = 3 Then
        '    Price = Extra_Large_Cup


        'determine the price of each cup (List Boxes)

        'asking user to select a cup
        If LocationListBox.SelectedIndex >= 0 Then


            If LocationListBox.SelectedIndex = 0 Then
                Price = Small_Cup
            ElseIf LocationListBox.SelectedIndex = 1 Then
                Price = Medium_Cup
            ElseIf LocationListBox.SelectedIndex = 2 Then
                Price = Large_Cup
            ElseIf LocationListBox.SelectedIndex = 3 Then
                Price = Extra_Large_Cup

            End If
            'adding the extra (Add Ins)
            If DblCheckBox.Checked = True Then
                AddIn += Double_Shot
            End If
            If SyrupCheckBox.Checked = True Then
                AddIn += Syrup
            End If
            If WhippedCreamCheckBox.Checked = True Then
                AddIn += Wipped_Cream
            End If
            If LiqueurCheckBox.Checked = True Then
                AddIn += Liqueur
            End If
            If DeliveryCheckBox.Checked = True Then
                DeliveryCost += Delivery
            End If
            'calculation
            Total = Price + AddIn + DeliveryCost
            'Displaying 
            TotalLabel.Text = "Your Order Came To : " & Total.ToString("C") & ControlChars.CrLf & "Your addins added: " & AddIn.ToString("C") & ControlChars.CrLf & "Stop in again soon!!"
        Else
            MessageBox.Show("Select one cup")
        End If


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'close the application
        Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'clearing the label
        TotalLabel.Text = ""

        'Deselect all check boxes
        DblCheckBox.Checked = False
        SyrupCheckBox.Checked = False
        WhippedCreamCheckBox.Checked = False
        LiqueurCheckBox.Checked = False
        DeliveryCheckBox.Checked = False

        'Radio Buttons
        LocationListBox.SelectedIndex = 0


        'ask if they wish to clear totals too
        Dim answer As DialogResult
        answer = MessageBox.Show("Clear totals too?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            Total = 0


        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Adding Menu to the list
        LocationListBox.Items.Add("Small")
        LocationListBox.Items.Add("Medium")
        LocationListBox.Items.Add("Large")
        LocationListBox.Items.Add("Extra Large")

    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        'allow user to change the backcolor
        FormColorDialog.ShowDialog()
        'apply their changes to the window
        Me.BackColor = FormColorDialog.Color
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        'apply the changes to the window
        Me.Font = FontDialog1.Font
    End Sub
End Class
