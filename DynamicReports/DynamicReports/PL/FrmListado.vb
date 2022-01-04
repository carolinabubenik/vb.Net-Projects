Imports modEntities

Public Class FrmListado

    Dim Cls As New ClsListado
    Dim bgsListado As New BindingSource
    Dim colorResalt, colorResalt2, colorRojo, colorAzul As Color

#Region "Inicializar"
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub FrmListado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AdecuarEstilos()

        InicializarControles()

        btnBuscar_Click(Nothing, Nothing)
        dgvListado.DataSource = bgsListado
        Habilitar(False)
    End Sub
    Private Sub AdecuarEstilos()
        'Form
        modEstilos.ClsEstilo.AplicarEstilo(Me, ClsVariablesSesion.Instancia)
        btnBuscar.Image = modRecursos.My.Resources.buscar
        btnNuevo.Image = modRecursos.My.Resources.add
        btnModificar.Image = modRecursos.My.Resources.modif
        btnEliminar.Image = modRecursos.My.Resources.borrar
        btnGuardar.Image = modRecursos.My.Resources.disk
        btnCancelar.Image = modRecursos.My.Resources.cross

        'Varios
        Dim lbl As New Label
        lbl.ForeColor = lblnombre.ForeColor 'Color por defecto.
        modEstilos.ClsEstilo.AplicarPropiedad(lbl, "ForeColor", "ColorResaltado")
        colorResalt = lbl.ForeColor
        lbl.ForeColor = lblnombre.ForeColor 'Color por defecto.
        modEstilos.ClsEstilo.AplicarPropiedad(lbl, "ForeColor", "ColorResaltado2")
        colorResalt2 = lbl.ForeColor
        lbl.ForeColor = Color.IndianRed   'Color por defecto.
        modEstilos.ClsEstilo.AplicarPropiedad(lbl, "ForeColor", "SEMAFORO_ROJO")
        colorRojo = lbl.ForeColor
        lbl.ForeColor = Color.Blue   'Color por defecto.
        modEstilos.ClsEstilo.AplicarPropiedad(lbl, "ForeColor", "SEMAFORO_AZUL")
        colorAzul = lbl.ForeColor

        'Sentencia SQL
        lblSenInfo.ForeColor = colorResalt2
        pbxSenInfo.Image = modRecursos.My.Resources.info.ToBitmap
        btnSenRefrescar.Image = modRecursos.My.Resources.actualizar

        'Columnas
        lblColInfo.ForeColor = colorResalt2
        pbxColInfo.Image = modRecursos.My.Resources.info.ToBitmap
        btnColAgregar.Image = modRecursos.My.Resources.add
        btnColCancelar.Image = modRecursos.My.Resources.cross
        btnColModificar.Image = modRecursos.My.Resources.modif
        btnColEliminar.Image = modRecursos.My.Resources.borrar
        ToolTip1.SetToolTip(btnColAgregar, "Agregar")
        ToolTip1.SetToolTip(btnColCancelar, "Descartar cambios")
        btnColSubir.Image = modRecursos.My.Resources.up
        btnColBajar.Image = modRecursos.My.Resources.down
        ToolTip1.SetToolTip(btnColSubir, "Subir")
        ToolTip1.SetToolTip(btnColBajar, "Bajar")

        'Parámetros
        lblParInfo.ForeColor = colorResalt2
        lblCondInfo.ForeColor = colorResalt2
        pbxParInfo.Image = modRecursos.My.Resources.info.ToBitmap
        pbxCondInfo.Image = modRecursos.My.Resources.info.ToBitmap
        btnParAgregar.Image = modRecursos.My.Resources.add
        btnParCancelar.Image = modRecursos.My.Resources.cross
        btnParModificar.Image = modRecursos.My.Resources.modif
        btnParEliminar.Image = modRecursos.My.Resources.borrar
        ToolTip1.SetToolTip(btnParAgregar, "Agregar")
        ToolTip1.SetToolTip(btnParCancelar, "Descartar cambios")
        btnParSubir.Image = modRecursos.My.Resources.up
        btnParBajar.Image = modRecursos.My.Resources.down
        ToolTip1.SetToolTip(btnParSubir, "Subir")
        ToolTip1.SetToolTip(btnParBajar, "Bajar")
        btnParAgregarCondicion.Image = modRecursos.My.Resources.add
        btnParModificarCond.Image = modRecursos.My.Resources.modif
        btnParEliminarCond.Image = modRecursos.My.Resources.borrar

    End Sub
    Private Sub InicializarControles()
        cbxParTipo.DataSource = ClsEnumerados.Instancia.lstListadoParametroTipo
        modFunciones.FuncUtiles.cbxAjustaAncho(cbxParTipo)
        cbxParDefecto.DataSource = ClsEnumerados.Instancia.lstListadoParametroDefecto
        modFunciones.FuncUtiles.cbxAjustaAncho(cbxParDefecto)

        chkColVisible_CheckedChanged(Nothing, Nothing)
    End Sub
