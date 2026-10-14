Public Module modListas
    Public Areas() As String = {"Campo", "Fábrica", "Logística", "Mantenimiento", "Administración", "Recursos humanos", "Sistemas"}
    Public Roles() As String = {"Operario", "Supervisor", "Administrador"}
    Public Prioridades() As String = {"Alta", "Media", "Baja"}
    Public EstadosSolicitud() As String = {"Pendiente", "En revisión", "Aprobado", "Rechazado"}
    Public EstadosMaquina() As String = {"Operativo", "En Mantenimiento", "Sin Tarea", "Dado de Baja"}
    Public Zonas() As String = {"Anexo Pampagrande", "Anexo Saltur", "Sipán Lote 4"}
    Public NivelesCombustible() As String = {"75%", "50%", "25%", "Reserva"}

    Public Function CombustibleANumero(texto As String) As Decimal
        Select Case If(texto, "").Trim()
            Case "100%"
                Return 100D
            Case "75%"
                Return 75D
            Case "50%"
                Return 50D
            Case "25%"
                Return 25D
            Case "Reserva"
                Return 10D
            Case Else
                Return 0D
        End Select
    End Function

    Public Function CombustibleATexto(valor As Object) As String
        If valor Is Nothing OrElse IsDBNull(valor) OrElse String.IsNullOrWhiteSpace(Convert.ToString(valor)) Then
            Return "-"
        End If
        Dim numero As Decimal = Convert.ToDecimal(valor)
        If numero = 100D Then
            Return "100%"
        End If
        If numero = 75D Then
            Return "75%"
        End If
        If numero = 50D Then
            Return "50%"
        End If
        If numero = 25D Then
            Return "25%"
        End If
        If numero = 10D Then
            Return "Reserva"
        End If
        Return numero.ToString(Globalization.CultureInfo.InvariantCulture)
    End Function
End Module
