Public Class frmNpcEdit
    Private Sub btnNpcEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNpcEdit.Click
        NpcName = txtNpcName.Text
        NpcId = txtNpcId.Text
        NpcBoss = chkNpcBoss.Checked
        NpcId2 = cbNpcId2.SelectedValue

        'Check if something is filled in
        If txtNpcName.Text = "" And txtNpcId.Text = "" Then
            MessageBox.Show("You haven't filled in the NPC Name and ID", "ERROR: No NPC Name and ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtNpcId.Text = "" Then
            MessageBox.Show("You haven't filled in the NPC ID.", "ERROR: No NPC ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtNpcName.Text = "" Then
            MessageBox.Show("You haven't filled in the NPC Name.", "ERROR: No NPC Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsNumeric(txtNpcId.Text) Then
            'Also check if the ID is actually a number -- Names can contain numbers, as it doesn't matter.
            MessageBox.Show("The NPC ID may only contain numbers. Please correct the ID in order to proceed.", "ERROR: Incorrect NPC ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            NpcName = txtNpcName.Text
            NpcId = txtNpcId.Text
            NpcBoss = chkNpcBoss.Checked
            NpcId2 = cbNpcId2.SelectedValue
            Me.NPCTableAdapter.EditNpc(Me.WSBDataSet.NPC, NpcId2, NpcId, NpcName, NpcBoss)
            funcFormClose()
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub frmNpcEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.NPCTableAdapter.Fill(Me.WSBDataSet.NPC)
    End Sub
End Class