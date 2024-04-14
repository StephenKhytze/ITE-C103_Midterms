Public Class GameForm
    Dim playerHP As Integer = 200, enemyHP As Integer, playerAtk As Integer, enemyIndex As Integer = 0, gameRounds As Integer = 0
    Dim enemyAtk As Integer = 15, healUse As Integer = 5, empowerUse As Integer = 3
    Dim enemyHPArray() As Integer = {250, 350, 650, 850, 1000, 0} : Dim playerAtkArray() As Integer = {25, 30, 35, 40, 45, 0}
    Dim charClass As Object = New Character_Class, actionClass As Object = New Action_Class
    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateEnemy()
        UpdateUI()
        My.Computer.Audio.Play(My.Resources.battleMusic1, AudioPlayMode.BackgroundLoop)
        charClass.CharacterImage()
    End Sub
    Private Sub btnAtk_Click(sender As Object, e As EventArgs) Handles btnAtk1.Click
        charClass.CharacterAttack() : actionClass.Disable()
        tmrAnimation.Start()
        tmrHurt.Start()
        If enemyHP > 125 Then
            enemyAtk = 15
            playerHP = actionClass.enemyAttack(enemyAtk, playerHP) : enemyHP = actionClass.characterAttack(playerAtk, enemyHP)
        Else
            enemyAtk = 30
            playerHP = actionClass.enemyAttack(enemyAtk, playerHP) : enemyHP = actionClass.characterAttack(playerAtk, enemyHP)
        End If
        UpdateUI() : UpdateUI()
    End Sub
    Private Sub btnHeal1_Click(sender As Object, e As EventArgs) Handles btnHeal1.Click
        charClass.CharacterEmpower()
        actionClass.Disable()
        tmrAnimation.Start()
        If healUse > 0 Then
            healUse -= 1
            playerHP += 35
            If healUse = 0 Then btnHeal1.Enabled = False
        End If
        UpdateUI()
        actionClass.Enable(healUse, empowerUse)
    End Sub
    Private Sub btnEmpower1_Click(sender As Object, e As EventArgs) Handles btnEmpower1.Click
        charClass.CharacterEmpower()
        actionClass.Disable()
        tmrAnimation.Start()
        tmrHurt.Start()
        If empowerUse > 0 Then
            playerAtk *= 2.5
            playerHP = actionClass.enemyAttack(enemyAtk, playerHP) : enemyHP = actionClass.characterAttack(playerAtk, enemyHP)
            playerAtk /= 2.5
            empowerUse -= 1
            If empowerUse = 0 Then btnEmpower1.Enabled = False
        End If
        UpdateUI() : UpdateUI()
    End Sub
    Private Sub UpdateUI()
        lblHP1.Text = playerHP : lblEnemyHP.Text = enemyHP : lblAtk.Text = playerAtk : lblEmpUse.Text = empowerUse : lblHealUse.Text = healUse
        If playerHP <= 0 Then
            actionClass.Disable() : actionClass.Defeat()
        ElseIf enemyHP <= 0 Then
            storyPanel.Visible = True
            tmrHurt.Stop()
            actionClass.Enable(healUse, empowerUse)
            enemyIndex += 1 : gameRounds += 1 : healUse += 2 : empowerUse += 2
            playerHP += 165
            UpdateEnemy()
        End If
        If gameRounds = 5 Then
            enemyIndex -= 1
            actionClass.Victory()
        End If
    End Sub
    Private Sub UpdateEnemy()
        playerAtk = playerAtkArray(enemyIndex)
        enemyHP = enemyHPArray(enemyIndex)
        actionClass.EnemyUpdate(enemyIndex)
    End Sub
    Private Sub tmrAnimation_Tick(sender As Object, e As EventArgs) Handles tmrAnimation.Tick
        tmrAnimation.Stop()
        charClass.CharacterIdle()
    End Sub
    Private Sub tmrHurt_Tick(sender As Object, e As EventArgs) Handles tmrHurt.Tick
        tmrHurt.Stop()
        charClass.CharacterHurt()
        tmrAnimation.Start()
        actionClass.Enable(healUse, empowerUse)
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        actionClass.StoryLabel(enemyIndex, healUse, empowerUse)
    End Sub
End Class