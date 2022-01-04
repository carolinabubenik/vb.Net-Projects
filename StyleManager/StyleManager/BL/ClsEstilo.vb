
Imports modEntities

Public Class ClsEstilo
    Inherits modEntities.ClsMain

#Region "Propiedades"
    Private _EstiloControl As estilo_control
    Private _EstiloPropiedad As estilo_propiedad
    Private _lstEstiloControl As List(Of estilo_control)
    Private _lstEstiloPropiedad As List(Of estilo_propiedad)

    Public Property EstiloControl As estilo_control
        Get
            If _EstiloControl Is Nothing Then
                _EstiloControl = New estilo_control
            End If
            Return _EstiloControl
        End Get
        Set(ByVal value As estilo_control)
            _EstiloControl = value
        End Set
    End Property
    Public Property EstiloPropiedad As estilo_propiedad
        Get
            If _EstiloPropiedad Is Nothing Then
                _EstiloPropiedad = New estilo_propiedad
            End If
            Return _EstiloPropiedad
        End Get
        Set(ByVal value As estilo_propiedad)
            _EstiloPropiedad = value
        End Set
    End Property
    Public Property lstEstiloControl As List(Of estilo_control)
        Get
            If _lstEstiloControl Is Nothing Then
                _lstEstiloControl = New List(Of estilo_control)
            End If
            Return _lstEstiloControl
        End Get
        Set(ByVal value As List(Of estilo_control))
            _lstEstiloControl = value
        End Set
    End Property
    Public Property lstEstiloPropiedad As List(Of estilo_propiedad)
        Get
            If _lstEstiloPropiedad Is Nothing Then
                _lstEstiloPropiedad = New List(Of estilo_propiedad)
            End If
            Return _lstEstiloPropiedad
        End Get
        Set(ByVal value As List(Of estilo_propiedad))
            _lstEstiloPropiedad = value
        End Set
    End Property
    Public ReadOnly Property Prefijo As String
        Get
            Return "System.Windows.Forms"
        End Get
    End Property
#End Region

