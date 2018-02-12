Public Class ErrorReporter
    Private Async Sub ErrorReporter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar.Style = ProgressBarStyle.Marquee
        ProgressBar.MarqueeAnimationSpeed = 30
        Await Task.Delay(3000)
        Me.Close()
    End Sub
End Class