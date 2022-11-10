Imports System.IO
Imports Microsoft.Office.Interop
Imports Npgsql

Public Class Frm_03_formato_resultado_nl

    Public idnotiflocal As Integer

    Private Sub Frm_03_formato_resultado_nl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idnotiflocal = Lbl_idusuario.Text
        Llenagrid_sin_responder()
        DateTimePicker1.Value = Today
    End Sub

    'BOTONES
    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub TODOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TODOSToolStripMenuItem.Click
        Llenagrid_todos()
    End Sub
    Private Sub RESPONDIDOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESPONDIDOSToolStripMenuItem.Click
        Llenagrid_respondidos()
    End Sub
    Private Sub SINRESPONDERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SINRESPONDERToolStripMenuItem.Click
        Llenagrid_sin_responder()
    End Sub
    Private Sub PLANTILLASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PLANTILLASToolStripMenuItem.Click
        Generar_plantillas()
    End Sub
    Public Sub Verificar_Vacios()
        If Cbx_respuesta.Text = "" Or Txb_resultado.Text = "" Then
            MsgBox("Falta Respuesta o Resultado de la Verificacion de domiclio")
            Cbx_respuesta.Focus()
        ElseIf Cbx_respuestav1.Text = "" Or Txb_nombrev1.Text = "" Or Txb_resultadov1.Text = "" Or Cbx_respuestav1.Text = "" Then
            MsgBox("Falta Nombre, Respuesta o Resultado del Vecino 1")
            Txb_nombrev1.Focus()
        ElseIf Cbx_respuestav2.Text = "" Or Txb_nombrev2.Text = "" Or Txb_resultadov2.Text = "" Or Cbx_respuestav2.Text = "" Then
            MsgBox("Falta Nombre, Respuesta o Resultado del Vecino 2")
            Txb_nombrev2.Focus()
        ElseIf Cbx_respuestav3.Text = "" Or Txb_nombrev3.Text = "" Or Txb_resultadov3.Text = "" Or Cbx_respuestav3.Text = "" Then
            MsgBox("Falta Nombre, Respuesta o Resultado del Vecino 3")
            Txb_nombrev3.Focus()
        Else
            GUARDAR_RESULTADO()
        End If
    End Sub
    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click
        Verificar_Vacios()
    End Sub
    Private Sub IMPRIMIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IMPRIMIRToolStripMenuItem.Click
        Imprimir_reporte()
    End Sub

    Private Sub ToolStripTxbrp_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTxbrp.KeyDown
        If e.KeyData = Keys.Enter Then
            Llenagrid_rp()
        End If
    End Sub
    Private Sub ToolStripTxbnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTxbnombre.KeyDown
        If e.KeyData = Keys.Enter Then
            Llenagrid_nombre()
        End If
    End Sub

    'LLENAGRID
    Public Sub Llenagrid(sql)
        'Sql esta definida de manera global en el archivo de conexion

        Try
            Adp = New NpgsqlDataAdapter(sql, Mycon)
            Ds.Tables.Clear()
            Adp.Fill(Ds.Tables.Add("Tabla"))

            Me.Dgv_verificaciones_domicilio.DataSource = Ds.Tables("Tabla")
            Me.Dgv_verificaciones_domicilio.Columns(0).HeaderText = "ID"
            Me.Dgv_verificaciones_domicilio.Columns(1).HeaderText = "ID PATRON NL"
            Me.Dgv_verificaciones_domicilio.Columns(2).HeaderText = "REGISTRO PATRONAL"
            Me.Dgv_verificaciones_domicilio.Columns(3).HeaderText = "DIG VER"
            Me.Dgv_verificaciones_domicilio.Columns(4).HeaderText = "RAZON SOCIAL"
            Me.Dgv_verificaciones_domicilio.Columns(5).HeaderText = "ACTIVIDAD"
            Me.Dgv_verificaciones_domicilio.Columns(6).HeaderText = "DOMICILIO"
            Me.Dgv_verificaciones_domicilio.Columns(7).HeaderText = "LOCALIDAD"
            Me.Dgv_verificaciones_domicilio.Columns(8).HeaderText = "CP"
            Me.Dgv_verificaciones_domicilio.Columns(9).HeaderText = "DOMICILIO A VERIFICAR"
            Me.Dgv_verificaciones_domicilio.Columns(10).HeaderText = "ASIGNACION"
            Me.Dgv_verificaciones_domicilio.Columns(11).HeaderText = "MAXIMA RESPUESTA"

            Me.Dgv_verificaciones_domicilio.Columns(12).HeaderText = "FECHA RESPUESTA"
            Me.Dgv_verificaciones_domicilio.Columns(13).HeaderText = "RESULTADO"
            Me.Dgv_verificaciones_domicilio.Columns(14).HeaderText = "RESPUESTA"

            Me.Dgv_verificaciones_domicilio.Columns(15).HeaderText = "VECINO 1"
            Me.Dgv_verificaciones_domicilio.Columns(16).HeaderText = "DOMICILIO 1"
            Me.Dgv_verificaciones_domicilio.Columns(17).HeaderText = "RESULTADO 1"
            Me.Dgv_verificaciones_domicilio.Columns(18).HeaderText = "RESPUESTA 1"

            Me.Dgv_verificaciones_domicilio.Columns(19).HeaderText = "VECINO 2"
            Me.Dgv_verificaciones_domicilio.Columns(20).HeaderText = "DOMICILIO 2"
            Me.Dgv_verificaciones_domicilio.Columns(21).HeaderText = "RESULTADO 2"
            Me.Dgv_verificaciones_domicilio.Columns(22).HeaderText = "RESPUESTA 2"

            Me.Dgv_verificaciones_domicilio.Columns(23).HeaderText = "VECINO 3"
            Me.Dgv_verificaciones_domicilio.Columns(24).HeaderText = "DOMICILIO 3"
            Me.Dgv_verificaciones_domicilio.Columns(25).HeaderText = "RESULTADO 3"
            Me.Dgv_verificaciones_domicilio.Columns(26).HeaderText = "RESPUESTA 3"

            Me.Dgv_verificaciones_domicilio.Columns(27).HeaderText = "ID NL"

            ''VISIBILIDAD DE COLUMNAS
            Me.Dgv_verificaciones_domicilio.Columns(0).Visible = False
            Me.Dgv_verificaciones_domicilio.Columns(1).Visible = False
            Me.Dgv_verificaciones_domicilio.Columns(27).Visible = False

            'Me.Dgv_patrones_asignados.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Adp.Dispose()
    End Sub
    Public Sub Llenagrid_respondidos()
        Sql = "SELECT * FROM domicilio.vw_sicad_ver_dom WHERE idnotiflocal = " & idnotiflocal & " AND fecharspnl IS NOT NULL"
        Llenagrid(Sql)
        'Lbl_titulo.Text = "Patrones sin asignar"
    End Sub
    Public Sub Llenagrid_sin_responder()
        Sql = "SELECT * FROM domicilio.vw_sicad_ver_dom WHERE idnotiflocal = " & idnotiflocal & " AND fecharspnl ISNULL"
        Llenagrid(Sql)
        'Lbl_titulo.Text = "Patrones Asignados"
    End Sub
    Public Sub Llenagrid_todos()
        Sql = "SELECT * FROM domicilio.vw_sicad_ver_dom WHERE idnotiflocal = " & idnotiflocal
        Llenagrid(Sql)
        'Lbl_titulo.Text = "Todos los Patrones"
    End Sub
    Public Sub Llenagrid_rp()
        Sql = "SELECT * FROM domicilio.vw_sicad_ver_dom WHERE regpat LIKE '%" & ToolStripTxbrp.Text & "%' AND idnotiflocal = " & idnotiflocal

        Llenagrid(Sql)
        'Lbl_titulo.Text = "Todos los Patrones"
    End Sub
    Public Sub Llenagrid_nombre()
        Sql = "SELECT * FROM domicilio.vw_sicad_ver_dom WHERE razsoc LIKE '%" & ToolStripTxbnombre.Text & "%' AND idnotiflocal = " & idnotiflocal

        Llenagrid(Sql)
        'Lbl_titulo.Text = "Todos los Patrones"
    End Sub

    'ACCIONES
    Public Sub Generar_plantillas()
        'COPIAR EL ARCHIVO DEL PROYECTO AL EQUIPO
        Dim Direccion As String = "C:\SICAD09\RESULTADO_NL.xltx"


        Try

            Dim Archivo As Byte() = My.Resources.RESULTADO_NL 'OBTENEMOS EL ARCHIVO DE LOS RECURSOS
            File.WriteAllBytes(Direccion, Archivo) 'SE COPIA EL ARCHIVO A LA CARPETA

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
    Private Sub Dgv_verificaciones_domicilio_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_verificaciones_domicilio.CellClick
        Limpiar()
        Dim fecha_rsp As String = ""
        Try
            Dim i As Integer
            i = Dgv_verificaciones_domicilio.CurrentRow.Index

            Lbl_id_ver_dom.Text = Dgv_verificaciones_domicilio.Item(0, i).Value()
            Txb_reg_pat.Text = Dgv_verificaciones_domicilio.Item(2, i).Value()
            Txb_dig_rp.Text = Dgv_verificaciones_domicilio.Item(3, i).Value()
            Txb_raz_soc.Text = Dgv_verificaciones_domicilio.Item(4, i).Value()
            Txb_actividad.Text = Dgv_verificaciones_domicilio.Item(5, i).Value()
            Txb_domicilio.Text = Dgv_verificaciones_domicilio.Item(6, i).Value() & ", CP. " & Dgv_verificaciones_domicilio.Item(8, i).Value() & ", " & Dgv_verificaciones_domicilio.Item(7, i).Value()
            Txb_domicilio_verificar.Text = Dgv_verificaciones_domicilio.Item(9, i).Value()


            fecha_rsp = Dgv_verificaciones_domicilio.Item(12, i).Value()


            If fecha_rsp <> "" Then
                DateTimePicker1.Value = fecha_rsp
                Txb_resultado.Text = Dgv_verificaciones_domicilio.Item(13, i).Value()
                Cbx_respuesta.Text = Dgv_verificaciones_domicilio.Item(14, i).Value()

                Txb_nombrev1.Text = Dgv_verificaciones_domicilio.Item(15, i).Value()
                Txb_domv1.Text = Dgv_verificaciones_domicilio.Item(16, i).Value()
                Txb_resultadov1.Text = Dgv_verificaciones_domicilio.Item(17, i).Value()
                Cbx_respuestav1.Text = Dgv_verificaciones_domicilio.Item(18, i).Value()

                Txb_nombrev2.Text = Dgv_verificaciones_domicilio.Item(19, i).Value()
                Txb_domv2.Text = Dgv_verificaciones_domicilio.Item(20, i).Value()
                Txb_resultadov2.Text = Dgv_verificaciones_domicilio.Item(21, i).Value()
                Cbx_respuestav2.Text = Dgv_verificaciones_domicilio.Item(22, i).Value()

                Txb_nombrev3.Text = Dgv_verificaciones_domicilio.Item(23, i).Value()
                Txb_domv3.Text = Dgv_verificaciones_domicilio.Item(24, i).Value()
                Txb_resultadov3.Text = Dgv_verificaciones_domicilio.Item(25, i).Value()
                Cbx_respuestav3.Text = Dgv_verificaciones_domicilio.Item(26, i).Value()
            End If

        Catch

        End Try
        Me.TabControl1.SelectedIndex = 1
    End Sub
    Public Sub GUARDAR_RESULTADO()
        'Recorrer todos los controles TextBox y asignarles 'vacío' como valor 

        Sql = "UPDATE domicilio.sicad_asig_ver_dom SET 
                    fecharspnl = @fecharespnl, 
                    resultado = @resultado, 
                    respuesta = @respuesta,
                    nombrev1 = @nombrev1,
                    domiciliov1 = @domiciliov1,
                    resultadov1 = @resultadov1,
                    respuestav1 = @respuestav1,
                    nombrev2 = @nombrev2,
                    domiciliov2 = @domiciliov2,
                    resultadov2 = @resultadov2,
                    respuestav2 = @respuestav2,
                    nombrev3 = @nombrev3,
                    domiciliov3 = @domiciliov3,
                    resultadov3 = @resultadov3,
                    respuestav3 = @respuestav3
               WHERE idverdom = " & Lbl_id_ver_dom.Text


        Cmd = New NpgsqlCommand(Sql, Mycon)

        Cmd.Parameters.AddWithValue("@fecharespnl", DateTimePicker1.Value)
        Cmd.Parameters.AddWithValue("@respuesta", Cbx_respuesta.Text)
        Cmd.Parameters.AddWithValue("@resultado", Txb_resultado.Text)

        Cmd.Parameters.AddWithValue("@nombrev1", Txb_nombrev1.Text)
        Cmd.Parameters.AddWithValue("@domiciliov1", Txb_domv1.Text)
        Cmd.Parameters.AddWithValue("@respuestav1", Cbx_respuestav1.Text)
        Cmd.Parameters.AddWithValue("@resultadov1", Txb_resultadov1.Text)


        Cmd.Parameters.AddWithValue("@nombrev2", Txb_nombrev2.Text)
        Cmd.Parameters.AddWithValue("@domiciliov2", Txb_domv2.Text)
        Cmd.Parameters.AddWithValue("@respuestav2", Cbx_respuestav2.Text)
        Cmd.Parameters.AddWithValue("@resultadov2", Txb_resultadov2.Text)


        Cmd.Parameters.AddWithValue("@nombrev3", Txb_nombrev3.Text)
        Cmd.Parameters.AddWithValue("@domiciliov3", Txb_domv3.Text)
        Cmd.Parameters.AddWithValue("@respuestav3", Cbx_respuestav3.Text)
        Cmd.Parameters.AddWithValue("@resultadov3", Txb_resultadov3.Text)

        Try

            Cmd.ExecuteNonQuery()
            MsgBox("Resultado de Verificacion de Domicilio Guardado", vbInformation, "Mensaje del Sistema")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
    Public Sub Imprimir_reporte()
        Dim exApp As Excel.Application
        Dim exLibro As Excel.Workbook
        Dim exHoja As Excel.Worksheet
        Dim rutaPlantilla As String = "C:\SICAD09\PLANTILLAS\RESULTADO_NL.xltx"
        'Dim Ncol As Integer
        'Dim Nrow As Integer
        'Dim Afeta As String

        exApp = New Excel.Application
        exLibro = exApp.Workbooks.Open(rutaPlantilla)
        exHoja = exLibro.Worksheets("Hoja1")

        '(FILA, COLUMNA)
        exHoja.Cells.Item(1, 2) = Txb_raz_soc.Text
        exHoja.Cells.Item(2, 2) = Txb_reg_pat.Text & Txb_dig_rp.Text
        exHoja.Cells.Item(2, 4) = Txb_actividad.Text
        exHoja.Cells.Item(3, 2) = Txb_domicilio.Text
        exHoja.Cells.Item(7, 2) = Txb_domicilio_verificar.Text
        exHoja.Cells.Item(8, 2) = Cbx_respuesta.Text
        exHoja.Cells.Item(9, 1) = Txb_resultado.Text
        exHoja.Cells.Item(11, 2) = Txb_nombrev1.Text
        exHoja.Cells.Item(12, 2) = Txb_domv1.Text
        exHoja.Cells.Item(13, 2) = Cbx_respuestav1.Text
        exHoja.Cells.Item(14, 1) = Txb_resultadov1.Text

        exHoja.Cells.Item(15, 2) = Txb_nombrev2.Text
        exHoja.Cells.Item(16, 2) = Txb_domv2.Text
        exHoja.Cells.Item(17, 2) = Cbx_respuestav2.Text
        exHoja.Cells.Item(18, 1) = Txb_resultadov2.Text

        exHoja.Cells.Item(19, 2) = Txb_nombrev3.Text
        exHoja.Cells.Item(20, 2) = Txb_domv3.Text
        exHoja.Cells.Item(21, 2) = Cbx_respuestav3.Text
        exHoja.Cells.Item(22, 1) = Txb_resultadov3.Text

        exHoja.Cells.Item(24, 2) = Lbl_nombre_nl.Text
        exHoja.Cells.Item(24, 4) = DateTimePicker1.Value

        exApp.Application.Visible = True
        exHoja = Nothing
        exLibro = Nothing
        exApp = Nothing

    End Sub
    Public Sub Limpiar()
        Txb_reg_pat.Clear()
        Txb_dig_rp.Clear()
        Txb_raz_soc.Clear()
        Txb_actividad.Clear()
        Txb_domicilio.Clear()
        Txb_domicilio_verificar.Clear()
        Cbx_respuesta.Text = ""
        Txb_resultado.Clear()

        Txb_nombrev1.Clear()
        Txb_domv1.Clear()
        Txb_resultadov1.Clear()
        Cbx_respuestav1.Text = ""

        Txb_nombrev2.Clear()
        Txb_domv2.Clear()
        Txb_resultadov2.Clear()
        Cbx_respuestav2.Text = ""

        Txb_nombrev3.Clear()
        Txb_domv3.Clear()
        Txb_resultadov3.Clear()
        Cbx_respuestav3.Text = ""
        DateTimePicker1.Value = Today
    End Sub
    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        Llenagrid_sin_responder()

        PLANTILLASToolStripMenuItem.Enabled = False
        GUARDARToolStripMenuItem.Enabled = False
        IMPRIMIRToolStripMenuItem.Enabled = False
        VERToolStripMenuItem.Enabled = True
    End Sub
    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        PLANTILLASToolStripMenuItem.Enabled = True
        GUARDARToolStripMenuItem.Enabled = True
        IMPRIMIRToolStripMenuItem.Enabled = True

        VERToolStripMenuItem.Enabled = False
    End Sub


End Class