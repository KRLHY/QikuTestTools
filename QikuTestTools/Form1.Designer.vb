<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Usehelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.Duty = New System.Windows.Forms.ToolStripMenuItem()
        Me.Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.Checkupdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.About = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Opensource = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.MenuStrip1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Usehelp, Me.Duty, Me.Opensource, Me.Help})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(808, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Usehelp
        '
        Me.Usehelp.Name = "Usehelp"
        Me.Usehelp.Size = New System.Drawing.Size(83, 24)
        Me.Usehelp.Text = "使用说明"
        '
        'Duty
        '
        Me.Duty.Name = "Duty"
        Me.Duty.Size = New System.Drawing.Size(83, 24)
        Me.Duty.Text = "免责声明"
        '
        'Help
        '
        Me.Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Checkupdate, Me.About})
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(53, 24)
        Me.Help.Text = "帮助"
        '
        'Checkupdate
        '
        Me.Checkupdate.Name = "Checkupdate"
        Me.Checkupdate.Size = New System.Drawing.Size(152, 26)
        Me.Checkupdate.Text = "检查更新"
        '
        'About
        '
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(152, 26)
        Me.About.Text = "关于"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(197, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "点击下方的功能按键来执行相关操作"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(17, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(236, 67)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "关闭推送通道（实验）"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(17, 173)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(236, 67)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "卸载PatchSystem"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.Location = New System.Drawing.Point(17, 263)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(236, 67)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "禁止系统更新"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button4.Location = New System.Drawing.Point(17, 352)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(236, 67)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "安装线刷工具"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button5.Location = New System.Drawing.Point(283, 81)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(236, 67)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "修复线刷驱动（实验）"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button6.Location = New System.Drawing.Point(283, 173)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(236, 67)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "保修查询（仅供参考）"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button7.Location = New System.Drawing.Point(283, 263)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(236, 67)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "破解无忧天气广告"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button8.Location = New System.Drawing.Point(283, 352)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(236, 67)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "破解主题商店"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button9.Location = New System.Drawing.Point(550, 81)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(236, 67)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "修改分辨率（DPI）"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button10.Location = New System.Drawing.Point(549, 173)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(236, 67)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "更新3D球（智能组件）"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button11.Location = New System.Drawing.Point(549, 263)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(236, 67)
        Me.Button11.TabIndex = 13
        Me.Button11.Text = "安装万能扫一扫"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button12.Location = New System.Drawing.Point(549, 352)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(236, 67)
        Me.Button12.TabIndex = 14
        Me.Button12.Text = "安装魔球"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Opensource
        '
        Me.Opensource.Name = "Opensource"
        Me.Opensource.Size = New System.Drawing.Size(83, 24)
        Me.Opensource.Text = "开源地址"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 450)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(826, 497)
        Me.MinimumSize = New System.Drawing.Size(826, 497)
        Me.Name = "Form1"
        Me.Text = "QikuTestTools & Version"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Usehelp As ToolStripMenuItem
    Friend WithEvents Help As ToolStripMenuItem
    Friend WithEvents Checkupdate As ToolStripMenuItem
    Friend WithEvents About As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Duty As ToolStripMenuItem
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Opensource As ToolStripMenuItem
End Class
