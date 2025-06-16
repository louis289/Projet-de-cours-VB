<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        RedCursor = New Label()
        BtnMiseA0 = New Button()
        BtnMiseA1 = New Button()
        BtnInitialisation = New Button()
        HScrollBar1 = New HScrollBar()
        Label1 = New Label()
        LED1 = New Label()
        LED2 = New Label()
        LED4 = New Label()
        LED3 = New Label()
        BlackCursor = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        LED8RadioButton = New RadioButton()
        LED7RadioButton = New RadioButton()
        LED6RadioButton = New RadioButton()
        LED5RadioButton = New RadioButton()
        Label5 = New Label()
        LED4RadioButton = New RadioButton()
        ProgressBar1 = New ProgressBar()
        LED3RadioButton = New RadioButton()
        LED2RadioButton = New RadioButton()
        stopBtn = New Button()
        LED1RadioButton = New RadioButton()
        Vitesse_red_cursor = New HScrollBar()
        RemiseA0 = New Button()
        Label4 = New Label()
        pause = New Button()
        marche = New Button()
        Timer1 = New Timer(components)
        MenuStrip1 = New MenuStrip()
        ValeursToolStripMenuItem = New ToolStripMenuItem()
        MiseÀ1ToolStripMenuItem = New ToolStripMenuItem()
        MiseÀ0ToolStripMenuItem = New ToolStripMenuItem()
        InitialisationToolStripMenuItem = New ToolStripMenuItem()
        FichierToolStripMenuItem = New ToolStripMenuItem()
        OuvrirToolStripMenuItem = New ToolStripMenuItem()
        EnregistrerToolStripMenuItem = New ToolStripMenuItem()
        TimerToolStripMenuItem = New ToolStripMenuItem()
        MarcheToolStripMenuItem = New ToolStripMenuItem()
        PauseToolStripMenuItem = New ToolStripMenuItem()
        RemiseÀ0ToolStripMenuItem = New ToolStripMenuItem()
        StopToolStripMenuItem = New ToolStripMenuItem()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        LED5 = New Label()
        LED6 = New Label()
        LED8 = New Label()
        LED7 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' RedCursor
        ' 
        RedCursor.AutoSize = True
        RedCursor.BackColor = Color.Red
        RedCursor.Location = New Point(54, 30)
        RedCursor.MaximumSize = New Size(2, 580)
        RedCursor.MinimumSize = New Size(2, 580)
        RedCursor.Name = "RedCursor"
        RedCursor.Size = New Size(2, 580)
        RedCursor.TabIndex = 52
        RedCursor.Visible = False
        ' 
        ' BtnMiseA0
        ' 
        BtnMiseA0.Location = New Point(50, 630)
        BtnMiseA0.Name = "BtnMiseA0"
        BtnMiseA0.Size = New Size(100, 30)
        BtnMiseA0.TabIndex = 0
        BtnMiseA0.Text = "Mise à 0"
        BtnMiseA0.UseVisualStyleBackColor = True
        ' 
        ' BtnMiseA1
        ' 
        BtnMiseA1.Location = New Point(50, 680)
        BtnMiseA1.Name = "BtnMiseA1"
        BtnMiseA1.Size = New Size(100, 30)
        BtnMiseA1.TabIndex = 1
        BtnMiseA1.Text = "Mise à 1"
        BtnMiseA1.UseVisualStyleBackColor = True
        ' 
        ' BtnInitialisation
        ' 
        BtnInitialisation.Location = New Point(50, 730)
        BtnInitialisation.Name = "BtnInitialisation"
        BtnInitialisation.Size = New Size(100, 30)
        BtnInitialisation.TabIndex = 2
        BtnInitialisation.Text = "Initialisation"
        BtnInitialisation.UseVisualStyleBackColor = True
        ' 
        ' HScrollBar1
        ' 
        HScrollBar1.LargeChange = 1
        HScrollBar1.Location = New Point(200, 730)
        HScrollBar1.Maximum = 69
        HScrollBar1.Name = "HScrollBar1"
        HScrollBar1.Size = New Size(450, 30)
        HScrollBar1.TabIndex = 69
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(200, 760)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 4
        Label1.Text = "Label1"
        ' 
        ' LED1
        ' 
        LED1.AutoSize = True
        LED1.BackColor = SystemColors.ActiveCaptionText
        LED1.Location = New Point(775, 50)
        LED1.MaximumSize = New Size(50, 50)
        LED1.MinimumSize = New Size(50, 50)
        LED1.Name = "LED1"
        LED1.Size = New Size(50, 50)
        LED1.TabIndex = 5
        ' 
        ' LED2
        ' 
        LED2.AutoSize = True
        LED2.BackColor = SystemColors.ActiveCaptionText
        LED2.Location = New Point(775, 120)
        LED2.MaximumSize = New Size(50, 50)
        LED2.MinimumSize = New Size(50, 50)
        LED2.Name = "LED2"
        LED2.Size = New Size(50, 50)
        LED2.TabIndex = 7
        ' 
        ' LED4
        ' 
        LED4.AutoSize = True
        LED4.BackColor = SystemColors.ActiveCaptionText
        LED4.Location = New Point(775, 260)
        LED4.MaximumSize = New Size(50, 50)
        LED4.MinimumSize = New Size(50, 50)
        LED4.Name = "LED4"
        LED4.Size = New Size(50, 50)
        LED4.TabIndex = 9
        ' 
        ' LED3
        ' 
        LED3.AutoSize = True
        LED3.BackColor = SystemColors.ActiveCaptionText
        LED3.Location = New Point(775, 190)
        LED3.MaximumSize = New Size(50, 50)
        LED3.MinimumSize = New Size(50, 50)
        LED3.Name = "LED3"
        LED3.Size = New Size(50, 50)
        LED3.TabIndex = 8
        ' 
        ' BlackCursor
        ' 
        BlackCursor.AutoSize = True
        BlackCursor.BackColor = SystemColors.ActiveCaptionText
        BlackCursor.Location = New Point(54, 30)
        BlackCursor.MaximumSize = New Size(2, 580)
        BlackCursor.MinimumSize = New Size(2, 580)
        BlackCursor.Name = "BlackCursor"
        BlackCursor.Size = New Size(2, 580)
        BlackCursor.TabIndex = 50
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(865, 50)
        Panel1.MaximumSize = New Size(175, 100)
        Panel1.MinimumSize = New Size(175, 70)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(175, 100)
        Panel1.TabIndex = 51
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 53
        Label3.Text = "Label3"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 4)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 52
        Label2.Text = "Label2"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonShadow
        Panel2.Controls.Add(LED8RadioButton)
        Panel2.Controls.Add(LED7RadioButton)
        Panel2.Controls.Add(LED6RadioButton)
        Panel2.Controls.Add(LED5RadioButton)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(LED4RadioButton)
        Panel2.Controls.Add(ProgressBar1)
        Panel2.Controls.Add(LED3RadioButton)
        Panel2.Controls.Add(LED2RadioButton)
        Panel2.Controls.Add(stopBtn)
        Panel2.Controls.Add(LED1RadioButton)
        Panel2.Controls.Add(Vitesse_red_cursor)
        Panel2.Controls.Add(RemiseA0)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(pause)
        Panel2.Controls.Add(marche)
        Panel2.Location = New Point(865, 156)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(240, 510)
        Panel2.TabIndex = 53
        ' 
        ' LED8RadioButton
        ' 
        LED8RadioButton.AutoCheck = False
        LED8RadioButton.AutoSize = True
        LED8RadioButton.Location = New Point(34, 245)
        LED8RadioButton.Name = "LED8RadioButton"
        LED8RadioButton.Size = New Size(63, 24)
        LED8RadioButton.TabIndex = 62
        LED8RadioButton.Text = "led 8"
        LED8RadioButton.TextAlign = ContentAlignment.BottomLeft
        LED8RadioButton.UseVisualStyleBackColor = True
        ' 
        ' LED7RadioButton
        ' 
        LED7RadioButton.AutoCheck = False
        LED7RadioButton.AutoSize = True
        LED7RadioButton.Location = New Point(34, 222)
        LED7RadioButton.Name = "LED7RadioButton"
        LED7RadioButton.Size = New Size(63, 24)
        LED7RadioButton.TabIndex = 61
        LED7RadioButton.Text = "led 7"
        LED7RadioButton.TextAlign = ContentAlignment.BottomLeft
        LED7RadioButton.UseVisualStyleBackColor = True
        ' 
        ' LED6RadioButton
        ' 
        LED6RadioButton.AutoCheck = False
        LED6RadioButton.AutoSize = True
        LED6RadioButton.Location = New Point(34, 199)
        LED6RadioButton.Name = "LED6RadioButton"
        LED6RadioButton.Size = New Size(63, 24)
        LED6RadioButton.TabIndex = 60
        LED6RadioButton.Text = "led 6"
        LED6RadioButton.TextAlign = ContentAlignment.BottomLeft
        LED6RadioButton.UseVisualStyleBackColor = True
        ' 
        ' LED5RadioButton
        ' 
        LED5RadioButton.AutoCheck = False
        LED5RadioButton.AutoSize = True
        LED5RadioButton.Location = New Point(34, 176)
        LED5RadioButton.Name = "LED5RadioButton"
        LED5RadioButton.Size = New Size(63, 24)
        LED5RadioButton.TabIndex = 59
        LED5RadioButton.Text = "led 5"
        LED5RadioButton.TextAlign = ContentAlignment.BottomLeft
        LED5RadioButton.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(34, 286)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 54
        Label5.Text = "Label5"
        ' 
        ' LED4RadioButton
        ' 
        LED4RadioButton.AutoCheck = False
        LED4RadioButton.AutoSize = True
        LED4RadioButton.Location = New Point(34, 153)
        LED4RadioButton.Name = "LED4RadioButton"
        LED4RadioButton.Size = New Size(63, 24)
        LED4RadioButton.TabIndex = 57
        LED4RadioButton.Text = "led 4"
        LED4RadioButton.TextAlign = ContentAlignment.BottomLeft
        LED4RadioButton.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(18, 463)
        ProgressBar1.Maximum = 69
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(125, 29)
        ProgressBar1.TabIndex = 58
        ' 
        ' LED3RadioButton
        ' 
        LED3RadioButton.AutoCheck = False
        LED3RadioButton.AutoSize = True
        LED3RadioButton.Location = New Point(34, 130)
        LED3RadioButton.Name = "LED3RadioButton"
        LED3RadioButton.Size = New Size(63, 24)
        LED3RadioButton.TabIndex = 56
        LED3RadioButton.Text = "led 3"
        LED3RadioButton.TextAlign = ContentAlignment.BottomLeft
        LED3RadioButton.UseVisualStyleBackColor = True
        ' 
        ' LED2RadioButton
        ' 
        LED2RadioButton.AutoCheck = False
        LED2RadioButton.AutoSize = True
        LED2RadioButton.Location = New Point(34, 107)
        LED2RadioButton.Name = "LED2RadioButton"
        LED2RadioButton.Size = New Size(63, 24)
        LED2RadioButton.TabIndex = 55
        LED2RadioButton.Text = "led 2"
        LED2RadioButton.TextAlign = ContentAlignment.BottomLeft
        LED2RadioButton.UseVisualStyleBackColor = True
        ' 
        ' stopBtn
        ' 
        stopBtn.Location = New Point(18, 433)
        stopBtn.Name = "stopBtn"
        stopBtn.Size = New Size(94, 29)
        stopBtn.TabIndex = 57
        stopBtn.Text = "stop"
        stopBtn.UseVisualStyleBackColor = True
        ' 
        ' LED1RadioButton
        ' 
        LED1RadioButton.AutoCheck = False
        LED1RadioButton.AutoSize = True
        LED1RadioButton.Location = New Point(34, 84)
        LED1RadioButton.Name = "LED1RadioButton"
        LED1RadioButton.Size = New Size(63, 24)
        LED1RadioButton.TabIndex = 54
        LED1RadioButton.Text = "led 1"
        LED1RadioButton.TextAlign = ContentAlignment.BottomLeft
        LED1RadioButton.UseVisualStyleBackColor = True
        ' 
        ' Vitesse_red_cursor
        ' 
        Vitesse_red_cursor.LargeChange = 1
        Vitesse_red_cursor.Location = New Point(18, 42)
        Vitesse_red_cursor.Maximum = 400
        Vitesse_red_cursor.Name = "Vitesse_red_cursor"
        Vitesse_red_cursor.Size = New Size(197, 30)
        Vitesse_red_cursor.TabIndex = 54
        ' 
        ' RemiseA0
        ' 
        RemiseA0.Location = New Point(18, 398)
        RemiseA0.Name = "RemiseA0"
        RemiseA0.Size = New Size(94, 29)
        RemiseA0.TabIndex = 56
        RemiseA0.Text = "remise à 0"
        RemiseA0.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 54
        Label4.Text = "Label4"
        ' 
        ' pause
        ' 
        pause.Location = New Point(18, 363)
        pause.Name = "pause"
        pause.Size = New Size(94, 29)
        pause.TabIndex = 55
        pause.Text = "pause"
        pause.UseVisualStyleBackColor = True
        ' 
        ' marche
        ' 
        marche.Location = New Point(18, 328)
        marche.Name = "marche"
        marche.Size = New Size(94, 29)
        marche.TabIndex = 54
        marche.Text = "marche"
        marche.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ValeursToolStripMenuItem, FichierToolStripMenuItem, TimerToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1224, 28)
        MenuStrip1.TabIndex = 54
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ValeursToolStripMenuItem
        ' 
        ValeursToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MiseÀ1ToolStripMenuItem, MiseÀ0ToolStripMenuItem, InitialisationToolStripMenuItem})
        ValeursToolStripMenuItem.Name = "ValeursToolStripMenuItem"
        ValeursToolStripMenuItem.Size = New Size(69, 24)
        ValeursToolStripMenuItem.Text = "valeurs"
        ' 
        ' MiseÀ1ToolStripMenuItem
        ' 
        MiseÀ1ToolStripMenuItem.Name = "MiseÀ1ToolStripMenuItem"
        MiseÀ1ToolStripMenuItem.Size = New Size(173, 26)
        MiseÀ1ToolStripMenuItem.Text = "mise à 1"
        ' 
        ' MiseÀ0ToolStripMenuItem
        ' 
        MiseÀ0ToolStripMenuItem.Name = "MiseÀ0ToolStripMenuItem"
        MiseÀ0ToolStripMenuItem.Size = New Size(173, 26)
        MiseÀ0ToolStripMenuItem.Text = "mise à 0"
        ' 
        ' InitialisationToolStripMenuItem
        ' 
        InitialisationToolStripMenuItem.Name = "InitialisationToolStripMenuItem"
        InitialisationToolStripMenuItem.Size = New Size(173, 26)
        InitialisationToolStripMenuItem.Text = "initialisation"
        ' 
        ' FichierToolStripMenuItem
        ' 
        FichierToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OuvrirToolStripMenuItem, EnregistrerToolStripMenuItem})
        FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        FichierToolStripMenuItem.Size = New Size(64, 24)
        FichierToolStripMenuItem.Text = "fichier"
        ' 
        ' OuvrirToolStripMenuItem
        ' 
        OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        OuvrirToolStripMenuItem.Size = New Size(163, 26)
        OuvrirToolStripMenuItem.Text = "ouvrir"
        ' 
        ' EnregistrerToolStripMenuItem
        ' 
        EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        EnregistrerToolStripMenuItem.Size = New Size(163, 26)
        EnregistrerToolStripMenuItem.Text = "enregistrer"
        ' 
        ' TimerToolStripMenuItem
        ' 
        TimerToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MarcheToolStripMenuItem, PauseToolStripMenuItem, RemiseÀ0ToolStripMenuItem, StopToolStripMenuItem})
        TimerToolStripMenuItem.Name = "TimerToolStripMenuItem"
        TimerToolStripMenuItem.Size = New Size(58, 24)
        TimerToolStripMenuItem.Text = "timer"
        ' 
        ' MarcheToolStripMenuItem
        ' 
        MarcheToolStripMenuItem.Name = "MarcheToolStripMenuItem"
        MarcheToolStripMenuItem.Size = New Size(160, 26)
        MarcheToolStripMenuItem.Text = "marche"
        ' 
        ' PauseToolStripMenuItem
        ' 
        PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        PauseToolStripMenuItem.Size = New Size(160, 26)
        PauseToolStripMenuItem.Text = "pause"
        ' 
        ' RemiseÀ0ToolStripMenuItem
        ' 
        RemiseÀ0ToolStripMenuItem.Name = "RemiseÀ0ToolStripMenuItem"
        RemiseÀ0ToolStripMenuItem.Size = New Size(160, 26)
        RemiseÀ0ToolStripMenuItem.Text = "remise à 0"
        ' 
        ' StopToolStripMenuItem
        ' 
        StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        StopToolStripMenuItem.Size = New Size(160, 26)
        StopToolStripMenuItem.Text = "stop"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' LED5
        ' 
        LED5.AutoSize = True
        LED5.BackColor = SystemColors.ActiveCaptionText
        LED5.Location = New Point(775, 330)
        LED5.MaximumSize = New Size(50, 50)
        LED5.MinimumSize = New Size(50, 50)
        LED5.Name = "LED5"
        LED5.Size = New Size(50, 50)
        LED5.TabIndex = 55
        ' 
        ' LED6
        ' 
        LED6.AutoSize = True
        LED6.BackColor = SystemColors.ActiveCaptionText
        LED6.Location = New Point(775, 400)
        LED6.MaximumSize = New Size(50, 50)
        LED6.MinimumSize = New Size(50, 50)
        LED6.Name = "LED6"
        LED6.Size = New Size(50, 50)
        LED6.TabIndex = 56
        ' 
        ' LED8
        ' 
        LED8.AutoSize = True
        LED8.BackColor = SystemColors.ActiveCaptionText
        LED8.Location = New Point(775, 540)
        LED8.MaximumSize = New Size(50, 50)
        LED8.MinimumSize = New Size(50, 50)
        LED8.Name = "LED8"
        LED8.Size = New Size(50, 50)
        LED8.TabIndex = 58
        ' 
        ' LED7
        ' 
        LED7.AutoSize = True
        LED7.BackColor = SystemColors.ActiveCaptionText
        LED7.Location = New Point(775, 470)
        LED7.MaximumSize = New Size(50, 50)
        LED7.MinimumSize = New Size(50, 50)
        LED7.Name = "LED7"
        LED7.Size = New Size(50, 50)
        LED7.TabIndex = 57
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(1224, 799)
        Controls.Add(LED8)
        Controls.Add(LED7)
        Controls.Add(LED6)
        Controls.Add(LED5)
        Controls.Add(Panel2)
        Controls.Add(RedCursor)
        Controls.Add(Panel1)
        Controls.Add(BlackCursor)
        Controls.Add(LED4)
        Controls.Add(LED3)
        Controls.Add(LED2)
        Controls.Add(LED1)
        Controls.Add(Label1)
        Controls.Add(HScrollBar1)
        Controls.Add(BtnInitialisation)
        Controls.Add(BtnMiseA1)
        Controls.Add(BtnMiseA0)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnMiseA0 As Button
    Friend WithEvents BtnMiseA1 As Button
    Friend WithEvents BtnInitialisation As Button
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents Label1 As Label
    Friend WithEvents LED1 As Label
    Friend WithEvents LED2 As Label
    Friend WithEvents LED4 As Label
    Friend WithEvents LED3 As Label
    Friend WithEvents BlackCursor As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RedCursor As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Vitesse_red_cursor As HScrollBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents stopBtn As Button
    Friend WithEvents RemiseA0 As Button
    Friend WithEvents pause As Button
    Friend WithEvents marche As Button
    Friend WithEvents LED1RadioButton As RadioButton
    Friend WithEvents LED2RadioButton As RadioButton
    Friend WithEvents LED4RadioButton As RadioButton
    Friend WithEvents LED3RadioButton As RadioButton
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ValeursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiseÀ1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiseÀ0ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InitialisationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarcheToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemiseÀ0ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents LED5 As Label
    Friend WithEvents LED6 As Label
    Friend WithEvents LED8 As Label
    Friend WithEvents LED7 As Label
    Friend WithEvents LED8RadioButton As RadioButton
    Friend WithEvents LED7RadioButton As RadioButton
    Friend WithEvents LED6RadioButton As RadioButton
    Friend WithEvents LED5RadioButton As RadioButton

End Class
