Public Class ErrorMatriUser
    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        Application.Exit()
    End Sub

    Private Sub SiticoneRoundedButton4_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton4.Click
        Dim Datos4proUser As New Datos4proUser()
        Datos4proUser.Show()
        Me.Hide()
    End Sub
End Class