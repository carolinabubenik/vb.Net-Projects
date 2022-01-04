Imports modEntities

Public Class ClsEntidad
    Inherits entidad


#Region "Objetos"
    Private _Entidad As entidad
    'Private _Encuestalinea As encuesta_linea

    Public Property Entidad As entidad
        Get
            If _Entidad Is Nothing Then
                _Entidad = New entidad
            End If
            Return _Entidad
        End Get
        Set(ByVal value As entidad)
            _Entidad = value
        End Set
    End Property


#End Region
#Region "Listas"
    Private _lstEntidad As List(Of entidad)
    'Private _lstEncuestaLinea As List(Of encuesta_linea)

    Public Property lstEntidad As List(Of entidad)
        Get
            If _lstEntidad Is Nothing Then
                _lstEntidad = New List(Of entidad)
                _lstEntidad = FillListByNombreApellido(nombre, apellido, ClsVariablesSesion.Instancia.getConn)
            End If
            Return _lstEntidad
        End Get
        Set(ByVal value As List(Of entidad))
            _lstEntidad = value
        End Set
    End Property

#End Region
    Public Sub New()

    End Sub
    Public Sub New(ByVal ClsVarSes As ClsVariablesSesion)
        ClsVariablesSesion.Instancia = ClsVarSes
    End Sub
    Public Function FindEntidad(ByVal nombre1 As String, ByVal ListEnti As List(Of entidad))
        Return (From h In ListEnti Select h.id, h.nombre, h.apellido Where nombre = nombre1 Order By id Ascending).ToList
    End Function

    'Public Sub BuscarEncuestasPreguntas(ByVal id, ByVal id1, ByVal conexion)
    '    lstEncuestaPregunta = EncuestaPregunta.FillByencuesta_pregunta(.encuesta_id, EncuestaPregunta.pregunta_id, ClsVariablesSesion.Instancia.getConn)
    'End Sub
    'Public Sub CargarComunicacionesCliente()
    '    lstEncuesta = Encuesta.FillListByActivas(getConn)
    'End Sub
    'Public Sub buscarEncuestaLinea()
    '    lstEncuestaLinea = Encuesta_Linea.FillListByEncuestaLinea(getConn)
    'End Sub
    'Public Sub Persistir_Encuesta_Linea()
    '    With Encuesta_Linea
    '        If .EstadoFila = "N" Then
    '            .Insert(getConn, gettrn)
    '            lstEncuestaLinea.Add(Encuesta_Linea)
    '        ElseIf .EstadoFila = "U" Then
    '            .Update(getConn, gettrn)
    '        ElseIf .EstadoFila = "D" Then
    '            .Delete(getConn, gettrn)
    '            lstEncuestaLinea.Remove(Encuesta_Linea)
    '        End If

    '    End With
    '    'lstEncuestaLinea = Nothing
    'End Sub
    Public Sub PersistirEntidad()
        With Entidad
            If .EstadoFila = "N" Then
                '.id = Encuesta.id
                '.nombre = Encuesta.nombre
                '.inicio = Encuesta.inicio
                '.fin = Encuesta.fin
                .Insert(ClsVariablesSesion.Instancia.getConn, ClsVariablesSesion.Instancia.getTrn)
                _lstEntidad.Add(Entidad)
            ElseIf .EstadoFila = "U" Then
                .Update(ClsVariablesSesion.Instancia.getConn, ClsVariablesSesion.Instancia.getTrn)
            ElseIf .EstadoFila = "D" Then
                .Delete(ClsVariablesSesion.Instancia.getConn, ClsVariablesSesion.Instancia.getTrn)
                lstEntidad.Remove(Entidad)
            End If
        End With

        lstEntidad = Nothing
    End Sub
    'Public Function FindEncuesta(ByVal nombre As String, ByVal fecha As Date, ByVal chec As Boolean) As List(Of encuesta)
    '    ' Dim text2 As DateTimePicker = New DateTimePicker
    '    '  text2.Value = Date.Today
    '    ' fecha.Value = text2.Value
    '    If chec Then
    '        If nombre.Length > 0 Then
    '            Return (From h In lstEncuesta Where h.nombre.Contains(nombre) And h.fin <= fecha).ToList
    '        Else
    '            Return (From h In lstEncuesta Where h.fin <= fecha).ToList
    '        End If
    '    Else
    '        If nombre.Length > 0 Then
    '            Return (From h In lstEncuesta Where h.nombre.Contains(nombre) And h.fin > fecha).ToList
    '        Else
    '            Return (From h In lstEncuesta Where h.fin > fecha).ToList
    '        End If
    '    End If

    '    'Return (From h In lstEncuesta Where h.nombre.Contains(nombre)).ToList
    'End Function

End Class
