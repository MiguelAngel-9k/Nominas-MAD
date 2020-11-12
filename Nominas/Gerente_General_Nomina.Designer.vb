<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerente_General_Nomina
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeEmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeGerentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NominaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NominasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeadcounterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NóminaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NominasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeduccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersepcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.PanelHeadcounterReporte = New System.Windows.Forms.Panel()
        Me.PuestosGrid = New System.Windows.Forms.DataGridView()
        Me.DepartamentosGrid = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregarEmpleado = New System.Windows.Forms.Button()
        Me.NominaGeneralPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbReporteFiltro = New System.Windows.Forms.ComboBox()
        Me.EmpleadosGrid = New System.Windows.Forms.DataGridView()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lbEmpresa = New System.Windows.Forms.Label()
        Me.PanelGeneralReporte = New System.Windows.Forms.Panel()
        Me.reporteGeneralGrid = New System.Windows.Forms.DataGridView()
        Me.PanelNominaPuesto = New System.Windows.Forms.Panel()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.lblIncidencias = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.lblDeducciones = New System.Windows.Forms.Label()
        Me.PanelPuestoInfo = New System.Windows.Forms.Panel()
        Me.txtSueldoBase = New System.Windows.Forms.TextBox()
        Me.txtEmpleadosNomina = New System.Windows.Forms.TextBox()
        Me.txtGerenteNomina = New System.Windows.Forms.TextBox()
        Me.lblGerenteDepartamento = New System.Windows.Forms.Label()
        Me.lblSueldoBase = New System.Windows.Forms.Label()
        Me.lblEmpleadosPuesto = New System.Windows.Forms.Label()
        Me.lblDepartamentoNomina = New System.Windows.Forms.Label()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.Nomina_departamentos = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAgregarEmpresa = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeadcounterReporte.SuspendLayout()
        CType(Me.PuestosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NominaGeneralPanel.SuspendLayout()
        CType(Me.EmpleadosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGeneralReporte.SuspendLayout()
        CType(Me.reporteGeneralGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNominaPuesto.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPuestoInfo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresasToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.NominasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeEmpresasToolStripMenuItem, Me.ListadoDeGerentesToolStripMenuItem, Me.NominasToolStripMenuItem1})
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.EmpresasToolStripMenuItem.Text = "Empresas"
        '
        'ListadoDeEmpresasToolStripMenuItem
        '
        Me.ListadoDeEmpresasToolStripMenuItem.Name = "ListadoDeEmpresasToolStripMenuItem"
        Me.ListadoDeEmpresasToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ListadoDeEmpresasToolStripMenuItem.Text = "Listado de empresas"
        '
        'ListadoDeGerentesToolStripMenuItem
        '
        Me.ListadoDeGerentesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NominaToolStripMenuItem, Me.DepartamentoToolStripMenuItem})
        Me.ListadoDeGerentesToolStripMenuItem.Name = "ListadoDeGerentesToolStripMenuItem"
        Me.ListadoDeGerentesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ListadoDeGerentesToolStripMenuItem.Text = "Listado de Gerentes"
        '
        'NominaToolStripMenuItem
        '
        Me.NominaToolStripMenuItem.Name = "NominaToolStripMenuItem"
        Me.NominaToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NominaToolStripMenuItem.Text = "Nomina"
        '
        'DepartamentoToolStripMenuItem
        '
        Me.DepartamentoToolStripMenuItem.Name = "DepartamentoToolStripMenuItem"
        Me.DepartamentoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DepartamentoToolStripMenuItem.Text = "Departamento"
        '
        'NominasToolStripMenuItem1
        '
        Me.NominasToolStripMenuItem1.Name = "NominasToolStripMenuItem1"
        Me.NominasToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.NominasToolStripMenuItem1.Text = "Nominas"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HeadcounterToolStripMenuItem, Me.GeneralToolStripMenuItem, Me.NóminaToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'HeadcounterToolStripMenuItem
        '
        Me.HeadcounterToolStripMenuItem.Name = "HeadcounterToolStripMenuItem"
        Me.HeadcounterToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.HeadcounterToolStripMenuItem.Text = "Headcounter"
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'NóminaToolStripMenuItem
        '
        Me.NóminaToolStripMenuItem.Name = "NóminaToolStripMenuItem"
        Me.NóminaToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.NóminaToolStripMenuItem.Text = "Nómina"
        '
        'NominasToolStripMenuItem
        '
        Me.NominasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentoToolStripMenuItem1, Me.DeduccionesToolStripMenuItem, Me.PersepcionesToolStripMenuItem})
        Me.NominasToolStripMenuItem.Name = "NominasToolStripMenuItem"
        Me.NominasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.NominasToolStripMenuItem.Text = "Nominas"
        '
        'DepartamentoToolStripMenuItem1
        '
        Me.DepartamentoToolStripMenuItem1.Name = "DepartamentoToolStripMenuItem1"
        Me.DepartamentoToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.DepartamentoToolStripMenuItem1.Text = "Departamento"
        '
        'DeduccionesToolStripMenuItem
        '
        Me.DeduccionesToolStripMenuItem.Name = "DeduccionesToolStripMenuItem"
        Me.DeduccionesToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DeduccionesToolStripMenuItem.Text = "Deducciones"
        '
        'PersepcionesToolStripMenuItem
        '
        Me.PersepcionesToolStripMenuItem.Name = "PersepcionesToolStripMenuItem"
        Me.PersepcionesToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PersepcionesToolStripMenuItem.Text = "Persepciones"
        '
        'ListadoGrid
        '
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Location = New System.Drawing.Point(12, 132)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.Size = New System.Drawing.Size(776, 306)
        Me.ListadoGrid.TabIndex = 1
        '
        'PanelHeadcounterReporte
        '
        Me.PanelHeadcounterReporte.Controls.Add(Me.NominaGeneralPanel)
        Me.PanelHeadcounterReporte.Controls.Add(Me.PuestosGrid)
        Me.PanelHeadcounterReporte.Controls.Add(Me.DepartamentosGrid)
        Me.PanelHeadcounterReporte.Controls.Add(Me.Label1)
        Me.PanelHeadcounterReporte.Location = New System.Drawing.Point(355, 419)
        Me.PanelHeadcounterReporte.Name = "PanelHeadcounterReporte"
        Me.PanelHeadcounterReporte.Size = New System.Drawing.Size(800, 428)
        Me.PanelHeadcounterReporte.TabIndex = 2
        '
        'PuestosGrid
        '
        Me.PuestosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PuestosGrid.Location = New System.Drawing.Point(370, 39)
        Me.PuestosGrid.Name = "PuestosGrid"
        Me.PuestosGrid.Size = New System.Drawing.Size(418, 306)
        Me.PuestosGrid.TabIndex = 2
        '
        'DepartamentosGrid
        '
        Me.DepartamentosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DepartamentosGrid.Location = New System.Drawing.Point(12, 39)
        Me.DepartamentosGrid.Name = "DepartamentosGrid"
        Me.DepartamentosGrid.Size = New System.Drawing.Size(274, 306)
        Me.DepartamentosGrid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(642, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Soy el panel de head counter"
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(651, 93)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(137, 23)
        Me.btnAgregarEmpleado.TabIndex = 3
        Me.btnAgregarEmpleado.Text = "Agregar Empleado"
        Me.btnAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'NominaGeneralPanel
        '
        Me.NominaGeneralPanel.Controls.Add(Me.PanelGeneralReporte)
        Me.NominaGeneralPanel.Controls.Add(Me.Label2)
        Me.NominaGeneralPanel.Controls.Add(Me.cbReporteFiltro)
        Me.NominaGeneralPanel.Controls.Add(Me.EmpleadosGrid)
        Me.NominaGeneralPanel.Controls.Add(Me.lblDepartamento)
        Me.NominaGeneralPanel.Controls.Add(Me.ComboBox2)
        Me.NominaGeneralPanel.Controls.Add(Me.ComboBox1)
        Me.NominaGeneralPanel.Controls.Add(Me.lbEmpresa)
        Me.NominaGeneralPanel.Location = New System.Drawing.Point(425, 351)
        Me.NominaGeneralPanel.Name = "NominaGeneralPanel"
        Me.NominaGeneralPanel.Size = New System.Drawing.Size(800, 468)
        Me.NominaGeneralPanel.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Filtrar por:"
        '
        'cbReporteFiltro
        '
        Me.cbReporteFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbReporteFiltro.FormattingEnabled = True
        Me.cbReporteFiltro.Location = New System.Drawing.Point(12, 54)
        Me.cbReporteFiltro.Name = "cbReporteFiltro"
        Me.cbReporteFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cbReporteFiltro.TabIndex = 5
        '
        'EmpleadosGrid
        '
        Me.EmpleadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosGrid.Location = New System.Drawing.Point(12, 99)
        Me.EmpleadosGrid.Name = "EmpleadosGrid"
        Me.EmpleadosGrid.Size = New System.Drawing.Size(776, 271)
        Me.EmpleadosGrid.TabIndex = 4
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(612, 24)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.lblDepartamento.TabIndex = 3
        Me.lblDepartamento.Text = "Departamento"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(612, 54)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(484, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'lbEmpresa
        '
        Me.lbEmpresa.AutoSize = True
        Me.lbEmpresa.Location = New System.Drawing.Point(481, 25)
        Me.lbEmpresa.Name = "lbEmpresa"
        Me.lbEmpresa.Size = New System.Drawing.Size(48, 13)
        Me.lbEmpresa.TabIndex = 0
        Me.lbEmpresa.Text = "Empresa"
        '
        'PanelGeneralReporte
        '
        Me.PanelGeneralReporte.Controls.Add(Me.PanelNominaPuesto)
        Me.PanelGeneralReporte.Controls.Add(Me.reporteGeneralGrid)
        Me.PanelGeneralReporte.Location = New System.Drawing.Point(524, 391)
        Me.PanelGeneralReporte.Name = "PanelGeneralReporte"
        Me.PanelGeneralReporte.Size = New System.Drawing.Size(800, 481)
        Me.PanelGeneralReporte.TabIndex = 4
        '
        'reporteGeneralGrid
        '
        Me.reporteGeneralGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.reporteGeneralGrid.Location = New System.Drawing.Point(12, 129)
        Me.reporteGeneralGrid.Name = "reporteGeneralGrid"
        Me.reporteGeneralGrid.Size = New System.Drawing.Size(776, 269)
        Me.reporteGeneralGrid.TabIndex = 0
        '
        'PanelNominaPuesto
        '
        Me.PanelNominaPuesto.Controls.Add(Me.DataGridView3)
        Me.PanelNominaPuesto.Controls.Add(Me.lblIncidencias)
        Me.PanelNominaPuesto.Controls.Add(Me.DataGridView2)
        Me.PanelNominaPuesto.Controls.Add(Me.lblDeducciones)
        Me.PanelNominaPuesto.Controls.Add(Me.PanelPuestoInfo)
        Me.PanelNominaPuesto.Controls.Add(Me.lblDepartamentoNomina)
        Me.PanelNominaPuesto.Controls.Add(Me.cbDepartamento)
        Me.PanelNominaPuesto.Controls.Add(Me.Nomina_departamentos)
        Me.PanelNominaPuesto.Controls.Add(Me.DataGridView1)
        Me.PanelNominaPuesto.Location = New System.Drawing.Point(484, 112)
        Me.PanelNominaPuesto.Name = "PanelNominaPuesto"
        Me.PanelNominaPuesto.Size = New System.Drawing.Size(800, 488)
        Me.PanelNominaPuesto.TabIndex = 1
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(306, 350)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(270, 61)
        Me.DataGridView3.TabIndex = 8
        '
        'lblIncidencias
        '
        Me.lblIncidencias.AutoSize = True
        Me.lblIncidencias.Location = New System.Drawing.Point(303, 333)
        Me.lblIncidencias.Name = "lblIncidencias"
        Me.lblIncidencias.Size = New System.Drawing.Size(70, 13)
        Me.lblIncidencias.TabIndex = 7
        Me.lblIncidencias.Text = "Deducciones"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(306, 246)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(270, 67)
        Me.DataGridView2.TabIndex = 6
        '
        'lblDeducciones
        '
        Me.lblDeducciones.AutoSize = True
        Me.lblDeducciones.Location = New System.Drawing.Point(307, 228)
        Me.lblDeducciones.Name = "lblDeducciones"
        Me.lblDeducciones.Size = New System.Drawing.Size(70, 13)
        Me.lblDeducciones.TabIndex = 5
        Me.lblDeducciones.Text = "Deducciones"
        '
        'PanelPuestoInfo
        '
        Me.PanelPuestoInfo.Controls.Add(Me.txtSueldoBase)
        Me.PanelPuestoInfo.Controls.Add(Me.txtEmpleadosNomina)
        Me.PanelPuestoInfo.Controls.Add(Me.txtGerenteNomina)
        Me.PanelPuestoInfo.Controls.Add(Me.lblGerenteDepartamento)
        Me.PanelPuestoInfo.Controls.Add(Me.lblSueldoBase)
        Me.PanelPuestoInfo.Controls.Add(Me.lblEmpleadosPuesto)
        Me.PanelPuestoInfo.Location = New System.Drawing.Point(306, 96)
        Me.PanelPuestoInfo.Name = "PanelPuestoInfo"
        Me.PanelPuestoInfo.Size = New System.Drawing.Size(481, 115)
        Me.PanelPuestoInfo.TabIndex = 4
        '
        'txtSueldoBase
        '
        Me.txtSueldoBase.Location = New System.Drawing.Point(162, 74)
        Me.txtSueldoBase.Name = "txtSueldoBase"
        Me.txtSueldoBase.Size = New System.Drawing.Size(108, 20)
        Me.txtSueldoBase.TabIndex = 7
        '
        'txtEmpleadosNomina
        '
        Me.txtEmpleadosNomina.Location = New System.Drawing.Point(162, 47)
        Me.txtEmpleadosNomina.Name = "txtEmpleadosNomina"
        Me.txtEmpleadosNomina.ReadOnly = True
        Me.txtEmpleadosNomina.Size = New System.Drawing.Size(36, 20)
        Me.txtEmpleadosNomina.TabIndex = 6
        '
        'txtGerenteNomina
        '
        Me.txtGerenteNomina.Location = New System.Drawing.Point(162, 18)
        Me.txtGerenteNomina.Name = "txtGerenteNomina"
        Me.txtGerenteNomina.ReadOnly = True
        Me.txtGerenteNomina.Size = New System.Drawing.Size(217, 20)
        Me.txtGerenteNomina.TabIndex = 5
        '
        'lblGerenteDepartamento
        '
        Me.lblGerenteDepartamento.AutoSize = True
        Me.lblGerenteDepartamento.Location = New System.Drawing.Point(28, 25)
        Me.lblGerenteDepartamento.Name = "lblGerenteDepartamento"
        Me.lblGerenteDepartamento.Size = New System.Drawing.Size(45, 13)
        Me.lblGerenteDepartamento.TabIndex = 4
        Me.lblGerenteDepartamento.Text = "Gerente"
        '
        'lblSueldoBase
        '
        Me.lblSueldoBase.AutoSize = True
        Me.lblSueldoBase.Location = New System.Drawing.Point(28, 81)
        Me.lblSueldoBase.Name = "lblSueldoBase"
        Me.lblSueldoBase.Size = New System.Drawing.Size(66, 13)
        Me.lblSueldoBase.TabIndex = 3
        Me.lblSueldoBase.Text = "Sueldo base"
        '
        'lblEmpleadosPuesto
        '
        Me.lblEmpleadosPuesto.AutoSize = True
        Me.lblEmpleadosPuesto.Location = New System.Drawing.Point(28, 54)
        Me.lblEmpleadosPuesto.Name = "lblEmpleadosPuesto"
        Me.lblEmpleadosPuesto.Size = New System.Drawing.Size(118, 13)
        Me.lblEmpleadosPuesto.TabIndex = 2
        Me.lblEmpleadosPuesto.Text = "Cantidad de empleados"
        '
        'lblDepartamentoNomina
        '
        Me.lblDepartamentoNomina.AutoSize = True
        Me.lblDepartamentoNomina.Location = New System.Drawing.Point(303, 50)
        Me.lblDepartamentoNomina.Name = "lblDepartamentoNomina"
        Me.lblDepartamentoNomina.Size = New System.Drawing.Size(74, 13)
        Me.lblDepartamentoNomina.TabIndex = 3
        Me.lblDepartamentoNomina.Text = "Departamento"
        '
        'cbDepartamento
        '
        Me.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(383, 50)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(121, 21)
        Me.cbDepartamento.TabIndex = 2
        '
        'Nomina_departamentos
        '
        Me.Nomina_departamentos.AutoSize = True
        Me.Nomina_departamentos.Location = New System.Drawing.Point(112, 71)
        Me.Nomina_departamentos.Name = "Nomina_departamentos"
        Me.Nomina_departamentos.Size = New System.Drawing.Size(45, 13)
        Me.Nomina_departamentos.TabIndex = 1
        Me.Nomina_departamentos.Text = "Puestos"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(274, 304)
        Me.DataGridView1.TabIndex = 0
        '
        'btnAgregarEmpresa
        '
        Me.btnAgregarEmpresa.Location = New System.Drawing.Point(509, 93)
        Me.btnAgregarEmpresa.Name = "btnAgregarEmpresa"
        Me.btnAgregarEmpresa.Size = New System.Drawing.Size(136, 23)
        Me.btnAgregarEmpresa.TabIndex = 5
        Me.btnAgregarEmpresa.Text = "Agregar Empresa"
        Me.btnAgregarEmpresa.UseVisualStyleBackColor = True
        '
        'Gerente_General_Nomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 520)
        Me.Controls.Add(Me.PanelHeadcounterReporte)
        Me.Controls.Add(Me.ListadoGrid)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnAgregarEmpleado)
        Me.Controls.Add(Me.btnAgregarEmpresa)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Gerente_General_Nomina"
        Me.Text = "Gerente General Nomina"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeadcounterReporte.ResumeLayout(False)
        Me.PanelHeadcounterReporte.PerformLayout()
        CType(Me.PuestosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NominaGeneralPanel.ResumeLayout(False)
        Me.NominaGeneralPanel.PerformLayout()
        CType(Me.EmpleadosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGeneralReporte.ResumeLayout(False)
        CType(Me.reporteGeneralGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNominaPuesto.ResumeLayout(False)
        Me.PanelNominaPuesto.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPuestoInfo.ResumeLayout(False)
        Me.PanelPuestoInfo.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NominasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeEmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeGerentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NominasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NominaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoGrid As DataGridView
    Friend WithEvents PanelHeadcounterReporte As Panel
    Friend WithEvents HeadcounterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NóminaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentosGrid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregarEmpleado As Button
    Friend WithEvents NominaGeneralPanel As Panel
    Friend WithEvents PuestosGrid As DataGridView
    Friend WithEvents lbEmpresa As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbReporteFiltro As ComboBox
    Friend WithEvents EmpleadosGrid As DataGridView
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PanelGeneralReporte As Panel
    Friend WithEvents reporteGeneralGrid As DataGridView
    Friend WithEvents DepartamentoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeduccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersepcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelNominaPuesto As Panel
    Friend WithEvents PanelPuestoInfo As Panel
    Friend WithEvents lblGerenteDepartamento As Label
    Friend WithEvents lblSueldoBase As Label
    Friend WithEvents lblEmpleadosPuesto As Label
    Friend WithEvents lblDepartamentoNomina As Label
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents Nomina_departamentos As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblDeducciones As Label
    Friend WithEvents txtSueldoBase As TextBox
    Friend WithEvents txtEmpleadosNomina As TextBox
    Friend WithEvents txtGerenteNomina As TextBox
    Friend WithEvents lblIncidencias As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents btnAgregarEmpresa As Button
End Class
