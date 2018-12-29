Imports System.Runtime.InteropServices

Module GUIEffect

#Region "Aero 그림자 효과 (Vista이상)"
    '윈도우 Vista 이상에서만 작동 가능
    '코드 참조: https://stackoverflow.com/questions/20322637
    '코드 참조2: https://gist.github.com/bae-unidev/94c907b7a5acd98f2c44

    Structure MARGINS
        Public Left, Right, Top, Bottom As Integer
    End Structure

    <DllImport("dwmapi.dll", PreserveSig:=True)>
    Private Function DwmSetWindowAttribute(hwnd As IntPtr, attr As Integer, ByRef attrValue As Integer, attrSize As Integer) As Integer
    End Function

    <DllImport("dwmapi.dll")>
    Private Function DwmExtendFrameIntoClientArea(hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
    End Function

    Public Function CreateDropShadow(form As Form) As Boolean

        Try
            Dim val As Integer = 2
            Dim ret1 As Integer = DwmSetWindowAttribute(form.Handle, 2, val, 4)

            If ret1 = 0 Then
                Dim m As MARGINS = New MARGINS() With {
                            .Left = 1,
                            .Right = 1,
                            .Top = 1,
                            .Bottom = 1
                        }

                Dim ret2 As Integer = DwmExtendFrameIntoClientArea(form.Handle, m)
                Return ret2 = 0
            Else
                Return False
            End If
        Catch ex As Exception
            ' Probably dwmapi.dll not found (incompatible OS)
            Return False
        End Try

    End Function

#End Region


#Region "창 페이드 인/아웃 효과"
    Public Sub FadeIn(Form As Form, goalopacity As Double)
        Form.Opacity = 0

        Do While Form.Opacity < goalopacity - 0.1
            Form.Opacity += 0.1
            Threading.Thread.Sleep(10)
        Loop


        Form.Opacity = goalopacity
    End Sub

    Public Sub FadeOut(Form As Form)

        Do While Not Form.Opacity = 0
            Form.Opacity = Form.Opacity - 0.1
            Threading.Thread.Sleep(10)
        Loop

    End Sub
#End Region

End Module
