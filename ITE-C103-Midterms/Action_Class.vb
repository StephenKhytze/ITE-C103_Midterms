Public Class Action_Class
    Dim storyIndex As Integer
    Dim charClass As Object = New Character_Class
    Public Function characterAttack(ByVal playerAtk As Integer, ByVal enemyHP As Integer)
        enemyHP -= playerAtk
        Return enemyHP
    End Function
    Public Function enemyAttack(ByVal enemyAtk As Integer, ByVal playerHP As Integer)
        playerHP -= enemyAtk
        Return playerHP
    End Function
    Public Sub Enable(ByVal healUse As Integer, ByVal empowerUse As Integer)
        GameForm.btnAtk1.Enabled = True
        If healUse > 0 Then GameForm.btnHeal1.Enabled = True
        If empowerUse > 0 Then GameForm.btnEmpower1.Enabled = True
    End Sub
    Public Sub Disable()
        GameForm.btnAtk1.Enabled = False
        GameForm.btnHeal1.Enabled = False
        GameForm.btnEmpower1.Enabled = False
    End Sub
    Public Sub Victory()
        GameForm.Dispose()
        MenuForm.Show()
        My.Computer.Audio.Play(My.Resources.victoryMusic1, AudioPlayMode.BackgroundLoop)
        MenuForm.tabMenu.SelectedIndex += 1
    End Sub
    Public Sub Defeat()
        GameForm.Dispose()
        MenuForm.Show()
        My.Computer.Audio.Play(My.Resources.defeatMusic1, AudioPlayMode.BackgroundLoop)
        MenuForm.tabMenu.SelectedIndex += 2
    End Sub
    Public Sub EnemyUpdate(ByVal enemyIndex As Integer)
        Select Case enemyIndex
            Case 0

                GameForm.imgEnemy.Image = My.Resources.pixel_art_skeleton : MenuForm.imgEndEnemy.Image = My.Resources.pixel_art_skeleton
            Case 1
                Disable()
                GameForm.lblStory.Text = "After defeating the demon that dragged you into hell, you stumbled upon a manticore."
                GameForm.imgEnemy.Image = My.Resources.manticore : MenuForm.imgEndEnemy.Image = My.Resources.manticore
            Case 2
                Disable()
                GameForm.lblStory.Text = "After the manticore died, you felt the ground rumbling."
                GameForm.imgEnemy.Image = My.Resources.skull_dragon1 : MenuForm.imgEndEnemy.Image = My.Resources.skull_dragon1
            Case 3
                Disable()
                GameForm.lblStory.Text = "The skeletal dragon crumbled into pieces after its defeat. A blood-curdling screech could be heard from the distance."
                GameForm.imgEnemy.Image = My.Resources.undead_dragon : MenuForm.imgEndEnemy.Image = My.Resources.undead_dragon
            Case 4
                Disable()
                GameForm.lblStory.Text = "After defeating the undead dragon, you felt an ominous presence from a distance."
                GameForm.imgEnemy.Image = My.Resources.hell_horse : MenuForm.imgEndEnemy.Image = My.Resources.hell_horse
        End Select
    End Sub
    Public Sub StoryLabel(ByVal enemyIndex As Integer, ByVal healUse As Integer, ByVal empowerUse As Integer)
        storyIndex += 1
        Select Case enemyIndex
            Case 1
                Select Case storyIndex
                    Case 0
                        GameForm.lblStory.Text = "It immediately felt your presence, it started to creep towards you while keeping its vicious eyes on you."
                    Case 1
                        GameForm.lblStory.Text = "It let out a mighty roar that alerted several other demons in the area."
                    Case 2
                        Enable(healUse, empowerUse)
                        GameForm.storyPanel.Visible = False
                End Select
            Case 2
                Select Case storyIndex
                    Case 3
                        GameForm.lblStory.Text = "It came from a large, skeletal dragon whose steps made the ground shake."
                    Case 4
                        GameForm.lblStory.Text = "When it spotted you, it started to made it's way towards you, making the the ground around it shake with every step it takes."
                    Case 5
                        Enable(healUse, empowerUse)
                        GameForm.storyPanel.Visible = False
                End Select
            Case 3
                Select Case storyIndex
                    Case 6
                        GameForm.lblStory.Text = "An undead dragon flew its way over to were you were, its flight was messy because Of it's damaged wings."
                    Case 7
                        GameForm.lblStory.Text = "When it landed, it set it's eyes on you and let out another screech."
                    Case 8
                        Enable(healUse, empowerUse)
                        GameForm.storyPanel.Visible = False
                End Select
            Case 4
                Select Case storyIndex
                    Case 9
                        GameForm.lblStory.Text = "You heard what seemed to be a horse neighing, but in a much lower, deeper pitch."
                    Case 10
                        GameForm.lblStory.Text = "After a while, you felt the ground shaking as a large, demonic-looking horse started running to your direction."
                    Case 11
                        GameForm.lblStory.Text = "This creature felt more powerful than the rest of the demons you've faced."
                    Case 12
                        GameForm.lblStory.Text = "This was it, the final obstacle that stands between you and your escape from this hell."
                    Case 13
                        Enable(healUse, empowerUse)
                        GameForm.storyPanel.Visible = False
                End Select
        End Select
    End Sub
End Class