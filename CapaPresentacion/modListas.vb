Public Module modListas
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
