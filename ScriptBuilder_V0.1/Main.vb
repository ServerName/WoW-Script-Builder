Public Class frmMain

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveCode.Click
        'Save the file
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowCode.Click
        'Showing the code on the right of the screen.
        'txtCode.Text = strComment1 + strHeaders -- Commented out due to showing the list of npcs while I'm working on that system...


        Dim listNpcs As String
        listNpcs = "Name    |   ID  |   Is-A-Boss"


        listNpcs = listNpcs & vbCrLf & collName.Item(listKey) & " | " & collId.Item(listKey) & " | " & collBoss.Item(listKey)


        txtCode.Text = listNpcs


        'MessageBox.Show("There are no NPC's in this script. Add at least one NPC in order to show the code and/or save the file.", "ERROR: There are no NPC's in this script", MessageBoxButtons.OK, MessageBoxIcon.Error)



        'End of the code showing.
    End Sub

    Private Sub btnAddNpc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNpc.Click
        frmNpcAdd.ShowDialog()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Tooltips
        ttpMain.SetToolTip(btnAddNpc, "Add an NPC to your script!")
        ttpMain.SetToolTip(btnShowCode, "Show the latest version of the code.")
        ttpMain.SetToolTip(btnSaveCode, "Save the code to a file on your computer." & vbCrLf & "You should check your code first!")
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
End Class
