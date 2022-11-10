Imports Npgsql
Imports System.IO
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel


Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Data.OleDb


Public Class Frm_03_inicio
    Dim doc As New Document(PageSize.LETTER.Rotate, 25, 25, 55, 60) ' margenes donde comienza a colocar el texto 
    Dim oImagen As iTextSharp.text.Image
    Public Nl As String
    Public Var_jefe As String

    Private Sub Frm_02_inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenagrid()
    End Sub

    Public Sub Llenagrid()

        'Sql esta definida de manera global en el archivo de conexion
        Sql = "SELECT * FROM domicilio.vw_sicad_inicios_nl WHERE fecharecibido IS NULL"
        Adp = New NpgsqlDataAdapter(Sql, Mycon)
        Ds.Tables.Clear()
        Adp.Fill(Ds.Tables.Add("Tabla"))

        Me.Dgv_inicio.DataSource = Ds.Tables("Tabla")
        Me.Dgv_inicio.Columns(0).HeaderText = "ID"
        Me.Dgv_inicio.Columns(1).HeaderText = "ID PATRON"
        Me.Dgv_inicio.Columns(2).HeaderText = "REGISTRO PATRONAL"
        Me.Dgv_inicio.Columns(3).HeaderText = "DIGITO"
        Me.Dgv_inicio.Columns(4).HeaderText = "RAZON SOCIAL"
        Me.Dgv_inicio.Columns(5).HeaderText = "DOMICILIO"
        Me.Dgv_inicio.Columns(6).HeaderText = "LOCALIDAD"
        Me.Dgv_inicio.Columns(7).HeaderText = "CP"
        Me.Dgv_inicio.Columns(8).HeaderText = "SECTOR"
        Me.Dgv_inicio.Columns(9).HeaderText = "NOTIFICADOR"
        Me.Dgv_inicio.Columns(10).HeaderText = "CREDITOS COP INICIO"
        Me.Dgv_inicio.Columns(11).HeaderText = "CREDITOS RCV INICIO"
        Me.Dgv_inicio.Columns(12).HeaderText = "OFICINA DE ORIGEN"
        Me.Dgv_inicio.Columns(13).HeaderText = "NO MEMO"
        Me.Dgv_inicio.Columns(14).HeaderText = "CREDITOS COP"
        Me.Dgv_inicio.Columns(15).HeaderText = "IMPORTES COP"
        Me.Dgv_inicio.Columns(16).HeaderText = "CREDITOS RCV"
        Me.Dgv_inicio.Columns(17).HeaderText = "IMPORTES RCV"
        Me.Dgv_inicio.Columns(18).HeaderText = "TOTAL DE CREDITOS"
        Me.Dgv_inicio.Columns(19).HeaderText = "IMPORTE TOTAL"
        Me.Dgv_inicio.Columns(20).HeaderText = "FECHA ACTA CIRCUNSTANCIADA"
        Me.Dgv_inicio.Columns(21).HeaderText = "FECHA DE RECIBIDO"
        Me.Dgv_inicio.Columns(22).HeaderText = "FECHA LIMITE"
        Me.Dgv_inicio.Columns(23).HeaderText = "DOCUMENTO PARA BAJA"
        Me.Dgv_inicio.Columns(24).HeaderText = "USUARIO"

        'VISIBILIDAD DE COLUMNAS
        Me.Dgv_inicio.Columns(0).Visible = False
        Me.Dgv_inicio.Columns(1).Visible = False

        Me.Dgv_inicio.Columns(5).Visible = False
        Me.Dgv_inicio.Columns(6).Visible = False

        Me.Dgv_inicio.Columns(7).Visible = False
        Me.Dgv_inicio.Columns(9).Visible = False
        Me.Dgv_inicio.Columns(10).Visible = False
        Me.Dgv_inicio.Columns(11).Visible = False
        Me.Dgv_inicio.Columns(12).Visible = False
        Me.Dgv_inicio.Columns(13).Visible = False
        Me.Dgv_inicio.Columns(14).Visible = False
        Me.Dgv_inicio.Columns(15).Visible = False
        Me.Dgv_inicio.Columns(16).Visible = False
        Me.Dgv_inicio.Columns(17).Visible = False
        Me.Dgv_inicio.Columns(18).Visible = False
        Me.Dgv_inicio.Columns(19).Visible = False
        Me.Dgv_inicio.Columns(20).Visible = False
        Me.Dgv_inicio.Columns(21).Visible = False
        Me.Dgv_inicio.Columns(22).Visible = False
        Me.Dgv_inicio.Columns(23).Visible = False
        'Me.Dgv_inicio.Columns(24).Visible = False

        Me.Dgv_inicio.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.Dgv_inicio.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.Dgv_inicio.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Adp.Dispose()


        Adp.Dispose()

    End Sub
    'AGREGA Y ACTIVA LOS VALORES ACTUALES
    Private Sub Dgv_inicio_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_inicio.CellClick
        Dim i As Integer
        Try
            i = Dgv_inicio.CurrentRow.Index
            id_patronnl.Text = Dgv_inicio.Item(0, i).Value()
            Txb_reg_pat.Text = Dgv_inicio.Item(2, i).Value()
            Txb_dig_rp.Text = Dgv_inicio.Item(3, i).Value()
            Txb_raz_soc.Text = Dgv_inicio.Item(4, i).Value()
            Txb_domicilio.Text = Dgv_inicio.Item(5, i).Value() & ", CP. " & Dgv_inicio.Item(7, i).Value() & ", " & Dgv_inicio.Item(6, i).Value()
            Txb_sector.Text = Dgv_inicio.Item(8, i).Value()
            Txb_sector.Focus()
            Consultar_creditos_COP()
            Consultar_creditos_RCV()
            Suma_adeudos()

        Catch ex As Exception

        End Try
        Activar1()
    End Sub
    Public Sub Activar1()

        Cbx_ofi_origen.Enabled = True
        Txb_memo.Enabled = True
        Txb_doc_baja.Enabled = True
        Dtp_acta_circ.Enabled = True
        Dtp_recibido.Enabled = True
        Cbx_dias_mas.Enabled = True
        Btn_guardar.Enabled = True
        Txb_sector.Enabled = True
    End Sub
    Private Sub Txb_sector_TextChanged(sender As Object, e As EventArgs) Handles Txb_sector.TextChanged

        If Txb_sector.Text = "" Then
        Else
            Sql = "SELECT * FROM domicilio.vw_sectores_nl WHERE sector = '" & Txb_sector.Text & "'"
            Cmd = New NpgsqlCommand(Sql, Mycon)
            Try
                Dr = Cmd.ExecuteReader
                Dr.Read()
                Txb_notificador.Text = Dr.GetValue(1)
                Txb_mat_not.Text = Dr.GetValue(2)
                Dr.Close()
            Catch ex As Exception
                MsgBox("Sector no tiene NL", vbCritical, "Busqueda 1")
                Dr.Close()
                Cmd.Dispose()
            End Try
        End If
    End Sub
    Private Sub Cbx_dias_mas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_dias_mas.SelectedIndexChanged
        Dim Fecha_recibido As Date
        Dim var_dias As Integer
        Dim Fecha_avanza As Date

        Fecha_recibido = Dtp_recibido.Value ' fecha inicial
        var_dias = Cbx_dias_mas.Text 'dias a incrementar
        Fecha_avanza = DateAndTime.DateAdd(DateInterval.Day, 1, Fecha_recibido) 'Se comienza el siguiente 


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

        Dtp_vencimiento.Text = Format(DateAdd("d", var_dias, Dtp_recibido.Value), "short Date") 'se muestra la fecha inicial mas los dias solicitados que ya sumaron dias que incluia sabado
        Activar2()
    End Sub ' dias habiles

    Public Sub Activar2()
        Dgv_creditos.Enabled = True
        Btn_cargar_creditos.Enabled = True

    End Sub

    'MUESTRA LSO CREDITOS DEPENDIENDO DEL BOTON Y AGREGA AL TEXTBOX DEPENDIENDO DEL TIPO DE DOCUMENTO
    Private Sub Btn_cargar_creditos_Click(sender As Object, e As EventArgs) Handles Btn_cargar_creditos.Click

        Sql = "SELECT detrales,credito,periodo,importe, incidencia, td FROM domicilio.vw_ultimo_rale
               WHERE patron = '" & Txb_reg_pat.Text & "'
               ORDER BY periodo"

        LlenagridCreditos(Sql)

        Btn_agregar_creditos.Enabled = True
    End Sub
    Private Sub LlenagridCreditos(SQL)

        Try
            Adp = New NpgsqlDataAdapter(SQL, Mycon)
            Ds.Tables.Clear()

            Adp.Fill(Ds.Tables.Add("Tabla"))

            'Nombres de Columnas
            Me.Dgv_creditos.DataSource = Ds.Tables("Tabla")
            Me.Dgv_creditos.Columns(1).Name = "Id"
            Me.Dgv_creditos.Columns(2).Name = "Credito"
            Me.Dgv_creditos.Columns(3).Name = "Periodo"
            Me.Dgv_creditos.Columns(4).Name = "Importe"
            Me.Dgv_creditos.Columns(5).Name = "Incidencia"
            Me.Dgv_creditos.Columns(6).Name = "TD"
            'Encabezados
            Me.Dgv_creditos.Columns("Id").HeaderText = "ID"
            Me.Dgv_creditos.Columns("Credito").HeaderText = "Credito"
            Me.Dgv_creditos.Columns("Periodo").HeaderText = "Periodo"
            Me.Dgv_creditos.Columns("Importe").HeaderText = "Importe"
            Me.Dgv_creditos.Columns("Incidencia").HeaderText = "Incidencia"
            Me.Dgv_creditos.Columns("TD").HeaderText = "TD"

            'Propiedaes
            'Me.Dgv_creditos.DataSource = Ds.Tables("Tabla")
            Me.Dgv_creditos.Columns("Id").Visible = False
            Me.Dgv_creditos.Columns("Importe").DefaultCellStyle.Format = "C2"

            'Alineacion de columnas
            Me.Dgv_creditos.Columns("Credito").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.Dgv_creditos.Columns("Periodo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.Dgv_creditos.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.Dgv_creditos.Columns("Incidencia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.Dgv_creditos.Columns("TD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Adp.Dispose()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Btn_agregar_creditos_Click(sender As Object, e As EventArgs) Handles Btn_agregar_creditos.Click
        Txb_cop_inicio.Text = ""
        Txb_rcv_inicio.Text = ""
        Dim credito As String = ""
        Dim td As String = ""
        For Each dgvfilas As DataGridViewRow In Dgv_creditos.Rows

            If Convert.ToBoolean(dgvfilas.Cells("Seleccionar").Value) = True Then

                td = RTrim(dgvfilas.Cells(6).Value)
                If td = "06" Then
                    Txb_rcv_inicio.Text = Txb_rcv_inicio.Text + dgvfilas.Cells(2).Value & ","
                Else
                    Txb_cop_inicio.Text = Txb_cop_inicio.Text + dgvfilas.Cells(2).Value & ","
                End If

            End If
        Next


        Txb_cop_inicio.Enabled = True
        Txb_rcv_inicio.Enabled = True

    End Sub



    'CARGA LA CANTIDAD DE CREDITOS ACTUALES EN EL RALE Y EL IMPORTE COP, RCV Y TOTAL
    Public Sub Consultar_creditos_COP()

        Sql = "SELECT count(*) FROM domicilio.vw_ultimo_rale_cop WHERE incidencia <> '000' AND patron = '" & Txb_reg_pat.Text & "'"

        'MsgBox(Sql)
        Cmd = New NpgsqlCommand(Sql, Mycon)
        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()

            Txb_cop_cant.Text = Dr.GetValue(0)

            Dr.Close()

        Catch ex As Exception
            Dr.Close()
            ' MsgBox(ex.ToString)
        End Try

        Sql2 = "SELECT SUM(importe) FROM domicilio.vw_ultimo_rale_cop WHERE patron = '" & Txb_reg_pat.Text & "'"

        'MsgBox(Sql)
        Cmd = New NpgsqlCommand(Sql2, Mycon)
        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()

            MsgBox(Format(CDec(Dr.GetValue(0)), "C2"))
            Txb_cop_imp.Text = Format(CDec(Dr.GetValue(0)), "C2")

            If Txb_cop_imp.Text = "" Then
                Txb_cop_imp.Text = Format(CDec(0), "C2")
            End If


            Dr.Close()

        Catch ex As Exception
            Dr.Close()
            'MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub Consultar_creditos_RCV()

        Sql = "SELECT count(*) FROM domicilio.vw_ultimo_rale_rcv WHERE patron = '" & Txb_reg_pat.Text & "'"

        'MsgBox(Sql)
        Cmd = New NpgsqlCommand(Sql, Mycon)
        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()

            Txb_rcv_cant.Text = Dr.GetValue(0)

            Dr.Close()

        Catch ex As Exception
            Dr.Close()
            'MsgBox(ex.ToString)
        End Try

        Sql2 = "SELECT SUM(importe) FROM domicilio.vw_ultimo_rale_rcv WHERE patron = '" & Txb_reg_pat.Text & "'"

        'MsgBox(Sql)
        Cmd = New NpgsqlCommand(Sql2, Mycon)
        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()

            Txb_rcv_imp.Text = Format(CDec(Dr.GetValue(0)), "C2")


            If Txb_rcv_imp.Text = "" Then
                Txb_rcv_imp.Text = Format(CDec(0), "C2")
            End If
            Dr.Close()

        Catch ex As Exception
            Dr.Close()
            'MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub Suma_adeudos()

        Dim SUMA_TEMP As Integer = CInt(Txb_rcv_cant.Text) + CInt(Txb_cop_cant.Text)
        Txb_tot_cant.Text = SUMA_TEMP

        Dim IMP_TEMP As Double = CDbl(Txb_cop_imp.Text) + CDbl(Txb_rcv_imp.Text)
        Txb_tot_imp.Text = Format(CDec(IMP_TEMP), "C2")
    End Sub

    Private Sub Btn_guardar_Click(sender As Object, e As EventArgs) Handles Btn_guardar.Click


        Guardar()

        'Datos_pop.Idpatronnl = id_patronnl.Text
        'Frm_rep_03.Show()


    End Sub
    Public Sub Guardar()
        Sql = "UPDATE domicilio.sicad_iniciosnl 
                    SET 
                        copinicio = @copinicio,
                        rcvinicio = @rcvinicio,
                        oficinaorigen = @oficinaorigen,
                        nomemo = @nomemo,
                        totalcreditos = @totalcreditos,
                        importecop = @importecop,
                        importercv = @importercv,
                        importetotal = @importetotal,
                        fechaactcirc = @fechaactcirc,
                        fecharecibido = @fecharecibido,
                        fechalimite = @fechalimite,
                        sector = @sector,
                        notificador = @notificador,
                        docparabaja = @docparabaja,
                        creditoscop = @creditoscop,
                        creditosrcv = @creditosrcv
                    WHERE idinicio = " & id_patronnl.Text

        Cmd = New NpgsqlCommand(Sql, Mycon)

        Cmd.Parameters.AddWithValue("@copinicio", Txb_cop_inicio.Text)
        Cmd.Parameters.AddWithValue("@rcvinicio", Txb_rcv_inicio.Text)
        Cmd.Parameters.AddWithValue("@oficinaorigen", Cbx_ofi_origen.Text)
        Cmd.Parameters.AddWithValue("@nomemo", Txb_memo.Text)
        Cmd.Parameters.AddWithValue("@totalcreditos", CInt(Txb_tot_cant.Text))
        Cmd.Parameters.AddWithValue("@importecop", CDec(Txb_cop_imp.Text))
        Cmd.Parameters.AddWithValue("@importercv", CDec(Txb_rcv_imp.Text))
        Cmd.Parameters.AddWithValue("@importetotal", CDec(Txb_tot_imp.Text))
        Cmd.Parameters.AddWithValue("@fechaactcirc", Dtp_acta_circ.Value)
        Cmd.Parameters.AddWithValue("@fecharecibido", Dtp_recibido.Value)
        Cmd.Parameters.AddWithValue("@fechalimite", Dtp_vencimiento.Value)
        Cmd.Parameters.AddWithValue("@sector", Txb_sector.Text)
        Cmd.Parameters.AddWithValue("@notificador", Txb_notificador.Text)
        Cmd.Parameters.AddWithValue("@docparabaja", Txb_doc_baja.Text)
        Cmd.Parameters.AddWithValue("@creditoscop", CInt(Txb_cop_cant.Text))
        Cmd.Parameters.AddWithValue("@creditosrcv", CInt(Txb_rcv_cant.Text))

        Try

            Cmd.ExecuteNonQuery()
            MsgBox("Informacion Guardada", vbInformation, "Mensaje del Sistema")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        VALIDAR_CARPETA()


    End Sub
    Public Sub Limpiar()

        Txb_reg_pat.Clear()
        Txb_dig_rp.Clear()
        Txb_raz_soc.Clear()
        Txb_sector.Clear()
        Txb_notificador.Clear()
        Txb_mat_not.Clear()
        Cbx_ofi_origen.Text = ""
        Txb_memo.Clear()
        Txb_doc_baja.Clear()
        Dtp_acta_circ.Value = Today
        Dtp_recibido.Value = Today
        Cbx_dias_mas.Text = ""
        Dtp_vencimiento.Value = Today
        Dgv_creditos.DataSource = Nothing
        Txb_cop_inicio.Clear()
        Txb_rcv_inicio.Clear()
        Txb_cop_cant.Clear()
        Txb_rcv_cant.Clear()
        Txb_tot_cant.Clear()
        Txb_cop_imp.Clear()
        Txb_rcv_imp.Clear()
        Txb_tot_imp.Clear()
        Llenagrid()
    End Sub
    Public Sub Bloquear()
        Txb_sector.Enabled = False
        Cbx_ofi_origen.Enabled = False
        Txb_memo.Enabled = False
        Txb_doc_baja.Enabled = False
        Dtp_acta_circ.Enabled = False
        Dtp_recibido.Enabled = False
        Cbx_dias_mas.Enabled = False
        Btn_guardar.Enabled = False
        Dgv_creditos.Enabled = False
        Btn_cargar_creditos.Enabled = False
        Btn_agregar_creditos.Enabled = False
        Txb_cop_inicio.Enabled = False
        Txb_rcv_inicio.Enabled = False
        Btn_guardar.Enabled = False
    End Sub



    'PDF DE CONTROL 
    Public Sub Jefe() 'se cambiara por la tabla de usuarios y cargos
        Sql = "SELECT * FROM domicilio.iniciales_jefes WHERE id_iniciales = " & 3
        Cmd = New NpgsqlCommand(Sql, Mycon)

        Try

            Dr = Cmd.ExecuteReader
            Dr.Read()
            Var_jefe = Dr.GetValue(1)
            Dr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            'Cmd.Dispose()
            ' MsgBox("Sector no tiene NL", vbCritical, "Busqueda 1")

        End Try

    End Sub
    Public Sub VALIDAR_CARPETA()

        Dim CarpetaDestino As String = ("C:\SICAD09\CONTROL NL")

        Try
            ':::Validamos si la carpeta existe
            If My.Computer.FileSystem.DirectoryExists(CarpetaDestino) Then
                Imprimir_PDF()
            Else
                ':::Si la carpeta no existe la creamos
                My.Computer.FileSystem.CreateDirectory(CarpetaDestino)
                Imprimir_PDF()
            End If
        Catch ex As Exception
            MsgBox("Error al realizar el proceso debido a: " & ex.Message)
        End Try
    End Sub 'si funciona
    Public Sub Imprimir_PDF()
        Try

            'guardar el reporte
            Dim FECHA As String = DateTime.Now.ToString("dd-MM-yyyy H-mm-ss")
            Dim filename As String = ("C:\SICAD09\CONTROL NL\documento-" & FECHA & ".pdf")
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            Dim ev As New ItsEvents 'EVENTO PARA REPETIR HEADER Y FOOTER
            PdfWriter.GetInstance(doc, file).PageEvent = ev
            'abrimos el pdf para comenzar a escribir en el, al terminar cerramos
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
            Me.Close()
        Catch ex As Exception
            'si el intento es fallido, mostrar mensaje
            MessageBox.Show(Err.Description)
            '  msgbox("no se puede generar el documento pdf.", vbcritical)
        End Try
        Limpiar()
        Bloquear()
    End Sub 'si funciona
    Public Sub Header() 'si funciona
        'imagenes del encabezado 
        oImagen = iTextSharp.text.Image.GetInstance("C:\SICAD09\membretes\izquierdo.png")
        oImagen.SetAbsolutePosition(20, 550)
        oImagen.ScalePercent(20) 'tamaño de la imagen
        doc.Add(oImagen)

        oImagen = iTextSharp.text.Image.GetInstance("C:\SICAD09\membretes\derecho.png")
        oImagen.SetAbsolutePosition(650, 550)
        oImagen.ScalePercent(8) 'tamaño de la imagen
        doc.Add(oImagen)
    End Sub 'si funciona

    Public Sub Antes_footer()
        Jefe()

        'Se asigna algunas propiedades para el diseño del PDF
        Dim tabladatos = New PdfPTable(7) With {
            .WidthPercentage = 100
        } 'declaracion de tabla con las columnas requeridas
        tabladatos.DefaultCell.BorderWidth = 0
        tabladatos.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
        tabladatos.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE

        Dim Vacio As New Phrase(" ")
        Dim Texto1 As New Phrase("FECHA DE RECEPCIÓN DE LA DOCUMENTACIÓN DEL NL: " & Today)
        Dim Texto2 As New Phrase("NOMBRE Y FIRMA DEL NL: " & Txb_notificador.Text)
        Dim Texto3 As New Phrase("NOMBRE Y FIRMA ENCARGADO DE LA MESA DE CRÉDITOS CON IMPEDIMENTO DE COBRO: " & Var_jefe)
        'Dim Texto4 As New Phrase("VARIABLE DEL USUARIO QUE IMPRIME EL FORMATO:" & "VARIABLE DE LA OFICINA DE ORIGEN")  
        Dim Derivadas As New Phrase("DERIVADAS: " & " Variables Derivadas " & " FORANEAS: " & " Variable de Foraneas ")

        Dim celltablevacio = New PdfPCell(Vacio) With {
            .Border = 0,
            .Colspan = 7,
            .HorizontalAlignment = 1 '0=Left, 1=Centre, 2=Right
        }
        Dim CellTextos1 = New PdfPCell(Texto1) With {
            .Border = 0,
            .Colspan = 7,
            .HorizontalAlignment = 0 '0=Left, 1=Centre, 2=Right
        }
        Dim CellTextos2 = New PdfPCell(Texto2) With {
            .Border = 0,
            .Colspan = 7,
            .HorizontalAlignment = 0 '0=Left, 1=Centre, 2=Right
        }
        Dim CellTextos3 = New PdfPCell(Texto3) With {
            .Border = 0,
            .Colspan = 7,
            .HorizontalAlignment = 0 '0=Left, 1=Centre, 2=Right
        }
        'Dim CellTextos4 = New PdfPCell(Texto4) With {
        '      .Border = 0,
        '    .Colspan = 7,
        '    .HorizontalAlignment = 0 '0=Left, 1=Centre, 2=Right
        '}
        Dim CellTextos5 = New PdfPCell(Derivadas) With {
            .Border = 0,
            .Colspan = 7,
            .HorizontalAlignment = 0 '0=Left, 1=Centre, 2=Right
        }

        tabladatos.AddCell(celltablevacio)
        tabladatos.AddCell(CellTextos1)
        tabladatos.AddCell(CellTextos2)
        tabladatos.AddCell(CellTextos3)
        tabladatos.AddCell(celltablevacio)
        'tabladatos.AddCell(CellTextos4)
        tabladatos.AddCell("") '1
        tabladatos.AddCell("") '2
        tabladatos.AddCell("") '3
        tabladatos.AddCell("") '4
        tabladatos.AddCell("VARIABLE DEL USUARIO QUE IMPRIME EL FORMATO:") '5
        tabladatos.AddCell("") '6
        tabladatos.AddCell(Cbx_ofi_origen.Text) '7
        tabladatos.AddCell(celltablevacio)
        tabladatos.AddCell(CellTextos5)

        tabladatos.HeaderRows = 0
        tabladatos.DefaultCell.BorderWidth = 0 'para que no tenga bordes la tabla

        doc.Add(tabladatos) 'para que se publique la tabla
    End Sub
    Public Sub Footer()
        'imagenes del pie de pagina
        oImagen = iTextSharp.text.Image.GetInstance("C:\SICAD09\membretes\abajo.png")
        oImagen.SetAbsolutePosition(60, 8)
        oImagen.ScalePercent(60) 'tamaño de la imagen
        doc.Add(oImagen)

        oImagen = iTextSharp.text.Image.GetInstance("C:\SICAD09\membretes\direccion.png")
        oImagen.SetAbsolutePosition(20, 45)
        oImagen.ScalePercent(50) 'tamaño de la imagen
        doc.Add(oImagen)
    End Sub
    Public Sub ExportarDatosPDF(ByVal document As Document)
        'se crea un objeto  PDFTABLE con el numero de columnas del DGV

        'Se asigna algunas propiedades para el diseño del PDF
        Dim datatable = New PdfPTable(7) With {
            .WidthPercentage = 100
        }
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        datatable.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE

        'se crea el texto debajo del encabezado
        Dim textovacio As New Phrase(" ")
        Dim texto As New Phrase("CONTROL DE TRABAJO DEL NOTIFICADOR-LOCALIZADOR (NL) Y/O PERSONA QUE SE DESIGNE", New iTextSharp.text.Font(Font.Name = "Arial Rounded MT Bold", 14))

        Dim celltablevacio = New PdfPCell(textovacio) With {
            .Border = 0,
            .Colspan = 7,
            .HorizontalAlignment = 1 '0=Left, 1=Centre, 2=Right
        }
        Dim celltable = New PdfPCell(texto) With {
            .Border = 0,
            .Colspan = 7,
            .HorizontalAlignment = 1 '0=Left, 1=Centre, 2=Right
            }

        datatable.AddCell(celltablevacio)
        datatable.AddCell(celltable)
        datatable.AddCell(celltablevacio)



        'se captura los titulos de la tabla misma fila diferentes celdas
        datatable.AddCell("Registro Patronal") '1
        datatable.AddCell("Nombre del patrón o sujeto obligado") '2
        datatable.AddCell("Domicilo") '3
        datatable.AddCell("Fecha máxima de verificacion de domicilio y entrevistas a vecinos") '4
        datatable.AddCell("Fecha máxima de entrevista a trabajadores") '5
        datatable.AddCell("Fecha de entrega de resultados verificacion de domicilio y entrevistas a vecinos") '6
        datatable.AddCell("Fecha de entrega entrevista a trabajadores") '7

        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        datatable.AddCell(Txb_reg_pat.Text & "-" & Txb_dig_rp.Text) '1
        datatable.AddCell(Txb_raz_soc.Text) '2
        datatable.AddCell(Txb_domicilio.Text) '3
        datatable.AddCell(Dtp_vencimiento.Value.ToShortDateString) '4
        datatable.AddCell("") '5
        datatable.AddCell("") '6
        datatable.AddCell("") '7


        'se agrega el PDFTable al documento
        'Header en el evento
        document.Add(datatable)
        Antes_footer()
        'Footer en el evento
    End Sub
    Public Class ItsEvents
        Inherits PdfPageEventHelper
        Public Overrides Sub OnStartPage(ByVal writer As iTextSharp.text.pdf.PdfWriter, ByVal document As iTextSharp.text.Document)
            'Dim ch As New Chunk("This is my Stack Overflow Header on page " & writer.PageNumber)
            'document.Add(ch)

            Dim oImagen As iTextSharp.text.Image
            'Encabezado de la pagina
            oImagen = iTextSharp.text.Image.GetInstance("C:\SICAD09\membretes\izquierdo.png")
            oImagen.SetAbsolutePosition(20, 550)
            oImagen.ScalePercent(20) 'tamaño de la imagen
            document.Add(oImagen)

            oImagen = iTextSharp.text.Image.GetInstance("C:\SICAD09\membretes\derecho.png")
            oImagen.SetAbsolutePosition(650, 550)
            oImagen.ScalePercent(8) 'tamaño de la imagen
            document.Add(oImagen)


            'imagenes del pie de pagina
            oImagen = iTextSharp.text.Image.GetInstance("C:\SICAD09\membretes\abajo.png")
            oImagen.SetAbsolutePosition(60, 8)
            oImagen.ScalePercent(60) 'tamaño de la imagen
            document.Add(oImagen)

            oImagen = iTextSharp.text.Image.GetInstance("C:\SICAD09\membretes\direccion.png")
            oImagen.SetAbsolutePosition(20, 45)
            oImagen.ScalePercent(50) 'tamaño de la imagen
            document.Add(oImagen)
        End Sub
    End Class

    Private Sub CERRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARToolStripMenuItem.Click
        Me.Close()
    End Sub












    'idinicio
    'idpatronl
    'regpat
    'digver
    'copinicio
    'rcvinicio
    'oficinaorigen
    'nomemo
    'totalcreditos
    'importecop
    'importercv
    'importetotal
    'fechaactcirc
    'fecharecibido
    'fechalimite
    'sector
    'notificador
    'docparabaja
    'creditoscop
    'creditosrcv

End Class