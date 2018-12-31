<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CloseBT = New System.Windows.Forms.PictureBox()
        Me.BT3 = New System.Windows.Forms.PictureBox()
        Me.BT2 = New System.Windows.Forms.PictureBox()
        Me.BT1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.CloseBT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BT3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BT1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CloseBT)
        Me.Panel1.Controls.Add(Me.BT3)
        Me.Panel1.Controls.Add(Me.BT2)
        Me.Panel1.Controls.Add(Me.BT1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(23)
        Me.Panel1.Size = New System.Drawing.Size(520, 204)
        Me.Panel1.TabIndex = 0
        '
        'CloseBT
        '
        Me.CloseBT.Image = Global.PocketFanMgr.My.Resources.Resources.closeicon
        Me.CloseBT.Location = New System.Drawing.Point(469, 1)
        Me.CloseBT.Name = "CloseBT"
        Me.CloseBT.Size = New System.Drawing.Size(50, 50)
        Me.CloseBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseBT.TabIndex = 3
        Me.CloseBT.TabStop = False
        '
        'BT3
        '
        Me.BT3.Image = Global.PocketFanMgr.My.Resources.Resources.fan_turbo
        Me.BT3.Location = New System.Drawing.Point(354, 38)
        Me.BT3.Margin = New System.Windows.Forms.Padding(15)
        Me.BT3.Name = "BT3"
        Me.BT3.Size = New System.Drawing.Size(128, 128)
        Me.BT3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BT3.TabIndex = 2
        Me.BT3.TabStop = False
        '
        'BT2
        '
        Me.BT2.Image = Global.PocketFanMgr.My.Resources.Resources.fan_sleep
        Me.BT2.Location = New System.Drawing.Point(196, 38)
        Me.BT2.Margin = New System.Windows.Forms.Padding(15)
        Me.BT2.Name = "BT2"
        Me.BT2.Size = New System.Drawing.Size(128, 128)
        Me.BT2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BT2.TabIndex = 1
        Me.BT2.TabStop = False
        '
        'BT1
        '
        Me.BT1.Image = Global.PocketFanMgr.My.Resources.Resources.fan_auto
        Me.BT1.Location = New System.Drawing.Point(38, 38)
        Me.BT1.Margin = New System.Windows.Forms.Padding(15)
        Me.BT1.Name = "BT1"
        Me.BT1.Size = New System.Drawing.Size(128, 128)
        Me.BT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BT1.TabIndex = 0
        Me.BT1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(522, 206)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PocketFanMgr"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Panel1.ResumeLayout(False)
        CType(Me.CloseBT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BT3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BT1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BT1 As PictureBox
    Friend WithEvents BT3 As PictureBox
    Friend WithEvents BT2 As PictureBox
    Friend WithEvents CloseBT As PictureBox
End Class
