
Module Module1

    Sub Main()

        Console.Write("你要輸入幾個數字 :")
        Console.Write("")

        Dim size As Integer = Val(Console.ReadLine)
        Dim a As Integer = 0
        Dim number(size) As Integer

        Do
            number(a) = Val(Console.ReadLine)
            a = a + 1
        Loop While (a < size)


        Console.WriteLine("最大值 = {0}", getmax(number))
        For b As Integer = b To UBound(number)
        Next

        Console.WriteLine("最小值 = {0}", getmin(number))

        For c As Integer = c To LBound(number)
        Next

        Console.Read()


    End Sub

    Function getmax(ByVal ParamArray x() As Integer) As Integer

        Dim max As Integer = x(0)

        For b As Integer = b To UBound(x)
            If x(b) >= max Then
                max = x(b)
            End If

        Next
        Return max
    End Function

    Function getmin(ByVal ParamArray y() As Integer) As Integer

        Dim min As Integer = y(0)

        For c As Integer = c To LBound(y)
            If y(c) <= min Then
                min = y(c)
            End If


        Next
        Return min
    End Function
End Module