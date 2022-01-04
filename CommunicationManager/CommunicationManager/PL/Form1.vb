Imports modEntities

Public Class Form1
#Region "Inicializar"
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        With My.Settings
            txtHost.Text = .host
            txtDb.Text = .db
            txtUser.Text = .user
            txtPass.Text = .pass
        End With
    End Sub
    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        Try
            With My.Settings
                .host = txtHost.Text
                .db = txtDb.Text
                .user = txtUser.Text
                .pass = txtPass.Text
                .Save()
                ClsVariablesSesion.DbDomain = .host
                ClsVariablesSesion.Db = .db
                ClsVariablesSesion.DbUser = .user
                ClsVariablesSesion.DbPass = .pass
            End With
            'ClsVariablesSesion.Instancia.getConn.Open()
            'Cargo las variables de session
            ClsVariablesSesion.Instancia.Sucursal.FillBysucursal(1, ClsVariablesSesion.Instancia.getConn)
            ClsVariablesSesion.Instancia.Usuario.FillByUsuario(1, ClsVariablesSesion.Instancia.getConn)
            ClsVariablesSesion.Instancia.Empresa.FillByempresa(ClsVariablesSesion.Instancia.Sucursal.empresa_id, ClsVariablesSesion.Instancia.getConn)
            With cbxSucursal
                .DisplayMember = "nombre"
                .ValueMember = "id"
                .DataSource = ClsEnumerados.Instancia.lst_Sucursal
            End With
            gbxAcciones.Enabled = True
            btnConectar.Enabled = False
            btnDesconectar.Enabled = True
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir la conexion " & ex.Message)
        End Try
    End Sub
    Private Sub btnDesconectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesconectar.Click
        ClsVariablesSesion.Instancia.getConn.Close()
        gbxAcciones.Enabled = False
        btnConectar.Enabled = True
        btnDesconectar.Enabled = False
    End Sub
#End Region

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim com As New comunicacion
        com.FillBycomunicacion(167186, ClsVariablesSesion.Instancia.getConn)
        Dim lin = com.lst_ComunicacionLinea.First
        lin.valoracion = ""
        Dim frm As New FrmComunicacion(ClsVariablesSesion.Instancia, lin, "CLIENTE") '
        frm.Show()

        'frm.TopMost = True --> para que esté siempre arriba!!

        'Dim com As New comunicacion
        'com = comunicacion.FillList(ClsVariablesSesion.Instancia.getConn).First
        'Dim frm As New comunicacion(com, ClsVariablesSesion.Instancia)
        'frm.Show()
    End Sub

    Private Sub btnDialogos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDialogos.Click
        Dim c As New comunicacion
        c.FillBycomunicacion(1, ClsVariablesSesion.Instancia.getConn)
        Dim Frm As New FrmDialogos(c, True, True)
        Frm.SetearColoresDialogos(Color.Gold, Color.White, Color.LightSteelBlue, Color.Pink)
        Frm.Show()
    End Sub

    Private Sub cbxSucursal_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxSucursal.SelectedIndexChanged
        If cbxSucursal.Items.Count Then
            With cbxUsuario
                .DisplayMember = "nombre"
                .ValueMember = "id"
                .DataSource = (From us In CType(cbxSucursal.SelectedItem, sucursal).lst_UsuarioSucursal Select us.Usuario).ToList
            End With
        End If
    End Sub

End Class
