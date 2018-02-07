Imports System.ComponentModel

Public Class Proxy

    Dim UserSelectedMenu As String

    Private Sub Proxy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConnectPanel.BackColor = Color.DimGray
        UserSelectedMenu = "connect"

        Dim DispMenu0 As New MenuConnect 'Define Menu
        DisplayArea.Controls.Add(DispMenu0) 'Add the Menu

        Dim DispMenu1 As New MenuSetting 'Define Menu
        DisplayArea.Controls.Add(DispMenu1) 'Add the Menu

        Dim DispMenu2 As New MenuHelp 'Define Menu
        DisplayArea.Controls.Add(DispMenu2) 'Add the Menu

        Dim DispMenu3 As New MenuUpdate 'Define Menu
        DisplayArea.Controls.Add(DispMenu3) 'Add the Menu

        Dim DispMenu4 As New MenuConsole 'Define Menu
        DisplayArea.Controls.Add(DispMenu4) 'Add the Menu
    End Sub



#Region "Panel Animations"

    ' Panel Animations
    ' Last checked on 6/2/18
    ' Should not cause errors


    'ConnectPanel
    Private Sub ConnectPanel_MouseEnter(sender As Object, e As EventArgs) Handles ConnectPanel.MouseEnter
        If UserSelectedMenu = "connect" Then
        Else
            ConnectPanel.BackColor = Color.Gray
        End If
    End Sub
    Private Sub ConnectPanel_MouseLeave(sender As Object, e As EventArgs) Handles ConnectPanel.MouseLeave
        If UserSelectedMenu = "connect" Then
        Else
            ConnectPanel.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub ConnectPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles ConnectPanel.MouseClick
        UserSelectedMenu = "connect"
        ConnectPanel.BackColor = Color.DimGray
        SettingsPanel.BackColor = Color.DarkGray
        HelpPanel.BackColor = Color.DarkGray
        UpdatePanel.BackColor = Color.DarkGray
        ConsolePanel.BackColor = Color.DarkGray
        HandleMouseClickActions(UserSelectedMenu)
    End Sub

    'ConnectLabel
    Private Sub ConnectLabel_MouseEnter(sender As Object, e As EventArgs) Handles ConnectLabel.MouseEnter
        If UserSelectedMenu = "connect" Then
        Else
            ConnectPanel.BackColor = Color.Gray
        End If
    End Sub
    Private Sub ConnectLabel_MouseLeave(sender As Object, e As EventArgs) Handles ConnectLabel.MouseLeave
        If UserSelectedMenu = "connect" Then
        Else
            ConnectPanel.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub ConnectLabel_Click(sender As Object, e As EventArgs) Handles ConnectLabel.Click
        UserSelectedMenu = "connect"
        ConnectPanel.BackColor = Color.DimGray
        SettingsPanel.BackColor = Color.DarkGray
        HelpPanel.BackColor = Color.DarkGray
        UpdatePanel.BackColor = Color.DarkGray
        ConsolePanel.BackColor = Color.DarkGray
        HandleMouseClickActions(UserSelectedMenu)
    End Sub


    'SettingsPanel
    Private Sub SettingsPanel_MouseEnter(sender As Object, e As EventArgs) Handles SettingsPanel.MouseEnter
        If UserSelectedMenu = "setting" Then
        Else
            SettingsPanel.BackColor = Color.Gray
        End If
    End Sub
    Private Sub SettingsPanel_MouseLeave(sender As Object, e As EventArgs) Handles SettingsPanel.MouseLeave
        If UserSelectedMenu = "setting" Then
        Else
            SettingsPanel.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub SettingsPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles SettingsPanel.MouseClick
        UserSelectedMenu = "setting"
        ConnectPanel.BackColor = Color.DarkGray
        SettingsPanel.BackColor = Color.DimGray
        HelpPanel.BackColor = Color.DarkGray
        UpdatePanel.BackColor = Color.DarkGray
        ConsolePanel.BackColor = Color.DarkGray
        HandleMouseClickActions(UserSelectedMenu)
    End Sub

    'SettingsLabel
    Private Sub SettingsLabel_MouseEnter(sender As Object, e As EventArgs) Handles SettingsLabel.MouseEnter
        If UserSelectedMenu = "setting" Then
        Else
            SettingsPanel.BackColor = Color.Gray
        End If
    End Sub
    Private Sub SettingsLabel_MouseLeave(sender As Object, e As EventArgs) Handles SettingsLabel.MouseLeave
        If UserSelectedMenu = "setting" Then
        Else
            SettingsPanel.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub SettingsLabel_Click(sender As Object, e As EventArgs) Handles SettingsLabel.Click
        UserSelectedMenu = "setting"
        ConnectPanel.BackColor = Color.DarkGray
        SettingsPanel.BackColor = Color.DimGray
        HelpPanel.BackColor = Color.DarkGray
        UpdatePanel.BackColor = Color.DarkGray
        ConsolePanel.BackColor = Color.DarkGray
        HandleMouseClickActions(UserSelectedMenu)
    End Sub



    'HelpPanel
    Private Sub HelpPanel_MouseEnter(sender As Object, e As EventArgs) Handles HelpPanel.MouseEnter
        If UserSelectedMenu = "help" Then
        Else
            HelpPanel.BackColor = Color.Gray
        End If
    End Sub
    Private Sub HelpPanel_MouseLeave(sender As Object, e As EventArgs) Handles HelpPanel.MouseLeave
        If UserSelectedMenu = "help" Then
        Else
            HelpPanel.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub HelpPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles HelpPanel.MouseClick
        UserSelectedMenu = "help"
        ConnectPanel.BackColor = Color.DarkGray
        SettingsPanel.BackColor = Color.DarkGray
        HelpPanel.BackColor = Color.DimGray
        UpdatePanel.BackColor = Color.DarkGray
        ConsolePanel.BackColor = Color.DarkGray
        HandleMouseClickActions(UserSelectedMenu)
    End Sub

    'HelpLabel
    Private Sub HelpLabel_MouseEnter(sender As Object, e As EventArgs) Handles HelpLabel.MouseEnter
        If UserSelectedMenu = "help" Then
        Else
            HelpPanel.BackColor = Color.Gray
        End If
    End Sub
    Private Sub HelpLabel_MouseLeave(sender As Object, e As EventArgs) Handles HelpLabel.MouseLeave
        If UserSelectedMenu = "help" Then
        Else
            HelpPanel.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub HelpLabel_Click(sender As Object, e As EventArgs) Handles HelpLabel.Click
        UserSelectedMenu = "help"
        ConnectPanel.BackColor = Color.DarkGray
        SettingsPanel.BackColor = Color.DarkGray
        HelpPanel.BackColor = Color.DimGray
        UpdatePanel.BackColor = Color.DarkGray
        ConsolePanel.BackColor = Color.DarkGray
        HandleMouseClickActions(UserSelectedMenu)
    End Sub

    'UpdatePanel
    Private Sub UpdatePanel_MouseEnter(sender As Object, e As EventArgs) Handles UpdatePanel.MouseEnter
        If UserSelectedMenu = "update" Then
        Else
            UpdatePanel.BackColor = Color.Gray
        End If
    End Sub
    Private Sub UpdatePanel_MouseLeave(sender As Object, e As EventArgs) Handles UpdatePanel.MouseLeave
        If UserSelectedMenu = "update" Then
        Else
            UpdatePanel.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub UpdatePanel_MouseClick(sender As Object, e As MouseEventArgs) Handles UpdatePanel.MouseClick
        UserSelectedMenu = "update"
        ConnectPanel.BackColor = Color.DarkGray
        SettingsPanel.BackColor = Color.DarkGray
        HelpPanel.BackColor = Color.DarkGray
        UpdatePanel.BackColor = Color.DimGray
        ConsolePanel.BackColor = Color.DarkGray
        HandleMouseClickActions(UserSelectedMenu)
    End Sub

    'UpdateLabel
    Private Sub UpdateLabel_MouseEnter(sender As Object, e As EventArgs) Handles UpdateLabel.MouseEnter
        If UserSelectedMenu = "update" Then
        Else
            UpdatePanel.BackColor = Color.Gray
        End If
    End Sub
    Private Sub UpdateLabel_MouseLeave(sender As Object, e As EventArgs) Handles UpdateLabel.MouseLeave
        If UserSelectedMenu = "update" Then
        Else
            UpdatePanel.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub UpdateLabel_Click(sender As Object, e As EventArgs) Handles UpdateLabel.Click
        UserSelectedMenu = "update"
        ConnectPanel.BackColor = Color.DarkGray
        SettingsPanel.BackColor = Color.DarkGray
        HelpPanel.BackColor = Color.DarkGray
        UpdatePanel.BackColor = Color.DimGray
        ConsolePanel.BackColor = Color.DarkGray
        HandleMouseClickActions(UserSelectedMenu)
    End Sub

    'ConsolePanel
    Private Sub ConsolePanel_MouseEnter(sender As Object, e As EventArgs) Handles ConsolePanel.MouseEnter
        If UserSelectedMenu = "console" Then
        Else
            ConsolePanel.BackColor = Color.Gray
        End If
    End Sub
    Private Sub ConsolePanel_MouseLeave(sender As Object, e As EventArgs) Handles ConsolePanel.MouseLeave
        If UserSelectedMenu = "console" Then
        Else
            ConsolePanel.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub ConsolePanel_MouseClick(sender As Object, e As MouseEventArgs) Handles ConsolePanel.MouseClick
        UserSelectedMenu = "console"
        ConnectPanel.BackColor = Color.DarkGray
        SettingsPanel.BackColor = Color.DarkGray
        HelpPanel.BackColor = Color.DarkGray
        UpdatePanel.BackColor = Color.DarkGray
        ConsolePanel.BackColor = Color.DimGray
        HandleMouseClickActions(UserSelectedMenu)
    End Sub

    'ConsoleLabel
    Private Sub ConsoleLabel_MouseEnter(sender As Object, e As EventArgs) Handles ConsoleLabel.MouseEnter
        If UserSelectedMenu = "console" Then
        Else
            ConsolePanel.BackColor = Color.Gray
        End If
    End Sub
    Private Sub ConsoleLabel_MouseLeave(sender As Object, e As EventArgs) Handles ConsoleLabel.MouseLeave
        If UserSelectedMenu = "console" Then
        Else
            ConsolePanel.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub ConsoleLabel_Click(sender As Object, e As EventArgs) Handles ConsoleLabel.Click
        UserSelectedMenu = "console"
        ConnectPanel.BackColor = Color.DarkGray
        SettingsPanel.BackColor = Color.DarkGray
        HelpPanel.BackColor = Color.DarkGray
        UpdatePanel.BackColor = Color.DarkGray
        ConsolePanel.BackColor = Color.DimGray
        HandleMouseClickActions(UserSelectedMenu)
    End Sub

