﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class producto
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim CostoLabel As System.Windows.Forms.Label
        Dim Precio_ventaLabel As System.Windows.Forms.Label
        Dim Cant_minLabel As System.Windows.Forms.Label
        Dim Cod_articuloLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DbBarelPackDataSet = New BarelPck1.dbBarelPackDataSet()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter = New BarelPck1.dbBarelPackDataSetTableAdapters.stockTableAdapter()
        Me.TableAdapterManager = New BarelPck1.dbBarelPackDataSetTableAdapters.TableAdapterManager()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.CostoTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_ventaTextBox = New System.Windows.Forms.TextBox()
        Me.Cant_minTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_articuloTextBox = New System.Windows.Forms.TextBox()
        Me.Button_Guardar_Producto = New System.Windows.Forms.Button()
        DescripcionLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        CostoLabel = New System.Windows.Forms.Label()
        Precio_ventaLabel = New System.Windows.Forms.Label()
        Cant_minLabel = New System.Windows.Forms.Label()
        Cod_articuloLabel = New System.Windows.Forms.Label()
        CType(Me.DbBarelPackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(22, 134)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(64, 13)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "descripcion:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(23, 98)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(51, 13)
        CantidadLabel.TabIndex = 5
        CantidadLabel.Text = "cantidad:"
        '
        'CostoLabel
        '
        CostoLabel.AutoSize = True
        CostoLabel.Location = New System.Drawing.Point(23, 164)
        CostoLabel.Name = "CostoLabel"
        CostoLabel.Size = New System.Drawing.Size(36, 13)
        CostoLabel.TabIndex = 7
        CostoLabel.Text = "costo:"
        '
        'Precio_ventaLabel
        '
        Precio_ventaLabel.AutoSize = True
        Precio_ventaLabel.Location = New System.Drawing.Point(23, 198)
        Precio_ventaLabel.Name = "Precio_ventaLabel"
        Precio_ventaLabel.Size = New System.Drawing.Size(69, 13)
        Precio_ventaLabel.TabIndex = 9
        Precio_ventaLabel.Text = "precio venta:"
        '
        'Cant_minLabel
        '
        Cant_minLabel.AutoSize = True
        Cant_minLabel.Location = New System.Drawing.Point(23, 234)
        Cant_minLabel.Name = "Cant_minLabel"
        Cant_minLabel.Size = New System.Drawing.Size(50, 13)
        Cant_minLabel.TabIndex = 11
        Cant_minLabel.Text = "cant min:"
        '
        'Cod_articuloLabel
        '
        Cod_articuloLabel.AutoSize = True
        Cod_articuloLabel.Location = New System.Drawing.Point(21, 67)
        Cod_articuloLabel.Name = "Cod_articuloLabel"
        Cod_articuloLabel.Size = New System.Drawing.Size(65, 13)
        Cod_articuloLabel.TabIndex = 13
        Cod_articuloLabel.Text = "cod articulo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NUEVO PROUCTO"
        '
        'DbBarelPackDataSet
        '
        Me.DbBarelPackDataSet.DataSetName = "dbBarelPackDataSet"
        Me.DbBarelPackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me.DbBarelPackDataSet
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.localidadTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.stockMPrimaTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Me.StockTableAdapter
        Me.TableAdapterManager.UpdateOrder = BarelPck1.dbBarelPackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(98, 131)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(254, 20)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(98, 95)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(254, 20)
        Me.CantidadTextBox.TabIndex = 6
        '
        'CostoTextBox
        '
        Me.CostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "costo", True))
        Me.CostoTextBox.Location = New System.Drawing.Point(98, 161)
        Me.CostoTextBox.Name = "CostoTextBox"
        Me.CostoTextBox.Size = New System.Drawing.Size(254, 20)
        Me.CostoTextBox.TabIndex = 8
        '
        'Precio_ventaTextBox
        '
        Me.Precio_ventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "precio_venta", True))
        Me.Precio_ventaTextBox.Location = New System.Drawing.Point(98, 195)
        Me.Precio_ventaTextBox.Name = "Precio_ventaTextBox"
        Me.Precio_ventaTextBox.Size = New System.Drawing.Size(254, 20)
        Me.Precio_ventaTextBox.TabIndex = 10
        '
        'Cant_minTextBox
        '
        Me.Cant_minTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "cant_min", True))
        Me.Cant_minTextBox.Location = New System.Drawing.Point(98, 231)
        Me.Cant_minTextBox.Name = "Cant_minTextBox"
        Me.Cant_minTextBox.Size = New System.Drawing.Size(254, 20)
        Me.Cant_minTextBox.TabIndex = 12
        '
        'Cod_articuloTextBox
        '
        Me.Cod_articuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "cod_articulo", True))
        Me.Cod_articuloTextBox.Location = New System.Drawing.Point(96, 64)
        Me.Cod_articuloTextBox.Name = "Cod_articuloTextBox"
        Me.Cod_articuloTextBox.Size = New System.Drawing.Size(254, 20)
        Me.Cod_articuloTextBox.TabIndex = 14
        '
        'Button_Guardar_Producto
        '
        Me.Button_Guardar_Producto.Location = New System.Drawing.Point(422, 223)
        Me.Button_Guardar_Producto.Name = "Button_Guardar_Producto"
        Me.Button_Guardar_Producto.Size = New System.Drawing.Size(93, 44)
        Me.Button_Guardar_Producto.TabIndex = 15
        Me.Button_Guardar_Producto.Text = "GUARDAR "
        Me.Button_Guardar_Producto.UseVisualStyleBackColor = True
        '
        'producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 320)
        Me.Controls.Add(Me.Button_Guardar_Producto)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(CostoLabel)
        Me.Controls.Add(Me.CostoTextBox)
        Me.Controls.Add(Precio_ventaLabel)
        Me.Controls.Add(Me.Precio_ventaTextBox)
        Me.Controls.Add(Cant_minLabel)
        Me.Controls.Add(Me.Cant_minTextBox)
        Me.Controls.Add(Cod_articuloLabel)
        Me.Controls.Add(Me.Cod_articuloTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "producto"
        Me.Text = "producto"
        CType(Me.DbBarelPackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DbBarelPackDataSet As BarelPck1.dbBarelPackDataSet
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter As BarelPck1.dbBarelPackDataSetTableAdapters.stockTableAdapter
    Friend WithEvents TableAdapterManager As BarelPck1.dbBarelPackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Precio_ventaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cant_minTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cod_articuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button_Guardar_Producto As System.Windows.Forms.Button
End Class
