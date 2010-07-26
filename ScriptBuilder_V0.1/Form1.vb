Public Class frmMain

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveCode.Click
        'Save the file
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowCode.Click
        'All strings go first, it'll be a wall of text so just scroll until you see the next green text :)
        'This is in order of the file itself, so the names are not in a logical sequence.

        Dim strComment1 As String
        strComment1 = "/*" & vbCrLf & _
        "* ArcScripts for ArcEmu MMORPG Server" & vbCrLf & _
        "* Copyright (C) 2009-2010 ArcEmu Team <http://www.arcemu.org/>" & vbCrLf & _
        "* Copyright (C) 2008-2009 Sun++ Team <http://www.sunscripting.com/>" & vbCrLf & _
        "* Copyright (C) 2007-2008 Moon++ Team <http://www.moonplusplus.info/>" & vbCrLf & _
        "* Copyright (C) 2005-2007 Ascent Team <http://www.ascentemu.com/>" & vbCrLf & _
        "*" & vbCrLf & _
        "* This program is free software: you can redistribute it and/or modify" & vbCrLf & _
        "* it under the terms of the GNU General Public License as published by" & vbCrLf & _
        "* the Free Software Foundation, either version 3 of the License, or" & vbCrLf & _
        "* any later version." & vbCrLf & _
        "*" & vbCrLf & _
        "* This program is distributed in the hope that it will be useful," & vbCrLf & _
        "* but WITHOUT ANY WARRANTY; without even the implied warranty of" & vbCrLf & _
        "* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the" & vbCrLf & _
        "* GNU General Public License for more details." & vbCrLf & _
        "*" & vbCrLf & _
        "* You should have received a copy of the GNU General Public License" & vbCrLf & _
        "* along with this program.  If not, see <http://www.gnu.org/licenses/>." & vbCrLf & _
        "*/" & vbCrLf & _
        ""

        Dim strHeaders As String
        strHeaders = "" & vbCrLf & _
        "#include ""StdAfx.h/""" & vbCrLf & _
        "#include ""Setup.h""" & vbCrLf & _
        "#include ""../Common/Base.h""" & vbCrLf & _
        ""

        'End of the strings, don't touch it if you don't know what you're doing. Some things won't change anything (they create comments) other things may break the script.

        'Showing the code on the right of the screen.
        'txtCode.Text = strComment1 + strHeaders -- Commented out due to showing the list of npcs while I'm working on that system...


        Dim listNpcs As String
        listKey = 1
        listNpcs = "Name   |   ID   |   Is-A-Boss"

        If collKey <> 0 Then
            While listKey <= collKey
                listNpcs = listNpcs & vbCrLf & collName.Item(listKey) & " | " & collId.Item(listKey) & " | " & collBoss.Item(listKey)
                listKey += 1

                txtCode.Text = listNpcs
            End While
        Else
            MessageBox.Show("There are no NPC's in the memory. Add at least one NPC in order to show the code and/or save the file.", "ERROR: No NPC in memory", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'End of the code showing.
    End Sub

    Private Sub btnAddNpc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNpc.Click
        'Opening New NPC window
        frmNpcAdd.ShowDialog()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WSB_DBDataSet.NPC' table. You can move, or remove it, as needed.
        Me.NPCTableAdapter.Fill(Me.WSB_DBDataSet.NPC)
        'Tooltips
        ttpMain.SetToolTip(btnAddNpc, "Open a window to add an NPC to the script.")
        ttpMain.SetToolTip(btnShowCode, "Show the last version of the code.")
        ttpMain.SetToolTip(btnSaveCode, "Save the code to a file." & vbCrLf & "It is advised to check the code first.")
    End Sub

    Private Sub lblInstanceName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblInstanceName.Click

    End Sub

    Private Sub ToolsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub lblCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCode.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class
