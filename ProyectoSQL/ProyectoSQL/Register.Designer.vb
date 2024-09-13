<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextPass = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
        Me.SiticonePanel1 = New Siticone.UI.WinForms.SiticonePanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SiticoneButton2 = New Siticone.UI.WinForms.SiticoneButton()
        Me.SiticoneButton1 = New Siticone.UI.WinForms.SiticoneButton()
        Me.SiticoneRoundedButton1 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.TextUser = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
        Me.SiticoneDragControl1 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
        Me.SiticoneDragControl2 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
        Me.SiticoneElipse1 = New Siticone.UI.WinForms.SiticoneElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SiticonePanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(207, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'TextPass
        '
        Me.TextPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextPass.DefaultText = ""
        Me.TextPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextPass.DisabledState.Parent = Me.TextPass
        Me.TextPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextPass.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextPass.FocusedState.BorderColor = System.Drawing.Color.DarkRed
        Me.TextPass.FocusedState.Parent = Me.TextPass
        Me.TextPass.ForeColor = System.Drawing.Color.Black
        Me.TextPass.HoveredState.BorderColor = System.Drawing.Color.DarkRed
        Me.TextPass.HoveredState.Parent = Me.TextPass
        Me.TextPass.IconLeft = CType(resources.GetObject("TextPass.IconLeft"), System.Drawing.Image)
        Me.TextPass.IconLeftSize = New System.Drawing.Size(19, 18)
        Me.TextPass.Location = New System.Drawing.Point(153, 217)
        Me.TextPass.Name = "TextPass"
        Me.TextPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextPass.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TextPass.PlaceholderText = "Contraseña"
        Me.TextPass.SelectedText = ""
        Me.TextPass.ShadowDecoration.Parent = Me.TextPass
        Me.TextPass.Size = New System.Drawing.Size(246, 35)
        Me.TextPass.TabIndex = 8
        '
        'SiticonePanel1
        '
        Me.SiticonePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticonePanel1.Controls.Add(Me.PictureBox2)
        Me.SiticonePanel1.Controls.Add(Me.Label2)
        Me.SiticonePanel1.Controls.Add(Me.SiticoneButton2)
        Me.SiticonePanel1.Controls.Add(Me.SiticoneButton1)
        Me.SiticonePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SiticonePanel1.Location = New System.Drawing.Point(0, 0)
        Me.SiticonePanel1.Name = "SiticonePanel1"
        Me.SiticonePanel1.ShadowDecoration.Parent = Me.SiticonePanel1
        Me.SiticonePanel1.Size = New System.Drawing.Size(549, 29)
        Me.SiticonePanel1.TabIndex = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(240, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Registro"
        '
        'SiticoneButton2
        '
        Me.SiticoneButton2.CheckedState.Parent = Me.SiticoneButton2
        Me.SiticoneButton2.CustomImages.Parent = Me.SiticoneButton2
        Me.SiticoneButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticoneButton2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneButton2.ForeColor = System.Drawing.Color.White
        Me.SiticoneButton2.HoveredState.Parent = Me.SiticoneButton2
        Me.SiticoneButton2.Location = New System.Drawing.Point(475, 0)
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
        Me.SiticoneButton1.Location = New System.Drawing.Point(511, 0)
        Me.SiticoneButton1.Name = "SiticoneButton1"
        Me.SiticoneButton1.ShadowDecoration.Parent = Me.SiticoneButton1
        Me.SiticoneButton1.Size = New System.Drawing.Size(38, 29)
        Me.SiticoneButton1.TabIndex = 0
        Me.SiticoneButton1.Text = "✕"
        '
        'SiticoneRoundedButton1
        '
        Me.SiticoneRoundedButton1.CheckedState.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.CustomImages.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticoneRoundedButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneRoundedButton1.ForeColor = System.Drawing.Color.White
        Me.SiticoneRoundedButton1.HoveredState.FillColor = System.Drawing.Color.Red
        Me.SiticoneRoundedButton1.HoveredState.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.Location = New System.Drawing.Point(214, 279)
        Me.SiticoneRoundedButton1.Name = "SiticoneRoundedButton1"
        Me.SiticoneRoundedButton1.ShadowDecoration.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.Size = New System.Drawing.Size(122, 35)
        Me.SiticoneRoundedButton1.TabIndex = 9
        Me.SiticoneRoundedButton1.Text = "Registrarse"
        '
        'TextUser
        '
        Me.TextUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TextUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextUser.DefaultText = ""
        Me.TextUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextUser.DisabledState.Parent = Me.TextUser
        Me.TextUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextUser.FocusedState.BorderColor = System.Drawing.Color.DarkRed
        Me.TextUser.FocusedState.Parent = Me.TextUser
        Me.TextUser.ForeColor = System.Drawing.Color.Black
        Me.TextUser.HoveredState.BorderColor = System.Drawing.Color.DarkRed
        Me.TextUser.HoveredState.Parent = Me.TextUser
        Me.TextUser.IconLeft = CType(resources.GetObject("TextUser.IconLeft"), System.Drawing.Image)
        Me.TextUser.Location = New System.Drawing.Point(153, 164)
        Me.TextUser.Name = "TextUser"
        Me.TextUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextUser.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TextUser.PlaceholderText = "Usuario"
        Me.TextUser.SelectedText = ""
        Me.TextUser.ShadowDecoration.Parent = Me.TextUser
        Me.TextUser.Size = New System.Drawing.Size(246, 35)
        Me.TextUser.TabIndex = 7
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(212, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "¿Tienes una cuenta?"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(366, 226)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(549, 322)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextPass)
        Me.Controls.Add(Me.SiticonePanel1)
        Me.Controls.Add(Me.SiticoneRoundedButton1)
        Me.Controls.Add(Me.TextUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SiticonePanel1.ResumeLayout(False)
        Me.SiticonePanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextPass As Siticone.UI.WinForms.SiticoneRoundedTextBox
    Friend WithEvents SiticonePanel1 As Siticone.UI.WinForms.SiticonePanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SiticoneButton2 As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents SiticoneButton1 As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents SiticoneRoundedButton1 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents TextUser As Siticone.UI.WinForms.SiticoneRoundedTextBox
    Friend WithEvents SiticoneDragControl1 As Siticone.UI.WinForms.SiticoneDragControl
    Friend WithEvents SiticoneDragControl2 As Siticone.UI.WinForms.SiticoneDragControl
    Friend WithEvents SiticoneElipse1 As Siticone.UI.WinForms.SiticoneElipse
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
