Imports System

Module Program
    Sub Main()

        Dim Num As Integer
        Dim Data As String
        Dim Caller As Integer

        FileOpen(1, "*.txt", OpenMode.Append)

        Console.Write("How many lines = ")
        Num = Console.ReadLine
        Console.WriteLine()

        For Count = 1 To Num
            Console.Write("What to print = ")
            Data = Console.ReadLine
            PrintLine(1, Data)
        Next

        FileClose(1)
        Console.WriteLine()

        Console.Write("Which line to read = ")
        Caller = Console.ReadLine
        Console.WriteLine()

        FileOpen(1, "*.txt", OpenMode.Input)

        For Count = 1 To Num
            If Count = Caller Then
                Console.WriteLine("Line No. " & Count & vbTab & LineInput(1))
            Else
                LineInput(1)
            End If
        Next

        FileClose(1)

        Kill("*.txt")

        Console.ReadLine()

    End Sub

End Module
