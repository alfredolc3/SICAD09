Imports Npgsql

Public Class Frm_04_investigaciones_internas

    Public Marca As String

    Private Sub Frm_04_investigaciones_internas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'BOTONES
    'CARGAR DATAGRID
    Public Sub Llenagrid(sql)
        'Sql esta definida de manera global en el archivo de conexion

        Try
            Adp = New NpgsqlDataAdapter(sql, Mycon)
            Ds.Tables.Clear()
            Adp.Fill(Ds.Tables.Add("Tabla"))

            Me.Dgv_inv_int.DataSource = Ds.Tables("Tabla")
            Me.Dgv_inv_int.Columns(0).HeaderText = "ID"
            Me.Dgv_inv_int.Columns(1).HeaderText = "ID PATRON NL"
            Me.Dgv_inv_int.Columns(2).HeaderText = "REGISTRO PATRONAL"
            Me.Dgv_inv_int.Columns(3).HeaderText = "DIG VER"
            Me.Dgv_inv_int.Columns(4).HeaderText = "RAZON SOCIAL"
            Me.Dgv_inv_int.Columns(5).HeaderText = "ACTIVIDAD"
            Me.Dgv_inv_int.Columns(6).HeaderText = "DOMICILIO"
            Me.Dgv_inv_int.Columns(7).HeaderText = "LOCALIDAD"
            Me.Dgv_inv_int.Columns(8).HeaderText = "CP"
            Me.Dgv_inv_int.Columns(9).HeaderText = "DOMICILIO A VERIFICAR"
            Me.Dgv_inv_int.Columns(10).HeaderText = "ASIGNACION"
            Me.Dgv_inv_int.Columns(11).HeaderText = "MAXIMA RESPUESTA"

            Me.Dgv_inv_int.Columns(12).HeaderText = "FECHA RESPUESTA"
            Me.Dgv_inv_int.Columns(13).HeaderText = "RESULTADO"
            Me.Dgv_inv_int.Columns(14).HeaderText = "RESPUESTA"

            Me.Dgv_inv_int.Columns(15).HeaderText = "VECINO 1"
            Me.Dgv_inv_int.Columns(16).HeaderText = "DOMICILIO 1"
            Me.Dgv_inv_int.Columns(17).HeaderText = "RESULTADO 1"
            Me.Dgv_inv_int.Columns(18).HeaderText = "RESPUESTA 1"

            Me.Dgv_inv_int.Columns(19).HeaderText = "VECINO 2"
            Me.Dgv_inv_int.Columns(20).HeaderText = "DOMICILIO 2"
            Me.Dgv_inv_int.Columns(21).HeaderText = "RESULTADO 2"
            Me.Dgv_inv_int.Columns(22).HeaderText = "RESPUESTA 2"

            Me.Dgv_inv_int.Columns(23).HeaderText = "VECINO 3"
            Me.Dgv_inv_int.Columns(24).HeaderText = "DOMICILIO 3"
            Me.Dgv_inv_int.Columns(25).HeaderText = "RESULTADO 3"
            Me.Dgv_inv_int.Columns(26).HeaderText = "RESPUESTA 3"

            Me.Dgv_inv_int.Columns(27).HeaderText = "ID NL"

            ''VISIBILIDAD DE COLUMNAS
            Me.Dgv_inv_int.Columns(0).Visible = False
            Me.Dgv_inv_int.Columns(1).Visible = False
            Me.Dgv_inv_int.Columns(27).Visible = False

            'Me.Dgv_patrones_asignados.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Adp.Dispose()
    End Sub
    Public Sub Llenagrid_todos()
        Sql = "SELECT * FROM domicilio.vw_sicad_ver_dom WHERE idnotiflocal = " & idnotiflocal
        Llenagrid(Sql)
        'Lbl_titulo.Text = "Todos los Patrones"
    End Sub


    'ACCIONES
    Private Sub Rb_pos1_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos1.CheckedChanged
        If Rb_pos1.Checked = True Then
            Txb_res1.Clear()
            Txb_res1.Enabled = True
        Else
            Txb_res1.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res1.Enabled = False
        End If
    End Sub

    Private Sub Rb_pos2_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos2.CheckedChanged
        If Rb_pos2.Checked = True Then
            Txb_res2.Clear()
            Txb_res2.Enabled = True
        Else
            Txb_res2.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res2.Enabled = False
        End If
    End Sub

    Private Sub Rb_pos3_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos3.CheckedChanged
        If Rb_pos3.Checked = True Then
            Txb_res3.Clear()
            Txb_res3.Enabled = True
        Else
            Txb_res3.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res3.Enabled = False
        End If
    End Sub

    Private Sub Rb_pos4_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos4.CheckedChanged
        If Rb_pos4.Checked = True Then
            Txb_res4.Clear()
            Txb_res4.Enabled = True
        Else
            Txb_res4.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res4.Enabled = False
        End If
    End Sub

    Private Sub Rb_pos5_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos5.CheckedChanged
        If Rb_pos1.Checked = True Then
            Txb_res5.Clear()
            Txb_res5.Enabled = True
        Else
            Txb_res5.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res5.Enabled = False
        End If
    End Sub

    Private Sub Rb_pos6_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos6.CheckedChanged
        If Rb_pos6.Checked = True Then
            Txb_res6.Clear()
            Txb_res6.Enabled = True
        Else
            Txb_res6.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res6.Enabled = False
        End If
    End Sub

    Private Sub Rb_pos7_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos7.CheckedChanged
        If Rb_pos7.Checked = True Then
            Txb_res7.Clear()
            Txb_res7.Enabled = True
        Else
            Txb_res7.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res7.Enabled = False
        End If
    End Sub

    Private Sub Rb_pos8_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos8.CheckedChanged
        If Rb_pos8.Checked = True Then
            Txb_res8.Clear()
            Txb_res8.Enabled = True
        Else
            Txb_res8.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res8.Enabled = False
        End If
    End Sub

    Private Sub Rb_pos9_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos9.CheckedChanged
        If Rb_pos9.Checked = True Then
            Txb_res9.Clear()
            Txb_res9.Enabled = True
        Else
            Txb_res9.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res9.Enabled = False
        End If
    End Sub

    Private Sub Rb_pos10_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos10.CheckedChanged
        If Rb_pos10.Checked = True Then
            Txb_res10.Clear()
            Txb_res10.Enabled = True
        Else
            Txb_res10.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res10.Enabled = False
        End If
    End Sub

    Private Sub Rb_pos11_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos11.CheckedChanged
        If Rb_pos11.Checked = True Then
            Txb_res11.Clear()
            Txb_res11.Enabled = True
        Else
            Txb_res11.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res11.Enabled = False
        End If
    End Sub

    Private Sub Rb_pos12_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos12.CheckedChanged
        If Rb_pos12.Checked = True Then
            Txb_res12.Clear()
            Txb_res12.Enabled = True
        Else
            Txb_res12.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res12.Enabled = False
        End If
    End Sub

    Private Sub Rb_pos13_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos13.CheckedChanged
        If Rb_pos13.Checked = True Then
            Txb_res13.Clear()
            Txb_res13.Enabled = True
        Else
            Txb_res13.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res13.Enabled = False
        End If
    End Sub

    Private Sub Rb_pos14_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos14.CheckedChanged
        If Rb_pos14.Checked = True Then
            Txb_res14.Clear()
            Txb_res14.Enabled = True
        Else
            Txb_res14.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res14.Enabled = False
        End If
    End Sub

    Private Sub Rb_pos15_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos15.CheckedChanged
        If Rb_pos15.Checked = True Then
            Txb_res15.Clear()
            Txb_res15.Enabled = True
        Else
            Txb_res15.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res15.Enabled = False
        End If
    End Sub

    Private Sub Rb_pos16_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_pos16.CheckedChanged
        If Rb_pos16.Checked = True Then
            Txb_res16.Clear()
            Txb_res16.Enabled = True
        Else
            Txb_res16.Text = "SIN INDICIOS DE LOCALIZACION"
            Txb_res16.Enabled = False
        End If
    End Sub
End Class