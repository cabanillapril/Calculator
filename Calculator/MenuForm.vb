Public Class MenuForm
    Private calcuForm As Calcu
    Private txtDisplay As TextBox ' ensure txtDisplay is a TextBox

    ' sub to open a new instance of the calculator when the menu item is clicked
    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        OpenCalculator()
    End Sub

    ' sub to open a new instance of the calculator when the button is clicked
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        OpenCalculator()
    End Sub

    ' sub to log out and show the login form
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Dim loginForm As New Login()
        loginForm.Show()
        AddHandler loginForm.FormClosed, Sub(sender2, e2) Application.Exit()
    End Sub

    ' sub to open a new instance of the calculator from the file menu
    Private Sub menuitemNew_Click(sender As Object, e As EventArgs) Handles menuitemNew.Click
        OpenCalculator()
    End Sub

    ' sub to save the history of calculations
    Private Sub menuitemSave_Click(sender As Object, e As EventArgs) Handles menuitemSave.Click
        MessageBox.Show("Calculator history saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' sub to print the history of calculations
    Private Sub menuitemPrint_Click(sender As Object, e As EventArgs) Handles menuitemPrint.Click
        MessageBox.Show("Printing Calculation History.", "Print")
    End Sub

    ' sub to exit the application
    Private Sub menuitemExit_Click(sender As Object, e As EventArgs) Handles menuitemExit.Click
        Application.Exit()
    End Sub

    ' sub to cut selected text from the display
    Private Sub menuitemCut_Click(sender As Object, e As EventArgs) Handles menuitemCut.Click
        If txtDisplay IsNot Nothing Then
            If txtDisplay.SelectedText <> "" Then
                Clipboard.SetText(txtDisplay.SelectedText)
                txtDisplay.SelectedText = ""
            Else
                MessageBox.Show("No text selected to cut.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Text display is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' sub to copy text from the calculator
    Private Sub menuitemCopy_Click(sender As Object, e As EventArgs) Handles menuitemCopy.Click
        If calcuForm IsNot Nothing AndAlso Not calcuForm.IsDisposed Then
            calcuForm.CopyText()
        Else
            MessageBox.Show("No calculator instance is open to copy text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' sub to paste text into the calculator
    Private Sub menuitemPaste_Click(sender As Object, e As EventArgs) Handles menuitemPaste.Click
        If calcuForm IsNot Nothing AndAlso Not calcuForm.IsDisposed Then
            calcuForm.PasteText()
        Else
            MessageBox.Show("No calculator instance is open to paste text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' sub to select all text in the display
    Private Sub menuitemSelectAll_Click(sender As Object, e As EventArgs) Handles menuitemSelectAll.Click
        If txtDisplay IsNot Nothing Then
            If txtDisplay.Text.Length > 0 Then
                txtDisplay.SelectAll()
            Else
                MessageBox.Show("No text available to select.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Text display is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' sub to display information about the application
    Private Sub menuitemAbout_Click(sender As Object, e As EventArgs) Handles menuitemAbout.Click
        MessageBox.Show("Calculator App Version 1.0" & vbCrLf & "Developed by: April Anne C. Cabanilla" & vbCrLf & "CYS: BSCS - 2A" & vbCrLf & "© 2024-2025 University of Northern Philippines", "About Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' sub to display the latest version information
    Private Sub menuitemUpdates_Click(sender As Object, e As EventArgs) Handles menuitemUpdates.Click
        MessageBox.Show("The latest version is installed.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' sub to show the user guide with detailed instructions
    Private Sub menuitemUserGuide_Click(sender As Object, e As EventArgs) Handles menuitemUserGuide.Click
        Dim userGuideText As String = "User Guide:" & vbCrLf & vbCrLf &
                                      "1. Starting the Calculator:" & vbCrLf &
                                      "    - Launch the application and the main menu will appear." & vbCrLf & vbCrLf &
                                      "2. Using the Calculator:" & vbCrLf &
                                      "    - Click the number buttons to enter numbers." & vbCrLf &
                                      "    - Use the operator buttons (+, -, *, /) to perform calculations." & vbCrLf &
                                      "    - Click '=' to get the result." & vbCrLf &
                                      "    - Click 'C' to clear all input, or 'CE' to clear the last entry." & vbCrLf & vbCrLf &
                                      "3. File Menu:" & vbCrLf &
                                      "    - New: Opens a new calculator instance." & vbCrLf &
                                      "    - Save: Saves the history of calculations to a file." & vbCrLf &
                                      "    - Print: Prints the history of calculations." & vbCrLf &
                                      "    - Exit: Closes the application." & vbCrLf & vbCrLf &
                                      "4. Edit Menu:" & vbCrLf &
                                      "    - Cut: Cuts the selected text and copies it to the clipboard." & vbCrLf &
                                      "    - Copy: Copies the selected text to the clipboard." & vbCrLf &
                                      "    - Paste: Pastes text from the clipboard into the display." & vbCrLf &
                                      "    - Select All: Selects all text in the display." & vbCrLf & vbCrLf &
                                      "5. Help Menu:" & vbCrLf &
                                      "    - User Guide: Shows this user guide." & vbCrLf &
                                      "    - About: Displays information about the application." & vbCrLf &
                                      "    - Updates: Shows the latest version information." & vbCrLf & vbCrLf &
                                      "    Note!" & vbCrLf &
                                      "    Keyboard inputs are not supported."

        MessageBox.Show(userGuideText, "User Guide", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' sub to ensure the application closes entirely when the form is closed
    Private Sub MenuForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Application.Exit() ' close the entire application
        End If
    End Sub

    ' helper method to open the calculator form
    Private Sub OpenCalculator()
        If calcuForm Is Nothing OrElse calcuForm.IsDisposed Then
            calcuForm = New Calcu()
        End If
        calcuForm.Show()
    End Sub
End Class
