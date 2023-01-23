<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu1))
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnañadir = New System.Windows.Forms.Button()
        Me.btnconsultar = New System.Windows.Forms.Button()
        Me.btnventas = New System.Windows.Forms.Button()
        Me.btncompras = New System.Windows.Forms.Button()
        Me.btnadministrador = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(395, 178)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(8, 8)
        Me.PrintPreviewControl1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1433, 812)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnañadir
        '
        Me.btnañadir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnañadir.Image = CType(resources.GetObject("btnañadir.Image"), System.Drawing.Image)
        Me.btnañadir.Location = New System.Drawing.Point(210, 213)
        Me.btnañadir.Name = "btnañadir"
        Me.btnañadir.Size = New System.Drawing.Size(193, 68)
        Me.btnañadir.TabIndex = 2
        Me.btnañadir.UseVisualStyleBackColor = True
        '
        'btnconsultar
        '
        Me.btnconsultar.BackgroundImage = CType(resources.GetObject("btnconsultar.BackgroundImage"), System.Drawing.Image)
        Me.btnconsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnconsultar.Image = CType(resources.GetObject("btnconsultar.Image"), System.Drawing.Image)
        Me.btnconsultar.Location = New System.Drawing.Point(210, 362)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.Size = New System.Drawing.Size(193, 68)
        Me.btnconsultar.TabIndex = 3
        Me.btnconsultar.UseVisualStyleBackColor = True
        '
        'btnventas
        '
        Me.btnventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnventas.Image = CType(resources.GetObject("btnventas.Image"), System.Drawing.Image)
        Me.btnventas.Location = New System.Drawing.Point(778, 213)
        Me.btnventas.Name = "btnventas"
        Me.btnventas.Size = New System.Drawing.Size(195, 66)
        Me.btnventas.TabIndex = 4
        Me.btnventas.UseVisualStyleBackColor = True
        '
        'btncompras
        '
        Me.btncompras.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncompras.Image = CType(resources.GetObject("btncompras.Image"), System.Drawing.Image)
        Me.btncompras.Location = New System.Drawing.Point(780, 362)
        Me.btncompras.Name = "btncompras"
        Me.btncompras.Size = New System.Drawing.Size(193, 68)
        Me.btncompras.TabIndex = 5
        Me.btncompras.UseVisualStyleBackColor = False
        '
        'btnadministrador
        '
        Me.btnadministrador.BackgroundImage = CType(resources.GetObject("btnadministrador.BackgroundImage"), System.Drawing.Image)
        Me.btnadministrador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadministrador.Image = CType(resources.GetObject("btnadministrador.Image"), System.Drawing.Image)
        Me.btnadministrador.Location = New System.Drawing.Point(455, 529)
        Me.btnadministrador.Name = "btnadministrador"
        Me.btnadministrador.Size = New System.Drawing.Size(284, 92)
        Me.btnadministrador.TabIndex = 6
        Me.btnadministrador.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.Location = New System.Drawing.Point(12, 596)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(209, 75)
        Me.btnsalir.TabIndex = 7
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-30, 567)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(283, 286)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Menu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 683)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnadministrador)
        Me.Controls.Add(Me.btncompras)
        Me.Controls.Add(Me.btnventas)
        Me.Controls.Add(Me.btnconsultar)
        Me.Controls.Add(Me.btnañadir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Name = "Menu1"
        Me.Text = "Menu1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnañadir As Button
    Friend WithEvents btnconsultar As Button
    Friend WithEvents btnventas As Button
    Friend WithEvents btncompras As Button
    Friend WithEvents btnadministrador As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
