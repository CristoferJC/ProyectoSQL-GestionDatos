﻿Public Class ErrorFormatoMa
    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        Application.Exit()
    End Sub

    Private Sub SiticoneRoundedButton4_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton4.Click
        Dim Datos4pro As New Datos4pro()
        Datos4pro.Show()
        Me.Hide()
    End Sub
End Class