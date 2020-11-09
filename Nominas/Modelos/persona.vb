Public Class persona
    Public CURP As String
    Public nombre As String
    Public apellido As String
    Public fechaNacimiento As String

    Public Sub New()
    End Sub

    Public Sub New(cURP As String, nombre As String, apellido As String, fechaNacimiento As String)
        Me.CURP = cURP
        Me.nombre = nombre
        Me.apellido = apellido
        Me.fechaNacimiento = fechaNacimiento
    End Sub
End Class
