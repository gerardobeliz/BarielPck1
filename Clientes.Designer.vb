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
        Dim NomLabel1 As System.Windows.Forms.Label
        Dim DniLabel1 As System.Windows.Forms.Label
        Dim DniLabel3 As System.Windows.Forms.Label
        Dim MailLabel1 As System.Windows.Forms.Label
        Dim Cod_posLabel1 As System.Windows.Forms.Label
        Dim DireLabel1 As System.Windows.Forms.Label
        Dim TelLabel1 As System.Windows.Forms.Label
        Dim ApeLabel1 As System.Windows.Forms.Label
        Dim NomLabel3 As System.Windows.Forms.Label
        Dim Id_clienteLabel As System.Windows.Forms.Label
        Dim NomLabel As System.Windows.Forms.Label
        Dim ApeLabel As System.Windows.Forms.Label
        Dim TelLabel As System.Windows.Forms.Label
        Dim DireLabel As System.Windows.Forms.Label
        Dim Cod_posLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim DniLabel As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Id_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.NomTextBox3 = New System.Windows.Forms.TextBox()
        Me.ApeTextBox1 = New System.Windows.Forms.TextBox()
        Me.TelTextBox1 = New System.Windows.Forms.TextBox()
        Me.DireTextBox1 = New System.Windows.Forms.TextBox()
        Me.Cod_posTextBox1 = New System.Windows.Forms.TextBox()
        Me.MailTextBox1 = New System.Windows.Forms.TextBox()
        Me.DniTextBox3 = New System.Windows.Forms.TextBox()
        Me.DniTextBox1 = New System.Windows.Forms.TextBox()
        Me.NomTextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Cod_posTextBox = New System.Windows.Forms.TextBox()
        Me.DniTextBox = New System.Windows.Forms.TextBox()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.DireTextBox = New System.Windows.Forms.TextBox()
        Me.TelTextBox = New System.Windows.Forms.TextBox()
        Me.ApeTextBox = New System.Windows.Forms.TextBox()
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBarelPackDataSet = New BarelPck1.dbBarelPackDataSet()
        Me.ClienteTableAdapter = New BarelPck1.dbBarelPackDataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New BarelPck1.dbBarelPackDataSetTableAdapters.TableAdapterManager()
        NomLabel1 = New System.Windows.Forms.Label()
        DniLabel1 = New System.Windows.Forms.Label()
        DniLabel3 = New System.Windows.Forms.Label()
        MailLabel1 = New System.Windows.Forms.Label()
        Cod_posLabel1 = New System.Windows.Forms.Label()
        DireLabel1 = New System.Windows.Forms.Label()
        TelLabel1 = New System.Windows.Forms.Label()
        ApeLabel1 = New System.Windows.Forms.Label()
        NomLabel3 = New System.Windows.Forms.Label()
        Id_clienteLabel = New System.Windows.Forms.Label()
        NomLabel = New System.Windows.Forms.Label()
        ApeLabel = New System.Windows.Forms.Label()
        TelLabel = New System.Windows.Forms.Label()
        DireLabel = New System.Windows.Forms.Label()
        Cod_posLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        DniLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBarelPackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        DniLabel1.Location = New System.Drawing.Point(43, 95)
        DniLabel1.Name = "DniLabel1"
        DniLabel1.Size = New System.Drawing.Size(29, 13)
        DniLabel1.TabIndex = 2
        DniLabel1.Text = "DNI:"
        '
        'DniLabel3
        '
        DniLabel3.AutoSize = True
        DniLabel3.Location = New System.Drawing.Point(310, 201)
        DniLabel3.Name = "DniLabel3"
        DniLabel3.Size = New System.Drawing.Size(24, 13)
        DniLabel3.TabIndex = 50
        DniLabel3.Text = "dni:"
        '
        'MailLabel1
        '
        MailLabel1.AutoSize = True
        MailLabel1.Location = New System.Drawing.Point(310, 175)
        MailLabel1.Name = "MailLabel1"
        MailLabel1.Size = New System.Drawing.Size(28, 13)
        MailLabel1.TabIndex = 48
        MailLabel1.Text = "mail:"
        '
        'Cod_posLabel1
        '
        Cod_posLabel1.AutoSize = True
        Cod_posLabel1.Location = New System.Drawing.Point(310, 149)
        Cod_posLabel1.Name = "Cod_posLabel1"
        Cod_posLabel1.Size = New System.Drawing.Size(48, 13)
        Cod_posLabel1.TabIndex = 46
        Cod_posLabel1.Text = "cod pos:"
        '
        'DireLabel1
        '
        DireLabel1.AutoSize = True
        DireLabel1.Location = New System.Drawing.Point(310, 123)
        DireLabel1.Name = "DireLabel1"
        DireLabel1.Size = New System.Drawing.Size(27, 13)
        DireLabel1.TabIndex = 44
        DireLabel1.Text = "dire:"
        '
        'TelLabel1
        '
        TelLabel1.AutoSize = True
        TelLabel1.Location = New System.Drawing.Point(310, 97)
        TelLabel1.Name = "TelLabel1"
        TelLabel1.Size = New System.Drawing.Size(21, 13)
        TelLabel1.TabIndex = 42
        TelLabel1.Text = "tel:"
        '
        'ApeLabel1
        '
        ApeLabel1.AutoSize = True
        ApeLabel1.Location = New System.Drawing.Point(310, 71)
        ApeLabel1.Name = "ApeLabel1"
        ApeLabel1.Size = New System.Drawing.Size(28, 13)
        ApeLabel1.TabIndex = 40
        ApeLabel1.Text = "ape:"
        '
        'NomLabel3
        '
        NomLabel3.AutoSize = True
        NomLabel3.Location = New System.Drawing.Point(310, 45)
        NomLabel3.Name = "NomLabel3"
        NomLabel3.Size = New System.Drawing.Size(30, 13)
        NomLabel3.TabIndex = 38
        NomLabel3.Text = "nom:"
        '
        'Id_clienteLabel
        '
        Id_clienteLabel.AutoSize = True
        Id_clienteLabel.Location = New System.Drawing.Point(310, 19)
        Id_clienteLabel.Name = "Id_clienteLabel"
        Id_clienteLabel.Size = New System.Drawing.Size(52, 13)
        Id_clienteLabel.TabIndex = 36
        Id_clienteLabel.Text = "id cliente:"
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
        'ApeLabel
        '
        ApeLabel.AutoSize = True
        ApeLabel.Location = New System.Drawing.Point(25, 91)
        ApeLabel.Name = "ApeLabel"
        ApeLabel.Size = New System.Drawing.Size(62, 13)
        ApeLabel.TabIndex = 34
        ApeLabel.Text = "APELLIDO:"
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
        'DireLabel
        '
        DireLabel.AutoSize = True
        DireLabel.Location = New System.Drawing.Point(24, 193)
        DireLabel.Name = "DireLabel"
        DireLabel.Size = New System.Drawing.Size(69, 13)
        DireLabel.TabIndex = 38
        DireLabel.Text = "DIRECCION:"
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
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(24, 251)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(45, 13)
        MailLabel.TabIndex = 42
        MailLabel.Text = "E-MAIL:"
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BarelPck1.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(30, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VentaToolStripMenuItem, Me.IformesToolStripMenuItem, Me.ConfiguracionesEspecialesToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(82, 15, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(568, 36)
        Me.MenuStrip1.TabIndex = 34
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
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Id_clienteLabel)
        Me.TabPage2.Controls.Add(Me.Id_clienteTextBox)
        Me.TabPage2.Controls.Add(Me.NomTextBox3)
        Me.TabPage2.Controls.Add(Me.ApeTextBox1)
        Me.TabPage2.Controls.Add(Me.TelTextBox1)
        Me.TabPage2.Controls.Add(Me.DireTextBox1)
        Me.TabPage2.Controls.Add(Me.Cod_posTextBox1)
        Me.TabPage2.Controls.Add(Me.MailTextBox1)
        Me.TabPage2.Controls.Add(Me.DniTextBox3)
        Me.TabPage2.Controls.Add(Me.DniTextBox1)
        Me.TabPage2.Controls.Add(Me.NomTextBox1)
        Me.TabPage2.Controls.Add(NomLabel3)
        Me.TabPage2.Controls.Add(ApeLabel1)
        Me.TabPage2.Controls.Add(TelLabel1)
        Me.TabPage2.Controls.Add(DireLabel1)
        Me.TabPage2.Controls.Add(Cod_posLabel1)
        Me.TabPage2.Controls.Add(MailLabel1)
        Me.TabPage2.Controls.Add(DniLabel3)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(DniLabel1)
        Me.TabPage2.Controls.Add(NomLabel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(548, 371)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BUSCAR/ELIMINAR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Id_clienteTextBox
        '
        Me.Id_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "id_cliente", True))
        Me.Id_clienteTextBox.Location = New System.Drawing.Point(368, 16)
        Me.Id_clienteTextBox.Name = "Id_clienteTextBox"
        Me.Id_clienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_clienteTextBox.TabIndex = 37
        '
        'NomTextBox3
        '
        Me.NomTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nom", True))
        Me.NomTextBox3.Location = New System.Drawing.Point(368, 42)
        Me.NomTextBox3.Name = "NomTextBox3"
        Me.NomTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.NomTextBox3.TabIndex = 39
        '
        'ApeTextBox1
        '
        Me.ApeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ape", True))
        Me.ApeTextBox1.Location = New System.Drawing.Point(368, 68)
        Me.ApeTextBox1.Name = "ApeTextBox1"
        Me.ApeTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.ApeTextBox1.TabIndex = 41
        '
        'TelTextBox1
        '
        Me.TelTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "tel", True))
        Me.TelTextBox1.Location = New System.Drawing.Point(368, 94)
        Me.TelTextBox1.Name = "TelTextBox1"
        Me.TelTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TelTextBox1.TabIndex = 43
        '
        'DireTextBox1
        '
        Me.DireTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "dire", True))
        Me.DireTextBox1.Location = New System.Drawing.Point(368, 120)
        Me.DireTextBox1.Name = "DireTextBox1"
        Me.DireTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.DireTextBox1.TabIndex = 45
        '
        'Cod_posTextBox1
        '
        Me.Cod_posTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "cod_pos", True))
        Me.Cod_posTextBox1.Location = New System.Drawing.Point(368, 146)
        Me.Cod_posTextBox1.Name = "Cod_posTextBox1"
        Me.Cod_posTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Cod_posTextBox1.TabIndex = 47
        '
        'MailTextBox1
        '
        Me.MailTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "mail", True))
        Me.MailTextBox1.Location = New System.Drawing.Point(368, 172)
        Me.MailTextBox1.Name = "MailTextBox1"
        Me.MailTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MailTextBox1.TabIndex = 49
        '
        'DniTextBox3
        '
        Me.DniTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "dni", True))
        Me.DniTextBox3.Location = New System.Drawing.Point(368, 198)
        Me.DniTextBox3.Name = "DniTextBox3"
        Me.DniTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.DniTextBox3.TabIndex = 51
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
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(426, 303)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 36)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "ELIMINAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(46, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 36)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "BUSCAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(323, 303)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 36)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "EDITAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Cod_posTextBox)
        Me.TabPage1.Controls.Add(Me.DniTextBox)
        Me.TabPage1.Controls.Add(Me.MailTextBox)
        Me.TabPage1.Controls.Add(Me.DireTextBox)
        Me.TabPage1.Controls.Add(Me.TelTextBox)
        Me.TabPage1.Controls.Add(Me.ApeTextBox)
        Me.TabPage1.Controls.Add(Me.NomTextBox)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(DniLabel)
        Me.TabPage1.Controls.Add(MailLabel)
        Me.TabPage1.Controls.Add(Cod_posLabel)
        Me.TabPage1.Controls.Add(DireLabel)
        Me.TabPage1.Controls.Add(TelLabel)
        Me.TabPage1.Controls.Add(ApeLabel)
        Me.TabPage1.Controls.Add(NomLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(548, 371)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "NUEVO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Cod_posTextBox
        '
        Me.Cod_posTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "cod_pos", True))
        Me.Cod_posTextBox.Location = New System.Drawing.Point(127, 222)
        Me.Cod_posTextBox.Name = "Cod_posTextBox"
        Me.Cod_posTextBox.Size = New System.Drawing.Size(83, 20)
        Me.Cod_posTextBox.TabIndex = 47
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(404, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "GUARDAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(556, 397)
        Me.TabControl1.TabIndex = 29
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.DbBarelPackDataSet
        '
        'DbBarelPackDataSet
        '
        Me.DbBarelPackDataSet.DataSetName = "dbBarelPackDataSet"
        Me.DbBarelPackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 443)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBarelPackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbBarelPackDataSet As BarelPck1.dbBarelPackDataSet
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As BarelPck1.dbBarelPackDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As BarelPck1.dbBarelPackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionesEspecialesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Id_clienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomTextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ApeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TelTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DireTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Cod_posTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MailTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DniTextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents DniTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NomTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Cod_posTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
