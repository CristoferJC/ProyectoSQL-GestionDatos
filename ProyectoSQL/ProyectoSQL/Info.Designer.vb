<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info))
        Me.SiticonePanel1 = New Siticone.UI.WinForms.SiticonePanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SiticoneButton1 = New Siticone.UI.WinForms.SiticoneButton()
        Me.SiticoneDragControl1 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
        Me.SiticoneDragControl2 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
        Me.SiticoneElipse1 = New Siticone.UI.WinForms.SiticoneElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SiticoneSeparator1 = New Siticone.UI.WinForms.SiticoneSeparator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SiticoneRoundedButton5 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.SiticonePanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SiticonePanel1
        '
        Me.SiticonePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticonePanel1.Controls.Add(Me.Label2)
        Me.SiticonePanel1.Controls.Add(Me.SiticoneButton1)
        Me.SiticonePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SiticonePanel1.Location = New System.Drawing.Point(0, 0)
        Me.SiticonePanel1.Name = "SiticonePanel1"
        Me.SiticonePanel1.ShadowDecoration.Parent = Me.SiticonePanel1
        Me.SiticonePanel1.Size = New System.Drawing.Size(519, 29)
        Me.SiticonePanel1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(209, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Información"
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(343, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Creado por Cristofer Jeldes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "¿Qué es ListView?"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 51)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ListView en Visual Basic es un control que permite mostrar datos en forma de list" &
    "a, similar a una tabla." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "¿Para qué sirve ListView?"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(231, 68)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Sirve para mostrar información de manera organizada y fácil de usar, permitiendo " &
    "a los usuarios visualizar y seleccionar datos de forma eficiente."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SiticoneSeparator1
        '
        Me.SiticoneSeparator1.Location = New System.Drawing.Point(15, 153)
        Me.SiticoneSeparator1.Name = "SiticoneSeparator1"
        Me.SiticoneSeparator1.Size = New System.Drawing.Size(228, 13)
        Me.SiticoneSeparator1.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(263, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(256, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "¿Cómo se utiliza en el código fuente?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(286, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
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
        Me.SiticoneRoundedButton5.Location = New System.Drawing.Point(249, 280)
        Me.SiticoneRoundedButton5.Name = "SiticoneRoundedButton5"
        Me.SiticoneRoundedButton5.ShadowDecoration.Parent = Me.SiticoneRoundedButton5
        Me.SiticoneRoundedButton5.Size = New System.Drawing.Size(77, 35)
        Me.SiticoneRoundedButton5.TabIndex = 16
        Me.SiticoneRoundedButton5.Text = "Menú"
        '
        'Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(519, 323)
        Me.Controls.Add(Me.SiticoneRoundedButton5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SiticoneSeparator1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SiticonePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información"
        Me.SiticonePanel1.ResumeLayout(False)
        Me.SiticonePanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SiticonePanel1 As Siticone.UI.WinForms.SiticonePanel
    Friend WithEvents Label2 As Label
    Friend WithEvents SiticoneButton1 As Siticone.UI.WinForms.SiticoneButton
    Friend WithEvents SiticoneDragControl1 As Siticone.UI.WinForms.SiticoneDragControl
    Friend WithEvents SiticoneDragControl2 As Siticone.UI.WinForms.SiticoneDragControl
    Friend WithEvents SiticoneElipse1 As Siticone.UI.WinForms.SiticoneElipse
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SiticoneSeparator1 As Siticone.UI.WinForms.SiticoneSeparator
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SiticoneRoundedButton5 As Siticone.UI.WinForms.SiticoneRoundedButton
End Class
