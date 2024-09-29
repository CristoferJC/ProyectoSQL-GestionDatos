Imports System.Runtime.Remoting.Messaging
Imports MySql.Data.MySqlClient
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf

Module Datos4progUser
    ' Crea una nueva conexión a la base de datos
    Public cone4progUser As New MySqlConnection("Server=127.0.0.1; Database=4pro; Uid=root; Pwd= ")
    ' Declara variables para el lector de datos y el comando
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand
End Module

Public Class Datos4proUser
    Private matriculaOriginal As String

    Private Sub CargarDatos()
        ' Limpia los items y columnas del ListView
        ListView1.Items.Clear()
        ListView1.Columns.Clear()
        ' Configura las columnas del ListView
        ListView1.Columns.Add("N. Matricula", 100)
        ListView1.Columns.Add("RUT", 150)
        ListView1.Columns.Add("Nombres", 150)
        ListView1.Columns.Add("Apellido Pat", 100)
        ListView1.Columns.Add("Apellido Mat", 150)
        ListView1.Columns.Add("F. Nacimiento", 150)
        ListView1.Columns.Add("Direccion", 100)
        ListView1.Columns.Add("Email", 150)
        ListView1.Columns.Add("N. Celular", 150)
        ListView1.Columns.Add("Rut (Apo)", 150)
        ListView1.Columns.Add("Nombres (Apo)", 150)
        ListView1.Columns.Add("Apellido Pat (Apo)", 100)
        ListView1.Columns.Add("Apellido Mat (Apo)", 150)
        ListView1.Columns.Add("N. Celular (Apo)", 150)

        ' Crea un nuevo comando para la base de datos
        Dim cmd As New MySqlCommand("SELECT Matricula, Rut, Nombres, ApellidoP, ApellidoM, FNacimiento, Direccion, Email, NCelular, RutA, NombresA, ApellidoPA, ApellidoMA, NCelularA FROM datos_liceo", cone4progUser)
        Try
            ' Abre la conexión si está cerrada
            If cone4progUser.State = ConnectionState.Closed Then
                cone4progUser.Open()
            End If

            ' Ejecuta el comando y lee los datos
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Agrega los datos leídos al ListView
            While dr.Read()
                Dim item As New ListViewItem(dr("Matricula").ToString())
                item.SubItems.Add(dr("Rut").ToString())
                item.SubItems.Add(dr("Nombres").ToString())
                item.SubItems.Add(dr("ApellidoP").ToString())
                item.SubItems.Add(dr("ApellidoM").ToString())
                item.SubItems.Add(dr("FNacimiento").ToString())
                item.SubItems.Add(dr("Direccion").ToString())
                item.SubItems.Add(dr("Email").ToString())
                item.SubItems.Add(dr("NCelular").ToString())
                item.SubItems.Add(dr("RutA").ToString())
                item.SubItems.Add(dr("NombresA").ToString())
                item.SubItems.Add(dr("ApellidoPA").ToString())
                item.SubItems.Add(dr("ApellidoMA").ToString())
                item.SubItems.Add(dr("NCelularA").ToString())
                ListView1.Items.Add(item)
            End While
            ' Cierra el lector de datos
            dr.Close()
        Catch ex As Exception
            ' Manejo de errores al cargar los datos
            MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cierra la conexión si está abierta
            If cone4progUser.State = ConnectionState.Open Then
                cone4progUser.Close()
            End If
        End Try
    End Sub

    Private Sub Insertar()
        ' Verifica que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(Matricula.Text) OrElse String.IsNullOrWhiteSpace(Rut.Text) OrElse String.IsNullOrWhiteSpace(Nombres.Text) OrElse String.IsNullOrWhiteSpace(FNacimiento.Text) OrElse String.IsNullOrWhiteSpace(ApellidoP.Text) OrElse String.IsNullOrWhiteSpace(ApellidoM.Text) OrElse String.IsNullOrWhiteSpace(Direccion.Text) OrElse String.IsNullOrWhiteSpace(Email.Text) OrElse String.IsNullOrWhiteSpace(NCelular.Text) Then
            Dim Adver4proUser As New Adver4proUser()
            Adver4proUser.Show()
            Me.Hide()
            Return
        End If

        ' Verifica el formato del RUT
        If Not System.Text.RegularExpressions.Regex.IsMatch(Rut.Text, "^\d{8}-[\dkK]$") Or Not System.Text.RegularExpressions.Regex.IsMatch(Rut.Text, "^\d{8}-[\dkK]$") Then
            Dim ErrorFormatoMaUser As New ErrorFormatoMaUser()
            ErrorFormatoMaUser.Show()
            Me.Hide()
            Return
        End If

        ' Abre la conexión si está cerrada
        If cone4progUser.State = ConnectionState.Closed Then
            cone4progUser.Open()
        End If

        ' Crea un nuevo comando para la base de datos
        Dim cmd As New MySqlCommand("INSERT INTO datos_liceo(Matricula,Rut,Nombres,ApellidoP,ApellidoM,FNacimiento,Direccion,Email,NCelular,RutA,NombresA,ApellidoPA,ApellidoMA,NCelularA) VALUES(@Matricula, @Rut, @Nombres, @ApellidoP, @ApellidoM, @FNacimiento, @Direccion, @Email, @NCelular, @RutA, @NombresA, @ApellidoPA, @ApellidoMA, @NCelularA)", cone4progUser)
        ' Agrega parámetros al comando
        cmd.Parameters.AddWithValue("@Matricula", Matricula.Text)
        cmd.Parameters.AddWithValue("@Rut", Rut.Text)
        cmd.Parameters.AddWithValue("@Nombres", CapitalizarPrimeraLetra(Nombres.Text))
        cmd.Parameters.AddWithValue("@ApellidoP", CapitalizarPrimeraLetra(ApellidoP.Text))
        cmd.Parameters.AddWithValue("@ApellidoM", CapitalizarPrimeraLetra(ApellidoM.Text))
        cmd.Parameters.AddWithValue("@FNacimiento", FNacimiento.Text)
        cmd.Parameters.AddWithValue("@Direccion", CapitalizarPrimeraLetra(Direccion.Text))
        cmd.Parameters.AddWithValue("@Email", Email.Text)
        cmd.Parameters.AddWithValue("@NCelular", NCelular.Text)
        cmd.Parameters.AddWithValue("@RutA", RutA.Text)
        cmd.Parameters.AddWithValue("@NombresA", CapitalizarPrimeraLetra(NombresA.Text))
        cmd.Parameters.AddWithValue("@ApellidoPA", CapitalizarPrimeraLetra(ApellidoPA.Text))
        cmd.Parameters.AddWithValue("@ApellidoMA", CapitalizarPrimeraLetra(ApellidoMA.Text))
        cmd.Parameters.AddWithValue("@NCelularA", NCelularA.Text)
        Try
            ' Ejecuta el comando
            cmd.ExecuteNonQuery()
            ' Muestra mensaje de éxito
            Dim DatosIns4proUser As New DatosIns4proUser()
            DatosIns4proUser.Show()
            Me.Hide()
        Catch ex As MySqlException
            ' Manejo de errores al insertar datos
            If ex.Number = 1062 Then
                Dim ErrorMatriUser As New ErrorMatriUser()
                ErrorMatriUser.Show()
                Me.Hide()
            End If
        Finally
            ' Cierra la conexión si está abierta
            If cone4progUser.State = ConnectionState.Open Then
                cone4progUser.Close()
            End If
        End Try
    End Sub

    ' Convierte la primera letra de un texto en mayúscula y el resto en minúscula
    Private Function CapitalizarPrimeraLetra(texto As String) As String
        If String.IsNullOrEmpty(texto) Then
            Return texto
        End If
        Return Char.ToUpper(texto(0)) & texto.Substring(1).ToLower()
    End Function

    ' Botón para insertar los datos
    Private Sub SiticoneRoundedButton3_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton3.Click
        If SiticoneRoundedButton3.Text = "Agregar" Then
            Call Insertar()
        Else
            Call ActualizarDatos()
        End If
    End Sub

    ' Botón para cerrar la aplicación
    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        Application.Exit()
    End Sub

    ' Botón para minimizar la ventana
    Private Sub SiticoneButton2_Click(sender As Object, e As EventArgs) Handles SiticoneButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Botón para limpiar los campos de texto del estudiante
    Private Sub SiticoneRoundedButton2_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton2.Click
        Matricula.Text = ""
        Rut.Text = ""
        Nombres.Text = ""
        FNacimiento.Text = ""
        ApellidoP.Text = ""
        ApellidoM.Text = ""
        Direccion.Text = ""
        Email.Text = ""
        NCelular.Text = ""
    End Sub

    ' Botón para limpiar los campos de texto del apoderado
    Private Sub SiticoneRoundedButton1_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton1.Click
        RutA.Text = ""
        NombresA.Text = ""
        ApellidoPA.Text = ""
        ApellidoMA.Text = ""
        NCelularA.Text = ""
    End Sub

    ' Carga los datos al ListView al abrir el formulario
    Private Sub Datos4proUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    ' Botón para abrir el menú
    Private Sub SiticoneRoundedButton5_Click(sender As Object, e As EventArgs) Handles SiticoneRoundedButton5.Click
        Dim MenuUser As New MenuUser()
        MenuUser.Show()
        Me.Hide()
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
        Dim consulta As String = "SELECT * FROM datos_liceo WHERE Matricula LIKE @busqueda OR Rut LIKE @busqueda OR Nombres LIKE @busqueda OR ApellidoP LIKE @busqueda OR ApellidoM LIKE @busqueda"

        ' Crear el comando y establecer los parámetros
        Using cmd As New MySqlCommand(consulta, cone4prog)
            cmd.Parameters.AddWithValue("@busqueda", "%" & textoBusqueda & "%")

            Try
                ' Abrir la conexión si está cerrada
                If cone4prog.State = ConnectionState.Closed Then
                    cone4prog.Open()
                End If

                ' Ejecutar la consulta y obtener los resultados
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Mostrar los resultados en el ListView
                While reader.Read()
                    Dim item As New ListViewItem(reader("Matricula").ToString())
                    item.SubItems.Add(reader("Rut").ToString())
                    item.SubItems.Add(reader("Nombres").ToString())
                    item.SubItems.Add(reader("ApellidoP").ToString())
                    item.SubItems.Add(reader("ApellidoM").ToString())
                    item.SubItems.Add(reader("FNacimiento").ToString())
                    item.SubItems.Add(reader("Direccion").ToString())
                    item.SubItems.Add(reader("Email").ToString())
                    item.SubItems.Add(reader("NCelular").ToString())
                    item.SubItems.Add(reader("RutA").ToString())
                    item.SubItems.Add(reader("NombresA").ToString())
                    item.SubItems.Add(reader("ApellidoPA").ToString())
                    item.SubItems.Add(reader("ApellidoMA").ToString())
                    item.SubItems.Add(reader("NCelularA").ToString())
                    ListView1.Items.Add(item)
                End While

                ' Cerrar el reader
                reader.Close()
            Finally
                ' Cerrar la conexión si está abierta
                If cone4prog.State = ConnectionState.Open Then
                    cone4prog.Close()
                End If
            End Try
        End Using
    End Sub

    Private Sub GenerarPDF()
        Dim documento As New PdfDocument()
        Dim pagina As PdfPage = documento.AddPage()
        Dim gfx As XGraphics = XGraphics.FromPdfPage(pagina)
        Dim fuente As New XFont("Arial", 7)
        Dim fuenteTitulo As New XFont("Arial", 12, XFontStyle.Bold)
        Dim fuenteNumero As New XFont("Arial", 9, XFontStyle.Bold)
        Dim lapizGris As New XPen(XColors.LightGray, 0.5)

        ' Agrega título al PDF
        gfx.DrawString("Listado de Estudiantes y Apoderados", fuenteTitulo, XBrushes.Black, New XRect(10, 10, pagina.Width.Point, 20), XStringFormats.TopCenter)

        Dim y As Double = 40
        Dim x As Double = 10
        Dim anchoColumna As Double = (pagina.Width.Point - 20) / 2 ' 2 columnas por fila

        ' Definir encabezados y datos
        Dim encabezados() As String = {"N. Matrícula", "RUT", "Nombres", "Apellido P", "Apellido M", "F. Nacimiento", "Dirección",
                                       "Email", "N. Celular", "RUT (Apo)", "Nombres (Apo)", "Apellido P (Apo)", "Apellido M (Apo)", "N. Celular (Apo)"}

        ' Contador para enumerar estudiantes
        Dim contadorEstudiantes As Integer = 1

        ' Dibujar encabezados y datos
        For Each item As ListViewItem In ListView1.Items
            ' Dibujar número de estudiante
            gfx.DrawString(contadorEstudiantes.ToString() & ".", fuenteNumero, XBrushes.Black, New XRect(x, y, pagina.Width.Point, 20), XStringFormats.TopLeft)
            y += 20

            For i As Integer = 0 To 13
                Dim columna As Integer = i Mod 2
                Dim xPos As Double = x + (columna * anchoColumna)

                ' Dibujar encabezado y dato
                gfx.DrawString(encabezados(i), fuente, XBrushes.Black, New XRect(xPos, y, anchoColumna, 10), XStringFormats.TopLeft)
                gfx.DrawString(item.SubItems(i).Text, fuente, XBrushes.Black, New XRect(xPos, y + 10, anchoColumna, 10), XStringFormats.TopLeft)

                ' Dibujar línea de separación después de cada dato
                gfx.DrawLine(lapizGris, x, y + 25, pagina.Width.Point - 10, y + 25)

                ' Si es la segunda columna, pasar a la siguiente fila
                If columna = 1 Then
                    y += 30
                End If
            Next

            ' Agregar espacio extra después de cada estudiante
            y += 20

            ' Incrementar el contador de estudiantes
            contadorEstudiantes += 1

            ' Si llegamos al final de la página, creamos una nueva
            If y >= pagina.Height.Point - 40 Then
                pagina = documento.AddPage()
                gfx = XGraphics.FromPdfPage(pagina)
                y = 20
            End If
        Next

        ' Guardar el documento
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
        saveFileDialog.FileName = "listado_estudiantes_apoderados.pdf"
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
        matriculaOriginal = selectedItem.SubItems(0).Text
        Matricula.Text = matriculaOriginal
        Rut.Text = selectedItem.SubItems(1).Text
        Nombres.Text = selectedItem.SubItems(2).Text
        ApellidoP.Text = selectedItem.SubItems(3).Text
        ApellidoM.Text = selectedItem.SubItems(4).Text
        FNacimiento.Text = selectedItem.SubItems(5).Text
        Direccion.Text = selectedItem.SubItems(6).Text
        Email.Text = selectedItem.SubItems(7).Text
        NCelular.Text = selectedItem.SubItems(8).Text
        RutA.Text = selectedItem.SubItems(9).Text
        NombresA.Text = selectedItem.SubItems(10).Text
        ApellidoPA.Text = selectedItem.SubItems(11).Text
        ApellidoMA.Text = selectedItem.SubItems(12).Text
        NCelularA.Text = selectedItem.SubItems(13).Text

        ' Cambiar el texto del botón de insertar a "Actualizar"
        SiticoneRoundedButton3.Text = "Actualizar"
    End Sub

    Private Sub ActualizarDatos()
        ' Verificar que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(Matricula.Text) OrElse String.IsNullOrWhiteSpace(Rut.Text) OrElse String.IsNullOrWhiteSpace(Nombres.Text) OrElse String.IsNullOrWhiteSpace(FNacimiento.Text) OrElse String.IsNullOrWhiteSpace(ApellidoP.Text) OrElse String.IsNullOrWhiteSpace(ApellidoM.Text) OrElse String.IsNullOrWhiteSpace(Direccion.Text) OrElse String.IsNullOrWhiteSpace(Email.Text) OrElse String.IsNullOrWhiteSpace(NCelular.Text) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Verificar el formato del RUT
        If Not System.Text.RegularExpressions.Regex.IsMatch(Rut.Text, "^\d{8}-\d$") Or Not System.Text.RegularExpressions.Regex.IsMatch(RutA.Text, "^\d{8}-\d$") Then
            MessageBox.Show("El formato del RUT no es válido. Debe ser 12345678-9", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Abrir la conexión si está cerrada
        If cone4progUser.State = ConnectionState.Closed Then
            cone4progUser.Open()
        End If

        ' Crear el comando SQL para actualizar los datos
        Dim cmd As New MySqlCommand("UPDATE datos_liceo SET Matricula = @Matricula, Rut = @Rut, Nombres = @Nombres, ApellidoP = @ApellidoP, ApellidoM = @ApellidoM, FNacimiento = @FNacimiento, Direccion = @Direccion, Email = @Email, NCelular = @NCelular, RutA = @RutA, NombresA = @NombresA, ApellidoPA = @ApellidoPA, ApellidoMA = @ApellidoMA, NCelularA = @NCelularA WHERE Matricula = @MatriculaOriginal", cone4progUser)

        ' Agregar los parámetros al comando
        cmd.Parameters.AddWithValue("@Matricula", Matricula.Text)
        cmd.Parameters.AddWithValue("@Rut", Rut.Text)
        cmd.Parameters.AddWithValue("@Nombres", CapitalizarPrimeraLetra(Nombres.Text))
        cmd.Parameters.AddWithValue("@ApellidoP", CapitalizarPrimeraLetra(ApellidoP.Text))
        cmd.Parameters.AddWithValue("@ApellidoM", CapitalizarPrimeraLetra(ApellidoM.Text))
        cmd.Parameters.AddWithValue("@FNacimiento", FNacimiento.Text)
        cmd.Parameters.AddWithValue("@Direccion", CapitalizarPrimeraLetra(Direccion.Text))
        cmd.Parameters.AddWithValue("@Email", Email.Text)
        cmd.Parameters.AddWithValue("@NCelular", NCelular.Text)
        cmd.Parameters.AddWithValue("@RutA", RutA.Text)
        cmd.Parameters.AddWithValue("@NombresA", CapitalizarPrimeraLetra(NombresA.Text))
        cmd.Parameters.AddWithValue("@ApellidoPA", CapitalizarPrimeraLetra(ApellidoPA.Text))
        cmd.Parameters.AddWithValue("@ApellidoMA", CapitalizarPrimeraLetra(ApellidoMA.Text))
        cmd.Parameters.AddWithValue("@NCelularA", NCelularA.Text)
        cmd.Parameters.AddWithValue("@MatriculaOriginal", matriculaOriginal)

        Try
            ' Ejecutar el comando
            cmd.ExecuteNonQuery()
            MessageBox.Show("Datos actualizados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarDatos()
            LimpiarCampos()
            SiticoneRoundedButton3.Text = "Insertar"
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("La nueva matrícula ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Error al actualizar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Finally
            ' Cerrar la conexión si está abierta
            If cone4progUser.State = ConnectionState.Open Then
                cone4progUser.Close()
            End If
        End Try
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        EditarDatos()
    End Sub

    ' Asegúrate de que el método LimpiarCampos() esté implementado correctamente
    Private Sub LimpiarCampos()
        Matricula.Text = ""
        Rut.Text = ""
        Nombres.Text = ""
        FNacimiento.Text = ""
        ApellidoP.Text = ""
        ApellidoM.Text = ""
        Direccion.Text = ""
        Email.Text = ""
        NCelular.Text = ""
        RutA.Text = ""
        NombresA.Text = ""
        ApellidoPA.Text = ""
        ApellidoMA.Text = ""
        NCelularA.Text = ""
        SiticoneRoundedButton3.Text = "Insertar"
    End Sub
End Class