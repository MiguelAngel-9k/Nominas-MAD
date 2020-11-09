Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Fill_ComboBox()

    End Sub

    Private Sub Fill_ComboBox()
        Perfiles.Items.Add("Empleado")
        Perfiles.Items.Add("Gerente General")
        Perfiles.Items.Add("Gerente de nomina")
        Perfiles.Items.Add("Gerente de Departamento")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Me.Hide()
        'obtengo y valido la informacion para buscar en la base de datos
        'Número de empleado, contraseña y tipo de empleado

        Dim con As connexion = New connexion()
        con.iniciar_sesion(Convert.ToDecimal(No_empleado.Text), Contrasenia.Text)


        Dim seleccion = Perfiles.SelectedIndex
        Select Case seleccion
            Case 0 'Pantalla de Empleado'
            Case 1 'Pantalla de Gerente General
                Gerente_General_Nomina.ShowDialog()
            Case 3 'Pantalla de Gerente de nomina
            Case 4 'Pantalla de Gerente de Departamento
        End Select
        'Form1.ShowDialog()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Canel_Click(sender As Object, e As EventArgs) Handles Canel.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class