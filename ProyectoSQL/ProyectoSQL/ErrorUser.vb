Public Class ErrorUser
    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        Application.Exit()
    End Sub

    Private Sub SiticoneRoundedButton4_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton4.Click
        Dim DatosAdmin As New DatosAdmin()
        DatosAdmin.Show()
        Me.Hide()
    End Sub
End Class