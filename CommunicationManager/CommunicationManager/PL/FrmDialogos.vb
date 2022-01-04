Imports modEntities
Imports Telerik.WinControls.UI
Public Class FrmDialogos
    Dim Cls As New ClsComunicacion

#Region "Inicializar"

    Public Sub New(ByVal comunicacion As comunicacion, ByVal alFrente As Boolean, ByVal agregarDialogos As Boolean)
        InitializeComponent()

        Cls.Comunicacion = comunicacion
        Me.TopMost = alFrente
        spcDialogos.Panel2Collapsed = Not agregarDialogos
    End Sub
    Public Sub New(ByVal ClsVarSes As ClsVariablesSesion, ByVal comunicacion As comunicacion, ByVal alFrente As Boolean, ByVal agregarDialogos As Boolean)
        InitializeComponent()

        ClsVariablesSesion.Instancia = ClsVarSes
        Cls.Comunicacion = comunicacion
        Me.TopMost = alFrente
        spcDialogos.Panel2Collapsed = Not agregarDialogos
    End Sub
    Public Sub SetearColoresDialogos(Optional ByVal colorTitulos As Color = Nothing, Optional ByVal colorLabels As Color = Nothing, Optional ByVal colorLinkLabels As Color = Nothing, Optional ByVal colorTextoABuscar As Color = Nothing)
        Cls.SetearColoresDialogos(colorTitulos, colorLabels, colorLinkLabels, colorTextoABuscar)
    End Sub
    Public Sub FrmDialogos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modEstilos.ClsEstilo.AplicarEstilo(Me, ClsVariablesSesion.Instancia)

        'Combos 

        'Pertenece
        Dim lstPer = ClsEnumerados.Instancia.lstMotivoPertenece
        If Not lstPer.Exists(Function(x) x = "TODAS") Then lstPer.Insert(0, "TODAS")
        cbxPertenece.DataSource = lstPer
        modFunciones.FuncUtiles.cbxAjustaAncho(cbxPertenece)

        'Motivos: van en el selection_changed del cbxPertenece
        With cbxRespEstado
            .DisplayMember = "nombre"
            .ValueMember = "id"
            .DataSource = ClsEnumerados.Instancia.lst_ComunicacionEstado.FindAll(Function(x) Not x.vDadaDeBaja).ToList
        End With
        'cbxRespEstado.DataSource = Cls.lst_RespComunicacionEstado
        With cbxRespMotivo
            .DisplayMember = "descripcionModif"
            .ValueMember = "id"
            .DataSource = Cls.getArbolMotivos("TODAS", Cls.Comunicacion) 'Cls.getArbolMotivos(0, "")
            modFunciones.FuncUtiles.cbxAjustaAnchoLista(cbxRespMotivo)
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .DropDownListElement.AutoCompleteSuggest = New modFunciones.CustomAutoCompleteSuggestHelper(cbxRespMotivo.DropDownListElement)
            .DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains

        End With
        btnResponder.Parent = spcDialogos.Panel2
        btnResponder.BringToFront()
        InhabilitarResponder()

        CargarComunicacion(Cls.Comunicacion)
    End Sub
    Public Sub CargarComunicacion(ByVal comunicacion As comunicacion)
        'Si está redactando no se pueden redibujar los diálogos. Se debe descartar primero.
        If redactando Then
            Me.TopMost = False
            If txtRespObservac.Text.Trim.Length = 0 OrElse MessageBox.Show("Está redactando un diálogo. ¿Desea descartarlo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                InhabilitarResponder()
            Else
                Exit Sub
            End If
            Me.TopMost = True
        End If
        Cls.Comunicacion = comunicacion
        With Cls.Comunicacion
            lblComAyN.Text = .EntidadAyN
            lblComCategoria.Text = .DescripcionCat
            lblComFecha.Text = String.Format("{0:dd/MM/yyyy hh:mm}", .fecha_hora)
            'Alex Tareas #5745 2018-07-11
            lblComEstado.Text = .Comunicacion_estado.nombre
            'lblComEstado.Text = .estado
        End With

        btnResponder.ForeColor = Color.Maroon
        btnResponder.Enabled = True 'Antes estaban en MostrarDialogos

        MostrarDialogos()
    End Sub
#End Region
#Region "Dialogos"
    Dim separacion As Integer = 10
    Private Sub MostrarDialogos()
        '
        pnlDialogos.Controls.Clear()
        Cls.DibujarDialogos(pnlDialogos, modRecursos.My.Resources.star_on, txtBuscador.Text, , cbxPertenece.Text, cbxMotivo.SelectedValue)
    End Sub
    Private Sub RedibujarDialogos()
        For Each p As Control In pnlDialogos.Controls
            If p.GetType = GetType(Panel) Then
                p.Width = pnlDialogos.Width - (separacion * 4)
                Dim cPara, cEntidad, cSucursal, cCrearT, cVerT As New Control
                For Each c In p.Controls
                    Select Case c.name
                        Case "lblEntidad"
                            cEntidad = c
                        Case "lblSucursal" 'Caro 2017-06-05: se agregó este control.
                            cSucursal = c
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
                cSucursal.Left = p.Width - cSucursal.Width - separacion
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
#Region "Navegación"
    Private Sub cbxPertenece_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxPertenece.SelectedIndexChanged
        'Cargar los motivos según lo que seleccionó
        With cbxMotivo
            .ValueMember = "id"
            .DisplayMember = "descripcionModif"
            Dim lstMot = Cls.getArbolMotivos(cbxPertenece.Text, Cls.Comunicacion)
            Dim m As New motivo
            m.descripcionModif = "TODAS"
            lstMot.Insert(0, m)
            .DataSource = lstMot
            modFunciones.FuncUtiles.cbxAjustaAncho(cbxMotivo)
        End With
    End Sub
    Private Sub cbxMotivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMotivo.SelectedIndexChanged
        MostrarDialogos()
    End Sub
    Private Sub txtBuscador_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscador.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            MostrarDialogos()
        End If
    End Sub
    Private Sub FrmDialogos_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If redactando Then
            Me.TopMost = False
            If txtRespObservac.Text.Trim.Length > 0 AndAlso Not MessageBox.Show("Está redactando un diálogo. ¿Desea descartarlo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
                Me.TopMost = True
                Exit Sub
            End If
            InhabilitarResponder()
        End If
    End Sub

#Region "Responder"
    Dim redactando As Boolean = False
    Private Sub btnResponder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResponder.Click
        If Not redactando Then
            HabilitarResponder()
        Else
            If MessageBox.Show("¿Desea descartar el diálogo?", "Atención", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
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
        ErrorProvider1.Dispose()
        'Pintar estrellas inactivas
        For i = 1 To 4
            PintarEstrella(i, False)
        Next
    End Sub
    Private Sub HabilitarResponder()
        redactando = True
        pnlResponder.Enabled = True
        chkContacto.Checked = False
        btnResponder.Text = "Descartar"
        btnRespEnviar.ForeColor = Color.Maroon
        PintarEstrella(1, True)
    End Sub
    Private Sub txtRespObservac_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRespObservac.Validating
        If txtRespObservac.Text.Trim.Length > 0 Or Not txtRespObservac.Enabled Then
            ErrorProvider1.SetError(txtRespObservac, Nothing)
        End If
    End Sub

    Private Sub cbxRespMotivo_Validating_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cbxRespMotivo.Validating
        If cbxRespMotivo.Enabled AndAlso cbxRespMotivo.SelectedItem.DataBoundItem Is Nothing Then
            ErrorProvider1.SetError(sender, "Indique el motivo")
            e.Cancel = True
            Exit Sub
        End If
        ErrorProvider1.SetError(sender, Nothing)
    End Sub

    Private Sub btnRespBuscar_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles btnRespBuscar.Validating
        If chkContacto.Enabled AndAlso chkContacto.Checked Then
            With Cls.Comunicacion_linea
                If .entidad_id = .Comunicacion.entidad_id Then
                    ErrorProvider1.SetError(sender, "Indique el contacto")
                    e.Cancel = True
                    Exit Sub
                End If
            End With
        End If
        ErrorProvider1.SetError(sender, Nothing)
    End Sub
    Private Sub chkContacto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkContacto.CheckedChanged
        With Cls.Comunicacion_linea
            .Entidad = .Comunicacion.Entidad
            .entidad_id = .Comunicacion.entidad_id
        End With
        lblRespEntidad.Text = ""
        If chkContacto.Checked Then
            btnRespBuscar.Enabled = True
        Else
            btnRespBuscar.Enabled = False
        End If
    End Sub
    Private Sub btnRespBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRespBuscar.Click
        'Dim dlg As Form
        'dlg = modPermisos.ClsPermisos.loadForm(New modEntidad.FrmEntidadRelacion(Cls.Cliente.Entidad, Cls.Cliente.Entidad.lst_Relacion), True)
        'If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    Cls.Comunicacion_linea.entidad_id = dlg.Tag.id
        '    Cls.Comunicacion_linea.Entidad = dlg.Tag
        '    lblRespEntidad.Text = Cls.Comunicacion_linea.Entidad.AyN
        'End If
    End Sub
    Private Sub btnRespEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRespEnviar.Click
        If txtRespObservac.Text = "" Then
            ErrorProvider1.SetError(txtRespObservac, "Ingrese alguna observación")
        Else
            AgregarDialogo()
        End If
    End Sub
    Private Sub AgregarDialogo()
        With Cls.Comunicacion_linea
            .sucursal_id = ClsVariablesSesion.Instancia.Sucursal.id
            .Comunicacion = Cls.Comunicacion
            .comunicacion_id = Cls.Comunicacion.id
            'Alex Tareas #5745 2018-07-11
            .Comunicacion.comunicacion_estado_id = cbxRespEstado.SelectedValue
            '.Comunicacion.estado = cbxRespEstado.Text
            If Cls.Comunicacion.id > 0 Then
                .Comunicacion.EstadoFila = "U"
            Else
                .Comunicacion.EstadoFila = "N"
                .Comunicacion.entidad_id = Cls.Cliente.entidad_id
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
        End With
        Dim exito As Boolean = False
        Cls.IniciarTrn()
        Try
            Cls.PersistirComunicacion()
            Cls.gettrn.Commit()
            exito = True
        Catch ex As Exception
            Cls.gettrn.Rollback()
            MessageBox.Show("Ha ocurrido un error." & vbNewLine & ex.Message)
        End Try
        If exito Then
            InhabilitarResponder()
            Cls.Comunicacion.lst_ComunicacionLinea = Nothing
            CargarComunicacion(Cls.Comunicacion)
        End If
    End Sub

    Private Sub cbxRespMotivo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxRespMotivo.SelectedValueChanged
        txtRespObservac.Text = ""
        If cbxRespMotivo.SelectedItem IsNot Nothing Then
            txtRespObservac.Text = CType(cbxRespMotivo.SelectedItem.DataBoundItem, motivo).descripcion_dialogo
        End If
    End Sub

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
                Cls.Comunicacion_linea.valoracion = ToolTip1.GetToolTip(pbx.First)
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

#End Region
#End Region
#Region "Guardar/Cancelar"

#End Region

End Class