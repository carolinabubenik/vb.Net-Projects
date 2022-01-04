Imports modEntities
Imports Telerik.WinControls.UI
Public Class FrmComunicacion
    Friend Cls As New ClsComunicacion
    Dim bgsUsuario, bgsRelacion As New BindingSource
    Dim pertenece As String
    Dim Salvar As Boolean
    Dim verNombreProveedor As Boolean = False


#Region "Inicializar"
    Public Sub New(ByVal Lin As comunicacion_linea, ByVal perten As String, ByVal Guardar As Boolean, Optional ByVal verNombreProv As Boolean = False)
        InitializeComponent()
        verNombreProveedor = verNombreProv
        With Cls
            .Comunicacion_linea = Lin
            If .Comunicacion_linea.Comunicacion.id = 0 Then
                .Comunicacion_linea.Comunicacion.EstadoFila = "N"
            Else
                .Comunicacion_linea.Comunicacion.EstadoFila = "U"
            End If
            .Comunicacion_linea.Comunicacion = Lin.Comunicacion
            .Comunicacion_linea.comunicacion_id = Lin.Comunicacion.id
            If .Comunicacion_linea.Entidad.id = 0 Then
                .Comunicacion_linea.Entidad = .Comunicacion_linea.Comunicacion.Entidad
                .Comunicacion_linea.entidad_id = .Comunicacion_linea.Entidad.id
            End If
            If .Comunicacion_linea.Comunicacion.Entidad.isSucursal Then
                cbxSucursal.SelectedItem = .Comunicacion_linea.Comunicacion.Entidad
            End If
        End With
        pertenece = perten
        ' Me.Text = Me.Text & IIf(Cls.Comunicacion_linea.Comunicacion.id > 0, Cls.Comunicacion_linea.Comunicacion.id, "NUEVA")
        Me.Text = IIf(Cls.Comunicacion_linea.Comunicacion.id > 0, "Nuevo Diálogo", "Nueva Comunicación")
        Salvar = Guardar
    End Sub
    Public Sub New(ByVal Lin As comunicacion_linea, ByVal perten As String)
        InitializeComponent()
        With Cls
            .Comunicacion_linea = Lin
            If .Comunicacion_linea.Comunicacion.id = 0 Then
                .Comunicacion_linea.Comunicacion.EstadoFila = "N"
            Else
                .Comunicacion_linea.Comunicacion.EstadoFila = "U"
            End If
            .Comunicacion_linea.Comunicacion = Lin.Comunicacion
            .Comunicacion_linea.comunicacion_id = Lin.Comunicacion.id
            If .Comunicacion_linea.Entidad.id = 0 Then
                .Comunicacion_linea.Entidad = .Comunicacion_linea.Comunicacion.Entidad
                .Comunicacion_linea.entidad_id = .Comunicacion_linea.Entidad.id
            End If
            If .Comunicacion_linea.Comunicacion.Entidad.isSucursal Then
                cbxSucursal.SelectedItem = .Comunicacion_linea.Comunicacion.Entidad
            End If
        End With
        pertenece = perten
        'Me.Text = Me.Text & IIf(Cls.Comunicacion_linea.Comunicacion.id > 0, Cls.Comunicacion_linea.Comunicacion.id, "NUEVA")
        Me.Text = IIf(Cls.Comunicacion_linea.Comunicacion.id > 0, " Nuevo Diálogo", " Nueva Comunicación")
        Salvar = True
    End Sub
    Public Sub New(ByVal ClsVar As ClsVariablesSesion, ByVal Lin As comunicacion_linea, ByVal perten As String, ByVal Guardar As Boolean)
        InitializeComponent()

        With Cls
            .Comunicacion_linea = Lin
            If .Comunicacion_linea.Comunicacion.id = 0 Then
                .Comunicacion_linea.Comunicacion.EstadoFila = "N"
            Else
                .Comunicacion_linea.Comunicacion.EstadoFila = "U"
            End If
            .Comunicacion_linea.Comunicacion = Lin.Comunicacion
            .Comunicacion_linea.comunicacion_id = Lin.Comunicacion.id
            If .Comunicacion_linea.Entidad.id = 0 Then
                .Comunicacion_linea.Entidad = .Comunicacion_linea.Comunicacion.Entidad
                .Comunicacion_linea.entidad_id = .Comunicacion_linea.Entidad.id
            End If
            If .Comunicacion_linea.Comunicacion.Entidad.isSucursal Then
                cbxSucursal.SelectedItem = .Comunicacion_linea.Comunicacion.Entidad
            End If
        End With
        pertenece = perten
        Me.Text = Me.Text & IIf(Cls.Comunicacion_linea.Comunicacion.id > 0, Cls.Comunicacion_linea.Comunicacion.id, "NUEVA")
        Salvar = Guardar
    End Sub
    Public Sub New(ByVal ClsVar As ClsVariablesSesion, ByVal Lin As comunicacion_linea, ByVal perten As String)
        InitializeComponent()
        With Cls
            .Comunicacion_linea = Lin
            If .Comunicacion_linea.Comunicacion.id = 0 Then
                .Comunicacion_linea.Comunicacion.EstadoFila = "N"
            Else
                .Comunicacion_linea.Comunicacion.EstadoFila = "U"
            End If
            .Comunicacion_linea.Comunicacion = Lin.Comunicacion
            .Comunicacion_linea.comunicacion_id = Lin.Comunicacion.id
            If .Comunicacion_linea.Entidad.id = 0 Then
                .Comunicacion_linea.Entidad = .Comunicacion_linea.Comunicacion.Entidad
                .Comunicacion_linea.entidad_id = .Comunicacion_linea.Entidad.id
            End If
            If .Comunicacion_linea.Comunicacion.Entidad.isSucursal Then
                cbxSucursal.SelectedItem = .Comunicacion_linea.Comunicacion.Entidad
            End If
        End With
        pertenece = perten
        'Me.Text = Me.Text & IIf(Cls.Comunicacion_linea.Comunicacion.id > 0, Cls.Comunicacion_linea.Comunicacion.id, "NUEVA")
        Me.Text = Me.Text & IIf(Cls.Comunicacion_linea.Comunicacion.id > 0, "Nuevo Diálogo", "Nueva Comunicación")
        Salvar = True
    End Sub
    Private Sub FrmComunicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modEstilos.ClsEstilo.AplicarEstilo(Me, ClsVariablesSesion.Instancia)
        dgvEntidades.AutoGenerateColumns = False

        CargarControles()

        CargarDatos()

        'carga los motivos de la comunicacion modificados p seleccionar del combo
        With cbxMotivo
            .DisplayMember = "descripcionModif"
            .ValueMember = "id"
            .DataSource = Cls.getArbolMotivos("TODAS",,, cbxCategComunic.SelectedValue)
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .DropDownListElement.AutoCompleteSuggest = New modFunciones.CustomAutoCompleteSuggestHelper(cbxMotivo.DropDownListElement)
            .DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains
            modFunciones.FuncUtiles.cbxAjustaAnchoLista(cbxMotivo)
            With Cls.Comunicacion_linea
                If .motivo_id <> 0 Then
                    cbxMotivo.SelectedValue = .motivo_id
                Else
                    cbxMotivo.Text = ""
                End If
            End With
            'If Cls.Comunicacion_linea.Comunicacion.id = 0 Then 'Com Nueva: Muestra todos los motivos, según pertenece
            '    'Caro 23/10/2014: agrego el motivo-id por defecto para que se incluya
            '.DataSource = Cls.getArbolMotivos(pertenece, Cls.Comunicacion_linea.Comunicacion, Cls.Comunicacion_linea.motivo_id)
            '    '.DataSource = Cls.getArbolMotivos(pertenece, , Cls.Comunicacion_linea.motivo_id)

            '    '.DataSource = (From m In Cls.getArbolMotivos(0, "--") Where m.pertenece = pertenece Or m.pertenece = "").ToList

            'Else 'Nuevo Diálogo: Muestra los motivos de los padres que ya participan de la comunicacion
            '    'Caro 23/10/2014: agrego el motivo-id por defecto para que se incluya
            '    .DataSource = Cls.getArbolMotivos(pertenece, Cls.Comunicacion_linea.Comunicacion, Cls.Comunicacion_linea.motivo_id)

            '    'Dim lstPadresIds = Cls.Comunicacion_linea.Comunicacion.lst_ComunicacionLinea.Select(Function(x) IIf(x.Motivo.motivo_padre_id = 0, x.motivo_id, x.Motivo.motivo_padre_id)).Distinct.ToList

            '    '.DataSource = (From m In Cls.getArbolMotivos(0, "--") Where (m.pertenece = pertenece Or m.pertenece = "") _
            '    '               And (lstPadresIds.Contains(m.motivo_padre_id) Or lstPadresIds.Contains(m.id))).ToList

            'End If

        End With


        txtObservaciones.Select()
    End Sub
    Private Sub CargarControles()
        'Carga las categorías
        With cbxCategComunic
            .DisplayMember = "descripcion"
            .ValueMember = "id"
            If Cls.Comunicacion_linea.Comunicacion.id = 0 Then 'Comunicacion Nueva: se filtran las categorías según "pertenece" de parametro
                .DataSource = (From c In ClsEnumerados.Instancia.lst_ComunicacionCat Where c.pertenece = pertenece And Not c.vDadaDeBaja).ToList
            Else 'Según el pertenece de la comunicación.
                .DataSource = (From c In ClsEnumerados.Instancia.lst_ComunicacionCat
                               Where (c.pertenece = Cls.Comunicacion_linea.Comunicacion.Comunicacion_cat.pertenece) And Not c.vDadaDeBaja).ToList
                'Where (c.pertenece = pertenece Or Cls.Comunicacion_linea.comunicacion_id > 0)).ToList 'agrego el >0 para que me agregue todas las categorías.. ya que puede no coincidir el "pertenece" de la línea con el de la comunicación
            End If
        End With

        'Carga los estados
        'Alex Tareas #5745 2018-07-11
        With cbxtEstado
            .DisplayMember = "nombre"
            .ValueMember = "id"
            .DataSource = ClsEnumerados.Instancia.lst_ComunicacionEstado().FindAll(Function(x) Not x.vDadaDeBaja)
        End With

        'With cbxtEstado
        '    .DisplayMember = "descripcion"
        '    .ValueMember = "id"
        '    .DataSource = ClsEnumerados.Instancia.lst_Estado_Comunicacion()
        'End With

        'carga las valoraciones
        'cbxValoracion.DataSource = ClsEnumerados.Instancia.lst_Valoracion_Com_Linea

        'Carga las sucursales
        With cbxSucursal
            .DisplayMember = "nombre"
            .ValueMember = "id"
            .DataSource = ClsEnumerados.Instancia.lst_Sucursal
        End With

        'chkContacto.Enabled = True
        'dgvEntidades.Visible = False
        'cbxSucursal.Visible = False

        With Cls.Comunicacion_linea

            'Checkear si la entidad del diálogo es diferente a la de la comunicación
            chkContacto.Checked = (.Entidad.id <> .Comunicacion.Entidad.id)
            chkContacto_CheckedChanged(Nothing, Nothing)

            If pertenece = "INTERNA" Then
                cbxSucursal.DataSource = ClsEnumerados.Instancia.lst_Sucursal
                bgsUsuario.DataSource = ClsEnumerados.Instancia.lst_Usuario
                dgvEntidades.DataSource = bgsUsuario
                Datos.HeaderText = "Sucursal"
                Datos.DataPropertyName = "nombre_Sucursales"

            ElseIf pertenece = "CLIENTE" Then
                bgsRelacion.DataSource = .Comunicacion.Entidad.lst_Relacion
                dgvEntidades.DataSource = bgsRelacion
                bgsRelacion.ResetBindings(False)
                Datos.HeaderText = "Vínculo"
                Datos.DataPropertyName = "relacion"

            ElseIf pertenece = "PROVEEDOR" Then
                chkContacto.Enabled = False
            End If

            'If Cls.Comunicacion_linea.Entidad.id <> Cls.Comunicacion_linea.Comunicacion.Entidad.id Then
            '    chkContacto.Checked = True
            '    If pertenece = "PROVEEDOR" Then lblEntidadDialogo.Text = Cls.Comunicacion_linea.Entidad.AyN
            'End If

        End With
    End Sub
    Private Sub CargarDatos()

        'Datos de la comunicación
        With Cls.Comunicacion_linea.Comunicacion
            'Entidad de la comunicación
            If verNombreProveedor Then
                lblEntidadComunic.Text = Cls.VerLegajoProveedor(.entidad_id)
            Else
                lblEntidadComunic.Text = .EntidadAyN
            End If

            If .comunicacion_cat_id <> 0 Then
                cbxCategComunic.SelectedValue = .comunicacion_cat_id
                cbxCategComunic.Enabled = False
            Else
                cbxCategComunic.Text = ""
                cbxCategComunic.Enabled = True
            End If
            'Alex 2018-07-11 Tareas #5745
            cbxtEstado.Text = .Comunicacion_estado.nombre

            'cbxtEstado.Text = .estado
        End With

        'Datos del diálogo
        With Cls.Comunicacion_linea
            'Entidad del diálogo
            If verNombreProveedor Then
                If .Entidad.id > 0 Then gbLnComunic.Text = "Diálogo con " & Cls.VerLegajoProveedor(.entidad_id)
            Else
                If .Entidad.id > 0 Then gbLnComunic.Text = "Diálogo con " & .Entidad.AyN
            End If

            txtObservFijas.Text = .observaciones.Trim
            spcObservaciones.Panel1Collapsed = (.observaciones.Trim.Length = 0)

            'cbxValoracion.Text = .valoracion
            'Dim nro = 0
            estrellaActiva = ClsEnumerados.Instancia.lst_Valoracion_Com_Linea.IndexOf(.valoracion) '(la primera posición de esta lista es vacía, entonces ya devuelve el índice correcto)
            For i = 1 To 4
                PintarEstrella(i, i <= estrellaActiva)
            Next

        End With
        'PintarEstrella(1, True)
    End Sub

