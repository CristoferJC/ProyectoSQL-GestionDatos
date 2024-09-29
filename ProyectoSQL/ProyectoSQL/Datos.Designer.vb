<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Datos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Datos))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Rut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextRut = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
        Me.TextNombre = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
        Me.TextApellido = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
        Me.SiticoneVSeparator1 = New Siticone.UI.WinForms.SiticoneVSeparator()
        Me.SiticoneElipse1 = New Siticone.UI.WinForms.SiticoneElipse(Me.components)
        Me.SiticoneElipse2 = New Siticone.UI.WinForms.SiticoneElipse(Me.components)
        Me.SiticoneRoundedButton1 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.SiticoneRoundedButton2 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.SiticoneRoundedButton3 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.SiticoneButton2 = New Siticone.UI.WinForms.SiticoneButton()
        Me.SiticoneButton1 = New Siticone.UI.WinForms.SiticoneButton()
        Me.SiticonePanel1 = New Siticone.UI.WinForms.SiticonePanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SiticoneDragControl1 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
        Me.SiticoneDragControl2 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
        Me.SiticoneElipse3 = New Siticone.UI.WinForms.SiticoneElipse(Me.components)
        Me.SiticoneRoundedButton4 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.SiticoneRoundedButton5 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.SiticoneCheckBox1 = New Siticone.UI.WinForms.SiticoneCheckBox()
        Me.buscar = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SiticonePanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(63, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Datos personales"
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.BackColor = System.Drawing.Color.OldLace
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Rut, Me.Nombre, Me.Apellido})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.Black
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(341, 81)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(405, 275)
        Me.ListView1.TabIndex = 2
        Me.ListView1.TileSize = New System.Drawing.Size(2, 2)
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Rut
        '
        Me.Rut.Text = "Rut"
        Me.Rut.Width = 124
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 132
        '
        'Apellido
        '
        Me.Apellido.Text = "Apellido"
        Me.Apellido.Width = 149
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(34, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "RUT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Apellido"
        '
        'TextRut
        '
        Me.TextRut.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextRut.DefaultText = ""
        Me.TextRut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextRut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextRut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextRut.DisabledState.Parent = Me.TextRut
        Me.TextRut.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextRut.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextRut.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.TextRut.FocusedState.Parent = Me.TextRut
        Me.TextRut.ForeColor = System.Drawing.Color.Black
        Me.TextRut.HoveredState.BorderColor = System.Drawing.Color.Red
        Me.TextRut.HoveredState.Parent = Me.TextRut
        Me.TextRut.Location = New System.Drawing.Point(94, 146)
        Me.TextRut.Name = "TextRut"
        Me.TextRut.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextRut.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TextRut.PlaceholderText = "Ej: 12345678-9"
        Me.TextRut.SelectedText = ""
        Me.TextRut.ShadowDecoration.Parent = Me.TextRut
        Me.TextRut.Size = New System.Drawing.Size(139, 29)
        Me.TextRut.TabIndex = 6
        '
        'TextNombre
        '
        Me.TextNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextNombre.DefaultText = ""
        Me.TextNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextNombre.DisabledState.Parent = Me.TextNombre
        Me.TextNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextNombre.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextNombre.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.TextNombre.FocusedState.Parent = Me.TextNombre
        Me.TextNombre.ForeColor = System.Drawing.Color.Black
        Me.TextNombre.HoveredState.BorderColor = System.Drawing.Color.Red
        Me.TextNombre.HoveredState.Parent = Me.TextNombre
        Me.TextNombre.Location = New System.Drawing.Point(94, 224)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextNombre.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TextNombre.PlaceholderText = "Ej: John"
        Me.TextNombre.SelectedText = ""
        Me.TextNombre.ShadowDecoration.Parent = Me.TextNombre
        Me.TextNombre.Size = New System.Drawing.Size(139, 29)
        Me.TextNombre.TabIndex = 7
        '
        'TextApellido
        '
        Me.TextApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextApellido.DefaultText = ""
        Me.TextApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextApellido.DisabledState.Parent = Me.TextApellido
        Me.TextApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextApellido.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextApellido.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.TextApellido.FocusedState.Parent = Me.TextApellido
        Me.TextApellido.ForeColor = System.Drawing.Color.Black
        Me.TextApellido.HoveredState.BorderColor = System.Drawing.Color.Red
        Me.TextApellido.HoveredState.Parent = Me.TextApellido
        Me.TextApellido.Location = New System.Drawing.Point(94, 300)
        Me.TextApellido.Name = "TextApellido"
        Me.TextApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextApellido.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TextApellido.PlaceholderText = "Ej: Doe"
        Me.TextApellido.SelectedText = ""
        Me.TextApellido.ShadowDecoration.Parent = Me.TextApellido
        Me.TextApellido.Size = New System.Drawing.Size(139, 29)
        Me.TextApellido.TabIndex = 8
        '
        'SiticoneVSeparator1
        '
        Me.SiticoneVSeparator1.Location = New System.Drawing.Point(284, 62)
        Me.SiticoneVSeparator1.Name = "SiticoneVSeparator1"
        Me.SiticoneVSeparator1.Size = New System.Drawing.Size(13, 343)
        Me.SiticoneVSeparator1.TabIndex = 9
        '
        'SiticoneElipse1
        '
        Me.SiticoneElipse1.TargetControl = Me.ListView1
        '
        'SiticoneElipse2
        '
        Me.SiticoneElipse2.BorderRadius = 10
        Me.SiticoneElipse2.TargetControl = Me
        '
        'SiticoneRoundedButton1
        '
        Me.SiticoneRoundedButton1.CheckedState.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.CustomImages.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticoneRoundedButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneRoundedButton1.ForeColor = System.Drawing.Color.White
        Me.SiticoneRoundedButton1.HoveredState.FillColor = System.Drawing.Color.DarkRed
        Me.SiticoneRoundedButton1.HoveredState.ForeColor = System.Drawing.Color.White
        Me.SiticoneRoundedButton1.HoveredState.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.Image = CType(resources.GetObject("SiticoneRoundedButton1.Image"), System.Drawing.Image)
        Me.SiticoneRoundedButton1.ImageSize = New System.Drawing.Size(20, 25)
        Me.SiticoneRoundedButton1.Location = New System.Drawing.Point(535, 362)
        Me.SiticoneRoundedButton1.Name = "SiticoneRoundedButton1"
        Me.SiticoneRoundedButton1.ShadowDecoration.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.Size = New System.Drawing.Size(95, 33)
        Me.SiticoneRoundedButton1.TabIndex = 10
        Me.SiticoneRoundedButton1.Text = "Agregar"
        '
        'SiticoneRoundedButton2
        '
        Me.SiticoneRoundedButton2.CheckedState.Parent = Me.SiticoneRoundedButton2
        Me.SiticoneRoundedButton2.CustomImages.Parent = Me.SiticoneRoundedButton2
        Me.SiticoneRoundedButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticoneRoundedButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneRoundedButton2.ForeColor = System.Drawing.Color.White
        Me.SiticoneRoundedButton2.HoveredState.FillColor = System.Drawing.Color.Red
        Me.SiticoneRoundedButton2.HoveredState.Parent = Me.SiticoneRoundedButton2
        Me.SiticoneRoundedButton2.Image = CType(resources.GetObject("SiticoneRoundedButton2.Image"), System.Drawing.Image)
        Me.SiticoneRoundedButton2.Location = New System.Drawing.Point(94, 362)
        Me.SiticoneRoundedButton2.Name = "SiticoneRoundedButton2"
        Me.SiticoneRoundedButton2.ShadowDecoration.Parent = Me.SiticoneRoundedButton2
        Me.SiticoneRoundedButton2.Size = New System.Drawing.Size(89, 33)
        Me.SiticoneRoundedButton2.TabIndex = 11
        Me.SiticoneRoundedButton2.Text = "Limpiar"
        '
        'SiticoneRoundedButton3
        '
        Me.SiticoneRoundedButton3.CheckedState.Parent = Me.SiticoneRoundedButton3
        Me.SiticoneRoundedButton3.CustomImages.Parent = Me.SiticoneRoundedButton3
        Me.SiticoneRoundedButton3.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticoneRoundedButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneRoundedButton3.ForeColor = System.Drawing.Color.White
        Me.SiticoneRoundedButton3.HoveredState.FillColor = System.Drawing.Color.DarkRed
        Me.SiticoneRoundedButton3.HoveredState.ForeColor = System.Drawing.Color.White
        Me.SiticoneRoundedButton3.HoveredState.Parent = Me.SiticoneRoundedButton3
        Me.SiticoneRoundedButton3.Image = CType(resources.GetObject("SiticoneRoundedButton3.Image"), System.Drawing.Image)
        Me.SiticoneRoundedButton3.ImageSize = New System.Drawing.Size(19, 19)
        Me.SiticoneRoundedButton3.Location = New System.Drawing.Point(636, 362)
        Me.SiticoneRoundedButton3.Name = "SiticoneRoundedButton3"
        Me.SiticoneRoundedButton3.ShadowDecoration.Parent = Me.SiticoneRoundedButton3
        Me.SiticoneRoundedButton3.Size = New System.Drawing.Size(95, 33)
        Me.SiticoneRoundedButton3.TabIndex = 12
        Me.SiticoneRoundedButton3.Text = "Eliminar"
        '
        'SiticoneButton2
        '
        Me.SiticoneButton2.CheckedState.Parent = Me.SiticoneButton2
        Me.SiticoneButton2.CustomImages.Parent = Me.SiticoneButton2
        Me.SiticoneButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticoneButton2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneButton2.ForeColor = System.Drawing.Color.White
        Me.SiticoneButton2.HoveredState.Parent = Me.SiticoneButton2
        Me.SiticoneButton2.Location = New System.Drawing.Point(726, 0)
        Me.SiticoneButton2.Name = "SiticoneButton2"
        Me.SiticoneButton2.ShadowDecoration.Parent = Me.SiticoneButton2
        Me.SiticoneButton2.Size = New System.Drawing.Size(36, 29)
        Me.SiticoneButton2.TabIndex = 1
        Me.SiticoneButton2.Text = "_"
        Me.SiticoneButton2.TextOffset = New System.Drawing.Point(0, -5)
        '
        'SiticoneButton1
        '
        Me.SiticoneButton1.CheckedState.Parent = Me.SiticoneButton1
        Me.SiticoneButton1.CustomImages.Parent = Me.SiticoneButton1
        Me.SiticoneButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticoneButton1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneButton1.ForeColor = System.Drawing.Color.White
        Me.SiticoneButton1.HoveredState.FillColor = System.Drawing.Color.Red
        Me.SiticoneButton1.HoveredState.ForeColor = System.Drawing.Color.White
        Me.SiticoneButton1.HoveredState.Parent = Me.SiticoneButton1
        Me.SiticoneButton1.Location = New System.Drawing.Point(762, 0)
        Me.SiticoneButton1.Name = "SiticoneButton1"
        Me.SiticoneButton1.ShadowDecoration.Parent = Me.SiticoneButton1
        Me.SiticoneButton1.Size = New System.Drawing.Size(38, 29)
        Me.SiticoneButton1.TabIndex = 0
        Me.SiticoneButton1.Text = "✕"
        '
        'SiticonePanel1
        '
        Me.SiticonePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticonePanel1.Controls.Add(Me.Label1)
        Me.SiticonePanel1.Controls.Add(Me.SiticoneButton2)
        Me.SiticonePanel1.Controls.Add(Me.SiticoneButton1)
        Me.SiticonePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SiticonePanel1.Location = New System.Drawing.Point(0, 0)
        Me.SiticonePanel1.Name = "SiticonePanel1"
        Me.SiticonePanel1.ShadowDecoration.Parent = Me.SiticonePanel1
        Me.SiticonePanel1.Size = New System.Drawing.Size(800, 29)
        Me.SiticonePanel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(347, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Formulario"
        '
        'SiticoneDragControl1
        '
        Me.SiticoneDragControl1.TargetControl = Me.SiticonePanel1
        '
        'SiticoneDragControl2
        '
        Me.SiticoneDragControl2.TargetControl = Me.Label1
        '
        'SiticoneElipse3
        '
        Me.SiticoneElipse3.BorderRadius = 10
        '
        'SiticoneRoundedButton4
        '
        Me.SiticoneRoundedButton4.CheckedState.Parent = Me.SiticoneRoundedButton4
        Me.SiticoneRoundedButton4.CustomImages.Parent = Me.SiticoneRoundedButton4
        Me.SiticoneRoundedButton4.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticoneRoundedButton4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneRoundedButton4.ForeColor = System.Drawing.Color.White
        Me.SiticoneRoundedButton4.HoveredState.FillColor = System.Drawing.Color.Red
        Me.SiticoneRoundedButton4.HoveredState.Parent = Me.SiticoneRoundedButton4
        Me.SiticoneRoundedButton4.Location = New System.Drawing.Point(711, 411)
        Me.SiticoneRoundedButton4.Name = "SiticoneRoundedButton4"
        Me.SiticoneRoundedButton4.ShadowDecoration.Parent = Me.SiticoneRoundedButton4
        Me.SiticoneRoundedButton4.Size = New System.Drawing.Size(77, 35)
        Me.SiticoneRoundedButton4.TabIndex = 13
        Me.SiticoneRoundedButton4.Text = "Salir"
        '
        'SiticoneRoundedButton5
        '
        Me.SiticoneRoundedButton5.CheckedState.Parent = Me.SiticoneRoundedButton5
        Me.SiticoneRoundedButton5.CustomImages.Parent = Me.SiticoneRoundedButton5
        Me.SiticoneRoundedButton5.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticoneRoundedButton5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneRoundedButton5.ForeColor = System.Drawing.Color.White
        Me.SiticoneRoundedButton5.HoveredState.FillColor = System.Drawing.Color.Red
        Me.SiticoneRoundedButton5.HoveredState.Parent = Me.SiticoneRoundedButton5
        Me.SiticoneRoundedButton5.Location = New System.Drawing.Point(618, 411)
        Me.SiticoneRoundedButton5.Name = "SiticoneRoundedButton5"
        Me.SiticoneRoundedButton5.ShadowDecoration.Parent = Me.SiticoneRoundedButton5
        Me.SiticoneRoundedButton5.Size = New System.Drawing.Size(77, 35)
        Me.SiticoneRoundedButton5.TabIndex = 15
        Me.SiticoneRoundedButton5.Text = "Menú"
        '
        'SiticoneCheckBox1
        '
        Me.SiticoneCheckBox1.AutoSize = True
        Me.SiticoneCheckBox1.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.SiticoneCheckBox1.CheckedState.BorderRadius = 2
        Me.SiticoneCheckBox1.CheckedState.BorderThickness = 0
        Me.SiticoneCheckBox1.CheckedState.FillColor = System.Drawing.Color.Red
        Me.SiticoneCheckBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneCheckBox1.ForeColor = System.Drawing.Color.White
        Me.SiticoneCheckBox1.Location = New System.Drawing.Point(341, 59)
        Me.SiticoneCheckBox1.Name = "SiticoneCheckBox1"
        Me.SiticoneCheckBox1.Size = New System.Drawing.Size(131, 21)
        Me.SiticoneCheckBox1.TabIndex = 16
        Me.SiticoneCheckBox1.Text = "Seleccionar todos"
        Me.SiticoneCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.SiticoneCheckBox1.UncheckedState.BorderRadius = 2
        Me.SiticoneCheckBox1.UncheckedState.BorderThickness = 0
        Me.SiticoneCheckBox1.UncheckedState.FillColor = System.Drawing.Color.White
        Me.SiticoneCheckBox1.UseVisualStyleBackColor = True
        '
        'buscar
        '
        Me.buscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.buscar.DefaultText = ""
        Me.buscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.buscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.buscar.DisabledState.Parent = Me.buscar
        Me.buscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.buscar.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.buscar.FocusedState.Parent = Me.buscar
        Me.buscar.ForeColor = System.Drawing.Color.Black
        Me.buscar.HoveredState.BorderColor = System.Drawing.Color.Red
        Me.buscar.HoveredState.Parent = Me.buscar
        Me.buscar.IconLeft = CType(resources.GetObject("buscar.IconLeft"), System.Drawing.Image)
        Me.buscar.Location = New System.Drawing.Point(341, 364)
        Me.buscar.Name = "buscar"
        Me.buscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.buscar.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.buscar.PlaceholderText = "Buscar"
        Me.buscar.SelectedText = ""
        Me.buscar.ShadowDecoration.Parent = Me.buscar
        Me.buscar.Size = New System.Drawing.Size(188, 27)
        Me.buscar.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(720, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 455)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.SiticoneCheckBox1)
        Me.Controls.Add(Me.SiticoneRoundedButton5)
        Me.Controls.Add(Me.SiticonePanel1)
        Me.Controls.Add(Me.SiticoneRoundedButton4)
        Me.Controls.Add(Me.SiticoneRoundedButton3)
        Me.Controls.Add(Me.SiticoneRoundedButton2)
        Me.Controls.Add(Me.SiticoneRoundedButton1)
        Me.Controls.Add(Me.SiticoneVSeparator1)
        Me.Controls.Add(Me.TextApellido)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.TextRut)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Datos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario Personal"
        Me.SiticonePanel1.ResumeLayout(False)
        Me.SiticonePanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextRut As Siticone.UI.WinForms.SiticoneRoundedTextBox
    Friend WithEvents TextNombre As Siticone.UI.WinForms.SiticoneRoundedTextBox
    Friend WithEvents TextApellido As Siticone.UI.WinForms.SiticoneRoundedTextBox
    Friend WithEvents SiticoneVSeparator1 As Siticone.UI.WinForms.SiticoneVSeparator
    Friend WithEvents SiticoneElipse1 As Siticone.UI.WinForms.SiticoneElipse
    Friend WithEvents SiticoneElipse2 As Siticone.UI.WinForms.SiticoneElipse
    Friend WithEvents SiticoneRoundedButton3 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents SiticoneRoundedButton2 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents SiticoneRoundedButton1 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents SiticonePanel1 As Siticone.UI.WinForms.SiticonePanel
    Friend WithEvents SiticoneButton2 As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents SiticoneButton1 As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents SiticoneDragControl1 As Siticone.UI.WinForms.SiticoneDragControl
    Friend WithEvents Rut As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Apellido As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents SiticoneDragControl2 As Siticone.UI.WinForms.SiticoneDragControl
    Friend WithEvents SiticoneRoundedButton5 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents SiticoneRoundedButton4 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents SiticoneElipse3 As Siticone.UI.WinForms.SiticoneElipse
    Friend WithEvents SiticoneCheckBox1 As Siticone.UI.WinForms.SiticoneCheckBox
    Friend WithEvents buscar As Siticone.UI.WinForms.SiticoneRoundedTextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
