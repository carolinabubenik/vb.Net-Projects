Imports modEntities

Public Class FrmReglas
    Dim Cls As New ClsRegla
    Dim bgsCondiciones, bgsReglas As New BindingSource
    Dim colSelFore, colFore As Color

#Region "Inicializar"
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmReglas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClsEstilo.AplicarEstilo(Me)
        colSelFore = dgvRegla.DefaultCellStyle.ForeColor
        colSelFore = dgvRegla.DefaultCellStyle.SelectionForeColor

        Cls.cargar()

        With cbxReglaAplica
            .ValueMember = "id"
            .DisplayMember = "nombre"
            Dim lstRA As New List(Of regla_aplica)
            lstRA.Add(New regla_aplica)
            lstRA.AddRange(Cls.lstRegla_aplica)
            .DataSource = lstRA
        End With
        With cbxCampo
            .ValueMember = "id"
            .DisplayMember = "nombre"
            .DataSource = Cls.lstRegla_campo
        End With
        With cbxOperador
            '.ValueMember = "id"
            '.DisplayMember = "operador"
            .DataSource = ClsEnumerados.Instancia.lstReglasOperadores
        End With
        dgvCondicion.AutoGenerateColumns = False
        dgvRegla.AutoGenerateColumns = False
        bgsReglas.DataSource = (From r In Cls.lstRegla Order By r.vAplica, r.orden).ToList
        dgvCondicion.DataSource = bgsCondiciones
        dgvRegla.DataSource = bgsReglas
        bgsCondiciones.DataSource = (From c In Cls.Regla.lstReglaCondicion Where c.EstadoFila <> "D").ToList  'Cls.lstRegla_condicion
        bgsCondiciones.ResetBindings(False)

        habilitar(False)
    End Sub
