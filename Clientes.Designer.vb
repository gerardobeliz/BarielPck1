<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim DniLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim Cod_posLabel As System.Windows.Forms.Label
        Dim DireLabel As System.Windows.Forms.Label
        Dim TelLabel As System.Windows.Forms.Label
        Dim ApeLabel As System.Windows.Forms.Label
        Dim NomLabel As System.Windows.Forms.Label
        Dim NomLabel1 As System.Windows.Forms.Label
        Dim DniLabel1 As System.Windows.Forms.Label
        Dim DniLabel2 As System.Windows.Forms.Label
        Dim NomLabel2 As System.Windows.Forms.Label
        Me.DbBarelPackDataSet = New BarelPck1.dbBarelPackDataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New BarelPck1.dbBarelPackDataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New BarelPck1.dbBarelPackDataSetTableAdapters.TableAdapterManager()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DniTextBox = New System.Windows.Forms.TextBox()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_posNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.DireTextBox = New System.Windows.Forms.TextBox()
        Me.TelTextBox = New System.Windows.Forms.TextBox()
        Me.ApeTextBox = New System.Windows.Forms.TextBox()
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DniTextBox1 = New System.Windows.Forms.TextBox()
        Me.NomTextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ClienteDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomTextBox2 = New System.Windows.Forms.TextBox()
        Me.DniTextBox2 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionesEspecialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        DniLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        Cod_posLabel = New System.Windows.Forms.Label()
        DireLabel = New System.Windows.Forms.Label()
        TelLabel = New System.Windows.Forms.Label()
        ApeLabel = New System.Windows.Forms.Label()
        NomLabel = New System.Windows.Forms.Label()
        NomLabel1 = New System.Windows.Forms.Label()
        DniLabel1 = New System.Windows.Forms.Label()
        DniLabel2 = New System.Windows.Forms.Label()
        NomLabel2 = New System.Windows.Forms.Label()
        CType(Me.DbBarelPackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Cod_posNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.ClienteDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DniLabel
        '
        DniLabel.AutoSize = True
        DniLabel.Location = New System.Drawing.Point(25, 121)
        DniLabel.Name = "DniLabel"
        DniLabel.Size = New System.Drawing.Size(29, 13)
        DniLabel.TabIndex = 44
        DniLabel.Text = "DNI:"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(24, 251)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(45, 13)
        MailLabel.TabIndex = 42
        MailLabel.Text = "E-MAIL:"
        '
        'Cod_posLabel
        '
        Cod_posLabel.AutoSize = True
        Cod_posLabel.Location = New System.Drawing.Point(24, 225)
        Cod_posLabel.Name = "Cod_posLabel"
        Cod_posLabel.Size = New System.Drawing.Size(97, 13)
        Cod_posLabel.TabIndex = 40
        Cod_posLabel.Text = "CODIGO POSTAL:"
        '
        'DireLabel
        '
        DireLabel.AutoSize = True
        DireLabel.Location = New System.Drawing.Point(24, 193)
        DireLabel.Name = "DireLabel"
        DireLabel.Size = New System.Drawing.Size(69, 13)
        DireLabel.TabIndex = 38
        DireLabel.Text = "DIRECCION:"
        '
        'TelLabel
        '
        TelLabel.AutoSize = True
        TelLabel.Location = New System.Drawing.Point(24, 156)
        TelLabel.Name = "TelLabel"
        TelLabel.Size = New System.Drawing.Size(67, 13)
        TelLabel.TabIndex = 36
        TelLabel.Text = "TELEFONO:"
        '
        'ApeLabel
        '
        ApeLabel.AutoSize = True
        ApeLabel.Location = New System.Drawing.Point(25, 91)
        ApeLabel.Name = "ApeLabel"
        ApeLabel.Size = New System.Drawing.Size(62, 13)
        ApeLabel.TabIndex = 34
        ApeLabel.Text = "APELLIDO:"
        '
        'NomLabel
        '
        NomLabel.AutoSize = True
        NomLabel.Location = New System.Drawing.Point(25, 56)
        NomLabel.Name = "NomLabel"
        NomLabel.Size = New System.Drawing.Size(57, 13)
        NomLabel.TabIndex = 32
        NomLabel.Text = "NOMBRE:"
        '
        'NomLabel1
        '
        NomLabel1.AutoSize = True
        NomLabel1.Location = New System.Drawing.Point(43, 59)
        NomLabel1.Name = "NomLabel1"
        NomLabel1.Size = New System.Drawing.Size(57, 13)
        NomLabel1.TabIndex = 0
        NomLabel1.Text = "NOMBRE:"
        '
        'DniLabel1
        '
        DniLabel1.AutoSize = True
        DniLabel1.Location = New System.Drawing.Point(71, 95)
        DniLabel1.Name = "DniLabel1"
        DniLabel1.Size = New System.Drawing.Size(29, 13)
        DniLabel1.TabIndex = 2
        DniLabel1.Text = "DNI:"
        '
        'DniLabel2
        '
        DniLabel2.AutoSize = True
        DniLabel2.Location = New System.Drawing.Point(38, 43)
        DniLabel2.Name = "DniLabel2"
        DniLabel2.Size = New System.Drawing.Size(24, 13)
        DniLabel2.TabIndex = 0
        DniLabel2.Text = "dni:"
        '
        'NomLabel2
        '
        NomLabel2.AutoSize = True
        NomLabel2.Location = New System.Drawing.Point(40, 93)
        NomLabel2.Name = "NomLabel2"
        NomLabel2.Size = New System.Drawing.Size(30, 13)
        NomLabel2.TabIndex = 2
        NomLabel2.Text = "nom:"
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(556, 397)
        Me.TabControl1.TabIndex = 29
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ButtonGuardar)
        Me.TabPage1.Controls.Add(DniLabel)
        Me.TabPage1.Controls.Add(Me.DniTextBox)
        Me.TabPage1.Controls.Add(MailLabel)
        Me.TabPage1.Controls.Add(Me.MailTextBox)
        Me.TabPage1.Controls.Add(Cod_posLabel)
        Me.TabPage1.Controls.Add(Me.Cod_posNumericUpDown)
        Me.TabPage1.Controls.Add(DireLabel)
        Me.TabPage1.Controls.Add(Me.DireTextBox)
        Me.TabPage1.Controls.Add(TelLabel)
        Me.TabPage1.Controls.Add(Me.TelTextBox)
        Me.TabPage1.Controls.Add(ApeLabel)
        Me.TabPage1.Controls.Add(Me.ApeTextBox)
        Me.TabPage1.Controls.Add(NomLabel)
        Me.TabPage1.Controls.Add(Me.NomTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(548, 371)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "NUEVO CLIENTE"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DniTextBox
        '
        Me.DniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "dni", True))
        Me.DniTextBox.Location = New System.Drawing.Point(128, 118)
        Me.DniTextBox.Name = "DniTextBox"
        Me.DniTextBox.Size = New System.Drawing.Size(169, 20)
        Me.DniTextBox.TabIndex = 45
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(127, 251)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(171, 20)
        Me.MailTextBox.TabIndex = 43
        '
        'Cod_posNumericUpDown
        '
        Me.Cod_posNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClienteBindingSource, "cod_pos", True))
        Me.Cod_posNumericUpDown.Location = New System.Drawing.Point(127, 218)
        Me.Cod_posNumericUpDown.Name = "Cod_posNumericUpDown"
        Me.Cod_posNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.Cod_posNumericUpDown.TabIndex = 41
        '
        'DireTextBox
        '
        Me.DireTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "dire", True))
        Me.DireTextBox.Location = New System.Drawing.Point(127, 186)
        Me.DireTextBox.Name = "DireTextBox"
        Me.DireTextBox.Size = New System.Drawing.Size(171, 20)
        Me.DireTextBox.TabIndex = 39
        '
        'TelTextBox
        '
        Me.TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "tel", True))
        Me.TelTextBox.Location = New System.Drawing.Point(127, 153)
        Me.TelTextBox.Name = "TelTextBox"
        Me.TelTextBox.Size = New System.Drawing.Size(170, 20)
        Me.TelTextBox.TabIndex = 37
        '
        'ApeTextBox
        '
        Me.ApeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ape", True))
        Me.ApeTextBox.Location = New System.Drawing.Point(128, 84)
        Me.ApeTextBox.Name = "ApeTextBox"
        Me.ApeTextBox.Size = New System.Drawing.Size(169, 20)
        Me.ApeTextBox.TabIndex = 35
        '
        'NomTextBox
        '
        Me.NomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nom", True))
        Me.NomTextBox.Location = New System.Drawing.Point(128, 49)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(170, 20)
        Me.NomTextBox.TabIndex = 33
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.ButtonEditar)
        Me.TabPage2.Controls.Add(Me.ButtonBuscar)
        Me.TabPage2.Controls.Add(Me.ClienteDataGridView)
        Me.TabPage2.Controls.Add(DniLabel1)
        Me.TabPage2.Controls.Add(Me.DniTextBox1)
        Me.TabPage2.Controls.Add(NomLabel1)
        Me.TabPage2.Controls.Add(Me.NomTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(548, 371)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BUSCAR CLIENTE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(26, 133)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(466, 167)
        Me.ClienteDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nom"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nom"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ape"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ape"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "tel"
        Me.DataGridViewTextBoxColumn4.HeaderText = "tel"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "dire"
        Me.DataGridViewTextBoxColumn5.HeaderText = "dire"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cod_pos"
        Me.DataGridViewTextBoxColumn6.HeaderText = "cod_pos"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "mail"
        Me.DataGridViewTextBoxColumn7.HeaderText = "mail"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "dni"
        Me.DataGridViewTextBoxColumn8.HeaderText = "dni"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DniTextBox1
        '
        Me.DniTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "dni", True))
        Me.DniTextBox1.Location = New System.Drawing.Point(115, 88)
        Me.DniTextBox1.Name = "DniTextBox1"
        Me.DniTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.DniTextBox1.TabIndex = 3
        '
        'NomTextBox1
        '
        Me.NomTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nom", True))
        Me.NomTextBox1.Location = New System.Drawing.Point(115, 52)
        Me.NomTextBox1.Name = "NomTextBox1"
        Me.NomTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.NomTextBox1.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.ButtonEliminar)
        Me.TabPage3.Controls.Add(Me.ClienteDataGridView1)
        Me.TabPage3.Controls.Add(NomLabel2)
        Me.TabPage3.Controls.Add(Me.NomTextBox2)
        Me.TabPage3.Controls.Add(DniLabel2)
        Me.TabPage3.Controls.Add(Me.DniTextBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(548, 371)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ELIMINAR CLIENTE"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ClienteDataGridView1
        '
        Me.ClienteDataGridView1.AutoGenerateColumns = False
        Me.ClienteDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.ClienteDataGridView1.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView1.Location = New System.Drawing.Point(6, 125)
        Me.ClienteDataGridView1.Name = "ClienteDataGridView1"
        Me.ClienteDataGridView1.Size = New System.Drawing.Size(534, 240)
        Me.ClienteDataGridView1.TabIndex = 4
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn9.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "nom"
        Me.DataGridViewTextBoxColumn10.HeaderText = "nom"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ape"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ape"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "tel"
        Me.DataGridViewTextBoxColumn12.HeaderText = "tel"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "dire"
        Me.DataGridViewTextBoxColumn13.HeaderText = "dire"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "cod_pos"
        Me.DataGridViewTextBoxColumn14.HeaderText = "cod_pos"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "mail"
        Me.DataGridViewTextBoxColumn15.HeaderText = "mail"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "dni"
        Me.DataGridViewTextBoxColumn16.HeaderText = "dni"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'NomTextBox2
        '
        Me.NomTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nom", True))
        Me.NomTextBox2.Location = New System.Drawing.Point(76, 86)
        Me.NomTextBox2.Name = "NomTextBox2"
        Me.NomTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.NomTextBox2.TabIndex = 3
        '
        'DniTextBox2
        '
        Me.DniTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "dni", True))
        Me.DniTextBox2.Location = New System.Drawing.Point(76, 36)
        Me.DniTextBox2.Name = "DniTextBox2"
        Me.DniTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.DniTextBox2.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VentaToolStripMenuItem, Me.ConfiguracionesEspecialesToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(82, 15, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(568, 36)
        Me.MenuStrip1.TabIndex = 30
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
        'ButtonGuardar
        '
        Me.ButtonGuardar.BackgroundImage = Global.BarelPck1.My.Resources.Resources.png_transparent_save_icon_button_symbol_thumbnail
        Me.ButtonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonGuardar.FlatAppearance.BorderSize = 0
        Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardar.Location = New System.Drawing.Point(383, 251)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(120, 83)
        Me.ButtonGuardar.TabIndex = 48
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'ButtonEditar
        '
        Me.ButtonEditar.BackgroundImage = Global.BarelPck1.My.Resources.Resources.png_clipart_computer_icons_floppy_disk_save_button_miscellaneous_blue
        Me.ButtonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonEditar.FlatAppearance.BorderSize = 0
        Me.ButtonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditar.Location = New System.Drawing.Point(397, 44)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(95, 64)
        Me.ButtonEditar.TabIndex = 6
        Me.ButtonEditar.UseVisualStyleBackColor = True
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackgroundImage = Global.BarelPck1.My.Resources.Resources.klipartz2
        Me.ButtonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonBuscar.FlatAppearance.BorderSize = 0
        Me.ButtonBuscar.Location = New System.Drawing.Point(250, 44)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(115, 64)
        Me.ButtonBuscar.TabIndex = 5
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackgroundImage = Global.BarelPck1.My.Resources.Resources.eliminar_icono_boton_forma_cuadrada_redonda_300191_523
        Me.ButtonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonEliminar.FlatAppearance.BorderSize = 0
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminar.Location = New System.Drawing.Point(271, 36)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(136, 70)
        Me.ButtonEliminar.TabIndex = 5
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 443)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.DbBarelPackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Cod_posNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.ClienteDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbBarelPackDataSet As BarelPck1.dbBarelPackDataSet
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As BarelPck1.dbBarelPackDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As BarelPck1.dbBarelPackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonGuardar As System.Windows.Forms.Button
    Friend WithEvents DniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cod_posNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents DireTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionesEspecialesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents ClienteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DniTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NomTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ClienteDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DniTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonEliminar As System.Windows.Forms.Button
    Friend WithEvents ButtonEditar As System.Windows.Forms.Button
End Class
