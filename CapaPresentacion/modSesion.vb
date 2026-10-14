Public Module modSesion
    Public UsuarioId As Integer
    Public UsuarioDni As String
    Public UsuarioNombre As String
    Public UsuarioRol As String
    Public UsuarioArea As String

    Public Sub CerrarSesion()
        UsuarioId = 0
        UsuarioDni = ""
        UsuarioNombre = ""
        UsuarioRol = ""
        UsuarioArea = ""
    End Sub
End Module
