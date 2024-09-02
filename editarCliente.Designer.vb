<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editarCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NomLabel As System.Windows.Forms.Label
        Dim ApeLabel As System.Windows.Forms.Label
        Dim TelLabel As System.Windows.Forms.Label
        Dim DireLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim DniLabel As System.Windows.Forms.Label
        Dim Cod_posLabel1 As System.Windows.Forms.Label
        Me.DbBarelPackDataSet = New BarelPck1.dbBarelPackDataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New BarelPck1.dbBarelPackDataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New BarelPck1.dbBarelPackDataSetTableAdapters.TableAdapterManager()
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.ApeTextBox = New System.Windows.Forms.TextBox()
        Me.TelTextBox = New System.Windows.Forms.TextBox()
        Me.DireTextBox = New System.Windows.Forms.TextBox()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.DniTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_posTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Buttonvolver = New System.Windows.Forms.Button()
        Me.Buttonactualizar = New System.Windows.Forms.Button()
        NomLabel = New System.Windows.Forms.Label()
        ApeLabel = New System.Windows.Forms.Label()
        TelLabel = New System.Windows.Forms.Label()
        DireLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        DniLabel = New System.Windows.Forms.Label()
        Cod_posLabel1 = New System.Windows.Forms.Label()
        CType(Me.DbBarelPackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomLabel
        '
        NomLabel.AutoSize = True
        NomLabel.Location = New System.Drawing.Point(67, 76)
        NomLabel.Name = "NomLabel"
        NomLabel.Size = New System.Drawing.Size(30, 13)
        NomLabel.TabIndex = 1
        NomLabel.Text = "nom:"
        '
        'ApeLabel
        '
        ApeLabel.AutoSize = True
        ApeLabel.Location = New System.Drawing.Point(69, 109)
        ApeLabel.Name = "ApeLabel"
        ApeLabel.Size = New System.Drawing.Size(28, 13)
        ApeLabel.TabIndex = 3
        ApeLabel.Text = "ape:"
        '
        'TelLabel
        '
        TelLabel.AutoSize = True
        TelLabel.Location = New System.Drawing.Point(79, 141)
        TelLabel.Name = "TelLabel"
        TelLabel.Size = New System.Drawing.Size(21, 13)
        TelLabel.TabIndex = 5
        TelLabel.Text = "tel:"
        '
        'DireLabel
        '
        DireLabel.AutoSize = True
        DireLabel.Location = New System.Drawing.Point(70, 182)
        DireLabel.Name = "DireLabel"
        DireLabel.Size = New System.Drawing.Size(27, 13)
        DireLabel.TabIndex = 7
        DireLabel.Text = "dire:"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(69, 244)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(28, 13)
        MailLabel.TabIndex = 11
        MailLabel.Text = "mail:"
        '
        'DniLabel
        '
        DniLabel.AutoSize = True
        DniLabel.Location = New System.Drawing.Point(73, 281)
        DniLabel.Name = "DniLabel"
        DniLabel.Size = New System.Drawing.Size(24, 13)
        DniLabel.TabIndex = 13
        DniLabel.Text = "dni:"
        '
        'Cod_posLabel1
        '
        Cod_posLabel1.AutoSize = True
        Cod_posLabel1.Location = New System.Drawing.Point(49, 208)
        Cod_posLabel1.Name = "Cod_posLabel1"
        Cod_posLabel1.Size = New System.Drawing.Size(48, 13)
        Cod_posLabel1.TabIndex = 15
        Cod_posLabel1.Text = "cod pos:"
        '
        'DbBarelPackDataSet
        '
        Me.DbBarelPackDataSet.DataSetName = "dbBarelPackDataSet"
        Me.DbBarelPackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.DbBarelPackDataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.localidadTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.stockMPrimaTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BarelPck1.dbBarelPackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'NomTextBox
        '
        Me.NomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nom", True))
        Me.NomTextBox.Location = New System.Drawing.Point(103, 73)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(138, 20)
        Me.NomTextBox.TabIndex = 2
        '
        'ApeTextBox
        '
        Me.ApeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ape", True))
        Me.ApeTextBox.Location = New System.Drawing.Point(103, 106)
        Me.ApeTextBox.Name = "ApeTextBox"
        Me.ApeTextBox.Size = New System.Drawing.Size(138, 20)
        Me.ApeTextBox.TabIndex = 4
        '
        'TelTextBox
        '
        Me.TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "tel", True))
        Me.TelTextBox.Location = New System.Drawing.Point(103, 138)
        Me.TelTextBox.Name = "TelTextBox"
        Me.TelTextBox.Size = New System.Drawing.Size(138, 20)
        Me.TelTextBox.TabIndex = 6
        '
        'DireTextBox
        '
        Me.DireTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "dire", True))
        Me.DireTextBox.Location = New System.Drawing.Point(103, 175)
        Me.DireTextBox.Name = "DireTextBox"
        Me.DireTextBox.Size = New System.Drawing.Size(138, 20)
        Me.DireTextBox.TabIndex = 8
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(103, 241)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(138, 20)
        Me.MailTextBox.TabIndex = 12
        '
        'DniTextBox
        '
        Me.DniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "dni", True))
        Me.DniTextBox.Location = New System.Drawing.Point(103, 278)
        Me.DniTextBox.Name = "DniTextBox"
        Me.DniTextBox.Size = New System.Drawing.Size(138, 20)
        Me.DniTextBox.TabIndex = 14
        '
        'Cod_posTextBox
        '
        Me.Cod_posTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "cod_pos", True))
        Me.Cod_posTextBox.Location = New System.Drawing.Point(103, 201)
        Me.Cod_posTextBox.Name = "Cod_posTextBox"
        Me.Cod_posTextBox.Size = New System.Drawing.Size(138, 20)
        Me.Cod_posTextBox.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "EDITAR CLIENTE :"
        '
        'Buttonvolver
        '
        Me.Buttonvolver.BackgroundImage = Global.BarelPck1.My.Resources.Resources.atras
        Me.Buttonvolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Buttonvolver.FlatAppearance.BorderSize = 0
        Me.Buttonvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonvolver.Location = New System.Drawing.Point(394, 238)
        Me.Buttonvolver.Name = "Buttonvolver"
        Me.Buttonvolver.Size = New System.Drawing.Size(75, 50)
        Me.Buttonvolver.TabIndex = 19
        Me.Buttonvolver.UseVisualStyleBackColor = True
        '
        'Buttonactualizar
        '
        Me.Buttonactualizar.BackgroundImage = Global.BarelPck1.My.Resources.Resources.png_transparent_save_icon_button_symbol_thumbnail
        Me.Buttonactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Buttonactualizar.FlatAppearance.BorderSize = 0
        Me.Buttonactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonactualizar.Location = New System.Drawing.Point(257, 229)
        Me.Buttonactualizar.Name = "Buttonactualizar"
        Me.Buttonactualizar.Size = New System.Drawing.Size(91, 69)
        Me.Buttonactualizar.TabIndex = 18
        Me.Buttonactualizar.UseVisualStyleBackColor = True
        '
        'editarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 349)
        Me.Controls.Add(Me.Buttonvolver)
        Me.Controls.Add(Me.Buttonactualizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Cod_posLabel1)
        Me.Controls.Add(Me.Cod_posTextBox)
        Me.Controls.Add(DniLabel)
        Me.Controls.Add(Me.DniTextBox)
        Me.Controls.Add(MailLabel)
        Me.Controls.Add(Me.MailTextBox)
        Me.Controls.Add(DireLabel)
        Me.Controls.Add(Me.DireTextBox)
        Me.Controls.Add(TelLabel)
        Me.Controls.Add(Me.TelTextBox)
        Me.Controls.Add(ApeLabel)
        Me.Controls.Add(Me.ApeTextBox)
        Me.Controls.Add(NomLabel)
        Me.Controls.Add(Me.NomTextBox)
        Me.Name = "editarCliente"
        Me.Text = "editarCliente"
        CType(Me.DbBarelPackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbBarelPackDataSet As BarelPck1.dbBarelPackDataSet
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As BarelPck1.dbBarelPackDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As BarelPck1.dbBarelPackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cod_posTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Buttonactualizar As System.Windows.Forms.Button
    Friend WithEvents Buttonvolver As System.Windows.Forms.Button
End Class
