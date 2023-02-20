Public Class Form1


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim guessedNumber As String
        Dim number As Integer
        Dim correct As Boolean
        Dim count As Integer

        Randomize()
        number = Int(Rnd() * 100) + 1
        correct = False
        count = 1

        Do While count < 11 And correct = False
            guessedNumber = InputBox("Enter your guess" & count)
            If Val(guessedNumber) = number Then
                correct = True
            Else
                If guessedNumber < number Then
                    MsgBox("Too low" & count)
                Else
                    MsgBox("Too high" & count)
                End If
                count = count + 1
            End If
        Loop

    End Sub
End Class
