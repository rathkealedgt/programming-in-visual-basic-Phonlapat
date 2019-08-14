Module Component2
    ''' <summary>
    '''     Lucky Unicorn Decomposition Task 2
    '''    Generate a random token from a list and display it for the user.
    ''' </summary>
    ''' <author> Mr. M </author>
    ''' <date> 20Jun19 </date>
    Sub Main()
        ' Housekeeping
        Dim HowMuch As Integer

        ' Prompt user
        Console.WriteLine("How much money would you like to play which?")
        HowMuch = IntegerCheck(1, 10)
        Console.ReadLine()

    End Sub
End Module
