imports System.IO
Module Module1

    Sub Main()
        Dim passwords As new StreamReader ("input.txt")
        'Console.WriteLine(passwords.ReadToEnd())
        Dim fileContents(999) as String
        Dim counter as Integer = 0
        Dim Check1, Check2, valid As Integer
        Dim TargetChar1, TargetChar2 As Char
        Dim CheckChar as Char
        Dim StrHolder(1) As String
        Dim StrHolder2(2) As String
        Dim line, lastBit as String
        
        Do 
            fileContents(counter) = passwords.ReadLine()
            counter += 1
        Loop Until passwords.EndOfStream
        
        passwords.Close()
        
        For i = 0 to 999
            'Console.WriteLine(fileContents(i))
            line = fileContents(i)
            StrHolder = Split(line,"-",2)
            Check1 = Val(StrHolder(0))
            Check2 = Val(StrHolder(1))
            Console.WriteLine("First number " & Check1)
            Console.WriteLine("Second number " & Check2)
            StrHolder2 = Split(line, " ", -1)
            CheckChar = StrHolder2(1)
            Console.WriteLine("Check Char is " & CheckChar)
            lastBit = (StrHolder2(2))
            TargetChar1 = lastBit(Check1 - 1)
            TargetChar2 = lastBit(Check2 - 1)
            If CheckChar = TargetChar1 And TargetChar2 <> CheckChar Or CheckChar <> TargetChar1 And TargetChar2 = CheckChar Then
                Console.WriteLine("DING DING DING")
                valid += 1
            End If
            
        Next
       Console.WriteLine(valid)
        
       'Todo Pull the check char out
        
       'Todo check if the line matches the validation rules.
        
        
    End Sub
End Module
