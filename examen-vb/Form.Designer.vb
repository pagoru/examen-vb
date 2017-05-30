<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PreuAmbIVA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Comentaris = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EstocActual = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CodiFamilia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Preu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DescripcioArticle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CodiArticle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Crear = New System.Windows.Forms.Button()
        Me.ModificarEstoc = New System.Windows.Forms.Button()
        Me.Primer = New System.Windows.Forms.Button()
        Me.Anterior = New System.Windows.Forms.Button()
        Me.Ultim = New System.Windows.Forms.Button()
        Me.Seguent = New System.Windows.Forms.Button()
        Me.Acceptar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PreuAmbIVA)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Comentaris)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.EstocActual)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CodiFamilia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Preu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DescripcioArticle)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CodiArticle)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 208)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Article"
        '
        'PreuAmbIVA
        '
        Me.PreuAmbIVA.Location = New System.Drawing.Point(113, 177)
        Me.PreuAmbIVA.Name = "PreuAmbIVA"
        Me.PreuAmbIVA.ReadOnly = True
        Me.PreuAmbIVA.Size = New System.Drawing.Size(97, 20)
        Me.PreuAmbIVA.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "PreuAmbIVA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Comentaris
        '
        Me.Comentaris.Location = New System.Drawing.Point(113, 151)
        Me.Comentaris.Name = "Comentaris"
        Me.Comentaris.ReadOnly = True
        Me.Comentaris.Size = New System.Drawing.Size(97, 20)
        Me.Comentaris.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Comentaris"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EstocActual
        '
        Me.EstocActual.Location = New System.Drawing.Point(113, 125)
        Me.EstocActual.Name = "EstocActual"
        Me.EstocActual.ReadOnly = True
        Me.EstocActual.Size = New System.Drawing.Size(97, 20)
        Me.EstocActual.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(7, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "EstocActual"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CodiFamilia
        '
        Me.CodiFamilia.Location = New System.Drawing.Point(113, 99)
        Me.CodiFamilia.Name = "CodiFamilia"
        Me.CodiFamilia.ReadOnly = True
        Me.CodiFamilia.Size = New System.Drawing.Size(97, 20)
        Me.CodiFamilia.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(7, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CodiFamilia"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Preu
        '
        Me.Preu.Location = New System.Drawing.Point(113, 73)
        Me.Preu.Name = "Preu"
        Me.Preu.ReadOnly = True
        Me.Preu.Size = New System.Drawing.Size(97, 20)
        Me.Preu.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Preu"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DescripcioArticle
        '
        Me.DescripcioArticle.Location = New System.Drawing.Point(113, 47)
        Me.DescripcioArticle.Name = "DescripcioArticle"
        Me.DescripcioArticle.ReadOnly = True
        Me.DescripcioArticle.Size = New System.Drawing.Size(97, 20)
        Me.DescripcioArticle.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DescripcioArticle"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CodiArticle
        '
        Me.CodiArticle.Location = New System.Drawing.Point(113, 21)
        Me.CodiArticle.Name = "CodiArticle"
        Me.CodiArticle.ReadOnly = True
        Me.CodiArticle.Size = New System.Drawing.Size(97, 20)
        Me.CodiArticle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CodiArticle"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(238, 59)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(97, 20)
        Me.Modificar.TabIndex = 15
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(238, 86)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(97, 20)
        Me.Eliminar.TabIndex = 16
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Crear
        '
        Me.Crear.Location = New System.Drawing.Point(238, 34)
        Me.Crear.Name = "Crear"
        Me.Crear.Size = New System.Drawing.Size(97, 20)
        Me.Crear.TabIndex = 17
        Me.Crear.Text = "Crear"
        Me.Crear.UseVisualStyleBackColor = True
        '
        'ModificarEstoc
        '
        Me.ModificarEstoc.Location = New System.Drawing.Point(238, 138)
        Me.ModificarEstoc.Name = "ModificarEstoc"
        Me.ModificarEstoc.Size = New System.Drawing.Size(97, 20)
        Me.ModificarEstoc.TabIndex = 18
        Me.ModificarEstoc.Text = "Modificar Estoc"
        Me.ModificarEstoc.UseVisualStyleBackColor = True
        Me.ModificarEstoc.Visible = False
        '
        'Primer
        '
        Me.Primer.Location = New System.Drawing.Point(23, 227)
        Me.Primer.Name = "Primer"
        Me.Primer.Size = New System.Drawing.Size(61, 20)
        Me.Primer.TabIndex = 18
        Me.Primer.Text = "<<"
        Me.Primer.UseVisualStyleBackColor = True
        '
        'Anterior
        '
        Me.Anterior.Location = New System.Drawing.Point(90, 227)
        Me.Anterior.Name = "Anterior"
        Me.Anterior.Size = New System.Drawing.Size(61, 20)
        Me.Anterior.TabIndex = 19
        Me.Anterior.Text = "<"
        Me.Anterior.UseVisualStyleBackColor = True
        '
        'Ultim
        '
        Me.Ultim.Location = New System.Drawing.Point(229, 227)
        Me.Ultim.Name = "Ultim"
        Me.Ultim.Size = New System.Drawing.Size(61, 20)
        Me.Ultim.TabIndex = 20
        Me.Ultim.Text = ">>"
        Me.Ultim.UseVisualStyleBackColor = True
        '
        'Seguent
        '
        Me.Seguent.Location = New System.Drawing.Point(162, 227)
        Me.Seguent.Name = "Seguent"
        Me.Seguent.Size = New System.Drawing.Size(61, 20)
        Me.Seguent.TabIndex = 21
        Me.Seguent.Text = ">"
        Me.Seguent.UseVisualStyleBackColor = True
        '
        'Acceptar
        '
        Me.Acceptar.Location = New System.Drawing.Point(238, 190)
        Me.Acceptar.Name = "Acceptar"
        Me.Acceptar.Size = New System.Drawing.Size(97, 20)
        Me.Acceptar.TabIndex = 22
        Me.Acceptar.Text = "Acceptar"
        Me.Acceptar.UseVisualStyleBackColor = True
        Me.Acceptar.Visible = False
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(238, 164)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(97, 20)
        Me.Cancelar.TabIndex = 23
        Me.Cancelar.Text = "Cancel·lar"
        Me.Cancelar.UseVisualStyleBackColor = True
        Me.Cancelar.Visible = False
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 261)
        Me.Controls.Add(Me.ModificarEstoc)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Acceptar)
        Me.Controls.Add(Me.Seguent)
        Me.Controls.Add(Me.Ultim)
        Me.Controls.Add(Me.Anterior)
        Me.Controls.Add(Me.Primer)
        Me.Controls.Add(Me.Crear)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form"
        Me.ShowIcon = False
        Me.Text = "Examen - Pablo González Rubio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PreuAmbIVA As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Comentaris As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents EstocActual As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CodiFamilia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Preu As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DescripcioArticle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CodiArticle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Modificar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Crear As Button
    Friend WithEvents ModificarEstoc As Button
    Friend WithEvents Primer As Button
    Friend WithEvents Anterior As Button
    Friend WithEvents Ultim As Button
    Friend WithEvents Seguent As Button
    Friend WithEvents Acceptar As Button
    Friend WithEvents Cancelar As Button
End Class
