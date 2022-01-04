Imports modEntities

Friend Class FrmPrueba
    Private _Objeto As Objeto
    Private _lstObjeto As List(Of Objeto)

    Public Property Objeto As Objeto
        Get
            If _Objeto Is Nothing Then
                _Objeto = New Objeto
            End If
            Return _Objeto
        End Get
        Set(ByVal value As Objeto)
            _Objeto = value
        End Set
    End Property
    Public Property lstObjeto As List(Of Objeto)
        Get
            If _lstObjeto Is Nothing Then
                _lstObjeto = New List(Of Objeto)
            End If
            Return _lstObjeto
        End Get
        Set(ByVal value As List(Of Objeto))
            _lstObjeto = value
        End Set
    End Property


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        getEstilo()
        EstiloAControl(Me, GetType(Form).ToString)
    End Sub
    Private Sub EstiloAControl(ByVal c, Optional ByVal tipo = Nothing)
        If c.GetType Is GetType(TabControl) Then Dim a = 4

        Objeto = lstObjeto.Find(Function(x) x.tipo = c.GetType.ToString Or (tipo IsNot Nothing AndAlso x.tipo = tipo))
        If Objeto.tipo.Length > 0 Then
            For Each p In Objeto.lstPropiedad
                Dim prop As Reflection.PropertyInfo = c.GetType().GetProperty(p.nombre)
                If prop IsNot Nothing Then asignarValor(c, prop, p.valor)
            Next
        End If
        For Each p In (From prop In c.GetType.GetProperties Where prop.PropertyType.Name.ToLower.Contains("collection")).ToList
            For Each hijo In p.GetValue(c, Nothing)
                EstiloAControl(hijo)
            Next
        Next
    End Sub
    Private Sub asignarValor(ByVal c, ByVal prop, ByVal valor)
        With CType(prop, System.Reflection.PropertyInfo)
            Select Case .PropertyType
                Case GetType(Color)
                    prop.SetValue(c, getColor(valor), Nothing)
                Case GetType(Font)
                    prop.SetValue(c, getFont(valor), Nothing)
                Case GetType(Point), GetType(Size)
                    prop.SetValue(c, getPoint(valor), Nothing)
                Case Else
                    prop.SetValue(c, valor, Nothing)
            End Select
        End With
    End Sub
    Private Function getColor(ByVal valor As String) As Color
        valor = valor.Replace("Color [", "")
        valor = valor.Replace("]", "")
        If valor.Contains(",") Then
            Dim a As New List(Of Integer)
            For Each s In valor.Split(",")
                a.Add(s.Substring(s.IndexOf("=") + 1))
            Next
            Return ColorTranslator.FromOle(RGB(a(1), a(2), a(3)))
        Else
            Return Color.FromName(valor)
        End If
    End Function
    Private Function getFont(ByVal valor As String) As Font
        valor = valor.Replace("[Font:", "")
        valor = valor.Replace("]", "")
        Dim a As New List(Of String)
        For Each s In valor.Split(",")
            a.Add(s.Substring(s.IndexOf("=") + 1))
        Next
        Return New Font(a(0), a(1))
    End Function
    Private Function getPoint(ByVal valor As String) As Point
        Dim a As New List(Of Integer)
        For Each s In valor.Split(",")
            a.Add(s.Substring(s.IndexOf("=") + 1))
        Next
        Return New Point(a(0), a(1))
    End Function

    Private Sub getEstilo() 'traeria las propiedades y valores de la BD. Ahora lo defino a mano
        'form
        Objeto = Nothing
        With Objeto
            .tipo = GetType(Form).ToString
            Dim p As New Propiedad
            p.nombre = "BackColor"
            Dim c As Color = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
            p.valor = (c.ToString).ToString
            .lstPropiedad.Add(p)
            p = New Propiedad
            p.nombre = "Font"
            Dim f As Font = New System.Drawing.Font("Verdana", 9)
            p.valor = (f.ToString).ToString
            .lstPropiedad.Add(p)
            p = New Propiedad
            p.nombre = "ForeColor"
            c = Color.White
            p.valor = c.ToString
            .lstPropiedad.Add(p)
            lstObjeto.Add(Objeto)
        End With
        'button
        Objeto = Nothing
        With Objeto
            .tipo = GetType(Button).ToString
            Dim p As New Propiedad
            p.nombre = "ForeColor"
            Dim c As Color = Color.FromKnownColor(KnownColor.ControlText)
            p.valor = (c).ToString
            .lstPropiedad.Add(p)
            lstObjeto.Add(Objeto)
        End With
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cls As New ClsEstilo
        cls.AplicarEstilo(Me)
    End Sub

    Private Sub pbxGuardarControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim str = ""
        Dim pnl As New Panel
        Dim lbl As New Label
        Dim txt As New TextBox
        Dim btn As New Button
        Dim gbx As New GroupBox

        str &= pnl.GetType.ToString & vbNewLine
        str &= lbl.GetType.ToString & vbNewLine
        str &= txt.GetType.ToString & vbNewLine
        str &= btn.GetType.ToString & vbNewLine
        str &= gbx.GetType.ToString & vbNewLine

        For Each p In pnl.GetType.GetProperties
            str &= p.Name & vbNewLine
        Next
        txtControles.Text = str
    End Sub

    Private Sub FrmPrueba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgv.DataSource = ClsEnumerados.Instancia.lst_Usuario
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        MessageBox.Show("boton aceptar")
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        MessageBox.Show("boton buscar")
    End Sub
End Class

Public Class Objeto
    Private _tipo As String
    Private _lstPropiedad As List(Of Propiedad)

    Public Sub New()
        _tipo = ""
    End Sub

    Public Property tipo As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property
    Public Property lstPropiedad As List(Of Propiedad)
        Get
            If _lstPropiedad Is Nothing Then
                _lstPropiedad = New List(Of Propiedad)
            End If
            Return _lstPropiedad
        End Get
        Set(ByVal value As List(Of Propiedad))
            _lstPropiedad = value
        End Set
    End Property
End Class

Public Class Propiedad
    Private _nombre As String
    Private _valor As String

    Public Sub New()
        _nombre = ""
        _valor = ""
    End Sub

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Public Property valor As String
        Get
            Return _valor
        End Get
        Set(ByVal value As String)
            _valor = value
        End Set
    End Property

End Class