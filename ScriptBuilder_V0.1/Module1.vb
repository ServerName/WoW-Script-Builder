Module Module1
    'Public Variables
    'Main Variables
    Public NpcTotal As Integer

    'NPC variables
    Public NpcName As String
    Public NpcId As Integer
    Public NpcBoss As Boolean
    Public NpcId2 As Integer

    'Header variables
    Public HeaderName As String
    Public HeaderId As Integer

    'Comment variables
    Public CommentName As String
    Public CommentId As Integer

    Function funcFormClose() As Boolean 'No clue what I should use, so I just pick boolean.
        NpcTotal = frmMain.NpcTableAdapter1.Fill(frmMain.WsbDataSet1.NPC)
        frmMain.sbNpcTotal.Text = "Total NPCs: " & NpcTotal
    End Function
End Module
