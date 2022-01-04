Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports modEntities
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class rptListado
    Inherits Telerik.Reporting.Report

    Dim Cls As New ClsListado
    Friend WithEvents txt As Telerik.Reporting.TextBox
    Friend WithEvents ctList As Crosstab
    Const ANCHO_MAXIMO As Double = 60 '60 mm=6cm como maximo.
    'Const ANCHO_DEFECTO As Double = 16 '16mm=1.6cm por defecto.

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub CargarDatos(ByVal Listado As listado)
        Cls.Listado = Listado
        Me.Name = Listado.nombre_alias

        Me.picLogoEmpresa.Value = modFunciones.FuncUtiles.Bytes2Image(ClsVariablesSesion.Instancia.Sucursal.pic_header_reporte)
        txtFecha.Value = "Fecha de Impresión :" & ClsVariablesSesion.Instancia.FechaHoy.ToShortDateString
        txtTitulo.Value = Cls.Listado.nombre_alias

        If Listado.id > 0 Then
            Try
                Dim dt = modEntities.listado.EjecutarConsulta(Listado, ClsVariablesSesion.Instancia.getConn)
                CrearCrossTab(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

        End If
    End Sub
    Private Sub Ordenar(ByRef dt As DataTable, ByRef ctb As Crosstab)

        'NO UTILIZAR TODAVÍA, YA QUE ESTÁ EN DESARROLLO.

        'Limpiar todo
        Dim rpt = ctb.Report
        rpt.ReportParameters.Clear()
        rpt.Filters.Clear()
        ctb.Sortings.Clear()


        Dim lstColAdicOrd = New List(Of String)

        For Each lc In Cls.Listado.lstListadoColumna 'ver orden 

            '---- AGREGAR FILTRO:
            If lc.getAdicional("filtrar") = "1" Then
                Dim nombreFiltrar = lc.getAdicional("filtrar_campo") 'Si anda bien,  usar esto mismo para el que cuenta 
                If String.IsNullOrWhiteSpace(nombreFiltrar) Then nombreFiltrar = lc.nombre
                Dim lst = (From r As DataRow In dt.Rows Select New modFunciones.FuncUtiles.datoCadena(r(nombreFiltrar).ToString, r(lc.nombre).ToString)).Distinct.ToList
                'Dim lstValores = (From r As DataRow In dt.Rows Select nombre = r(nombreFiltrar).ToString).Distinct.ToList

                'Agregar el parámetro
                Dim p As New Telerik.Reporting.ReportParameter
                p.Name = "par" & lc.nombre
                p.Text = lc.nombre_alias
                p.MultiValue = True
                p.AutoRefresh = True
                p.Visible = True
                p.Type = Telerik.Reporting.ReportParameterType.String
                'For Each v In lstValores
                '    lst.Add(New modFunciones.FuncUtiles.datoCadena(v, v))
                'Next
                With p.AvailableValues
                    .ValueMember = "id"
                    .DisplayMember = "valor"
                    .DataSource = lst.OrderBy(Function(x) x.valor).ToList
                End With
                p.Value = lst.Select(Function(x) x.id).ToArray

                rpt.ReportParameters.Add(p)

                'Agregar el filtro a la Crosstab
                Dim f As New Telerik.Reporting.Filter
                f.Expression = "=" & nombreFiltrar
                f.Operator = Telerik.Reporting.FilterOperator.In
                f.Value = "=Parameters." & p.Name.ToString & ".Value"
                If ctb Is Nothing Then
                    rpt.Filters.Add(f)
                Else
                    ctb.Filters.Add(f)
                End If
            End If

            '---- 

            '---- AGREGAR PARAMETRO PARA ORDEN
            'Resguardar las columnas que se ordenan para luego agregar el parámetro.

            'Si la columna está configurada para que pueda ordenarse, por cada criterior de orden (1, 2, etc) agregar el combo.
            For Each adicOrd In lc.vLstNombresAdicionales.FindAll(Function(x) x.ToLower.Contains("ordenar"))   'lc.getAdicional("ordenar") = "1" Then
                If Not lstColAdicOrd.Exists(Function(x) x = adicOrd) Then lstColAdicOrd.Add(adicOrd)
            Next

        Next

        'Si hay columnas para ordenar
        For Each adicOrd In lstColAdicOrd
            Dim parOrd = New Telerik.Reporting.ReportParameter
            parOrd.Name = "par" & adicOrd
            parOrd.Text = "Ordenar por"
            parOrd.MultiValue = False
            parOrd.AutoRefresh = True
            parOrd.Visible = True
            parOrd.Type = Telerik.Reporting.ReportParameterType.String

            Dim lst As New List(Of modFunciones.FuncUtiles.datoCadena)
            For Each lc In Cls.Listado.lstListadoColumna
                If lc.vLstNombresAdicionales.Exists(Function(x) x = adicOrd) Then
                    lst.Add(New modFunciones.FuncUtiles.datoCadena(lc.nombre, lc.nombre_alias))
                End If
            Next

            With parOrd.AvailableValues
                .ValueMember = "id"
                .DisplayMember = "valor"
                .DataSource = lst.OrderBy(Function(x) x.valor).ToList
            End With
            If lst.Count > 0 Then parOrd.Value = lst.First.id

            rpt.ReportParameters.Add(parOrd)


            ctb.Sortings.AddRange(New Telerik.Reporting.Sorting() _
                {New Telerik.Reporting.Sorting(ctb.Report.ReportParameters(parOrd.Name).Value, Telerik.Reporting.SortDirection.Asc)})
            '{New Telerik.Reporting.Sorting(ctb.Report.ReportParameters(parOrd.Name).Value, Telerik.Reporting.SortDirection.Asc)})
            '{New Telerik.Reporting.Sorting("=Parameters." & parOrd.Name & ".Value", Telerik.Reporting.SortDirection.Asc)})
        Next
    End Sub

    Private Sub CrearCrossTab(ByRef dt As DataTable)
        'NOTA: Los anchos se miden en milímetros, porque es lo necesario en un reporte.

        ctList = New Telerik.Reporting.Crosstab()
        Me.detail.Items.Clear() 'Agregar dispose
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.ctList})

        If dt.Rows.Count = 0 Then Exit Sub


        'Crear Fila de datos: 0.65R
        Me.ctList.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(New Telerik.Reporting.Drawing.Unit(0.4R, Telerik.Reporting.Drawing.UnitType.Cm)))

        Dim ix As Integer = -1
        Dim anchoTotal As Double = 0
        Dim agregarTotales As Boolean = Cls.Listado.lstListadoColumna.Exists(Function(x) x.vTotalizaAdic Or x.vContabilizaAdic)

        If agregarTotales Then
            'Crear fila de totales
            Me.ctList.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(New Telerik.Reporting.Drawing.Unit(0.65R, Telerik.Reporting.Drawing.UnitType.Cm)))
        End If

        Dim lstColNoEncontradas As New List(Of listado_columna)

        Dim lstCol = Cls.Listado.lstListadoColumna.FindAll(Function(x) x.vVisibleAdic).OrderBy(Function(x) x.orden).ToList
        For Each lc In lstCol  'c As DataColumn In dt.Columns

            'Verificar que exista la columna
            If dt.Columns.IndexOf(lc.nombre) = -1 Then
                'Si no existe, igual se procesa el reporte pero al finalizar se muestra un mensaje con las columnas no encontradas
                lstColNoEncontradas.Add(lc)

            Else 'Es correcta la columna, procesar:

                Dim lstStr = (From r As DataRow In dt.Rows
                              Where r(lc.nombre) IsNot Nothing AndAlso r(lc.nombre).ToString.Length > 0
                              Select nombre = r(lc.nombre).ToString).ToList


                Dim esEntero, esDecimal, esFecha, esFechaHora As Boolean
                Dim ancho = Math.Round(getAncho(lstStr, lc.nombre_alias, esEntero, esDecimal, esFecha, esFechaHora), 2)
                anchoTotal += ancho

                ix += 1
                Dim esUltima = (ix = lstCol.Count - 1)

                'CORNER
                If ix = 0 Then
                    'Crear un textbox para el Título
                    crearTextBox(txt, True, lc.nombre, lc.nombre_alias, ancho, esUltima,,,,, False)
                    anchoTotal += txt.Style.BorderWidth.Left.Value * IIf(esUltima, 2, 1)

                    Me.ctList.Items.Add(txt)
                    Me.ctList.Corner.SetCellContent(0, 0, txt)

                    'Primera fila, debajo del Corner - Crear un textox para el dato
                    crearTextBox(txt, False, lc.nombre, "=" & lc.nombre, ancho, esUltima, esEntero, esDecimal, esFecha, esFechaHora)
                    'Crear un TAbleGroup para los datos del Corner:
                    Dim tgRow As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
                    tgRow.ReportItem = txt
                    tgRow.Name = "tgRow" & lc.nombre
                    Me.ctList.Items.Add(txt)
                    Me.ctList.RowGroups.Add(tgRow)

                    'Agrupacion de Fila:
                    Dim lstColGrupoFila = Cls.Listado.lstListadoColumna.FindAll(Function(x) x.vAgrupaFilaAdic)
                    If lstColGrupoFila IsNot Nothing AndAlso lstColGrupoFila.Count > 0 Then
                        'Si hay una propiedad configurada para la agrupación:
                        'Dim lstG As New Telerik.Reporting.GroupingCollection
                        For Each g In lstColGrupoFila
                            tgRow.Groupings.Add(New Telerik.Reporting.Grouping("=" & g.nombre))
                            'lstG.Add(New Telerik.Reporting.Grouping("=" & g.nombre))
                        Next
                        'tgRow.Groupings.AddRange(lstG)
                        'tgRow.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=" & colGrupoFila.nombre)})
                    Else
                        'Si no hay, colocar el primer campo visible como agrupador: OJO! si un dato es vacio, va a agrupar!
                        tgRow.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=" & lc.nombre)})
                    End If

                Else 'No es CORNER

                    'Crear un textox para el Título
                    crearTextBox(txt, True, lc.nombre, lc.nombre_alias, ancho, esUltima,,,,, False)
                    anchoTotal += txt.Style.BorderWidth.Left.Value * IIf(esUltima, 2, 1)

                    'Crear un TableGroup para títulos:
                    Dim tgHeader As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
                    tgHeader.ReportItem = txt
                    tgHeader.Name = "tgHeader" & lc.nombre
                    Me.ctList.ColumnGroups.Add(tgHeader)
                    Me.ctList.Items.Add(txt)


                    'BODY-----------
                    'Crear una columna por cada elemento para el BODY
                    Me.ctList.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(New Telerik.Reporting.Drawing.Unit(ancho, Telerik.Reporting.Drawing.UnitType.Mm)))

                    'Crear un textox para el dato
                    crearTextBox(txt, False, lc.nombre, "=" & lc.nombre, ancho, esUltima, esEntero, esDecimal, esFecha, esFechaHora)
                    'Agregar el textbox a la fila de datos (siempre es un índice menos, porque el primero va en el corner)
                    Me.ctList.Body.SetCellContent(0, ix - 1, txt)
                    Me.ctList.Items.Add(txt)

                End If

                If agregarTotales Then
                    'Crear un textox para el dato. Vacío si éste no totaliza.

                    Dim prop As String = ""
                    If lc.vTotalizaAdic Then prop = "= SUM(" & lc.nombre & ")"
                    If lc.vContabilizaAdic Then prop = "= ""# "" + COUNT(" & lc.nombre & ")"
                    crearTextBox(txt, True, "total_" & lc.nombre, prop, ancho, esUltima, esEntero, esDecimal, False, False, True)
                    'Crear un TableGroup para los datos del Corner:
                    If ix = 0 Then
                        Dim tgRowFoot As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
                        tgRowFoot.Name = "tgRowFoot" & lc.nombre
                        tgRowFoot.ReportItem = txt
                        Me.ctList.Items.Add(txt)
                        Me.ctList.RowGroups.Add(tgRowFoot)
                    Else
                        Me.ctList.Body.SetCellContent(1, ix - 1, txt)
                    End If

                End If

            End If

        Next

        Me.ctList.Name = "ctList" & Cls.Listado.nombre.Replace(" ", "_")
        ctList.Location = New PointU(New Unit(0), New Unit(0))
        'ctList.Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(11.542709350585938R, Telerik.Reporting.Drawing.UnitType.Cm), New Telerik.Reporting.Drawing.Unit(1.4864586591720581R, Telerik.Reporting.Drawing.UnitType.Cm))

        ctList.DataSource = dt

        If anchoTotal > (Me.PageSettings.PaperSize.Width.Value - Me.PageSettings.Margins.Left.Value - Me.PageSettings.Margins.Right.Value) Then  'ix > 4 Then
            Me.PageSettings.Landscape = True
        End If

        If lstColNoEncontradas.Count > 0 Then
            MessageBox.Show("No pudieron mostrarse las siguientes columnas: " _
                            & String.Join(", ", lstColNoEncontradas.Select(Function(x) x.nombre_alias)) _
                            & vbNewLine & vbNewLine & "Consulte con el administrador del sistema.",
                            "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Ordenar(dt, ctList)

    End Sub
    Private Function getAncho(ByVal lstStr As List(Of String), ByVal tituloColumna As String, ByRef esEntero As Boolean, ByRef esDecimal As Boolean, ByRef esFecha As Boolean, ByRef esFechaHora As Boolean) As Single
        Dim txt = New Telerik.Reporting.TextBox()
        Dim fuente As System.Drawing.Font = New System.Drawing.Font(txt.Style.Font.Name, New Unit(8, UnitType.Point).Value) 'txt.Style.Font.Size.Value) 'f.ConvertFrom(txt.Style.Font)
        Dim ancho As Decimal = 0

        esEntero = False
        esDecimal = False
        esFecha = False
        esFechaHora = False

        If lstStr.Count > 0 Then 'Si hay elementos..
            esEntero = True
            esDecimal = True
            esFecha = True
            esFechaHora = True

            Dim lstAnchos As New List(Of Decimal)

            For Each s In lstStr
                'Si existe al menos un elemento que no sea numero, deja de serlo.
                'Si existe al menos un elemento que no sea fecha, deja de serlo.

                If (esEntero Or esDecimal) Then
                    If Not IsNumeric(s) Then
                        esEntero = False
                        esDecimal = False
                    ElseIf esEntero Then  'es numeric
                        'If CInt(s) <> CDbl(s) Then 'Si entero=decimal, es porque no tiene decimales.
                        If s Mod 1 <> 0 Then 'Cuando es un numero grande como un telefono revienta el casteo. Rodrigo 2017-07-06
                            esEntero = False
                        End If
                    End If
                End If
                If (esFecha Or esFechaHora) Then
                    If Not IsDate(s) Then
                        esFecha = False
                        esFechaHora = False
                    ElseIf esFecha Then  'es Date
                        If Date.Parse(s) <> DateTime.Parse(s) Then 'Si fecha=fechahora, es porque no tiene hora.
                            esFecha = False
                        End If
                    End If
                End If

                lstAnchos.Add(modFunciones.FuncUtiles.getAnchoString(s, fuente, GraphicsUnit.Millimeter))
            Next

            If (esEntero Or esDecimal Or esFecha Or esFechaHora) Then 'Devolver el más ancho
                ancho = Math.Round(lstAnchos.Max(), 2, MidpointRounding.AwayFromZero)

            Else 'Si es string, devolver un promedio
                ancho = Math.Round((lstAnchos.Sum() / lstStr.Count()), 2, MidpointRounding.AwayFromZero)
            End If


            'Else 'Si no hay elementos no vacíos, devolver el ancho de la columna. Si es cero, se devuelve cero.

        End If

        If tituloColumna.Length > 0 Then
            fuente = New System.Drawing.Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)
            Dim anchoTit = Math.Round(modFunciones.FuncUtiles.getAnchoString(tituloColumna, fuente, GraphicsUnit.Millimeter), 2, MidpointRounding.AwayFromZero)
            If anchoTit > ancho Then ancho = anchoTit
        End If

        ancho += 0.01
        If ancho <= ANCHO_MAXIMO Then Return ancho Else Return ANCHO_MAXIMO

    End Function
    Private Function crearTextBox(ByRef txt As Telerik.Reporting.TextBox, ByVal titulo As Boolean, ByVal nombre As String,
                                  ByVal propiedad As String, ByVal anchoMM As Decimal, ByVal esUltima As Boolean,
                                  Optional ByVal esEntero As Boolean = False, Optional ByVal esDecimal As Boolean = False,
                                  Optional ByVal esFecha As Boolean = False, Optional ByVal esFechaHora As Boolean = False,
                                  Optional ByVal aplicarFormato As Boolean = True) As Telerik.Reporting.TextBox

        txt = New Telerik.Reporting.TextBox()
        With txt
            .Name = "txt" & IIf(titulo, "Tit", "") & nombre

            .Size = New Telerik.Reporting.Drawing.SizeU(New Telerik.Reporting.Drawing.Unit(anchoMM, Telerik.Reporting.Drawing.UnitType.Mm), New Telerik.Reporting.Drawing.Unit(0.4R, Telerik.Reporting.Drawing.UnitType.Cm))
            .Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
            .CanShrink = False
            .CanGrow = True ' False

            If titulo Then
                .Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center 'Por defecto, centrado. Luego puede cambiar.
                .Style.Font.Size = New Unit(9)
                .Style.Font.Bold = True
                .Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
                .Style.BorderWidth.Default = New Unit(1, UnitType.Point)
            Else
                .Style.Font.Size = New Unit(8)
                .Style.Font.Bold = False
                .Style.BorderStyle.Default = BorderType.None
                .Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
                .Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
                .Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
                If esUltima Then
                    .Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
                Else
                    .Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
                End If
                .Style.BorderWidth.Default = New Unit(0.4, UnitType.Point)
            End If

            If aplicarFormato Then
                If esEntero Or esDecimal Then 'Número
                    .Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
                    If esEntero Then
                        .Format = "{0:N0}"
                    Else
                        .Format = "{0:N2}"
                    End If
                Else
                    If esFecha Or esFechaHora Then 'Fecha
                        .Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
                        If esFecha Then
                            .Format = "{0:d}"
                        Else
                            .Format = "{0:g}"
                        End If
                    Else 'String
                        .Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
                        .Format = ""
                    End If
                End If
            End If

            .Value = propiedad

        End With

        If txt.Size.Width.Value > anchoMM Then
            Dim b = 2
        End If
        Return txt
    End Function
    Private Function getDatoMax(ByRef dt As DataTable, ByVal nombre As String, ByVal fuente As System.Drawing.Font)
        Dim c As System.Data.DataColumn = dt.Columns.Item(nombre)
        Dim lst = (From r As DataRow In dt.Rows Select largo = CType(r(nombre), String).Length Order By largo Descending).ToList
        If lst IsNot Nothing AndAlso lst.Count > 0 Then
            Dim l = lst.First
            Dim txtLargo As New Windows.Forms.TextBox
            Dim a = txtLargo.CreateGraphics().MeasureString(l, fuente).Width
        End If
        Return 0
    End Function
End Class