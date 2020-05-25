Public Class frmSplash
    Public m As New Process
    Public s As String
    Public start As Boolean
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = "V" & Application.ProductVersion
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Button2.Enabled = False
        Label1.Text = "QikuTestTools正在显示一些必要的说明内容......"
        MessageBox.Show("请注意：请知悉，QikuTestTools V1.5.6.0将会是预计最后的更新！", "QikuTestTools V1.5.6.0将会是预计最后的更新", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        MessageBox.Show("请注意：程序运行过程中可能弹出若干个黑色的界面，标题显示为" & Chr(34) & "QikuTestTools" & Chr(34) & "，请勿手动操作关闭该界面，一些代码依靠这个黑色界面实现，目前暂时无法实现界面隐藏，待代码执行完成会自动关闭，若手动关闭会造成程序运行错误！" & Chr(10) & Chr(10) & "您在使用之前已经承认该工具箱及OS先锋队已经在使用之前将注意事项和高风险行为及有关可能遇到的问题全部向您交代清楚，并且您对自己操作该工具箱带来的一系列不可预知的风险及不可控因素承担所有责任。其他注意事项可见360社区帖子以及帖子下方的评论区置顶第一条！", "QikuTestTools使用必要说明", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        MessageBox.Show("因为目录拥有管理员权限，QikuTestTools无法正常进行读写操作，请在第一次使用时以管理员权限打开该应用。本应用不会收集任何信息和数据，也不会对计算机系统和手机系统产生任何危害，只是目前技术上暂时无法解决权限问题。用命令来修改权限必须要有管理员权限，如不相信可以手动给应用目录下的" & Chr(34) & "tmp" & Chr(34) & "文件夹添加" & Chr(34) & "Everyone完全控制" & Chr(34) & "权限即可。", "首次运行程序的建议", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Label1.Text = "QikuTestTools正在进行一些必要的计算任务......"
        Dim i As Integer
        s = ""
        i = 0
        Do While i <= Len(Application.StartupPath)
            i = i + 1
            If Mid(Application.StartupPath, i, 1) <> "\" Then
                s = s & Mid(Application.StartupPath, i, 1)
            Else
                s = s & "/"
            End If
        Loop
        Label1.Text = "QikuTestTools正在进行属性赋值任务......"
        Me.Text = "QikuTestTools V" & Application.ProductVersion
        Form1.Text = "QikuTestTools V" & Application.ProductVersion
        Form2.Text = "QikuTestTools V" & Application.ProductVersion
        frmAbout.Text = "关于 QikuTestTools V" & Application.ProductVersion
        Label1.Text = "QikuTestTools正在关闭可能会造成冲突的临时应用......"
        m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkill /f /t /im adb.exe")
        Application.DoEvents()
        m.WaitForExit()
        m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkil /f /t /im cmd.exe")
        Application.DoEvents()
        m.WaitForExit()
        Label1.Text = "QikuTestTools正在校验程序完整性......"
        If Not (System.IO.File.Exists(s & "System.Net.Http.dll") Or System.IO.File.Exists(s & "/QikuTestTools.xml") Or System.IO.File.Exists(s & "/QikuTestTools.pdb") Or System.IO.File.Exists(s & "/QikuTestTools.exe.manifest") Or System.IO.File.Exists(s & "/QikuTestTools.exe.config") Or System.IO.File.Exists(s & "/QikuTestTools.application") Or System.IO.File.Exists(s & "/icon.ico") Or System.IO.File.Exists(s & "/tmp/型号汇总.txt") Or System.IO.File.Exists(s & "/tools/aapt.exe") Or System.IO.File.Exists(s & "/tools/adb.exe") Or System.IO.File.Exists(s & "/tools/AdbAdapter.dll") Or System.IO.File.Exists(s & "/tools/AdbWinApi.dll") Or System.IO.File.Exists(s & "/tools/AdbWinUsbApi.dll") Or System.IO.File.Exists(s & "/tools/bx.apk") Or System.IO.File.Exists(s & "/tools/fastboot.exe") Or System.IO.File.Exists(s & "/tools/fastboot90.exe") Or System.IO.File.Exists(s & "/tools/hiweather.apk") Or System.IO.File.Exists(s & "/tools/Magicball.apk") Or System.IO.File.Exists(s & "/tools/qikudownnetworkfix.exe") Or System.IO.File.Exists(s & "/tools/QikuTestTools2.0.apk") Or System.IO.File.Exists(s & "/tools/qitu_adb.exe") Or System.IO.File.Exists(s & "/tools/qitu_fastboot.exe") Or System.IO.File.Exists(s & "/tools/RemoveUpdate.apk") Or System.IO.File.Exists(s & "/tools/Scanner.apk") Or System.IO.File.Exists(s & "/tools/Theme.apk") Or System.IO.File.Exists(s & "/xianshua/QIKU Download Assistant Setup V5.0.5_180716.exe") Or System.IO.File.Exists(s & "/QIKU-SETUP.exe") Or System.IO.File.Exists(s & "/vcredist.exe") Or System.IO.Directory.Exists(s & "/线刷教程图解")) Then
            MessageBox.Show("QikuTestTools检测到当前程序不完整，请从原始下载链接中重新下载或关闭电脑中的安全软件再尝试重新运行！", "QikuTestTools程序异常", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End If
        Label1.Text = "QikuTestTools正在清理上次使用产生的临时文件......"
        If System.IO.File.Exists("C:/Users/Public/Downloads/temporary0.txt") Then
            System.IO.File.Delete("C:/Users/Public/Downloads/temporary0.txt")
        End If
        If System.IO.File.Exists(s & "/tmp/temporary.txt") Then
            System.IO.File.Delete(s & "/tmp/temporary.txt")
        End If
        If System.IO.File.Exists(s & "/tmp/temporary1.txt") Then
            System.IO.File.Delete(s & "/tmp/temporary1.txt")
        End If
        If System.IO.File.Exists(s & "/tmp/temporary2.txt") Then
            System.IO.File.Delete(s & "/tmp/temporary2.txt")
        End If

        If System.IO.File.Exists(s & "/tmp/QK_PatchSystem.apk") Then
            System.IO.File.Delete(s & "/tmp/QK_PatchSystem.apk")
        End If
        If System.IO.File.Exists(s & "/tmp/update.txt") Then
            System.IO.File.Delete(s & "/tmp/update.txt")
        End If
        Label1.Text = "QikuTestTools正在检查公用目录是否存在......"
        If Not System.IO.Directory.Exists("C:/Users/Public/Downloads") Then
            Label1.Text = "QikuTestTools正在创建不存在的公用目录......"
            System.IO.Directory.CreateDirectory("C:/Users/Public/Downloads")
        End If
        Label1.Text = "QikuTestTools正在修改临时目录的权限以便于读写......"
        m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && icacls " & Chr(34) & Application.StartupPath & "\tmp" & Chr(34) & " /t /grant:r everyone:f > " & Chr(34) & "C:\Users\Public\Downloads\temporary0.txt" & Chr(34))
        Application.DoEvents()
        m.WaitForExit()
        Dim file = New System.IO.StreamReader("C:/Users/Public/Downloads/temporary0.txt")
        Dim a As String
        Dim n As Integer
        n = 0
        a = file.ReadLine()
        file.Close()
        For n = 1 To Len(a)
            If Mid(a, n, 1) = "0" Or Mid(a, n, 1) = "1" Then
                n = Val(Mid(a, n, 1))
                Exit For
            End If
        Next
        System.IO.File.Delete("C:/Users/Public/Downloads/temporary0.txt")
        If n = 0 Then
            MessageBox.Show("QikuTestTools无法读取指定目录，请以管理员权限打开应用，否则无法正常运行。" & Chr(10) & Chr(10) & "因为目录拥有管理员权限，QikuTestTools无法正常进行读写操作，请在第一次使用时以管理员权限打开该应用。本应用不会收集任何信息和数据，也不会对计算机系统和手机系统产生任何危害，只是目前技术上暂时无法解决权限问题。用命令来修改权限必须要有管理员权限，如不相信可以手动给应用目录下的" & Chr(34) & "tmp" & Chr(34) & "文件夹添加" & Chr(34) & "Everyone完全控制" & Chr(34) & "权限即可。", "QikuTestTools无法读取指定目录", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show("QikuTestTools无法获取目录的权限，即将关闭，请以管理员权限再次打开。", "QikuTestTools即将关闭", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End
        End If
        Label1.Text = "QikuTestTools正在联网检查程序更新或公告信息......"
        Dim u As Boolean
        u = True
        Try
            My.Computer.Network.DownloadFile("http://39.105.165.68/11.txt", s & "/tmp/update.txt")
        Catch
            u = False
        End Try
        Dim b, c As String
        b = ""
        c = ""
        If u Then
            file = New System.IO.StreamReader(s & "/tmp/update.txt")
            a = file.ReadLine()
            b = file.ReadLine()
            If Not file.EndOfStream Then
                c = file.ReadLine()
            End If
            file.Close()
            If Mid(a, 1, 1) = "V" And Mid(a, 3, 1) = "." And Mid(a, 5, 1) = "." Then
                If a > "V" & Application.ProductVersion Then
                    MessageBox.Show("检测到应用有新版本" & Chr（34） & a & Chr(34) & ",当前版本为" & Chr(34) & "V" & Application.ProductVersion & Chr(34) & "。请前往链接处更新已获得更优质的使用体验。" & Chr(10) & Chr(10) & "最近一次的更新日志为：" & Chr(34) & b & Chr(34), "QikuTestTools发现新版本", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    System.Diagnostics.Process.Start("https://yunpan.360.cn/surl_yutDxRfVpKc")
                ElseIf a < "V" & Application.ProductVersion Then
                    MessageBox.Show("请注意：当前应用版本为" & Chr(34) & "V" & Application.ProductVersion & "测试版" & Chr(34) & "，正式版最新为" & Chr(34) & a & Chr(34) & "。仅供内部测试使用，请勿外传！", "QikuTestTools测试版提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MsgBox(a, b, c)
            End If
        End If
        Label1.Text = "QikuTestTools正在等待检测手机连接......"
        Button2.Enabled = True
        PictureBox1.Visible = False
        Button1.Visible = True
        Button1.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Enabled = False
        Button1.Enabled = False
        Label1.Text = "QikuTestTools正在检测是否有连接的手机......"
        m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && cd " & Application.StartupPath & "\Tools &&" & Mid(Application.StartupPath, 1, 2) & "&& adb devices >" & Chr(34) & Application.StartupPath & "\tmp\temporary.txt" & Chr(34))
        Application.DoEvents()
        m.WaitForExit()
        m = Process.Start("cmd.exe", "/c title QikuTestTools &&echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkill /f /t /im adb.exe")
        Application.DoEvents()
        m.WaitForExit()
        System.Threading.Thread.Sleep(1200)
        Dim a, b, c, d As String
        a = ""
        b = ""
        c = ""
        d = ""
        Dim file = New System.IO.StreamReader(s & "/tmp/temporary.txt")
        a = file.ReadLine()
        Do While a <> "List of devices attached " And Not file.EndOfStream
            a = file.ReadLine()
        Loop
        a = file.ReadLine()
        file.Close()
        If a = "" Then
            Label1.Text = "QikuTestTools没有检测到连接的手机"
            MessageBox.Show("QikuTestTools没有检测到连接的手机，请检查手机是否连接到电脑，是否已经关闭杀毒软件，是否在手机中允许进行USB调试等事项！待检测完成后可以重新尝试进行检测连接。", "QikuTestTools未检测到手机", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Button1.Enabled = True
            Button2.Enabled = True
            Exit Sub
        End If
        Label1.Text = "QikuTestTools正在获取一些必要的手机信息......"
        m = Process.Start("cmd.exe", "/c title QikuTestTools && echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && cd " & Chr(34) & Application.StartupPath & "\Tools" & Chr(34) & " &&" & Mid(Application.StartupPath, 1, 2) & "adb shell getprop >" & Chr(34) & Application.StartupPath & "\tmp\temporary1.txt" & Chr(34))
        Application.DoEvents()
        m.WaitForExit()
        m = Process.Start("cmd.exe", "/c title QikuTestTools &&echo QikuTestTools正在执行一些代码，请不要关闭该界面并耐心等待一段时间，该界面会自动在代码执行完成后消失...... && taskkill /f /t /im adb.exe")
        Application.DoEvents()
        m.WaitForExit()
        System.Threading.Thread.Sleep(1200)
        Dim file1 = New System.IO.StreamReader(s & "/tmp/temporary1.txt")
        Do While Not file1.EndOfStream
            a = file1.ReadLine()
            If Mid(a, 1, 18) = "[ro.product.brand]" Then
                b = a
            End If
            If Mid(a, 1, 20) = "[ro.build.uiversion]" Then
                c = a
            End If
            If Mid(a, 1, 26) = "[ro.build.version.release]" Then
                d = a
            End If
        Loop
        'If b <> "[ro.product.brand]: [Xiaomi]" Then
        If b <> "[ro.product.brand]: [360]" Then
            file1.Close()
            Label1.Text = "QikuTestTools检测到连接的手机非360手机"
            MessageBox.Show("QikuTestTools检测到连接的手机不是360手机，当前连接的手机品牌信息为" & Chr(34) & b & Chr(34) & "。" & Chr(10) & Chr(10) & "请注意：QikuTestTools也不支持奇酷/大神系列手机。", "QikuTestTools检测到非360手机", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Button1.Enabled = True
            Button2.Enabled = True
            Exit Sub
        Else
            Label1.Text = "QikuTestTools正在根据手机信息智能限制功能......"
        End If
        Dim j As Boolean
        j = False
        If c <> "[ro.build.uiversion]: [360UI:V3.0]" Then

            Form1.Button1.Text = Form1.Button1.Text & "（禁用）"
            Form1.Button2.Text = Form1.Button2.Text & "（禁用）"
            Form1.Button3.Text = Form1.Button3.Text & "（禁用）"
            Form1.Button8.Text = Form1.Button8.Text & "（禁用）"
            Form1.Button10.Text = Form1.Button10.Text & "（禁用）"
            j = True
        End If
        If d <> "[ro.build.version.release]: [8.1.0]" Then
            If j = False Then
                Form1.Button1.Text = Form1.Button1.Text & "（禁用）"
                Form1.Button2.Text = Form1.Button2.Text & "（禁用）"
                Form1.Button8.Text = Form1.Button8.Text & "（禁用）"
                Form1.Button11.Text = Form1.Button11.Text & "（禁用）"
            End If
            j = True
        End If
        Label1.Text = "QikuTestTools已成功检测到360手机，并完成一些检测"
        MessageBox.Show("QikuTestTools成功检测到连接的360手机，并已对必要的手机信息进行检测和判断。", "QikuTestTools检测到360手机", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If j = True Then
            MessageBox.Show("QikuTestTools检测到连接的手机OS版本或安卓版本不符合要求，已经智能限制允许使用的功能。", "QikuTestTools智能控制", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        start = True
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
    Private Sub MDI_Main_FormClosing(ByVal sender As System.Object, ByVal Myapp As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing    '无法关闭程序
        If start = False Then
            MessageBox.Show("请注意：不允许直接跳过启动界面的" & Chr(34) & "检测手机" & Chr(34) & "功能！", "QikuTestTools重要功能不允许跳过", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Myapp.Cancel = True
        End If

    End Sub
End Class