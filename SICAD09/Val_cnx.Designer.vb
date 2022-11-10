<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Val_cnx
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Val_cnx))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txb_port = New System.Windows.Forms.TextBox()
        Me.txb_pasw = New System.Windows.Forms.TextBox()
        Me.txb_user = New System.Windows.Forms.TextBox()
        Me.txb_db = New System.Windows.Forms.TextBox()
        Me.txb_server = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 15)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Valores para Conexion"
        '
        'txb_port
        '
        Me.txb_port.Location = New System.Drawing.Point(92, 85)
        Me.txb_port.Name = "txb_port"
        Me.txb_port.Size = New System.Drawing.Size(112, 20)
        Me.txb_port.TabIndex = 38
        Me.txb_port.Text = "5432"
        '
        'txb_pasw
        '
        Me.txb_pasw.Location = New System.Drawing.Point(92, 163)
        Me.txb_pasw.Name = "txb_pasw"
        Me.txb_pasw.Size = New System.Drawing.Size(112, 20)
        Me.txb_pasw.TabIndex = 44
        Me.txb_pasw.UseSystemPasswordChar = True
        '
        'txb_user
        '
        Me.txb_user.Location = New System.Drawing.Point(92, 137)
        Me.txb_user.Name = "txb_user"
        Me.txb_user.Size = New System.Drawing.Size(112, 20)
        Me.txb_user.TabIndex = 42
        Me.txb_user.Text = "domicilio_usr"
        '
        'txb_db
        '
        Me.txb_db.Location = New System.Drawing.Point(92, 111)
        Me.txb_db.Name = "txb_db"
        Me.txb_db.Size = New System.Drawing.Size(112, 20)
        Me.txb_db.TabIndex = 40
        Me.txb_db.Text = "sicorem_vhsa"
        '
        'txb_server
        '
        Me.txb_server.Location = New System.Drawing.Point(92, 59)
        Me.txb_server.Name = "txb_server"
        Me.txb_server.Size = New System.Drawing.Size(112, 20)
        Me.txb_server.TabIndex = 36
        Me.txb_server.Text = "localhost"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "DB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Puerto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Servidor"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(78, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 64)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Conectar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Val_cnx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 272)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txb_port)
        Me.Controls.Add(Me.txb_pasw)
        Me.Controls.Add(Me.txb_user)
        Me.Controls.Add(Me.txb_db)
        Me.Controls.Add(Me.txb_server)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Val_cnx"
        Me.Text = "Val_cnx"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txb_port As TextBox
    Friend WithEvents txb_pasw As TextBox
    Friend WithEvents txb_user As TextBox
    Friend WithEvents txb_db As TextBox
    Friend WithEvents txb_server As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
