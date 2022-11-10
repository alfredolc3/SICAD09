Imports Npgsql

Public Class Frm_102_rangos
    Public smgv, maxr1, minr2, maxr2, minr3, maxr3, minr4, maxr4, minr5 As Double
    Public Var_guardar As Integer


    Private Sub Frm_102_rangos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_anios()
    End Sub

    Public Sub Cargar_anios()
        Sql = "SELECT * FROM domicilio.sicad_rangos ORDER BY anual DESC"

        Cmd = New NpgsqlCommand(Sql, Mycon)
        Dr = Cmd.ExecuteReader

        Dim Dt As New Data.DataTable
        Dt.Load(Dr)

        Cbx_anio.DataSource = Dt
        Cbx_anio.ValueMember = "idrango"
        Cbx_anio.DisplayMember = "anual"

        Dr.Close()
    End Sub

    Private Sub Cbx_anio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_anio.SelectedIndexChanged
        Cargar_rangos()
        Calcular_rangos()
    End Sub

    Public Sub Cargar_rangos()
        Sql = "SELECT * FROM domicilio.sicad_rangos WHERE anual = '" & Cbx_anio.Text & "'"

        'MsgBox(Sql)

        Cmd = New NpgsqlCommand(Sql, Mycon)

        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()
            smgv = Dr.GetValue(2)
            Txb_smgv.Text = Format(smgv, "C2")
            Dr.Close()

        Catch ex As Exception
            Dr.Close()

            'MsgBox("Patron no encontrado, intente Buscando con el Digito Verificador")

            'MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Calcular_rangos()

        maxr1 = CDbl(smgv * 365)
        Txb_max_r1.Text = Format(maxr1, "C2")

        minr2 = (maxr1 + 0.01)
        Txb_min_r2.Text = Format(minr2, "C2")

        maxr2 = CDbl(smgv * (365 * 2))
        Txb_max_r2.Text = Format(maxr2, "C2")

        minr3 = (maxr2 + 0.01)
        Txb_min_r3.Text = Format(minr3, "C2")

        maxr3 = CDbl(smgv * (365 * 4))
        Txb_max_r3.Text = Format(maxr3, "C2")

        minr4 = (maxr3 + 0.01)
        Txb_min_r4.Text = Format(minr4, "C2")

        maxr4 = CDbl(smgv * (365 * 25))
        Txb_max_r4.Text = Format(maxr4, "C2")

        minr5 = (maxr4 + 0.01)
        Txb_min_r5.Text = Format(minr5, "C2")


    End Sub

    Private Sub Btn_nuevo_Click(sender As Object, e As EventArgs) Handles Btn_nuevo.Click
        Var_guardar = 1
        Activar_nuevo()
    End Sub

    Public Sub Activar_nuevo()
        Cbx_anio.Enabled = False
        Txb_smgv.Enabled = False
        Btn_nuevo.Visible = False
        Btn_modif.Visible = False

        Label7.Visible = True
        Txb_anio_edit.Visible = True
        Label6.Visible = True
        Txb_smgv_edit.Visible = True
        Btn_guardar.Visible = True
    End Sub

    Public Sub Activar_normal()
        Cbx_anio.Enabled = True
        Txb_smgv.Enabled = True
        Btn_nuevo.Visible = True
        Btn_modif.Visible = True

        Label7.Visible = False
        Txb_anio_edit.Visible = False
        Label6.Visible = False
        Txb_smgv_edit.Visible = False
        Btn_guardar.Visible = False
    End Sub

    Private Sub Btn_modif_Click(sender As Object, e As EventArgs) Handles Btn_modif.Click
        Var_guardar = 2
        Txb_anio_edit.Text = Cbx_anio.Text
        Txb_smgv_edit.Text = Txb_smgv.Text
        Activar_nuevo()
    End Sub

    Private Sub Btn_guardar_Click(sender As Object, e As EventArgs) Handles Btn_guardar.Click
        If Var_guardar = 1 Then
            Guardar()
        Else
            Editar()
        End If
    End Sub

    Public Sub Guardar()
        Sql = "INSERT INTO domicilio.sicad_rangos
                    (anual, smgv)
                VALUES 
                    (@anual, @smgv)"


        'MsgBox(Dtp_mov.Value) 'formato fecha y hora
        Cmd = New NpgsqlCommand(Sql, Mycon)
        Cmd.Parameters.AddWithValue("@anual", Txb_anio_edit.Text)
        Cmd.Parameters.AddWithValue("@smgv", CDbl(Txb_smgv_edit.Text))

        Try
            Cmd.ExecuteNonQuery()
            MsgBox("Nuevo Salario Minimo Agregado", vbInformation, "Mensaje del Sistema")
            Activar_normal()
            Cargar_anios()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Editar()
        Sql = "Update domicilio.sicad_rangos SET 
                 anual = '" & Txb_anio_edit.Text & "', 
                 smgv = " & CDbl(Txb_smgv_edit.Text) & "
            WHERE anual = '" & Txb_anio_edit.Text & "'"

        MsgBox(Sql)
        Cmd = New NpgsqlCommand(Sql, Mycon)

        Try
            Cmd.ExecuteNonQuery()
            MsgBox("Salario Minimo Modificado", vbInformation, "Mensaje del Sistema")
            Activar_normal()
            Cargar_anios()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class