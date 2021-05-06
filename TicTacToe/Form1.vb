Public Class Form1

    Private intPlayer1Wins As Integer
    Private intPlayer2Wins As Integer
    Private intPlayerTurn As Integer


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
        intPlayerTurn = 1
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
            dlgAnswer = MessageBox.Show("Starting a new game will reset both players wins total back to zero." + ControlChars.NewLine +
                                        "Are you sure you want to start a new game?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dlgAnswer = DialogResult.Yes Then
                Reset_Grid()
                intPlayer1Wins = 0
                intPlayer2Wins = 0
                lblPlayer1GamesWon.Text = intPlayer1Wins.ToString
                lblPlayer2Gameswon.Text = intPlayer2Wins.ToString
            End If
        End If
    End Sub



    Private Function Player_Change() As String
        If intPlayerTurn = 1 Then
            intPlayerTurn = 2
            Return "X"
        Else
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
End Class
