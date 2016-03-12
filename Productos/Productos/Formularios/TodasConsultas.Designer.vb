<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TodasConsultas
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Total de productos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Consulta por codigo producto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 134)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 31)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Consulta por codigo proveedor"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 171)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(177, 31)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Consulta por valor compra"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 205)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(177, 31)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Productos vencidos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 242)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(177, 31)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Productos no vencidos"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 279)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(177, 31)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Productos vencidos por mes"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(12, 316)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(177, 31)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Productos por nombre"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(12, 351)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(177, 41)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Productos vencidos por rango de fecha"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(12, 19)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(177, 33)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "Total de proveedores"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(12, 398)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(177, 33)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = " Proveedores por codigo"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(12, 437)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(177, 33)
        Me.Button12.TabIndex = 11
        Me.Button12.Text = " Proveedores por nombre"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(12, 482)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(177, 33)
        Me.Button13.TabIndex = 12
        Me.Button13.Text = "Productos ordenados por nombre"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'TodasConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(202, 527)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "TodasConsultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TodasConsultas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
End Class
