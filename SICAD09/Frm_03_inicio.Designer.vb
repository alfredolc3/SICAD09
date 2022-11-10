<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_03_inicio
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CERRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Txb_reg_pat = New System.Windows.Forms.TextBox()
        Me.Txb_dig_rp = New System.Windows.Forms.TextBox()
        Me.Txb_raz_soc = New System.Windows.Forms.TextBox()
        Me.Txb_domicilio = New System.Windows.Forms.TextBox()
        Me.Txb_sector = New System.Windows.Forms.TextBox()
        Me.Txb_notificador = New System.Windows.Forms.TextBox()
        Me.Txb_mat_not = New System.Windows.Forms.TextBox()
        Me.Cbx_ofi_origen = New System.Windows.Forms.ComboBox()
        Me.Txb_memo = New System.Windows.Forms.TextBox()
        Me.Txb_doc_baja = New System.Windows.Forms.TextBox()
        Me.Dtp_acta_circ = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_recibido = New System.Windows.Forms.DateTimePicker()
        Me.Cbx_dias_mas = New System.Windows.Forms.ComboBox()
        Me.Dtp_vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Dgv_inicio = New System.Windows.Forms.DataGridView()
        Me.Dgv_creditos = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Btn_cargar_creditos = New System.Windows.Forms.Button()
        Me.Btn_agregar_creditos = New System.Windows.Forms.Button()
        Me.Txb_cop_inicio = New System.Windows.Forms.TextBox()
        Me.Txb_rcv_inicio = New System.Windows.Forms.TextBox()
        Me.Txb_cop_cant = New System.Windows.Forms.TextBox()
        Me.Txb_cop_imp = New System.Windows.Forms.TextBox()
        Me.Txb_rcv_cant = New System.Windows.Forms.TextBox()
        Me.Txb_rcv_imp = New System.Windows.Forms.TextBox()
        Me.Txb_tot_cant = New System.Windows.Forms.TextBox()
        Me.Txb_tot_imp = New System.Windows.Forms.TextBox()
        Me.Btn_guardar = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.id_patronnl = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Dgv_inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_creditos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CERRARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1302, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CERRARToolStripMenuItem
        '
        Me.CERRARToolStripMenuItem.Name = "CERRARToolStripMenuItem"
        Me.CERRARToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CERRARToolStripMenuItem.Text = "CERRAR"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1302, 725)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Txb_reg_pat)
        Me.TabPage1.Controls.Add(Me.Txb_dig_rp)
        Me.TabPage1.Controls.Add(Me.Txb_raz_soc)
        Me.TabPage1.Controls.Add(Me.Txb_domicilio)
        Me.TabPage1.Controls.Add(Me.Txb_sector)
        Me.TabPage1.Controls.Add(Me.Txb_notificador)
        Me.TabPage1.Controls.Add(Me.Txb_mat_not)
        Me.TabPage1.Controls.Add(Me.Cbx_ofi_origen)
        Me.TabPage1.Controls.Add(Me.Txb_memo)
        Me.TabPage1.Controls.Add(Me.Txb_doc_baja)
        Me.TabPage1.Controls.Add(Me.Dtp_acta_circ)
        Me.TabPage1.Controls.Add(Me.Dtp_recibido)
        Me.TabPage1.Controls.Add(Me.Cbx_dias_mas)
        Me.TabPage1.Controls.Add(Me.Dtp_vencimiento)
        Me.TabPage1.Controls.Add(Me.Dgv_inicio)
        Me.TabPage1.Controls.Add(Me.Dgv_creditos)
        Me.TabPage1.Controls.Add(Me.Btn_cargar_creditos)
        Me.TabPage1.Controls.Add(Me.Btn_agregar_creditos)
        Me.TabPage1.Controls.Add(Me.Txb_cop_inicio)
        Me.TabPage1.Controls.Add(Me.Txb_rcv_inicio)
        Me.TabPage1.Controls.Add(Me.Txb_cop_cant)
        Me.TabPage1.Controls.Add(Me.Txb_cop_imp)
        Me.TabPage1.Controls.Add(Me.Txb_rcv_cant)
        Me.TabPage1.Controls.Add(Me.Txb_rcv_imp)
        Me.TabPage1.Controls.Add(Me.Txb_tot_cant)
        Me.TabPage1.Controls.Add(Me.Txb_tot_imp)
        Me.TabPage1.Controls.Add(Me.Btn_guardar)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.id_patronnl)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1294, 699)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(1183, 542)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(31, 32)
        Me.Label25.TabIndex = 123
        Me.Label25.Text = "0"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(1166, 497)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 17)
        Me.Label24.TabIndex = 122
        Me.Label24.Text = "RANGO"
        '
        'Txb_reg_pat
        '
        Me.Txb_reg_pat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txb_reg_pat.Enabled = False
        Me.Txb_reg_pat.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_reg_pat.Location = New System.Drawing.Point(25, 49)
        Me.Txb_reg_pat.MaxLength = 10
        Me.Txb_reg_pat.Name = "Txb_reg_pat"
        Me.Txb_reg_pat.Size = New System.Drawing.Size(114, 26)
        Me.Txb_reg_pat.TabIndex = 71
        '
        'Txb_dig_rp
        '
        Me.Txb_dig_rp.Enabled = False
        Me.Txb_dig_rp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_dig_rp.Location = New System.Drawing.Point(154, 49)
        Me.Txb_dig_rp.MaxLength = 1
        Me.Txb_dig_rp.Name = "Txb_dig_rp"
        Me.Txb_dig_rp.Size = New System.Drawing.Size(30, 26)
        Me.Txb_dig_rp.TabIndex = 73
        '
        'Txb_raz_soc
        '
        Me.Txb_raz_soc.Enabled = False
        Me.Txb_raz_soc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_raz_soc.Location = New System.Drawing.Point(195, 49)
        Me.Txb_raz_soc.MaxLength = 100
        Me.Txb_raz_soc.Name = "Txb_raz_soc"
        Me.Txb_raz_soc.Size = New System.Drawing.Size(499, 26)
        Me.Txb_raz_soc.TabIndex = 74
        '
        'Txb_domicilio
        '
        Me.Txb_domicilio.Enabled = False
        Me.Txb_domicilio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_domicilio.Location = New System.Drawing.Point(25, 98)
        Me.Txb_domicilio.MaxLength = 100
        Me.Txb_domicilio.Multiline = True
        Me.Txb_domicilio.Name = "Txb_domicilio"
        Me.Txb_domicilio.Size = New System.Drawing.Size(669, 53)
        Me.Txb_domicilio.TabIndex = 121
        '
        'Txb_sector
        '
        Me.Txb_sector.Enabled = False
        Me.Txb_sector.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_sector.Location = New System.Drawing.Point(26, 174)
        Me.Txb_sector.MaxLength = 2
        Me.Txb_sector.Name = "Txb_sector"
        Me.Txb_sector.Size = New System.Drawing.Size(65, 26)
        Me.Txb_sector.TabIndex = 75
        '
        'Txb_notificador
        '
        Me.Txb_notificador.Enabled = False
        Me.Txb_notificador.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_notificador.Location = New System.Drawing.Point(108, 174)
        Me.Txb_notificador.MaxLength = 2
        Me.Txb_notificador.Name = "Txb_notificador"
        Me.Txb_notificador.Size = New System.Drawing.Size(450, 26)
        Me.Txb_notificador.TabIndex = 76
        '
        'Txb_mat_not
        '
        Me.Txb_mat_not.Enabled = False
        Me.Txb_mat_not.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_mat_not.Location = New System.Drawing.Point(564, 174)
        Me.Txb_mat_not.MaxLength = 2
        Me.Txb_mat_not.Name = "Txb_mat_not"
        Me.Txb_mat_not.Size = New System.Drawing.Size(131, 26)
        Me.Txb_mat_not.TabIndex = 77
        '
        'Cbx_ofi_origen
        '
        Me.Cbx_ofi_origen.Enabled = False
        Me.Cbx_ofi_origen.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_ofi_origen.FormattingEnabled = True
        Me.Cbx_ofi_origen.Items.AddRange(New Object() {"COBROS", "OEPO", "AFILIACION", "AUDITORIA", "CORREO", "FORANEO", "SINDO"})
        Me.Cbx_ofi_origen.Location = New System.Drawing.Point(26, 233)
        Me.Cbx_ofi_origen.Name = "Cbx_ofi_origen"
        Me.Cbx_ofi_origen.Size = New System.Drawing.Size(288, 26)
        Me.Cbx_ofi_origen.TabIndex = 78
        '
        'Txb_memo
        '
        Me.Txb_memo.Enabled = False
        Me.Txb_memo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_memo.Location = New System.Drawing.Point(350, 233)
        Me.Txb_memo.MaxLength = 100
        Me.Txb_memo.Name = "Txb_memo"
        Me.Txb_memo.Size = New System.Drawing.Size(345, 26)
        Me.Txb_memo.TabIndex = 79
        '
        'Txb_doc_baja
        '
        Me.Txb_doc_baja.Enabled = False
        Me.Txb_doc_baja.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_doc_baja.Location = New System.Drawing.Point(26, 301)
        Me.Txb_doc_baja.MaxLength = 100
        Me.Txb_doc_baja.Name = "Txb_doc_baja"
        Me.Txb_doc_baja.Size = New System.Drawing.Size(203, 26)
        Me.Txb_doc_baja.TabIndex = 80
        '
        'Dtp_acta_circ
        '
        Me.Dtp_acta_circ.Enabled = False
        Me.Dtp_acta_circ.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_acta_circ.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_acta_circ.Location = New System.Drawing.Point(235, 301)
        Me.Dtp_acta_circ.Name = "Dtp_acta_circ"
        Me.Dtp_acta_circ.Size = New System.Drawing.Size(126, 26)
        Me.Dtp_acta_circ.TabIndex = 81
        '
        'Dtp_recibido
        '
        Me.Dtp_recibido.Enabled = False
        Me.Dtp_recibido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_recibido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_recibido.Location = New System.Drawing.Point(367, 301)
        Me.Dtp_recibido.Name = "Dtp_recibido"
        Me.Dtp_recibido.Size = New System.Drawing.Size(126, 26)
        Me.Dtp_recibido.TabIndex = 82
        '
        'Cbx_dias_mas
        '
        Me.Cbx_dias_mas.Enabled = False
        Me.Cbx_dias_mas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_dias_mas.FormattingEnabled = True
        Me.Cbx_dias_mas.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "20", "90", "120"})
        Me.Cbx_dias_mas.Location = New System.Drawing.Point(499, 301)
        Me.Cbx_dias_mas.Name = "Cbx_dias_mas"
        Me.Cbx_dias_mas.Size = New System.Drawing.Size(51, 26)
        Me.Cbx_dias_mas.TabIndex = 83
        '
        'Dtp_vencimiento
        '
        Me.Dtp_vencimiento.Enabled = False
        Me.Dtp_vencimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_vencimiento.Location = New System.Drawing.Point(569, 301)
        Me.Dtp_vencimiento.Name = "Dtp_vencimiento"
        Me.Dtp_vencimiento.Size = New System.Drawing.Size(126, 26)
        Me.Dtp_vencimiento.TabIndex = 84
        '
        'Dgv_inicio
        '
        Me.Dgv_inicio.AllowUserToAddRows = False
        Me.Dgv_inicio.AllowUserToDeleteRows = False
        Me.Dgv_inicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_inicio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_inicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_inicio.Location = New System.Drawing.Point(16, 376)
        Me.Dgv_inicio.Name = "Dgv_inicio"
        Me.Dgv_inicio.ReadOnly = True
        Me.Dgv_inicio.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_inicio.Size = New System.Drawing.Size(691, 298)
        Me.Dgv_inicio.TabIndex = 72
        Me.Dgv_inicio.TabStop = False
        '
        'Dgv_creditos
        '
        Me.Dgv_creditos.AllowUserToAddRows = False
        Me.Dgv_creditos.AllowUserToDeleteRows = False
        Me.Dgv_creditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_creditos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.Dgv_creditos.Enabled = False
        Me.Dgv_creditos.Location = New System.Drawing.Point(764, 24)
        Me.Dgv_creditos.Name = "Dgv_creditos"
        Me.Dgv_creditos.Size = New System.Drawing.Size(517, 176)
        Me.Dgv_creditos.TabIndex = 86
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        '
        'Btn_cargar_creditos
        '
        Me.Btn_cargar_creditos.Enabled = False
        '        Me.Btn_cargar_creditos.Image = Global.SICAD09.My.Resources.Resources.file_48px
        Me.Btn_cargar_creditos.Location = New System.Drawing.Point(764, 203)
        Me.Btn_cargar_creditos.Name = "Btn_cargar_creditos"
        Me.Btn_cargar_creditos.Size = New System.Drawing.Size(47, 51)
        Me.Btn_cargar_creditos.TabIndex = 85
        Me.Btn_cargar_creditos.UseVisualStyleBackColor = True
        '
        'Btn_agregar_creditos
        '
        Me.Btn_agregar_creditos.Enabled = False
        Me.Btn_agregar_creditos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '        Me.Btn_agregar_creditos.Image = Global.SICAD09.My.Resources.Resources.add_graph_report_24px
        Me.Btn_agregar_creditos.Location = New System.Drawing.Point(1234, 203)
        Me.Btn_agregar_creditos.Name = "Btn_agregar_creditos"
        Me.Btn_agregar_creditos.Size = New System.Drawing.Size(47, 51)
        Me.Btn_agregar_creditos.TabIndex = 87
        Me.Btn_agregar_creditos.UseVisualStyleBackColor = True
        '
        'Txb_cop_inicio
        '
        Me.Txb_cop_inicio.Enabled = False
        Me.Txb_cop_inicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_cop_inicio.Location = New System.Drawing.Point(764, 287)
        Me.Txb_cop_inicio.MaxLength = 300
        Me.Txb_cop_inicio.Multiline = True
        Me.Txb_cop_inicio.Name = "Txb_cop_inicio"
        Me.Txb_cop_inicio.Size = New System.Drawing.Size(517, 38)
        Me.Txb_cop_inicio.TabIndex = 88
        '
        'Txb_rcv_inicio
        '
        Me.Txb_rcv_inicio.Enabled = False
        Me.Txb_rcv_inicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_rcv_inicio.Location = New System.Drawing.Point(764, 353)
        Me.Txb_rcv_inicio.MaxLength = 300
        Me.Txb_rcv_inicio.Multiline = True
        Me.Txb_rcv_inicio.Name = "Txb_rcv_inicio"
        Me.Txb_rcv_inicio.Size = New System.Drawing.Size(517, 38)
        Me.Txb_rcv_inicio.TabIndex = 89
        '
        'Txb_cop_cant
        '
        Me.Txb_cop_cant.Enabled = False
        Me.Txb_cop_cant.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_cop_cant.Location = New System.Drawing.Point(841, 460)
        Me.Txb_cop_cant.MaxLength = 100
        Me.Txb_cop_cant.Name = "Txb_cop_cant"
        Me.Txb_cop_cant.Size = New System.Drawing.Size(85, 26)
        Me.Txb_cop_cant.TabIndex = 90
        Me.Txb_cop_cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txb_cop_imp
        '
        Me.Txb_cop_imp.Enabled = False
        Me.Txb_cop_imp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_cop_imp.Location = New System.Drawing.Point(950, 460)
        Me.Txb_cop_imp.MaxLength = 100
        Me.Txb_cop_imp.Name = "Txb_cop_imp"
        Me.Txb_cop_imp.Size = New System.Drawing.Size(132, 26)
        Me.Txb_cop_imp.TabIndex = 91
        Me.Txb_cop_imp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_rcv_cant
        '
        Me.Txb_rcv_cant.Enabled = False
        Me.Txb_rcv_cant.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_rcv_cant.Location = New System.Drawing.Point(841, 505)
        Me.Txb_rcv_cant.MaxLength = 100
        Me.Txb_rcv_cant.Name = "Txb_rcv_cant"
        Me.Txb_rcv_cant.Size = New System.Drawing.Size(85, 26)
        Me.Txb_rcv_cant.TabIndex = 92
        Me.Txb_rcv_cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txb_rcv_imp
        '
        Me.Txb_rcv_imp.Enabled = False
        Me.Txb_rcv_imp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_rcv_imp.Location = New System.Drawing.Point(950, 505)
        Me.Txb_rcv_imp.MaxLength = 100
        Me.Txb_rcv_imp.Name = "Txb_rcv_imp"
        Me.Txb_rcv_imp.Size = New System.Drawing.Size(132, 26)
        Me.Txb_rcv_imp.TabIndex = 93
        Me.Txb_rcv_imp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txb_tot_cant
        '
        Me.Txb_tot_cant.Enabled = False
        Me.Txb_tot_cant.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_tot_cant.Location = New System.Drawing.Point(841, 548)
        Me.Txb_tot_cant.MaxLength = 100
        Me.Txb_tot_cant.Name = "Txb_tot_cant"
        Me.Txb_tot_cant.Size = New System.Drawing.Size(85, 26)
        Me.Txb_tot_cant.TabIndex = 94
        Me.Txb_tot_cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txb_tot_imp
        '
        Me.Txb_tot_imp.Enabled = False
        Me.Txb_tot_imp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_tot_imp.Location = New System.Drawing.Point(950, 548)
        Me.Txb_tot_imp.MaxLength = 100
        Me.Txb_tot_imp.Name = "Txb_tot_imp"
        Me.Txb_tot_imp.Size = New System.Drawing.Size(132, 26)
        Me.Txb_tot_imp.TabIndex = 96
        Me.Txb_tot_imp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Btn_guardar
        '
        Me.Btn_guardar.Enabled = False
        Me.Btn_guardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_guardar.Location = New System.Drawing.Point(915, 626)
        Me.Btn_guardar.Name = "Btn_guardar"
        Me.Btn_guardar.Size = New System.Drawing.Size(119, 48)
        Me.Btn_guardar.TabIndex = 97
        Me.Btn_guardar.Text = "Guardar"
        Me.Btn_guardar.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(13, 78)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(75, 17)
        Me.Label23.TabIndex = 120
        Me.Label23.Text = "Domicilio"
        '
        'id_patronnl
        '
        Me.id_patronnl.AutoSize = True
        Me.id_patronnl.Location = New System.Drawing.Point(26, 340)
        Me.id_patronnl.Name = "id_patronnl"
        Me.id_patronnl.Size = New System.Drawing.Size(60, 13)
        Me.id_patronnl.TabIndex = 119
        Me.id_patronnl.Text = "Id_patronnl"
        Me.id_patronnl.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(496, 284)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 17)
        Me.Label22.TabIndex = 118
        Me.Label22.Text = "Dias"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(561, 284)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(98, 17)
        Me.Label21.TabIndex = 117
        Me.Label21.Text = "Vencimiento"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(364, 284)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 17)
        Me.Label20.TabIndex = 116
        Me.Label20.Text = "Recibido"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(232, 284)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(108, 17)
        Me.Label19.TabIndex = 115
        Me.Label19.Text = "Acta Circuns."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(14, 284)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(166, 17)
        Me.Label18.TabIndex = 114
        Me.Label18.Text = "Documento para Baja"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(761, 552)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 17)
        Me.Label17.TabIndex = 113
        Me.Label17.Text = "TOTAL"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(761, 509)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 17)
        Me.Label16.TabIndex = 112
        Me.Label16.Text = "RCV"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(977, 433)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 17)
        Me.Label15.TabIndex = 111
        Me.Label15.Text = "IMPORTE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(838, 433)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 17)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "CANTIDAD"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(761, 464)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 17)
        Me.Label12.TabIndex = 109
        Me.Label12.Text = "COP "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(873, 410)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 17)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "CREDITOS TOTALES"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(334, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 17)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "Memorandum "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 17)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "Oficina Origen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(561, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Matricula"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(95, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Notificador"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(940, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 40)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "CREDITOS INICIOS DE BAJA"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(766, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "RCV"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(766, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "COP "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 17)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Sector"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(140, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 17)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(181, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Razon Social"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Registro Patronal"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1294, 699)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Frm_03_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1302, 749)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_03_inicio"
        Me.Text = "Frm_02_inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Dgv_inicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_creditos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents MenuStrip1 As MenuStrip
    Public WithEvents CERRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Public WithEvents Txb_reg_pat As TextBox
    Public WithEvents Txb_dig_rp As TextBox
    Public WithEvents Txb_raz_soc As TextBox
    Public WithEvents Txb_domicilio As TextBox
    Public WithEvents Txb_sector As TextBox
    Public WithEvents Txb_notificador As TextBox
    Public WithEvents Txb_mat_not As TextBox
    Public WithEvents Cbx_ofi_origen As ComboBox
    Public WithEvents Txb_memo As TextBox
    Public WithEvents Txb_doc_baja As TextBox
    Public WithEvents Dtp_acta_circ As DateTimePicker
    Public WithEvents Dtp_recibido As DateTimePicker
    Public WithEvents Cbx_dias_mas As ComboBox
    Public WithEvents Dtp_vencimiento As DateTimePicker
    Public WithEvents Dgv_inicio As DataGridView
    Public WithEvents Dgv_creditos As DataGridView
    Public WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Public WithEvents Btn_cargar_creditos As Button
    Public WithEvents Btn_agregar_creditos As Button
    Public WithEvents Txb_cop_inicio As TextBox
    Public WithEvents Txb_rcv_inicio As TextBox
    Public WithEvents Txb_cop_cant As TextBox
    Public WithEvents Txb_cop_imp As TextBox
    Public WithEvents Txb_rcv_cant As TextBox
    Public WithEvents Txb_rcv_imp As TextBox
    Public WithEvents Txb_tot_cant As TextBox
    Public WithEvents Txb_tot_imp As TextBox
    Public WithEvents Btn_guardar As Button
    Public WithEvents Label23 As Label
    Public WithEvents id_patronnl As Label
    Public WithEvents Label22 As Label
    Public WithEvents Label21 As Label
    Public WithEvents Label20 As Label
    Public WithEvents Label19 As Label
    Public WithEvents Label18 As Label
    Public WithEvents Label17 As Label
    Public WithEvents Label16 As Label
    Public WithEvents Label15 As Label
    Public WithEvents Label14 As Label
    Public WithEvents Label12 As Label
    Public WithEvents Label11 As Label
    Public WithEvents Label10 As Label
    Public WithEvents Label9 As Label
    Public WithEvents Label8 As Label
    Public WithEvents Label7 As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label1 As Label
    Public WithEvents Label13 As Label
    Public WithEvents Label3 As Label
    Public WithEvents Label4 As Label
    Public WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Public WithEvents Label25 As Label
    Public WithEvents Label24 As Label
End Class
