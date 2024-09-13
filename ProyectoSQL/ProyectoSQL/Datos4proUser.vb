Imports System.Runtime.Remoting.Messaging
Imports MySql.Data.MySqlClient

Module Datos4progUser
    ' Crea una nueva conexión a la base de datos
    Public cone4progUser As New MySqlConnection("Server=127.0.0.1; Database=4pro; Uid=root; Pwd= ")
    ' Declara variables para el lector de datos y el comando
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand
End Module

Public Class Datos4proUser
    Private Sub CargarDatos()
        ' Limpia los items y columnas del ListView
        ListView1.Items.Clear()
        ListView1.Columns.Clear()
        ' Configura las columnas del ListView
        ListView1.Columns.Add("N. Matricula", 100)
        ListView1.Columns.Add("RUT", 150)
        ListView1.Columns.Add("Nombres", 150)
        ListView1.Columns.Add("Apellido Pat", 100)
        ListView1.Columns.Add("Apellido Mat", 150)
        ListView1.Columns.Add("F. Nacimiento", 150)
        ListView1.Columns.Add("Direccion", 100)
        ListView1.Columns.Add("Email", 150)
        ListView1.Columns.Add("N. Celular", 150)
        ListView1.Columns.Add("Rut (Apo)", 150)
        ListView1.Columns.Add("Nombres (Apo)", 150)
        ListView1.Columns.Add("Apellido Pat (Apo)", 100)
        ListView1.Columns.Add("Apellido Mat (Apo)", 150)
        ListView1.Columns.Add("N. Celular (Apo)", 150)

        ' Crea un nuevo comando para la base de datos
        Dim cmd As New MySqlCommand("SELECT Matricula, Rut, Nombres, ApellidoP, ApellidoM, FNacimiento, Direccion, Email, NCelular, RutA, NombresA, ApellidoPA, ApellidoMA, NCelularA FROM datos_liceo", cone4progUser)
        Try
            ' Abre la conexión si está cerrada
            If cone4progUser.State = ConnectionState.Closed Then
                cone4progUser.Open()
            End If

            ' Ejecuta el comando y lee los datos
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Agrega los datos leídos al ListView
            While dr.Read()
                Dim item As New ListViewItem(dr("Matricula").ToString())
                item.SubItems.Add(dr("Rut").ToString())
                item.SubItems.Add(dr("Nombres").ToString())
                item.SubItems.Add(dr("ApellidoP").ToString())
                item.SubItems.Add(dr("ApellidoM").ToString())
                item.SubItems.Add(dr("FNacimiento").ToString())
                item.SubItems.Add(dr("Direccion").ToString())
                item.SubItems.Add(dr("Email").ToString())
                item.SubItems.Add(dr("NCelular").ToString())
                item.SubItems.Add(dr("RutA").ToString())
                item.SubItems.Add(dr("NombresA").ToString())
                item.SubItems.Add(dr("ApellidoPA").ToString())
                item.SubItems.Add(dr("ApellidoMA").ToString())
                item.SubItems.Add(dr("NCelularA").ToString())
                ListView1.Items.Add(item)
            End While
            ' Cierra el lector de datos
            dr.Close()
        Catch ex As Exception
            ' Manejo de errores al cargar los datos
            MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cierra la conexión si está abierta
            If cone4progUser.State = ConnectionState.Open Then
                cone4progUser.Close()
            End If
        End Try
    End Sub

    Private Sub Insertar()
        ' Verifica que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(Matricula.Text) OrElse String.IsNullOrWhiteSpace(Rut.Text) OrElse String.IsNullOrWhiteSpace(Nombres.Text) OrElse String.IsNullOrWhiteSpace(FNacimiento.Text) OrElse String.IsNullOrWhiteSpace(ApellidoP.Text) OrElse String.IsNullOrWhiteSpace(ApellidoM.Text) OrElse String.IsNullOrWhiteSpace(Direccion.Text) OrElse String.IsNullOrWhiteSpace(Email.Text) OrElse String.IsNullOrWhiteSpace(NCelular.Text) Then
            Dim Adver4proUser As New Adver4proUser()
            Adver4proUser.Show()
            Me.Hide()
            Return
        End If

        ' Verifica el formato del RUT
        If Not System.Text.RegularExpressions.Regex.IsMatch(Rut.Text, "^\d{8}-\d$") Or Not System.Text.RegularExpressions.Regex.IsMatch(RutA.Text, "^\d{8}-\d$") Then
            Dim ErrorFormatoMaUser As New ErrorFormatoMaUser()
            ErrorFormatoMaUser.Show()
            Me.Hide()
            Return
        End If

        ' Abre la conexión si está cerrada
        If cone4progUser.State = ConnectionState.Closed Then
            cone4progUser.Open()
        End If

        ' Crea un nuevo comando para la base de datos
        Dim cmd As New MySqlCommand("INSERT INTO datos_liceo(Matricula,Rut,Nombres,ApellidoP,ApellidoM,FNacimiento,Direccion,Email,NCelular,RutA,NombresA,ApellidoPA,ApellidoMA,NCelularA) VALUES(@Matricula, @Rut, @Nombres, @ApellidoP, @ApellidoM, @FNacimiento, @Direccion, @Email, @NCelular, @RutA, @NombresA, @ApellidoPA, @ApellidoMA, @NCelularA)", cone4progUser)
        ' Agrega parámetros al comando
        cmd.Parameters.AddWithValue("@Matricula", Matricula.Text)
        cmd.Parameters.AddWithValue("@Rut", Rut.Text)
        cmd.Parameters.AddWithValue("@Nombres", CapitalizarPrimeraLetra(Nombres.Text))
        cmd.Parameters.AddWithValue("@ApellidoP", CapitalizarPrimeraLetra(ApellidoP.Text))
        cmd.Parameters.AddWithValue("@ApellidoM", CapitalizarPrimeraLetra(ApellidoM.Text))
        cmd.Parameters.AddWithValue("@FNacimiento", FNacimiento.Text)
        cmd.Parameters.AddWithValue("@Direccion", CapitalizarPrimeraLetra(Direccion.Text))
        cmd.Parameters.AddWithValue("@Email", Email.Text)
        cmd.Parameters.AddWithValue("@NCelular", NCelular.Text)
        cmd.Parameters.AddWithValue("@RutA", RutA.Text)
        cmd.Parameters.AddWithValue("@NombresA", CapitalizarPrimeraLetra(NombresA.Text))
        cmd.Parameters.AddWithValue("@ApellidoPA", CapitalizarPrimeraLetra(ApellidoPA.Text))
        cmd.Parameters.AddWithValue("@ApellidoMA", CapitalizarPrimeraLetra(ApellidoMA.Text))
        cmd.Parameters.AddWithValue("@NCelularA", NCelularA.Text)
        Try
            ' Ejecuta el comando
            cmd.ExecuteNonQuery()
            ' Muestra mensaje de éxito
            Dim DatosIns4proUser As New DatosIns4proUser()
            DatosIns4proUser.Show()
            Me.Hide()
        Catch ex As MySqlException
            ' Manejo de errores al insertar datos
            If ex.Number = 1062 Then
                Dim ErrorMatriUser As New ErrorMatriUser()
                ErrorMatriUser.Show()
                Me.Hide()
            End If
        Finally
            ' Cierra la conexión si está abierta
            If cone4progUser.State = ConnectionState.Open Then
                cone4progUser.Close()
            End If
        End Try
    End Sub

    ' Convierte la primera letra de un texto en mayúscula y el resto en minúscula
    Private Function CapitalizarPrimeraLetra(texto As String) As String
        If String.IsNullOrEmpty(texto) Then
            Return texto
        End If
        Return Char.ToUpper(texto(0)) & texto.Substring(1).ToLower()
    End Function

    ' Botón para insertar los datos
    Private Sub SiticoneRoundedButton3_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton3.Click
        ' Llamada al método Insertar
        Call Insertar()
    End Sub

    ' Botón para cerrar la aplicación
    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        Application.Exit()
    End Sub

    ' Botón para minimizar la ventana
    Private Sub SiticoneButton2_Click(sender As Object, e As EventArgs) Handles SiticoneButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Botón para limpiar los campos de texto del estudiante
    Private Sub SiticoneRoundedButton2_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton2.Click
        Matricula.Text = ""
        Rut.Text = ""
        Nombres.Text = ""
        FNacimiento.Text = ""
        ApellidoP.Text = ""
        ApellidoM.Text = ""
        Direccion.Text = ""
        Email.Text = ""
        NCelular.Text = ""
    End Sub

    ' Botón para limpiar los campos de texto del apoderado
    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        RutA.Text = ""
        NombresA.Text = ""
        ApellidoPA.Text = ""
        ApellidoMA.Text = ""
        NCelularA.Text = ""
    End Sub

    ' Carga los datos al ListView al abrir el formulario
    Private Sub Datos4proUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    ' Botón para abrir el menú
    Private Sub SiticoneRoundedButton5_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton5.Click
        Dim MenuUser As New MenuUser()
        MenuUser.Show()
        Me.Hide()
    End Sub
End Class