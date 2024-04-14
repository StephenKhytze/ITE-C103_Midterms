Public Class MenuForm
    Dim textboxIndex As Integer = 0
    Dim tutorialTextboxIndex As Integer = 0
    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnStart2.Visible = False
        My.Computer.Audio.Play(My.Resources.menuMusic1, AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tabMenu.SelectedTab = CharacterTab
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If textboxIndex < 3 Then
            Select Case textboxIndex
                Case 0
                    lblStory2.Visible = True
                Case 1
                    lblStory3.Visible = True
                    btnNext.Visible = False
                    btnStart2.Visible = True
            End Select
        End If
        textboxIndex += 1
    End Sub

    Private Sub btnCharSelect_Click(sender As Object, e As EventArgs) Handles btnCharSelect.Click
        tabMenu.SelectedIndex += 1
    End Sub

    Private Sub btnStart2_Click(sender As Object, e As EventArgs) Handles btnStart2.Click
        tabMenu.SelectedTab = TutorialTab
    End Sub
    Private Sub btnTutorialNext_Click(sender As Object, e As EventArgs) Handles btnTutorialNext.Click
        If tutorialTextboxIndex < 7 Then
            Select Case tutorialTextboxIndex
                Case 0
                    lblTutHeal.Visible = True
                Case 1
                    lblTutEmpower.Visible = True
                Case 2
                    lblUsage.Visible = True
                Case 3
                    lblTutHp.Visible = True
                Case 4
                    lblTutAtkDisplay.Visible = True
                Case 5
                    lblTutEnemyHP.Visible = True
                Case 6
                    lblExtra.Visible = True
                    lblExtraInfo.Visible = True
                    btnGameStart.Visible = True
            End Select
        End If
        tutorialTextboxIndex += 1
    End Sub
    Private Sub btnGameStart_Click(sender As Object, e As EventArgs) Handles btnGameStart.Click
        GameForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnReturnMenu1_Click(sender As Object, e As EventArgs) Handles btnReturnMenu1.Click
        tabMenu.SelectedTab = MenuTab
        My.Computer.Audio.Play(My.Resources.menuMusic1, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnReturnMenu2_Click(sender As Object, e As EventArgs) Handles btnReturnMenu2.Click
        tabMenu.SelectedTab = MenuTab
        My.Computer.Audio.Play(My.Resources.menuMusic1, AudioPlayMode.BackgroundLoop)
    End Sub
End Class