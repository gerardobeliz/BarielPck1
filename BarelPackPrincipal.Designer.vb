﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarelPackPrincipal
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
        Me.DbBarelPackDataSet = New BarelPck1.dbBarelPackDataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New BarelPck1.dbBarelPackDataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New BarelPck1.dbBarelPackDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionesEspecialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DbBarelPackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VentaToolStripMenuItem, Me.IformesToolStripMenuItem, Me.ConfiguracionesEspecialesToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(82, 15, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 36)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 19)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.NuevoToolStripMenuItem.Text = "Cliente"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.BuscarToolStripMenuItem.Text = "Proveedor"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NToolStripMenuItem, Me.BuscarToolStripMenuItem1, Me.EliminarToolStripMenuItem1})
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.EliminarToolStripMenuItem.Text = "Producto"
        '
        'NToolStripMenuItem
        '
        Me.NToolStripMenuItem.Name = "NToolStripMenuItem"
        Me.NToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NToolStripMenuItem.Text = "Nuevo"
        '
        'BuscarToolStripMenuItem1
        '
        Me.BuscarToolStripMenuItem1.Name = "BuscarToolStripMenuItem1"
        Me.BuscarToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.BuscarToolStripMenuItem1.Text = "Modificar"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(48, 19)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'IformesToolStripMenuItem
        '
        Me.IformesToolStripMenuItem.Name = "IformesToolStripMenuItem"
        Me.IformesToolStripMenuItem.Size = New System.Drawing.Size(66, 19)
        Me.IformesToolStripMenuItem.Text = "Informes"
        '
        'ConfiguracionesEspecialesToolStripMenuItem
        '
        Me.ConfiguracionesEspecialesToolStripMenuItem.Name = "ConfiguracionesEspecialesToolStripMenuItem"
        Me.ConfiguracionesEspecialesToolStripMenuItem.Size = New System.Drawing.Size(160, 19)
        Me.ConfiguracionesEspecialesToolStripMenuItem.Text = "configuraciones Especiales"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(51, 19)
        Me.AyudaToolStripMenuItem.Text = "ayuda"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 19)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BarelPck1.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(21, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'BarelPackPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BarelPck1.My.Resources.Resources._1000_F_896925343_QkE7HXMMNpIFkdTmE5SmZZeUXLIOhGKd
        Me.ClientSize = New System.Drawing.Size(584, 378)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "BarelPackPrincipal"
        Me.Text = "Barielpack"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.DbBarelPackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbBarelPackDataSet As BarelPck1.dbBarelPackDataSet
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As BarelPck1.dbBarelPackDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As BarelPck1.dbBarelPackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionesEspecialesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
