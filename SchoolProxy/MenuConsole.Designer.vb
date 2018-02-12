<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuConsole
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ConsoleDisplay = New System.Windows.Forms.ListBox()
        Me.ConsoleEntry = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ConsoleDisplay
        '
        Me.ConsoleDisplay.BackColor = System.Drawing.Color.Black
        Me.ConsoleDisplay.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsoleDisplay.ForeColor = System.Drawing.Color.Lime
        Me.ConsoleDisplay.FormattingEnabled = True
        Me.ConsoleDisplay.Location = New System.Drawing.Point(3, 3)
        Me.ConsoleDisplay.Name = "ConsoleDisplay"
        Me.ConsoleDisplay.Size = New System.Drawing.Size(496, 212)
        Me.ConsoleDisplay.TabIndex = 0
        '
        'ConsoleEntry
        '
        Me.ConsoleEntry.BackColor = System.Drawing.Color.Black
        Me.ConsoleEntry.ForeColor = System.Drawing.Color.Lime
        Me.ConsoleEntry.Location = New System.Drawing.Point(3, 214)
        Me.ConsoleEntry.Name = "ConsoleEntry"
        Me.ConsoleEntry.Size = New System.Drawing.Size(496, 20)
        Me.ConsoleEntry.TabIndex = 1
        '
        'MenuConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.Controls.Add(Me.ConsoleEntry)
        Me.Controls.Add(Me.ConsoleDisplay)
        Me.Name = "MenuConsole"
        Me.Size = New System.Drawing.Size(502, 240)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConsoleDisplay As ListBox
    Friend WithEvents ConsoleEntry As TextBox
End Class
