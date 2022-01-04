<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListado))
        Me.spcTodo = New System.Windows.Forms.SplitContainer()
        Me.tsBuscar = New System.Windows.Forms.ToolStrip()
        Me.lblBuscar = New System.Windows.Forms.ToolStripLabel()
        Me.txtNombreBus = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre_alias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSentencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAdicionales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsListado = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnModificar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.gbxListado = New System.Windows.Forms.GroupBox()
        Me.tbcListado = New System.Windows.Forms.TabControl()
        Me.tbpSentencia = New System.Windows.Forms.TabPage()
        Me.btnSenRefrescar = New System.Windows.Forms.Button()
        Me.txtSentencia = New System.Windows.Forms.RichTextBox()
        Me.cmsSentencia = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblSenInfo = New System.Windows.Forms.Label()
        Me.pbxSenInfo = New System.Windows.Forms.PictureBox()
        Me.tbpColumnas = New System.Windows.Forms.TabPage()
        Me.lblColInfo = New System.Windows.Forms.Label()
        Me.pbxColInfo = New System.Windows.Forms.PictureBox()
        Me.btnColBajar = New System.Windows.Forms.Button()
        Me.btnColSubir = New System.Windows.Forms.Button()
        Me.gbxColumna = New System.Windows.Forms.GroupBox()
        Me.rbtColContabiliza = New System.Windows.Forms.RadioButton()
        Me.rbtColTotaliza = New System.Windows.Forms.RadioButton()
        Me.btnColCancelar = New System.Windows.Forms.Button()
        Me.btnColAgregar = New System.Windows.Forms.Button()
        Me.chkColAgrupa = New System.Windows.Forms.CheckBox()
        Me.chkColVisible = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtColNombre = New System.Windows.Forms.TextBox()
        Me.txtColAlias = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvColumnas = New System.Windows.Forms.DataGridView()
        Me.colColOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColAlias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColVisible = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colColTotaliza = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colColContabiliza = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colColAgrupaFila = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cmsColumna = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnColModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnColEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbpCondiciones = New System.Windows.Forms.TabPage()
        Me.btnParBajar = New System.Windows.Forms.Button()
        Me.btnParSubir = New System.Windows.Forms.Button()
        Me.pbxCondInfo = New System.Windows.Forms.PictureBox()
        Me.lblCondInfo = New System.Windows.Forms.Label()
        Me.pbxParInfo = New System.Windows.Forms.PictureBox()
        Me.lblParInfo = New System.Windows.Forms.Label()
        Me.gbxCondicion = New System.Windows.Forms.GroupBox()
        Me.chkParVisible = New System.Windows.Forms.CheckBox()
        Me.spcParDefecto = New System.Windows.Forms.SplitContainer()
        Me.cbxParDefecto = New System.Windows.Forms.ComboBox()
        Me.txtParDefecto = New System.Windows.Forms.TextBox()
        Me.cbxParTipo = New System.Windows.Forms.ComboBox()
        Me.btnParCancelar = New System.Windows.Forms.Button()
        Me.btnParAgregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtParNombre = New System.Windows.Forms.TextBox()
        Me.txtParAlias = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvParametros = New System.Windows.Forms.DataGridView()
        Me.colParNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colParAlias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colParTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colParDefecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colParVisible = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colParObligatorio = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colParCondiciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsParametro = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnParModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnParEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnParAgregarCondicion = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnParModificarCond = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnParEliminarCond = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblnombre_alias = New System.Windows.Forms.Label()
        Me.txtNombre_alias = New System.Windows.Forms.TextBox()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.spcTodo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcTodo.Panel1.SuspendLayout
        Me.spcTodo.Panel2.SuspendLayout
        Me.spcTodo.SuspendLayout
        Me.tsBuscar.SuspendLayout
        CType(Me.dgvListado,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tsListado.SuspendLayout
        Me.gbxListado.SuspendLayout
        Me.tbcListado.SuspendLayout
        Me.tbpSentencia.SuspendLayout
        CType(Me.pbxSenInfo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tbpColumnas.SuspendLayout
        CType(Me.pbxColInfo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbxColumna.SuspendLayout
        CType(Me.dgvColumnas,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsColumna.SuspendLayout
        Me.tbpCondiciones.SuspendLayout
        CType(Me.pbxCondInfo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbxParInfo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbxCondicion.SuspendLayout
        CType(Me.spcParDefecto,System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcParDefecto.Panel1.SuspendLayout
        Me.spcParDefecto.Panel2.SuspendLayout
        Me.spcParDefecto.SuspendLayout
        CType(Me.dgvParametros,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsParametro.SuspendLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'spcTodo
        '
        Me.spcTodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcTodo.Location = New System.Drawing.Point(0, 0)
        Me.spcTodo.Name = "spcTodo"
        Me.spcTodo.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcTodo.Panel1
        '
        Me.spcTodo.Panel1.Controls.Add(Me.tsBuscar)
        Me.spcTodo.Panel1.Controls.Add(Me.dgvListado)
        '
        'spcTodo.Panel2
        '
        Me.spcTodo.Panel2.Controls.Add(Me.tsListado)
        Me.spcTodo.Panel2.Controls.Add(Me.gbxListado)
        Me.spcTodo.Size = New System.Drawing.Size(624, 561)
        Me.spcTodo.SplitterDistance = 142
        Me.spcTodo.SplitterWidth = 8
        Me.spcTodo.TabIndex = 0
        '
        'tsBuscar
        '
        Me.tsBuscar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsBuscar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsBuscar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblBuscar, Me.txtNombreBus, Me.btnBuscar})
        Me.tsBuscar.Location = New System.Drawing.Point(0, 0)
        Me.tsBuscar.Name = "tsBuscar"
        Me.tsBuscar.Size = New System.Drawing.Size(624, 25)
        Me.tsBuscar.TabIndex = 0
        '
        'lblBuscar
        '
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(45, 22)
        Me.lblBuscar.Text = "Buscar:"
        '
        'txtNombreBus
        '
        Me.txtNombreBus.AutoSize = false
        Me.txtNombreBus.Name = "txtNombreBus"
        Me.txtNombreBus.Size = New System.Drawing.Size(300, 23)
        '
        'btnBuscar
        '
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(23, 22)
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = false
        Me.dgvListado.AllowUserToDeleteRows = false
        Me.dgvListado.AllowUserToResizeRows = false
        Me.dgvListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colNombre, Me.colNombre_alias, Me.colDescripcion, Me.colSentencia, Me.colAdicionales})
        Me.dgvListado.Location = New System.Drawing.Point(10, 28)
        Me.dgvListado.MultiSelect = false
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = true
        Me.dgvListado.RowHeadersVisible = false
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(604, 111)
        Me.dgvListado.TabIndex = 1
        '
        'colId
        '
        Me.colId.DataPropertyName = "id"
        Me.colId.HeaderText = "Id"
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        Me.colId.Width = 42
        '
        'colNombre
        '
        Me.colNombre.DataPropertyName = "nombre"
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        Me.colNombre.Width = 76
        '
        'colNombre_alias
        '
        Me.colNombre_alias.DataPropertyName = "nombre_alias"
        Me.colNombre_alias.HeaderText = "Nombre_alias"
        Me.colNombre_alias.Name = "colNombre_alias"
        Me.colNombre_alias.ReadOnly = True
        Me.colNombre_alias.Width = 104
        '
        'colDescripcion
        '
        Me.colDescripcion.DataPropertyName = "descripcion"
        Me.colDescripcion.HeaderText = "Descripción"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.ReadOnly = True
        Me.colDescripcion.Width = 94
        '
        'colSentencia
        '
        Me.colSentencia.DataPropertyName = "sentencia"
        Me.colSentencia.HeaderText = "Sentencia"
        Me.colSentencia.Name = "colSentencia"
        Me.colSentencia.ReadOnly = True
        Me.colSentencia.Width = 83
        '
        'colAdicionales
        '
        Me.colAdicionales.DataPropertyName = "adicionales"
        Me.colAdicionales.HeaderText = "Adicionales"
        Me.colAdicionales.Name = "colAdicionales"
        Me.colAdicionales.ReadOnly = True
        Me.colAdicionales.Width = 93
        '
        'tsListado
        '
        Me.tsListado.AutoSize = False
        Me.tsListado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsListado.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsListado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnModificar, Me.btnEliminar, Me.btnGuardar, Me.btnCancelar})
        Me.tsListado.Location = New System.Drawing.Point(0, 0)
        Me.tsListado.Name = "tsListado"
        Me.tsListado.Size = New System.Drawing.Size(624, 25)
        Me.tsListado.TabIndex = 0
        '
        'btnNuevo
        '
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(46, 22)
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.ToolTipText = "Nuevo"
        '
        'btnModificar
        '
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(62, 22)
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.ToolTipText = "Modificar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(54, 22)
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.ToolTipText = "Eliminar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(53, 22)
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.ToolTipText = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(57, 22)
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipText = "Cancelar"
        '
        'gbxListado
        '
        Me.gbxListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxListado.Controls.Add(Me.tbcListado)
        Me.gbxListado.Controls.Add(Me.lblnombre)
        Me.gbxListado.Controls.Add(Me.txtNombre)
        Me.gbxListado.Controls.Add(Me.lblnombre_alias)
        Me.gbxListado.Controls.Add(Me.txtNombre_alias)
        Me.gbxListado.Controls.Add(Me.lbldescripcion)
        Me.gbxListado.Controls.Add(Me.txtDescripcion)
        Me.gbxListado.Location = New System.Drawing.Point(10, 35)
        Me.gbxListado.Name = "gbxListado"
        Me.gbxListado.Size = New System.Drawing.Size(604, 364)
        Me.gbxListado.TabIndex = 1
        Me.gbxListado.TabStop = False
        Me.gbxListado.Text = "Listado"
        '
        'tbcListado
        '
        Me.tbcListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcListado.Controls.Add(Me.tbpSentencia)
        Me.tbcListado.Controls.Add(Me.tbpColumnas)
        Me.tbcListado.Controls.Add(Me.tbpCondiciones)
        Me.tbcListado.Location = New System.Drawing.Point(6, 76)
        Me.tbcListado.Name = "tbcListado"
        Me.tbcListado.SelectedIndex = 0
        Me.tbcListado.Size = New System.Drawing.Size(592, 282)
        Me.tbcListado.TabIndex = 6
        '
        'tbpSentencia
        '
        Me.tbpSentencia.Controls.Add(Me.btnSenRefrescar)
        Me.tbpSentencia.Controls.Add(Me.txtSentencia)
        Me.tbpSentencia.Controls.Add(Me.lblSenInfo)
        Me.tbpSentencia.Controls.Add(Me.pbxSenInfo)
        Me.tbpSentencia.Location = New System.Drawing.Point(4, 24)
        Me.tbpSentencia.Name = "tbpSentencia"
        Me.tbpSentencia.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSentencia.Size = New System.Drawing.Size(584, 254)
        Me.tbpSentencia.TabIndex = 0
        Me.tbpSentencia.Text = "Sentencia SQL"
        Me.tbpSentencia.UseVisualStyleBackColor = True
        '
        'btnSenRefrescar
        '
        Me.btnSenRefrescar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSenRefrescar.Location = New System.Drawing.Point(554, 22)
        Me.btnSenRefrescar.Name = "btnSenRefrescar"
        Me.btnSenRefrescar.Size = New System.Drawing.Size(24, 24)
        Me.btnSenRefrescar.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.btnSenRefrescar, "Refrescar Sentencia")
        Me.btnSenRefrescar.UseVisualStyleBackColor = True
        '
        'txtSentencia
        '
        Me.txtSentencia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSentencia.ContextMenuStrip = Me.cmsSentencia
        Me.txtSentencia.Location = New System.Drawing.Point(6, 49)
        Me.txtSentencia.Name = "txtSentencia"
        Me.txtSentencia.Size = New System.Drawing.Size(572, 199)
        Me.txtSentencia.TabIndex = 20
        Me.txtSentencia.Text = ""
        '
        'cmsSentencia
        '
        Me.cmsSentencia.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsSentencia.Name = "cmsSentencia"
        Me.cmsSentencia.Size = New System.Drawing.Size(61, 4)
        '
        'lblSenInfo
        '
        Me.lblSenInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSenInfo.AutoEllipsis = True
        Me.lblSenInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSenInfo.Location = New System.Drawing.Point(22, 5)
        Me.lblSenInfo.Name = "lblSenInfo"
        Me.lblSenInfo.Size = New System.Drawing.Size(533, 41)
        Me.lblSenInfo.TabIndex = 19
        Me.lblSenInfo.Text = resources.GetString("lblSenInfo.Text")
        Me.lblSenInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxSenInfo
        '
        Me.pbxSenInfo.Location = New System.Drawing.Point(4, 13)
        Me.pbxSenInfo.Name = "pbxSenInfo"
        Me.pbxSenInfo.Size = New System.Drawing.Size(17, 17)
        Me.pbxSenInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSenInfo.TabIndex = 18
        Me.pbxSenInfo.TabStop = False
        '
        'tbpColumnas
        '
        Me.tbpColumnas.Controls.Add(Me.lblColInfo)
        Me.tbpColumnas.Controls.Add(Me.pbxColInfo)
        Me.tbpColumnas.Controls.Add(Me.btnColBajar)
        Me.tbpColumnas.Controls.Add(Me.btnColSubir)
        Me.tbpColumnas.Controls.Add(Me.gbxColumna)
        Me.tbpColumnas.Controls.Add(Me.dgvColumnas)
        Me.tbpColumnas.Location = New System.Drawing.Point(4, 24)
        Me.tbpColumnas.Name = "tbpColumnas"
        Me.tbpColumnas.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpColumnas.Size = New System.Drawing.Size(584, 269)
        Me.tbpColumnas.TabIndex = 1
        Me.tbpColumnas.Text = "Columnas"
        Me.tbpColumnas.UseVisualStyleBackColor = True
        '
        'lblColInfo
        '
        Me.lblColInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblColInfo.AutoEllipsis = True
        Me.lblColInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblColInfo.Location = New System.Drawing.Point(22, 8)
        Me.lblColInfo.Name = "lblColInfo"
        Me.lblColInfo.Size = New System.Drawing.Size(550, 30)
        Me.lblColInfo.TabIndex = 11
        Me.lblColInfo.Text = resources.GetString("lblColInfo.Text")
        Me.lblColInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxColInfo
        '
        Me.pbxColInfo.Location = New System.Drawing.Point(4, 13)
        Me.pbxColInfo.Name = "pbxColInfo"
        Me.pbxColInfo.Size = New System.Drawing.Size(17, 17)
        Me.pbxColInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxColInfo.TabIndex = 10
        Me.pbxColInfo.TabStop = False
        '
        'btnColBajar
        '
        Me.btnColBajar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnColBajar.Location = New System.Drawing.Point(5, 196)
        Me.btnColBajar.Name = "btnColBajar"
        Me.btnColBajar.Size = New System.Drawing.Size(26, 26)
        Me.btnColBajar.TabIndex = 7
        Me.btnColBajar.UseVisualStyleBackColor = True
        '
        'btnColSubir
        '
        Me.btnColSubir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnColSubir.Location = New System.Drawing.Point(5, 164)
        Me.btnColSubir.Name = "btnColSubir"
        Me.btnColSubir.Size = New System.Drawing.Size(26, 26)
        Me.btnColSubir.TabIndex = 7
        Me.btnColSubir.UseVisualStyleBackColor = True
        '
        'gbxColumna
        '
        Me.gbxColumna.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxColumna.Controls.Add(Me.rbtColContabiliza)
        Me.gbxColumna.Controls.Add(Me.rbtColTotaliza)
        Me.gbxColumna.Controls.Add(Me.btnColCancelar)
        Me.gbxColumna.Controls.Add(Me.btnColAgregar)
        Me.gbxColumna.Controls.Add(Me.chkColAgrupa)
        Me.gbxColumna.Controls.Add(Me.chkColVisible)
        Me.gbxColumna.Controls.Add(Me.Label1)
        Me.gbxColumna.Controls.Add(Me.txtColNombre)
        Me.gbxColumna.Controls.Add(Me.txtColAlias)
        Me.gbxColumna.Controls.Add(Me.Label2)
        Me.gbxColumna.Location = New System.Drawing.Point(6, 41)
        Me.gbxColumna.Name = "gbxColumna"
        Me.gbxColumna.Size = New System.Drawing.Size(572, 72)
        Me.gbxColumna.TabIndex = 6
        Me.gbxColumna.TabStop = False
        Me.gbxColumna.Text = "Columna"
        '
        'rbtColContabiliza
        '
        Me.rbtColContabiliza.AutoSize = True
        Me.rbtColContabiliza.Location = New System.Drawing.Point(188, 48)
        Me.rbtColContabiliza.Name = "rbtColContabiliza"
        Me.rbtColContabiliza.Size = New System.Drawing.Size(84, 19)
        Me.rbtColContabiliza.TabIndex = 4
        Me.rbtColContabiliza.TabStop = True
        Me.rbtColContabiliza.Text = "Contabiliza"
        Me.rbtColContabiliza.UseVisualStyleBackColor = True
        '
        'rbtColTotaliza
        '
        Me.rbtColTotaliza.AutoSize = True
        Me.rbtColTotaliza.Location = New System.Drawing.Point(120, 48)
        Me.rbtColTotaliza.Name = "rbtColTotaliza"
        Me.rbtColTotaliza.Size = New System.Drawing.Size(64, 19)
        Me.rbtColTotaliza.TabIndex = 3
        Me.rbtColTotaliza.TabStop = True
        Me.rbtColTotaliza.Text = "Totaliza"
        Me.rbtColTotaliza.UseVisualStyleBackColor = True
        '
        'btnColCancelar
        '
        Me.btnColCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnColCancelar.Location = New System.Drawing.Point(533, 39)
        Me.btnColCancelar.Name = "btnColCancelar"
        Me.btnColCancelar.Size = New System.Drawing.Size(27, 27)
        Me.btnColCancelar.TabIndex = 7
        Me.btnColCancelar.UseVisualStyleBackColor = True
        '
        'btnColAgregar
        '
        Me.btnColAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnColAgregar.Location = New System.Drawing.Point(533, 11)
        Me.btnColAgregar.Name = "btnColAgregar"
        Me.btnColAgregar.Size = New System.Drawing.Size(27, 27)
        Me.btnColAgregar.TabIndex = 6
        Me.btnColAgregar.UseVisualStyleBackColor = True
        '
        'chkColAgrupa
        '
        Me.chkColAgrupa.AutoSize = True
        Me.chkColAgrupa.Location = New System.Drawing.Point(270, 49)
        Me.chkColAgrupa.Name = "chkColAgrupa"
        Me.chkColAgrupa.Size = New System.Drawing.Size(86, 19)
        Me.chkColAgrupa.TabIndex = 5
        Me.chkColAgrupa.Text = "Agrupa Fila"
        Me.ToolTip1.SetToolTip(Me.chkColAgrupa, "Marcar para indicar que el campo pemite identificar cada fila en el reporte")
        Me.chkColAgrupa.UseVisualStyleBackColor = True
        '
        'chkColVisible
        '
        Me.chkColVisible.AutoSize = True
        Me.chkColVisible.Location = New System.Drawing.Point(58, 49)
        Me.chkColVisible.Name = "chkColVisible"
        Me.chkColVisible.Size = New System.Drawing.Size(60, 19)
        Me.chkColVisible.TabIndex = 2
        Me.chkColVisible.Text = "Visible"
        Me.ToolTip1.SetToolTip(Me.chkColVisible, "Marcar para que la columna aparezca en el reporte")
        Me.chkColVisible.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label1, "Nombre del campo devuelto en la sentencia SELECT. No lleva prefijo. No puede repe" &
        "tirse en el reporte.")
        '
        'txtColNombre
        '
        Me.txtColNombre.Location = New System.Drawing.Point(59, 19)
        Me.txtColNombre.Name = "txtColNombre"
        Me.txtColNombre.Size = New System.Drawing.Size(128, 23)
        Me.txtColNombre.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtColNombre, "Nombre del campo devuelto en la sentencia SELECT. No lleva prefijo. No puede repe" &
        "tirse en el reporte.")
        '
        'txtColAlias
        '
        Me.txtColAlias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtColAlias.Location = New System.Drawing.Point(231, 19)
        Me.txtColAlias.Name = "txtColAlias"
        Me.txtColAlias.Size = New System.Drawing.Size(279, 23)
        Me.txtColAlias.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtColAlias, "Texto que se mostrará al usuario como título de la columna")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Alias:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label2, "Texto que se mostrará al usuario como título de la columna")
        '
        'dgvColumnas
        '
        Me.dgvColumnas.AllowUserToAddRows = False
        Me.dgvColumnas.AllowUserToDeleteRows = False
        Me.dgvColumnas.AllowUserToResizeRows = False
        Me.dgvColumnas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvColumnas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvColumnas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colColOrden, Me.colColNombre, Me.colColAlias, Me.colColVisible, Me.colColTotaliza, Me.colColContabiliza, Me.colColAgrupaFila})
        Me.dgvColumnas.ContextMenuStrip = Me.cmsColumna
        Me.dgvColumnas.Location = New System.Drawing.Point(35, 119)
        Me.dgvColumnas.MultiSelect = False
        Me.dgvColumnas.Name = "dgvColumnas"
        Me.dgvColumnas.ReadOnly = True
        Me.dgvColumnas.RowHeadersVisible = False
        Me.dgvColumnas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvColumnas.Size = New System.Drawing.Size(543, 147)
        Me.dgvColumnas.TabIndex = 5
        '
        'colColOrden
        '
        Me.colColOrden.DataPropertyName = "orden"
        Me.colColOrden.HeaderText = "Orden"
        Me.colColOrden.Name = "colColOrden"
        Me.colColOrden.ReadOnly = True
        Me.colColOrden.Visible = False
        Me.colColOrden.Width = 61
        '
        'colColNombre
        '
        Me.colColNombre.DataPropertyName = "nombre"
        Me.colColNombre.HeaderText = "Nombre"
        Me.colColNombre.Name = "colColNombre"
        Me.colColNombre.ReadOnly = True
        Me.colColNombre.Width = 76
        '
        'colColAlias
        '
        Me.colColAlias.DataPropertyName = "nombre_alias"
        Me.colColAlias.HeaderText = "Alias"
        Me.colColAlias.Name = "colColAlias"
        Me.colColAlias.ReadOnly = True
        Me.colColAlias.ToolTipText = "Texto a mostrar"
        Me.colColAlias.Width = 57
        '
        'colColVisible
        '
        Me.colColVisible.DataPropertyName = "vVisibleAdic"
        Me.colColVisible.HeaderText = "Visible"
        Me.colColVisible.Name = "colColVisible"
        Me.colColVisible.ReadOnly = True
        Me.colColVisible.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colColVisible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colColVisible.Width = 66
        '
        'colColTotaliza
        '
        Me.colColTotaliza.DataPropertyName = "vTotalizaAdic"
        Me.colColTotaliza.HeaderText = "Totaliza"
        Me.colColTotaliza.Name = "colColTotaliza"
        Me.colColTotaliza.ReadOnly = True
        Me.colColTotaliza.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colColTotaliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colColTotaliza.Width = 71
        '
        'colColContabiliza
        '
        Me.colColContabiliza.DataPropertyName = "vContabilizaAdic"
        Me.colColContabiliza.HeaderText = "Contabiliza"
        Me.colColContabiliza.Name = "colColContabiliza"
        Me.colColContabiliza.ReadOnly = True
        Me.colColContabiliza.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colColContabiliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colColContabiliza.Width = 91
        '
        'colColAgrupaFila
        '
        Me.colColAgrupaFila.DataPropertyName = "vAgrupaFilaAdic"
        Me.colColAgrupaFila.HeaderText = "Agrupa Fila"
        Me.colColAgrupaFila.Name = "colColAgrupaFila"
        Me.colColAgrupaFila.ReadOnly = True
        Me.colColAgrupaFila.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colColAgrupaFila.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colColAgrupaFila.Width = 92
        '
        'cmsColumna
        '
        Me.cmsColumna.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsColumna.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnColModificar, Me.btnColEliminar})
        Me.cmsColumna.Name = "cmsColumna"
        Me.cmsColumna.Size = New System.Drawing.Size(126, 48)
        '
        'btnColModificar
        '
        Me.btnColModificar.Name = "btnColModificar"
        Me.btnColModificar.Size = New System.Drawing.Size(125, 22)
        Me.btnColModificar.Text = "Modificar"
        '
        'btnColEliminar
        '
        Me.btnColEliminar.Name = "btnColEliminar"
        Me.btnColEliminar.Size = New System.Drawing.Size(125, 22)
        Me.btnColEliminar.Text = "Eliminar"
        '
        'tbpCondiciones
        '
        Me.tbpCondiciones.Controls.Add(Me.btnParBajar)
        Me.tbpCondiciones.Controls.Add(Me.btnParSubir)
        Me.tbpCondiciones.Controls.Add(Me.pbxCondInfo)
        Me.tbpCondiciones.Controls.Add(Me.lblCondInfo)
        Me.tbpCondiciones.Controls.Add(Me.pbxParInfo)
        Me.tbpCondiciones.Controls.Add(Me.lblParInfo)
        Me.tbpCondiciones.Controls.Add(Me.gbxCondicion)
        Me.tbpCondiciones.Controls.Add(Me.dgvParametros)
        Me.tbpCondiciones.Location = New System.Drawing.Point(4, 24)
        Me.tbpCondiciones.Name = "tbpCondiciones"
        Me.tbpCondiciones.Size = New System.Drawing.Size(584, 269)
        Me.tbpCondiciones.TabIndex = 2
        Me.tbpCondiciones.Text = "Parámetros y Condiciones"
        Me.tbpCondiciones.UseVisualStyleBackColor = True
        '
        'btnParBajar
        '
        Me.btnParBajar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnParBajar.Location = New System.Drawing.Point(5, 184)
        Me.btnParBajar.Name = "btnParBajar"
        Me.btnParBajar.Size = New System.Drawing.Size(26, 26)
        Me.btnParBajar.TabIndex = 12
        Me.btnParBajar.UseVisualStyleBackColor = True
        '
        'btnParSubir
        '
        Me.btnParSubir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnParSubir.Location = New System.Drawing.Point(5, 152)
        Me.btnParSubir.Name = "btnParSubir"
        Me.btnParSubir.Size = New System.Drawing.Size(26, 26)
        Me.btnParSubir.TabIndex = 13
        Me.btnParSubir.UseVisualStyleBackColor = True
        '
        'pbxCondInfo
        '
        Me.pbxCondInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbxCondInfo.Location = New System.Drawing.Point(6, 242)
        Me.pbxCondInfo.Name = "pbxCondInfo"
        Me.pbxCondInfo.Size = New System.Drawing.Size(17, 17)
        Me.pbxCondInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCondInfo.TabIndex = 11
        Me.pbxCondInfo.TabStop = False
        '
        'lblCondInfo
        '
        Me.lblCondInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCondInfo.AutoEllipsis = True
        Me.lblCondInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCondInfo.Location = New System.Drawing.Point(25, 239)
        Me.lblCondInfo.Name = "lblCondInfo"
        Me.lblCondInfo.Size = New System.Drawing.Size(553, 28)
        Me.lblCondInfo.TabIndex = 10
        Me.lblCondInfo.Text = "Las condiciones deben contener los conectores lógicos necesarios, como AND u OR y" &
    "a que si se omiten, se sustituyen por completo de la sentencia SQL."
        '
        'pbxParInfo
        '
        Me.pbxParInfo.Location = New System.Drawing.Point(4, 13)
        Me.pbxParInfo.Name = "pbxParInfo"
        Me.pbxParInfo.Size = New System.Drawing.Size(17, 17)
        Me.pbxParInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxParInfo.TabIndex = 9
        Me.pbxParInfo.TabStop = False
        '
        'lblParInfo
        '
        Me.lblParInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblParInfo.AutoEllipsis = True
        Me.lblParInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblParInfo.Location = New System.Drawing.Point(22, 8)
        Me.lblParInfo.Name = "lblParInfo"
        Me.lblParInfo.Size = New System.Drawing.Size(550, 30)
        Me.lblParInfo.TabIndex = 8
        Me.lblParInfo.Text = "Los parámetros estarán disponibles para que el usuario indique su valor. Para que" &
    " el parámetro sea opcional, debe cargar condiciones (serán reemplazadas en la se" &
    "ntencia SQL)."
        Me.lblParInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbxCondicion
        '
        Me.gbxCondicion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxCondicion.Controls.Add(Me.chkParVisible)
        Me.gbxCondicion.Controls.Add(Me.spcParDefecto)
        Me.gbxCondicion.Controls.Add(Me.cbxParTipo)
        Me.gbxCondicion.Controls.Add(Me.btnParCancelar)
        Me.gbxCondicion.Controls.Add(Me.btnParAgregar)
        Me.gbxCondicion.Controls.Add(Me.Label5)
        Me.gbxCondicion.Controls.Add(Me.Label3)
        Me.gbxCondicion.Controls.Add(Me.txtParNombre)
        Me.gbxCondicion.Controls.Add(Me.txtParAlias)
        Me.gbxCondicion.Controls.Add(Me.Label6)
        Me.gbxCondicion.Controls.Add(Me.Label4)
        Me.gbxCondicion.Location = New System.Drawing.Point(6, 41)
        Me.gbxCondicion.Name = "gbxCondicion"
        Me.gbxCondicion.Size = New System.Drawing.Size(572, 72)
        Me.gbxCondicion.TabIndex = 7
        Me.gbxCondicion.TabStop = False
        Me.gbxCondicion.Text = "Parámetros"
        '
        'chkParVisible
        '
        Me.chkParVisible.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkParVisible.AutoSize = True
        Me.chkParVisible.Location = New System.Drawing.Point(450, 21)
        Me.chkParVisible.Name = "chkParVisible"
        Me.chkParVisible.Size = New System.Drawing.Size(60, 19)
        Me.chkParVisible.TabIndex = 13
        Me.chkParVisible.Text = "Visible"
        Me.ToolTip1.SetToolTip(Me.chkParVisible, "Marcar para que la columna aparezca en el reporte")
        Me.chkParVisible.UseVisualStyleBackColor = True
        '
        'spcParDefecto
        '
        Me.spcParDefecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spcParDefecto.Location = New System.Drawing.Point(256, 42)
        Me.spcParDefecto.Name = "spcParDefecto"
        '
        'spcParDefecto.Panel1
        '
        Me.spcParDefecto.Panel1.Controls.Add(Me.cbxParDefecto)
        '
        'spcParDefecto.Panel2
        '
        Me.spcParDefecto.Panel2.Controls.Add(Me.txtParDefecto)
        Me.spcParDefecto.Size = New System.Drawing.Size(254, 26)
        Me.spcParDefecto.SplitterDistance = 91
        Me.spcParDefecto.SplitterWidth = 8
        Me.spcParDefecto.TabIndex = 3
        '
        'cbxParDefecto
        '
        Me.cbxParDefecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxParDefecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxParDefecto.FormattingEnabled = True
        Me.cbxParDefecto.Location = New System.Drawing.Point(3, 3)
        Me.cbxParDefecto.Name = "cbxParDefecto"
        Me.cbxParDefecto.Size = New System.Drawing.Size(85, 23)
        Me.cbxParDefecto.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cbxParDefecto, "Sólo algunos valores por defecto son válidos según el tipo de parámetro")
        '
        'txtParDefecto
        '
        Me.txtParDefecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtParDefecto.Location = New System.Drawing.Point(3, 4)
        Me.txtParDefecto.Name = "txtParDefecto"
        Me.txtParDefecto.Size = New System.Drawing.Size(145, 23)
        Me.txtParDefecto.TabIndex = 0
        '
        'cbxParTipo
        '
        Me.cbxParTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxParTipo.FormattingEnabled = True
        Me.cbxParTipo.Location = New System.Drawing.Point(60, 46)
        Me.cbxParTipo.Name = "cbxParTipo"
        Me.cbxParTipo.Size = New System.Drawing.Size(127, 23)
        Me.cbxParTipo.TabIndex = 2
        '
        'btnParCancelar
        '
        Me.btnParCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnParCancelar.Location = New System.Drawing.Point(533, 39)
        Me.btnParCancelar.Name = "btnParCancelar"
        Me.btnParCancelar.Size = New System.Drawing.Size(27, 27)
        Me.btnParCancelar.TabIndex = 5
        Me.btnParCancelar.UseVisualStyleBackColor = True
        '
        'btnParAgregar
        '
        Me.btnParAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnParAgregar.Location = New System.Drawing.Point(533, 11)
        Me.btnParAgregar.Name = "btnParAgregar"
        Me.btnParAgregar.Size = New System.Drawing.Size(27, 27)
        Me.btnParAgregar.TabIndex = 4
        Me.btnParAgregar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label3, "Nombre que identifica al parámetro. No puede repetirse en el reporte.")
        '
        'txtParNombre
        '
        Me.txtParNombre.Location = New System.Drawing.Point(59, 19)
        Me.txtParNombre.Name = "txtParNombre"
        Me.txtParNombre.Size = New System.Drawing.Size(128, 23)
        Me.txtParNombre.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtParNombre, "Nombre que identifica al parámetro. No puede repetirse en el reporte.")
        '
        'txtParAlias
        '
        Me.txtParAlias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtParAlias.Location = New System.Drawing.Point(231, 19)
        Me.txtParAlias.Name = "txtParAlias"
        Me.txtParAlias.Size = New System.Drawing.Size(217, 23)
        Me.txtParAlias.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtParAlias, "Texto que se mostrará en pantalla al usuario")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(193, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Por defecto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(193, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Alias:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label4, "Texto que se mostrará en pantalla al usuario")
        '
        'dgvParametros
        '
        Me.dgvParametros.AllowUserToAddRows = False
        Me.dgvParametros.AllowUserToDeleteRows = False
        Me.dgvParametros.AllowUserToResizeRows = False
        Me.dgvParametros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvParametros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvParametros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colParNombre, Me.colParAlias, Me.colParTipo, Me.colParDefecto, Me.colParVisible, Me.colParObligatorio, Me.colParCondiciones})
        Me.dgvParametros.ContextMenuStrip = Me.cmsParametro
        Me.dgvParametros.Location = New System.Drawing.Point(35, 119)
        Me.dgvParametros.MultiSelect = False
        Me.dgvParametros.Name = "dgvParametros"
        Me.dgvParametros.ReadOnly = True
        Me.dgvParametros.RowHeadersVisible = False
        Me.dgvParametros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParametros.Size = New System.Drawing.Size(540, 117)
        Me.dgvParametros.TabIndex = 6
        '
        'colParNombre
        '
        Me.colParNombre.DataPropertyName = "nombre"
        Me.colParNombre.HeaderText = "Nombre"
        Me.colParNombre.Name = "colParNombre"
        Me.colParNombre.ReadOnly = True
        Me.colParNombre.Width = 76
        '
        'colParAlias
        '
        Me.colParAlias.DataPropertyName = "nombre_alias"
        Me.colParAlias.HeaderText = "Alias"
        Me.colParAlias.Name = "colParAlias"
        Me.colParAlias.ReadOnly = True
        Me.colParAlias.Width = 57
        '
        'colParTipo
        '
        Me.colParTipo.DataPropertyName = "tipo"
        Me.colParTipo.HeaderText = "Tipo"
        Me.colParTipo.Name = "colParTipo"
        Me.colParTipo.ReadOnly = True
        Me.colParTipo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colParTipo.Width = 55
        '
        'colParDefecto
        '
        Me.colParDefecto.DataPropertyName = "defecto"
        Me.colParDefecto.HeaderText = "Valor por Defecto"
        Me.colParDefecto.Name = "colParDefecto"
        Me.colParDefecto.ReadOnly = True
        Me.colParDefecto.Width = 123
        '
        'colParVisible
        '
        Me.colParVisible.DataPropertyName = "vVisibleAdic"
        Me.colParVisible.HeaderText = "Visible"
        Me.colParVisible.Name = "colParVisible"
        Me.colParVisible.ReadOnly = True
        Me.colParVisible.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colParVisible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colParVisible.Width = 66
        '
        'colParObligatorio
        '
        Me.colParObligatorio.DataPropertyName = "vObligatorio"
        Me.colParObligatorio.HeaderText = "Obligatorio"
        Me.colParObligatorio.Name = "colParObligatorio"
        Me.colParObligatorio.ReadOnly = True
        Me.colParObligatorio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colParObligatorio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colParObligatorio.Width = 92
        '
        'colParCondiciones
        '
        Me.colParCondiciones.DataPropertyName = "vCondiciones"
        Me.colParCondiciones.HeaderText = "Condiciones"
        Me.colParCondiciones.Name = "colParCondiciones"
        Me.colParCondiciones.ReadOnly = True
        Me.colParCondiciones.Width = 98
        '
        'cmsParametro
        '
        Me.cmsParametro.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsParametro.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnParModificar, Me.btnParEliminar, Me.btnParAgregarCondicion, Me.btnParModificarCond, Me.btnParEliminarCond})
        Me.cmsParametro.Name = "cmsCondicion"
        Me.cmsParametro.Size = New System.Drawing.Size(184, 114)
        '
        'btnParModificar
        '
        Me.btnParModificar.Name = "btnParModificar"
        Me.btnParModificar.Size = New System.Drawing.Size(183, 22)
        Me.btnParModificar.Text = "Modificar"
        '
        'btnParEliminar
        '
        Me.btnParEliminar.Name = "btnParEliminar"
        Me.btnParEliminar.Size = New System.Drawing.Size(183, 22)
        Me.btnParEliminar.Text = "Eliminar"
        '
        'btnParAgregarCondicion
        '
        Me.btnParAgregarCondicion.Name = "btnParAgregarCondicion"
        Me.btnParAgregarCondicion.Size = New System.Drawing.Size(183, 22)
        Me.btnParAgregarCondicion.Text = "Agregar Condición"
        '
        'btnParModificarCond
        '
        Me.btnParModificarCond.Name = "btnParModificarCond"
        Me.btnParModificarCond.Size = New System.Drawing.Size(183, 22)
        Me.btnParModificarCond.Text = "Modificar Condición"
        '
        'btnParEliminarCond
        '
        Me.btnParEliminarCond.Name = "btnParEliminarCond"
        Me.btnParEliminarCond.Size = New System.Drawing.Size(183, 22)
        Me.btnParEliminarCond.Text = "Eliminar Condición"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(29, 27)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(54, 15)
        Me.lblnombre.TabIndex = 10
        Me.lblnombre.Text = "Nombre:"
        Me.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblnombre, "Nombre único, no puede repetirse en otro listado")
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(82, 24)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(192, 23)
        Me.txtNombre.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtNombre, "Nombre único, no puede repetirse en otro listado")
        '
        'lblnombre_alias
        '
        Me.lblnombre_alias.AutoSize = True
        Me.lblnombre_alias.Location = New System.Drawing.Point(283, 27)
        Me.lblnombre_alias.Name = "lblnombre_alias"
        Me.lblnombre_alias.Size = New System.Drawing.Size(35, 15)
        Me.lblnombre_alias.TabIndex = 12
        Me.lblnombre_alias.Text = "Alias:"
        Me.lblnombre_alias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblnombre_alias, "Texto que se mostrará al usuario como título del reporte")
        '
        'txtNombre_alias
        '
        Me.txtNombre_alias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre_alias.Location = New System.Drawing.Point(321, 24)
        Me.txtNombre_alias.Name = "txtNombre_alias"
        Me.txtNombre_alias.Size = New System.Drawing.Size(273, 23)
        Me.txtNombre_alias.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtNombre_alias, "Texto que se mostrará al usuario como título del reporte")
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(10, 47)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(72, 15)
        Me.lbldescripcion.TabIndex = 14
        Me.lbldescripcion.Text = "Descripcion:"
        Me.lbldescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.Location = New System.Drawing.Point(82, 50)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(512, 23)
        Me.txtDescripcion.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtDescripcion, "Detalle de los datos o contenido del listado.")
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmListado
        '
        Me.ClientSize = New System.Drawing.Size(624, 561)
        Me.Controls.Add(Me.spcTodo)
        Me.Name = "FrmListado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Listados"
        Me.spcTodo.Panel1.ResumeLayout(false)
        Me.spcTodo.Panel1.PerformLayout
        Me.spcTodo.Panel2.ResumeLayout(false)
        CType(Me.spcTodo,System.ComponentModel.ISupportInitialize).EndInit
        Me.spcTodo.ResumeLayout(false)
        Me.tsBuscar.ResumeLayout(false)
        Me.tsBuscar.PerformLayout
        CType(Me.dgvListado,System.ComponentModel.ISupportInitialize).EndInit
        Me.tsListado.ResumeLayout(false)
        Me.tsListado.PerformLayout
        Me.gbxListado.ResumeLayout(false)
        Me.gbxListado.PerformLayout
        Me.tbcListado.ResumeLayout(false)
        Me.tbpSentencia.ResumeLayout(false)
        CType(Me.pbxSenInfo,System.ComponentModel.ISupportInitialize).EndInit
        Me.tbpColumnas.ResumeLayout(false)
        CType(Me.pbxColInfo,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbxColumna.ResumeLayout(false)
        Me.gbxColumna.PerformLayout
        CType(Me.dgvColumnas,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsColumna.ResumeLayout(false)
        Me.tbpCondiciones.ResumeLayout(false)
        CType(Me.pbxCondInfo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbxParInfo,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbxCondicion.ResumeLayout(false)
        Me.gbxCondicion.PerformLayout
        Me.spcParDefecto.Panel1.ResumeLayout(false)
        Me.spcParDefecto.Panel2.ResumeLayout(false)
        Me.spcParDefecto.Panel2.PerformLayout
        CType(Me.spcParDefecto,System.ComponentModel.ISupportInitialize).EndInit
        Me.spcParDefecto.ResumeLayout(false)
        CType(Me.dgvParametros,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsParametro.ResumeLayout(false)
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
Friend WithEvents spcTodo as System.Windows.Forms.SplitContainer
Friend WithEvents tsBuscar as System.Windows.Forms.ToolStrip
Friend WithEvents lblBuscar as System.Windows.Forms.ToolStripLabel
Friend WithEvents txtNombreBus as System.Windows.Forms.ToolStripTextBox
Friend WithEvents btnBuscar as System.Windows.Forms.ToolStripButton
Friend WithEvents dgvListado as System.Windows.Forms.DataGridView
Friend WithEvents tsListado as System.Windows.Forms.ToolStrip
Friend WithEvents btnNuevo as System.Windows.Forms.ToolStripButton
Friend WithEvents btnModificar as System.Windows.Forms.ToolStripButton
Friend WithEvents btnEliminar as System.Windows.Forms.ToolStripButton
Friend WithEvents btnGuardar as System.Windows.Forms.ToolStripButton
Friend WithEvents btnCancelar as System.Windows.Forms.ToolStripButton
Friend WithEvents gbxListado as System.Windows.Forms.GroupBox
Friend WithEvents lblnombre as System.Windows.Forms.Label
Friend WithEvents txtNombre as System.Windows.Forms.TextBox
Friend WithEvents lblnombre_alias as System.Windows.Forms.Label
Friend WithEvents txtNombre_alias as System.Windows.Forms.TextBox
Friend WithEvents lbldescripcion as System.Windows.Forms.Label
Friend WithEvents txtDescripcion as System.Windows.Forms.TextBox
    Friend WithEvents tbcListado As TabControl
    Friend WithEvents tbpSentencia As TabPage
    Friend WithEvents tbpColumnas As TabPage
    Friend WithEvents dgvColumnas As DataGridView
    Friend WithEvents tbpCondiciones As TabPage
    Friend WithEvents dgvParametros As DataGridView
    Friend WithEvents gbxColumna As GroupBox
    Friend WithEvents chkColAgrupa As CheckBox
    Friend WithEvents chkColVisible As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtColNombre As TextBox
    Friend WithEvents txtColAlias As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnColCancelar As Button
    Friend WithEvents btnColAgregar As Button
    Friend WithEvents gbxCondicion As GroupBox
    Friend WithEvents btnParCancelar As Button
    Friend WithEvents btnParAgregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtParNombre As TextBox
    Friend WithEvents txtParAlias As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxParTipo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtParDefecto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmsColumna As ContextMenuStrip
    Friend WithEvents cmsParametro As ContextMenuStrip
    Friend WithEvents btnColModificar As ToolStripMenuItem
    Friend WithEvents btnColEliminar As ToolStripMenuItem
    Friend WithEvents btnParModificar As ToolStripMenuItem
    Friend WithEvents btnParEliminar As ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblParInfo As Label
    Friend WithEvents btnParAgregarCondicion As ToolStripMenuItem
    Friend WithEvents btnParModificarCond As ToolStripMenuItem
    Friend WithEvents btnParEliminarCond As ToolStripMenuItem
    Friend WithEvents pbxParInfo As PictureBox
    Friend WithEvents lblColInfo As Label
    Friend WithEvents pbxColInfo As PictureBox
    Friend WithEvents lblSenInfo As Label
    Friend WithEvents pbxSenInfo As PictureBox
    Friend WithEvents spcParDefecto As SplitContainer
    Friend WithEvents cbxParDefecto As ComboBox
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colNombre As DataGridViewTextBoxColumn
    Friend WithEvents colNombre_alias As DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents colSentencia As DataGridViewTextBoxColumn
    Friend WithEvents colAdicionales As DataGridViewTextBoxColumn
    Friend WithEvents txtSentencia As RichTextBox
    Friend WithEvents cmsSentencia As ContextMenuStrip
    Friend WithEvents btnSenRefrescar As Button
    Friend WithEvents pbxCondInfo As PictureBox
    Friend WithEvents lblCondInfo As Label
    Friend WithEvents rbtColContabiliza As RadioButton
    Friend WithEvents rbtColTotaliza As RadioButton
    Friend WithEvents colColOrden As DataGridViewTextBoxColumn
    Friend WithEvents colColNombre As DataGridViewTextBoxColumn
    Friend WithEvents colColAlias As DataGridViewTextBoxColumn
    Friend WithEvents colColVisible As DataGridViewCheckBoxColumn
    Friend WithEvents colColTotaliza As DataGridViewCheckBoxColumn
    Friend WithEvents colColContabiliza As DataGridViewCheckBoxColumn
    Friend WithEvents colColAgrupaFila As DataGridViewCheckBoxColumn
    Friend WithEvents btnColBajar As Button
    Friend WithEvents btnColSubir As Button
    Friend WithEvents btnParBajar As Button
    Friend WithEvents btnParSubir As Button
    Friend WithEvents chkParVisible As CheckBox
    Friend WithEvents colParNombre As DataGridViewTextBoxColumn
    Friend WithEvents colParAlias As DataGridViewTextBoxColumn
    Friend WithEvents colParTipo As DataGridViewTextBoxColumn
    Friend WithEvents colParDefecto As DataGridViewTextBoxColumn
    Friend WithEvents colParVisible As DataGridViewCheckBoxColumn
    Friend WithEvents colParObligatorio As DataGridViewCheckBoxColumn
    Friend WithEvents colParCondiciones As DataGridViewTextBoxColumn
End Class

