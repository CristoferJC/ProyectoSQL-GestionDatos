Public Class DatosInsAdmin
    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        Dim DatosAdmin As New DatosAdmin()
        DatosAdmin.Show()
        Me.Hide()
    End Sub
End Class