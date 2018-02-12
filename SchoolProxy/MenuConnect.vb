Imports System.IO 'File Reader, Writer & Manager
Imports System.Net 'Network Settings
Imports System.Net.NetworkInformation 'Internet Traffic Logging Service
Imports System.Environment 'Error Logging Service

Public Class MenuConnect

    Dim Properties As IPGlobalProperties 'Internet Properties 
    Dim StatV4 As IPGlobalStatistics 'Internet Statistics

    Dim PacketHostName As String 'Packet Host Name
    Dim PacketReceived As String 'Packet Received
    Dim PacketDelivered As String 'Packet Delivered
    Dim PacketDiscarded As String 'Packet Discarded
    Dim PacketForwarded As String 'Packet Forwarded

    Dim PacketUserDisplay As String 'Packet User Display

    Private Sub PacketsMonitor_Tick(sender As Object, e As EventArgs) Handles PacketsMonitor.Tick
        Properties = IPGlobalProperties.GetIPGlobalProperties 'Define Properties
        StatV4 = Properties.GetIPv4GlobalStatistics 'Define Network IVP4 Statistics

        PacketHostName = Properties.HostName 'Host Name
        PacketReceived = StatV4.ReceivedPackets 'Received Packets
        PacketDelivered = StatV4.ReceivedPacketsDelivered 'Delivered Packets
        PacketDiscarded = StatV4.ReceivedPacketsDiscarded 'Discarded Packets
        PacketForwarded = StatV4.ReceivedPacketsForwarded 'Forwarded Packets

        PacketUserDisplay = PacketReceived.ToString & "/" & PacketDelivered.ToString 'Packet User Display

        PacketsDisplay.Text = PacketUserDisplay 'Display the Information
        DiscardedDisplay.Text = PacketDiscarded 'Display the Information
        ForwardedDisplay.Text = PacketForwarded 'Display the Information
    End Sub

    Private Sub MenuConnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False 'Keep this off, allows illegal cross threads

        PacketsMonitor.Start() 'Start the packet monitor (Can be used offline)

        If My.Computer.Network.IsAvailable = True Then              'There is network
            StatusLabel.Text = "Ready to Connect..."
            StatusLabel.ForeColor = Color.LightGreen
            StatusDisp.BackgroundImage = My.Resources.OK

            IPGrabber.WorkerSupportsCancellation = True             'Assure that BackgroundWorker can be stopped
            IPGrabber.RunWorkerAsync()                              'Start the background worker

        Else                                                        'No network detected
            StatusLabel.Text = "No Internet Connection."
            StatusLabel.ForeColor = Color.Orange
            StatusDisp.BackgroundImage = My.Resources.WARNING
        End If
    End Sub

    Private Sub UploadCertificate_Click(sender As Object, e As EventArgs) Handles UploadCertificate.Click
        CertificateSelector.ShowDialog() 'Show the certificate selector
    End Sub

    Private Sub IPGrabber_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles IPGrabber.DoWork

        If IPGrabber.CancellationPending Then 'Check if BackgroundWorker has been terminated
            e.Cancel = True 'Cancel the background worker
            Return 'Return to code
        End If

        Try
            Dim req As HttpWebRequest = WebRequest.Create("http://schoolappip.000webhostapp.com/") 'IP Request site
            Dim res As HttpWebResponse = req.GetResponse()
            Dim Stream As Stream = res.GetResponseStream()
            Dim sr As StreamReader = New StreamReader(Stream)
            UserIP.Text = (sr.ReadToEnd())
            UserIP.ForeColor = Color.Cyan
            IPGrabber.CancelAsync() 'Cancel the Background worker
        Catch ex As Exception
            ErrorLoggingService(ex.ToString)
        End Try

    End Sub

    Public Sub ErrorLoggingService(ByVal ErrorMSG As String)
        Dim RandomSystem As Random = New Random
        Dim RandomID = RandomSystem.Next(10000000, 99999999)

        Dim AppDataFilePath As String = GetFolderPath(SpecialFolder.ApplicationData)
        My.Computer.FileSystem.WriteAllText(AppDataFilePath & "\SchoolProxy\" & RandomID & "_[Crash].dmp", ErrorMSG, False)
        Application.Run(New ErrorReporter())
    End Sub

End Class
