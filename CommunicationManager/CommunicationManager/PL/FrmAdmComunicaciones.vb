Imports modEntities

Public Class FrmAdmComunicaciones
    Private Cls As New ClsEntidad
    Private ClsCom As New ClsComunicacion()
    Dim ClsEst As New modEstilos.ClsEstilo
    Private bgsComunicacion As New BindingSource
    Private redactando As Boolean = False
    Private noRefrescar As Boolean = False
    Private backColorCelda, foreColorCelda, selForeColCelda, selBackColCelda As Color
    Dim desde, hasta As Date

#Region "Inicializadores"
    ''' <summary>
    ''' Muestra todas las comunicaciones. Por defecto muestra los ultimos 7 dias.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()
        desde = ClsMain.FechaHoy.AddDays(-7)
        hasta = ClsMain.FechaHoy
    End Sub

    ''' <summary>
    ''' Muestra las Comunicaciones de un cliente.
    ''' </summary>
    ''' <param name="Cliente"></param>
    ''' <remarks></remarks>
    Public Sub New(VariableSesion As ClsVariablesSesion, ByVal Cliente As cliente)
        InitializeComponent()
        Cls.Cliente = Cliente
        ClsCom.Cliente = Cliente
        ClsVariablesSesion.Instancia = VariableSesion
    End Sub

    ''' <summary>
    ''' Ininicializa los objetos necesarios (invoca al Load de este formulario)
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Iniciar()

        FrmAdmComunicaciones_load(Me, Nothing)
    End Sub

    Public ReadOnly Property Pestaña As TabPage
        Get
            Return tbpComunicaciones
        End Get
    End Property

    Public Sub RefrescarComunicaciones()
        btnComBuscar_Click(Nothing, Nothing)
    End Sub

    Public Sub FrmAdmComunicaciones_load(sender As Object, e As EventArgs) Handles MyBase.Load

        modEstilos.ClsEstilo.AplicarEstilo(Me, ClsVariablesSesion.Instancia)
        dgvComunicacion.AutoGenerateColumns = False

        If desde = Nothing Then
            desde = dtpComDesde.Value.AddDays(-1)
            hasta = dtpComHasta.Value
        End If
        dtpComDesde.Value = desde
        dtpComHasta.Value = hasta

        With cbxRespEstado
            .DisplayMember = "nombre"
            .ValueMember = "id"
            .DataSource = ClsEnumerados.Instancia.lst_ComunicacionEstado.FindAll(Function(x) Not x.vDadaDeBaja).ToList
        End With

        With cbxRespMotivo
            .DisplayMember = "descripcionModif"
            .ValueMember = "id"
            .DataSource = ClsCom.getArbolMotivos(0, "")
        End With
        btnResponder.Parent = spcDialogos.Panel2
        btnResponder.BringToFront()

        InhabilitarResponder()


        btnComBuscar_Click(Nothing, Nothing)
    End Sub
#End Region

#Region "Comunicacion"
    Private Sub pbxComFechas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxComAnt.Click, pbxComSig.Click
        Dim mes = 1
        If sender Is pbxComAnt Then mes *= -1
        dtpComDesde.Value = dtpComDesde.Value.AddMonths(mes)
        dtpComHasta.Value = dtpComHasta.Value.AddMonths(mes)
        btnComBuscar_Click(Nothing, Nothing)
    End Sub

    Private Sub BuscarComunicaciones()
        ClsCom.CargarComunicacionesCliente(dtpComDesde.Value, dtpComHasta.Value)
        bgsComunicacion.DataSource = ClsCom.lstComunicacion
        dgvComunicacion.DataSource = bgsComunicacion
        bgsComunicacion.ResetBindings(False)

        If bgsComunicacion.Count = 0 Then
            pnlDialogos.Controls.Clear()
            pnlDialogos.BackColor = Color.FromArgb(64, 64, 64)
            btnResponder.Enabled = False
        Else
            btnResponder.Enabled = True
        End If
    End Sub

    Private Sub btnComBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComBuscar.Click
        noRefrescar = True
        BuscarComunicaciones()
        bgsComunicacion.MoveFirst()
        noRefrescar = False
        dgvComunicacion_SelectionChanged(Nothing, Nothing)
        PintarComunicaciones()
    End Sub

    Private Sub dgvComunicacion_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvComunicacion.SelectionChanged
        If dgvComunicacion.CurrentRow IsNot Nothing Then
            ClsCom.Comunicacion = dgvComunicacion.CurrentRow.DataBoundItem
        Else
            ClsCom.Comunicacion = Nothing
        End If
        If Not noRefrescar Then
            MostrarDialogos()
        End If
    End Sub

    Private Sub PintarComunicaciones()
        'backColorCelda, foreColorCelda, selForeColCelda, selBackColCelda
        For Each r As DataGridViewRow In dgvComunicacion.Rows
            With CType(r.DataBoundItem, comunicacion)
                r.DefaultCellStyle.BackColor = backColorCelda
                r.DefaultCellStyle.SelectionBackColor = selBackColCelda
                If txtContenidoCom.TextLength > 0 Then
                    If .Comunicacion_cat.descripcion.ToUpper.Contains(txtContenidoCom.Text.ToUpper) Then
                        r.DefaultCellStyle.BackColor = selBackColCelda 'Me.BackColor
                        r.DefaultCellStyle.SelectionBackColor = selBackColCelda 'Me.BackColor
                    Else
                        For Each l In .lst_ComunicacionLinea
                            If l.observaciones.ToUpper.Contains(txtContenidoCom.Text.ToUpper) Then
                                r.DefaultCellStyle.BackColor = selBackColCelda 'Me.BackColor
                                r.DefaultCellStyle.SelectionBackColor = selBackColCelda 'Me.BackColor
                                If r Is dgvComunicacion.CurrentRow Then MostrarDialogos()
                                Exit For
                            Else
                                If l.Motivo.descripcion.ToUpper.Contains(txtContenidoCom.Text.ToUpper) Then
                                    r.DefaultCellStyle.BackColor = selBackColCelda 'Me.BackColor
                                    r.DefaultCellStyle.SelectionBackColor = selBackColCelda 'Me.BackColor
                                    If r Is dgvComunicacion.CurrentRow Then MostrarDialogos()
                                    Exit For
                                End If
                            End If
                        Next
                    End If
                End If
                If r Is dgvComunicacion.CurrentRow Then MostrarDialogos()
            End With
        Next
    End Sub

    'Private Sub btnComNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComNueva.Click
    '    Dim frm As New modFunciones.FrmIngresar("Nueva entrada en la agenda del socio:", "Iniciada por", ClsEnumerados.Instancia.lst_ComunicacionCat, "id", "descripcion")

    '    modEstilos.ClsEstilo.AplicarEstilo(frm, ClsVariablesSesion.Instancia)
    '    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        ClsCom.Comunicacion = Nothing
    '        ClsCom.Comunicacion.Comunicacion_cat = frm.Tag
    '        HabilitarResponder()
    '    End If
    '    'Dim Frm As Form
    '    'ClsCom.Comunicacion_linea = Nothing
    '    'ClsCom.Comunicacion_linea.Comunicacion.Entidad = Cls.Cliente.Entidad
    '    'Frm = modPermisos.ClsPermisos.loadForm(New modComunicacion.FrmComunicacion(ClsCom.Comunicacion_linea, "CLIENTE", True))
    '    'With Frm
    '    '    .MdiParent = Nothing
    '    '    If .ShowDialog = Windows.Forms.DialogResult.OK Then
    '    '        noRefrescar = True
    '    '        BuscarComunicaciones()
    '    '        bgsComunicacion.MoveFirst()
    '    '        noRefrescar = False
    '    '        dgvComunicacion_SelectionChanged(Nothing, Nothing)
    '    '    End If
    '    'End With
    'End Sub

    Private Sub txtContenidoCom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContenidoCom.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            PintarComunicaciones()
        End If
    End Sub

    Private Sub btnNuevaComunicación_Click(sender As Object, e As EventArgs) Handles btnNuevaComunicacion.Click
        Dim Frm As Form
        ClsCom.Comunicacion_linea = Nothing
        ClsCom.Comunicacion_linea.Comunicacion.Entidad = Cls.Cliente.Entidad
        ClsCom.Comunicacion_linea.Comunicacion.entidad_id = Cls.Cliente.entidad_id
        Frm = modPermisos.ClsPermisos.loadForm(New FrmComunicacion(ClsCom.Comunicacion_linea, "CLIENTE", True))
        With Frm
            .MdiParent = Nothing
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                noRefrescar = True
                BuscarComunicaciones()
                bgsComunicacion.MoveFirst()
                noRefrescar = False
                dgvComunicacion_SelectionChanged(Nothing, Nothing)
            End If
        End With
    End Sub

    Private Sub btnComNueva_Click(sender As Object, e As EventArgs) Handles btnComNueva.Click
        Dim Frm As Form
        ClsCom.Comunicacion_linea = Nothing
        ClsCom.Comunicacion_linea.Comunicacion.Entidad = Cls.Cliente.Entidad
        ClsCom.Comunicacion_linea.Comunicacion.entidad_id = Cls.Cliente.entidad_id
        Frm = modPermisos.ClsPermisos.loadForm(New FrmComunicacion(ClsCom.Comunicacion_linea, "CLIENTE", True))
        With Frm
            .MdiParent = Nothing
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                noRefrescar = True
                BuscarComunicaciones()
                bgsComunicacion.MoveFirst()
                noRefrescar = False
                dgvComunicacion_SelectionChanged(Nothing, Nothing)
            End If
        End With
    End Sub
#End Region

#Region "Dialogos"
    Dim separacion As Integer = 10
    Private Sub MostrarDialogos()
        btnResponder.ForeColor = Color.Maroon
        btnResponder.Enabled = True
        pnlDialogos.Controls.Clear()
        'pnlDialogos.AutoScroll = True
        If dgvComunicacion.CurrentRow IsNot Nothing Then
            'Alex 2018-07-11
            cbxRespEstado.Text = ClsCom.Comunicacion.Comunicacion_estado.nombre
            'cbxRespEstado.Text = ClsCom.Comunicacion.estado
            ClsCom.DibujarDialogos(pnlDialogos, modRecursos.My.Resources.star_on, txtContenidoCom.Text, selBackColCelda)
        End If
        pnlDialogos.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub RedibujarDialogos()
        For Each p As Control In pnlDialogos.Controls
            If p.GetType = GetType(Panel) Then
                p.Width = pnlDialogos.Width - (separacion * 4)
                Dim cPara, cEntidad, cCrearT, cVerT As New Control
                For Each c In p.Controls
                    Select Case c.name
                        Case "lblEntidad"
                            cEntidad = c
                        Case "lblPara"
                            cPara = c
                        Case "lklCrearTarea"
                            cCrearT = c
                        Case "lklVerTareas"
                            cVerT = c
                        Case "txtObservaciones"
                            c.width = p.Width - separacion * 2
                            Dim cantlineas As Integer = c.Lines.Length
                            For Each l In c.Lines
                                If CreateGraphics().MeasureString(l, New Font("Verdana", 8)).Width > c.Width Then
                                    cantlineas += Int(CreateGraphics().MeasureString(l, New Font("Verdana", 8)).Width / c.Width)
                                End If
                                c.Height = cantlineas * 15
                                'p.Height = c.Height + separacion * 5
                            Next
                    End Select
                Next
                cEntidad.Left = p.Width - cEntidad.Width - separacion
                cPara.Left = cEntidad.Left - cPara.Width - 3
                cCrearT.Left = p.Width - cCrearT.Width - separacion
                cVerT.Left = cCrearT.Left - cVerT.Width - separacion
            ElseIf p.Name = "lblFechaHora" Then
                p.Left = pnlDialogos.Width - p.Width - separacion * 4
            End If
        Next
    End Sub

    Private Sub spcDialogos_Panel1_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spcDialogos.SizeChanged
        RedibujarDialogos()
    End Sub
#End Region

#Region "Responder"
    Private Sub btnResponder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResponder.Click
        If Not redactando Then
            If ClsCom.Comunicacion.comunicacion_cat_id = 0 Then
                btnComNueva_Click(Nothing, Nothing)
                Exit Sub
            End If
            'ClsCom = New ClsComunicacion MMMM AHORA NO PUEDO LIMPIAR LA CLASE PORQUE TENGO CLIENTE Y COMUNICACION QUE NO QUIERO PERDER.
            'PARA QUÉ SE NECESITA?
            HabilitarResponder()
        Else
            Dim noPreguntar As Boolean = (String.IsNullOrWhiteSpace(txtRespObservac.Text) Or txtRespObservac.Text.Trim.ToLower = ToolTip1.GetToolTip(txtRespObservac).Trim.ToLower)
            If noPreguntar OrElse MessageBox.Show("¿Desea descartar el diálogo?", "Atención", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                InhabilitarResponder()
            End If
        End If
    End Sub

    Private Sub InhabilitarResponder()
        redactando = False
        lblRespEntidad.Text = ""
        txtRespObservac.Clear()
        pnlResponder.Enabled = False
        btnResponder.Text = "Agregar"
        btnResponder.ForeColor = Color.Maroon
        dgvComunicacion.Enabled = True
        ErrorProvider1.Dispose()
        'Pintar estrellas inactivas
        For i = 1 To 4
            PintarEstrella(i, False)
        Next
        dgvComunicacion_SelectionChanged(Nothing, Nothing) '--> para que tome la comunicacion seleccionada.
    End Sub

    Private Sub HabilitarResponder()
        redactando = True
        pnlResponder.Enabled = True
        cbxContacto.Checked = False
        btnResponder.Text = "Descartar"
        btnRespEnviar.ForeColor = Color.Maroon
        dgvComunicacion.Enabled = False
        PintarEstrella(1, True)
        txtRespObservac.Text = ToolTip1.GetToolTip(txtRespObservac)
        txtRespObservac.Focus()
    End Sub

    Private Sub txtRespObservac_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRespObservac.Validating
        If txtRespObservac.Text.Trim.Length > 0 Or Not txtRespObservac.Enabled Then
            ErrorProvider1.SetError(txtRespObservac, Nothing)
        End If
    End Sub

    Private Sub cbxContacto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxContacto.CheckedChanged
        With ClsCom.Comunicacion_linea
            .Entidad = .Comunicacion.Entidad
            .entidad_id = .Comunicacion.entidad_id
        End With
        lblRespEntidad.Text = ""
        If cbxContacto.Checked Then
            btnRespBuscar.Enabled = True
        Else
            btnRespBuscar.Enabled = False
        End If
    End Sub

    Private Sub btnRespBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRespBuscar.Click
        Dim dlg As Form
        dlg = modPermisos.ClsPermisos.loadForm(New modEntidad.FrmEntidadRelacion(Cls.Cliente.Entidad, Cls.Cliente.Entidad.lst_Relacion), True)
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ClsCom.Comunicacion_linea.entidad_id = dlg.Tag.id
            ClsCom.Comunicacion_linea.Entidad = dlg.Tag
            lblRespEntidad.Text = ClsCom.Comunicacion_linea.Entidad.AyN
        End If
    End Sub

    Private Sub btnRespEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRespEnviar.Click
        'If cbxRespValoracion.SelectedIndex = 0 Then
        '    ErrorProvider1.SetError(cbxRespValoracion, "Indique la valoración")
        'Else
        If txtRespObservac.Text = "" Then
            ErrorProvider1.SetError(txtRespObservac, "Ingrese alguna observación")
        Else
            AgregarDialogo()
            InhabilitarResponder()
            noRefrescar = True
            BuscarComunicaciones()
            bgsComunicacion.MoveFirst()
            noRefrescar = False
            dgvComunicacion_SelectionChanged(Nothing, Nothing)
        End If
        'End If
    End Sub

    Private Sub AgregarDialogo()
        'If dgvComunicacion.SelectedRows.Count = 1 Then
        With ClsCom.Comunicacion_linea
            .Comunicacion = ClsCom.Comunicacion
            .comunicacion_id = ClsCom.Comunicacion.id
            'Alex Tareas #5745 2018-07-11
            .Comunicacion.comunicacion_estado_id = cbxRespEstado.SelectedValue
            '.Comunicacion.estado = cbxRespEstado.Text
            If ClsCom.Comunicacion.id > 0 Then
                .Comunicacion.EstadoFila = "U"
            Else
                .Comunicacion.EstadoFila = "N"
                .Comunicacion.entidad_id = ClsCom.Cliente.entidad_id
                .Comunicacion.comunicacion_cat_id = .Comunicacion.Comunicacion_cat.id
            End If
            If .entidad_id = 0 Then
                .Entidad = .Comunicacion.Entidad
                .entidad_id = .Comunicacion.entidad_id
            End If
            .Usuario = ClsVariablesSesion.Instancia.Usuario
            .usuario_id = ClsVariablesSesion.Instancia.Usuario.id
            .motivo_id = cbxRespMotivo.SelectedValue
            .observaciones = txtRespObservac.Text
            '.valoracion = cbxRespValoracion.Text

            .fechahora = ClsVariablesSesion.Instancia.FechaHora '08-04-2021

            If .Comunicacion.lst_ComunicacionLinea.Exists(Function(x) x.lst_Tarea.Count > 0) Then
                Dim tareaID = (From cl In .Comunicacion.lst_ComunicacionLinea Where cl.lst_Tarea.Count > 0 Select cl.lst_Tarea.First).ToList '.Comunicacion.lst_ComunicacionLinea.First.lst_Tarea.First
                .lst_Tarea.AddRange(tareaID)
            End If

        End With
        ClsCom.PersistirComunicacion()
        'End If
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
        Dim pbx = pnlResponder.Controls.Find("pbxStar" & nro.ToString.Trim, False)
        If pbx.Count > 0 Then
            If Activar Then
                CType(pbx.First, PictureBox).Image = modRecursos.My.Resources.star_on
                ClsCom.Comunicacion_linea.valoracion = ToolTip1.GetToolTip(pbx.First)
            Else
                CType(pbx.First, PictureBox).Image = modRecursos.My.Resources.star_off
            End If
        End If
    End Sub

    Dim estrellaActiva As Integer = 1

    Private Sub pbxStar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxStar1.Click, pbxStar2.Click, pbxStar3.Click, pbxStar4.Click
        'Sólo al hacer click en una estrella se la toma como "valoración"
        With CType(sender, PictureBox)
            If .Enabled Then
                If IsNumeric(.Name.Substring(7, 1)) Then estrellaActiva = .Name.Substring(7, 1)
            End If
        End With
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
#End Region

#Region "HotKeys Dinamicas"
    Private Sub ColocarHotKeys(ByVal agregarTodo As Boolean)
        If agregarTodo Then
            ClsEst.ManejarKeyDown(tbpComunicaciones.FindForm, True) 'Agrega el manejador del KeyDown del formulario donde está la pestaña
            ClsEst.HotKeysBasicas(tbpComunicaciones, tbpComunicaciones.FindForm)
        End If
    End Sub
    Private Sub QuitarHotKeys()
        ClsEst.ManejarKeyDown(tbpComunicaciones.FindForm, False)
    End Sub
    Public Sub tbcPestanias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcPestanias.SelectedIndexChanged
        If CType(tbpComunicaciones.Parent, TabControl).SelectedTab Is tbpComunicaciones Then
            ColocarHotKeys(True)
            RefrescarComunicaciones()
        Else
            QuitarHotKeys()
        End If
    End Sub
#End Region

End Class