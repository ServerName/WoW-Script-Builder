<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNpcAdd
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
        Me.txtNpcName = New System.Windows.Forms.TextBox
        Me.lblNpcName = New System.Windows.Forms.Label
        Me.txtNpcId = New System.Windows.Forms.TextBox
        Me.lblNpcId = New System.Windows.Forms.Label
        Me.btnNpcSave = New System.Windows.Forms.Button
        Me.chkBoss = New System.Windows.Forms.CheckBox
        Me.ttpNpcAdd = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtNpcName
        '
        Me.txtNpcName.Location = New System.Drawing.Point(12, 25)
        Me.txtNpcName.Name = "txtNpcName"
        Me.txtNpcName.Size = New System.Drawing.Size(226, 20)
        Me.txtNpcName.TabIndex = 0
        '
        'lblNpcName
        '
        Me.lblNpcName.AutoSize = True
        Me.lblNpcName.Location = New System.Drawing.Point(12, 9)
        Me.lblNpcName.Name = "lblNpcName"
        Me.lblNpcName.Size = New System.Drawing.Size(60, 13)
        Me.lblNpcName.TabIndex = 1
        Me.lblNpcName.Text = "NPC Name"
        '
        'txtNpcId
        '
        Me.txtNpcId.Location = New System.Drawing.Point(244, 25)
        Me.txtNpcId.Name = "txtNpcId"
        Me.txtNpcId.Size = New System.Drawing.Size(79, 20)
        Me.txtNpcId.TabIndex = 2
        '
        'lblNpcId
        '
        Me.lblNpcId.AutoSize = True
        Me.lblNpcId.Location = New System.Drawing.Point(241, 9)
        Me.lblNpcId.Name = "lblNpcId"
        Me.lblNpcId.Size = New System.Drawing.Size(43, 13)
        Me.lblNpcId.TabIndex = 3
        Me.lblNpcId.Text = "NPC ID"
        '
        'btnNpcSave
        '
        Me.btnNpcSave.Location = New System.Drawing.Point(244, 48)
        Me.btnNpcSave.Name = "btnNpcSave"
        Me.btnNpcSave.Size = New System.Drawing.Size(79, 23)
        Me.btnNpcSave.TabIndex = 4
        Me.btnNpcSave.Text = "Save NPC"
        Me.btnNpcSave.UseVisualStyleBackColor = True
        '
        'chkBoss
        '
        Me.chkBoss.AutoSize = True
        Me.chkBoss.Location = New System.Drawing.Point(12, 48)
        Me.chkBoss.Name = "chkBoss"
        Me.chkBoss.Size = New System.Drawing.Size(93, 17)
        Me.chkBoss.TabIndex = 5
        Me.chkBoss.Text = "NPC is a Boss"
        Me.chkBoss.UseVisualStyleBackColor = True
        '
        'frmNpcAdd
        '
        Me.AcceptButton = Me.btnNpcSave
        Me.AccessibleDescription = ""
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 83)
        Me.Controls.Add(Me.chkBoss)
        Me.Controls.Add(Me.btnNpcSave)
        Me.Controls.Add(Me.lblNpcId)
        Me.Controls.Add(Me.txtNpcId)
        Me.Controls.Add(Me.lblNpcName)
        Me.Controls.Add(Me.txtNpcName)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(351, 121)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(351, 121)
        Me.Name = "frmNpcAdd"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New NPC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNpcName As System.Windows.Forms.TextBox
    Friend WithEvents lblNpcName As System.Windows.Forms.Label
    Friend WithEvents txtNpcId As System.Windows.Forms.TextBox
    Friend WithEvents lblNpcId As System.Windows.Forms.Label
    Friend WithEvents chkBoss As System.Windows.Forms.CheckBox
    Friend WithEvents ttpNpcAdd As System.Windows.Forms.ToolTip
    Private WithEvents btnNpcSave As System.Windows.Forms.Button
End Class
