Public Class Calculator

    Dim firstNum As Decimal
    Dim secondNum As Decimal
    Dim operations As Integer
    Dim operator_selector As Boolean = False

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        If displayTextBox.Text <> "0" Then
            displayTextBox.Text += "1"
        Else
            displayTextBox.Text = "1"
        End If
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        If displayTextBox.Text <> "0" Then
            displayTextBox.Text += "2"
        Else
            displayTextBox.Text = "2"
        End If
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        If displayTextBox.Text <> "0" Then
            displayTextBox.Text += "3"
        Else
            displayTextBox.Text = "3"
        End If
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        If displayTextBox.Text <> "0" Then
            displayTextBox.Text += "4"
        Else
            displayTextBox.Text = "4"
        End If
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        If displayTextBox.Text <> "0" Then
            displayTextBox.Text += "5"
        Else
            displayTextBox.Text = "5"
        End If
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        If displayTextBox.Text <> "0" Then
            displayTextBox.Text += "6"
        Else
            displayTextBox.Text = "6"
        End If
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        If displayTextBox.Text <> "0" Then
            displayTextBox.Text += "7"
        Else
            displayTextBox.Text = "7"
        End If
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        If displayTextBox.Text <> "0" Then
            displayTextBox.Text += "8"
        Else
            displayTextBox.Text = "8"
        End If
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        If displayTextBox.Text <> "0" Then
            displayTextBox.Text += "9"
        Else
            displayTextBox.Text = "9"
        End If
    End Sub

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        If displayTextBox.Text <> "0" Then
            displayTextBox.Text += "0"
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        displayTextBox.Text = "0"
    End Sub

    Private Sub btn_decimal_Click(sender As Object, e As EventArgs) Handles btn_decimal.Click
        If Not (displayTextBox.Text.Contains(".")) Then
            displayTextBox.Text += "."
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        firstNum = displayTextBox.Text
        displayTextBox.Text = "0"
        operator_selector = True
        operations = 1
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        firstNum = displayTextBox.Text
        displayTextBox.Text = "0"
        operator_selector = True
        operations = 2
    End Sub

    Private Sub btn_multiply_Click(sender As Object, e As EventArgs) Handles btn_multiply.Click
        firstNum = displayTextBox.Text
        displayTextBox.Text = "0"
        operator_selector = True
        operations = 3
    End Sub

    Private Sub btn_divide_Click(sender As Object, e As EventArgs) Handles btn_divide.Click
        firstNum = displayTextBox.Text
        displayTextBox.Text = "0"
        operator_selector = True
        operations = 4
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If operator_selector = True Then
            secondNum = displayTextBox.Text
            If operations = 1 Then
                displayTextBox.Text = firstNum + secondNum
            ElseIf operations = 2 Then
                displayTextBox.Text = firstNum - secondNum
            ElseIf operations = 3 Then
                displayTextBox.Text = firstNum * secondNum
            Else
                If secondNum = 0 Then
                    displayTextBox.Text = "SYNTAX ERROR"
                Else
                    displayTextBox.Text = firstNum / secondNum
                End If
            End If
            operator_selector = False
        End If
    End Sub

    Private Sub displayTextBox_TextChanged(sender As Object, e As EventArgs) Handles displayTextBox.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
End Class
