Imports modEntities

Public Class ClsRegla
    Inherits modEntities.ClsMain

    Dim _regla As regla
    Dim _regla_campo As regla_campo
    Dim _regla_condicion As regla_condicion
    Dim _regla_aplica As regla_aplica

#Region "Propiedades"


    Public Property Regla As regla
        Get
            If _regla Is Nothing Then
                _regla = New regla
            End If
            Return _regla
        End Get
        Set(ByVal value As regla)
            _regla = value
        End Set
    End Property


    Public Property regla_campo As regla_campo
        Get
            If _regla_campo Is Nothing Then
                _regla_campo = New regla_campo
            End If
            Return _regla_campo
        End Get
        Set(ByVal value As regla_campo)
            _regla_campo = value
        End Set
    End Property


    Public Property regla_condicion As regla_condicion
        Get
            If _regla_condicion Is Nothing Then
                _regla_condicion = New regla_condicion
            End If

            Return _regla_condicion
        End Get
        Set(ByVal value As regla_condicion)
            _regla_condicion = value
        End Set
    End Property

    Public Property regla_aplica As regla_aplica
        Get
            If _regla_aplica Is Nothing Then
                _regla_aplica = New regla_aplica
            End If

            Return _regla_aplica
        End Get
        Set(ByVal value As regla_aplica)
            _regla_aplica = value
        End Set
    End Property


    Dim _lstRegla As List(Of regla)
    Public Property lstRegla As List(Of regla)
        Get
            If _lstRegla Is Nothing Then
                _lstRegla = New List(Of regla)
            End If
            Return _lstRegla
        End Get
        Set(ByVal value As List(Of regla))
            _lstRegla = value
        End Set
    End Property

    Dim _lstRegla_aplica As List(Of regla_aplica)
    Public Property lstRegla_aplica As List(Of regla_aplica)
        Get
            If _lstRegla_aplica Is Nothing Then
                _lstRegla_aplica = New List(Of regla_aplica)
            End If
            Return _lstRegla_aplica
        End Get
        Set(ByVal value As List(Of regla_aplica))
            _lstRegla_aplica = value
        End Set
    End Property

    Dim _lstRegla_campo As List(Of regla_campo)
    Public Property lstRegla_campo As List(Of regla_campo)
        Get
            If _lstRegla_campo Is Nothing Then
                _lstRegla_campo = New List(Of regla_campo)
            End If
            Return _lstRegla_campo
        End Get
        Set(ByVal value As List(Of regla_campo))
            _lstRegla_campo = value
        End Set
    End Property

    Dim _lstRegla_condicion As List(Of regla_condicion)
    Public Property lstRegla_condicion As List(Of regla_condicion)
        Get
            If _lstRegla_condicion Is Nothing Then
                _lstRegla_condicion = New List(Of regla_condicion)
            End If
            Return _lstRegla_condicion
        End Get
        Set(ByVal value As List(Of regla_condicion))
            _lstRegla_condicion = value
        End Set
    End Property





#End Region

#Region "Funciones"
    Public Sub cargar()
        lstRegla = Nothing
        lstRegla_aplica = ClsEnumerados.Instancia.lstReglaAplica
        lstRegla_campo = ClsEnumerados.Instancia.lstReglaCampo
        lstRegla = ClsEnumerados.Instancia.lstRegla
    End Sub
    Dim reglaAux As regla

    Public Sub ordenar(ByVal valor As Int16)
        Regla.orden = Regla.orden + valor
        reglaAux = ((From r As regla In lstRegla Where r.orden = Regla.orden).ToList).First
        reglaAux.orden = reglaAux.orden + (valor * -1)
        Regla.Update(getConn, gettrn)
        reglaAux.Update(getConn, gettrn)

    End Sub


    Public Sub persistirRegla()
        Dim exito As Boolean = False
        IniciarTrn()
        Try
            If Regla.EstadoFila = "D" Then
                For Each rc As regla_condicion In Regla.lstReglaCondicion
                    rc.Delete(getConn, gettrn)
                Next
                Regla.Delete(getConn, gettrn)
            Else
                Regla.id = Regla.InsertUpdate(getConn, gettrn)
                Dim id = 0
                If Regla.lstReglaCondicion.Count > 0 Then id = Regla.lstReglaCondicion.Max(Function(x) x.id)

                For Each rc As regla_condicion In Regla.lstReglaCondicion '(From rcc As regla_condicion In regla.lstReglaCondicion Where rcc.EstadoFila = "N").ToList
                    If rc.EstadoFila = "D" Then
                        If rc.id > 0 Then rc.Delete(getConn, gettrn)
                    Else
                        rc.regla_id = Regla.id
                        If rc.id = 0 Then
                            id += 1
                            rc.id = id
                        End If
                        rc.InsertUpdate(getConn, gettrn)
                    End If
                Next
            End If

            gettrn.Commit()
            exito = True
        Catch ex As Exception
            gettrn.Rollback()
            MessageBox.Show("No se han podido guardar los datos." & vbNewLine & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        If exito Then
            Regla.EstadoFila = ""
        End If

    End Sub
    Public Sub persistirCondicion()
        IniciarTrn()
        Try
            If regla_condicion.id > 0 Then
                regla_condicion.Delete(getConn, gettrn)
                gettrn.Commit()
                'regla.lstReglaCondicion.RemoveAll(Function(x) x.id = regla_condicion.id And x.regla_id = regla_condicion.regla_id)
            End If

        Catch ex As Exception
            gettrn.Rollback()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub PersistirReglaAplica()
        With Me.regla_aplica
            If .EstadoFila = "D" Then
                .Delete(getConn, gettrn)
            Else
                .InsertUpdate(getConn, gettrn)
            End If
        End With
    End Sub

#End Region

End Class
