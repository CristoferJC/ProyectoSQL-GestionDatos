Public Class MenuUser
    ' Botón para cerrar la aplicación
    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        Application.Exit()
    End Sub

    ' Botón para minimizar la ventana
    Private Sub SiticoneButton2_Click(sender As Object, e As EventArgs) Handles SiticoneButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Botón para abrir la ventana de información del usuario
    Private Sub SiticoneButton5_Click(sender As Object, e As EventArgs) Handles SiticoneButton5.Click
        Dim InfoUser As New InfoUser()
        InfoUser.Show()
        Me.Hide()
    End Sub

    ' Botón para abrir la ventana de datos del usuario
    Private Sub SiticoneButton3_Click(sender As Object, e As EventArgs) Handles SiticoneButton3.Click
        Dim DatosUser As New DatosUser()
        DatosUser.Show()
        Me.Hide()
    End Sub

    ' Botón para abrir la ventana de datos 4pro
    Private Sub SiticoneButton4_Click(sender As Object, e As EventArgs) Handles SiticoneButton4.Click
        Dim Datos4proUser As New Datos4proUser()
        Datos4proUser.Show()
        Me.Hide()
    End Sub

    ' Botón para volver a la pantalla de inicio de sesión
    Private Sub SiticoneButton7_Click(sender As Object, e As EventArgs) Handles SiticoneButton7.Click
        Dim Login As New Login()
        Login.Show()
        Me.Hide()
    End Sub
End Class