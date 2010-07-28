Public Class frmMain
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowCode.Click
        'Showing the code on the right of the screen.

        'End of the code showing.
    End Sub

    Private Sub btnAddNpc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNpc.Click
        frmNpcAdd.ShowDialog()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Statusbar information
        Dim NpcTotal As Integer
        NpcTotal = Me.NpcTableAdapter1.Fill(Me.WsbDataSet1.NPC)
        sbNpcTotal.Text = "Total NPCs: " & NpcTotal


        'Tooltips
        ttpMain.SetToolTip(btnAddNpc, "Add an NPC to your script!")
        ttpMain.SetToolTip(btnShowCode, "Show the latest version of the code.")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem1.Click
        frmNpcAdd.ShowDialog()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        frmHeaderAdd.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem2.Click
        frmHeaderView.ShowDialog()
    End Sub

    Private Sub EditToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem2.Click
        frmHeaderEdit.ShowDialog()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        frmHeaderDelete.ShowDialog()
    End Sub

    Private Sub EditToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem1.Click
        frmCommentAdd.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        frmCommentEdit.ShowDialog()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        frmCommentDelete.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem1.Click
        frmCommentView.ShowDialog()
    End Sub

    Private Sub EditToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem3.Click
        frmNpcEdit.ShowDialog()
    End Sub

    Private Sub DeleteToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem2.Click
        frmNpcDelete.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem3.Click
        frmNpcView.ShowDialog()
    End Sub
End Class
