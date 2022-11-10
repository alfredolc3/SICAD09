Imports Npgsql

Public Class Frm_02_documentos
    Public Origen As String
    Private Sub CERRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub Frm_02_documentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_integradores()
        Sin_revisar()
    End Sub

    Public Sub Cargar_integradores()
        Sql = "SELECT * FROM domicilio.sicad_integradores"

        Cmd = New NpgsqlCommand(Sql, Mycon)
        Dr = Cmd.ExecuteReader

        Dim Dt As New Data.DataTable
        Dt.Load(Dr)

        Cbx_integradores.DataSource = Dt
        Cbx_integradores.ValueMember = "idintegrador"
        Cbx_integradores.DisplayMember = "nombre"

        Dr.Close()
    End Sub

    Private Sub Txb_foraneas_TextChanged(sender As Object, e As EventArgs) Handles Txb_foraneas.TextChanged
        Try
            If Txb_foraneas.Text > 0 Then
                Lbl_integrador_asignado.Visible = True
                Cbx_integradores.Visible = True
            ElseIf Txb_foraneas.Text = "" Then
                Lbl_integrador_asignado.Visible = False
                Cbx_integradores.Visible = False
            Else
                Lbl_integrador_asignado.Visible = False
                Cbx_integradores.Visible = False
            End If
        Catch ex As Exception
            Txb_foraneas.Text = ""
            Lbl_integrador_asignado.Visible = False
            Cbx_integradores.Visible = False
        End Try

    End Sub

    Private Sub Txb_derivadas_TextChanged(sender As Object, e As EventArgs) Handles Txb_derivadas.TextChanged
        Try
            If Txb_derivadas.Text >= 0 Then

            Else
                Txb_derivadas.Text = ""
            End If
        Catch ex As Exception
            Txb_derivadas.Text = ""
        End Try

    End Sub

    Public Sub Llenagrid(Sql)

        'Sql esta definida de manera global en el archivo de conexion

        Adp = New NpgsqlDataAdapter(Sql, Mycon)
        Ds.Tables.Clear()
        Adp.Fill(Ds.Tables.Add("Tabla"))

        Me.Dgv_documentosnl.DataSource = Ds.Tables("Tabla")
        'Me.Dgv_patronesnl.Columns(0).HeaderText = "ID"
        'Me.Dgv_patronesnl.Columns(1).HeaderText = "ID PATRON"
        'Me.Dgv_patronesnl.Columns(2).HeaderText = "REGISTRO PATRONAL"
        'Me.Dgv_patronesnl.Columns(3).HeaderText = "DIGITO"
        'Me.Dgv_patronesnl.Columns(4).HeaderText = "RAZON SOCIAL"
        'Me.Dgv_patronesnl.Columns(5).HeaderText = "DOMICILIO"
        'Me.Dgv_patronesnl.Columns(6).HeaderText = "LOCALIDAD"
        'Me.Dgv_patronesnl.Columns(7).HeaderText = "CP"
        'Me.Dgv_patronesnl.Columns(8).HeaderText = "SECTOR"
        'Me.Dgv_patronesnl.Columns(9).HeaderText = "NOTIFICADOR"
        'Me.Dgv_patronesnl.Columns(10).HeaderText = "CREDITOS COP INICIO"
        'Me.Dgv_patronesnl.Columns(11).HeaderText = "CREDITOS RCV INICIO"
        'Me.Dgv_patronesnl.Columns(12).HeaderText = "OFICINA DE ORIGEN"
        'Me.Dgv_patronesnl.Columns(13).HeaderText = "NO MEMO"
        'Me.Dgv_patronesnl.Columns(14).HeaderText = "CREDITOS COP"
        'Me.Dgv_patronesnl.Columns(15).HeaderText = "IMPORTES COP"
        'Me.Dgv_patronesnl.Columns(16).HeaderText = "CREDITOS RCV"
        'Me.Dgv_patronesnl.Columns(17).HeaderText = "IMPORTES RCV"
        'Me.Dgv_patronesnl.Columns(18).HeaderText = "TOTAL DE CREDITOS"
        'Me.Dgv_patronesnl.Columns(19).HeaderText = "IMPORTE TOTAL"
        'Me.Dgv_patronesnl.Columns(20).HeaderText = "FECHA ACTA CIRCUNSTANCIADA"
        'Me.Dgv_patronesnl.Columns(21).HeaderText = "FECHA DE RECIBIDO"
        'Me.Dgv_patronesnl.Columns(22).HeaderText = "FECHA LIMITE"
        'Me.Dgv_patronesnl.Columns(23).HeaderText = "DOCUMENTO PARA BAJA"
        'Me.Dgv_patronesnl.Columns(24).HeaderText = "USUARIO"

        ''VISIBILIDAD DE COLUMNAS
        'Me.Dgv_patronesnl.Columns(0).Visible = False
        'Me.Dgv_patronesnl.Columns(1).Visible = False

        'Me.Dgv_patronesnl.Columns(5).Visible = False
        'Me.Dgv_patronesnl.Columns(6).Visible = False

        'Me.Dgv_patronesnl.Columns(7).Visible = False
        'Me.Dgv_patronesnl.Columns(9).Visible = False
        'Me.Dgv_patronesnl.Columns(10).Visible = False
        'Me.Dgv_patronesnl.Columns(11).Visible = False
        'Me.Dgv_patronesnl.Columns(12).Visible = False
        'Me.Dgv_patronesnl.Columns(13).Visible = False
        'Me.Dgv_patronesnl.Columns(14).Visible = False
        'Me.Dgv_patronesnl.Columns(15).Visible = False
        'Me.Dgv_patronesnl.Columns(16).Visible = False
        'Me.Dgv_patronesnl.Columns(17).Visible = False
        'Me.Dgv_patronesnl.Columns(18).Visible = False
        'Me.Dgv_patronesnl.Columns(19).Visible = False
        'Me.Dgv_patronesnl.Columns(20).Visible = False
        'Me.Dgv_patronesnl.Columns(21).Visible = False
        'Me.Dgv_patronesnl.Columns(22).Visible = False
        'Me.Dgv_patronesnl.Columns(23).Visible = False
        ''Me.Dgv_patronesnl.Columns(24).Visible = False

        'Me.Dgv_patronesnl.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Me.Dgv_patronesnl.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Me.Dgv_patronesnl.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



        Adp.Dispose()

    End Sub

    Public Sub Sin_revisar()
        Sql = "SELECT * FROM domicilio.vw_sicad_documentosnl WHERE completo IS NULL"

        Llenagrid(Sql)
    End Sub

    Private Sub Dgv_documentosnl_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_documentosnl.CellClick
        Dim i As Integer

        Try
            i = Dgv_documentosnl.CurrentRow.Index
            id_documentosnl.Text = Dgv_documentosnl.Item(0, i).Value()
            Txb_reg_pat.Text = Dgv_documentosnl.Item(1, i).Value()
            Txb_dig_rp.Text = Dgv_documentosnl.Item(2, i).Value()
            Txb_raz_soc.Text = Dgv_documentosnl.Item(3, i).Value()
            Txb_derivadas.Text = Dgv_documentosnl.Item(4, i).Value()
            Txb_foraneas.Text = Dgv_documentosnl.Item(5, i).Value()
            Cbx_integradores.Text = Dgv_documentosnl.Item(6, i).Value()

            Origen = Dgv_documentosnl.Item(7, i).Value()

            Select Case Origen
                Case = "OEPO"
                    Rb_oepo.Checked = True
                Case = "COBROS"
                    Rb_cobros.Checked = True
                Case = "AFILIACION"
                    Rb_afiliacion.Checked = True
                Case = "AUDITORIA"
                    Rb_auditoria.Checked = True
                Case = "CORREO"
                    Rb_correo.Checked = True
                Case = "FORANEO"
                    Rb_foraneo.Checked = True
                Case = "SINDO"
                    Rb_sindo.Checked = True
            End Select

            If Dgv_documentosnl.Item(7, i).Value() = "SI" Then
                Chb_mem_orig.Checked = True
            ElseIf Dgv_documentosnl.Item(7, i).Value() = "NO" Then
                Chb_mem_orig.Checked = False
            Else
                Chb_mem_orig.Checked = False
            End If

            If Dgv_documentosnl.Item(8, i).Value() = "SI" Then
                Chb_foto.Checked = True
            ElseIf Dgv_documentosnl.Item(8, i).Value() = "NO" Then
                Chb_foto.Checked = False
            Else
                Chb_foto.Checked = False
            End If

            If Dgv_documentosnl.Item(9, i).Value() = "SI" Then
                Chb_acta.Checked = True
            ElseIf Dgv_documentosnl.Item(9, i).Value() = "NO" Then
                Chb_acta.Checked = False
            Else
                Chb_acta.Checked = False
            End If

            If Dgv_documentosnl.Item(10, i).Value() = "SI" Then
                Chb_edo_ade_cop.Checked = True
            ElseIf Dgv_documentosnl.Item(10, i).Value() = "NO" Then
                Chb_edo_ade_cop.Checked = False
            Else
                Chb_edo_ade_cop.Checked = False
            End If

            If Dgv_documentosnl.Item(11, i).Value() = "SI" Then
                Chb_edo_ade_rcv.Checked = True
            ElseIf Dgv_documentosnl.Item(11, i).Value() = "NO" Then
                Chb_edo_ade_rcv.Checked = False
            Else
                Chb_edo_ade_rcv.Checked = False
            End If

            If Dgv_documentosnl.Item(12, i).Value() = "SI" Then
                Chb_edo_cta_cop.Checked = True
            ElseIf Dgv_documentosnl.Item(12, i).Value() = "NO" Then
                Chb_edo_cta_cop.Checked = False
            Else
                Chb_edo_cta_cop.Checked = False
            End If

            If Dgv_documentosnl.Item(13, i).Value() = "SI" Then
                Chb_edo_cta_rcv.Checked = True
            ElseIf Dgv_documentosnl.Item(13, i).Value() = "NO" Then
                Chb_edo_cta_rcv.Checked = False
            Else
                Chb_edo_cta_rcv.Checked = False
            End If

            If Dgv_documentosnl.Item(14, i).Value() = "SI" Then
                Chb_arp.Checked = True
            ElseIf Dgv_documentosnl.Item(14, i).Value() = "NO" Then
                Chb_arp.Checked = False
            Else
                Chb_arp.Checked = False
            End If

            If Dgv_documentosnl.Item(15, i).Value() = "SI" Then
                Chb_not_estrado.Checked = True
            ElseIf Dgv_documentosnl.Item(15, i).Value() = "NO" Then
                Chb_not_estrado.Checked = False
            Else
                Chb_not_estrado.Checked = False
            End If

            If Dgv_documentosnl.Item(16, i).Value() = "SI" Then
                Chb_sicofi.Checked = True
            ElseIf Dgv_documentosnl.Item(16, i).Value() = "NO" Then
                Chb_sicofi.Checked = False
            Else
                Chb_sicofi.Checked = False
            End If

            If Dgv_documentosnl.Item(17, i).Value() = "SI" Then
                Chb_mandamiento.Checked = True
            ElseIf Dgv_documentosnl.Item(17, i).Value() = "NO" Then
                Chb_mandamiento.Checked = False
            Else
                Chb_mandamiento.Checked = False
            End If

            If Dgv_documentosnl.Item(18, i).Value() = "SI" Then
                Chb_ced_liq.Checked = True
            ElseIf Dgv_documentosnl.Item(18, i).Value() = "NO" Then
                Chb_ced_liq.Checked = False
            Else
                Chb_ced_liq.Checked = False
            End If

            If Dgv_documentosnl.Item(19, i).Value() = "SI" Then
                Chb_amp_emb.Checked = True
            ElseIf Dgv_documentosnl.Item(19, i).Value() = "NO" Then
                Chb_amp_emb.Checked = False
            Else
                Chb_amp_emb.Checked = False
            End If

            If Dgv_documentosnl.Item(20, i).Value() = "SI" Then
                Chb_completo.Checked = True
            ElseIf Dgv_documentosnl.Item(20, i).Value() = "NO" Then
                Chb_completo.Checked = False
            Else
                Chb_completo.Checked = False
            End If

            Txb_devolucion.Text = Dgv_documentosnl.Item(21, i).Value()

            Dtp_devolucion.Value = Format(Dgv_documentosnl.Item(22, i).Value(), "short Date")
            id_patronesnl.Text = Dgv_documentosnl.Item(23, i).Value()

            Me.TabControl1.SelectedIndex = 1

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Chb_completo_CheckedChanged(sender As Object, e As EventArgs) Handles Chb_completo.CheckedChanged
        If Chb_completo.Checked = True Then
            Txb_devolucion.Enabled = False
            Dtp_devolucion.Enabled = False
        Else
            Txb_devolucion.Enabled = True
            Dtp_devolucion.Enabled = True
        End If
    End Sub

    Private Sub Btn_guardar_Click(sender As Object, e As EventArgs) Handles Btn_guardar.Click
        Actualizar_documentosnl()
        Guardar_inicio()
    End Sub
    Public Sub Actualizar_documentosnl()
        Dim Mem_origen, Foto, Acta, Edo_ade_cop, Edo_ade_rcv, Edo_cta_cop, Edo_cta_rcv As String
        Dim Arp, Estrados, Sicofi, Mandamiento, Ced_liq, Amp_emb, Completo As String
        Select Case True
            Case = Rb_oepo.Checked
                Origen = "OEPO"
            Case Rb_cobros.Checked
                Origen = "COBROS"
            Case Rb_afiliacion.Checked
                Origen = "AFILIACION"
            Case Rb_auditoria.Checked
                Origen = "AUDITORIA"
            Case Rb_correo.Checked
                Origen = "CORREO"
            Case Rb_foraneo.Checked
                Origen = "FORANEO"
            Case Rb_sindo.Checked
                Origen = "SINDO"
        End Select

        If Chb_mem_orig.Checked = True Then
            Mem_origen = "SI"
        Else
            Mem_origen = "NO"
        End If

        If Chb_foto.Checked = True Then
            Foto = "SI"
        Else
            Foto = "NO"
        End If

        If Chb_acta.Checked = True Then
            Acta = "SI"
        Else
            Acta = "NO"
        End If

        If Chb_edo_ade_cop.Checked = True Then
            Edo_ade_cop = "SI"
        Else
            Edo_ade_cop = "NO"
        End If

        If Chb_edo_ade_rcv.Checked = True Then
            Edo_ade_rcv = "SI"
        Else
            Edo_ade_rcv = "NO"
        End If

        If Chb_edo_cta_cop.Checked = True Then
            Edo_cta_cop = "SI"
        Else
            Edo_cta_cop = "NO"
        End If

        If Chb_edo_cta_rcv.Checked = True Then
            Edo_cta_rcv = "SI"

        Else
            Edo_cta_rcv = "NO"
        End If

        If Chb_arp.Checked = True Then
            Arp = "SI"
        Else
            Arp = "NO"
        End If

        If Chb_not_estrado.Checked = True Then
            Estrados = "SI"

        Else
            Estrados = "NO"
        End If

        If Chb_sicofi.Checked = True Then
            Sicofi = "SI"
        Else
            Sicofi = "NO"
        End If

        If Chb_mandamiento.Checked = True Then
            Mandamiento = "SI"
        Else
            Mandamiento = "NO"
        End If

        If Chb_ced_liq.Checked = True Then
            Ced_liq = "SI"
        Else
            Ced_liq = "NO"
        End If

        If Chb_amp_emb.Checked = True Then
            Amp_emb = "SI"
        Else
            Amp_emb = "NO"
        End If

        If Chb_completo.Checked = True Then
            Completo = "SI"
        Else
            Completo = "NO"
        End If



        Sql = "Update domicilio.sicad_documentosnl SET 
                 derivadas = '" & Txb_derivadas.Text & "', 
                 foraneas = '" & Txb_foraneas.Text & "', 
                 id_integrador = '" & Cbx_integradores.SelectedValue & "', 
                 oficina_origen = '" & Origen & "',  
                 origen_baja = '" & Mem_origen & "', 
                 foto = '" & Foto & "', 
                 acta = '" & Acta & "', 
                 edo_adeudo_cop = '" & Edo_ade_cop & "', 
                 edo_adeudo_rcv = '" & Edo_ade_rcv & "', 
                 eco_cuenta_cop = '" & Edo_cta_cop & "',  
                 edo_cuenta_rcv = '" & Edo_cta_rcv & "', 
                 arp = '" & Arp & "', 
                 sicofi = '" & Sicofi & "', 
                 mandamiento = '" & Mandamiento & "', 
                 cedula_liquidacion = '" & Ced_liq & "', 
                 notifiacion_estrado = '" & Estrados & "', 
                 ampliacion_embargo = '" & Amp_emb & "', 
                 completo = '" & Completo & "', 
                 devolucion = '" & Txb_devolucion.Text & "', 
                 fecha_devolucion = '" & Format(Dtp_devolucion.Value, "short Date") & "'
            WHERE iddocumentos = " & id_documentosnl.Text

        'derivadas
        'foraneas
        'id_integrador
        'oficina_origen
        'origen_baja
        'foto
        'acta
        'edo_adeudo_cop
        'edo_adeudo_rcv
        'eco_cuenta_cop
        'edo_cuenta_rcv
        'arp
        'sicofi
        'mandamiento
        'cedula_liquidacion
        'notifiacion_estrado
        'ampliacion_embargo
        'completo
        'devolucion
        'fecha_devolucion


        MsgBox(Sql)
        Cmd = New NpgsqlCommand(Sql, Mycon)


        Try
            Cmd.ExecuteNonQuery()
            MsgBox("Documentos de Patron NL Actualizado", vbInformation, "Mensaje del Sistema")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Guardar_inicio()
        If Chb_completo.Checked = True Then
            'guardar patronnl
            'guardar reg pat
            'guardar dig ver

            Sql = "INSERT INTO domicilio.sicad_documentosnl(idpatronnl,regpat,digver)
                 VALUES 
                    (@idpatronnl, @regpat, @digver)"
            'MsgBox(Sql)



            'MsgBox(Dtp_mov.Value) 'formato fecha y hora
            Cmd = New NpgsqlCommand(Sql, Mycon)
            Cmd.Parameters.AddWithValue("@idpatronnl", id_patronesnl.Text)
            Cmd.Parameters.AddWithValue("@regpat", Txb_reg_pat.Text)
            Cmd.Parameters.AddWithValue("@digver", Txb_dig_rp.Text)


            Try
                Cmd.ExecuteNonQuery()
                'MsgBox("No localizado Agregado", vbInformation, "Mensaje del Sistema")
                'pasar a la captura del localizador

                Me.Close()

                Dim resp As MsgBoxResult = MsgBox("Continuar capturando informacion del patron", MsgBoxStyle.YesNo)

                If resp = MsgBoxResult.Yes Then
                    SICAD09.openChildForm(New Frm_03_inicio)
                Else
                    Limpiar()
                    Sin_revisar()
                    Me.TabControl1.SelectedIndex = 0
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub Btn_cancelar_Click(sender As Object, e As EventArgs) Handles Btn_cancelar.Click
        Limpiar()
    End Sub
    Public Sub Limpiar()
        id_documentosnl.Text = ""
        Txb_reg_pat.Clear()
        Txb_dig_rp.Clear()
        Txb_raz_soc.Clear()
        Txb_derivadas.Clear()
        Txb_foraneas.Clear()
        Cbx_integradores.Text = ""

        Rb_oepo.Checked = False
        Rb_cobros.Checked = False
        Rb_afiliacion.Checked = False
        Rb_auditoria.Checked = False
        Rb_correo.Checked = False
        Rb_foraneo.Checked = False
        Rb_sindo.Checked = False

        Chb_mem_orig.Checked = False
        Chb_foto.Checked = False
        Chb_acta.Checked = False
        Chb_edo_ade_cop.Checked = False
        Chb_edo_ade_rcv.Checked = False
        Chb_edo_cta_cop.Checked = False
        Chb_edo_cta_rcv.Checked = False
        Chb_arp.Checked = False
        Chb_not_estrado.Checked = False
        Chb_sicofi.Checked = False
        Chb_mandamiento.Checked = False
        Chb_ced_liq.Checked = False
        Chb_amp_emb.Checked = False
        Chb_completo.Checked = False

        Txb_devolucion.Clear()
        Dtp_devolucion.Value = Format(Today, "short Date")

    End Sub

    Private Sub Cbx_integradores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_integradores.SelectedIndexChanged

    End Sub
End Class