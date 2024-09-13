Public Class DatosInsUser
    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        Dim DatosUser As New DatosUser()
        DatosUser.Show()
        Me.Hide()
    End Sub
End Class