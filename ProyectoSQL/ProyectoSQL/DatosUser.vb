Imports System.Runtime.Remoting.Messaging
Imports MySql.Data.MySqlClient

Module LogeoUser
    ' Crea una nueva conexión a la base de datos
    Public coneUser As New MySqlConnection("Server=127.0.0.1; Database=4pro; Uid=root; Pwd= ")
    ' Declara variables para el lector de datos y el comando
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand
End Module

Public Class DatosUser
    Private Sub CargarDatos()
        ' Limpia los items y columnas del ListView
        ListView1.Items.Clear()
        ListView1.Columns.Clear()

        ' Configura las columnas del ListView
        ListView1.Columns.Add("RUT", 100)
        ListView1.Columns.Add("Nombre", 150)
        ListView1.Columns.Add("Apellido", 150)

        ' Crea un nuevo comando para la base de datos
        Dim cmd As New MySqlCommand("SELECT rut, nombre, apellido FROM datos_personales", coneUser)
        Try
            ' Abre la conexión si está cerrada
            If coneUser.State = ConnectionState.Closed Then
                coneUser.Open()
            End If

            ' Ejecuta el comando y lee los datos
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Agrega los datos leídos al ListView
            While dr.Read()
                Dim item As New ListViewItem(dr("rut").ToString())
                item.SubItems.Add(dr("nombre").ToString())
                item.SubItems.Add(dr("apellido").ToString())
                ListView1.Items.Add(item)
            End While

            ' Cierra el lector de datos
            dr.Close()
        Catch ex As Exception
            ' Muestra un mensaje de error si ocurre una excepción
            MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cierra la conexión si está abierta
            If coneUser.State = ConnectionState.Open Then
                coneUser.Close()
            End If
        End Try
    End Sub
    Private Sub Insertar()
        ' Verifica que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(TextRut.Text) OrElse String.IsNullOrWhiteSpace(TextNombre.Text) OrElse String.IsNullOrWhiteSpace(TextApellido.Text) Then
            Dim AdverUser As New AdverUser()
            AdverUser.Show()
            Me.Hide()
            Return
        End If

        ' Verifica el formato del RUT
        If Not System.Text.RegularExpressions.Regex.IsMatch(TextRut.Text, "^\d{8}-\d$") Then
            Dim ErrorFormatoUser As New ErrorFormatoUser()
            ErrorFormatoUser.Show()
            Me.Hide()
            Return
        End If

        ' Abre la conexión si está cerrada
        If coneUser.State = ConnectionState.Closed Then
            coneUser.Open()
        End If

        ' Convierte la primera letra a mayúscula y el resto a minúsculas
        Dim nombreFormateado As String = StrConv(TextNombre.Text.Trim(), VbStrConv.ProperCase)
        Dim apellidoFormateado As String = StrConv(TextApellido.Text.Trim(), VbStrConv.ProperCase)

        ' Crea un nuevo comando para la base de datos
        Dim cmd As New MySqlCommand("INSERT INTO datos_personales(Rut,Nombre,Apellido) VALUES(@Rut, @Nombre, @Apellido)", coneUser)
        cmd.Parameters.AddWithValue("@Rut", TextRut.Text)
        cmd.Parameters.AddWithValue("@Nombre", nombreFormateado)
        cmd.Parameters.AddWithValue("@Apellido", apellidoFormateado)
        Try
            ' Ejecuta el comando
            cmd.ExecuteNonQuery()
            ' Muestra mensaje de éxito
            Dim DatosInsUser As New DatosInsUser()
            DatosInsUser.Show()
            Me.Hide()
        Catch ex As MySqlException
            ' Advertencia si el RUT ya existe
            If ex.Number = 1062 Then
                Dim ErrorRUTUser As New ErrorRUTUser()
                ErrorRUTUser.Show()
                Me.Hide()
            Else
                MsgBox("Error al insertar datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End If
        Finally
            ' Cierra la conexión si está abierta
            If coneUser.State = ConnectionState.Open Then
                coneUser.Close()
            End If
        End Try
    End Sub

    ' Botón para insertar datos
    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        ' Llama al método Insertar
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

    ' Botón para abrir el menú
    Private Sub SiticoneRoundedButton5_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton5.Click
        Dim MenuUser As New MenuUser()
        MenuUser.Show()
        Me.Hide()
    End Sub

    ' Botón para limpiar los campos de texto
    Private Sub SiticoneRoundedButton2_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton2.Click
        TextRut.Text = ""
        TextNombre.Text = ""
        TextApellido.Text = ""
    End Sub

    ' Botón para cerrar la aplicación
    Private Sub SiticoneRoundedButton4_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton4.Click
        Application.Exit()
    End Sub

    ' Carga los datos al ListView al abrir el formulario
    Private Sub DatosUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub
End Class