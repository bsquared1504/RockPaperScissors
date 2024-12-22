<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rpsFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpsFrm))
        titleLbl = New Label()
        helpBtn = New Button()
        startBtn = New Button()
        exitBtn = New Button()
        helpLbl = New Label()
        helpExitBtn = New Button()
        oneBtn = New Button()
        twoBtn = New Button()
        SuspendLayout()
        ' 
        ' titleLbl
        ' 
        titleLbl.AutoSize = True
        titleLbl.BackColor = SystemColors.ActiveCaptionText
        titleLbl.Font = New Font("Star Jedi Outline", 28F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        titleLbl.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        titleLbl.Location = New Point(83, 31)
        titleLbl.Margin = New Padding(2, 0, 2, 0)
        titleLbl.Name = "titleLbl"
        titleLbl.Size = New Size(638, 61)
        titleLbl.TabIndex = 0
        titleLbl.Text = "Welcome to Cantina Clash"
        ' 
        ' helpBtn
        ' 
        helpBtn.BackColor = Color.Black
        helpBtn.Font = New Font("Star Jedi Outline", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        helpBtn.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        helpBtn.Location = New Point(214, 295)
        helpBtn.Margin = New Padding(2)
        helpBtn.Name = "helpBtn"
        helpBtn.Size = New Size(140, 50)
        helpBtn.TabIndex = 1
        helpBtn.Text = "&Help"
        helpBtn.UseVisualStyleBackColor = False
        ' 
        ' startBtn
        ' 
        startBtn.BackColor = Color.Black
        startBtn.Font = New Font("Star Jedi Outline", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        startBtn.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        startBtn.Location = New Point(451, 295)
        startBtn.Margin = New Padding(2)
        startBtn.Name = "startBtn"
        startBtn.Size = New Size(140, 50)
        startBtn.TabIndex = 0
        startBtn.Text = "&Start"
        startBtn.UseVisualStyleBackColor = False
        ' 
        ' exitBtn
        ' 
        exitBtn.BackColor = Color.Black
        exitBtn.Font = New Font("Star Jedi Outline", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        exitBtn.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        exitBtn.Location = New Point(653, 406)
        exitBtn.Margin = New Padding(2)
        exitBtn.Name = "exitBtn"
        exitBtn.Size = New Size(140, 50)
        exitBtn.TabIndex = 2
        exitBtn.Text = "E&xit"
        exitBtn.UseVisualStyleBackColor = False
        ' 
        ' helpLbl
        ' 
        helpLbl.AutoSize = True
        helpLbl.Font = New Font("Star Jedi Outline", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        helpLbl.ForeColor = Color.Black
        helpLbl.Location = New Point(17, 18)
        helpLbl.Margin = New Padding(2, 0, 2, 0)
        helpLbl.MinimumSize = New Size(770, 430)
        helpLbl.Name = "helpLbl"
        helpLbl.Size = New Size(770, 430)
        helpLbl.TabIndex = 1
        helpLbl.Text = resources.GetString("helpLbl.Text")
        helpLbl.TextAlign = ContentAlignment.TopCenter
        helpLbl.Visible = False
        ' 
        ' helpExitBtn
        ' 
        helpExitBtn.BackColor = Color.Black
        helpExitBtn.Font = New Font("Star Jedi Outline", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        helpExitBtn.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        helpExitBtn.Location = New Point(332, 390)
        helpExitBtn.Margin = New Padding(2)
        helpExitBtn.Name = "helpExitBtn"
        helpExitBtn.Size = New Size(140, 50)
        helpExitBtn.TabIndex = 3
        helpExitBtn.Text = "E&xit"
        helpExitBtn.UseVisualStyleBackColor = False
        helpExitBtn.Visible = False
        ' 
        ' oneBtn
        ' 
        oneBtn.BackColor = Color.Black
        oneBtn.Font = New Font("Star Jedi Outline", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        oneBtn.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        oneBtn.Location = New Point(214, 295)
        oneBtn.Margin = New Padding(2)
        oneBtn.Name = "oneBtn"
        oneBtn.Size = New Size(140, 50)
        oneBtn.TabIndex = 4
        oneBtn.Text = "&1P"
        oneBtn.UseVisualStyleBackColor = False
        oneBtn.Visible = False
        ' 
        ' twoBtn
        ' 
        twoBtn.BackColor = Color.Black
        twoBtn.Font = New Font("Star Jedi Outline", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        twoBtn.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        twoBtn.Location = New Point(451, 295)
        twoBtn.Margin = New Padding(2)
        twoBtn.Name = "twoBtn"
        twoBtn.Size = New Size(140, 50)
        twoBtn.TabIndex = 5
        twoBtn.Text = "&2P"
        twoBtn.UseVisualStyleBackColor = False
        twoBtn.Visible = False
        ' 
        ' rpsFrm
        ' 
        AcceptButton = startBtn
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.home_pic
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = exitBtn
        ClientSize = New Size(804, 467)
        Controls.Add(twoBtn)
        Controls.Add(oneBtn)
        Controls.Add(helpExitBtn)
        Controls.Add(exitBtn)
        Controls.Add(startBtn)
        Controls.Add(helpBtn)
        Controls.Add(titleLbl)
        Controls.Add(helpLbl)
        Margin = New Padding(2)
        Name = "rpsFrm"
        Text = "Cantina Clash"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents titleLbl As Label
    Friend WithEvents helpBtn As Button
    Friend WithEvents startBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents helpLbl As Label
    Friend WithEvents helpExitBtn As Button
    Friend WithEvents oneBtn As Button
    Friend WithEvents twoBtn As Button

End Class
