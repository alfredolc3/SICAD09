
Imports CrystalDecisions.Shared
Imports Npgsql
Public Class Frm_rep_03
    Private Sub Frm_rep_03_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_reporte()
    End Sub

    Public Sub Cargar_reporte()
        Dim ds1 As New DataSet

        Sql2 = "SELECT * FROM domicilio.patronesnl WHERE idpatronnl = @idpatronnl"
        Adp1 = New NpgsqlDataAdapter(Sql2, Mycon)
        Adp1.SelectCommand.Parameters.AddWithValue("@idpatronnl", Datos_pop.Idpatronnl)
        Adp1.Fill(ds1)
        ds1.Tables(0).TableName = "patronesnl"

        Sql = "SELECT * FROM domicilio.iniciosnl WHERE idpatronnl = @idpatronnl"
        Adp = New NpgsqlDataAdapter(Sql, Mycon)
        Adp.SelectCommand.Parameters.AddWithValue("@idpatronnl", Datos_pop.Idpatronnl)
        Adp.Fill(ds1)
        ds1.Tables(1).TableName = "iniciosnl"



        Dim reporte As New CR_03
        reporte.SetDataSource(ds1)
        CrystalReportViewer1.ReportSource = reporte
        CrystalReportViewer1.Refresh()


        'PARA GUARDAR EL PDF

        'Try
        '    Dim CrExportOptions As ExportOptions
        '    Dim CrDiskFileDestinationOptions As New _
        '    DiskFileDestinationOptions()
        '    Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
        '    CrDiskFileDestinationOptions.DiskFileName = "Z:\tickets\" & Datos_pop.ID_TICKET & ".pdf"
        '    CrExportOptions = reporte.ExportOptions
        '    With CrExportOptions
        '        .ExportDestinationType = ExportDestinationType.DiskFile
        '        .ExportFormatType = ExportFormatType.PortableDocFormat
        '        .DestinationOptions = CrDiskFileDestinationOptions
        '        .FormatOptions = CrFormatTypeOptions
        '    End With
        '    reporte.Export()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Sub
End Class