Public Class Form1

    Private intPlayer1Wins As Integer
    Private intPlayer2Wins As Integer

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
        intPlayer1Wins = 0
        intPlayer2Wins = 0
        lblPlayer1GamesWon.Text = intPlayer1Wins.ToString
        lblPlayer2Gameswon.Text = intPlayer2Wins.ToString

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Dim strContentOfGrid As String
        strContentOfGrid = lblGrid1.Text + lblGrid2.Text + lblGrid3.Text + lblGrid4.Text + lblGrid5.Text + lblGrid6.Text + lblGrid7.Text +
            lblGrid8.Text + lblGrid9.Text
        If strContentOfGrid <> String.Empty Then
            Dim dlgAnswer As DialogResult
            dlgAnswer = MessageBox.Show("New Game", "Starting a new game will reset both players wins total back to zero." + ControlChars.NewLine +
                                        "Are you sure you want to start a new game?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dlgAnswer = DialogResult.Yes Then
                Reset_Grid()
                intPlayer1Wins = 0
                intPlayer2Wins = 0
                lblPlayer1GamesWon.Text = intPlayer1Wins.ToString
                lblPlayer2Gameswon.Text = intPlayer2Wins.ToString
            End If
        End If
    End Sub
End Class
