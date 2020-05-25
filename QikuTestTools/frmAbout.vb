Public Class frmAbout
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "V" & Application.ProductVersion
        ComboBox1.Items.Add("V1.5.6.0（当前版本）")
        ComboBox1.Items.Add("V1.5.5.0")
        ComboBox1.Items.Add("V1.5.4.0")
        ComboBox1.Items.Add("V1.5.3.0")
        ComboBox1.Items.Add("V1.5.2.0")
        ComboBox1.Items.Add("V1.5.1.0")
        ComboBox1.Items.Add("V1.5.0.0")
        ComboBox1.Items.Add("V1.0.4")
        ComboBox1.Items.Add("V1.0.3")
        ComboBox1.Items.Add("V1.0.2")
        ComboBox1.Items.Add("V1.0.1")
        ComboBox1.Items.Add("V1.0.0")
        ComboBox1.Text = "V1.5.6.0（当前版本）"
        Label4.Text = "修复" & Chr(34) & "卸载PatchSystem" & Chr(34) & "、" & Chr(34) & "关闭推送通道（实验）" & Chr(34) & "功能出现的错误；主界面菜单栏位置调整；修复可以直接跳过启动界面" & Chr(34) & "手机检测" & Chr(34) & "功能；新增集成" & Chr(34) & "V2.60" & Chr(34) & "、" & Chr(34) & "V3.61" & Chr(34) & "刷机工具；新增" & Chr(34) & "安装万能扫一扫" & Chr(34) & "、" & Chr(34) & "安装魔球" & Chr(34) & "功能；主界面禁止缩放；程序开源。"
    End Sub
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "V1.5.6.0（当前版本）" Then
            Label4.Text = "修复" & Chr(34) & "卸载PatchSystem" & Chr(34) & "、" & Chr(34) & "关闭推送通道（实验）" & Chr(34) & "功能出现的错误；主界面菜单栏位置调整；修复可以直接跳过启动界面" & Chr(34) & "手机检测" & Chr(34) & "功能；新增集成" & Chr(34) & "V2.60" & Chr(34) & "、" & Chr(34) & "V3.61" & Chr(34) & "刷机工具；新增" & Chr(34) & "安装万能扫一扫" & Chr(34) & "、" & Chr(34) & "安装魔球" & Chr(34) & "功能；主界面禁止缩放；程序开源。"
        ElseIf ComboBox1.Text = "V1.5.5.0" Then
            Label4.Text = Chr(34) & "启动界面" & Chr(34) & "的" & Chr(34) & "关闭" & Chr(34) & "按钮不再作为键盘的焦点；优化程序启动流程和" & Chr(34) & "启动界面" & Chr(34) & "；" & Chr(34) & "启动界面" & Chr(34) & "新增程序版本号；修复当公用目录不存在时造成的错误；优化取消操作时的逻辑；修复" & Chr(34) & "修改分辨率（DPI）" & Chr(34) & "无法取消操作的错误；" & Chr(34) & "使用说明" & Chr(34) & "添加弹窗解释；主界面添加" & Chr(34) & "免责声明" & Chr(34) & "。"
        ElseIf ComboBox1.Text = "V1.5.4.0" Then
            Label4.Text = Chr(34) & "启动界面" & Chr(34) & "自检完成后将把焦点自动移动到" & Chr(34) & "检测手机连接" & Chr(34) & "按钮上。"
        ElseIf ComboBox1.Text = "V1.5.3.0" Then
            Label4.Text = "提升" & Chr(34) & ".Net Framework" & Chr(34) & "框架版本为" & Chr(34) & "4.7.2" & Chr(34) & "；优化代码逻辑，减少重复运算；更新" & Chr(34) & "校验程序完整性" & Chr(34) & "；" & Chr(34) & "启动界面" & Chr(34) & "优化。"
        ElseIf ComboBox1.Text = "V1.5.2.0" Then
            Label4.Text = "修复" & Chr(34) & "卸载PatchSystem" & Chr(34) & "功能出现的错误。"
        ElseIf ComboBox1.Text = "V1.5.1.0" Then
            Label4.Text = "修复" & Chr(34) & "卸载PatchSystem" & Chr(34) & "功能出现的错误。"
        ElseIf ComboBox1.Text = "V1.5.0.0" Then
            Label4.Text = "采用全新程序语言" & Chr(34) & "Visual Basic .NET" & Chr(34) & "、算法和平台" & Chr(34) & "Microsoft Visual Studio Professional 2019" & Chr(34) & "，底层框架升级为" & Chr(34) & ".Net Framework 4.6" & Chr(34) & "全新平台，程序兼容性强劲提升，带来更多新特性、新体验；整个程序重新设计，重写代码；新增" & Chr(34) & "更新3D球（智能组件）" & Chr(34) & "的功能；代码结构、程序流程优化；所有界面重新设计，视觉体验提升；" & Chr(34) & "更新服务" & Chr(34) & "优化；程序文案优化；优化" & Chr(34) & "修改分辨率（DPI）" & Chr(34) & "的逻辑;修复可能存在的内存泄漏；修复当安卓或OS版本不支持时无法进入界面且文案的错误提示。"
        ElseIf ComboBox1.Text = "V1.0.4" Then
            Label4.Text = "经测试后开放非英文目录以便提升用户体验。"
        ElseIf ComboBox1.Text = "V1.0.3" Then
            Label4.Text = "修复错误的可能导致无法检测手机连接的问题。"
        ElseIf ComboBox1.Text = "V1.0.2" Then
            Label4.Text = "开放对所有360手机的使用权限（根据不同情况进行功能限制）；" & Chr(34) & "启动" & Chr(34) & "界面新增" & Chr(34) & "关闭程序" & Chr(34) & "功能；优化对话框文字显示；" & Chr(34) & "更新服务" & Chr(34) & "支持发布公告；新增自检时自动检测更新。"
        ElseIf ComboBox1.Text = "V1.0.1" Then
            Label4.Text = "优化安装" & Chr(34) & "破解无忧天气广告" & Chr(34) & "的逻辑；新增只允许运行一个进程；同步" & Chr(34) & "关于" & Chr(34) & "界面icon；新增" & Chr(34) & "检查更新" & Chr(34) & "功能；修复错误的" & Chr(34) & "使用说明" & Chr(34) & "链接导向。"
        ElseIf ComboBox1.Text = "V1.0.0" Then
            Label4.Text = "QikuTestTools首个版本全新起航，多种功能集合箱，360OS先锋队荣誉出品。"
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If System.IO.File.Exists(frmSplash.s & "/tmp/update.txt") Then
            System.IO.File.Delete(frmSplash.s & "/tmp/update.txt")
        End If
        Dim u As Boolean
        u = True
        Try
            My.Computer.Network.DownloadFile("http://39.105.165.68/11.txt", frmSplash.s & "/tmp/update.txt")
        Catch
            u = False
        End Try
        Dim a, b, c As String
        a = ""
        b = ""
        c = ""
        If u Then
            Dim file = New System.IO.StreamReader(frmSplash.s & "/tmp/update.txt")
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
                ElseIf a = "V" & Application.ProductVersion Then
                    MessageBox.Show("当前版本" & Chr(34) & a & Chr(34) & "已经是最新版本。" & Chr(10) & Chr(10) & "当前版本的更新日志为：" & Chr(34) & b & Chr(34), "QikuTestTools更新服务", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("当前没有最新版本信息，只有公告信息，如需要更新应用请前往360社区帖子处自行进入下载地址查看。", "QikuTestTools公告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                MsgBox(a, b, c)
            End If
        Else
            MessageBox.Show("当前无法从服务器上获取更新或公告信息，可能是没有网络连接或者服务器出现异常。", "QikuTestTools无法连接到服务器", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class