Imports Nominas

Public Class Empresa
    Public RazonSocial As String
    Public registroPatronal As String
    Public RFC As String
    Public fIOperaciones As String
    Public domicilioFiscal As Domicilio
    Public gerenteNomina As gerenteNomina

    Public Sub New()
    End Sub

    Public Sub New(razonSocial As String, registroPatronal As String, rFC As String, fIOperaciones As String, domicilioFiscal As Domicilio)
        Me.RazonSocial = razonSocial
        Me.registroPatronal = registroPatronal
        Me.RFC = rFC
        Me.fIOperaciones = fIOperaciones
        Me.domicilioFiscal = domicilioFiscal
    End Sub

    Public Sub New(razonSocial As String, registroPatronal As String, rFC As String, fIOperaciones As String, domicilioFiscal As Domicilio, gerenteNomina As gerenteNomina)
        Me.RazonSocial = razonSocial
        Me.registroPatronal = registroPatronal
        Me.RFC = rFC
        Me.fIOperaciones = fIOperaciones
        Me.domicilioFiscal = domicilioFiscal
        Me.gerenteNomina = gerenteNomina
    End Sub
End Class
