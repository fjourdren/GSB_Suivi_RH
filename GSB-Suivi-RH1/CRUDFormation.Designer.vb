﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRUDFormation
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRUDFormation))
        Me.textBoxName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.labelIdentifRender = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lebelIdentifRender = New System.Windows.Forms.Label()
        Me.labelIdentif = New System.Windows.Forms.Label()
        Me.labelName = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textBoxName
        '
        Me.textBoxName.Location = New System.Drawing.Point(66, 32)
        Me.textBoxName.Name = "textBoxName"
        Me.textBoxName.Size = New System.Drawing.Size(163, 20)
        Me.textBoxName.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.labelIdentifRender)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.lebelIdentifRender)
        Me.GroupBox1.Controls.Add(Me.labelIdentif)
        Me.GroupBox1.Controls.Add(Me.labelName)
        Me.GroupBox1.Controls.Add(Me.textBoxName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(627, 143)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(533, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(88, 23)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "Réinitialiser"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(533, 101)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Supprimer"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(533, 70)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Sauvegarder"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'labelIdentifRender
        '
        Me.labelIdentifRender.AutoSize = True
        Me.labelIdentifRender.Location = New System.Drawing.Point(66, 16)
        Me.labelIdentifRender.Name = "labelIdentifRender"
        Me.labelIdentifRender.Size = New System.Drawing.Size(39, 13)
        Me.labelIdentifRender.TabIndex = 5
        Me.labelIdentifRender.Text = "Label1"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(533, 41)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(88, 23)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "Nouveau"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lebelIdentifRender
        '
        Me.lebelIdentifRender.AutoSize = True
        Me.lebelIdentifRender.Location = New System.Drawing.Point(63, 16)
        Me.lebelIdentifRender.Name = "lebelIdentifRender"
        Me.lebelIdentifRender.Size = New System.Drawing.Size(0, 13)
        Me.lebelIdentifRender.TabIndex = 4
        '
        'labelIdentif
        '
        Me.labelIdentif.AutoSize = True
        Me.labelIdentif.Location = New System.Drawing.Point(6, 16)
        Me.labelIdentif.Name = "labelIdentif"
        Me.labelIdentif.Size = New System.Drawing.Size(24, 13)
        Me.labelIdentif.TabIndex = 3
        Me.labelIdentif.Text = "ID :"
        '
        'labelName
        '
        Me.labelName.AutoSize = True
        Me.labelName.Location = New System.Drawing.Point(6, 35)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(35, 13)
        Me.labelName.TabIndex = 2
        Me.labelName.Text = "Nom :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 161)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(628, 279)
        Me.DataGridView1.TabIndex = 3
        '
        'CRUDFormation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(669, 489)
        Me.MinimumSize = New System.Drawing.Size(669, 489)
        Me.Name = "CRUDFormation"
        Me.Text = "Gestion des Formations"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents textBoxName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lebelIdentifRender As Label
    Friend WithEvents labelIdentif As Label
    Friend WithEvents labelName As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents labelIdentifRender As Label
    Friend WithEvents btnReset As Button
End Class