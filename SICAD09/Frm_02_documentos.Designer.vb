<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_02_documentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_02_documentos))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CERRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinRevisarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevisadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompletadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevueltosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXPORTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Dgv_documentosnl = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.id_patronesnl = New System.Windows.Forms.Label()
        Me.id_documentosnl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Rb_oepo = New System.Windows.Forms.RadioButton()
        Me.Rb_cobros = New System.Windows.Forms.RadioButton()
        Me.Rb_afiliacion = New System.Windows.Forms.RadioButton()
        Me.Rb_auditoria = New System.Windows.Forms.RadioButton()
        Me.Rb_correo = New System.Windows.Forms.RadioButton()
        Me.Rb_foraneo = New System.Windows.Forms.RadioButton()
        Me.Rb_sindo = New System.Windows.Forms.RadioButton()
        Me.Chb_mem_orig = New System.Windows.Forms.CheckBox()
        Me.Chb_foto = New System.Windows.Forms.CheckBox()
        Me.Chb_acta = New System.Windows.Forms.CheckBox()
        Me.Chb_edo_ade_cop = New System.Windows.Forms.CheckBox()
        Me.Chb_edo_ade_rcv = New System.Windows.Forms.CheckBox()
        Me.Chb_edo_cta_cop = New System.Windows.Forms.CheckBox()
        Me.Chb_edo_cta_rcv = New System.Windows.Forms.CheckBox()
        Me.Chb_arp = New System.Windows.Forms.CheckBox()
        Me.Chb_not_estrado = New System.Windows.Forms.CheckBox()
        Me.Chb_sicofi = New System.Windows.Forms.CheckBox()
        Me.Chb_mandamiento = New System.Windows.Forms.CheckBox()
        Me.Chb_ced_liq = New System.Windows.Forms.CheckBox()
        Me.Chb_amp_emb = New System.Windows.Forms.CheckBox()
        Me.Chb_completo = New System.Windows.Forms.CheckBox()
        Me.Txb_devolucion = New System.Windows.Forms.TextBox()
        Me.Dtp_devolucion = New System.Windows.Forms.DateTimePicker()
        Me.Cbx_integradores = New System.Windows.Forms.ComboBox()
        Me.Lbl_integrador_asignado = New System.Windows.Forms.Label()
        Me.Txb_foraneas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txb_derivadas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_cancelar = New System.Windows.Forms.Button()
        Me.Btn_modificar = New System.Windows.Forms.Button()
        Me.Btn_guardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txb_raz_soc = New System.Windows.Forms.TextBox()
        Me.Txb_dig_rp = New System.Windows.Forms.TextBox()
        Me.Txb_reg_pat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Dgv_documentosnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CERRARToolStripMenuItem, Me.VERToolStripMenuItem, Me.EXPORTARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1302, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CERRARToolStripMenuItem
        '
        Me.CERRARToolStripMenuItem.Name = "CERRARToolStripMenuItem"
        Me.CERRARToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CERRARToolStripMenuItem.Text = "CERRAR"
        '
        'VERToolStripMenuItem
        '
        Me.VERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodosToolStripMenuItem, Me.SinRevisarToolStripMenuItem, Me.RevisadosToolStripMenuItem, Me.CompletadosToolStripMenuItem, Me.DevueltosToolStripMenuItem})
        Me.VERToolStripMenuItem.Name = "VERToolStripMenuItem"
        Me.VERToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.VERToolStripMenuItem.Text = "VER"
        '
        'TodosToolStripMenuItem
        '
        Me.TodosToolStripMenuItem.Name = "TodosToolStripMenuItem"
        Me.TodosToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.TodosToolStripMenuItem.Text = "Todos"
        '
        'SinRevisarToolStripMenuItem
        '
        Me.SinRevisarToolStripMenuItem.Name = "SinRevisarToolStripMenuItem"
        Me.SinRevisarToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.SinRevisarToolStripMenuItem.Text = "Sin Revisar"
        '
        'RevisadosToolStripMenuItem
        '
        Me.RevisadosToolStripMenuItem.Name = "RevisadosToolStripMenuItem"
        Me.RevisadosToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.RevisadosToolStripMenuItem.Text = "Revisados"
        '
        'CompletadosToolStripMenuItem
        '
        Me.CompletadosToolStripMenuItem.Name = "CompletadosToolStripMenuItem"
        Me.CompletadosToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.CompletadosToolStripMenuItem.Text = "Completados"
        '
        'DevueltosToolStripMenuItem
        '
        Me.DevueltosToolStripMenuItem.Name = "DevueltosToolStripMenuItem"
        Me.DevueltosToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DevueltosToolStripMenuItem.Text = "Devueltos"
        '
        'EXPORTARToolStripMenuItem
        '
        Me.EXPORTARToolStripMenuItem.Name = "EXPORTARToolStripMenuItem"
        Me.EXPORTARToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.EXPORTARToolStripMenuItem.Text = "EXPORTAR"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1302, 725)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Dgv_documentosnl)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1294, 699)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listado"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Dgv_documentosnl
        '
        Me.Dgv_documentosnl.AllowUserToAddRows = False
        Me.Dgv_documentosnl.AllowUserToDeleteRows = False
        Me.Dgv_documentosnl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_documentosnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_documentosnl.Location = New System.Drawing.Point(3, 3)
        Me.Dgv_documentosnl.Name = "Dgv_documentosnl"
        Me.Dgv_documentosnl.ReadOnly = True
        Me.Dgv_documentosnl.Size = New System.Drawing.Size(1288, 693)
        Me.Dgv_documentosnl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.id_patronesnl)
        Me.TabPage1.Controls.Add(Me.id_documentosnl)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Rb_oepo)
        Me.TabPage1.Controls.Add(Me.Rb_cobros)
        Me.TabPage1.Controls.Add(Me.Rb_afiliacion)
        Me.TabPage1.Controls.Add(Me.Rb_auditoria)
        Me.TabPage1.Controls.Add(Me.Rb_correo)
        Me.TabPage1.Controls.Add(Me.Rb_foraneo)
        Me.TabPage1.Controls.Add(Me.Rb_sindo)
        Me.TabPage1.Controls.Add(Me.Chb_mem_orig)
        Me.TabPage1.Controls.Add(Me.Chb_foto)
        Me.TabPage1.Controls.Add(Me.Chb_acta)
        Me.TabPage1.Controls.Add(Me.Chb_edo_ade_cop)
        Me.TabPage1.Controls.Add(Me.Chb_edo_ade_rcv)
        Me.TabPage1.Controls.Add(Me.Chb_edo_cta_cop)
        Me.TabPage1.Controls.Add(Me.Chb_edo_cta_rcv)
        Me.TabPage1.Controls.Add(Me.Chb_arp)
        Me.TabPage1.Controls.Add(Me.Chb_not_estrado)
        Me.TabPage1.Controls.Add(Me.Chb_sicofi)
        Me.TabPage1.Controls.Add(Me.Chb_mandamiento)
        Me.TabPage1.Controls.Add(Me.Chb_ced_liq)
        Me.TabPage1.Controls.Add(Me.Chb_amp_emb)
        Me.TabPage1.Controls.Add(Me.Chb_completo)
        Me.TabPage1.Controls.Add(Me.Txb_devolucion)
        Me.TabPage1.Controls.Add(Me.Dtp_devolucion)
        Me.TabPage1.Controls.Add(Me.Cbx_integradores)
        Me.TabPage1.Controls.Add(Me.Lbl_integrador_asignado)
        Me.TabPage1.Controls.Add(Me.Txb_foraneas)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Txb_derivadas)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Btn_cancelar)
        Me.TabPage1.Controls.Add(Me.Btn_modificar)
        Me.TabPage1.Controls.Add(Me.Btn_guardar)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Txb_raz_soc)
        Me.TabPage1.Controls.Add(Me.Txb_dig_rp)
        Me.TabPage1.Controls.Add(Me.Txb_reg_pat)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1294, 699)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Documentos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'id_patronesnl
        '
        Me.id_patronesnl.AutoSize = True
        Me.id_patronesnl.Location = New System.Drawing.Point(95, 0)
        Me.id_patronesnl.Name = "id_patronesnl"
        Me.id_patronesnl.Size = New System.Drawing.Size(70, 13)
        Me.id_patronesnl.TabIndex = 109
        Me.id_patronesnl.Text = "id_patronesnl"
        Me.id_patronesnl.Visible = False
        '
        'id_documentosnl
        '
        Me.id_documentosnl.AutoSize = True
        Me.id_documentosnl.Location = New System.Drawing.Point(0, 0)
        Me.id_documentosnl.Name = "id_documentosnl"
        Me.id_documentosnl.Size = New System.Drawing.Size(87, 13)
        Me.id_documentosnl.TabIndex = 108
        Me.id_documentosnl.Text = "id_documentosnl"
        Me.id_documentosnl.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Location = New System.Drawing.Point(912, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(374, 491)
        Me.Panel1.TabIndex = 102
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 148)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(365, 221)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = resources.GetString("Label19.Text")
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 73)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(365, 53)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "En este Modulo, se guardara los documentos con los que se solicita la baja del pa" &
    "tron por 251, en caso de no estar completo devolver a la oficina correspondiente" &
    " "
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(368, 53)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "CAPTURA DE DOCUMENTACION ENTREGADA"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(522, 386)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 17)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Fecha de Devolucion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(522, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 17)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Motivo de Devolucion"
        '
        'Rb_oepo
        '
        Me.Rb_oepo.AutoSize = True
        Me.Rb_oepo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_oepo.Location = New System.Drawing.Point(60, 241)
        Me.Rb_oepo.Name = "Rb_oepo"
        Me.Rb_oepo.Size = New System.Drawing.Size(74, 22)
        Me.Rb_oepo.TabIndex = 55
        Me.Rb_oepo.TabStop = True
        Me.Rb_oepo.Text = "OEPO"
        Me.Rb_oepo.UseVisualStyleBackColor = True
        '
        'Rb_cobros
        '
        Me.Rb_cobros.AutoSize = True
        Me.Rb_cobros.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_cobros.Location = New System.Drawing.Point(60, 269)
        Me.Rb_cobros.Name = "Rb_cobros"
        Me.Rb_cobros.Size = New System.Drawing.Size(99, 22)
        Me.Rb_cobros.TabIndex = 58
        Me.Rb_cobros.TabStop = True
        Me.Rb_cobros.Text = "COBROS"
        Me.Rb_cobros.UseVisualStyleBackColor = True
        '
        'Rb_afiliacion
        '
        Me.Rb_afiliacion.AutoSize = True
        Me.Rb_afiliacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_afiliacion.Location = New System.Drawing.Point(60, 297)
        Me.Rb_afiliacion.Name = "Rb_afiliacion"
        Me.Rb_afiliacion.Size = New System.Drawing.Size(122, 22)
        Me.Rb_afiliacion.TabIndex = 56
        Me.Rb_afiliacion.TabStop = True
        Me.Rb_afiliacion.Text = "AFILIACION"
        Me.Rb_afiliacion.UseVisualStyleBackColor = True
        '
        'Rb_auditoria
        '
        Me.Rb_auditoria.AutoSize = True
        Me.Rb_auditoria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_auditoria.Location = New System.Drawing.Point(60, 325)
        Me.Rb_auditoria.Name = "Rb_auditoria"
        Me.Rb_auditoria.Size = New System.Drawing.Size(119, 22)
        Me.Rb_auditoria.TabIndex = 57
        Me.Rb_auditoria.TabStop = True
        Me.Rb_auditoria.Text = "AUDITORIA"
        Me.Rb_auditoria.UseVisualStyleBackColor = True
        '
        'Rb_correo
        '
        Me.Rb_correo.AutoSize = True
        Me.Rb_correo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_correo.Location = New System.Drawing.Point(60, 353)
        Me.Rb_correo.Name = "Rb_correo"
        Me.Rb_correo.Size = New System.Drawing.Size(99, 22)
        Me.Rb_correo.TabIndex = 59
        Me.Rb_correo.TabStop = True
        Me.Rb_correo.Text = "CORREO"
        Me.Rb_correo.UseVisualStyleBackColor = True
        '
        'Rb_foraneo
        '
        Me.Rb_foraneo.AutoSize = True
        Me.Rb_foraneo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_foraneo.Location = New System.Drawing.Point(60, 381)
        Me.Rb_foraneo.Name = "Rb_foraneo"
        Me.Rb_foraneo.Size = New System.Drawing.Size(109, 22)
        Me.Rb_foraneo.TabIndex = 60
        Me.Rb_foraneo.TabStop = True
        Me.Rb_foraneo.Text = "FORANEO"
        Me.Rb_foraneo.UseVisualStyleBackColor = True
        '
        'Rb_sindo
        '
        Me.Rb_sindo.AutoSize = True
        Me.Rb_sindo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_sindo.Location = New System.Drawing.Point(60, 409)
        Me.Rb_sindo.Name = "Rb_sindo"
        Me.Rb_sindo.Size = New System.Drawing.Size(79, 22)
        Me.Rb_sindo.TabIndex = 61
        Me.Rb_sindo.TabStop = True
        Me.Rb_sindo.Text = "SINDO"
        Me.Rb_sindo.UseVisualStyleBackColor = True
        '
        'Chb_mem_orig
        '
        Me.Chb_mem_orig.AutoSize = True
        Me.Chb_mem_orig.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_mem_orig.Location = New System.Drawing.Point(244, 181)
        Me.Chb_mem_orig.Name = "Chb_mem_orig"
        Me.Chb_mem_orig.Size = New System.Drawing.Size(323, 22)
        Me.Chb_mem_orig.TabIndex = 50
        Me.Chb_mem_orig.Text = "Memorandum que da Origen a la Baja"
        Me.Chb_mem_orig.UseVisualStyleBackColor = True
        '
        'Chb_foto
        '
        Me.Chb_foto.AutoSize = True
        Me.Chb_foto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_foto.Location = New System.Drawing.Point(244, 209)
        Me.Chb_foto.Name = "Chb_foto"
        Me.Chb_foto.Size = New System.Drawing.Size(63, 22)
        Me.Chb_foto.TabIndex = 33
        Me.Chb_foto.Text = "Foto"
        Me.Chb_foto.UseVisualStyleBackColor = True
        '
        'Chb_acta
        '
        Me.Chb_acta.AutoSize = True
        Me.Chb_acta.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_acta.Location = New System.Drawing.Point(244, 237)
        Me.Chb_acta.Name = "Chb_acta"
        Me.Chb_acta.Size = New System.Drawing.Size(201, 22)
        Me.Chb_acta.TabIndex = 43
        Me.Chb_acta.Text = "Acta Circunstanciada"
        Me.Chb_acta.UseVisualStyleBackColor = True
        '
        'Chb_edo_ade_cop
        '
        Me.Chb_edo_ade_cop.AutoSize = True
        Me.Chb_edo_ade_cop.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_edo_ade_cop.Location = New System.Drawing.Point(244, 265)
        Me.Chb_edo_ade_cop.Name = "Chb_edo_ade_cop"
        Me.Chb_edo_ade_cop.Size = New System.Drawing.Size(164, 22)
        Me.Chb_edo_ade_cop.TabIndex = 44
        Me.Chb_edo_ade_cop.Text = "Edo Adeudo COP"
        Me.Chb_edo_ade_cop.UseVisualStyleBackColor = True
        '
        'Chb_edo_ade_rcv
        '
        Me.Chb_edo_ade_rcv.AutoSize = True
        Me.Chb_edo_ade_rcv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_edo_ade_rcv.Location = New System.Drawing.Point(244, 293)
        Me.Chb_edo_ade_rcv.Name = "Chb_edo_ade_rcv"
        Me.Chb_edo_ade_rcv.Size = New System.Drawing.Size(163, 22)
        Me.Chb_edo_ade_rcv.TabIndex = 45
        Me.Chb_edo_ade_rcv.Text = "Edo Adeudo RCV"
        Me.Chb_edo_ade_rcv.UseVisualStyleBackColor = True
        '
        'Chb_edo_cta_cop
        '
        Me.Chb_edo_cta_cop.AutoSize = True
        Me.Chb_edo_cta_cop.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_edo_cta_cop.Location = New System.Drawing.Point(244, 319)
        Me.Chb_edo_cta_cop.Name = "Chb_edo_cta_cop"
        Me.Chb_edo_cta_cop.Size = New System.Drawing.Size(160, 22)
        Me.Chb_edo_cta_cop.TabIndex = 46
        Me.Chb_edo_cta_cop.Text = "Edo Cuenta COP"
        Me.Chb_edo_cta_cop.UseVisualStyleBackColor = True
        '
        'Chb_edo_cta_rcv
        '
        Me.Chb_edo_cta_rcv.AutoSize = True
        Me.Chb_edo_cta_rcv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_edo_cta_rcv.Location = New System.Drawing.Point(244, 347)
        Me.Chb_edo_cta_rcv.Name = "Chb_edo_cta_rcv"
        Me.Chb_edo_cta_rcv.Size = New System.Drawing.Size(159, 22)
        Me.Chb_edo_cta_rcv.TabIndex = 47
        Me.Chb_edo_cta_rcv.Text = "Edo Cuenta RCV"
        Me.Chb_edo_cta_rcv.UseVisualStyleBackColor = True
        '
        'Chb_arp
        '
        Me.Chb_arp.AutoSize = True
        Me.Chb_arp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_arp.Location = New System.Drawing.Point(244, 375)
        Me.Chb_arp.Name = "Chb_arp"
        Me.Chb_arp.Size = New System.Drawing.Size(133, 22)
        Me.Chb_arp.TabIndex = 48
        Me.Chb_arp.Text = "Formato ARP"
        Me.Chb_arp.UseVisualStyleBackColor = True
        '
        'Chb_not_estrado
        '
        Me.Chb_not_estrado.AutoSize = True
        Me.Chb_not_estrado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_not_estrado.Location = New System.Drawing.Point(244, 403)
        Me.Chb_not_estrado.Name = "Chb_not_estrado"
        Me.Chb_not_estrado.Size = New System.Drawing.Size(220, 22)
        Me.Chb_not_estrado.TabIndex = 53
        Me.Chb_not_estrado.Text = "Notificacion por Estrado"
        Me.Chb_not_estrado.UseVisualStyleBackColor = True
        '
        'Chb_sicofi
        '
        Me.Chb_sicofi.AutoSize = True
        Me.Chb_sicofi.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_sicofi.Location = New System.Drawing.Point(244, 431)
        Me.Chb_sicofi.Name = "Chb_sicofi"
        Me.Chb_sicofi.Size = New System.Drawing.Size(125, 22)
        Me.Chb_sicofi.TabIndex = 49
        Me.Chb_sicofi.Text = "Folio SICOFI"
        Me.Chb_sicofi.UseVisualStyleBackColor = True
        '
        'Chb_mandamiento
        '
        Me.Chb_mandamiento.AutoSize = True
        Me.Chb_mandamiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_mandamiento.Location = New System.Drawing.Point(244, 458)
        Me.Chb_mandamiento.Name = "Chb_mandamiento"
        Me.Chb_mandamiento.Size = New System.Drawing.Size(134, 22)
        Me.Chb_mandamiento.TabIndex = 51
        Me.Chb_mandamiento.Text = "Mandamiento"
        Me.Chb_mandamiento.UseVisualStyleBackColor = True
        '
        'Chb_ced_liq
        '
        Me.Chb_ced_liq.AutoSize = True
        Me.Chb_ced_liq.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_ced_liq.Location = New System.Drawing.Point(244, 486)
        Me.Chb_ced_liq.Name = "Chb_ced_liq"
        Me.Chb_ced_liq.Size = New System.Drawing.Size(203, 22)
        Me.Chb_ced_liq.TabIndex = 52
        Me.Chb_ced_liq.Text = "Cedula de Liquidacion"
        Me.Chb_ced_liq.UseVisualStyleBackColor = True
        '
        'Chb_amp_emb
        '
        Me.Chb_amp_emb.AutoSize = True
        Me.Chb_amp_emb.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_amp_emb.Location = New System.Drawing.Point(244, 514)
        Me.Chb_amp_emb.Name = "Chb_amp_emb"
        Me.Chb_amp_emb.Size = New System.Drawing.Size(215, 22)
        Me.Chb_amp_emb.TabIndex = 54
        Me.Chb_amp_emb.Text = "Ampliacion de Embargo"
        Me.Chb_amp_emb.UseVisualStyleBackColor = True
        '
        'Chb_completo
        '
        Me.Chb_completo.AutoSize = True
        Me.Chb_completo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_completo.Location = New System.Drawing.Point(675, 181)
        Me.Chb_completo.Name = "Chb_completo"
        Me.Chb_completo.Size = New System.Drawing.Size(103, 22)
        Me.Chb_completo.TabIndex = 103
        Me.Chb_completo.Text = "Completo"
        Me.Chb_completo.UseVisualStyleBackColor = True
        '
        'Txb_devolucion
        '
        Me.Txb_devolucion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_devolucion.Location = New System.Drawing.Point(525, 263)
        Me.Txb_devolucion.MaxLength = 100
        Me.Txb_devolucion.Multiline = True
        Me.Txb_devolucion.Name = "Txb_devolucion"
        Me.Txb_devolucion.Size = New System.Drawing.Size(351, 106)
        Me.Txb_devolucion.TabIndex = 104
        '
        'Dtp_devolucion
        '
        Me.Dtp_devolucion.CalendarFont = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_devolucion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_devolucion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_devolucion.Location = New System.Drawing.Point(525, 411)
        Me.Dtp_devolucion.Name = "Dtp_devolucion"
        Me.Dtp_devolucion.Size = New System.Drawing.Size(136, 26)
        Me.Dtp_devolucion.TabIndex = 107
        '
        'Cbx_integradores
        '
        Me.Cbx_integradores.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_integradores.FormattingEnabled = True
        Me.Cbx_integradores.Location = New System.Drawing.Point(289, 94)
        Me.Cbx_integradores.Name = "Cbx_integradores"
        Me.Cbx_integradores.Size = New System.Drawing.Size(411, 26)
        Me.Cbx_integradores.TabIndex = 42
        Me.Cbx_integradores.Visible = False
        '
        'Lbl_integrador_asignado
        '
        Me.Lbl_integrador_asignado.AutoSize = True
        Me.Lbl_integrador_asignado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_integrador_asignado.Location = New System.Drawing.Point(286, 75)
        Me.Lbl_integrador_asignado.Name = "Lbl_integrador_asignado"
        Me.Lbl_integrador_asignado.Size = New System.Drawing.Size(158, 17)
        Me.Lbl_integrador_asignado.TabIndex = 41
        Me.Lbl_integrador_asignado.Text = "Integrador Asignado"
        Me.Lbl_integrador_asignado.Visible = False
        '
        'Txb_foraneas
        '
        Me.Txb_foraneas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txb_foraneas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_foraneas.Location = New System.Drawing.Point(160, 94)
        Me.Txb_foraneas.MaxLength = 3
        Me.Txb_foraneas.Name = "Txb_foraneas"
        Me.Txb_foraneas.Size = New System.Drawing.Size(114, 26)
        Me.Txb_foraneas.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(148, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Foraneas"
        '
        'Txb_derivadas
        '
        Me.Txb_derivadas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txb_derivadas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_derivadas.Location = New System.Drawing.Point(28, 94)
        Me.Txb_derivadas.MaxLength = 3
        Me.Txb_derivadas.Name = "Txb_derivadas"
        Me.Txb_derivadas.Size = New System.Drawing.Size(114, 26)
        Me.Txb_derivadas.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Derivadas"
        '
        'Btn_cancelar
        '
        Me.Btn_cancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '        Me.Btn_cancelar.Image = Global.SICAD09.My.Resources.Resources.unavailable_32px
        Me.Btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_cancelar.Location = New System.Drawing.Point(656, 478)
        Me.Btn_cancelar.Name = "Btn_cancelar"
        Me.Btn_cancelar.Size = New System.Drawing.Size(95, 59)
        Me.Btn_cancelar.TabIndex = 36
        Me.Btn_cancelar.Text = "Cancelar"
        Me.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_cancelar.UseVisualStyleBackColor = True
        '
        'Btn_modificar
        '
        Me.Btn_modificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '        Me.Btn_modificar.Image = Global.SICAD09.My.Resources.Resources.edit_32px
        Me.Btn_modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_modificar.Location = New System.Drawing.Point(781, 478)
        Me.Btn_modificar.Name = "Btn_modificar"
        Me.Btn_modificar.Size = New System.Drawing.Size(95, 59)
        Me.Btn_modificar.TabIndex = 35
        Me.Btn_modificar.Text = "Modificar"
        Me.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_modificar.UseVisualStyleBackColor = True
        '
        'Btn_guardar
        '
        Me.Btn_guardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '        Me.Btn_guardar.Image = Global.SICAD09.My.Resources.Resources.save_32px
        Me.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_guardar.Location = New System.Drawing.Point(525, 477)
        Me.Btn_guardar.Name = "Btn_guardar"
        Me.Btn_guardar.Size = New System.Drawing.Size(95, 59)
        Me.Btn_guardar.TabIndex = 34
        Me.Btn_guardar.Text = "Guardar"
        Me.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_guardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(146, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "-"
        '
        'Txb_raz_soc
        '
        Me.Txb_raz_soc.Enabled = False
        Me.Txb_raz_soc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_raz_soc.Location = New System.Drawing.Point(201, 38)
        Me.Txb_raz_soc.MaxLength = 100
        Me.Txb_raz_soc.Name = "Txb_raz_soc"
        Me.Txb_raz_soc.Size = New System.Drawing.Size(499, 26)
        Me.Txb_raz_soc.TabIndex = 29
        '
        'Txb_dig_rp
        '
        Me.Txb_dig_rp.Enabled = False
        Me.Txb_dig_rp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_dig_rp.Location = New System.Drawing.Point(160, 38)
        Me.Txb_dig_rp.MaxLength = 1
        Me.Txb_dig_rp.Name = "Txb_dig_rp"
        Me.Txb_dig_rp.Size = New System.Drawing.Size(30, 26)
        Me.Txb_dig_rp.TabIndex = 28
        '
        'Txb_reg_pat
        '
        Me.Txb_reg_pat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txb_reg_pat.Enabled = False
        Me.Txb_reg_pat.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_reg_pat.Location = New System.Drawing.Point(31, 38)
        Me.Txb_reg_pat.MaxLength = 10
        Me.Txb_reg_pat.Name = "Txb_reg_pat"
        Me.Txb_reg_pat.Size = New System.Drawing.Size(114, 26)
        Me.Txb_reg_pat.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Razon Social"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Registro Patronal"
        '
        'Frm_02_documentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 749)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Frm_02_documentos"
        Me.Text = "Frm_02_documentos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Dgv_documentosnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CERRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Txb_raz_soc As TextBox
    Friend WithEvents Txb_dig_rp As TextBox
    Friend WithEvents Txb_reg_pat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents VERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_cancelar As Button
    Friend WithEvents Btn_modificar As Button
    Friend WithEvents Btn_guardar As Button
    Friend WithEvents Chb_foto As CheckBox
    Friend WithEvents Dgv_documentosnl As DataGridView
    Friend WithEvents Txb_foraneas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txb_derivadas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cbx_integradores As ComboBox
    Friend WithEvents Lbl_integrador_asignado As Label
    Friend WithEvents Rb_oepo As RadioButton
    Friend WithEvents Chb_amp_emb As CheckBox
    Friend WithEvents Chb_not_estrado As CheckBox
    Friend WithEvents Chb_ced_liq As CheckBox
    Friend WithEvents Chb_mandamiento As CheckBox
    Friend WithEvents Chb_mem_orig As CheckBox
    Friend WithEvents Chb_sicofi As CheckBox
    Friend WithEvents Chb_arp As CheckBox
    Friend WithEvents Chb_edo_cta_rcv As CheckBox
    Friend WithEvents Chb_edo_cta_cop As CheckBox
    Friend WithEvents Chb_edo_ade_rcv As CheckBox
    Friend WithEvents Chb_edo_ade_cop As CheckBox
    Friend WithEvents Chb_acta As CheckBox
    Friend WithEvents Rb_sindo As RadioButton
    Friend WithEvents Rb_foraneo As RadioButton
    Friend WithEvents Rb_correo As RadioButton
    Friend WithEvents Rb_cobros As RadioButton
    Friend WithEvents Rb_auditoria As RadioButton
    Friend WithEvents Rb_afiliacion As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Chb_completo As CheckBox
    Friend WithEvents Dtp_devolucion As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txb_devolucion As TextBox
    Friend WithEvents TodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SinRevisarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RevisadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompletadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevueltosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents id_documentosnl As Label
    Friend WithEvents id_patronesnl As Label
    Friend WithEvents EXPORTARToolStripMenuItem As ToolStripMenuItem
End Class
