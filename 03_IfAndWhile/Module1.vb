''' <summary>
'''     This exercise will introduce you to if statements and while loops.
''' </summary>
''' <author> Mr Macri </author>
''' <date> 13Jun19 </date>
''' 
Module Module1

    Sub Main()
        ' Housekeeping
        Dim UserInput As String
        Dim KeepGoing As String = ""

        While KeepGoing = ""
            ' Ask user if they like coffee and record their answer.
            Console.WriteLine("Do you like coffee?")
            UserInput = Console.ReadLine().ToLower()

            ' Check input and respond
            If UserInput = "yes" Or UserInput = "y" Then
                Console.WriteLine("I Like coffee too!")
            ElseIf UserInput = "no" Or UserInput = "n" Then
                Console.WriteLine("Your life must be empty!")
            End If

            ' Pause program to let the user read 
            Console.WriteLine("Press q followed by <Enter> to quite.")
            KeepGoing = Console.ReadLine()
        End While

    End Sub

End Module
