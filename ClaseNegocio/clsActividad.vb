Imports System.Data
Imports System.Globalization
Imports CapaDatos

Public Class clsActividad
    Dim objMan As New clsMantenimiento
    Dim strCon As String

    Public Function listarMaquinasParaCheckin() As DataTable
        strCon = "SELECT m.id_maquinaria, m.nombre_codigo + ' - ' + ISNULL(m.tipo, '') AS maquina FROM maquinaria m WHERE (m.estado='Operativo' OR m.estado='Sin Tarea') AND NOT EXISTS (SELECT 1 FROM actividad_maquinaria a WHERE a.id_maquinaria=m.id_maquinaria AND a.estado='ACTIVO') ORDER BY m.nombre_codigo"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar las máquinas!")
        End Try
    End Function

    Public Function tieneJornadaActiva(idPersonal As Integer) As Boolean
        strCon = "SELECT id_actividad FROM actividad_maquinaria WHERE id_personal=" & idPersonal & " AND estado='ACTIVO'"
        Try
            Dim dtVal As DataTable = objMan.listarComando(strCon)
            Return dtVal.Rows.Count > 0
        Catch ex As Exception
            Throw New Exception("Error al verificar la jornada!")
        End Try
    End Function

    Public Function maquinaOcupada(idMaquinaria As Integer) As Boolean
        strCon = "SELECT id_actividad FROM actividad_maquinaria WHERE id_maquinaria=" & idMaquinaria & " AND estado='ACTIVO'"
        Try
            Dim dtVal As DataTable = objMan.listarComando(strCon)
            Return dtVal.Rows.Count > 0
        Catch ex As Exception
            Throw New Exception("Error al verificar la máquina!")
        End Try
    End Function

    Public Sub iniciarJornada(idMaquinaria As Integer, idPersonal As Integer, zona As String, horasEstimadas As Decimal)
        strCon = "INSERT INTO actividad_maquinaria (id_maquinaria, id_personal, zona, combustible_inicial, horas_estimadas, estado) VALUES (" &
            idMaquinaria & ", " & idPersonal & ", '" & Q(zona) & "', 100, " & Dec(horasEstimadas) & ", 'ACTIVO')"
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al iniciar la jornada!")
        End Try
    End Sub

    Public Function listarActividades(idPersonal As Integer, estado As String, desde As Date, hasta As Date) As DataTable
        strCon = "SELECT LTRIM(RTRIM(ISNULL(p.nombres, ''))) + ' ' + LTRIM(RTRIM(ISNULL(p.apellidos, ''))) AS operario, a.fecha_inicio, m.nombre_codigo + ' - ' + ISNULL(m.tipo, '') AS maquina, a.zona, a.horas_estimadas, a.horas_reales, a.combustible_final, a.estado, a.fecha_fin, a.id_actividad, a.id_maquinaria, a.id_personal, a.combustible_inicial, a.motivo_retraso, a.observacion_falla " &
            "FROM actividad_maquinaria a INNER JOIN maquinaria m ON m.id_maquinaria=a.id_maquinaria INNER JOIN personal p ON p.id_personal=a.id_personal WHERE 1=1"
        If idPersonal <> 0 Then
            strCon &= " AND a.id_personal=" & idPersonal
        End If
        If Not SinFiltro(estado) Then
            strCon &= " AND a.estado='" & Q(estado) & "'"
        End If
        strCon &= " AND a.fecha_inicio>='" & desde.Date.ToString("yyyyMMdd") & "' AND a.fecha_inicio<'" & hasta.Date.AddDays(1).ToString("yyyyMMdd") & "'"
        strCon &= " ORDER BY a.fecha_inicio DESC"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar las actividades!")
        End Try
    End Function

    Public Function obtenerEstado(idActividad As Integer) As String
        strCon = "SELECT estado FROM actividad_maquinaria WHERE id_actividad=" & idActividad
        Try
            Dim dtVal As DataTable = objMan.listarComando(strCon)
            If dtVal.Rows.Count = 0 Then
                Return ""
            End If
            Return dtVal.Rows(0).Item(0).ToString().Trim()
        Catch ex As Exception
            Throw New Exception("Error al obtener el estado de la actividad!")
        End Try
    End Function

    Public Sub finalizarJornada(idActividad As Integer, combustibleFinal As Decimal, horasReales As Decimal, motivoRetraso As String)
        strCon = "UPDATE actividad_maquinaria SET estado='FINALIZADO', combustible_final=" & Dec(combustibleFinal) & ", horas_reales=" & Dec(horasReales) & ", motivo_retraso=" & QN(motivoRetraso) & ", fecha_fin=GETDATE() WHERE id_actividad=" & idActividad & " AND estado='ACTIVO'"
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al finalizar la jornada!")
        End Try
    End Sub

    Public Sub reportarAveria(idActividad As Integer, observacionFalla As String)
        strCon = "UPDATE actividad_maquinaria SET estado='AVERIADO', observacion_falla=" & QN(observacionFalla) & ", fecha_fin=GETDATE() WHERE id_actividad=" & idActividad & " AND estado='ACTIVO'; " &
            "UPDATE maquinaria SET estado='En Mantenimiento' WHERE id_maquinaria=(SELECT id_maquinaria FROM actividad_maquinaria WHERE id_actividad=" & idActividad & ")"
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al reportar la avería!")
        End Try
    End Sub

    Private Function Dec(valor As Decimal) As String
        Return valor.ToString(CultureInfo.InvariantCulture)
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
