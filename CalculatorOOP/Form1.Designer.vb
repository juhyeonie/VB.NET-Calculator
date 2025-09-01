<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtDisplay = New TextBox()
        btnBackspace = New Button()
        btnClear = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btnDiv = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btnMul = New Button()
        btn1 = New Button()
        btn2 = New Button()
        btnSub = New Button()
        btn0 = New Button()
        btnDecimal = New Button()
        btnEqual = New Button()
        btnAdd = New Button()
        btn6 = New Button()
        btn3 = New Button()
        SuspendLayout()
        ' 
        ' txtDisplay
        ' 
        txtDisplay.AccessibleName = ""
        txtDisplay.BackColor = SystemColors.Control
        txtDisplay.Dock = DockStyle.Top
        txtDisplay.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDisplay.ForeColor = SystemColors.MenuText
        txtDisplay.Location = New Point(0, 0)
        txtDisplay.Margin = New Padding(3, 4, 3, 4)
        txtDisplay.Multiline = True
        txtDisplay.Name = "txtDisplay"
        txtDisplay.ReadOnly = True
        txtDisplay.Size = New Size(303, 104)
        txtDisplay.TabIndex = 0
        txtDisplay.Text = "0"
        txtDisplay.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnBackspace
        ' 
        btnBackspace.BackColor = Color.IndianRed
        btnBackspace.ForeColor = SystemColors.Control
        btnBackspace.Location = New Point(158, 116)
        btnBackspace.Margin = New Padding(3, 4, 3, 4)
        btnBackspace.Name = "btnBackspace"
        btnBackspace.Size = New Size(65, 59)
        btnBackspace.TabIndex = 1
        btnBackspace.Text = "←"
        btnBackspace.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.IndianRed
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = SystemColors.Control
        btnClear.Location = New Point(14, 116)
        btnClear.Margin = New Padding(3, 4, 3, 4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(137, 59)
        btnClear.TabIndex = 2
        btnClear.Text = "AC"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btn7
        ' 
        btn7.ForeColor = SystemColors.ActiveCaptionText
        btn7.Location = New Point(14, 183)
        btn7.Margin = New Padding(3, 4, 3, 4)
        btn7.Name = "btn7"
        btn7.Size = New Size(65, 59)
        btn7.TabIndex = 3
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.ForeColor = SystemColors.ActiveCaptionText
        btn8.Location = New Point(86, 183)
        btn8.Margin = New Padding(3, 4, 3, 4)
        btn8.Name = "btn8"
        btn8.Size = New Size(65, 59)
        btn8.TabIndex = 4
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.ForeColor = SystemColors.ActiveCaptionText
        btn9.Location = New Point(158, 183)
        btn9.Margin = New Padding(3, 4, 3, 4)
        btn9.Name = "btn9"
        btn9.Size = New Size(65, 59)
        btn9.TabIndex = 5
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btnDiv
        ' 
        btnDiv.ForeColor = SystemColors.Desktop
        btnDiv.Location = New Point(230, 116)
        btnDiv.Margin = New Padding(3, 4, 3, 4)
        btnDiv.Name = "btnDiv"
        btnDiv.Size = New Size(65, 59)
        btnDiv.TabIndex = 6
        btnDiv.Text = "÷"
        btnDiv.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.ForeColor = SystemColors.ActiveCaptionText
        btn4.Location = New Point(14, 249)
        btn4.Margin = New Padding(3, 4, 3, 4)
        btn4.Name = "btn4"
        btn4.Size = New Size(65, 59)
        btn4.TabIndex = 7
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.ForeColor = SystemColors.ActiveCaptionText
        btn5.Location = New Point(86, 249)
        btn5.Margin = New Padding(3, 4, 3, 4)
        btn5.Name = "btn5"
        btn5.Size = New Size(65, 59)
        btn5.TabIndex = 8
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btnMul
        ' 
        btnMul.ForeColor = SystemColors.ActiveCaptionText
        btnMul.Location = New Point(230, 183)
        btnMul.Margin = New Padding(3, 4, 3, 4)
        btnMul.Name = "btnMul"
        btnMul.Size = New Size(65, 59)
        btnMul.TabIndex = 10
        btnMul.Text = "×"
        btnMul.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.ForeColor = SystemColors.ActiveCaptionText
        btn1.Location = New Point(14, 316)
        btn1.Margin = New Padding(3, 4, 3, 4)
        btn1.Name = "btn1"
        btn1.Size = New Size(65, 59)
        btn1.TabIndex = 11
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.ForeColor = SystemColors.ActiveCaptionText
        btn2.Location = New Point(86, 316)
        btn2.Margin = New Padding(3, 4, 3, 4)
        btn2.Name = "btn2"
        btn2.Size = New Size(65, 59)
        btn2.TabIndex = 12
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btnSub
        ' 
        btnSub.ForeColor = SystemColors.ActiveCaptionText
        btnSub.Location = New Point(230, 249)
        btnSub.Margin = New Padding(3, 4, 3, 4)
        btnSub.Name = "btnSub"
        btnSub.Size = New Size(65, 59)
        btnSub.TabIndex = 14
        btnSub.Text = "-"
        btnSub.UseVisualStyleBackColor = True
        ' 
        ' btn0
        ' 
        btn0.ForeColor = SystemColors.ActiveCaptionText
        btn0.Location = New Point(86, 383)
        btn0.Margin = New Padding(3, 4, 3, 4)
        btn0.Name = "btn0"
        btn0.Size = New Size(65, 59)
        btn0.TabIndex = 15
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btnDecimal
        ' 
        btnDecimal.ForeColor = SystemColors.ActiveCaptionText
        btnDecimal.Location = New Point(14, 383)
        btnDecimal.Margin = New Padding(3, 4, 3, 4)
        btnDecimal.Name = "btnDecimal"
        btnDecimal.Size = New Size(65, 59)
        btnDecimal.TabIndex = 16
        btnDecimal.Text = "."
        btnDecimal.UseVisualStyleBackColor = True
        ' 
        ' btnEqual
        ' 
        btnEqual.BackColor = Color.IndianRed
        btnEqual.ForeColor = SystemColors.Control
        btnEqual.Location = New Point(158, 383)
        btnEqual.Margin = New Padding(3, 4, 3, 4)
        btnEqual.Name = "btnEqual"
        btnEqual.Size = New Size(137, 59)
        btnEqual.TabIndex = 17
        btnEqual.Text = "="
        btnEqual.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.ForeColor = SystemColors.ActiveCaptionText
        btnAdd.Location = New Point(230, 316)
        btnAdd.Margin = New Padding(3, 4, 3, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(65, 59)
        btnAdd.TabIndex = 18
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.ForeColor = SystemColors.ActiveCaptionText
        btn6.Location = New Point(158, 249)
        btn6.Margin = New Padding(3, 4, 3, 4)
        btn6.Name = "btn6"
        btn6.Size = New Size(65, 59)
        btn6.TabIndex = 9
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.ForeColor = SystemColors.ActiveCaptionText
        btn3.Location = New Point(158, 316)
        btn3.Margin = New Padding(3, 4, 3, 4)
        btn3.Name = "btn3"
        btn3.Size = New Size(65, 59)
        btn3.TabIndex = 13
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(303, 456)
        Controls.Add(btnAdd)
        Controls.Add(btnEqual)
        Controls.Add(btnDecimal)
        Controls.Add(btn0)
        Controls.Add(btnSub)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(btnMul)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btnDiv)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btnClear)
        Controls.Add(btnBackspace)
        Controls.Add(txtDisplay)
        ForeColor = SystemColors.ActiveCaptionText
        KeyPreview = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnBackspace As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btnMul As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnDecimal As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn3 As Button

End Class
