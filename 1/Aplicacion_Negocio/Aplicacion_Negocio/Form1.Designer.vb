<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio_de_Sesion1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio_de_Sesion1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtintento = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnsesion = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.txtcuenta = New System.Windows.Forms.TextBox()
        Me.txt11 = New System.Windows.Forms.TextBox()
        Me.lbl111 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(877, 485)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(929, 78)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(63, 13)
        Me.lblfecha.TabIndex = 1
        Me.lblfecha.Text = "LabelFecha"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Location = New System.Drawing.Point(932, 110)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(56, 13)
        Me.lblhora.TabIndex = 2
        Me.lblhora.Text = "LabelHora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(932, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(935, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'txtintento
        '
        Me.txtintento.BackColor = System.Drawing.Color.White
        Me.txtintento.Location = New System.Drawing.Point(932, 212)
        Me.txtintento.Name = "txtintento"
        Me.txtintento.Size = New System.Drawing.Size(100, 20)
        Me.txtintento.TabIndex = 5
        Me.txtintento.Tag = ""
        Me.txtintento.Visible = False
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(262, 99)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(270, 20)
        Me.txtnombre.TabIndex = 6
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(262, 229)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.Size = New System.Drawing.Size(270, 20)
        Me.txtcontraseña.TabIndex = 7
        '
        'Timer1
        '
        '
        'btnsesion
        '
        Me.btnsesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnsesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsesion.Image = CType(resources.GetObject("btnsesion.Image"), System.Drawing.Image)
        Me.btnsesion.Location = New System.Drawing.Point(496, 329)
        Me.btnsesion.Name = "btnsesion"
        Me.btnsesion.Size = New System.Drawing.Size(120, 67)
        Me.btnsesion.TabIndex = 8
        Me.btnsesion.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.Location = New System.Drawing.Point(177, 329)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(122, 67)
        Me.btnsalir.TabIndex = 9
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'txtcuenta
        '
        Me.txtcuenta.Location = New System.Drawing.Point(777, 448)
        Me.txtcuenta.Name = "txtcuenta"
        Me.txtcuenta.Size = New System.Drawing.Size(13, 20)
        Me.txtcuenta.TabIndex = 10
        Me.txtcuenta.Text = "3"
        '
        'txt11
        '
        Me.txt11.Location = New System.Drawing.Point(938, 329)
        Me.txt11.Name = "txt11"
        Me.txt11.Size = New System.Drawing.Size(100, 20)
        Me.txt11.TabIndex = 11
        Me.txt11.Visible = False
        '
        'lbl111
        '
        Me.lbl111.AutoSize = True
        Me.lbl111.Location = New System.Drawing.Point(638, 451)
        Me.lbl111.Name = "lbl111"
        Me.lbl111.Size = New System.Drawing.Size(133, 13)
        Me.lbl111.TabIndex = 12
        Me.lbl111.Text = "INTENTOS RESTANTES:"
        '
        'Inicio_de_Sesion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 480)
        Me.Controls.Add(Me.lbl111)
        Me.Controls.Add(Me.txt11)
        Me.Controls.Add(Me.txtcuenta)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnsesion)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtintento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Inicio_de_Sesion1"
        Me.Text = "Inicio de Sesion "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblfecha As Label
    Friend WithEvents lblhora As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtintento As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnsesion As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents txtcuenta As TextBox
    Friend WithEvents txt11 As TextBox
    Friend WithEvents lbl111 As Label
End Class
