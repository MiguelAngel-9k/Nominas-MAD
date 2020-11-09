<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarEmpresa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelDomFiscal = New System.Windows.Forms.Panel()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCodigoPostal = New System.Windows.Forms.Label()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblDomFiscal = New System.Windows.Forms.Label()
        Me.panelGerenteNomina = New System.Windows.Forms.Panel()
        Me.panelBanco = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.lblNombreBanco = New System.Windows.Forms.Label()
        Me.lblAgregarBanco = New System.Windows.Forms.Label()
        Me.btnAceptarInfoP = New System.Windows.Forms.Button()
        Me.panelAgregarGerente = New System.Windows.Forms.Panel()
        Me.lblGerente = New System.Windows.Forms.Label()
        Me.lblRFCgerente = New System.Windows.Forms.Label()
        Me.txtSalarioD = New System.Windows.Forms.TextBox()
        Me.lblNSS = New System.Windows.Forms.Label()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.lblNomina = New System.Windows.Forms.Label()
        Me.lblNoCuenta = New System.Windows.Forms.Label()
        Me.txtNSS = New System.Windows.Forms.TextBox()
        Me.txtRFCgerente = New System.Windows.Forms.TextBox()
        Me.txtNomina = New System.Windows.Forms.TextBox()
        Me.lblSalarioD = New System.Windows.Forms.Label()
        Me.cbBanco = New System.Windows.Forms.ComboBox()
        Me.btnAgregarBanco = New System.Windows.Forms.Button()
        Me.txtEstadoG = New System.Windows.Forms.TextBox()
        Me.lblEstadoGerente = New System.Windows.Forms.Label()
        Me.txtCodigoPostalG = New System.Windows.Forms.TextBox()
        Me.lblDomicilioGerente = New System.Windows.Forms.Label()
        Me.txtMunicipioG = New System.Windows.Forms.TextBox()
        Me.txtColoniaG = New System.Windows.Forms.TextBox()
        Me.lblCodigoPostalGerente = New System.Windows.Forms.Label()
        Me.txtCalleG = New System.Windows.Forms.TextBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblMunicipioGerente = New System.Windows.Forms.Label()
        Me.lblColoniaGerente = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.lblCalleGerente = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCURP = New System.Windows.Forms.TextBox()
        Me.lblFechaNaciemiento = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblInformacionPersonal = New System.Windows.Forms.Label()
        Me.lblCURP = New System.Windows.Forms.Label()
        Me.btnAceptarEmrpesa = New System.Windows.Forms.Button()
        Me.btnCancelarEmpresa = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.txtRegistroPatronal = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.lblFOpreaciones = New System.Windows.Forms.Label()
        Me.lblRFC = New System.Windows.Forms.Label()
        Me.lblRegistroPatronal = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.btnAgregarEmpresa = New System.Windows.Forms.Button()
        Me.panelDomFiscal.SuspendLayout()
        Me.panelGerenteNomina.SuspendLayout()
        Me.panelBanco.SuspendLayout()
        Me.panelAgregarGerente.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelDomFiscal
        '
        Me.panelDomFiscal.Controls.Add(Me.txtEstado)
        Me.panelDomFiscal.Controls.Add(Me.txtCodigoPostal)
        Me.panelDomFiscal.Controls.Add(Me.txtMunicipio)
        Me.panelDomFiscal.Controls.Add(Me.txtColonia)
        Me.panelDomFiscal.Controls.Add(Me.txtCalle)
        Me.panelDomFiscal.Controls.Add(Me.lblEstado)
        Me.panelDomFiscal.Controls.Add(Me.lblCodigoPostal)
        Me.panelDomFiscal.Controls.Add(Me.lblMunicipio)
        Me.panelDomFiscal.Controls.Add(Me.lblColonia)
        Me.panelDomFiscal.Controls.Add(Me.lblCalle)
        Me.panelDomFiscal.Controls.Add(Me.lblDomFiscal)
        Me.panelDomFiscal.Location = New System.Drawing.Point(24, 23)
        Me.panelDomFiscal.Name = "panelDomFiscal"
        Me.panelDomFiscal.Size = New System.Drawing.Size(418, 243)
        Me.panelDomFiscal.TabIndex = 0
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(128, 196)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(245, 20)
        Me.txtEstado.TabIndex = 11
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Location = New System.Drawing.Point(128, 162)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(113, 20)
        Me.txtCodigoPostal.TabIndex = 10
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(128, 129)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(245, 20)
        Me.txtMunicipio.TabIndex = 9
        '
        'txtColonia
        '
        Me.txtColonia.Location = New System.Drawing.Point(128, 96)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(245, 20)
        Me.txtColonia.TabIndex = 8
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(128, 64)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(245, 20)
        Me.txtCalle.TabIndex = 7
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(15, 203)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 6
        Me.lblEstado.Text = "Estado"
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.Location = New System.Drawing.Point(13, 169)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(72, 13)
        Me.lblCodigoPostal.TabIndex = 5
        Me.lblCodigoPostal.Text = "Codigo Postal"
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Location = New System.Drawing.Point(13, 136)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(52, 13)
        Me.lblMunicipio.TabIndex = 4
        Me.lblMunicipio.Text = "Municipio"
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(13, 103)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(42, 13)
        Me.lblColonia.TabIndex = 3
        Me.lblColonia.Text = "Colonia"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(13, 71)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(30, 13)
        Me.lblCalle.TabIndex = 2
        Me.lblCalle.Text = "Calle"
        '
        'lblDomFiscal
        '
        Me.lblDomFiscal.AutoSize = True
        Me.lblDomFiscal.Location = New System.Drawing.Point(140, 19)
        Me.lblDomFiscal.Name = "lblDomFiscal"
        Me.lblDomFiscal.Size = New System.Drawing.Size(79, 13)
        Me.lblDomFiscal.TabIndex = 0
        Me.lblDomFiscal.Text = "Domicilio Fiscal"
        '
        'panelGerenteNomina
        '
        Me.panelGerenteNomina.Controls.Add(Me.panelBanco)
        Me.panelGerenteNomina.Controls.Add(Me.btnAceptarInfoP)
        Me.panelGerenteNomina.Controls.Add(Me.panelAgregarGerente)
        Me.panelGerenteNomina.Controls.Add(Me.txtEstadoG)
        Me.panelGerenteNomina.Controls.Add(Me.lblEstadoGerente)
        Me.panelGerenteNomina.Controls.Add(Me.txtCodigoPostalG)
        Me.panelGerenteNomina.Controls.Add(Me.lblDomicilioGerente)
        Me.panelGerenteNomina.Controls.Add(Me.txtMunicipioG)
        Me.panelGerenteNomina.Controls.Add(Me.txtColoniaG)
        Me.panelGerenteNomina.Controls.Add(Me.lblCodigoPostalGerente)
        Me.panelGerenteNomina.Controls.Add(Me.txtCalleG)
        Me.panelGerenteNomina.Controls.Add(Me.dtpFechaNacimiento)
        Me.panelGerenteNomina.Controls.Add(Me.lblMunicipioGerente)
        Me.panelGerenteNomina.Controls.Add(Me.lblColoniaGerente)
        Me.panelGerenteNomina.Controls.Add(Me.txtApellidos)
        Me.panelGerenteNomina.Controls.Add(Me.lblCalleGerente)
        Me.panelGerenteNomina.Controls.Add(Me.txtNombre)
        Me.panelGerenteNomina.Controls.Add(Me.txtCURP)
        Me.panelGerenteNomina.Controls.Add(Me.lblFechaNaciemiento)
        Me.panelGerenteNomina.Controls.Add(Me.lblApellido)
        Me.panelGerenteNomina.Controls.Add(Me.lblNombre)
        Me.panelGerenteNomina.Controls.Add(Me.lblInformacionPersonal)
        Me.panelGerenteNomina.Controls.Add(Me.lblCURP)
        Me.panelGerenteNomina.Location = New System.Drawing.Point(24, 285)
        Me.panelGerenteNomina.Name = "panelGerenteNomina"
        Me.panelGerenteNomina.Size = New System.Drawing.Size(789, 499)
        Me.panelGerenteNomina.TabIndex = 1
        '
        'panelBanco
        '
        Me.panelBanco.Controls.Add(Me.btnCancelar)
        Me.panelBanco.Controls.Add(Me.btnAceptar)
        Me.panelBanco.Controls.Add(Me.txtBanco)
        Me.panelBanco.Controls.Add(Me.lblNombreBanco)
        Me.panelBanco.Controls.Add(Me.lblAgregarBanco)
        Me.panelBanco.Location = New System.Drawing.Point(41, 367)
        Me.panelBanco.Name = "panelBanco"
        Me.panelBanco.Size = New System.Drawing.Size(369, 129)
        Me.panelBanco.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(282, 98)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 27
        Me.btnCancelar.Text = "Canelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(194, 98)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 26
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(156, 58)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(138, 20)
        Me.txtBanco.TabIndex = 25
        '
        'lblNombreBanco
        '
        Me.lblNombreBanco.AutoSize = True
        Me.lblNombreBanco.Location = New System.Drawing.Point(11, 65)
        Me.lblNombreBanco.Name = "lblNombreBanco"
        Me.lblNombreBanco.Size = New System.Drawing.Size(38, 13)
        Me.lblNombreBanco.TabIndex = 24
        Me.lblNombreBanco.Text = "Banco"
        '
        'lblAgregarBanco
        '
        Me.lblAgregarBanco.AutoSize = True
        Me.lblAgregarBanco.Location = New System.Drawing.Point(153, 19)
        Me.lblAgregarBanco.Name = "lblAgregarBanco"
        Me.lblAgregarBanco.Size = New System.Drawing.Size(77, 13)
        Me.lblAgregarBanco.TabIndex = 0
        Me.lblAgregarBanco.Text = "Agregar banco"
        '
        'btnAceptarInfoP
        '
        Me.btnAceptarInfoP.Location = New System.Drawing.Point(64, 242)
        Me.btnAceptarInfoP.Name = "btnAceptarInfoP"
        Me.btnAceptarInfoP.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarInfoP.TabIndex = 15
        Me.btnAceptarInfoP.Text = "Aceptar"
        Me.btnAceptarInfoP.UseVisualStyleBackColor = True
        '
        'panelAgregarGerente
        '
        Me.panelAgregarGerente.Controls.Add(Me.lblGerente)
        Me.panelAgregarGerente.Controls.Add(Me.lblRFCgerente)
        Me.panelAgregarGerente.Controls.Add(Me.txtSalarioD)
        Me.panelAgregarGerente.Controls.Add(Me.lblNSS)
        Me.panelAgregarGerente.Controls.Add(Me.lblBanco)
        Me.panelAgregarGerente.Controls.Add(Me.txtNoCuenta)
        Me.panelAgregarGerente.Controls.Add(Me.lblNomina)
        Me.panelAgregarGerente.Controls.Add(Me.lblNoCuenta)
        Me.panelAgregarGerente.Controls.Add(Me.txtNSS)
        Me.panelAgregarGerente.Controls.Add(Me.txtRFCgerente)
        Me.panelAgregarGerente.Controls.Add(Me.txtNomina)
        Me.panelAgregarGerente.Controls.Add(Me.lblSalarioD)
        Me.panelAgregarGerente.Controls.Add(Me.cbBanco)
        Me.panelAgregarGerente.Controls.Add(Me.btnAgregarBanco)
        Me.panelAgregarGerente.Enabled = False
        Me.panelAgregarGerente.Location = New System.Drawing.Point(41, 283)
        Me.panelAgregarGerente.Name = "panelAgregarGerente"
        Me.panelAgregarGerente.Size = New System.Drawing.Size(694, 199)
        Me.panelAgregarGerente.TabIndex = 24
        '
        'lblGerente
        '
        Me.lblGerente.AutoSize = True
        Me.lblGerente.Location = New System.Drawing.Point(256, 10)
        Me.lblGerente.Name = "lblGerente"
        Me.lblGerente.Size = New System.Drawing.Size(97, 13)
        Me.lblGerente.TabIndex = 0
        Me.lblGerente.Text = "Gerente de nomina"
        '
        'lblRFCgerente
        '
        Me.lblRFCgerente.AutoSize = True
        Me.lblRFCgerente.Location = New System.Drawing.Point(12, 51)
        Me.lblRFCgerente.Name = "lblRFCgerente"
        Me.lblRFCgerente.Size = New System.Drawing.Size(28, 13)
        Me.lblRFCgerente.TabIndex = 1
        Me.lblRFCgerente.Text = "RFC"
        '
        'txtSalarioD
        '
        Me.txtSalarioD.Location = New System.Drawing.Point(139, 104)
        Me.txtSalarioD.Name = "txtSalarioD"
        Me.txtSalarioD.Size = New System.Drawing.Size(145, 20)
        Me.txtSalarioD.TabIndex = 10
        '
        'lblNSS
        '
        Me.lblNSS.AutoSize = True
        Me.lblNSS.Location = New System.Drawing.Point(366, 44)
        Me.lblNSS.Name = "lblNSS"
        Me.lblNSS.Size = New System.Drawing.Size(29, 13)
        Me.lblNSS.TabIndex = 4
        Me.lblNSS.Text = "NSS"
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(366, 82)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(38, 13)
        Me.lblBanco.TabIndex = 5
        Me.lblBanco.Text = "Banco"
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.Location = New System.Drawing.Point(139, 73)
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Size = New System.Drawing.Size(190, 20)
        Me.txtNoCuenta.TabIndex = 9
        '
        'lblNomina
        '
        Me.lblNomina.AutoSize = True
        Me.lblNomina.Location = New System.Drawing.Point(364, 113)
        Me.lblNomina.Name = "lblNomina"
        Me.lblNomina.Size = New System.Drawing.Size(43, 13)
        Me.lblNomina.TabIndex = 6
        Me.lblNomina.Text = "Nomina"
        '
        'lblNoCuenta
        '
        Me.lblNoCuenta.AutoSize = True
        Me.lblNoCuenta.Location = New System.Drawing.Point(12, 80)
        Me.lblNoCuenta.Name = "lblNoCuenta"
        Me.lblNoCuenta.Size = New System.Drawing.Size(96, 13)
        Me.lblNoCuenta.TabIndex = 2
        Me.lblNoCuenta.Text = "Número de Cuenta"
        '
        'txtNSS
        '
        Me.txtNSS.Location = New System.Drawing.Point(491, 37)
        Me.txtNSS.Name = "txtNSS"
        Me.txtNSS.Size = New System.Drawing.Size(190, 20)
        Me.txtNSS.TabIndex = 11
        '
        'txtRFCgerente
        '
        Me.txtRFCgerente.Location = New System.Drawing.Point(139, 44)
        Me.txtRFCgerente.Name = "txtRFCgerente"
        Me.txtRFCgerente.Size = New System.Drawing.Size(190, 20)
        Me.txtRFCgerente.TabIndex = 8
        '
        'txtNomina
        '
        Me.txtNomina.Location = New System.Drawing.Point(491, 106)
        Me.txtNomina.Name = "txtNomina"
        Me.txtNomina.Size = New System.Drawing.Size(190, 20)
        Me.txtNomina.TabIndex = 12
        '
        'lblSalarioD
        '
        Me.lblSalarioD.AutoSize = True
        Me.lblSalarioD.Location = New System.Drawing.Point(12, 111)
        Me.lblSalarioD.Name = "lblSalarioD"
        Me.lblSalarioD.Size = New System.Drawing.Size(69, 13)
        Me.lblSalarioD.TabIndex = 3
        Me.lblSalarioD.Text = "Salario Diario"
        '
        'cbBanco
        '
        Me.cbBanco.FormattingEnabled = True
        Me.cbBanco.Location = New System.Drawing.Point(491, 74)
        Me.cbBanco.Name = "cbBanco"
        Me.cbBanco.Size = New System.Drawing.Size(100, 21)
        Me.cbBanco.TabIndex = 13
        '
        'btnAgregarBanco
        '
        Me.btnAgregarBanco.Location = New System.Drawing.Point(597, 72)
        Me.btnAgregarBanco.Name = "btnAgregarBanco"
        Me.btnAgregarBanco.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarBanco.TabIndex = 14
        Me.btnAgregarBanco.Text = "Agregar"
        Me.btnAgregarBanco.UseVisualStyleBackColor = True
        '
        'txtEstadoG
        '
        Me.txtEstadoG.Location = New System.Drawing.Point(480, 187)
        Me.txtEstadoG.Name = "txtEstadoG"
        Me.txtEstadoG.Size = New System.Drawing.Size(245, 20)
        Me.txtEstadoG.TabIndex = 16
        '
        'lblEstadoGerente
        '
        Me.lblEstadoGerente.AutoSize = True
        Me.lblEstadoGerente.Location = New System.Drawing.Point(390, 194)
        Me.lblEstadoGerente.Name = "lblEstadoGerente"
        Me.lblEstadoGerente.Size = New System.Drawing.Size(40, 13)
        Me.lblEstadoGerente.TabIndex = 16
        Me.lblEstadoGerente.Text = "Estado"
        '
        'txtCodigoPostalG
        '
        Me.txtCodigoPostalG.Location = New System.Drawing.Point(480, 153)
        Me.txtCodigoPostalG.Name = "txtCodigoPostalG"
        Me.txtCodigoPostalG.Size = New System.Drawing.Size(113, 20)
        Me.txtCodigoPostalG.TabIndex = 15
        '
        'lblDomicilioGerente
        '
        Me.lblDomicilioGerente.AutoSize = True
        Me.lblDomicilioGerente.Location = New System.Drawing.Point(462, 20)
        Me.lblDomicilioGerente.Name = "lblDomicilioGerente"
        Me.lblDomicilioGerente.Size = New System.Drawing.Size(105, 13)
        Me.lblDomicilioGerente.TabIndex = 23
        Me.lblDomicilioGerente.Text = "Domicilio de Gerente"
        '
        'txtMunicipioG
        '
        Me.txtMunicipioG.Location = New System.Drawing.Point(480, 120)
        Me.txtMunicipioG.Name = "txtMunicipioG"
        Me.txtMunicipioG.Size = New System.Drawing.Size(245, 20)
        Me.txtMunicipioG.TabIndex = 14
        '
        'txtColoniaG
        '
        Me.txtColoniaG.Location = New System.Drawing.Point(480, 87)
        Me.txtColoniaG.Name = "txtColoniaG"
        Me.txtColoniaG.Size = New System.Drawing.Size(245, 20)
        Me.txtColoniaG.TabIndex = 13
        '
        'lblCodigoPostalGerente
        '
        Me.lblCodigoPostalGerente.AutoSize = True
        Me.lblCodigoPostalGerente.Location = New System.Drawing.Point(388, 160)
        Me.lblCodigoPostalGerente.Name = "lblCodigoPostalGerente"
        Me.lblCodigoPostalGerente.Size = New System.Drawing.Size(72, 13)
        Me.lblCodigoPostalGerente.TabIndex = 15
        Me.lblCodigoPostalGerente.Text = "Codigo Postal"
        '
        'txtCalleG
        '
        Me.txtCalleG.Location = New System.Drawing.Point(480, 55)
        Me.txtCalleG.Name = "txtCalleG"
        Me.txtCalleG.Size = New System.Drawing.Size(245, 20)
        Me.txtCalleG.TabIndex = 12
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(182, 166)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(153, 20)
        Me.dtpFechaNacimiento.TabIndex = 22
        '
        'lblMunicipioGerente
        '
        Me.lblMunicipioGerente.AutoSize = True
        Me.lblMunicipioGerente.Location = New System.Drawing.Point(388, 127)
        Me.lblMunicipioGerente.Name = "lblMunicipioGerente"
        Me.lblMunicipioGerente.Size = New System.Drawing.Size(52, 13)
        Me.lblMunicipioGerente.TabIndex = 14
        Me.lblMunicipioGerente.Text = "Municipio"
        '
        'lblColoniaGerente
        '
        Me.lblColoniaGerente.AutoSize = True
        Me.lblColoniaGerente.Location = New System.Drawing.Point(388, 94)
        Me.lblColoniaGerente.Name = "lblColoniaGerente"
        Me.lblColoniaGerente.Size = New System.Drawing.Size(42, 13)
        Me.lblColoniaGerente.TabIndex = 13
        Me.lblColoniaGerente.Text = "Colonia"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(182, 126)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(153, 20)
        Me.txtApellidos.TabIndex = 21
        '
        'lblCalleGerente
        '
        Me.lblCalleGerente.AutoSize = True
        Me.lblCalleGerente.Location = New System.Drawing.Point(388, 62)
        Me.lblCalleGerente.Name = "lblCalleGerente"
        Me.lblCalleGerente.Size = New System.Drawing.Size(30, 13)
        Me.lblCalleGerente.TabIndex = 12
        Me.lblCalleGerente.Text = "Calle"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(182, 92)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(153, 20)
        Me.txtNombre.TabIndex = 20
        '
        'txtCURP
        '
        Me.txtCURP.Location = New System.Drawing.Point(182, 63)
        Me.txtCURP.Name = "txtCURP"
        Me.txtCURP.Size = New System.Drawing.Size(153, 20)
        Me.txtCURP.TabIndex = 19
        '
        'lblFechaNaciemiento
        '
        Me.lblFechaNaciemiento.AutoSize = True
        Me.lblFechaNaciemiento.Location = New System.Drawing.Point(61, 174)
        Me.lblFechaNaciemiento.Name = "lblFechaNaciemiento"
        Me.lblFechaNaciemiento.Size = New System.Drawing.Size(106, 13)
        Me.lblFechaNaciemiento.TabIndex = 18
        Me.lblFechaNaciemiento.Text = "Fecha de nacimiento"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(61, 133)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(49, 13)
        Me.lblApellido.TabIndex = 17
        Me.lblApellido.Text = "Apellidos"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(61, 99)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 16
        Me.lblNombre.Text = "Nombre"
        '
        'lblInformacionPersonal
        '
        Me.lblInformacionPersonal.AutoSize = True
        Me.lblInformacionPersonal.Location = New System.Drawing.Point(125, 20)
        Me.lblInformacionPersonal.Name = "lblInformacionPersonal"
        Me.lblInformacionPersonal.Size = New System.Drawing.Size(105, 13)
        Me.lblInformacionPersonal.TabIndex = 15
        Me.lblInformacionPersonal.Text = "Información personal"
        '
        'lblCURP
        '
        Me.lblCURP.AutoSize = True
        Me.lblCURP.Location = New System.Drawing.Point(61, 63)
        Me.lblCURP.Name = "lblCURP"
        Me.lblCURP.Size = New System.Drawing.Size(37, 13)
        Me.lblCURP.TabIndex = 7
        Me.lblCURP.Text = "CURP"
        '
        'btnAceptarEmrpesa
        '
        Me.btnAceptarEmrpesa.Location = New System.Drawing.Point(593, 842)
        Me.btnAceptarEmrpesa.Name = "btnAceptarEmrpesa"
        Me.btnAceptarEmrpesa.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarEmrpesa.TabIndex = 2
        Me.btnAceptarEmrpesa.Text = "Aceptar"
        Me.btnAceptarEmrpesa.UseVisualStyleBackColor = True
        '
        'btnCancelarEmpresa
        '
        Me.btnCancelarEmpresa.Location = New System.Drawing.Point(700, 842)
        Me.btnCancelarEmpresa.Name = "btnCancelarEmpresa"
        Me.btnCancelarEmpresa.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarEmpresa.TabIndex = 3
        Me.btnCancelarEmpresa.Text = "Cancelar"
        Me.btnCancelarEmpresa.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAgregarEmpresa)
        Me.Panel2.Controls.Add(Me.txtRFC)
        Me.Panel2.Controls.Add(Me.txtRegistroPatronal)
        Me.Panel2.Controls.Add(Me.txtRazonSocial)
        Me.Panel2.Controls.Add(Me.lblFOpreaciones)
        Me.Panel2.Controls.Add(Me.lblRFC)
        Me.Panel2.Controls.Add(Me.lblRegistroPatronal)
        Me.Panel2.Controls.Add(Me.lblRazonSocial)
        Me.Panel2.Controls.Add(Me.lblEmpresa)
        Me.Panel2.Location = New System.Drawing.Point(468, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 243)
        Me.Panel2.TabIndex = 4
        '
        'txtRFC
        '
        Me.txtRFC.Location = New System.Drawing.Point(125, 129)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(182, 20)
        Me.txtRFC.TabIndex = 7
        '
        'txtRegistroPatronal
        '
        Me.txtRegistroPatronal.Location = New System.Drawing.Point(125, 96)
        Me.txtRegistroPatronal.Name = "txtRegistroPatronal"
        Me.txtRegistroPatronal.Size = New System.Drawing.Size(182, 20)
        Me.txtRegistroPatronal.TabIndex = 6
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(125, 57)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(182, 20)
        Me.txtRazonSocial.TabIndex = 5
        '
        'lblFOpreaciones
        '
        Me.lblFOpreaciones.AutoSize = True
        Me.lblFOpreaciones.Location = New System.Drawing.Point(21, 169)
        Me.lblFOpreaciones.Name = "lblFOpreaciones"
        Me.lblFOpreaciones.Size = New System.Drawing.Size(125, 13)
        Me.lblFOpreaciones.TabIndex = 4
        Me.lblFOpreaciones.Text = "Fecha inicio operaciones"
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Location = New System.Drawing.Point(21, 136)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(28, 13)
        Me.lblRFC.TabIndex = 3
        Me.lblRFC.Text = "RFC"
        '
        'lblRegistroPatronal
        '
        Me.lblRegistroPatronal.AutoSize = True
        Me.lblRegistroPatronal.Location = New System.Drawing.Point(18, 99)
        Me.lblRegistroPatronal.Name = "lblRegistroPatronal"
        Me.lblRegistroPatronal.Size = New System.Drawing.Size(88, 13)
        Me.lblRegistroPatronal.TabIndex = 2
        Me.lblRegistroPatronal.Text = "Registro Patronal"
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Location = New System.Drawing.Point(18, 64)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(68, 13)
        Me.lblRazonSocial.TabIndex = 1
        Me.lblRazonSocial.Text = "Razón social"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Location = New System.Drawing.Point(122, 19)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(120, 13)
        Me.lblEmpresa.TabIndex = 0
        Me.lblEmpresa.Text = "Información de empresa"
        '
        'btnAgregarEmpresa
        '
        Me.btnAgregarEmpresa.Location = New System.Drawing.Point(232, 203)
        Me.btnAgregarEmpresa.Name = "btnAgregarEmpresa"
        Me.btnAgregarEmpresa.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregarEmpresa.TabIndex = 8
        Me.btnAgregarEmpresa.Text = "Agregar"
        Me.btnAgregarEmpresa.UseVisualStyleBackColor = True
        '
        'agregarEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 877)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnCancelarEmpresa)
        Me.Controls.Add(Me.btnAceptarEmrpesa)
        Me.Controls.Add(Me.panelGerenteNomina)
        Me.Controls.Add(Me.panelDomFiscal)
        Me.Name = "agregarEmpresa"
        Me.Text = "agregarEmpresa"
        Me.panelDomFiscal.ResumeLayout(False)
        Me.panelDomFiscal.PerformLayout()
        Me.panelGerenteNomina.ResumeLayout(False)
        Me.panelGerenteNomina.PerformLayout()
        Me.panelBanco.ResumeLayout(False)
        Me.panelBanco.PerformLayout()
        Me.panelAgregarGerente.ResumeLayout(False)
        Me.panelAgregarGerente.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelDomFiscal As Panel
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblCodigoPostal As Label
    Friend WithEvents lblMunicipio As Label
    Friend WithEvents lblColonia As Label
    Friend WithEvents lblCalle As Label
    Friend WithEvents lblDomFiscal As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtCodigoPostal As TextBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents panelGerenteNomina As Panel
    Friend WithEvents panelBanco As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtBanco As TextBox
    Friend WithEvents lblNombreBanco As Label
    Friend WithEvents lblAgregarBanco As Label
    Friend WithEvents txtEstadoG As TextBox
    Friend WithEvents lblEstadoGerente As Label
    Friend WithEvents txtCodigoPostalG As TextBox
    Friend WithEvents lblDomicilioGerente As Label
    Friend WithEvents txtMunicipioG As TextBox
    Friend WithEvents txtColoniaG As TextBox
    Friend WithEvents lblCodigoPostalGerente As Label
    Friend WithEvents txtCalleG As TextBox
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents lblMunicipioGerente As Label
    Friend WithEvents lblColoniaGerente As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents lblCalleGerente As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCURP As TextBox
    Friend WithEvents lblFechaNaciemiento As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblInformacionPersonal As Label
    Friend WithEvents btnAgregarBanco As Button
    Friend WithEvents cbBanco As ComboBox
    Friend WithEvents txtNomina As TextBox
    Friend WithEvents txtNSS As TextBox
    Friend WithEvents txtSalarioD As TextBox
    Friend WithEvents txtNoCuenta As TextBox
    Friend WithEvents txtRFCgerente As TextBox
    Friend WithEvents lblCURP As Label
    Friend WithEvents lblNomina As Label
    Friend WithEvents lblBanco As Label
    Friend WithEvents lblNSS As Label
    Friend WithEvents lblSalarioD As Label
    Friend WithEvents lblNoCuenta As Label
    Friend WithEvents lblRFCgerente As Label
    Friend WithEvents lblGerente As Label
    Friend WithEvents btnAceptarInfoP As Button
    Friend WithEvents panelAgregarGerente As Panel
    Friend WithEvents btnAceptarEmrpesa As Button
    Friend WithEvents btnCancelarEmpresa As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblFOpreaciones As Label
    Friend WithEvents lblRFC As Label
    Friend WithEvents lblRegistroPatronal As Label
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents txtRegistroPatronal As TextBox
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents btnAgregarEmpresa As Button
End Class
