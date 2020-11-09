Public Class agregarEmpresa
    Private Sub agregarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelBanco.Hide()
        panelAgregarGerente.Hide()
    End Sub

    Private Sub lblMunicipio_Click(sender As Object, e As EventArgs) Handles lblMunicipio.Click

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub

    Private Sub btnAgregarBanco_Click(sender As Object, e As EventArgs) Handles btnAgregarBanco.Click
        panelBanco.Show()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        panelBanco.Hide()
    End Sub

    Private Sub btnAceptarInfoP_Click(sender As Object, e As EventArgs) Handles btnAceptarInfoP.Click

        'Dim nuevaPersona As persona = New persona(
        '        txtCURP.Text,
        '        txtNomina.Text,
        '        txtApellidos.Text,
        '        ""
        '    )

        'Dim domicilioPersona As Domicilio = New Domicilio(
        '        txtCalleG.Text,
        '        txtColoniaG.Text,
        '        txtMunicipioG.Text,
        '        Convert.ToDecimal(txtCodigoPostalG.Text),
        '        txtEstadoG.Text
        '    )

        'Dim gerente As gerenteNomina = New gerenteNomina(
        '        txtNoCuenta.Text,
        '        Convert.ToDecimal(txtSalarioD.Text),
        '        txtNSS.Text,
        '        cbBanco.Text,
        '        txtNomina.Text,
        '        domicilioPersona
        '    )

        panelAgregarGerente.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblFOpreaciones.Click

    End Sub

    Private Sub btnAceptarEmrpesa_Click(sender As Object, e As EventArgs) Handles btnAceptarEmrpesa.Click
        'aqui vamos a guardar toda la informacion en mis objetos
        Dim empresaDomicilio As Domicilio = New Domicilio(
                txtCalle.Text,
                txtColonia.Text,
                txtMunicipio.Text,
                Convert.ToDecimal(txtCodigoPostal.Text),
                txtEstado.Text
            )

        Dim nuevaEmpresa As Empresa = New Empresa(
                txtRazonSocial.Text,
                txtRegistroPatronal.Text,
                txtRFC.Text,
                "",
                empresaDomicilio
            )

        'Dim nuevaPersona As persona = New persona(
        '        txtCURP.Text,
        '        txtNomina.Text,
        '        txtApellidos.Text,
        '        ""
        '    )

        'Dim domicilioPersona As Domicilio = New Domicilio(
        '        txtCalleG.Text,
        '        txtColoniaG.Text,
        '        txtMunicipioG.Text,
        '        Convert.ToDecimal(txtCodigoPostalG.Text),
        '        txtEstadoG.Text
        '    )

        'Dim gerente As gerenteNomina = New gerenteNomina(
        '        txtNoCuenta.Text,
        '        Convert.ToDecimal(txtSalarioD.Text),
        '        txtNSS.Text,
        '        cbBanco.Text,
        '        txtNomina.Text,
        '        txtRFCgerente.Text,
        '        domicilioPersona,
        '        nuevaPersona,
        '        nuevaEmpresa
        '    )

        Dim conn As connexion = New connexion()
        conn.insertar_domicilio_fiscal(nuevaEmpresa)
        'conn.insertar_gerente_nomina(gerente)

    End Sub

    Private Sub lblContraseniaEmpleado_Click(sender As Object, e As EventArgs) Handles lblRFCgerente.Click

    End Sub

    Private Sub btnAgregarEmpresa_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpresa.Click
        Dim status As Boolean = True
        'aqui vamos a guardar toda la informacion en mis objetos
        Dim empresaDomicilio As Domicilio = New Domicilio(
                txtCalle.Text,
                txtColonia.Text,
                txtMunicipio.Text,
                Convert.ToDecimal(txtCodigoPostal.Text),
                txtEstado.Text
            )

        Dim nuevaEmpresa As Empresa = New Empresa(
                txtRazonSocial.Text,
                txtRegistroPatronal.Text,
                txtRFC.Text,
                "",
                empresaDomicilio
            )

        Dim conn As connexion = New connexion()
        'status = conn.inseretar_domicilio_fiscal(nuevaEmpresa)
        status = conn.insertar_domicilio_fiscal(nuevaEmpresa)
        status = conn.insertar_empresa(nuevaEmpresa)

        If status Then
            panelGerenteNomina.Enabled = True
        Else
            panelGerenteNomina.Enabled = False
        End If

    End Sub
End Class