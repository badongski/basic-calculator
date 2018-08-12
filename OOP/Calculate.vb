Public Class Calculate
    Public Function add(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim sum As Double
        sum = Val(num1) + Val(num2)

        Return sum
    End Function
    Public Function subtract(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim diff As Double

        diff = Val(num1) - Val(num2)
        Return diff
    End Function
    Public Function multiply(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim product As Double

        product = Val(num1) * Val(num2)
        Return product
    End Function
    Public Function divide(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim quotient As Double

        quotient = Val(num1) / Val(num2)
        Return quotient
    End Function

    Public Function sample()
        Dim obj As New Object

        obj = {"1", "2", "3"}

        Return obj
    End Function
End Class
