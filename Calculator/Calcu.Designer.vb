<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calcu
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
        txtDisplay = New TextBox()
        btnDel = New Button()
        btnCE = New Button()
        btnPN = New Button()
        btnC = New Button()
        btn8 = New Button()
        btn7 = New Button()
        btnPlus = New Button()
        btn9 = New Button()
        btn5 = New Button()
        btn4 = New Button()
        btnMin = New Button()
        btn6 = New Button()
        btn2 = New Button()
        btn1 = New Button()
        btnDiv = New Button()
        btn3 = New Button()
        btnMul = New Button()
        btnEquals = New Button()
        btnDot = New Button()
        btn0 = New Button()
        SuspendLayout()
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Cursor = Cursors.IBeam
        txtDisplay.Font = New Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDisplay.Location = New Point(27, 25)
        txtDisplay.Multiline = True
        txtDisplay.Name = "txtDisplay"
        txtDisplay.Size = New Size(372, 86)
        txtDisplay.TabIndex = 0
        ' 
        ' btnDel
        ' 
        btnDel.BackColor = Color.FromArgb(CByte(166), CByte(156), CByte(172))
        btnDel.Font = New Font("Wingdings", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(2))
        btnDel.Location = New Point(27, 128)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(88, 84)
        btnDel.TabIndex = 1
        btnDel.Text = ""
        btnDel.UseVisualStyleBackColor = False
        ' 
        ' btnCE
        ' 
        btnCE.BackColor = Color.FromArgb(CByte(166), CByte(156), CByte(172))
        btnCE.Font = New Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCE.Location = New Point(121, 128)
        btnCE.Name = "btnCE"
        btnCE.Size = New Size(89, 84)
        btnCE.TabIndex = 2
        btnCE.Text = "CE"
        btnCE.UseVisualStyleBackColor = False
        ' 
        ' btnPN
        ' 
        btnPN.BackColor = Color.FromArgb(CByte(166), CByte(156), CByte(172))
        btnPN.Font = New Font("Trebuchet MS", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPN.Location = New Point(310, 128)
        btnPN.Name = "btnPN"
        btnPN.Size = New Size(89, 84)
        btnPN.TabIndex = 4
        btnPN.Text = "±"
        btnPN.UseVisualStyleBackColor = False
        ' 
        ' btnC
        ' 
        btnC.BackColor = Color.FromArgb(CByte(166), CByte(156), CByte(172))
        btnC.Font = New Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnC.Location = New Point(216, 128)
        btnC.Name = "btnC"
        btnC.Size = New Size(88, 84)
        btnC.TabIndex = 3
        btnC.Text = "C"
        btnC.UseVisualStyleBackColor = False
        ' 
        ' btn8
        ' 
        btn8.Font = New Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn8.Location = New Point(121, 218)
        btn8.Name = "btn8"
        btn8.Size = New Size(89, 84)
        btn8.TabIndex = 6
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Font = New Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn7.Location = New Point(27, 218)
        btn7.Name = "btn7"
        btn7.Size = New Size(88, 84)
        btn7.TabIndex = 5
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btnPlus
        ' 
        btnPlus.BackColor = Color.FromArgb(CByte(166), CByte(156), CByte(172))
        btnPlus.Font = New Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPlus.Location = New Point(310, 218)
        btnPlus.Name = "btnPlus"
        btnPlus.Size = New Size(89, 84)
        btnPlus.TabIndex = 8
        btnPlus.Text = "+"
        btnPlus.UseVisualStyleBackColor = False
        ' 
        ' btn9
        ' 
        btn9.Font = New Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn9.Location = New Point(216, 218)
        btn9.Name = "btn9"
        btn9.Size = New Size(88, 84)
        btn9.TabIndex = 7
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Font = New Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn5.Location = New Point(121, 308)
        btn5.Name = "btn5"
        btn5.Size = New Size(89, 84)
        btn5.TabIndex = 10
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Font = New Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn4.Location = New Point(27, 308)
        btn4.Name = "btn4"
        btn4.Size = New Size(88, 84)
        btn4.TabIndex = 9
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btnMin
        ' 
        btnMin.BackColor = Color.FromArgb(CByte(166), CByte(156), CByte(172))
        btnMin.Font = New Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMin.Location = New Point(310, 308)
        btnMin.Name = "btnMin"
        btnMin.Size = New Size(89, 84)
        btnMin.TabIndex = 12
        btnMin.Text = "-"
        btnMin.UseVisualStyleBackColor = False
        ' 
        ' btn6
        ' 
        btn6.Font = New Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn6.Location = New Point(216, 308)
        btn6.Name = "btn6"
        btn6.Size = New Size(88, 84)
        btn6.TabIndex = 11
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Font = New Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn2.Location = New Point(121, 398)
        btn2.Name = "btn2"
        btn2.Size = New Size(89, 84)
        btn2.TabIndex = 14
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Font = New Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn1.Location = New Point(27, 398)
        btn1.Name = "btn1"
        btn1.Size = New Size(88, 84)
        btn1.TabIndex = 13
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btnDiv
        ' 
        btnDiv.BackColor = Color.FromArgb(CByte(166), CByte(156), CByte(172))
        btnDiv.Font = New Font("Trebuchet MS", 16F)
        btnDiv.Location = New Point(310, 398)
        btnDiv.Name = "btnDiv"
        btnDiv.Size = New Size(89, 84)
        btnDiv.TabIndex = 16
        btnDiv.Text = "/"
        btnDiv.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.Font = New Font("Trebuchet MS", 16F)
        btn3.Location = New Point(216, 398)
        btn3.Name = "btn3"
        btn3.Size = New Size(88, 84)
        btn3.TabIndex = 15
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btnMul
        ' 
        btnMul.BackColor = Color.FromArgb(CByte(166), CByte(156), CByte(172))
        btnMul.Font = New Font("Trebuchet MS", 16F)
        btnMul.Location = New Point(310, 488)
        btnMul.Name = "btnMul"
        btnMul.Size = New Size(89, 84)
        btnMul.TabIndex = 20
        btnMul.Text = "*"
        btnMul.UseVisualStyleBackColor = False
        ' 
        ' btnEquals
        ' 
        btnEquals.Font = New Font("Trebuchet MS", 16F)
        btnEquals.Location = New Point(216, 488)
        btnEquals.Name = "btnEquals"
        btnEquals.Size = New Size(88, 84)
        btnEquals.TabIndex = 19
        btnEquals.Text = "="
        btnEquals.UseVisualStyleBackColor = True
        ' 
        ' btnDot
        ' 
        btnDot.Font = New Font("Trebuchet MS", 16F)
        btnDot.Location = New Point(121, 488)
        btnDot.Name = "btnDot"
        btnDot.Size = New Size(89, 84)
        btnDot.TabIndex = 18
        btnDot.Text = "."
        btnDot.UseVisualStyleBackColor = True
        ' 
        ' btn0
        ' 
        btn0.Font = New Font("Trebuchet MS", 16F)
        btn0.Location = New Point(27, 488)
        btn0.Name = "btn0"
        btn0.Size = New Size(88, 84)
        btn0.TabIndex = 17
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' Calcu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(71), CByte(73), CByte(118))
        ClientSize = New Size(428, 585)
        Controls.Add(btnMul)
        Controls.Add(btnEquals)
        Controls.Add(btnDot)
        Controls.Add(btn0)
        Controls.Add(btnDiv)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(btnMin)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btnPlus)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btnPN)
        Controls.Add(btnC)
        Controls.Add(btnCE)
        Controls.Add(btnDel)
        Controls.Add(txtDisplay)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Calcu"
        Text = "Calcu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnDel As Button
    Friend WithEvents btnCE As Button
    Friend WithEvents btnPN As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btnMul As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents btn0 As Button
End Class
