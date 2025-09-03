Public Class Form1
    'Global Variables
    Dim dblFirstNumber As Double
    Dim dblSecondNumber As Double
    Dim strOperator As String
    Dim blnOperatorClicked As Boolean = False
    Dim dblResult As Double

    'Form load event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDisplay.Text = "0"
        Me.KeyPreview = True
    End Sub

    'Number button click events
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click,
    btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnDecimal.Click

        If lblDisplay.Text = "0" Or blnOperatorClicked Then
            lblDisplay.Text = ""
        End If

        blnOperatorClicked = False
        Dim button As Button = CType(sender, Button)

        If button.Text = "." Then
            If Not lblDisplay.Text.Contains(".") Then
                lblDisplay.Text &= button.Text
            End If
        Else
            lblDisplay.Text &= button.Text
        End If

        Me.ActiveControl = Nothing
    End Sub

    'Operator button click events
    Private Sub operator_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSub.Click, btnMul.Click, btnDiv.Click
        Dim button As Button = CType(sender, Button)

        If strOperator <> "" AndAlso Not blnOperatorClicked Then
            btnEqual.PerformClick()
        End If

        strOperator = button.Text
        If strOperator = "×" Then strOperator = "*"
        If strOperator = "÷" Then strOperator = "/"

        Double.TryParse(lblDisplay.Text, dblFirstNumber)
        blnOperatorClicked = True
    End Sub

    'Equal button click event
    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If blnOperatorClicked Then
            Return
        End If

        If Not Double.TryParse(lblDisplay.Text, dblSecondNumber) Then
            lblDisplay.Text = "0"
            Return
        End If

        Select Case strOperator
            Case "+"
                dblResult = dblFirstNumber + dblSecondNumber
            Case "-"
                dblResult = dblFirstNumber - dblSecondNumber
            Case "*"
                dblResult = dblFirstNumber * dblSecondNumber
            Case "/"
                If dblSecondNumber = 0 Then
                    lblDisplay.Text = "Cannot divide by zero"
                    blnOperatorClicked = True
                    strOperator = ""
                    Return
                Else
                    dblResult = dblFirstNumber / dblSecondNumber
                End If
            Case Else
                Return
        End Select

        lblDisplay.Text = dblResult.ToString()
        dblFirstNumber = dblResult
        blnOperatorClicked = True
        strOperator = ""
    End Sub

    'Clear button click event
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblDisplay.Text = "0"
        dblFirstNumber = 0
        dblSecondNumber = 0
        strOperator = ""
        blnOperatorClicked = False
    End Sub

    'Backspace button click event
    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If lblDisplay.Text = "Cannot divide by zero" Then
            lblDisplay.Text = "0"
            dblFirstNumber = 0
            dblSecondNumber = 0
            strOperator = ""
            blnOperatorClicked = False
            Return
        End If

        If lblDisplay.Text.Length > 1 Then
            lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1)
        Else
            lblDisplay.Text = "0"
        End If
    End Sub

    'Keyboard special keys 
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnEqual.PerformClick()
                e.SuppressKeyPress = True

            Case Keys.Back
                btnBackspace.PerformClick()
                e.SuppressKeyPress = True

            Case Keys.Escape
                btnClear.PerformClick()
                e.SuppressKeyPress = True
        End Select
    End Sub

    'Keyboard number and operator keys
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case "0"c : btn0.PerformClick()
            Case "1"c : btn1.PerformClick()
            Case "2"c : btn2.PerformClick()
            Case "3"c : btn3.PerformClick()
            Case "4"c : btn4.PerformClick()
            Case "5"c : btn5.PerformClick()
            Case "6"c : btn6.PerformClick()
            Case "7"c : btn7.PerformClick()
            Case "8"c : btn8.PerformClick()
            Case "9"c : btn9.PerformClick()
            Case "."c : btnDecimal.PerformClick()

            Case "-"c
                If lblDisplay.Text = "0" Or lblDisplay.Text = "" Or blnOperatorClicked Then
                    lblDisplay.Text = "-"
                    blnOperatorClicked = False
                Else
                    btnSub.PerformClick()
                End If

            Case "+"c : btnAdd.PerformClick()
            Case "*"c : btnMul.PerformClick()
            Case "/"c : btnDiv.PerformClick()
            Case "="c : btnEqual.PerformClick()
        End Select
    End Sub
End Class
