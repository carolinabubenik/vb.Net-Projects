<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDialogos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDialogos))
        Me.spcTodo = New System.Windows.Forms.SplitContainer()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.cbxMotivo = New System.Windows.Forms.ComboBox()
        Me.cbxPertenece = New System.Windows.Forms.ComboBox()
        Me.gbxComunicacion = New System.Windows.Forms.GroupBox()
        Me.lblComEstado = New System.Windows.Forms.Label()
        Me.lblComFecha = New System.Windows.Forms.Label()
        Me.lblComCategoria = New System.Windows.Forms.Label()
        Me.lblComAyN = New System.Windows.Forms.Label()
        Me.lblContacto = New System.Windows.Forms.Label()
        Me.lblIniciadaPor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.cbxRespMotivo = New Telerik.WinControls.UI.RadDropDownList()
        Me.pbxStar4 = New System.Windows.Forms.PictureBox()
        Me.pbxStar3 = New System.Windows.Forms.PictureBox()
        Me.pbxStar2 = New System.Windows.Forms.PictureBox()
        Me.pbxStar1 = New System.Windows.Forms.PictureBox()
        Me.btnResponder = New System.Windows.Forms.Button()
        Me.chkContacto = New System.Windows.Forms.CheckBox()
        Me.cbxRespEstado = New System.Windows.Forms.ComboBox()
        Me.lblRespEntidad = New System.Windows.Forms.Label()
        Me.btnRespEnviar = New System.Windows.Forms.Button()
        Me.btnRespBuscar = New System.Windows.Forms.Button()
        Me.txtRespObservac = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.spcTodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcTodo.Panel1.SuspendLayout()
        Me.spcTodo.Panel2.SuspendLayout()
        Me.spcTodo.SuspendLayout()
        Me.gbxComunicacion.SuspendLayout()
        CType(Me.spcDialogos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcDialogos.Panel1.SuspendLayout()
        Me.spcDialogos.Panel2.SuspendLayout()
        Me.spcDialogos.SuspendLayout()
        Me.pnlDialogos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlResponder.SuspendLayout()
        CType(Me.cbxRespMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spcTodo
        '
        Me.spcTodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcTodo.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.spcTodo.IsSplitterFixed = True
        Me.spcTodo.Location = New System.Drawing.Point(0, 0)
        Me.spcTodo.Name = "spcTodo"
        Me.spcTodo.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcTodo.Panel1
        '
        Me.spcTodo.Panel1.Controls.Add(Me.txtBuscador)
        Me.spcTodo.Panel1.Controls.Add(Me.cbxMotivo)
        Me.spcTodo.Panel1.Controls.Add(Me.cbxPertenece)
        Me.spcTodo.Panel1.Controls.Add(Me.gbxComunicacion)
        Me.spcTodo.Panel1.Controls.Add(Me.Label3)
        '
        'spcTodo.Panel2
        '
        Me.spcTodo.Panel2.Controls.Add(Me.spcDialogos)
        Me.spcTodo.Size = New System.Drawing.Size(464, 502)
        Me.spcTodo.SplitterDistance = 95
        Me.spcTodo.SplitterWidth = 8
        Me.spcTodo.TabIndex = 0
        '
        'txtBuscador
        '
        Me.txtBuscador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscador.Location = New System.Drawing.Point(311, 71)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(141, 21)
        Me.txtBuscador.TabIndex = 2
        '
        'cbxMotivo
        '
        Me.cbxMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMotivo.DropDownWidth = 280
        Me.cbxMotivo.FormattingEnabled = True
        Me.cbxMotivo.Location = New System.Drawing.Point(177, 71)
        Me.cbxMotivo.Name = "cbxMotivo"
        Me.cbxMotivo.Size = New System.Drawing.Size(128, 21)
        Me.cbxMotivo.TabIndex = 1
        '
        'cbxPertenece
        '
        Me.cbxPertenece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPertenece.DropDownWidth = 200
        Me.cbxPertenece.FormattingEnabled = True
        Me.cbxPertenece.Location = New System.Drawing.Point(72, 71)
        Me.cbxPertenece.Name = "cbxPertenece"
        Me.cbxPertenece.Size = New System.Drawing.Size(99, 21)
        Me.cbxPertenece.TabIndex = 1
        '
        'gbxComunicacion
        '
        Me.gbxComunicacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxComunicacion.Controls.Add(Me.lblComEstado)
        Me.gbxComunicacion.Controls.Add(Me.lblComFecha)
        Me.gbxComunicacion.Controls.Add(Me.lblComCategoria)
        Me.gbxComunicacion.Controls.Add(Me.lblComAyN)
        Me.gbxComunicacion.Controls.Add(Me.lblContacto)
        Me.gbxComunicacion.Controls.Add(Me.lblIniciadaPor)
        Me.gbxComunicacion.Location = New System.Drawing.Point(9, 3)
        Me.gbxComunicacion.Name = "gbxComunicacion"
        Me.gbxComunicacion.Size = New System.Drawing.Size(443, 64)
        Me.gbxComunicacion.TabIndex = 0
        Me.gbxComunicacion.TabStop = False
        Me.gbxComunicacion.Text = "Comunicación"
        '
        'lblComEstado
        '
        Me.lblComEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblComEstado.AutoEllipsis = True
        Me.lblComEstado.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComEstado.Location = New System.Drawing.Point(315, 41)
        Me.lblComEstado.Name = "lblComEstado"
        Me.lblComEstado.Size = New System.Drawing.Size(122, 13)
        Me.lblComEstado.TabIndex = 0
        Me.lblComEstado.Text = "Estado"
        Me.lblComEstado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblComFecha
        '
        Me.lblComFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblComFecha.AutoEllipsis = True
        Me.lblComFecha.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComFecha.Location = New System.Drawing.Point(312, 19)
        Me.lblComFecha.Name = "lblComFecha"
        Me.lblComFecha.Size = New System.Drawing.Size(125, 13)
        Me.lblComFecha.TabIndex = 0
        Me.lblComFecha.Text = "Fecha"
        Me.lblComFecha.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblComCategoria
        '
        Me.lblComCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblComCategoria.AutoEllipsis = True
        Me.lblComCategoria.Location = New System.Drawing.Point(92, 41)
        Me.lblComCategoria.Name = "lblComCategoria"
        Me.lblComCategoria.Size = New System.Drawing.Size(230, 13)
        Me.lblComCategoria.TabIndex = 0
        Me.lblComCategoria.Text = "Contacto:"
        '
        'lblComAyN
        '
        Me.lblComAyN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblComAyN.AutoEllipsis = True
        Me.lblComAyN.Location = New System.Drawing.Point(92, 19)
        Me.lblComAyN.Name = "lblComAyN"
        Me.lblComAyN.Size = New System.Drawing.Size(230, 13)
        Me.lblComAyN.TabIndex = 0
        Me.lblComAyN.Text = "Contacto:"
        '
        'lblContacto
        '
        Me.lblContacto.AutoSize = True
        Me.lblContacto.Location = New System.Drawing.Point(23, 19)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.Size = New System.Drawing.Size(63, 13)
        Me.lblContacto.TabIndex = 0
        Me.lblContacto.Text = "Contacto:"
        '
        'lblIniciadaPor
        '
        Me.lblIniciadaPor.AutoSize = True
        Me.lblIniciadaPor.Location = New System.Drawing.Point(6, 41)
        Me.lblIniciadaPor.Name = "lblIniciadaPor"
        Me.lblIniciadaPor.Size = New System.Drawing.Size(80, 13)
        Me.lblIniciadaPor.TabIndex = 0
        Me.lblIniciadaPor.Text = "Iniciada por:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mostrar:"
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
        Me.spcDialogos.Size = New System.Drawing.Size(464, 399)
        Me.spcDialogos.SplitterDistance = 265
        Me.spcDialogos.TabIndex = 1
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
        Me.pnlDialogos.Size = New System.Drawing.Size(464, 265)
        Me.pnlDialogos.TabIndex = 199
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(29, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
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
        Me.Label16.Size = New System.Drawing.Size(28, 13)
        Me.Label16.TabIndex = 190
        Me.Label16.Text = "De:"
        Me.Label16.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(29, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
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
        Me.lklCrearTarea2.Size = New System.Drawing.Size(76, 13)
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
        Me.LinkLabel2.Size = New System.Drawing.Size(68, 13)
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
        Me.Label15.Location = New System.Drawing.Point(-2976, 8218)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
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
        Me.Label17.Location = New System.Drawing.Point(-2932, 336)
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
        Me.Label19.Location = New System.Drawing.Point(12, 8186)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(168, 23)
        Me.Label19.TabIndex = 188
        Me.Label19.Text = "Pedido realizado"
        Me.Label19.Visible = False
        '
        'pnlResponder
        '
        Me.pnlResponder.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.pnlResponder.Controls.Add(Me.cbxRespMotivo)
        Me.pnlResponder.Controls.Add(Me.pbxStar4)
        Me.pnlResponder.Controls.Add(Me.pbxStar3)
        Me.pnlResponder.Controls.Add(Me.pbxStar2)
        Me.pnlResponder.Controls.Add(Me.pbxStar1)
        Me.pnlResponder.Controls.Add(Me.btnResponder)
        Me.pnlResponder.Controls.Add(Me.chkContacto)
        Me.pnlResponder.Controls.Add(Me.cbxRespEstado)
        Me.pnlResponder.Controls.Add(Me.lblRespEntidad)
        Me.pnlResponder.Controls.Add(Me.btnRespEnviar)
        Me.pnlResponder.Controls.Add(Me.btnRespBuscar)
        Me.pnlResponder.Controls.Add(Me.txtRespObservac)
        Me.pnlResponder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlResponder.Location = New System.Drawing.Point(0, 0)
        Me.pnlResponder.Name = "pnlResponder"
        Me.pnlResponder.Size = New System.Drawing.Size(464, 130)
        Me.pnlResponder.TabIndex = 202
        '
        'cbxRespMotivo
        '
        Me.cbxRespMotivo.Location = New System.Drawing.Point(9, 34)
        Me.cbxRespMotivo.Name = "cbxRespMotivo"
        Me.cbxRespMotivo.Size = New System.Drawing.Size(223, 20)
        Me.cbxRespMotivo.TabIndex = 201
        '
        'pbxStar4
        '
        Me.pbxStar4.Image = modRecursos.My.Resources.Resources.star_off
        Me.pbxStar4.Location = New System.Drawing.Point(292, 38)
        Me.pbxStar4.Name = "pbxStar4"
        Me.pbxStar4.Size = New System.Drawing.Size(16, 16)
        Me.pbxStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxStar4.TabIndex = 205
        Me.pbxStar4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxStar4, "Muy Bueno")
        '
        'pbxStar3
        '
        Me.pbxStar3.Image = modRecursos.My.Resources.Resources.star_on
        Me.pbxStar3.Location = New System.Drawing.Point(274, 38)
        Me.pbxStar3.Name = "pbxStar3"
        Me.pbxStar3.Size = New System.Drawing.Size(16, 16)
        Me.pbxStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxStar3.TabIndex = 205
        Me.pbxStar3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxStar3, "Bueno")
        '
        'pbxStar2
        '
        Me.pbxStar2.Image = modRecursos.My.Resources.Resources.star_on
        Me.pbxStar2.Location = New System.Drawing.Point(256, 38)
        Me.pbxStar2.Name = "pbxStar2"
        Me.pbxStar2.Size = New System.Drawing.Size(16, 16)
        Me.pbxStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxStar2.TabIndex = 205
        Me.pbxStar2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxStar2, "Regular")
        '
        'pbxStar1
        '
        Me.pbxStar1.Image = modRecursos.My.Resources.Resources.star_on
        Me.pbxStar1.Location = New System.Drawing.Point(238, 38)
        Me.pbxStar1.Name = "pbxStar1"
        Me.pbxStar1.Size = New System.Drawing.Size(16, 16)
        Me.pbxStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxStar1.TabIndex = 205
        Me.pbxStar1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxStar1, "Malo")
        '
        'btnResponder
        '
        Me.btnResponder.Image = modRecursos.My.Resources.Resources.dialog
        Me.btnResponder.Location = New System.Drawing.Point(9, 8)
        Me.btnResponder.Name = "btnResponder"
        Me.btnResponder.Size = New System.Drawing.Size(92, 23)
        Me.btnResponder.TabIndex = 204
        Me.btnResponder.Text = "Agregar"
        Me.btnResponder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResponder.UseVisualStyleBackColor = True
        '
        'chkContacto
        '
        Me.chkContacto.AutoSize = True
        Me.chkContacto.ForeColor = System.Drawing.Color.White
        Me.chkContacto.Location = New System.Drawing.Point(107, 12)
        Me.chkContacto.Name = "chkContacto"
        Me.chkContacto.Size = New System.Drawing.Size(82, 17)
        Me.chkContacto.TabIndex = 196
        Me.chkContacto.Text = "Contacto:"
        Me.chkContacto.UseVisualStyleBackColor = True
        '
        'cbxRespEstado
        '
        Me.cbxRespEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxRespEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRespEstado.FormattingEnabled = True
        Me.cbxRespEstado.Location = New System.Drawing.Point(341, 8)
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
        Me.lblRespEntidad.Size = New System.Drawing.Size(115, 13)
        Me.lblRespEntidad.TabIndex = 194
        Me.lblRespEntidad.Text = "Entidad"
        '
        'btnRespEnviar
        '
        Me.btnRespEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRespEnviar.ForeColor = System.Drawing.Color.Maroon
        Me.btnRespEnviar.Image = modRecursos.My.Resources.Resources.disk
        Me.btnRespEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRespEnviar.Location = New System.Drawing.Point(373, 34)
        Me.btnRespEnviar.Name = "btnRespEnviar"
        Me.btnRespEnviar.Size = New System.Drawing.Size(81, 23)
        Me.btnRespEnviar.TabIndex = 192
        Me.btnRespEnviar.Text = "Guardar"
        Me.btnRespEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRespEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRespEnviar.UseVisualStyleBackColor = True
        '
        'btnRespBuscar
        '
        Me.btnRespBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRespBuscar.Image = modRecursos.My.Resources.Resources.buscar
        Me.btnRespBuscar.Location = New System.Drawing.Point(306, 7)
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
        Me.txtRespObservac.Size = New System.Drawing.Size(445, 62)
        Me.txtRespObservac.TabIndex = 189
        Me.txtRespObservac.Text = "blah blah blah" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "etc..."
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmDialogos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(464, 502)
        Me.Controls.Add(Me.spcTodo)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmDialogos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diálogos"
        Me.spcTodo.Panel1.ResumeLayout(False)
        Me.spcTodo.Panel1.PerformLayout()
        Me.spcTodo.Panel2.ResumeLayout(False)
        CType(Me.spcTodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcTodo.ResumeLayout(False)
        Me.gbxComunicacion.ResumeLayout(False)
        Me.gbxComunicacion.PerformLayout()
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
        CType(Me.cbxRespMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spcDialogos As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlDialogos As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lklCrearTarea2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents pnlResponder As System.Windows.Forms.Panel
    Friend WithEvents pbxStar4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStar3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStar2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStar1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnResponder As System.Windows.Forms.Button
    Friend WithEvents chkContacto As System.Windows.Forms.CheckBox
    Friend WithEvents cbxRespEstado As System.Windows.Forms.ComboBox
    Friend WithEvents lblRespEntidad As System.Windows.Forms.Label
    Friend WithEvents btnRespEnviar As System.Windows.Forms.Button
    Friend WithEvents btnRespBuscar As System.Windows.Forms.Button
    Friend WithEvents txtRespObservac As System.Windows.Forms.TextBox
    Friend WithEvents lblComEstado As System.Windows.Forms.Label
    Friend WithEvents lblComFecha As System.Windows.Forms.Label
    Friend WithEvents lblComCategoria As System.Windows.Forms.Label
    Friend WithEvents lblComAyN As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cbxMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents cbxPertenece As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBuscador As System.Windows.Forms.TextBox
    Public WithEvents spcTodo As System.Windows.Forms.SplitContainer
    Public WithEvents lblContacto As Label
    Public WithEvents gbxComunicacion As GroupBox
    Public WithEvents lblIniciadaPor As Label
    Friend WithEvents cbxRespMotivo As Telerik.WinControls.UI.RadDropDownList
End Class
