<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_02_asignacion
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
        Me.Dgv_patrones_asignados = New System.Windows.Forms.DataGridView()
        Me.Lbl_rango = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txb_imp_tot = New System.Windows.Forms.TextBox()
        Me.Txb_imp_rcv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txb_imp_cop = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txb_cant_cop = New System.Windows.Forms.TextBox()
        Me.Txb_cant_rcv = New System.Windows.Forms.TextBox()
        Me.Txb_can_tot = New System.Windows.Forms.TextBox()
        Me.Txb_reg_pat = New System.Windows.Forms.TextBox()
        Me.Txb_dig_rp = New System.Windows.Forms.TextBox()
        Me.Txb_raz_soc = New System.Windows.Forms.TextBox()
        Me.Txb_domicilio = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cbx_dias_nl = New System.Windows.Forms.ComboBox()
        Me.Dtp_vencimiento_nl = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Btn_update = New System.Windows.Forms.Button()
        Me.Btn_save = New System.Windows.Forms.Button()
        Me.Btn_clean = New System.Windows.Forms.Button()
        Me.Cbx_nl = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Dtp_asig_nl = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Dtp_asig_loc = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cbx_localizadores = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Cbx_dias_loc = New System.Windows.Forms.ComboBox()
        Me.Dtp_vencimiento_loc = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TODOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SINASIGNACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SINNLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SINLOCALIZADORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASIGNADOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PLANTILLASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_imp_con_nl = New System.Windows.Forms.Button()
        Me.Btn_imp_con_loc = New System.Windows.Forms.Button()
        Me.Lbl_idpatronnl = New System.Windows.Forms.Label()
        Me.Lbl_acta_circ = New System.Windows.Forms.Label()
        Me.Lbl_titulo = New System.Windows.Forms.Label()
        CType(Me.Dgv_patrones_asignados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_patrones_asignados
        '
        Me.Dgv_patrones_asignados.AllowUserToAddRows = False
        Me.Dgv_patrones_asignados.AllowUserToDeleteRows = False
        Me.Dgv_patrones_asignados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_patrones_asignados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_patrones_asignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_patrones_asignados.Location = New System.Drawing.Point(12, 76)
        Me.Dgv_patrones_asignados.Name = "Dgv_patrones_asignados"
        Me.Dgv_patrones_asignados.ReadOnly = True
        Me.Dgv_patrones_asignados.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_patrones_asignados.Size = New System.Drawing.Size(1133, 228)
        Me.Dgv_patrones_asignados.TabIndex = 106
        '
        'Lbl_rango
        '
        Me.Lbl_rango.AutoSize = True
        Me.Lbl_rango.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_rango.Location = New System.Drawing.Point(833, 330)
        Me.Lbl_rango.Name = "Lbl_rango"
        Me.Lbl_rango.Size = New System.Drawing.Size(26, 28)
        Me.Lbl_rango.TabIndex = 110
        Me.Lbl_rango.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(762, 339)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 17)
        Me.Label22.TabIndex = 109
        Me.Label22.Text = "RANGO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(516, 322)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 17)
        Me.Label16.TabIndex = 108
        Me.Label16.Text = "Importe Total"
        '
        'Txb_imp_tot
        '
        Me.Txb_imp_tot.Enabled = False
        Me.Txb_imp_tot.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_imp_tot.Location = New System.Drawing.Point(519, 350)
        Me.Txb_imp_tot.MaxLength = 100
        Me.Txb_imp_tot.Name = "Txb_imp_tot"
        Me.Txb_imp_tot.Size = New System.Drawing.Size(196, 26)
        Me.Txb_imp_tot.TabIndex = 107
        Me.Txb_imp_tot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_imp_rcv
        '
        Me.Txb_imp_rcv.Enabled = False
        Me.Txb_imp_rcv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_imp_rcv.Location = New System.Drawing.Point(281, 350)
        Me.Txb_imp_rcv.MaxLength = 100
        Me.Txb_imp_rcv.Name = "Txb_imp_rcv"
        Me.Txb_imp_rcv.Size = New System.Drawing.Size(196, 26)
        Me.Txb_imp_rcv.TabIndex = 111
        Me.Txb_imp_rcv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "RCV"
        '
        'Txb_imp_cop
        '
        Me.Txb_imp_cop.Enabled = False
        Me.Txb_imp_cop.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_imp_cop.Location = New System.Drawing.Point(28, 350)
        Me.Txb_imp_cop.MaxLength = 100
        Me.Txb_imp_cop.Name = "Txb_imp_cop"
        Me.Txb_imp_cop.Size = New System.Drawing.Size(196, 26)
        Me.Txb_imp_cop.TabIndex = 113
        Me.Txb_imp_cop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "COP"
        '
        'Txb_cant_cop
        '
        Me.Txb_cant_cop.Enabled = False
        Me.Txb_cant_cop.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_cant_cop.Location = New System.Drawing.Point(141, 318)
        Me.Txb_cant_cop.MaxLength = 100
        Me.Txb_cant_cop.Name = "Txb_cant_cop"
        Me.Txb_cant_cop.Size = New System.Drawing.Size(83, 26)
        Me.Txb_cant_cop.TabIndex = 115
        Me.Txb_cant_cop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_cant_rcv
        '
        Me.Txb_cant_rcv.Enabled = False
        Me.Txb_cant_rcv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_cant_rcv.Location = New System.Drawing.Point(394, 318)
        Me.Txb_cant_rcv.MaxLength = 100
        Me.Txb_cant_rcv.Name = "Txb_cant_rcv"
        Me.Txb_cant_rcv.Size = New System.Drawing.Size(83, 26)
        Me.Txb_cant_rcv.TabIndex = 116
        Me.Txb_cant_rcv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_can_tot
        '
        Me.Txb_can_tot.Enabled = False
        Me.Txb_can_tot.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_can_tot.Location = New System.Drawing.Point(632, 318)
        Me.Txb_can_tot.MaxLength = 100
        Me.Txb_can_tot.Name = "Txb_can_tot"
        Me.Txb_can_tot.Size = New System.Drawing.Size(83, 26)
        Me.Txb_can_tot.TabIndex = 117
        Me.Txb_can_tot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_reg_pat
        '
        Me.Txb_reg_pat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txb_reg_pat.Enabled = False
        Me.Txb_reg_pat.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_reg_pat.Location = New System.Drawing.Point(28, 409)
        Me.Txb_reg_pat.MaxLength = 10
        Me.Txb_reg_pat.Name = "Txb_reg_pat"
        Me.Txb_reg_pat.Size = New System.Drawing.Size(114, 26)
        Me.Txb_reg_pat.TabIndex = 122
        '
        'Txb_dig_rp
        '
        Me.Txb_dig_rp.Enabled = False
        Me.Txb_dig_rp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_dig_rp.Location = New System.Drawing.Point(157, 409)
        Me.Txb_dig_rp.MaxLength = 1
        Me.Txb_dig_rp.Name = "Txb_dig_rp"
        Me.Txb_dig_rp.Size = New System.Drawing.Size(30, 26)
        Me.Txb_dig_rp.TabIndex = 123
        '
        'Txb_raz_soc
        '
        Me.Txb_raz_soc.Enabled = False
        Me.Txb_raz_soc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_raz_soc.Location = New System.Drawing.Point(198, 409)
        Me.Txb_raz_soc.MaxLength = 100
        Me.Txb_raz_soc.Name = "Txb_raz_soc"
        Me.Txb_raz_soc.Size = New System.Drawing.Size(593, 26)
        Me.Txb_raz_soc.TabIndex = 124
        '
        'Txb_domicilio
        '
        Me.Txb_domicilio.Enabled = False
        Me.Txb_domicilio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_domicilio.Location = New System.Drawing.Point(28, 458)
        Me.Txb_domicilio.MaxLength = 100
        Me.Txb_domicilio.Multiline = True
        Me.Txb_domicilio.Name = "Txb_domicilio"
        Me.Txb_domicilio.Size = New System.Drawing.Size(763, 53)
        Me.Txb_domicilio.TabIndex = 129
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(25, 438)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(75, 17)
        Me.Label23.TabIndex = 128
        Me.Label23.Text = "Domicilio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(143, 413)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 17)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(195, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Razon Social"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 17)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "Registro Patronal"
        '
        'Cbx_dias_nl
        '
        Me.Cbx_dias_nl.Enabled = False
        Me.Cbx_dias_nl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_dias_nl.FormattingEnabled = True
        Me.Cbx_dias_nl.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.Cbx_dias_nl.Location = New System.Drawing.Point(187, 643)
        Me.Cbx_dias_nl.Name = "Cbx_dias_nl"
        Me.Cbx_dias_nl.Size = New System.Drawing.Size(51, 26)
        Me.Cbx_dias_nl.TabIndex = 135
        '
        'Dtp_vencimiento_nl
        '
        Me.Dtp_vencimiento_nl.Enabled = False
        Me.Dtp_vencimiento_nl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_vencimiento_nl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_vencimiento_nl.Location = New System.Drawing.Point(268, 643)
        Me.Dtp_vencimiento_nl.Name = "Dtp_vencimiento_nl"
        Me.Dtp_vencimiento_nl.Size = New System.Drawing.Size(126, 26)
        Me.Dtp_vencimiento_nl.TabIndex = 136
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(184, 626)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Dias"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(260, 626)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(98, 17)
        Me.Label21.TabIndex = 142
        Me.Label21.Text = "Vencimiento"
        '
        'Btn_update
        '
        Me.Btn_update.Enabled = False
        Me.Btn_update.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_update.Location = New System.Drawing.Point(919, 617)
        Me.Btn_update.Name = "Btn_update"
        Me.Btn_update.Size = New System.Drawing.Size(133, 52)
        Me.Btn_update.TabIndex = 146
        Me.Btn_update.Text = "ACTUALIZAR EXPEDIENTE"
        Me.Btn_update.UseVisualStyleBackColor = True
        Me.Btn_update.Visible = False
        '
        'Btn_save
        '
        Me.Btn_save.Enabled = False
        Me.Btn_save.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_save.Location = New System.Drawing.Point(919, 495)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(133, 52)
        Me.Btn_save.TabIndex = 145
        Me.Btn_save.Text = "GUARDAR EXPEDIENTE"
        Me.Btn_save.UseVisualStyleBackColor = True
        '
        'Btn_clean
        '
        Me.Btn_clean.Enabled = False
        Me.Btn_clean.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_clean.Location = New System.Drawing.Point(919, 553)
        Me.Btn_clean.Name = "Btn_clean"
        Me.Btn_clean.Size = New System.Drawing.Size(133, 52)
        Me.Btn_clean.TabIndex = 144
        Me.Btn_clean.Text = "LIMPIAR CAMPOS"
        Me.Btn_clean.UseVisualStyleBackColor = True
        '
        'Cbx_nl
        '
        Me.Cbx_nl.Enabled = False
        Me.Cbx_nl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_nl.FormattingEnabled = True
        Me.Cbx_nl.Location = New System.Drawing.Point(29, 591)
        Me.Cbx_nl.Name = "Cbx_nl"
        Me.Cbx_nl.Size = New System.Drawing.Size(365, 26)
        Me.Cbx_nl.TabIndex = 148
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 572)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 17)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = "Notificadar-Localizador"
        '
        'Dtp_asig_nl
        '
        Me.Dtp_asig_nl.Enabled = False
        Me.Dtp_asig_nl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_asig_nl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_asig_nl.Location = New System.Drawing.Point(29, 640)
        Me.Dtp_asig_nl.Name = "Dtp_asig_nl"
        Me.Dtp_asig_nl.Size = New System.Drawing.Size(126, 26)
        Me.Dtp_asig_nl.TabIndex = 149
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 623)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "Asignacion"
        '
        'Dtp_asig_loc
        '
        Me.Dtp_asig_loc.Enabled = False
        Me.Dtp_asig_loc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_asig_loc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_asig_loc.Location = New System.Drawing.Point(426, 640)
        Me.Dtp_asig_loc.Name = "Dtp_asig_loc"
        Me.Dtp_asig_loc.Size = New System.Drawing.Size(126, 26)
        Me.Dtp_asig_loc.TabIndex = 157
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(423, 623)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 17)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "Asignacion"
        '
        'Cbx_localizadores
        '
        Me.Cbx_localizadores.Enabled = False
        Me.Cbx_localizadores.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_localizadores.FormattingEnabled = True
        Me.Cbx_localizadores.Location = New System.Drawing.Point(426, 596)
        Me.Cbx_localizadores.Name = "Cbx_localizadores"
        Me.Cbx_localizadores.Size = New System.Drawing.Size(365, 26)
        Me.Cbx_localizadores.TabIndex = 156
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(423, 577)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 17)
        Me.Label11.TabIndex = 155
        Me.Label11.Text = "Localizador"
        '
        'Cbx_dias_loc
        '
        Me.Cbx_dias_loc.Enabled = False
        Me.Cbx_dias_loc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_dias_loc.FormattingEnabled = True
        Me.Cbx_dias_loc.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.Cbx_dias_loc.Location = New System.Drawing.Point(584, 643)
        Me.Cbx_dias_loc.Name = "Cbx_dias_loc"
        Me.Cbx_dias_loc.Size = New System.Drawing.Size(51, 26)
        Me.Cbx_dias_loc.TabIndex = 151
        '
        'Dtp_vencimiento_loc
        '
        Me.Dtp_vencimiento_loc.Enabled = False
        Me.Dtp_vencimiento_loc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_vencimiento_loc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_vencimiento_loc.Location = New System.Drawing.Point(665, 643)
        Me.Dtp_vencimiento_loc.Name = "Dtp_vencimiento_loc"
        Me.Dtp_vencimiento_loc.Size = New System.Drawing.Size(126, 26)
        Me.Dtp_vencimiento_loc.TabIndex = 152
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(581, 626)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 17)
        Me.Label12.TabIndex = 154
        Me.Label12.Text = "Dias"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(657, 626)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 17)
        Me.Label13.TabIndex = 153
        Me.Label13.Text = "Vencimiento"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.VERToolStripMenuItem, Me.PLANTILLASToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1157, 24)
        Me.MenuStrip1.TabIndex = 160
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CerrarToolStripMenuItem.Text = "CERRAR"
        '
        'VERToolStripMenuItem
        '
        Me.VERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TODOSToolStripMenuItem, Me.SINASIGNACIONToolStripMenuItem, Me.SINNLToolStripMenuItem, Me.SINLOCALIZADORToolStripMenuItem, Me.ASIGNADOSToolStripMenuItem})
        Me.VERToolStripMenuItem.Name = "VERToolStripMenuItem"
        Me.VERToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.VERToolStripMenuItem.Text = "VER"
        '
        'TODOSToolStripMenuItem
        '
        Me.TODOSToolStripMenuItem.Name = "TODOSToolStripMenuItem"
        Me.TODOSToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TODOSToolStripMenuItem.Text = "TODOS"
        '
        'SINASIGNACIONToolStripMenuItem
        '
        Me.SINASIGNACIONToolStripMenuItem.Name = "SINASIGNACIONToolStripMenuItem"
        Me.SINASIGNACIONToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SINASIGNACIONToolStripMenuItem.Text = "SIN ASIGNACION"
        '
        'SINNLToolStripMenuItem
        '
        Me.SINNLToolStripMenuItem.Name = "SINNLToolStripMenuItem"
        Me.SINNLToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SINNLToolStripMenuItem.Text = "SIN NL"
        '
        'SINLOCALIZADORToolStripMenuItem
        '
        Me.SINLOCALIZADORToolStripMenuItem.Name = "SINLOCALIZADORToolStripMenuItem"
        Me.SINLOCALIZADORToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SINLOCALIZADORToolStripMenuItem.Text = "SIN LOCALIZADOR"
        '
        'ASIGNADOSToolStripMenuItem
        '
        Me.ASIGNADOSToolStripMenuItem.Name = "ASIGNADOSToolStripMenuItem"
        Me.ASIGNADOSToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ASIGNADOSToolStripMenuItem.Text = "ASIGNADOS"
        '
        'PLANTILLASToolStripMenuItem
        '
        Me.PLANTILLASToolStripMenuItem.Name = "PLANTILLASToolStripMenuItem"
        Me.PLANTILLASToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.PLANTILLASToolStripMenuItem.Text = "PLANTILLAS"
        '
        'Btn_imp_con_nl
        '
        Me.Btn_imp_con_nl.Enabled = False
        Me.Btn_imp_con_nl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_imp_con_nl.Location = New System.Drawing.Point(164, 697)
        Me.Btn_imp_con_nl.Name = "Btn_imp_con_nl"
        Me.Btn_imp_con_nl.Size = New System.Drawing.Size(133, 71)
        Me.Btn_imp_con_nl.TabIndex = 161
        Me.Btn_imp_con_nl.Text = "IMPRIMIR CONTROL NL"
        Me.Btn_imp_con_nl.UseVisualStyleBackColor = True
        '
        'Btn_imp_con_loc
        '
        Me.Btn_imp_con_loc.Enabled = False
        Me.Btn_imp_con_loc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_imp_con_loc.Location = New System.Drawing.Point(553, 697)
        Me.Btn_imp_con_loc.Name = "Btn_imp_con_loc"
        Me.Btn_imp_con_loc.Size = New System.Drawing.Size(137, 71)
        Me.Btn_imp_con_loc.TabIndex = 162
        Me.Btn_imp_con_loc.Text = "IMPRIMIR CONTROL LOCALIZADOR"
        Me.Btn_imp_con_loc.UseVisualStyleBackColor = True
        '
        'Lbl_idpatronnl
        '
        Me.Lbl_idpatronnl.AutoSize = True
        Me.Lbl_idpatronnl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_idpatronnl.Location = New System.Drawing.Point(1024, 318)
        Me.Lbl_idpatronnl.Name = "Lbl_idpatronnl"
        Me.Lbl_idpatronnl.Size = New System.Drawing.Size(108, 17)
        Me.Lbl_idpatronnl.TabIndex = 163
        Me.Lbl_idpatronnl.Text = "IDPATRONNL"
        Me.Lbl_idpatronnl.Visible = False
        '
        'Lbl_acta_circ
        '
        Me.Lbl_acta_circ.AutoSize = True
        Me.Lbl_acta_circ.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_acta_circ.Location = New System.Drawing.Point(1040, 354)
        Me.Lbl_acta_circ.Name = "Lbl_acta_circ"
        Me.Lbl_acta_circ.Size = New System.Drawing.Size(92, 17)
        Me.Lbl_acta_circ.TabIndex = 164
        Me.Lbl_acta_circ.Text = "ACTA CIRC"
        Me.Lbl_acta_circ.Visible = False
        '
        'Lbl_titulo
        '
        Me.Lbl_titulo.AutoSize = True
        Me.Lbl_titulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_titulo.Location = New System.Drawing.Point(475, 56)
        Me.Lbl_titulo.Name = "Lbl_titulo"
        Me.Lbl_titulo.Size = New System.Drawing.Size(81, 17)
        Me.Lbl_titulo.TabIndex = 165
        Me.Lbl_titulo.Text = "LISTA DE "
        '
        'Frm_02_asignacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 844)
        Me.Controls.Add(Me.Lbl_titulo)
        Me.Controls.Add(Me.Lbl_acta_circ)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Dgv_patrones_asignados)
        Me.Controls.Add(Me.Txb_reg_pat)
        Me.Controls.Add(Me.Txb_dig_rp)
        Me.Controls.Add(Me.Txb_raz_soc)
        Me.Controls.Add(Me.Txb_domicilio)
        Me.Controls.Add(Me.Cbx_nl)
        Me.Controls.Add(Me.Dtp_asig_nl)
        Me.Controls.Add(Me.Cbx_dias_nl)
        Me.Controls.Add(Me.Dtp_vencimiento_nl)
        Me.Controls.Add(Me.Cbx_localizadores)
        Me.Controls.Add(Me.Dtp_asig_loc)
        Me.Controls.Add(Me.Cbx_dias_loc)
        Me.Controls.Add(Me.Dtp_vencimiento_loc)
        Me.Controls.Add(Me.Txb_cant_cop)
        Me.Controls.Add(Me.Txb_imp_cop)
        Me.Controls.Add(Me.Txb_cant_rcv)
        Me.Controls.Add(Me.Txb_imp_rcv)
        Me.Controls.Add(Me.Txb_can_tot)
        Me.Controls.Add(Me.Txb_imp_tot)
        Me.Controls.Add(Me.Lbl_rango)
        Me.Controls.Add(Me.Lbl_idpatronnl)
        Me.Controls.Add(Me.Btn_save)
        Me.Controls.Add(Me.Btn_clean)
        Me.Controls.Add(Me.Btn_update)
        Me.Controls.Add(Me.Btn_imp_con_nl)
        Me.Controls.Add(Me.Btn_imp_con_loc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Name = "Frm_02_asignacion"
        Me.Text = "Asignacion de Verificacion"
        CType(Me.Dgv_patrones_asignados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_patrones_asignados As DataGridView
    Friend WithEvents Lbl_rango As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Txb_imp_tot As TextBox
    Friend WithEvents Txb_imp_rcv As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txb_imp_cop As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txb_cant_cop As TextBox
    Friend WithEvents Txb_cant_rcv As TextBox
    Friend WithEvents Txb_can_tot As TextBox
    Public WithEvents Txb_reg_pat As TextBox
    Public WithEvents Txb_dig_rp As TextBox
    Public WithEvents Txb_raz_soc As TextBox
    Public WithEvents Txb_domicilio As TextBox
    Public WithEvents Label23 As Label
    Public WithEvents Label3 As Label
    Public WithEvents Label4 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Cbx_dias_nl As ComboBox
    Public WithEvents Dtp_vencimiento_nl As DateTimePicker
    Public WithEvents Label6 As Label
    Public WithEvents Label21 As Label
    Friend WithEvents Btn_update As Button
    Friend WithEvents Btn_save As Button
    Friend WithEvents Btn_clean As Button
    Friend WithEvents Cbx_nl As ComboBox
    Friend WithEvents Label9 As Label
    Public WithEvents Dtp_asig_nl As DateTimePicker
    Public WithEvents Label7 As Label
    Public WithEvents Dtp_asig_loc As DateTimePicker
    Public WithEvents Label8 As Label
    Friend WithEvents Cbx_localizadores As ComboBox
    Friend WithEvents Label11 As Label
    Public WithEvents Cbx_dias_loc As ComboBox
    Public WithEvents Dtp_vencimiento_loc As DateTimePicker
    Public WithEvents Label12 As Label
    Public WithEvents Label13 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TODOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SINASIGNACIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SINNLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SINLOCALIZADORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASIGNADOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_imp_con_nl As Button
    Friend WithEvents Btn_imp_con_loc As Button
    Public WithEvents Lbl_idpatronnl As Label
    Friend WithEvents PLANTILLASToolStripMenuItem As ToolStripMenuItem
    Public WithEvents Lbl_acta_circ As Label
    Public WithEvents Lbl_titulo As Label
End Class