#End Region
#Region "Aceptar Cancelar"
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.ValidateChildren Then
            With Cls.Comunicacion_linea.Comunicacion
                'Alex 2018-07-11 Tareas #5745
                '.estado = cbxtEstado.Text
                .comunicacion_estado_id = cbxtEstado.SelectedValue
                .comunicacion_cat_id = cbxCategComunic.SelectedValue
                '12-07-2012 (Rodrigo)
                If .entidad_id = 0 Then .entidad_id = ClsVariablesSesion.Instancia.Usuario.entidad_id
                .fecha_vencimiento = dtpVencimiento.Value
            End With
            With Cls.Comunicacion_linea
                .usuario_id = ClsVariablesSesion.Instancia.Usuario.id
                .motivo_id = cbxMotivo.SelectedValue
                .observaciones &= vbNewLine & txtObservaciones.Text 'Lo que ya tenía precargado, más lo que agrega el usuario
                '.valoracion = cbxValoracion.Text 'Ya se cargó al clickear las estrellas
                .fechahora = ClsMain.FechaHora
                If chkContacto.Checked Then
                    If Not spcDialogo.Panel2Collapsed Then
                        If pertenece = "INTERNA" Then
                            If bgsUsuario.Count > 0 Then .entidad_id = bgsUsuario.Item(bgsUsuario.Position).id
                        Else
                            If bgsRelacion.Count > 0 Then .entidad_id = bgsRelacion.Item(bgsRelacion.Position).entidad_id_Destino
                        End If
                        .Entidad = Nothing
                    End If
                Else
                    'Queda con la entidad con la que vino el diálogo (ej Un proveedor, otro cliente, etc.)
                End If
            End With
            With Cls
                If Salvar Then
                    .IniciarTrn()
                    Try
                        .PersistirComunicacion()
                        .gettrn.Commit()
                    Catch ex As Exception
                        .gettrn.Rollback()
                        MessageBox.Show("Error, no se dio de alta la comunicacion" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                End If
            End With
            With Cls
                If .Comunicacion_linea.EstadoFila = "N" Then
                    .Comunicacion_linea.Comunicacion.lst_ComunicacionLinea.Add(.Comunicacion_linea)
                    If .Comunicacion_linea.Comunicacion.entidad_id = 0 Then .Comunicacion_linea.Comunicacion.entidad_id = .Comunicacion_linea.entidad_id
                End If
                Me.Tag = .Comunicacion_linea
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End With
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
#End Region
    '#Region "Relacion"
    '    Private Sub NuevaRelacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim frm As Form
    '        frm = modPermisos.ClsPermisos.loadForm(New FrmEntidadRelacion(Cls.Comunicacion_linea.Comunicacion.Entidad))
    '        With frm
    '            .MdiParent = Nothing
    '            If .ShowDialog = Windows.Forms.DialogResult.OK Then
    '                bgsRelacion.ResetBindings(False)
    '            End If
    '        End With
    '    End Sub
    '#End Region
#Region "Contacto"
    Private Sub chkContacto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkContacto.CheckedChanged
        If chkContacto.Checked Then
            lblEntidadDialogo.Text = Cls.Comunicacion_linea.Entidad.AyN
            lblEntidadDialogo.Visible = True
            If Cls.Comunicacion_linea.Entidad.id = 0 _
                Or Cls.Comunicacion_linea.Entidad.id = Cls.Comunicacion_linea.Comunicacion.Entidad.id Then 'No se precargó una entidad, se la debe seleccionar.
                spcDialogo.Panel2Collapsed = (pertenece = "PROVEEDOR") 'Para Interna y Cliente no se colapsa el panel.
            Else
                spcDialogo.Panel2Collapsed = True
            End If
            cbxSucursal.Visible = (pertenece = "INTERNA")
        Else
            lblEntidadDialogo.Visible = False
            spcDialogo.Panel2Collapsed = True
            cbxSucursal.Visible = False
        End If
        'With Me
        '    Select Case pertenece
        '        Case "PROVEEDOR"
        '            If Cls.Comunicacion_linea.Entidad.id <> Cls.Comunicacion_linea.Comunicacion.Entidad.id Then
        '                lblContactoProveedor.Visible = chkContacto.Checked
        '            Else
        '                .Height = IIf(chkContacto.Checked, .Height + 156, .Height - 156)
        '                dgvEntidades.Visible = chkContacto.Checked
        '            End If
        '        Case "CLIENTE"
        '            .Height = IIf(chkContacto.Checked, .Height + 156, .Height - 156)
        '            dgvEntidades.Visible = chkContacto.Checked

        '        Case "INTERNA"
        '            .Height = IIf(chkContacto.Checked, .Height + 156, .Height - 156)
        '            cbxSucursal.Visible = chkContacto.Checked
        '            dgvEntidades.Visible = chkContacto.Checked
        '    End Select
        'End With
    End Sub
    Private Sub cbxSucursal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxSucursal.SelectedIndexChanged
        If pertenece = "INTERNA" Then
            bgsUsuario.DataSource = (From us As usuario_sucursal In CType(cbxSucursal.SelectedItem, sucursal).lst_UsuarioSucursal Select us.Usuario).ToList
            bgsUsuario.ResetBindings(False)
        End If
    End Sub
    Private Sub dgvEntidades_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvEntidades.SelectionChanged
        If Not spcDialogo.Panel2Collapsed Then
            If pertenece = "INTERNA" Then
                If bgsUsuario.Position > -1 Then
                    lblEntidadDialogo.Text = CType(bgsUsuario.Item(bgsUsuario.Position), usuario).ApeyNom
                Else
                    lblEntidadDialogo.Text = ""
                End If
            Else
                If bgsRelacion.Position > -1 Then
                    lblEntidadDialogo.Text = CType(bgsRelacion.Item(bgsRelacion.Position), relacion).Entidad_destino.AyN
                Else
                    lblEntidadDialogo.Text = ""
                End If
            End If
        End If
    End Sub
#End Region
#Region "Validaciones"
    Private Sub cbxMotivo_Validating_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cbxMotivo.Validating
        If cbxMotivo.Text.Length = 0 Then
            ErrorProvider1.SetError(cbxMotivo, "Seleccione un Motivo")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(cbxMotivo, Nothing)
        End If
    End Sub
    Private Sub cbxCategComunic_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbxCategComunic.Validating
        If cbxCategComunic.Text.Length = 0 Then
            ErrorProvider1.SetError(cbxCategComunic, "Seleccione una Categoria Comunicacion")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(cbxCategComunic, Nothing)
        End If
    End Sub
    Private Sub cbxtEstado_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbxtEstado.Validating
        If cbxtEstado.Text.Length = 0 Then
            ErrorProvider1.SetError(cbxtEstado, "Seleccione un Estado")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(cbxtEstado, Nothing)
        End If
    End Sub
    Private Sub txtObservaciones_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If txtObservaciones.Text.Length = 0 Then
            ErrorProvider1.SetError(txtObservaciones, "Debe ingresar una observacion")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(txtObservaciones, Nothing)
        End If
    End Sub
#End Region
#Region "Estrellas"
    Private Sub pbxStar_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxStar1.MouseEnter, pbxStar2.MouseEnter, pbxStar3.MouseEnter, pbxStar4.MouseEnter
        'Al entrar a una estrella se pintan desde la primera hasta aquí
        With CType(sender, PictureBox)
            If .Enabled Then
                Dim nro As Integer = .Name.Substring(.Name.Length - 1)
                For i = 1 To 4
                    PintarEstrella(i, i <= nro)
                Next
            End If
        End With
    End Sub
    Private Sub PintarEstrella(ByVal nro As Integer, ByVal Activar As Boolean)
        Dim pbx = gbLnComunic.Controls.Find("pbxStar" & nro.ToString.Trim, False)
        If pbx.Count > 0 Then
            If Activar Then
                CType(pbx.First, PictureBox).Image = modRecursos.My.Resources.star_on
                Cls.Comunicacion_linea.valoracion = ToolTip1.GetToolTip(pbx.First)
            Else
                CType(pbx.First, PictureBox).Image = modRecursos.My.Resources.star_off
            End If
        End If
    End Sub
    Dim estrellaActiva As Integer = 0
    Private Sub pbxStar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxStar1.Click, pbxStar2.Click, pbxStar3.Click, pbxStar4.Click
        'Sólo al hacer click en una estrella se la toma como "valoración"
        With CType(sender, PictureBox)
            If .Enabled Then
                If IsNumeric(.Name.Substring(7, 1)) Then estrellaActiva = .Name.Substring(7, 1)
            End If
        End With
        'txtObservFijas_Validating(Nothing, Nothing)
    End Sub
    Private Sub pbxStar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxStar1.MouseLeave, pbxStar2.MouseLeave, pbxStar3.MouseLeave, pbxStar4.MouseLeave
        'Al salir de una estrella se pintan desde la primera hasta la que se haya marcado como valoración, no necesariamente la estrella de donde se está saliendo.
        With CType(sender, PictureBox)
            If .Enabled Then
                For i = 1 To 4
                    PintarEstrella(i, i <= estrellaActiva)
                Next
            End If
        End With
    End Sub

    Private Sub cbxMotivo_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles cbxMotivo.SelectedIndexChanged
        'txtObservaciones.Text = "" --> Porque lo borra ??
        Dim cbMotivo As New motivo
        If cbxMotivo.SelectedItem IsNot Nothing Then
            cbMotivo = CType(cbxMotivo.SelectedItem.DataBoundItem, motivo)
            If cbMotivo IsNot Nothing Then
                If cbMotivo.descripcion_dialogo.Length > 0 Then
                    txtObservaciones.Text = cbMotivo.descripcion_dialogo
                End If
            End If
        End If
    End Sub


    'Private Sub txtObservFijas_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtObservFijas.Validating
    '    If estrellaActiva <= 0 Then
    '        ErrorProvider1.SetError(lblValoracion, "Valore el diálogo")
    '        e.Cancel = True
    '    Else
    '        ErrorProvider1.SetError(lblValoracion, Nothing)
    '    End If
    'End Sub

#End Region


End Class