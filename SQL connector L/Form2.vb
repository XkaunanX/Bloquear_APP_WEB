Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            System.Diagnostics.Process.Start("https://www.mubis.es/media/users/11242/104369/yossarian-l_cover.gif")
        Catch ex As Exception
            MsgBox(ex)
        End Try
        Timer1.Stop()
        Timer2.Stop()
        Me.WindowState = WindowState.Minimized
        Me.Hide()
        Me.Dispose()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MsgBox("Bro? ¯\_( ͡❛ ͜ʖ ͡❛)_/¯")
    End Sub

End Class