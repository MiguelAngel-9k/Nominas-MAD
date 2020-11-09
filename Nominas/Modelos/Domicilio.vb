Public Class Domicilio
    Public calle As String
    Public colonia As String
    Public municipio As String
    Public codigoPostal As Int32
    Public estado As String

    Public Sub New()
    End Sub

    Public Sub New(calle As String, colonia As String, municipio As String, codigoPostal As Integer, estado As String)
        Me.calle = calle
        Me.colonia = colonia
        Me.municipio = municipio
        Me.codigoPostal = codigoPostal
        Me.estado = estado
    End Sub
End Class
