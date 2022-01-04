Imports modEntities

Public Class FrmSetearColores
    Dim Cls As New ClsEstilo
    Dim lstControles As New Collection

#Region "Inicializar"
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub FrmSetearColores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvControles.AutoGenerateColumns = False
        dgvPropiedades.AutoGenerateColumns = False

        CargarControles()
    End Sub
    Private Sub CargarControles()
        lstControles.Add(New Label)
        lstControles.Add(New TextBox)
        lstControles.Add(New Panel)
        lstControles.Add(New SplitContainer)
        lstControles.Add(New GroupBox)
        lstControles.Add(New DataGridView)
        lstControles.Add(New Button)
        lstControles.Add(New DataGridViewCellStyle)
        lstControles.Add(New Form)
        lstControles.Add(New ListBox)
        lstControles.Add(New CheckBox)
        lstControles.Add(New ComboBox)
        lstControles.Add(New CheckedListBox)
        lstControles.Add(New DateTimePicker)
        lstControles.Add(New ContextMenuStrip)
        lstControles.Add(New LinkLabel)
        lstControles.Add(New MaskedTextBox)
        lstControles.Add(New NumericUpDown)
        lstControles.Add(New PictureBox)
        lstControles.Add(New MenuStrip)
        lstControles.Add(New RadioButton)
        lstControles.Add(New TabControl)
        lstControles.Add(New TableLayoutPanel)
        lstControles.Add(New ToolStrip)
        lstControles.Add(New ToolStripContainer)
        lstControles.Add(New TreeView)
        lstControles.Add(New TabPage)

        Cls.lstEstiloControl = Nothing
        For Each c In (From ct In lstControles Order By ct.GetType.ToString).ToList
            Dim ec = ClsEnumerados.Instancia.lst_estilo_control.Find(Function(x) x.nombre.ToLower = c.GetType.ToString.ToLower)
            If ec Is Nothing Then
                ec = New estilo_control
                ec.nombre = c.GetType.ToString
            End If
            Cls.lstEstiloControl.Add(ec)
        Next

        dgvControles.DataSource = Cls.lstEstiloControl
    End Sub
#End Region

