Public Class rpsFrm

    Friend numPlayer As Integer
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        End
    End Sub

    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click
        helpBtn.Visible = False
        startBtn.Visible = False
        oneBtn.Visible = True
        twoBtn.Visible = True
    End Sub

    Private Sub helpBtn_Click(sender As Object, e As EventArgs) Handles helpBtn.Click
        helpBtn.Visible = False
        startBtn.Visible = False
        exitBtn.Visible = False
        titleLbl.Visible = False
        helpLbl.Visible = True
        helpExitBtn.Visible = True
    End Sub

    Private Sub helpExitBtn_Click(sender As Object, e As EventArgs) Handles helpExitBtn.Click
        helpBtn.Visible = True
        startBtn.Visible = True
        exitBtn.Visible = True
        titleLbl.Visible = True
        helpLbl.Visible = False
        helpExitBtn.Visible = False
    End Sub

    Private Sub oneBtn_Click(sender As Object, e As EventArgs) Handles oneBtn.Click
        numPlayer = 1
        rpsGameFrm.Show()
        Me.Hide()
    End Sub

    Private Sub twoBtn_Click(sender As Object, e As EventArgs) Handles twoBtn.Click
        numPlayer = 2
        rpsGameFrm.Show()
        Me.Hide()
    End Sub
End Class
