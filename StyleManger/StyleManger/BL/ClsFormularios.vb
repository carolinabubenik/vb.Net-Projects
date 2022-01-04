Public Class ClsFormularios
    Inherits modEntities.ClsMain

#Region "Métodos"
    Public Shared Function AbrirForm(ByVal Formulario As modEntities.formulario, ByVal AbrirComoDialog As Boolean, Optional ByRef Padre As Form = Nothing) As Form
        If Formulario IsNot Nothing Then
            Try
                Dim _assembly As System.Reflection.Assembly = System.Reflection.Assembly.LoadFrom(Formulario.Proyecto.ensamblado)
                Dim frmType As Type = _assembly.GetType(Formulario.Proyecto.nombre.Trim & "." & Formulario.nombre_form.Trim, False, True)
                If frmType IsNot Nothing Then
                    Dim frm As Object
                    If Formulario.lst_FormularioArgumento.Count > 0 Then
                        Dim arg As New List(Of Object)
                        For Each a In Formulario.lst_FormularioArgumento
                            Select Case a.argumento.ToLower.Trim
                                Case "True".ToLower
                                    arg.Add(True)
                                Case "False".ToLower
                                    arg.Add(False)
                                Case "Nothing".ToLower
                                    arg.Add(Nothing)
                                Case Else
                                    arg.Add(a.argumento)
                            End Select
                        Next
                        frm = _assembly.CreateInstance(frmType.ToString, True, Nothing, Nothing, arg.ToArray, Nothing, Nothing)
                    Else 'crearlo sin argumentos... 
                        frm = _assembly.CreateInstance(frmType.ToString)
                    End If
                    If Padre IsNot Nothing Then CType(frm, Form).MdiParent = Padre
                    Dim metodo = "Show"
                    If AbrirComoDialog Then metodo = "ShowDialog"
                    frmType.InvokeMember(metodo, Reflection.BindingFlags.InvokeMethod, Nothing, frm, Nothing)
                    Return frm
                End If
            Catch ex As Exception
            End Try
        End If
        Return Nothing
    End Function
#End Region
End Class
