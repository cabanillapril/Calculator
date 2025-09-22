'Developed by: April Anne C. Cabanilla
'CYS: BSCS - 2A
'Instructor: Mr. Eddiemar Sinco
'Subject: Object Oriented Programming

Public Class Login
    ' form Load Event
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set the default PasswordChar to hide the password
        txtPass.PasswordChar = "•"
    End Sub

    ' event handler for the login button click
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String
        Dim password As String

        ' get the raw input from the TextBoxes
        username = txtUser.Text
        password = txtPass.Text

        ' compare the raw values directly (this is insecure for real apps)
        If (username.Equals("aprilcabanilla") And password.Equals("admin")) Then
            ' show the MenuForm and close the Login form
            Dim menuForm As New MenuForm()
            menuForm.Show()
            Me.Hide() ' optionally hide the login form
        Else
            MessageBox.Show("Error", "Invalid username or password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' show/hide password using the CheckBox
    Private Sub chckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chckBox.CheckedChanged
        ' toggle the PasswordChar property based on the CheckBox state
        If chckBox.Checked Then
            txtPass.PasswordChar = "" ' show the password (no mask character)
        Else
            txtPass.PasswordChar = "•" ' hide the password (use custom mask character)
        End If
    End Sub

    Private Sub labelForgotPass_Click(sender As Object, e As EventArgs) Handles labelForgotPass.Click
        MessageBox.Show("Please contact support to reset your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' handle the Enter key press to trigger login
    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown, txtUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick() ' simulate the login button click
        End If
    End Sub

    Private Sub labelAbout_Click(sender As Object, e As EventArgs) Handles labelAbout.Click
        MessageBox.Show("Version 1.0 " & vbCrLf & "Developed by: April Anne C. Cabanilla" & vbCrLf & "CYS: BSCS 2A" & vbCrLf & "College of Communication and Information Technology" & vbCrLf & "@2024-2025 University of Northern Philippines", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    ' create a Sub for the labelSupport click event to display the contact info
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles labelSupport.Click
        MessageBox.Show("Contact us: " & vbCrLf & "Phone Number: 09358031831" & vbCrLf & "Email: cabanillapril@gmail.com", "Support", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' ensure the application terminates when the form is closed
        Application.Exit()
    End Sub

End Class
