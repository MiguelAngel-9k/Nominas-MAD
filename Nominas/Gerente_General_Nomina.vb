Public Class Gerente_General_Nomina
    Private Sub Gerente_General_Nomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelHeadcounterReporte.Hide()
        NominaGeneralPanel.Hide()
        PanelGeneralReporte.Hide()
        PanelNominaPuesto.Hide()

        cbReporteFiltro.Items.Add("Empresa")
        cbReporteFiltro.Items.Add("Año-Mes")

    End Sub
    Private Sub ListadoDeEmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeEmpresasToolStripMenuItem.Click
        'Listado se empresas en el grid
        PanelHeadcounterReporte.Hide()
    End Sub

    Private Sub NominaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NominaToolStripMenuItem.Click
        'Listado de nominas
        'PanelHeadcounterReporte.Hide()
    End Sub

    Private Sub DepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentoToolStripMenuItem.Click
        'Listado de Departamentos ESTA POR VERSE
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click

    End Sub

    Private Sub HeadcounterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HeadcounterToolStripMenuItem.Click
        NominaGeneralPanel.Hide()
        PanelGeneralReporte.Hide()
        PanelHeadcounterReporte.Show()
    End Sub

    Private Sub EmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem.Click

    End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralToolStripMenuItem.Click
        PanelHeadcounterReporte.Hide()
        PanelGeneralReporte.Hide()
        NominaGeneralPanel.Show()
    End Sub

    Private Sub NóminaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NóminaToolStripMenuItem.Click
        PanelHeadcounterReporte.Hide()
        NominaGeneralPanel.Hide()
        PanelGeneralReporte.Show()
    End Sub

    Private Sub lblSueldoBase_Click(sender As Object, e As EventArgs) Handles lblSueldoBase.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblDeducciones.Click

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles lblIncidencias.Click

    End Sub

    Private Sub btnAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpleado.Click

    End Sub

    Private Sub btnAgregarEmpresa_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpresa.Click
        Me.Enabled = False
        agregarEmpresa.ShowDialog()
    End Sub
End Class