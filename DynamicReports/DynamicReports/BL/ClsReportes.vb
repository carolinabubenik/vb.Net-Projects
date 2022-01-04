Imports System.Threading.Tasks
Imports modEntities
Imports Telerik.Reporting

Public Class ClsReportes
    Inherits ClsMain

    Public Sub New()

    End Sub
    ''' <summary>
    ''' Si se le pasa el Formulario, agrega el manejador del evento KeyDown para controlar el "F11" (ocultar controles prueba)
    ''' </summary>
    ''' <param name="frm"></param>
    Public Sub New(ByVal frm As Form)
        If frm IsNot Nothing Then
            AddHandler frm.KeyDown, AddressOf Frm_KeyDown
            erpError = New ErrorProvider(frm)
        End If
    End Sub

#Region "Propiedades"
    Public Shared filtrarPorHoraCaja As Boolean = "1" = parametro.GetValor("REPORTES DE CAJA POR HORA", "0", "1=Los reportes de caja se pueden filtrar por fecha y hora. 0=Se filtran solo por fecha.", ClsEnumerados.Acceso.TOTAL, "REPORTES,CAJA,VENTAS")

#End Region

#Region "Funciones"


    Public Shared Function getFiltrosSeleccionados(ByRef rpt As Telerik.Reporting.Report) As String
        Dim str = ""

        For Each par In rpt.ReportParameters
            If par.Value IsNot Nothing AndAlso par.Visible Then
                str &= par.Text & ": "
                If par.MultiValue Then
                    For Each v In par.Value 'Por cada opción seleccionada:

                        'Caro 10/07/2015: El split por la coma no afecta cuando es un valor común, único (sin coma); lo pongo porque lo necesito
                        '                 en ClsPropiedadProducto (se concatenan dos valores para identificar los registros).
                        Dim valor = CType(v, String).Split(",").Last 'Este es el "id", el valor que identifica al dato.

                        str &= getTextoParametro(valor, par)
                    Next

                Else
                    str &= getTextoParametro(par.Value, par) 'par.Value
                End If

                If str.EndsWith(",") Then str = str.Remove(str.Length - 1)
                str &= " - "

            End If
        Next

        If str.EndsWith(" - ") Then str = str.Remove(str.Length - 2)

        Return str

    End Function
    Private Shared Function getTextoParametro(ByVal valor As Object, ByVal par As Telerik.Reporting.ReportParameter) As String
        'Caro 10/07/2015: El split por la coma no afecta cuando es un valor común, único (sin coma); lo pongo porque lo necesito
        '                 en ClsPropiedadProducto (se concatenan dos valores para identificar los registros).

        Dim lst As IList = par.AvailableValues.DataSource 'Lista con todos los elementos del parámetro.
        'Aquí se recupera el texto asociado al valor seleccionado:
        Dim texto = (From t In lst
                     Where t.GetType.GetProperty(par.AvailableValues.ValueMember).GetValue(t, Nothing).ToString.Split(",").Last = valor
                     Select t.GetType.GetProperty(par.AvailableValues.DisplayMember).GetValue(t, Nothing))

        If texto.Count > 0 Then Return texto.First & ","
        Return ""
    End Function

    'Private Sub ProcesarConsulta(ReportBook As ReportBook, conciliado As Boolean, lstCliente As List(Of cliente), desde As Date, hasta As Date, sucursal As sucursal)
    '    Dim t As New Task(Sub()

    '                      End Sub)
    '    t.Start()
    '    'Mientras espero a que terminen de ejecutarse las consultas, itero la barra de progreso.
    '    While Not t.Status = TaskStatus.RanToCompletion
    '        Application.DoEvents()
    '    End While
    'End Sub
    Private frmBP As Form
    'Private Sub CargarBarraDeProgreso()
    '    'Barra de progreso
    '    Dim Pro = New ProgressBar
    '    Dim lbl As New Label
    '    lbl.Text = "Aguarde un instante por favor...."
    '    frmBP = modFunciones.FuncUtiles.FormularioProgreso(Pro, lbl)
    '    Pro.MarqueeAnimationSpeed = 30
    '    Pro.Style = ProgressBarStyle.Marquee
    '    frmBP.TopMost = True
    '    frmBP.Show()
    '    Application.DoEvents()
    'End Sub
    'Private Sub CerrarBarraDeProgreso()
    '    If frmBP IsNot Nothing Then
    '        frmBP.Close()
    '    End If
    'End Sub


    ''' <summary>
    ''' Genera un PDF del reporte indicado (ya instanciado) en la ruta indicada, o en la carpeta Temporal si se omite.
    ''' Devuelve la ruta y nombre del archivo creado, o un string vacío si no se pudo crear.
    ''' </summary>
    Public Shared Function ReporteToPDF(ByVal rpt As Report, Optional ByVal ruta As String = "", Optional ByVal abrir As Boolean = False, Optional nombreArchivo As String = "") As String

        Try

            Dim fileName As String = ""
            If Not String.IsNullOrWhiteSpace(nombreArchivo) Then
                fileName = nombreArchivo.Replace("/", "-").Replace(":", " ")
                rpt.DocumentName = fileName
            End If
            Dim result = ReporteToPDFResult(rpt, fileName)

            Dim path As String = System.IO.Path.GetTempPath()
            If Not String.IsNullOrWhiteSpace(ruta) Then path = ruta

            Dim filePath As String = System.IO.Path.Combine(path, fileName)

            Using fs As New System.IO.FileStream(filePath, System.IO.FileMode.Create)
                fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length)
            End Using

            If abrir Then
                Process.Start(filePath)
            End If

            Return filePath

        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Shared Function ReporteToPDFBytes(ByVal rpt As Report, Optional ByRef nombreArchivo As String = "", Optional ByVal mensajesPorConsola As Boolean = False) As Byte()

        'Dejamos como estaba antes al final 10-03-2020
        Dim result = ReporteToPDFResult(rpt, nombreArchivo)

        ''02-03-2020 ----------------------------
        'Dim result As Processing.RenderingResult
        'If mensajesPorConsola Then
        '    result = ReportToPDFResult(rpt, nombreArchivo, mensajesPorConsola)
        'Else
        '    result = ReportToPDFResult(rpt, nombreArchivo)
        'End If

        ''Verifica nuevamente que el archivo no contenga errores (Por si el usuario cancelo regenerarlo y retorno el reporte erroneo)
        'If result.HasErrors OrElse result.Extension <> "pdf" Then
        '    Return Nothing
        'Else
        '    Return result.DocumentBytes
        'End If
        '----------------------------------------

        Return result.DocumentBytes '10-03-2020

    End Function

    Public Shared Function ReporteToPDFResult(ByVal rpt As Report, Optional ByRef nombreArchivo As String = "") As Processing.RenderingResult

        Try

            Dim reportProcessor As New Telerik.Reporting.Processing.ReportProcessor()

            'set any deviceInfo settings if necessary
            Dim deviceInfo As New System.Collections.Hashtable()

            'Dim typeReportSource As New Telerik.Reporting.TypeReportSource()

            ' reportName is the Assembly Qualified Name of the report
            'typeReportSource.TypeName = rpt.Name 'nombreReporte


            'Dim result As Telerik.Reporting.Processing.RenderingResult = reportProcessor.RenderReport("PDF", typeReportSource, deviceInfo
            Dim result As Telerik.Reporting.Processing.RenderingResult = reportProcessor.RenderReport("PDF", rpt, deviceInfo)


            If nombreArchivo IsNot Nothing Then nombreArchivo = result.DocumentName '.Replace("/", "-").Replace(":", " ") + "." + result.Extension
            'Caro 2020-02-27: Mejoro esto porque funciona mal cuando el nombre tiene "comas" (ocurre con "apellido, nombre")
            'El problema es porque la coma es el separador de los "adicionales" y cuando se quiere leer el nombre del archivo de alli, sale cortado.
            'Si bien venia asi en el nombre del documento, lo cambio afuera para que se haga siempre la conversion.
            'Ademas, agrego la extension por si el nombre no la traía.
            nombreArchivo = nombreArchivo.Replace("/", "-").Replace(":", " ").Replace(",", " ")
            If Not nombreArchivo.ToUpper.EndsWith("." & result.Extension.ToUpper) Then nombreArchivo &= "." & result.Extension

            'Dim excepciones = result.Errors

            Return result


        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    '02-03-2020
    Public Shared Function ReportToPDFResult(ByVal rpt As Report, Optional ByRef nombreArchivo As String = "", Optional ByVal mensajesPorConsola As Boolean = False) As Processing.RenderingResult

        Dim reportProcessor As New Telerik.Reporting.Processing.ReportProcessor()
        Dim result As Telerik.Reporting.Processing.RenderingResult = reportProcessor.RenderReport("PDF", rpt, Nothing)

        If nombreArchivo IsNot Nothing Then nombreArchivo = result.DocumentName
        nombreArchivo = nombreArchivo.Replace("/", "-").Replace(":", " ").Replace(",", " ")
        If Not nombreArchivo.ToUpper.EndsWith("." & result.Extension.ToUpper) Then nombreArchivo &= "." & result.Extension

        If mensajesPorConsola Then 'Esto lo hago para Carrito (Mensajes por consola)
            Dim contador As Integer
            While result.HasErrors OrElse result.Extension <> "pdf"
                result = reportProcessor.RenderReport("PDF", rpt, Nothing)
                If nombreArchivo IsNot Nothing Then nombreArchivo = result.DocumentName
                nombreArchivo = nombreArchivo.Replace("/", "-").Replace(":", " ").Replace(",", " ")
                If Not nombreArchivo.ToUpper.EndsWith("." & result.Extension.ToUpper) Then nombreArchivo &= "." & result.Extension
                contador = +1
                If contador = 3 Then 'Que intente generar solo 3 veces
                    Exit While
                End If
            End While
        Else
            While (result.HasErrors OrElse result.Extension <> "pdf") AndAlso MessageBox.Show("No se pudo generar el reporte del comprobante. ¿Desea intentarlo de nuevo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes
                result = reportProcessor.RenderReport("PDF", rpt, Nothing)
                If nombreArchivo IsNot Nothing Then nombreArchivo = result.DocumentName
                nombreArchivo = nombreArchivo.Replace("/", "-").Replace(":", " ").Replace(",", " ")
                If Not nombreArchivo.ToUpper.EndsWith("." & result.Extension.ToUpper) Then nombreArchivo &= "." & result.Extension
            End While
        End If

        Return result

    End Function


    Public Shared Sub ImprimirDirecto(ByRef reporte As Telerik.Reporting.Report, ByVal NombreImpresora As String, ByVal cantCopias As Integer)
        'Si queda genérico, moverlo a modReportes..

        If String.IsNullOrWhiteSpace(NombreImpresora) Then
            MessageBox.Show("No se puede realizar la impresión: No está configurado cuál es la impresora.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim tmr As New Timer()
        tmr.Interval = 1000
        AddHandler tmr.Tick, AddressOf Tmr_Tick
        Dim frmP = modFunciones.FuncUtiles.CargarBarraDeProgreso($"Imprimiendo en: {NombreImpresora}.")
        tmr.Tag = frmP
        tmr.Start()

        ' Obtain the settings of the default printer
        Dim printerSettings As System.Drawing.Printing.PrinterSettings = New System.Drawing.Printing.PrinterSettings()

        printerSettings.PrinterName = NombreImpresora
        printerSettings.Copies = cantCopias
        printerSettings.Collate = False

        ' The standard print controller comes with no UI
        Dim standardPrintController As System.Drawing.Printing.PrintController = New System.Drawing.Printing.StandardPrintController()

        ' Print the report using the custom print controller
        Dim reportProcessor As Telerik.Reporting.Processing.ReportProcessor = New Telerik.Reporting.Processing.ReportProcessor()

        reportProcessor.PrintController = standardPrintController

        'Dim typeReportSource as Telerik.Reporting.TypeReportSource = New Telerik.Reporting.TypeReportSource()
        '' reportName Is the Assembly Qualified Name of the report
        'typeReportSource.TypeName = reportName;
        'reportProcessor.PrintReport(typeReportSource, printerSettings);


        'Caro 2021-12-24: Esta línea se había comentado en Trunk y por eso no se enviaba la impresión directa.
        reportProcessor.PrintReport(reporte, printerSettings) ' Forzamos el commit desde Development

        'modFunciones.FuncUtiles.CerrarBarraDeProgreso(frmP)
    End Sub
    Private Shared Sub Tmr_Tick(sender As Object, e As EventArgs)
        If sender IsNot Nothing AndAlso sender.GetType Is GetType(Timer) Then
            With CType(sender, Timer)
                If .Tag IsNot Nothing AndAlso .Tag.GetType Is GetType(Form) Then
                    modFunciones.FuncUtiles.CerrarBarraDeProgreso(.Tag)
                End If
                .Stop()
            End With
        End If
    End Sub
#End Region
#Region "Filtros"
    'Consideramos que Y ya viene con la posición donde se va a insertar el nuevo control, y luego de hacerlo se incrementa su valor.
    'Siempre se colocan en (X, Y) los controles; si es necesario desplazar, se hace asignando explícitamente el valor a X o a Y.
    Dim sepControles As Integer = 6 '25
    Dim sepLabel As Integer = 3 '7
    Dim tabIx As Integer = 0 'Para ir incrementando el tabIndex
    Dim erpError As New ErrorProvider

    '------------METODOS----------------------


    '------------------ GENÉRICOS

    Private Function AgregarLabel(ByRef X As Integer, ByRef Y As Integer, pnl As System.Windows.Forms.Panel, ByVal nombre As String, ByVal texto As String, Optional ByVal ocultar As Boolean = False) As Label
        Dim lbl As New Label
        With lbl
            .Name = nombre.Trim
            .Text = texto.Trim & IIf(Not texto.Trim.EndsWith(":"), ":", "")
            '.AutoSize = True
            .AutoSize = False
            .AutoEllipsis = True
            .Width = (pnl.Width - X - pnl.Padding.Right)
            .Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
            .TextAlign = ContentAlignment.BottomLeft
            .Location = New System.Drawing.Point(X, Y)
            .TabIndex = tabIx
            tabIx += 1

            pnl.Controls.Add(lbl)

            If ocultar Then
                .Visible = False
                lstControlesAOcultar.Add(lbl)
            End If

            Y += .Height + sepLabel 'Separar Label del Control
        End With
        Return lbl
    End Function
    Private Function CrearCombo(ByRef X As Integer, ByRef Y As Integer, pnl As System.Windows.Forms.Panel, ByVal nombre As String, ByVal valueMember As String, ByVal displayMember As String, ByVal lst As IList, Optional ByVal valorDef As Object = Nothing, Optional ByVal obligatorio As Boolean = True, Optional ByVal ocultar As Boolean = False) As ComboBox
        Dim cbx = New ComboBox
        With cbx
            .Name = nombre
            .Location = New System.Drawing.Point(X, Y)
            .Width = (pnl.Width - X - pnl.Padding.Right)
            .Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
            .DropDownStyle = ComboBoxStyle.DropDownList
            .DropDownWidth = (pnl.Width - X - pnl.Padding.Right)
            .ValueMember = valueMember
            .DisplayMember = displayMember
            .DataSource = lst
            .TabIndex = tabIx
            tabIx += 1

            pnl.Controls.Add(cbx) 'Debe ir antes de setear el SelectedValue
            If valorDef IsNot Nothing Then .SelectedValue = valorDef

            modFunciones.FuncUtiles.cbxAjustaAncho(cbx)

            Y += .Height + sepControles  'Separar este control del siguiente.

            If obligatorio Then AddHandler .Validating, AddressOf cbx_Validating

            If ocultar Then
                .Visible = False
                lstControlesAOcultar.Add(cbx)
            End If

        End With

        Return cbx

    End Function
    Private Function CrearComboTelerik(ByRef X As Integer, ByRef Y As Integer, pnl As System.Windows.Forms.Panel, ByVal nombre As String,
                                       ByVal valueMember As String, ByVal displayMember As String, ByVal lst As IList,
                                       Optional ByVal valorDef As Object = Nothing, Optional ByVal obligatorio As Boolean = False) _
                                       As Telerik.WinControls.UI.RadDropDownList
        Dim cbxRad As New Telerik.WinControls.UI.RadDropDownList
        With cbxRad
            .FormattingEnabled = True
            .Location = New System.Drawing.Point(X, Y)
            .Name = nombre
            '.Size = New System.Drawing.Size(155, 21)
            .Height = 21
            .Width = (pnl.Width - X - pnl.Padding.Right - 15) 'Alex 25-03-2018 reduci en 15 el combo para que entre el icono error
            .Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
            .ValueMember = valueMember
            .DisplayMember = displayMember
            .DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDownAndRightBottom
            .DataSource = lst
            .TabIndex = tabIx
            '.DropDownListElement.SelectionMode = SelectionMode.MultiExtended
            tabIx += 1

            'Matias. 08-06-2017  Aparentemente recién se puede asignar un valor después de agregarlo al panel
            'If valorDef IsNot Nothing Then .SelectedValue = valorDef       

            .AutoCompleteMode = AutoCompleteMode.Suggest
            .DropDownListElement.AutoCompleteSuggest = New modFunciones.CustomAutoCompleteSuggestHelper(cbxRad.DropDownListElement)
            .DropDownListElement.AutoCompleteSuggest.SuggestMode = Telerik.WinControls.UI.SuggestMode.Contains
            modFunciones.FuncUtiles.cbxAjustaAnchoLista(cbxRad)

            .Visible = True

            Y += .Height + sepControles  'Separar este control del siguiente.

            If obligatorio Then AddHandler .Validating, AddressOf rdl_Validating


        End With
        pnl.Controls.Add(cbxRad)

        'Matias. 08-06-2017  Aparentemente recién se puede asignar un valor después de agregarlo al panel
        If valorDef IsNot Nothing Then cbxRad.SelectedValue = valorDef

        Return cbxRad
    End Function

    Private Function CrearCheckedComboTelerik(ByRef X As Integer, ByRef Y As Integer, pnl As System.Windows.Forms.Panel, ByVal nombre As String,
                                       ByVal valueMember As String, ByVal displayMember As String, ByVal lst As IList, ByVal incluyeNinguno As Boolean,
                                       Optional ByVal valorDef As Object = Nothing, Optional ByVal obligatorio As Boolean = False) _
                                       As Telerik.WinControls.UI.RadCheckedDropDownList
        Dim cbxRad As New Telerik.WinControls.UI.RadCheckedDropDownList
        With cbxRad
            .FormattingEnabled = True
            .Location = New System.Drawing.Point(X, Y)
            .Name = nombre
            '.Size = New System.Drawing.Size(155, 21)
            .Height = 21
            .Width = (pnl.Width - X - pnl.Padding.Right - 15) 'Alex 25-03-2018 reduci en 15 el combo para que entre el icono error
            .Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
            .ValueMember = valueMember
            .DisplayMember = displayMember
            .DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDownAndRightBottom
            .DataSource = lst
            .TabIndex = tabIx
            .ShowCheckAllItems = incluyeNinguno
            '.DropDownListElement.SelectionMode = SelectionMode.MultiExtended
            tabIx += 1

            'Matias. 08-06-2017  Aparentemente recién se puede asignar un valor después de agregarlo al panel
            'If valorDef IsNot Nothing Then .SelectedValue = valorDef       

            .AutoCompleteMode = AutoCompleteMode.Suggest
            .DropDownListElement.AutoCompleteSuggest = New modFunciones.CustomAutoCompleteSuggestHelper(cbxRad.DropDownListElement)
            .DropDownListElement.AutoCompleteSuggest.SuggestMode = Telerik.WinControls.UI.SuggestMode.Contains
            modFunciones.FuncUtiles.cbxAjustaAnchoLista(cbxRad)

            .Visible = True

            Y += .Height + sepControles  'Separar este control del siguiente.

            If obligatorio Then AddHandler .Validating, AddressOf rdl_Validating


        End With
        pnl.Controls.Add(cbxRad)

        'Matias. 08-06-2017  Aparentemente recién se puede asignar un valor después de agregarlo al panel
        If valorDef IsNot Nothing Then cbxRad.SelectedValue = valorDef

        Return cbxRad
    End Function
    Public Function AgregarCheckedListBox(ByRef X As Integer, ByRef Y As Integer, pnl As System.Windows.Forms.Panel, ByVal Nro As Int16, nombre As String,
                                    ByVal texto As String, DisplayMember As String, ValueMember As String, lstDataSource As IList, Optional obligatorio As Boolean = False) As CheckedListBox
        AgregarLabel(X, Y, pnl, "lbl" & nombre & Nro, texto)

        Dim clbCheckedListBox As New CheckedListBox
        With clbCheckedListBox
            .FormattingEnabled = True
            .Location = New System.Drawing.Point(X, Y)
            .Name = nombre & Nro
            .CheckOnClick = True
            '.Size = New System.Drawing.Size(155, 100)
            .Height = 100
            .Width = (pnl.Width - X - pnl.Padding.Right - 15) 'Alex 25-03-2018 para que entre el error provider
            .Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
            .TabIndex = 10
            .DisplayMember = DisplayMember
            .ValueMember = ValueMember
            .DataSource = lstDataSource
            .Visible = True
            If obligatorio Then AddHandler .Validating, AddressOf clb_Validating
            pnl.Controls.Add(clbCheckedListBox)
            .HorizontalScrollbar = True
            .TabIndex = tabIx
            tabIx += 1

            Y += .Height + sepControles

        End With

        Return clbCheckedListBox 'Caro 2017-07-03: Hago que se retorne el control creado para facilitar su uso en algunos lugares.

    End Function
    '------------------ FIN GENÉRICOS

    '------------------ CONTROLES ESPECÍFICOS
    Public Function AgrFechahora(ByRef X As Integer, ByRef Y As Integer, Panel As SplitterPanel, ByVal Nro As Int16, ByVal Lba As String) As DateTimePicker
        AgregarLabel(X, Y, Panel, "lblFechaHora" & Nro, Lba)
        'Dim lbl As New System.Windows.Forms.Label
        'With lbl
        '    .Location = New System.Drawing.Point(X, Y)
        '    .ForeColor = Color.Black
        '    .Size = New System.Drawing.Size(100, 20)
        '    .Name = "lblFechaHora" & Nro
        '    .Text = Lba
        '    .AutoSize = True

        '    Y += .Height + sepLabel 'Separar Label del Control
        'End With
        'Panel.Controls.Add(lbl)

        Dim dtp As New System.Windows.Forms.DateTimePicker
        With dtp
            .CustomFormat = "dd/MM/yy HH:mm"
            .Format = System.Windows.Forms.DateTimePickerFormat.Custom
            .Location = New System.Drawing.Point(X, Y)
            .Name = "Fecha" & Nro
            .Size = New System.Drawing.Size(134, 20)
            .Anchor = AnchorStyles.Left Or AnchorStyles.Top
            .TabIndex = tabIx
            tabIx += 1
            If Nro = 1 Then
                If Lba.Contains("Ingrese") Then
                    .Value = FechaHoy
                Else
                    .Value = FirstDay
                End If
            Else
                .Value = LastDay
            End If

            Y += .Height + sepControles  'Separar este control del siguiente.
        End With
        Panel.Controls.Add(dtp)

        Return dtp 'Caro 2017-07-03: Hago que se retorne el control creado para facilitar su uso en algunos lugares.
    End Function

    Public Function AgrFecha(ByRef X As Integer, ByRef Y As Integer, Panel As SplitterPanel, ByVal Nro As Int16, ByVal Lba As String, Optional ByVal fechaDefecto As Date = Nothing) As DateTimePicker
        AgregarLabel(X, Y, Panel, "lblFecha" & Nro, Lba)
        Dim dtp As New System.Windows.Forms.DateTimePicker
        With dtp
            .Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            .Location = New System.Drawing.Point(X, Y)
            .Name = "Fecha" & Nro
            .Size = New System.Drawing.Size(104, 20)
            .Anchor = AnchorStyles.Left Or AnchorStyles.Top
            .TabIndex = tabIx
            tabIx += 1
            If fechaDefecto = Nothing Then
                If Nro = 1 Then
                    If Lba.Contains("Ingrese") Then
                        .Value = ClsMain.FechaHoy
                    Else
                        .Value = FirstDay
                    End If
                Else
                    .Value = LastDay
                End If
            Else
                .Value = fechaDefecto
            End If

            Y += .Height + sepControles  'Separar este control del siguiente.
        End With
        Panel.Controls.Add(dtp)

        Return dtp 'Caro 2017-07-03: Hago que se retorne el control creado para facilitar su uso en algunos lugares.
    End Function

    '21-11-2019  rptVentasMesActualMesAnterior
    Public Function AgrFechaMes(ByRef X As Integer, ByRef Y As Integer, Panel As SplitterPanel, ByVal Nro As Int16, ByVal Lba As String, Optional ByVal fechaDefecto As Date = Nothing) As DateTimePicker
        AgregarLabel(X, Y, Panel, "lblFecha" & Nro, Lba)
        Dim dtp As New System.Windows.Forms.DateTimePicker
        With dtp
            .Format = System.Windows.Forms.DateTimePickerFormat.Custom
            .CustomFormat = "MM"
            .Location = New System.Drawing.Point(X, Y)
            .Name = "Fecha" & Nro
            .Size = New System.Drawing.Size(104, 20)
            .Anchor = AnchorStyles.Left Or AnchorStyles.Top
            .TabIndex = tabIx
            tabIx += 1

            'Caro 2019-12-05: Colocamos siempre el primer dia porque en este control interesa solo el mes, 
            '                 y si ponemos el ultimo dia, da error en los meses que tienen menos dias
            If fechaDefecto = Nothing Then
                .Value = FirstDay
                'If Nro = 1 Then
                '    If Lba.Contains("Ingrese") Then
                '        .Value = ClsMain.FechaHoy
                '    Else
                '        .Value = FirstDay
                '    End If
                'Else
                '    .Value = LastDay
                'End If
            Else
                .Value = FirstDay(fechaDefecto)
                '.Value = fechaDefecto
            End If

            Y += .Height + sepControles  'Separar este control del siguiente.
        End With
        Panel.Controls.Add(dtp)

        Return dtp
    End Function


    Public Function AgrFechaAnio(ByRef X As Integer, ByRef Y As Integer, Panel As SplitterPanel, ByVal Nro As Int16, ByVal Lba As String, Optional ByVal fechaDefecto As Date = Nothing) As DateTimePicker
        AgregarLabel(X, Y, Panel, "lblFecha" & Nro, Lba)
        Dim dtp As New System.Windows.Forms.DateTimePicker
        With dtp
            .Format = System.Windows.Forms.DateTimePickerFormat.Custom
            .CustomFormat = "yyyy"
            .Location = New System.Drawing.Point(X, Y)
            .Name = "Fecha" & Nro
            .Size = New System.Drawing.Size(104, 20)
            .Anchor = AnchorStyles.Left Or AnchorStyles.Top
            .TabIndex = tabIx
            tabIx += 1
            If fechaDefecto = Nothing Then
                If Nro = 1 Then
                    If Lba.Contains("Ingrese") Then
                        .Value = ClsMain.FechaHoy.AddYears(-1)
                    Else
                        .Value = FirstDay
                    End If
                Else
                    .Value = LastDay
                End If
            Else
                .Value = fechaDefecto
            End If

            Y += .Height + sepControles  'Separar este control del siguiente.
        End With
        Panel.Controls.Add(dtp)

        Return dtp
    End Function


    Public Function ComboboxUsuarios(ByRef X As Integer, ByRef Y As Integer, pnl As SplitterPanel, cbxUsuarios As ComboBox, lblUsuarios As Label) As ComboBox
        If cbxUsuarios Is Nothing Then
            AgregarLabel(X, Y, pnl, "lblUsuarios", "Usuario:")
            'lblUsuarios = New Label
            'With lblUsuarios
            '    .Location = New System.Drawing.Point(X, Y) '+ 25)
            '    .Text = "Usuario:"
            '    .Visible = True

            '    Y += .Height + sepLabel 'Separar Label del Control
            'End With
            'Panel.Controls.Add(lblUsuarios)

            cbxUsuarios = New System.Windows.Forms.ComboBox()
            With cbxUsuarios
                .FormattingEnabled = True
                .Location = New System.Drawing.Point(X, Y) '+ 25)
                .Name = "cbxUsuarios"
                '.Size = New System.Drawing.Size(155, 21)
                .Height = 21
                .Width = (pnl.Width - X - pnl.Padding.Right)
                .Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
                .TabIndex = 10
                .DropDownStyle = ComboBoxStyle.DropDownList
                .DisplayMember = "ApeyNom"
                .ValueMember = "id"
                .TabIndex = tabIx
                tabIx += 1
                .DataSource = ClsEnumerados.Instancia.lst_Usuario 'oCmbUsuarios.FillList(ClsVariablesSesion.Instancia.getConn)

                .Visible = True

                Y += .Height + sepControles  'Separar este control del siguiente.
            End With
            pnl.Controls.Add(cbxUsuarios)

        End If

        Return cbxUsuarios 'Caro 2017-07-03: Hago que se retorne el control creado para facilitar su uso en algunos lugares.

    End Function
    Public Function ComboboxVendedores(ByRef X As Integer, ByRef Y As Integer, pnl As SplitterPanel, cbxUsuarios As ComboBox, lblUsuarios As Label) As ComboBox
        Return ComboboxVendedores(X, Y, pnl, cbxUsuarios, lblUsuarios, False)
    End Function

    Public Function ComboboxVendedores(ByRef X As Integer, ByRef Y As Integer, pnl As SplitterPanel, cbxUsuarios As ComboBox, lblUsuarios As Label, ByVal incluirTodos As Boolean) As ComboBox
        If cbxUsuarios Is Nothing Then
            AgregarLabel(X, Y, pnl, "lblUsuarios", "Vendedores:")
            Dim lst As New List(Of usuario)
            cbxUsuarios = New System.Windows.Forms.ComboBox()
            With cbxUsuarios
                .FormattingEnabled = True
                .Location = New System.Drawing.Point(X, Y) '+ 25)
                .Name = "cbxUsuarios"
                '.Size = New System.Drawing.Size(155, 21)
                .Height = 21
                .Width = (pnl.Width - X - pnl.Padding.Right)
                .Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
                .TabIndex = 10
                .DropDownStyle = ComboBoxStyle.DropDownList
                .DisplayMember = "ApeyNom"
                .ValueMember = "id"
                .TabIndex = tabIx
                tabIx += 1
                If incluirTodos Then
                    Dim u As New usuario
                    u.apellido = "(Todos)"
                    lst.Add(u)
                End If
                lst.AddRange(ClsEnumerados.Instancia.lst_Usuario.FindAll(Function(u) u.activo AndAlso u.vRoles.ToUpper.Contains("VENDEDOR")))
                .DataSource = lst
                .Visible = True
                Y += .Height + sepControles
            End With
            pnl.Controls.Add(cbxUsuarios)

        End If

        Return cbxUsuarios

    End Function

    Public Function ComboboxUsuarioTelerik(ByRef X As Integer, ByRef Y As Integer, ByRef pnl As System.Windows.Forms.Panel, ByVal Nro As Integer, ByVal texto As String, ByVal TodaLaEmpresa As Boolean, ByVal incluyeNinguno As Boolean, Optional ByVal idDefecto As Integer = 0) As Telerik.WinControls.UI.RadDropDownList
        AgregarLabel(X, Y, pnl, "lblUsuario" & Nro, texto.Trim & (IIf(Not texto.Trim.EndsWith(":"), ":", "")))
        'Dim lbl = New Label
        'With lbl
        '    .Name = "lblUsuario" & Nro
        '    .Location = New System.Drawing.Point(X, Y) ' + 25)
        '    .Text = texto.Trim & (IIf(Not texto.Trim.EndsWith(":"), ":", ""))
        '    .Visible = True

        '    Y += .Height + sepLabel 'Separar Label del Control
        'End With
        'pnl.Controls.Add(lbl)

        Dim lst As New List(Of usuario)
        If incluyeNinguno Then
            Dim u As New usuario
            u.apellido = "(Todos)"
            lst.Add(u)
        End If
        If TodaLaEmpresa Then
            lst.AddRange(ClsEnumerados.Instancia.lst_Usuario.FindAll(Function(j) j.activo AndAlso j.lst_UsuarioSucursal.Exists(Function(k) k.Sucursal.empresa_id = ClsVariablesSesion.Instancia.Empresa.id)).OrderBy(Function(j) j.ApeyNom).ToList)
            'lst.AddRange((From u In ClsEnumerados.Instancia.lst_Usuario Where u.activo Order By u.ApeyNom).ToList) 'oCmbUsuarios.FillList(ClsVariablesSesion.Instancia.getConn)
        Else
            lst.AddRange((From u In ClsVariablesSesion.Instancia.Sucursal.lst_UsuarioSucursal Where u.Usuario.activo Order By u.Usuario.ApeyNom Select u.Usuario).ToList)
        End If

        Dim cbx = CrearComboTelerik(X, Y, pnl, "cbxRadUsuarios" & Nro, "id", "ApeyNom", lst, idDefecto, Not incluyeNinguno)

        Return cbx 'Caro 2017-07-03: Hago que se retorne el control creado para facilitar su uso en algunos lugares.

    End Function

    'Caro 2018-10-18: Agrego este método para poder poner un combo de una lista que le indique.
    Public Function ComboClsEnumeradosTelerik(ByRef X As Integer, ByRef Y As Integer, ByRef pnl As System.Windows.Forms.Panel, ByVal Nro As Integer, ByVal texto As String, ByVal incluyeNinguno As Boolean, ByVal nombreListaEnumerados As String, ByVal nombreDisplayMember As String, ByVal nombreValueMember As String, Optional ByVal idDefecto As Integer = 0) As Telerik.WinControls.UI.RadDropDownList

        Dim m = ClsEnumerados.Instancia.GetType.GetProperty(nombreListaEnumerados)
        If m IsNot Nothing Then
            Dim lista = m.GetValue(ClsEnumerados.Instancia, Nothing) 'm.Invoke(Me, Nothing)

            If lista IsNot Nothing Then
                AgregarLabel(X, Y, pnl, "lblClsEnumerados" & Nro, texto.Trim & (IIf(Not texto.Trim.EndsWith(":"), ":", "")))

                Dim cbx = CrearCheckedComboTelerik(X, Y, pnl, "cbxRadClsEnumerados" & Nro, nombreValueMember, nombreDisplayMember, lista, incluyeNinguno, idDefecto, False)
                'Dim cbx = CrearComboTelerik(X, Y, pnl, "cbxRadClsEnumerados" & Nro, nombreValueMember, nombreDisplayMember, lista, idDefecto, Not incluyeNinguno)

                Return cbx

            End If
        End If

        Return Nothing

    End Function

    'CrearCheckedComboTelerik
    Public Function ComboboxCheckedUsuarioTelerik(ByRef X As Integer, ByRef Y As Integer, ByRef pnl As System.Windows.Forms.Panel,
                                                  ByVal Nro As Integer, ByVal texto As String, ByVal TodaLaEmpresa As Boolean, SoloUsuariosActivo As Boolean,
                                                  ByVal incluyeNinguno As Boolean, Optional ByVal idDefecto As Integer = 0) As Telerik.WinControls.UI.RadDropDownList
        AgregarLabel(X, Y, pnl, "lblUsuario" & Nro, texto.Trim & (IIf(Not texto.Trim.EndsWith(":"), ":", "")))

        Dim lst As New List(Of usuario)
        'If incluyeNinguno Then
        '    Dim u As New usuario
        '    u.apellido = "(Todas)"
        '    lst.Add(u)
        'End If
        If TodaLaEmpresa Then
            lst.AddRange(ClsEnumerados.Instancia.lst_Usuario.FindAll(Function(j) j.lst_UsuarioSucursal.Exists(Function(k) k.Sucursal.empresa_id = ClsVariablesSesion.Instancia.Empresa.id)).OrderBy(Function(j) j.ApeyNom).ToList)
        Else
            lst.AddRange((From u In ClsVariablesSesion.Instancia.Sucursal.lst_UsuarioSucursal Order By u.Usuario.ApeyNom Select u.Usuario).ToList)
        End If
        If SoloUsuariosActivo Then
            lst = (From u In lst Where u.activo).ToList
        End If

        Dim cbx = CrearCheckedComboTelerik(X, Y, pnl, "cbxRadUsuariosChecked" & Nro, "id", "ApeyNom", lst, incluyeNinguno, idDefecto, Not incluyeNinguno)

        Return cbx 'Caro 2017-07-03: Hago que se retorne el control creado para facilitar su uso en algunos lugares.

    End Function
    Public Function AgregarTexto(ByRef X As Integer, ByRef Y As Integer, pnl As System.Windows.Forms.Panel, ByVal Nro As Int16, ByVal texto As String, ByVal esNumero As Boolean, Optional ByVal defecto As String = "") As Windows.Forms.TextBox
        AgregarLabel(X, Y, pnl, "lbl" & IIf(esNumero, "NUMERO", "TEXTO") & Nro, texto)
        'Dim lbl As New System.Windows.Forms.Label
        'With lbl
        '    .Name = "lbl" & IIf(esNumero, "NUMERO", "TEXTO") & Nro
        '    .Location = New System.Drawing.Point(X, Y)
        '    .Size = New System.Drawing.Size(100, 20)
        '    .Text = texto
        '    .AutoSize = True

        '    Y += .Height + sepLabel 'Separar Label del Control
        'End With
        'pnl.Controls.Add(lbl)

        Dim txt As New System.Windows.Forms.TextBox
        With txt
            .Name = "txt" & IIf(esNumero, "NUMERO", "TEXTO") & Nro
            .Location = New System.Drawing.Point(X, Y)
            If esNumero Then
                .Size = New System.Drawing.Size(70, 20)
                AddHandler .KeyPress, AddressOf txtNUMERO_KeyPress
                .Anchor = AnchorStyles.Left Or AnchorStyles.Top
            Else
                'Caro 2017-10-10: Permitimos múltiples líneas y lo hacemos más alto.
                .Size = New System.Drawing.Size(pnl.Width - X - pnl.Padding.Right, 60) 'height: 20
                .Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
                .Multiline = True 'Caro 2017-10-09: Que permita saltos de carro.
                Dim ttp As New System.Windows.Forms.ToolTip
                ttp.SetToolTip(txt, "Utilice Ctrl+Enter para hacer un salto de línea")
            End If
            .Text = defecto
            .TabIndex = tabIx
            tabIx += 1

            Y += .Height + sepControles  'Separar este control del siguiente.
        End With
        pnl.Controls.Add(txt)

        Return txt 'Caro 2017-07-03: Hago que se retorne el control creado para facilitar su uso en algunos lugares.

    End Function
    Public Function ComboSucursal(ByRef X As Integer, ByRef Y As Integer, pnl As System.Windows.Forms.Panel, ByVal Nro As Int16, ByVal texto As String, Optional ByVal idDefecto As Integer = 0, Optional incluirTodas As Boolean = False) As ComboBox
        AgregarLabel(X, Y, pnl, "lblSucursal" & Nro, "Sucursal:")

        Dim cbx = New ComboBox
        With cbx
            .Name = "cbxSucursal" & Nro
            .Location = New System.Drawing.Point(X, Y)
            .DropDownStyle = ComboBoxStyle.DropDownList
            .DropDownWidth = (pnl.Width - X - pnl.Padding.Right)
            .Width = (pnl.Width - X - pnl.Padding.Right)
            .Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
            .TabIndex = tabIx
            tabIx += 1

            sucursal.SetComboBox(cbx, False, incluirTodas, True)

            'modFunciones.FuncUtiles.cbxAjustaAncho(cbx)

            If Not incluirTodas Then AddHandler .Validating, AddressOf cbx_Validating

            Y += .Height + sepControles  'Separar este control del siguiente.
        End With
        pnl.Controls.Add(cbx) 'Debe ir antes de setear el SelectedValue

        If idDefecto > 0 Then
            cbx.SelectedValue = idDefecto
        Else
            'Caro 2018-06-11: No debe tomar un valor por defecto....
            'cbx.SelectedValue = ClsVariablesSesion.Instancia.Sucursal.id
        End If

        Return cbx 'Caro 2017-07-03: Hago que se retorne el control creado para facilitar su uso en algunos lugares.
    End Function
    Public Function ComboLogico(ByRef X As Integer, ByRef Y As Integer, pnl As System.Windows.Forms.Panel, ByVal Nro As Int16, ByVal texto As String, Optional ByVal defecto As Boolean? = Nothing, Optional incluirTodos As Boolean = False, Optional ByVal NombreTodos As String = "Todos", Optional ByVal Ocultar As Boolean = False) As ComboBox
        AgregarLabel(X, Y, pnl, "lblLogico" & Nro, texto, Ocultar)

        Dim lstB As New List(Of modFunciones.FuncUtiles.datoBooleano)
        If incluirTodos Then lstB.Add(New modFunciones.FuncUtiles.datoBooleano(Nothing, NombreTodos))
        lstB.Add(New modFunciones.FuncUtiles.datoBooleano(True, "Sí"))
        lstB.Add(New modFunciones.FuncUtiles.datoBooleano(False, "No"))

        'Dim lstB As New List(Of modFunciones.FuncUtiles.datoBooleano)
        'If incluirTodos Then lstB.Add(New modFunciones.FuncUtiles.datoBooleano(Nothing, NombreTodos))
        'lstB.Add(New modFunciones.FuncUtiles.datoBooleano(True, "Sí"))
        'lstB.Add(New modFunciones.FuncUtiles.datoBooleano(False, "No"))

        Dim cbx = CrearCombo(X, Y, pnl, "cbxLogico" & Nro, "id", "valor", lstB, defecto, Not incluirTodos, Ocultar)

        cbx.SelectedValue = defecto
        Return cbx 'Caro 2017-07-03: Hago que se retorne el control creado para facilitar su uso en algunos lugares.

    End Function
    Public Function ComboCadena(ByRef X As Integer, ByRef Y As Integer, pnl As System.Windows.Forms.Panel, ByVal Nro As Int16, ByVal texto As String, ByVal lst As List(Of modFunciones.FuncUtiles.datoCadena), Optional ByVal defecto As String = Nothing, Optional ByVal obligatorio As Boolean = False, Optional ByVal Ocultar As Boolean = False) As ComboBox
        AgregarLabel(X, Y, pnl, "lblCadena" & Nro, texto, Ocultar)

        Dim cbx = CrearCombo(X, Y, pnl, "cbxCadena" & Nro, "id", "valor", lst, defecto, obligatorio, Ocultar)

        Return cbx

    End Function
    Public Function ListaCategoriasCliente(ByRef X As Integer, ByRef Y As Integer, pnl As System.Windows.Forms.Panel, ByVal Nro As Int16, ByVal texto As String, Optional obligatorio As Boolean = False) As CheckedListBox
        'AgregarLabel(X, Y, pnl, "lblClienteCat" & Nro, texto)
        '.DataSource = ClsEnumerados.Instancia.lstClienteCategoria.OrderBy(Function(c) c.categoria).ToList      'Matias. 13-06-2017
        'Matias. 13-06-2017
        'A partir de Distribuidora Curuzú los usuarios tienen Roles y esos Roles son los que pueden ver y/o trabajar sobre determinados Clientes de acuerdo a la 
        'Categoría que tienen configurado. Por lo tanto, en lugar de cargar todas las categorias, se cargan solo las que puede ver el usario logueado.
        'Si el proyecto no trabaja de esta manera, la vista: .vLstClienteCategoria devuelve todas las categorías.
        '.DataSource = ClsVariablesSesion.Instancia.Usuario.vLstClienteCategoria.OrderBy(Function(c) c.categoria).ToList

        'Matias. 26-06-2017         
        Dim clb = AgregarCheckedListBox(X, Y, pnl, Nro, "clbClienteCat", texto, "vNombreCompleto", "id", ClsVariablesSesion.Instancia.Usuario.vLstClienteCategoria.OrderBy(Function(c) c.vNombreCompleto).ToList, obligatorio)

        Return clb 'Caro 2017-07-03: Hago que se retorne el control creado para facilitar su uso en algunos lugares.

    End Function
    Public Function ComboProvincia(ByRef X As Integer, ByRef Y As Integer, pnl As System.Windows.Forms.Panel, ByVal Nro As Int16,
                                   ByVal texto As String, Optional ByVal idDefecto As Integer = 0,
                                   Optional ObligatorioProvincias As Boolean = True) As Telerik.WinControls.UI.RadDropDownList

        AgregarLabel(X, Y, pnl, "lblProvincia" & Nro, texto)

        Dim lstProv = ClsEnumerados.Instancia.Provincias.OrderBy(Function(p) p.nombre).ToList
        If Not ObligatorioProvincias Then
            Dim prov As New provincia
            prov.nombre = "(Todas)"
            lstProv.Insert(0, prov)
        End If
        Dim cbxProv = CrearComboTelerik(X, Y, pnl, "cbxProvincia" & Nro, "id", "nombre", lstProv, idDefecto, True)
        Return cbxProv
    End Function

    Dim incluirTodasLoc As Boolean
    Public Sub ComboLocalidad(ByRef X As Integer, ByRef Y As Integer, pnl As System.Windows.Forms.Panel, ByVal Nro As Int16, ByVal NroProvincias As Int16,
                              ByVal texto As String, Optional ByVal idDefectoLocalidad As Integer = 0,
                              Optional ByVal idDefectoProvincia As Integer = 0, Optional obligatorioLocalidades As Boolean = True,
                              Optional obligatorioProvincias As Boolean = True)

        ''Primero PROVINCIA:
        'AgregarLabel(X, Y, pnl, "lblProvincia" & Nro, "Provincia: ")
        'Dim idProvDef As Integer = 0

        If idDefectoProvincia = 0 Then
            If idDefectoLocalidad > 0 Then
                Dim loc = ClsEnumerados.Instancia.lstLocalidadUsada.Find(Function(l) l.id = idDefectoLocalidad)
                If loc IsNot Nothing Then idDefectoProvincia = loc.provincia_id
            End If
        End If

        'Dim lstProv = ClsEnumerados.Instancia.Provincias.OrderBy(Function(p) p.nombre).ToList
        'If incluirTodas Then
        '    Dim prov As New provincia
        '    prov.nombre = "(Todas)"
        '    lstProv.Insert(0, prov)
        'End If
        'Dim cbxProv = CrearComboTelerik(X, Y, pnl, "cbxProvincia" & Nro, "id", "nombre", lstProv, idProvDef, Not incluirTodas)
        Dim cbxProv = ComboProvincia(X, Y, pnl, NroProvincias, "Provincia:", idDefectoProvincia, obligatorioProvincias)

        'Dim cbxProv = ComboProvincia(X, Y, pnl, Nro, "Provincia:", idProvDef, False)

        'Luego LOCALIDAD:
        AgregarLabel(X, Y, pnl, "lblLocalidad" & Nro, "Localidad:")

        Dim lstLoc As New List(Of localidad)

        Dim cbxLoc = CrearComboTelerik(X, Y, pnl, "cbxLocalidad" & Nro, "id", "nombre", lstLoc,, True)
        incluirTodasLoc = obligatorioLocalidades
        'Dim cbxLoc = CrearComboTelerik(X, Y, pnl, "cbxLocalidad" & Nro, "id", "nombre", lstLoc, Not incluirTodasLocalidades)

        cbxProv.Tag = cbxLoc
        AddHandler cbxProv.SelectedIndexChanged, AddressOf cbxProvincia_SelectedIndexChanged

        'Hacer que cargue el combo de localidades
        cbxProvincia_SelectedIndexChanged(cbxProv, Nothing)

        If idDefectoLocalidad > 0 Then
            cbxLoc.SelectedValue = idDefectoLocalidad
        End If
    End Sub
    '------------------ FIN CONTROLES ESPECÍFICOS

    '------------------ EVENTOS DE CONTROLES (VALIDACIONES, SELECTEDCHANGED, ETC)
    Public Function getControl(ByRef panel As Windows.Forms.Panel, ByVal nombre As String, ByVal tipo As Type) As Object
        For Each Ctrl In panel.Controls
            If Ctrl.GetType Is tipo Then
                If Ctrl.Name = nombre Then Return Ctrl
            End If
        Next
        Return Nothing
    End Function
    Private Sub txtNUMERO_KeyPress(sender As Object, e As KeyPressEventArgs)
        modFunciones.FuncUtiles.contDecimal(sender, e.KeyChar)
    End Sub
    Private Sub clb_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        erpError.SetError(sender, Nothing)
        With CType(sender, CheckedListBox)
            If .CheckedItems.Count = 0 Then
                erpError.SetError(sender, "Seleccione algún elemento")
                e.Cancel = True
            End If
        End With
    End Sub
    Private Sub cbx_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        erpError.SetError(sender, Nothing)
        With CType(sender, ComboBox)
            If .SelectedItem Is Nothing OrElse .SelectedValue Is Nothing OrElse (IsNumeric(.SelectedValue) AndAlso .SelectedValue = 0) OrElse String.IsNullOrWhiteSpace(.SelectedValue) Then
                erpError.SetError(sender, "Seleccione algún elemento")
                e.Cancel = True
            End If
        End With
    End Sub
    Private Sub rdl_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        erpError.SetError(sender, Nothing)
        With CType(sender, Telerik.WinControls.UI.RadDropDownList)
            'Alex 22-03-2018 se saco OrElse .SelectedValue = 0 para poder aceptar (Todos) 
            If .SelectedItem Is Nothing OrElse .SelectedValue Is Nothing _
                OrElse .Text <> .SelectedItem.DataBoundItem.GetType.GetProperty(.DisplayMember).GetValue(.SelectedItem.DataBoundItem, Nothing) Then
                erpError.SetError(sender, "Seleccione algún elemento")
                e.Cancel = True
            End If
        End With
    End Sub
    Private Sub cbxProvincia_SelectedIndexChanged(sender As Object, e As EventArgs)

        With CType(sender, Telerik.WinControls.UI.RadDropDownList) 'Combo Provincia
            Dim incluirTodas As Boolean = incluirTodasLoc
            'Dim incluirTodas As Boolean = ((From i In .Items Where CType(i.DataBoundItem, provincia).id = 0).Count > 0)
            Dim lstLoc As New List(Of localidad)
            If .SelectedValue > 0 Then
                lstLoc.AddRange(CType(.SelectedItem.DataBoundItem, provincia).Localidades)
                'Else
                '    lstLoc.AddRange(ClsEnumerados.Instancia.Localidades) 'Alex 25-03-2018 para que cuando se seleccione todas las provincias cargue solo todas localidades
            End If
            If Not incluirTodas Then
                Dim loc As New localidad
                loc.nombre = "(Todas)"
                lstLoc.Insert(0, loc)
            End If

            lstLoc = lstLoc.OrderBy(Function(p) p.nombre).ToList
            With CType(.Tag, Telerik.WinControls.UI.RadDropDownList) 'Combo Localidad
                .DataSource = lstLoc
            End With
        End With
    End Sub
    '------------------ FIN EVENTOS DE CONTROLES


    '--------------------- CONTROL DE VISIBILIDAD --------------------------
    Dim _siempreVisibleConciliado As Boolean = False
    Dim _siempreVisibleReal As Boolean = False
    Dim lstControlesAOcultar As New List(Of Object)
    Private Sub Frm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) 'Handles MyBase.KeyDown
        If modEstilos.ClsEstilo.PresionoPrueba(e) Then 'e.KeyCode = Keys.F11 Then
            MostrarOcultarFiltros()
        End If
    End Sub
    Private Sub MostrarOcultarFiltros()
        For Each ctrl In lstControlesAOcultar
            If ctrl.GetType.GetProperty("Visible") IsNot Nothing Then
                ctrl.Visible = (_siempreVisibleConciliado OrElse Not ctrl.Visible)
            End If
        Next
    End Sub
    '--------------------- Fin CONTROL DE VISIBILIDAD --------------------------
#End Region
End Class
