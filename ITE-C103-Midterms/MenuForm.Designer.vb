<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        tabMenu = New TabControl()
        MenuTab = New TabPage()
        btnStart = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        CharacterTab = New TabPage()
        btnCharSelect = New PictureBox()
        rdoFemale = New RadioButton()
        rdoMale = New RadioButton()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        StoryTab = New TabPage()
        btnNext = New PictureBox()
        btnStart2 = New PictureBox()
        lblStory3 = New Label()
        lblStory2 = New Label()
        lblStory1 = New Label()
        TutorialTab = New TabPage()
        lblExtraInfo = New Label()
        lblExtra = New Label()
        lblUsage = New Label()
        btnGameStart = New PictureBox()
        lblTutEnemyHP = New Label()
        Label3 = New Label()
        lblEnemyHP = New Label()
        btnTutorialNext = New PictureBox()
        lblTutAtkDisplay = New Label()
        lblTutHp = New Label()
        lblTutEmpower = New Label()
        lblTutHeal = New Label()
        lblTutAtk = New Label()
        Panel1 = New Panel()
        lblHealUse = New Label()
        lblEmpUse = New Label()
        Label9 = New Label()
        Label4 = New Label()
        lblTutorialAtk = New Label()
        Label2 = New Label()
        lblTutorialHP = New Label()
        Label1 = New Label()
        imgTutorial = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox7 = New PictureBox()
        VictoryTab = New TabPage()
        btnReturnMenu1 = New PictureBox()
        Label5 = New Label()
        imgEscape = New PictureBox()
        Defeat = New TabPage()
        imgEndEnemy = New PictureBox()
        Label6 = New Label()
        btnReturnMenu2 = New PictureBox()
        imgDefeat = New PictureBox()
        tabMenu.SuspendLayout()
        MenuTab.SuspendLayout()
        CType(btnStart, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CharacterTab.SuspendLayout()
        CType(btnCharSelect, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        StoryTab.SuspendLayout()
        CType(btnNext, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnStart2, ComponentModel.ISupportInitialize).BeginInit()
        TutorialTab.SuspendLayout()
        CType(btnGameStart, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnTutorialNext, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(imgTutorial, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        VictoryTab.SuspendLayout()
        CType(btnReturnMenu1, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgEscape, ComponentModel.ISupportInitialize).BeginInit()
        Defeat.SuspendLayout()
        CType(imgEndEnemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnReturnMenu2, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgDefeat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tabMenu
        ' 
        tabMenu.Controls.Add(MenuTab)
        tabMenu.Controls.Add(CharacterTab)
        tabMenu.Controls.Add(StoryTab)
        tabMenu.Controls.Add(TutorialTab)
        tabMenu.Controls.Add(VictoryTab)
        tabMenu.Controls.Add(Defeat)
        tabMenu.Location = New Point(-2, -23)
        tabMenu.Name = "tabMenu"
        tabMenu.SelectedIndex = 0
        tabMenu.Size = New Size(1907, 1064)
        tabMenu.TabIndex = 0
        ' 
        ' MenuTab
        ' 
        MenuTab.BackgroundImage = My.Resources.Resources.hell_dark__1_
        MenuTab.BackgroundImageLayout = ImageLayout.Stretch
        MenuTab.Controls.Add(btnStart)
        MenuTab.Controls.Add(PictureBox3)
        MenuTab.Controls.Add(PictureBox2)
        MenuTab.Controls.Add(PictureBox1)
        MenuTab.Location = New Point(4, 24)
        MenuTab.Name = "MenuTab"
        MenuTab.Padding = New Padding(3)
        MenuTab.Size = New Size(1899, 1036)
        MenuTab.TabIndex = 0
        MenuTab.Text = "Menu"
        MenuTab.UseVisualStyleBackColor = True
        ' 
        ' btnStart
        ' 
        btnStart.Cursor = Cursors.Hand
        btnStart.Image = My.Resources.Resources.Start_Button__1_
        btnStart.Location = New Point(721, 762)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(465, 197)
        btnStart.SizeMode = PictureBoxSizeMode.Zoom
        btnStart.TabIndex = 3
        btnStart.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Escape_from_hell
        PictureBox3.Location = New Point(659, 401)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(589, 61)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Arnoux
        PictureBox2.Location = New Point(710, 190)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(487, 112)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Arnoux_logo
        PictureBox1.Location = New Point(801, 77)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(305, 305)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' CharacterTab
        ' 
        CharacterTab.BackgroundImage = CType(resources.GetObject("CharacterTab.BackgroundImage"), Image)
        CharacterTab.BackgroundImageLayout = ImageLayout.Stretch
        CharacterTab.Controls.Add(btnCharSelect)
        CharacterTab.Controls.Add(rdoFemale)
        CharacterTab.Controls.Add(rdoMale)
        CharacterTab.Controls.Add(PictureBox6)
        CharacterTab.Controls.Add(PictureBox5)
        CharacterTab.Controls.Add(PictureBox4)
        CharacterTab.Location = New Point(4, 24)
        CharacterTab.Name = "CharacterTab"
        CharacterTab.Padding = New Padding(3)
        CharacterTab.Size = New Size(1899, 1036)
        CharacterTab.TabIndex = 1
        CharacterTab.Text = "Character"
        CharacterTab.UseVisualStyleBackColor = True
        ' 
        ' btnCharSelect
        ' 
        btnCharSelect.Cursor = Cursors.Hand
        btnCharSelect.Image = My.Resources.Resources._Select
        btnCharSelect.Location = New Point(756, 829)
        btnCharSelect.Name = "btnCharSelect"
        btnCharSelect.Size = New Size(389, 179)
        btnCharSelect.SizeMode = PictureBoxSizeMode.Zoom
        btnCharSelect.TabIndex = 5
        btnCharSelect.TabStop = False
        ' 
        ' rdoFemale
        ' 
        rdoFemale.AutoSize = True
        rdoFemale.Font = New Font("Upheaval TT (BRK)", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdoFemale.ForeColor = Color.Maroon
        rdoFemale.Location = New Point(1079, 667)
        rdoFemale.Name = "rdoFemale"
        rdoFemale.Size = New Size(418, 90)
        rdoFemale.TabIndex = 4
        rdoFemale.Text = "FEMALE"
        rdoFemale.UseVisualStyleBackColor = True
        ' 
        ' rdoMale
        ' 
        rdoMale.AutoSize = True
        rdoMale.Checked = True
        rdoMale.Font = New Font("Upheaval TT (BRK)", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdoMale.ForeColor = Color.Maroon
        rdoMale.Location = New Point(461, 667)
        rdoMale.Name = "rdoMale"
        rdoMale.Size = New Size(300, 90)
        rdoMale.TabIndex = 3
        rdoMale.TabStop = True
        rdoMale.Text = "MALE"
        rdoMale.UseVisualStyleBackColor = True
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.Girl_MainSprite
        PictureBox6.Location = New Point(1056, 196)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(465, 465)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 2
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.Choose_Your_Character
        PictureBox5.Location = New Point(10, 11)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(1880, 91)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 1
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.Boy_MainSprite
        PictureBox4.Location = New Point(379, 196)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(465, 465)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' StoryTab
        ' 
        StoryTab.BackgroundImage = CType(resources.GetObject("StoryTab.BackgroundImage"), Image)
        StoryTab.BackgroundImageLayout = ImageLayout.Stretch
        StoryTab.Controls.Add(btnNext)
        StoryTab.Controls.Add(btnStart2)
        StoryTab.Controls.Add(lblStory3)
        StoryTab.Controls.Add(lblStory2)
        StoryTab.Controls.Add(lblStory1)
        StoryTab.Location = New Point(4, 24)
        StoryTab.Name = "StoryTab"
        StoryTab.Padding = New Padding(3)
        StoryTab.Size = New Size(1899, 1036)
        StoryTab.TabIndex = 2
        StoryTab.Text = "Story"
        StoryTab.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Cursor = Cursors.Hand
        btnNext.Image = CType(resources.GetObject("btnNext.Image"), Image)
        btnNext.Location = New Point(1722, 880)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(142, 121)
        btnNext.SizeMode = PictureBoxSizeMode.Zoom
        btnNext.TabIndex = 5
        btnNext.TabStop = False
        ' 
        ' btnStart2
        ' 
        btnStart2.Cursor = Cursors.Hand
        btnStart2.Image = My.Resources.Resources.Start_Button__1_
        btnStart2.Location = New Point(703, 804)
        btnStart2.Name = "btnStart2"
        btnStart2.Size = New Size(465, 197)
        btnStart2.SizeMode = PictureBoxSizeMode.Zoom
        btnStart2.TabIndex = 4
        btnStart2.TabStop = False
        ' 
        ' lblStory3
        ' 
        lblStory3.Font = New Font("Upheaval TT (BRK)", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStory3.ForeColor = Color.DarkOrange
        lblStory3.Location = New Point(295, 514)
        lblStory3.Name = "lblStory3"
        lblStory3.Size = New Size(1316, 231)
        lblStory3.TabIndex = 2
        lblStory3.Text = resources.GetString("lblStory3.Text")
        lblStory3.TextAlign = ContentAlignment.MiddleCenter
        lblStory3.Visible = False
        ' 
        ' lblStory2
        ' 
        lblStory2.Font = New Font("Upheaval TT (BRK)", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStory2.ForeColor = Color.DarkOrange
        lblStory2.Location = New Point(295, 258)
        lblStory2.Name = "lblStory2"
        lblStory2.Size = New Size(1316, 188)
        lblStory2.TabIndex = 1
        lblStory2.Text = "As it turns out, a mischievious demon has came into the surface to drag an innocent bystander to hell in order to kill them. Unfortunately for you, you became it's target" & vbCrLf
        lblStory2.TextAlign = ContentAlignment.MiddleCenter
        lblStory2.Visible = False
        ' 
        ' lblStory1
        ' 
        lblStory1.Font = New Font("Upheaval TT (BRK)", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStory1.ForeColor = Color.DarkOrange
        lblStory1.Location = New Point(295, 43)
        lblStory1.Name = "lblStory1"
        lblStory1.Size = New Size(1316, 147)
        lblStory1.TabIndex = 0
        lblStory1.Text = "One day, you were walking back home from your adventure when all of the sudden you have been dragged in to hell." & vbCrLf
        lblStory1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TutorialTab
        ' 
        TutorialTab.BackgroundImage = CType(resources.GetObject("TutorialTab.BackgroundImage"), Image)
        TutorialTab.BackgroundImageLayout = ImageLayout.Stretch
        TutorialTab.Controls.Add(lblExtraInfo)
        TutorialTab.Controls.Add(lblExtra)
        TutorialTab.Controls.Add(lblUsage)
        TutorialTab.Controls.Add(btnGameStart)
        TutorialTab.Controls.Add(lblTutEnemyHP)
        TutorialTab.Controls.Add(Label3)
        TutorialTab.Controls.Add(lblEnemyHP)
        TutorialTab.Controls.Add(btnTutorialNext)
        TutorialTab.Controls.Add(lblTutAtkDisplay)
        TutorialTab.Controls.Add(lblTutHp)
        TutorialTab.Controls.Add(lblTutEmpower)
        TutorialTab.Controls.Add(lblTutHeal)
        TutorialTab.Controls.Add(lblTutAtk)
        TutorialTab.Controls.Add(Panel1)
        TutorialTab.Location = New Point(4, 24)
        TutorialTab.Name = "TutorialTab"
        TutorialTab.Padding = New Padding(3)
        TutorialTab.Size = New Size(1899, 1036)
        TutorialTab.TabIndex = 4
        TutorialTab.Text = "Tutorial"
        TutorialTab.UseVisualStyleBackColor = True
        ' 
        ' lblExtraInfo
        ' 
        lblExtraInfo.Font = New Font("Upheaval TT (BRK)", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblExtraInfo.ForeColor = Color.LightCoral
        lblExtraInfo.Location = New Point(24, 76)
        lblExtraInfo.Name = "lblExtraInfo"
        lblExtraInfo.Size = New Size(606, 477)
        lblExtraInfo.TabIndex = 15
        lblExtraInfo.Text = resources.GetString("lblExtraInfo.Text")
        lblExtraInfo.TextAlign = ContentAlignment.MiddleLeft
        lblExtraInfo.Visible = False
        ' 
        ' lblExtra
        ' 
        lblExtra.Font = New Font("Upheaval TT (BRK)", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblExtra.ForeColor = Color.LightCoral
        lblExtra.Location = New Point(24, 26)
        lblExtra.Name = "lblExtra"
        lblExtra.Size = New Size(371, 38)
        lblExtra.TabIndex = 14
        lblExtra.Text = "Extra Information:"
        lblExtra.TextAlign = ContentAlignment.MiddleCenter
        lblExtra.Visible = False
        ' 
        ' lblUsage
        ' 
        lblUsage.Font = New Font("Upheaval TT (BRK)", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsage.ForeColor = Color.LightCoral
        lblUsage.Location = New Point(1125, 572)
        lblUsage.Name = "lblUsage"
        lblUsage.Size = New Size(198, 249)
        lblUsage.TabIndex = 13
        lblUsage.Text = "E: Empower usage left" & vbCrLf & "H: Heal usage left" & vbCrLf & "|"
        lblUsage.TextAlign = ContentAlignment.MiddleCenter
        lblUsage.Visible = False
        ' 
        ' btnGameStart
        ' 
        btnGameStart.Cursor = Cursors.Hand
        btnGameStart.Image = My.Resources.Resources.Start_Button__1_
        btnGameStart.Location = New Point(1555, 462)
        btnGameStart.Name = "btnGameStart"
        btnGameStart.Size = New Size(333, 161)
        btnGameStart.SizeMode = PictureBoxSizeMode.Zoom
        btnGameStart.TabIndex = 12
        btnGameStart.TabStop = False
        btnGameStart.Visible = False
        ' 
        ' lblTutEnemyHP
        ' 
        lblTutEnemyHP.Font = New Font("Upheaval TT (BRK)", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTutEnemyHP.ForeColor = Color.LightCoral
        lblTutEnemyHP.Location = New Point(666, 114)
        lblTutEnemyHP.Name = "lblTutEnemyHP"
        lblTutEnemyHP.Size = New Size(287, 106)
        lblTutEnemyHP.TabIndex = 11
        lblTutEnemyHP.Text = "The enemy's  -" & vbCrLf & "current HP. "
        lblTutEnemyHP.TextAlign = ContentAlignment.MiddleCenter
        lblTutEnemyHP.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Upheaval TT (BRK)", 56.25F)
        Label3.ForeColor = Color.LightCoral
        Label3.Location = New Point(959, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(457, 67)
        Label3.TabIndex = 10
        Label3.Text = "Enemy's HP:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEnemyHP
        ' 
        lblEnemyHP.Font = New Font("Upheaval TT (BRK)", 56.25F)
        lblEnemyHP.ForeColor = Color.LightCoral
        lblEnemyHP.Location = New Point(959, 128)
        lblEnemyHP.Name = "lblEnemyHP"
        lblEnemyHP.Size = New Size(165, 58)
        lblEnemyHP.TabIndex = 9
        lblEnemyHP.Text = "250"
        lblEnemyHP.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnTutorialNext
        ' 
        btnTutorialNext.Cursor = Cursors.Hand
        btnTutorialNext.Image = My.Resources.Resources.button
        btnTutorialNext.Location = New Point(1748, 482)
        btnTutorialNext.Name = "btnTutorialNext"
        btnTutorialNext.Size = New Size(142, 121)
        btnTutorialNext.SizeMode = PictureBoxSizeMode.Zoom
        btnTutorialNext.TabIndex = 8
        btnTutorialNext.TabStop = False
        ' 
        ' lblTutAtkDisplay
        ' 
        lblTutAtkDisplay.Font = New Font("Upheaval TT (BRK)", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTutAtkDisplay.ForeColor = Color.LightCoral
        lblTutAtkDisplay.Location = New Point(1640, 662)
        lblTutAtkDisplay.Name = "lblTutAtkDisplay"
        lblTutAtkDisplay.Size = New Size(230, 162)
        lblTutAtkDisplay.TabIndex = 5
        lblTutAtkDisplay.Text = "The player's attack power" & vbCrLf & "|"
        lblTutAtkDisplay.TextAlign = ContentAlignment.MiddleCenter
        lblTutAtkDisplay.Visible = False
        ' 
        ' lblTutHp
        ' 
        lblTutHp.Font = New Font("Upheaval TT (BRK)", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTutHp.ForeColor = Color.LightCoral
        lblTutHp.Location = New Point(1428, 634)
        lblTutHp.Name = "lblTutHp"
        lblTutHp.Size = New Size(230, 187)
        lblTutHp.TabIndex = 4
        lblTutHp.Text = "The player's current Health Points (HP)" & vbCrLf & "|"
        lblTutHp.TextAlign = ContentAlignment.MiddleCenter
        lblTutHp.Visible = False
        ' 
        ' lblTutEmpower
        ' 
        lblTutEmpower.Font = New Font("Upheaval TT (BRK)", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTutEmpower.ForeColor = Color.LightCoral
        lblTutEmpower.Location = New Point(784, 662)
        lblTutEmpower.Name = "lblTutEmpower"
        lblTutEmpower.Size = New Size(340, 162)
        lblTutEmpower.TabIndex = 3
        lblTutEmpower.Text = "Deals 2.5x of your attack damage, can only be used 3 times." & vbCrLf & "|" & vbCrLf
        lblTutEmpower.TextAlign = ContentAlignment.MiddleCenter
        lblTutEmpower.Visible = False
        ' 
        ' lblTutHeal
        ' 
        lblTutHeal.Font = New Font("Upheaval TT (BRK)", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTutHeal.ForeColor = Color.LightCoral
        lblTutHeal.Location = New Point(408, 662)
        lblTutHeal.Name = "lblTutHeal"
        lblTutHeal.Size = New Size(340, 163)
        lblTutHeal.TabIndex = 2
        lblTutHeal.Text = "heals a set amount of hp, can only be used 5 times. " & vbCrLf & "|"
        lblTutHeal.TextAlign = ContentAlignment.MiddleCenter
        lblTutHeal.Visible = False
        ' 
        ' lblTutAtk
        ' 
        lblTutAtk.Font = New Font("Upheaval TT (BRK)", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTutAtk.ForeColor = Color.LightCoral
        lblTutAtk.Location = New Point(24, 697)
        lblTutAtk.Name = "lblTutAtk"
        lblTutAtk.Size = New Size(340, 126)
        lblTutAtk.TabIndex = 1
        lblTutAtk.Text = "deals a set amount of damage to the enemy. " & vbCrLf & "|" & vbCrLf
        lblTutAtk.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lblHealUse)
        Panel1.Controls.Add(lblEmpUse)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblTutorialAtk)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(lblTutorialHP)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(imgTutorial)
        Panel1.Controls.Add(PictureBox9)
        Panel1.Controls.Add(PictureBox8)
        Panel1.Controls.Add(PictureBox7)
        Panel1.Location = New Point(6, 827)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1887, 201)
        Panel1.TabIndex = 0
        ' 
        ' lblHealUse
        ' 
        lblHealUse.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHealUse.ForeColor = Color.Firebrick
        lblHealUse.Location = New Point(1217, 124)
        lblHealUse.Name = "lblHealUse"
        lblHealUse.Size = New Size(79, 58)
        lblHealUse.TabIndex = 15
        lblHealUse.Text = "5"
        lblHealUse.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmpUse
        ' 
        lblEmpUse.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmpUse.ForeColor = Color.Firebrick
        lblEmpUse.Location = New Point(1217, 19)
        lblEmpUse.Name = "lblEmpUse"
        lblEmpUse.Size = New Size(79, 58)
        lblEmpUse.TabIndex = 14
        lblEmpUse.Text = "3"
        lblEmpUse.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Firebrick
        Label9.Location = New Point(1147, 124)
        Label9.Name = "Label9"
        Label9.Size = New Size(76, 58)
        Label9.TabIndex = 13
        Label9.Text = "H:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Firebrick
        Label4.Location = New Point(1147, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 58)
        Label4.TabIndex = 12
        Label4.Text = "E:"
        ' 
        ' lblTutorialAtk
        ' 
        lblTutorialAtk.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTutorialAtk.ForeColor = Color.Firebrick
        lblTutorialAtk.Location = New Point(1678, 112)
        lblTutorialAtk.Name = "lblTutorialAtk"
        lblTutorialAtk.Size = New Size(123, 58)
        lblTutorialAtk.TabIndex = 7
        lblTutorialAtk.Text = "10"
        lblTutorialAtk.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Firebrick
        Label2.Location = New Point(1678, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 58)
        Label2.TabIndex = 6
        Label2.Text = "ATK:"
        ' 
        ' lblTutorialHP
        ' 
        lblTutorialHP.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTutorialHP.ForeColor = Color.Firebrick
        lblTutorialHP.Location = New Point(1496, 112)
        lblTutorialHP.Name = "lblTutorialHP"
        lblTutorialHP.Size = New Size(123, 58)
        lblTutorialHP.TabIndex = 5
        lblTutorialHP.Text = "100"
        lblTutorialHP.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Firebrick
        Label1.Location = New Point(1496, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 58)
        Label1.TabIndex = 4
        Label1.Text = "HP:"
        ' 
        ' imgTutorial
        ' 
        imgTutorial.BorderStyle = BorderStyle.FixedSingle
        imgTutorial.Image = My.Resources.Resources.Boy_CloseUp
        imgTutorial.Location = New Point(1302, 22)
        imgTutorial.Name = "imgTutorial"
        imgTutorial.Size = New Size(163, 163)
        imgTutorial.SizeMode = PictureBoxSizeMode.Zoom
        imgTutorial.TabIndex = 3
        imgTutorial.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = My.Resources.Resources.Empower
        PictureBox9.Location = New Point(785, 19)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(340, 163)
        PictureBox9.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox9.TabIndex = 2
        PictureBox9.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.Heal
        PictureBox8.Location = New Point(401, 22)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(340, 163)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 1
        PictureBox8.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.Attack
        PictureBox7.Location = New Point(17, 22)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(340, 163)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 0
        PictureBox7.TabStop = False
        ' 
        ' VictoryTab
        ' 
        VictoryTab.BackgroundImage = CType(resources.GetObject("VictoryTab.BackgroundImage"), Image)
        VictoryTab.BackgroundImageLayout = ImageLayout.Stretch
        VictoryTab.Controls.Add(btnReturnMenu1)
        VictoryTab.Controls.Add(Label5)
        VictoryTab.Controls.Add(imgEscape)
        VictoryTab.Location = New Point(4, 24)
        VictoryTab.Name = "VictoryTab"
        VictoryTab.Padding = New Padding(3)
        VictoryTab.Size = New Size(1899, 1036)
        VictoryTab.TabIndex = 5
        VictoryTab.Text = "Victory"
        VictoryTab.UseVisualStyleBackColor = True
        ' 
        ' btnReturnMenu1
        ' 
        btnReturnMenu1.Cursor = Cursors.Hand
        btnReturnMenu1.Image = My.Resources.Resources.Return_To_Menu
        btnReturnMenu1.Location = New Point(703, 829)
        btnReturnMenu1.Name = "btnReturnMenu1"
        btnReturnMenu1.Size = New Size(458, 175)
        btnReturnMenu1.SizeMode = PictureBoxSizeMode.Zoom
        btnReturnMenu1.TabIndex = 4
        btnReturnMenu1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkOrange
        Label5.Location = New Point(274, 64)
        Label5.Name = "Label5"
        Label5.Size = New Size(1316, 317)
        Label5.TabIndex = 3
        Label5.Text = "You've successfully defeated the demons that were attacking you. Luckily, the surface wasn't that far from where you were. You've successfully escaped!"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' imgEscape
        ' 
        imgEscape.Image = CType(resources.GetObject("imgEscape.Image"), Image)
        imgEscape.Location = New Point(571, 560)
        imgEscape.Name = "imgEscape"
        imgEscape.Size = New Size(315, 219)
        imgEscape.SizeMode = PictureBoxSizeMode.Zoom
        imgEscape.TabIndex = 2
        imgEscape.TabStop = False
        ' 
        ' Defeat
        ' 
        Defeat.BackgroundImage = CType(resources.GetObject("Defeat.BackgroundImage"), Image)
        Defeat.Controls.Add(imgEndEnemy)
        Defeat.Controls.Add(Label6)
        Defeat.Controls.Add(btnReturnMenu2)
        Defeat.Controls.Add(imgDefeat)
        Defeat.Location = New Point(4, 24)
        Defeat.Name = "Defeat"
        Defeat.Padding = New Padding(3)
        Defeat.Size = New Size(1899, 1036)
        Defeat.TabIndex = 6
        Defeat.Text = "Defeat"
        Defeat.UseVisualStyleBackColor = True
        ' 
        ' imgEndEnemy
        ' 
        imgEndEnemy.Image = CType(resources.GetObject("imgEndEnemy.Image"), Image)
        imgEndEnemy.Location = New Point(1187, 467)
        imgEndEnemy.Name = "imgEndEnemy"
        imgEndEnemy.Size = New Size(679, 392)
        imgEndEnemy.SizeMode = PictureBoxSizeMode.Zoom
        imgEndEnemy.TabIndex = 7
        imgEndEnemy.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkOrange
        Label6.Location = New Point(282, 63)
        Label6.Name = "Label6"
        Label6.Size = New Size(1316, 401)
        Label6.TabIndex = 6
        Label6.Text = "You have failed to exterminate the demons. Now your soul is forever trapped within the darkest pits of hell, with no chance of escaping." & vbCrLf & vbCrLf & "Game over"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnReturnMenu2
        ' 
        btnReturnMenu2.Cursor = Cursors.Hand
        btnReturnMenu2.Image = My.Resources.Resources.Return_To_Menu
        btnReturnMenu2.Location = New Point(708, 829)
        btnReturnMenu2.Name = "btnReturnMenu2"
        btnReturnMenu2.Size = New Size(458, 175)
        btnReturnMenu2.SizeMode = PictureBoxSizeMode.Zoom
        btnReturnMenu2.TabIndex = 5
        btnReturnMenu2.TabStop = False
        ' 
        ' imgDefeat
        ' 
        imgDefeat.Image = CType(resources.GetObject("imgDefeat.Image"), Image)
        imgDefeat.Location = New Point(169, 850)
        imgDefeat.Name = "imgDefeat"
        imgDefeat.Size = New Size(213, 115)
        imgDefeat.SizeMode = PictureBoxSizeMode.Zoom
        imgDefeat.TabIndex = 3
        imgDefeat.TabStop = False
        ' 
        ' MenuForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1904, 1041)
        Controls.Add(tabMenu)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "MenuForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Arnoux: Escape from Hell"
        tabMenu.ResumeLayout(False)
        MenuTab.ResumeLayout(False)
        CType(btnStart, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CharacterTab.ResumeLayout(False)
        CharacterTab.PerformLayout()
        CType(btnCharSelect, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        StoryTab.ResumeLayout(False)
        CType(btnNext, ComponentModel.ISupportInitialize).EndInit()
        CType(btnStart2, ComponentModel.ISupportInitialize).EndInit()
        TutorialTab.ResumeLayout(False)
        TutorialTab.PerformLayout()
        CType(btnGameStart, ComponentModel.ISupportInitialize).EndInit()
        CType(btnTutorialNext, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(imgTutorial, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        VictoryTab.ResumeLayout(False)
        CType(btnReturnMenu1, ComponentModel.ISupportInitialize).EndInit()
        CType(imgEscape, ComponentModel.ISupportInitialize).EndInit()
        Defeat.ResumeLayout(False)
        CType(imgEndEnemy, ComponentModel.ISupportInitialize).EndInit()
        CType(btnReturnMenu2, ComponentModel.ISupportInitialize).EndInit()
        CType(imgDefeat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tabMenu As TabControl
    Friend WithEvents MenuTab As TabPage
    Friend WithEvents CharacterTab As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnStart As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents StoryTab As TabPage
    Friend WithEvents lblStory1 As Label
    Friend WithEvents lblStory2 As Label
    Friend WithEvents lblStory3 As Label
    Friend WithEvents btnStart2 As PictureBox
    Friend WithEvents btnNext As PictureBox
    Friend WithEvents btnCharSelect As PictureBox
    Friend WithEvents TutorialTab As TabPage
    Friend WithEvents btnTutorialNext As PictureBox
    Friend WithEvents lblTutAtkDisplay As Label
    Friend WithEvents lblTutHp As Label
    Friend WithEvents lblTutEmpower As Label
    Friend WithEvents lblTutHeal As Label
    Friend WithEvents lblTutAtk As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTutorialAtk As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTutorialHP As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents imgTutorial As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEnemyHP As Label
    Friend WithEvents lblTutEnemyHP As Label
    Friend WithEvents lblHealUse As Label
    Friend WithEvents lblEmpUse As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents VictoryTab As TabPage
    Friend WithEvents Defeat As TabPage
    Friend WithEvents imgEscape As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnReturnMenu1 As PictureBox
    Friend WithEvents imgDefeat As PictureBox
    Friend WithEvents btnReturnMenu2 As PictureBox
    Friend WithEvents lblUsage As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents imgEndEnemy As PictureBox
    Friend WithEvents btnGameStart As PictureBox
    Friend WithEvents lblExtraInfo As Label
    Friend WithEvents lblExtra As Label

End Class