#Region "Funciones"
    Public Sub New(Optional ByVal ClsVarSes As ClsVariablesSesion = Nothing)
        If ClsVarSes IsNot Nothing Then ClsVariablesSesion.Instancia = ClsVarSes
    End Sub
    Public Shared Sub AplicarEstilo(ByRef frm As Form)
        Dim Aux As New ClsEstilo()
        Aux.AplicarEstilo(frm)
    End Sub

    Dim sts As StatusStrip
    Public Sub AplicarEstilo(ByRef frm As Form, ActivaAutogenerateGrilla As Boolean) 'Optional ActivaAutogenerateGrilla As Boolean = False

        'Configurar propiedades por defecto para un formulario
        frm.Icon = modFunciones.FuncUtiles.Bytes2Icon(ClsVariablesSesion.Instancia.Sucursal.pic_icon) 'Caro 12/03/2015
        frm.AutoScaleMode = AutoScaleMode.None 'Caro 12/03/2015
        frm.AutoValidate = AutoValidate.EnableAllowFocusChange 'Caro 13/05/2015
        frm.KeyPreview = True
        frm.StartPosition = FormStartPosition.CenterScreen 'Caro 13/05/2015
        If ClsVariablesSesion.Instancia.Usuario.lst_UsuarioRol.Exists(Function(x) x.Rol.hasAdicional("PERMISOS", "DEBUG")) Then
            frm.Text &= " => " & frm.Name
        End If
        'Aplicar los estilos
        lstEstiloControl = ClsEnumerados.Instancia.lst_estilo_control
        EstiloAControl(frm, GetType(Form), ActivaAutogenerateGrilla)

        'Agregar manejador de Tecla Presionada al formulario. Se hace una única vez por formulario, por eso va en este método.
        ManejarKeyDown(frm, True)

        'Caro 25/05/2015: Agrego HotKeys a botones básicos del formulario(frmAceptar, frmCancelar, frmBuscar, frmNuevo, frmModificar, frmEliminar)
        'Se recorren todos los controles de nuevo
        HotKeysBasicas(frm)
        'Si se desea cambiar las HotKeys según la pestaña activa de un TabControl, en el SelectedTabChanged invocar a: HotKeysBasicas(tabcontrol1.SelectedTab)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="c">Control al que se van a aplicar los estilos</param>
    ''' <param name="tipo">Es necesario pasarle tipo "Form" a los formularios ya que cada uno tiene un tipo diferente</param>
    ''' <remarks></remarks>
    Public Sub EstiloAControl(ByVal c, Optional ByVal tipo = Nothing, Optional ActivaAutoGenerationGrilla = False)
        EstiloControl = lstEstiloControl.Find(Function(x) (c.GetType.ToString.ToLower = x.nombre.ToLower OrElse (tipo IsNot Nothing AndAlso tipo.ToString.ToLower = x.nombre.ToLower)))
        If EstiloControl.nombre.Length > 0 Then
            For Each p In EstiloControl.lst_EstiloPropiedad
                Dim prop As Reflection.PropertyInfo
                If tipo IsNot Nothing Then 'si se especificó el tipo 
                    For Each pr In CType(tipo, System.Type).GetProperties
                        If pr.Name.ToLower = p.nombre.ToLower Then
                            prop = pr
                            Exit For
                        End If
                    Next
                Else : prop = c.GetType().GetProperty(p.nombre)
                End If
                If prop IsNot Nothing Then
                    If prop.Name.ToLower = "defaultcellstyle" Then 'Tratamiento de esta propiedad especial. 
                        'Creo un objeto del tipo de la propiedad, para buscar y aplicar los estilos que ésta tenga definidos
                        Dim o = System.Reflection.Assembly.GetAssembly(GetType(DataGridViewCellStyle)).CreateInstance(GetType(DataGridViewCellStyle).ToString)
                        EstiloAControl(o,, ActivaAutoGenerationGrilla)
                        prop.SetValue(c, o, Nothing)
                    Else 'el caso normal
                        asignarValor(c, prop, p.valor)
                    End If
                End If
            Next
        End If

        If TypeOf (c) Is DataGridView Then
            CType(c, DataGridView).AutoGenerateColumns = ActivaAutoGenerationGrilla 'Caro 26/05/2015: Poner en autogenereateColumns.
        End If

        'Recorro las colecciones que tenga para seguir aplicando los estilos 
        For Each p In (From prop In c.GetType.GetProperties Where prop.PropertyType.Name.ToLower.Contains("collection")).ToList
            'Caro 26/05/2016: Para que no dé error con el RadList de Telerik
            If p.GetValue(c, Nothing).GetType.GetProperty("Count") IsNot Nothing Then
                For Each hijo In p.GetValue(c, Nothing)
                    EstiloAControl(hijo,, ActivaAutoGenerationGrilla)
                Next
                'Else
            End If
        Next
    End Sub
    Private Shared Sub asignarValor(ByVal c, ByVal prop, ByVal valor)
        If valor.ToString.Length > 0 Then
            With CType(prop, System.Reflection.PropertyInfo)
                Select Case .PropertyType
                    Case GetType(Color)
                        prop.SetValue(c, getColor(valor), Nothing)
                    Case GetType(Font)
                        prop.SetValue(c, getFont(valor), Nothing)
                    Case GetType(Point), GetType(Size)
                        prop.SetValue(c, getPoint(valor), Nothing)
                    Case Else
                        prop.SetValue(c, valor, Nothing)
                End Select
            End With
        End If
    End Sub
    Public Shared Function getColor(ByVal valor As String) As Color
        'Caro 29/09/2015: Lo moví a modFunciones
        Return modFunciones.FuncUtiles.getColor(valor)
        'valor = valor.Replace("Color [", "")
        'valor = valor.Replace("]", "")
        'If valor.Contains(",") Then
        '    Dim a As New List(Of Integer)
        '    For Each s In valor.Split(",")
        '        a.Add(s.Substring(s.IndexOf("=") + 1))
        '    Next
        '    If a.Count > 3 Then
        '        Return Color.FromArgb(a(0), a(1), a(2), a(3))
        '    Else
        '        Return ColorTranslator.FromOle(RGB(a(0), a(1), a(2)))
        '    End If
        'Else
        '    Return Color.FromName(valor)
        'End If
    End Function
    Private Shared Function getFont(ByVal valor As String) As Font
        valor = valor.Replace("[Font:", "")
        valor = valor.Replace("]", "")
        Dim a As New List(Of String)
        For Each s In valor.Split(",")
            a.Add(s.Substring(s.IndexOf("=") + 1))
        Next
        Dim st As New FontStyle
        Select Case a(2).ToLower
            Case "bold"
                st = FontStyle.Bold
            Case "regular"
                st = FontStyle.Regular
            Case "italic"
                st = FontStyle.Italic
            Case "strikeout"
                st = FontStyle.Strikeout
            Case "underline"
                st = FontStyle.Underline
            Case Else
                st = FontStyle.Regular
        End Select
        Return New Font(a(0), CType(a(1), Single), st)
    End Function
    Private Shared Function getPoint(ByVal valor As String) As Point
        Dim a As New List(Of Integer)
        For Each s In valor.Split(",")
            a.Add(s.Substring(s.IndexOf("=") + 1))
        Next
        Return New Point(a(0), a(1))
    End Function
    Public Sub GuardarControlPropiedad()
        IniciarTrn()
        Try
            'EstiloControl.InsertUpdate(getConn, gettrn)
            EstiloPropiedad.Estilo_control.InsertUpdate(getConn, gettrn)
            EstiloPropiedad.estilo_control_id = EstiloPropiedad.Estilo_control.id
            EstiloPropiedad.InsertUpdate(getConn, gettrn)
            gettrn.Commit()
        Catch ex As Exception
            gettrn.Rollback()
            MessageBox.Show(ex.Message)
        End Try
        ClsEnumerados.Instancia.lst_estilo_control = Nothing
        ClsEnumerados.Instancia.lst_estilo_propiedad = Nothing
    End Sub
    Public Sub EliminarPropiedad()
        Me.EstiloPropiedad.Delete(getConn, gettrn)
        ClsEnumerados.Instancia.lst_estilo_control = Nothing
        ClsEnumerados.Instancia.lst_estilo_propiedad = Nothing
    End Sub

    '-------------- 
    ''' <summary>
    ''' Aplica a la propiedad "propiedadControl" del control "ctrl" el valor configurado para la propiedad "propiedadAAplicar"
    ''' </summary>
    ''' <param name="ctrl">Control al cual aplicar la propiedad. Ej: un label (Label1)</param>
    ''' <param name="propiedadControl">Nombre de la propiedad del control a la que se le va a colocar el valor. Ej: "ForeColor".</param>
    ''' <param name="propiedadAAplicar">Nombre de la propiedad configurada con los valores deseados. Ej: "ColorResaltado"</param>
    ''' <remarks>Si falla en algún caso, el control queda sin modificaciones.</remarks>
    Public Shared Sub AplicarPropiedad(ByVal ctrl As Control, ByVal propiedadControl As String, ByVal propiedadAAplicar As String)
        'Obtener la propiedad deseada del control
        Dim lstP = (From pr In ctrl.GetType.GetProperties Where pr.Name.ToLower = propiedadControl.ToLower)
        If lstP.Count > 0 Then
            Dim propCtrl = lstP.First

            'Obtener los estilos definidos para el control
            Dim ec = ClsEnumerados.Instancia.lst_estilo_control.Find(Function(x) x.nombre.ToLower = ctrl.GetType.ToString.ToLower)
            If ec IsNot Nothing Then

                'Obtener la propiedad deseada a aplicar
                Dim ep = ec.lst_EstiloPropiedad.Find(Function(x) x.nombre.ToLower = propiedadAAplicar.ToLower)
                If ep IsNot Nothing Then
                    asignarValor(ctrl, propCtrl, ep.valor)
                End If
            End If
        End If
    End Sub


#Region "Solo Lectura a Formularios"
    ''' <summary>
    ''' Inhabilita todos los controles de un formulario.
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <remarks>No lo hace con controles contenedores, como paneles o groupBoxes.
    ''' Si se desea habilitar algún control especial, hacerlo puntualmente luego de llamar a este método.</remarks>
    Public Shared Sub HacerSoloLectura(ByRef frm As Form)
        'Caro 04/05/2015: Lo hago igual que hice MostrarOcultarPrueba en Antuan.FrmGestionCliente
        For Each c As Control In frm.Controls
            SoloLecturaControl(c)
            SoloLecturaHijos(c.Controls)
        Next
    End Sub
    Public Event RefreshNeeded(ByVal Motivo As String)
    Public Shared Sub SoloLecturaHijos(ByVal lstCtrl As System.Windows.Forms.Control.ControlCollection)
        For Each c As Control In lstCtrl
            SoloLecturaControl(c)
            SoloLecturaHijos(c.Controls)
            If c.ContextMenuStrip IsNot Nothing Then
                For Each i As ToolStripItem In c.ContextMenuStrip.Items
                    SoloLecturaControl(i)
                    If TypeOf (i) Is ToolStripMenuItem Then
                        For Each d In CType(i, ToolStripMenuItem).DropDownItems
                            SoloLecturaControl(d)
                        Next
                    End If
                Next
            End If
        Next
    End Sub
    Private Shared Sub SoloLecturaControl(ByVal c As Object)
        Select Case c.GetType
            Case GetType(Label), GetType(Panel), GetType(GroupBox), GetType(SplitContainer), GetType(SplitterPanel), GetType(TabControl), GetType(TabPage)
                'En estos casos no se hace nada.

            Case GetType(DataGridView) 'Las grillas se habilitan, pero se quita su menú contextual y se ponen ReadOnly
                CType(c, DataGridView).ContextMenuStrip = Nothing
                CType(c, DataGridView).ReadOnly = True
                CType(c, DataGridView).Enabled = True

            Case GetType(TreeView)
                AddHandler CType(c, TreeView).BeforeCheck, AddressOf trv_BeforeCheck
                'For Each n As TreeNode In CType(c, TreeView).Nodes

                'Next
                'AddHandler CType(c, TreeView).DoubleClick, AddressOf trv_DoubleClick
                AddHandler CType(c, TreeView).BeforeSelect, AddressOf trv_BeforeSelect
            Case GetType(TreeNode)
                'Para treeview se cancela si se intenta checkear
            Case Else
                'Los demás controles, inhabilitarlos
                c.enabled = False
        End Select
    End Sub
    Private Shared Sub trv_BeforeCheck(ByVal sender As Object, ByVal e As TreeViewCancelEventArgs)
        'Cancelar el check en un treeview
        e.Cancel = True
    End Sub
    Private Shared Sub trv_BeforeSelect(sender As Object, e As TreeViewCancelEventArgs)
        e.Cancel = True
    End Sub
    'Private Shared Sub trv_DoubleClick(sender As Object, e As EventArgs)
    '    MessageBox.Show(sender.ToString)
    '    MessageBox.Show(e.ToString)
    'End Sub
    'No anda
    'Public Class MyTreeView
    '    Inherits TreeView
    '    'Protected Overrides Sub WndProc(ByRef m As Message)
    '    '    'Suppress WM_LBUTTONDBLCLK
    '    '    If (m.Msg = &H203) Then
    '    '        m.Result = IntPtr.Zero
    '    '    Else
    '    '        MyBase.WndProc(m)
    '    '    End If
    '    'End Sub

    '    Protected Overrides Sub WndProc(ByRef m As Message)

    '        ' Suppress WM_LBUTTONDBLCLK
    '        If (m.Msg = &H203) Then
    '            Dim Hitpoint As Point = New Point(CInt(m.LParam))
    '            Dim tvhti As TreeViewHitTestInfo = HitTest(Hitpoint)
    '            If tvhti IsNot Nothing AndAlso tvhti.Location = TreeViewHitTestLocations.StateImage Then
    '                Me.SelectedNode = tvhti.Node
    '                Dim tvs As New TreeNodeMouseClickEventArgs(Me.SelectedNode, Windows.Forms.MouseButtons.Left, 2, Hitpoint.X, Hitpoint.Y)
    '                Dim mvs As New MouseEventArgs(Windows.Forms.MouseButtons.Left, 2, Hitpoint.X, Hitpoint.Y, 0)
    '                OnNodeMouseDoubleClick(tvs)
    '                OnMouseDoubleClick(mvs)
    '                OnDoubleClick(New EventArgs)
    '                If tvhti.Node.IsExpanded Then
    '                    SendKeys.Send("{LEFT}")
    '                Else
    '                    SendKeys.Send("{RIGHT}")
    '                End If
    '                m.Result = IntPtr.Zero
    '                Return
    '            Else
    '                MyBase.WndProc(m)
    '            End If
    '        Else
    '            MyBase.WndProc(m)
    '        End If
    '    End Sub
    'End Class
