Imports MySql.Data.MySqlClient

' Módulo para la conexión a la base de datos
Module Logeo1
    ' Cadena de conexión a la base de datos MySQL
    Public con As New MySqlConnection("Server=127.0.0.1; Database=4pro; Uid=root; Pwd= ")
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand
End Module

Public Class Login
    ' Botón para cerrar la aplicación
    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        Application.Exit()
    End Sub

    ' Botón para minimizar la ventana
    Private Sub SiticoneButton2_Click(sender As Object, e As EventArgs) Handles SiticoneButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Botón de inicio de sesión
    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        ' Verifica si los campos de usuario y contraseña están vacíos
        If Trim(SiticoneRoundedTextBox1.Text) = "" Or Trim(SiticoneRoundedTextBox2.Text) = "" Then
            Dim Errorv As New Errorv()
            Errorv.Show()
            Me.Hide()
        Else
            ' Intenta iniciar sesión
            con.Open()
            Dim sql = "SELECT * FROM login WHERE user = @user AND pass = @pass"
            Dim cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@user", SiticoneRoundedTextBox1.Text)
            cmd.Parameters.AddWithValue("@pass", SiticoneRoundedTextBox2.Text)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            Try
                If dr.Read Then
                    ' Si las credenciales son correctas, verifica el tipo de usuario
                    Select Case dr("user").ToString().ToLower()
                        Case "admin"
                            Dim Correcto As New Correcto()
                            Correcto.Show()
                            Me.Hide()
                        Case Else
                            Dim CorrectoUser As New CorrectoUser()
                            CorrectoUser.Show()
                            Me.Hide()
                    End Select
                    Me.Hide()
                Else
                    ' Si las credenciales son incorrectas, muestra un error
                    Dim ErrorIn As New ErrorIn()
                    ErrorIn.Show()
                    Me.Hide()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    ' Enlace para ir a la pantalla de registro
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Register As New Register()
        Register.Show()
        Me.Hide()
    End Sub

    ' Configuración inicial del formulario
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establece el carácter de contraseña
        SiticoneRoundedTextBox2.PasswordChar = "•"c
    End Sub

    ' Botón para mostrar/ocultar la contraseña
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ' Cambia el carácter de contraseña
        If SiticoneRoundedTextBox2.PasswordChar = "•"c Then
            SiticoneRoundedTextBox2.PasswordChar = ControlChars.NullChar
        Else
            ' Restaura el carácter de contraseña
            SiticoneRoundedTextBox2.PasswordChar = "•"c
        End If
    End Sub
End Class
