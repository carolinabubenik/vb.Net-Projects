<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListados))
        Me.ReportViewer1 = New Telerik.ReportViewer.WinForms.ReportViewer()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.spcIzq = New System.Windows.Forms.SplitContainer()
        Me.pnlAutorizacion = New System.Windows.Forms.Panel()
        Me.lblTitAutorizacion = New System.Windows.Forms.Label()
        Me.lklUsuarios = New System.Windows.Forms.LinkLabel()
        Me.lblAutorizacion = New System.Windows.Forms.Label()
        Me.lklCrearAutorizacion = New System.Windows.Forms.LinkLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ttp = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        CType(Me.spcIzq,System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcIzq.Panel1.SuspendLayout
        Me.spcIzq.Panel2.SuspendLayout
        Me.spcIzq.SuspendLayout
        Me.pnlAutorizacion.SuspendLayout
        Me.SuspendLayout
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Resources.AllFiles = "Todos los archivos"
        Me.ReportViewer1.Resources.BackToolTip = "Navegue hacia atrás en la historia"
        Me.ReportViewer1.Resources.CurrentPageToolTip = "Página actual"
        Me.ReportViewer1.Resources.DocumentMapToolTip = "Haga clic para cerrar el documento mapa | Haga clic para abrir documento de mapa"
        Me.ReportViewer1.Resources.FirstPageToolTip = "Primera página"
        Me.ReportViewer1.Resources.ForwardToolTip = "Navegue hacia adelante en la historia"
        Me.ReportViewer1.Resources.GenericMessageBoxCaption = "Visor de informes"
        Me.ReportViewer1.Resources.LabelOf = "de"
        Me.ReportViewer1.Resources.LastPageToolTip = "Última página"
        Me.ReportViewer1.Resources.MissingReportSource = "No se ha especificado el origen de la definición de informe."
        Me.ReportViewer1.Resources.NextPageToolTip = "Proxima pagina."
        Me.ReportViewer1.Resources.NoPageToDisplay = "No página para mostrar."
        Me.ReportViewer1.Resources.PageSetupToolTip = "Opciones de pagina..."
        Me.ReportViewer1.Resources.ParametersToolTip = "Haga clic para cerrar el área de parámetros | Haga clic para abrir el área de par"& _ 
    "ámetros"
        Me.ReportViewer1.Resources.PreviousPageToolTip = "Pagina anterior"
        Me.ReportViewer1.Resources.PrintToolTip = "Imprimir Reporte"
        Me.ReportViewer1.Resources.ProcessingReportMessage = "Generando reporte..."
        Me.ReportViewer1.Resources.RefreshToolTip = "Actualizar"
        Me.ReportViewer1.Resources.ReportParametersEmptyStringError = "Valor de cadena vacío no permitido."
        Me.ReportViewer1.Resources.ReportParametersInputDataError = "Por favor, los datos de entrada para todos los parámetros."
        Me.ReportViewer1.Resources.ReportParametersInvalidValueText = "Valor invalido"
        Me.ReportViewer1.Resources.ReportParametersNoValueText = "Requiere un valor"
        Me.ReportViewer1.Resources.ReportParametersNullText = "No Aplicar"
        Me.ReportViewer1.Resources.ReportParametersPreviewButtonText = "Buscar"
        Me.ReportViewer1.Resources.ReportParametersSelectAllText = "Seleccionar Todos"
        Me.ReportViewer1.Resources.StopProcessing = "El procesamiento de informes se canceló."
        Me.ReportViewer1.Resources.StopToolTip = "Parar"
        Me.ReportViewer1.Resources.TotalPagesToolTip = "Total paginas"
        Me.ReportViewer1.Resources.ZoomToPageWidth = "Ancho de página"
        Me.ReportViewer1.Resources.ZoomToWholePage = "Toda la página"
        Me.ReportViewer1.Size = New System.Drawing.Size(563, 556)
        Me.ReportViewer1.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelar.Location = New System.Drawing.Point(109, 387)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = false
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAceptar.Location = New System.Drawing.Point(20, 387)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(82, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = false
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.spcIzq)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 562)
        Me.SplitContainer1.SplitterDistance = 222
        Me.SplitContainer1.TabIndex = 11
        '
        'spcIzq
        '
        Me.spcIzq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcIzq.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.spcIzq.IsSplitterFixed = true
        Me.spcIzq.Location = New System.Drawing.Point(0, 0)
        Me.spcIzq.Name = "spcIzq"
        Me.spcIzq.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcIzq.Panel1
        '
        Me.spcIzq.Panel1.Controls.Add(Me.btnCancelar)
        Me.spcIzq.Panel1.Controls.Add(Me.btnAceptar)
        '
        'spcIzq.Panel2
        '
        Me.spcIzq.Panel2.Controls.Add(Me.pnlAutorizacion)
        Me.spcIzq.Size = New System.Drawing.Size(222, 562)
        Me.spcIzq.SplitterDistance = 413
        Me.spcIzq.SplitterWidth = 8
        Me.spcIzq.TabIndex = 12
        '
        'pnlAutorizacion
        '
        Me.pnlAutorizacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.pnlAutorizacion.Controls.Add(Me.lblTitAutorizacion)
        Me.pnlAutorizacion.Controls.Add(Me.lklUsuarios)
        Me.pnlAutorizacion.Controls.Add(Me.lblAutorizacion)
        Me.pnlAutorizacion.Controls.Add(Me.lklCrearAutorizacion)
        Me.pnlAutorizacion.Location = New System.Drawing.Point(3, 3)
        Me.pnlAutorizacion.Name = "pnlAutorizacion"
        Me.pnlAutorizacion.Size = New System.Drawing.Size(215, 119)
        Me.pnlAutorizacion.TabIndex = 11
        '
        'lblTitAutorizacion
        '
        Me.lblTitAutorizacion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitAutorizacion.AutoSize = true
        Me.lblTitAutorizacion.Location = New System.Drawing.Point(24, 2)
        Me.lblTitAutorizacion.Name = "lblTitAutorizacion"
        Me.lblTitAutorizacion.Size = New System.Drawing.Size(169, 13)
        Me.lblTitAutorizacion.TabIndex = 3
        Me.lblTitAutorizacion.Text = "Autorización para Impresión"
        '
        'lklUsuarios
        '
        Me.lklUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lklUsuarios.AutoSize = true
        Me.lklUsuarios.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lklUsuarios.Location = New System.Drawing.Point(117, 99)
        Me.lklUsuarios.Name = "lklUsuarios"
        Me.lklUsuarios.Size = New System.Drawing.Size(92, 12)
        Me.lklUsuarios.TabIndex = 2
        Me.lklUsuarios.TabStop = true
        Me.lklUsuarios.Text = "Asignar Usuarios"
        '
        'lblAutorizacion
        '
        Me.lblAutorizacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblAutorizacion.AutoEllipsis = true
        Me.lblAutorizacion.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblAutorizacion.Location = New System.Drawing.Point(3, 20)
        Me.lblAutorizacion.Name = "lblAutorizacion"
        Me.lblAutorizacion.Size = New System.Drawing.Size(209, 74)
        Me.lblAutorizacion.TabIndex = 1
        Me.lblAutorizacion.Text = "(Crear Autorización...)"
        Me.lblAutorizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lklCrearAutorizacion
        '
        Me.lklCrearAutorizacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.lklCrearAutorizacion.AutoSize = true
        Me.lklCrearAutorizacion.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lklCrearAutorizacion.Location = New System.Drawing.Point(2, 99)
        Me.lklCrearAutorizacion.Name = "lklCrearAutorizacion"
        Me.lklCrearAutorizacion.Size = New System.Drawing.Size(99, 12)
        Me.lklCrearAutorizacion.TabIndex = 0
        Me.lklCrearAutorizacion.TabStop = true
        Me.lklCrearAutorizacion.Tag = "CREAR"
        Me.lklCrearAutorizacion.Text = "Crear Autorización"
        '
        'FrmListados
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.Name = "FrmListados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.spcIzq.Panel1.ResumeLayout(false)
        Me.spcIzq.Panel2.ResumeLayout(false)
        CType(Me.spcIzq,System.ComponentModel.ISupportInitialize).EndInit
        Me.spcIzq.ResumeLayout(false)
        Me.pnlAutorizacion.ResumeLayout(false)
        Me.pnlAutorizacion.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Protected WithEvents ReportViewer1 As Telerik.ReportViewer.WinForms.ReportViewer
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Protected WithEvents btnAceptar As System.Windows.Forms.Button
    Protected WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnlAutorizacion As Panel
    Friend WithEvents lklUsuarios As LinkLabel
    Friend WithEvents lblAutorizacion As Label
    Friend WithEvents lklCrearAutorizacion As LinkLabel
    Friend WithEvents lblTitAutorizacion As Label
    Friend WithEvents ttp As ToolTip
    Protected Friend WithEvents spcIzq As SplitContainer
End Class