#End Region

#Region "HotKeys Dinamico"
    Private lstCombinaciones As New List(Of combinacionTecla) 'En el primer elemento se guarda el Button, y en el segundo la combinación de teclas para su click.

    Public Sub ManejarKeyDown(ByRef frm As Form, ByVal agregar As Boolean)
        'Agregar manejador de Tecla Presionada al formulario. Se hace una única vez por formulario, por eso va en este método.
        'If lstCombinaciones.Count = 0 Then 
        If agregar Then
            AddHandler frm.KeyDown, AddressOf Frm_KeyDown
        Else
            RemoveHandler frm.KeyDown, AddressOf Frm_KeyDown
        End If
        'End If
    End Sub

    ''' <summary>
    ''' Agrega la lógica para accesos de teclados Básicos a un formulario. Ej: Aceptar/Cancelar/Buscar/Nuevo/Modificar/Eliminar
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub HotKeysBasicas(ByRef frm As Form)
        lstCombinaciones.Clear()
        'Identificar la statusBar del fomulario y borrar sus elementos 
        For Each c In frm.Controls
            If c.GetType Is GetType(StatusStrip) Then
                CType(c, StatusStrip).Items.Clear()
            End If
        Next
        For Each c In frm.Controls
            HotKeysAControl(c, frm)
        Next

        AddHandler frm.Shown, AddressOf Frm_Shown
    End Sub
    Private Sub Frm_Shown(sender As Object, e As EventArgs)
        If sts IsNot Nothing Then
            If CType(sender, Form).Controls.Find(sts.Name, True).Count = 0 Then
                CType(sender, Form).Controls.Add(sts)
                CType(sender, Form).Height += sts.Height 'Caro 2019-12-13: Hay pantallas que se ven afectadas al reducir el espacio donde van los controles.. 
                'Hago que se agrande cuando hay una statusStrip
            End If
        End If
    End Sub
    ''' <summary>
    ''' Agrega la lógica para accesos de teclados Básicos a una pestaña. Ej: Aceptar/Cancelar/Buscar/Nuevo/Modificar/Eliminar
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub HotKeysBasicas(ByRef tbp As TabPage, ByRef frm As Form)
        lstCombinaciones.Clear()
        'Identificar la statusBar del fomulario y borrar sus elementos 
        For Each c In frm.Controls
            If c.GetType Is GetType(StatusStrip) Then
                CType(c, StatusStrip).Items.Clear()
                Exit For
            End If
        Next

        For Each c In tbp.Controls()
            HotKeysAControl(c, frm)
        Next
    End Sub
    Private Sub HotKeysAControl(ByVal c, ByRef frm)
        'Identificar las funciones básicas por el nombre del control.
        'Aplicar la HotKey correspondiente.
        Dim propNombre = c.GetType.GetProperty("Name")
        If propNombre IsNot Nothing Then
            Dim nombre As String = propNombre.GetValue(c, Nothing)

            If nombre.Trim.Length >= 3 Then
                Dim funcion As String = nombre.Substring(3)
                Dim orden As Integer = 0
                Select Case nombre.ToLower
                    'Case "btnAceptar".ToLower, "btnCancelar".ToLower, "btnBuscar".ToLower, "btnNuevo".ToLower, "btnModificar".ToLower, "btnEliminar".ToLower
                    '    funcion = nombre.Substring(3)

                    Case "btnBuscar".ToLower
                        orden = 10

                    Case "btnNuevo".ToLower
                        orden = 20

                    Case "btnModificar".ToLower
                        orden = 30

                    Case "btnEliminar".ToLower
                        orden = 40

                    Case "btnAceptar".ToLower
                        orden = 50

                    Case "btnCancelar".ToLower
                        orden = 60
                End Select

                If orden > 0 Then
                    AddHotKey(c, CType(frm, Form), funcion.ToUpper, StrConv(funcion, VbStrConv.ProperCase), orden)
                End If
            End If
        End If

        'Recorrer las colecciones del control para seguir aplicando las hotKeys
        For Each p In (From prop In c.GetType.GetProperties Where prop.PropertyType.Name.ToLower.Contains("collection")).ToList
            If p.GetValue(c, Nothing).GetType.GetProperty("Count") IsNot Nothing Then
                For Each hijo In p.GetValue(c, Nothing)
                    HotKeysAControl(hijo, frm)
                Next
                'Else
            End If
        Next
    End Sub
    ''' <summary>
    ''' Permite agregar la HotKey que corresponda a la función indicada para el botón (button) indicado
    ''' </summary>
    Public Sub AddHotKey(ByRef frm As Form, ByRef btn As Button, ByVal funcionParametrizada As String, Optional ByVal nombreLeyenda As String = "")
        AddHotKey(btn, frm, funcionParametrizada, nombreLeyenda)
    End Sub
    ''' <summary>
    ''' Permite agregar la HotKey que corresponda a la función indicada para el botón (ToolStripMenuItem) indicado
    ''' </summary>
    Public Sub AddHotKey(ByRef frm As Form, ByRef btn As ToolStripMenuItem, ByVal funcionParametrizada As String, Optional ByVal nombreLeyenda As String = "")
        AddHotKey(btn, frm, funcionParametrizada, nombreLeyenda)
    End Sub
    ''' <summary>
    ''' Permite agregar la HotKey que corresponda a la función indicada para el botón (ToolStripButton) indicado
    ''' </summary>
    Public Sub AddHotKey(ByRef frm As Form, ByRef btn As ToolStripButton, ByVal funcionParametrizada As String, Optional ByVal nombreLeyenda As String = "")
        AddHotKey(btn, frm, funcionParametrizada, nombreLeyenda)
    End Sub
    ''' <summary>
    ''' Agrega la lógica para manejar una combinación de teclas a un botón, tomando la combinación de lo configurado
    ''' en Parámetros (según el nombre de la función). Agrega una leyenda informativa.
    ''' </summary>
    ''' <param name="btn">Button cuyo evento Click se va a desencadenar al detectar la combinación de teclas presionada.</param>
    ''' <param name="frm">Formulario que contiene el botón.</param>
    ''' <param name="funcionParametrizada">Nombre de la función a buscar en los parametros. Ej: ACEPTAR; CANCELAR/SALIR; NUEVO; etc.</param>
    ''' <param name="nombreLeyenda">Leyenda a mostrar al pie del formulario. Si se omite, se muestra el nombre de la función. Ej: "Nuevo Presupuesto".</param>
    ''' <remarks></remarks>
    Private Sub AddHotKey(ByRef btn As Object, ByRef frm As Form, ByVal funcionParametrizada As String, Optional ByVal nombreLeyenda As String = "", Optional ByVal orden As Integer = 0)

        Dim nombreBtn = btn.Name

        If Not lstCombinaciones.Exists(Function(x) x.btn.Name = nombreBtn) Then

            'Acá se hacía: AddHandler KeyDown (Movido a AplicarEstilo para que se haga una única vez por formulario)

            ''Limpiar todo lo de este botón --> No, si ya existe no se hace nada m{as.
            'lstCombinaciones.RemoveAll(Function(x) x.btn.Name = nombreBtn)

            'Dim sts As StatusStrip Caro 09/10/2015
            'Identificar la statusBar del fomulario. Si no existe, crear una nueva.
            If sts Is Nothing Then
                For Each c In frm.Controls
                    If c.GetType Is GetType(StatusStrip) Then
                        sts = c
                        Exit For
                    End If
                Next
            End If

            'Traer por parametro la combinación de teclas para la función      / ej teclas para Modificar / Nuevo / Cancelar-salir / Eliminar-quitar 
            Dim teclas = parametro.GetValor("ATAJO " & funcionParametrizada.Trim.ToUpper, "", "Combinación de teclas para la función: " & funcionParametrizada.Trim & ". Se separan con ""+"" y puede contener ALT, ENTER, SHIFT, CTRL. Ej: ALT+M+O")
            If teclas.Trim.Length > 0 Then

                If sts Is Nothing Then 'Sólo se agrega si existe una combinación configurada.
                    sts = New StatusStrip
                    sts.Name = "stsHotKeys"
                    'frm.Height += sts.Height 'Se aumenta el alto del formulario en el alto de la barra de estado, para que no le quite espacio.
                    'frm.Controls.Add(sts) ' C ARO 09/10/2015
                End If

                'Resguardar en una lista el botón con su combinación de teclas para usarlo en el KeyDown.
                lstCombinaciones.Add(New combinacionTecla(btn, teclas))

                'Agregar un label con la leyenda: teclas = nombre. 
                Dim lbl As New ToolStripStatusLabel
                lbl.Tag = orden 'En el tag se guarda el orden
                If nombreLeyenda.Trim.Length > 0 Then
                    lbl.Text = teclas & "=" & nombreLeyenda.Trim
                Else
                    lbl.Text = teclas & "=" & funcionParametrizada.Trim
                End If
                If TypeOf (btn) Is Button Then
                    lbl.Font = New Font(CType(btn, Button).Font.FontFamily, btn.Font.Size - 1, FontStyle.Regular)
                ElseIf TypeOf (btn) Is ToolStripMenuItem Then
                    lbl.Font = New Font(CType(btn, ToolStripMenuItem).Font.FontFamily, btn.Font.Size - 1, FontStyle.Regular)
                ElseIf TypeOf (btn) Is ToolStripButton Then
                    lbl.Font = New Font(CType(btn, ToolStripButton).Font.FontFamily, btn.Font.Size - 1, FontStyle.Regular)
                ElseIf TypeOf (btn) Is ToolStripSplitButton Then
                    lbl.Font = New Font(CType(btn, ToolStripSplitButton).Font.FontFamily, btn.Font.Size - 1, FontStyle.Regular)
                End If
                'Se agrega en el orden indicado, o al final si orden=0
                If orden = 0 Then
                    sts.Items.Add(lbl)
                Else
                    Dim ix = sts.Items.Count 'Se inicializa para ponerlo al final
                    For Each i In sts.Items
                        If orden <= i.tag Then
                            ix = sts.Items.IndexOf(i)
                            Exit For
                        End If
                    Next
                    sts.Items.Insert(ix, lbl)
                End If
            End If
        End If
    End Sub
    Private Sub Frm_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        For Each c In lstCombinaciones
            If modFunciones.FuncUtiles.PresionoTeclas(e, c.teclas) Then
                Dim btn = c.btn
                If TypeOf (btn) Is Button Then
                    CType(btn, Button).Select()
                    CType(btn, Button).PerformClick()
                    e.SuppressKeyPress = True 'Agregado el 08/10/2015

                    Exit Sub

                ElseIf TypeOf (btn) Is ToolStripMenuItem Then
                    CType(btn, ToolStripMenuItem).Select()
                    CType(btn, ToolStripMenuItem).PerformClick()
                    e.SuppressKeyPress = True 'Agregado el 08/10/2015
                    Exit Sub

                ElseIf TypeOf (btn) Is ToolStripButton Then
                    CType(btn, ToolStripButton).Select()
                    CType(btn, ToolStripButton).PerformClick()
                    e.SuppressKeyPress = True 'Agregado el 08/10/2015
                    Exit Sub

                ElseIf TypeOf (btn) Is ToolStripSplitButton Then
                    CType(btn, ToolStripSplitButton).Select()
                    CType(btn, ToolStripSplitButton).PerformButtonClick()
                    e.SuppressKeyPress = True 'Agregado el 08/10/2015
                    Exit Sub

                End If
            End If
        Next
    End Sub
    Private Class combinacionTecla
        ''' <summary>
        ''' Debe ser Button o ToolStripMenuItem o ToolStripButton
        ''' </summary>
        Friend Property btn As Object
        Friend teclas As String
        Friend Sub New(ByVal btn As Object, ByVal teclas As String)
            Me.btn = btn
            Me.teclas = teclas
        End Sub
    End Class

    Public Shared Function PresionoPrueba(ByVal e As KeyEventArgs) As Boolean
        Dim atajoPrueba = parametro.GetValor("ATAJO PRUEBA", "F11", "Atajo de teclas para mostrar/ocultar filtro prueba. Admite, separados por ""+"": Ctrl, Shift, Alt, Enter, Esc, y cualquier caracter, número o tecla de función (F)", ClsEnumerados.Acceso.ALTO, "ATAJOS DE TECLADO")
        Return modFunciones.FuncUtiles.PresionoTeclas(e, atajoPrueba)
    End Function
#End Region

#End Region
End Class
