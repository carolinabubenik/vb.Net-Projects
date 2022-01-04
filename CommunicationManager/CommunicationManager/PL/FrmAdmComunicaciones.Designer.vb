<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdmComunicaciones
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmComunicaciones))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbcPestanias = New System.Windows.Forms.TabControl()
        Me.tbpComunicaciones = New System.Windows.Forms.TabPage()
        Me.txtContenidoCom = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.spcComunicaciones = New System.Windows.Forms.SplitContainer()
        Me.btnComNueva = New System.Windows.Forms.Button()
        Me.dgvComunicacion = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inicia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsComunicacion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnNuevaComunicacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.spcDialogos = New System.Windows.Forms.SplitContainer()
        Me.pnlDialogos = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lklCrearTarea2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.pnlResponder = New System.Windows.Forms.Panel()
        Me.pbxStar4 = New System.Windows.Forms.PictureBox()
        Me.pbxStar3 = New System.Windows.Forms.PictureBox()
        Me.pbxStar2 = New System.Windows.Forms.PictureBox()
        Me.pbxStar1 = New System.Windows.Forms.PictureBox()
        Me.btnResponder = New System.Windows.Forms.Button()
        Me.cbxContacto = New System.Windows.Forms.CheckBox()
        Me.cbxRespEstado = New System.Windows.Forms.ComboBox()
        Me.lblRespEntidad = New System.Windows.Forms.Label()
        Me.cbxRespMotivo = New System.Windows.Forms.ComboBox()
        Me.btnRespEnviar = New System.Windows.Forms.Button()
        Me.btnRespBuscar = New System.Windows.Forms.Button()
        Me.txtRespObservac = New System.Windows.Forms.TextBox()
        Me.pbxComSig = New System.Windows.Forms.PictureBox()
        Me.pbxComAnt = New System.Windows.Forms.PictureBox()
        Me.btnComBuscar = New System.Windows.Forms.Button()
        Me.dtpComHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpComDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tbcPestanias.SuspendLayout()
        Me.tbpComunicaciones.SuspendLayout()
        CType(Me.spcComunicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcComunicaciones.Panel1.SuspendLayout()
        Me.spcComunicaciones.Panel2.SuspendLayout()
        Me.spcComunicaciones.SuspendLayout()
        CType(Me.dgvComunicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsComunicacion.SuspendLayout()
        CType(Me.spcDialogos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcDialogos.Panel1.SuspendLayout()
        Me.spcDialogos.Panel2.SuspendLayout()
        Me.spcDialogos.SuspendLayout()
        Me.pnlDialogos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlResponder.SuspendLayout()
        CType(Me.pbxStar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxComSig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxComAnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcPestanias
        '
        Me.tbcPestanias.Controls.Add(Me.tbpComunicaciones)
        Me.tbcPestanias.Location = New System.Drawing.Point(1, 3)
        Me.tbcPestanias.Name = "tbcPestanias"
        Me.tbcPestanias.SelectedIndex = 0
        Me.tbcPestanias.Size = New System.Drawing.Size(926, 483)
        Me.tbcPestanias.TabIndex = 0
        '
        'tbpComunicaciones
        '
        Me.tbpComunicaciones.Controls.Add(Me.txtContenidoCom)
        Me.tbpComunicaciones.Controls.Add(Me.Label22)
        Me.tbpComunicaciones.Controls.Add(Me.spcComunicaciones)
        Me.tbpComunicaciones.Controls.Add(Me.pbxComSig)
        Me.tbpComunicaciones.Controls.Add(Me.pbxComAnt)
        Me.tbpComunicaciones.Controls.Add(Me.btnComBuscar)
        Me.tbpComunicaciones.Controls.Add(Me.dtpComHasta)
        Me.tbpComunicaciones.Controls.Add(Me.dtpComDesde)
        Me.tbpComunicaciones.Controls.Add(Me.Label1)
        Me.tbpComunicaciones.Controls.Add(Me.Label8)
        Me.tbpComunicaciones.Location = New System.Drawing.Point(4, 22)
        Me.tbpComunicaciones.Name = "tbpComunicaciones"
        Me.tbpComunicaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpComunicaciones.Size = New System.Drawing.Size(918, 457)
        Me.tbpComunicaciones.TabIndex = 4
        Me.tbpComunicaciones.Text = "Agenda"
        Me.tbpComunicaciones.UseVisualStyleBackColor = True
        '
        'txtContenidoCom
        '
        Me.txtContenidoCom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContenidoCom.Location = New System.Drawing.Point(492, 6)
        Me.txtContenidoCom.Name = "txtContenidoCom"
        Me.txtContenidoCom.Size = New System.Drawing.Size(293, 20)
        Me.txtContenidoCom.TabIndex = 175
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(421, 10)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 13)
        Me.Label22.TabIndex = 174
        Me.Label22.Text = "Contenido:"
        '
        'spcComunicaciones
        '
        Me.spcComunicaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spcComunicaciones.Location = New System.Drawing.Point(3, 35)
        Me.spcComunicaciones.Name = "spcComunicaciones"
        '
        'spcComunicaciones.Panel1
        '
        Me.spcComunicaciones.Panel1.Controls.Add(Me.btnComNueva)
        Me.spcComunicaciones.Panel1.Controls.Add(Me.dgvComunicacion)
        '
        'spcComunicaciones.Panel2
        '
        Me.spcComunicaciones.Panel2.Controls.Add(Me.spcDialogos)
        Me.spcComunicaciones.Size = New System.Drawing.Size(911, 416)
        Me.spcComunicaciones.SplitterDistance = 416
        Me.spcComunicaciones.SplitterWidth = 8
        Me.spcComunicaciones.TabIndex = 59
        '
        'btnComNueva
        '
        Me.btnComNueva.Image = CType(resources.GetObject("btnComNueva.Image"), System.Drawing.Image)
        Me.btnComNueva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComNueva.Location = New System.Drawing.Point(3, 3)
        Me.btnComNueva.Name = "btnComNueva"
        Me.btnComNueva.Size = New System.Drawing.Size(67, 26)
        Me.btnComNueva.TabIndex = 197
        Me.btnComNueva.Text = "Nueva"
        Me.btnComNueva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnComNueva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnComNueva.UseVisualStyleBackColor = True
        '
        'dgvComunicacion
        '
        Me.dgvComunicacion.AllowUserToAddRows = False
        Me.dgvComunicacion.AllowUserToResizeRows = False
        Me.dgvComunicacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvComunicacion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvComunicacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvComunicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComunicacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Inicia, Me.Categoria, Me.Estado})
        Me.dgvComunicacion.ContextMenuStrip = Me.cmsComunicacion
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvComunicacion.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvComunicacion.Location = New System.Drawing.Point(0, 34)
        Me.dgvComunicacion.Name = "dgvComunicacion"
        Me.dgvComunicacion.ReadOnly = True
        Me.dgvComunicacion.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvComunicacion.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvComunicacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvComunicacion.Size = New System.Drawing.Size(413, 379)
        Me.dgvComunicacion.TabIndex = 196
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Fecha.DataPropertyName = "fecha_hora"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 62
        '
        'Inicia
        '
        Me.Inicia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Inicia.DataPropertyName = "EntidadAyN"
        Me.Inicia.HeaderText = "Contacto"
        Me.Inicia.Name = "Inicia"
        Me.Inicia.ReadOnly = True
        Me.Inicia.Width = 120
        '
        'Categoria
        '
        Me.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Categoria.DataPropertyName = "DescripcionCat"
        Me.Categoria.HeaderText = "Iniciado por"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        Me.Categoria.Width = 87
        '
        'Estado
        '
        Me.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Estado.DataPropertyName = "estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Visible = False
        '
        'cmsComunicacion
        '
        Me.cmsComunicacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevaComunicacion})
        Me.cmsComunicacion.Name = "cmsComunicacion"
        Me.cmsComunicacion.Size = New System.Drawing.Size(190, 26)
        '
        'btnNuevaComunicacion
        '
        Me.btnNuevaComunicacion.Name = "btnNuevaComunicacion"
        Me.btnNuevaComunicacion.Size = New System.Drawing.Size(189, 22)
        Me.btnNuevaComunicacion.Text = "Nueva Comunicación"
        '
        'spcDialogos
        '
        Me.spcDialogos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcDialogos.Location = New System.Drawing.Point(0, 0)
        Me.spcDialogos.Name = "spcDialogos"
        Me.spcDialogos.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcDialogos.Panel1
        '
        Me.spcDialogos.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.spcDialogos.Panel1.Controls.Add(Me.pnlDialogos)
        '
        'spcDialogos.Panel2
        '
        Me.spcDialogos.Panel2.Controls.Add(Me.pnlResponder)
        Me.spcDialogos.Size = New System.Drawing.Size(487, 416)
        Me.spcDialogos.SplitterDistance = 239
        Me.spcDialogos.TabIndex = 0
        '
        'pnlDialogos
        '
        Me.pnlDialogos.AutoScroll = True
        Me.pnlDialogos.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.pnlDialogos.Controls.Add(Me.Label12)
        Me.pnlDialogos.Controls.Add(Me.Panel2)
        Me.pnlDialogos.Controls.Add(Me.Label13)
        Me.pnlDialogos.Controls.Add(Me.Panel1)
        Me.pnlDialogos.Controls.Add(Me.Label15)
        Me.pnlDialogos.Controls.Add(Me.Label17)
        Me.pnlDialogos.Controls.Add(Me.Label19)
        Me.pnlDialogos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDialogos.Location = New System.Drawing.Point(0, 0)
        Me.pnlDialogos.Name = "pnlDialogos"
        Me.pnlDialogos.Size = New System.Drawing.Size(487, 239)
        Me.pnlDialogos.TabIndex = 199
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(29, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 194
        Me.Label12.Text = "REMITO"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Location = New System.Drawing.Point(14, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(386, 60)
        Me.Panel2.TabIndex = 193
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(444, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 195
        Me.Button1.Text = "Crear Tarea"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(46, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 14)
        Me.Label18.TabIndex = 191
        Me.Label18.Text = "Juan Pérez"
        Me.Label18.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(11, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(24, 13)
        Me.Label16.TabIndex = 190
        Me.Label16.Text = "De:"
        Me.Label16.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Gold
        Me.Label13.Location = New System.Drawing.Point(29, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 194
        Me.Label13.Text = "REMITO"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lklCrearTarea2)
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(14, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 95)
        Me.Panel1.TabIndex = 193
        '
        'lklCrearTarea2
        '
        Me.lklCrearTarea2.ActiveLinkColor = System.Drawing.Color.IndianRed
        Me.lklCrearTarea2.AutoSize = True
        Me.lklCrearTarea2.LinkColor = System.Drawing.Color.LightSteelBlue
        Me.lklCrearTarea2.Location = New System.Drawing.Point(488, 68)
        Me.lklCrearTarea2.Name = "lklCrearTarea2"
        Me.lklCrearTarea2.Size = New System.Drawing.Size(63, 13)
        Me.lklCrearTarea2.TabIndex = 195
        Me.lklCrearTarea2.TabStop = True
        Me.lklCrearTarea2.Text = "Crear Tarea"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.IndianRed
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkColor = System.Drawing.Color.LightSteelBlue
        Me.LinkLabel2.Location = New System.Drawing.Point(410, 68)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel2.TabIndex = 195
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Ver Tareas"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(14, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 14)
        Me.Label14.TabIndex = 194
        Me.Label14.Text = "Muy Buena!"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(-3072, 8815)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 189
        Me.Label15.Text = "Para:"
        Me.Label15.Visible = False
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(-3028, 336)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 14)
        Me.Label17.TabIndex = 192
        Me.Label17.Text = "Antonio Rios"
        Me.Label17.Visible = False
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(12, 8783)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(168, 23)
        Me.Label19.TabIndex = 188
        Me.Label19.Text = "Pedido realizado"
        Me.Label19.Visible = False
        '
        'pnlResponder
        '
        Me.pnlResponder.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.pnlResponder.Controls.Add(Me.pbxStar4)
        Me.pnlResponder.Controls.Add(Me.pbxStar3)
        Me.pnlResponder.Controls.Add(Me.pbxStar2)
        Me.pnlResponder.Controls.Add(Me.pbxStar1)
        Me.pnlResponder.Controls.Add(Me.btnResponder)
        Me.pnlResponder.Controls.Add(Me.cbxContacto)
        Me.pnlResponder.Controls.Add(Me.cbxRespEstado)
        Me.pnlResponder.Controls.Add(Me.lblRespEntidad)
        Me.pnlResponder.Controls.Add(Me.cbxRespMotivo)
        Me.pnlResponder.Controls.Add(Me.btnRespEnviar)
        Me.pnlResponder.Controls.Add(Me.btnRespBuscar)
        Me.pnlResponder.Controls.Add(Me.txtRespObservac)
        Me.pnlResponder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlResponder.Location = New System.Drawing.Point(0, 0)
        Me.pnlResponder.Name = "pnlResponder"
        Me.pnlResponder.Size = New System.Drawing.Size(487, 173)
        Me.pnlResponder.TabIndex = 202
        '
        'pbxStar4
        '
        Me.pbxStar4.Location = New System.Drawing.Point(292, 38)
        Me.pbxStar4.Name = "pbxStar4"
        Me.pbxStar4.Size = New System.Drawing.Size(16, 16)
        Me.pbxStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxStar4.TabIndex = 205
        Me.pbxStar4.TabStop = False
        Me.pbxStar4.Visible = False
        '
        'pbxStar3
        '
        Me.pbxStar3.Image = CType(resources.GetObject("pbxStar3.Image"), System.Drawing.Image)
        Me.pbxStar3.Location = New System.Drawing.Point(274, 38)
        Me.pbxStar3.Name = "pbxStar3"
        Me.pbxStar3.Size = New System.Drawing.Size(16, 16)
        Me.pbxStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxStar3.TabIndex = 205
        Me.pbxStar3.TabStop = False
        Me.pbxStar3.Visible = False
        '
        'pbxStar2
        '
        Me.pbxStar2.Image = CType(resources.GetObject("pbxStar2.Image"), System.Drawing.Image)
        Me.pbxStar2.Location = New System.Drawing.Point(256, 38)
        Me.pbxStar2.Name = "pbxStar2"
        Me.pbxStar2.Size = New System.Drawing.Size(16, 16)
        Me.pbxStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxStar2.TabIndex = 205
        Me.pbxStar2.TabStop = False
        Me.pbxStar2.Visible = False
        '
        'pbxStar1
        '
        Me.pbxStar1.Image = CType(resources.GetObject("pbxStar1.Image"), System.Drawing.Image)
        Me.pbxStar1.Location = New System.Drawing.Point(238, 38)
        Me.pbxStar1.Name = "pbxStar1"
        Me.pbxStar1.Size = New System.Drawing.Size(16, 16)
        Me.pbxStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxStar1.TabIndex = 205
        Me.pbxStar1.TabStop = False
        Me.pbxStar1.Visible = False
        '
        'btnResponder
        '
        Me.btnResponder.Image = CType(resources.GetObject("btnResponder.Image"), System.Drawing.Image)
        Me.btnResponder.Location = New System.Drawing.Point(9, 8)
        Me.btnResponder.Name = "btnResponder"
        Me.btnResponder.Size = New System.Drawing.Size(92, 23)
        Me.btnResponder.TabIndex = 204
        Me.btnResponder.Text = "Agregar"
        Me.btnResponder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResponder.UseVisualStyleBackColor = True
        '
        'cbxContacto
        '
        Me.cbxContacto.AutoSize = True
        Me.cbxContacto.ForeColor = System.Drawing.Color.White
        Me.cbxContacto.Location = New System.Drawing.Point(107, 12)
        Me.cbxContacto.Name = "cbxContacto"
        Me.cbxContacto.Size = New System.Drawing.Size(72, 17)
        Me.cbxContacto.TabIndex = 196
        Me.cbxContacto.Text = "Contacto:"
        Me.cbxContacto.UseVisualStyleBackColor = True
        '
        'cbxRespEstado
        '
        Me.cbxRespEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxRespEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRespEstado.FormattingEnabled = True
        Me.cbxRespEstado.Location = New System.Drawing.Point(364, 8)
        Me.cbxRespEstado.Name = "cbxRespEstado"
        Me.cbxRespEstado.Size = New System.Drawing.Size(113, 21)
        Me.cbxRespEstado.TabIndex = 195
        '
        'lblRespEntidad
        '
        Me.lblRespEntidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRespEntidad.ForeColor = System.Drawing.Color.White
        Me.lblRespEntidad.Location = New System.Drawing.Point(185, 13)
        Me.lblRespEntidad.Name = "lblRespEntidad"
        Me.lblRespEntidad.Size = New System.Drawing.Size(138, 13)
        Me.lblRespEntidad.TabIndex = 194
        Me.lblRespEntidad.Text = "Entidad"
        '
        'cbxRespMotivo
        '
        Me.cbxRespMotivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxRespMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRespMotivo.ForeColor = System.Drawing.Color.White
        Me.cbxRespMotivo.FormattingEnabled = True
        Me.cbxRespMotivo.Location = New System.Drawing.Point(9, 36)
        Me.cbxRespMotivo.Name = "cbxRespMotivo"
        Me.cbxRespMotivo.Size = New System.Drawing.Size(207, 21)
        Me.cbxRespMotivo.TabIndex = 193
        '
        'btnRespEnviar
        '
        Me.btnRespEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRespEnviar.ForeColor = System.Drawing.Color.Maroon
        Me.btnRespEnviar.Image = CType(resources.GetObject("btnRespEnviar.Image"), System.Drawing.Image)
        Me.btnRespEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRespEnviar.Location = New System.Drawing.Point(400, 34)
        Me.btnRespEnviar.Name = "btnRespEnviar"
        Me.btnRespEnviar.Size = New System.Drawing.Size(77, 25)
        Me.btnRespEnviar.TabIndex = 192
        Me.btnRespEnviar.Text = "Guardar"
        Me.btnRespEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRespEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRespEnviar.UseVisualStyleBackColor = True
        '
        'btnRespBuscar
        '
        Me.btnRespBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRespBuscar.Image = CType(resources.GetObject("btnRespBuscar.Image"), System.Drawing.Image)
        Me.btnRespBuscar.Location = New System.Drawing.Point(329, 7)
        Me.btnRespBuscar.Name = "btnRespBuscar"
        Me.btnRespBuscar.Size = New System.Drawing.Size(29, 23)
        Me.btnRespBuscar.TabIndex = 192
        Me.btnRespBuscar.UseVisualStyleBackColor = True
        '
        'txtRespObservac
        '
        Me.txtRespObservac.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRespObservac.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRespObservac.ForeColor = System.Drawing.Color.White
        Me.txtRespObservac.Location = New System.Drawing.Point(9, 65)
        Me.txtRespObservac.Multiline = True
        Me.txtRespObservac.Name = "txtRespObservac"
        Me.txtRespObservac.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRespObservac.Size = New System.Drawing.Size(475, 105)
        Me.txtRespObservac.TabIndex = 189
        Me.txtRespObservac.Text = "blah blah blah" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "etc..."
        '
        'pbxComSig
        '
        Me.pbxComSig.Location = New System.Drawing.Point(383, 3)
        Me.pbxComSig.Name = "pbxComSig"
        Me.pbxComSig.Size = New System.Drawing.Size(33, 26)
        Me.pbxComSig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxComSig.TabIndex = 24
        Me.pbxComSig.TabStop = False
        '
        'pbxComAnt
        '
        Me.pbxComAnt.Location = New System.Drawing.Point(344, 3)
        Me.pbxComAnt.Name = "pbxComAnt"
        Me.pbxComAnt.Size = New System.Drawing.Size(33, 26)
        Me.pbxComAnt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxComAnt.TabIndex = 23
        Me.pbxComAnt.TabStop = False
        '
        'btnComBuscar
        '
        Me.btnComBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnComBuscar.Image = CType(resources.GetObject("btnComBuscar.Image"), System.Drawing.Image)
        Me.btnComBuscar.Location = New System.Drawing.Point(792, 2)
        Me.btnComBuscar.Name = "btnComBuscar"
        Me.btnComBuscar.Size = New System.Drawing.Size(32, 27)
        Me.btnComBuscar.TabIndex = 22
        Me.btnComBuscar.UseVisualStyleBackColor = True
        '
        'dtpComHasta
        '
        Me.dtpComHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpComHasta.Location = New System.Drawing.Point(225, 6)
        Me.dtpComHasta.Name = "dtpComHasta"
        Me.dtpComHasta.Size = New System.Drawing.Size(109, 20)
        Me.dtpComHasta.TabIndex = 21
        '
        'dtpComDesde
        '
        Me.dtpComDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpComDesde.Location = New System.Drawing.Point(60, 6)
        Me.dtpComDesde.Name = "dtpComDesde"
        Me.dtpComDesde.Size = New System.Drawing.Size(109, 20)
        Me.dtpComDesde.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Hasta:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Desde:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmAdmComunicaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 498)
        Me.Controls.Add(Me.tbcPestanias)
        Me.Name = "FrmAdmComunicaciones"
        Me.Text = "FrmAdmComunicaciones"
        Me.tbcPestanias.ResumeLayout(False)
        Me.tbpComunicaciones.ResumeLayout(False)
        Me.tbpComunicaciones.PerformLayout()
        Me.spcComunicaciones.Panel1.ResumeLayout(False)
        Me.spcComunicaciones.Panel2.ResumeLayout(False)
        CType(Me.spcComunicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcComunicaciones.ResumeLayout(False)
        CType(Me.dgvComunicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsComunicacion.ResumeLayout(False)
        Me.spcDialogos.Panel1.ResumeLayout(False)
        Me.spcDialogos.Panel2.ResumeLayout(False)
        CType(Me.spcDialogos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcDialogos.ResumeLayout(False)
        Me.pnlDialogos.ResumeLayout(False)
        Me.pnlDialogos.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlResponder.ResumeLayout(False)
        Me.pnlResponder.PerformLayout()
        CType(Me.pbxStar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxComSig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxComAnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcPestanias As TabControl
    Friend WithEvents tbpComunicaciones As TabPage
    Friend WithEvents txtContenidoCom As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents spcComunicaciones As SplitContainer
    Friend WithEvents btnComNueva As Button
    Friend WithEvents dgvComunicacion As DataGridView
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Inicia As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents spcDialogos As SplitContainer
    Friend WithEvents pnlDialogos As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lklCrearTarea2 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents pnlResponder As Panel
    Friend WithEvents pbxStar4 As PictureBox
    Friend WithEvents pbxStar3 As PictureBox
    Friend WithEvents pbxStar2 As PictureBox
    Friend WithEvents pbxStar1 As PictureBox
    Friend WithEvents btnResponder As Button
    Friend WithEvents cbxContacto As CheckBox
    Friend WithEvents cbxRespEstado As ComboBox
    Friend WithEvents lblRespEntidad As Label
    Friend WithEvents cbxRespMotivo As ComboBox
    Friend WithEvents btnRespEnviar As Button
    Friend WithEvents btnRespBuscar As Button
    Friend WithEvents txtRespObservac As TextBox
    Friend WithEvents pbxComSig As PictureBox
    Friend WithEvents pbxComAnt As PictureBox
    Friend WithEvents btnComBuscar As Button
    Friend WithEvents dtpComHasta As DateTimePicker
    Friend WithEvents dtpComDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cmsComunicacion As ContextMenuStrip
    Friend WithEvents btnNuevaComunicacion As ToolStripMenuItem
End Class
