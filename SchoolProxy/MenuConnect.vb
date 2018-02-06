Imports System.Net.NetworkInformation 'Internet Traffic Logging Service

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
        PacketsMonitor.Start() 'Start the packet monitor

        If My.Computer.Network.IsAvailable = True Then
            StatusLabel.Text = "Ready to Connect..."
            StatusLabel.ForeColor = Color.LightGreen
            StatusDisp.BackgroundImage = My.Resources.OK
        End If
    End Sub
End Class
