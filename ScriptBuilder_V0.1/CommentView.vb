Public Class frmCommentView
    Private Sub frmCommentView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WSBDataSet.Comments' table. You can move, or remove it, as needed.
        Me.CommentsTableAdapter.Fill(Me.WSBDataSet.Comments)
    End Sub
End Class