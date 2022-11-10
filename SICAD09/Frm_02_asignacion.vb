
Imports System.IO
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Imports System.Data.OleDb

Imports Npgsql

Public Class Frm_02_asignacion
    Public Modificacion As Integer = 0

    Private Sub Frm_02_asignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenagrid_sin_asignar()
        Cargar_NL()
        Cargar_localizadores()
    End Sub
    'CARGA DE BD
    Public Sub Cargar_NL()
        Sql = "SELECT * FROM domicilio.sicad_notif_local"

        Cmd = New NpgsqlCommand(Sql, Mycon)
        Dr = Cmd.ExecuteReader

        Dim Dt As New Data.DataTable
        Dt.Load(Dr)

        Cbx_nl.DataSource = Dt
        Cbx_nl.ValueMember = "idnotiflocal"
        Cbx_nl.DisplayMember = "nombre"

        Dr.Close()

        Cbx_nl.Text = ""
    End Sub
    Public Sub Cargar_localizadores()
        Sql = "SELECT * FROM domicilio.sicad_localizadores"

        Cmd = New NpgsqlCommand(Sql, Mycon)
        Dr = Cmd.ExecuteReader

        Dim Dt As New Data.DataTable
        Dt.Load(Dr)

        Cbx_localizadores.DataSource = Dt
        Cbx_localizadores.ValueMember = "idlocalizador"
        Cbx_localizadores.DisplayMember = "nombre"

        Dr.Close()
        Cbx_localizadores.Text = ""
    End Sub
    'BOTONES
    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click
        If Modificacion = 1 Then
            Actualizar()
        Else
            If Cbx_nl.Text <> "" And Cbx_localizadores.Text <> "" Then
                Guardar_NL()
                Guardar_Loc()
            ElseIf Cbx_nl.Text <> "" Then
                Guardar_NL()
            ElseIf Cbx_localizadores.Text <> "" Then
                Guardar_Loc()
            Else
                MsgBox("Debe asignar un NL o un Localizador para guardar")
            End If
        End If
        Llenagrid_sin_asignar()
    End Sub
    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click
        Modificacion = 1

        Cbx_nl.Enabled = True
        Dtp_asig_nl.Enabled = True
        Cbx_dias_nl.Enabled = True
        Dtp_vencimiento_nl.Enabled = True

        Cbx_localizadores.Enabled = True
        Dtp_asig_loc.Enabled = True
        Cbx_dias_loc.Enabled = True
        Dtp_vencimiento_loc.Enabled = True

        Btn_update.Visible = False
    End Sub
    Private Sub Btn_clean_Click(sender As Object, e As EventArgs) Handles Btn_clean.Click
        Limpiar()
    End Sub
    Private Sub PLANTILLASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PLANTILLASToolStripMenuItem.Click
        Generar_plantillas()
    End Sub
    Private Sub Btn_imp_con_nl_Click(sender As Object, e As EventArgs) Handles Btn_imp_con_nl.Click
        Imprimir_control_nl()
    End Sub
    Private Sub Btn_imp_con_loc_Click(sender As Object, e As EventArgs) Handles Btn_imp_con_loc.Click
        Imprimir_control_loc()
    End Sub
    Private Sub TODOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TODOSToolStripMenuItem.Click
        Llenagrid_todos()

    End Sub
    Private Sub SINASIGNACIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SINASIGNACIONToolStripMenuItem.Click
        Llenagrid_sin_asignar()

    End Sub
    Private Sub SINNLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SINNLToolStripMenuItem.Click
        Llenagrid_sin_NL()

    End Sub
    Private Sub SINLOCALIZADORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SINLOCALIZADORToolStripMenuItem.Click
        Llenagrid_sin_loc()
    End Sub
    Private Sub ASIGNADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASIGNADOSToolStripMenuItem.Click
        Llenagrid_asignados()
    End Sub
    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    'LLENAGRID
    Public Sub Llenagrid(sql)
        'Sql esta definida de manera global en el archivo de conexion
        ' Sql = "SELECT * FROM domicilio.vw_sicad_asignaciones WHERE fechaasignacionnl ISNULL AND fechaasignacionloc ISNULL"

        Try
            Adp = New NpgsqlDataAdapter(sql, Mycon)
            Ds.Tables.Clear()
            Adp.Fill(Ds.Tables.Add("Tabla"))

            Me.Dgv_patrones_asignados.DataSource = Ds.Tables("Tabla")
            Me.Dgv_patrones_asignados.Columns(0).HeaderText = "ID"
            Me.Dgv_patrones_asignados.Columns(1).HeaderText = "REGISTRO PATRONAL"
            Me.Dgv_patrones_asignados.Columns(2).HeaderText = "DIG VER"
            Me.Dgv_patrones_asignados.Columns(3).HeaderText = "RAZON SOCIAL"
            Me.Dgv_patrones_asignados.Columns(4).HeaderText = "ACTIVIDAD"
            Me.Dgv_patrones_asignados.Columns(5).HeaderText = "DOMICILIO"
            Me.Dgv_patrones_asignados.Columns(6).HeaderText = "LOCALIDAD"
            Me.Dgv_patrones_asignados.Columns(7).HeaderText = "CP"
            Me.Dgv_patrones_asignados.Columns(8).HeaderText = "ACTA CIRCUNSTANCIADA"
            Me.Dgv_patrones_asignados.Columns(9).HeaderText = "ACTA RECIBIDA"
            Me.Dgv_patrones_asignados.Columns(10).HeaderText = "ID NL"
            Me.Dgv_patrones_asignados.Columns(11).HeaderText = "NL"
            Me.Dgv_patrones_asignados.Columns(12).HeaderText = "ASIGNACION NL"
            Me.Dgv_patrones_asignados.Columns(13).HeaderText = "MAXIMA DE RESP NL"
            Me.Dgv_patrones_asignados.Columns(14).HeaderText = "FECHA DE RESPUESTA NL"
            Me.Dgv_patrones_asignados.Columns(15).HeaderText = "ID LOCALIZADOR"
            Me.Dgv_patrones_asignados.Columns(16).HeaderText = "LOCALIZADOR"
            Me.Dgv_patrones_asignados.Columns(17).HeaderText = "ASIGNACION LOCALIZADOR"
            Me.Dgv_patrones_asignados.Columns(18).HeaderText = "MAXIMA DE RESP LOC"
            Me.Dgv_patrones_asignados.Columns(19).HeaderText = "FECHA DE RESPUESTA LOC"
            Me.Dgv_patrones_asignados.Columns(20).HeaderText = "ID NL"
            'Me.Dgv_patrones_asignados.Columns(21).HeaderText = "FECHA DE RECIBIDO"
            'Me.Dgv_patrones_asignados.Columns(22).HeaderText = "FECHA LIMITE"
            'Me.Dgv_patrones_asignados.Columns(23).HeaderText = "DOCUMENTO PARA BAJA"
            'Me.Dgv_patrones_asignados.Columns(24).HeaderText = "USUARIO"

            'VISIBILIDAD DE COLUMNAS
            Me.Dgv_patrones_asignados.Columns(0).Visible = False
            Me.Dgv_patrones_asignados.Columns(10).Visible = False
            Me.Dgv_patrones_asignados.Columns(14).Visible = False
            Me.Dgv_patrones_asignados.Columns(15).Visible = False
            Me.Dgv_patrones_asignados.Columns(19).Visible = False
            Me.Dgv_patrones_asignados.Columns(20).Visible = False
            'Me.Dgv_patrones_asignados.Columns(9).Visible = False
            'Me.Dgv_patrones_asignados.Columns(10).Visible = False
            'Me.Dgv_patrones_asignados.Columns(11).Visible = False
            'Me.Dgv_patrones_asignados.Columns(12).Visible = False
            'Me.Dgv_patrones_asignados.Columns(13).Visible = False
            'Me.Dgv_patrones_asignados.Columns(14).Visible = False
            'Me.Dgv_patrones_asignados.Columns(15).Visible = False
            'Me.Dgv_patrones_asignados.Columns(16).Visible = False
            'Me.Dgv_patrones_asignados.Columns(17).Visible = False
            'Me.Dgv_patrones_asignados.Columns(18).Visible = False
            'Me.Dgv_patrones_asignados.Columns(19).Visible = False
            'Me.Dgv_patrones_asignados.Columns(20).Visible = False
            'Me.Dgv_patrones_asignados.Columns(21).Visible = False
            'Me.Dgv_patrones_asignados.Columns(22).Visible = False
            'Me.Dgv_patrones_asignados.Columns(23).Visible = False
            'Me.Dgv_patrones_asignados.Columns(24).Visible = False


            'Me.Dgv_patrones_asignados.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'Me.Dgv_patrones_asignados.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'Me.Dgv_patrones_asignados.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Adp.Dispose()
    End Sub
    Public Sub Llenagrid_sin_asignar()
        Sql = "SELECT * FROM domicilio.vw_sicad_asignaciones WHERE fechaasignacionnl ISNULL AND fechaasignacionloc ISNULL"
        Llenagrid(Sql)
        Lbl_titulo.Text = "Patrones sin asignar"
    End Sub
    Public Sub Llenagrid_asignados()
        Sql = "SELECT * FROM domicilio.vw_sicad_asignaciones WHERE fechaasignacionnl IS NOT NULL AND fechaasignacionloc IS NOT NULL"
        Llenagrid(Sql)
        Lbl_titulo.Text = "Patrones Asignados"
    End Sub
    Public Sub Llenagrid_todos()
        Sql = "SELECT * FROM domicilio.vw_sicad_asignaciones"
        Llenagrid(Sql)
        Lbl_titulo.Text = "Todos los Patrones"
    End Sub
    Public Sub Llenagrid_sin_NL()
        Sql = "SELECT * FROM domicilio.vw_sicad_asignaciones WHERE fechaasignacionnl ISNULL"
        Llenagrid(Sql)
        Lbl_titulo.Text = "Patrones sin Asignar Notificador Localizador"
    End Sub
    Public Sub Llenagrid_sin_loc()
        Sql = "SELECT * FROM domicilio.vw_sicad_asignaciones WHERE fechaasignacionloc ISNULL"
        Llenagrid(Sql)
        Lbl_titulo.Text = "Patrones sin Asignar Localizador"
    End Sub


    'ACCIONES

    Public Sub Guardar_NL()
        If Cbx_nl.Enabled = True Then

            If Cbx_dias_nl.Text = "" Then
                MsgBox("Selecciona cuantos dias para la verificacion del Notificador Localizador")
            Else

                Sql = "UPDATE domicilio.sicad_asig_ver_dom SET 
                    idnotiflocal = @idnotiflocal, 
                    domicilio = @domicilio, 
                    fechaasignacionnl = @fechaasignacionnl, 
                    fechamaxrespnl = @fechamaxrespnl 
               WHERE idpatronnl = " & Lbl_idpatronnl.Text


                Cmd = New NpgsqlCommand(Sql, Mycon)

                Cmd.Parameters.AddWithValue("@idnotiflocal", Cbx_nl.SelectedValue)
                Cmd.Parameters.AddWithValue("@domicilio", Txb_domicilio.Text)
                Cmd.Parameters.AddWithValue("@fechaasignacionnl", Dtp_asig_nl.Value)
                Cmd.Parameters.AddWithValue("@fechamaxrespnl", Dtp_vencimiento_nl.Value)


                Try

                    Cmd.ExecuteNonQuery()
                    MsgBox("Notificador Localizador Asignado", vbInformation, "Mensaje del Sistema")

                    Btn_imp_con_nl.Enabled = True
                    Cbx_nl.Enabled = False
                    Dtp_asig_nl.Enabled = False
                    Cbx_dias_nl.Enabled = False

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End If
        End If
    End Sub
    Public Sub Guardar_Loc()
        If Cbx_localizadores.Enabled = True Then
            If Cbx_dias_loc.Text = "" Then
                MsgBox("Selecciona cuantos dias para la verificacion del Localizador")
            Else
                Sql = "UPDATE domicilio.sicad_asig_ver_int SET 
                    idlocalizador = @idlocalizador, 
                    fechaasignacionloc = @fechaasignacionloc, 
                    fechamaxrsploc = @fechamaxrsploc 
               WHERE idpatronnl = " & Lbl_idpatronnl.Text


                Cmd = New NpgsqlCommand(Sql, Mycon)

                Cmd.Parameters.AddWithValue("@idlocalizador", Cbx_localizadores.SelectedValue)
                Cmd.Parameters.AddWithValue("@fechaasignacionloc", Dtp_asig_loc.Value)
                Cmd.Parameters.AddWithValue("@fechamaxrsploc", Dtp_vencimiento_loc.Value)

                Try

                    Cmd.ExecuteNonQuery()
                    MsgBox("Localizador Asignado", vbInformation, "Mensaje del Sistema")
                    Btn_imp_con_loc.Enabled = True
                    Cbx_localizadores.Enabled = False
                    Dtp_asig_loc.Enabled = False
                    Cbx_dias_loc.Enabled = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End If
        End If
    End Sub
    Public Sub Actualizar()
        Sql = "UPDATE domicilio.sicad_asig_ver_dom SET 
                    idnotiflocal = @idnotiflocal, 
                    domicilio = @domicilio, 
                    fechaasignacionnl = @fechaasignacionnl, 
                    fechamaxrespnl = @fechamaxrespnl 
               WHERE idpatronnl = " & Lbl_idpatronnl.Text


        Cmd = New NpgsqlCommand(Sql, Mycon)

        Cmd.Parameters.AddWithValue("@idnotiflocal", Cbx_nl.SelectedValue)
        Cmd.Parameters.AddWithValue("@domicilio", Txb_domicilio.Text)
        Cmd.Parameters.AddWithValue("@fechaasignacionnl", Dtp_asig_nl.Value)
        Cmd.Parameters.AddWithValue("@fechamaxrespnl", Dtp_vencimiento_nl.Value)


        Try

            Cmd.ExecuteNonQuery()
            MsgBox("Notificador Localizador Actualizado", vbInformation, "Mensaje del Sistema")

            Btn_imp_con_nl.Enabled = True
            Cbx_nl.Enabled = False
            Dtp_asig_nl.Enabled = False
            Cbx_dias_nl.Enabled = False
            Dtp_vencimiento_nl.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        Sql = "UPDATE domicilio.sicad_asig_ver_int SET 
                    idlocalizador = @idlocalizador, 
                    fechaasignacionloc = @fechaasignacionloc, 
                    fechamaxrsploc = @fechamaxrsploc 
               WHERE idpatronnl = " & Lbl_idpatronnl.Text


        Cmd = New NpgsqlCommand(Sql, Mycon)

        Cmd.Parameters.AddWithValue("@idlocalizador", Cbx_localizadores.SelectedValue)
        Cmd.Parameters.AddWithValue("@fechaasignacionloc", Dtp_asig_loc.Value)
        Cmd.Parameters.AddWithValue("@fechamaxrsploc", Dtp_vencimiento_loc.Value)

        Try

            Cmd.ExecuteNonQuery()
            MsgBox("Localizador Actualizado", vbInformation, "Mensaje del Sistema")
            Btn_imp_con_loc.Enabled = True
            Cbx_localizadores.Enabled = False
            Dtp_asig_loc.Enabled = False
            Cbx_dias_loc.Enabled = False
            Dtp_vencimiento_loc.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub Limpiar()
        Txb_reg_pat.Clear()
        Txb_dig_rp.Clear()
        Txb_raz_soc.Clear()
        Txb_domicilio.Clear()
        Cbx_nl.Text = ""
        Dtp_asig_nl.Value = Today
        Cbx_dias_nl.Text = ""
        Dtp_vencimiento_nl.Value = Today
        Cbx_localizadores.Text = ""
        Dtp_asig_loc.Value = Today
        Cbx_dias_loc.Text = ""
        Dtp_vencimiento_loc.Value = Today

        Txb_cant_cop.Clear()
        Txb_imp_cop.Clear()
        Txb_cant_rcv.Clear()
        Txb_imp_rcv.Clear()
        Txb_can_tot.Clear()
        Txb_imp_tot.Clear()
        Lbl_rango.Text = "0"

        Txb_reg_pat.Clear()
        Txb_dig_rp.Clear()
        Txb_raz_soc.Clear()
        Txb_domicilio.Clear()
        Cbx_nl.Text = ""
        Dtp_asig_nl.Value = Today
        Cbx_dias_nl.Text = ""
        Dtp_vencimiento_nl.Value = Today
        Cbx_localizadores.Text = ""
        Dtp_asig_loc.Value = Today
        Cbx_dias_loc.Text = ""
        Dtp_vencimiento_loc.Value = Today




        Txb_reg_pat.Enabled = False
        Txb_dig_rp.Enabled = False
        Txb_raz_soc.Enabled = False
        Txb_domicilio.Enabled = False
        Cbx_nl.Enabled = False
        Dtp_asig_nl.Enabled = False
        Cbx_dias_nl.Enabled = False
        Dtp_vencimiento_nl.Enabled = False
        Cbx_localizadores.Enabled = False
        Dtp_asig_loc.Enabled = False
        Cbx_dias_loc.Enabled = False
        Dtp_vencimiento_loc.Enabled = False

        Btn_imp_con_nl.Enabled = False
        Btn_imp_con_loc.Enabled = False
        Btn_save.Enabled = False
        Btn_clean.Enabled = False
        Btn_update.Enabled = False


    End Sub
    Public Sub Generar_plantillas()
        'COPIAR EL ARCHIVO DEL PROYECTO AL EQUIPO
        Dim Direccion As String = "C:\SICAD09\CONTROL_NOTIF_LOCAL.xltx"
        Dim Direccion1 As String = "C:\SICAD09\CONTROL_LOCAL.xltx"

        Try

            Dim Archivo As Byte() = My.Resources.CONTROL_NOTIF_LOCAL 'OBTENEMOS EL ARCHIVO DE LOS RECURSOS
            File.WriteAllBytes(Direccion, Archivo) 'SE COPIA EL ARCHIVO A LA CARPETA

            Dim Archivo1 As Byte() = My.Resources.CONTROL_LOCAL 'OBTENEMOS EL ARCHIVO DE LOS RECURSOS
            File.WriteAllBytes(Direccion1, Archivo1) 'SE COPIA EL ARCHIVO A LA CARPETA

            MsgBox("Plantilla Generada")
        Catch ex As Exception
            MsgBox("Plantilla No Generada")
            MsgBox(ex.ToString)
        End Try


        ''ABRIR EL ARCHIVO
        'Dim Excel As Application
        'Excel = CreateObject("excel.Application")
        'Excel.Visible = True
        'Excel.WindowState = XlWindowState.xlMaximized
        'Excel.Workbooks.Open(Direccion)
    End Sub
    Public Sub Imprimir_control_nl()
        Dim exApp As Excel.Application
        Dim exLibro As Excel.Workbook
        Dim exHoja As Excel.Worksheet
        Dim rutaPlantilla As String = "C:\SICAD09\PLANTILLAS\CONTROL_NOTIF_LOCAL.xltx"
        'Dim Ncol As Integer
        'Dim Nrow As Integer
        'Dim Afeta As String

        exApp = New Excel.Application
        exLibro = exApp.Workbooks.Open(rutaPlantilla)
        exHoja = exLibro.Worksheets("Hoja1")

        '(FILA, COLUMNA)
        exHoja.Cells.Item(3, 1) = Txb_reg_pat.Text & Txb_dig_rp.Text
        exHoja.Cells.Item(3, 2) = Txb_raz_soc.Text
        exHoja.Cells.Item(3, 3) = Txb_domicilio.Text
        exHoja.Cells.Item(3, 4) = Dtp_vencimiento_nl.Value
        exHoja.Cells.Item(11, 4) = Dtp_asig_nl.Value
        exHoja.Cells.Item(12, 4) = Cbx_nl.Text

        exApp.Application.Visible = True
        exHoja = Nothing
        exLibro = Nothing
        exApp = Nothing


    End Sub
    Public Sub Imprimir_control_loc()
        Dim exApp As Excel.Application
        Dim exLibro As Excel.Workbook
        Dim exHoja As Excel.Worksheet
        Dim rutaPlantilla As String = "C:\SICAD09\PLANTILLAS\CONTROL_LOCAL.xltx"
        'Dim Ncol As Integer
        'Dim Nrow As Integer
        'Dim Afeta As String

        exApp = New Excel.Application
        exLibro = exApp.Workbooks.Open(rutaPlantilla)
        exHoja = exLibro.Worksheets("Hoja1")

        '(FILA, COLUMNA)
        exHoja.Cells.Item(3, 1) = Txb_reg_pat.Text & Txb_dig_rp.Text
        exHoja.Cells.Item(3, 2) = Txb_raz_soc.Text
        exHoja.Cells.Item(3, 3) = Lbl_acta_circ.Text
        exHoja.Cells.Item(3, 4) = Dtp_vencimiento_loc.Value
        exHoja.Cells.Item(3, 6) = Lbl_rango.Text

        exHoja.Cells.Item(11, 4) = Dtp_asig_loc.Value
        exHoja.Cells.Item(12, 4) = Cbx_localizadores.Text

        exApp.Application.Visible = True
        exHoja = Nothing
        exLibro = Nothing
        exApp = Nothing

    End Sub

    Private Sub Dgv_patrones_asignados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_patrones_asignados.CellClick
        Limpiar()
        Dim i As Integer
        Try
            i = Dgv_patrones_asignados.CurrentRow.Index
            Lbl_idpatronnl.Text = Dgv_patrones_asignados.Item(0, i).Value()
            Txb_reg_pat.Text = Dgv_patrones_asignados.Item(1, i).Value()
            Txb_dig_rp.Text = Dgv_patrones_asignados.Item(2, i).Value()
            Txb_raz_soc.Text = Dgv_patrones_asignados.Item(3, i).Value()
            Txb_domicilio.Text = Dgv_patrones_asignados.Item(5, i).Value() & ", CP. " & Dgv_patrones_asignados.Item(7, i).Value() & ", " & Dgv_patrones_asignados.Item(6, i).Value()
            Lbl_acta_circ.Text = Dgv_patrones_asignados.Item(8, i).Value()

            If Dgv_patrones_asignados.Item(10, i).Value() Is DBNull.Value Then

                Cbx_nl.Enabled = True
                Dtp_asig_nl.Enabled = True
                Cbx_dias_nl.Enabled = True

            Else
                Cbx_nl.Text = Dgv_patrones_asignados.Item(11, i).Value()
                Dtp_asig_nl.Value = Dgv_patrones_asignados.Item(12, i).Value()
            End If


            If Dgv_patrones_asignados.Item(13, i).Value() Is DBNull.Value Then
                Cbx_localizadores.Enabled = True
                Dtp_asig_loc.Enabled = True
                Cbx_dias_loc.Enabled = True
                Dtp_vencimiento_loc.Enabled = True
            Else
                Cbx_localizadores.Text = Dgv_patrones_asignados.Item(16, i).Value()
                Dtp_asig_loc.Value = Dgv_patrones_asignados.Item(17, i).Value()
                Dtp_vencimiento_loc.Value = Dgv_patrones_asignados.Item(18, i).Value()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        If Cbx_nl.Text <> "" And Cbx_localizadores.Text <> "" Then
            Btn_update.Visible = True
            Btn_update.Enabled = True
            Btn_imp_con_nl.Enabled = True
            Btn_imp_con_loc.Enabled = True
        Else
            Btn_update.Visible = False
            Btn_update.Enabled = False
        End If
        Cargar_creditos()
        Btn_save.Enabled = True

        Btn_clean.Enabled = True
    End Sub
    Private Sub Cbx_dias_nl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_dias_nl.SelectedIndexChanged
        Dim Fecha_asignado As Date
        Dim var_dias As Integer
        Dim Fecha_avanza As Date

        Fecha_asignado = Dtp_asig_nl.Value ' fecha inicial
        var_dias = Cbx_dias_nl.Text 'dias a incrementar
        Fecha_avanza = DateAndTime.DateAdd(DateInterval.Day, 1, Fecha_asignado) 'Se comienza el siguiente 


        Dim i As Integer = 1
        While i <= var_dias ' mientras que i sea menor que los dias a sumar  ingresa

            ' MsgBox(var_dias)
            'MsgBox(Format(Fecha_avanza, "dddd"))

            If Format(Fecha_avanza, "dddd") = "sábado" Or Format(Fecha_avanza, "dddd") = "domingo" Then ' si el dia recorrido es sabado o domingo
                var_dias = var_dias + 1 'se le suma 1 dia al los dias limites
            End If
            Fecha_avanza = DateAndTime.DateAdd(DateInterval.Day, 1, Fecha_avanza) 'se avanza al siguiente dia a evaluar

            i = i + 1 ' se suma el contador
        End While

        Dtp_vencimiento_nl.Text = Format(DateAdd("d", var_dias, Dtp_asig_nl.Value), "short Date") 'se muestra la fecha inicial mas los dias solicitados que ya sumaron dias que incluia sabado
        'Activar2()
    End Sub
    Private Sub Cbx_dias_loc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_dias_loc.SelectedIndexChanged
        Dim Fecha_asignado As Date
        Dim var_dias As Integer
        Dim Fecha_avanza As Date

        Fecha_asignado = Dtp_asig_loc.Value ' fecha inicial
        var_dias = Cbx_dias_loc.Text 'dias a incrementar
        Fecha_avanza = DateAndTime.DateAdd(DateInterval.Day, 1, Fecha_asignado) 'Se comienza el siguiente 


        Dim i As Integer = 1
        While i <= var_dias ' mientras que i sea menor que los dias a sumar  ingresa

            'MsgBox(var_dias)
            'MsgBox(Format(Fecha_avanza, "dddd"))

            If Format(Fecha_avanza, "dddd") = "sábado" Or Format(Fecha_avanza, "dddd") = "domingo" Then ' si el dia recorrido es sabado o domingo
                var_dias = var_dias + 1 'se le suma 1 dia al los dias limites
            End If
            Fecha_avanza = DateAndTime.DateAdd(DateInterval.Day, 1, Fecha_avanza) 'se avanza al siguiente dia a evaluar

            i = i + 1 ' se suma el contador
        End While

        Dtp_vencimiento_loc.Text = Format(DateAdd("d", var_dias, Dtp_asig_loc.Value), "short Date") 'se muestra la fecha inicial mas los dias solicitados que ya sumaron dias que incluia sabado
        'Activar2()
    End Sub
    Public Sub Cargar_creditos()

        Txb_cant_cop.Text = Creditos_COP(Txb_reg_pat.Text)
        Txb_imp_cop.Text = Format(Importe_COP(Txb_reg_pat.Text), "C2")

        Txb_cant_rcv.Text = Creditos_RCV(Txb_reg_pat.Text)
        Txb_imp_rcv.Text = Format(Importe_RCV(Txb_reg_pat.Text), "C2")

        Txb_can_tot.Text = Creditos_TOT(Txb_reg_pat.Text)
        Txb_imp_tot.Text = Format(Importe_TOT(Txb_reg_pat.Text), "C2")

        Lbl_rango.Text = Evaluar_rango("2022", CDbl(Txb_imp_tot.Text)) 'DE DONDE TOMAR EL AÑOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

        'query para traer la cuenta de credito y el importe

        'Sql = "SELECT 
        '        COUNT(patron) AS creditos, SUM(importe) As importe
        '       FROM
        '        domicilio.vw_ultimo_rale_cop
        '       WHERE
        '        patron = '" & Txb_reg_pat.Text & "' AND td <> '00'"
    End Sub


End Class