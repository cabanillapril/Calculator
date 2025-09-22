Imports System.Reflection

Public Class Calcu
    ' variables to store the first number, second number, and operator
    Dim firstNumber As Decimal = 0
    Dim secondNumber As Decimal = 0
    Dim operation As String = ""
    Dim isOperationPerformed As Boolean = False

    ' public property to access txtDisplay
    Public ReadOnly Property DisplayText As String
        Get
            Return txtDisplay.Text
        End Get
    End Property

    ' method to update display text
    Public Sub SetDisplayText(text As String)
        txtDisplay.Text = text
    End Sub

    ' method to copy text
    Public Sub CopyText()
        Clipboard.SetText(txtDisplay.SelectedText)
    End Sub

    ' method to paste text
    Public Sub PasteText()
        If Clipboard.ContainsText() Then
            txtDisplay.SelectedText = Clipboard.GetText()
        End If
    End Sub

    ' handle number button clicks
    Private Sub btnNumber_Click(sender As Object, e As EventArgs) _
        Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click

        Dim button As Button = CType(sender, Button)

        If txtDisplay.Text = "0" OrElse isOperationPerformed Then
            txtDisplay.Text = ""
        End If

        txtDisplay.Text &= button.Text
        isOperationPerformed = False
    End Sub

    ' clear all input
    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtDisplay.Text = "0"
        firstNumber = 0
        secondNumber = 0
        operation = ""
        isOperationPerformed = False
    End Sub

    ' clear last entry
    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        txtDisplay.Text = "0"
    End Sub

    ' delete the last character
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1)
        End If
        If txtDisplay.Text = "" Then
            txtDisplay.Text = "0"
        End If
    End Sub

    ' set the operation (+, -, *, /)
    Private Sub btnOperator_Click(sender As Object, e As EventArgs) _
        Handles btnPlus.Click, btnMin.Click, btnDiv.Click, btnMul.Click

        Dim button As Button = CType(sender, Button)
        Try
            firstNumber = Decimal.Parse(txtDisplay.Text)
            operation = button.Text
            isOperationPerformed = True
        Catch ex As Exception
            MessageBox.Show("Error parsing number. Please check your input.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDisplay.Text = "0"
        End Try
    End Sub

    ' toggle positive/negative sign
    Private Sub btnPN_Click(sender As Object, e As EventArgs) Handles btnPN.Click
        Try
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text = (-1 * Decimal.Parse(txtDisplay.Text)).ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error toggling sign. Please check your input.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDisplay.Text = "0"
        End Try
    End Sub

    ' decimal point
    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If Not txtDisplay.Text.Contains(".") Then
            txtDisplay.Text &= "."
        End If
    End Sub

    ' perform the calculation when equals is clicked
    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        Try
            secondNumber = Decimal.Parse(txtDisplay.Text)

            Select Case operation
                Case "+"
                    txtDisplay.Text = (firstNumber + secondNumber).ToString()
                Case "-"
                    txtDisplay.Text = (firstNumber - secondNumber).ToString()
                Case "*"
                    txtDisplay.Text = (firstNumber * secondNumber).ToString()
                Case "/"
                    If secondNumber <> 0 Then
                        txtDisplay.Text = (firstNumber / secondNumber).ToString()
                    Else
                        MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtDisplay.Text = "0"
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show("Error performing calculation. Please check your input.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDisplay.Text = "0"
        End Try
        isOperationPerformed = False
    End Sub

End Class

