﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosUser
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SiticoneButton2 = New Siticone.UI.WinForms.SiticoneButton()
        Me.SiticoneButton1 = New Siticone.UI.WinForms.SiticoneButton()
        Me.SiticoneRoundedButton5 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.SiticonePanel1 = New Siticone.UI.WinForms.SiticonePanel()
        Me.SiticoneRoundedButton4 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.SiticoneRoundedButton2 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.SiticoneRoundedButton1 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.SiticoneVSeparator1 = New Siticone.UI.WinForms.SiticoneVSeparator()
        Me.TextApellido = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
        Me.TextNombre = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
        Me.TextRut = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Rut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SiticoneDragControl1 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
        Me.SiticoneDragControl2 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
        Me.SiticoneElipse1 = New Siticone.UI.WinForms.SiticoneElipse(Me.components)
        Me.SiticoneElipse2 = New Siticone.UI.WinForms.SiticoneElipse(Me.components)
        Me.SiticonePanel1.SuspendLayout()
        Me.SuspendLayout()
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
        'SiticoneRoundedButton5
        '
        Me.SiticoneRoundedButton5.CheckedState.Parent = Me.SiticoneRoundedButton5
        Me.SiticoneRoundedButton5.CustomImages.Parent = Me.SiticoneRoundedButton5
        Me.SiticoneRoundedButton5.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticoneRoundedButton5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneRoundedButton5.ForeColor = System.Drawing.Color.White
        Me.SiticoneRoundedButton5.HoveredState.FillColor = System.Drawing.Color.Red
        Me.SiticoneRoundedButton5.HoveredState.Parent = Me.SiticoneRoundedButton5
        Me.SiticoneRoundedButton5.Location = New System.Drawing.Point(618, 410)
        Me.SiticoneRoundedButton5.Name = "SiticoneRoundedButton5"
        Me.SiticoneRoundedButton5.ShadowDecoration.Parent = Me.SiticoneRoundedButton5
        Me.SiticoneRoundedButton5.Size = New System.Drawing.Size(77, 35)
        Me.SiticoneRoundedButton5.TabIndex = 30
        Me.SiticoneRoundedButton5.Text = "Menú"
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
        Me.SiticonePanel1.TabIndex = 29
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
        Me.SiticoneRoundedButton4.Location = New System.Drawing.Point(711, 410)
        Me.SiticoneRoundedButton4.Name = "SiticoneRoundedButton4"
        Me.SiticoneRoundedButton4.ShadowDecoration.Parent = Me.SiticoneRoundedButton4
        Me.SiticoneRoundedButton4.Size = New System.Drawing.Size(77, 35)
        Me.SiticoneRoundedButton4.TabIndex = 28
        Me.SiticoneRoundedButton4.Text = "Salir"
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
        Me.SiticoneRoundedButton2.Location = New System.Drawing.Point(94, 363)
        Me.SiticoneRoundedButton2.Name = "SiticoneRoundedButton2"
        Me.SiticoneRoundedButton2.ShadowDecoration.Parent = Me.SiticoneRoundedButton2
        Me.SiticoneRoundedButton2.Size = New System.Drawing.Size(89, 33)
        Me.SiticoneRoundedButton2.TabIndex = 26
        Me.SiticoneRoundedButton2.Text = "Limpiar"
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
        Me.SiticoneRoundedButton1.Location = New System.Drawing.Point(492, 363)
        Me.SiticoneRoundedButton1.Name = "SiticoneRoundedButton1"
        Me.SiticoneRoundedButton1.ShadowDecoration.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.Size = New System.Drawing.Size(95, 33)
        Me.SiticoneRoundedButton1.TabIndex = 25
        Me.SiticoneRoundedButton1.Text = "Agregar"
        '
        'SiticoneVSeparator1
        '
        Me.SiticoneVSeparator1.Location = New System.Drawing.Point(284, 63)
        Me.SiticoneVSeparator1.Name = "SiticoneVSeparator1"
        Me.SiticoneVSeparator1.Size = New System.Drawing.Size(13, 343)
        Me.SiticoneVSeparator1.TabIndex = 24
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
        Me.TextApellido.Location = New System.Drawing.Point(94, 301)
        Me.TextApellido.Name = "TextApellido"
        Me.TextApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextApellido.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TextApellido.PlaceholderText = "Ej: Doe"
        Me.TextApellido.SelectedText = ""
        Me.TextApellido.ShadowDecoration.Parent = Me.TextApellido
        Me.TextApellido.Size = New System.Drawing.Size(139, 29)
        Me.TextApellido.TabIndex = 23
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
        Me.TextNombre.Location = New System.Drawing.Point(94, 225)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextNombre.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TextNombre.PlaceholderText = "Ej: John"
        Me.TextNombre.SelectedText = ""
        Me.TextNombre.ShadowDecoration.Parent = Me.TextNombre
        Me.TextNombre.Size = New System.Drawing.Size(139, 29)
        Me.TextNombre.TabIndex = 22
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
        Me.TextRut.Location = New System.Drawing.Point(94, 147)
        Me.TextRut.Name = "TextRut"
        Me.TextRut.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextRut.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TextRut.PlaceholderText = "Ej: 12345678-9"
        Me.TextRut.SelectedText = ""
        Me.TextRut.ShadowDecoration.Parent = Me.TextRut
        Me.TextRut.Size = New System.Drawing.Size(139, 29)
        Me.TextRut.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 19)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(34, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "RUT"
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
        Me.ListView1.Location = New System.Drawing.Point(341, 82)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(405, 275)
        Me.ListView1.TabIndex = 17
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(63, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Datos personales"
        '
        'SiticoneDragControl1
        '
        Me.SiticoneDragControl1.TargetControl = Me.Label1
        '
        'SiticoneDragControl2
        '
        Me.SiticoneDragControl2.TargetControl = Me.SiticonePanel1
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
        'DatosUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 455)
        Me.Controls.Add(Me.SiticoneRoundedButton5)
        Me.Controls.Add(Me.SiticonePanel1)
        Me.Controls.Add(Me.SiticoneRoundedButton4)
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
        Me.Name = "DatosUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario"
        Me.SiticonePanel1.ResumeLayout(False)
        Me.SiticonePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SiticoneButton2 As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents SiticoneButton1 As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents SiticoneRoundedButton5 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents SiticonePanel1 As Siticone.UI.WinForms.SiticonePanel
    Friend WithEvents SiticoneRoundedButton4 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents SiticoneRoundedButton2 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents SiticoneRoundedButton1 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents SiticoneVSeparator1 As Siticone.UI.WinForms.SiticoneVSeparator
    Friend WithEvents TextApellido As Siticone.UI.WinForms.SiticoneRoundedTextBox
    Friend WithEvents TextNombre As Siticone.UI.WinForms.SiticoneRoundedTextBox
    Friend WithEvents TextRut As Siticone.UI.WinForms.SiticoneRoundedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Rut As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Apellido As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents SiticoneDragControl1 As Siticone.UI.WinForms.SiticoneDragControl
    Friend WithEvents SiticoneDragControl2 As Siticone.UI.WinForms.SiticoneDragControl
    Friend WithEvents SiticoneElipse1 As Siticone.UI.WinForms.SiticoneElipse
    Friend WithEvents SiticoneElipse2 As Siticone.UI.WinForms.SiticoneElipse
End Class
