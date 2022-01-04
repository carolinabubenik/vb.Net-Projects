
Imports modEntities

Public Class ClsComunicacion
    Inherits modEntities.ClsMain
#Region "Objetos"
    Private _Comunicacion As comunicacion
    Private _Comunicacion_linea As comunicacion_linea
    Private _Comunicacion_categoria As comunicacion_cat
    Private _Motivo As motivo
    Private _Auditoria As auditoria
    Private _Cliente As cliente
    Public Property Comunicacion As comunicacion
        Get
            If _Comunicacion Is Nothing Then
                _Comunicacion = New comunicacion
            End If
            Return _Comunicacion
        End Get
        Set(ByVal value As comunicacion)
            _Comunicacion = value
        End Set
    End Property
    Public Property Comunicacion_linea As comunicacion_linea
        Get
            If _Comunicacion_linea Is Nothing Then
                _Comunicacion_linea = New comunicacion_linea
                _Comunicacion_linea.EstadoFila = "N"
            End If
            Return _Comunicacion_linea
        End Get
        Set(ByVal value As comunicacion_linea)
            _Comunicacion_linea = value
        End Set
    End Property
    Public Property Comunicacion_categoria As comunicacion_cat
        Get
            If _Comunicacion_categoria Is Nothing Then
                _Comunicacion_categoria = New comunicacion_cat
                _Comunicacion_categoria.EstadoFila = "N"
            End If
            Return _Comunicacion_categoria
        End Get
        Set(ByVal value As comunicacion_cat)
            _Comunicacion_categoria = value
        End Set
    End Property
    Public Property Motivo As motivo
        Get
            If _Motivo Is Nothing Then
                _Motivo = New motivo
            End If
            Return _Motivo
        End Get
        Set(ByVal value As motivo)
            _Motivo = value
        End Set
    End Property
    Public Property Auditoria As auditoria
        Get
            If _Auditoria Is Nothing Then
                _Auditoria = New auditoria
            End If
            Return _Auditoria
        End Get
        Set(ByVal value As auditoria)
            _Auditoria = value
        End Set
    End Property
    Public Property Cliente As cliente
        Get
            If _Cliente Is Nothing Then
                _Cliente = New cliente
            End If
            Return _Cliente
        End Get
        Set(ByVal value As cliente)
            _Cliente = value
        End Set
    End Property
#End Region
#Region "Listas"
    Private _lstComunicacion As List(Of comunicacion)
    Private _Motivos As List(Of motivo)
    Private _lst_ComunicacionCat As List(Of comunicacion_cat)
    Private _lst_ComunicacionEstado As List(Of String)
    Private _lst_RespComunicacionEstado As List(Of String)
    Public Property lstComunicacion As List(Of comunicacion)
        Get
            If _lstComunicacion Is Nothing Then
                _lstComunicacion = New List(Of comunicacion)
            End If
            Return _lstComunicacion
        End Get
        Set(ByVal value As List(Of comunicacion))
            _lstComunicacion = value
        End Set
    End Property
    Public Property Motivos As List(Of motivo)
        Get
            Return ClsEnumerados.Instancia.Motivos
        End Get
        Set(ByVal value As List(Of motivo))
            _Motivos = value
        End Set
    End Property
    Public Property lst_ComunicacionCat As List(Of comunicacion_cat)
        Get
            Return ClsEnumerados.Instancia.lst_ComunicacionCat
        End Get
        Set(ByVal value As List(Of comunicacion_cat))
            _lst_ComunicacionCat = value
        End Set
    End Property


    Public Property lst_ComunicacionEstado As List(Of String)
        Get
            If _lst_ComunicacionEstado Is Nothing Then
                _lst_ComunicacionEstado = New List(Of String)
            End If
            'For Each s As String In ClsEnumerados.Instancia.lst_Estado_Comunicacion
            For Each s As comunicacion_estado In (ClsEnumerados.Instancia.lst_ComunicacionEstado.FindAll(Function(x) Not x.vDadaDeBaja).ToList)
                _lst_ComunicacionEstado.Add(String.Copy(s.nombre))
            Next
            Return _lst_ComunicacionEstado
        End Get
        Set(ByVal value As List(Of String))
            _lst_ComunicacionEstado = value
        End Set
    End Property

    Public Property lst_RespComunicacionEstado As List(Of String)
        Get
            If _lst_RespComunicacionEstado Is Nothing Then
                _lst_RespComunicacionEstado = New List(Of String)
            End If
            'Alex Tareas #5745 2018-07-11
            'For Each s In ClsEnumerados.Instancia.lst_Estado_Comunicacion
            '    Dim a As String = s
            For Each s In ClsEnumerados.Instancia.lst_ComunicacionEstado.FindAll(Function(x) Not x.vDadaDeBaja)
                Dim a As String = s.nombre
                _lst_RespComunicacionEstado.Add(a)
            Next
            Return _lst_RespComunicacionEstado
        End Get
        Set(ByVal value As List(Of String))
            _lst_RespComunicacionEstado = value
        End Set
    End Property
