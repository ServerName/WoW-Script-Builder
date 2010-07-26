Public Class frmNpcAdd

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNpcSave.Click

        NpcName = txtNpcName.Text
        NpcId = txtNpcId.Text
        NpcBoss = chkBoss.Checked

        'Check if something is filled in
        If NpcName = "" And NpcId = "" Then
            MessageBox.Show("You haven't filled in the NPC Name and ID", "ERROR: No NPC Name and ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NpcId = "" Then
            MessageBox.Show("You haven't filled in the NPC ID.", "ERROR: No NPC ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NpcName = "" Then
            MessageBox.Show("You haven't filled in the NPC Name.", "ERROR: No NPC Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsNumeric(NpcId) Then
            'Also check if the ID is actually a number -- Names can contain numbers, as it doesn't matter.
            MessageBox.Show("The NPC ID may only contain numbers. Please correct the ID in order to proceed.", "ERROR: Incorrect NPC ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            listKey2 = 1
            'Check if the ID or name isn't used yet
            If collKey <> 0 Then


            Else
                Call npcAdd()
            End If



        End If
    End Sub

    Private Sub frmNpcAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Tooltips
        ttpNpcAdd.SetToolTip(txtNpcName, "Enter the name of the NPC here.")
        ttpNpcAdd.SetToolTip(txtNpcId, "Enter the ID of the NPC here.")
        ttpNpcAdd.SetToolTip(chkBoss, "Check this box if the NPC is a boss")
        ttpNpcAdd.SetToolTip(btnNpcSave, "Save the NPC and close the window.")
    End Sub

End Class