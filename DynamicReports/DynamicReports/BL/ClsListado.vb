Imports modEntities

Public Class ClsListado
    Inherits modEntities.ClsMain

#Region "Objetos y Listas"
    Private _Listado As listado
    Public Property Listado As listado
        Get
            If _Listado Is Nothing Then
                _Listado = New listado
            End If
            Return _Listado
        End Get
        Set(value As listado)
            _Listado = value
        End Set
    End Property
    Private _ListadoColumna As listado_columna
    Public Property ListadoColumna() As listado_columna
        Get
            If _ListadoColumna Is Nothing Then
                _ListadoColumna = New listado_columna
            End If
            Return _ListadoColumna
        End Get
        Set(ByVal value As listado_columna)
            _ListadoColumna = value
        End Set
    End Property
    Private _ListadoParametro As listado_parametro
    Public Property ListadoParametro() As listado_parametro
        Get
            If _ListadoParametro Is Nothing Then
                _ListadoParametro = New listado_parametro
            End If
            Return _ListadoParametro
        End Get
        Set(ByVal value As listado_parametro)
            _ListadoParametro = value
        End Set
    End Property
    Private _ListadoCondicion As listado_condicion
    Public Property ListadoCondicion() As listado_condicion
        Get
            If _ListadoCondicion Is Nothing Then
                _ListadoCondicion = New listado_condicion
            End If
            Return _ListadoCondicion
        End Get
        Set(ByVal value As listado_condicion)
            _ListadoCondicion = value
        End Set
    End Property

    Private _lstListado As List(Of listado)
    Public Property lstListado As List(Of listado)
        Get
            If _lstListado Is Nothing Then
                _lstListado = New List(Of listado)
            End If
            Return _lstListado
        End Get
        Set(ByVal value As List(Of listado))
            _lstListado = value
        End Set
    End Property
#End Region
#Region "Procedimientos"
    Public Sub CargarListado(ByVal nombreListado As String)
        Dim lst = Listado.FillListByNombre(nombreListado, ClsVariablesSesion.Instancia.getConn)
        If lst.Count = 0 Then
            MessageBox.Show("No se encontró el listado: " & nombreListado & "." & vbNewLine & "Consulte con el Administrador del Sistema.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Listado = Nothing
        ElseIf lst.Count > 1 Then
            MessageBox.Show("No se pudo identificar el listado: " & nombreListado & "." & vbNewLine & "Consulte con el Administrador del Sistema.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Listado = Nothing
        Else
            Listado = lst.First
        End If
    End Sub

    Public Sub CargarLstListado()
        Me.lstListado = ClsEnumerados.Instancia.lstListado   'listado.FillList(getConn)
    End Sub
    Public Sub PersistirListado()
        With Listado
            Select Case .EstadoFila
                Case "N", "U"
                    .id = .InsertUpdate(getConn, gettrn)
                    PersistirColumnas()
                    PersistirParametros()

                Case "D"
                    For Each lc In .lstListadoColumna
                        lc.EstadoFila = "D"
                    Next
                    PersistirColumnas()
                    For Each lp In .lstListadoParametro
                        lp.EstadoFila = "D"
                    Next
                    PersistirParametros()
                    .Delete(getConn, gettrn)
            End Select
        End With
        ClsEnumerados.Instancia.lstListado = Nothing
        ClsEnumerados.Instancia.lstListadoColumna = Nothing
        ClsEnumerados.Instancia.lstListadoParametro = Nothing
        ClsEnumerados.Instancia.lstListadoCondicion = Nothing

        Me.CargarLstListado()
    End Sub
    Private Sub PersistirColumnas()
        For Each lc In Me.Listado.lstListadoColumna
            lc.listado_id = Me.Listado.id
            Select Case lc.EstadoFila
                Case "D"
                    lc.Delete(getConn, gettrn)
                Case "N", "U"
                    lc.InsertUpdate(getConn, gettrn)
            End Select
        Next
    End Sub
    Private Sub PersistirParametros()
        For Each lp In Me.Listado.lstListadoParametro
            lp.listado_id = Me.Listado.id
            Select Case lp.EstadoFila
                Case "N", "U"
                    lp.InsertUpdate(getConn, gettrn)

                Case "D"
                    For Each lc In lp.lstListadoCondicion
                        lc.EstadoFila = "D"
                    Next
                    PersistirCondiciones(lp)
                    lp.Delete(getConn, gettrn)
            End Select
            If lp.EstadoFila <> "D" Then
                PersistirCondiciones(lp)
            End If
        Next
    End Sub
    Private Sub PersistirCondiciones(ByVal lp As listado_parametro)
        For Each lc In lp.lstListadoCondicion
            lc.listado_parametro_id = lp.id
            Select Case lc.EstadoFila
                Case "N", "U"
                    lc.InsertUpdate(getConn, gettrn)
                Case "D"
                    lc.Delete(getConn, gettrn)
            End Select
        Next
    End Sub
#End Region

End Class
