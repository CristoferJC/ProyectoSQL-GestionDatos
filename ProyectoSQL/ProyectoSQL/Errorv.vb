Public Class Errorv
    Private Sub SiticoneRoundedButton4_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton4.Click
        Dim Login As New Login()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        Application.Exit()
    End Sub
End Class