#End Region 'Top level animations for panel's

    Public Sub HandleMouseClickActions(ByVal MenuType As String)

        'Hide the display before showing to code, this prevents control(0) from overriding everything.
        DisplayArea.Controls(0).Hide()
        DisplayArea.Controls(1).Hide()
        DisplayArea.Controls(2).Hide()
        DisplayArea.Controls(3).Hide()
        DisplayArea.Controls(4).Hide()

        'Connect Control
        If MenuType = "connect" Then
            DisplayArea.Controls(0).Show()
        End If

        'Setting Control
        If MenuType = "setting" Then
            DisplayArea.Controls(1).Show()
        End If

        'Help Control
        If MenuType = "help" Then
            DisplayArea.Controls(2).Show()
        End If

        'Update Control
        If MenuType = "update" Then
            DisplayArea.Controls(3).Show()
        End If

        'Console Control
        If MenuType = "console" Then
            DisplayArea.Controls(4).Show()
        End If
    End Sub 'Top level panel menu navigation

#Region "Form Movement"

    'Allow's the user to move the form freely

    Dim IsUserDraggingForm As Boolean
    Dim FormMouseX As Integer
    Dim FormMouseY As Integer

    'Top Bar
    Private Sub TopBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TopBar.MouseDown
        IsUserDraggingForm = True
        FormMouseX = Cursor.Position.X - Left
        FormMouseY = Cursor.Position.Y - Top
    End Sub
    Private Sub TopBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TopBar.MouseMove
        If IsUserDraggingForm Then
            Left = Cursor.Position.X - FormMouseX
            Top = Cursor.Position.Y - FormMouseY
        End If
    End Sub
    Private Sub TopBar_MouseUp(sender As Object, e As MouseEventArgs) Handles TopBar.MouseUp
        IsUserDraggingForm = False
    End Sub

    'Top Title
    Private Sub TopTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles TopTitle.MouseDown
        IsUserDraggingForm = True
        FormMouseX = Cursor.Position.X - Left
        FormMouseY = Cursor.Position.Y - Top
    End Sub
    Private Sub TopTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles TopTitle.MouseMove
        If IsUserDraggingForm Then
            Left = Cursor.Position.X - FormMouseX
            Top = Cursor.Position.Y - FormMouseY
        End If
    End Sub
    Private Sub TopTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles TopTitle.MouseUp
        IsUserDraggingForm = False
    End Sub

    'Top Icon
    Private Sub TopIcon_MouseDown(sender As Object, e As MouseEventArgs) Handles TopIcon.MouseDown
        IsUserDraggingForm = True
        FormMouseX = Cursor.Position.X - Left
        FormMouseY = Cursor.Position.Y - Top
    End Sub
    Private Sub TopIcon_MouseMove(sender As Object, e As MouseEventArgs) Handles TopIcon.MouseMove
        If IsUserDraggingForm Then
            Left = Cursor.Position.X - FormMouseX
            Top = Cursor.Position.Y - FormMouseY
        End If
    End Sub
    Private Sub TopIcon_MouseUp(sender As Object, e As MouseEventArgs) Handles TopIcon.MouseUp
        IsUserDraggingForm = False
    End Sub
#End Region 'Form Mouse move actions

#Region "ExitSettings"

    ' Exiting the application :: Animations/Actions 

    'Animation to fade the form upon closing.
    Public Sub AnimationsFadeOut()
        For FadeOut = 90 To 10 Step -10
            Me.Opacity = FadeOut / 100
            Me.Refresh()
            Threading.Thread.Sleep(5)
        Next
    End Sub


    'Show the animations upon closing.
    Private Sub Proxy_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        AnimationsFadeOut()
    End Sub

    'Exit button click
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Exit Button Animations
    Private Sub ExitButton_MouseEnter(sender As Object, e As EventArgs) Handles ExitButton.MouseEnter
        ExitButton.BackColor = Color.IndianRed
    End Sub

    'Exit Button Animations
    Private Sub ExitButton_MouseLeave(sender As Object, e As EventArgs) Handles ExitButton.MouseLeave
        ExitButton.BackColor = Color.LightCoral
    End Sub
#End Region 'Exit actions including methods, animations and tasks.

End Class
