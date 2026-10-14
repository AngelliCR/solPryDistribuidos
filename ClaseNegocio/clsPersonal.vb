Imports System.Data
Imports CapaDatos
Public Class clsPersonal
    Dim objMan As New clsMantenimiento
    Dim strCon As String
    Dim dt As New DataTable

    ' 1. Iniciar sesión usando DNI y Contraseña (verificando que esté Activo)
    Public Function iniciarSesion(dni As String, con As String) As Boolean
        strCon = "SELECT * FROM personal WHERE TRIM(dni)='" & dni.Trim().Replace("'", "''") & "' AND TRIM(password)='" & con.Trim().Replace("'", "''") & "' AND estado='Activo'"
        Try
            dt = objMan.listarComando(strCon)
            If dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception("Error al iniciar sesión!")
        End Try
    End Function

    ' Datos del usuario que inicia sesión (sin devolver la contraseña)
    Public Function obtenerUsuarioLogin(dni As String, con As String) As DataRow
        Dim dtLogin As New DataTable
        strCon = "SELECT id_personal, dni, nombres, apellidos, tipo_usuario, area FROM personal WHERE TRIM(dni)='" & dni.Trim().Replace("'", "''") & "' AND TRIM(password)='" & con.Trim().Replace("'", "''") & "' AND estado='Activo'"
        Try
            dtLogin = objMan.listarComando(strCon)
            If dtLogin.Rows.Count > 0 Then
                Return dtLogin.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw New Exception("Error al obtener el usuario!")
        End Try
    End Function

    ' 2. Validar si existe el DNI del personal
    Public Function validarDNI(dni As String) As Boolean
        Dim dtVal As New DataTable
        strCon = "SELECT * FROM personal WHERE TRIM(dni)='" & dni.Trim() & "'"
        Try
            dtVal = objMan.listarComando(strCon)
            If dtVal.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception("Error al validar el DNI!")
        End Try
    End Function

    ' 3. Generar ID automático para el personal
    Public Function generarIDPersonal() As Integer
        strCon = "SELECT ISNULL(MAX(id_personal),0)+1 FROM personal"
        Try
            dt = objMan.listarComando(strCon)
            Return Convert.ToInt32(dt.Rows(0).Item(0))
        Catch ex As Exception
            Throw New Exception("Error al generar el ID de Personal!")
        End Try
    End Function

    ' 4. Registrar nuevo Personal


    Public Sub registrarPersonal(dni As String, nombres As String, apellidos As String, telefono As String, correo As String, password As String, tipo_usuario As String, area As String, estado As String)

        strCon = "INSERT INTO dbo.personal (dni, nombres, apellidos, telefono, correo, [password], tipo_usuario, area, estado) " &
             "VALUES ('" & dni & "', '" & nombres & "', '" & apellidos & "', '" & telefono & "', '" & correo & "', '" & password & "', '" & tipo_usuario & "', '" & area & "', '" & estado & "')"

        System.Diagnostics.Debug.WriteLine("SQL A EJECUTAR: " & strCon)
        Console.WriteLine("SQL A EJECUTAR: " & strCon)

        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error SQL: " & ex.Message & " | Consulta: " & strCon)
        End Try
    End Sub

    ' 5. Modificar datos del Personal
    Public Sub modificarPersonal(id As Integer, dni As String, nombres As String, apellidos As String, telefono As String, correo As String, password As String, tipo_usuario As String, area As String, estado As String)
        strCon = "UPDATE personal SET dni='" & dni & "', nombres='" & nombres & "', apellidos='" & apellidos & "', telefono='" & telefono & "', correo='" & correo & "', password='" & password & "', tipo_usuario='" & tipo_usuario & "', area='" & area & "', estado='" & estado & "' WHERE id_personal=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al modificar personal!")
        End Try
    End Sub

    ' 6. Eliminar Personal (Implementando baja lógica mediante el campo estado, recomendado por las relaciones de la BD)
    Public Sub eliminarPersonal(id As Integer)
        strCon = "UPDATE personal SET estado='Inactivo' WHERE id_personal=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al eliminar (desactivar) personal!")
        End Try
    End Sub

    ' 7. Listar todo el Personal
    Public Function listarPersonal() As DataTable
        strCon = "SELECT id_personal, dni, nombres, apellidos, telefono, correo, tipo_usuario, area, fecha_ingreso, estado FROM personal"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar el personal!")
        End Try
    End Function

    Public Function listarPersonalFiltrado(texto As String, rol As String, estado As String) As DataTable
        strCon = "SELECT id_personal, dni, nombres, apellidos, telefono, correo, tipo_usuario, area, fecha_ingreso, estado FROM personal WHERE 1=1"
        If Not String.IsNullOrWhiteSpace(texto) Then
            Dim t As String = Q(texto)
            strCon &= " AND (dni LIKE '%" & t & "%' OR nombres LIKE '%" & t & "%' OR apellidos LIKE '%" & t & "%')"
        End If
        If Not SinFiltro(rol) Then
            strCon &= " AND tipo_usuario='" & Q(rol) & "'"
        End If
        If Not SinFiltro(estado) Then
            strCon &= " AND estado='" & Q(estado) & "'"
        End If
        strCon &= " ORDER BY apellidos"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar el personal!")
        End Try
    End Function

    Public Function validarDNIOtro(dni As String, idExcluir As Integer) As Boolean
        Dim dtVal As New DataTable
        strCon = "SELECT id_personal FROM personal WHERE TRIM(dni)='" & Q(dni) & "' AND id_personal<>" & idExcluir
        Try
            dtVal = objMan.listarComando(strCon)
            Return dtVal.Rows.Count > 0
        Catch ex As Exception
            Throw New Exception("Error al validar el DNI!")
        End Try
    End Function

    Public Sub registrarPersonalAdmin(dni As String, nombres As String, apellidos As String, telefono As String, correo As String, password As String, tipo_usuario As String, area As String, estado As String)
        strCon = "INSERT INTO dbo.personal (dni, nombres, apellidos, telefono, correo, [password], tipo_usuario, area, estado) " &
            "VALUES ('" & Q(dni) & "', '" & Q(nombres) & "', '" & Q(apellidos) & "', " & QN(telefono) & ", " & QN(correo) & ", '" & Q(password) & "', '" & Q(tipo_usuario) & "', '" & Q(area) & "', '" & Q(estado) & "')"
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al registrar personal!")
        End Try
    End Sub

    Public Sub actualizarPersonal(id As Integer, dni As String, nombres As String, apellidos As String, telefono As String, correo As String, password As String, tipo_usuario As String, area As String)
        Dim sqlClave As String = ""
        If Not String.IsNullOrWhiteSpace(password) Then
            sqlClave = ", [password]='" & Q(password) & "'"
        End If
        strCon = "UPDATE personal SET dni='" & Q(dni) & "', nombres='" & Q(nombres) & "', apellidos='" & Q(apellidos) & "', telefono=" & QN(telefono) & ", correo=" & QN(correo) & ", tipo_usuario='" & Q(tipo_usuario) & "', area='" & Q(area) & "'" & sqlClave & " WHERE id_personal=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al actualizar personal!")
        End Try
    End Sub

    Public Sub darDeBajaPersonal(id As Integer)
        strCon = "UPDATE personal SET estado='Inactivo' WHERE id_personal=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja al personal!")
        End Try
    End Sub

    Public Sub reactivarPersonal(id As Integer)
        strCon = "UPDATE personal SET estado='Activo' WHERE id_personal=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al reactivar al personal!")
        End Try
    End Sub

    Public Function tieneRegistrosPersonal(id As Integer) As Boolean
        strCon = "SELECT (SELECT COUNT(*) FROM solicitudes WHERE id_personal=" & id & ") + (SELECT COUNT(*) FROM actividad_maquinaria WHERE id_personal=" & id & ")"
        Try
            dt = objMan.listarComando(strCon)
            Return Convert.ToInt32(dt.Rows(0).Item(0)) > 0
        Catch ex As Exception
            Throw New Exception("Error al verificar los registros del personal!")
        End Try
    End Function

    Public Sub eliminarPersonalDefinitivo(id As Integer)
        strCon = "DELETE FROM personal WHERE id_personal=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al eliminar personal!")
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
