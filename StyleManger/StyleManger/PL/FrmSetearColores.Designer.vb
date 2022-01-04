<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSetearColores
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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.spcTodo = New System.Windows.Forms.SplitContainer()
        Me.spcIzq = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvControles = New System.Windows.Forms.DataGridView()
        Me.colControlName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvPropiedades = New System.Windows.Forms.DataGridView()
        Me.colPropName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.lklQuitar = New System.Windows.Forms.LinkLabel()
        Me.lklGuardar = New System.Windows.Forms.LinkLabel()
        Me.pnlColor = New System.Windows.Forms.Panel()
        Me.lblPropiedad = New System.Windows.Forms.Label()
        Me.lblControl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.spcTodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcTodo.Panel1.SuspendLayout()
        Me.spcTodo.Panel2.SuspendLayout()
        Me.spcTodo.SuspendLayout()
        CType(Me.spcIzq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcIzq.Panel1.SuspendLayout()
        Me.spcIzq.Panel2.SuspendLayout()
        Me.spcIzq.SuspendLayout()
        CType(Me.dgvControles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPropiedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spcTodo
        '
        Me.spcTodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcTodo.Location = New System.Drawing.Point(0, 0)
        Me.spcTodo.Name = "spcTodo"
        '
        'spcTodo.Panel1
        '
        Me.spcTodo.Panel1.Controls.Add(Me.spcIzq)
        '
        'spcTodo.Panel2
        '
        Me.spcTodo.Panel2.Controls.Add(Me.pnlControl)
        Me.spcTodo.Panel2.Controls.Add(Me.lklQuitar)
        Me.spcTodo.Panel2.Controls.Add(Me.lklGuardar)
        Me.spcTodo.Panel2.Controls.Add(Me.pnlColor)
        Me.spcTodo.Panel2.Controls.Add(Me.lblPropiedad)
        Me.spcTodo.Panel2.Controls.Add(Me.lblControl)
        Me.spcTodo.Panel2.Controls.Add(Me.Label3)
        Me.spcTodo.Size = New System.Drawing.Size(691, 374)
        Me.spcTodo.SplitterDistance = 487
        Me.spcTodo.SplitterWidth = 8
        Me.spcTodo.TabIndex = 0
        '
        'spcIzq
        '
        Me.spcIzq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcIzq.Location = New System.Drawing.Point(0, 0)
        Me.spcIzq.Name = "spcIzq"
        '
        'spcIzq.Panel1
        '
        Me.spcIzq.Panel1.Controls.Add(Me.Label1)
        Me.spcIzq.Panel1.Controls.Add(Me.dgvControles)
        '
        'spcIzq.Panel2
        '
        Me.spcIzq.Panel2.Controls.Add(Me.Label2)
        Me.spcIzq.Panel2.Controls.Add(Me.dgvPropiedades)
        Me.spcIzq.Size = New System.Drawing.Size(487, 374)
        Me.spcIzq.SplitterDistance = 240
        Me.spcIzq.SplitterWidth = 8
        Me.spcIzq.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(11, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Controles:"
        '
        'dgvControles
        '
        Me.dgvControles.AllowUserToAddRows = False
        Me.dgvControles.AllowUserToDeleteRows = False
        Me.dgvControles.AllowUserToResizeRows = False
        Me.dgvControles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvControles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvControles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colControlName})
        Me.dgvControles.Location = New System.Drawing.Point(12, 33)
        Me.dgvControles.MultiSelect = False
        Me.dgvControles.Name = "dgvControles"
        Me.dgvControles.ReadOnly = True
        Me.dgvControles.RowHeadersVisible = False
        Me.dgvControles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvControles.Size = New System.Drawing.Size(225, 329)
        Me.dgvControles.TabIndex = 6
        '
        'colControlName
        '
        Me.colControlName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colControlName.DataPropertyName = "nombre"
        Me.colControlName.HeaderText = "Nombre"
        Me.colControlName.Name = "colControlName"
        Me.colControlName.ReadOnly = True
        Me.colControlName.Width = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(0, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Propiedades"
        '
        'dgvPropiedades
        '
        Me.dgvPropiedades.AllowUserToAddRows = False
        Me.dgvPropiedades.AllowUserToDeleteRows = False
        Me.dgvPropiedades.AllowUserToResizeRows = False
        Me.dgvPropiedades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPropiedades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPropName, Me.colColor})
        Me.dgvPropiedades.Location = New System.Drawing.Point(3, 33)
        Me.dgvPropiedades.MultiSelect = False
        Me.dgvPropiedades.Name = "dgvPropiedades"
        Me.dgvPropiedades.ReadOnly = True
        Me.dgvPropiedades.RowHeadersVisible = False
        Me.dgvPropiedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPropiedades.Size = New System.Drawing.Size(221, 329)
        Me.dgvPropiedades.TabIndex = 15
        '
        'colPropName
        '
        Me.colPropName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colPropName.DataPropertyName = "nombre"
        Me.colPropName.HeaderText = "Nombre"
        Me.colPropName.Name = "colPropName"
        Me.colPropName.ReadOnly = True
        Me.colPropName.Width = 69
        '
        'colColor
        '
        Me.colColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colColor.DataPropertyName = "valor"
        Me.colColor.HeaderText = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.ReadOnly = True
        Me.colColor.Width = 56
        '
        'pnlControl
        '
        Me.pnlControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlControl.Location = New System.Drawing.Point(3, 163)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(186, 208)
        Me.pnlControl.TabIndex = 29
        '
        'lklQuitar
        '
        Me.lklQuitar.AutoSize = True
        Me.lklQuitar.Location = New System.Drawing.Point(3, 135)
        Me.lklQuitar.Name = "lklQuitar"
        Me.lklQuitar.Size = New System.Drawing.Size(35, 13)
        Me.lklQuitar.TabIndex = 27
        Me.lklQuitar.TabStop = True
        Me.lklQuitar.Text = "Quitar"
        '
        'lklGuardar
        '
        Me.lklGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lklGuardar.AutoSize = True
        Me.lklGuardar.Location = New System.Drawing.Point(127, 135)
        Me.lklGuardar.Name = "lklGuardar"
        Me.lklGuardar.Size = New System.Drawing.Size(45, 13)
        Me.lklGuardar.TabIndex = 28
        Me.lklGuardar.TabStop = True
        Me.lklGuardar.Text = "Guardar"
        '
        'pnlColor
        '
        Me.pnlColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlColor.BackColor = System.Drawing.Color.Maroon
        Me.pnlColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlColor.Location = New System.Drawing.Point(141, 89)
        Me.pnlColor.Name = "pnlColor"
        Me.pnlColor.Size = New System.Drawing.Size(31, 31)
        Me.pnlColor.TabIndex = 26
        '
        'lblPropiedad
        '
        Me.lblPropiedad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPropiedad.AutoEllipsis = True
        Me.lblPropiedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropiedad.Location = New System.Drawing.Point(6, 89)
        Me.lblPropiedad.Name = "lblPropiedad"
        Me.lblPropiedad.Size = New System.Drawing.Size(129, 35)
        Me.lblPropiedad.TabIndex = 24
        Me.lblPropiedad.Text = "Propiedad:"
        Me.lblPropiedad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblControl
        '
        Me.lblControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblControl.AutoEllipsis = True
        Me.lblControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControl.Location = New System.Drawing.Point(3, 33)
        Me.lblControl.Name = "lblControl"
        Me.lblControl.Size = New System.Drawing.Size(169, 40)
        Me.lblControl.TabIndex = 25
        Me.lblControl.Text = "Control"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(3, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Color"
        '
        'FrmSetearColores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 374)
        Me.Controls.Add(Me.spcTodo)
        Me.Name = "FrmSetearColores"
        Me.Text = "Configurar Colores"
        Me.spcTodo.Panel1.ResumeLayout(False)
        Me.spcTodo.Panel2.ResumeLayout(False)
        Me.spcTodo.Panel2.PerformLayout()
        CType(Me.spcTodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcTodo.ResumeLayout(False)
        Me.spcIzq.Panel1.ResumeLayout(False)
        Me.spcIzq.Panel1.PerformLayout()
        Me.spcIzq.Panel2.ResumeLayout(False)
        Me.spcIzq.Panel2.PerformLayout()
        CType(Me.spcIzq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcIzq.ResumeLayout(False)
        CType(Me.dgvControles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPropiedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents spcTodo As System.Windows.Forms.SplitContainer
    Friend WithEvents spcIzq As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvControles As System.Windows.Forms.DataGridView
    Friend WithEvents colControlName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvPropiedades As System.Windows.Forms.DataGridView
    Friend WithEvents colPropName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colColor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lklQuitar As System.Windows.Forms.LinkLabel
    Friend WithEvents lklGuardar As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlColor As System.Windows.Forms.Panel
    Friend WithEvents lblPropiedad As System.Windows.Forms.Label
    Friend WithEvents lblControl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlControl As System.Windows.Forms.Panel
End Class
