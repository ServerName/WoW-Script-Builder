Public Class frmNpcDelete
    Private Sub btnNpcDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNpcDelete.Click
        NpcId2 = cbNpcId2.SelectedValue

        Me.NPCTableAdapter.DelNpc(Me.WSBDataSet.NPC, NpcId2)
        Me.Dispose()
        Me.Close()
    End Sub
End Class