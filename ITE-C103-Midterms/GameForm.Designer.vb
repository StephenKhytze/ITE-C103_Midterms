<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameForm))
        tabGame = New TabControl()
        GameTab = New TabPage()
        storyPanel = New Panel()
        lblStory = New Label()
        btnNext = New PictureBox()
        Label1 = New Label()
        lblEnemyHP = New Label()
        imgEnemy = New PictureBox()
        imgCharacter = New PictureBox()
        Panel2 = New Panel()
        lblHealUse = New Label()
        lblEmpUse = New Label()
        Label9 = New Label()
        Label3 = New Label()
        lblAtk = New Label()
        Label15 = New Label()
        lblHP1 = New Label()
        Label17 = New Label()
        imgPlayer = New PictureBox()
        btnEmpower1 = New PictureBox()
        btnHeal1 = New PictureBox()
        btnAtk1 = New PictureBox()
        tmrAnimation = New Timer(components)
        tmrHurt = New Timer(components)
        tabGame.SuspendLayout()
        GameTab.SuspendLayout()
        storyPanel.SuspendLayout()
        CType(btnNext, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgEnemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgCharacter, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(imgPlayer, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnEmpower1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnHeal1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnAtk1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tabGame
        ' 
        tabGame.Controls.Add(GameTab)
        tabGame.Location = New Point(-2, -23)
        tabGame.Name = "tabGame"
        tabGame.SelectedIndex = 0
        tabGame.Size = New Size(1907, 1064)
        tabGame.TabIndex = 1
        ' 
        ' GameTab
        ' 
        GameTab.BackgroundImage = CType(resources.GetObject("GameTab.BackgroundImage"), Image)
        GameTab.BackgroundImageLayout = ImageLayout.Stretch
        GameTab.Controls.Add(storyPanel)
        GameTab.Controls.Add(Label1)
        GameTab.Controls.Add(lblEnemyHP)
        GameTab.Controls.Add(imgEnemy)
        GameTab.Controls.Add(imgCharacter)
        GameTab.Controls.Add(Panel2)
        GameTab.Location = New Point(4, 24)
        GameTab.Name = "GameTab"
        GameTab.Padding = New Padding(3)
        GameTab.Size = New Size(1899, 1036)
        GameTab.TabIndex = 4
        GameTab.Text = "Game"
        GameTab.UseVisualStyleBackColor = True
        ' 
        ' storyPanel
        ' 
        storyPanel.BackColor = Color.FromArgb(CByte(115), CByte(0), CByte(3))
        storyPanel.Controls.Add(lblStory)
        storyPanel.Controls.Add(btnNext)
        storyPanel.Location = New Point(235, 134)
        storyPanel.Name = "storyPanel"
        storyPanel.Size = New Size(1437, 817)
        storyPanel.TabIndex = 9
        storyPanel.Visible = False
        ' 
        ' lblStory
        ' 
        lblStory.Font = New Font("Upheaval TT (BRK)", 63.7499924F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStory.ForeColor = Color.DarkOrange
        lblStory.Location = New Point(27, 52)
        lblStory.Name = "lblStory"
        lblStory.Size = New Size(1388, 596)
        lblStory.TabIndex = 1
        lblStory.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnNext
        ' 
        btnNext.Cursor = Cursors.Hand
        btnNext.Image = My.Resources.Resources.button
        btnNext.Location = New Point(1276, 669)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(139, 122)
        btnNext.SizeMode = PictureBoxSizeMode.Zoom
        btnNext.TabIndex = 0
        btnNext.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Upheaval TT (BRK)", 56.25F)
        Label1.ForeColor = Color.Firebrick
        Label1.Location = New Point(959, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(457, 67)
        Label1.TabIndex = 8
        Label1.Text = "Enemy's HP:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEnemyHP
        ' 
        lblEnemyHP.Font = New Font("Upheaval TT (BRK)", 56.25F)
        lblEnemyHP.ForeColor = Color.Firebrick
        lblEnemyHP.Location = New Point(959, 128)
        lblEnemyHP.Name = "lblEnemyHP"
        lblEnemyHP.Size = New Size(229, 58)
        lblEnemyHP.TabIndex = 7
        lblEnemyHP.Text = "10"
        lblEnemyHP.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' imgEnemy
        ' 
        imgEnemy.BackgroundImageLayout = ImageLayout.Zoom
        imgEnemy.Location = New Point(959, 210)
        imgEnemy.Name = "imgEnemy"
        imgEnemy.Size = New Size(879, 592)
        imgEnemy.SizeMode = PictureBoxSizeMode.Zoom
        imgEnemy.TabIndex = 2
        imgEnemy.TabStop = False
        ' 
        ' imgCharacter
        ' 
        imgCharacter.Image = My.Resources.Resources.Girl_Idle
        imgCharacter.Location = New Point(385, 602)
        imgCharacter.Name = "imgCharacter"
        imgCharacter.Size = New Size(315, 219)
        imgCharacter.SizeMode = PictureBoxSizeMode.Zoom
        imgCharacter.TabIndex = 1
        imgCharacter.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(lblHealUse)
        Panel2.Controls.Add(lblEmpUse)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(lblAtk)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(lblHP1)
        Panel2.Controls.Add(Label17)
        Panel2.Controls.Add(imgPlayer)
        Panel2.Controls.Add(btnEmpower1)
        Panel2.Controls.Add(btnHeal1)
        Panel2.Controls.Add(btnAtk1)
        Panel2.Location = New Point(6, 827)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1887, 201)
        Panel2.TabIndex = 0
        ' 
        ' lblHealUse
        ' 
        lblHealUse.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHealUse.ForeColor = Color.Firebrick
        lblHealUse.Location = New Point(1217, 124)
        lblHealUse.Name = "lblHealUse"
        lblHealUse.Size = New Size(86, 58)
        lblHealUse.TabIndex = 11
        lblHealUse.Text = "5"
        lblHealUse.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmpUse
        ' 
        lblEmpUse.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmpUse.ForeColor = Color.Firebrick
        lblEmpUse.Location = New Point(1217, 19)
        lblEmpUse.Name = "lblEmpUse"
        lblEmpUse.Size = New Size(86, 58)
        lblEmpUse.TabIndex = 10
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
        Label9.TabIndex = 9
        Label9.Text = "H:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Firebrick
        Label3.Location = New Point(1147, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 58)
        Label3.TabIndex = 8
        Label3.Text = "E:"
        ' 
        ' lblAtk
        ' 
        lblAtk.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAtk.ForeColor = Color.Firebrick
        lblAtk.Location = New Point(1678, 112)
        lblAtk.Name = "lblAtk"
        lblAtk.Size = New Size(147, 58)
        lblAtk.TabIndex = 7
        lblAtk.Text = "100"
        lblAtk.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Firebrick
        Label15.Location = New Point(1678, 39)
        Label15.Name = "Label15"
        Label15.Size = New Size(153, 58)
        Label15.TabIndex = 6
        Label15.Text = "ATK:"
        ' 
        ' lblHP1
        ' 
        lblHP1.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHP1.ForeColor = Color.Firebrick
        lblHP1.Location = New Point(1496, 112)
        lblHP1.Name = "lblHP1"
        lblHP1.Size = New Size(147, 58)
        lblHP1.TabIndex = 5
        lblHP1.Text = "100"
        lblHP1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.Firebrick
        Label17.Location = New Point(1496, 39)
        Label17.Name = "Label17"
        Label17.Size = New Size(114, 58)
        Label17.TabIndex = 4
        Label17.Text = "HP:"
        ' 
        ' imgPlayer
        ' 
        imgPlayer.BorderStyle = BorderStyle.FixedSingle
        imgPlayer.Image = CType(resources.GetObject("imgPlayer.Image"), Image)
        imgPlayer.Location = New Point(1302, 22)
        imgPlayer.Name = "imgPlayer"
        imgPlayer.Size = New Size(163, 163)
        imgPlayer.SizeMode = PictureBoxSizeMode.Zoom
        imgPlayer.TabIndex = 3
        imgPlayer.TabStop = False
        ' 
        ' btnEmpower1
        ' 
        btnEmpower1.Cursor = Cursors.Hand
        btnEmpower1.Image = My.Resources.Resources.Empower
        btnEmpower1.Location = New Point(785, 19)
        btnEmpower1.Name = "btnEmpower1"
        btnEmpower1.Size = New Size(340, 163)
        btnEmpower1.SizeMode = PictureBoxSizeMode.Zoom
        btnEmpower1.TabIndex = 2
        btnEmpower1.TabStop = False
        ' 
        ' btnHeal1
        ' 
        btnHeal1.Cursor = Cursors.Hand
        btnHeal1.Image = My.Resources.Resources.Heal
        btnHeal1.Location = New Point(401, 22)
        btnHeal1.Name = "btnHeal1"
        btnHeal1.Size = New Size(340, 163)
        btnHeal1.SizeMode = PictureBoxSizeMode.Zoom
        btnHeal1.TabIndex = 1
        btnHeal1.TabStop = False
        ' 
        ' btnAtk1
        ' 
        btnAtk1.Cursor = Cursors.Hand
        btnAtk1.Image = My.Resources.Resources.Attack
        btnAtk1.Location = New Point(17, 22)
        btnAtk1.Name = "btnAtk1"
        btnAtk1.Size = New Size(340, 163)
        btnAtk1.SizeMode = PictureBoxSizeMode.Zoom
        btnAtk1.TabIndex = 0
        btnAtk1.TabStop = False
        ' 
        ' tmrAnimation
        ' 
        tmrAnimation.Interval = 400
        ' 
        ' tmrHurt
        ' 
        tmrHurt.Interval = 750
        ' 
        ' GameForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1904, 1041)
        Controls.Add(tabGame)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "GameForm"
        Text = "Arnoux: Escape From Hell"
        tabGame.ResumeLayout(False)
        GameTab.ResumeLayout(False)
        GameTab.PerformLayout()
        storyPanel.ResumeLayout(False)
        CType(btnNext, ComponentModel.ISupportInitialize).EndInit()
        CType(imgEnemy, ComponentModel.ISupportInitialize).EndInit()
        CType(imgCharacter, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(imgPlayer, ComponentModel.ISupportInitialize).EndInit()
        CType(btnEmpower1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnHeal1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnAtk1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tabGame As TabControl
    Friend WithEvents TutorialTab As TabPage
    Friend WithEvents lblTutorialAtk As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTutorialHP As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents imgTutorial As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GameTab As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblEnemyHP As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblHP1 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents imgPlayer As PictureBox
    Friend WithEvents btnEmpower1 As PictureBox
    Friend WithEvents btnHeal1 As PictureBox
    Friend WithEvents btnAtk1 As PictureBox
    Friend WithEvents btnTutorialNext As PictureBox
    Friend WithEvents imgCharacter As PictureBox
    Friend WithEvents tmrAnimation As Timer
    Friend WithEvents imgEnemy As PictureBox
    Friend WithEvents lblAtk As Label
    Friend WithEvents lblHealUse As Label
    Friend WithEvents lblEmpUse As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tmrHurt As Timer
    Friend WithEvents storyPanel As Panel
    Friend WithEvents btnNext As PictureBox
    Friend WithEvents lblStory As Label
End Class
