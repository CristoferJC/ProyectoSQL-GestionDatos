Imports MySql.Data.MySqlClient
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing

Module Logeo
    ' Crear una nueva conexión a la base de datos
    Public cone As New MySqlConnection("Server=127.0.0.1; Database=4pro; Uid=root; Pwd= ")
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand
End Module

Public Class Datos
    ' Limpia los campos de texto y restaura el botón de inserción
    Private Sub SiticoneRoundedButton2_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton2.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        TextRut.Text = ""
        TextNombre.Text = ""
        TextApellido.Text = ""
        SiticoneRoundedButton1.Text = "Agregar"
    End Sub

    ' Boton para cerrar la aplicación
    Private Sub SiticoneRoundedButton4_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton4.Click
        Application.Exit()
    End Sub

    ' Boton para cerrar la aplicación
    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        Application.Exit()
    End Sub

    ' Boton para minimizar la ventana
    Private Sub SiticoneButton2_Click(sender As Object, e As EventArgs) Handles SiticoneButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Carga los datos
    Private Sub CargarDatos()
        ' Configura la vista del ListView
        ListView1.CheckBoxes = True
        ListView1.Items.Clear()
        ListView1.Columns.Clear()

        ' Agrega columnas a la vista del ListView
        ListView1.Columns.Add("RUT", 100)
        ListView1.Columns.Add("Nombre", 150)
        ListView1.Columns.Add("Apellido", 150)

        ' Crea un nuevo comando para la base de datos
        Dim cmd As New MySqlCommand("SELECT rut, nombre, apellido FROM datos_personales", cone)
        Try
            ' Abre la conexión si está cerrada
            If cone.State = ConnectionState.Closed Then
                cone.Open()
            End If

            ' Ejecuta el comando y lee los datos
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Agrega los datos a la vista del ListView
            While dr.Read()
                Dim item As New ListViewItem(dr("rut").ToString())
                item.SubItems.Add(dr("nombre").ToString())
                item.SubItems.Add(dr("apellido").ToString())
                ListView1.Items.Add(item)
            End While

            ' Cierra el lector de datos
            dr.Close()
        Catch ex As Exception
            ' Muestra un mensaje de error si ocurre una excepción
            MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cierra la conexión si está abierta
            If cone.State = ConnectionState.Open Then
                cone.Close()
            End If
        End Try
    End Sub

    Private Sub Insertar()
        ' Verifica que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(TextRut.Text) OrElse String.IsNullOrWhiteSpace(TextNombre.Text) OrElse String.IsNullOrWhiteSpace(TextApellido.Text) Then
            Dim Adver As New Adver()
            Adver.Show()
            Me.Hide()
            Return
        End If

        ' Verifica el formato del RUT
        If Not System.Text.RegularExpressions.Regex.IsMatch(TextRut.Text, "^\d{8}-[\dkK]$") Then
            Dim ErrorFormato As New ErrorFormato()
            ErrorFormato.Show()
            Me.Hide()
            Return
        End If

        ' Abre la conexión si está cerrada
        If cone.State = ConnectionState.Closed Then
            cone.Open()
        End If

        ' Convierte la primera letra a mayúscula y el resto a minúsculas
        Dim nombreFormateado As String = StrConv(TextNombre.Text.Trim(), VbStrConv.ProperCase)
        Dim apellidoFormateado As String = StrConv(TextApellido.Text.Trim(), VbStrConv.ProperCase)

        ' Crea un nuevo comando para la base de datos
        Dim cmd As New MySqlCommand("INSERT INTO datos_personales(Rut,Nombre,Apellido) VALUES(@Rut, @Nombre, @Apellido)", cone)
        cmd.Parameters.AddWithValue("@Rut", TextRut.Text)
        cmd.Parameters.AddWithValue("@Nombre", nombreFormateado)
        cmd.Parameters.AddWithValue("@Apellido", apellidoFormateado)

        ' Intenta ejecutar el comando
        Try
            cmd.ExecuteNonQuery()
            Dim DatosIns As New DatosIns()
            DatosIns.Show()
            Me.Hide()
        Catch ex As MySqlException
            ' Maneja el error de RUT duplicado
            If ex.Number = 1062 Then
                Dim ErrorRUT As New ErrorRUT()
                ErrorRUT.Show()
                Me.Hide()
            Else
                MsgBox("Error al insertar datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End If
        Finally
            ' Cierra la conexión si está abierta
            If cone.State = ConnectionState.Open Then
                cone.Close()
            End If
        End Try
    End Sub

    Private Sub EliminarDatosSeleccionados()
        ' Verifica que se haya seleccionado al menos un dato
        If ListView1.CheckedItems.Count = 0 Then
            Dim SelDato As New SelDato()
            SelDato.Show()
            Me.Hide()
            Return
        End If

        ' Muestra un cuadro de diálogo para confirmar la eliminación
        Dim ConfEliminar As New ConfEliminar()
        ConfEliminar.ShowDialog()

        ' Si se confirma la eliminación, proceder
        If ConfEliminar.Respuesta = DialogResult.Yes Then
            ' Abre la conexión si está cerrada
            If cone.State = ConnectionState.Closed Then
                cone.Open()
            End If

            ' Intenta eliminar los datos
            Try
                For Each item As ListViewItem In ListView1.CheckedItems
                    Dim rutSeleccionado As String = item.Text
                    Dim cmd As New MySqlCommand("DELETE FROM datos_personales WHERE Rut = @Rut", cone)
                    cmd.Parameters.AddWithValue("@Rut", rutSeleccionado)
                    cmd.ExecuteNonQuery()
                Next

                ' Muestra un mensaje de éxito y recarga los datos
                Dim DatosBorr As New DatosBorr()
                DatosBorr.Show()
                Me.Hide()
                CargarDatos()
            Catch ex As Exception
                MsgBox("Error al eliminar los registros: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                ' Cierra la conexión si está abierta
                If cone.State = ConnectionState.Open Then
                    cone.Close()
                End If
            End Try
        End If
    End Sub

    ' Llama al metodo eliminar al botón
    Private Sub SiticoneRoundedButton3_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton3.Click
        EliminarDatosSeleccionados()
    End Sub

    ' Llama al metodo insertar al botón
    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        If SiticoneRoundedButton1.Text = "Agregar" Then
            Call Insertar()
        Else
            Call ActualizarDatos()
        End If
    End Sub

    ' Carga los datos al ListView al abrir el formulario
    Private Sub Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    ' Boton para abrir el menú
    Private Sub SiticoneRoundedButton5_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton5.Click
        Dim Menu As New Menu()
        Menu.Show()
        Me.Hide()
    End Sub

    ' CheckBox para seleccionar todos los datos del ListView
    Private Sub SeleccionarTodos(seleccionar As Boolean)
        For Each item As ListViewItem In ListView1.Items
            item.Checked = seleccionar
        Next
    End Sub

    ' Llama al metodo seleccionar todos al CheckBox
    Private Sub SiticoneCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles SiticoneCheckBox1.CheckedChanged
        SeleccionarTodos(SiticoneCheckBox1.Checked)
    End Sub

    Private Sub buscar_TextChanged(sender As Object, e As EventArgs) Handles buscar.TextChanged
        ' Obtener el texto de búsqueda del TextBox
        Dim textoBusqueda As String = buscar.Text.Trim()

        ' Limpiar los resultados anteriores
        ListView1.Items.Clear()

        ' Si el texto de búsqueda está vacío, mostrar todos los registros
        If String.IsNullOrEmpty(textoBusqueda) Then
            CargarDatos()
            Return
        End If

        ' Crear la consulta SQL
        Dim consulta As String = "SELECT * FROM datos_personales WHERE rut LIKE @busqueda OR nombre LIKE @busqueda OR apellido LIKE @busqueda"

        ' Crear el comando y establecer los parámetros
        Using cmd As New MySqlCommand(consulta, cone)
            cmd.Parameters.AddWithValue("@busqueda", "%" & textoBusqueda & "%")

            Try
                ' Abrir la conexión si está cerrada
                If cone.State = ConnectionState.Closed Then
                    cone.Open()
                End If

                ' Ejecutar la consulta y obtener los resultados
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Mostrar los resultados en el ListView
                While reader.Read()
                    Dim item As New ListViewItem(reader("rut").ToString())
                    item.SubItems.Add(reader("nombre").ToString())
                    item.SubItems.Add(reader("apellido").ToString())
                    ListView1.Items.Add(item)
                End While

                ' Cerrar el reader
                reader.Close()
            Finally
                ' Cerrar la conexión si está abierta
                If cone.State = ConnectionState.Open Then
                    cone.Close()
                End If
            End Try
        End Using
    End Sub

    Private Sub GenerarPDF()
        Dim documento As New PdfDocument()
        Dim pagina As PdfPage = documento.AddPage()
        Dim gfx As XGraphics = XGraphics.FromPdfPage(pagina)
        Dim fuente As New XFont("Arial", 12)

        ' Agrega encabezados al PDF
        gfx.DrawString("RUT", fuente, XBrushes.Black, New XRect(40, 10, pagina.Width, 20), XStringFormats.TopLeft)
        gfx.DrawString("Nombre", fuente, XBrushes.Black, New XRect(130, 10, pagina.Width, 20), XStringFormats.TopLeft)
        gfx.DrawString("Apellido", fuente, XBrushes.Black, New XRect(230, 10, pagina.Width, 20), XStringFormats.TopLeft)

        Dim y As Integer = 40
        Dim numeroFila As Integer = 1

        For Each item As ListViewItem In ListView1.Items
            gfx.DrawString(numeroFila.ToString(), fuente, XBrushes.Black, New XRect(10, y, pagina.Width, 20), XStringFormats.TopLeft)
            gfx.DrawString(item.SubItems(0).Text, fuente, XBrushes.Black, New XRect(40, y, pagina.Width, 20), XStringFormats.TopLeft)
            gfx.DrawString(item.SubItems(1).Text, fuente, XBrushes.Black, New XRect(130, y, pagina.Width, 20), XStringFormats.TopLeft)
            gfx.DrawString(item.SubItems(2).Text, fuente, XBrushes.Black, New XRect(230, y, pagina.Width, 20), XStringFormats.TopLeft)
            y += 20
            numeroFila += 1
        Next

        ' Guardar el documento
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
        saveFileDialog.FileName = "listado.pdf"
        saveFileDialog.Title = "Guardar listado"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            documento.Save(saveFileDialog.FileName)
            MessageBox.Show("PDF generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        GenerarPDF()
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

        ' Cambiar el texto del botón de insertar a "Actualizar"
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

    Private rutOriginal As String

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        EditarDatos()
    End Sub
End Class