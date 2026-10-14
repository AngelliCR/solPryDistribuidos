Imports System.Data
Imports CapaDatos

Public Class clsMaquinaria
    Dim objMan As New clsMantenimiento
    Dim strCon As String

    Public Function listarMaquinaria(texto As String, estado As String, area As String) As DataTable
        strCon = "SELECT id_maquinaria, nombre_codigo, tipo, marca, modelo, area, estado, observaciones, fecha_registro FROM maquinaria WHERE 1=1"
        If Not String.IsNullOrWhiteSpace(texto) Then
            Dim t As String = Q(texto)
            strCon &= " AND (nombre_codigo LIKE '%" & t & "%' OR tipo LIKE '%" & t & "%' OR marca LIKE '%" & t & "%')"
        End If
        If Not SinFiltro(estado) Then
            strCon &= " AND estado='" & Q(estado) & "'"
        End If
        If Not SinFiltro(area) Then
            strCon &= " AND area='" & Q(area) & "'"
        End If
        strCon &= " ORDER BY nombre_codigo"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar la maquinaria!")
        End Try
    End Function

    Public Function listarMaquinariaDisponible() As DataTable
        strCon = "SELECT id_maquinaria, nombre_codigo + ' - ' + ISNULL(tipo, '') AS maquina FROM maquinaria WHERE estado<>'Dado de Baja' ORDER BY nombre_codigo"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar la maquinaria disponible!")
        End Try
    End Function

    Public Function validarCodigo(codigo As String, idExcluir As Integer) As Boolean
        strCon = "SELECT id_maquinaria FROM maquinaria WHERE UPPER(LTRIM(RTRIM(nombre_codigo)))='" & Q(codigo).ToUpper() & "' AND id_maquinaria<>" & idExcluir
        Try
            Dim dtVal As DataTable = objMan.listarComando(strCon)
            Return dtVal.Rows.Count > 0
        Catch ex As Exception
            Throw New Exception("Error al validar el código!")
        End Try
    End Function

    Public Sub registrarMaquinaria(nombre_codigo As String, tipo As String, marca As String, modelo As String, area As String, estado As String, observaciones As String)
        strCon = "INSERT INTO maquinaria (nombre_codigo, tipo, marca, modelo, area, estado, observaciones) VALUES ('" &
            Q(nombre_codigo).ToUpper() & "', '" & Q(tipo) & "', " & QN(marca) & ", " & QN(modelo) & ", '" & Q(area) & "', '" & Q(estado) & "', " & QN(observaciones) & ")"
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al registrar la maquinaria!")
        End Try
    End Sub

    Public Sub actualizarMaquinaria(id As Integer, nombre_codigo As String, tipo As String, marca As String, modelo As String, area As String, estado As String, observaciones As String)
        strCon = "UPDATE maquinaria SET nombre_codigo='" & Q(nombre_codigo).ToUpper() & "', tipo='" & Q(tipo) & "', marca=" & QN(marca) & ", modelo=" & QN(modelo) & ", area='" & Q(area) & "', estado='" & Q(estado) & "', observaciones=" & QN(observaciones) & " WHERE id_maquinaria=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al actualizar la maquinaria!")
        End Try
    End Sub

    Public Sub darDeBajaMaquinaria(id As Integer)
        strCon = "UPDATE maquinaria SET estado='Dado de Baja' WHERE id_maquinaria=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja la maquinaria!")
        End Try
    End Sub

    Public Function tieneRegistrosMaquinaria(id As Integer) As Boolean
        strCon = "SELECT (SELECT COUNT(*) FROM actividad_maquinaria WHERE id_maquinaria=" & id & ") + (SELECT COUNT(*) FROM solicitudes WHERE id_maquinaria=" & id & ")"
        Try
            Dim dtVal As DataTable = objMan.listarComando(strCon)
            Return Convert.ToInt32(dtVal.Rows(0).Item(0)) > 0
        Catch ex As Exception
            Throw New Exception("Error al verificar los registros de la maquinaria!")
        End Try
    End Function

    Public Sub eliminarMaquinaria(id As Integer)
        strCon = "DELETE FROM maquinaria WHERE id_maquinaria=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al eliminar la maquinaria!")
        End Try
    End Sub

    Private Function Q(valor As String) As String
        Return If(valor, "").Trim().Replace("'", "''")
    End Function

    Private Function QN(valor As String) As String
        If String.IsNullOrWhiteSpace(valor) Then
            Return "NULL"
        End If
        Return "'" & Q(valor) & "'"
    End Function

    Private Function SinFiltro(valor As String) As Boolean
        Return String.IsNullOrWhiteSpace(valor) OrElse valor.Trim() = "Todos"
    End Function
End Class
