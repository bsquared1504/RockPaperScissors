<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rpsGameFrm
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
        jediBtn = New Button()
        bountyBtn = New Button()
        sithBtn = New Button()
        jediPic = New PictureBox()
        bountyPic = New PictureBox()
        sithPic = New PictureBox()
        infoLbl = New Label()
        nextBtn = New Button()
        againBtn = New Button()
        exitBtn = New Button()
        winnerPic = New PictureBox()
        CType(jediPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(bountyPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(sithPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(winnerPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' jediBtn
        ' 
        jediBtn.Font = New Font("Star Jedi Outline", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        jediBtn.Location = New Point(47, 418)
        jediBtn.Name = "jediBtn"
        jediBtn.Size = New Size(175, 40)
        jediBtn.TabIndex = 0
        jediBtn.Text = "&Jedi"
        jediBtn.UseVisualStyleBackColor = True
        ' 
        ' bountyBtn
        ' 
        bountyBtn.Font = New Font("Star Jedi Outline", 12F)
        bountyBtn.Location = New Point(315, 418)
        bountyBtn.Name = "bountyBtn"
        bountyBtn.Size = New Size(175, 40)
        bountyBtn.TabIndex = 1
        bountyBtn.Text = "&Bounty Hunter"
        bountyBtn.UseVisualStyleBackColor = True
        ' 
        ' sithBtn
        ' 
        sithBtn.Font = New Font("Star Jedi Outline", 12F)
        sithBtn.Location = New Point(582, 418)
        sithBtn.Name = "sithBtn"
        sithBtn.Size = New Size(175, 40)
        sithBtn.TabIndex = 2
        sithBtn.Text = "&Sith"
        sithBtn.UseVisualStyleBackColor = True
        ' 
        ' jediPic
        ' 
        jediPic.BackColor = Color.Transparent
        jediPic.Image = My.Resources.Resources.luke_pic
        jediPic.InitialImage = My.Resources.Resources.luke_pic
        jediPic.Location = New Point(47, 63)
        jediPic.Name = "jediPic"
        jediPic.Size = New Size(175, 349)
        jediPic.SizeMode = PictureBoxSizeMode.StretchImage
        jediPic.TabIndex = 3
        jediPic.TabStop = False
        ' 
        ' bountyPic
        ' 
        bountyPic.BackColor = Color.Transparent
        bountyPic.Image = My.Resources.Resources.mando_pic
        bountyPic.Location = New Point(315, 63)
        bountyPic.Name = "bountyPic"
        bountyPic.Size = New Size(175, 349)
        bountyPic.SizeMode = PictureBoxSizeMode.StretchImage
        bountyPic.TabIndex = 4
        bountyPic.TabStop = False
        ' 
        ' sithPic
        ' 
        sithPic.BackColor = Color.Transparent
        sithPic.Image = My.Resources.Resources.darth_pic
        sithPic.Location = New Point(582, 63)
        sithPic.Name = "sithPic"
        sithPic.Size = New Size(175, 349)
        sithPic.SizeMode = PictureBoxSizeMode.StretchImage
        sithPic.TabIndex = 5
        sithPic.TabStop = False
        ' 
        ' infoLbl
        ' 
        infoLbl.AutoSize = True
        infoLbl.BackColor = SystemColors.Control
        infoLbl.Font = New Font("Star Jedi Outline", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        infoLbl.Location = New Point(27, 9)
        infoLbl.MinimumSize = New Size(750, 40)
        infoLbl.Name = "infoLbl"
        infoLbl.Size = New Size(750, 40)
        infoLbl.TabIndex = 6
        infoLbl.Text = "Make your choice"
        infoLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nextBtn
        ' 
        nextBtn.Font = New Font("Star Jedi Outline", 12F)
        nextBtn.Location = New Point(315, 418)
        nextBtn.Name = "nextBtn"
        nextBtn.Size = New Size(175, 40)
        nextBtn.TabIndex = 3
        nextBtn.Text = "&Next"
        nextBtn.UseVisualStyleBackColor = True
        nextBtn.Visible = False
        ' 
        ' againBtn
        ' 
        againBtn.Font = New Font("Star Jedi Outline", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        againBtn.Location = New Point(47, 418)
        againBtn.Name = "againBtn"
        againBtn.Size = New Size(175, 40)
        againBtn.TabIndex = 4
        againBtn.Text = "&Play Again"
        againBtn.UseVisualStyleBackColor = True
        againBtn.Visible = False
        ' 
        ' exitBtn
        ' 
        exitBtn.Font = New Font("Star Jedi Outline", 12F)
        exitBtn.Location = New Point(582, 418)
        exitBtn.Name = "exitBtn"
        exitBtn.Size = New Size(175, 40)
        exitBtn.TabIndex = 5
        exitBtn.Text = "E&xit"
        exitBtn.UseVisualStyleBackColor = True
        exitBtn.Visible = False
        ' 
        ' winnerPic
        ' 
        winnerPic.BackColor = Color.Transparent
        winnerPic.Location = New Point(315, 63)
        winnerPic.Name = "winnerPic"
        winnerPic.Size = New Size(175, 349)
        winnerPic.SizeMode = PictureBoxSizeMode.StretchImage
        winnerPic.TabIndex = 10
        winnerPic.TabStop = False
        winnerPic.Visible = False
        ' 
        ' rpsGameFrm
        ' 
        AcceptButton = againBtn
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.battle_background
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = exitBtn
        ClientSize = New Size(804, 467)
        Controls.Add(exitBtn)
        Controls.Add(againBtn)
        Controls.Add(nextBtn)
        Controls.Add(infoLbl)
        Controls.Add(sithPic)
        Controls.Add(bountyPic)
        Controls.Add(jediPic)
        Controls.Add(sithBtn)
        Controls.Add(bountyBtn)
        Controls.Add(jediBtn)
        Controls.Add(winnerPic)
        Name = "rpsGameFrm"
        Text = "Cantina Clash"
        CType(jediPic, ComponentModel.ISupportInitialize).EndInit()
        CType(bountyPic, ComponentModel.ISupportInitialize).EndInit()
        CType(sithPic, ComponentModel.ISupportInitialize).EndInit()
        CType(winnerPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents jediBtn As Button
    Friend WithEvents bountyBtn As Button
    Friend WithEvents sithBtn As Button
    Friend WithEvents jediPic As PictureBox
    Friend WithEvents bountyPic As PictureBox
    Friend WithEvents sithPic As PictureBox
    Friend WithEvents infoLbl As Label
    Friend WithEvents nextBtn As Button
    Friend WithEvents againBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents winnerPic As PictureBox
End Class
