Public Class frmCalcu
    Dim calc = New Calculate
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim num1 As Integer, num2 As Integer, output As Integer

        Try
            num1 = txtNum1.Text
            num2 = txtNum2.Text
            If num1 <> vbEmpty Or num2 <> vbEmpty Then
                If cmbOperator.SelectedIndex = 0 Then
                    output = calc.add(num1, num2)
                    MsgBox("Sum is :" & output)
                ElseIf cmbOperator.SelectedIndex = 1 Then
                    output = calc.subtract(num1, num2)
                    MsgBox("Difference is :" & output)
                ElseIf cmbOperator.SelectedIndex = 2 Then
                    output = calc.multiply(num1, num2)
                    MsgBox("Product is :" & output)
                ElseIf cmbOperator.SelectedIndex = 3 Then
                    output = calc.divide(num1, num2)
                    MsgBox("Quotient is :" & output)
                End If
            Else
                MsgBox("Fields are required")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub frmCalcu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbOperator.Items.Add("Addition")
        cmbOperator.Items.Add("Subtraction")
        cmbOperator.Items.Add("Multiplication")
        cmbOperator.Items.Add("Division")
        cmbOperator.SelectedIndex = 0
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        For Each qwe In calc.sample()
            MsgBox(qwe)
        Next

    End Sub
End Class
