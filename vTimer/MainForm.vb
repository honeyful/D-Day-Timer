Imports IWshRuntimeLibrary
Public Class MainForm
    Private _shortcutPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
    Sub New()

        InitializeComponent()
        Me.ShowInTaskbar = False
        If IO.File.Exists(IO.Path.Combine(_shortcutPath, Application.ProductName) & ".lnk") Then
            chkStartup.Checked = True
        Else
            chkStartup.Checked = False
        End If

    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Clock.Interval = 1000
        Clock.Start()
    End Sub
    Private Sub CreateShortcutInStartUp(ByVal Description As String)
        Dim WshShell As WshShell = New WshShell()
        Dim Shortcut As IWshShortcut = CType(WshShell.CreateShortcut(IO.Path.Combine(_shortcutPath, Application.ProductName) & ".lnk"), IWshShortcut)
        With Shortcut
            .TargetPath = Application.ExecutablePath
            .WorkingDirectory = Application.StartupPath
            .Description = Description
            '.Arguments = "-tray"
            .Save()
        End With
    End Sub

    Private Sub DeleteShortCutInStartUp()
        IO.File.Delete(IO.Path.Combine(_shortcutPath, Application.ProductName) & ".lnk")
    End Sub

    Private Sub Clock_Tick(sender As Object, e As EventArgs) Handles Clock.Tick
        Dim sDate As DateTime = DateTime.Parse(Date.Now)
        Dim eDate As DateTime = DateTime.Parse("2017-12-31 00:00:00")
        Dim ts As TimeSpan = eDate.Subtract(sDate)

        LabelTime.Text = CStr(ts.Days) & " Days " & CStr(ts.Hours) & " Hours " & CStr(ts.Minutes) & " Minutes " & CStr(ts.Seconds) & " Seconds "
    End Sub
    Dim x, y As Integer
    Dim newPoint As New Point
    Private Sub LabelTime_DoubleClick(sender As Object, e As EventArgs) Handles LabelTime.DoubleClick
        If ColorDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            LabelTime.ForeColor = ColorDialog.Color
            If ColorDialog.Color.R >= 253 Or ColorDialog.Color.G >= 253 Or ColorDialog.Color.B >= 253 Then
                Me.TransparencyKey = System.Drawing.Color.FromArgb(252, 252, 252)
                Me.BackColor = Me.TransparencyKey
            Else
                Me.TransparencyKey = System.Drawing.Color.FromArgb(ColorDialog.Color.R + 2, ColorDialog.Color.B + 2, ColorDialog.Color.B + 2)
                Me.BackColor = Me.TransparencyKey
            End If
        End If
    End Sub
    Private Sub LabelTime_MouseDown(sender As Object, e As MouseEventArgs) Handles LabelTime.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub chkStartup_CheckedChanged(sender As Object, e As EventArgs) Handles chkStartup.CheckedChanged
        If chkStartup.Checked Then
            CreateShortcutInStartUp(String.Empty)

        Else
            DeleteShortCutInStartUp()
        End If
    End Sub

    Private Sub LabelTime_MouseMove(sender As Object, e As MouseEventArgs) Handles LabelTime.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            newPoint = Control.MousePosition
            newPoint.X -= x
            newPoint.Y -= y
            Me.Location = newPoint
            Application.DoEvents()
        End If
    End Sub
End Class
