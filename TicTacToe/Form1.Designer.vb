<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPlayer1Name = New System.Windows.Forms.Label()
        Me.lblPlayer2Name = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblGrid1 = New System.Windows.Forms.Label()
        Me.lblGrid2 = New System.Windows.Forms.Label()
        Me.lblGrid3 = New System.Windows.Forms.Label()
        Me.lblGrid4 = New System.Windows.Forms.Label()
        Me.lblGrid5 = New System.Windows.Forms.Label()
        Me.lblGrid6 = New System.Windows.Forms.Label()
        Me.lblGrid7 = New System.Windows.Forms.Label()
        Me.lblGrid8 = New System.Windows.Forms.Label()
        Me.lblGrid9 = New System.Windows.Forms.Label()
        Me.lblPlayer1GamesWon = New System.Windows.Forms.Label()
        Me.lblPlayer2Gameswon = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResetScores = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPlayer1Name = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPlayer2Name = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRegle = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 77)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TicTacToe"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer1Name
        '
        Me.lblPlayer1Name.AutoSize = True
        Me.lblPlayer1Name.Location = New System.Drawing.Point(12, 153)
        Me.lblPlayer1Name.Name = "lblPlayer1Name"
        Me.lblPlayer1Name.Size = New System.Drawing.Size(57, 17)
        Me.lblPlayer1Name.TabIndex = 1
        Me.lblPlayer1Name.Text = "Player 1:"
        '
        'lblPlayer2Name
        '
        Me.lblPlayer2Name.AutoSize = True
        Me.lblPlayer2Name.Location = New System.Drawing.Point(12, 186)
        Me.lblPlayer2Name.Name = "lblPlayer2Name"
        Me.lblPlayer2Name.Size = New System.Drawing.Size(57, 17)
        Me.lblPlayer2Name.TabIndex = 2
        Me.lblPlayer2Name.Text = "Player 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Games Won"
        '
        'lblGrid1
        '
        Me.lblGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrid1.Enabled = False
        Me.lblGrid1.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrid1.Location = New System.Drawing.Point(211, 176)
        Me.lblGrid1.Name = "lblGrid1"
        Me.lblGrid1.Size = New System.Drawing.Size(148, 128)
        Me.lblGrid1.TabIndex = 4
        Me.lblGrid1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrid2
        '
        Me.lblGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrid2.Enabled = False
        Me.lblGrid2.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrid2.Location = New System.Drawing.Point(356, 176)
        Me.lblGrid2.Name = "lblGrid2"
        Me.lblGrid2.Size = New System.Drawing.Size(148, 128)
        Me.lblGrid2.TabIndex = 5
        Me.lblGrid2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrid3
        '
        Me.lblGrid3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrid3.Enabled = False
        Me.lblGrid3.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrid3.Location = New System.Drawing.Point(501, 176)
        Me.lblGrid3.Name = "lblGrid3"
        Me.lblGrid3.Size = New System.Drawing.Size(148, 128)
        Me.lblGrid3.TabIndex = 6
        Me.lblGrid3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrid4
        '
        Me.lblGrid4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrid4.Enabled = False
        Me.lblGrid4.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrid4.Location = New System.Drawing.Point(211, 304)
        Me.lblGrid4.Name = "lblGrid4"
        Me.lblGrid4.Size = New System.Drawing.Size(148, 128)
        Me.lblGrid4.TabIndex = 7
        Me.lblGrid4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrid5
        '
        Me.lblGrid5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrid5.Enabled = False
        Me.lblGrid5.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrid5.Location = New System.Drawing.Point(356, 304)
        Me.lblGrid5.Name = "lblGrid5"
        Me.lblGrid5.Size = New System.Drawing.Size(148, 128)
        Me.lblGrid5.TabIndex = 8
        Me.lblGrid5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrid6
        '
        Me.lblGrid6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrid6.Enabled = False
        Me.lblGrid6.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrid6.Location = New System.Drawing.Point(501, 304)
        Me.lblGrid6.Name = "lblGrid6"
        Me.lblGrid6.Size = New System.Drawing.Size(148, 128)
        Me.lblGrid6.TabIndex = 9
        Me.lblGrid6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrid7
        '
        Me.lblGrid7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrid7.Enabled = False
        Me.lblGrid7.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrid7.Location = New System.Drawing.Point(211, 432)
        Me.lblGrid7.Name = "lblGrid7"
        Me.lblGrid7.Size = New System.Drawing.Size(148, 128)
        Me.lblGrid7.TabIndex = 10
        Me.lblGrid7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrid8
        '
        Me.lblGrid8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrid8.Enabled = False
        Me.lblGrid8.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrid8.Location = New System.Drawing.Point(356, 432)
        Me.lblGrid8.Name = "lblGrid8"
        Me.lblGrid8.Size = New System.Drawing.Size(148, 128)
        Me.lblGrid8.TabIndex = 11
        Me.lblGrid8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrid9
        '
        Me.lblGrid9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrid9.Enabled = False
        Me.lblGrid9.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrid9.Location = New System.Drawing.Point(501, 432)
        Me.lblGrid9.Name = "lblGrid9"
        Me.lblGrid9.Size = New System.Drawing.Size(148, 128)
        Me.lblGrid9.TabIndex = 12
        Me.lblGrid9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer1GamesWon
        '
        Me.lblPlayer1GamesWon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayer1GamesWon.Location = New System.Drawing.Point(79, 152)
        Me.lblPlayer1GamesWon.Name = "lblPlayer1GamesWon"
        Me.lblPlayer1GamesWon.Size = New System.Drawing.Size(78, 25)
        Me.lblPlayer1GamesWon.TabIndex = 13
        '
        'lblPlayer2Gameswon
        '
        Me.lblPlayer2Gameswon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayer2Gameswon.Location = New System.Drawing.Point(79, 185)
        Me.lblPlayer2Gameswon.Name = "lblPlayer2Gameswon"
        Me.lblPlayer2Gameswon.Size = New System.Drawing.Size(78, 25)
        Me.lblPlayer2Gameswon.TabIndex = 14
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(833, 536)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(88, 24)
        Me.btnQuit.TabIndex = 15
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(698, 479)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(88, 24)
        Me.btnNewGame.TabIndex = 16
        Me.btnNewGame.Text = "&New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInstructions.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(698, 196)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(223, 209)
        Me.lblInstructions.TabIndex = 17
        '
        'btnReset
        '
        Me.btnReset.Enabled = False
        Me.btnReset.Location = New System.Drawing.Point(65, 304)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(92, 24)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "&Reset Scores"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(933, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.mnuResetScores, Me.QuitToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.FichierToolStripMenuItem.Text = "&Files"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.NewGameToolStripMenuItem.Text = "&New Game"
        '
        'mnuResetScores
        '
        Me.mnuResetScores.Enabled = False
        Me.mnuResetScores.Name = "mnuResetScores"
        Me.mnuResetScores.Size = New System.Drawing.Size(139, 22)
        Me.mnuResetScores.Text = "&Reset Scores"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.QuitToolStripMenuItem.Text = "&Quit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPlayer1Name, Me.mnuPlayer2Name})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'mnuPlayer1Name
        '
        Me.mnuPlayer1Name.Name = "mnuPlayer1Name"
        Me.mnuPlayer1Name.Size = New System.Drawing.Size(150, 22)
        Me.mnuPlayer1Name.Text = "Player &1 Name"
        '
        'mnuPlayer2Name
        '
        Me.mnuPlayer2Name.Name = "mnuPlayer2Name"
        Me.mnuPlayer2Name.Size = New System.Drawing.Size(150, 22)
        Me.mnuPlayer2Name.Text = "Player &2 Name"
        '
        'btnRecords
        '
        Me.btnRecords.Location = New System.Drawing.Point(833, 479)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(88, 24)
        Me.btnRecords.TabIndex = 20
        Me.btnRecords.Text = "&Records"
        Me.btnRecords.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(698, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Game Master:"
        '
        'btnRegle
        '
        Me.btnRegle.Location = New System.Drawing.Point(698, 536)
        Me.btnRegle.Name = "btnRegle"
        Me.btnRegle.Size = New System.Drawing.Size(88, 24)
        Me.btnRegle.TabIndex = 22
        Me.btnRegle.Text = "&Rules"
        Me.btnRegle.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(933, 588)
        Me.Controls.Add(Me.btnRegle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRecords)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblPlayer2Gameswon)
        Me.Controls.Add(Me.lblPlayer1GamesWon)
        Me.Controls.Add(Me.lblGrid9)
        Me.Controls.Add(Me.lblGrid8)
        Me.Controls.Add(Me.lblGrid7)
        Me.Controls.Add(Me.lblGrid6)
        Me.Controls.Add(Me.lblGrid5)
        Me.Controls.Add(Me.lblGrid4)
        Me.Controls.Add(Me.lblGrid3)
        Me.Controls.Add(Me.lblGrid2)
        Me.Controls.Add(Me.lblGrid1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPlayer2Name)
        Me.Controls.Add(Me.lblPlayer1Name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "TicTacToe"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPlayer1Name As Label
    Friend WithEvents lblPlayer2Name As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblGrid1 As Label
    Friend WithEvents lblGrid2 As Label
    Friend WithEvents lblGrid3 As Label
    Friend WithEvents lblGrid4 As Label
    Friend WithEvents lblGrid5 As Label
    Friend WithEvents lblGrid6 As Label
    Friend WithEvents lblGrid7 As Label
    Friend WithEvents lblGrid8 As Label
    Friend WithEvents lblGrid9 As Label
    Friend WithEvents lblPlayer1GamesWon As Label
    Friend WithEvents lblPlayer2Gameswon As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnNewGame As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuResetScores As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuPlayer1Name As ToolStripMenuItem
    Friend WithEvents mnuPlayer2Name As ToolStripMenuItem
    Friend WithEvents btnRecords As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRegle As Button
End Class
