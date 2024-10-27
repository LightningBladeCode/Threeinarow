Imports System.Data.OleDb
Public Class Form1
    Public Structure game
        Dim gameboard As String
    End Structure

    Dim board(2, 2) As game
    Public Structure login
        Dim userid As Integer
        Dim username As String
        Dim password As String
        Dim NoWins As Integer
    End Structure

    Dim loginInfo(99) As login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Clear_Game()



    End Sub
    Private Sub Clear_Game()
        Dim row As Integer
        Dim col As Integer
        Button2.Text = "Button2"
        Button3.Text = "Button3"
        Button4.Text = "Button4"
        Button5.Text = "Button5"
        Button6.Text = "Button6"
        Button7.Text = "Button7"
        Button8.Text = "Button8"
        Button9.Text = "Button9"
        Button10.Text = "Button10"

        For row = 0 To 2
            For col = 0 To 2
                board(row, col).gameboard = ""

            Next

        Next

    End Sub

    Private Sub WinGame()
        If board(0, 0).gameboard = "O" And board(0, 1).gameboard = "O" And board(0, 2).gameboard = "O" Then

            MsgBox("You have won the game")

        ElseIf board(1, 0).gameboard = "O" And board(1, 1).gameboard = "O" And board(1, 2).gameboard = "O" Then

            MsgBox("You have won the game")

        ElseIf board(2, 0).gameboard = "O" And board(2, 1).gameboard = "O" And board(2, 2).gameboard = "O" Then

            MsgBox("You have won the game")

        ElseIf board(0, 0).gameboard = "O" And board(1, 0).gameboard = "O" And board(2, 0).gameboard = "O" Then

            MsgBox("You have won the game")

        ElseIf board(0, 1).gameboard = "O" And board(1, 1).gameboard = "O" And board(2, 1).gameboard = "O" Then

            MsgBox("You have won the game")

        ElseIf board(0, 2).gameboard = "O" And board(1, 2).gameboard = "O" And board(2, 2).gameboard = "O" Then

            MsgBox("You have won the game")

        ElseIf board(0, 2).gameboard = "O" And board(1, 1).gameboard = "O" And board(2, 0).gameboard = "O" Then

            MsgBox("You have won the game")

        ElseIf board(0, 0).gameboard = "O" And board(1, 1).gameboard = "O" And board(2, 2).gameboard = "O" Then

            MsgBox("You have won the game")

        ElseIf board(0, 0).gameboard = "X" And board(0, 1).gameboard = "X" And board(0, 2).gameboard = "X" Then
            MsgBox("You have lost the game")

        ElseIf board(1, 0).gameboard = "X" And board(1, 1).gameboard = "X" And board(1, 2).gameboard = "X" Then

            MsgBox("You have lost the game")

        ElseIf board(2, 0).gameboard = "X" And board(2, 1).gameboard = "X" And board(2, 2).gameboard = "X" Then

            MsgBox("You have lost the game")

        ElseIf board(0, 0).gameboard = "X" And board(1, 0).gameboard = "X" And board(2, 0).gameboard = "X" Then

            MsgBox("You have lost the game")

        ElseIf board(0, 1).gameboard = "X" And board(1, 1).gameboard = "X" And board(2, 1).gameboard = "X" Then

            MsgBox("You have lost the game")

        ElseIf board(0, 2).gameboard = "X" And board(1, 2).gameboard = "X" And board(2, 2).gameboard = "X" Then

            MsgBox("You have lost the game")

        ElseIf board(0, 2).gameboard = "X" And board(1, 1).gameboard = "X" And board(2, 0).gameboard = "X" Then

            MsgBox("You have lost the game")

        ElseIf board(0, 0).gameboard = "X" And board(1, 1).gameboard = "X" And board(2, 2).gameboard = "X" Then

            MsgBox("You have lost the game")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim col As Integer
        Dim check As Boolean
        Dim row As Integer
        If Button2.Text = "Button2" Then
            Button2.Text = "O"
            board(0, 0).gameboard = "O"
            For row = 0 To 2
                For col = 0 To 2
                    If board(row, col).gameboard <> "" Then
                        col += 1
                    ElseIf board(row, col).gameboard = "" Then
                        If board(row, col).gameboard = board(0, 0).gameboard Then
                            Button2.Text = "X"
                            board(0, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 1).gameboard Then
                            Button3.Text = "X"
                            board(0, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 2).gameboard Then
                            Button4.Text = "X"
                            board(0, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 0).gameboard Then
                            Button5.Text = "X"
                            board(1, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 1).gameboard Then
                            Button6.Text = "X"
                            board(1, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 2).gameboard Then
                            Button7.Text = "X"
                            board(1, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 0).gameboard Then
                            Button8.Text = "X"
                            board(2, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 1).gameboard Then
                            Button9.Text = "X"
                            board(2, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 2).gameboard Then
                            Button10.Text = "X"
                            board(2, 2).gameboard = "X"
                            check = True
                            Exit For
                        End If


                    End If

                Next
                If check = True Then
                    Exit For
                End If
            Next
        ElseIf Button2.Text = "X" Or Button2.Text = "O" Then
            MsgBox("You can't overwrite the placed shape  ")
        End If

        WinGame()




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim col As Integer
        Dim check As Boolean
        Dim row As Integer
        If Button3.Text = "Button3" Then
            Button3.Text = "O"
            board(0, 1).gameboard = "O"
            For row = 0 To 2
                For col = 0 To 2
                    If board(row, col).gameboard <> "" Then
                        col += 1
                    ElseIf board(row, col).gameboard = "" Then
                        If board(row, col).gameboard = board(0, 0).gameboard Then
                            Button2.Text = "X"
                            board(0, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 1).gameboard Then
                            Button3.Text = "X"
                            board(0, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 2).gameboard Then
                            Button4.Text = "X"
                            board(0, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 0).gameboard Then
                            Button5.Text = "X"
                            board(1, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 1).gameboard Then
                            Button6.Text = "X"
                            board(1, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 2).gameboard Then
                            Button7.Text = "X"
                            board(1, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 0).gameboard Then
                            Button8.Text = "X"
                            board(2, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 1).gameboard Then
                            Button9.Text = "X"
                            board(2, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 2).gameboard Then
                            Button10.Text = "X"
                            board(2, 2).gameboard = "X"
                            check = True
                            Exit For
                        End If


                    End If

                Next
                If check = True Then
                    Exit For
                End If
            Next
        ElseIf Button3.Text = "X" Or Button3.Text = "O" Then
            MsgBox("You can't overwrite the placed shape  ")
        End If

        WinGame()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim col As Integer
        Dim check As Boolean
        Dim row As Integer
        If Button4.Text = "Button4" Then
            Button4.Text = "O"
            board(0, 2).gameboard = "O"
            For row = 0 To 2
                For col = 0 To 2
                    If board(row, col).gameboard <> "" Then
                        col += 1
                    ElseIf board(row, col).gameboard = "" Then
                        If board(row, col).gameboard = board(0, 0).gameboard Then
                            Button2.Text = "X"
                            board(0, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 1).gameboard Then
                            Button3.Text = "X"
                            board(0, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 2).gameboard Then
                            Button4.Text = "X"
                            board(0, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 0).gameboard Then
                            Button5.Text = "X"
                            board(1, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 1).gameboard Then
                            Button6.Text = "X"
                            board(1, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 2).gameboard Then
                            Button7.Text = "X"
                            board(1, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 0).gameboard Then
                            Button8.Text = "X"
                            board(2, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 1).gameboard Then
                            Button9.Text = "X"
                            board(2, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 2).gameboard Then
                            Button10.Text = "X"
                            board(2, 2).gameboard = "X"
                            check = True
                            Exit For
                        End If


                    End If

                Next
                If check = True Then
                    Exit For
                End If
            Next
        ElseIf Button4.Text = "X" Or Button4.Text = "O" Then
            MsgBox("You can't overwrite the placed shape  ")
        End If

        WinGame()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim col As Integer
        Dim check As Boolean
        Dim row As Integer
        If Button5.Text = "Button5" Then
            Button5.Text = "O"
            board(1, 0).gameboard = "O"
            For row = 0 To 2
                For col = 0 To 2
                    If board(row, col).gameboard <> "" Then
                        col += 1
                    ElseIf board(row, col).gameboard = "" Then
                        If board(row, col).gameboard = board(0, 0).gameboard Then
                            Button2.Text = "X"
                            board(0, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 1).gameboard Then
                            Button3.Text = "X"
                            board(0, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 2).gameboard Then
                            Button4.Text = "X"
                            board(0, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 0).gameboard Then
                            Button5.Text = "X"
                            board(1, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 1).gameboard Then
                            Button6.Text = "X"
                            board(1, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 2).gameboard Then
                            Button7.Text = "X"
                            board(1, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 0).gameboard Then
                            Button8.Text = "X"
                            board(2, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 1).gameboard Then
                            Button9.Text = "X"
                            board(2, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 2).gameboard Then
                            Button10.Text = "X"
                            board(2, 2).gameboard = "X"
                            check = True
                            Exit For
                        End If


                    End If

                Next
                If check = True Then
                    Exit For
                End If
            Next
        ElseIf Button5.Text = "X" Or Button5.Text = "O" Then
            MsgBox("You can't overwrite the placed shape  ")
        End If
        WinGame()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim col As Integer
        Dim check As Boolean
        Dim row As Integer
        If Button6.Text = "Button6" Then
            Button6.Text = "O"
            board(1, 1).gameboard = "O"
            For row = 0 To 2
                For col = 0 To 2
                    If board(row, col).gameboard <> "" Then
                        col += 1
                    ElseIf board(row, col).gameboard = "" Then
                        If board(row, col).gameboard = board(0, 0).gameboard Then
                            Button2.Text = "X"
                            board(0, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 1).gameboard Then
                            Button3.Text = "X"
                            board(0, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 2).gameboard Then
                            Button4.Text = "X"
                            board(0, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 0).gameboard Then
                            Button5.Text = "X"
                            board(1, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 1).gameboard Then
                            Button6.Text = "X"
                            board(1, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 2).gameboard Then
                            Button7.Text = "X"
                            board(1, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 0).gameboard Then
                            Button8.Text = "X"
                            board(2, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 1).gameboard Then
                            Button9.Text = "X"
                            board(2, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 2).gameboard Then
                            Button10.Text = "X"
                            board(2, 2).gameboard = "X"
                            check = True
                            Exit For
                        End If


                    End If

                Next
                If check = True Then
                    Exit For
                End If
            Next
        ElseIf Button6.Text = "X" Or Button6.Text = "O" Then
            MsgBox("You can't overwrite the placed shape  ")
        End If

        WinGame()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim col As Integer
        Dim check As Boolean
        Dim row As Integer
        If Button7.Text = "Button7" Then
            Button7.Text = "O"
            board(1, 2).gameboard = "O"
            For row = 0 To 2
                For col = 0 To 2
                    If board(row, col).gameboard <> "" Then
                        col += 1
                    ElseIf board(row, col).gameboard = "" Then
                        If board(row, col).gameboard = board(0, 0).gameboard Then
                            Button2.Text = "X"
                            board(0, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 1).gameboard Then
                            Button3.Text = "X"
                            board(0, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 2).gameboard Then
                            Button4.Text = "X"
                            board(0, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 0).gameboard Then
                            Button5.Text = "X"
                            board(1, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 1).gameboard Then
                            Button6.Text = "X"
                            board(1, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 2).gameboard Then
                            Button7.Text = "X"
                            board(1, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 0).gameboard Then
                            Button8.Text = "X"
                            board(2, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 1).gameboard Then
                            Button9.Text = "X"
                            board(2, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 2).gameboard Then
                            Button10.Text = "X"
                            board(2, 2).gameboard = "X"
                            check = True
                            Exit For
                        End If


                    End If

                Next
                If check = True Then
                    Exit For
                End If
            Next
        ElseIf Button7.Text = "X" Or Button7.Text = "O" Then
            MsgBox("You can't overwrite the placed shape  ")
        End If

        WinGame()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim col As Integer
        Dim check As Boolean
        Dim row As Integer
        If Button8.Text = "Button8" Then
            Button8.Text = "O"
            board(2, 0).gameboard = "O"
            For row = 0 To 2
                For col = 0 To 2
                    If board(row, col).gameboard <> "" Then
                        col += 1
                    ElseIf board(row, col).gameboard = "" Then
                        If board(row, col).gameboard = board(0, 0).gameboard Then
                            Button2.Text = "X"
                            board(0, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 1).gameboard Then
                            Button3.Text = "X"
                            board(0, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 2).gameboard Then
                            Button4.Text = "X"
                            board(0, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 0).gameboard Then
                            Button5.Text = "X"
                            board(1, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 1).gameboard Then
                            Button6.Text = "X"
                            board(1, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 2).gameboard Then
                            Button7.Text = "X"
                            board(1, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 0).gameboard Then
                            Button8.Text = "X"
                            board(2, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 1).gameboard Then
                            Button9.Text = "X"
                            board(2, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 2).gameboard Then
                            Button10.Text = "X"
                            board(2, 2).gameboard = "X"
                            check = True
                            Exit For
                        End If


                    End If

                Next
                If check = True Then
                    Exit For
                End If
            Next
        ElseIf Button8.Text = "X" Or Button8.Text = "O" Then
            MsgBox("You can't overwrite the placed shape ")
        End If

        WinGame()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim col As Integer
        Dim check As Boolean
        Dim row As Integer
        If Button9.Text = "Button9" Then
            Button9.Text = "O"
            board(2, 1).gameboard = "O"
            For row = 0 To 2
                For col = 0 To 2
                    If board(row, col).gameboard <> "" Then
                        col += 1
                    ElseIf board(row, col).gameboard = "" Then
                        If board(row, col).gameboard = board(0, 0).gameboard Then
                            Button2.Text = "X"
                            board(0, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 1).gameboard Then
                            Button3.Text = "X"
                            board(0, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 2).gameboard Then
                            Button4.Text = "X"
                            board(0, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 0).gameboard Then
                            Button5.Text = "X"
                            board(1, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 1).gameboard Then
                            Button6.Text = "X"
                            board(1, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 2).gameboard Then
                            Button7.Text = "X"
                            board(1, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 0).gameboard Then
                            Button8.Text = "X"
                            board(2, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 1).gameboard Then
                            Button9.Text = "X"
                            board(2, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 2).gameboard Then
                            Button10.Text = "X"
                            board(2, 2).gameboard = "X"
                            check = True
                            Exit For
                        End If


                    End If

                Next
                If check = True Then
                    Exit For
                End If
            Next
        ElseIf Button9.Text = "X" Or Button9.Text = "O" Then
            MsgBox("You can't overwrite the placed shape")
        End If

        WinGame()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim col As Integer
        Dim check As Boolean
        Dim row As Integer
        If Button10.Text = "Button10" Then
            Button10.Text = "O"
            board(2, 2).gameboard = "O"
            For row = 0 To 2
                For col = 0 To 2
                    If board(row, col).gameboard <> "" Then
                        col += 1
                    ElseIf board(row, col).gameboard = "" Then
                        If board(row, col).gameboard = board(0, 0).gameboard Then
                            Button2.Text = "X"
                            board(0, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 1).gameboard Then
                            Button3.Text = "X"
                            board(0, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(0, 2).gameboard Then
                            Button4.Text = "X"
                            board(0, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 0).gameboard Then
                            Button5.Text = "X"
                            board(1, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 1).gameboard Then
                            Button6.Text = "X"
                            board(1, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(1, 2).gameboard Then
                            Button7.Text = "X"
                            board(1, 2).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 0).gameboard Then
                            Button8.Text = "X"
                            board(2, 0).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 1).gameboard Then
                            Button9.Text = "X"
                            board(2, 1).gameboard = "X"
                            check = True
                            Exit For
                        ElseIf board(row, col).gameboard = board(2, 2).gameboard Then
                            Button10.Text = "X"
                            board(2, 2).gameboard = "X"
                            check = True
                            Exit For
                        End If


                    End If

                Next
                If check = True Then
                    Exit For
                End If
            Next
        ElseIf Button10.Text = "X" Or Button10.Text = "O" Then
            MsgBox("You can't overwrite the placed shape  ")
        End If

        WinGame()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click ' login

        logintoaccount(loginInfo)


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click ' sign up
        ReadFile(loginInfo)
        makeoaccount(loginInfo)
    End Sub
    Private Sub ReadFile(ByVal loginInfo() As login) 'read txt file sub
        Dim index As Integer = 0
        FileOpen(1, "Login.txt", OpenMode.Input)
        Do While Not EOF(1)

            Input(1, loginInfo(index).userid)
            Input(1, loginInfo(index).username)
            Input(1, loginInfo(index).password)
            Input(1, loginInfo(index).NoWins)
            index = index + 1
        Loop

        FileClose()
    End Sub

    Private Sub makeoaccount(ByVal loginInfo() As login) 'sign up sub
        Dim taken As Boolean = False
        Dim inputname As String
        Dim index As Integer
        Dim inputpassword As String
        Dim inputID, InputNowins As Integer


        Do
            inputname = InputBox("enter your username you would like to use. Note: this will be your name in leaderboards")
            For index = 0 To loginInfo.Length - 1
                If loginInfo(index).username = inputname Or inputname.Length = 0 Then
                    taken = True
                    index = index + 1
                End If

            Next

        Loop Until taken = False

        Do
            inputpassword = InputBox("enter the password you'd like to make between 6 and 15 characters")
            taken = False
            If inputpassword.Length < 6 Or inputpassword.Length > 15 Then
                taken = True
                index = index + 1
            End If

        Loop Until taken = False

        Do
            Randomize()
            inputID = Int((Rnd() * 2000) + 1000)
            For index = 0 To loginInfo.Length - 1
                If loginInfo(index).userid = inputID Then
                    taken = True

                Else
                    index = index + 1
                End If
            Next
        Loop Until taken = False



        FileOpen(1, "Login.txt", OpenMode.Append)


        WriteLine(1, inputID, inputname, inputpassword, InputNowins)




        FileClose()

    End Sub
    Private Sub logintoaccount(ByVal loginInfo() As login)
        ReadFile(loginInfo)
        Dim inputname1, inputpassword1 As String
        Dim pos As Integer
        Dim veri1, veri2 As Boolean
        inputname1 = InputBox("ENTER your account username")
        Dim index As Integer = 0
        For index = 0 To loginInfo.Length - 1
            If inputname1 = loginInfo(index).username Then

                pos = index
                veri1 = True
                Exit For
            Else
                veri1 = False
            End If
        Next

        ListBox1.Items.Add(veri1)

        inputpassword1 = InputBox("enter the account password")

        If loginInfo(pos).password = inputpassword1 Then
            veri2 = True
        Else
            veri2 = False

        End If

        If veri1 = True And veri2 = True Then
            MsgBox("logged in successfully")
            Label1.Text = inputname1
        Else
            MsgBox("you have failed to login.")
        End If
        ListBox1.Items.Add(veri2)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click 'leaderboard

        UserToDb(loginInfo)
        readdb(loginInfo)
    End Sub
    Private Sub readdb(ByVal loginInfo() As login)

        Try

        Catch ex As Exception
            ListBox1.Items.Add(ex.Message)
        End Try


        Dim SQLReader As OleDbDataReader
        Dim connection_type As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
        Dim file_location As String = "Data Source=C:\Users\Rayane\Desktop\cluckcluck\bin\Debug\net6.0-windows\LeaderBoard.accdb"
        Dim conn As OleDbConnection
        conn = New OleDbConnection(connection_type & file_location)
        conn.Open()

        Dim query As String = "Select * FROM [Leaderboard]"
        Dim command As New OleDbCommand(query, conn)
        SQLReader = command.ExecuteReader()
        If SQLReader.HasRows Then
            While SQLReader.Read
                ListBox1.Items.Add(SQLReader("ID") & " " &
                SQLReader("username"))
            End While
        Else
            ListBox1.Items.Add("No Results Returned")
        End If

    End Sub

    Private Sub UserToDb(ByVal loginInfo() As login)
        ReadFile(loginInfo)
        Dim query As String
        Try

        Catch ex As Exception
            ListBox1.Items.Add(ex.Message)
        End Try


        Dim SQLReader As OleDbDataReader
        Dim connection_type As String = "Provider=Microsoft.ACE.OLEDB.16.0;"
        Dim file_location As String = "Data Source=C:\Users\Rayane\Desktop\cluckcluck\bin\Debug\net6.0-windows\LeaderBoard.accdb"
        Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Rayane\Desktop\delete\Implementation\bin\Debug\net5.0-windows\LeaderBoard.accdb")

        conn.Open()


        For index = 0 To loginInfo.Length - 1
            query = "INSERT INTO [LeaderBoard] VALUES ( " &
loginInfo(index).userid & " , ' " & loginInfo(index).username & " ');"



        Next

        Dim command As New OleDbCommand(query, conn)
        SQLReader = command.ExecuteReader()

    End Sub

    Private Sub sort(ByVal loginInfo() As login)
        'Insertion Sort Ascending
        Dim temp As Integer
        Dim index As Integer ' Outer loop counts from 2nd to end of list
        Dim j As Integer ' Inner loop counts back from i
        For index = 1 To loginInfo.Length() - 1
            temp = loginInfo(index).userid
            j = index
            While j > 0 AndAlso loginInfo(j - 1).userid > temp
                loginInfo(j).userid = loginInfo(j - 1).userid ' push along
                j = j - 1
            End While
            loginInfo(j).userid = temp ' Insert
        Next
    End Sub

End Class
