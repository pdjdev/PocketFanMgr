Public Class WaitMsg

    Private Sub WaitMsg_Load(sender As Object, e As EventArgs) Handles Me.Load
        Size = MainForm.Size
        CenterToScreen()
        Label1.Text = "잠시만 기다리세요..."
        Opacity = 0
        Refresh()
    End Sub

    Private Sub WaitMsg_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        '100ms
        Refresh()
        FadeIn(Me, 0.9)


        Threading.Thread.Sleep(5200)

        FadeOut(Me)

        Me.Close()
    End Sub
End Class