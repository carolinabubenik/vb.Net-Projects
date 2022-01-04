Imports modEntities
Imports Telerik.Reporting.Drawing

Public Class Form1

#Region "Inicializar"
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        'With My.Settings
        '    txtHost.Text = .host
        '    txtDb.Text = .db
        '    txtUser.Text = .user
        '    txtPass.Text = .pass
        '    If .sucId <> "" Then txtSucId.Text = .sucId
        '    If .usuId <> "" Then txtUsuId.Text = .usuId
        '    txtOtroId.Text = .id
        '    If IsDate(.fecha1) And .fecha1.Year > 1980 Then dtpDesde.Value = .fecha1
        '    If IsDate(.fecha2) And .fecha2.Year > 1980 Then dtpHasta.Value = .fecha2
        'End With
    End Sub
    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        Try
            'With My.Settings
            '    .host = txtHost.Text
            '    .db = txtDb.Text
            '    .user = txtUser.Text
            '    .pass = txtPass.Text
            '    .sucId = txtSucId.Text
            '    .usuId = txtUsuId.Text
            '    .Save()
            '    ClsVariablesSesion.DbDomain = .host
            '    ClsVariablesSesion.Db = .db
            '    ClsVariablesSesion.DbUser = .user
            '    ClsVariablesSesion.DbPass = .pass
            'End With



            'ClsVariablesSesion.Instancia.getConn.Open()
            'Cargo las variables de session

            ClsVariablesSesion.Instancia.Sucursal.FillBysucursal(txtSucId.Text, ClsVariablesSesion.Instancia.getConn)
            ClsVariablesSesion.Instancia.Usuario.FillByUsuario(txtUsuId.Text, ClsVariablesSesion.Instancia.getConn)
            ClsVariablesSesion.Instancia.Empresa.FillByempresa(ClsVariablesSesion.Instancia.Sucursal.empresa_id, ClsVariablesSesion.Instancia.getConn)

            gbxAcciones.Enabled = True
            btnConectar.Enabled = False


            'btnDesconectar.Enabled = True
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir la conexion " & ex.Message)
        End Try
        'dtpDesde.Value = ClsMain.FechaHoy.AddMonths(-1)
        'dtpHasta.Value = ClsMain.FechaHoy
    End Sub
    Private Sub Form1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        'With My.Settings
        '    .id = txtOtroId.Text
        '    .fecha1 = dtpDesde.Value
        '    .fecha2 = dtpHasta.Value
        '    .Save()
        'End With


    End Sub
    Private Sub btnDesconectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesconectar.Click
        ClsVariablesSesion.Instancia.getConn.Close()
        gbxAcciones.Enabled = False
        btnConectar.Enabled = True
        btnDesconectar.Enabled = False
    End Sub
#End Region

    Private Sub btnListado_Click(sender As Object, e As EventArgs) Handles btnListado.Click
        Dim f As New modFunciones.FrmIngresar("Seleccione el listado: ", "Listado", ClsEnumerados.Instancia.lstListado, "id", "nombre")
        If f.ShowDialog = DialogResult.OK Then
            Dim l As listado = f.Tag
            Dim Frm As New FrmListados(l.nombre) '"RETENCIONES_CONTADORA") 'Proveedores")
            Frm.Show()
        End If

    End Sub
    Private Sub frmAbmListado_Click(sender As Object, e As EventArgs) Handles frmAbmListado.Click
        Dim frm As New FrmListado()
        frm.Show()
    End Sub



End Class
