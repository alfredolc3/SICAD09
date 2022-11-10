<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_102_rangos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cbx_anio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txb_smgv = New System.Windows.Forms.TextBox()
        Me.Txb_r1 = New System.Windows.Forms.TextBox()
        Me.Txb_min_r1 = New System.Windows.Forms.TextBox()
        Me.Txb_max_r1 = New System.Windows.Forms.TextBox()
        Me.Txb_max_r2 = New System.Windows.Forms.TextBox()
        Me.Txb_min_r2 = New System.Windows.Forms.TextBox()
        Me.Txb_r2 = New System.Windows.Forms.TextBox()
        Me.Txb_max_r3 = New System.Windows.Forms.TextBox()
        Me.Txb_min_r3 = New System.Windows.Forms.TextBox()
        Me.Txb_r3 = New System.Windows.Forms.TextBox()
        Me.Txb_max_r4 = New System.Windows.Forms.TextBox()
        Me.Txb_min_r4 = New System.Windows.Forms.TextBox()
        Me.Txb_r4 = New System.Windows.Forms.TextBox()
        Me.Txb_max_r5 = New System.Windows.Forms.TextBox()
        Me.Txb_min_r5 = New System.Windows.Forms.TextBox()
        Me.Txb_r5 = New System.Windows.Forms.TextBox()
        Me.Btn_nuevo = New System.Windows.Forms.Button()
        Me.Txb_smgv_edit = New System.Windows.Forms.TextBox()
        Me.Txb_anio_edit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_modif = New System.Windows.Forms.Button()
        Me.Btn_guardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AÑO"
        '
        'Cbx_anio
        '
        Me.Cbx_anio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_anio.FormattingEnabled = True
        Me.Cbx_anio.Location = New System.Drawing.Point(48, 70)
        Me.Cbx_anio.Name = "Cbx_anio"
        Me.Cbx_anio.Size = New System.Drawing.Size(87, 26)
        Me.Cbx_anio.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(328, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RANGO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(497, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "MINIMO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(646, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "MAXIMO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(193, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "SMGV"
        '
        'Txb_smgv
        '
        Me.Txb_smgv.Enabled = False
        Me.Txb_smgv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_smgv.Location = New System.Drawing.Point(171, 70)
        Me.Txb_smgv.Name = "Txb_smgv"
        Me.Txb_smgv.Size = New System.Drawing.Size(100, 26)
        Me.Txb_smgv.TabIndex = 1
        Me.Txb_smgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_r1
        '
        Me.Txb_r1.Enabled = False
        Me.Txb_r1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_r1.Location = New System.Drawing.Point(313, 70)
        Me.Txb_r1.Name = "Txb_r1"
        Me.Txb_r1.Size = New System.Drawing.Size(100, 26)
        Me.Txb_r1.TabIndex = 7
        Me.Txb_r1.TabStop = False
        Me.Txb_r1.Text = "1"
        Me.Txb_r1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txb_min_r1
        '
        Me.Txb_min_r1.Enabled = False
        Me.Txb_min_r1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_min_r1.Location = New System.Drawing.Point(459, 70)
        Me.Txb_min_r1.Name = "Txb_min_r1"
        Me.Txb_min_r1.Size = New System.Drawing.Size(144, 26)
        Me.Txb_min_r1.TabIndex = 8
        Me.Txb_min_r1.TabStop = False
        Me.Txb_min_r1.Text = "0.01"
        Me.Txb_min_r1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_max_r1
        '
        Me.Txb_max_r1.Enabled = False
        Me.Txb_max_r1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_max_r1.Location = New System.Drawing.Point(612, 70)
        Me.Txb_max_r1.Name = "Txb_max_r1"
        Me.Txb_max_r1.Size = New System.Drawing.Size(144, 26)
        Me.Txb_max_r1.TabIndex = 9
        Me.Txb_max_r1.TabStop = False
        Me.Txb_max_r1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_max_r2
        '
        Me.Txb_max_r2.Enabled = False
        Me.Txb_max_r2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_max_r2.Location = New System.Drawing.Point(612, 114)
        Me.Txb_max_r2.Name = "Txb_max_r2"
        Me.Txb_max_r2.Size = New System.Drawing.Size(144, 26)
        Me.Txb_max_r2.TabIndex = 12
        Me.Txb_max_r2.TabStop = False
        Me.Txb_max_r2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_min_r2
        '
        Me.Txb_min_r2.Enabled = False
        Me.Txb_min_r2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_min_r2.Location = New System.Drawing.Point(459, 114)
        Me.Txb_min_r2.Name = "Txb_min_r2"
        Me.Txb_min_r2.Size = New System.Drawing.Size(144, 26)
        Me.Txb_min_r2.TabIndex = 11
        Me.Txb_min_r2.TabStop = False
        Me.Txb_min_r2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_r2
        '
        Me.Txb_r2.Enabled = False
        Me.Txb_r2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_r2.Location = New System.Drawing.Point(313, 114)
        Me.Txb_r2.Name = "Txb_r2"
        Me.Txb_r2.Size = New System.Drawing.Size(100, 26)
        Me.Txb_r2.TabIndex = 10
        Me.Txb_r2.TabStop = False
        Me.Txb_r2.Text = "2"
        Me.Txb_r2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txb_max_r3
        '
        Me.Txb_max_r3.Enabled = False
        Me.Txb_max_r3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_max_r3.Location = New System.Drawing.Point(612, 158)
        Me.Txb_max_r3.Name = "Txb_max_r3"
        Me.Txb_max_r3.Size = New System.Drawing.Size(144, 26)
        Me.Txb_max_r3.TabIndex = 15
        Me.Txb_max_r3.TabStop = False
        Me.Txb_max_r3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_min_r3
        '
        Me.Txb_min_r3.Enabled = False
        Me.Txb_min_r3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_min_r3.Location = New System.Drawing.Point(459, 158)
        Me.Txb_min_r3.Name = "Txb_min_r3"
        Me.Txb_min_r3.Size = New System.Drawing.Size(144, 26)
        Me.Txb_min_r3.TabIndex = 14
        Me.Txb_min_r3.TabStop = False
        Me.Txb_min_r3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_r3
        '
        Me.Txb_r3.Enabled = False
        Me.Txb_r3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_r3.Location = New System.Drawing.Point(313, 158)
        Me.Txb_r3.Name = "Txb_r3"
        Me.Txb_r3.Size = New System.Drawing.Size(100, 26)
        Me.Txb_r3.TabIndex = 13
        Me.Txb_r3.TabStop = False
        Me.Txb_r3.Text = "3"
        Me.Txb_r3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txb_max_r4
        '
        Me.Txb_max_r4.Enabled = False
        Me.Txb_max_r4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_max_r4.Location = New System.Drawing.Point(612, 202)
        Me.Txb_max_r4.Name = "Txb_max_r4"
        Me.Txb_max_r4.Size = New System.Drawing.Size(144, 26)
        Me.Txb_max_r4.TabIndex = 18
        Me.Txb_max_r4.TabStop = False
        Me.Txb_max_r4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_min_r4
        '
        Me.Txb_min_r4.Enabled = False
        Me.Txb_min_r4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_min_r4.Location = New System.Drawing.Point(459, 202)
        Me.Txb_min_r4.Name = "Txb_min_r4"
        Me.Txb_min_r4.Size = New System.Drawing.Size(144, 26)
        Me.Txb_min_r4.TabIndex = 17
        Me.Txb_min_r4.TabStop = False
        Me.Txb_min_r4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_r4
        '
        Me.Txb_r4.Enabled = False
        Me.Txb_r4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_r4.Location = New System.Drawing.Point(313, 202)
        Me.Txb_r4.Name = "Txb_r4"
        Me.Txb_r4.Size = New System.Drawing.Size(100, 26)
        Me.Txb_r4.TabIndex = 16
        Me.Txb_r4.TabStop = False
        Me.Txb_r4.Text = "4"
        Me.Txb_r4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txb_max_r5
        '
        Me.Txb_max_r5.Enabled = False
        Me.Txb_max_r5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_max_r5.Location = New System.Drawing.Point(612, 246)
        Me.Txb_max_r5.Name = "Txb_max_r5"
        Me.Txb_max_r5.Size = New System.Drawing.Size(144, 26)
        Me.Txb_max_r5.TabIndex = 21
        Me.Txb_max_r5.TabStop = False
        Me.Txb_max_r5.Text = "$999,999,999.99"
        Me.Txb_max_r5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txb_min_r5
        '
        Me.Txb_min_r5.Enabled = False
        Me.Txb_min_r5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_min_r5.Location = New System.Drawing.Point(459, 246)
        Me.Txb_min_r5.Name = "Txb_min_r5"
        Me.Txb_min_r5.Size = New System.Drawing.Size(144, 26)
        Me.Txb_min_r5.TabIndex = 20
        Me.Txb_min_r5.TabStop = False
        Me.Txb_min_r5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_r5
        '
        Me.Txb_r5.Enabled = False
        Me.Txb_r5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_r5.Location = New System.Drawing.Point(313, 246)
        Me.Txb_r5.Name = "Txb_r5"
        Me.Txb_r5.Size = New System.Drawing.Size(100, 26)
        Me.Txb_r5.TabIndex = 19
        Me.Txb_r5.TabStop = False
        Me.Txb_r5.Text = "5"
        Me.Txb_r5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_nuevo
        '
        Me.Btn_nuevo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_nuevo.Location = New System.Drawing.Point(39, 271)
        Me.Btn_nuevo.Name = "Btn_nuevo"
        Me.Btn_nuevo.Size = New System.Drawing.Size(96, 65)
        Me.Btn_nuevo.TabIndex = 2
        Me.Btn_nuevo.Text = "Agregar Nuevo SMGV"
        Me.Btn_nuevo.UseVisualStyleBackColor = True
        '
        'Txb_smgv_edit
        '
        Me.Txb_smgv_edit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_smgv_edit.Location = New System.Drawing.Point(162, 387)
        Me.Txb_smgv_edit.Name = "Txb_smgv_edit"
        Me.Txb_smgv_edit.Size = New System.Drawing.Size(100, 26)
        Me.Txb_smgv_edit.TabIndex = 5
        Me.Txb_smgv_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txb_smgv_edit.Visible = False
        '
        'Txb_anio_edit
        '
        Me.Txb_anio_edit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_anio_edit.Location = New System.Drawing.Point(39, 387)
        Me.Txb_anio_edit.Name = "Txb_anio_edit"
        Me.Txb_anio_edit.Size = New System.Drawing.Size(95, 26)
        Me.Txb_anio_edit.TabIndex = 4
        Me.Txb_anio_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txb_anio_edit.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(184, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "SMGV"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(60, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 18)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "AÑO"
        Me.Label7.Visible = False
        '
        'Btn_modif
        '
        Me.Btn_modif.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_modif.Location = New System.Drawing.Point(162, 271)
        Me.Btn_modif.Name = "Btn_modif"
        Me.Btn_modif.Size = New System.Drawing.Size(96, 65)
        Me.Btn_modif.TabIndex = 3
        Me.Btn_modif.Text = "Modificar Smgv"
        Me.Btn_modif.UseVisualStyleBackColor = True
        '
        'Btn_guardar
        '
        Me.Btn_guardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_guardar.Location = New System.Drawing.Point(313, 378)
        Me.Btn_guardar.Name = "Btn_guardar"
        Me.Btn_guardar.Size = New System.Drawing.Size(96, 35)
        Me.Btn_guardar.TabIndex = 6
        Me.Btn_guardar.Text = "Guardar"
        Me.Btn_guardar.UseVisualStyleBackColor = True
        Me.Btn_guardar.Visible = False
        '
        'Frm_102_rangos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Cbx_anio)
        Me.Controls.Add(Me.Txb_smgv)
        Me.Controls.Add(Me.Txb_smgv_edit)
        Me.Controls.Add(Me.Txb_anio_edit)
        Me.Controls.Add(Me.Txb_max_r5)
        Me.Controls.Add(Me.Txb_min_r5)
        Me.Controls.Add(Me.Txb_r5)
        Me.Controls.Add(Me.Txb_max_r4)
        Me.Controls.Add(Me.Txb_min_r4)
        Me.Controls.Add(Me.Txb_r4)
        Me.Controls.Add(Me.Txb_max_r3)
        Me.Controls.Add(Me.Txb_min_r3)
        Me.Controls.Add(Me.Txb_r3)
        Me.Controls.Add(Me.Txb_max_r2)
        Me.Controls.Add(Me.Txb_min_r2)
        Me.Controls.Add(Me.Txb_r2)
        Me.Controls.Add(Me.Txb_max_r1)
        Me.Controls.Add(Me.Txb_min_r1)
        Me.Controls.Add(Me.Txb_r1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_nuevo)
        Me.Controls.Add(Me.Btn_modif)
        Me.Controls.Add(Me.Btn_guardar)
        Me.Name = "Frm_102_rangos"
        Me.Text = "Configuracion de Rangos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Cbx_anio As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txb_smgv As TextBox
    Friend WithEvents Txb_r1 As TextBox
    Friend WithEvents Txb_min_r1 As TextBox
    Friend WithEvents Txb_max_r1 As TextBox
    Friend WithEvents Txb_max_r2 As TextBox
    Friend WithEvents Txb_min_r2 As TextBox
    Friend WithEvents Txb_r2 As TextBox
    Friend WithEvents Txb_max_r3 As TextBox
    Friend WithEvents Txb_min_r3 As TextBox
    Friend WithEvents Txb_r3 As TextBox
    Friend WithEvents Txb_max_r4 As TextBox
    Friend WithEvents Txb_min_r4 As TextBox
    Friend WithEvents Txb_r4 As TextBox
    Friend WithEvents Txb_max_r5 As TextBox
    Friend WithEvents Txb_min_r5 As TextBox
    Friend WithEvents Txb_r5 As TextBox
    Friend WithEvents Btn_nuevo As Button
    Friend WithEvents Txb_smgv_edit As TextBox
    Friend WithEvents Txb_anio_edit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Btn_modif As Button
    Friend WithEvents Btn_guardar As Button
End Class
