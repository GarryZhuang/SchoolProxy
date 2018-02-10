<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuConnect
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuConnect))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusDisp = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UserIP = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelSSLTLS = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ForwardedDisplay = New System.Windows.Forms.Label()
        Me.DiscardedDisplay = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PacketsDisplay = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PacketsMonitor = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UploadCertificate = New System.Windows.Forms.Button()
        Me.CertificateSelector = New System.Windows.Forms.OpenFileDialog()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.IPGrabber = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.StatusDisp)
        Me.Panel1.Location = New System.Drawing.Point(4, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(90, 90)
        Me.Panel1.TabIndex = 0
        '
        'StatusDisp
        '
        Me.StatusDisp.BackColor = System.Drawing.Color.Transparent
        Me.StatusDisp.BackgroundImage = Global.SchoolProxy.My.Resources.Resources.WAIT
        Me.StatusDisp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusDisp.Location = New System.Drawing.Point(40, 40)
        Me.StatusDisp.Name = "StatusDisp"
        Me.StatusDisp.Size = New System.Drawing.Size(50, 50)
        Me.StatusDisp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(107, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Status:"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.ForeColor = System.Drawing.Color.Yellow
        Me.StatusLabel.Location = New System.Drawing.Point(164, 12)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(122, 13)
        Me.StatusLabel.TabIndex = 2
        Me.StatusLabel.Text = "Checking your internet..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(105, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Your IP:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(99, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Proxy IP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(95, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "SSL/TLS:"
        '
        'UserIP
        '
        Me.UserIP.AutoSize = True
        Me.UserIP.ForeColor = System.Drawing.Color.Red
        Me.UserIP.Location = New System.Drawing.Point(164, 38)
        Me.UserIP.Name = "UserIP"
        Me.UserIP.Size = New System.Drawing.Size(40, 13)
        Me.UserIP.TabIndex = 6
        Me.UserIP.Text = "0.0.0.0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(164, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "0.0.0.0"
        '
        'LabelSSLTLS
        '
        Me.LabelSSLTLS.AutoSize = True
        Me.LabelSSLTLS.ForeColor = System.Drawing.Color.Orange
        Me.LabelSSLTLS.Location = New System.Drawing.Point(164, 85)
        Me.LabelSSLTLS.Name = "LabelSSLTLS"
        Me.LabelSSLTLS.Size = New System.Drawing.Size(71, 13)
        Me.LabelSSLTLS.TabIndex = 8
        Me.LabelSSLTLS.Text = "No Certificate"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.LabelSSLTLS)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.StatusLabel)
        Me.GroupBox1.Controls.Add(Me.UserIP)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(4, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 107)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ForwardedDisplay)
        Me.GroupBox2.Controls.Add(Me.DiscardedDisplay)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.PacketsDisplay)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(307, -3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 107)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'ForwardedDisplay
        '
        Me.ForwardedDisplay.AutoSize = True
        Me.ForwardedDisplay.ForeColor = System.Drawing.Color.Orange
        Me.ForwardedDisplay.Location = New System.Drawing.Point(123, 80)
        Me.ForwardedDisplay.Name = "ForwardedDisplay"
        Me.ForwardedDisplay.Size = New System.Drawing.Size(13, 13)
        Me.ForwardedDisplay.TabIndex = 5
        Me.ForwardedDisplay.Text = "0"
        '
        'DiscardedDisplay
        '
        Me.DiscardedDisplay.AutoSize = True
        Me.DiscardedDisplay.ForeColor = System.Drawing.Color.Tomato
        Me.DiscardedDisplay.Location = New System.Drawing.Point(123, 55)
        Me.DiscardedDisplay.Name = "DiscardedDisplay"
        Me.DiscardedDisplay.Size = New System.Drawing.Size(13, 13)
        Me.DiscardedDisplay.TabIndex = 4
        Me.DiscardedDisplay.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(9, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 18)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Packets Forwarded"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(14, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Packets Discarded"
        '
        'PacketsDisplay
        '
        Me.PacketsDisplay.ForeColor = System.Drawing.Color.LightGreen
        Me.PacketsDisplay.Location = New System.Drawing.Point(30, 27)
        Me.PacketsDisplay.Name = "PacketsDisplay"
        Me.PacketsDisplay.Size = New System.Drawing.Size(134, 23)
        Me.PacketsDisplay.TabIndex = 1
        Me.PacketsDisplay.Text = "0/0"
        Me.PacketsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(29, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Packets Sent/Received"
        '
        'PacketsMonitor
        '
        Me.PacketsMonitor.Interval = 1000
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(336, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 29)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(336, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 29)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Disconnect"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UploadCertificate
        '
        Me.UploadCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UploadCertificate.ForeColor = System.Drawing.Color.GreenYellow
        Me.UploadCertificate.Location = New System.Drawing.Point(433, 170)
        Me.UploadCertificate.Name = "UploadCertificate"
        Me.UploadCertificate.Size = New System.Drawing.Size(62, 29)
        Me.UploadCertificate.TabIndex = 13
        Me.UploadCertificate.Tag = ""
        Me.UploadCertificate.Text = "SSL/TLS"
        Me.UploadCertificate.UseVisualStyleBackColor = True
        '
        'CertificateSelector
        '
        Me.CertificateSelector.FileName = "Certificate File"
        Me.CertificateSelector.Tag = "*.cer|"
        Me.CertificateSelector.Title = "Select a SSL/TLS Certificate"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"[Netspace Direct] Wheeler's Hill SC"})
        Me.ComboBox1.Location = New System.Drawing.Point(7, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(314, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Select Proxy to Connect:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 164)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(327, 73)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'IPGrabber
        '
        Me.IPGrabber.WorkerSupportsCancellation = True
        '
        'MenuConnect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.UploadCertificate)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MenuConnect"
        Me.Size = New System.Drawing.Size(502, 240)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents StatusDisp As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents UserIP As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelSSLTLS As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PacketsDisplay As Label
    Friend WithEvents PacketsMonitor As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ForwardedDisplay As Label
    Friend WithEvents DiscardedDisplay As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents UploadCertificate As Button
    Friend WithEvents CertificateSelector As OpenFileDialog
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents IPGrabber As System.ComponentModel.BackgroundWorker
End Class
