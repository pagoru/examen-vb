Imports System.Data.SqlClient

Public Class Form

    Private sqlConnection As SqlConnection

    Private ds_articles, ds_families As DataSet
    Private sda_articles, sda_families As SqlDataAdapter
    Private bmb_articles As BindingManagerBase

    Private columns_article As String() = {"CODIARTICLE", "DESCRIPCIOARTICLE", "PREU", "CODIFAMILIA", "ESTOCACTUAL", "COMENTARIS", "PREUAMBIVA"}

    Private PROXNUMARTICLE As Integer

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlConnection = New SqlConnection()
        sqlConnection.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=EX02; Trusted_Connection=True;"
        sqlConnection.Open()


        sda_articles = New SqlDataAdapter("SELECT * FROM ARTICLES ORDER BY codiarticle", sqlConnection)
        Dim sqlCommandBuilder As SqlCommandBuilder = New SqlCommandBuilder(sda_articles)

        ds_articles = New DataSet()
        sda_articles.Fill(ds_articles, "Articles")
        BindArticles()

        sda_families = New SqlDataAdapter("SELECT * FROM FAMILIES", sqlConnection)
        sqlCommandBuilder = New SqlCommandBuilder(sda_families)

        ds_families = New DataSet()
        sda_families.Fill(ds_families, "Families")


        SelectorsUpdate()
    End Sub

    Private Function GetProxNumArticle()
        Dim int As Integer
        Dim read As SqlDataReader
        Dim sqlCommand = New SqlCommand
        sqlCommand.Connection = sqlConnection
        sqlCommand.CommandText = "SELECT PROXNUMARTICLE FROM NUMERACIONS"

        read = sqlCommand.ExecuteReader()
        read.Read()
        int = Integer.Parse(read(0))
        read.Close()

        Return int
    End Function

    Private Sub IncrementProxNumArticle()
        Dim sqlCommand = New SqlCommand
        sqlCommand.Connection = sqlConnection
        sqlCommand.CommandText = "UPDATE NUMERACIONS SET PROXNUMARTICLE += 1"

        sqlCommand.ExecuteNonQuery()
    End Sub

    Private Sub BindArticles()
        Dim inputs_article As TextBox() = {CodiArticle, DescripcioArticle, Preu, CodiFamilia, EstocActual, Comentaris, PreuAmbIVA}

        For index As Integer = 0 To columns_article.Length - 1 Step 1
            inputs_article(index).DataBindings.Add(New Binding("Text", ds_articles, "Articles." + columns_article(index)))
        Next
        bmb_articles = BindingContext(ds_articles, "Articles")
    End Sub

    Private Sub LeftSelectorsEnabled(bool As Boolean)
        Primer.Enabled = bool
        Anterior.Enabled = bool
    End Sub

    Private Sub RightSelectorsenabled(bool As Boolean)
        Ultim.Enabled = bool
        Seguent.Enabled = bool
    End Sub

    Private Sub SelectorsUpdate()
        LeftSelectorsEnabled(True)
        RightSelectorsenabled(True)
        If bmb_articles.Count > 1 Then
            If bmb_articles.Position = 0 Then
                LeftSelectorsEnabled(False)
            ElseIf bmb_articles.Count - 1 = bmb_articles.Position Then
                RightSelectorsenabled(False)
            End If
            Return
        End If
        LeftSelectorsEnabled(False)
        RightSelectorsenabled(False)
    End Sub

    Private Sub Primer_Click(sender As Object, e As EventArgs) Handles Primer.Click
        bmb_articles.Position = 0
        SelectorsUpdate()
    End Sub

    Private Sub Anterior_Click(sender As Object, e As EventArgs) Handles Anterior.Click
        bmb_articles.Position -= 1
        SelectorsUpdate()
    End Sub

    Private Sub Seguent_Click(sender As Object, e As EventArgs) Handles Seguent.Click
        bmb_articles.Position += 1
        SelectorsUpdate()
    End Sub

    Private Sub Ultim_Click(sender As Object, e As EventArgs) Handles Ultim.Click
        bmb_articles.Position = bmb_articles.Count - 1
        SelectorsUpdate()
    End Sub

    Private Sub ToggleEditMode()
        ModificarEstoc.Visible = Not ModificarEstoc.Visible
        Cancelar.Visible = Not Cancelar.Visible
        Acceptar.Visible = Not Acceptar.Visible

        Crear.Visible = Not Crear.Visible
        Modificar.Visible = Not Modificar.Visible
        Eliminar.Visible = Not Eliminar.Visible

        Primer.Visible = Not Primer.Visible
        Anterior.Visible = Not Anterior.Visible
        Ultim.Visible = Not Ultim.Visible
        Seguent.Visible = Not Seguent.Visible

        DescripcioArticle.ReadOnly = Not DescripcioArticle.ReadOnly
        Preu.ReadOnly = Not Preu.ReadOnly
        CodiFamilia.ReadOnly = Not CodiFamilia.ReadOnly
        Comentaris.ReadOnly = Not Comentaris.ReadOnly
    End Sub

    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        bmb_articles.AddNew()
        CodiArticle.Text = GetProxNumArticle()
        ToggleEditMode()
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        ToggleEditMode()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        bmb_articles.CancelCurrentEdit()
        ToggleEditMode()
        SelectorsUpdate()
    End Sub

    Private Sub Preu_TextChanged(sender As Object, e As EventArgs) Handles Preu.TextChanged
        If Preu.Text.Length > 0 Then
            Try
                PreuAmbIVA.Text = Decimal.Parse(Preu.Text) * 1.21
            Catch ex As Exception
                MsgBox("El preu ha de ser un número valid")
            End Try
        End If
    End Sub

    Private Sub Acceptar_Click(sender As Object, e As EventArgs) Handles Acceptar.Click
        bmb_articles.EndCurrentEdit()
        If Not CanSaveCurrentEdit() Then
            Return
        End If
        IncrementProxNumArticle()

        If Not MakePersistencia() Then
            Return
        End If
        ToggleEditMode()
        SelectorsUpdate()
    End Sub

    Private Function CanSaveCurrentEdit()
        If DescripcioArticle.Text.Length = 0 Then
            MsgBox("El camp de la descripció no pot estar vuit")
            Return False
        End If
        If CodiFamilia.Text.Length > 0 Then
            If Not isCodiFamiliaValid(CodiFamilia.Text) Then
                MsgBox("El codi de la familia no es valid")
                Return False
            End If
        End If
        Return True
    End Function

    Private Function isCodiFamiliaValid(codi As String)
        Dim c As String
        For index As Integer = 0 To ds_families.Tables("Families").Rows.Count - 1
            c = ds_families.Tables("Families").Rows(index)("CODIFAMILIA")
            If codi = c Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub ModificarEstoc_Click(sender As Object, e As EventArgs) Handles ModificarEstoc.Click
        Dim estoc As String = InputBox("Introdueix un integer valid per l'estoc actual", "Estoc", EstocActual.Text)

        If estoc.Length = 0 Then
            Return
        End If
        Try
            Integer.Parse(estoc)
            EstocActual.Text = estoc
        Catch ex As Exception
            MsgBox("L'estoc ha de ser un integr valid!")
        End Try
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If MessageBox.Show("Vols eliminar l'article?", "Alerta!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            bmb_articles.RemoveAt(bmb_articles.Position)

            MakePersistencia()
            SelectorsUpdate()
        End If
    End Sub

    Private Function MakePersistencia()
        Try
            sda_articles.Update(ds_articles.Tables("Articles").GetChanges())
            ds_articles.Tables("Articles").AcceptChanges()
            Return True
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        Return False
    End Function

End Class
