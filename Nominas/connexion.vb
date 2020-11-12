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

    Public Function mostrar_empresas() As DataTable
        Try
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("sp_mostrar_empresas", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim data As DataSet = New DataSet

            adaptador.SelectCommand = cmd
            adaptador.Fill(tabla)

            Return tabla

        Catch ex As Exception

        End Try
    End Function

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

    Public Function cargar_estados(estados As ComboBox) As Boolean
        Dim status As Boolean
        Dim qry As String = "Select estado from Estado"
        Try
            conectar()
            Dim cmd As SqlDataAdapter = New SqlDataAdapter(qry, conexion)
            Dim data As DataSet = New DataSet()
            cmd.Fill(data)
            estados.DataSource = data.Tables(0)
            estados.DisplayMember = "Estado"
            estados.ValueMember = "clave_estado"
        Catch ex As Exception

        End Try
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

    Private Function insertar_persona(persona As gerenteNomina) As Boolean
        Dim state As Boolean
        Try
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("sp_insertar_persona_gerente", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim curp As SqlParameter = cmd.Parameters.Add("@CURP", SqlDbType.VarChar, 20)
            curp.Value = persona.persona.CURP

            Dim rfc As SqlParameter = cmd.Parameters.Add("@RFC", SqlDbType.VarChar, 20)
            rfc.Value = persona.RFC

            Dim nombre As SqlParameter = cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 20)
            nombre.Value = persona.persona.nombre

            Dim apellido As SqlParameter = cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 20)
            apellido.Value = persona.persona.apellido

            Dim fecha As Date = Date.Now()

            Dim fechaNacim As SqlParameter = cmd.Parameters.Add("@fehcaNacim", SqlDbType.Date, 20)
            fechaNacim.Value = fecha

            Dim calle As SqlParameter = cmd.Parameters.Add("@calle_p", SqlDbType.VarChar, 20)
            calle.Value = persona.domicilio.calle

            Dim colonia As SqlParameter = cmd.Parameters.Add("@colonia_p", SqlDbType.VarChar, 20)
            colonia.Value = persona.domicilio.colonia

            conexion.Open()
            adaptador.InsertCommand = cmd
            cmd.ExecuteNonQuery()

            state = True

        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
        Finally
            desconectar()
        End Try
    End Function

    Private Function insertar_domicilio_persona(domicilio As Domicilio)
        Dim state As Boolean = False
        Try
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("sp_insertar_domicilio", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim codigoPostal As SqlParameter = cmd.Parameters.Add("@codigoPostal", SqlDbType.Int, 8)
            codigoPostal.Value = domicilio.codigoPostal

            Dim estado As SqlParameter = cmd.Parameters.Add("@estado", SqlDbType.VarChar, 20)
            estado.Value = domicilio.estado

            Dim municipio As SqlParameter = cmd.Parameters.Add("@municipio", SqlDbType.VarChar, 20)
            municipio.Value = domicilio.municipio

            Dim calle As SqlParameter = cmd.Parameters.Add("@calle", SqlDbType.VarChar, 20)
            calle.Value = domicilio.calle

            Dim colonia As SqlParameter = cmd.Parameters.Add("@colonia", SqlDbType.VarChar, 20)
            colonia.Value = domicilio.colonia

            Dim opcion As SqlParameter = cmd.Parameters.Add("@OPC", SqlDbType.Char, 13)
            opcion.Value = "Persona"

            state = True

            conexion.Open()
            adaptador.InsertCommand = cmd
            cmd.ExecuteNonQuery()

        Catch ex As SqlException
            state = False
            MessageBox.Show(ex.ToString(), "no se pudo insertar")
        Finally
            desconectar()
        End Try

        Return state

    End Function

    Public Function insertar_persona_gerente(gerente As gerenteNomina) As Boolean

        If Me.insertar_domicilio_persona(gerente.domicilio) = False Then
            MessageBox.Show("No se pudo insertar la informacion del domicilio\npuede haber informacion duplicada o que ya exista", "No se pudo guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Me.insertar_persona(gerente) = False Then
            MessageBox.Show("No se pudo insertar la informacion personal\npuede haber informacion duplicada o que ya exista", "No se pudo guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Me.insertar_gerente_nomina(gerente) = False Then
            MessageBox.Show("No se pudo insertar la informacion del gerente\npuede haber informacion duplicada o que ya exista", "No se pudo guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True

    End Function

    Public Function insertar_gerente_nomina(gerente As gerenteNomina) As Boolean
        Dim state As Boolean = True
        Try
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("sp_insertar_gerente_nomina", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim temDomicilio As Domicilio = New Domicilio()
            Dim temEmpresa As Empresa = New Empresa()

            'domicilio del gerente
            Dim rfcEmpresa As SqlParameter = cmd.Parameters.Add("@RFC_EMPRESA", SqlDbType.VarChar, 20)
            rfcEmpresa.Value = gerente.empresa

            Dim sueldoBase As SqlParameter = cmd.Parameters.Add("@sueldo_base", SqlDbType.Int, 8)
            sueldoBase.Value = gerente.sueldoBase

            Dim cantEmpleados As SqlParameter = cmd.Parameters.Add("@cant_empleados", SqlDbType.Int, 8)
            cantEmpleados.Value = 1

            Dim curp As SqlParameter = cmd.Parameters.Add("@CURP", SqlDbType.VarChar, 20)
            curp.Value = gerente.persona.CURP

            Dim sueldoEsp As SqlParameter = cmd.Parameters.Add("@sueldo_especifico", SqlDbType.Int, 8)
            sueldoEsp.Value = gerente.salarioDiario + gerente.sueldoBase + gerente.nivelSalarial

            Dim nivelSalarial As SqlParameter = cmd.Parameters.Add("@nivelSalarial", SqlDbType.Int, 8)
            nivelSalarial.Value = gerente.nivelSalarial

            Dim salarioDiario As SqlParameter = cmd.Parameters.Add("@salarioDiario", SqlDbType.Int, 8)
            salarioDiario.Value = gerente.salarioDiario

            Dim noCuenta As SqlParameter = cmd.Parameters.Add("@noCuenta", SqlDbType.VarChar, 50)
            noCuenta.Value = gerente.noCuenta

            Dim NSS As SqlParameter = cmd.Parameters.Add("@NSS", SqlDbType.VarChar, 50)
            NSS.Value = gerente.NSS

            Dim banco As SqlParameter = cmd.Parameters.Add("@banco", SqlDbType.VarChar, 20)
            banco.Value = gerente.banco

            'Dim nomina As SqlParameter = cmd.Parameters.Add("@nomina", SqlDbType.Int, 8)
            'nomina.Value = gerente.nomina

            conexion.Open()
            adaptador.InsertCommand = cmd
            cmd.ExecuteNonQuery()

            state = True

        Catch ex As SqlException
            MessageBox.Show(ex.ToString(), "no se pudo insertar gerente")
            state = False
        Finally
            desconectar()
        End Try
        Return state
    End Function

End Class
