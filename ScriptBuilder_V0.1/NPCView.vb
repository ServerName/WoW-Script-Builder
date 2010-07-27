Public Class frmNpcView
    Private Sub frmNpcView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WSBDataSet.NPC' table. You can move, or remove it, as needed.
        Me.NPCTableAdapter.Fill(Me.WSBDataSet.NPC)

    End Sub
End Class