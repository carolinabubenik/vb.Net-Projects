<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComunicacion
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComunicacion))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cbxtEstado = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblVencimiento = New System.Windows.Forms.Label()
        Me.dtpVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblContacto = New System.Windows.Forms.Label()
        Me.cbxCategComunic = New System.Windows.Forms.ComboBox()
        Me.lblEntidadComunic = New System.Windows.Forms.Label()
        Me.gbLnComunic = New System.Windows.Forms.GroupBox()
        Me.cbxMotivo = New Telerik.WinControls.UI.RadDropDownList()
        Me.spcDialogo = New System.Windows.Forms.SplitContainer()
        Me.spcObservaciones = New System.Windows.Forms.SplitContainer()
        Me.txtObservFijas = New System.Windows.Forms.TextBox()
        Me.cbxSucursal = New System.Windows.Forms.ComboBox()
        Me.lblEntidadDialogo = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.chkContacto = New System.Windows.Forms.CheckBox()
        Me.dgvEntidades = New System.Windows.Forms.DataGridView()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pbxStar4 = New System.Windows.Forms.PictureBox()
        Me.pbxStar3 = New System.Windows.Forms.PictureBox()
        Me.pbxStar1 = New System.Windows.Forms.PictureBox()
        Me.pbxStar2 = New System.Windows.Forms.PictureBox()
        Me.lblValoracion = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.gbLnComunic.SuspendLayout()
        CType(Me.cbxMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spcDialogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcDialogo.Panel1.SuspendLayout()
        Me.spcDialogo.Panel2.SuspendLayout()
        Me.spcDialogo.SuspendLayout()
        CType(Me.spcObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcObservaciones.Panel1.SuspendLayout()
        Me.spcObservaciones.Panel2.SuspendLayout()
        Me.spcObservaciones.SuspendLayout()
        CType(Me.dgvEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(333, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Estado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Motivo:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(481, 392)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(562, 392)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'cbxtEstado
        '
        Me.cbxtEstado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxtEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxtEstado.FormattingEnabled = True
        Me.cbxtEstado.Location = New System.Drawing.Point(389, 48)
        Me.cbxtEstado.Name = "cbxtEstado"
        Me.cbxtEstado.Size = New System.Drawing.Size(224, 21)
        Me.cbxtEstado.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lblVencimiento)
        Me.GroupBox1.Controls.Add(Me.dtpVencimiento)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblContacto)
        Me.GroupBox1.Controls.Add(Me.cbxCategComunic)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbxtEstado)
        Me.GroupBox1.Controls.Add(Me.lblEntidadComunic)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 104)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comunicación"
        '
        'lblVencimiento
        '
        Me.lblVencimiento.AutoSize = True
        Me.lblVencimiento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVencimiento.ForeColor = System.Drawing.Color.White
        Me.lblVencimiento.Location = New System.Drawing.Point(11, 81)
        Me.lblVencimiento.Name = "lblVencimiento"
        Me.lblVencimiento.Size = New System.Drawing.Size(81, 13)
        Me.lblVencimiento.TabIndex = 174
        Me.lblVencimiento.Text = "Vencimiento:"
        '
        'dtpVencimiento
        '
        Me.dtpVencimiento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimiento.Location = New System.Drawing.Point(97, 77)
        Me.dtpVencimiento.Name = "dtpVencimiento"
        Me.dtpVencimiento.Size = New System.Drawing.Size(95, 21)
        Me.dtpVencimiento.TabIndex = 173
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Iniciada por:"
        '
        'lblContacto
        '
        Me.lblContacto.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContacto.ForeColor = System.Drawing.Color.White
        Me.lblContacto.Location = New System.Drawing.Point(11, 25)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.Size = New System.Drawing.Size(80, 13)
        Me.lblContacto.TabIndex = 16
        Me.lblContacto.Text = "Contacto:"
        Me.lblContacto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbxCategComunic
        '
        Me.cbxCategComunic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxCategComunic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategComunic.FormattingEnabled = True
        Me.cbxCategComunic.Location = New System.Drawing.Point(97, 48)
        Me.cbxCategComunic.Name = "cbxCategComunic"
        Me.cbxCategComunic.Size = New System.Drawing.Size(221, 21)
        Me.cbxCategComunic.TabIndex = 15
        '
        'lblEntidadComunic
        '
        Me.lblEntidadComunic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEntidadComunic.AutoEllipsis = True
        Me.lblEntidadComunic.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntidadComunic.ForeColor = System.Drawing.Color.White
        Me.lblEntidadComunic.Location = New System.Drawing.Point(97, 25)
        Me.lblEntidadComunic.Name = "lblEntidadComunic"
        Me.lblEntidadComunic.Size = New System.Drawing.Size(515, 13)
        Me.lblEntidadComunic.TabIndex = 7
        Me.lblEntidadComunic.Text = "Entidad comunicación"
        '
        'gbLnComunic
        '
        Me.gbLnComunic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbLnComunic.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gbLnComunic.Controls.Add(Me.cbxMotivo)
        Me.gbLnComunic.Controls.Add(Me.spcDialogo)
        Me.gbLnComunic.Controls.Add(Me.pbxStar4)
        Me.gbLnComunic.Controls.Add(Me.pbxStar3)
        Me.gbLnComunic.Controls.Add(Me.pbxStar1)
        Me.gbLnComunic.Controls.Add(Me.pbxStar2)
        Me.gbLnComunic.Controls.Add(Me.lblValoracion)
        Me.gbLnComunic.Controls.Add(Me.Label3)
        Me.gbLnComunic.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLnComunic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbLnComunic.Location = New System.Drawing.Point(10, 117)
        Me.gbLnComunic.Name = "gbLnComunic"
        Me.gbLnComunic.Size = New System.Drawing.Size(626, 266)
        Me.gbLnComunic.TabIndex = 21
        Me.gbLnComunic.TabStop = False
        Me.gbLnComunic.Text = "Diálogo"
        '
        'cbxMotivo
        '
        Me.cbxMotivo.Location = New System.Drawing.Point(69, 24)
        Me.cbxMotivo.Name = "cbxMotivo"
        Me.cbxMotivo.Size = New System.Drawing.Size(335, 20)
        Me.cbxMotivo.TabIndex = 213
        '
        'spcDialogo
        '
        Me.spcDialogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spcDialogo.Location = New System.Drawing.Point(14, 49)
        Me.spcDialogo.Name = "spcDialogo"
        Me.spcDialogo.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcDialogo.Panel1
        '
        Me.spcDialogo.Panel1.Controls.Add(Me.spcObservaciones)
        '
        'spcDialogo.Panel2
        '
        Me.spcDialogo.Panel2.Controls.Add(Me.dgvEntidades)
        Me.spcDialogo.Size = New System.Drawing.Size(599, 211)
        Me.spcDialogo.SplitterDistance = 146
        Me.spcDialogo.SplitterWidth = 8
        Me.spcDialogo.TabIndex = 212
        '
        'spcObservaciones
        '
        Me.spcObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcObservaciones.Location = New System.Drawing.Point(0, 0)
        Me.spcObservaciones.Name = "spcObservaciones"
        Me.spcObservaciones.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcObservaciones.Panel1
        '
        Me.spcObservaciones.Panel1.Controls.Add(Me.txtObservFijas)
        '
        'spcObservaciones.Panel2
        '
        Me.spcObservaciones.Panel2.Controls.Add(Me.cbxSucursal)
        Me.spcObservaciones.Panel2.Controls.Add(Me.lblEntidadDialogo)
        Me.spcObservaciones.Panel2.Controls.Add(Me.txtObservaciones)
        Me.spcObservaciones.Panel2.Controls.Add(Me.chkContacto)
        Me.spcObservaciones.Size = New System.Drawing.Size(599, 146)
        Me.spcObservaciones.SplitterDistance = 54
        Me.spcObservaciones.SplitterWidth = 8
        Me.spcObservaciones.TabIndex = 212
        '
        'txtObservFijas
        '
        Me.txtObservFijas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservFijas.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtObservFijas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservFijas.ForeColor = System.Drawing.Color.White
        Me.txtObservFijas.Location = New System.Drawing.Point(3, 3)
        Me.txtObservFijas.Multiline = True
        Me.txtObservFijas.Name = "txtObservFijas"
        Me.txtObservFijas.ReadOnly = True
        Me.txtObservFijas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservFijas.Size = New System.Drawing.Size(593, 48)
        Me.txtObservFijas.TabIndex = 151
        '
        'cbxSucursal
        '
        Me.cbxSucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSucursal.DropDownWidth = 300
        Me.cbxSucursal.FormattingEnabled = True
        Me.cbxSucursal.Location = New System.Drawing.Point(361, 56)
        Me.cbxSucursal.Name = "cbxSucursal"
        Me.cbxSucursal.Size = New System.Drawing.Size(235, 21)
        Me.cbxSucursal.TabIndex = 213
        '
        'lblEntidadDialogo
        '
        Me.lblEntidadDialogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEntidadDialogo.AutoEllipsis = True
        Me.lblEntidadDialogo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntidadDialogo.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lblEntidadDialogo.Location = New System.Drawing.Point(117, 60)
        Me.lblEntidadDialogo.Name = "lblEntidadDialogo"
        Me.lblEntidadDialogo.Size = New System.Drawing.Size(238, 13)
        Me.lblEntidadDialogo.TabIndex = 211
        Me.lblEntidadDialogo.Text = "Entidad diálogo"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtObservaciones.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.White
        Me.txtObservaciones.Location = New System.Drawing.Point(3, 3)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(593, 49)
        Me.txtObservaciones.TabIndex = 198
        '
        'chkContacto
        '
        Me.chkContacto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkContacto.AutoSize = True
        Me.chkContacto.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkContacto.ForeColor = System.Drawing.Color.White
        Me.chkContacto.Location = New System.Drawing.Point(3, 58)
        Me.chkContacto.Name = "chkContacto"
        Me.chkContacto.Size = New System.Drawing.Size(108, 17)
        Me.chkContacto.TabIndex = 212
        Me.chkContacto.Text = "Otro contacto:"
        Me.chkContacto.UseVisualStyleBackColor = True
        '
        'dgvEntidades
        '
        Me.dgvEntidades.AllowUserToAddRows = False
        Me.dgvEntidades.AllowUserToDeleteRows = False
        Me.dgvEntidades.AllowUserToResizeRows = False
        Me.dgvEntidades.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvEntidades.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEntidades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEntidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.apellido, Me.Datos})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEntidades.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEntidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEntidades.Location = New System.Drawing.Point(0, 0)
        Me.dgvEntidades.Name = "dgvEntidades"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEntidades.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvEntidades.RowHeadersVisible = False
        Me.dgvEntidades.Size = New System.Drawing.Size(599, 57)
        Me.dgvEntidades.TabIndex = 214
        '
        'apellido
        '
        Me.apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.apellido.DataPropertyName = "AyN"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.apellido.DefaultCellStyle = DataGridViewCellStyle2
        Me.apellido.HeaderText = "Apellido y Nombre"
        Me.apellido.Name = "apellido"
        Me.apellido.Width = 137
        '
        'Datos
        '
        Me.Datos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datos.DefaultCellStyle = DataGridViewCellStyle3
        Me.Datos.HeaderText = "Datos"
        Me.Datos.Name = "Datos"
        Me.Datos.Width = 65
        '
        'pbxStar4
        '
        Me.pbxStar4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxStar4.Image = modRecursos.My.Resources.Resources.star_off
        Me.pbxStar4.Location = New System.Drawing.Point(596, 22)
        Me.pbxStar4.Name = "pbxStar4"
        Me.pbxStar4.Size = New System.Drawing.Size(16, 16)
        Me.pbxStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxStar4.TabIndex = 208
        Me.pbxStar4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxStar4, "Muy Bueno")
        Me.pbxStar4.Visible = False
        '
        'pbxStar3
        '
        Me.pbxStar3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxStar3.Image = CType(resources.GetObject("pbxStar3.Image"), System.Drawing.Image)
        Me.pbxStar3.Location = New System.Drawing.Point(574, 22)
        Me.pbxStar3.Name = "pbxStar3"
        Me.pbxStar3.Size = New System.Drawing.Size(16, 16)
        Me.pbxStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxStar3.TabIndex = 209
        Me.pbxStar3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxStar3, "Bueno")
        Me.pbxStar3.Visible = False
        '
        'pbxStar1
        '
        Me.pbxStar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxStar1.Image = modRecursos.My.Resources.Resources.star_on
        Me.pbxStar1.Location = New System.Drawing.Point(530, 22)
        Me.pbxStar1.Name = "pbxStar1"
        Me.pbxStar1.Size = New System.Drawing.Size(16, 16)
        Me.pbxStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxStar1.TabIndex = 206
        Me.pbxStar1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxStar1, "Malo")
        Me.pbxStar1.Visible = False
        '
        'pbxStar2
        '
        Me.pbxStar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxStar2.Image = CType(resources.GetObject("pbxStar2.Image"), System.Drawing.Image)
        Me.pbxStar2.Location = New System.Drawing.Point(552, 22)
        Me.pbxStar2.Name = "pbxStar2"
        Me.pbxStar2.Size = New System.Drawing.Size(16, 16)
        Me.pbxStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxStar2.TabIndex = 207
        Me.pbxStar2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxStar2, "Regular")
        Me.pbxStar2.Visible = False
        '
        'lblValoracion
        '
        Me.lblValoracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValoracion.AutoSize = True
        Me.lblValoracion.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValoracion.ForeColor = System.Drawing.Color.White
        Me.ErrorProvider1.SetIconAlignment(Me.lblValoracion, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.lblValoracion.Location = New System.Drawing.Point(452, 25)
        Me.lblValoracion.Name = "lblValoracion"
        Me.lblValoracion.Size = New System.Drawing.Size(71, 13)
        Me.lblValoracion.TabIndex = 20
        Me.lblValoracion.Text = "Valoración:"
        Me.lblValoracion.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmComunicacion
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(646, 427)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbLnComunic)
        Me.Controls.Add(Me.btnAceptar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmComunicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de la Comunicación:"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbLnComunic.ResumeLayout(False)
        Me.gbLnComunic.PerformLayout()
        CType(Me.cbxMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcDialogo.Panel1.ResumeLayout(False)
        Me.spcDialogo.Panel2.ResumeLayout(False)
        CType(Me.spcDialogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcDialogo.ResumeLayout(False)
        Me.spcObservaciones.Panel1.ResumeLayout(False)
        Me.spcObservaciones.Panel1.PerformLayout()
        Me.spcObservaciones.Panel2.ResumeLayout(False)
        Me.spcObservaciones.Panel2.PerformLayout()
        CType(Me.spcObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcObservaciones.ResumeLayout(False)
        CType(Me.dgvEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button


    Friend WithEvents cbxtEstado As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbLnComunic As System.Windows.Forms.GroupBox
    Friend WithEvents lblContacto As System.Windows.Forms.Label
    Friend WithEvents cbxCategComunic As System.Windows.Forms.ComboBox
    Friend WithEvents lblValoracion As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblEntidadComunic As System.Windows.Forms.Label
    Friend WithEvents pbxStar4 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pbxStar3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStar1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxStar2 As System.Windows.Forms.PictureBox
    Friend WithEvents spcDialogo As System.Windows.Forms.SplitContainer
    Friend WithEvents spcObservaciones As System.Windows.Forms.SplitContainer
    Friend WithEvents txtObservFijas As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblEntidadDialogo As System.Windows.Forms.Label
    Friend WithEvents cbxSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents dgvEntidades As System.Windows.Forms.DataGridView
    Friend WithEvents chkContacto As System.Windows.Forms.CheckBox
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Datos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblVencimiento As Label
    Friend WithEvents dtpVencimiento As DateTimePicker
    Friend WithEvents cbxMotivo As Telerik.WinControls.UI.RadDropDownList
End Class
