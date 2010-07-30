Public Class frmNpcDelete
    Private Sub btnNpcDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNpcDelete.Click
        NpcId2 = cbNpcId2.SelectedValue

        Me.NPCTableAdapter.DelNpc(Me.WSBDataSet.NPC, NpcId2)
        funcFormClose()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmNpcDelete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.NPCTableAdapter.Fill(Me.WSBDataSet.NPC)
    End Sub
End Class