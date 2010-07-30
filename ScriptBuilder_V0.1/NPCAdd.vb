Public Class frmNpcAdd
    Private Sub frmNpcAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Tooltips
        ttpNpcAdd.SetToolTip(txtNpcName, "Enter the name of the NPC here.")
        ttpNpcAdd.SetToolTip(txtNpcId, "Enter the ID of the NPC here.")
        ttpNpcAdd.SetToolTip(chkNpcBoss, "Check this box if the NPC is a boss")
        ttpNpcAdd.SetToolTip(btnNpcAdd, "Save the NPC and close the window.")
    End Sub

    Private Sub btnNpcAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNpcAdd.Click
        NpcName = txtNpcName.Text
        NpcId = txtNpcId.Text
        NpcBoss = chkNpcBoss.Checked

        'Check if something is filled in
        If txtNpcName.Text = "" And txtNpcId.Text = "" Then
            MessageBox.Show("You haven't filled in the NPC Name and ID", "ERROR: No NPC Name and ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtNpcId.Text = "" Then
            MessageBox.Show("You haven't filled in the NPC ID.", "ERROR: No NPC ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtNpcName.Text = "" Then
            MessageBox.Show("You haven't filled in the NPC Name.", "ERROR: No NPC Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsNumeric(txtNpcId.Text) Then
            'Also check if the ID is actually a number
            MessageBox.Show("The NPC ID may only contain numbers. Please correct the ID in order to proceed.", "ERROR: Incorrect NPC ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            NpcName = txtNpcName.Text
            NpcId = txtNpcId.Text
            NpcBoss = chkNpcBoss.Checked

            Me.NPCTableAdapter.AddNpc(Me.WSBDataSet.NPC, NpcId, NpcName, NpcBoss)
            funcFormClose()
            Me.Dispose()
            Me.Close()
        End If
    End Sub
End Class