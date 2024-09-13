<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelDatoAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelDatoAdmin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SiticoneRoundedButton1 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SiticoneRoundedButton4 = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SiticoneDragControl1 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
        Me.SiticoneDragControl2 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
        Me.SiticoneElipse1 = New Siticone.UI.WinForms.SiticoneElipse(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(52, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 19)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Seleccione un campo para eliminar."
        '
        'SiticoneRoundedButton1
        '
        Me.SiticoneRoundedButton1.CheckedState.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.CustomImages.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticoneRoundedButton1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneRoundedButton1.ForeColor = System.Drawing.Color.White
        Me.SiticoneRoundedButton1.HoveredState.FillColor = System.Drawing.Color.Red
        Me.SiticoneRoundedButton1.HoveredState.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.Location = New System.Drawing.Point(175, 125)
        Me.SiticoneRoundedButton1.Name = "SiticoneRoundedButton1"
        Me.SiticoneRoundedButton1.ShadowDecoration.Parent = Me.SiticoneRoundedButton1
        Me.SiticoneRoundedButton1.Size = New System.Drawing.Size(88, 35)
        Me.SiticoneRoundedButton1.TabIndex = 27
        Me.SiticoneRoundedButton1.Text = "Salir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(117, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 26
        '
        'SiticoneRoundedButton4
        '
        Me.SiticoneRoundedButton4.CheckedState.Parent = Me.SiticoneRoundedButton4
        Me.SiticoneRoundedButton4.CustomImages.Parent = Me.SiticoneRoundedButton4
        Me.SiticoneRoundedButton4.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SiticoneRoundedButton4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneRoundedButton4.ForeColor = System.Drawing.Color.White
        Me.SiticoneRoundedButton4.HoveredState.FillColor = System.Drawing.Color.Red
        Me.SiticoneRoundedButton4.HoveredState.Parent = Me.SiticoneRoundedButton4
        Me.SiticoneRoundedButton4.Location = New System.Drawing.Point(63, 125)
        Me.SiticoneRoundedButton4.Name = "SiticoneRoundedButton4"
        Me.SiticoneRoundedButton4.ShadowDecoration.Parent = Me.SiticoneRoundedButton4
        Me.SiticoneRoundedButton4.Size = New System.Drawing.Size(92, 35)
        Me.SiticoneRoundedButton4.TabIndex = 25
        Me.SiticoneRoundedButton4.Text = "Reintentar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 26)
        Me.Panel1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(120, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Advertencia"
        '
        'SiticoneDragControl1
        '
        Me.SiticoneDragControl1.TargetControl = Me.Label2
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
        'SelDatoAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(326, 171)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SiticoneRoundedButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SiticoneRoundedButton4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SelDatoAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advertencia"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SiticoneRoundedButton1 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents Label3 As Label
    Friend WithEvents SiticoneRoundedButton4 As Siticone.UI.WinForms.SiticoneRoundedButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents SiticoneDragControl1 As Siticone.UI.WinForms.SiticoneDragControl
    Friend WithEvents SiticoneDragControl2 As Siticone.UI.WinForms.SiticoneDragControl
    Friend WithEvents SiticoneElipse1 As Siticone.UI.WinForms.SiticoneElipse
End Class
