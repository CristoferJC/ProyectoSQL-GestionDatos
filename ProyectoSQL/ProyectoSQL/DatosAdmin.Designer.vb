<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosAdmin))
        Me.SiticonePanel1 = New Siticone.UI.WinForms.SiticonePanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SiticoneButton2 = New Siticone.UI.WinForms.SiticoneButton()
        Me.SiticoneButton1 = New Siticone.UI.WinForms.SiticoneButton()
        Me.SiticoneDragControl1 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
        Me.SiticoneDragControl2 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
        Me.SiticoneElipse1 = New Siticone.UI.WinForms.SiticoneElipse(Me.components)
        Me.SiticoneRoundedButton5 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SiticoneElipse2 = New Siticone.UI.WinForms.SiticoneElipse(Me.components)
        Me.TextUser = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextPass = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SiticoneRoundedButton3 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.SiticoneRoundedButton1 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SiticoneCheckBox1 = New Siticone.UI.WinForms.SiticoneCheckBox()
        Me.SiticonePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SiticonePanel1
        '
        Me.SiticonePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticonePanel1.Controls.Add(Me.Label2)
        Me.SiticonePanel1.Controls.Add(Me.SiticoneButton2)
        Me.SiticonePanel1.Controls.Add(Me.SiticoneButton1)
        Me.SiticonePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SiticonePanel1.Location = New System.Drawing.Point(0, 0)
        Me.SiticonePanel1.Name = "SiticonePanel1"
        Me.SiticonePanel1.ShadowDecoration.Parent = Me.SiticonePanel1
        Me.SiticonePanel1.Size = New System.Drawing.Size(580, 29)
        Me.SiticonePanel1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(236, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Panel Admin"
        '
        'SiticoneButton2
        '
        Me.SiticoneButton2.CheckedState.Parent = Me.SiticoneButton2
        Me.SiticoneButton2.CustomImages.Parent = Me.SiticoneButton2
        Me.SiticoneButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticoneButton2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneButton2.ForeColor = System.Drawing.Color.White
        Me.SiticoneButton2.HoveredState.Parent = Me.SiticoneButton2
        Me.SiticoneButton2.Location = New System.Drawing.Point(506, 0)
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
        Me.SiticoneButton1.Location = New System.Drawing.Point(542, 0)
        Me.SiticoneButton1.Name = "SiticoneButton1"
        Me.SiticoneButton1.ShadowDecoration.Parent = Me.SiticoneButton1
        Me.SiticoneButton1.Size = New System.Drawing.Size(38, 29)
        Me.SiticoneButton1.TabIndex = 0
        Me.SiticoneButton1.Text = "✕"
        '
        'SiticoneDragControl1
        '
        Me.SiticoneDragControl1.TargetControl = Me.Label2
        '
        'SiticoneDragControl2
        '
        Me.SiticoneDragControl2.TargetControl = Me.SiticonePanel1
        '
        'SiticoneElipse1
        '
        Me.SiticoneElipse1.BorderRadius = 10
        Me.SiticoneElipse1.TargetControl = Me
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
        Me.SiticoneRoundedButton5.Location = New System.Drawing.Point(12, 272)
        Me.SiticoneRoundedButton5.Name = "SiticoneRoundedButton5"
        Me.SiticoneRoundedButton5.ShadowDecoration.Parent = Me.SiticoneRoundedButton5
        Me.SiticoneRoundedButton5.Size = New System.Drawing.Size(83, 34)
        Me.SiticoneRoundedButton5.TabIndex = 17
        Me.SiticoneRoundedButton5.Text = "Menú"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.OldLace
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(199, 82)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(330, 163)
        Me.ListView1.TabIndex = 18
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'SiticoneElipse2
        '
        Me.SiticoneElipse2.TargetControl = Me.ListView1
        '
        'TextUser
        '
        Me.TextUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextUser.DefaultText = ""
        Me.TextUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextUser.DisabledState.Parent = Me.TextUser
        Me.TextUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextUser.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.TextUser.FocusedState.Parent = Me.TextUser
        Me.TextUser.ForeColor = System.Drawing.Color.Black
        Me.TextUser.HoveredState.BorderColor = System.Drawing.Color.Red
        Me.TextUser.HoveredState.Parent = Me.TextUser
        Me.TextUser.Location = New System.Drawing.Point(34, 123)
        Me.TextUser.Name = "TextUser"
        Me.TextUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextUser.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TextUser.PlaceholderText = "Admin"
        Me.TextUser.SelectedText = ""
        Me.TextUser.ShadowDecoration.Parent = Me.TextUser
        Me.TextUser.Size = New System.Drawing.Size(139, 29)
        Me.TextUser.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(35, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Usuario"
        '
        'TextPass
        '
        Me.TextPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextPass.DefaultText = ""
        Me.TextPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextPass.DisabledState.Parent = Me.TextPass
        Me.TextPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextPass.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextPass.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.TextPass.FocusedState.Parent = Me.TextPass
        Me.TextPass.ForeColor = System.Drawing.Color.Black
        Me.TextPass.HoveredState.BorderColor = System.Drawing.Color.Red
        Me.TextPass.HoveredState.Parent = Me.TextPass
        Me.TextPass.Location = New System.Drawing.Point(34, 198)
        Me.TextPass.Name = "TextPass"
        Me.TextPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextPass.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TextPass.PlaceholderText = "Admin"
        Me.TextPass.SelectedText = ""
        Me.TextPass.ShadowDecoration.Parent = Me.TextPass
        Me.TextPass.Size = New System.Drawing.Size(139, 29)
        Me.TextPass.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Contraseña"
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
        Me.SiticoneRoundedButton3.Location = New System.Drawing.Point(434, 246)
        Me.SiticoneRoundedButton3.Name = "SiticoneRoundedButton3"
        Me.SiticoneRoundedButton3.ShadowDecoration.Parent = Me.SiticoneRoundedButton3
        Me.SiticoneRoundedButton3.Size = New System.Drawing.Size(95, 33)
        Me.SiticoneRoundedButton3.TabIndex = 26
        Me.SiticoneRoundedButton3.Text = "Eliminar"
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
        Me.SiticoneRoundedButton1.Location = New System.Drawing.Point(333, 246)
        Me.SiticoneRoundedButton1.Name = "SiticoneRoundedButton1"
        Me.SiticoneRoundedButton1.ShadowDecoration.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.Size = New System.Drawing.Size(95, 33)
        Me.SiticoneRoundedButton1.TabIndex = 25
        Me.SiticoneRoundedButton1.Text = "Agregar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(222, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(301, 19)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Aquí puede crear nuevos usuarios o eliminarlos."
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
        Me.SiticoneCheckBox1.Location = New System.Drawing.Point(199, 251)
        Me.SiticoneCheckBox1.Name = "SiticoneCheckBox1"
        Me.SiticoneCheckBox1.Size = New System.Drawing.Size(131, 21)
        Me.SiticoneCheckBox1.TabIndex = 28
        Me.SiticoneCheckBox1.Text = "Seleccionar todos"
        Me.SiticoneCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.SiticoneCheckBox1.UncheckedState.BorderRadius = 2
        Me.SiticoneCheckBox1.UncheckedState.BorderThickness = 0
        Me.SiticoneCheckBox1.UncheckedState.FillColor = System.Drawing.Color.White
        Me.SiticoneCheckBox1.UseVisualStyleBackColor = True
        '
        'DatosAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 318)
        Me.Controls.Add(Me.SiticoneCheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SiticoneRoundedButton3)
        Me.Controls.Add(Me.SiticoneRoundedButton1)
        Me.Controls.Add(Me.TextPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.SiticoneRoundedButton5)
        Me.Controls.Add(Me.SiticonePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DatosAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel Admin"
        Me.SiticonePanel1.ResumeLayout(False)
        Me.SiticonePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SiticonePanel1 As Siticone.UI.WinForms.SiticonePanel
    Friend WithEvents Label2 As Label
    Friend WithEvents SiticoneButton2 As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents SiticoneButton1 As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents SiticoneDragControl1 As Siticone.UI.WinForms.SiticoneDragControl
    Friend WithEvents SiticoneDragControl2 As Siticone.UI.WinForms.SiticoneDragControl
    Friend WithEvents SiticoneElipse1 As Siticone.UI.WinForms.SiticoneElipse
    Friend WithEvents SiticoneRoundedButton5 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents ListView1 As ListView
    Friend WithEvents SiticoneElipse2 As Siticone.UI.WinForms.SiticoneElipse
    Friend WithEvents TextPass As Siticone.UI.WinForms.SiticoneRoundedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextUser As Siticone.UI.WinForms.SiticoneRoundedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SiticoneRoundedButton3 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents SiticoneRoundedButton1 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents Label4 As Label
    Friend WithEvents SiticoneCheckBox1 As Siticone.UI.WinForms.SiticoneCheckBox
End Class
