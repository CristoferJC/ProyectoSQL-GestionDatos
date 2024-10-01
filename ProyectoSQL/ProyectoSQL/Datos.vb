Imports MySql.Data.MySqlClient
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing

Module Logeo
    Public cone As New MySqlConnection("Server=127.0.0.1; Database=4pro; Uid=root; Pwd= ")
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand
End Module

Public Class Datos
    Private rutOriginal As String

    Private Sub LimpiarCampos()
        TextRut.Text = ""
        TextNombre.Text = ""
        TextApellido.Text = ""
        SiticoneRoundedButton1.Text = "Agregar"
    End Sub

    Private Sub CargarDatos()
        ListView1.CheckBoxes = True
        ListView1.Items.Clear()
        ListView1.Columns.Clear()

        ListView1.Columns.Add("RUT", 100)
        ListView1.Columns.Add("Nombre", 150)
        ListView1.Columns.Add("Apellido", 150)

        Dim cmd As New MySqlCommand("SELECT rut, nombre, apellido FROM datos_personales", cone)
        Try
            If cone.State = ConnectionState.Closed Then
                cone.Open()
            End If

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(dr("rut").ToString())
                item.SubItems.Add(dr("nombre").ToString())
                item.SubItems.Add(dr("apellido").ToString())
                ListView1.Items.Add(item)
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cone.State = ConnectionState.Open Then
                cone.Close()
            End If
        End Try
    End Sub

    Private Sub Insertar()
        If String.IsNullOrWhiteSpace(TextRut.Text) OrElse String.IsNullOrWhiteSpace(TextNombre.Text) OrElse String.IsNullOrWhiteSpace(TextApellido.Text) Then
            Dim Adver As New Adver()
            Adver.Show()
            Me.Hide()
            Return
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(TextRut.Text, "^\d{8}-[\dkK]$") Then
            Dim ErrorFormato As New ErrorFormato()
            ErrorFormato.Show()
            Me.Hide()
            Return
        End If

        If cone.State = ConnectionState.Closed Then
            cone.Open()
        End If

        Dim nombreFormateado As String = StrConv(TextNombre.Text.Trim(), VbStrConv.ProperCase)
        Dim apellidoFormateado As String = StrConv(TextApellido.Text.Trim(), VbStrConv.ProperCase)

        Dim cmd As New MySqlCommand("INSERT INTO datos_personales(Rut,Nombre,Apellido) VALUES(@Rut, @Nombre, @Apellido)", cone)
        cmd.Parameters.AddWithValue("@Rut", TextRut.Text)
        cmd.Parameters.AddWithValue("@Nombre", nombreFormateado)
        cmd.Parameters.AddWithValue("@Apellido", apellidoFormateado)

        Try
            cmd.ExecuteNonQuery()
            Dim DatosIns As New DatosIns()
            DatosIns.Show()
            Me.Hide()
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                Dim ErrorRUT As New ErrorRUT()
                ErrorRUT.Show()
                Me.Hide()
            Else
                MsgBox("Error al insertar datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End If
        Finally
            If cone.State = ConnectionState.Open Then
                cone.Close()
            End If
        End Try
    End Sub

    Private Sub EliminarDatosSeleccionados()
        If ListView1.CheckedItems.Count = 0 Then
            Dim SelDato As New SelDato()
            SelDato.Show()
            Me.Hide()
            Return
        End If

        Dim ConfEliminar As New ConfEliminar()
        ConfEliminar.ShowDialog()

        If ConfEliminar.Respuesta = DialogResult.Yes Then
            If cone.State = ConnectionState.Closed Then
                cone.Open()
            End If

            Try
                For Each item As ListViewItem In ListView1.CheckedItems
                    Dim rutSeleccionado As String = item.Text
                    Dim cmd As New MySqlCommand("DELETE FROM datos_personales WHERE Rut = @Rut", cone)
                    cmd.Parameters.AddWithValue("@Rut", rutSeleccionado)
                    cmd.ExecuteNonQuery()
                Next

                Dim DatosBorr As New DatosBorr()
                DatosBorr.Show()
                Me.Hide()
                CargarDatos()
            Catch ex As Exception
                MsgBox("Error al eliminar los registros: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                If cone.State = ConnectionState.Open Then
                    cone.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub GenerarPDF()
        Dim documento As New PdfDocument()
        Dim pagina As PdfPage = documento.AddPage()
        Dim gfx As XGraphics = XGraphics.FromPdfPage(pagina)
        Dim fuente As New XFont("Arial", 12)
        Dim fuenteTitulo As New XFont("Arial", 14, XFontStyle.Bold)

        gfx.DrawString("Listado de Personas", fuenteTitulo, XBrushes.Black, New XRect(0, 10, pagina.Width.Point, 20), XStringFormats.TopCenter)

        gfx.DrawString("RUT", fuente, XBrushes.Black, New XRect(40, 40, pagina.Width.Point, 20), XStringFormats.TopLeft)
        gfx.DrawString("Nombre", fuente, XBrushes.Black, New XRect(130, 40, pagina.Width.Point, 20), XStringFormats.TopLeft)
        gfx.DrawString("Apellido", fuente, XBrushes.Black, New XRect(230, 40, pagina.Width.Point, 20), XStringFormats.TopLeft)

        Dim y As Double = 70
        Dim numeroFila As Integer = 1

        For Each item As ListViewItem In ListView1.Items
            If y + 20 > pagina.Height.Point - 50 Then
                pagina = documento.AddPage()
                gfx = XGraphics.FromPdfPage(pagina)
                y = 40
                gfx.DrawString("RUT", fuente, XBrushes.Black, New XRect(40, 10, pagina.Width.Point, 20), XStringFormats.TopLeft)
                gfx.DrawString("Nombre", fuente, XBrushes.Black, New XRect(130, 10, pagina.Width.Point, 20), XStringFormats.TopLeft)
                gfx.DrawString("Apellido", fuente, XBrushes.Black, New XRect(230, 10, pagina.Width.Point, 20), XStringFormats.TopLeft)
            End If

            gfx.DrawString(numeroFila.ToString(), fuente, XBrushes.Black, New XRect(10, y, pagina.Width.Point, 20), XStringFormats.TopLeft)
            gfx.DrawString(item.SubItems(0).Text, fuente, XBrushes.Black, New XRect(40, y, pagina.Width.Point, 20), XStringFormats.TopLeft)
            gfx.DrawString(item.SubItems(1).Text, fuente, XBrushes.Black, New XRect(130, y, pagina.Width.Point, 20), XStringFormats.TopLeft)
            gfx.DrawString(item.SubItems(2).Text, fuente, XBrushes.Black, New XRect(230, y, pagina.Width.Point, 20), XStringFormats.TopLeft)
            y += 20
            numeroFila += 1
        Next

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
        saveFileDialog.FileName = "listado_personas.pdf"
        saveFileDialog.Title = "Guardar listado"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            documento.Save(saveFileDialog.FileName)
            MessageBox.Show("PDF generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub EditarDatos()
        If ListView1.SelectedItems.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un registro para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
        rutOriginal = selectedItem.SubItems(0).Text
        TextRut.Text = rutOriginal
        TextNombre.Text = selectedItem.SubItems(1).Text
        TextApellido.Text = selectedItem.SubItems(2).Text

        SiticoneRoundedButton1.Text = "Actualizar"
    End Sub

    Private Sub ActualizarDatos()
        If String.IsNullOrWhiteSpace(TextRut.Text) OrElse String.IsNullOrWhiteSpace(TextNombre.Text) OrElse String.IsNullOrWhiteSpace(TextApellido.Text) Then
            Dim Adver As New Adver()
            Adver.Show()
            Me.Hide()
            Return
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(TextRut.Text, "^\d{8}-\d$") Then
            Dim ErrorRUT As New ErrorRUT()
            ErrorRUT.Show()
            Me.Hide()
            Return
        End If

        Dim nombreFormateado As String = StrConv(TextNombre.Text.Trim(), VbStrConv.ProperCase)
        Dim apellidoFormateado As String = StrConv(TextApellido.Text.Trim(), VbStrConv.ProperCase)

        Dim cmd As New MySqlCommand("UPDATE datos_personales SET Rut = @NuevoRut, Nombre = @Nombre, Apellido = @Apellido WHERE Rut = @RutOriginal", cone)
        cmd.Parameters.AddWithValue("@NuevoRut", TextRut.Text)
        cmd.Parameters.AddWithValue("@Nombre", nombreFormateado)
        cmd.Parameters.AddWithValue("@Apellido", apellidoFormateado)
        cmd.Parameters.AddWithValue("@RutOriginal", rutOriginal)

        Try
            If cone.State = ConnectionState.Closed Then
                cone.Open()
            End If

            cmd.ExecuteNonQuery()
            MessageBox.Show("Datos actualizados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarDatos()
            LimpiarCampos()
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("El nuevo RUT ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Error al actualizar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Finally
            If cone.State = ConnectionState.Open Then
                cone.Close()
            End If
        End Try
    End Sub

    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        If SiticoneRoundedButton1.Text = "Agregar" Then
            Call Insertar()
        Else
            Call ActualizarDatos()
        End If
    End Sub

    Private Sub Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        EditarDatos()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        GenerarPDF()
    End Sub

    Private Sub SiticoneRoundedButton2_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton2.Click
        LimpiarCampos()
    End Sub

    Private Sub SiticoneRoundedButton3_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton3.Click
        EliminarDatosSeleccionados()
    End Sub

    Private Sub SiticoneRoundedButton5_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton5.Click
        Dim Menu As New Menu()
        Menu.Show()
        Me.Hide()
    End Sub

    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        Application.Exit()
    End Sub

    Private Sub SiticoneButton2_Click(sender As Object, e As EventArgs) Handles SiticoneButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SeleccionarTodos(seleccionar As Boolean)
        For Each item As ListViewItem In ListView1.Items
            item.Checked = seleccionar
        Next
    End Sub

    Private Sub SiticoneCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles SiticoneCheckBox1.CheckedChanged
        SeleccionarTodos(SiticoneCheckBox1.Checked)
    End Sub

    Private Sub buscar_TextChanged(sender As Object, e As EventArgs) Handles buscar.TextChanged
        Dim textoBusqueda As String = buscar.Text.Trim()

        ListView1.Items.Clear()

        If String.IsNullOrEmpty(textoBusqueda) Then
            CargarDatos()
            Return
        End If

        Dim consulta As String = "SELECT * FROM datos_personales WHERE rut LIKE @busqueda OR nombre LIKE @busqueda OR apellido LIKE @busqueda"

        Using cmd As New MySqlCommand(consulta, cone)
            cmd.Parameters.AddWithValue("@busqueda", "%" & textoBusqueda & "%")

            Try
                If cone.State = ConnectionState.Closed Then
                    cone.Open()
                End If

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    Dim item As New ListViewItem(reader("rut").ToString())
                    item.SubItems.Add(reader("nombre").ToString())
                    item.SubItems.Add(reader("apellido").ToString())
                    ListView1.Items.Add(item)
                End While

                reader.Close()
            Finally
                If cone.State = ConnectionState.Open Then
                    cone.Close()
                End If
            End Try
        End Using
    End Sub
End Class