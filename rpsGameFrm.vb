Public Class rpsGameFrm

    Private P1Choice As Integer
    Private P1Wins As Integer
    Private P2Choice As Integer
    Private P2Wins As Integer
    Private Turn As Integer
    Private Winner As Integer
    Private TwoP As Boolean

    Private Sub rpsGameFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        P1Wins = 0
        P2Wins = 0
        If rpsFrm.numPlayer = 2 Then
            infoLbl.Text = "Player 1 " & infoLbl.Text
            TwoP = True
        Else
            TwoP = False
        End If
        Turn = 1
    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        winnerPic.Visible = False
        If P1Wins = 2 Then
            Me.BackgroundImage = My.Resources.win_background
            infoLbl.BackColor = Color.Black
            infoLbl.ForeColor = Color.LightGoldenrodYellow
            If TwoP Then
                infoLbl.Text = "Player 1 Wins!"
            Else
                infoLbl.Text = "You Win!"
            End If
            nextBtn.Visible = False
            againBtn.Visible = True
            exitBtn.Visible = True
        ElseIf P2Wins = 2 Then
            If TwoP Then
                Me.BackgroundImage = My.Resources.win_background
                infoLbl.BackColor = Color.Black
                infoLbl.ForeColor = Color.LightGoldenrodYellow
                infoLbl.Text = "Player 2 Wins!"
            Else
                Me.BackgroundImage = My.Resources.lose_background
                infoLbl.BackColor = Color.Black
                infoLbl.ForeColor = Color.LightGoldenrodYellow
                infoLbl.Text = "You Lose!"
            End If
            nextBtn.Visible = False
            againBtn.Visible = True
            exitBtn.Visible = True
        Else
            Me.BackgroundImage = My.Resources.battle_background
            nextBtn.Visible = False
            jediBtn.Visible = True
            jediPic.Visible = True
            bountyBtn.Visible = True
            bountyPic.Visible = True
            sithBtn.Visible = True
            sithPic.Visible = True
            If TwoP Then
                infoLbl.Text = "Player 1 make your choice"
            Else
                infoLbl.Text = "Make your choice"
            End If
        End If
    End Sub

    Private Sub againBtn_Click(sender As Object, e As EventArgs) Handles againBtn.Click
        If againBtn.Visible Then
            P1Wins = 0
            P2Wins = 0
            Me.BackgroundImage = My.Resources.battle_background
            againBtn.Visible = False
            exitBtn.Visible = False
            jediBtn.Visible = True
            jediPic.Visible = True
            bountyBtn.Visible = True
            bountyPic.Visible = True
            sithBtn.Visible = True
            sithPic.Visible = True
            If TwoP Then
                infoLbl.Text = "Player 1 make your choice"
            Else
                infoLbl.Text = "Make your choice"
            End If
            Turn = 1
        Else
            MsgBox("Please finish the game before starting another one", , "Data Input Error")
        End If
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        rpsFrm.Close()
        Me.Close()
    End Sub

    Private Sub jediBtn_Click(sender As Object, e As EventArgs) Handles jediBtn.Click
        If Turn = 1 Then
            P1Choice = 1
            If TwoP Then
                Turn = 2
                infoLbl.Text = "Player 2 make your choice"
            Else
                Randomize()
                P2Choice = Int((Rnd() * 3) + 1)
                jediBtn.Visible = False
                jediPic.Visible = False
                bountyBtn.Visible = False
                bountyPic.Visible = False
                sithBtn.Visible = False
                sithPic.Visible = False
                nextBtn.Visible = True
                If P2Choice = 1 Then
                    Me.BackgroundImage = My.Resources.home_pic
                    infoLbl.Text = "You Tied This Round"
                ElseIf P2Choice = 2 Then
                    Me.BackgroundImage = My.Resources.bounty_background
                    winnerPic.Image = My.Resources.mando_pic
                    winnerPic.Visible = True
                    infoLbl.Text = "The Computer Won This Round"
                    P2Wins = P2Wins + 1
                Else
                    Me.BackgroundImage = My.Resources.jedi_background
                    winnerPic.Image = My.Resources.luke_pic
                    winnerPic.Visible = True
                    infoLbl.Text = "You Won This Round"
                    P1Wins = P1Wins + 1
                End If
            End If
        Else
            Turn = 1
            P2Choice = 1
            jediBtn.Visible = False
            jediPic.Visible = False
            bountyBtn.Visible = False
            bountyPic.Visible = False
            sithBtn.Visible = False
            sithPic.Visible = False
            nextBtn.Visible = True
            If P1Choice = 1 Then
                Me.BackgroundImage = My.Resources.home_pic
                infoLbl.Text = "You Tied This Round"
            ElseIf P1Choice = 2 Then
                Me.BackgroundImage = My.Resources.bounty_background
                winnerPic.Image = My.Resources.mando_pic
                winnerPic.Visible = True
                infoLbl.Text = "Player 1 Won This Round"
                P1Wins = P1Wins + 1
            Else
                Me.BackgroundImage = My.Resources.jedi_background
                winnerPic.Image = My.Resources.luke_pic
                winnerPic.Visible = True
                infoLbl.Text = "Player 2 Won This Round"
                P2Wins = P2Wins + 1
            End If
        End If
    End Sub

    Private Sub bountyBtn_Click(sender As Object, e As EventArgs) Handles bountyBtn.Click
        If Turn = 1 Then
            P1Choice = 2
            If TwoP Then
                Turn = 2
                infoLbl.Text = "Player 2 make your choice"
            Else
                Randomize()
                P2Choice = Int((Rnd() * 3) + 1)
                jediBtn.Visible = False
                jediPic.Visible = False
                bountyBtn.Visible = False
                bountyPic.Visible = False
                sithBtn.Visible = False
                sithPic.Visible = False
                nextBtn.Visible = True
                If P2Choice = 1 Then
                    Me.BackgroundImage = My.Resources.bounty_background
                    winnerPic.Image = My.Resources.mando_pic
                    winnerPic.Visible = True
                    infoLbl.Text = "You Won This Round"
                    P1Wins = P1Wins + 1
                ElseIf P2Choice = 2 Then
                    Me.BackgroundImage = My.Resources.home_pic
                    infoLbl.Text = "You Tied This Round"
                Else
                    Me.BackgroundImage = My.Resources.sith_background
                    winnerPic.Image = My.Resources.darth_pic
                    winnerPic.Visible = True
                    infoLbl.Text = "The Computer Won This Round"
                    P2Wins = P2Wins + 1
                End If
            End If
        Else
            Turn = 1
            P2Choice = 2
            jediBtn.Visible = False
            jediPic.Visible = False
            bountyBtn.Visible = False
            bountyPic.Visible = False
            sithBtn.Visible = False
            sithPic.Visible = False
            nextBtn.Visible = True
            If P1Choice = 1 Then
                Me.BackgroundImage = My.Resources.bounty_background
                winnerPic.Image = My.Resources.mando_pic
                winnerPic.Visible = True
                infoLbl.Text = "Player 2 Won This Round"
                P2Wins = P2Wins + 1
            ElseIf P1Choice = 2 Then
                Me.BackgroundImage = My.Resources.home_pic
                infoLbl.Text = "You Tied This Round"
            Else
                Me.BackgroundImage = My.Resources.sith_background
                winnerPic.Image = My.Resources.darth_pic
                winnerPic.Visible = True
                infoLbl.Text = "Player 1 Won This Round"
                P1Wins = P1Wins + 1
            End If
        End If
    End Sub


    Private Sub sithBtn_Click(sender As Object, e As EventArgs) Handles sithBtn.Click
        If Turn = 1 Then
            P1Choice = 3
            If TwoP Then
                Turn = 2
                infoLbl.Text = "Player 2 make your choice"
            Else
                Randomize()
                P2Choice = Int((Rnd() * 3) + 1)
                jediBtn.Visible = False
                jediPic.Visible = False
                bountyBtn.Visible = False
                bountyPic.Visible = False
                sithBtn.Visible = False
                sithPic.Visible = False
                nextBtn.Visible = True
                If P2Choice = 1 Then
                    Me.BackgroundImage = My.Resources.jedi_background
                    winnerPic.Image = My.Resources.luke_pic
                    winnerPic.Visible = True
                    infoLbl.Text = "The Computer Won This Round"
                    P2Wins = P2Wins + 1
                ElseIf P2Choice = 2 Then
                    Me.BackgroundImage = My.Resources.sith_background
                    winnerPic.Image = My.Resources.darth_pic
                    winnerPic.Visible = True
                    infoLbl.Text = "You Won This Round"
                    P1Wins = P1Wins + 1
                Else
                    Me.BackgroundImage = My.Resources.home_pic
                    infoLbl.Text = "You Tied This Round"
                End If
            End If
        Else
            Turn = 1
            P2Choice = 2
            jediBtn.Visible = False
            jediPic.Visible = False
            bountyBtn.Visible = False
            bountyPic.Visible = False
            sithBtn.Visible = False
            sithPic.Visible = False
            nextBtn.Visible = True
            If P1Choice = 1 Then
                Me.BackgroundImage = My.Resources.jedi_background
                winnerPic.Image = My.Resources.luke_pic
                winnerPic.Visible = True
                infoLbl.Text = "Player 1 Won This Round"
                P1Wins = P1Wins + 1
            ElseIf P1Choice = 2 Then
                Me.BackgroundImage = My.Resources.sith_background
                winnerPic.Image = My.Resources.darth_pic
                winnerPic.Visible = True
                infoLbl.Text = "Player 2 Won This Round"
                P2Wins = P2Wins + 1
            Else
                Me.BackgroundImage = My.Resources.home_pic
                infoLbl.Text = "You Tied This Round"
            End If
        End If
    End Sub

End Class