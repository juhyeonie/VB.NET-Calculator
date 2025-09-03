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
        lblDisplay = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBackspace
        ' 
        btnBackspace.BackColor = SystemColors.AppWorkspace
        btnBackspace.Dock = DockStyle.Fill
        btnBackspace.FlatStyle = FlatStyle.Popup
        btnBackspace.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBackspace.ForeColor = SystemColors.ButtonFace
        btnBackspace.Location = New Point(177, 4)
        btnBackspace.Margin = New Padding(3, 4, 3, 4)
        btnBackspace.Name = "btnBackspace"
        btnBackspace.Size = New Size(81, 67)
        btnBackspace.TabIndex = 1
        btnBackspace.Text = "←"
        btnBackspace.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.AppWorkspace
        TableLayoutPanel1.SetColumnSpan(btnClear, 2)
        btnClear.Dock = DockStyle.Fill
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = SystemColors.ButtonFace
        btnClear.Location = New Point(3, 4)
        btnClear.Margin = New Padding(3, 4, 3, 4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(168, 67)
        btnClear.TabIndex = 2
        btnClear.Text = "AC"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btn7
        ' 
        btn7.BackColor = SystemColors.ControlDarkDark
        btn7.Dock = DockStyle.Fill
        btn7.FlatStyle = FlatStyle.Popup
        btn7.ForeColor = SystemColors.ButtonFace
        btn7.Location = New Point(3, 79)
        btn7.Margin = New Padding(3, 4, 3, 4)
        btn7.Name = "btn7"
        btn7.Size = New Size(81, 67)
        btn7.TabIndex = 3
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = False
        ' 
        ' btn8
        ' 
        btn8.BackColor = SystemColors.ControlDarkDark
        btn8.Dock = DockStyle.Fill
        btn8.FlatStyle = FlatStyle.Popup
        btn8.ForeColor = SystemColors.ButtonFace
        btn8.Location = New Point(90, 79)
        btn8.Margin = New Padding(3, 4, 3, 4)
        btn8.Name = "btn8"
        btn8.Size = New Size(81, 67)
        btn8.TabIndex = 4
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = False
        ' 
        ' btn9
        ' 
        btn9.BackColor = SystemColors.ControlDarkDark
        btn9.Dock = DockStyle.Fill
        btn9.FlatStyle = FlatStyle.Popup
        btn9.ForeColor = SystemColors.ButtonFace
        btn9.Location = New Point(177, 79)
        btn9.Margin = New Padding(3, 4, 3, 4)
        btn9.Name = "btn9"
        btn9.Size = New Size(81, 67)
        btn9.TabIndex = 5
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = False
        ' 
        ' btnDiv
        ' 
        btnDiv.BackColor = Color.DarkOrange
        btnDiv.Dock = DockStyle.Fill
        btnDiv.FlatStyle = FlatStyle.Popup
        btnDiv.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDiv.ForeColor = SystemColors.ButtonFace
        btnDiv.Location = New Point(264, 4)
        btnDiv.Margin = New Padding(3, 4, 3, 4)
        btnDiv.Name = "btnDiv"
        btnDiv.Size = New Size(81, 67)
        btnDiv.TabIndex = 6
        btnDiv.Text = "÷"
        btnDiv.UseVisualStyleBackColor = False
        ' 
        ' btn4
        ' 
        btn4.BackColor = SystemColors.ControlDarkDark
        btn4.Dock = DockStyle.Fill
        btn4.FlatStyle = FlatStyle.Popup
        btn4.ForeColor = SystemColors.ButtonFace
        btn4.Location = New Point(3, 154)
        btn4.Margin = New Padding(3, 4, 3, 4)
        btn4.Name = "btn4"
        btn4.Size = New Size(81, 67)
        btn4.TabIndex = 7
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = False
        ' 
        ' btn5
        ' 
        btn5.BackColor = SystemColors.ControlDarkDark
        btn5.Dock = DockStyle.Fill
        btn5.FlatStyle = FlatStyle.Popup
        btn5.ForeColor = SystemColors.ButtonFace
        btn5.Location = New Point(90, 154)
        btn5.Margin = New Padding(3, 4, 3, 4)
        btn5.Name = "btn5"
        btn5.Size = New Size(81, 67)
        btn5.TabIndex = 8
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = False
        ' 
        ' btnMul
        ' 
        btnMul.BackColor = Color.DarkOrange
        btnMul.Dock = DockStyle.Fill
        btnMul.FlatStyle = FlatStyle.Popup
        btnMul.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMul.ForeColor = SystemColors.ButtonFace
        btnMul.Location = New Point(264, 79)
        btnMul.Margin = New Padding(3, 4, 3, 4)
        btnMul.Name = "btnMul"
        btnMul.Size = New Size(81, 67)
        btnMul.TabIndex = 10
        btnMul.Text = "×"
        btnMul.UseVisualStyleBackColor = False
        ' 
        ' btn1
        ' 
        btn1.BackColor = SystemColors.ControlDarkDark
        btn1.Dock = DockStyle.Fill
        btn1.FlatStyle = FlatStyle.Popup
        btn1.ForeColor = SystemColors.ButtonFace
        btn1.Location = New Point(3, 229)
        btn1.Margin = New Padding(3, 4, 3, 4)
        btn1.Name = "btn1"
        btn1.Size = New Size(81, 67)
        btn1.TabIndex = 11
        btn1.TabStop = False
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = False
        ' 
        ' btn2
        ' 
        btn2.BackColor = SystemColors.ControlDarkDark
        btn2.Dock = DockStyle.Fill
        btn2.FlatStyle = FlatStyle.Popup
        btn2.ForeColor = SystemColors.Control
        btn2.Location = New Point(90, 229)
        btn2.Margin = New Padding(3, 4, 3, 4)
        btn2.Name = "btn2"
        btn2.Size = New Size(81, 67)
        btn2.TabIndex = 12
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = False
        ' 
        ' btnSub
        ' 
        btnSub.BackColor = Color.DarkOrange
        btnSub.Dock = DockStyle.Fill
        btnSub.FlatStyle = FlatStyle.Popup
        btnSub.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSub.ForeColor = SystemColors.ButtonFace
        btnSub.Location = New Point(264, 154)
        btnSub.Margin = New Padding(3, 4, 3, 4)
        btnSub.Name = "btnSub"
        btnSub.Size = New Size(81, 67)
        btnSub.TabIndex = 14
        btnSub.Text = "-"
        btnSub.UseVisualStyleBackColor = False
        ' 
        ' btn0
        ' 
        btn0.BackColor = SystemColors.WindowFrame
        btn0.Dock = DockStyle.Fill
        btn0.FlatStyle = FlatStyle.Popup
        btn0.ForeColor = SystemColors.ButtonFace
        btn0.Location = New Point(90, 304)
        btn0.Margin = New Padding(3, 4, 3, 4)
        btn0.Name = "btn0"
        btn0.Size = New Size(81, 67)
        btn0.TabIndex = 15
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = False
        ' 
        ' btnDecimal
        ' 
        btnDecimal.BackColor = SystemColors.ControlDarkDark
        btnDecimal.Dock = DockStyle.Fill
        btnDecimal.FlatStyle = FlatStyle.Popup
        btnDecimal.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDecimal.ForeColor = SystemColors.ButtonFace
        btnDecimal.Location = New Point(3, 304)
        btnDecimal.Margin = New Padding(3, 4, 3, 4)
        btnDecimal.Name = "btnDecimal"
        btnDecimal.Size = New Size(81, 67)
        btnDecimal.TabIndex = 16
        btnDecimal.Text = "."
        btnDecimal.UseVisualStyleBackColor = False
        ' 
        ' btnEqual
        ' 
        btnEqual.BackColor = Color.DarkOrange
        TableLayoutPanel1.SetColumnSpan(btnEqual, 2)
        btnEqual.Dock = DockStyle.Fill
        btnEqual.FlatStyle = FlatStyle.Popup
        btnEqual.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEqual.ForeColor = SystemColors.Control
        btnEqual.Location = New Point(177, 304)
        btnEqual.Margin = New Padding(3, 4, 3, 4)
        btnEqual.Name = "btnEqual"
        btnEqual.Size = New Size(168, 67)
        btnEqual.TabIndex = 17
        btnEqual.Text = "="
        btnEqual.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.DarkOrange
        btnAdd.Dock = DockStyle.Fill
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = SystemColors.ButtonFace
        btnAdd.Location = New Point(264, 229)
        btnAdd.Margin = New Padding(3, 4, 3, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(81, 67)
        btnAdd.TabIndex = 18
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btn6
        ' 
        btn6.BackColor = SystemColors.ControlDarkDark
        btn6.Dock = DockStyle.Fill
        btn6.FlatStyle = FlatStyle.Popup
        btn6.ForeColor = SystemColors.ButtonFace
        btn6.Location = New Point(177, 154)
        btn6.Margin = New Padding(3, 4, 3, 4)
        btn6.Name = "btn6"
        btn6.Size = New Size(81, 67)
        btn6.TabIndex = 9
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.BackColor = SystemColors.ControlDarkDark
        btn3.Dock = DockStyle.Fill
        btn3.FlatStyle = FlatStyle.Popup
        btn3.ForeColor = SystemColors.ButtonFace
        btn3.Location = New Point(177, 229)
        btn3.Margin = New Padding(3, 4, 3, 4)
        btn3.Name = "btn3"
        btn3.Size = New Size(81, 67)
        btn3.TabIndex = 13
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = False
        ' 
        ' lblDisplay
        ' 
        lblDisplay.BackColor = SystemColors.ControlText
        lblDisplay.Dock = DockStyle.Top
        lblDisplay.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDisplay.ForeColor = SystemColors.ButtonFace
        lblDisplay.Location = New Point(0, 0)
        lblDisplay.Name = "lblDisplay"
        lblDisplay.Size = New Size(352, 116)
        lblDisplay.TabIndex = 19
        lblDisplay.Text = "0"
        lblDisplay.TextAlign = ContentAlignment.BottomRight
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(btnClear, 0, 0)
        TableLayoutPanel1.Controls.Add(btnBackspace, 1, 0)
        TableLayoutPanel1.Controls.Add(btn0, 1, 4)
        TableLayoutPanel1.Controls.Add(btnEqual, 2, 4)
        TableLayoutPanel1.Controls.Add(btnAdd, 3, 3)
        TableLayoutPanel1.Controls.Add(btnDecimal, 0, 4)
        TableLayoutPanel1.Controls.Add(btnDiv, 2, 0)
        TableLayoutPanel1.Controls.Add(btn7, 0, 1)
        TableLayoutPanel1.Controls.Add(btn8, 1, 1)
        TableLayoutPanel1.Controls.Add(btn9, 2, 1)
        TableLayoutPanel1.Controls.Add(btn3, 2, 3)
        TableLayoutPanel1.Controls.Add(btnSub, 3, 2)
        TableLayoutPanel1.Controls.Add(btn2, 1, 3)
        TableLayoutPanel1.Controls.Add(btnMul, 3, 1)
        TableLayoutPanel1.Controls.Add(btn1, 0, 3)
        TableLayoutPanel1.Controls.Add(btn4, 0, 2)
        TableLayoutPanel1.Controls.Add(btn5, 1, 2)
        TableLayoutPanel1.Controls.Add(btn6, 2, 2)
        TableLayoutPanel1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TableLayoutPanel1.ForeColor = SystemColors.ControlText
        TableLayoutPanel1.Location = New Point(0, 119)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Size = New Size(348, 375)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlText
        ClientSize = New Size(352, 498)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(lblDisplay)
        ForeColor = SystemColors.ActiveCaptionText
        KeyPreview = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
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
    Friend WithEvents lblDisplay As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel

End Class
