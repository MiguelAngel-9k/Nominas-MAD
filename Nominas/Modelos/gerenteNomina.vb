Imports Nominas

Public Class gerenteNomina
    'informacion del gerente
    Public noCuenta As String
    Public salarioDiario As Integer
    Public NSS As String
    Public banco As String
    Public nomina As Integer
    Public RFC As String
    Public domicilio As Domicilio
    Public persona As persona
    Public empresa As String
    Public sueldoBase As Integer
    Public nivelSalarial As Integer

    Public Sub New()
    End Sub

    Public Sub New(noCuenta As String, salarioDiario As Integer, nSS As String, banco As String, nomina As Integer, RFC As String, domicilio As Domicilio, persona As persona, empresa As String, sueldoBase As Int32, nivelSalarial As Int32)
        Me.noCuenta = noCuenta
        Me.salarioDiario = salarioDiario
        Me.NSS = nSS
        Me.banco = banco
        Me.nomina = nomina
        Me.RFC = RFC
        Me.domicilio = domicilio
        Me.persona = persona
        Me.empresa = empresa
        Me.sueldoBase = sueldoBase
        Me.nivelSalarial = nivelSalarial
    End Sub
End Class
