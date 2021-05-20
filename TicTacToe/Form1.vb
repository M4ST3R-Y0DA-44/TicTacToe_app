' TicTacToe
' Program made to practice my newly learned skills. 
' M4ST3R Y0DA 44 on 05 may 2021

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1

    Private intPlayerTurn As Integer
    Private blnWinner As Boolean


    ' Empty the tictactoe Grid. 
    Private Sub Reset_Grid()
        lblGrid1.Text = String.Empty
        lblGrid2.Text = String.Empty
        lblGrid3.Text = String.Empty
        lblGrid4.Text = String.Empty
        lblGrid5.Text = String.Empty
        lblGrid6.Text = String.Empty
        lblGrid7.Text = String.Empty
        lblGrid8.Text = String.Empty
        lblGrid9.Text = String.Empty
    End Sub

    ' On main page load initialises both players wins to 0 and writes the instructions to start playing. 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intPlayerTurn = 1
        lblPlayer1GamesWon.Text = "0"
        lblPlayer2Gameswon.Text = "0"
        lblInstructions.Text = "Welcome to TicTacToe" + ControlChars.NewLine + "Please press on New Game to start!"
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click, QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Retrieves the content of the tictactoe grid to validate if the game has been started or not. 
    Private Function Grid_Content() As String
        Dim strContentOfGrid As String
        strContentOfGrid = lblGrid1.Text + lblGrid2.Text + lblGrid3.Text + lblGrid4.Text + lblGrid5.Text + lblGrid6.Text + lblGrid7.Text +
            lblGrid8.Text + lblGrid9.Text
        Return strContentOfGrid
    End Function

    ' Procedure that verifies if both players are humans and 1 players has more than 7 wins and if so, writes the game in the record books. 
    Private Sub Record_Books()
        ' Variable for players name and wins
        Dim strPlayer1Name As String
        Dim strPlayer2Name As String
        Dim intPlayer1Wins As Integer
        Dim intPlayer2Wins As Integer

        strPlayer1Name = lblPlayer1Name.Text.Trim().TrimEnd(":"c)
        strPlayer2Name = lblPlayer2Name.Text.Trim().TrimEnd(":"c)
        Integer.TryParse(lblPlayer1GamesWon.Text, intPlayer1Wins)
        Integer.TryParse(lblPlayer2Gameswon.Text, intPlayer2Wins)

        ' Verifie if both players are humans and if 1 of the players has more then 7 wins. 
        If strPlayer1Name <> "Player 1" And strPlayer2Name <> "Player 2" And (intPlayer1Wins >= 7 OrElse intPlayer2Wins >= 7) Then
            Try
                Dim RecordBooks As IO.StreamWriter

                If IO.File.Exists("RecordBooks.txt") Then
                    RecordBooks = IO.File.AppendText("RecordBooks.txt")
                    RecordBooks.WriteLine(lblPlayer1Name.Text.PadRight(14) & lblPlayer1GamesWon.Text.PadRight(8) & lblPlayer2Name.Text.PadRight(14) & lblPlayer2Gameswon.Text)
                    RecordBooks.Close()
                Else
                    RecordBooks = IO.File.CreateText("RecordBooks.txt")
                    RecordBooks.WriteLine("Player1".PadRight(14) & "Wins".PadRight(8) & "Player2".PadRight(14) & "Wins")
                    RecordBooks.WriteLine(lblPlayer1Name.Text.PadRight(14) & lblPlayer1GamesWon.Text.PadRight(8) & lblPlayer2Name.Text.PadRight(14) & lblPlayer2Gameswon.Text)
                    RecordBooks.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    ' Resets a single game of tic tac toe or initializes the game if the games wasnt started. 
    Private Sub NewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click, NewGameToolStripMenuItem.Click
        If Grid_Content() <> String.Empty Then
            Dim dlgAnswer As DialogResult
            dlgAnswer = MessageBox.Show("Starting a new game will reset the TicTactoe grid but keep current wins active." + ControlChars.NewLine +
                                        "Are you sure you want to start a new game?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dlgAnswer = DialogResult.Yes Then
                Activate_Grid_Labels()
                blnWinner = False
                Reset_Grid()
                If intPlayerTurn = 1 Then
                    lblInstructions.Text = "It's your turn " + lblPlayer1Name.Text.Trim.TrimEnd(":"c)
                ElseIf intPlayerTurn = 2 Then
                    lblInstructions.Text = "It's your turn " + lblPlayer2Name.Text.Trim.TrimEnd(":"c)
                End If
            End If
        Else
            If intPlayerTurn = 1 Then
                lblInstructions.Text = "It's your turn " + lblPlayer1Name.Text.Trim.TrimEnd(":"c)
            ElseIf intPlayerTurn = 2 Then
                lblInstructions.Text = "It's your turn " + lblPlayer2Name.Text.Trim.TrimEnd(":"c)
            End If
            Activate_Grid_Labels()
            blnWinner = False
        End If
    End Sub

    ' Activates all labels of the tictactoe grid. 
    Private Sub Activate_Grid_Labels()
        lblGrid1.Enabled = True
        lblGrid2.Enabled = True
        lblGrid3.Enabled = True
        lblGrid4.Enabled = True
        lblGrid5.Enabled = True
        lblGrid6.Enabled = True
        lblGrid7.Enabled = True
        lblGrid8.Enabled = True
        lblGrid9.Enabled = True
    End Sub

    ' End of game or tictactoe.
    Private Sub End_Of_Game()
        If blnWinner = True Or Grid_Content().Length() = 9 Then
            lblGrid1.Enabled = False
            lblGrid2.Enabled = False
            lblGrid3.Enabled = False
            lblGrid4.Enabled = False
            lblGrid5.Enabled = False
            lblGrid6.Enabled = False
            lblGrid7.Enabled = False
            lblGrid8.Enabled = False
            lblGrid9.Enabled = False
            If blnWinner = True Then
                Dim message As String
                If intPlayerTurn = 1 Then
                    Dim intPlayer2CurrentWins As Integer
                    Integer.TryParse(lblPlayer2Gameswon.Text, intPlayer2CurrentWins)
                    intPlayer2CurrentWins += 1
                    lblPlayer2Gameswon.Text = intPlayer2CurrentWins.ToString()
                    message = "Nice win " + lblPlayer2Name.Text.Trim.TrimEnd(":"c)
                    ' Activate reset score button and menu
                    mnuResetScores.Enabled = True
                    btnReset.Enabled = True
                ElseIf intPlayerTurn = 2 Then
                    Dim intPlayer1CurrentWins As Integer
                    Integer.TryParse(lblPlayer1GamesWon.Text, intPlayer1CurrentWins)
                    intPlayer1CurrentWins += 1
                    lblPlayer1GamesWon.Text = intPlayer1CurrentWins.ToString()
                    message = "Nice win " + lblPlayer1Name.Text.Trim.TrimEnd(":"c)
                    ' Activate reset score button and menu
                    mnuResetScores.Enabled = True
                    btnReset.Enabled = True
                End If
                lblInstructions.Text = message
            End If
        End If
    End Sub

    ' Changes the players turns after each player clicks the tictactoe grid to play a turn. Returns the string for the grid and tells the other player to play.
    Private Function Player_Change() As String
        If intPlayerTurn = 1 Then
            lblInstructions.Text = "It's your turn " + lblPlayer2Name.Text + " (O)"
            intPlayerTurn = 2
            Return "X"
        Else
            lblInstructions.Text = "It's your turn " + lblPlayer1Name.Text + " (X)"
            intPlayerTurn = 1
            Return "O"
        End If
    End Function

    ' Click gridlabel1 verification for tictactoe condition if the label is empty. Changes boolean condition of winner to true if tictactoe condition is met and ends game. 
    Private Sub lblGrid1_Click(sender As Object, e As EventArgs) Handles lblGrid1.Click
        If lblGrid1.Text = String.Empty Then
            lblGrid1.Text = Player_Change()
            If lblGrid1.Text = lblGrid2.Text And lblGrid2.Text = lblGrid3.Text Then
                blnWinner = True
            ElseIf lblGrid1.Text = lblGrid5.Text And lblGrid5.Text = lblGrid9.Text Then
                blnWinner = True
            ElseIf lblGrid1.Text = lblGrid4.Text And lblGrid4.Text = lblGrid7.Text Then
                blnWinner = True
            End If
            End_Of_Game()
        End If
    End Sub

    ' Click gridlabel2 verification for tictactoe condition if label is empty. changes boolean condition of winner to true if tictactoe condition is met and ends game.
    Private Sub lblGrid2_Click(sender As Object, e As EventArgs) Handles lblGrid2.Click
        If lblGrid2.Text = String.Empty Then
            lblGrid2.Text = Player_Change()
            If lblGrid2.Text = lblGrid3.Text And lblGrid2.Text = lblGrid1.Text Then
                blnWinner = True
            ElseIf lblGrid2.Text = lblGrid5.Text And lblGrid2.Text = lblGrid8.Text Then
                blnWinner = True
            End If
            End_Of_Game()
        End If
    End Sub

    ' Click gridlabel3 verification for tictactoe confition if label is empty. changes boolean condition to winner to true if tictactoe is met and ends game. 
    Private Sub lblGrid3_Click(sender As Object, e As EventArgs) Handles lblGrid3.Click
        If lblGrid3.Text = String.Empty Then
            lblGrid3.Text = Player_Change()
            If lblGrid3.Text = lblGrid2.Text And lblGrid3.Text = lblGrid1.Text Then
                blnWinner = True
            ElseIf lblGrid3.Text = lblGrid6.Text And lblGrid3.Text = lblGrid9.Text Then
                blnWinner = True
            ElseIf lblGrid3.Text = lblGrid5.Text And lblGrid3.Text = lblGrid7.Text Then
                blnWinner = True
            End If
            End_Of_Game()
        End If
    End Sub

    ' Click gridLabel4 verification for tictactoe condition if label is empty. changes boolean condition to winner if tictactoe is met and ends game. 
    Private Sub lblGrid4_Click(sender As Object, e As EventArgs) Handles lblGrid4.Click
        If lblGrid4.Text = String.Empty Then
            lblGrid4.Text = Player_Change()
            If lblGrid4.Text = lblGrid1.Text And lblGrid4.Text = lblGrid7.Text Then
                blnWinner = True
            ElseIf lblGrid4.Text = lblGrid5.Text And lblGrid4.Text = lblGrid6.Text Then
                blnWinner = True
            End If
            End_Of_Game()
        End If
    End Sub

    ' Click gridlabel5 verification for tictactoe if label is empty. changes boolean condition to winner if tictactoe is met and ends game. 
    Private Sub lblGrid5_Click(sender As Object, e As EventArgs) Handles lblGrid5.Click
        If lblGrid5.Text = String.Empty Then
            lblGrid5.Text = Player_Change()
            If lblGrid5.Text = lblGrid6.Text And lblGrid5.Text = lblGrid4.Text Then
                blnWinner = True
            ElseIf lblGrid5.Text = lblGrid2.Text And lblGrid5.Text = lblGrid8.Text Then
                blnWinner = True
            ElseIf lblGrid5.Text = lblGrid3.Text And lblGrid5.Text = lblGrid7.Text Then
                blnWinner = True
            ElseIf lblGrid5.Text = lblGrid1.Text And lblGrid5.Text = lblGrid9.Text Then
                blnWinner = True
            End If
            End_Of_Game()
        End If
    End Sub

    ' Click gridlabel6 verification for tictactoe if label is empty. changes boolean condition to winner if tictactoe is met and ends game. 
    Private Sub lblGrid6_Click(sender As Object, e As EventArgs) Handles lblGrid6.Click
        If lblGrid6.Text = String.Empty Then
            lblGrid6.Text = Player_Change()
            If lblGrid6.Text = lblGrid3.Text And lblGrid6.Text = lblGrid9.Text Then
                blnWinner = True
            ElseIf lblGrid6.Text = lblGrid5.Text And lblGrid6.Text = lblGrid4.Text Then
                blnWinner = True
            End If
            End_Of_Game()
        End If
    End Sub

    ' Click gridlabel7 verification for tictactoe if label is empty. changes boolean condition to winner if tictactoe condition is met and ends the game. 
    Private Sub lblGrid7_Click(sender As Object, e As EventArgs) Handles lblGrid7.Click
        If lblGrid7.Text = String.Empty Then
            lblGrid7.Text = Player_Change()
            If lblGrid7.Text = lblGrid4.Text And lblGrid7.Text = lblGrid1.Text Then
                blnWinner = True
            ElseIf lblGrid7.Text = lblGrid5.Text And lblGrid7.Text = lblGrid3.Text Then
                blnWinner = True
            ElseIf lblGrid7.Text = lblGrid8.Text And lblGrid7.Text = lblGrid9.Text Then
                blnWinner = True
            End If
            End_Of_Game()
        End If
    End Sub

    ' Click gridlabel8 verification if label is empty. changes boolean to winner if tictactoe condition is met and end the game. 
    Private Sub lblGrid8_Click(sender As Object, e As EventArgs) Handles lblGrid8.Click
        If lblGrid8.Text = String.Empty Then
            lblGrid8.Text = Player_Change()
            If lblGrid8.Text = lblGrid9.Text And lblGrid8.Text = lblGrid7.Text Then
                blnWinner = True
            ElseIf lblGrid8.Text = lblGrid5.Text And lblGrid8.Text = lblGrid2.Text Then
                blnWinner = True
            End If
            End_Of_Game()
        End If
    End Sub

    ' Click gridlabel9 verification if label is empty. changes boolean to winner if tictactoe confition is met and end the game. 
    Private Sub lblGrid9_Click(sender As Object, e As EventArgs) Handles lblGrid9.Click
        If lblGrid9.Text = String.Empty Then
            lblGrid9.Text = Player_Change()
            If lblGrid9.Text = lblGrid8.Text And lblGrid9.Text = lblGrid7.Text Then
                blnWinner = True
            ElseIf lblGrid9.Text = lblGrid6.Text And lblGrid9.Text = lblGrid3.Text Then
                blnWinner = True
            ElseIf lblGrid9.Text = lblGrid5.Text And lblGrid9.Text = lblGrid1.Text Then
                blnWinner = True
            End If
            End_Of_Game()
        End If
    End Sub

    ' Close form if the user has not started any games if not ask the user if he is sure if he wants to quit. 
    Private Sub Closing_Main_Form(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (lblPlayer1GamesWon.Text <> "0" Or lblPlayer2Gameswon.Text <> "0") Or Grid_Content() <> String.Empty Then
            Dim dlgButton As DialogResult
            dlgButton = MessageBox.Show("Are you sure you want to quit this game?" + ControlChars.NewLine + "The total number of wins will also be lost.", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dlgButton = DialogResult.No Then
                e.Cancel = True
            Else
                Record_Books()
            End If
        End If
    End Sub

    ' Edit player 1 name
    Private Sub mnuPlayer1Name_Click(sender As Object, e As EventArgs) Handles mnuPlayer1Name.Click
        Try
            Dim strPlayer1Name As String
            strPlayer1Name = InputBox("Player 1 What is your Name: ", "Player 1 Name", "Player 1 : ")
            lblPlayer1Name.Text = strPlayer1Name.Trim() + " : "
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' edit player 2 name. 
    Private Sub mnuPlayer2Name_Click(sender As Object, e As EventArgs) Handles mnuPlayer2Name.Click
        Try
            Dim strPlayer2Name As String
            strPlayer2Name = InputBox("Player 2 What is your Name: ", "Player 2 Name", "Player 2 : ")
            lblPlayer2Name.Text = strPlayer2Name.Trim() + " : "
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Resets both players wins. 
    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles btnReset.Click, mnuResetScores.Click
        Dim dlgResponse As DialogResult
        dlgResponse = MessageBox.Show("Are you sure you want to reset both players win total? Only games with at least 7 recorded wins will enter the records book!", "Reset Win Count", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If dlgResponse = DialogResult.Yes Then
            Record_Books()
            lblPlayer1GamesWon.Text = "0"
            lblPlayer2Gameswon.Text = "0"
            ' Disable reset button and menu. 
            mnuResetScores.Enabled = False
            btnReset.Enabled = False
        End If
    End Sub

    Private Sub BtnRegle_Click(sender As Object, e As EventArgs) Handles btnRegle.Click
        Dim strRules As String
        strRules = "Rules of TicTacToe" + ControlChars.NewLine + "Turn by turn, each player places an 'X' or an 'O' on the playing grid." + ControlChars.NewLine +
            "The goal is to form a straight line of three 'X's or 'O's in a row." + ControlChars.NewLine + "This can be accomplished horizontaly, vertically, or diagonaly on the playing grid." +
            ControlChars.NewLine + "First player to complete the goal wins the game. The looser will start next round." + ControlChars.NewLine + ControlChars.NewLine + "Note: You can edit your players name through the edit menu for the game to go in the record books!"
        MessageBox.Show(strRules, "Rules", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        Try
            Dim RecordBooks As IO.StreamReader

            If IO.File.Exists("RecordBooks.txt") Then
                Dim strRecordBooksContent As String
                RecordBooks = IO.File.OpenText("RecordBooks.txt")
                strRecordBooksContent = RecordBooks.ReadToEnd()
                MessageBox.Show(strRecordBooksContent, "RecordBooks", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
