﻿Public Class CRUDEntreprise
    Dim table As String = "Entreprise"

    'events
    Private Sub CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.clear() 'clear form
        Me.loadDataGrid()
    End Sub

    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellContentDoubleClick, DataGridView1.CellClick
        Dim x As Integer = e.RowIndex

        If x >= 0 Then
            Try
                Me.labelIdentifRender.Text = Me.DataGridView1.Rows(x).Cells(0).Value
                Me.textBoxName.Text = Me.DataGridView1.Rows(x).Cells(1).Value

                Me.btnDelete.Enabled = True
                Me.btnSave.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Erreur de chargement des données")
                Me.clear()
            End Try
        End If
    End Sub


    'boutons
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.clear()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        General.BDD.nonQuery("INSERT INTO " & Me.table & "(nom) VALUES ('" & Replace(Me.textBoxName.Text, "'", "''") & "');")
        Me.clear() 'clear form
        Me.loadDataGrid() 'refresh data grid
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim identif As Integer = Me.labelIdentifRender.Text
        If identif > 0 Then
            General.BDD.nonQuery("UPDATE " & Me.table & " SET nom='" & Replace(Me.textBoxName.Text, "'", "''") & "' WHERE identif = '" & identif & "';")
            Me.clear() 'clear form
            Me.loadDataGrid() 'refresh data grid
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim identif As Integer = Me.labelIdentifRender.Text
        If identif > 0 Then
            General.BDD.nonQuery("DELETE FROM " & Me.table & " WHERE identif = '" & identif & "';")
            Me.clear() 'clear form
            Me.loadDataGrid() 'refresh data grid
        End If
    End Sub


    'utils
    Private Sub loadDataGrid()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT * FROM " & Me.table & ";")

        Dim dataTable = New DataTable()
        dataTable.Load(reader)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dataTable
        DataGridView1.Refresh()
    End Sub

    Private Sub clear()
        Me.btnDelete.Enabled = False
        Me.btnSave.Enabled = False

        Me.labelIdentifRender.Text = ""
        Me.textBoxName.Text = ""
    End Sub

End Class