Public Class ConfEliminar4pro
    Public Property Respuesta4pro As DialogResult

    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        Respuesta4pro = DialogResult.Yes
        Me.Close()
    End Sub
    Private Sub SiticoneRoundedButton2_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton2.Click
        Respuesta4pro = DialogResult.No
        Me.Close()
    End Sub
End Class