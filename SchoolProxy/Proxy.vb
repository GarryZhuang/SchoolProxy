Public Class Proxy

    Private Sub Proxy_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    ' Exiting the application :: Animations/Actions
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub
    Private Sub ExitButton_MouseEnter(sender As Object, e As EventArgs) Handles ExitButton.MouseEnter
        ExitButton.BackColor = Color.IndianRed
    End Sub
    Private Sub ExitButton_MouseLeave(sender As Object, e As EventArgs) Handles ExitButton.MouseLeave
        ExitButton.BackColor = Color.LightCoral
    End Sub

    'ConnectPanel
    Private Sub ConnectPanel_MouseEnter(sender As Object, e As EventArgs) Handles ConnectPanel.MouseEnter
        If ConnectPanel.BackColor = Color.DarkGray Then
            ConnectPanel.BackColor = Color.Gray
            ConnectLabel.BackColor = Color.Gray
        End If
    End Sub
    Private Sub ConnectPanel_MouseLeave(sender As Object, e As EventArgs) Handles ConnectPanel.MouseLeave
        If ConnectPanel.BackColor = Color.DimGray Then
        Else
            ConnectPanel.BackColor = Color.DarkGray
            ConnectLabel.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub ConnectPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles ConnectPanel.MouseClick
        DisplayArea.Controls.Clear()

        Dim UserControl As New MenuConnect
        DisplayArea.Controls.Add(UserControl)

        ConnectPanel.BackColor = Color.DimGray
        ConnectLabel.BackColor = Color.DimGray

        SettingsPanel.BackColor = Color.DarkGray
        HelpPanel.BackColor = Color.DarkGray
        UpdatePanel.BackColor = Color.DarkGray
        ConsolePanel.BackColor = Color.DarkGray
    End Sub
    Private Sub ConnectLabel_Click(sender As Object, e As EventArgs) Handles ConnectLabel.Click
        DisplayArea.Controls.Clear()

        Dim UserControl As New MenuConnect
        DisplayArea.Controls.Add(UserControl)

        ConnectPanel.BackColor = Color.DimGray
        ConnectLabel.BackColor = Color.DimGray

        ConnectPanel.BackColor = Color.DimGray
        SettingsPanel.BackColor = Color.DarkGray
        HelpPanel.BackColor = Color.DarkGray
        UpdatePanel.BackColor = Color.DarkGray
        ConsolePanel.BackColor = Color.DarkGray
    End Sub
    Private Sub ConnectLabel_MouseEnter(sender As Object, e As EventArgs) Handles ConnectLabel.MouseEnter

    End Sub
    Private Sub ConnectLabel_MouseLeave(sender As Object, e As EventArgs) Handles ConnectLabel.MouseLeave

    End Sub


    'SettingsPanel
    Private Sub SettingsPanel_MouseEnter(sender As Object, e As EventArgs) Handles SettingsPanel.MouseEnter
        If SettingsPanel.BackColor = Color.DarkGray Then
            SettingsPanel.BackColor = Color.Gray
        End If
    End Sub
    Private Sub SettingsPanel_MouseLeave(sender As Object, e As EventArgs) Handles SettingsPanel.MouseLeave
        If SettingsPanel.BackColor = Color.DimGray Then
        Else
            SettingsPanel.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub SettingsPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles SettingsPanel.MouseClick
        ConnectPanel.BackColor = Color.DarkGray
        SettingsPanel.BackColor = Color.DimGray
        HelpPanel.BackColor = Color.DarkGray
        UpdatePanel.BackColor = Color.DarkGray
        ConsolePanel.BackColor = Color.DarkGray
    End Sub
    Private Sub SettingsLabel_Click(sender As Object, e As EventArgs) Handles SettingsLabel.Click

    End Sub
    Private Sub SettingsLabel_MouseEnter(sender As Object, e As EventArgs) Handles SettingsLabel.MouseEnter

    End Sub
    Private Sub SettingsLabel_MouseLeave(sender As Object, e As EventArgs) Handles SettingsLabel.MouseLeave

    End Sub

    'HelpPanel
    Private Sub HelpPanel_MouseEnter(sender As Object, e As EventArgs) Handles HelpPanel.MouseEnter
        If HelpPanel.BackColor = Color.DarkGray Then
            HelpPanel.BackColor = Color.Gray
        End If
    End Sub
    Private Sub HelpPanel_MouseLeave(sender As Object, e As EventArgs) Handles HelpPanel.MouseLeave
        If HelpPanel.BackColor = Color.DimGray Then
        Else
            HelpPanel.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub HelpPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles HelpPanel.MouseClick
        ConnectPanel.BackColor = Color.DarkGray
        SettingsPanel.BackColor = Color.DarkGray
        HelpPanel.BackColor = Color.DimGray
        UpdatePanel.BackColor = Color.DarkGray
        ConsolePanel.BackColor = Color.DarkGray
    End Sub
    Private Sub HelpLabel_Click(sender As Object, e As EventArgs) Handles HelpLabel.Click

    End Sub
    Private Sub HelpLabel_MouseEnter(sender As Object, e As EventArgs) Handles HelpLabel.MouseEnter

    End Sub
    Private Sub HelpLabel_MouseLeave(sender As Object, e As EventArgs) Handles HelpLabel.MouseLeave

    End Sub

    'UpdatePanel
    Private Sub UpdatePanel_MouseEnter(sender As Object, e As EventArgs) Handles UpdatePanel.MouseEnter
        If UpdatePanel.BackColor = Color.DarkGray Then
            UpdatePanel.BackColor = Color.Gray
        End If
    End Sub
    Private Sub UpdatePanel_MouseLeave(sender As Object, e As EventArgs) Handles UpdatePanel.MouseLeave
        If UpdatePanel.BackColor = Color.DimGray Then
        Else
            UpdatePanel.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub UpdatePanel_MouseClick(sender As Object, e As MouseEventArgs) Handles UpdatePanel.MouseClick
        ConnectPanel.BackColor = Color.DarkGray
        SettingsPanel.BackColor = Color.DarkGray
        HelpPanel.BackColor = Color.DarkGray
        UpdatePanel.BackColor = Color.DimGray
        ConsolePanel.BackColor = Color.DarkGray
    End Sub
    Private Sub UpdateLabel_Click(sender As Object, e As EventArgs) Handles UpdateLabel.Click

    End Sub
    Private Sub UpdateLabel_MouseEnter(sender As Object, e As EventArgs) Handles UpdateLabel.MouseEnter

    End Sub
    Private Sub UpdateLabel_MouseLeave(sender As Object, e As EventArgs) Handles UpdateLabel.MouseLeave

    End Sub

    'ConsolePanel
    Private Sub ConsolePanel_MouseEnter(sender As Object, e As EventArgs) Handles ConsolePanel.MouseEnter
        If ConsolePanel.BackColor = Color.DarkGray Then
            ConsolePanel.BackColor = Color.Gray
        End If
    End Sub
    Private Sub ConsolePanel_MouseLeave(sender As Object, e As EventArgs) Handles ConsolePanel.MouseLeave
        If ConsolePanel.BackColor = Color.DimGray Then
        Else
            ConsolePanel.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub ConsolePanel_MouseClick(sender As Object, e As MouseEventArgs) Handles ConsolePanel.MouseClick
        ConnectPanel.BackColor = Color.DarkGray
        SettingsPanel.BackColor = Color.DarkGray
        HelpPanel.BackColor = Color.DarkGray
        UpdatePanel.BackColor = Color.DarkGray
        ConsolePanel.BackColor = Color.DimGray
    End Sub
    Private Sub ConsoleLabel_Click(sender As Object, e As EventArgs) Handles ConsoleLabel.Click

    End Sub
    Private Sub ConsoleLabel_MouseEnter(sender As Object, e As EventArgs) Handles ConsoleLabel.MouseEnter

    End Sub
    Private Sub ConsoleLabel_MouseLeave(sender As Object, e As EventArgs) Handles ConsoleLabel.MouseLeave

    End Sub

End Class
