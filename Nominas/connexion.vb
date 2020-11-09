Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class connexion

    Private aux As String
    Private conexion As SqlConnection
    'Private conexionNomina As SqlConnection
    Private tabla As DataTable = New DataTable
    Private adaptador As SqlDataAdapter = New SqlDataAdapter
    Private comandosql As SqlCommand = New SqlCommand

    Private Sub conectar()
        'Dim DBConnection As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("SQL").ConnectionString)        
        conexion = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("SQL").ConnectionString)
    End Sub

    Private Sub desconectar()
        conexion.Close()
    End Sub

    Public Function iniciar_sesion(No_empleado As Integer, contrasenia As String) As Boolean
        Dim estado As Boolean
        Dim table As New DataTable

        Try
            conectar()
            comandosql = New SqlCommand("sp_login", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim _no_empleado As SqlParameter = comandosql.Parameters.Add("@employee", SqlDbType.Int, 3)
            _no_empleado.Value = No_empleado
            Dim _contrasenia As SqlParameter = comandosql.Parameters.Add("@PASSWORD", SqlDbType.VarChar, 100)
            _contrasenia.Value = contrasenia

            adaptador.SelectCommand = comandosql
            adaptador.Fill(table)

            If table.Rows.Count > 0 Then
                MessageBox.Show("succes")
            Else
                MessageBox.Show("fail")
            End If


        Catch ex As SqlException
            MessageBox.Show(ex.ToString())
            estado = False
        Finally
            desconectar()
        End Try

        Return estado

    End Function

    Public Function insertar_domicilio_fiscal(empresa As Empresa) As Boolean
        Try
            conectar()
            'domicilio fiscal de la empresa
            Dim cmd As SqlCommand = New SqlCommand("sp_insertar_domicilio", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim codigoPostal As SqlParameter = cmd.Parameters.Add("@codigoPostal", SqlDbType.Int, 8)
            codigoPostal.Value = empresa.domicilioFiscal.codigoPostal

            Dim estado As SqlParameter = cmd.Parameters.Add("@estado", SqlDbType.VarChar, 20)
            estado.Value = empresa.domicilioFiscal.estado

            Dim municipio As SqlParameter = cmd.Parameters.Add("@municipio", SqlDbType.VarChar, 20)
            municipio.Value = empresa.domicilioFiscal.municipio

            Dim calle As SqlParameter = cmd.Parameters.Add("@calle", SqlDbType.VarChar, 20)
            calle.Value = empresa.domicilioFiscal.calle

            Dim colonia As SqlParameter = cmd.Parameters.Add("@colonia", SqlDbType.VarChar, 20)
            colonia.Value = empresa.domicilioFiscal.colonia

            Dim _opcion As String = "Empresa"

            Dim opcion As SqlParameter = cmd.Parameters.Add("@OPC", SqlDbType.Char, 13)
            opcion.Value = "Empresa"
            'informacion de la empresa
            'Dim razonSocial As SqlParameter = cmd.Parameters.Add("@razonSocial", SqlDbType.VarChar, 20)
            'razonSocial.Value = empresa.RazonSocial

            'Dim registroPatronal As SqlParameter = cmd.Parameters.Add("@registroPatronal", SqlDbType.VarChar, 20)
            'registroPatronal.Value = empresa.registroPatronal

            'Dim rfc As SqlParameter = cmd.Parameters.Add("@RFC", SqlDbType.VarChar, 20)
            'rfc.Value = empresa.RFC

            'adaptador.SelectCommand = cmd


            'Dim fechaInOp As SqlParameter = cmd.Parameters.Add("@fechaInOp", SqlDbType.VarChar, 20)
            'registroPatronal.Value = empresa.registroPatronal

            conexion.Open()
            adaptador.InsertCommand = cmd
            cmd.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show(ex.ToString(), "no se pudo insertar")
            Return False
        Finally
            desconectar()
        End Try
        Return True
    End Function

    Public Function insertar_empresa(empresa As Empresa) As Boolean
        Dim status As Boolean = True
        Try
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("sp_insertar_emrpesa", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim calle As SqlParameter = cmd.Parameters.Add("@calle_e", SqlDbType.VarChar, 20)
            calle.Value = empresa.domicilioFiscal.calle

            Dim colonia As SqlParameter = cmd.Parameters.Add("@colonia_e", SqlDbType.VarChar, 20)
            colonia.Value = empresa.domicilioFiscal.colonia

            Dim razonSocial As SqlParameter = cmd.Parameters.Add("@razonSocial", SqlDbType.VarChar, 20)
            razonSocial.Value = empresa.RazonSocial

            Dim registroPatronal As SqlParameter = cmd.Parameters.Add("@registroPatronal", SqlDbType.VarChar, 20)
            registroPatronal.Value = empresa.registroPatronal

            Dim rfc As SqlParameter = cmd.Parameters.Add("@RFC", SqlDbType.VarChar, 20)
            rfc.Value = empresa.RFC

            Dim fecha As Date = Date.Now()

            Dim fechaInOp As SqlParameter = cmd.Parameters.Add("@fechaInOp", SqlDbType.Date, 20)
            fechaInOp.Value = fecha

            conexion.Open()
            adaptador.InsertCommand = cmd
            cmd.ExecuteNonQuery()

            status = True

        Catch ex As SqlException
            MessageBox.Show(ex.ToString())
        Finally
            desconectar()
            status = False
        End Try

        Return status

    End Function

    Public Function insertar_gerente_nomina(gerente As gerenteNomina) As Boolean
        Try
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("sp_insertar_gerente_nomina", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim temDomicilio As Domicilio = New Domicilio()
            Dim temEmpresa As Empresa = New Empresa()

            'domicilio del gerente
            Dim rfcEmpresa As SqlParameter = cmd.Parameters.Add("@RFC_EMPRESA", SqlDbType.VarChar, 20)
            rfcEmpresa.Value = gerente.empresa.RFC

            Dim sueldoBase As SqlParameter = cmd.Parameters.Add("@sueldo_base", SqlDbType.Int, 8)
            sueldoBase.Value = 1500

            Dim cantEmpleados As SqlParameter = cmd.Parameters.Add("@cant_empleados", SqlDbType.Int, 2)
            cantEmpleados.Value = 1

            Dim curp As SqlParameter = cmd.Parameters.Add("@CURP", SqlDbType.VarChar, 20)
            curp.Value = gerente.persona.CURP

            Dim rfcGerente As SqlParameter = cmd.Parameters.Add("@RFC", SqlDbType.VarChar, 20)
            cantEmpleados.Value = gerente.RFC

            Dim nombre As SqlParameter = cmd.Parameters.Add("@cant_empleados", SqlDbType.VarChar, 20)
            nombre.Value = gerente.persona.nombre

            Dim apellidos As SqlParameter = cmd.Parameters.Add("@apellido_p", SqlDbType.VarChar, 20)
            apellidos.Value = gerente.persona.apellido

            Dim fechaNac As SqlParameter = cmd.Parameters.Add("@fehcaNacim", SqlDbType.Date, 10)
            fechaNac.Value = "19990524"

            'informacion del domicolio
            Dim calle As SqlParameter = cmd.Parameters.Add("@calle_e", SqlDbType.VarChar, 20)
            calle.Value = gerente.domicilio.calle

            Dim colonia As SqlParameter = cmd.Parameters.Add("@colonia_e", SqlDbType.VarChar, 20)
            colonia.Value = gerente.domicilio.colonia

            Dim municipio As SqlParameter = cmd.Parameters.Add("@municipio_e", SqlDbType.VarChar, 20)
            municipio.Value = gerente.domicilio.municipio

            Dim codigoPostal As SqlParameter = cmd.Parameters.Add("@codigoPostal_e", SqlDbType.Int, 8)
            codigoPostal.Value = gerente.domicilio.codigoPostal

            Dim estado As SqlParameter = cmd.Parameters.Add("@estado_e", SqlDbType.VarChar, 20)
            estado.Value = gerente.domicilio.estado

            Dim sueldoEsp As SqlParameter = cmd.Parameters.Add("@sueldo_especifico", SqlDbType.Int, 8)
            sueldoEsp.Value = 1500

            Dim nivelSalarial As SqlParameter = cmd.Parameters.Add("@nivelSalarial", SqlDbType.Int, 8)
            nivelSalarial.Value = 2000

            Dim noCuenta As SqlParameter = cmd.Parameters.Add("@noCuenta", SqlDbType.Int, 8)
            noCuenta.Value = gerente.noCuenta

            Dim NSS As SqlParameter = cmd.Parameters.Add("@NSS", SqlDbType.Int, 8)
            NSS.Value = gerente.NSS

            Dim banco As SqlParameter = cmd.Parameters.Add("@banco", SqlDbType.VarChar, 20)
            banco.Value = gerente.banco

            Dim nomina As SqlParameter = cmd.Parameters.Add("@nomina", SqlDbType.VarChar, 20)
            nomina.Value = gerente.nomina

            adaptador.InsertCommand = cmd

        Catch ex As SqlException
            MessageBox.Show(ex.ToString(), "no se pudo insertar gerente")
            Return False
        Finally
            desconectar()
        End Try
        Return True
    End Function

End Class