#End Region
#Region "Navegacion"
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Cls.CargarLstListado()
        bgsListado.DataSource = (From L In Cls.lstListado Where modFunciones.FuncUtiles.ContienePalabras(String.Join(" ", {L.nombre, L.nombre_alias, L.descripcion}), txtNombreBus.Text.ToLower)).ToList
        bgsListado.ResetBindings(False)
    End Sub
    Private Sub dgvListado_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvListado.DataBindingComplete, dgvColumnas.DataBindingComplete
        colId.Visible = ClsVariablesSesion.Instancia.Usuario.superusuario
    End Sub
    Private Sub dgvListado_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvListado.SelectionChanged
        If dgvListado.CurrentRow IsNot Nothing Then
            Cls.Listado = dgvListado.CurrentRow.DataBoundItem
        Else
            Cls.Listado = Nothing
        End If
        CargarDatos()
        btnModificar.Enabled = (dgvListado.SelectedRows.Count = 1)
        btnEliminar.Enabled = (dgvListado.SelectedRows.Count = 1)
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Cls.Listado = Nothing
        Cls.Listado.EstadoFila = "N"
        CargarDatos()
        Habilitar(True)
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Cls.Listado.EstadoFila = "U"
        Habilitar(True)
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Está seguro de que desea eliminar el dato?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Cls.Listado.EstadoFila = "D"
            btnGuardar_Click(sender, Nothing)
            btnBuscar_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If txtNombre.Enabled AndAlso String.IsNullOrWhiteSpace(txtNombre.Text) Then
            ErrorProvider1.SetError(sender, "Indique un nombre único")
            e.Cancel = True
        Else
            If listado.FillListByNombre(txtNombre.Text.Trim, Cls.getConn).Exists(Function(x) x.id <> Cls.Listado.id) Then
                ErrorProvider1.SetError(sender, "El nombre no está disponible.")
                e.Cancel = True
            Else
                ErrorProvider1.SetError(sender, Nothing)
            End If
        End If
    End Sub
    Private Sub txtNombre_alias_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre_alias.Validating
        If txtNombre_alias.Enabled AndAlso String.IsNullOrWhiteSpace(txtNombre_alias.Text) Then
            ErrorProvider1.SetError(sender, "Indique un alias")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(sender, Nothing)
        End If
    End Sub
    Private Sub chkColAgrupa_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles chkColAgrupa.Validating
        If chkColAgrupa.Enabled AndAlso Not Cls.Listado.lstListadoColumna.Exists(Function(x) x.EstadoFila <> "D" AndAlso x.vAgrupaFilaAdic) Then
            ErrorProvider1.SetError(sender, "Debe indicar al menos una columna como agrupación de fila.")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(sender, Nothing)
        End If
    End Sub
    Private Sub chkColVisible_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles chkColVisible.Validating
        If chkColVisible.Enabled AndAlso Not Cls.Listado.lstListadoColumna.Exists(Function(x) x.EstadoFila <> "D" AndAlso x.vVisibleAdic) Then
            ErrorProvider1.SetError(sender, "Debe indicar al menos una columna visible.")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(sender, Nothing)
        End If
    End Sub
#End Region

#Region "Procedimientos"
    Private Sub Habilitar(ByVal valor As Boolean)
        tsBuscar.Enabled = Not valor
        gbxListado.Enabled = valor
        dgvListado.Enabled = Not valor
        btnNuevo.Enabled = Not valor
        btnModificar.Enabled = Not valor
        btnEliminar.Enabled = Not valor
        btnGuardar.Enabled = valor
        btnCancelar.Enabled = valor

        If valor Then
            btnSenRefrescar_Click(Nothing, Nothing)
        End If
    End Sub
    'Private Sub LimpiarDatos()
    '    txtNombre.Text = ""
    '    txtNombre_alias.Text = ""
    '    txtDescripcion.Text = ""
    '    txtSentencia.Text = ""
    'End Sub
    Private Sub CargarDatos()
        With Cls.Listado
            txtNombre.Text = .nombre
            txtNombre_alias.Text = .nombre_alias
            txtDescripcion.Text = .descripcion
            txtSentencia.Text = .sentencia
            MostrarColumnas()
            MostrarParametros()
        End With
    End Sub
