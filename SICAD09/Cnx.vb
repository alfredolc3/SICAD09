
Imports Npgsql
Imports System.Configuration

'Este archivo se inicia de manera automatica cada vez que ejecutas la aplicación.
'Aquí deberías hacer el código para importar el archivo y leer las lineas y luego asignarlas a las variables
'Server, Port, Database,UserId,Password... etc.
'Y por ejemplo si quieres cambiar la conexión, solo editarás en archivo desde la misma aplicación

Module Cnx

    Public Mycon As New Npgsql.NpgsqlConnection
    Public Cmd As Npgsql.NpgsqlCommand
    Public Cmd1 As Npgsql.NpgsqlCommand
    Public Cmd2 As Npgsql.NpgsqlCommand
    Public Cmd3 As Npgsql.NpgsqlCommand
    Public Dr As Npgsql.NpgsqlDataReader
    Public Dr1 As Npgsql.NpgsqlDataReader
    Public Dr2 As Npgsql.NpgsqlDataReader
    Public Dr3 As Npgsql.NpgsqlDataReader
    Public Adp As Npgsql.NpgsqlDataAdapter
    Public Adp1 As Npgsql.NpgsqlDataAdapter
    Public Ds As New DataSet


    Public Sql As String = ""
    Public Sql1 As String = ""
    Public Sql2 As String = ""
    Public Sql3 As String = ""


    Public Sub Conectar()
        Try

            Dim Cone As String
            Cone = My.Computer.FileSystem.ReadAllText("C:\SICAD09\conexion.txt")
            Mycon = New NpgsqlConnection(Cone)

            Mycon.Open()
            If Mycon.State = ConnectionState.Open Then
                'MessageBox.Show("conectado")
            Else
                MessageBox.Show("Error de Conexion")
                Val_cnx.Show()
            End If
        Catch ex As Exception

            MessageBox.Show(Err.Description)
            Val_cnx.Show()
        End Try

    End Sub
    Public Sub Desconectar()
        Mycon.Close()
        'Return Mycon
    End Sub



End Module