#End Region
#Region "Navegación"
    Private Sub habilitar(ByVal flg As Boolean)
        gbxRelga.Enabled = flg
        gbx1.Enabled = Not flg
        btoGuardar.Enabled = flg
        btnCancelar.Enabled = flg
        btoModificar.Enabled = Not flg
        btoNuevo.Enabled = Not flg
        btoEliminar.Enabled = Not flg
    End Sub
    Private Sub btnAgregarCondicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCondicion.Click
        ErrorProvider1.SetError(cbxCampo, Nothing)
        ErrorProvider1.SetError(tbxValor, Nothing)
        ErrorProvider1.SetError(rdbNo, Nothing)
        If cbxCampo.SelectedItem Is Nothing OrElse cbxCampo.SelectedValue = 0 Then
            ErrorProvider1.SetError(cbxCampo, "Indique el campo")
            Exit Sub
        End If
        If tbxValor.Visible AndAlso String.IsNullOrWhiteSpace(tbxValor.Text) Then
            ErrorProvider1.SetError(tbxValor, "Indique el valor")
            Exit Sub
        End If
        If rdbSi.Visible AndAlso Not rdbSi.Checked And Not rdbNo.Checked Then
            ErrorProvider1.SetError(rdbNo, "Indique el valor")
            Exit Sub
        End If
        Cls.regla_condicion = Nothing
        cbxReglaAplica.Enabled = False
        With Cls.regla_condicion
            .regla_campo_id = cbxCampo.SelectedValue
            .Regla_campo = cbxCampo.SelectedItem
            .operador = cbxOperador.SelectedItem
            If rdbNo.Visible Then
                If rdbNo.Checked Then
                    .valor = 0
                ElseIf rdbSi.Checked Then
                    .valor = 1
                End If
            Else
                .valor = tbxValor.Text
            End If
            .EstadoFila = "N"
            'Cls.lstRegla_condicion.Add(Cls.regla_condicion)
            Cls.Regla.lstReglaCondicion.Add(Cls.regla_condicion)
            bgsCondiciones.DataSource = (From c In Cls.Regla.lstReglaCondicion Where c.EstadoFila <> "D").ToList
            bgsCondiciones.ResetBindings(False)
        End With
    End Sub
    Private Sub dgvRegla_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRegla.SelectionChanged
        If dgvRegla.RowCount > 0 Then
            Cls.Regla = dgvRegla.CurrentRow.DataBoundItem
        Else
            Cls.Regla = Nothing
        End If
        CargarRegla()
    End Sub
    Private Sub CargarRegla()
        With Cls.Regla
            cbxReglaAplica.SelectedValue = .regla_aplica_id
            tbxNombre.Text = .texto
            If .orden > 0 Then nudOrden.Value = .orden Else nudOrden.Value = 1
            If .color <> "" Then
                'lklColor.Text = .color
                'Panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#" & .color)
                pnlColor.BackColor = ClsEstilo.getColor(.color)
                lblColor.Text = ""
            Else
                pnlColor.BackColor = Color.White
                lblColor.Text = "Sin Color"
            End If
            'Cls.lstRegla_condicion = .lstReglaCondicion
            bgsCondiciones.DataSource = (From c In Cls.Regla.lstReglaCondicion Where c.EstadoFila <> "D").ToList
            bgsCondiciones.ResetBindings(False)
        End With
    End Sub
    Private Sub dgvRegla_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvRegla.DataBindingComplete
        For Each r As DataGridViewRow In dgvRegla.Rows
            With CType(r.DataBoundItem, regla)
                If .Regla_aplica.baja Then
                    r.DefaultCellStyle.ForeColor = Color.Gray
                    r.DefaultCellStyle.SelectionForeColor = Color.Gray
                Else
                    r.DefaultCellStyle.ForeColor = colFore
                    r.DefaultCellStyle.SelectionForeColor = colSelFore
                End If
                If .color.Trim.Length > 0 Then
                    r.Cells(colRegColor.Index).Style.BackColor = ClsEstilo.getColor(.color)
                    r.Cells(colRegColor.Index).Style.SelectionBackColor = ClsEstilo.getColor(.color)
                    r.Cells(colRegColor.Index).Value = ""
                Else
                    r.Cells(colRegColor.Index).Style.BackColor = r.Cells(colRegNombre.Index).Style.BackColor
                    r.Cells(colRegColor.Index).Style.SelectionBackColor = r.Cells(colRegNombre.Index).Style.SelectionBackColor
                    r.Cells(colRegColor.Index).Value = "Sin color"
                End If
            End With
        Next
    End Sub
    Private Sub cbxCampo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCampo.SelectedIndexChanged
        Cls.regla_campo = cbxCampo.SelectedItem
        lblDescripcionCampo.Text = Cls.regla_campo.descripcion
        If Cls.regla_campo.tipo = "Logico" Then
            tbxValor.Visible = False
            rdbNo.Visible = True
            rdbSi.Visible = True
        Else
            tbxValor.Visible = True
            rdbNo.Visible = False
            rdbSi.Visible = False
        End If
    End Sub
    Private Sub cbxReglaAplica_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxReglaAplica.SelectedIndexChanged
        Cls.regla_aplica = cbxReglaAplica.SelectedItem
        With cbxCampo
            .ValueMember = "id"
            .DisplayMember = "nombre"
            .DataSource = (From c In Cls.lstRegla_campo Where c.regla_aplica_id = Cls.regla_aplica.id).ToList
        End With
        Dim lstR = Cls.lstRegla.FindAll(Function(x) x.Regla_aplica.id = CType(cbxReglaAplica.SelectedItem, regla_aplica).id).ToList
        If lstR IsNot Nothing AndAlso lstR.Count > 0 Then
            nudOrden.Value = lstR.Max(Function(x) x.orden) + 1
        Else
            nudOrden.Value = 1
        End If
    End Sub
    Private Sub Panel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlColor.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pnlColor.BackColor = ColorDialog1.Color
            If pnlColor.BackColor.ToString = "Color [White]" Then
                lblColor.Text = "Sin Color"
            Else
                lblColor.Text = ""
            End If
        End If
    End Sub
    Private Sub tbxValor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxValor.KeyPress
        If CType(cbxCampo.SelectedItem, regla_campo).tipo.ToUpper = "Numero" Then e.KeyChar = modFunciones.FuncUtiles.contDecimal(sender, e.KeyChar)
    End Sub
    Private Sub cmsReglas_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsReglas.Opening
        If dgvRegla.CurrentRow IsNot Nothing Then
            With Cls.Regla
                If .Regla_aplica.baja Then
                    btnDesactivarAplica.Text = "Activar Regla de: " & .Regla_aplica.nombre
                Else
                    btnDesactivarAplica.Text = "Desactivar Regla de: " & .Regla_aplica.nombre
                End If
            End With
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub btnDesactivarAplica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesactivarAplica.Click
        With Cls.Regla
            .Regla_aplica.baja = Not .Regla_aplica.baja
            Cls.regla_aplica = .Regla_aplica
            Dim exito As Boolean = False
            Cls.IniciarTrn()
            Try
                Cls.PersistirReglaAplica()
                Cls.gettrn.Commit()
                exito = True
            Catch ex As Exception
                Cls.gettrn.Rollback()
                MessageBox.Show("Ha ocurrido un error." & vbNewLine & ex.Message, "Error")
            End Try
            If exito Then
                dgvRegla_DataBindingComplete(Nothing, Nothing)
            End If
        End With
    End Sub

    Private Sub cmsCondicion_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsCondicion.Opening
        If dgvCondicion.CurrentRow Is Nothing Then e.Cancel = True
    End Sub
