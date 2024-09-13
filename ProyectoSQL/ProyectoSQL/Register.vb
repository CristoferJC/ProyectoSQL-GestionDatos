Imports MySql.Data.MySqlClient

' Módulo para manejar la conexión a la base de datos
Module Registro
    ' Cadena de conexión a la base de datos MySQL
    Public coneReg As New MySqlConnection("Server=127.0.0.1; Database=4pro; Uid=root; Pwd= ")
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand
End Module

Public Class Register
    ' Botón para cerrar la aplicación
    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        Application.Exit()
    End Sub

    ' Botón para minimizar la ventana
    Private Sub SiticoneButton2_Click(sender As Object, e As EventArgs) Handles SiticoneButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Etiqueta para volver a la pantalla de inicio de sesión
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Login As New Login()
        Login.Show()
        Me.Hide()
    End Sub

    ' Botón para registrar un nuevo usuario
    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        ' Verifica si los campos de usuario y contraseña están vacíos
        If String.IsNullOrWhiteSpace(TextUser.Text) OrElse String.IsNullOrWhiteSpace(TextPass.Text) Then
            Dim AdverReg As New AdverReg()
            AdverReg.Show()
            Me.Hide()
            Return
        End If

        ' Abre la conexión si está cerrada
        If coneReg.State = ConnectionState.Closed Then
            coneReg.Open()
        End If

        ' Prepara la consulta SQL para insertar el nuevo usuario
        Dim cmd As New MySqlCommand("INSERT INTO login(user, pass) VALUES(@user, @pass)", coneReg)
        cmd.Parameters.AddWithValue("@user", TextUser.Text)
        cmd.Parameters.AddWithValue("@pass", TextPass.Text)

        Try
            ' Ejecuta la consulta
            cmd.ExecuteNonQuery()
            ' Muestra el mensaje de éxito
            Dim DatosInsReg As New DatosInsReg()
            DatosInsReg.Show()
            Me.Hide()
        Catch ex As MySqlException
            ' Maneja el error de usuarios duplicados
            If ex.Number = 1062 Then
                Dim ErrorReg As New ErrorReg()
                ErrorReg.Show()
                Me.Hide()
            Else
                ' Muestra otros errores
                MsgBox("Error al insertar datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End If
        Finally
            ' Cierra la conexión si está abierta
            If coneReg.State = ConnectionState.Open Then
                coneReg.Close()
            End If
        End Try
    End Sub

    ' Configuración inicial del formulario
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establece el carácter de contraseña
        TextPass.PasswordChar = "•"c
    End Sub

    ' Botón para mostrar/ocultar la contraseña
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ' Cambia el carácter de contraseña
        If TextPass.PasswordChar = "•"c Then
            TextPass.PasswordChar = ControlChars.NullChar
        Else
            ' Restaura el carácter de contraseña
            TextPass.PasswordChar = "•"c
        End If
    End Sub
End Class