#Region "Navegacion"
    Private Sub dgvControles_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvControles.SelectionChanged
        If dgvControles.CurrentRow IsNot Nothing Then

            'Caro 2021-11-04: Agrego Try-Catch
            Try
                Cls.EstiloControl = dgvControles.CurrentRow.DataBoundItem
                Dim ct
                For Each c In lstControles
                    If c.GetType.ToString.ToLower = Cls.EstiloControl.nombre.ToLower Then
                        ct = c
                        Exit For
                    End If
                Next
                Cls.lstEstiloPropiedad = Nothing
                If ct IsNot Nothing Then
                    For Each prop In (From p In ct.GetType.GetProperties Where p.PropertyType Is GetType(Color)).ToList
                        Dim ep = New estilo_propiedad
                        If Cls.EstiloControl.id > 0 Then
                            ep = ClsEnumerados.Instancia.lst_estilo_propiedad.Find(Function(x) x.estilo_control_id = Cls.EstiloControl.id And x.nombre.ToLower = prop.Name.ToLower)
                        End If
                        If ep Is Nothing OrElse ep.id = 0 Then
                            ep = New estilo_propiedad
                            ep.nombre = prop.Name
                            ep.Estilo_control = Cls.EstiloControl
                            ep.estilo_control_id = Cls.EstiloControl.id
                        End If
                        Cls.lstEstiloPropiedad.Add(ep)
                    Next

                    'Caro 2021-11-04: Agrego cualquier otra propiedad que esté configurada en la BD:
                    For Each ep In Cls.EstiloControl.lst_EstiloPropiedad
                        If Not Cls.lstEstiloPropiedad.Exists(Function(x) x.nombre.Trim.ToUpper Like ep.nombre.Trim.ToUpper) Then
                            Cls.lstEstiloPropiedad.Add(ep)
                        End If
                    Next

                    'Lo iba a hacer así, pero prefiero como lo hice arriba ya que permite más flexibilidad.
                    'Si ya existen en la BD, se cargan y están disponibles.
                    'If ct.GetType Is GetType(Label) Then
                    '    Cls.lstEstiloPropiedad.Add(getPropiedadPersonalizada("colorResaltado", Cls.EstiloControl))
                    '    Cls.lstEstiloPropiedad.Add(getPropiedadPersonalizada("colorResaltado2", Cls.EstiloControl))
                    '    Cls.lstEstiloPropiedad.Add(getPropiedadPersonalizada("SEMAFORO_VERDE", Cls.EstiloControl))
                    '    Cls.lstEstiloPropiedad.Add(getPropiedadPersonalizada("SEMAFORO_AMARILLO", Cls.EstiloControl))
                    '    Cls.lstEstiloPropiedad.Add(getPropiedadPersonalizada("SEMAFORO_ROJO", Cls.EstiloControl))
                    '    Cls.lstEstiloPropiedad.Add(getPropiedadPersonalizada("SEMAFORO_AZUL", Cls.EstiloControl))
                    'End If

                End If

                dgvPropiedades.DataSource = Cls.lstEstiloPropiedad
                lblControl.Text = Cls.EstiloControl.nombre
                DibujarControl()

            Catch ex As Exception
                'No hacemos nada.. pero es para evitar error
            End Try

        Else
            Cls.EstiloControl = Nothing
            dgvPropiedades.DataSource = Nothing
            lblControl.Text = "(Seleccione un control)"
            pnlControl.Controls.Clear()
        End If
    End Sub

    Private Function getPropiedadPersonalizada(ByVal nombreProp As String, ByVal ec As estilo_control) As estilo_propiedad
        Dim ep = Cls.EstiloControl.lst_EstiloPropiedad.Find(Function(x) x.nombre.Trim.ToUpper Like nombreProp.Trim.ToUpper)
        If ep Is Nothing Then
            ep = New estilo_propiedad
            ep.nombre = nombreProp
            ep.Estilo_control = ec
        End If
        Return ep
    End Function
    Private Sub DibujarControl()
        pnlControl.Controls.Clear()
        Try
            Dim c = System.Reflection.Assembly.GetAssembly(GetType(Label)).CreateInstance(Cls.EstiloControl.nombre)
            Try
                c.text = "Texto"
            Catch ex As Exception
            End Try
            Try
                pnlControl.Controls.Add(c)
                Cls.EstiloAControl(c)
            Catch ex As Exception
            End Try
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgvPropiedades_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvPropiedades.SelectionChanged
        If dgvPropiedades.CurrentRow IsNot Nothing Then
            Cls.EstiloPropiedad = dgvPropiedades.CurrentRow.DataBoundItem
            lblPropiedad.Text = Cls.EstiloPropiedad.nombre & ":"
            If Cls.EstiloPropiedad.valor <> "" Then
                pnlColor.BackColor = Cls.getColor(Cls.EstiloPropiedad.valor)
                pnlColor.BackgroundImage = Nothing
            Else
                'Caro 2021-11-04: Agrego
                pnlColor.BackColor = CType(pnlColor.Parent, Control).BackColor
                pnlColor.BackgroundImage = My.Resources.cross
            End If
            lklQuitar.Visible = (Cls.EstiloPropiedad.id > 0)
        Else
            Cls.EstiloPropiedad = Nothing
            lblPropiedad.Text = "(Seleccione una propiedad)"
            lklQuitar.Visible = False
        End If
    End Sub
    Private Sub dgvPropiedades_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvPropiedades.DataBindingComplete
        For Each r As DataGridViewRow In dgvPropiedades.Rows
            If CType(r.DataBoundItem, estilo_propiedad).valor <> "" Then
                r.Cells(colColor.Index).Style.ForeColor = Cls.getColor(CType(r.DataBoundItem, estilo_propiedad).valor)
            Else
                r.Cells(colColor.Index).Style.ForeColor = Color.Black
            End If
        Next
    End Sub
    Private Sub pnlColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlColor.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pnlColor.BackColor = ColorDialog1.Color
        End If
    End Sub
#End Region

#Region "Guardar"
    Private Sub lklGuardar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklGuardar.LinkClicked
        If dgvControles.CurrentRow IsNot Nothing And dgvPropiedades.CurrentRow IsNot Nothing Then
            Dim v = pnlColor.BackColor.ToString
            v = v.Replace("Color [", "").Replace("]", "")
            Cls.EstiloPropiedad.valor = v
            Cls.GuardarControlPropiedad()
            dgvControles_SelectionChanged(Nothing, Nothing)
        End If
    End Sub
    Private Sub lklQuitar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklQuitar.LinkClicked
        If dgvControles.CurrentRow IsNot Nothing And dgvPropiedades.CurrentRow IsNot Nothing Then
            Cls.EliminarPropiedad()
            dgvControles_SelectionChanged(Nothing, Nothing)
        End If
    End Sub
#End Region

End Class