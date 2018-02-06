<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proxy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proxy))
        Me.TopBar = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Label()
        Me.TopTitle = New System.Windows.Forms.Label()
        Me.TopIcon = New System.Windows.Forms.Panel()
        Me.ConnectPanel = New System.Windows.Forms.Panel()
        Me.ConnectLabel = New System.Windows.Forms.Label()
        Me.SettingsPanel = New System.Windows.Forms.Panel()
        Me.SettingsLabel = New System.Windows.Forms.Label()
        Me.HelpPanel = New System.Windows.Forms.Panel()
        Me.HelpLabel = New System.Windows.Forms.Label()
        Me.UpdatePanel = New System.Windows.Forms.Panel()
        Me.UpdateLabel = New System.Windows.Forms.Label()
        Me.ConsolePanel = New System.Windows.Forms.Panel()
        Me.ConsoleLabel = New System.Windows.Forms.Label()
        Me.DisplayArea = New System.Windows.Forms.Panel()
        Me.TopBar.SuspendLayout()
        Me.ConnectPanel.SuspendLayout()
        Me.SettingsPanel.SuspendLayout()
        Me.HelpPanel.SuspendLayout()
        Me.UpdatePanel.SuspendLayout()
        Me.ConsolePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopBar
        '
        Me.TopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TopBar.Controls.Add(Me.Label3)
        Me.TopBar.Controls.Add(Me.ExitButton)
        Me.TopBar.Controls.Add(Me.TopTitle)
        Me.TopBar.Controls.Add(Me.TopIcon)
        Me.TopBar.Location = New System.Drawing.Point(0, 0)
        Me.TopBar.Name = "TopBar"
        Me.TopBar.Size = New System.Drawing.Size(504, 33)
        Me.TopBar.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightCoral
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(448, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 3
        '
        'ExitButton
        '
        Me.ExitButton.AutoSize = True
        Me.ExitButton.BackColor = System.Drawing.Color.LightCoral
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Location = New System.Drawing.Point(478, 6)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(20, 20)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "X"
        '
        'TopTitle
        '
        Me.TopTitle.AutoSize = True
        Me.TopTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopTitle.ForeColor = System.Drawing.Color.White
        Me.TopTitle.Location = New System.Drawing.Point(43, 5)
        Me.TopTitle.Name = "TopTitle"
        Me.TopTitle.Size = New System.Drawing.Size(103, 21)
        Me.TopTitle.TabIndex = 1
        Me.TopTitle.Text = "Proxy Service"
        '
        'TopIcon
        '
        Me.TopIcon.BackgroundImage = CType(resources.GetObject("TopIcon.BackgroundImage"), System.Drawing.Image)
        Me.TopIcon.Location = New System.Drawing.Point(8, 0)
        Me.TopIcon.Name = "TopIcon"
        Me.TopIcon.Size = New System.Drawing.Size(32, 32)
        Me.TopIcon.TabIndex = 1
        '
        'ConnectPanel
        '
        Me.ConnectPanel.BackColor = System.Drawing.Color.DarkGray
        Me.ConnectPanel.Controls.Add(Me.ConnectLabel)
        Me.ConnectPanel.Location = New System.Drawing.Point(0, 32)
        Me.ConnectPanel.Name = "ConnectPanel"
        Me.ConnectPanel.Size = New System.Drawing.Size(100, 25)
        Me.ConnectPanel.TabIndex = 1
        '
        'ConnectLabel
        '
        Me.ConnectLabel.AutoSize = True
        Me.ConnectLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectLabel.ForeColor = System.Drawing.Color.White
        Me.ConnectLabel.Location = New System.Drawing.Point(17, 3)
        Me.ConnectLabel.Name = "ConnectLabel"
        Me.ConnectLabel.Size = New System.Drawing.Size(65, 20)
        Me.ConnectLabel.TabIndex = 5
        Me.ConnectLabel.Text = "Connect"
        '
        'SettingsPanel
        '
        Me.SettingsPanel.BackColor = System.Drawing.Color.DarkGray
        Me.SettingsPanel.Controls.Add(Me.SettingsLabel)
        Me.SettingsPanel.Location = New System.Drawing.Point(101, 32)
        Me.SettingsPanel.Name = "SettingsPanel"
        Me.SettingsPanel.Size = New System.Drawing.Size(100, 25)
        Me.SettingsPanel.TabIndex = 2
        '
        'SettingsLabel
        '
        Me.SettingsLabel.AutoSize = True
        Me.SettingsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsLabel.ForeColor = System.Drawing.Color.White
        Me.SettingsLabel.Location = New System.Drawing.Point(19, 3)
        Me.SettingsLabel.Name = "SettingsLabel"
        Me.SettingsLabel.Size = New System.Drawing.Size(63, 20)
        Me.SettingsLabel.TabIndex = 6
        Me.SettingsLabel.Text = "Settings"
        '
        'HelpPanel
        '
        Me.HelpPanel.BackColor = System.Drawing.Color.DarkGray
        Me.HelpPanel.Controls.Add(Me.HelpLabel)
        Me.HelpPanel.Location = New System.Drawing.Point(202, 32)
        Me.HelpPanel.Name = "HelpPanel"
        Me.HelpPanel.Size = New System.Drawing.Size(100, 25)
        Me.HelpPanel.TabIndex = 2
        '
        'HelpLabel
        '
        Me.HelpLabel.AutoSize = True
        Me.HelpLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpLabel.ForeColor = System.Drawing.Color.White
        Me.HelpLabel.Location = New System.Drawing.Point(30, 3)
        Me.HelpLabel.Name = "HelpLabel"
        Me.HelpLabel.Size = New System.Drawing.Size(41, 20)
        Me.HelpLabel.TabIndex = 7
        Me.HelpLabel.Text = "Help"
        '
        'UpdatePanel
        '
        Me.UpdatePanel.BackColor = System.Drawing.Color.DarkGray
        Me.UpdatePanel.Controls.Add(Me.UpdateLabel)
        Me.UpdatePanel.Location = New System.Drawing.Point(303, 32)
        Me.UpdatePanel.Name = "UpdatePanel"
        Me.UpdatePanel.Size = New System.Drawing.Size(100, 25)
        Me.UpdatePanel.TabIndex = 3
        '
        'UpdateLabel
        '
        Me.UpdateLabel.AutoSize = True
        Me.UpdateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateLabel.ForeColor = System.Drawing.Color.White
        Me.UpdateLabel.Location = New System.Drawing.Point(22, 3)
        Me.UpdateLabel.Name = "UpdateLabel"
        Me.UpdateLabel.Size = New System.Drawing.Size(59, 20)
        Me.UpdateLabel.TabIndex = 8
        Me.UpdateLabel.Text = "Update"
        '
        'ConsolePanel
        '
        Me.ConsolePanel.BackColor = System.Drawing.Color.DarkGray
        Me.ConsolePanel.Controls.Add(Me.ConsoleLabel)
        Me.ConsolePanel.Location = New System.Drawing.Point(404, 32)
        Me.ConsolePanel.Name = "ConsolePanel"
        Me.ConsolePanel.Size = New System.Drawing.Size(100, 25)
        Me.ConsolePanel.TabIndex = 4
        '
        'ConsoleLabel
        '
        Me.ConsoleLabel.AutoSize = True
        Me.ConsoleLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsoleLabel.ForeColor = System.Drawing.Color.White
        Me.ConsoleLabel.Location = New System.Drawing.Point(19, 3)
        Me.ConsoleLabel.Name = "ConsoleLabel"
        Me.ConsoleLabel.Size = New System.Drawing.Size(63, 20)
        Me.ConsoleLabel.TabIndex = 8
        Me.ConsoleLabel.Text = "Console"
        '
        'DisplayArea
        '
        Me.DisplayArea.Location = New System.Drawing.Point(1, 58)
        Me.DisplayArea.Name = "DisplayArea"
        Me.DisplayArea.Size = New System.Drawing.Size(502, 240)
        Me.DisplayArea.TabIndex = 5
        '
        'Proxy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(504, 300)
        Me.Controls.Add(Me.DisplayArea)
        Me.Controls.Add(Me.ConsolePanel)
        Me.Controls.Add(Me.UpdatePanel)
        Me.Controls.Add(Me.HelpPanel)
        Me.Controls.Add(Me.SettingsPanel)
        Me.Controls.Add(Me.ConnectPanel)
        Me.Controls.Add(Me.TopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Proxy"
        Me.Text = "Form1"
        Me.TopBar.ResumeLayout(False)
        Me.TopBar.PerformLayout()
        Me.ConnectPanel.ResumeLayout(False)
        Me.ConnectPanel.PerformLayout()
        Me.SettingsPanel.ResumeLayout(False)
        Me.SettingsPanel.PerformLayout()
        Me.HelpPanel.ResumeLayout(False)
        Me.HelpPanel.PerformLayout()
        Me.UpdatePanel.ResumeLayout(False)
        Me.UpdatePanel.PerformLayout()
        Me.ConsolePanel.ResumeLayout(False)
        Me.ConsolePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopBar As Panel
    Friend WithEvents TopIcon As Panel
    Friend WithEvents TopTitle As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ExitButton As Label
    Friend WithEvents ConnectPanel As Panel
    Friend WithEvents SettingsPanel As Panel
    Friend WithEvents HelpPanel As Panel
    Friend WithEvents UpdatePanel As Panel
    Friend WithEvents ConsolePanel As Panel
    Friend WithEvents ConnectLabel As Label
    Friend WithEvents SettingsLabel As Label
    Friend WithEvents HelpLabel As Label
    Friend WithEvents UpdateLabel As Label
    Friend WithEvents ConsoleLabel As Label
    Friend WithEvents DisplayArea As Panel
End Class
