Public Class ConfEliminarAdmin
    Public Property Respuesta As DialogResult

    Private Sub SiticoneRoundedButton2_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton2.Click
        Respuesta = DialogResult.No
        Me.Close()
    End Sub

    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        Respuesta = DialogResult.Yes
        Me.Close()
    End Sub
End Class