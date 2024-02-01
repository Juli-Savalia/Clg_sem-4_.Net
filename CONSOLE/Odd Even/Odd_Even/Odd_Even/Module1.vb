Module Module1

    Sub Main()

        Dim i As Integer
        Console.Write("Enter number = ")
        i = Integer.Parse(Console.ReadLine())
        If i Mod 2 = 0 Then
            Console.WriteLine("given number is even")
        Else
            Console.WriteLine("given number is odd")
        End If
    End Sub

End Module
