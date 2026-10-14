Imports System.Data
Imports CapaDatos

Public Class clsSolicitud
    Dim objMan As New clsMantenimiento
    Dim strCon As String

    Public Sub registrarSolicitud(idPersonal As Integer, descripcion As String, area As String, prioridad As String, idMaquinaria As Integer)
        strCon = "INSERT INTO solicitudes (id_personal, descripcion, area, prioridad, estado, tipo_solicitud, id_maquinaria) VALUES (" &
            idPersonal & ", '" & Q(descripcion) & "', '" & Q(area) & "', '" & Q(prioridad) & "', 'Pendiente', 'Mantenimiento', " & idMaquinaria & ")"
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al registrar la solicitud!")
        End Try
    End Sub

    Public Sub registrarTarea(idPersonal As Integer, descripcion As String, area As String, prioridad As String)
        strCon = "INSERT INTO solicitudes (id_personal, descripcion, area, prioridad, estado, tipo_solicitud, id_maquinaria) VALUES (" &
            idPersonal & ", '" & Q(descripcion) & "', '" & Q(area) & "', '" & Q(prioridad) & "', 'Pendiente', 'Trabajo', NULL)"
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al registrar la tarea!")
        End Try
    End Sub

    Public Function listarMisSolicitudes(idPersonal As Integer) As DataTable
        strCon = ConsultaBase() & " WHERE s.id_personal=" & idPersonal & " ORDER BY s.fecha_registro DESC"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar las solicitudes!")
        End Try
    End Function

    Public Function listarSolicitudes(estado As String, area As String, prioridad As String, Optional tipo As String = "") As DataTable
        strCon = ConsultaBase() & " WHERE 1=1"
        If Not SinFiltro(estado) Then
            strCon &= " AND s.estado='" & Q(estado) & "'"
        End If
        If Not SinFiltro(area) Then
            strCon &= " AND s.area='" & Q(area) & "'"
        End If
        If Not SinFiltro(prioridad) Then
            strCon &= " AND s.prioridad='" & Q(prioridad) & "'"
        End If
        If Not SinFiltro(tipo) Then
            strCon &= " AND s.tipo_solicitud='" & Q(tipo) & "'"
        End If
        strCon &= " ORDER BY s.fecha_registro DESC"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar las solicitudes!")
        End Try
    End Function

    Public Function obtenerEstado(idSolicitud As Integer) As String
        strCon = "SELECT estado FROM solicitudes WHERE id_solicitud=" & idSolicitud
        Try
            Dim dtVal As DataTable = objMan.listarComando(strCon)
            If dtVal.Rows.Count = 0 Then
                Return ""
            End If
            Return dtVal.Rows(0).Item(0).ToString().Trim()
        Catch ex As Exception
            Throw New Exception("Error al obtener el estado de la solicitud!")
        End Try
    End Function

    Public Sub actualizarSolicitudOperario(idSolicitud As Integer, descripcion As String, area As String, prioridad As String, idMaquinaria As Integer)
        strCon = "UPDATE solicitudes SET descripcion='" & Q(descripcion) & "', area='" & Q(area) & "', prioridad='" & Q(prioridad) & "', id_maquinaria=" & idMaquinaria & " WHERE id_solicitud=" & idSolicitud
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al actualizar la solicitud!")
        End Try
    End Sub

    Public Sub eliminarSolicitud(idSolicitud As Integer)
        strCon = "DELETE FROM solicitudes WHERE id_solicitud=" & idSolicitud
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al eliminar la solicitud!")
        End Try
    End Sub

    Public Sub cambiarEstadoSolicitud(idSolicitud As Integer, estado As String, comentario As String)
        strCon = "UPDATE solicitudes SET estado='" & Q(estado) & "', comentario=" & QN(comentario) & " WHERE id_solicitud=" & idSolicitud
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al cambiar el estado de la solicitud!")
        End Try
    End Sub

    Private Function ConsultaBase() As String
        Return "SELECT s.id_solicitud, s.id_personal, s.id_maquinaria, s.fecha_registro, s.descripcion, s.area, s.prioridad, s.estado, s.comentario, s.tipo_solicitud, " &
            "LTRIM(RTRIM(ISNULL(p.nombres, ''))) + ' ' + LTRIM(RTRIM(ISNULL(p.apellidos, ''))) AS trabajador, m.nombre_codigo AS maquina " &
            "FROM solicitudes s INNER JOIN personal p ON p.id_personal = s.id_personal LEFT JOIN maquinaria m ON m.id_maquinaria = s.id_maquinaria"
    End Function

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
