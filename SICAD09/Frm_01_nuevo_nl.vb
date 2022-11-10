
Imports System.IO
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Imports System.Data.OleDb
Imports Npgsql

Public Class Frm_01_nuevo_nl
    Public Var_causa_baja As String
    Public Conteo As Integer
    'BOTONES
    Private Sub CERRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click
        Guardar()
    End Sub
    Private Sub Btn_agregar_creditos_Click(sender As Object, e As EventArgs) Handles Btn_agregar_creditos.Click
        Creditos_incio()
    End Sub
    Private Sub Btn_clean_Click(sender As Object, e As EventArgs) Handles Btn_clean.Click
        Limpiar()
    End Sub
    Private Sub Txb_reg_pat_KeyDown(sender As Object, e As KeyEventArgs) Handles Txb_reg_pat.KeyDown
        If e.KeyData = Keys.Enter Then
            If Txb_dig_rp.Enabled = False Then
                Buscar_patron()
            Else
                Buscar_dv()
            End If

            Buscar_rp()
        End If
    End Sub
    Private Sub Btn_modificar_Click(sender As Object, e As EventArgs) Handles Btn_modificar.Click
        Modificar()
    End Sub

    Private Sub Btn_actualizar_Click(sender As Object, e As EventArgs) Handles Btn_actualizar.Click
        Actualizar_info()
    End Sub
    'ACCIONES
    Public Sub Buscar_patron()

        Sql = "SELECT * FROM patrones WHERE emip_patron = '" & Txb_reg_pat.Text & "'"
        'MsgBox(Sql)

        Cmd = New NpgsqlCommand(Sql, Mycon)

        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()

            Txb_raz_soc.Text = Dr.GetValue(5)
            Txb_curp.Text = Dr.GetValue(22)
            Txb_rfc.Text = Dr.GetValue(22)
            Txb_actividad.Text = Dr.GetValue(25)
            Txb_domicilio.Text = Dr.GetValue(23)
            Txb_localidad.Text = Dr.GetValue(24)
            Txb_cp.Text = Dr.GetValue(35)
            Txb_n_del.Text = Dr.GetValue(0)
            Txb_n_sub.Text = Dr.GetValue(1)

            Dr.Close()
            Activar()
        Catch ex As Exception
            Dr.Close()

            MsgBox("Patron no encontrado, intente Buscando con el Digito Verificador")
            Txb_dig_rp.Enabled = True

            'MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub Buscar_dv()
        Sql = "SELECT * FROM patrones WHERE emip_patron = '" & Txb_reg_pat.Text & Txb_dig_rp.Text & "'"
        'MsgBox(Sql)

        Cmd = New NpgsqlCommand(Sql, Mycon)

        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()

            Txb_raz_soc.Text = Dr.GetValue(5)
            Txb_curp.Text = Dr.GetValue(22)
            Txb_rfc.Text = Dr.GetValue(22)
            Txb_actividad.Text = Dr.GetValue(25)
            Txb_domicilio.Text = Dr.GetValue(23)
            Txb_localidad.Text = Dr.GetValue(24)
            Txb_cp.Text = Dr.GetValue(35)
            Txb_n_del.Text = Dr.GetValue(0)
            Txb_n_sub.Text = Dr.GetValue(1)

            Dr.Close()
            Activar()
        Catch ex As Exception
            Dr.Close()

            MsgBox("Patron no encontrado, Agregue los datos del Patron")
            Activar()
            'MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub Buscar_delegacion()
        Dr.Close()
        Sql2 = "SELECT * FROM domicilio.oficinas_subdelegacionales WHERE no_delegacion = " & Txb_n_del.Text & "AND no_subdelegacion = " & Txb_n_sub.Text
        'MsgBox(Sql)

        Cmd1 = New NpgsqlCommand(Sql2, Mycon)

        Try
            Dr = Cmd1.ExecuteReader
            Dr.Read()

            Txb_del.Text = Dr.GetValue(6) 'DELEGACION
            Txb_sub.Text = Dr.GetValue(7) 'SUBDELEGACION

            Dr.Close()

        Catch ex As Exception

            Dr.Close()
            'MsgBox(ex.ToString)
        End Try


    End Sub
    Private Sub Txb_n_sub_TextChanged(sender As Object, e As EventArgs) Handles Txb_n_sub.TextChanged
        Try
            Buscar_delegacion()
        Catch ex As Exception
            Txb_del.Clear()
            Txb_sub.Clear()
        End Try
    End Sub
    Public Sub Buscar_rp()
        Dr.Close()
        Sql1 = "SELECT detrales, patron, mov, fecha_mov, sect, credito, periodo, td, fecha_alta, incidencia, fecha_incid, dias_, importe 
                FROM domicilio.vw_ultimo_rale WHERE patron ='" & Txb_reg_pat.Text & "'"
        'MsgBox(Sql)
        Llenagrid_creditos(Sql1)

        Cmd = New NpgsqlCommand(Sql1, Mycon)

        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()

            Txb_sector.Text = Dr.GetValue(4)
            Txb_mov.Text = Dr.GetValue(2)
            Dtp_mov.Value = Format(Dr.GetValue(3), "short Date")

            Dr.Close()

        Catch ex As Exception

            Dr.Close()
            'MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub Llenagrid_creditos(Sql)

        'Sql esta definida de manera global en el archivo de conexion

        Adp = New NpgsqlDataAdapter(Sql, Mycon)
        Ds.Tables.Clear()
        Adp.Fill(Ds.Tables.Add("Tabla"))

        'NOMBRE DE COLUMNAS
        Me.Dgv_creditos_patron.DataSource = Ds.Tables("Tabla")
        Me.Dgv_creditos_patron.Columns(1).Name = "ID"
        Me.Dgv_creditos_patron.Columns(2).Name = "REGISTRO PATRONAL"
        Me.Dgv_creditos_patron.Columns(3).Name = "MOV"
        Me.Dgv_creditos_patron.Columns(4).Name = "FECHA DE MOVIMIENTO"
        Me.Dgv_creditos_patron.Columns(5).Name = "SECTOR"
        Me.Dgv_creditos_patron.Columns(6).Name = "CREDITO"
        Me.Dgv_creditos_patron.Columns(7).Name = "PERIODO"
        Me.Dgv_creditos_patron.Columns(8).Name = "TD"
        Me.Dgv_creditos_patron.Columns(9).Name = "FECHA DE ALTA"
        Me.Dgv_creditos_patron.Columns(10).Name = "INC"
        Me.Dgv_creditos_patron.Columns(11).Name = "FECHA DE INC"
        Me.Dgv_creditos_patron.Columns(12).Name = "DIAS"
        Me.Dgv_creditos_patron.Columns(13).Name = "IMPORTE"

        'ENCABEZADOS
        Me.Dgv_creditos_patron.Columns("ID").HeaderText = "ID"
        Me.Dgv_creditos_patron.Columns("REGISTRO PATRONAL").HeaderText = "REGISTRO PATRONAL"
        Me.Dgv_creditos_patron.Columns("MOV").HeaderText = "MOV"
        Me.Dgv_creditos_patron.Columns("FECHA DE MOVIMIENTO").HeaderText = "FECHA DE MOVIMIENTO"
        Me.Dgv_creditos_patron.Columns("SECTOR").HeaderText = "SECTOR"
        Me.Dgv_creditos_patron.Columns("CREDITO").HeaderText = "CREDITO"
        Me.Dgv_creditos_patron.Columns("PERIODO").HeaderText = "PERIODO"
        Me.Dgv_creditos_patron.Columns("TD").HeaderText = "TD"
        Me.Dgv_creditos_patron.Columns("FECHA DE ALTA").HeaderText = "FECHA DE ALTA"
        Me.Dgv_creditos_patron.Columns("INC").HeaderText = "INC"
        Me.Dgv_creditos_patron.Columns("FECHA DE INC").HeaderText = "FECHA DE INC"
        Me.Dgv_creditos_patron.Columns("DIAS").HeaderText = "DIAS"
        Me.Dgv_creditos_patron.Columns("IMPORTE").HeaderText = "IMPORTE"


        'ORDEN
        Me.Dgv_creditos_patron.Columns("ID").DisplayIndex = 1
        Me.Dgv_creditos_patron.Columns("REGISTRO PATRONAL").DisplayIndex = 2
        Me.Dgv_creditos_patron.Columns("CREDITO").DisplayIndex = 3
        Me.Dgv_creditos_patron.Columns("PERIODO").DisplayIndex = 4
        Me.Dgv_creditos_patron.Columns("TD").DisplayIndex = 5
        Me.Dgv_creditos_patron.Columns("IMPORTE").DisplayIndex = 6
        Me.Dgv_creditos_patron.Columns("INC").DisplayIndex = 7
        Me.Dgv_creditos_patron.Columns("FECHA DE INC").DisplayIndex = 8
        Me.Dgv_creditos_patron.Columns("DIAS").DisplayIndex = 9

        Me.Dgv_creditos_patron.Columns("FECHA DE ALTA").DisplayIndex = 10
        Me.Dgv_creditos_patron.Columns("MOV").DisplayIndex = 11
        Me.Dgv_creditos_patron.Columns("FECHA DE MOVIMIENTO").DisplayIndex = 12
        Me.Dgv_creditos_patron.Columns("SECTOR").DisplayIndex = 13




        'PROPIEDADES
        Me.Dgv_creditos_patron.Columns("ID").Visible = False

        Me.Dgv_creditos_patron.Columns("MOV").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.Dgv_creditos_patron.Columns("SECTOR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.Dgv_creditos_patron.Columns("CREDITO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.Dgv_creditos_patron.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.Dgv_creditos_patron.Columns("IMPORTE").DefaultCellStyle.Format = "C2"


        Adp.Dispose()
        Sumar_importe()
    End Sub
    Public Sub Sumar_importe()
        Try
            Dim Total As Single
            Dim Col As Integer = Dgv_creditos_patron.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Dgv_creditos_patron.Rows
                Total += Val(row.Cells("IMPORTE").Value)
            Next
            Txb_importe_total.Text = Format(Total, "C2")
            Calcular_rango()
        Catch ex As Exception

        End Try


    End Sub

    Public Sub Calcular_rango()
        Lbl_rango.Text = Evaluar_rango(Dtp_registro.Value.Year, CDbl(Txb_importe_total.Text))
    End Sub

    Public Sub Creditos_incio()
        Conteo = 0
        Txb_cop_inicio.Text = ""
        Txb_rcv_inicio.Text = ""
        Dim credito As String = ""
        Dim td As String = ""

        For Each dgvfilas As DataGridViewRow In Dgv_creditos_patron.Rows

            If Convert.ToBoolean(dgvfilas.Cells("Seleccionar").Value) = True Then

                td = RTrim(dgvfilas.Cells("TD").Value)
                If td = "06" Then
                    Txb_rcv_inicio.Text = Txb_rcv_inicio.Text + dgvfilas.Cells("CREDITO").Value & " BIM " & dgvfilas.Cells("PERIODO").Value & ", "
                Else
                    Txb_cop_inicio.Text = Txb_cop_inicio.Text + dgvfilas.Cells("CREDITO").Value & " PER " & dgvfilas.Cells("PERIODO").Value & ", "
                End If
                Conteo = Conteo + 1
            End If
        Next

        If Conteo = 0 Then
            MsgBox("No has seleccionado Creditos")
        Else
            Btn_save.Enabled = True
        End If

    End Sub

    Public Sub Guardar()

        'Sql = "WITH rows as (
        '        INSERT INTO domicilio.sicad_patronesnl
        '            (regpat, digver, razsoc, curp, rfc, activi, domici, locali, cp, del, sub, secnot, tipmovimiento, fecmov, causabaja, createat, updateat, idusuario, fecconsulta)
        '        VALUES 
        '            (@regpat, @digver, @razsoc, @curp, @rfc, @activi, @domici, @locali, @cp, @del, @sub, @secnot, @tipmovimiento, @fecmov, @causabaja, @create, @update, @idusuario, @fecconsulta)
        '        RETURNING idpatronnl
        '        )
        '        INSERT INTO domicilio.sicad_documentosnl(idpatronnl,regpat,digver)
        '        SELECT idpatronnl,@regpat, @digver
        '        FROM rows"
        'MsgBox(Sql)

        Sql = "WITH rows as (
                INSERT INTO domicilio.sicad_patronesnl
                    (regpat, digver, razsoc, curp, rfc, activi, domici, locali, cp, del, sub, secnot, createat, updateat, idusuario, fecharegistro,oficinaorigen,memorandum,docbaja,fechaactacirc,fecharecibacta,copinicio,rcvinicio)
                VALUES 
                    (@regpat, @digver, @razsoc, @curp, @rfc, @activi, @domici, @locali, @cp, @del, @sub, @secnot, @create, @update, @idusuario, @fecharegistro,@oficinaorigen,@memorandum,@docbaja,@fechaactacirc,@fecharecibacta,@creditoscop,@creditosrcv)
                RETURNING idpatronnl
                ),
                rows2 AS(
                    INSERT INTO domicilio.sicad_asig_ver_dom(idpatronnl)
                    SELECT idpatronnl
                    FROM rows
                    RETURNING idpatronnl
                )
                INSERT INTO domicilio.sicad_asig_ver_int(idpatronnl)
                    SELECT idpatronnl
                    FROM rows2"


        'MsgBox(Dtp_mov.Value) 'formato fecha y hora
        Cmd = New NpgsqlCommand(Sql, Mycon)
        Cmd.Parameters.AddWithValue("@regpat", Txb_reg_pat.Text)
        Cmd.Parameters.AddWithValue("@digver", Txb_dig_rp.Text)
        Cmd.Parameters.AddWithValue("@razsoc", Txb_raz_soc.Text)
        Cmd.Parameters.AddWithValue("@curp", Txb_curp.Text)
        Cmd.Parameters.AddWithValue("@rfc", Txb_rfc.Text)
        Cmd.Parameters.AddWithValue("@activi", Txb_actividad.Text)
        Cmd.Parameters.AddWithValue("@domici", Txb_domicilio.Text)
        Cmd.Parameters.AddWithValue("@locali", Txb_localidad.Text)
        Cmd.Parameters.AddWithValue("@cp", Txb_cp.Text)
        Cmd.Parameters.AddWithValue("@del", Txb_n_del.Text)
        Cmd.Parameters.AddWithValue("@sub", Txb_n_sub.Text)
        Cmd.Parameters.AddWithValue("@secnot", Txb_sector.Text)
        Cmd.Parameters.AddWithValue("@create", Now) 'formato fecha y hora
        Cmd.Parameters.AddWithValue("@update", Now) 'formato fecha y hora
        Cmd.Parameters.AddWithValue("@idusuario", 1) 'id del usuario que este dentro del sistema
        Cmd.Parameters.AddWithValue("@fecharegistro", Dtp_registro.Value)

        Cmd.Parameters.AddWithValue("@oficinaorigen", Cbx_ofi_origen.Text)
        Cmd.Parameters.AddWithValue("@memorandum", Txb_memo.Text)
        Cmd.Parameters.AddWithValue("@docbaja", Txb_doc_baja.Text)
        Cmd.Parameters.AddWithValue("@fechaactacirc", Dtp_acta_circ.Value)
        Cmd.Parameters.AddWithValue("@fecharecibacta", Dtp_recibido.Value)
        Cmd.Parameters.AddWithValue("@creditoscop", Txb_cop_inicio.Text)
        Cmd.Parameters.AddWithValue("@creditosrcv", Txb_rcv_inicio.Text)

        Try
            Cmd.ExecuteNonQuery()
            MsgBox("Solicitud de Patron No localizado Agregado", vbInformation, "Mensaje del Sistema")

            Dim resp As MsgBoxResult = MsgBox("Agregar Nueva Solicitud", MsgBoxStyle.YesNo)

            If resp = MsgBoxResult.No Then
                'pasar a la captura del localizador
                Me.Close()
                SICAD09.openChildForm(New Frm_02_documentos)
                Limpiar()
            End If
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub Activar()
        Txb_dig_rp.Enabled = True
        Txb_raz_soc.Enabled = True
        Txb_curp.Enabled = True
        Txb_rfc.Enabled = True
        Txb_actividad.Enabled = True
        Txb_domicilio.Enabled = True
        Txb_localidad.Enabled = True
        Txb_cp.Enabled = True
        Txb_n_del.Enabled = True
        Txb_n_sub.Enabled = True
        Txb_sector.Enabled = True
        Txb_mov.Enabled = True
        Dtp_mov.Enabled = True

        Cbx_ofi_origen.Enabled = True
        Txb_memo.Enabled = True
        Txb_doc_baja.Enabled = True
        Dtp_acta_circ.Enabled = True
        Dtp_recibido.Enabled = True
        Txb_cop_inicio.Enabled = True
        Txb_rcv_inicio.Enabled = True

        'Btn_save.Enabled = True
        Btn_agregar_creditos.Enabled = True
        Btn_clean.Enabled = True
    End Sub
    Public Sub Limpiar()
        Dtp_registro.Value = Today
        Txb_reg_pat.Clear()
        Txb_dig_rp.Clear()
        Txb_raz_soc.Clear()
        Txb_curp.Clear()
        Txb_rfc.Clear()
        Txb_actividad.Clear()
        Txb_domicilio.Clear()
        Txb_localidad.Clear()
        Txb_cp.Clear()
        Txb_n_del.Clear()
        Txb_n_sub.Clear()
        Txb_sector.Clear()
        Txb_mov.Clear()
        Dtp_mov.Value = Today
        Cbx_ofi_origen.Text = ""
        Txb_memo.Clear()
        Txb_doc_baja.Clear()
        Dtp_acta_circ.Value = Today
        Dtp_recibido.Value = Today
        Txb_cop_inicio.Clear()
        Txb_rcv_inicio.Clear()

        Txb_dig_rp.Enabled = False
        Txb_raz_soc.Enabled = False
        Txb_curp.Enabled = False
        Txb_rfc.Enabled = False
        Txb_actividad.Enabled = False
        Txb_domicilio.Enabled = False
        Txb_localidad.Enabled = False
        Txb_cp.Enabled = False
        Txb_n_del.Enabled = False
        Txb_n_sub.Enabled = False
        Txb_sector.Enabled = False
        Txb_mov.Enabled = False
        Dtp_mov.Enabled = False

        Cbx_ofi_origen.Enabled = False
        Txb_memo.Enabled = False
        Txb_doc_baja.Enabled = False
        Dtp_acta_circ.Enabled = False
        Dtp_recibido.Enabled = False
        Txb_cop_inicio.Enabled = False
        Txb_rcv_inicio.Enabled = False



        Btn_agregar_creditos.Enabled = False
        Btn_save.Enabled = False
        'Btn_SINDO.Enabled = False
        Btn_clean.Enabled = False

    End Sub
    Public Sub Modificar()
        Dim i As Integer
        Try
            i = Dgv_patronesnl.CurrentRow.Index
            Lbl_idpatronnl.Text = Dgv_patronesnl.Item(0, i).Value()
            Me.TabControl2.SelectedIndex = 0

        Catch ex As Exception

        End Try


        Sql = "SELECT * FROM domicilio.sicad_patronesnl WHERE idpatronnl= " & Lbl_idpatronnl.Text
        'MsgBox(Sql)

        Cmd = New NpgsqlCommand(Sql, Mycon)

        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()

            Dtp_registro.Value = Dr.GetValue(16)
            Txb_reg_pat.Text = Dr.GetValue(1)
            Txb_dig_rp.Text = Dr.GetValue(2)
            Txb_raz_soc.Text = Dr.GetValue(3)
            Txb_curp.Text = Dr.GetValue(4)
            Txb_rfc.Text = Dr.GetValue(5)
            Txb_actividad.Text = Dr.GetValue(6)
            Txb_domicilio.Text = Dr.GetValue(7)
            Txb_localidad.Text = Dr.GetValue(8)
            Txb_cp.Text = Dr.GetValue(9)
            Cbx_ofi_origen.Text = Dr.GetValue(17)
            Txb_memo.Text = Dr.GetValue(18)
            Txb_doc_baja.Text = Dr.GetValue(19)
            Dtp_acta_circ.Value = Dr.GetValue(20)
            Dtp_recibido.Value = Dr.GetValue(21)
            Txb_cop_inicio.Text = Dr.GetValue(22)
            Txb_rcv_inicio.Text = Dr.GetValue(23)

            Txb_n_del.Text = Dr.GetValue(10)
            Txb_n_sub.Text = Dr.GetValue(11)


            Dr.Close()
            Activar()
            Buscar_rp()
            Dtp_recibido.Enabled = False
            Txb_reg_pat.Enabled = False
            Btn_actualizar.Visible = True
            Btn_actualizar.Enabled = True
            Btn_save.Visible = False
        Catch ex As Exception
            Dr.Close()
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub Actualizar_info()


        Sql = "UPDATE domicilio.sicad_patronesnl SET 
                    digver = '" & Txb_dig_rp.Text & "', 
                    razsoc = '" & Txb_raz_soc.Text & "', 
                    curp = '" & Txb_curp.Text & "', 
                    rfc = '" & Txb_rfc.Text & "', 
                    activi = '" & Txb_actividad.Text & "', 
                    domici = '" & Txb_domicilio.Text & "', 
                    locali = '" & Txb_localidad.Text & "', 
                    cp = '" & Txb_cp.Text & "', 
                    del = " & Txb_n_del.Text & ", 
                    sub = " & Txb_n_sub.Text & ", 
                    secnot = " & Txb_sector.Text & ", 
                    updateat = '" & Now & "', 
                    idusuario = 1,
                    oficinaorigen = '" & Cbx_ofi_origen.Text & "',
                    memorandum = '" & Txb_memo.Text & "',
                    docbaja= '" & Txb_doc_baja.Text & "',
                    fechaactacirc='" & Dtp_acta_circ.Value & "',
                    fecharecibacta='" & Dtp_recibido.Value & "',
                    copinicio = '" & Txb_cop_inicio.Text & "',
                    rcvinicio = '" & Txb_rcv_inicio.Text & "'
                WHERE idpatronnl = " & Lbl_idpatronnl.Text

        'MsgBox(Sql)
        Cmd = New NpgsqlCommand(Sql, Mycon)

        Try

            Cmd.ExecuteNonQuery()
            MsgBox("Registro Modificado", vbInformation, "Mensaje del Sistema")

            Limpiar()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub


    Private Sub TabLista_Enter(sender As Object, e As EventArgs) Handles TabLista.Enter
        Llenagrid_patrones()
    End Sub
    Public Sub Llenagrid_patrones()

        'Sql esta definida de manera global en el archivo de conexion
        Sql = "SELECT * FROM domicilio.sicad_patronesnl"

        Try
            Adp = New NpgsqlDataAdapter(Sql, Mycon)
            Ds.Tables.Clear()
            Adp.Fill(Ds.Tables.Add("Tabla"))

            Me.Dgv_patronesnl.DataSource = Ds.Tables("Tabla")
            'NOMBRES
            Me.Dgv_patronesnl.Columns(0).Name = "ID"
            Me.Dgv_patronesnl.Columns(1).Name = "REGISTRO PATRONAL"
            Me.Dgv_patronesnl.Columns(2).Name = "DIGITO"
            Me.Dgv_patronesnl.Columns(3).Name = "RAZON SOCIAL"
            Me.Dgv_patronesnl.Columns(4).Name = "CURP"
            Me.Dgv_patronesnl.Columns(5).Name = "RFC"
            Me.Dgv_patronesnl.Columns(6).Name = "ACTIVIDAD"
            Me.Dgv_patronesnl.Columns(7).Name = "DOMICILIO"
            Me.Dgv_patronesnl.Columns(8).Name = "LOCALIDAD"
            Me.Dgv_patronesnl.Columns(9).Name = "CP"
            Me.Dgv_patronesnl.Columns(10).Name = "DELEGACION"
            Me.Dgv_patronesnl.Columns(11).Name = "SUBDELEGACION"
            Me.Dgv_patronesnl.Columns(12).Name = "SECTOR"
            Me.Dgv_patronesnl.Columns(13).Name = "CREACION"
            Me.Dgv_patronesnl.Columns(14).Name = "ACTUALIZACION"
            Me.Dgv_patronesnl.Columns(15).Name = "ULTIMO USUARIO"
            Me.Dgv_patronesnl.Columns(16).Name = "FECHA DE SOLICITUD"
            Me.Dgv_patronesnl.Columns(17).Name = "OFICINA DE ORIGEN"
            Me.Dgv_patronesnl.Columns(18).Name = "MEMORANDUM"
            Me.Dgv_patronesnl.Columns(19).Name = "DOCUMENTO DE BAJA"
            Me.Dgv_patronesnl.Columns(20).Name = "FECHA ACTA CIRCUNSTANCIADA"
            Me.Dgv_patronesnl.Columns(21).Name = "FECHA DE RECIBIDO"
            Me.Dgv_patronesnl.Columns(22).Name = "CREDITOS COP INICIO"
            Me.Dgv_patronesnl.Columns(23).Name = "CREDITOS RCV INICIO"

            'ENCABEZADOS
            Me.Dgv_patronesnl.Columns("ID").HeaderText = "ID"
            Me.Dgv_patronesnl.Columns("REGISTRO PATRONAL").HeaderText = "REGISTRO PATRONAL"
            Me.Dgv_patronesnl.Columns("DIGITO").HeaderText = "DIGITO"
            Me.Dgv_patronesnl.Columns("RAZON SOCIAL").HeaderText = "RAZON SOCIAL"
            Me.Dgv_patronesnl.Columns("CURP").HeaderText = "CURP"
            Me.Dgv_patronesnl.Columns("RFC").HeaderText = "RFC"
            Me.Dgv_patronesnl.Columns("ACTIVIDAD").HeaderText = "ACTIVIDAD"
            Me.Dgv_patronesnl.Columns("DOMICILIO").HeaderText = "DOMICILIO"
            Me.Dgv_patronesnl.Columns("LOCALIDAD").HeaderText = "LOCALIDAD"
            Me.Dgv_patronesnl.Columns("CP").HeaderText = "CP"
            Me.Dgv_patronesnl.Columns("DELEGACION").HeaderText = "DELEGACION"
            Me.Dgv_patronesnl.Columns("SUBDELEGACION").HeaderText = "SUBDELEGACION"
            Me.Dgv_patronesnl.Columns("SECTOR").HeaderText = "SECTOR"
            Me.Dgv_patronesnl.Columns("CREACION").HeaderText = "CREACION"
            Me.Dgv_patronesnl.Columns("ACTUALIZACION").HeaderText = "ACTUALIZACION"
            Me.Dgv_patronesnl.Columns("ULTIMO USUARIO").HeaderText = "ULTIMO USUARIO"
            Me.Dgv_patronesnl.Columns("FECHA DE SOLICITUD").HeaderText = "FECHA DE SOLICITUD"
            Me.Dgv_patronesnl.Columns("OFICINA DE ORIGEN").HeaderText = "OFICINA DE ORIGEN"
            Me.Dgv_patronesnl.Columns("MEMORANDUM").HeaderText = "MEMORANDUM"
            Me.Dgv_patronesnl.Columns("DOCUMENTO DE BAJA").HeaderText = "DOCUMENTO DE BAJA"
            Me.Dgv_patronesnl.Columns("FECHA ACTA CIRCUNSTANCIADA").HeaderText = "FECHA ACTA CIRCUNSTANCIADA"
            Me.Dgv_patronesnl.Columns("FECHA DE RECIBIDO").HeaderText = "FECHA DE RECIBIDO"
            Me.Dgv_patronesnl.Columns("CREDITOS COP INICIO").HeaderText = "CREDITOS COP INICIO"
            Me.Dgv_patronesnl.Columns("CREDITOS RCV INICIO").HeaderText = "CREDITOS RCV INICIO"

            'ORDEN
            Me.Dgv_patronesnl.Columns("ID").DisplayIndex = 0
            Me.Dgv_patronesnl.Columns("FECHA DE SOLICITUD").DisplayIndex = 1
            Me.Dgv_patronesnl.Columns("REGISTRO PATRONAL").DisplayIndex = 2
            Me.Dgv_patronesnl.Columns("DIGITO").DisplayIndex = 3
            Me.Dgv_patronesnl.Columns("RAZON SOCIAL").DisplayIndex = 4
            Me.Dgv_patronesnl.Columns("CURP").DisplayIndex = 5
            Me.Dgv_patronesnl.Columns("RFC").DisplayIndex = 6
            Me.Dgv_patronesnl.Columns("ACTIVIDAD").DisplayIndex = 7
            Me.Dgv_patronesnl.Columns("DOMICILIO").DisplayIndex = 8
            Me.Dgv_patronesnl.Columns("LOCALIDAD").DisplayIndex = 9
            Me.Dgv_patronesnl.Columns("CP").DisplayIndex = 10
            Me.Dgv_patronesnl.Columns("SECTOR").DisplayIndex = 11
            Me.Dgv_patronesnl.Columns("OFICINA DE ORIGEN").DisplayIndex = 12
            Me.Dgv_patronesnl.Columns("MEMORANDUM").DisplayIndex = 13
            Me.Dgv_patronesnl.Columns("DOCUMENTO DE BAJA").DisplayIndex = 14
            Me.Dgv_patronesnl.Columns("FECHA ACTA CIRCUNSTANCIADA").DisplayIndex = 15
            Me.Dgv_patronesnl.Columns("FECHA DE RECIBIDO").DisplayIndex = 16
            Me.Dgv_patronesnl.Columns("CREDITOS COP INICIO").DisplayIndex = 17
            Me.Dgv_patronesnl.Columns("CREDITOS RCV INICIO").DisplayIndex = 18
            Me.Dgv_patronesnl.Columns("ULTIMO USUARIO").DisplayIndex = 19
            Me.Dgv_patronesnl.Columns("CREACION").DisplayIndex = 20
            Me.Dgv_patronesnl.Columns("ACTUALIZACION").DisplayIndex = 21
            Me.Dgv_patronesnl.Columns("DELEGACION").DisplayIndex = 22
            Me.Dgv_patronesnl.Columns("SUBDELEGACION").DisplayIndex = 23

            'VISIBILIDAD DE COLUMNAS
            Me.Dgv_patronesnl.Columns("ID").Visible = False
            Me.Dgv_patronesnl.Columns("CREACION").Visible = False
            Me.Dgv_patronesnl.Columns("ACTUALIZACION").Visible = False
            Me.Dgv_patronesnl.Columns("DELEGACION").Visible = False
            Me.Dgv_patronesnl.Columns("SUBDELEGACION").Visible = False

            'CONFIGURACIONES

            'Me.Dgv_patronesnl.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'Me.Dgv_patronesnl.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'Me.Dgv_patronesnl.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Adp.Dispose()
    End Sub


End Class