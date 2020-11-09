Imports Nominas

Public Class gerenteNomina
    'informacion del gerente
    Public noCuenta As Int32
    Public salarioDiario As Int32
    Public NSS As Int32
    Public banco As String
    Public nomina As Int32
    Public RFC As String
    Public domicilio As Domicilio
    Public persona As persona
    Public empresa As Empresa

    Public Sub New()
    End Sub

    Public Sub New(noCuenta As Integer, salarioDiario As Integer, nSS As Integer, banco As String, nomina As Integer, RFC As String, domicilio As Domicilio, persona As persona, empresa As Empresa)
        Me.noCuenta = noCuenta
        Me.salarioDiario = salarioDiario
        Me.NSS = nSS
        Me.banco = banco
        Me.nomina = nomina
        Me.RFC = RFC
        Me.domicilio = domicilio
        Me.persona = persona
        Me.empresa = empresa
    End Sub
End Class
