Public Class frmSpread
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("即将前往查看" & Chr(34) & "晨钟酱" & Chr(34) & "授权于QikuTestTools的全机型免玩机ROOT工具箱——《GJ2x_搞机工具箱》的介绍及获取方式。", "获取《GJ2x_搞机工具箱》", MessageBoxButtons.OK, MessageBoxIcon.Information)
        System.Diagnostics.Process.Start("https://bbs.360.cn/forum.php?mod=viewthread&tid=15898448")
    End Sub
End Class