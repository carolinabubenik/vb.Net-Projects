<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReglas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReglas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlColor = New System.Windows.Forms.Panel()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudOrden = New System.Windows.Forms.NumericUpDown()
        Me.cbxReglaAplica = New System.Windows.Forms.ComboBox()
        Me.gbxRelga = New System.Windows.Forms.GroupBox()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.rdbSi = New System.Windows.Forms.RadioButton()
        Me.lblDescripcionCampo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAgregarCondicion = New System.Windows.Forms.Button()
        Me.dgvCondicion = New System.Windows.Forms.DataGridView()
        Me.campo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsCondicion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarCondicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbxValor = New System.Windows.Forms.TextBox()
        Me.cbxOperador = New System.Windows.Forms.ComboBox()
        Me.cbxCampo = New System.Windows.Forms.ComboBox()
        Me.gbx1 = New System.Windows.Forms.GroupBox()
        Me.dgvRegla = New System.Windows.Forms.DataGridView()
        Me.colRegAmbito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRegColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRegOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRegNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsReglas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnDesactivarAplica = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.tsRegla = New System.Windows.Forms.ToolStrip()
        Me.btoNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btoModificar = New System.Windows.Forms.ToolStripButton()
        Me.btoEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btoGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxRelga.SuspendLayout()
        CType(Me.dgvCondicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsCondicion.SuspendLayout()
        Me.gbx1.SuspendLayout()
        CType(Me.dgvRegla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsReglas.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
        Me.tsRegla.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ámbito de aplicacion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de la regla:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(310, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Color:"
        '
        'pnlColor
        '
        Me.pnlColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlColor.Location = New System.Drawing.Point(350, 13)
        Me.pnlColor.Name = "pnlColor"
        Me.pnlColor.Size = New System.Drawing.Size(24, 24)
        Me.pnlColor.TabIndex = 3
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(135, 44)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(146, 20)
        Me.tbxNombre.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblColor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.nudOrden)
        Me.GroupBox1.Controls.Add(Me.cbxReglaAplica)
        Me.GroupBox1.Controls.Add(Me.tbxNombre)
        Me.GroupBox1.Controls.Add(Me.pnlColor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 77)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(380, 17)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(49, 13)
        Me.lblColor.TabIndex = 0
        Me.lblColor.Text = "Sin Color"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(305, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 167
        Me.Label6.Text = "Orden:"
        '
        'nudOrden
        '
        Me.nudOrden.Location = New System.Drawing.Point(350, 44)
        Me.nudOrden.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudOrden.Name = "nudOrden"
        Me.nudOrden.Size = New System.Drawing.Size(56, 20)
        Me.nudOrden.TabIndex = 166
        Me.nudOrden.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbxReglaAplica
        '
        Me.cbxReglaAplica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxReglaAplica.FormattingEnabled = True
        Me.cbxReglaAplica.Location = New System.Drawing.Point(135, 14)
        Me.cbxReglaAplica.Name = "cbxReglaAplica"
        Me.cbxReglaAplica.Size = New System.Drawing.Size(146, 21)
        Me.cbxReglaAplica.TabIndex = 165
        '
        'gbxRelga
        '
        Me.gbxRelga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxRelga.Controls.Add(Me.rdbNo)
        Me.gbxRelga.Controls.Add(Me.rdbSi)
        Me.gbxRelga.Controls.Add(Me.lblDescripcionCampo)
        Me.gbxRelga.Controls.Add(Me.Label5)
        Me.gbxRelga.Controls.Add(Me.Label4)
        Me.gbxRelga.Controls.Add(Me.btnAgregarCondicion)
        Me.gbxRelga.Controls.Add(Me.dgvCondicion)
        Me.gbxRelga.Controls.Add(Me.tbxValor)
        Me.gbxRelga.Controls.Add(Me.cbxOperador)
        Me.gbxRelga.Controls.Add(Me.cbxCampo)
        Me.gbxRelga.Controls.Add(Me.GroupBox1)
        Me.gbxRelga.Location = New System.Drawing.Point(16, 269)
        Me.gbxRelga.Name = "gbxRelga"
        Me.gbxRelga.Size = New System.Drawing.Size(485, 272)
        Me.gbxRelga.TabIndex = 6
        Me.gbxRelga.TabStop = False
        '
        'rdbNo
        '
        Me.rdbNo.AutoSize = True
        Me.rdbNo.Location = New System.Drawing.Point(374, 104)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(39, 17)
        Me.rdbNo.TabIndex = 177
        Me.rdbNo.TabStop = True
        Me.rdbNo.Text = "No"
        Me.rdbNo.UseVisualStyleBackColor = True
        '
        'rdbSi
        '
        Me.rdbSi.AutoSize = True
        Me.rdbSi.Location = New System.Drawing.Point(333, 104)
        Me.rdbSi.Name = "rdbSi"
        Me.rdbSi.Size = New System.Drawing.Size(34, 17)
        Me.rdbSi.TabIndex = 176
        Me.rdbSi.TabStop = True
        Me.rdbSi.Text = "Si"
        Me.rdbSi.UseVisualStyleBackColor = True
        '
        'lblDescripcionCampo
        '
        Me.lblDescripcionCampo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescripcionCampo.AutoEllipsis = True
        Me.lblDescripcionCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionCampo.Location = New System.Drawing.Point(61, 131)
        Me.lblDescripcionCampo.Name = "lblDescripcionCampo"
        Me.lblDescripcionCampo.Size = New System.Drawing.Size(411, 13)
        Me.lblDescripcionCampo.TabIndex = 175
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(294, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "Valor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "Campo:"
        '
        'btnAgregarCondicion
        '
        Me.btnAgregarCondicion.Image = Global.StyleManger.My.Resources.Resources.add
        Me.btnAgregarCondicion.Location = New System.Drawing.Point(442, 97)
        Me.btnAgregarCondicion.Name = "btnAgregarCondicion"
        Me.btnAgregarCondicion.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregarCondicion.TabIndex = 172
        Me.btnAgregarCondicion.UseVisualStyleBackColor = True
        '
        'dgvCondicion
        '
        Me.dgvCondicion.AllowUserToAddRows = False
        Me.dgvCondicion.AllowUserToDeleteRows = False
        Me.dgvCondicion.AllowUserToResizeRows = False
        Me.dgvCondicion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCondicion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvCondicion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCondicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCondicion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.campo})
        Me.dgvCondicion.ContextMenuStrip = Me.cmsCondicion
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCondicion.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCondicion.Location = New System.Drawing.Point(6, 147)
        Me.dgvCondicion.MultiSelect = False
        Me.dgvCondicion.Name = "dgvCondicion"
        Me.dgvCondicion.ReadOnly = True
        Me.dgvCondicion.RowHeadersVisible = False
        Me.dgvCondicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCondicion.Size = New System.Drawing.Size(468, 116)
        Me.dgvCondicion.TabIndex = 169
        '
        'campo
        '
        Me.campo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.campo.DataPropertyName = "v_campoOperValor"
        Me.campo.HeaderText = "Condiciones"
        Me.campo.Name = "campo"
        Me.campo.ReadOnly = True
        '
        'cmsCondicion
        '
        Me.cmsCondicion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarCondicionToolStripMenuItem})
        Me.cmsCondicion.Name = "ContextMenuStrip1"
        Me.cmsCondicion.Size = New System.Drawing.Size(177, 26)
        '
        'EliminarCondicionToolStripMenuItem
        '
        Me.EliminarCondicionToolStripMenuItem.Name = "EliminarCondicionToolStripMenuItem"
        Me.EliminarCondicionToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.EliminarCondicionToolStripMenuItem.Text = "Eliminar condicion "
        '
        'tbxValor
        '
        Me.tbxValor.Location = New System.Drawing.Point(326, 102)
        Me.tbxValor.Name = "tbxValor"
        Me.tbxValor.Size = New System.Drawing.Size(104, 20)
        Me.tbxValor.TabIndex = 168
        '
        'cbxOperador
        '
        Me.cbxOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOperador.FormattingEnabled = True
        Me.cbxOperador.Location = New System.Drawing.Point(229, 101)
        Me.cbxOperador.Name = "cbxOperador"
        Me.cbxOperador.Size = New System.Drawing.Size(52, 21)
        Me.cbxOperador.TabIndex = 167
        '
        'cbxCampo
        '
        Me.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCampo.DropDownWidth = 250
        Me.cbxCampo.FormattingEnabled = True
        Me.cbxCampo.Location = New System.Drawing.Point(61, 101)
        Me.cbxCampo.Name = "cbxCampo"
        Me.cbxCampo.Size = New System.Drawing.Size(153, 21)
        Me.cbxCampo.TabIndex = 166
        '
        'gbx1
        '
        Me.gbx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx1.Controls.Add(Me.dgvRegla)
        Me.gbx1.Location = New System.Drawing.Point(16, 5)
        Me.gbx1.Name = "gbx1"
        Me.gbx1.Size = New System.Drawing.Size(482, 234)
        Me.gbx1.TabIndex = 9
        Me.gbx1.TabStop = False
        '
        'dgvRegla
        '
        Me.dgvRegla.AllowUserToAddRows = False
        Me.dgvRegla.AllowUserToDeleteRows = False
        Me.dgvRegla.AllowUserToResizeRows = False
        Me.dgvRegla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRegla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvRegla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvRegla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRegla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRegAmbito, Me.colRegColor, Me.colRegOrden, Me.colRegNombre})
        Me.dgvRegla.ContextMenuStrip = Me.cmsReglas
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRegla.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRegla.Location = New System.Drawing.Point(6, 19)
        Me.dgvRegla.MultiSelect = False
        Me.dgvRegla.Name = "dgvRegla"
        Me.dgvRegla.ReadOnly = True
        Me.dgvRegla.RowHeadersVisible = False
        Me.dgvRegla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegla.Size = New System.Drawing.Size(466, 209)
        Me.dgvRegla.TabIndex = 170
        '
        'colRegAmbito
        '
        Me.colRegAmbito.DataPropertyName = "vAplica"
        Me.colRegAmbito.HeaderText = "Ámbito"
        Me.colRegAmbito.Name = "colRegAmbito"
        Me.colRegAmbito.ReadOnly = True
        Me.colRegAmbito.Width = 64
        '
        'colRegColor
        '
        Me.colRegColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colRegColor.DefaultCellStyle = DataGridViewCellStyle2
        Me.colRegColor.HeaderText = ""
        Me.colRegColor.Name = "colRegColor"
        Me.colRegColor.ReadOnly = True
        Me.colRegColor.ToolTipText = "Color"
        Me.colRegColor.Width = 19
        '
        'colRegOrden
        '
        Me.colRegOrden.DataPropertyName = "orden"
        Me.colRegOrden.HeaderText = ""
        Me.colRegOrden.Name = "colRegOrden"
        Me.colRegOrden.ReadOnly = True
        Me.colRegOrden.ToolTipText = "Orden"
        Me.colRegOrden.Width = 19
        '
        'colRegNombre
        '
        Me.colRegNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colRegNombre.DataPropertyName = "texto"
        Me.colRegNombre.HeaderText = "Regla"
        Me.colRegNombre.Name = "colRegNombre"
        Me.colRegNombre.ReadOnly = True
        Me.colRegNombre.Width = 60
        '
        'cmsReglas
        '
        Me.cmsReglas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDesactivarAplica})
        Me.cmsReglas.Name = "cmsReglas"
        Me.cmsReglas.Size = New System.Drawing.Size(185, 26)
        '
        'btnDesactivarAplica
        '
        Me.btnDesactivarAplica.Name = "btnDesactivarAplica"
        Me.btnDesactivarAplica.Size = New System.Drawing.Size(184, 22)
        Me.btnDesactivarAplica.Text = "Desactivar Reglas de:"
        '
        'pnlBotones
        '
        Me.pnlBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBotones.Controls.Add(Me.tsRegla)
        Me.pnlBotones.Location = New System.Drawing.Point(16, 245)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(485, 28)
        Me.pnlBotones.TabIndex = 11
        '
        'tsRegla
        '
        Me.tsRegla.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btoNuevo, Me.btoModificar, Me.btoEliminar, Me.btoGuardar, Me.btnCancelar})
        Me.tsRegla.Location = New System.Drawing.Point(0, 0)
        Me.tsRegla.Name = "tsRegla"
        Me.tsRegla.Size = New System.Drawing.Size(485, 25)
        Me.tsRegla.TabIndex = 176
        Me.tsRegla.Text = "ToolStrip2"
        '
        'btoNuevo
        '
        Me.btoNuevo.Image = CType(resources.GetObject("btoNuevo.Image"), System.Drawing.Image)
        Me.btoNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btoNuevo.Name = "btoNuevo"
        Me.btoNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btoNuevo.Text = "&Nuevo"
        '
        'btoModificar
        '
        Me.btoModificar.Image = CType(resources.GetObject("btoModificar.Image"), System.Drawing.Image)
        Me.btoModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btoModificar.Name = "btoModificar"
        Me.btoModificar.Size = New System.Drawing.Size(78, 22)
        Me.btoModificar.Text = "&Modificar"
        '
        'btoEliminar
        '
        Me.btoEliminar.Image = CType(resources.GetObject("btoEliminar.Image"), System.Drawing.Image)
        Me.btoEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btoEliminar.Name = "btoEliminar"
        Me.btoEliminar.Size = New System.Drawing.Size(70, 22)
        Me.btoEliminar.Text = "&Eliminar"
        '
        'btoGuardar
        '
        Me.btoGuardar.Image = CType(resources.GetObject("btoGuardar.Image"), System.Drawing.Image)
        Me.btoGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btoGuardar.Name = "btoGuardar"
        Me.btoGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btoGuardar.Text = "&Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmReglas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(513, 548)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.gbx1)
        Me.Controls.Add(Me.gbxRelga)
        Me.Name = "FrmReglas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Reglas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxRelga.ResumeLayout(False)
        Me.gbxRelga.PerformLayout()
        CType(Me.dgvCondicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsCondicion.ResumeLayout(False)
        Me.gbx1.ResumeLayout(False)
        CType(Me.dgvRegla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsReglas.ResumeLayout(False)
        Me.pnlBotones.ResumeLayout(False)
        Me.pnlBotones.PerformLayout()
        Me.tsRegla.ResumeLayout(False)
        Me.tsRegla.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlColor As System.Windows.Forms.Panel
    Friend WithEvents tbxNombre As System.Windows.Forms.TextBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxReglaAplica As System.Windows.Forms.ComboBox
    Friend WithEvents gbxRelga As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCondicion As System.Windows.Forms.DataGridView
    Friend WithEvents tbxValor As System.Windows.Forms.TextBox
    Friend WithEvents cbxOperador As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCampo As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregarCondicion As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbx1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvRegla As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nudOrden As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDescripcionCampo As System.Windows.Forms.Label
    Friend WithEvents cmsCondicion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarCondicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents rdbNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSi As System.Windows.Forms.RadioButton
    Friend WithEvents campo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents tsRegla As System.Windows.Forms.ToolStrip
    Friend WithEvents btoNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btoModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btoEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btoGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmsReglas As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnDesactivarAplica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colRegAmbito As DataGridViewTextBoxColumn
    Friend WithEvents colRegColor As DataGridViewTextBoxColumn
    Friend WithEvents colRegOrden As DataGridViewTextBoxColumn
    Friend WithEvents colRegNombre As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
