Imports modEntities

Friend Class Form1

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
        With My.Settings
            txtHost.Text = .host
            txtDB.Text = .db
            txtUser.Text = .user
            txtPass.Text = .pass
            'If .sucId <> "" Then txtSucId.Text = .sucId
            'If .usuId <> "" Then txtUsuId.Text = .usuId
        End With
    End Sub
    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Try
            With My.Settings
                .host = txtHost.Text
                .db = txtDB.Text
                .user = txtUser.Text
                .pass = txtPass.Text
                '.sucId = txtSucId.Text
                '.usuId = txtUsuId.Text
                ClsVariablesSesion.DbDomain = .host
                ClsVariablesSesion.Db = .db
                ClsVariablesSesion.DbUser = .user
                ClsVariablesSesion.DbPass = .pass

                .Save()

            End With


            'ClsVariablesSesion.Instancia.getConn.Open()
            'Cargo las variables de session
            ClsVariablesSesion.Instancia.Sucursal.FillBysucursal(3, ClsVariablesSesion.Instancia.getConn) 'decia 2 / 1
            ClsVariablesSesion.Instancia.Usuario.FillByUsuario(1, ClsVariablesSesion.Instancia.getConn)
            ClsVariablesSesion.Instancia.Empresa.FillByempresa(ClsVariablesSesion.Instancia.Sucursal.empresa_id, ClsVariablesSesion.Instancia.getConn)

            GroupBox1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir la conexion " & ex.Message)
        End Try
    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        ClsVariablesSesion.Instancia.getConn.Close()
        GroupBox1.Enabled = False
    End Sub

    Private Sub btnPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPago.Click
        Dim frm As New FrmPrueba
        frm.Show()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New FrmSetearColores
        frm.Show()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show(New Font("Verdana", 9, FontStyle.Bold).ToString)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim frm As New FrmPrueba2
        frm.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim frm As New FrmReglas
        frm.Show()
    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.ButtonClick
        MessageBox.Show(sender.text)
    End Sub
    Private Sub AlgoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'MessageBox.Show(sender.text)
        ToolStripSplitButton1.PerformButtonClick()
    End Sub
    Private Sub OtroToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OtroToolStripMenuItem.Click
        ' MessageBox.Show(sender.text)
        ToolStripSplitButton1.PerformClick()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ClsEstilo.AplicarEstilo(Me)
    End Sub
End Class
