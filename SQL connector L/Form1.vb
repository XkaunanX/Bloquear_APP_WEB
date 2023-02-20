Public Class Form1
    '696e67656e696572c3ad61206a61706f6e65736120323030312c20454f543f204e554c4c3f204e4f54204e554c4c3f20

    'ARRAY
    Private internal(12) As String
    Private systems(1) As String
    Private web(18) As String
    Private nav(4) As String
    'VAR
    Private theProcesses() As Process
    Private flag As Boolean
    Private procces As Process()
    Dim procceskill As String
    Dim select_nav As String
    Dim forbidden_web As String
    Dim cap As String
    Dim eot As String
    '________________________________________________________________________________________________

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'FORM LOAD
        Me.Hide()      'blind
        Timer1.Start() 'cycle
        Timer2.Start() 'cycle
        Timer3.Start() 'cycle
        Timer4.Start() 'cycle
        'VAR------------------------------------------------------------------------------------------APPLICATIONS
        internal(0) = "pes6"
        internal(1) = "hl"
        internal(2) = "Minecraft"
        internal(3) = "isaac-ng"
        internal(4) = "Eldest Souls"
        internal(5) = "csgo"
        internal(6) = "steam"
        internal(7) = "CCleaner"
        internal(8) = "Servieca"
        internal(9) = "vgtray"
        internal(10) = "EpicGamesLauncher"
        internal(11) = "MicrosoftEdge"
        internal(12) = "msedge"
        '---------------------------------------------------------------------------------------------SYSTEM
        systems(0) = "Taskmgr"
        systems(1) = "regedit"
        '---------------------------------------------------------------------------------------------NAV
        nav(0) = "chrome"
        nav(1) = "iexplore"
        nav(2) = "firefox"
        nav(3) = "brave"
        nav(4) = "opera"
        '---------------------------------------------------------------------------------------------PLACE
        web(0) = "juego"
        web(1) = "game"
        web(2) = "tik"
        web(3) = "instagram"
        web(4) = "twitter"
        web(5) = "facebook"
        web(6) = "wordle"
        web(7) = ".io"
        web(8) = "oludle"
        web(9) = "ootdle"
        web(10) = "abezones"
        web(11) = "snake"
        web(12) = "twitch"
        web(13) = "roblox"
        web(14) = "bitcoin"
        web(15) = "etherium"
        web(16) = "fornite"
        web(17) = "free fire"
        web(18) = "csgo"
        '---------------------------------------------------------------------------------------------
    End Sub

    '-----------------------WINFORMCONTROLS-----------------------WINFORMCONTROLS-----------------------WINFORMCONTROLS

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'BUTTON TO CHECK
        If TextBox3.Text = "fumandochiripi" Then
            flag = True
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'BUTTON TO HIDE
        Me.Hide()
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick 'FUNCTION FOR VISIBLE FORM VISIBLE
        If My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.CapsLock And My.Computer.Keyboard.ScrollLock And Not My.Computer.Keyboard.NumLock Then
            Me.Show()
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick 'FUNCTION CHECK APLICATION LOCAL PC

        internalFunction()

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick 'FUNCTION CHECK AND CLOSE FORBIDDEN SYSTEM FUNCTION 

        For Each systemss As String In systems

            procceskill = systemss

            procces = Process.GetProcessesByName(procceskill)
            If procces.Length > 0 Then
                Try
                    procces(0).Kill()
                    Form2.ShowDialog()
                Catch ex As Exception
                End Try
            End If
        Next
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick 'FUNCTION CHECK BROWSER

        For Each navs As String In nav

            select_nav = navs

            theProcesses = System.Diagnostics.Process.GetProcessesByName(select_nav)

            If theProcesses.Length > 0 Then
                Call block(theProcesses)
            End If

        Next
    End Sub

    Private Sub TextBox3_Click_1(sender As Object, e As EventArgs) Handles TextBox3.Click 'FUNCTION TO REVEAL
        PictureBox2.Visible = False
        PictureBox3.Visible = True
    End Sub

    '-FUNCTIONS----------------------------FUNCTIONS-----------------------------FUNCTIONS---------------------------FUNCTIONS-

    Private Sub internalFunction() 'CLOSE PROCCES APPLICATION FORBIDDEN

        For Each internals As String In internal

            procceskill = internals

            procces = Process.GetProcessesByName(procceskill)
            If procces.Length > 0 Then
                Try
                    procces(0).Kill()
                    Form2.ShowDialog()
                Catch ex As Exception
                End Try
            End If
        Next
    End Sub

    Public Sub block(ByVal theProcesses() As Process)

        For Each currentProcess As Process In theProcesses 'LOOP FOR BROWSER

            For Each webs As String In web 'LOOP FOR WEB FORBIDDEN

                forbidden_web = webs
                'OPTIONS FOR BLOCK
                If currentProcess.MainWindowTitle.Contains(forbidden_web.ToLower) Or currentProcess.MainWindowTitle.Contains(forbidden_web.ToUpper) Or currentProcess.MainWindowTitle.Contains(cap = capitalize(forbidden_web)) Then
                    currentProcess.Kill()
                    Form2.ShowDialog()
                End If

            Next

        Next
    End Sub

    Function capitalize(ByVal forbidden_web As String)

        eot = StrConv(forbidden_web, vbProperCase)
        Return eot
    End Function

End Class
