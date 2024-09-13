<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfEliminar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfEliminar))
        Me.SiticoneRoundedButton1 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.SiticoneRoundedButton2 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SiticoneDragControl1 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
        Me.SiticoneDragControl2 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
        Me.SiticoneElipse1 = New Siticone.UI.WinForms.SiticoneElipse(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SiticoneRoundedButton1
        '
        Me.SiticoneRoundedButton1.CheckedState.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.CustomImages.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticoneRoundedButton1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneRoundedButton1.ForeColor = System.Drawing.Color.White
        Me.SiticoneRoundedButton1.HoveredState.FillColor = System.Drawing.Color.Red
        Me.SiticoneRoundedButton1.HoveredState.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.Image = CType(resources.GetObject("SiticoneRoundedButton1.Image"), System.Drawing.Image)
        Me.SiticoneRoundedButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SiticoneRoundedButton1.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.SiticoneRoundedButton1.ImageSize = New System.Drawing.Size(20, 25)
        Me.SiticoneRoundedButton1.Location = New System.Drawing.Point(147, 124)
        Me.SiticoneRoundedButton1.Name = "SiticoneRoundedButton1"
        Me.SiticoneRoundedButton1.ShadowDecoration.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.Size = New System.Drawing.Size(74, 35)
        Me.SiticoneRoundedButton1.TabIndex = 21
        Me.SiticoneRoundedButton1.Text = "Si"
        '
        'SiticoneRoundedButton2
        '
        Me.SiticoneRoundedButton2.CheckedState.Parent = Me.SiticoneRoundedButton2
        Me.SiticoneRoundedButton2.CustomImages.Parent = Me.SiticoneRoundedButton2
        Me.SiticoneRoundedButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticoneRoundedButton2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneRoundedButton2.ForeColor = System.Drawing.Color.White
        Me.SiticoneRoundedButton2.HoveredState.FillColor = System.Drawing.Color.Red
        Me.SiticoneRoundedButton2.HoveredState.Parent = Me.SiticoneRoundedButton2
        Me.SiticoneRoundedButton2.Image = CType(resources.GetObject("SiticoneRoundedButton2.Image"), System.Drawing.Image)
        Me.SiticoneRoundedButton2.Location = New System.Drawing.Point(236, 124)
        Me.SiticoneRoundedButton2.Name = "SiticoneRoundedButton2"
        Me.SiticoneRoundedButton2.ShadowDecoration.Parent = Me.SiticoneRoundedButton2
        Me.SiticoneRoundedButton2.Size = New System.Drawing.Size(78, 35)
        Me.SiticoneRoundedButton2.TabIndex = 22
        Me.SiticoneRoundedButton2.Text = "No"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 26)
        Me.Panel1.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(120, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Advertencia"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label2.Location = New System.Drawing.Point(120, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 19)
        Me.Label2.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 42)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "¿Está seguro de que desea eliminar los registros seleccionados?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'SiticoneDragControl1
        '
        Me.SiticoneDragControl1.TargetControl = Me.Label3
        '
        'SiticoneDragControl2
        '
        Me.SiticoneDragControl2.TargetControl = Me.Panel1
        '
        'SiticoneElipse1
        '
        Me.SiticoneElipse1.BorderRadius = 10
        Me.SiticoneElipse1.TargetControl = Me
        '
        'ConfEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(326, 171)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SiticoneRoundedButton2)
        Me.Controls.Add(Me.SiticoneRoundedButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConfEliminar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advertencia"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SiticoneRoundedButton1 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents SiticoneRoundedButton2 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SiticoneDragControl1 As Siticone.UI.WinForms.SiticoneDragControl
    Friend WithEvents SiticoneDragControl2 As Siticone.UI.WinForms.SiticoneDragControl
    Friend WithEvents SiticoneElipse1 As Siticone.UI.WinForms.SiticoneElipse
End Class
