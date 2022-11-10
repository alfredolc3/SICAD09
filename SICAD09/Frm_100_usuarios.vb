Imports Npgsql

Public Class Frm_100_usuarios
    Private Sub Frm_00_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
    End Sub
    'carga de las pestañas
    'rol
    Private Sub TabRoles_Enter(sender As Object, e As EventArgs) Handles TabRoles.Enter
        '  MsgBox("Estas dentro de Roles")
        Llenagrid_roles()
    End Sub
    Private Sub TabCargos_Enter(sender As Object, e As EventArgs) Handles TabCargos.Enter
        ' MsgBox("Estas dentro de Cargos")
        Llenagrid_cargos()
    End Sub
    Private Sub TabUsuarios_Enter(sender As Object, e As EventArgs) Handles TabUsuarios.Enter
        Llenagrid_usuarios()
    End Sub
    Private Sub TabPermisos_Enter(sender As Object, e As EventArgs) Handles TabPermisos.Enter
        Cargar_roles_permisos()
        'MsgBox("Estas dentro de Permisos")
    End Sub

    Private Sub TabForm_Enter(sender As Object, e As EventArgs) Handles TabForm.Enter
        'MsgBox("Estas dentro de Formularios")
        Llenagrid_formularios()
    End Sub

    'rutinas para los formularios
    Public Sub Cargar_combo_form()

        Sql = "SELECT * FROM domicilio.sicad_formularios"

        Cmd = New NpgsqlCommand(Sql, Mycon)
        Dr = Cmd.ExecuteReader

        Dim Dt As New Data.DataTable
        Dt.Load(Dr)

        Cbx_formularios.ValueMember = "idformulario"
        Cbx_formularios.DisplayMember = "nombre"
        Cbx_formularios.DataSource = Dt

        Dr.Close()
        'cargo el combo de formularios
        'Dim myAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        'Dim tipos As Type() = myAssembly.GetTypes()
        'For Each miTipo In tipos
        '    If miTipo.BaseType.FullName = "System.Windows.Forms.Form" Then
        '        Me.Cbx_formularios.Items.Add(miTipo.Name)
        '    End If
        'Next
    End Sub
    Public Shared Function CrearInstanciaObjeto(ByVal nombreTipoObjeto As String) As Object

        Dim obj As Object
        Dim nombreCompletoTipo As String = nombreTipoObjeto
        Dim appendNamespace As Boolean

        Try
            If nombreTipoObjeto.LastIndexOf(".") = -1 Then
                nombreCompletoTipo = System.Reflection.Assembly.GetEntryAssembly.GetName.Name & "." & nombreTipoObjeto
                appendNamespace = True
                'nombreCompletoTipo = [ Assembly ].GetEntryAssembly.GetName.Name & "." & nombreTipoObjetoappendNamespace = True
                'System.Reflection.Assembly.GetEntryAssembly.GetName.Name
            End If

            obj = System.Reflection.Assembly.GetEntryAssembly.CreateInstance(nombreCompletoTipo)

            If (obj Is Nothing) Then

                Dim asms() As System.Reflection.Assembly = AppDomain.CurrentDomain.GetAssemblies()

                For Each asm As System.Reflection.Assembly In asms
                    Try
                        If appendNamespace Then
                            nombreCompletoTipo = asm.GetName.Name & "." & nombreTipoObjeto
                        End If
                        obj = asm.CreateInstance(nombreCompletoTipo)

                    Catch ex As Exception
                        obj = Nothing
                    End Try

                    If Not (obj Is Nothing) Then
                        Exit For
                    End If
                Next

            End If
        Catch ex As Exception
            '--Log Error
            Throw New ApplicationException("Error al crear la instancia")
        End Try
        Return obj

    End Function
    Private Sub Cbx_formularios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_formularios.SelectedIndexChanged
        Me.Cbx_acciones.Items.Clear()
        If Me.Cbx_formularios.Text <> "" Then
            'creo la instancia del formulario que tengo seleccionado en el otro combo
            Dim frm As Form = DirectCast(CrearInstanciaObjeto(Me.Cbx_formularios.Text), Form)
            For Each ctrl As Control In frm.Controls
                Cbx_acciones.Items.Add(ctrl.Name)
            Next
        End If
    End Sub

    'Llena LOS DGV

    Public Sub Llenagrid_roles()

        'Sql esta definida de manera global en el archivo de conexion
        Sql = "SELECT * FROM domicilio.sicad_roles ORDER BY id_rol ASC"
        Adp = New NpgsqlDataAdapter(Sql, Mycon)
        Ds.Tables.Clear()
        Adp.Fill(Ds.Tables.Add("Tabla"))
        Me.Dgv_roles.DataSource = Ds.Tables("Tabla")
        Adp.Dispose()
    End Sub
    Public Sub Llenagrid_cargos()
        'Sql esta definida de manera global en el archivo de conexion
        Sql = "SELECT * FROM domicilio.sicad_cargos"
        Adp = New NpgsqlDataAdapter(Sql, Mycon)
        Ds.Tables.Clear()
        Adp.Fill(Ds.Tables.Add("Tabla"))
        Me.Dgv_cargos.DataSource = Ds.Tables("Tabla")
        Adp.Dispose()
    End Sub
    Public Sub Llenagrid_usuarios()
        'Sql esta definida de manera global en el archivo de conexion
        Sql = "SELECT * FROM domicilio.vw_sicad_usuarios"
        Adp = New NpgsqlDataAdapter(Sql, Mycon)
        Ds.Tables.Clear()
        Adp.Fill(Ds.Tables.Add("Tabla"))
        Me.Dgv_usuarios.DataSource = Ds.Tables("Tabla")
        Adp.Dispose()
    End Sub
    Public Sub Llenagrid_formularios()
        'Sql esta definida de manera global en el archivo de conexion
        Sql = "SELECT * FROM domicilio.sicad_formularios"
        Adp = New NpgsqlDataAdapter(Sql, Mycon)
        Ds.Tables.Clear()
        Adp.Fill(Ds.Tables.Add("Tabla"))
        Me.Dgv_formularios.DataSource = Ds.Tables("Tabla")
        Adp.Dispose()
    End Sub

    'Acciones de Roles
    'Recuerda agregar los permisos nuevos cada que se crea un nuevo formulario
    Private Sub Btn_nuevo_Click(sender As Object, e As EventArgs) Handles Btn_nuevo_rol.Click

        Lbl_id_rol.Text = ""
        Txb_nombre_rol.Clear()
        Txb_nombre_rol.Enabled = True
        Btn_guardar_rol.Enabled = True
        Btn_mod_rol.Enabled = False
        Btn_eliminar_rol.Enabled = False
    End Sub
    Private Sub Btn_guardar_rol_Click(sender As Object, e As EventArgs) Handles Btn_guardar_rol.Click
        If Txb_nombre_rol.Text = "" Then
            MsgBox("No se Puede Agregar Campo Vacio")
            Txb_nombre_rol.Focus()
        Else
            Sql = "With rows as (
                    INSERT INTO domicilio.sicad_roles
                        (rol,createat,updateat)
                    VALUES 
                        (@rol,@createat,@updateat)
                    RETURNING id_rol
                    )
                    INSERT INTO domicilio.sicad_permisos(idrol,p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12)
                    SELECT id_rol,false,false,false,false,false,false,false,false,false,false,false,false
                    FROM rows"

            'agregar el rol a la tabla permisos y todos los demas seran en 0

            Cmd = New NpgsqlCommand(Sql, Mycon)
            Cmd.Parameters.AddWithValue("@rol", Txb_nombre_rol.Text)
            Cmd.Parameters.AddWithValue("@createat", Now) 'formato fecha y hora
            Cmd.Parameters.AddWithValue("@updateat", Now) 'formato fecha y hora

            Try
                Cmd.ExecuteNonQuery()
                MsgBox("Rol Agregado", vbInformation, "Mensaje del Sistema")
                Lbl_id_rol.Text = ""
                Txb_nombre_rol.Clear()
                Txb_nombre_rol.Enabled = False
                Btn_guardar_rol.Enabled = False
                Llenagrid_roles()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub Dgv_roles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_roles.CellClick
        Dim i As Integer
        Try
            i = Dgv_roles.CurrentRow.Index
            Lbl_id_rol.Text = Dgv_roles.Item(0, i).Value()
            Txb_nombre_rol.Text = Dgv_roles.Item(1, i).Value()
            Btn_guardar_rol.Enabled = False

            If Lbl_id_rol.Text = 1 Then
                MsgBox("No puede Modificar este ROL", MsgBoxStyle.Critical)
                Txb_nombre_rol.Enabled = False
                Btn_mod_rol.Enabled = False
                Btn_eliminar_rol.Enabled = False

            Else
                Txb_nombre_rol.Enabled = True
                Btn_mod_rol.Enabled = True
                Btn_eliminar_rol.Enabled = True

            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Btn_mod_rol_Click(sender As Object, e As EventArgs) Handles Btn_mod_rol.Click
        If Txb_nombre_rol.Text = "" Then
            MsgBox("No se Puede actualizar Campo Vacio")
        Else


            Sql = "UPDATE domicilio.sicad_roles
                    SET 
                        rol = @rol,
                        updateat = @updateat
                    WHERE id_rol = " & Lbl_id_rol.Text

            Cmd = New NpgsqlCommand(Sql, Mycon)

            Cmd.Parameters.AddWithValue("@rol", Txb_nombre_rol.Text)
            Cmd.Parameters.AddWithValue("@updateat", Now)

            Try

                Cmd.ExecuteNonQuery()
                MsgBox("Rol Actualizado", vbInformation, "Mensaje del Sistema")
                Lbl_id_rol.Text = ""
                Txb_nombre_rol.Clear()
                Txb_nombre_rol.Enabled = False
                Btn_mod_rol.Enabled = False
                Btn_eliminar_rol.Enabled = False
                Llenagrid_roles()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub
    Private Sub Btn_eliminar_rol_Click(sender As Object, e As EventArgs) Handles Btn_eliminar_rol.Click
        MsgBox("Analizar Base de Datos para ver si puede eliminar este rol", MsgBoxStyle.Critical)
        Lbl_id_rol.Text = ""
        Txb_nombre_rol.Clear()
        Txb_nombre_rol.Enabled = False
        Btn_mod_rol.Enabled = False
        Btn_eliminar_rol.Enabled = False
        Llenagrid_roles()
    End Sub
    Private Sub TabRoles_Leave(sender As Object, e As EventArgs) Handles TabRoles.Leave
        Lbl_id_rol.Text = ""
        Txb_nombre_rol.Clear()
        Txb_nombre_rol.Enabled = False
        Btn_guardar_rol.Enabled = False
        Btn_mod_rol.Enabled = False
        Btn_eliminar_rol.Enabled = False
    End Sub

    'Acciones Cargos
    Private Sub Btn_nuevo_cargo_Click(sender As Object, e As EventArgs) Handles Btn_nuevo_cargo.Click

        Lbl_id_cargo.Text = ""
        Txb_nombre_cargo.Clear()
        Txb_nombre_cargo.Enabled = True
        Btn_guardar_cargo.Enabled = True
        Btn_mod_cargo.Enabled = False
        Btn_eliminar_cargo.Enabled = False
    End Sub
    Private Sub Btn_guardar_cargo_Click(sender As Object, e As EventArgs) Handles Btn_guardar_cargo.Click
        If Txb_nombre_cargo.Text = "" Then
            MsgBox("No se Puede Agregar Campo Vacio")
            Txb_nombre_cargo.Focus()
        Else
            Sql = "INSERT INTO domicilio.sicad_cargos
                    (cargo,createat,updateat)
                VALUES 
                    (@cargo,@createat,@updateat)"

            Cmd = New NpgsqlCommand(Sql, Mycon)
            Cmd.Parameters.AddWithValue("@cargo", Txb_nombre_cargo.Text)
            Cmd.Parameters.AddWithValue("@createat", Now) 'formato fecha y hora
            Cmd.Parameters.AddWithValue("@updateat", Now) 'formato fecha y hora

            Try
                Cmd.ExecuteNonQuery()
                MsgBox("cargo Agregado", vbInformation, "Mensaje del Sistema")
                Lbl_id_cargo.Text = ""
                Txb_nombre_cargo.Clear()
                Txb_nombre_cargo.Enabled = False
                Btn_guardar_cargo.Enabled = False
                Llenagrid_cargos()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub Dgv_cargos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_cargos.CellClick
        Dim i As Integer
        Try
            i = Dgv_cargos.CurrentRow.Index
            Lbl_id_cargo.Text = Dgv_cargos.Item(0, i).Value()
            Txb_nombre_cargo.Text = Dgv_cargos.Item(1, i).Value()
            Btn_guardar_cargo.Enabled = False

            If Lbl_id_cargo.Text = 1 Then
                MsgBox("No puede Modificar este cargo", MsgBoxStyle.Critical)
                Txb_nombre_cargo.Enabled = False
                Btn_mod_cargo.Enabled = False
                Btn_eliminar_cargo.Enabled = False

            Else
                Txb_nombre_cargo.Enabled = True
                Btn_mod_cargo.Enabled = True
                Btn_eliminar_cargo.Enabled = True

            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Btn_mod_cargo_Click(sender As Object, e As EventArgs) Handles Btn_mod_cargo.Click
        If Txb_nombre_cargo.Text = "" Then
            MsgBox("No se Puede actualizar Campo Vacio")
        Else
            Sql = "UPDATE domicilio.sicad_cargos
                    SET 
                        cargo = @cargo,
                        updateat = @updateat
                    WHERE idcargo = " & Lbl_id_cargo.Text
            Cmd = New NpgsqlCommand(Sql, Mycon)
            Cmd.Parameters.AddWithValue("@cargo", Txb_nombre_cargo.Text)
            Cmd.Parameters.AddWithValue("@updateat", Now)
            Try
                Cmd.ExecuteNonQuery()
                MsgBox("cargo Actualizado", vbInformation, "Mensaje del Sistema")
                Lbl_id_cargo.Text = ""
                Txb_nombre_cargo.Clear()
                Txb_nombre_cargo.Enabled = False
                Btn_mod_cargo.Enabled = False
                Btn_eliminar_cargo.Enabled = False
                Llenagrid_cargos()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub
    Private Sub Btn_eliminar_cargo_Click(sender As Object, e As EventArgs) Handles Btn_eliminar_cargo.Click
        MsgBox("Analizar Base de Datos para ver si puede eliminar este cargo", MsgBoxStyle.Critical)
        Lbl_id_cargo.Text = ""
        Txb_nombre_cargo.Clear()
        Txb_nombre_cargo.Enabled = False
        Btn_mod_cargo.Enabled = False
        Btn_eliminar_cargo.Enabled = False
        Llenagrid_cargos()
    End Sub
    Private Sub TabCargos_Leave(sender As Object, e As EventArgs) Handles TabCargos.Leave
        Lbl_id_cargo.Text = ""
        Txb_nombre_cargo.Clear()
        Txb_nombre_cargo.Enabled = False
        Btn_guardar_cargo.Enabled = False
        Btn_mod_cargo.Enabled = False
        Btn_eliminar_cargo.Enabled = False
    End Sub

    'Acciones de Usuarios
    Public Sub Cargar_cargos()
        Sql = "SELECT * FROM domicilio.sicad_cargos"

        Cmd = New NpgsqlCommand(Sql, Mycon)
        Dr = Cmd.ExecuteReader

        Dim Dt As New Data.DataTable
        Dt.Load(Dr)

        Cbx_cargo.ValueMember = "idcargo"
        Cbx_cargo.DisplayMember = "cargo"
        Cbx_cargo.DataSource = Dt

        Dr.Close()
    End Sub
    Public Sub Cargar_roles()
        Sql = "SELECT * FROM domicilio.sicad_roles"

        Cmd = New NpgsqlCommand(Sql, Mycon)
        Dr = Cmd.ExecuteReader

        Dim Dt As New Data.DataTable
        Dt.Load(Dr)

        Cbx_roles.DataSource = Dt
        Cbx_roles.ValueMember = "id_rol"
        Cbx_roles.DisplayMember = "rol"


        Dr.Close()
    End Sub

    Private Sub Btn_nuevo_usuario_Click(sender As Object, e As EventArgs) Handles Btn_nuevo_usuario.Click
        Lbl_id_usuario.Text = ""
        Txb_usuario.Clear()
        Txb_pass1.Clear()
        Txb_pass2.Clear()
        Txb_nombre_usuario.Clear()
        Cbx_cargo.Text = ""
        Cbx_roles.Text = ""
        Cbx_activo.Text = ""
        Txb_iniciales.Clear()

        Txb_usuario.Enabled = True
        Txb_pass1.Enabled = True
        Txb_pass2.Enabled = True
        Txb_nombre_usuario.Enabled = True
        Cbx_cargo.Enabled = True
        Cbx_roles.Enabled = True
        Cbx_activo.Enabled = True
        Txb_iniciales.Enabled = True

        Cargar_cargos()
        Cargar_roles()

        Btn_guardar_usuario.Enabled = True
        Btn_mod_usuario.Enabled = False


    End Sub
    Private Sub Btn_guardar_usuario_Click(sender As Object, e As EventArgs) Handles Btn_guardar_usuario.Click
        Verificar_usuario()
        'convertir contraseña para guardar
    End Sub
    Public Sub Verificar_usuario()
        Dim contar_usuario As Integer
        Sql = "SELECT COUNT(*) FROM domicilio.sicad_usuarios WHERE usuario = '" & Txb_usuario.Text & "'"
        Cmd = New NpgsqlCommand(Sql, Mycon)
        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()
            contar_usuario = Dr.GetValue(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error de Busqueda", vbCritical, "Busqueda 1")

        End Try
        Dr.Close()
        Cmd.Dispose()
        If contar_usuario = 1 Then
            MsgBox("Ya existe el Usuario ")
        Else
            Verificar_nombre()
        End If

    End Sub
    Public Sub Verificar_nombre()
        Dim contar_nombre As Integer
        Sql = "SELECT COUNT(*) FROM domicilio.sicad_usuarios WHERE nombrecompleto = '" & Txb_nombre_usuario.Text & "'"
        Cmd = New NpgsqlCommand(Sql, Mycon)
        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()
            contar_nombre = Dr.GetValue(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error de Busqueda", vbCritical, "Busqueda 1")

        End Try
        Dr.Close()
        Cmd.Dispose()
        If contar_nombre = 1 Then
            MsgBox("Ya existe el Nombre, verifique si puede activar de nuevo al Usuario ")
        Else
            Verificar_password()
        End If
    End Sub
    Public Sub Verificar_password()
        If Txb_pass1.Text = Txb_pass2.Text Then
            guardar_usuario()
        Else
            MsgBox("Las contraseñas no son iguales")
            Txb_pass1.Clear()
            Txb_pass2.Clear()
            Txb_pass1.Focus()
        End If
    End Sub
    Public Sub guardar_usuario()
        If Txb_usuario.Text = "" Or Txb_pass2.Text = "" Or Txb_nombre_usuario.Text = "" Or Cbx_cargo.Text = "" Or Cbx_roles.Text = "" Or Txb_iniciales.Text = "" Or Cbx_activo.Text = "" Then
            MsgBox("No se Puede Agregar Campo Vacio")
            Txb_nombre_cargo.Focus()
        Else
            Sql = "INSERT INTO domicilio.sicad_usuarios
                    (usuario,password,idrol,nombrecompleto,idcargo,iniciales,activo,createat,updateat)
                VALUES 
                    (@usuario,@password,@idrol,@nombrecompleto,@idcargo,@iniciales,@activo,@createat,@updateat)"

            Cmd = New NpgsqlCommand(Sql, Mycon)
            Cmd.Parameters.AddWithValue("@usuario", Txb_usuario.Text)
            Dim Usu_pas As String = Eramake.eCryptography.Encrypt(Txb_pass2.Text)
            Cmd.Parameters.AddWithValue("@password", Usu_pas)
            Cmd.Parameters.AddWithValue("@idrol", Cbx_roles.SelectedValue)
            Cmd.Parameters.AddWithValue("@nombrecompleto", Txb_nombre_usuario.Text)
            Cmd.Parameters.AddWithValue("@idcargo", Cbx_cargo.SelectedValue)
            Cmd.Parameters.AddWithValue("@iniciales", Txb_iniciales.Text)

            Dim activo As Integer
            If Cbx_activo.Text = "SI" Then
                activo = 1
            Else
                activo = 0
            End If
            Cmd.Parameters.AddWithValue("@activo", activo) 'revisaractivo = 0
            Cmd.Parameters.AddWithValue("@createat", Now) 'formato fecha y hora
            Cmd.Parameters.AddWithValue("@updateat", Now) 'formato fecha y hora

            Try
                Cmd.ExecuteNonQuery()
                MsgBox("Usuario Agregado", vbInformation, "Mensaje del Sistema")
                Lbl_id_usuario.Text = ""
                Txb_usuario.Clear()
                Txb_pass1.Clear()
                Txb_pass2.Clear()
                Txb_nombre_usuario.Clear()
                Cbx_cargo.Text = ""
                Cbx_roles.Text = ""
                Cbx_activo.Text = ""
                Txb_iniciales.Clear()

                Txb_usuario.Enabled = False
                Txb_pass1.Enabled = False
                Txb_pass2.Enabled = False
                Txb_nombre_usuario.Enabled = False
                Cbx_cargo.Enabled = False
                Cbx_roles.Enabled = False
                Cbx_activo.Enabled = False
                Txb_iniciales.Enabled = False

                Btn_guardar_usuario.Enabled = False
                Btn_mod_usuario.Enabled = False

                Llenagrid_usuarios()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub Dgv_usuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_usuarios.CellClick
        Cargar_cargos()
        Cargar_roles()
        Dim i As Integer
        Try
            i = Dgv_usuarios.CurrentRow.Index
            Lbl_id_usuario.Text = Dgv_usuarios.Item(0, i).Value()
            Txb_usuario.Text = Dgv_usuarios.Item(1, i).Value()
            Txb_pass1.Text = Eramake.eCryptography.Decrypt(Dgv_usuarios.Item(2, i).Value())
            Txb_nombre_usuario.Text = Dgv_usuarios.Item(4, i).Value()
            Cbx_cargo.Text = Dgv_usuarios.Item(5, i).Value()
            Cbx_roles.Text = Dgv_usuarios.Item(3, i).Value()
            Txb_iniciales.Text = Dgv_usuarios.Item(6, i).Value()

            ' Dim activo As String
            If Dgv_usuarios.Item(7, i).Value() = 1 Then
                Cbx_activo.Text = "SI"
            Else
                Cbx_activo.Text = "NO"
            End If

            Txb_usuario.Enabled = False
            Btn_guardar_usuario.Enabled = False


            Txb_pass1.Enabled = True
            Txb_pass2.Enabled = True
            Txb_nombre_usuario.Enabled = True
            Cbx_cargo.Enabled = True
            Cbx_roles.Enabled = True
            Cbx_activo.Enabled = True
            Txb_iniciales.Enabled = True
            Btn_mod_usuario.Enabled = True


        Catch ex As Exception

        End Try
    End Sub
    Private Sub Btn_mod_usuario_Click(sender As Object, e As EventArgs) Handles Btn_mod_usuario.Click

        If Txb_usuario.Text = "" Or Txb_pass2.Text = "" Or Txb_nombre_usuario.Text = "" Or Cbx_cargo.Text = "" Or Cbx_roles.Text = "" Or Txb_iniciales.Text = "" Or Cbx_activo.Text = "" Then
            MsgBox("No se Puede Agregar Campo Vacio")
            Txb_nombre_cargo.Focus()
        Else
            If Txb_pass1.Text = Txb_pass2.Text Then
                Sql = "UPDATE domicilio.sicad_usuarios SET 
                    password = @password, 
                    idrol = @idrol, 
                    nombrecompleto = @nombrecompleto, 
                    idcargo = @idcargo, 
                    iniciales = @iniciales, 
                    activo = @activo 
              WHERE idusuario = " & Lbl_id_usuario.Text

                Cmd = New NpgsqlCommand(Sql, Mycon)

                Dim Usu_pas As String = Eramake.eCryptography.Encrypt(Txb_pass2.Text)
                Cmd.Parameters.AddWithValue("@password", Usu_pas)
                Cmd.Parameters.AddWithValue("@idrol", Cbx_roles.SelectedValue)
                Cmd.Parameters.AddWithValue("@nombrecompleto", Txb_nombre_usuario.Text)
                Cmd.Parameters.AddWithValue("@idcargo", Cbx_cargo.SelectedValue)
                Cmd.Parameters.AddWithValue("@iniciales", Txb_iniciales.Text)

                Dim activo As Integer
                If Cbx_activo.Text = "SI" Then
                    activo = 1
                Else
                    activo = 0
                End If 'cambia el valor de la BD por si o no
                Cmd.Parameters.AddWithValue("@activo", activo)
                Cmd.Parameters.AddWithValue("@updateat", Now) 'formato fecha y hora


                Try
                    Cmd.ExecuteNonQuery()
                    MsgBox("Usuario Actualizado", vbInformation, "Mensaje del Sistema")
                    Lbl_id_usuario.Text = ""
                    Txb_usuario.Clear()
                    Txb_pass1.Clear()
                    Txb_pass1.Enabled = False
                    Txb_pass2.Enabled = False
                    Txb_pass2.Clear()
                    Txb_nombre_usuario.Clear()
                    Txb_nombre_usuario.Enabled = False
                    Cbx_cargo.Enabled = False
                    Cbx_roles.Enabled = False
                    Txb_iniciales.Clear()
                    Txb_iniciales.Enabled = False
                    Cbx_activo.Enabled = False
                    Btn_mod_usuario.Enabled = False
                    Llenagrid_usuarios()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Las contraseñas no son iguales")
                Txb_pass1.Clear()
                Txb_pass2.Clear()
                Txb_pass1.Focus()
            End If 'verifica que las contraseñas sean iguales

        End If

    End Sub
    Private Sub TabUsuarios_Leave(sender As Object, e As EventArgs) Handles TabUsuarios.Leave
        Lbl_id_usuario.Text = ""
        Txb_usuario.Clear()
        Txb_pass1.Clear()
        Txb_pass2.Clear()
        Txb_nombre_usuario.Clear()
        Cbx_cargo.Text = ""
        Cbx_roles.Text = ""
        Cbx_activo.Text = ""
        Txb_iniciales.Clear()

        Txb_usuario.Enabled = False
        Txb_pass1.Enabled = False
        Txb_pass2.Enabled = False
        Txb_nombre_usuario.Enabled = False
        Cbx_cargo.Enabled = False
        Cbx_roles.Enabled = False
        Cbx_activo.Enabled = False
        Txb_iniciales.Enabled = False
        Btn_guardar_usuario.Enabled = False
        Btn_mod_usuario.Enabled = False

    End Sub

    'acciones de permisos
    'Recuerda agregar los permisos nuevos cada que se crea un nuevo formulario
    Public Sub Cargar_roles_permisos()
        Sql = "SELECT * FROM domicilio.sicad_roles ORDER BY id_rol ASC"

        Cmd = New NpgsqlCommand(Sql, Mycon)
        Dr = Cmd.ExecuteReader

        Dim Dt As New Data.DataTable
        Dt.Load(Dr)


        Cbx_rol_permiso.ValueMember = "id_rol"
        Cbx_rol_permiso.DisplayMember = "rol"
        Cbx_rol_permiso.DataSource = Dt
        Dr.Close()

    End Sub
    Private Sub Cbx_rol_permiso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_rol_permiso.SelectedIndexChanged

        Sql = "SELECT * FROM domicilio.sicad_permisos WHERE idrol = " & Cbx_rol_permiso.SelectedValue
        Cmd = New NpgsqlCommand(Sql, Mycon)
        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()

            Chb_1.Checked = Dr.GetValue(2)
            Chb_2.Checked = Dr.GetValue(3)
            Chb_3.Checked = Dr.GetValue(4)
            Chb_4.Checked = Dr.GetValue(5)
            Chb_5.Checked = Dr.GetValue(6)
            Chb_6.Checked = Dr.GetValue(7)
            Chb_7.Checked = Dr.GetValue(8)
            Chb_8.Checked = Dr.GetValue(9)
            Chb_9.Checked = Dr.GetValue(10)
            Chb_10.Checked = Dr.GetValue(11)
            Chb_11.Checked = Dr.GetValue(12)
            Chb_12.Checked = Dr.GetValue(13)

        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error de Busqueda", vbCritical, "Busqueda 1")

        End Try
        Dr.Close()
        Cmd.Dispose()
    End Sub
    Public Sub Validar_permisos() 'no funciona asi 

        Dim chk As New CheckBox()
        Try
            Sql = "SELECT * FROM domicilio.sicad_permisos WHERE idrol = " & Cbx_rol_permiso.SelectedValue
            Cmd = New NpgsqlCommand(Sql, Mycon)
            Try
                Dr = Cmd.ExecuteReader
                Dr.Read()
                Dim j As Integer = 2
                For i = 1 To 12
                    chk.Name = ("Chb_" & i)
                    chk.Checked = Dr.GetValue(j)
                    j = j + 1
                Next
                'Chb_1.Checked = Dr.GetValue(2)
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox("Error de Busqueda", vbCritical, "Busqueda 1")

            End Try
            Dr.Close()
            Cmd.Dispose()
        Catch ex As Exception

        End Try
    End Sub 'no funciona 
    Public Sub Limpiar_chk()
        Chb_1.Checked = False
        Chb_2.Checked = False
        Chb_3.Checked = False
        Chb_4.Checked = False
        Chb_5.Checked = False
        Chb_6.Checked = False
        Chb_7.Checked = False
        Chb_8.Checked = False
        Chb_9.Checked = False
        Chb_10.Checked = False
        Chb_11.Checked = False
        Chb_12.Checked = False
    End Sub
    Private Sub TabPermisos_Leave(sender As Object, e As EventArgs) Handles TabPermisos.Leave
        Limpiar_chk()
    End Sub
    Private Sub Btn_todos_chk_Click(sender As Object, e As EventArgs) Handles Btn_todos_chk.Click
        Chb_1.Checked = True
        Chb_2.Checked = True
        Chb_3.Checked = True
        Chb_4.Checked = True
        Chb_5.Checked = True
        Chb_6.Checked = True
        Chb_7.Checked = True
        Chb_8.Checked = True
        Chb_9.Checked = True
        Chb_10.Checked = True
        Chb_11.Checked = True
        Chb_12.Checked = True
    End Sub
    Private Sub Btn_limpiar_chk_Click(sender As Object, e As EventArgs) Handles Btn_limpiar_chk.Click
        Limpiar_chk()
    End Sub
    Private Sub Btn_guardar_permisos_Click(sender As Object, e As EventArgs) Handles Btn_guardar_permisos.Click
        Sql = "Update domicilio.sicad_permisos SET 
                 p1 = '" & Chb_1.Checked & "', 
                 p2 = '" & Chb_2.Checked & "', 
                 p3 = '" & Chb_3.Checked & "', 
                 p4 = '" & Chb_4.Checked & "',  
                 p5 = '" & Chb_5.Checked & "', 
                 p6 = '" & Chb_6.Checked & "', 
                 p7 = '" & Chb_7.Checked & "', 
                 p8 = '" & Chb_8.Checked & "', 
                 p9 = '" & Chb_9.Checked & "', 
                 p10 = '" & Chb_10.Checked & "',  
                 p11 = '" & Chb_11.Checked & "', 
                 p12 = '" & Chb_12.Checked & "' 
            WHERE idrol = " & Cbx_rol_permiso.SelectedValue
        MsgBox(Sql)
        Cmd = New NpgsqlCommand(Sql, Mycon)

        'Cmd.Parameters.AddWithValue("@activo", activo)
        'Cmd.Parameters.AddWithValue("@updateat", Now) 'formato fecha y hora


        Try
            Cmd.ExecuteNonQuery()
            MsgBox("Permisos de Usuario Actualizado", vbInformation, "Mensaje del Sistema")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class