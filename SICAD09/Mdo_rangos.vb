Imports Npgsql

Module Mdo_rangos
    Public Rango, Creditos As Integer

    Public smgv, maxr1, minr2, maxr2, minr3, maxr3, minr4, maxr4, minr5, Importe As Double
    Public Function Evaluar_rango(anio, Monto)
        'MsgBox(anio)
        'MsgBox(Monto)

        Sql = "SELECT * FROM domicilio.sicad_rangos WHERE anual = '" & anio & "'"

        'MsgBox(Sql)

        Cmd = New NpgsqlCommand(Sql, Mycon)

        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()
            smgv = Dr.GetValue(2)
            '   MsgBox(smgv)
            Dr.Close()

        Catch ex As Exception
            Dr.Close()
            'MsgBox("Patron no encontrado, intente Buscando con el Digito Verificador")
            'MsgBox(ex.ToString)
        End Try


        maxr1 = CDbl(smgv * 365)
        'MsgBox(maxr1)

        minr2 = (maxr1 + 0.01)
        maxr2 = CDbl(smgv * (365 * 2))
        'MsgBox(minr2 & "-" & maxr2)

        minr3 = (maxr2 + 0.01)
        maxr3 = CDbl(smgv * (365 * 4))
        'MsgBox(minr3 & "-" & maxr3)

        minr4 = (maxr3 + 0.01)
        maxr4 = CDbl(smgv * (365 * 25))
        'MsgBox(minr4 & "-" & maxr4)

        minr5 = (maxr4 + 0.01)
        'MsgBox(minr5)


        If Monto <= maxr1 Then
            Rango = 1

        ElseIf Monto >= minr2 And Monto <= maxr2 Then
            Rango = 2

        ElseIf Monto >= minr3 And Monto <= maxr3 Then
            Rango = 3

        ElseIf Monto >= minr4 And Monto <= maxr4 Then
            Rango = 4
        Else
            Rango = 5
        End If

        Return (Rango)
    End Function

    Public Function Creditos_COP(RP)
        Sql = "SELECT 
                COUNT(patron) AS creditos
               FROM
	               domicilio.vw_ultimo_rale_cop
               WHERE
	               patron = '" & RP & "' AND td <> '00'"
        'MsgBox(Sql)

        Cmd = New NpgsqlCommand(Sql, Mycon)

        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()
            Creditos = Dr.GetValue(0)
            '   MsgBox(smgv)
            Dr.Close()

        Catch ex As Exception
            Dr.Close()
            'MsgBox("Patron no encontrado, intente Buscando con el Digito Verificador")
            'MsgBox(ex.ToString)
        End Try


        Return (Creditos)
    End Function
    Public Function Importe_COP(RP)
        Sql = "SELECT 
               SUM(importe) As importe
               FROM
	               domicilio.vw_ultimo_rale_cop
               WHERE
	               patron = '" & RP & "' AND td <> '00'"

        'MsgBox(Sql)

        Cmd = New NpgsqlCommand(Sql, Mycon)

        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()
            Importe = Dr.GetValue(0)
            '   MsgBox(smgv)
            Dr.Close()

        Catch ex As Exception
            Dr.Close()
            'MsgBox("Patron no encontrado, intente Buscando con el Digito Verificador")
            'MsgBox(ex.ToString)
        End Try

        Return (Importe)
    End Function

    Public Function Creditos_RCV(RP)
        Sql = "SELECT 
                COUNT(patron) AS creditos
               FROM
	               domicilio.vw_ultimo_rale_rcv
               WHERE
	               patron = '" & RP & "' AND td <> '00'"
        'MsgBox(Sql)

        Cmd = New NpgsqlCommand(Sql, Mycon)

        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()
            Creditos = Dr.GetValue(0)
            '   MsgBox(smgv)
            Dr.Close()

        Catch ex As Exception
            Dr.Close()
            'MsgBox("Patron no encontrado, intente Buscando con el Digito Verificador")
            'MsgBox(ex.ToString)
        End Try


        Return (Creditos)
    End Function
    Public Function Importe_RCV(RP)
        Sql = "SELECT 
               SUM(importe) As importe
               FROM
	               domicilio.vw_ultimo_rale_rcv
               WHERE
	               patron = '" & RP & "' AND td <> '00'"

        'MsgBox(Sql)

        Cmd = New NpgsqlCommand(Sql, Mycon)

        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()
            Importe = Dr.GetValue(0)
            '   MsgBox(smgv)
            Dr.Close()

        Catch ex As Exception
            Dr.Close()
            'MsgBox("Patron no encontrado, intente Buscando con el Digito Verificador")
            'MsgBox(ex.ToString)
        End Try

        Return (Importe)
    End Function

    Public Function Creditos_TOT(RP)
        Sql = "SELECT 
                COUNT(patron) AS creditos
               FROM
	               domicilio.vw_ultimo_rale
               WHERE
	               patron = '" & RP & "' AND td <> '00'"
        'MsgBox(Sql)

        Cmd = New NpgsqlCommand(Sql, Mycon)

        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()
            Creditos = Dr.GetValue(0)
            '   MsgBox(smgv)
            Dr.Close()

        Catch ex As Exception
            Dr.Close()
            'MsgBox("Patron no encontrado, intente Buscando con el Digito Verificador")
            'MsgBox(ex.ToString)
        End Try


        Return (Creditos)
    End Function
    Public Function Importe_TOT(RP)
        Sql = "SELECT 
               SUM(importe) As importe
               FROM
	               domicilio.vw_ultimo_rale
               WHERE
	               patron = '" & RP & "' AND td <> '00'"

        'MsgBox(Sql)

        Cmd = New NpgsqlCommand(Sql, Mycon)

        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()
            Importe = Dr.GetValue(0)
            '   MsgBox(smgv)
            Dr.Close()

        Catch ex As Exception
            Dr.Close()
            'MsgBox("Patron no encontrado, intente Buscando con el Digito Verificador")
            'MsgBox(ex.ToString)
        End Try

        Return (Importe)
    End Function

    Public Function Marcas_rb()

    End Function
End Module
