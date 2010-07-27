<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.txtInstanceName = New System.Windows.Forms.TextBox
        Me.lblInstanceName = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.btnSaveCode = New System.Windows.Forms.Button
        Me.btnShowCode = New System.Windows.Forms.Button
        Me.btnAddNpc = New System.Windows.Forms.Button
        Me.ttpMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNPCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveNPCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CommentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SyntaxMakeuoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HowDoesThisWorkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportABugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangelogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblCode = New System.Windows.Forms.Label
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInstanceName
        '
        Me.txtInstanceName.Location = New System.Drawing.Point(12, 43)
        Me.txtInstanceName.Name = "txtInstanceName"
        Me.txtInstanceName.Size = New System.Drawing.Size(274, 20)
        Me.txtInstanceName.TabIndex = 2
        '
        'lblInstanceName
        '
        Me.lblInstanceName.AutoSize = True
        Me.lblInstanceName.Location = New System.Drawing.Point(9, 27)
        Me.lblInstanceName.Name = "lblInstanceName"
        Me.lblInstanceName.Size = New System.Drawing.Size(82, 13)
        Me.lblInstanceName.TabIndex = 4
        Me.lblInstanceName.Text = "Instance Name:"
        '
        'txtCode
        '
        Me.txtCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCode.Location = New System.Drawing.Point(292, 43)
        Me.txtCode.Multiline = True
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCode.Size = New System.Drawing.Size(380, 292)
        Me.txtCode.TabIndex = 7
        Me.txtCode.WordWrap = False
        '
        'btnSaveCode
        '
        Me.btnSaveCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSaveCode.Location = New System.Drawing.Point(211, 312)
        Me.btnSaveCode.Name = "btnSaveCode"
        Me.btnSaveCode.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveCode.TabIndex = 8
        Me.btnSaveCode.Text = "Save"
        Me.btnSaveCode.UseVisualStyleBackColor = True
        '
        'btnShowCode
        '
        Me.btnShowCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnShowCode.Location = New System.Drawing.Point(211, 283)
        Me.btnShowCode.Name = "btnShowCode"
        Me.btnShowCode.Size = New System.Drawing.Size(75, 23)
        Me.btnShowCode.TabIndex = 9
        Me.btnShowCode.Text = "Show Code"
        Me.btnShowCode.UseVisualStyleBackColor = True
        '
        'btnAddNpc
        '
        Me.btnAddNpc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddNpc.Location = New System.Drawing.Point(211, 254)
        Me.btnAddNpc.Name = "btnAddNpc"
        Me.btnAddNpc.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNpc.TabIndex = 10
        Me.btnAddNpc.Text = "Add NPC"
        Me.btnAddNpc.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 338)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(684, 24)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(223, 19)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Total NPCs: 0"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(223, 19)
        Me.ToolStripStatusLabel4.Spring = True
        Me.ToolStripStatusLabel4.Text = "Total Spells: 0"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(223, 19)
        Me.ToolStripStatusLabel5.Spring = True
        Me.ToolStripStatusLabel5.Text = "File Name: -"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.SaveToolStripMenuItem, Me.LoadToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNPCToolStripMenuItem, Me.RemoveNPCToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.EditToolStripMenuItem.Text = "Data"
        '
        'AddNPCToolStripMenuItem
        '
        Me.AddNPCToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem1, Me.EditToolStripMenuItem3, Me.DeleteToolStripMenuItem2, Me.ViewToolStripMenuItem3})
        Me.AddNPCToolStripMenuItem.Name = "AddNPCToolStripMenuItem"
        Me.AddNPCToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.AddNPCToolStripMenuItem.Text = "NPCs"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AddToolStripMenuItem1.Text = "Add"
        '
        'EditToolStripMenuItem3
        '
        Me.EditToolStripMenuItem3.Name = "EditToolStripMenuItem3"
        Me.EditToolStripMenuItem3.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem3.Text = "Edit"
        '
        'DeleteToolStripMenuItem2
        '
        Me.DeleteToolStripMenuItem2.Name = "DeleteToolStripMenuItem2"
        Me.DeleteToolStripMenuItem2.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem2.Text = "Delete"
        '
        'ViewToolStripMenuItem3
        '
        Me.ViewToolStripMenuItem3.Name = "ViewToolStripMenuItem3"
        Me.ViewToolStripMenuItem3.Size = New System.Drawing.Size(107, 22)
        Me.ViewToolStripMenuItem3.Text = "View"
        '
        'RemoveNPCToolStripMenuItem
        '
        Me.RemoveNPCToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem2, Me.EditToolStripMenuItem4, Me.DeleteToolStripMenuItem3, Me.ViewToolStripMenuItem4})
        Me.RemoveNPCToolStripMenuItem.Name = "RemoveNPCToolStripMenuItem"
        Me.RemoveNPCToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.RemoveNPCToolStripMenuItem.Text = "Spells"
        '
        'AddToolStripMenuItem2
        '
        Me.AddToolStripMenuItem2.Name = "AddToolStripMenuItem2"
        Me.AddToolStripMenuItem2.Size = New System.Drawing.Size(107, 22)
        Me.AddToolStripMenuItem2.Text = "Add"
        '
        'EditToolStripMenuItem4
        '
        Me.EditToolStripMenuItem4.Name = "EditToolStripMenuItem4"
        Me.EditToolStripMenuItem4.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem4.Text = "Edit"
        '
        'DeleteToolStripMenuItem3
        '
        Me.DeleteToolStripMenuItem3.Name = "DeleteToolStripMenuItem3"
        Me.DeleteToolStripMenuItem3.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem3.Text = "Delete"
        '
        'ViewToolStripMenuItem4
        '
        Me.ViewToolStripMenuItem4.Name = "ViewToolStripMenuItem4"
        Me.ViewToolStripMenuItem4.Size = New System.Drawing.Size(107, 22)
        Me.ViewToolStripMenuItem4.Text = "View"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewCodeToolStripMenuItem, Me.EditCodeToolStripMenuItem, Me.CToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HelpToolStripMenuItem.Text = "Code"
        '
        'ViewCodeToolStripMenuItem
        '
        Me.ViewCodeToolStripMenuItem.Name = "ViewCodeToolStripMenuItem"
        Me.ViewCodeToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ViewCodeToolStripMenuItem.Text = "View Code"
        '
        'EditCodeToolStripMenuItem
        '
        Me.EditCodeToolStripMenuItem.Name = "EditCodeToolStripMenuItem"
        Me.EditCodeToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EditCodeToolStripMenuItem.Text = "Edit Code"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.CToolStripMenuItem.Text = "Clear Code"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommentsToolStripMenuItem, Me.SyntaxMakeuoToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.SettingsToolStripMenuItem1})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'CommentsToolStripMenuItem
        '
        Me.CommentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem1, Me.ViewToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ViewToolStripMenuItem1})
        Me.CommentsToolStripMenuItem.Name = "CommentsToolStripMenuItem"
        Me.CommentsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CommentsToolStripMenuItem.Text = "Comments"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem1.Text = "Add"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ViewToolStripMenuItem1.Text = "View"
        '
        'SyntaxMakeuoToolStripMenuItem
        '
        Me.SyntaxMakeuoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem2, Me.DeleteToolStripMenuItem1, Me.ViewToolStripMenuItem2})
        Me.SyntaxMakeuoToolStripMenuItem.Name = "SyntaxMakeuoToolStripMenuItem"
        Me.SyntaxMakeuoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SyntaxMakeuoToolStripMenuItem.Text = "Headers"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem2
        '
        Me.EditToolStripMenuItem2.Name = "EditToolStripMenuItem2"
        Me.EditToolStripMenuItem2.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem2.Text = "Edit"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'ViewToolStripMenuItem2
        '
        Me.ViewToolStripMenuItem2.Name = "ViewToolStripMenuItem2"
        Me.ViewToolStripMenuItem2.Size = New System.Drawing.Size(107, 22)
        Me.ViewToolStripMenuItem2.Text = "View"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem.Text = "Syntax Editor"
        '
        'SettingsToolStripMenuItem1
        '
        Me.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1"
        Me.SettingsToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem1.Text = "Settings"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HowDoesThisWorkToolStripMenuItem, Me.ReportABugToolStripMenuItem, Me.ChangelogToolStripMenuItem})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HowDoesThisWorkToolStripMenuItem
        '
        Me.HowDoesThisWorkToolStripMenuItem.Name = "HowDoesThisWorkToolStripMenuItem"
        Me.HowDoesThisWorkToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.HowDoesThisWorkToolStripMenuItem.Text = "Scripter Help"
        '
        'ReportABugToolStripMenuItem
        '
        Me.ReportABugToolStripMenuItem.Name = "ReportABugToolStripMenuItem"
        Me.ReportABugToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ReportABugToolStripMenuItem.Text = "Report a Bug"
        '
        'ChangelogToolStripMenuItem
        '
        Me.ChangelogToolStripMenuItem.Name = "ChangelogToolStripMenuItem"
        Me.ChangelogToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ChangelogToolStripMenuItem.Text = "Changelog"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(289, 27)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(35, 13)
        Me.lblCode.TabIndex = 13
        Me.lblCode.Text = "Code:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 362)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnAddNpc)
        Me.Controls.Add(Me.btnShowCode)
        Me.Controls.Add(Me.btnSaveCode)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblInstanceName)
        Me.Controls.Add(Me.txtInstanceName)
        Me.MinimumSize = New System.Drawing.Size(700, 400)
        Me.Name = "frmMain"
        Me.Text = "Script Creator Tool"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInstanceName As System.Windows.Forms.TextBox
    Friend WithEvents lblInstanceName As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents btnAddNpc As System.Windows.Forms.Button
    Friend WithEvents ttpMain As System.Windows.Forms.ToolTip
    Private WithEvents btnSaveCode As System.Windows.Forms.Button
    Private WithEvents btnShowCode As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNPCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveNPCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowDoesThisWorkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportABugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangelogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SyntaxMakeuoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem

End Class
