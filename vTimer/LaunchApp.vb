
Public Module LaunchApp

    Public Sub Main()
        If UBound(Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName)) > 0 Then
            MsgBox("Already Running!", MsgBoxStyle.Critical)
            End
        End If
        Application.EnableVisualStyles()
        Application.Run(New AppContext)
    End Sub

    'public sub main(byval cmdargs() as string)
    '    if ubound(process.getprocessesbyname(process.getcurrentprocess.processname)) > 0 then
    '        msgbox("already running!" & vbnewline & "check your taskbar", msgboxstyle.critical)
    '        end
    '    end if
    '    application.enablevisualstyles()

    '    dim usetray as boolean = false

    '    for each cmd as string in cmdargs
    '        if cmd.tolower = "-tray" then
    '            usetray = true
    '            exit for
    '        end if
    '    next

    '    if usetray then
    '        displayform = false
    '    else
    '        displayform = true
    '    end if
    '    application.run(new appcontext)
    'end sub

    'Public Function Main() As Integer
    'End Function

    'Public Function Main(ByVal cmdArgs() As String) As Integer
    'End Function

End Module
