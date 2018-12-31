Imports Microsoft.Win32

Module FanCtrl

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


End Module
