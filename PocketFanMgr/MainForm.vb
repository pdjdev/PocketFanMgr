Imports Microsoft.Win32

Public Class MainForm
    'Icon: Fan by Kevin Kwok from the Noun Project

#Region "Aero 그림자 효과 (Vista이상)"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub

#End Region

    Public Sub RestartService()
        Dim oldProcesses = Process.GetProcessesByName("FanMonitorService")

        For Each p In oldProcesses
            p.Kill()
        Next

        Dim cmd As New ProcessStartInfo

        With cmd
            .FileName = Environment.GetEnvironmentVariable("ComSpec")
            .CreateNoWindow = True
            .UseShellExecute = False
            .Arguments = "/c net start ""Fan Monitor"""
        End With

        Process.Start(cmd)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            SetDefault()
        Catch ex As Exception
            MsgBox("문제 발생. 권한을 확인하세요", vbCritical)
            GoTo endtsk
        End Try
        MsgBox("적용 완료", vbInformation)
endtsk:
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            SetSlowest()
        Catch ex As Exception
            MsgBox("문제 발생. 권한을 확인하세요", vbCritical)
            GoTo endtsk
        End Try
        MsgBox("적용 완료", vbInformation)
endtsk:
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try
            SetFastest()
        Catch ex As Exception
            MsgBox("문제 발생. 권한을 확인하세요", vbCritical)
            GoTo endtsk
        End Try
        MsgBox("적용 완료", vbInformation)
endtsk:
    End Sub

    't를 보니 강도같음.

    Public Sub SetDefault()
        WriteReg("SYSTEM\CurrentControlSet\Services\wfan0109", "margin", 5)
        WriteReg("SYSTEM\CurrentControlSet\Services\wfan0109", "t0", 40)
        WriteReg("SYSTEM\CurrentControlSet\Services\wfan0109", "t1", 60)
        WriteReg("SYSTEM\CurrentControlSet\Services\wfan0109", "t2", 75)
        RestartService()
    End Sub

    Public Sub SetFastest()
        WriteReg("SYSTEM\CurrentControlSet\Services\wfan0109", "margin", 5)
        WriteReg("SYSTEM\CurrentControlSet\Services\wfan0109", "t0", 99)
        WriteReg("SYSTEM\CurrentControlSet\Services\wfan0109", "t1", 99)
        WriteReg("SYSTEM\CurrentControlSet\Services\wfan0109", "t2", 10)
        RestartService()
    End Sub

    Public Sub SetSlowest()
        WriteReg("SYSTEM\CurrentControlSet\Services\wfan0109", "margin", 5)
        WriteReg("SYSTEM\CurrentControlSet\Services\wfan0109", "t0", 99)
        WriteReg("SYSTEM\CurrentControlSet\Services\wfan0109", "t1", 99)
        WriteReg("SYSTEM\CurrentControlSet\Services\wfan0109", "t2", 85)
        RestartService()
    End Sub

    Public Sub WriteReg(ByVal subKey As String, ByVal keyName As String, ByVal value As Integer)
        Dim key = Registry.LocalMachine.CreateSubKey(subKey)
        key?.SetValue(keyName, value, RegistryValueKind.DWord)
        key?.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Opacity = 0
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Refresh()
        FadeIn(Me, 1)
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FadeOut(Me)
    End Sub
End Class