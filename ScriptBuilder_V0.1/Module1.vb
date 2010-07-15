Module Module1
    'Collection
    'NPC
    Public collName As New Microsoft.VisualBasic.Collection()
    Public collId As New Microsoft.VisualBasic.Collection()
    Public collBoss As New Microsoft.VisualBasic.Collection()
    Public collKey As Integer
    Public listKey As Integer
    Public listKey2 As Integer

    'Spells

    'TODO


    'Public Variables
    Public NpcName As String
    Public NpcId As String
    Public NpcBoss As Boolean
    Function npcAdd() As Boolean

        'Add mob to collection
        collName.Add(NpcName, collKey)
        collId.Add(NpcId, collKey)
        If NpcBoss Then
            collBoss.Add(1, collKey)
        Else
            collBoss.Add(0, collKey)
        End If

        collKey += 1

        'Close 'n dispose
        frmNpcAdd.Dispose()
        frmNpcAdd.Close()


    End Function
End Module
