Public Class MainForm
    'Icon: Fan by Kevin Kwok from the Noun Project

#Region "Aero 그림자 효과 (Vista이상)"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub

#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BT1.Click
        Try
            SetDefault()
        Catch ex As Exception
            MsgBox("문제 발생. 권한을 확인하세요", vbCritical)
            GoTo endtsk
        End Try
        WaitMsg.Show()
endtsk:
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BT2.Click
        Try
            SetSlowest()
        Catch ex As Exception
            MsgBox("문제 발생. 권한을 확인하세요", vbCritical)
            GoTo endtsk
        End Try
        WaitMsg.Show()
endtsk:
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BT3.Click
        Try
            SetFastest()
        Catch ex As Exception
            MsgBox("문제 발생. 권한을 확인하세요", vbCritical)
            GoTo endtsk
        End Try
        WaitMsg.Show()
endtsk:
    End Sub

    Private Sub CloseBT_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        Application.Exit()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Opacity = 0
        CenterToScreen()
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Refresh()
        FadeIn(Me, 1)
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FadeOut(Me)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        WaitMsg.ShowDialog()
    End Sub
End Class