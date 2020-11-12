Public Class agregarEmpresa

    Dim Gerente_General As gerenteNomina

    Private Sub agregarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelBanco.Hide()
        panelAgregarGerente.Enabled = False
        panelGerenteNomina.Enabled = False

        Dim conn As connexion = New connexion()
        conn.cargar_estados(cbEstado)
        conn.cargar_estados(cbEstadoP)
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


        'Dim res As DialogResult = MessageBox.Show("¿Se creara un departamento de para el nuevo gerente?", "Agregar gerente", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        'If res = DialogResult.Cancel Then
        '    Return
        'End If

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
        '       cbEstadoP.Text
        '    )

        'Gerente_General = New gerenteNomina(
        '        txtNoCuenta.Text,
        '        Convert.ToDecimal(txtSalarioD.Text),
        '        txtNSS.Text,
        '        cbBanco.Text,
        '        txtNomina.Text,
        '        txtRFCgerente.Text,
        '        domicilioPersona,
        '        nuevaPersona,
        '        txtRFC.Text,
        '        Convert.ToDecimal(txtSueldoBase),
        '        Convert.ToDecimal(txtNivelSalarial)
        '    )

        'panelAgregarGerente.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblFOpreaciones.Click

    End Sub

    Private Sub btnAceptarEmrpesa_Click(sender As Object, e As EventArgs) Handles btnAceptarEmrpesa.Click
        'aqui vamos a guardar toda la informacion en mis objetos
        Dim res As DialogResult = MessageBox.Show("¿Se creara un departamento de para el nuevo gerente?", "Agregar gerente", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        If res = DialogResult.Cancel Then
            Return
        End If

        Dim nuevaPersona As persona = New persona(
                txtCURP.Text,
                txtNomina.Text,
                txtApellidos.Text,
                ""
            )

        Dim domicilioPersona As Domicilio = New Domicilio(
                txtCalleG.Text,
                txtColoniaG.Text,
                txtMunicipioG.Text,
                Convert.ToDecimal(txtCodigoPostalG.Text),
               cbEstadoP.Text
            )

        Gerente_General = New gerenteNomina(
                txtNoCuenta.Text,
                Convert.ToDecimal(txtSalarioD.Text),
                txtNSS.Text,
                cbBanco.Text,
                txtNomina.Text,
                txtRFCgerente.Text,
                domicilioPersona,
                nuevaPersona,
                txtRFC.Text,
                Convert.ToDecimal(txtSueldoBase.Text),
                Convert.ToDecimal(txtNivelSalarial.Text)
            )

        Dim conn As connexion = New connexion()
        conn.insertar_persona_gerente(Gerente_General)

        Gerente_General_Nomina.Enabled = True
        Me.Close()

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
                cbEstado.Text
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

        Dim Respuesta As DialogResult = MessageBox.Show("¿Desea agregar gerente?", "Agregar gerente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Respuesta = DialogResult.Yes Then
            panelGerenteNomina.Enabled = True
            panelAgregarGerente.Enabled = True
        Else
            'Me.Close()
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarEstado.Click

    End Sub

    Private Sub btnCancelarEmpresa_Click(sender As Object, e As EventArgs) Handles btnCancelarEmpresa.Click
        Gerente_General_Nomina.Enabled = True
        Me.Close()

    End Sub
End Class