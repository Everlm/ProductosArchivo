<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProveedoresPorCodigo
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
        Me.GrillaProveedor = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodigoprovee = New System.Windows.Forms.TextBox()
        CType(Me.GrillaProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrillaProveedor
        '
        Me.GrillaProveedor.AllowUserToAddRows = False
        Me.GrillaProveedor.AllowUserToDeleteRows = False
        Me.GrillaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.GrillaProveedor.Location = New System.Drawing.Point(0, 78)
        Me.GrillaProveedor.Name = "GrillaProveedor"
        Me.GrillaProveedor.ReadOnly = True
        Me.GrillaProveedor.Size = New System.Drawing.Size(466, 365)
        Me.GrillaProveedor.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo Proveedor"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 214
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre Proveedor"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 214
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo proveedor"
        '
        'txtcodigoprovee
        '
        Me.txtcodigoprovee.Location = New System.Drawing.Point(139, 28)
        Me.txtcodigoprovee.Name = "txtcodigoprovee"
        Me.txtcodigoprovee.Size = New System.Drawing.Size(123, 20)
        Me.txtcodigoprovee.TabIndex = 4
        '
        'ProveedoresPorCodigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 436)
        Me.Controls.Add(Me.txtcodigoprovee)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrillaProveedor)
        Me.Name = "ProveedoresPorCodigo"
        Me.Text = "ProveedoresPorCodigo"
        CType(Me.GrillaProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrillaProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoprovee As System.Windows.Forms.TextBox
End Class
