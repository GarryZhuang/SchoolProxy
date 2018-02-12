Imports System
Imports System.Runtime.InteropServices
Imports System.Environment
Imports System.IO

Public Class MenuConsole


    Private Sub MenuConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim UserDefinedConfigFile(5) As String 'User defined startup commands 
        Dim CurrentLine As Integer = 0

        Dim AppDataFilePath As String = GetFolderPath(SpecialFolder.ApplicationData)

        If My.Computer.FileSystem.FileExists(AppDataFilePath & "\SchoolProxy\ConsoleConfig.ini") Then
            For Each line As String In File.ReadLines(AppDataFilePath & "\SchoolProxy\ConsoleConfig.ini")
                UserDefinedConfigFile(CurrentLine) = line.ToString()
                CurrentLine = CurrentLine + 1
            Next
        Else
            If Not My.Computer.FileSystem.DirectoryExists(AppDataFilePath & "\SchoolProxy\") Then
                My.Computer.FileSystem.CreateDirectory(AppDataFilePath & "\SchoolProxy\")
            End If
            My.Computer.FileSystem.WriteAllText(AppDataFilePath & "\SchoolProxy\ConsoleConfig.ini", "help-s", False)
            For Each line As String In File.ReadLines(AppDataFilePath & "\SchoolProxy\ConsoleConfig.ini")
                UserDefinedConfigFile(CurrentLine) = line.ToString()
                CurrentLine = CurrentLine + 1
            Next
        End If


        Dim UserDefinedStartupCMD_0 As String = UserDefinedConfigFile(0)
        Dim UserDefinedStartupCMD_1 As String = UserDefinedConfigFile(1)
        Dim UserDefinedStartupCMD_2 As String = UserDefinedConfigFile(2)
        Dim UserDefinedStartupCMD_3 As String = UserDefinedConfigFile(3)
        Dim UserDefinedStartupCMD_4 As String = UserDefinedConfigFile(4)
        Dim UserDefinedStartupCMD_5 As String = UserDefinedConfigFile(5)

        If Not UserDefinedStartupCMD_0 = "" Then
            ConsoleDisplay.Items.Add(ConsoleManager(UserDefinedStartupCMD_0))
        End If
        If Not UserDefinedStartupCMD_1 = "" Then
            ConsoleDisplay.Items.Add(ConsoleManager(UserDefinedStartupCMD_1))
        End If
        If Not UserDefinedStartupCMD_2 = "" Then
            ConsoleDisplay.Items.Add(ConsoleManager(UserDefinedStartupCMD_2))
        End If
        If Not UserDefinedStartupCMD_3 = "" Then
            ConsoleDisplay.Items.Add(ConsoleManager(UserDefinedStartupCMD_3))
        End If
        If Not UserDefinedStartupCMD_4 = "" Then
            ConsoleDisplay.Items.Add(ConsoleManager(UserDefinedStartupCMD_4))
        End If
        If Not UserDefinedStartupCMD_5 = "" Then
            ConsoleDisplay.Items.Add(ConsoleManager(UserDefinedStartupCMD_5))
        End If
    End Sub

    Private Sub ConsoleEntry_KeyDown(sender As Object, e As KeyEventArgs) Handles ConsoleEntry.KeyDown
        If e.KeyCode = Keys.Enter Then
            ConsoleDisplay.Items.Add(ConsoleManager(ConsoleEntry.Text))
            ConsoleEntry.Clear()
        End If
    End Sub

#Disable Warning BC42105
    Private Function ConsoleManager(ByVal command As String)

        Select Case command
            Case "help-s"
                Return "SchoolProxy Console! Type 'help' for commands."

            Case "clear"
                ConsoleDisplay.Items.Clear()
                Return "History Cleared."
            Case "help"
                Return "Commands: clear"
            Case Else

                If command.Contains("summon") Then
                    Dim CMDAction = command.Split(" ")(1)
                    Dim ReturnTXT As String = "For help do 'summon -h'"
                    If CMDAction = "errorhelper" Then
                        ErrorReporter.Show()
                        ReturnTXT = "Showing Error Helper"
                    End If
                    If CMDAction = "errorhelper -d" Then
                        ErrorReporter.ShowDialog()
                        ReturnTXT = "Showing Error Helper Dialogue"
                    End If
                    If CMDAction = "-h" Then
                        ReturnTXT = "errorhelper"
                    End If

                    Return ("Object Summoner: " & ReturnTXT)
                Else
                    Return "Invalid Command. Type 'help' for commands."
                End If
        End Select

    End Function
#Enable Warning BC42105


End Class
