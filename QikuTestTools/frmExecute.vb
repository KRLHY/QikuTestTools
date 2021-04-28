Public Class frmExecute
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Label1.Text = "QikuTestTools正在执行" & Chr(34) & "关闭推送通道" & Chr（34） & "（实验）......"
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && cd " & Chr(34) & Application.StartupPath & "\Tools" & Chr(34) & " &&" & Mid(Application.StartupPath, 1, 2) & "&& adb install -r " & Chr(34) & Application.StartupPath & "\Tools\QikuTestTools2.0.apk" & Chr(34))
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools &&echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkill /f /t /im adb.exe")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        Label1.Text = "QikuTestTools执行" & Chr(34) & "关闭推送通道（实验）" & Chr(34) & "成功"
        Me.Hide()
        Me.Close()
        Label1.Text = "QikuTestTools正在准备执行需要的操作......"
        MessageBox.Show("QikuTestTools执行" & Chr(34) & "关闭推送通道" & Chr(34) & "成功，快前往手机端看看吧" & Chr(10) & "｡◕ᴗ◕｡", "QikuTestTools执行成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        Label1.Text = "QikuTestTools正在执行" & Chr(34) & "分析PatchSystem" & Chr（34） & "......"
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && cd " & Chr(34) & Application.StartupPath & "\Tools" & Chr(34) & " &&" & Mid(Application.StartupPath, 1, 2) & "&& adb pull /system/priv-app/QK_PatchSystem/QK_PatchSystem.apk " & Chr(34) & frmSplash.s & "/tmp/QK_PatchSystem.apk" & Chr(34))
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools &&echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkill /f /t /im adb.exe")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && cd " & Chr(34) & Application.StartupPath & "\Tools" & Chr(34) & " &&" & Mid(Application.StartupPath, 1, 2) & "&& aapt dump badging " & Chr(34) & Application.StartupPath & "\tmp\QK_PatchSystem.apk" & Chr(34) & " >" & Chr(34) & Application.StartupPath & "\tmp\temporary2.txt" & Chr(34))
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools &&echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkill /f /t /im adb.exe")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        Dim a, b As String
        Dim n As Integer
        a = ""
        b = ""
        Dim file = New System.IO.StreamReader(frmSplash.s & "/tmp/temporary2.txt")
        Do While Not file.EndOfStream
            a = file.ReadLine()
            If Mid(a, 1, 15) = "package: name='" Then
                For n = 16 To 150
                    If Mid(a, n, 1) <> "'" Then
                        b = b & Mid(a, n, 1)
                    Else
                        Exit Do
                    End If
                Next
            End If
        Loop
        Label1.Text = "QikuTestTools已经对PatchSystme分析完成"
        n = 7
        n = MessageBox.Show("请注意：" & Chr(34) & "卸载PatchSyatem" & Chr(34) & "不可逆并可能带来一些负面后果，如无法获得正常OS应用推送的更新等，建议谨慎操作！该功能只针对安卓8的360OS3.0生效，并无法确保去除推送的可靠性！请再次确认是否需要执行。", "QikuTestTools高危功能警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If n <> 6 Then
            Label1.Text = "QikuTestTools已经取消" & Chr(34) & "卸载PatchSystem" & Chr(34)
            Me.Hide()
            Me.Close()
            Label1.Text = "QikuTestTools正在准备执行需要的操作......"
            MessageBox.Show("已经成功取消卸载PatchSystem。", "QikuTestTools取消卸载PatchSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label1.Text = "QikuTestTools正在执行" & Chr(34) & "卸载PatchSysttem" & Chr(34) & "......"
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && cd " & Chr(34) & Application.StartupPath & "\Tools" & Chr(34) & " &&" & Mid(Application.StartupPath, 1, 2) & "&& adb shell pm uninstall --user 0 " & b)
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools &&echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkill /f /t /im adb.exe")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        Label1.Text = "QikuTestTools执行" & Chr(34) & "卸载PatchSystem" & Chr(34) & "成功"
        Me.Hide()
        Me.Close()
        Label1.Text = "QikuTestTools正在准备执行需要的操作......"
        MessageBox.Show("QikuTestTools执行" & Chr(34) & "卸载PatchSystem" & Chr(34) & "成功，快前往手机端看看吧" & Chr(10) & "｡◕ᴗ◕｡", "QikuTestTools执行成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Enabled = False
        Label1.Text = "QikuTestTools正在执行安装" & Chr(34) & "禁止系统更新" & Chr（34） & "......"
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && cd " & Chr(34) & Application.StartupPath & "\Tools" & Chr(34) & " &&" & Mid(Application.StartupPath, 1, 2) & "&& adb install -r " & Chr(34) & Application.StartupPath & "\Tools\RemoveUpdate.apk" & Chr(34))
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools &&echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkill /f /t /im adb.exe")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        Label1.Text = "QikuTestTools安装" & Chr(34) & "禁止系统更新" & Chr(34) & "成功"
        Me.Hide()
        Me.Close()
        Label1.Text = "QikuTestTools正在准备执行需要的操作......"
        MessageBox.Show("QikuTestTools安装" & Chr(34) & "禁止系统更新" & Chr(34) & "成功，快前往手机端看看吧" & Chr(10) & "｡◕ᴗ◕｡", "QikuTestTools执行成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer4.Enabled = False
        Label1.Text = "QikuTestTools正在执行前往" & Chr(34) & "线刷工具" & Chr(34) & "文件夹......"
        frmSplash.m = Process.Start("explorer.exe", Application.StartupPath & "\xianshua\")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        Label1.Text = "QikuTestTools前往" & Chr(34) & "线刷工具" & Chr(34) & "文件夹成功"
        Me.Hide()
        Me.Close()
        Label1.Text = "QikuTestTools正在准备执行需要的操作......"
    End Sub
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer5.Enabled = False
        Label1.Text = "QikuTestTools正在执行启动" & Chr(34) & "线刷驱动修复工具" & Chr(34) & "......"
        frmSplash.m = Process.Start("explorer.exe", Application.StartupPath & "\Tools\qikudownnetworkfix.exe")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        Label1.Text = "QikuTestTools启动" & Chr(34) & "线刷驱动修复工具" & Chr(34) & "成功"
        Me.Hide()
        Me.Close()
        Label1.Text = "QikuTestTools正在准备执行需要的操作......"
    End Sub
    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Timer6.Enabled = False
        Label1.Text = "QikuTestTools正在执行安装" & Chr(34) & "360手机保修查询工具" & Chr(34) & "......"
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && cd " & Chr(34) & Application.StartupPath & "\Tools" & Chr(34) & " &&" & Mid(Application.StartupPath, 1, 2) & "&& adb install -r " & Chr(34) & Application.StartupPath & "\Tools\bx.apk" & Chr(34))
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools &&echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkill /f /t /im adb.exe")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        Label1.Text = "QikuTestTools执行安装" & Chr(34) & "360保修查询工具" & Chr(34) & "成功"
        Me.Hide()
        Me.Close()
        Label1.Text = "QikuTestTools正在准备执行需要的操作......"
        MessageBox.Show("QikuTestTools执行安装" & Chr(34) & "360保修查修工具" & Chr(34) & "成功，快前往手机端看看吧" & Chr(10) & "｡◕ᴗ◕｡", "QikuTestTools执行成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Timer7.Enabled = False
        Label1.Text = "QikuTestTools正在执行安装" & Chr(34) & "破解无忧天气广告" & Chr(34) & "......"
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && cd " & Chr(34) & Application.StartupPath & "\Tools" & Chr(34) & " &&" & Mid(Application.StartupPath, 1, 2) & "&& adb shell pm uninstall --user 0 com.mobile.hiweather")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        System.Threading.Thread.Sleep(1200)
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && cd " & Chr(34) & Application.StartupPath & "\Tools" & Chr(34) & " &&" & Mid(Application.StartupPath, 1, 2) & "&& adb install -r " & Chr(34) & Application.StartupPath & "\Tools\hiweather.apk" & Chr(34))
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools &&echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkill /f /t /im adb.exe")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        Label1.Text = "QikuTestTools执行安装" & Chr(34) & "破解无忧天气广告" & Chr(34) & "成功"
        Me.Hide()
        Me.Close()
        Label1.Text = "QikuTestTools正在准备执行需要的操作......"
        MessageBox.Show("QikuTestTools执行安装" & Chr(34) & "破解无忧天气广告" & Chr(34) & "成功，快前往手机端看看吧" & Chr(10) & "｡◕ᴗ◕｡", "QikuTestTools执行成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Timer8.Enabled = False
        Label1.Text = "QikuTestTools正在执行安装" & Chr(34) & "破解主题商店" & Chr（34） & "......"
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && cd " & Chr(34) & Application.StartupPath & "\Tools" & Chr(34) & " &&" & Mid(Application.StartupPath, 1, 2) & "&& adb install -r " & Chr(34) & Application.StartupPath & "\Tools\Theme.apk" & Chr(34))
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools &&echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkill /f /t /im adb.exe")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        Label1.Text = "QikuTestTools安装" & Chr(34) & "破解主题商店" & Chr(34) & "成功"
        Me.Hide()
        Me.Close()
        Label1.Text = "QikuTestTools正在准备执行需要的操作......"
        MessageBox.Show("QikuTestTools安装" & Chr(34) & "破解主题商店" & Chr(34) & "成功，快前往手机端看看吧" & Chr(10) & "｡◕ᴗ◕｡", "QikuTestTools执行成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Timer9.Enabled = False
        Dim a As String
        a = ""
        Label1.Text = "QikuTestTools正在准备执行" & Chr(34) & "修改分辨率（DPI）" & Chr（34） & "......"
        a = InputBox("请输入需要的DPI值（100-600），之后手机会重启以使修改生效。（留空代表取消操作）", "请输入DPI的值")
        Do While Not (a >= "100" And a <= "600") And Not a = ""
            MessageBox.Show("输入的DPI值可能会有问题，请重新输入一个安全的值。", "QikuTestTools修改DPI", MessageBoxButtons.OK, MessageBoxIcon.Error)
            a = InputBox("请输入需要的DPI值（100-600），之后手机会重启以使修改生效。", "请输入DPI的值")
        Loop
        If a = "" Then
            Label1.Text = "QikuTestTools已经取消" & Chr(34) & "修改分辨率（DPI）" & Chr(34)
            Me.Hide()
            Me.Close()
            Label1.Text = "QikuTestTools正在准备执行需要的操作......"
            MessageBox.Show("已经成功取消修改分辨率（DPI）。", "QikuTestTools取消修改分辨率（DPI）", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && cd " & Application.StartupPath & "\Tools &&" & Mid(Application.StartupPath, 1, 2) & "&& adb shell wm density " & a & "&& adb reboot")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools &&echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkill /f /t /im adb.exe")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        Label1.Text = "QikuTestTools" & Chr(34) & "修改分辨率（DPI）" & Chr(34) & "成功"
        Me.Hide()
        Me.Close()
        Label1.Text = "QikuTestTools正在准备执行需要的操作......"
        MessageBox.Show("QikuTestTools" & Chr(34) & "修改分辨率（DPI）" & Chr(34) & "成功，快前往手机端看看吧" & Chr(10) & "｡◕ᴗ◕｡", "QikuTestTools执行成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        Timer10.Enabled = False
        Label1.Text = "QikuTestTools正在执行" & Chr(34) & "更新3D球（智能组件）" & Chr（34） & "......"
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && cd " & Chr(34) & Application.StartupPath & "\Tools" & Chr(34) & " &&" & Mid(Application.StartupPath, 1, 2) & "&& adb install -r " & Chr(34) & Application.StartupPath & "\Tools\3D.apk" & Chr(34))
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools &&echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkill /f /t /im adb.exe")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        Label1.Text = "QikuTestTools" & Chr(34) & "更新3D球（智能组件）" & Chr(34) & "成功"
        Me.Hide()
        Me.Close()
        Label1.Text = "QikuTestTools正在准备执行需要的操作......"
        MessageBox.Show("QikuTestTools" & Chr(34) & "更新3D球（智能组件）" & Chr(34) & "成功，快前往手机端看看吧" & Chr(10) & "｡◕ᴗ◕｡", "QikuTestTools执行成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        Timer11.Enabled = False
        Label1.Text = "QikuTestTools正在执行" & Chr(34) & "安装万能扫一扫" & Chr（34） & "......"
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && cd " & Chr(34) & Application.StartupPath & "\Tools" & Chr(34) & " &&" & Mid(Application.StartupPath, 1, 2) & "&& adb install -r " & Chr(34) & Application.StartupPath & "\Tools\Scanner.apk" & Chr(34))
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools &&echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkill /f /t /im adb.exe")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        Label1.Text = "QikuTestTools" & Chr(34) & "安装万能扫一扫" & Chr(34) & "成功"
        Me.Hide()
        Me.Close()
        Label1.Text = "QikuTestTools正在准备执行需要的操作......"
        MessageBox.Show("QikuTestTools" & Chr(34) & "安装万能扫一扫" & Chr(34) & "成功，快前往手机端看看吧" & Chr(10) & "｡◕ᴗ◕｡", "QikuTestTools执行成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        Timer12.Enabled = False
        Label1.Text = "QikuTestTools正在执行" & Chr(34) & "安装魔球" & Chr（34） & "......"
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && cd " & Chr(34) & Application.StartupPath & "\Tools" & Chr(34) & " &&" & Mid(Application.StartupPath, 1, 2) & "&& adb install -r " & Chr(34) & Application.StartupPath & "\Tools\Magicball.apk" & Chr(34))
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        frmSplash.m = Process.Start("cmd.exe", "/c title QikuTestTools &&echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkill /f /t /im adb.exe")
        Application.DoEvents()
        frmSplash.m.WaitForExit()
        Label1.Text = "QikuTestTools" & Chr(34) & "安装魔球" & Chr(34) & "成功"
        Me.Hide()
        Me.Close()
        Label1.Text = "QikuTestTools正在准备执行需要的操作......"
        MessageBox.Show("QikuTestTools" & Chr(34) & "安装魔球" & Chr(34) & "成功，快前往手机端看看吧" & Chr(10) & "｡◕ᴗ◕｡", "QikuTestTools执行成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class