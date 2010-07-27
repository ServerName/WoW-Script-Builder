<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNpcEdit
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
        Dim lblNpcId2 As System.Windows.Forms.Label
        Me.WSBDataSet = New ScriptBuilder_V0._1.WSBDataSet
        Me.NPCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NPCTableAdapter = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.NPCTableAdapter
        Me.TableAdapterManager = New ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
        Me.txtNpcId = New System.Windows.Forms.TextBox
        Me.chkNpcBoss = New System.Windows.Forms.CheckBox
        Me.txtNpcName = New System.Windows.Forms.TextBox
        Me.btnNpcEdit = New System.Windows.Forms.Button
        Me.nudNpcId2 = New System.Windows.Forms.NumericUpDown
        lblNpcId = New System.Windows.Forms.Label
        lblNpcName = New System.Windows.Forms.Label
        lblNpcId2 = New System.Windows.Forms.Label
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NPCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNpcId2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        lblNpcName.TabIndex = 5
        lblNpcName.Text = "NPC Name:"
        '
        'lblNpcId2
        '
        lblNpcId2.AutoSize = True
        lblNpcId2.Location = New System.Drawing.Point(12, 51)
        lblNpcId2.Name = "lblNpcId2"
        lblNpcId2.Size = New System.Drawing.Size(21, 13)
        lblNpcId2.TabIndex = 7
        lblNpcId2.Text = "ID:"
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
        'chkNpcBoss
        '
        Me.chkNpcBoss.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.NPCBindingSource, "Boss", True))
        Me.chkNpcBoss.Location = New System.Drawing.Point(188, 54)
        Me.chkNpcBoss.Name = "chkNpcBoss"
        Me.chkNpcBoss.Size = New System.Drawing.Size(52, 19)
        Me.chkNpcBoss.TabIndex = 4
        Me.chkNpcBoss.Text = "Boss"
        Me.chkNpcBoss.UseVisualStyleBackColor = True
        '
        'txtNpcName
        '
        Me.txtNpcName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NPCBindingSource, "NPCName", True))
        Me.txtNpcName.Location = New System.Drawing.Point(12, 25)
        Me.txtNpcName.Name = "txtNpcName"
        Me.txtNpcName.Size = New System.Drawing.Size(228, 20)
        Me.txtNpcName.TabIndex = 6
        '
        'btnNpcEdit
        '
        Me.btnNpcEdit.Location = New System.Drawing.Point(248, 51)
        Me.btnNpcEdit.Name = "btnNpcEdit"
        Me.btnNpcEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnNpcEdit.TabIndex = 7
        Me.btnNpcEdit.Text = "Edit"
        Me.btnNpcEdit.UseVisualStyleBackColor = True
        '
        'nudNpcId2
        '
        Me.nudNpcId2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NPCBindingSource, "ID", True))
        Me.nudNpcId2.Location = New System.Drawing.Point(39, 51)
        Me.nudNpcId2.Name = "nudNpcId2"
        Me.nudNpcId2.Size = New System.Drawing.Size(143, 20)
        Me.nudNpcId2.TabIndex = 8
        '
        'frmNpcEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 83)
        Me.Controls.Add(lblNpcId2)
        Me.Controls.Add(Me.nudNpcId2)
        Me.Controls.Add(Me.btnNpcEdit)
        Me.Controls.Add(lblNpcName)
        Me.Controls.Add(Me.txtNpcName)
        Me.Controls.Add(Me.chkNpcBoss)
        Me.Controls.Add(lblNpcId)
        Me.Controls.Add(Me.txtNpcId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNpcEdit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit NPC"
        CType(Me.WSBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NPCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNpcId2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WSBDataSet As ScriptBuilder_V0._1.WSBDataSet
    Friend WithEvents NPCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NPCTableAdapter As ScriptBuilder_V0._1.WSBDataSetTableAdapters.NPCTableAdapter
    Friend WithEvents TableAdapterManager As ScriptBuilder_V0._1.WSBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtNpcId As System.Windows.Forms.TextBox
    Friend WithEvents chkNpcBoss As System.Windows.Forms.CheckBox
    Friend WithEvents txtNpcName As System.Windows.Forms.TextBox
    Friend WithEvents btnNpcEdit As System.Windows.Forms.Button
    Friend WithEvents nudNpcId2 As System.Windows.Forms.NumericUpDown
End Class