#End Region
#Region "Sentencia"
    Private Sub btnSenRefrescar_Click(sender As Object, e As EventArgs) Handles btnSenRefrescar.Click
        'Que se ejecute sólo cuando se está editando.
        If txtSentencia.Enabled AndAlso Not String.IsNullOrWhiteSpace(txtSentencia.Text) Then

            For Each lp In Cls.Listado.lstListadoParametro.FindAll(Function(x) x.EstadoFila <> "D")
                txtSentencia.Find(lp.nombre, RichTextBoxFinds.WholeWord)
                txtSentencia.SelectionColor = colorRojo

                For Each lc In lp.lstListadoCondicion.FindAll(Function(x) x.EstadoFila <> "D")
                    txtSentencia.Find(lc.identificador, RichTextBoxFinds.WholeWord)
                    txtSentencia.SelectionColor = colorAzul
                Next
            Next

        End If
    End Sub
    Private Sub txtSentencia_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSentencia.Validating

        btnSenRefrescar_Click(Nothing, Nothing)

        If txtSentencia.Enabled AndAlso String.IsNullOrWhiteSpace(txtSentencia.Text) Then
            ErrorProvider1.SetError(sender, "Indique la sentencia SQL")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(sender, Nothing)
        End If
    End Sub
    'Private Sub txtSentencia_Leave(sender As Object, e As EventArgs) Handles txtSentencia.Leave
    '    pbxSenRefrescar_Click(Nothing, Nothing)
    'End Sub
    Private Sub cmsSentencia_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsSentencia.Opening

        cmsSentencia.Items.Clear()

        Dim lstItems As New List(Of ToolStripMenuItem)

        'Agregar Parámetros, agregar Condiciones
        For Each lp In Cls.Listado.lstListadoParametro.FindAll(Function(x) x.EstadoFila <> "D")
            'Crear Parámetro
            Dim i As New ToolStripMenuItem
            i.Text = lp.nombre
            i.Name = "btnSenAgregarPar" & lp.nombre
            i.Tag = lp
            AddHandler i.Click, AddressOf btnSenAgregarPar_Click
            cmsSentencia.Items.Add(i)

            For Each lc In lp.lstListadoCondicion.FindAll(Function(x) x.EstadoFila <> "D")
                'Crear Condición
                i = New ToolStripMenuItem
                i.Text = lc.identificador
                i.Name = "btnSenAgregarCond" & lc.identificador
                i.Tag = lc
                AddHandler i.Click, AddressOf btnSenAgregarCond_Click
                lstItems.Add(i)
            Next
        Next

        'Separador
        If cmsSentencia.Items.Count > 0 AndAlso lstItems.Count > 0 Then
            Dim sep As New ToolStripSeparator
            cmsSentencia.Items.Add(sep)
        End If

        'Agregar las condiciones
        For Each i In lstItems
            cmsSentencia.Items.Add(i)
        Next

    End Sub
    Private Sub btnSenAgregarPar_Click(sender As Object, e As EventArgs)
        If sender IsNot Nothing AndAlso sender.GetType Is GetType(ToolStripMenuItem) AndAlso CType(sender, ToolStripMenuItem).Tag.GetType Is GetType(listado_parametro) Then
            Dim lp = CType(CType(sender, ToolStripMenuItem).Tag, listado_parametro)

            txtSentencia.SelectedText = " " & lp.nombre & " "

            btnSenRefrescar_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub btnSenAgregarCond_Click(sender As Object, e As EventArgs)
        If sender IsNot Nothing AndAlso sender.GetType Is GetType(ToolStripMenuItem) AndAlso CType(sender, ToolStripMenuItem).Tag.GetType Is GetType(listado_condicion) Then
            Dim lc = CType(CType(sender, ToolStripMenuItem).Tag, listado_condicion)
            txtSentencia.SelectedText = " " & lc.identificador & " "
            'txtSentencia.AppendText(lc.identificador)
            btnSenRefrescar_Click(Nothing, Nothing)
        End If
    End Sub
