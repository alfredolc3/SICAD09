<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_100_usuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CerrrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabRoles = New System.Windows.Forms.TabPage()
        Me.Btn_nuevo_rol = New System.Windows.Forms.Button()
        Me.Lbl_id_rol = New System.Windows.Forms.Label()
        Me.Txb_nombre_rol = New System.Windows.Forms.TextBox()
        Me.Btn_guardar_rol = New System.Windows.Forms.Button()
        Me.Btn_mod_rol = New System.Windows.Forms.Button()
        Me.Btn_eliminar_rol = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Dgv_roles = New System.Windows.Forms.DataGridView()
        Me.TabPermisos = New System.Windows.Forms.TabPage()
        Me.Btn_guardar_permisos = New System.Windows.Forms.Button()
        Me.Btn_todos_chk = New System.Windows.Forms.Button()
        Me.Btn_limpiar_chk = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Chb_4 = New System.Windows.Forms.CheckBox()
        Me.Chb_5 = New System.Windows.Forms.CheckBox()
        Me.Chb_6 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Chb_7 = New System.Windows.Forms.CheckBox()
        Me.Chb_8 = New System.Windows.Forms.CheckBox()
        Me.Chb_9 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Chb_10 = New System.Windows.Forms.CheckBox()
        Me.Chb_11 = New System.Windows.Forms.CheckBox()
        Me.Chb_12 = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Chb_1 = New System.Windows.Forms.CheckBox()
        Me.Chb_2 = New System.Windows.Forms.CheckBox()
        Me.Chb_3 = New System.Windows.Forms.CheckBox()
        Me.Cbx_rol_permiso = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabCargos = New System.Windows.Forms.TabPage()
        Me.Lbl_id_cargo = New System.Windows.Forms.Label()
        Me.Btn_nuevo_cargo = New System.Windows.Forms.Button()
        Me.Txb_nombre_cargo = New System.Windows.Forms.TextBox()
        Me.Btn_guardar_cargo = New System.Windows.Forms.Button()
        Me.Btn_mod_cargo = New System.Windows.Forms.Button()
        Me.Btn_eliminar_cargo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dgv_cargos = New System.Windows.Forms.DataGridView()
        Me.TabUsuarios = New System.Windows.Forms.TabPage()
        Me.Lbl_id_usuario = New System.Windows.Forms.Label()
        Me.Cbx_cargo = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txb_usuario = New System.Windows.Forms.TextBox()
        Me.Txb_pass1 = New System.Windows.Forms.TextBox()
        Me.Txb_pass2 = New System.Windows.Forms.TextBox()
        Me.Txb_nombre_usuario = New System.Windows.Forms.TextBox()
        Me.Cbx_roles = New System.Windows.Forms.ComboBox()
        Me.Txb_iniciales = New System.Windows.Forms.TextBox()
        Me.Cbx_activo = New System.Windows.Forms.ComboBox()
        Me.Btn_nuevo_usuario = New System.Windows.Forms.Button()
        Me.Btn_guardar_usuario = New System.Windows.Forms.Button()
        Me.Btn_mod_usuario = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Dgv_usuarios = New System.Windows.Forms.DataGridView()
        Me.TabForm = New System.Windows.Forms.TabPage()
        Me.Cbx_formularios = New System.Windows.Forms.ComboBox()
        Me.Cbx_acciones = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dgv_formularios = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabRoles.SuspendLayout()
        CType(Me.Dgv_roles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPermisos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabCargos.SuspendLayout()
        CType(Me.Dgv_cargos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabUsuarios.SuspendLayout()
        CType(Me.Dgv_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabForm.SuspendLayout()
        CType(Me.Dgv_formularios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrrarToolStripMenuItem
        '
        Me.CerrrarToolStripMenuItem.Name = "CerrrarToolStripMenuItem"
        Me.CerrrarToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.CerrrarToolStripMenuItem.Text = "Cerrrar"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabRoles)
        Me.TabControl1.Controls.Add(Me.TabPermisos)
        Me.TabControl1.Controls.Add(Me.TabCargos)
        Me.TabControl1.Controls.Add(Me.TabUsuarios)
        Me.TabControl1.Controls.Add(Me.TabForm)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 519)
        Me.TabControl1.TabIndex = 2
        '
        'TabRoles
        '
        Me.TabRoles.Controls.Add(Me.Btn_nuevo_rol)
        Me.TabRoles.Controls.Add(Me.Lbl_id_rol)
        Me.TabRoles.Controls.Add(Me.Txb_nombre_rol)
        Me.TabRoles.Controls.Add(Me.Btn_guardar_rol)
        Me.TabRoles.Controls.Add(Me.Btn_mod_rol)
        Me.TabRoles.Controls.Add(Me.Btn_eliminar_rol)
        Me.TabRoles.Controls.Add(Me.Label3)
        Me.TabRoles.Controls.Add(Me.Dgv_roles)
        Me.TabRoles.Location = New System.Drawing.Point(4, 22)
        Me.TabRoles.Name = "TabRoles"
        Me.TabRoles.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRoles.Size = New System.Drawing.Size(792, 493)
        Me.TabRoles.TabIndex = 1
        Me.TabRoles.Text = "Roles"
        Me.TabRoles.UseVisualStyleBackColor = True
        '
        'Btn_nuevo_rol
        '
        Me.Btn_nuevo_rol.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_nuevo_rol.Location = New System.Drawing.Point(32, 139)
        Me.Btn_nuevo_rol.Name = "Btn_nuevo_rol"
        Me.Btn_nuevo_rol.Size = New System.Drawing.Size(94, 32)
        Me.Btn_nuevo_rol.TabIndex = 1
        Me.Btn_nuevo_rol.Text = "Nuevo"
        Me.Btn_nuevo_rol.UseVisualStyleBackColor = True
        '
        'Lbl_id_rol
        '
        Me.Lbl_id_rol.AutoSize = True
        Me.Lbl_id_rol.Location = New System.Drawing.Point(8, 50)
        Me.Lbl_id_rol.Name = "Lbl_id_rol"
        Me.Lbl_id_rol.Size = New System.Drawing.Size(32, 13)
        Me.Lbl_id_rol.TabIndex = 10
        Me.Lbl_id_rol.Text = "id_rol"
        Me.Lbl_id_rol.Visible = False
        '
        'Txb_nombre_rol
        '
        Me.Txb_nombre_rol.Enabled = False
        Me.Txb_nombre_rol.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_nombre_rol.Location = New System.Drawing.Point(8, 66)
        Me.Txb_nombre_rol.Name = "Txb_nombre_rol"
        Me.Txb_nombre_rol.Size = New System.Drawing.Size(261, 26)
        Me.Txb_nombre_rol.TabIndex = 0
        '
        'Btn_guardar_rol
        '
        Me.Btn_guardar_rol.Enabled = False
        Me.Btn_guardar_rol.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_guardar_rol.Location = New System.Drawing.Point(160, 139)
        Me.Btn_guardar_rol.Name = "Btn_guardar_rol"
        Me.Btn_guardar_rol.Size = New System.Drawing.Size(94, 32)
        Me.Btn_guardar_rol.TabIndex = 2
        Me.Btn_guardar_rol.Text = "Guardar"
        Me.Btn_guardar_rol.UseVisualStyleBackColor = True
        '
        'Btn_mod_rol
        '
        Me.Btn_mod_rol.Enabled = False
        Me.Btn_mod_rol.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_mod_rol.Location = New System.Drawing.Point(32, 205)
        Me.Btn_mod_rol.Name = "Btn_mod_rol"
        Me.Btn_mod_rol.Size = New System.Drawing.Size(94, 32)
        Me.Btn_mod_rol.TabIndex = 3
        Me.Btn_mod_rol.Text = "Modificar"
        Me.Btn_mod_rol.UseVisualStyleBackColor = True
        '
        'Btn_eliminar_rol
        '
        Me.Btn_eliminar_rol.Enabled = False
        Me.Btn_eliminar_rol.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_eliminar_rol.Location = New System.Drawing.Point(160, 201)
        Me.Btn_eliminar_rol.Name = "Btn_eliminar_rol"
        Me.Btn_eliminar_rol.Size = New System.Drawing.Size(94, 36)
        Me.Btn_eliminar_rol.TabIndex = 4
        Me.Btn_eliminar_rol.Text = "Eliminar"
        Me.Btn_eliminar_rol.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ROL"
        '
        'Dgv_roles
        '
        Me.Dgv_roles.AllowUserToAddRows = False
        Me.Dgv_roles.AllowUserToDeleteRows = False
        Me.Dgv_roles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_roles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_roles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_roles.Location = New System.Drawing.Point(275, 31)
        Me.Dgv_roles.Name = "Dgv_roles"
        Me.Dgv_roles.ReadOnly = True
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_roles.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_roles.Size = New System.Drawing.Size(509, 386)
        Me.Dgv_roles.TabIndex = 5
        '
        'TabPermisos
        '
        Me.TabPermisos.Controls.Add(Me.Btn_guardar_permisos)
        Me.TabPermisos.Controls.Add(Me.Btn_todos_chk)
        Me.TabPermisos.Controls.Add(Me.Btn_limpiar_chk)
        Me.TabPermisos.Controls.Add(Me.GroupBox1)
        Me.TabPermisos.Controls.Add(Me.GroupBox2)
        Me.TabPermisos.Controls.Add(Me.GroupBox3)
        Me.TabPermisos.Controls.Add(Me.GroupBox4)
        Me.TabPermisos.Controls.Add(Me.Cbx_rol_permiso)
        Me.TabPermisos.Controls.Add(Me.Label12)
        Me.TabPermisos.Location = New System.Drawing.Point(4, 22)
        Me.TabPermisos.Name = "TabPermisos"
        Me.TabPermisos.Size = New System.Drawing.Size(792, 493)
        Me.TabPermisos.TabIndex = 4
        Me.TabPermisos.Text = "Permisos"
        Me.TabPermisos.UseVisualStyleBackColor = True
        '
        'Btn_guardar_permisos
        '
        Me.Btn_guardar_permisos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_guardar_permisos.Location = New System.Drawing.Point(680, 440)
        Me.Btn_guardar_permisos.Name = "Btn_guardar_permisos"
        Me.Btn_guardar_permisos.Size = New System.Drawing.Size(94, 32)
        Me.Btn_guardar_permisos.TabIndex = 35
        Me.Btn_guardar_permisos.Text = "Guardar"
        Me.Btn_guardar_permisos.UseVisualStyleBackColor = True
        '
        'Btn_todos_chk
        '
        Me.Btn_todos_chk.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_todos_chk.Location = New System.Drawing.Point(680, 360)
        Me.Btn_todos_chk.Name = "Btn_todos_chk"
        Me.Btn_todos_chk.Size = New System.Drawing.Size(94, 32)
        Me.Btn_todos_chk.TabIndex = 36
        Me.Btn_todos_chk.Text = "Todos"
        Me.Btn_todos_chk.UseVisualStyleBackColor = True
        '
        'Btn_limpiar_chk
        '
        Me.Btn_limpiar_chk.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_limpiar_chk.Location = New System.Drawing.Point(680, 398)
        Me.Btn_limpiar_chk.Name = "Btn_limpiar_chk"
        Me.Btn_limpiar_chk.Size = New System.Drawing.Size(94, 36)
        Me.Btn_limpiar_chk.TabIndex = 37
        Me.Btn_limpiar_chk.Text = "Limpiar"
        Me.Btn_limpiar_chk.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Chb_4)
        Me.GroupBox1.Controls.Add(Me.Chb_5)
        Me.GroupBox1.Controls.Add(Me.Chb_6)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 100)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "01 Nuevo NL"
        '
        'Chb_4
        '
        Me.Chb_4.AutoSize = True
        Me.Chb_4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_4.Location = New System.Drawing.Point(6, 19)
        Me.Chb_4.Name = "Chb_4"
        Me.Chb_4.Size = New System.Drawing.Size(75, 24)
        Me.Chb_4.TabIndex = 0
        Me.Chb_4.Text = "Guardar"
        Me.Chb_4.UseVisualStyleBackColor = True
        '
        'Chb_5
        '
        Me.Chb_5.AutoSize = True
        Me.Chb_5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_5.Location = New System.Drawing.Point(6, 42)
        Me.Chb_5.Name = "Chb_5"
        Me.Chb_5.Size = New System.Drawing.Size(82, 24)
        Me.Chb_5.TabIndex = 1
        Me.Chb_5.Text = "Modificar"
        Me.Chb_5.UseVisualStyleBackColor = True
        '
        'Chb_6
        '
        Me.Chb_6.AutoSize = True
        Me.Chb_6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_6.Location = New System.Drawing.Point(6, 65)
        Me.Chb_6.Name = "Chb_6"
        Me.Chb_6.Size = New System.Drawing.Size(71, 24)
        Me.Chb_6.TabIndex = 2
        Me.Chb_6.Text = "Listado"
        Me.Chb_6.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Chb_7)
        Me.GroupBox2.Controls.Add(Me.Chb_8)
        Me.GroupBox2.Controls.Add(Me.Chb_9)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(153, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 100)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "02 Documentos"
        '
        'Chb_7
        '
        Me.Chb_7.AutoSize = True
        Me.Chb_7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_7.Location = New System.Drawing.Point(6, 19)
        Me.Chb_7.Name = "Chb_7"
        Me.Chb_7.Size = New System.Drawing.Size(75, 24)
        Me.Chb_7.TabIndex = 3
        Me.Chb_7.Text = "Guardar"
        Me.Chb_7.UseVisualStyleBackColor = True
        '
        'Chb_8
        '
        Me.Chb_8.AutoSize = True
        Me.Chb_8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_8.Location = New System.Drawing.Point(6, 42)
        Me.Chb_8.Name = "Chb_8"
        Me.Chb_8.Size = New System.Drawing.Size(82, 24)
        Me.Chb_8.TabIndex = 4
        Me.Chb_8.Text = "Modificar"
        Me.Chb_8.UseVisualStyleBackColor = True
        '
        'Chb_9
        '
        Me.Chb_9.AutoSize = True
        Me.Chb_9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_9.Location = New System.Drawing.Point(6, 65)
        Me.Chb_9.Name = "Chb_9"
        Me.Chb_9.Size = New System.Drawing.Size(71, 24)
        Me.Chb_9.TabIndex = 5
        Me.Chb_9.Text = "Listado"
        Me.Chb_9.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Chb_10)
        Me.GroupBox3.Controls.Add(Me.Chb_11)
        Me.GroupBox3.Controls.Add(Me.Chb_12)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(322, 77)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(130, 100)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "03 Inicio"
        '
        'Chb_10
        '
        Me.Chb_10.AutoSize = True
        Me.Chb_10.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_10.Location = New System.Drawing.Point(6, 19)
        Me.Chb_10.Name = "Chb_10"
        Me.Chb_10.Size = New System.Drawing.Size(75, 24)
        Me.Chb_10.TabIndex = 6
        Me.Chb_10.Text = "Guardar"
        Me.Chb_10.UseVisualStyleBackColor = True
        '
        'Chb_11
        '
        Me.Chb_11.AutoSize = True
        Me.Chb_11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_11.Location = New System.Drawing.Point(6, 42)
        Me.Chb_11.Name = "Chb_11"
        Me.Chb_11.Size = New System.Drawing.Size(82, 24)
        Me.Chb_11.TabIndex = 7
        Me.Chb_11.Text = "Modificar"
        Me.Chb_11.UseVisualStyleBackColor = True
        '
        'Chb_12
        '
        Me.Chb_12.AutoSize = True
        Me.Chb_12.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_12.Location = New System.Drawing.Point(6, 65)
        Me.Chb_12.Name = "Chb_12"
        Me.Chb_12.Size = New System.Drawing.Size(71, 24)
        Me.Chb_12.TabIndex = 8
        Me.Chb_12.Text = "Listado"
        Me.Chb_12.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Chb_1)
        Me.GroupBox4.Controls.Add(Me.Chb_2)
        Me.GroupBox4.Controls.Add(Me.Chb_3)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(14, 359)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(160, 126)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Configuracion de Permisos"
        '
        'Chb_1
        '
        Me.Chb_1.AutoSize = True
        Me.Chb_1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_1.Location = New System.Drawing.Point(6, 38)
        Me.Chb_1.Name = "Chb_1"
        Me.Chb_1.Size = New System.Drawing.Size(75, 24)
        Me.Chb_1.TabIndex = 6
        Me.Chb_1.Text = "Guardar"
        Me.Chb_1.UseVisualStyleBackColor = True
        '
        'Chb_2
        '
        Me.Chb_2.AutoSize = True
        Me.Chb_2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_2.Location = New System.Drawing.Point(6, 62)
        Me.Chb_2.Name = "Chb_2"
        Me.Chb_2.Size = New System.Drawing.Size(82, 24)
        Me.Chb_2.TabIndex = 7
        Me.Chb_2.Text = "Modificar"
        Me.Chb_2.UseVisualStyleBackColor = True
        '
        'Chb_3
        '
        Me.Chb_3.AutoSize = True
        Me.Chb_3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_3.Location = New System.Drawing.Point(6, 86)
        Me.Chb_3.Name = "Chb_3"
        Me.Chb_3.Size = New System.Drawing.Size(71, 24)
        Me.Chb_3.TabIndex = 8
        Me.Chb_3.Text = "Listado"
        Me.Chb_3.UseVisualStyleBackColor = True
        '
        'Cbx_rol_permiso
        '
        Me.Cbx_rol_permiso.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_rol_permiso.FormattingEnabled = True
        Me.Cbx_rol_permiso.Location = New System.Drawing.Point(8, 32)
        Me.Cbx_rol_permiso.Name = "Cbx_rol_permiso"
        Me.Cbx_rol_permiso.Size = New System.Drawing.Size(261, 26)
        Me.Cbx_rol_permiso.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 18)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Rol"
        '
        'TabCargos
        '
        Me.TabCargos.Controls.Add(Me.Lbl_id_cargo)
        Me.TabCargos.Controls.Add(Me.Btn_nuevo_cargo)
        Me.TabCargos.Controls.Add(Me.Txb_nombre_cargo)
        Me.TabCargos.Controls.Add(Me.Btn_guardar_cargo)
        Me.TabCargos.Controls.Add(Me.Btn_mod_cargo)
        Me.TabCargos.Controls.Add(Me.Btn_eliminar_cargo)
        Me.TabCargos.Controls.Add(Me.Label4)
        Me.TabCargos.Controls.Add(Me.Dgv_cargos)
        Me.TabCargos.Location = New System.Drawing.Point(4, 22)
        Me.TabCargos.Name = "TabCargos"
        Me.TabCargos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCargos.Size = New System.Drawing.Size(792, 493)
        Me.TabCargos.TabIndex = 2
        Me.TabCargos.Text = "Cargos"
        Me.TabCargos.UseVisualStyleBackColor = True
        '
        'Lbl_id_cargo
        '
        Me.Lbl_id_cargo.AutoSize = True
        Me.Lbl_id_cargo.Location = New System.Drawing.Point(8, 50)
        Me.Lbl_id_cargo.Name = "Lbl_id_cargo"
        Me.Lbl_id_cargo.Size = New System.Drawing.Size(48, 13)
        Me.Lbl_id_cargo.TabIndex = 17
        Me.Lbl_id_cargo.Text = "id_cargo"
        Me.Lbl_id_cargo.Visible = False
        '
        'Btn_nuevo_cargo
        '
        Me.Btn_nuevo_cargo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_nuevo_cargo.Location = New System.Drawing.Point(32, 143)
        Me.Btn_nuevo_cargo.Name = "Btn_nuevo_cargo"
        Me.Btn_nuevo_cargo.Size = New System.Drawing.Size(94, 32)
        Me.Btn_nuevo_cargo.TabIndex = 1
        Me.Btn_nuevo_cargo.Text = "Nuevo"
        Me.Btn_nuevo_cargo.UseVisualStyleBackColor = True
        '
        'Txb_nombre_cargo
        '
        Me.Txb_nombre_cargo.Enabled = False
        Me.Txb_nombre_cargo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_nombre_cargo.Location = New System.Drawing.Point(8, 67)
        Me.Txb_nombre_cargo.Name = "Txb_nombre_cargo"
        Me.Txb_nombre_cargo.Size = New System.Drawing.Size(261, 26)
        Me.Txb_nombre_cargo.TabIndex = 0
        '
        'Btn_guardar_cargo
        '
        Me.Btn_guardar_cargo.Enabled = False
        Me.Btn_guardar_cargo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_guardar_cargo.Location = New System.Drawing.Point(160, 143)
        Me.Btn_guardar_cargo.Name = "Btn_guardar_cargo"
        Me.Btn_guardar_cargo.Size = New System.Drawing.Size(94, 32)
        Me.Btn_guardar_cargo.TabIndex = 2
        Me.Btn_guardar_cargo.Text = "Guardar"
        Me.Btn_guardar_cargo.UseVisualStyleBackColor = True
        '
        'Btn_mod_cargo
        '
        Me.Btn_mod_cargo.Enabled = False
        Me.Btn_mod_cargo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_mod_cargo.Location = New System.Drawing.Point(32, 209)
        Me.Btn_mod_cargo.Name = "Btn_mod_cargo"
        Me.Btn_mod_cargo.Size = New System.Drawing.Size(94, 32)
        Me.Btn_mod_cargo.TabIndex = 3
        Me.Btn_mod_cargo.Text = "Modificar"
        Me.Btn_mod_cargo.UseVisualStyleBackColor = True
        '
        'Btn_eliminar_cargo
        '
        Me.Btn_eliminar_cargo.Enabled = False
        Me.Btn_eliminar_cargo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_eliminar_cargo.Location = New System.Drawing.Point(160, 209)
        Me.Btn_eliminar_cargo.Name = "Btn_eliminar_cargo"
        Me.Btn_eliminar_cargo.Size = New System.Drawing.Size(94, 32)
        Me.Btn_eliminar_cargo.TabIndex = 4
        Me.Btn_eliminar_cargo.Text = "Eliminar"
        Me.Btn_eliminar_cargo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "CARGOS"
        '
        'Dgv_cargos
        '
        Me.Dgv_cargos.AllowUserToAddRows = False
        Me.Dgv_cargos.AllowUserToDeleteRows = False
        Me.Dgv_cargos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_cargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_cargos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_cargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_cargos.Location = New System.Drawing.Point(275, 31)
        Me.Dgv_cargos.Name = "Dgv_cargos"
        Me.Dgv_cargos.ReadOnly = True
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_cargos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_cargos.Size = New System.Drawing.Size(509, 386)
        Me.Dgv_cargos.TabIndex = 5
        '
        'TabUsuarios
        '
        Me.TabUsuarios.Controls.Add(Me.Lbl_id_usuario)
        Me.TabUsuarios.Controls.Add(Me.Cbx_cargo)
        Me.TabUsuarios.Controls.Add(Me.Label13)
        Me.TabUsuarios.Controls.Add(Me.Txb_usuario)
        Me.TabUsuarios.Controls.Add(Me.Txb_pass1)
        Me.TabUsuarios.Controls.Add(Me.Txb_pass2)
        Me.TabUsuarios.Controls.Add(Me.Txb_nombre_usuario)
        Me.TabUsuarios.Controls.Add(Me.Cbx_roles)
        Me.TabUsuarios.Controls.Add(Me.Txb_iniciales)
        Me.TabUsuarios.Controls.Add(Me.Cbx_activo)
        Me.TabUsuarios.Controls.Add(Me.Btn_nuevo_usuario)
        Me.TabUsuarios.Controls.Add(Me.Btn_guardar_usuario)
        Me.TabUsuarios.Controls.Add(Me.Btn_mod_usuario)
        Me.TabUsuarios.Controls.Add(Me.Label10)
        Me.TabUsuarios.Controls.Add(Me.Label9)
        Me.TabUsuarios.Controls.Add(Me.Label8)
        Me.TabUsuarios.Controls.Add(Me.Label7)
        Me.TabUsuarios.Controls.Add(Me.Label6)
        Me.TabUsuarios.Controls.Add(Me.Label5)
        Me.TabUsuarios.Controls.Add(Me.Label11)
        Me.TabUsuarios.Controls.Add(Me.Dgv_usuarios)
        Me.TabUsuarios.Location = New System.Drawing.Point(4, 22)
        Me.TabUsuarios.Name = "TabUsuarios"
        Me.TabUsuarios.Size = New System.Drawing.Size(792, 493)
        Me.TabUsuarios.TabIndex = 3
        Me.TabUsuarios.Text = "Usuarios"
        Me.TabUsuarios.UseVisualStyleBackColor = True
        '
        'Lbl_id_usuario
        '
        Me.Lbl_id_usuario.AutoSize = True
        Me.Lbl_id_usuario.Location = New System.Drawing.Point(195, 7)
        Me.Lbl_id_usuario.Name = "Lbl_id_usuario"
        Me.Lbl_id_usuario.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_id_usuario.TabIndex = 37
        Me.Lbl_id_usuario.Text = "Lbl_id_usuario"
        Me.Lbl_id_usuario.Visible = False
        '
        'Cbx_cargo
        '
        Me.Cbx_cargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbx_cargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_cargo.Enabled = False
        Me.Cbx_cargo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_cargo.FormattingEnabled = True
        Me.Cbx_cargo.Location = New System.Drawing.Point(8, 254)
        Me.Cbx_cargo.Name = "Cbx_cargo"
        Me.Cbx_cargo.Size = New System.Drawing.Size(261, 26)
        Me.Cbx_cargo.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 231)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 18)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Cargo"
        '
        'Txb_usuario
        '
        Me.Txb_usuario.Enabled = False
        Me.Txb_usuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_usuario.Location = New System.Drawing.Point(8, 38)
        Me.Txb_usuario.Name = "Txb_usuario"
        Me.Txb_usuario.Size = New System.Drawing.Size(261, 26)
        Me.Txb_usuario.TabIndex = 0
        '
        'Txb_pass1
        '
        Me.Txb_pass1.Enabled = False
        Me.Txb_pass1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_pass1.Location = New System.Drawing.Point(8, 92)
        Me.Txb_pass1.Name = "Txb_pass1"
        Me.Txb_pass1.Size = New System.Drawing.Size(261, 26)
        Me.Txb_pass1.TabIndex = 1
        Me.Txb_pass1.UseSystemPasswordChar = True
        '
        'Txb_pass2
        '
        Me.Txb_pass2.Enabled = False
        Me.Txb_pass2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_pass2.Location = New System.Drawing.Point(8, 146)
        Me.Txb_pass2.Name = "Txb_pass2"
        Me.Txb_pass2.Size = New System.Drawing.Size(261, 26)
        Me.Txb_pass2.TabIndex = 2
        Me.Txb_pass2.UseSystemPasswordChar = True
        '
        'Txb_nombre_usuario
        '
        Me.Txb_nombre_usuario.Enabled = False
        Me.Txb_nombre_usuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_nombre_usuario.Location = New System.Drawing.Point(8, 200)
        Me.Txb_nombre_usuario.Name = "Txb_nombre_usuario"
        Me.Txb_nombre_usuario.Size = New System.Drawing.Size(261, 26)
        Me.Txb_nombre_usuario.TabIndex = 3
        '
        'Cbx_roles
        '
        Me.Cbx_roles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbx_roles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_roles.Enabled = False
        Me.Cbx_roles.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_roles.FormattingEnabled = True
        Me.Cbx_roles.Location = New System.Drawing.Point(9, 308)
        Me.Cbx_roles.Name = "Cbx_roles"
        Me.Cbx_roles.Size = New System.Drawing.Size(261, 26)
        Me.Cbx_roles.TabIndex = 5
        '
        'Txb_iniciales
        '
        Me.Txb_iniciales.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.Txb_iniciales.Enabled = False
        Me.Txb_iniciales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_iniciales.Location = New System.Drawing.Point(8, 362)
        Me.Txb_iniciales.Name = "Txb_iniciales"
        Me.Txb_iniciales.Size = New System.Drawing.Size(102, 26)
        Me.Txb_iniciales.TabIndex = 6
        '
        'Cbx_activo
        '
        Me.Cbx_activo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbx_activo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_activo.Enabled = False
        Me.Cbx_activo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_activo.FormattingEnabled = True
        Me.Cbx_activo.Items.AddRange(New Object() {"SI", "NO"})
        Me.Cbx_activo.Location = New System.Drawing.Point(167, 362)
        Me.Cbx_activo.Name = "Cbx_activo"
        Me.Cbx_activo.Size = New System.Drawing.Size(102, 26)
        Me.Cbx_activo.TabIndex = 7
        '
        'Btn_nuevo_usuario
        '
        Me.Btn_nuevo_usuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_nuevo_usuario.Location = New System.Drawing.Point(8, 403)
        Me.Btn_nuevo_usuario.Name = "Btn_nuevo_usuario"
        Me.Btn_nuevo_usuario.Size = New System.Drawing.Size(94, 32)
        Me.Btn_nuevo_usuario.TabIndex = 8
        Me.Btn_nuevo_usuario.Text = "Nuevo"
        Me.Btn_nuevo_usuario.UseVisualStyleBackColor = True
        '
        'Btn_guardar_usuario
        '
        Me.Btn_guardar_usuario.Enabled = False
        Me.Btn_guardar_usuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_guardar_usuario.Location = New System.Drawing.Point(175, 403)
        Me.Btn_guardar_usuario.Name = "Btn_guardar_usuario"
        Me.Btn_guardar_usuario.Size = New System.Drawing.Size(94, 32)
        Me.Btn_guardar_usuario.TabIndex = 9
        Me.Btn_guardar_usuario.Text = "Guardar"
        Me.Btn_guardar_usuario.UseVisualStyleBackColor = True
        '
        'Btn_mod_usuario
        '
        Me.Btn_mod_usuario.Enabled = False
        Me.Btn_mod_usuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_mod_usuario.Location = New System.Drawing.Point(89, 453)
        Me.Btn_mod_usuario.Name = "Btn_mod_usuario"
        Me.Btn_mod_usuario.Size = New System.Drawing.Size(94, 32)
        Me.Btn_mod_usuario.TabIndex = 10
        Me.Btn_mod_usuario.Text = "Modificar"
        Me.Btn_mod_usuario.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 339)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 18)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Iniciales"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 18)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 18)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Rol"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 18)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Confirmar Contraseña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 18)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Contraseña"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Usuario"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(210, 339)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 18)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Activo"
        '
        'Dgv_usuarios
        '
        Me.Dgv_usuarios.AllowUserToAddRows = False
        Me.Dgv_usuarios.AllowUserToDeleteRows = False
        Me.Dgv_usuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_usuarios.Location = New System.Drawing.Point(275, 7)
        Me.Dgv_usuarios.Name = "Dgv_usuarios"
        Me.Dgv_usuarios.ReadOnly = True
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_usuarios.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_usuarios.Size = New System.Drawing.Size(509, 474)
        Me.Dgv_usuarios.TabIndex = 12
        Me.Dgv_usuarios.TabStop = False
        '
        'TabForm
        '
        Me.TabForm.Controls.Add(Me.Cbx_formularios)
        Me.TabForm.Controls.Add(Me.Cbx_acciones)
        Me.TabForm.Controls.Add(Me.Label2)
        Me.TabForm.Controls.Add(Me.Label1)
        Me.TabForm.Controls.Add(Me.Dgv_formularios)
        Me.TabForm.Location = New System.Drawing.Point(4, 22)
        Me.TabForm.Name = "TabForm"
        Me.TabForm.Padding = New System.Windows.Forms.Padding(3)
        Me.TabForm.Size = New System.Drawing.Size(792, 493)
        Me.TabForm.TabIndex = 0
        Me.TabForm.Text = "Formularios"
        Me.TabForm.UseVisualStyleBackColor = True
        '
        'Cbx_formularios
        '
        Me.Cbx_formularios.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_formularios.FormattingEnabled = True
        Me.Cbx_formularios.Location = New System.Drawing.Point(8, 60)
        Me.Cbx_formularios.Name = "Cbx_formularios"
        Me.Cbx_formularios.Size = New System.Drawing.Size(260, 26)
        Me.Cbx_formularios.TabIndex = 0
        '
        'Cbx_acciones
        '
        Me.Cbx_acciones.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_acciones.FormattingEnabled = True
        Me.Cbx_acciones.Items.AddRange(New Object() {"Guardar", "Modificar", "Listado"})
        Me.Cbx_acciones.Location = New System.Drawing.Point(8, 132)
        Me.Cbx_acciones.Name = "Cbx_acciones"
        Me.Cbx_acciones.Size = New System.Drawing.Size(260, 26)
        Me.Cbx_acciones.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Acciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Formularios"
        '
        'Dgv_formularios
        '
        Me.Dgv_formularios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_formularios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_formularios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_formularios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_formularios.Location = New System.Drawing.Point(275, 31)
        Me.Dgv_formularios.Name = "Dgv_formularios"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_formularios.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_formularios.Size = New System.Drawing.Size(509, 386)
        Me.Dgv_formularios.TabIndex = 2
        '
        'Frm_00_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 543)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_00_usuarios"
        Me.Text = "Usuarios y permisos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabRoles.ResumeLayout(False)
        Me.TabRoles.PerformLayout()
        CType(Me.Dgv_roles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPermisos.ResumeLayout(False)
        Me.TabPermisos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabCargos.ResumeLayout(False)
        Me.TabCargos.PerformLayout()
        CType(Me.Dgv_cargos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabUsuarios.ResumeLayout(False)
        Me.TabUsuarios.PerformLayout()
        CType(Me.Dgv_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabForm.ResumeLayout(False)
        Me.TabForm.PerformLayout()
        CType(Me.Dgv_formularios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CerrrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabForm As TabPage
    Friend WithEvents TabRoles As TabPage
    Friend WithEvents TabCargos As TabPage
    Friend WithEvents TabUsuarios As TabPage
    Friend WithEvents TabPermisos As TabPage
    Friend WithEvents Cbx_acciones As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cbx_formularios As ComboBox
    Friend WithEvents Dgv_formularios As DataGridView
    Friend WithEvents Txb_nombre_rol As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Dgv_roles As DataGridView
    Friend WithEvents Btn_eliminar_rol As Button
    Friend WithEvents Btn_mod_rol As Button
    Friend WithEvents Btn_guardar_rol As Button
    Friend WithEvents Btn_eliminar_cargo As Button
    Friend WithEvents Btn_mod_cargo As Button
    Friend WithEvents Btn_guardar_cargo As Button
    Friend WithEvents Txb_nombre_cargo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Dgv_cargos As DataGridView
    Friend WithEvents Txb_usuario As TextBox
    Friend WithEvents Txb_pass1 As TextBox
    Friend WithEvents Txb_pass2 As TextBox
    Friend WithEvents Txb_nombre_usuario As TextBox
    Friend WithEvents Cbx_roles As ComboBox
    Friend WithEvents Txb_iniciales As TextBox
    Friend WithEvents Cbx_activo As ComboBox
    Friend WithEvents Btn_guardar_usuario As Button
    Friend WithEvents Btn_mod_usuario As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Dgv_usuarios As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Cbx_rol_permiso As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Cbx_cargo As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Chb_4 As CheckBox
    Friend WithEvents Chb_5 As CheckBox
    Friend WithEvents Chb_6 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Chb_7 As CheckBox
    Friend WithEvents Chb_8 As CheckBox
    Friend WithEvents Chb_9 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Chb_10 As CheckBox
    Friend WithEvents Chb_11 As CheckBox
    Friend WithEvents Chb_12 As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Chb_1 As CheckBox
    Friend WithEvents Chb_2 As CheckBox
    Friend WithEvents Chb_3 As CheckBox
    Friend WithEvents Lbl_id_rol As Label
    Friend WithEvents Btn_nuevo_rol As Button
    Friend WithEvents Lbl_id_cargo As Label
    Friend WithEvents Btn_nuevo_cargo As Button
    Friend WithEvents Btn_nuevo_usuario As Button
    Friend WithEvents Lbl_id_usuario As Label
    Friend WithEvents Btn_guardar_permisos As Button
    Friend WithEvents Btn_todos_chk As Button
    Friend WithEvents Btn_limpiar_chk As Button
End Class