#End Region
#Region "ABM"
    Private Sub btoNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoNuevo.Click
        habilitar(True)
        cbxReglaAplica.Enabled = True
        'nudOrden.Value = 1
        'If Cls.lstRegla.Count > 0 Then nudOrden.Value += Cls.lstRegla.Max(Function(x) x.orden)

        Cls.Regla = Nothing
        Cls.Regla.EstadoFila = "N"

        pnlColor.BackColor = Color.White

        cbxReglaAplica.SelectedValue = 0
        tbxNombre.Text = ""

        Cls.lstRegla_condicion = Nothing
        bgsCondiciones.DataSource = (From c In Cls.Regla.lstReglaCondicion Where c.EstadoFila <> "D").ToList
        bgsCondiciones.ResetBindings(False)
    End Sub
    Private Sub btoEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoEliminar.Click
        If MessageBox.Show("¿Está seguro que desea eliminar Regla " & Cls.Regla.texto & "? ", "Eliminar Regla", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Cls.Regla.EstadoFila = "D"
            Cls.persistirRegla()
            ClsEnumerados.Instancia.lstRegla = Nothing
            ClsEnumerados.Instancia.lstReglaCondicion = Nothing
            Cls.cargar()
            bgsReglas.DataSource = (From r In Cls.lstRegla Order By r.vAplica, r.orden).ToList
            bgsReglas.ResetBindings(False)
        End If
        '  habilitar(True)
    End Sub
    Private Sub EliminarCondicionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarCondicionToolStripMenuItem.Click
        'Cls.persistirCondicion()
        'ClsEnumerados.Instancia.lstReglaCondicion = Nothing
        'Cls.Regla.lstReglaCondicion = Nothing
        If Cls.regla_condicion.EstadoFila = "N" Then
            Cls.Regla.lstReglaCondicion.Remove(Cls.regla_condicion)
        Else
            Cls.regla_condicion.EstadoFila = "D"
        End If
        bgsCondiciones.DataSource = (From c In Cls.Regla.lstReglaCondicion Where c.EstadoFila <> "D").ToList
        bgsCondiciones.ResetBindings(False)
    End Sub
    Private Sub btoModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoModificar.Click
        habilitar(True)
        cbxReglaAplica.Enabled = False
    End Sub
    Private Sub dgvCondicion_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCondicion.SelectionChanged
        If dgvCondicion.CurrentRow IsNot Nothing Then
            Cls.regla_condicion = dgvCondicion.CurrentRow.DataBoundItem
        Else
            Cls.regla_condicion = Nothing
        End If
    End Sub
    Private Sub dgvCondicion_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCondicion.DataBindingComplete
        cbxReglaAplica.Enabled = Cls.Regla.lstReglaCondicion.FindAll(Function(x) x.EstadoFila <> "D").Count = 0
    End Sub
#End Region
#Region "Guardar/Cancelar"
    Private Sub btoGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoGuardar.Click
        With Cls.Regla
            .regla_aplica_id = cbxReglaAplica.SelectedValue
            .texto = tbxNombre.Text
            .orden = nudOrden.Value
            'If .color <> "" Then
            '    'lklColor.Text = .color
            '    Panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#" & .color)
            'End If
            If pnlColor.BackColor.ToString = "Color [White]" Then
                .color = ""
            Else
                .color = pnlColor.BackColor.ToString
            End If

            ' .lstReglaCondicion = Cls.lstRegla_condicion

            Cls.persistirRegla()
        End With

        ClsEnumerados.Instancia.lstRegla = Nothing
        ClsEnumerados.Instancia.lstReglaCondicion = Nothing
        'Cls.Regla.lstReglaCondicion = Nothing

        habilitar(False)
        Cls.cargar()
        bgsReglas.DataSource = (From r In Cls.lstRegla Order By r.vAplica, r.orden).ToList
        bgsReglas.ResetBindings(False) 'dispara el selection_changed

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        dgvRegla_SelectionChanged(Nothing, Nothing)
        habilitar(False)
    End Sub
#End Region

    'Private Sub btnSubirF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If dgvRegla.RowCount > 0 Then
    '        With Cls.regla
    '            If .orden > 1 Then
    '                Cls.ordenar(-1)
    '            End If
    '        End With
    '    End If
    'End Sub
    'Private Sub btnBajarF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If dgvRegla.RowCount > 0 Then
    '        With Cls.regla
    '            If .orden > 1 Then
    '                Cls.ordenar(1)
    '                Cls.cargar()
    '                bgsReglas.ResetBindings(False)

    '            End If
    '        End With
    '    End If
    'End Sub


End Class