#End Region
#Region "Columnas"
    Dim modificandoCol As Boolean = False

    Private Sub chkColVisible_CheckedChanged(sender As Object, e As EventArgs) Handles chkColVisible.CheckedChanged
        If chkColVisible.Enabled Then
            If chkColVisible.Checked Then
                rbtColTotaliza.Enabled = True
                rbtColContabiliza.Enabled = True
            Else
                rbtColTotaliza.Enabled = False
                rbtColContabiliza.Enabled = False
                rbtColTotaliza.Checked = False
                rbtColContabiliza.Checked = False
            End If
        End If
    End Sub
    Private Sub cmsColumna_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsColumna.Opening
        If dgvColumnas.CurrentRow Is Nothing Then
            e.Cancel = True
        End If
    End Sub
    Private Sub btnColModificar_Click(sender As Object, e As EventArgs) Handles btnColModificar.Click
        Cls.ListadoColumna = dgvColumnas.CurrentRow.DataBoundItem
        Cls.ListadoColumna.EstadoFila = "U"

        btnColAgregar.Image = modRecursos.My.Resources.predeterminado
        ToolTip1.SetToolTip(btnColAgregar, "Confirmar cambios")

        modificandoCol = True
        CargarColumna()
        HabilitarSeccionColumna(True)
    End Sub
    Private Sub CargarColumna()
        With Cls.ListadoColumna
            txtColNombre.Text = .nombre
            txtColAlias.Text = .nombre_alias
            chkColVisible.Checked = .vVisibleAdic
            rbtColTotaliza.Checked = .vTotalizaAdic
            rbtColContabiliza.Checked = .vContabilizaAdic
            chkColAgrupa.Checked = .vAgrupaFilaAdic
        End With
    End Sub
    ''' <summary>
    ''' Al habilita la seccion de datos de columna, se inhabilita la grilla.
    ''' </summary>
    ''' <param name="valor"></param>
    Private Sub HabilitarSeccionColumna(ByVal valor As Boolean)
        dgvColumnas.Enabled = Not valor
    End Sub
    Private Sub btnColAgregar_Click(sender As Object, e As EventArgs) Handles btnColAgregar.Click
        If ColumnaValida() Then
            If modificandoCol Then
                modificandoCol = False
                btnColAgregar.Image = modRecursos.My.Resources.add
                ToolTip1.SetToolTip(btnColAgregar, "Agregar")
            Else
                Cls.ListadoColumna = Nothing
                Cls.ListadoColumna.EstadoFila = "N"
                Dim ord As Integer = 0
                If Cls.Listado.lstListadoColumna.Exists(Function(x) x.EstadoFila <> "D") Then ord = Cls.Listado.lstListadoColumna.FindAll(Function(x) x.EstadoFila <> "D").Select(Function(x) x.orden).Max
                Cls.ListadoColumna.orden = ord + 1
                Cls.Listado.lstListadoColumna.Add(Cls.ListadoColumna)
            End If
            With Cls.ListadoColumna
                .nombre = txtColNombre.Text.Trim
                .nombre_alias = txtColAlias.Text.Trim
                .setAdicional(listado_columna.vNombreAdicVisible, IIf(chkColVisible.Checked, 1, 0))
                .setAdicional(listado_columna.vNombreAdicTotaliza, IIf(rbtColTotaliza.Checked, 1, 0))
                .setAdicional(listado_columna.vNombreAdicContabiliza, IIf(rbtColContabiliza.Checked, 1, 0))
                .setAdicional(listado_columna.vNombreAdicAgrupaFila, IIf(chkColAgrupa.Checked, 1, 0))

                HabilitarSeccionColumna(False)
                MostrarColumnas()
                Cls.ListadoColumna = Nothing
                CargarColumna()
                txtColNombre.Select()
            End With
        End If
    End Sub
    Private Function ColumnaValida() As Boolean
        ColumnaValida = True
        ErrorProvider1.SetError(txtColAlias, Nothing)
        If txtColNombre.Enabled Then
            If String.IsNullOrWhiteSpace(txtColNombre.Text) Then
                ErrorProvider1.SetError(txtColNombre, "Indique el dato")
                ColumnaValida = False
            ElseIf Cls.Listado.lstListadoColumna.Exists(Function(x) x.EstadoFila <> "D" AndAlso (Not modificandoCol OrElse x IsNot Cls.ListadoColumna) AndAlso x.nombre.Trim.ToLower = txtColNombre.Text.Trim.ToLower) Then
                ErrorProvider1.SetError(txtColNombre, "El nombre no está disponible")
                ColumnaValida = False
            End If
        End If

        If txtColAlias.Enabled AndAlso String.IsNullOrWhiteSpace(txtColAlias.Text) AndAlso chkColVisible.Checked Then
            ErrorProvider1.SetError(txtColAlias, "Una columna visible debe tener un alias a mostrar")
            ColumnaValida = False
        Else
            ErrorProvider1.SetError(txtColAlias, Nothing)
        End If
    End Function
    Private Sub MostrarColumnas()
        dgvColumnas.DataSource = Cls.Listado.lstListadoColumna.FindAll(Function(x) x.EstadoFila <> "D").OrderBy(Function(x) x.orden).ToList
    End Sub
    Private Sub btnColCancelar_Click(sender As Object, e As EventArgs) Handles btnColCancelar.Click
        ErrorProvider1.SetError(txtColNombre, Nothing)
        ErrorProvider1.SetError(txtColAlias, Nothing)

        btnColAgregar.Image = modRecursos.My.Resources.add
        ToolTip1.SetToolTip(btnColAgregar, "Agregar")

        modificandoCol = False
        Cls.ListadoColumna = Nothing
        CargarColumna()
        HabilitarSeccionColumna(False)
        MostrarColumnas()
    End Sub
    Private Sub btnColEliminar_Click(sender As Object, e As EventArgs) Handles btnColEliminar.Click
        Cls.ListadoColumna = dgvColumnas.CurrentRow.DataBoundItem
        'If MessageBox.Show("¿Está seguro de que desea eliminar la columna?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
        Cls.ListadoColumna.EstadoFila = "D"
        MostrarColumnas()
        'End If
    End Sub
    Private Sub btnColAgregar_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles btnColAgregar.Validating
        If modificandoCol Then
            ErrorProvider1.SetError(sender, "Guarde o descarte los cambios")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(sender, Nothing)
        End If
    End Sub
    Private Sub btnColSubirBajar_Click(sender As Object, e As EventArgs) Handles btnColSubir.Click, btnColBajar.Click
        If dgvColumnas.CurrentRow IsNot Nothing Then
            Cls.ListadoColumna = dgvColumnas.CurrentRow.DataBoundItem

            Dim otro As listado_columna
            If sender Is btnColSubir Then
                otro = Cls.Listado.lstListadoColumna.OrderByDescending(Function(x) x.orden).ToList.Find(Function(x) x.EstadoFila <> "D" And x.orden < Cls.ListadoColumna.orden)
            Else
                otro = Cls.Listado.lstListadoColumna.OrderBy(Function(x) x.orden).ToList.Find(Function(x) x.EstadoFila <> "D" And x.orden > Cls.ListadoColumna.orden)
            End If
            If otro IsNot Nothing Then
                Cls.ListadoColumna.EstadoFila = "U"
                otro.EstadoFila = "U"
                Dim actual = Cls.ListadoColumna.orden
                Cls.ListadoColumna.orden = otro.orden
                Dim lc = Cls.ListadoColumna 'Resguardar para poder seleccionar nuevamente
                otro.orden = actual
                MostrarColumnas()
                Dim filas = (From r As DataGridViewRow In dgvColumnas.Rows() Where CType(r.DataBoundItem, listado_columna) Is lc)
                If filas IsNot Nothing AndAlso filas.Count > 0 Then dgvColumnas.CurrentCell = filas.First.Cells(colColNombre.Name)
            End If
        End If
    End Sub
    'Private Sub btnColBajar_Click(sender As Object, e As EventArgs) Handles btnColBajar.Click
    '    If dgvColumnas.CurrentRow IsNot Nothing Then
    '        Cls.ListadoColumna = dgvColumnas.CurrentRow.DataBoundItem

    '        Dim otro = Cls.Listado.lstListadoColumna.OrderBy(Function(x) x.orden).ToList.Find(Function(x) x.EstadoFila <> "D" And x.orden > Cls.ListadoColumna.orden)
    '        If otro IsNot Nothing Then
    '            Dim actual = Cls.ListadoColumna.orden
    '            Cls.ListadoColumna.orden = otro.orden
    '            otro.orden = actual
    '            MostrarColumnas()
    '        End If
    '    End If
    'End Sub
    Private Sub txtColNombre_Leave(sender As Object, e As EventArgs) Handles txtColNombre.Leave
        txtColNombre.Text = txtColNombre.Text.Trim.ToLower.Replace(" ", "_")
    End Sub
