Imports System.Runtime.Remoting.Messaging
Imports MySql.Data.MySqlClient

Module Admin
    Public coneAdmin As New MySqlConnection("Server=127.0.0.1; Database=4pro; Uid=root; Pwd= ")
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand
End Module

Public Class DatosAdmin
    Private Sub CargarDatos()
        ListView1.CheckBoxes = True
        ListView1.Items.Clear()
        ListView1.Columns.Clear()

        ListView1.Columns.Add("Usuario", 150)
        ListView1.Columns.Add("Contraseña", 150)

        Dim cmd As New MySqlCommand("SELECT * FROM login", coneAdmin)
        Try
            If coneAdmin.State = ConnectionState.Closed Then
                coneAdmin.Open()
            End If

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(dr("user").ToString())
                item.SubItems.Add(dr("pass").ToString())
                ListView1.Items.Add(item)
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If coneAdmin.State = ConnectionState.Open Then
                coneAdmin.Close()
            End If
        End Try
    End Sub

    Private Sub Insertar()
        If String.IsNullOrWhiteSpace(TextUser.Text) OrElse String.IsNullOrWhiteSpace(TextPass.Text) Then
            Dim AdverAdmin As New AdverAdmin()
            AdverAdmin.Show()
            Me.Hide()
            Return
        End If

        If coneAdmin.State = ConnectionState.Closed Then
            coneAdmin.Open()
        End If

        Dim cmd As New MySqlCommand("INSERT INTO login(user, pass) VALUES(@user, @pass)", coneAdmin)
        cmd.Parameters.AddWithValue("@user", TextUser.Text)
        cmd.Parameters.AddWithValue("@pass", TextPass.Text)

        Try
            cmd.ExecuteNonQuery()
            Dim DatosInsAdmin As New DatosInsAdmin()
            DatosInsAdmin.Show()
            Me.Hide()
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                Dim ErrorUser As New ErrorUser()
                ErrorUser.Show()
                Me.Hide()
            Else
                MsgBox("Error al insertar datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End If
        Finally
            If coneAdmin.State = ConnectionState.Open Then
                coneAdmin.Close()
            End If
        End Try
    End Sub

    Private Sub EliminarDatosSeleccionados()
        If ListView1.CheckedItems.Count = 0 Then
            Dim SelDatoAdmin As New SelDatoAdmin()
            SelDatoAdmin.Show()
            Me.Hide()
            Return
        End If

        Dim ConfEliminarAdmin As New ConfEliminarAdmin()
        ConfEliminarAdmin.ShowDialog()

        If ConfEliminarAdmin.Respuesta = DialogResult.Yes Then
            If coneAdmin.State = ConnectionState.Closed Then
                coneAdmin.Open()
            End If

            Try
                For Each item As ListViewItem In ListView1.CheckedItems
                    Dim rutSeleccionado As String = item.Text
                    Dim cmd As New MySqlCommand("DELETE FROM login WHERE user = @user", coneAdmin)
                    cmd.Parameters.AddWithValue("@user", rutSeleccionado)
                    cmd.ExecuteNonQuery()
                Next

                Dim DatosBorrAdmin As New DatosBorrAdmin()
                DatosBorrAdmin.Show()
                Me.Hide()
                CargarDatos()
            Catch ex As Exception
                MsgBox("Error al eliminar los registros: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                If coneAdmin.State = ConnectionState.Open Then
                    coneAdmin.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        Application.Exit()
    End Sub

    Private Sub SiticoneButton2_Click(sender As Object, e As EventArgs) Handles SiticoneButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SiticoneRoundedButton5_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton5.Click
        Dim Menu As New Menu()
        Menu.Show()
        Me.Hide()
    End Sub

    Private Sub DatosAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        Call Insertar()
    End Sub

    Private Sub SiticoneRoundedButton3_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton3.Click
        EliminarDatosSeleccionados()
    End Sub

    Private Sub SeleccionarTodos(seleccionar As Boolean)
        For Each item As ListViewItem In ListView1.Items
            item.Checked = seleccionar
        Next
    End Sub

    Private Sub SiticoneCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles SiticoneCheckBox1.CheckedChanged
        SeleccionarTodos(SiticoneCheckBox1.Checked)
    End Sub
End Class