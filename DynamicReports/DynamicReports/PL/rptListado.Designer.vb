Partial Class rptListado

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.txtTitulo = New Telerik.Reporting.TextBox()
        Me.picLogoEmpresa = New Telerik.Reporting.PictureBox()
        Me.txtFecha = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = New Telerik.Reporting.Drawing.Unit(2.7999999523162842R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtTitulo, Me.picLogoEmpresa, Me.txtFecha})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(6.000300407409668R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.400199830532074R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(7.7996997833251953R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.7998000383377075R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.txtTitulo.Style.Font.Bold = true
        Me.txtTitulo.Style.Font.Italic = true
        Me.txtTitulo.Style.Font.Name = "Courier New"
        Me.txtTitulo.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(15R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.txtTitulo.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtTitulo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtTitulo.Value = "Listado"
        '
        'picLogoEmpresa
        '
        Me.picLogoEmpresa.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0.00010012308484874666R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.picLogoEmpresa.Name = "picLogoEmpresa"
        Me.picLogoEmpresa.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(6R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(2.6000001430511475R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.picLogoEmpresa.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
        Me.picLogoEmpresa.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.picLogoEmpresa.Style.Padding.Bottom = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.picLogoEmpresa.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.picLogoEmpresa.Style.Padding.Right = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.picLogoEmpresa.Style.Padding.Top = New Telerik.Reporting.Drawing.Unit(0.20000000298023224R, Telerik.Reporting.Drawing.UnitType.Cm)
        '
        'txtFecha
        '
        Me.txtFecha.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Top Or Telerik.Reporting.AnchoringStyles.Right),Telerik.Reporting.AnchoringStyles)
        Me.txtFecha.Format = "{0}"
        Me.txtFecha.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(13.614367485046387R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(5.38543176651001R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.40000000596046448R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.txtFecha.Style.Font.Bold = true
        Me.txtFecha.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(8R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.txtFecha.Value = "Fecha de Impresión :"
        '
        'detail
        '
        Me.detail.Height = New Telerik.Reporting.Drawing.Unit(5R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.detail.Name = "detail"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = New Telerik.Reporting.Drawing.Unit(0.41156724095344543R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.pageFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox4})
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(New Telerik.Reporting.Drawing.Unit(0R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.10000035166740418R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(18.999799728393555R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(0.31156688928604126R, Telerik.Reporting.Drawing.UnitType.Cm))
        Me.TextBox4.Style.Font.Size = New Telerik.Reporting.Drawing.Unit(7R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.Value = "= ""Página : ""  + PageNumber + "" de "" + PageCount"
        '
        'rptListado
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.PageSettings.Landscape = false
        Me.PageSettings.Margins.Bottom = New Telerik.Reporting.Drawing.Unit(10R, Telerik.Reporting.Drawing.UnitType.Mm)
        Me.PageSettings.Margins.Left = New Telerik.Reporting.Drawing.Unit(10R, Telerik.Reporting.Drawing.UnitType.Mm)
        Me.PageSettings.Margins.Right = New Telerik.Reporting.Drawing.Unit(10R, Telerik.Reporting.Drawing.UnitType.Mm)
        Me.PageSettings.Margins.Top = New Telerik.Reporting.Drawing.Unit(10R, Telerik.Reporting.Drawing.UnitType.Mm)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = New Telerik.Reporting.Drawing.Unit(2R, Telerik.Reporting.Drawing.UnitType.Point)
        StyleRule1.Style.Padding.Right = New Telerik.Reporting.Drawing.Unit(2R, Telerik.Reporting.Drawing.UnitType.Point)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = New Telerik.Reporting.Drawing.Unit(18.999898910522461R, Telerik.Reporting.Drawing.UnitType.Cm)
        Me.Name = "rptListado"
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents txtTitulo As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents picLogoEmpresa As Telerik.Reporting.PictureBox
    Friend WithEvents txtFecha As Telerik.Reporting.TextBox
End Class