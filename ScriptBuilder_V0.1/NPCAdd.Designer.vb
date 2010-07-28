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
        Dim lblNpcId As System.Windows.Forms.Label
        Dim lblNpcName As System.Windows.Forms.Label
        Me.ttpNpcAdd = New System.Windows.Forms.ToolTip(Me.components)
        Me.WSBDataSet = New ScriptBuilder_V0._1.WSBDataSet
        Me.NPCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NPCTableAdapter = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.NPCTableAdapter
        Me.TableAdapterManager = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
        Me.txtNpcId = New System.Windows.Forms.TextBox
        Me.txtNpcName = New System.Windows.Forms.TextBox
        Me.chkNpcBoss = New System.Windows.Forms.CheckBox
        Me.btnNpcAdd = New System.Windows.Forms.Button
        lblNpcId = New System.Windows.Forms.Label
        lblNpcName = New System.Windows.Forms.Label
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NPCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNpcId
        '
        lblNpcId.AutoSize = True
        lblNpcId.Location = New System.Drawing.Point(243, 9)
        lblNpcId.Name = "lblNpcId"
        lblNpcId.Size = New System.Drawing.Size(46, 13)
        lblNpcId.TabIndex = 1
        lblNpcId.Text = "NPC ID:"
        '
        'lblNpcName
        '
        lblNpcName.AutoSize = True
        lblNpcName.Location = New System.Drawing.Point(12, 9)
        lblNpcName.Name = "lblNpcName"
        lblNpcName.Size = New System.Drawing.Size(63, 13)
        lblNpcName.TabIndex = 3
        lblNpcName.Text = "NPC Name:"
        '
        'WSBDataSet
        '
        Me.WSBDataSet.DataSetName = "WSBDataSet"
        Me.WSBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NPCBindingSource
        '
        Me.NPCBindingSource.DataMember = "NPC"
        Me.NPCBindingSource.DataSource = Me.WSBDataSet
        '
        'NPCTableAdapter
        '
        Me.NPCTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CommentsTableAdapter = Nothing
        Me.TableAdapterManager.HeadersTableAdapter = Nothing
        Me.TableAdapterManager.NPCTableAdapter = Me.NPCTableAdapter
        Me.TableAdapterManager.UpdateOrder = ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtNpcId
        '
        Me.txtNpcId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NPCBindingSource, "NPCID", True))
        Me.txtNpcId.Location = New System.Drawing.Point(246, 25)
        Me.txtNpcId.Name = "txtNpcId"
        Me.txtNpcId.Size = New System.Drawing.Size(77, 20)
        Me.txtNpcId.TabIndex = 2
        '
        'txtNpcName
        '
        Me.txtNpcName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NPCBindingSource, "NPCName", True))
        Me.txtNpcName.Location = New System.Drawing.Point(12, 25)
        Me.txtNpcName.Name = "txtNpcName"
        Me.txtNpcName.Size = New System.Drawing.Size(228, 20)
        Me.txtNpcName.TabIndex = 4
        '
        'chkNpcBoss
        '
        Me.chkNpcBoss.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.NPCBindingSource, "Boss", True))
        Me.chkNpcBoss.Location = New System.Drawing.Point(188, 55)
        Me.chkNpcBoss.Name = "chkNpcBoss"
        Me.chkNpcBoss.Size = New System.Drawing.Size(52, 19)
        Me.chkNpcBoss.TabIndex = 6
        Me.chkNpcBoss.Text = "Boss"
        Me.chkNpcBoss.UseVisualStyleBackColor = True
        '
        'btnNpcAdd
        '
        Me.btnNpcAdd.Location = New System.Drawing.Point(248, 51)
        Me.btnNpcAdd.Name = "btnNpcAdd"
        Me.btnNpcAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnNpcAdd.TabIndex = 7
        Me.btnNpcAdd.Text = "Add"
        Me.btnNpcAdd.UseVisualStyleBackColor = True
        '
        'frmNpcAdd
        '
        Me.AccessibleDescription = ""
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 83)
        Me.Controls.Add(Me.btnNpcAdd)
        Me.Controls.Add(lblNpcId)
        Me.Controls.Add(Me.txtNpcId)
        Me.Controls.Add(lblNpcName)
        Me.Controls.Add(Me.txtNpcName)
        Me.Controls.Add(Me.chkNpcBoss)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNpcAdd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add NPC"
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NPCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ttpNpcAdd As System.Windows.Forms.ToolTip
    Friend WithEvents WSBDataSet As ScriptBuilder_V0._1.WSBDataSet
    Friend WithEvents NPCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NPCTableAdapter As ScriptBuilder_V0._1.WSBDataSetTableAdapters.NPCTableAdapter
    Friend WithEvents TableAdapterManager As ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtNpcId As System.Windows.Forms.TextBox
    Friend WithEvents txtNpcName As System.Windows.Forms.TextBox
    Friend WithEvents chkNpcBoss As System.Windows.Forms.CheckBox
    Friend WithEvents btnNpcAdd As System.Windows.Forms.Button
End Class
