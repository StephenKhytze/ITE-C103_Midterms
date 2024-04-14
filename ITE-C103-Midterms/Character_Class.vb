Public Class Character_Class
    Dim playerMain, playerAttack, playerIdle, playerEmpower, playerHurt, playerDefeat, playerEscape, playerDefeatEnd As Image
    Public Sub CharacterImage()
        If MenuForm.rdoMale.Checked Then
            playerMain = My.Resources.Boy_CloseUp
            playerAttack = My.Resources.Boy_Attack
            playerIdle = My.Resources.Boy_Idle
            playerEmpower = My.Resources.Boy_Empower
            playerHurt = My.Resources.Boy_Hurt
            playerDefeat = My.Resources.Boy_Defeat
            playerEscape = My.Resources.Boy_Escape
            playerDefeatEnd = My.Resources.Boy_DefeatEnd
        ElseIf MenuForm.rdoFemale.Checked Then
            playerMain = My.Resources.Girl_CloseUp
            playerAttack = My.Resources.Girl_Attack
            playerIdle = My.Resources.Girl_Idle
            playerEmpower = My.Resources.Girl_Empower
            playerHurt = My.Resources.Girl_Hurt
            playerDefeat = My.Resources.Girl_Defeat
            playerEscape = My.Resources.Girl_Escape
            playerDefeatEnd = My.Resources.Girl_DefeatEnd
        End If
        MenuForm.imgTutorial.Image = playerMain
        MenuForm.imgEscape.Image = playerEscape
        MenuForm.imgDefeat.Image = playerDefeatEnd
        GameForm.imgPlayer.Image = playerMain
        GameForm.imgCharacter.Image = playerIdle
    End Sub
    Public Sub CharacterIdle()
        GameForm.imgCharacter.Image = playerIdle
    End Sub
    Public Sub CharacterAttack()
        GameForm.imgCharacter.Image = playerAttack
    End Sub
    Public Sub CharacterEmpower()
        GameForm.imgCharacter.Image = playerEmpower
    End Sub
    Public Sub CharacterHurt()
        GameForm.imgCharacter.Image = playerHurt
    End Sub
End Class