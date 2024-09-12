<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proveedores
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CuitLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim Cod_posLabel As System.Windows.Forms.Label
        Dim TelLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim Id_proveedorLabel As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim CuitLabel1 As System.Windows.Forms.Label
        Dim DireccionLabel1 As System.Windows.Forms.Label
        Dim Cod_posLabel1 As System.Windows.Forms.Label
        Dim TelLabel1 As System.Windows.Forms.Label
        Dim MailLabel1 As System.Windows.Forms.Label
        Dim NombreLabel2 As System.Windows.Forms.Label
        Dim CuitLabel2 As System.Windows.Forms.Label
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBarelPackDataSet = New BarelPck1.dbBarelPackDataSet()
        Me.ProveedorTableAdapter = New BarelPck1.dbBarelPackDataSetTableAdapters.proveedorTableAdapter()
        Me.TableAdapterManager = New BarelPck1.dbBarelPackDataSetTableAdapters.TableAdapterManager()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button_buscar_proveedor = New System.Windows.Forms.Button()
        Me.Button_ELIMINAR_PROVEDOR = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button_GUARDAR_PROVEDOR_NUEVO = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CuitTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_posTextBox = New System.Windows.Forms.TextBox()
        Me.TelTextBox = New System.Windows.Forms.TextBox()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.Id_proveedorTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.CuitTextBox1 = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox1 = New System.Windows.Forms.TextBox()
        Me.Cod_posTextBox1 = New System.Windows.Forms.TextBox()
        Me.TelTextBox1 = New System.Windows.Forms.TextBox()
        Me.MailTextBox1 = New System.Windows.Forms.TextBox()
        Me.NombreTextBox2 = New System.Windows.Forms.TextBox()
        Me.CuitTextBox2 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionesEspecialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        NombreLabel = New System.Windows.Forms.Label()
        CuitLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        Cod_posLabel = New System.Windows.Forms.Label()
        TelLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        Id_proveedorLabel = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        CuitLabel1 = New System.Windows.Forms.Label()
        DireccionLabel1 = New System.Windows.Forms.Label()
        Cod_posLabel1 = New System.Windows.Forms.Label()
        TelLabel1 = New System.Windows.Forms.Label()
        MailLabel1 = New System.Windows.Forms.Label()
        NombreLabel2 = New System.Windows.Forms.Label()
        CuitLabel2 = New System.Windows.Forms.Label()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBarelPackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.DbBarelPackDataSet
        '
        'DbBarelPackDataSet
        '
        Me.DbBarelPackDataSet.DataSetName = "dbBarelPackDataSet"
        Me.DbBarelPackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.localidadTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.stockMPrimaTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BarelPck1.dbBarelPackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(NombreLabel2)
        Me.TabPage3.Controls.Add(Me.NombreTextBox2)
        Me.TabPage3.Controls.Add(CuitLabel2)
        Me.TabPage3.Controls.Add(Me.CuitTextBox2)
        Me.TabPage3.Controls.Add(NombreLabel)
        Me.TabPage3.Controls.Add(Me.NombreTextBox)
        Me.TabPage3.Controls.Add(CuitLabel)
        Me.TabPage3.Controls.Add(Me.CuitTextBox)
        Me.TabPage3.Controls.Add(DireccionLabel)
        Me.TabPage3.Controls.Add(Me.DireccionTextBox)
        Me.TabPage3.Controls.Add(Cod_posLabel)
        Me.TabPage3.Controls.Add(Me.Cod_posTextBox)
        Me.TabPage3.Controls.Add(TelLabel)
        Me.TabPage3.Controls.Add(Me.TelTextBox)
        Me.TabPage3.Controls.Add(MailLabel)
        Me.TabPage3.Controls.Add(Me.MailTextBox)
        Me.TabPage3.Controls.Add(Id_proveedorLabel)
        Me.TabPage3.Controls.Add(Me.Id_proveedorTextBox)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Button_buscar_proveedor)
        Me.TabPage3.Controls.Add(Me.Button_ELIMINAR_PROVEDOR)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(567, 349)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "EDITAR/ELIMINAR"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(296, 277)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 38)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "EDITAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button_buscar_proveedor
        '
        Me.Button_buscar_proveedor.Location = New System.Drawing.Point(22, 153)
        Me.Button_buscar_proveedor.Name = "Button_buscar_proveedor"
        Me.Button_buscar_proveedor.Size = New System.Drawing.Size(92, 37)
        Me.Button_buscar_proveedor.TabIndex = 20
        Me.Button_buscar_proveedor.Text = "BUSCAR"
        Me.Button_buscar_proveedor.UseVisualStyleBackColor = True
        '
        'Button_ELIMINAR_PROVEDOR
        '
        Me.Button_ELIMINAR_PROVEDOR.Location = New System.Drawing.Point(431, 277)
        Me.Button_ELIMINAR_PROVEDOR.Name = "Button_ELIMINAR_PROVEDOR"
        Me.Button_ELIMINAR_PROVEDOR.Size = New System.Drawing.Size(86, 37)
        Me.Button_ELIMINAR_PROVEDOR.TabIndex = 0
        Me.Button_ELIMINAR_PROVEDOR.Text = "ELIMINAR"
        Me.Button_ELIMINAR_PROVEDOR.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(NombreLabel1)
        Me.TabPage1.Controls.Add(Me.NombreTextBox1)
        Me.TabPage1.Controls.Add(CuitLabel1)
        Me.TabPage1.Controls.Add(Me.CuitTextBox1)
        Me.TabPage1.Controls.Add(DireccionLabel1)
        Me.TabPage1.Controls.Add(Me.DireccionTextBox1)
        Me.TabPage1.Controls.Add(Cod_posLabel1)
        Me.TabPage1.Controls.Add(Me.Cod_posTextBox1)
        Me.TabPage1.Controls.Add(TelLabel1)
        Me.TabPage1.Controls.Add(Me.TelTextBox1)
        Me.TabPage1.Controls.Add(MailLabel1)
        Me.TabPage1.Controls.Add(Me.MailTextBox1)
        Me.TabPage1.Controls.Add(Me.Button_GUARDAR_PROVEDOR_NUEVO)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(567, 349)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "NUEVO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button_GUARDAR_PROVEDOR_NUEVO
        '
        Me.Button_GUARDAR_PROVEDOR_NUEVO.Location = New System.Drawing.Point(438, 248)
        Me.Button_GUARDAR_PROVEDOR_NUEVO.Name = "Button_GUARDAR_PROVEDOR_NUEVO"
        Me.Button_GUARDAR_PROVEDOR_NUEVO.Size = New System.Drawing.Size(92, 44)
        Me.Button_GUARDAR_PROVEDOR_NUEVO.TabIndex = 14
        Me.Button_GUARDAR_PROVEDOR_NUEVO.Text = "GUARDAR"
        Me.Button_GUARDAR_PROVEDOR_NUEVO.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(575, 375)
        Me.TabControl1.TabIndex = 32
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BarelPck1.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(21, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(342, 37)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 21
        NombreLabel.Text = "nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(417, 34)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 22
        '
        'CuitLabel
        '
        CuitLabel.AutoSize = True
        CuitLabel.Location = New System.Drawing.Point(342, 63)
        CuitLabel.Name = "CuitLabel"
        CuitLabel.Size = New System.Drawing.Size(27, 13)
        CuitLabel.TabIndex = 23
        CuitLabel.Text = "cuit:"
        '
        'CuitTextBox
        '
        Me.CuitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "cuit", True))
        Me.CuitTextBox.Location = New System.Drawing.Point(417, 60)
        Me.CuitTextBox.Name = "CuitTextBox"
        Me.CuitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CuitTextBox.TabIndex = 24
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(342, 89)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 25
        DireccionLabel.Text = "direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(417, 86)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 26
        '
        'Cod_posLabel
        '
        Cod_posLabel.AutoSize = True
        Cod_posLabel.Location = New System.Drawing.Point(342, 115)
        Cod_posLabel.Name = "Cod_posLabel"
        Cod_posLabel.Size = New System.Drawing.Size(48, 13)
        Cod_posLabel.TabIndex = 27
        Cod_posLabel.Text = "cod pos:"
        '
        'Cod_posTextBox
        '
        Me.Cod_posTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "cod_pos", True))
        Me.Cod_posTextBox.Location = New System.Drawing.Point(417, 112)
        Me.Cod_posTextBox.Name = "Cod_posTextBox"
        Me.Cod_posTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cod_posTextBox.TabIndex = 28
        '
        'TelLabel
        '
        TelLabel.AutoSize = True
        TelLabel.Location = New System.Drawing.Point(342, 141)
        TelLabel.Name = "TelLabel"
        TelLabel.Size = New System.Drawing.Size(21, 13)
        TelLabel.TabIndex = 29
        TelLabel.Text = "tel:"
        '
        'TelTextBox
        '
        Me.TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "tel", True))
        Me.TelTextBox.Location = New System.Drawing.Point(417, 138)
        Me.TelTextBox.Name = "TelTextBox"
        Me.TelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelTextBox.TabIndex = 30
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(342, 167)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(28, 13)
        MailLabel.TabIndex = 31
        MailLabel.Text = "mail:"
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(417, 164)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MailTextBox.TabIndex = 32
        '
        'Id_proveedorLabel
        '
        Id_proveedorLabel.AutoSize = True
        Id_proveedorLabel.Location = New System.Drawing.Point(342, 193)
        Id_proveedorLabel.Name = "Id_proveedorLabel"
        Id_proveedorLabel.Size = New System.Drawing.Size(69, 13)
        Id_proveedorLabel.TabIndex = 33
        Id_proveedorLabel.Text = "id proveedor:"
        '
        'Id_proveedorTextBox
        '
        Me.Id_proveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "id_proveedor", True))
        Me.Id_proveedorTextBox.Location = New System.Drawing.Point(417, 190)
        Me.Id_proveedorTextBox.Name = "Id_proveedorTextBox"
        Me.Id_proveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_proveedorTextBox.TabIndex = 34
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(36, 67)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(45, 13)
        NombreLabel1.TabIndex = 14
        NombreLabel1.Text = "nombre:"
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "nombre", True))
        Me.NombreTextBox1.Location = New System.Drawing.Point(111, 64)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.Size = New System.Drawing.Size(280, 20)
        Me.NombreTextBox1.TabIndex = 15
        '
        'CuitLabel1
        '
        CuitLabel1.AutoSize = True
        CuitLabel1.Location = New System.Drawing.Point(36, 93)
        CuitLabel1.Name = "CuitLabel1"
        CuitLabel1.Size = New System.Drawing.Size(27, 13)
        CuitLabel1.TabIndex = 16
        CuitLabel1.Text = "cuit:"
        '
        'CuitTextBox1
        '
        Me.CuitTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "cuit", True))
        Me.CuitTextBox1.Location = New System.Drawing.Point(111, 90)
        Me.CuitTextBox1.Name = "CuitTextBox1"
        Me.CuitTextBox1.Size = New System.Drawing.Size(280, 20)
        Me.CuitTextBox1.TabIndex = 17
        '
        'DireccionLabel1
        '
        DireccionLabel1.AutoSize = True
        DireccionLabel1.Location = New System.Drawing.Point(36, 119)
        DireccionLabel1.Name = "DireccionLabel1"
        DireccionLabel1.Size = New System.Drawing.Size(53, 13)
        DireccionLabel1.TabIndex = 18
        DireccionLabel1.Text = "direccion:"
        '
        'DireccionTextBox1
        '
        Me.DireccionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "direccion", True))
        Me.DireccionTextBox1.Location = New System.Drawing.Point(111, 116)
        Me.DireccionTextBox1.Name = "DireccionTextBox1"
        Me.DireccionTextBox1.Size = New System.Drawing.Size(280, 20)
        Me.DireccionTextBox1.TabIndex = 19
        '
        'Cod_posLabel1
        '
        Cod_posLabel1.AutoSize = True
        Cod_posLabel1.Location = New System.Drawing.Point(36, 145)
        Cod_posLabel1.Name = "Cod_posLabel1"
        Cod_posLabel1.Size = New System.Drawing.Size(48, 13)
        Cod_posLabel1.TabIndex = 20
        Cod_posLabel1.Text = "cod pos:"
        '
        'Cod_posTextBox1
        '
        Me.Cod_posTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "cod_pos", True))
        Me.Cod_posTextBox1.Location = New System.Drawing.Point(111, 142)
        Me.Cod_posTextBox1.Name = "Cod_posTextBox1"
        Me.Cod_posTextBox1.Size = New System.Drawing.Size(280, 20)
        Me.Cod_posTextBox1.TabIndex = 21
        '
        'TelLabel1
        '
        TelLabel1.AutoSize = True
        TelLabel1.Location = New System.Drawing.Point(36, 171)
        TelLabel1.Name = "TelLabel1"
        TelLabel1.Size = New System.Drawing.Size(21, 13)
        TelLabel1.TabIndex = 22
        TelLabel1.Text = "tel:"
        '
        'TelTextBox1
        '
        Me.TelTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "tel", True))
        Me.TelTextBox1.Location = New System.Drawing.Point(111, 168)
        Me.TelTextBox1.Name = "TelTextBox1"
        Me.TelTextBox1.Size = New System.Drawing.Size(280, 20)
        Me.TelTextBox1.TabIndex = 23
        '
        'MailLabel1
        '
        MailLabel1.AutoSize = True
        MailLabel1.Location = New System.Drawing.Point(36, 197)
        MailLabel1.Name = "MailLabel1"
        MailLabel1.Size = New System.Drawing.Size(28, 13)
        MailLabel1.TabIndex = 24
        MailLabel1.Text = "mail:"
        '
        'MailTextBox1
        '
        Me.MailTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "mail", True))
        Me.MailTextBox1.Location = New System.Drawing.Point(111, 194)
        Me.MailTextBox1.Name = "MailTextBox1"
        Me.MailTextBox1.Size = New System.Drawing.Size(280, 20)
        Me.MailTextBox1.TabIndex = 25
        '
        'NombreLabel2
        '
        NombreLabel2.AutoSize = True
        NombreLabel2.Location = New System.Drawing.Point(33, 41)
        NombreLabel2.Name = "NombreLabel2"
        NombreLabel2.Size = New System.Drawing.Size(45, 13)
        NombreLabel2.TabIndex = 34
        NombreLabel2.Text = "nombre:"
        '
        'NombreTextBox2
        '
        Me.NombreTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "nombre", True))
        Me.NombreTextBox2.Location = New System.Drawing.Point(84, 34)
        Me.NombreTextBox2.Name = "NombreTextBox2"
        Me.NombreTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox2.TabIndex = 35
        '
        'CuitLabel2
        '
        CuitLabel2.AutoSize = True
        CuitLabel2.Location = New System.Drawing.Point(33, 86)
        CuitLabel2.Name = "CuitLabel2"
        CuitLabel2.Size = New System.Drawing.Size(27, 13)
        CuitLabel2.TabIndex = 36
        CuitLabel2.Text = "cuit:"
        '
        'CuitTextBox2
        '
        Me.CuitTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "cuit", True))
        Me.CuitTextBox2.Location = New System.Drawing.Point(83, 79)
        Me.CuitTextBox2.Name = "CuitTextBox2"
        Me.CuitTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.CuitTextBox2.TabIndex = 37
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VentaToolStripMenuItem, Me.ConfiguracionesEspecialesToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(82, 15, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(576, 36)
        Me.MenuStrip1.TabIndex = 37
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
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.EliminarToolStripMenuItem.Text = "Producto"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(48, 19)
        Me.VentaToolStripMenuItem.Text = "Venta"
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
        'proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 425)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "proveedores"
        Me.Text = "proveedores"
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBarelPackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbBarelPackDataSet As BarelPck1.dbBarelPackDataSet
    Friend WithEvents ProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedorTableAdapter As BarelPck1.dbBarelPackDataSetTableAdapters.proveedorTableAdapter
    Friend WithEvents TableAdapterManager As BarelPck1.dbBarelPackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button_buscar_proveedor As System.Windows.Forms.Button
    Friend WithEvents Button_ELIMINAR_PROVEDOR As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button_GUARDAR_PROVEDOR_NUEVO As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CuitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cod_posTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_proveedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CuitTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Cod_posTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TelTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MailTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CuitTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionesEspecialesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