#End Region
#Region "Funciones y Rutinas"
    Public Sub New()
        ResetearColoresDialogos()
    End Sub
    Public Sub New(ByVal ClsVarSes As ClsVariablesSesion)
        ClsVariablesSesion.Instancia = ClsVarSes
        ResetearColoresDialogos()
    End Sub
    Public Sub CargarComunicacionesCliente(ByVal Desde As Date, ByVal Hasta As Date, Optional ByVal estado As String = "", Optional ByVal categoria_id As Integer = 0)
        lstComunicacion = Comunicacion.FillListByFilter(getConn, Desde, Hasta, estado, categoria_id, "CLIENTE", Cliente.entidad_id)
    End Sub
    Public Sub pintarComunicacionesAVencer(ByRef dgview As DataGridView)
        Dim diasVencimiento As Integer = parametro.GetValor("COMUNICACION_CANTIDAD_DIAS_HASTA_VENCIMIENTO", "1", "Valor en días antes del vencimiento de una comunicación", ClsEnumerados.Acceso.BAJO)
        Dim fechaActual As Date = ClsVariablesSesion.Instancia.FechaHoy
        Dim vencimiento As Date
        Dim diferenciaFechas As Integer
        For Each r As DataGridViewRow In dgview.Rows
            With CType(r.DataBoundItem, comunicacion)
                If Not .Comunicacion_estado.cerrar Then
                    vencimiento = .fecha_vencimiento
                    diferenciaFechas = DateDiff("d", fechaActual, vencimiento)
                    If diferenciaFechas > 0 And diferenciaFechas <= diasVencimiento Then
                        r.DefaultCellStyle.ForeColor = Color.Orange
                    ElseIf diferenciaFechas <= 0 Then
                        r.DefaultCellStyle.ForeColor = Color.Red
                    End If
                End If
            End With
        Next
    End Sub

    Public Function VerLegajoProveedor(ByVal entidadId As Integer) As String
        Return proveedor.FillListByEntidad(entidadId, ClsVariablesSesion.Instancia.getConn).First.legajo
    End Function

    Public Function ComunicacionesEmergentes(ByRef entidadId As Integer, Optional ByVal esUsuario As Boolean = False) As List(Of comunicacion)
        Return Comunicacion.FillListByEmergentes(ClsVariablesSesion.Instancia.getConn, entidadId, esUsuario)
    End Function
    Public Sub PersistirComunicacion(Optional ByVal incremento As Integer = 0)
        With Comunicacion_linea
            'Caro 22/10/2014: Agrego!! porque puede que no se esté seteando en todos los lugares.
            If .sucursal_id = 0 Then .sucursal_id = ClsVariablesSesion.Instancia.Sucursal.id

            If .Comunicacion.EstadoFila = "N" Then
                .Comunicacion.fecha_hora = FechaHora
                .comunicacion_id = .Comunicacion.Insert(getConn, gettrn)
                .Insert(getConn, gettrn)
                If incremento > 0 Then
                    .fechahora = .fechahora.AddSeconds(incremento)
                    .Update(getConn, gettrn) 'Para que agregue el incremento
                End If
            ElseIf .Comunicacion.EstadoFila = "U" Then
                .Comunicacion.Update(getConn, gettrn)
                If Comunicacion_linea.EstadoFila = "U" Then
                    .Update(getConn, gettrn)
                Else
                    .Insert(getConn, gettrn)
                    If incremento > 0 Then
                        Comunicacion_linea.FillBycomunicacion_linea(.id, getConn)
                        .fechahora = .fechahora.AddSeconds(incremento)
                        .Update(getConn, gettrn) 'Para que agregue el incremento
                    End If
                End If
            End If



        End With
    End Sub
    Public Sub PersistirComunicacionCategoria()
        With Comunicacion_categoria
            If .EstadoFila = "N" Then
                .Insert(getConn, gettrn)
                ClsEnumerados.Instancia.lst_ComunicacionCat.Add(Comunicacion_categoria)
            ElseIf .EstadoFila = "U" Then
                .Update(getConn, gettrn)
            ElseIf .EstadoFila = "D" Then
                .Delete(getConn, gettrn)
                ClsEnumerados.Instancia.lst_ComunicacionCat.Remove(Comunicacion_categoria)
            End If
        End With
    End Sub
    Public Function PersistirAuditoria() As Boolean
        IniciarTrn()
        Try
            With Me.Auditoria
                .fecha_hora = Now
                If .EstadoFila = "N" Then
                    .Insert(getConn, gettrn)
                ElseIf .EstadoFila = "U" Then
                    .Update(getConn, gettrn)
                ElseIf .EstadoFila = "D" Then
                    .Delete(getConn, gettrn)
                End If
            End With
            gettrn.Commit()
            Return True
        Catch ex As Exception
            gettrn.Rollback()
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function
    Public Sub ArmarArbolMotivos(ByVal TrV As TreeView, Optional ByRef verEliminados As Boolean = False)
        Dim arbolPadre As TreeNode
        Dim lstMotivos As List(Of motivo)
        If verEliminados Then
            Dim lstMotivosEliminados = (From objeto As motivo In ClsEnumerados.Instancia.Motivos Where objeto.vDadaDeBaja Select objeto).ToList
            Dim lstPadreEliminados As New List(Of motivo)
            Dim motivoPadre As New motivo
            For Each motivoEliminado In lstMotivosEliminados
                motivoPadre = buscarPadreEliminados(motivoEliminado)
                lstPadreEliminados.Add(motivoPadre)
            Next
            lstMotivos = lstPadreEliminados
        Else
            lstMotivos = (From objeto As motivo In ClsEnumerados.Instancia.Motivos Where objeto.motivo_padre_id = 0 And Not objeto.vDadaDeBaja Select objeto).ToList
        End If

        'Por cada motivo raíz (padre_id=0)
        For Each obj As motivo In lstMotivos
            'Creo las primeras ramas
            arbolPadre = New TreeNode
            arbolPadre.Tag = obj
            arbolPadre.Text = obj.vDescripcionPertenece
            TrV.Nodes.Add(arbolPadre)
            crearHijosMotivos(arbolPadre, verEliminados)
        Next
    End Sub

    Private Function buscarPadreEliminados(ByRef nodo As motivo) As motivo
        If nodo.motivo_padre_id = 0 Then
            Return nodo
        Else
            buscarPadreEliminados(nodo.Motivo_padre)
        End If
        Return nodo
    End Function
    Private Sub crearHijosMotivos(ByVal nodoPadre As TreeNode, Optional ByRef verEliminados As Boolean = False)
        Dim arbolHijo As New TreeNode
        Dim lstMotivos As List(Of motivo)
        If verEliminados Then
            lstMotivos = (From objeto As motivo In ClsEnumerados.Instancia.Motivos Where objeto.motivo_padre_id = CType(nodoPadre.Tag, motivo).id And objeto.motivo_padre_id > 0 Select objeto).ToList
        Else
            lstMotivos = (From objeto As motivo In ClsEnumerados.Instancia.Motivos Where objeto.motivo_padre_id = CType(nodoPadre.Tag, motivo).id And objeto.motivo_padre_id > 0 And Not objeto.vDadaDeBaja Select objeto).ToList
        End If
        For Each obj As motivo In lstMotivos
            arbolHijo = nodoPadre.Nodes.Add(obj.vDescripcionPertenece)
            arbolHijo.Tag = obj
            crearHijosMotivos(arbolHijo)
        Next
    End Sub
    Public Function getArbolMotivos(ByVal Id As Integer, ByVal Separador As String, Optional ByVal separadorAnterior As String = "") As List(Of motivo)
        Dim Salida As New List(Of motivo)
        Dim lstMotivos = (From x In ClsEnumerados.Instancia.Motivos Where x.motivo_padre_id = Id And Not x.vDadaDeBaja Select x).ToList
        If lstMotivos.Count = 0 Then
            Separador = separadorAnterior
        End If
        For Each M In lstMotivos
            M.descripcionModif = IIf(M.motivo_padre_id = 0, "", Separador) & M.descripcion
            Salida.Add(M)
            If M.id = 0 Then
                Dim b = 0
            End If
            Salida.AddRange(getArbolMotivos(M.id, M.descripcionModif & "->", separadorAnterior))
        Next
        Return Salida
    End Function
    Public Function CargarListaPadres(Optional ByVal objMotivo As motivo = Nothing) As List(Of motivo)
        ''Si se pasa un motivo, se devuelve de su padre para arriba, y ninguno
        ''Si no se pasa, se devuelven sólo los motivos raíz

        Dim lst = New List(Of motivo)
        Dim m As New motivo
        m.descripcion = ""
        lst.Add(m)
        lst.AddRange(Motivos)

        'If objMotivo.id = 0 Then
        '    lst.AddRange(Motivos.FindAll(Function(x) x.id = objMotivo.motivo_padre_id))
        'End If

        Return lst


        'If objMotivo Is Nothing Or objMotivo.motivo_padre_id = 0 Then
        '    Return (From objeto As motivo In Motivos Where objeto.motivo_padre_id = 0 Select objeto).ToList
        'Else
        '    Return (From objeto As motivo In Motivos Where objeto.id = objMotivo.motivo_padre_id Or objeto.motivo_padre_id = objMotivo.motivo_padre_id Select objeto).ToList
        'End If
    End Function
    Public Function VerificarMotivos(ByVal obMot As motivo) As Boolean
        If (From o In Motivos Where obMot.id = o.motivo_padre_id).ToList.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub PersistirMotivo()
        With Motivo
            If .EstadoFila = "D" Then
                .Delete(getConn, gettrn)
            Else
                .InsertUpdate(getConn, gettrn)
            End If
        End With
        ClsEnumerados.Instancia.Motivos = Nothing
    End Sub
    Public Function cargarMotivoId(ByVal Descripcion As String, ByVal categoriaId As Integer, Optional ByVal pertenece As String = "", Optional ByVal motivoPadreId As Integer = 0) As Integer
        Dim m As motivo = ClsEnumerados.Instancia.Motivos.Find(Function(x) x.comunicacion_cat_id = categoriaId AndAlso x.descripcion.ToString.ToUpper.Trim = Descripcion.ToString.ToUpper.Trim)
        If m Is Nothing Then
            Dim cc As comunicacion_cat = ClsEnumerados.Instancia.lst_ComunicacionCat.Find(Function(x) x.id = categoriaId)
            Dim nuevoMotivo As motivo = New motivo
            With nuevoMotivo
                'Si se define un motivo padre lo toma de lo contrario lo carga null
                If motivoPadreId > 0 Then
                    .motivo_padre_id = motivoPadreId
                End If
                .descripcion = Descripcion
                'Si se define un valor para pertenece lo toma de lo contrario lo toma
                'de categoria.
                If pertenece.Length > 0 Then
                    .pertenece = pertenece
                Else
                    .pertenece = cc.pertenece
                End If
                .comunicacion_cat_id = cc.id
                .setAdicional("precargado_sistema", 1)
                Dim exito As Boolean = False
                Try
                    .Insert(ClsVariablesSesion.Instancia.getConn)
                    exito = True
                Catch ex As Exception
                    MessageBox.Show("Se produjo un error: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                If exito Then
                    MessageBox.Show(modRecursos.My.Resources.EXITO_GUARDAR, $"Se creo el motivo { .descripcion} categoria { cc.descripcion}", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    m = nuevoMotivo
                    ClsEnumerados.Instancia.Motivos = Nothing
                End If
            End With
        End If
        Return m.id
    End Function
    Public Function getMotivoId(ByVal Descripcion As String, Optional ByVal padreId As Integer = 0) As Integer
        Dim M As motivo
        Dim a As List(Of motivo)
        If padreId > 0 Then
            a = (From mot In ClsEnumerados.Instancia.Motivos Where mot.descripcion.ToLower.Contains(Descripcion.ToLower) And mot.motivo_padre_id = padreId).ToList
        Else
            a = (From mot In ClsEnumerados.Instancia.Motivos Where mot.descripcion.ToLower.Contains(Descripcion.ToLower)).ToList
        End If
        If a.Count > 0 Then
            M = a.First
            Return M.id
        Else
            MessageBox.Show("Se ha detectado un error. Comuníquese con el administrador del sistema." + vbNewLine + "Error: No se encontró el Motivo '" + Descripcion + "' para el diálogo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return 0
    End Function
    Public Function getMotivoId(ByVal descripcion As String, ByVal padreDescripcion As String) As Integer
        Dim M As New motivo
        Dim padreId As Integer = getMotivoId(padreDescripcion)
        If padreId > 0 Then
            M = ClsEnumerados.Instancia.Motivos.Find(Function(x) x.descripcion.ToLower.Contains(descripcion.ToLower) And x.motivo_padre_id = padreId)
            If M IsNot Nothing Then
                Return M.id
            Else
                MessageBox.Show("Se ha detectado un error. Comuníquese con el administrador del sistema." + vbNewLine + "Error: No se encontró el Motivo '" + descripcion + "' para el diálogo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return 0
    End Function
    Public Function getCategoriaId(ByVal Descripcion As String, ByVal Pertenece As String) As Integer
        Dim c As New comunicacion_cat
        c = ClsEnumerados.Instancia.lst_ComunicacionCat.Find(Function(x) x.descripcion.ToLower.Contains(Descripcion.ToLower) And x.pertenece.ToLower.Contains(Pertenece.ToLower))
        If c IsNot Nothing Then
            Return c.id
        Else
            Return 0
        End If
    End Function
    Friend lklCrearTarea, lklVerTareas As LinkLabel
    Dim colorTitulos, colorLabels, colorLinkLabels, colorTextoABuscar As Color
    Public Sub SetearColoresDialogos(Optional ByVal colorTitulos As Color = Nothing, Optional ByVal colorLabels As Color = Nothing, Optional ByVal colorLinkLabels As Color = Nothing, Optional ByVal colorTextoABuscar As Color = Nothing)
        If colorTitulos <> Nothing Then Me.colorTitulos = colorTitulos
        If colorLabels <> Nothing Then Me.colorLabels = colorLabels
        If colorLinkLabels <> Nothing Then Me.colorLinkLabels = colorLinkLabels
        If colorTextoABuscar <> Nothing Then Me.colorTextoABuscar = colorTextoABuscar
    End Sub
    Public Sub ResetearColoresDialogos()
        colorTitulos = Color.Gold
        colorLabels = Color.White
        colorLinkLabels = Color.LightSteelBlue
        colorTextoABuscar = Color.Pink
    End Sub
    Public Sub DibujarDialogos(ByRef pnlDialogos As Panel, ByVal imagenEstrellaOn As Image, ByVal textoABuscar As String, Optional ByVal colorTextoABuscar As Color = Nothing, Optional ByVal pertenece As String = "TODAS", Optional ByVal motivoId As Integer = 0)
        If colorTextoABuscar <> Nothing Then Me.colorTextoABuscar = colorTextoABuscar

        Dim parTareas As Boolean = parametro.GetValor("USA TAREAS EN COMUNICACIONES", 0, "Si el sistema permite crear y ver tareas a partir de un diálogo de comunicación.")
        Dim separacion As Integer = 10
        Dim altura As Integer = separacion
        For Each d As comunicacion_linea In Me.Comunicacion.lst_ComunicacionLinea.FindAll(Function(x) (pertenece = "TODAS" Or x.Motivo.pertenece = pertenece) _
                And (motivoId = 0 Or x.motivo_id = motivoId)).OrderByDescending(Function(x) x.fechahora)
            'Caro 2017-06-05: Agrego lblSucursal
            Dim pnlUnDialogo As New System.Windows.Forms.Panel
            Dim lblMotivo, lblDe, lblUsuario, lblFechaHora, lblPara, lblEntidad, lblSucursal As New System.Windows.Forms.Label 'lblValoracion
            Dim pbxEstr1, pbxEstr2, pbxEstr3, pbxEstr4 As New PictureBox
            Dim txtObservaciones As New System.Windows.Forms.TextBox
            If parTareas Then lklCrearTarea = New System.Windows.Forms.LinkLabel
            If parTareas Then lklVerTareas = New System.Windows.Forms.LinkLabel

            '---------- Nombre (necesito éstos para luego poder redibujar) ---------- 
            lblPara.Name = "lblPara"
            lblEntidad.Name = "lblEntidad"
            If parTareas Then lklCrearTarea.Name = "lklCrearTarea"
            If parTareas Then lklVerTareas.Name = "lklVerTareas"
            lblFechaHora.Name = "lblFechaHora"
            txtObservaciones.Name = "txtObservaciones"
            lblSucursal.Name = "lblSucursal"

            '---------- Cargo el contenido ---------- 
            lblMotivo.Text = d.MotivoDescripcion
            lblDe.Text = "Usuario:"
            lblUsuario.Text = d.Usuario.ApeyNom
            If lblUsuario.Text.Trim.Length = 0 Then lblDe.Visible = False
            lblFechaHora.Text = d.fechahora.ToString
            lblPara.Text = "Contacto:"
            lblEntidad.Text = d.Entidad.ApeyNom
            If lblEntidad.Text.Trim.Length = 0 Then lblPara.Visible = False
            lblSucursal.Text = d.Sucursal.nombre
            If ClsEnumerados.Instancia.lst_Sucursal.Count = 1 Then lblSucursal.Visible = False

            pbxEstr1.Image = imagenEstrellaOn
            pbxEstr2.Image = imagenEstrellaOn
            pbxEstr3.Image = imagenEstrellaOn
            pbxEstr4.Image = imagenEstrellaOn
            pbxEstr1.SizeMode = PictureBoxSizeMode.AutoSize
            pbxEstr2.SizeMode = PictureBoxSizeMode.AutoSize
            pbxEstr3.SizeMode = PictureBoxSizeMode.AutoSize
            pbxEstr4.SizeMode = PictureBoxSizeMode.AutoSize

            txtObservaciones.Text = d.observaciones
            If parTareas Then
                lklCrearTarea.Tag = d
                lklCrearTarea.Text = "Crear Tarea"
                AddHandler lklCrearTarea.LinkClicked, AddressOf Me.lklCrearTarea_LinkClicked
                'If d.lst_Tarea.Count > 1 Then
                '    lklVerTareas = New System.Windows.Forms.LinkLabel
                '    'lklVerTareas.Tag = d.lst_Tarea.First
                '    lklVerTareas.Text = "Ver Tareas"

                '    Me.DibujarMenuTareas(d)

                'Else
                If d.lst_Tarea.Count > 0 Then

                    lklVerTareas = New System.Windows.Forms.LinkLabel
                    lklVerTareas.Tag = d.lst_Tarea
                    lklVerTareas.Text = "Ver Tareas"
                    AddHandler lklVerTareas.LinkClicked, AddressOf Me.lklVerTareas_LinkClicked

                    'Me.DibujarMenuTareas(d)

                End If
            End If

            '---------- Padre ---------- 
            pnlUnDialogo.Parent = pnlDialogos
            lblMotivo.Parent = pnlDialogos
            lblDe.Parent = pnlUnDialogo
            lblUsuario.Parent = pnlUnDialogo
            lblFechaHora.Parent = pnlDialogos
            lblPara.Parent = pnlUnDialogo
            lblEntidad.Parent = pnlUnDialogo
            lblSucursal.Parent = pnlUnDialogo

            Select Case d.valoracion.ToUpper
                Case "MALA", "MALO"
                    pbxEstr1.Parent = pnlUnDialogo
                Case "REGULAR"
                    pbxEstr1.Parent = pnlUnDialogo
                    pbxEstr2.Parent = pnlUnDialogo
                Case "BUENA", "BUENO"
                    pbxEstr1.Parent = pnlUnDialogo
                    pbxEstr2.Parent = pnlUnDialogo
                    pbxEstr3.Parent = pnlUnDialogo
                Case "MUY BUENA", "MUY BUENO"
                    pbxEstr1.Parent = pnlUnDialogo
                    pbxEstr2.Parent = pnlUnDialogo
                    pbxEstr3.Parent = pnlUnDialogo
                    pbxEstr4.Parent = pnlUnDialogo
            End Select
            txtObservaciones.Parent = pnlUnDialogo
            If parTareas Then
                lklCrearTarea.Parent = pnlUnDialogo
                If d.lst_Tarea.Count > 0 Then
                    lklVerTareas.Parent = pnlUnDialogo '- -> No lo agrego porque no tengo la pantalla acá
                End If
            End If

            '---------- Fuente ---------- 
            lblMotivo.Font = New Font("Verdana", 10)
            lblDe.Font = New Font("Verdana", 8, FontStyle.Bold)
            lblUsuario.Font = New Font("Verdana", 8)
            lblFechaHora.Font = New Font("Verdana", 8)
            lblPara.Font = New Font("Verdana", 8, FontStyle.Bold)
            lblEntidad.Font = New Font("Verdana", 8)
            txtObservaciones.Font = New Font("Verdana", 8)
            txtObservaciones.BorderStyle = BorderStyle.None
            If parTareas Then
                lklCrearTarea.Font = New Font("Verdana", 8)
                If d.lst_Tarea.Count > 0 Then
                    lklVerTareas.Font = New Font("Verdana", 8)
                End If
            End If
            lblSucursal.Font = New Font("Verdana", 7)

            '---------- Color ---------- 
            txtObservaciones.BackColor = txtObservaciones.Parent.BackColor
            If textoABuscar.Trim.Length > 0 Then
                If d.observaciones.ToUpper.Contains(textoABuscar.ToUpper) Or d.MotivoDescripcion.ToUpper.Contains(textoABuscar.ToUpper) Then
                    pnlUnDialogo.BackColor = Me.colorTextoABuscar
                    txtObservaciones.BackColor = Me.colorTextoABuscar
                End If
            End If
            lblMotivo.ForeColor = colorTitulos
            lblUsuario.ForeColor = colorTitulos
            lblEntidad.ForeColor = colorTitulos
            lblDe.ForeColor = colorLabels
            lblFechaHora.ForeColor = colorLabels
            lblPara.ForeColor = colorLabels
            txtObservaciones.ForeColor = colorLabels
            pnlUnDialogo.BorderStyle = BorderStyle.FixedSingle
            If parTareas Then
                lklCrearTarea.LinkColor = colorLinkLabels
                If d.lst_Tarea.Count > 0 Then
                    lklVerTareas.LinkColor = colorLinkLabels
                End If
            End If
            lblSucursal.ForeColor = colorTitulos

            '---------- Tamaño ---------- 
            pnlUnDialogo.Width = pnlDialogos.Width - (separacion * 4)  ' porque la barra vertical me quita espacio
            lblMotivo.AutoSize = True
            lblDe.AutoSize = True
            lblUsuario.AutoSize = True
            lblFechaHora.AutoSize = True
            lblPara.AutoSize = True
            lblEntidad.AutoSize = True
            txtObservaciones.Multiline = True
            txtObservaciones.Width = pnlUnDialogo.Width - separacion * 2
            Dim cantlineas As Integer = txtObservaciones.Lines.Length
            For Each l In txtObservaciones.Lines
                If txtObservaciones.CreateGraphics().MeasureString(l, New Font("Verdana", 8)).Width > txtObservaciones.Width Then
                    cantlineas += Int(txtObservaciones.CreateGraphics().MeasureString(l, New Font("Verdana", 8)).Width / txtObservaciones.Width)
                End If
            Next
            txtObservaciones.Height = cantlineas * 15
            pnlUnDialogo.Height = lblDe.Height + txtObservaciones.Height + pbxEstr1.Height + separacion * 4
            If parTareas Then
                lklCrearTarea.AutoSize = True
                If d.lst_Tarea.Count > 0 Then
                    lklVerTareas.AutoSize = True
                End If
            End If
            lblSucursal.AutoSize = True

            '---------- Ubicación izquierda ---------- 
            pnlUnDialogo.Left = separacion
            lblMotivo.Left = pnlUnDialogo.Left + separacion
            lblDe.Left = separacion
            lblUsuario.Left = lblDe.Width + separacion
            txtObservaciones.Left = separacion + 3
            pbxEstr1.Left = separacion
            pbxEstr2.Left = pbxEstr1.Right + 2
            pbxEstr3.Left = pbxEstr2.Right + 2
            pbxEstr4.Left = pbxEstr3.Right + 2
            lblFechaHora.Left = pnlUnDialogo.Left + pnlUnDialogo.Width - lblFechaHora.Width - separacion
            lblEntidad.Left = pnlUnDialogo.Width - lblEntidad.Width - separacion
            lblPara.Left = lblEntidad.Left - lblPara.Width - 3
            lblSucursal.Left = pnlUnDialogo.Width - lblSucursal.Width - separacion
            If parTareas Then
                lklCrearTarea.Left = pnlUnDialogo.Width - lklCrearTarea.Width - separacion
                If d.lst_Tarea.Count > 0 Then
                    lklVerTareas.Left = lklCrearTarea.Left - lklVerTareas.Width - separacion
                    lblSucursal.Left = lklVerTareas.Left - lblSucursal.Width - separacion
                Else
                    lblSucursal.Left = lklCrearTarea.Left - lblSucursal.Width - separacion
                End If
            End If

            '---------- Ubicación arriba ---------- 
            pnlUnDialogo.Top = altura
            altura += pnlUnDialogo.Height + separacion
            lblMotivo.Top = pnlUnDialogo.Top - (lblMotivo.Height / 2)  ' Para centrarlo respecto al panel
            lblMotivo.BringToFront()
            lblFechaHora.Top = pnlUnDialogo.Top - (lblFechaHora.Height / 2)  'Para centrarlo respecto al panel
            lblFechaHora.BringToFront()
            lblDe.Top = separacion
            lblUsuario.Top = separacion
            lblPara.Top = separacion
            lblEntidad.Top = separacion
            txtObservaciones.Top = lblDe.Bottom + separacion
            pbxEstr1.Top = txtObservaciones.Bottom + separacion
            pbxEstr2.Top = txtObservaciones.Bottom + separacion
            pbxEstr3.Top = txtObservaciones.Bottom + separacion
            pbxEstr4.Top = txtObservaciones.Bottom + separacion
            lblSucursal.Top = pbxEstr1.Top 'Si no hay link de Tareas, va a la altura de las estrellas.
            If parTareas Then
                lklCrearTarea.Top = pbxEstr1.Top
                If d.lst_Tarea.Count > 0 Then
                    lklVerTareas.Top = pbxEstr1.Top
                End If
            End If

            '---------- Sólo lectura ---------- 
            txtObservaciones.ReadOnly = True
        Next
    End Sub

    ''' <summary>
    ''' Devuelve un arbol de Motivos, filtrando por Pertenece y opcionalmente sólo los motivos que participan de la comunicación que se le pasa.
    ''' </summary>
    ''' <param name="pertenece">TODAS | CLIENTE | PROVEEDOR | INTERNA</param>
    ''' <param name="comunicacionParaFiltrar">Sólo se incluyen los motivos (o sus padres) que ya participaron de la comunicación</param>
    Public Function getArbolMotivos(ByVal pertenece As String, Optional ByVal comunicacionParaFiltrar As comunicacion = Nothing, Optional ByVal idMotivoAIncluir As Integer = 0, Optional ByVal categoriaId As Integer = 0) As List(Of motivo)
        If comunicacionParaFiltrar IsNot Nothing Then
            Return (From m In Me.getArbolMotivos(0, "") Where (m.ComunicacionCategoria.pertenece = pertenece Or m.ComunicacionCategoria.pertenece = "" Or pertenece = "TODAS") And m.comunicacion_cat_id = comunicacionParaFiltrar.comunicacion_cat_id).ToList
        Else
            If categoriaId > 0 Then
                Return (From m In Me.getArbolMotivos(0, "") Where (m.pertenece = pertenece Or m.pertenece = "" Or pertenece = "TODAS") And m.comunicacion_cat_id = categoriaId).ToList
            Else
                Return (From m In Me.getArbolMotivos(0, "") Where (m.pertenece = pertenece Or m.pertenece = "" Or pertenece = "TODAS")).ToList
            End If
        End If

        'If comunicacionParaFiltrar IsNot Nothing Then
        '    'Obtiene los motivos y los padres de motivos que se usaron en algún diálogo de la comunicación
        '    Dim lstPadresIds = comunicacionParaFiltrar.lst_ComunicacionLinea.Select(Function(x) IIf(x.Motivo.motivo_padre_id = 0, x.motivo_id, x.Motivo.motivo_padre_id)).Distinct.ToList

        '    'Filtra el árbol según estos padres y según Pertenece
        '    Return (From m In Me.getArbolMotivos(0, "--") Where (m.pertenece = pertenece Or m.pertenece = "" Or pertenece = "TODAS") _
        '                       And (lstPadresIds.Contains(m.motivo_padre_id) Or lstPadresIds.Contains(m.id) _
        '                       Or m.id = idMotivoAIncluir) And m.comunicacion_cat_id = comunicacionParaFiltrar.comunicacion_cat_id).ToList
        'Else
        '    'Filtra el árbol según Pertenece (cuando el motivo no tiene definido este dato, o sea pertenece="", se lo incluye de todos modos)
        '    If categoriaId > 0 Then
        '        Return (From m In Me.getArbolMotivos(0, "--") Where (m.pertenece = pertenece Or m.pertenece = "" Or pertenece = "TODAS") And m.comunicacion_cat_id = categoriaId).ToList
        '    Else
        '        Return (From m In Me.getArbolMotivos(0, "--") Where (m.pertenece = pertenece Or m.pertenece = "" Or pertenece = "TODAS")).ToList
        '    End If
        'End If
    End Function

#Region "Tareas"
    Private Sub lklCrearTarea_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) 'Handles lklCrearTarea.LinkClicked
        'Dim Frm As Form
        'Frm = New FrmTarea(CType(sender.tag, comunicacion_linea))
        'Frm.MdiParent = Nothing
        'Frm.ShowDialog()
    End Sub

    Private Sub lklVerTareas_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) 'Handles lklVerTareas.LinkClicked
        '    Dim Frm As Form
        '    Frm = New FrmGestionUsuario(CType(sender.tag, comunicacion_linea).lst_Tarea)
        '    Frm.MdiParent = Nothing
        '    Frm.ShowDialog()

        'Dim comLn = CType(sender.Tag, comunicacion_linea)
        'Me.DibujarMenuTareas(comLn)

        Dim lstTareas As List(Of tarea) = sender.tag
        If lstTareas.Count > 1 Then
            Me.DibujarMenuTareas(lstTareas)

        ElseIf lstTareas.Count > 0 Then

            AbrirUnaTarea(lstTareas.First)

        End If



    End Sub
    Private Sub AbrirUnaTarea(ByVal t As tarea)
        'Dim Frm As Form
        'Frm = New FrmTarea(ClsVariablesSesion.Instancia, t, True)
        'Frm.MdiParent = Nothing
        'Frm.ShowDialog()
    End Sub

    Protected Friend WithEvents cmsTareas As New ContextMenuStrip
    Protected Friend WithEvents btnItem As ToolStripMenuItem
    Dim lblDialogo As New Label
    'Protected Friend WithEvents txtNroOrden As New TextBox
    Private Sub DibujarMenuTareas(ByVal lstTareas As List(Of tarea)) 'ByVal comLn As comunicacion_linea)

        'Crear un item en el menú por cada orden
        If cmsTareas Is Nothing Then cmsTareas = New ContextMenuStrip
        cmsTareas.Items.Clear()

        'If comLn.lst_Tarea.Count > 1 Then
        For Each t In lstTareas ' comLn.lst_Tarea
            'Botón Gestión Cliente
            btnItem = New ToolStripMenuItem
            btnItem.Name = "btnItemTarea" & lstTareas.IndexOf(t) + 1
            btnItem.Text = t.Entidad.ApeyNom  '"Gestión Cliente " & o.v_ClienteAyN
            btnItem.Image = modRecursos.My.Resources.client
            btnItem.Tag = t
            AddHandler btnItem.Click, AddressOf btnItemTarea_Click
            cmsTareas.Items.Add(btnItem)
            'Si se mostrara también otras Gestiones, sería bueno poner un separador.
        Next

        If cmsTareas.Items.Count > 0 Then
            lblDialogo.Text = ""
            'Abrir (mostrar) el menú
            'lklVerTareas.ContextMenuStrip = cmsTareas

            cmsTareas.Show(lklVerTareas, New System.Drawing.Point(0, lklVerTareas.Height + lklVerTareas.Margin.Bottom))
        Else
            lblDialogo.Text = "No se encontró la Tarea."
        End If

    End Sub
    Private Sub btnItemTarea_Click(sender As Object, e As EventArgs)
        AbrirUnaTarea(sender.tag)
    End Sub

#End Region

#End Region
End Class
