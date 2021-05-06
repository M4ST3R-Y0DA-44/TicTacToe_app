' TicTacToe
' Program made to practice my newly learned skills. 
' M4ST3R Y0DA 44 on 05 may 2021

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1

    Private intPlayer1Wins As Integer
    Private intPlayer2Wins As Integer
    Private intPlayerTurn As Integer

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInstructions.Text = "Welcome to TicTacToe" + ControlChars.NewLine + "Please press on New Game to start!"
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    ' Retrieves the content of the tictactoe grid to validate if the game has been started or not. 
    Private Function Grid_Content() As String
        Dim strContentOfGrid As String
        strContentOfGrid = lblGrid1.Text + lblGrid2.Text + lblGrid3.Text + lblGrid4.Text + lblGrid5.Text + lblGrid6.Text + lblGrid7.Text +
            lblGrid8.Text + lblGrid9.Text
        Return strContentOfGrid
    End Function

    ' Resets a single game of tic tac toe or initializes the game if the games wasnt started. 
    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        If Grid_Content() <> String.Empty Then
            Dim dlgAnswer As DialogResult
            dlgAnswer = MessageBox.Show("Starting a new game will reset both players wins total back to zero." + ControlChars.NewLine +
                                        "Are you sure you want to start a new game?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dlgAnswer = DialogResult.Yes Then
                intPlayerTurn = 1
                lblInstructions.Text = "It's your turn Player 1 (X)"
                Reset_Grid()
            End If
        Else
            Activate_Grid_Labels()
            intPlayerTurn = 1
            lblInstructions.Text = "It's your turn Player 1 (X)"
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

    ' Changes the players turns after each player clicks the tictactoe grid to play a turn. Returns the string for the grid and tells the other player to play.
    Private Function Player_Change() As String
        If intPlayerTurn = 1 Then
            lblInstructions.Text = "It's your turn Player 2 (O)"
            intPlayerTurn = 2
            Return "X"
        Else
            lblInstructions.Text = "It's your turn Player 1 (X)"
            intPlayerTurn = 1
            Return "O"
        End If
    End Function

    Private Sub lblGrid1_Click(sender As Object, e As EventArgs) Handles lblGrid1.Click
        If lblGrid1.Text = String.Empty Then
            lblGrid1.Text = Player_Change()
        End If
    End Sub

    Private Sub lblGrid2_Click(sender As Object, e As EventArgs) Handles lblGrid2.Click
        If lblGrid2.Text = String.Empty Then
            lblGrid2.Text = Player_Change()
        End If
    End Sub

    Private Sub lblGrid3_Click(sender As Object, e As EventArgs) Handles lblGrid3.Click
        If lblGrid3.Text = String.Empty Then
            lblGrid3.Text = Player_Change()
        End If
    End Sub

    Private Sub lblGrid4_Click(sender As Object, e As EventArgs) Handles lblGrid4.Click
        If lblGrid4.Text = String.Empty Then
            lblGrid4.Text = Player_Change()
        End If
    End Sub

    Private Sub lblGrid5_Click(sender As Object, e As EventArgs) Handles lblGrid5.Click
        If lblGrid5.Text = String.Empty Then
            lblGrid5.Text = Player_Change()
        End If
    End Sub

    Private Sub lblGrid6_Click(sender As Object, e As EventArgs) Handles lblGrid6.Click
        If lblGrid6.Text = String.Empty Then
            lblGrid6.Text = Player_Change()
        End If
    End Sub

    Private Sub lblGrid7_Click(sender As Object, e As EventArgs) Handles lblGrid7.Click
        If lblGrid7.Text = String.Empty Then
            lblGrid7.Text = Player_Change()
        End If

    End Sub

    Private Sub lblGrid8_Click(sender As Object, e As EventArgs) Handles lblGrid8.Click
        If lblGrid8.Text = String.Empty Then
            lblGrid8.Text = Player_Change()
        End If
    End Sub

    Private Sub lblGrid9_Click(sender As Object, e As EventArgs) Handles lblGrid9.Click
        If lblGrid9.Text = String.Empty Then
            lblGrid9.Text = Player_Change()
        End If
    End Sub

    ' Close form if the user has not started any games if not ask the user if he is sure if he wants to quit. 
    Private Sub Closing_Main_Form(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If intPlayer1Wins = 0 And intPlayer2Wins = 0 And Grid_Content() = String.Empty Then

        Else
            Dim dlgButton As DialogResult
            dlgButton = MessageBox.Show("Are you sure you want to quit this game?" + ControlChars.NewLine + "The total number of wins will also be lost.", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dlgButton = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class