#End Region
#Region "Parametros"
    Dim modificandoPar As Boolean = False

    Private Sub cmsParametro_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsParametro.Opening
        If dgvParametros.CurrentRow Is Nothing Then
            e.Cancel = True
        Else
            Cls.ListadoParametro = dgvParametros.CurrentRow.DataBoundItem
            DibujarCondiciones(Cls.ListadoParametro)
        End If
    End Sub
    Private Sub btnparModificar_Click(sender As Object, e As EventArgs) Handles btnParModificar.Click
        Cls.ListadoParametro = dgvParametros.CurrentRow.DataBoundItem
        Cls.ListadoParametro.EstadoFila = "U"

        btnParAgregar.Image = modRecursos.My.Resources.predeterminado
        ToolTip1.SetToolTip(btnParAgregar, "Confirmar cambios")

        modificandoPar = True
        CargarParametro()
        HabilitarSeccionParametro(True)
    End Sub
    Private Sub CargarParametro()
        With Cls.ListadoParametro
            txtParNombre.Text = .nombre
            txtParAlias.Text = .nombre_alias
            cbxParTipo.Text = .tipo
            cbxParDefecto.Text = .defecto
            txtParDefecto.Text = .vDefectoOtroAdic
            chkParVisible.Checked = .vVisibleAdic
        End With
    End Sub
    Private Sub cbxParDefecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxParDefecto.SelectedIndexChanged
        spcParDefecto.Panel2Collapsed = (cbxParDefecto.Text <> listado_parametro.DEFECTO_OTRO)
    End Sub
    ''' <summary>
    ''' Al habilita la seccion de datos de parametros, se inhabilita la grilla.
    ''' </summary>
    ''' <param name="valor"></param>
    Private Sub HabilitarSeccionParametro(ByVal valor As Boolean)
        dgvParametros.Enabled = Not valor
    End Sub
    Private Sub btnParAgregar_Click(sender As Object, e As EventArgs) Handles btnParAgregar.Click
        If ParametroValido() Then
            If modificandoPar Then
                modificandoPar = False
                btnParAgregar.Image = modRecursos.My.Resources.add
                ToolTip1.SetToolTip(btnParAgregar, "Agregar")
            Else
                Cls.ListadoParametro = Nothing
                Cls.ListadoParametro.EstadoFila = "N"

                Dim ord As Integer = 0
                If Cls.Listado.lstListadoParametro.Exists(Function(x) x.EstadoFila <> "D") Then ord = Cls.Listado.lstListadoParametro.FindAll(Function(x) x.EstadoFila <> "D").Select(Function(x) x.vOrdenAdic).Max
                Cls.ListadoParametro.vOrdenAdic = ord + 1
                Cls.Listado.lstListadoParametro.Add(Cls.ListadoParametro)
            End If
            With Cls.ListadoParametro
                .nombre = txtParNombre.Text.Trim
                .nombre_alias = txtParAlias.Text.Trim
                .tipo = cbxParTipo.Text
                .defecto = cbxParDefecto.Text
                .vVisibleAdic = chkParVisible.Checked 'IIf(, "1", "0")

                If spcParDefecto.Panel2Collapsed Then 'Si está colapsado (oculto), limpiar el defecto-otro.
                    .setAdicional(listado_parametro.vNombreAdicDefectoOtro, "")
                Else 'Si está visible, guardar el valor defecto-otro.
                    .setAdicional(listado_parametro.vNombreAdicDefectoOtro, txtParDefecto.Text)
                End If

                HabilitarSeccionParametro(False)
                MostrarParametros()
                Cls.ListadoParametro = Nothing
                CargarParametro()
                txtParNombre.Select()
            End With
        End If
    End Sub
    Private Function ParametroValido() As Boolean
        ParametroValido = True
        ErrorProvider1.SetError(txtParNombre, Nothing)
        If txtParNombre.Enabled Then
            If String.IsNullOrWhiteSpace(txtParNombre.Text.Replace("?", "")) Then
                ErrorProvider1.SetError(txtParNombre, "Indique el dato")
                ParametroValido = False
            ElseIf Cls.Listado.lstListadoParametro.Exists(Function(x) x.EstadoFila <> "D" AndAlso (Not modificandoPar OrElse x IsNot Cls.ListadoParametro) AndAlso x.nombre.Trim.ToLower = txtParNombre.Text.Trim.ToLower) Then
                ErrorProvider1.SetError(txtParNombre, "El nombre no está disponible")
                ParametroValido = False
            End If
        End If
        If txtParAlias.Enabled AndAlso String.IsNullOrWhiteSpace(txtParAlias.Text) Then
            ErrorProvider1.SetError(txtParAlias, "Indique el alias a mostrar")
            ParametroValido = False
        Else
            ErrorProvider1.SetError(txtParAlias, Nothing)
        End If
        If cbxParTipo.Enabled AndAlso String.IsNullOrWhiteSpace(cbxParTipo.Text) Then
            ErrorProvider1.SetError(cbxParTipo, "Indique el tipo del parámetro")
            ParametroValido = False
        Else
            ErrorProvider1.SetError(cbxParTipo, Nothing)
        End If

        ErrorProvider1.SetError(cbxParDefecto, Nothing)
        ErrorProvider1.SetError(txtParDefecto, Nothing)
        If cbxParDefecto.Enabled Then
            If String.IsNullOrWhiteSpace(cbxParDefecto.Text) Then
                ErrorProvider1.SetError(cbxParTipo, "Indique el valor por defecto")
                ParametroValido = False
            ElseIf cbxParDefecto.Text = listado_parametro.DEFECTO_OTRO AndAlso String.IsNullOrWhiteSpace(txtParDefecto.Text) Then
                ErrorProvider1.SetError(txtParDefecto, "Indique el valor por defecto")
                ParametroValido = False
            End If
        End If

    End Function
    Private Sub MostrarParametros()
        dgvParametros.DataSource = Cls.Listado.lstListadoParametro.FindAll(Function(x) x.EstadoFila <> "D").OrderBy(Function(x) x.vOrdenAdic).ToList
    End Sub
    Private Sub btnParCancelar_Click(sender As Object, e As EventArgs) Handles btnParCancelar.Click
        ErrorProvider1.SetError(txtParNombre, Nothing)
        ErrorProvider1.SetError(txtParAlias, Nothing)
        ErrorProvider1.SetError(cbxParTipo, Nothing)

        btnParAgregar.Image = modRecursos.My.Resources.add
        ToolTip1.SetToolTip(btnParAgregar, "Agregar")

        modificandoPar = False
        Cls.ListadoParametro = Nothing
        CargarParametro()
        HabilitarSeccionParametro(False)
        MostrarParametros()
    End Sub
    'Private Sub btnColEliminar_Click(sender As Object, e As EventArgs) Handles btnColEliminar.Click
    '    Cls.ListadoColumna = dgvColumnas.CurrentRow.DataBoundItem
    '    'If MessageBox.Show("¿Está seguro de que desea eliminar la columna?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
    '    Cls.ListadoColumna.EstadoFila = "D"
    '    MostrarColumnas()
    '    'End If
    'End Sub
    Private Sub btnParAgregar_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles btnParAgregar.Validating
        If modificandoPar Then
            ErrorProvider1.SetError(sender, "Guarde o descarte los cambios")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(sender, Nothing)
        End If
    End Sub
    Private Sub btnParSubirBajar_Click(sender As Object, e As EventArgs) Handles btnParSubir.Click, btnParBajar.Click
        If dgvParametros.CurrentRow IsNot Nothing Then
            Cls.ListadoParametro = dgvParametros.CurrentRow.DataBoundItem

            Dim otro As listado_parametro
            If sender Is btnParSubir Then
                otro = Cls.Listado.lstListadoParametro.OrderByDescending(Function(x) x.vOrdenAdic).ToList.Find(Function(x) x.EstadoFila <> "D" And x.vOrdenAdic < Cls.ListadoParametro.vOrdenAdic)
            Else
                otro = Cls.Listado.lstListadoParametro.OrderBy(Function(x) x.vOrdenAdic).ToList.Find(Function(x) x.EstadoFila <> "D" And x.vOrdenAdic > Cls.ListadoParametro.vOrdenAdic)
            End If
            If otro IsNot Nothing Then
                Cls.ListadoParametro.EstadoFila = "U"
                otro.EstadoFila = "U"

                Dim actual = Cls.ListadoParametro.vOrdenAdic
                Cls.ListadoParametro.setAdicional(listado_parametro.vNombreAdicOrden, otro.vOrdenAdic)
                Dim lp = Cls.ListadoParametro 'Resguardar para poder seleccionar nuevamente
                otro.setAdicional(listado_parametro.vNombreAdicOrden, actual)
                MostrarParametros()
                Dim filas = (From r As DataGridViewRow In dgvParametros.Rows() Where CType(r.DataBoundItem, listado_parametro) Is lp)
                If filas IsNot Nothing AndAlso filas.Count > 0 Then dgvParametros.CurrentCell = filas.First.Cells(colParNombre.Name)
            End If
        End If
    End Sub
    Private Sub txtParNombre_Leave(sender As Object, e As EventArgs) Handles txtParNombre.Leave
        txtParNombre.Text = txtParNombre.Text.Trim.ToLower.Replace(" ", "_")
        If Not txtParNombre.Text.StartsWith("?") Then txtParNombre.Text = "?" & txtParNombre.Text
    End Sub
#End Region
#Region "Condiciones"
    Private Sub btnParAgregarCondicion_Click(sender As Object, e As EventArgs) Handles btnParAgregarCondicion.Click
        Cls.ListadoParametro = dgvParametros.CurrentRow.DataBoundItem
        Cls.ListadoCondicion = Nothing
        With Cls.ListadoCondicion

            'De la forma: COND_DESDE | COND_DESDE1 | COND_DESDE2
            .identificador = Cls.ListadoParametro.NuevoIdentificadorCondicion

            Dim frm As New modFunciones.FrmIngresar("Indique la condición. Esta cadena será reemplazada en todos los lugares de la Sentencia SQL donde figure """ & .identificador & """.", .identificador, "", "V")
            If frm.ShowDialog = DialogResult.OK Then
                .EstadoFila = "N"
                .condicion = frm.Tag
                'Cls.ListadoParametro.EstadoFila = "U"
                Cls.ListadoParametro.lstListadoCondicion.Add(Cls.ListadoCondicion)
                MostrarParametros()
            End If
        End With
    End Sub
    Private Sub DibujarCondiciones(ByVal lp As listado_parametro)
        'Modificar
        btnParModificarCond.Enabled = False
        'Eliminar
        btnParEliminarCond.Enabled = False

        For Each lc In lp.lstListadoCondicion.FindAll(Function(x) x.EstadoFila <> "D").ToList
            'Modificar
            btnParModificarCond.Enabled = True
            Dim i As New ToolStripMenuItem
            i.Text = lc.identificador
            i.Name = "btnCondModificar_" & lc.identificador
            i.Tag = lc
            AddHandler i.Click, AddressOf btnCondModificar_Click
            btnParModificarCond.DropDownItems.Add(i)

            'Eliminar
            btnParEliminarCond.Enabled = True
            i = New ToolStripMenuItem
            i.Text = lc.identificador
            i.Name = "btnCondEliminar_" & lc.identificador
            i.Tag = lc
            AddHandler i.Click, AddressOf btnCondEliminar_Click
            btnParEliminarCond.DropDownItems.Add(i)
        Next
    End Sub
    Private Sub btnCondModificar_Click(sender As Object, e As EventArgs)
        Cls.ListadoCondicion = CType(sender, ToolStripMenuItem).Tag
        With Cls.ListadoCondicion
            Dim frm As New modFunciones.FrmIngresar("Indique la condición. Esta cadena será reemplazada en todos los lugares de la Sentencia SQL donde figure """ & .identificador & """.", .identificador, .condicion, "V")
            If frm.ShowDialog = DialogResult.OK Then
                Cls.ListadoParametro.EstadoFila = "U"
                .EstadoFila = "U"
                .condicion = frm.Tag
                MostrarParametros()
            End If
        End With
    End Sub

    Private Sub btnParEliminar_Click(sender As Object, e As EventArgs) Handles btnParEliminar.Click
        Cls.ListadoParametro = dgvParametros.CurrentRow.DataBoundItem
        Cls.ListadoParametro.EstadoFila = "D"
        MostrarParametros()
    End Sub

    Private Sub cbxParTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxParTipo.SelectedIndexChanged
        Dim valorAnteriorDef = txtParDefecto.Text
        'Caro 2018-10-19: Agrego esta "ayuda" para el nuevo tipo de Combo Enumerados
        If cbxParTipo.Text = listado_parametro.TIPO_COMBO_ENUMERADOS Then 'Agreagr: cbxParTipo.Text =
            If String.IsNullOrWhiteSpace(valorAnteriorDef) Then txtParDefecto.Text = "nombreLista|valueMember|displayMember"
        Else
            txtParDefecto.Text = valorAnteriorDef
        End If
    End Sub

    Private Sub btnCondEliminar_Click(sender As Object, e As EventArgs)
        Cls.ListadoCondicion = CType(sender, ToolStripMenuItem).Tag
        With Cls.ListadoCondicion
            .EstadoFila = "D"
            MostrarParametros()
        End With
    End Sub
#End Region
#Region "Guardar/Cancelar"
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If sender IsNot btnEliminar Then 'Para que no valide cuando se está eliminando
            If Me.ValidateChildren Then 'Para que no valide cuando se está eliminando
                With Cls.Listado
                    .nombre = txtNombre.Text
                    .nombre_alias = txtNombre_alias.Text
                    .descripcion = txtDescripcion.Text
                    .sentencia = txtSentencia.Text
                End With
            Else
                Exit Sub
            End If
        End If
        Dim exito As Boolean = False
        Cls.IniciarTrn()
        Try
            Cls.PersistirListado()
            Cls.gettrn.Commit()
            exito = True
        Catch ex As Exception
            Cls.gettrn.Rollback()
            MessageBox.Show(modRecursos.My.Resources.ERROR_GUARDAR & vbNewLine & vbNewLine & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        If exito Then
            MessageBox.Show(modRecursos.My.Resources.EXITO_GUARDAR, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCancelar_Click(Nothing, Nothing)
            btnBuscar_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Cls.Listado = Nothing
        dgvListado_SelectionChanged(Nothing, Nothing)
        Habilitar(False)
    End Sub
#End Region
End Class

