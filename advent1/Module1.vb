imports System.IO
Imports System.Runtime.InteropServices

Module Module1

    Sub Main()
        Console.WriteLine("Welcome to Advent of code Challenges Xmas 2020")
        Console.Writeline("DOOOOOOOOOOOOD!!!!!!!!!!WHAAAAAAAASAAAAAAAAAPPPPPPPPP!!!!!!!!")
        Console.WriteLine("This skips the first day and first ")
        Console.WriteLine("challenge of second day because when I ")
        Console.WriteLine("came back to them in 2021 that was as far as I'd got")
        userChoice()
    End Sub
    
    Sub adventDay2()
        Console.WriteLine("Welcome to day 2")
        Dim passwords As new StreamReader ("input2.txt")
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
           ' Console.WriteLine("First number " & check1)
           ' Console.WriteLine("Second number " & check2)
            strHolder2 = Split(line, " ", -1)
            checkChar = strHolder2(1)
            'Console.WriteLine("Check Char is " & checkChar)
            lastBit = (strHolder2(2))
            targetChar1 = lastBit(check1 - 1)
            targetChar2 = lastBit(check2 - 1)
            If checkChar = targetChar1 And targetChar2 <> checkChar Or checkChar <> targetChar1 And targetChar2 = checkChar Then
                'Console.WriteLine("DING DING DING")
                valid += 1
            End If
            
        Next
       Console.WriteLine("There are " & valid & " valid passwords for the second challenge")
        userChoice()
    End Sub
    Sub adventDay3()
        Console.WriteLine("Welcome to day 3")
        'TODO how to loop through the map using right three and down one? Two nested loops one for down 1 and then one for 3 right
        'Todo need to keep a running total for position
        'Todo need to loop back through the map if we hit the end of the line (It's 31 long)
        'Todo recognise the char as #
        'Todo return the number of #
        
        Dim map As new StreamReader ("input3.txt")
        Dim lineCount = File.ReadAllLines("input3.txt").Length
        Console.WriteLine(lineCount)
        Dim fileContents(lineCount) as String
        Dim counter as Integer = 0
        
        Do 
            fileContents(counter) = map.ReadLine()
            counter += 1
        Loop Until map.EndOfStream
        
        for i = 0 to lineCount
            Console.WriteLine(fileContents(i).Length)
        Next
        
        map.Close()
        
        userChoice()
    End Sub
    
    Sub userChoice()
        Console.WriteLine("")
        Console.WriteLine("Which Day?")
        Console.WriteLine("2...25? Or 999 to Exit")
        Dim userChoice as Integer = Console.ReadLine()
        Select Case userChoice
            Case 2
                adventDay2()
            Case 3
                adventDay3()
            Case 999
                Exit Sub        
        End Select
    End Sub
    
End Module
