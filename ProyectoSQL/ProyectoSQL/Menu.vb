Public Class Menu
    ' Botón para cerrar la aplicación
    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        Application.Exit()
    End Sub

    ' Botón para minimizar la ventana
    Private Sub SiticoneButton2_Click(sender As Object, e As EventArgs) Handles SiticoneButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Botón para abrir el formulario Datos
    Private Sub SiticoneButton3_Click(sender As Object, e As EventArgs) Handles SiticoneButton3.Click
        Dim Datos As New Datos()
        Datos.Show()
        Me.Hide()
    End Sub

    ' Botón para abrir el formulario Datos4pro
    Private Sub SiticoneButton4_Click(sender As Object, e As EventArgs) Handles SiticoneButton4.Click
        Dim Datos4pro As New Datos4pro()
        Datos4pro.Show()
        Me.Hide()
    End Sub

    ' Botón para abrir el formulario Info
    Private Sub SiticoneButton5_Click(sender As Object, e As EventArgs) Handles SiticoneButton5.Click
        Dim Info As New Info()
        Info.Show()
        Me.Hide()
    End Sub

    ' Botón para abrir el formulario DatosAdmin
    Private Sub SiticoneButton6_Click(sender As Object, e As EventArgs) Handles SiticoneButton6.Click
        Dim DatosAdmin As New DatosAdmin()
        DatosAdmin.Show()
        Me.Hide()
    End Sub

    ' Botón para abrir el formulario Login
    Private Sub SiticoneButton7_Click(sender As Object, e As EventArgs) Handles SiticoneButton7.Click
        Dim Login As New Login()
        Login.Show()
        Me.Hide()
    End Sub
End Class