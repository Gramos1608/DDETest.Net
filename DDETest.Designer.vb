<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DDETest
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
        Me.TApp = New System.Windows.Forms.TextBox()
        Me.TTopico = New System.Windows.Forms.TextBox()
        Me.TItem = New System.Windows.Forms.TextBox()
        Me.BLeer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TDatoLectura = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BEscribir = New System.Windows.Forms.Button()
        Me.TDatoEscribir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TApp
        '
        Me.TApp.Location = New System.Drawing.Point(124, 29)
        Me.TApp.Name = "TApp"
        Me.TApp.Size = New System.Drawing.Size(129, 20)
        Me.TApp.TabIndex = 0
        Me.TApp.Text = "CR_DDE"
        '
        'TTopico
        '
        Me.TTopico.Location = New System.Drawing.Point(124, 55)
        Me.TTopico.Name = "TTopico"
        Me.TTopico.Size = New System.Drawing.Size(129, 20)
        Me.TTopico.TabIndex = 1
        Me.TTopico.Text = "Cr500_No1"
        '
        'TItem
        '
        Me.TItem.Location = New System.Drawing.Point(124, 81)
        Me.TItem.Name = "TItem"
        Me.TItem.Size = New System.Drawing.Size(129, 20)
        Me.TItem.TabIndex = 2
        Me.TItem.Text = "RTCC"
        '
        'BLeer
        '
        Me.BLeer.Location = New System.Drawing.Point(25, 19)
        Me.BLeer.Name = "BLeer"
        Me.BLeer.Size = New System.Drawing.Size(129, 35)
        Me.BLeer.TabIndex = 3
        Me.BLeer.Text = "Leer"
        Me.BLeer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Aplicación:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tópico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Item:"
        '
        'TDatoLectura
        '
        Me.TDatoLectura.Location = New System.Drawing.Point(60, 60)
        Me.TDatoLectura.Name = "TDatoLectura"
        Me.TDatoLectura.Size = New System.Drawing.Size(94, 20)
        Me.TDatoLectura.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Dato:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BLeer)
        Me.GroupBox1.Controls.Add(Me.TDatoLectura)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 99)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BEscribir)
        Me.GroupBox2.Controls.Add(Me.TDatoEscribir)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 99)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'BEscribir
        '
        Me.BEscribir.Location = New System.Drawing.Point(25, 45)
        Me.BEscribir.Name = "BEscribir"
        Me.BEscribir.Size = New System.Drawing.Size(129, 35)
        Me.BEscribir.TabIndex = 3
        Me.BEscribir.Text = "Escribir"
        Me.BEscribir.UseVisualStyleBackColor = True
        '
        'TDatoEscribir
        '
        Me.TDatoEscribir.Location = New System.Drawing.Point(60, 19)
        Me.TDatoEscribir.Name = "TDatoEscribir"
        Me.TDatoEscribir.Size = New System.Drawing.Size(94, 20)
        Me.TDatoEscribir.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dato:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TItem)
        Me.GroupBox3.Controls.Add(Me.TTopico)
        Me.GroupBox3.Controls.Add(Me.TApp)
        Me.GroupBox3.Location = New System.Drawing.Point(43, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 118)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Conexión"
        '
        'DDETest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 307)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DDETest"
        Me.Text = "DDETest"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TApp As System.Windows.Forms.TextBox
    Friend WithEvents TTopico As System.Windows.Forms.TextBox
    Friend WithEvents TItem As System.Windows.Forms.TextBox
    Friend WithEvents BLeer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TDatoLectura As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BEscribir As System.Windows.Forms.Button
    Friend WithEvents TDatoEscribir As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

End Class
