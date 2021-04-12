imports System.IO
Module Module1

    Sub Main()
        Console.WriteLine("Which Day?")
        Dim adventDay As Integer = Console.ReadLine()
        Dim fullSubName as String
        fullSubName = "adventDay" & adventDay
        fullSubName
    End Sub
    
    Sub adventDay2()
        Dim passwords As new StreamReader ("input.txt")
        'Console.WriteLine(passwords.ReadToEnd())
        Dim fileContents(999) as String
        Dim counter as Integer = 0
        Dim check1, check2, valid As Integer
        Dim targetChar1, targetChar2 As Char
        Dim checkChar as Char
        Dim strHolder(1) As String
        Dim strHolder2(2) As String
        Dim line, lastBit as String
        
        Do 
            fileContents(counter) = passwords.ReadLine()
            counter += 1
        Loop Until passwords.EndOfStream
        
        passwords.Close()
        
        For i = 0 to 999
            'Console.WriteLine(fileContents(i))
            line = fileContents(i)
            strHolder = Split(line,"-",2)
            check1 = Val(strHolder(0))
            check2 = Val(strHolder(1))
            Console.WriteLine("First number " & check1)
            Console.WriteLine("Second number " & check2)
            strHolder2 = Split(line, " ", -1)
            checkChar = strHolder2(1)
            Console.WriteLine("Check Char is " & checkChar)
            lastBit = (strHolder2(2))
            targetChar1 = lastBit(check1 - 1)
            targetChar2 = lastBit(check2 - 1)
            If checkChar = targetChar1 And targetChar2 <> checkChar Or checkChar <> targetChar1 And targetChar2 = checkChar Then
                Console.WriteLine("DING DING DING")
                valid += 1
            End If
            
        Next
       Console.WriteLine(valid)
        
    End Sub
End Module
