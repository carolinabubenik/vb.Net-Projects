
Imports modEntities
Imports Telerik.WinControls.UI

Public Class FrmListados
    Protected X = 20, Y = 25
    Dim Cls As New ClsListado
    Dim ClsRep As New ClsReportes(Me)
    Dim nombreList As String

#Region "Inicializar"
    Public Sub New(ByVal nombreListado As String)
        InitializeComponent()
        nombreList = nombreListado
    End Sub
    'Public Sub New(ByVal nombreListado As String, ByVal strParametros As String)
    '    InitializeComponent()
    '    nombreList = nombreListado
    'End Sub
    Private Sub FrmListados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modEstilos.ClsEstilo.AplicarEstilo(Me, ClsVariablesSesion.Instancia)
        Me.WindowState = FormWindowState.Maximized

        'Caro 2019-03-12: No estaba esto y es necesario para las autorizaciones.
        MostrarSeccionAutorizacion()

        InicializarListado() '--> Shown
    End Sub
    'Private Sub FrmListados_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
    '    InicializarListado()
    'End Sub

    ''' <summary>
    ''' Busca el listado deseado y los parámetros que se deben solicitar al usuario
    ''' </summary>
    Private Sub InicializarListado()
        Cls.CargarListado(nombreList)
        If Cls.Listado.id = 0 Then
            Exit Sub
        End If

        Me.Text = Cls.Listado.nombre_alias

        'mostrar parametros
        If Cls.Listado.lstListadoParametro.Any Then

            Dim provObligatorio As Boolean = True

            Dim idDefProvincia As Integer = 0

            Dim idParamProvincia As Integer = 0

            Dim locObligatorio As Boolean = True

            Dim idDefLocalidad = 0

            Dim idParamLocalidad As Integer = 0

            Dim cargarProvincia As Boolean = False

            Dim cargarLocalidad As Boolean = False

            For Each lp In Cls.Listado.lstListadoParametro.OrderBy(Function(x) x.vOrdenAdic).ToList
                Select Case lp.tipo
                    Case listado_parametro.TIPO_NUMERO '"NUMERO"
                        Dim def = lp.vDefectoOtroAdic
                        If lp.vVisibleAdic Then
                            ClsRep.AgregarTexto(X, Y, Me.spcIzq.Panel1, lp.id, lp.nombre_alias, True, def)
                        Else
                            lp.vValor = def
                        End If

                    Case listado_parametro.TIPO_TEXTO  '"TEXTO"
                        Dim def = lp.vDefectoOtroAdic
                        If lp.vVisibleAdic Then
                            ClsRep.AgregarTexto(X, Y, Me.spcIzq.Panel1, lp.id, lp.nombre_alias, False, def)
                        Else
                            lp.vValor = def
                        End If

                    Case listado_parametro.TIPO_FECHA  '"FECHA"
                        Dim fechaDef As Date
                        If lp.defecto = listado_parametro.DEFECTO_INICIO_MES Then
                            fechaDef = Cls.FirstDay
                        ElseIf lp.defecto = listado_parametro.DEFECTO_FECHA_HOY Then
                            fechaDef = ClsMain.FechaHoy
                        End If
                        If lp.vVisibleAdic Then
                            ClsRep.AgrFecha(X, Y, Me.spcIzq.Panel1, lp.id, lp.nombre_alias, fechaDef)
                        Else
                            lp.vValor = fechaDef
                        End If

                    Case listado_parametro.TIPO_SUCURSAL  '"SUCURSAL"
                        Dim idDef = 0
                        If lp.defecto = listado_parametro.DEFECTO_SUCURSAL_ACTUAL Then idDef = ClsVariablesSesion.Instancia.Sucursal.id
                        If lp.vVisibleAdic Then
                            ClsRep.ComboSucursal(X, Y, Me.spcIzq.Panel1, lp.id, lp.nombre_alias, idDef, Not lp.vObligatorio)
                        Else
                            lp.vValor = idDef
                        End If

                    Case listado_parametro.TIPO_USUARIO  '"USUARIO"
                        Dim idDef = 0
                        If lp.defecto = listado_parametro.DEFECTO_USUARIO_ACTUAL Then idDef = ClsVariablesSesion.Instancia.Usuario.id
                        If lp.vVisibleAdic Then
                            ClsRep.ComboboxUsuarioTelerik(X, Y, Me.spcIzq.Panel1, lp.id, lp.nombre_alias, True, Not lp.vObligatorio, idDef)
                        Else
                            lp.vValor = idDef
                        End If
                    Case listado_parametro.TIPO_USUARIO_MULTI '"USUARIO"
                        Dim idDef = 0
                        If lp.defecto = listado_parametro.DEFECTO_USUARIO_ACTUAL Then idDef = ClsVariablesSesion.Instancia.Usuario.id
                        If lp.vVisibleAdic Then
                            ClsRep.ComboboxCheckedUsuarioTelerik(X, Y, Me.spcIzq.Panel1, lp.id, lp.nombre_alias, True, False, Not lp.vObligatorio, idDef)
                        Else
                            lp.vValor = idDef
                        End If
                    Case listado_parametro.TIPO_USUARIO_SUCURSAL  '"USUARIO_SUCURSAL"
                        Dim idDef = 0
                        If lp.defecto = listado_parametro.DEFECTO_USUARIO_ACTUAL Then idDef = ClsVariablesSesion.Instancia.Usuario.id
                        If lp.vVisibleAdic Then
                            ClsRep.ComboboxUsuarioTelerik(X, Y, Me.spcIzq.Panel1, lp.id, lp.nombre_alias, False, Not lp.vObligatorio, idDef)
                        Else
                            lp.vValor = idDef
                        End If

                    Case listado_parametro.TIPO_LOGICO  '"LOGICO"
                        Dim Def As Boolean? = Nothing
                        If lp.defecto = listado_parametro.DEFECTO_TRUE Then
                            Def = True
                        ElseIf lp.defecto = listado_parametro.DEFECTO_FALSE Then
                            Def = False
                        End If
                        If lp.vVisibleAdic Then
                            ClsRep.ComboLogico(X, Y, Me.spcIzq.Panel1, lp.id, lp.nombre_alias, Def, Not lp.vObligatorio)
                        Else
                            lp.vValor = Def
                        End If

                    Case listado_parametro.TIPO_CLIENTE_CATEGORIA
                        Dim idDef = 0
                        If lp.vVisibleAdic Then
                            ClsRep.ListaCategoriasCliente(X, Y, Me.spcIzq.Panel1, lp.id, lp.nombre_alias, lp.vObligatorio)
                        Else
                            lp.vValor = idDef
                        End If


                    Case listado_parametro.TIPO_LOCALIDAD, listado_parametro.TIPO_PROVINCIA

                        If lp.tipo = listado_parametro.TIPO_PROVINCIA Then

                            provObligatorio = lp.vObligatorio

                            idParamProvincia = lp.id

                            cargarProvincia = True

                            If lp.defecto = listado_parametro.DEFECTO_PROVINCIA_ACTUAL Then idDefProvincia = ClsVariablesSesion.Instancia.Sucursal.Localidad.provincia_id

                        ElseIf lp.tipo = listado_parametro.TIPO_LOCALIDAD Then

                            locObligatorio = lp.vObligatorio

                            idParamLocalidad = lp.id

                            cargarLocalidad = True

                            If lp.defecto = listado_parametro.DEFECTO_LOCALIDAD_ACTUAL Then idDefLocalidad = ClsVariablesSesion.Instancia.Sucursal.localidad_id

                        End If

                        If lp.vVisibleAdic Then
                            If cargarLocalidad AndAlso cargarProvincia Then
                                ClsRep.ComboLocalidad(X, Y, Me.spcIzq.Panel1, idParamLocalidad, idParamProvincia, lp.nombre_alias, idDefLocalidad, idDefProvincia, locObligatorio, provObligatorio)
                                'ClsRep.ComboLocalidad(X, Y, Me.spcIzq.Panel1, lp.id, lp.nombre_alias, idDef, Not lp.vObligatorio) 'Alex 22-03-2018 tarea 5411
                            End If
                        Else
                            lp.vValor = idDefLocalidad
                        End If

                    Case listado_parametro.TIPO_COMBO_ENUMERADOS
                        'Caro 2018-10-19: Agrego un "combo genérico" para listas que existen en ClsEnumerados.
                        'Los datos necesarios los vamos a cargar como valor por defecto "OTRO", separando con "|"
                        'primero el nombre de la lista, luego el valueMember, y luego el displayMember.
                        Dim idDef = 0
                        If lp.vVisibleAdic Then
                            Dim nombreLista = CType(lp.vDefectoOtroAdic, String).Split("|")(0)
                            Dim nombreValue = CType(lp.vDefectoOtroAdic, String).Split("|")(1)
                            Dim nombreDisplay = CType(lp.vDefectoOtroAdic, String).Split("|")(2)
                            ClsRep.ComboClsEnumeradosTelerik(X, Y, Me.spcIzq.Panel1, lp.id, lp.nombre_alias, Not lp.vObligatorio, nombreLista, nombreDisplay, nombreValue)
                        Else
                            lp.vValor = idDef
                        End If



                End Select
            Next
        End If
    End Sub
    Private Sub ObtenerDatos()
        If Cls.Listado.id > 0 Then
            For Each lp In Cls.Listado.lstListadoParametro
                'lp.vValor = Nothing

                Select Case lp.tipo
                    Case listado_parametro.TIPO_FECHA
                        Dim ctrl = ClsRep.getControl(spcIzq.Panel1, "Fecha" & lp.id, GetType(DateTimePicker))
                        If ctrl IsNot Nothing Then lp.vValor = CType(ctrl, DateTimePicker).Value

                    Case listado_parametro.TIPO_LOGICO
                        Dim ctrl = ClsRep.getControl(spcIzq.Panel1, "cbxLogico" & lp.id, GetType(ComboBox))
                        If ctrl IsNot Nothing Then lp.vValor = CType(ctrl, ComboBox).SelectedValue'Acá no se pregunta ni por nothing ni por cero.

                    Case listado_parametro.TIPO_NUMERO
                        Dim ctrl = ClsRep.getControl(spcIzq.Panel1, "txtNUMERO" & lp.id, GetType(TextBox))
                        If ctrl IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(CType(ctrl, TextBox).Text) Then lp.vValor = CType(ctrl, TextBox).Text

                    Case listado_parametro.TIPO_SUCURSAL
                        Dim ctrl = ClsRep.getControl(spcIzq.Panel1, "cbxSucursal" & lp.id, GetType(ComboBox))
                        If ctrl IsNot Nothing Then
                            If CType(ctrl, ComboBox).SelectedValue > 0 Then
                                lp.vValor = CType(ctrl, ComboBox).SelectedValue
                            Else
                                lp.vValor = ClsVariablesSesion.Instancia.Empresa.lstSucursal.Select(Function(x) x.id).ToList
                            End If
                            'Else 'Si es sucursal y el usuario no seleccionó nada, colocar las sucursales de la empresa.
                            'lp.vValor = ClsVariablesSesion.Instancia.Empresa.lstSucursal.Select(Function(x) x.id).ToList
                        End If

                    Case listado_parametro.TIPO_TEXTO
                        Dim ctrl = ClsRep.getControl(spcIzq.Panel1, "txtTEXTO" & lp.id, GetType(TextBox))
                        If ctrl IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(CType(ctrl, TextBox).Text) Then lp.vValor = CType(ctrl, TextBox).Text

                    Case listado_parametro.TIPO_USUARIO
                        'Caro 2018-06-11: Cambio porque se usa combo de Telerik:
                        'Dim ctrl = ClsRep.getControl(spcIzq.Panel1, "cbxUsuario" & lp.id, GetType(ComboBox))
                        Dim ctrl = ClsRep.getControl(spcIzq.Panel1, "cbxRadUsuarios" & lp.id, GetType(Telerik.WinControls.UI.RadDropDownList))
                        If ctrl IsNot Nothing AndAlso CType(ctrl, Telerik.WinControls.UI.RadDropDownList).SelectedValue > 0 Then lp.vValor = CType(ctrl, Telerik.WinControls.UI.RadDropDownList).SelectedValue
                    Case listado_parametro.TIPO_USUARIO_MULTI
                        'Rodrigo 2018-07-19 Agrego el nuevo control RadCheckedListBox
                        Dim ctrl = ClsRep.getControl(spcIzq.Panel1, "cbxRadUsuariosChecked" & lp.id, GetType(Telerik.WinControls.UI.RadCheckedDropDownList))
                        If ctrl IsNot Nothing AndAlso CType(ctrl, Telerik.WinControls.UI.RadCheckedDropDownList).CheckedItems.Any Then
                            Dim lstItems As New List(Of Integer)
                            For Each items In CType(ctrl, Telerik.WinControls.UI.RadCheckedDropDownList).CheckedItems
                                lstItems.Add(items.Value)
                            Next
                            lp.vValor = lstItems
                        End If

                    Case listado_parametro.TIPO_USUARIO_SUCURSAL
                        Dim ctrl = ClsRep.getControl(spcIzq.Panel1, "cbxUsuario" & lp.id, GetType(ComboBox))
                        If ctrl IsNot Nothing AndAlso CType(ctrl, ComboBox).SelectedValue > 0 Then lp.vValor = CType(ctrl, ComboBox).SelectedValue

                    Case listado_parametro.TIPO_CLIENTE_CATEGORIA
                        Dim ctrl = ClsRep.getControl(spcIzq.Panel1, "clbClienteCat" & lp.id, GetType(CheckedListBox))
                        If ctrl IsNot Nothing AndAlso CType(ctrl, CheckedListBox).CheckedItems.Count > 0 Then
                            lp.vValor = (From i In CType(ctrl, CheckedListBox).CheckedItems Select CType(i, cliente_categoria).id).ToList
                        End If

                    Case listado_parametro.TIPO_LOCALIDAD, listado_parametro.TIPO_PROVINCIA
                        If lp.tipo = listado_parametro.TIPO_LOCALIDAD Then
                            Dim ctrl = ClsRep.getControl(spcIzq.Panel1, "cbxLocalidad" & lp.id, GetType(Telerik.WinControls.UI.RadDropDownList))
                            'Alex 22-03-2018 tarea #5411 se cambio .SelectedValue > 0
                            If ctrl IsNot Nothing AndAlso CType(ctrl, Telerik.WinControls.UI.RadDropDownList).SelectedValue > -1 Then lp.vValor = CType(ctrl, Telerik.WinControls.UI.RadDropDownList).SelectedValue
                        ElseIf lp.tipo = listado_parametro.TIPO_PROVINCIA Then
                            Dim ctrl = ClsRep.getControl(spcIzq.Panel1, "cbxProvincia" & lp.id, GetType(Telerik.WinControls.UI.RadDropDownList))
                            If ctrl IsNot Nothing AndAlso CType(ctrl, Telerik.WinControls.UI.RadDropDownList).SelectedValue > -1 Then lp.vValor = CType(ctrl, Telerik.WinControls.UI.RadDropDownList).SelectedValue
                        End If

                    Case listado_parametro.TIPO_COMBO_ENUMERADOS

                        Dim ctrl = ClsRep.getControl(spcIzq.Panel1, "cbxRadClsEnumerados" & lp.id, GetType(Telerik.WinControls.UI.RadCheckedDropDownList))

                        If ctrl IsNot Nothing AndAlso CType(ctrl, Telerik.WinControls.UI.RadCheckedDropDownList).CheckedItems.Count > 0 Then
                            With CType(ctrl, Telerik.WinControls.UI.RadCheckedDropDownList)
                                Dim valueMem = .ValueMember
                                lp.vValor = (From a In .CheckedItems Select obj = a.DataBoundItem Select CInt(obj.GetType.GetProperty(valueMem).GetValue(obj, Nothing))).ToList
                            End With

                        End If

                End Select
            Next
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.ValidateChildren Then
            ObtenerDatos()
            Dim Rpt As New rptListado
            Rpt.CargarDatos(Cls.Listado)
            Me.ReportViewer1.Report = Rpt
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub
#End Region

    'Caro 2019-03-11: Muevo acá todo lo de autorizaciones
#Region "Autorizaciones"
    Private ReadOnly Property vNombreAutorizacionReporte As String
        Get
            Return "IMPRIMIR_REPORTE_" & nombreList.ToUpper
        End Get
    End Property
    Private Sub MostrarSeccionAutorizacion()
        If modPermisos.ClsPermisos.EstaAutorizadoPara(ClsVariablesSesion.Instancia.Usuario, "AUTORIZAR IMPRESION REPORTES", False) Then
            spcIzq.Panel2Collapsed = False
            modEstilos.ClsEstilo.AplicarPropiedad(lblTitAutorizacion, "ForeColor", "ColorResaltado")
        Else
            spcIzq.Panel2Collapsed = True
        End If
        MostrarAutorizacion()
    End Sub
    Private Sub lklCrearAutorizacion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklCrearAutorizacion.LinkClicked
        If lklCrearAutorizacion.Tag = "CREAR" Then
            modPermisos.ClsPermisos.EstaAutorizadoPara(ClsVariablesSesion.Instancia.Usuario, vNombreAutorizacionReporte, False)
        Else
            Dim aut = ClsEnumerados.Instancia.lst_autorizacion.Find(Function(x) x.nombre.ToUpper = vNombreAutorizacionReporte)
            If aut IsNot Nothing Then
                If aut.lst_UsuarioAutorizado.Count = 0 OrElse MessageBox.Show("La autorización está actualmente asignada a " & aut.lst_UsuarioAutorizado.Count & " usuarios. ¿Está seguro de que desea quitarla?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.None) = DialogResult.Yes Then
                    aut.Delete(Cls.getConn)
                    ClsEnumerados.Instancia.lst_autorizacion = Nothing
                End If
            End If
        End If
        MostrarAutorizacion()
    End Sub
    Private Sub lklUsuarios_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklUsuarios.LinkClicked
        'Sin controlar permisos: si tiene autorización para esta sección, puede asignar los usuarios.
        Dim frm As New modPermisos.FrmUsuariosAutorizados(vNombreAutorizacionReporte)
        frm.MdiParent = Nothing
        frm.ShowDialog()
        MostrarAutorizacion()
    End Sub
    Private Sub MostrarAutorizacion()
        Dim aut = ClsEnumerados.Instancia.lst_autorizacion.Find(Function(x) x.nombre.ToUpper = vNombreAutorizacionReporte)
        If aut IsNot Nothing Then
            lblAutorizacion.Text = aut.nombre
            'ttp.SetToolTip(lblAutorizacion, aut.descripcion)
            lklCrearAutorizacion.Tag = "QUITAR"
            lklCrearAutorizacion.Text = "Quitar Autorización"
            ttp.SetToolTip(lklCrearAutorizacion, "Si quita la autorización, cualquier usuario podrá imprimir o exportar el reporte.")
            lklUsuarios.Visible = True
            If modPermisos.ClsPermisos.EstaAutorizadoPara(ClsVariablesSesion.Instancia.Usuario, vNombreAutorizacionReporte, False) Then
                ReportViewer1.ShowExportButton = True
                ReportViewer1.ShowPrintButton = True
            Else
                ReportViewer1.ShowExportButton = False
                ReportViewer1.ShowPrintButton = False
            End If
        Else
            lblAutorizacion.Text = "(Reporte sin autorización creada)"
            'ttp.SetToolTip(lblAutorizacion, Nothing)
            lklCrearAutorizacion.Tag = "CREAR"
            lklCrearAutorizacion.Text = "Crear Autorización"
            ttp.SetToolTip(lklCrearAutorizacion, "Si agrega una autorización, sólo los usuarios con autorización podrán imprimir o exportar el reporte.")
            lklUsuarios.Visible = False
            ReportViewer1.ShowExportButton = True
            ReportViewer1.ShowPrintButton = True
        End If
    End Sub
#End Region

End Class
