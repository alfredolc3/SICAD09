Imports System.IO
Imports System.Text

Public Class Val_cnx

    Public server, port, database, user, psw As String

    Private Sub Val_cnx_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        server = txb_server.Text
        port = txb_port.Text
        database = txb_db.Text
        user = txb_user.Text
        psw = txb_pasw.Text


        Dim path As String = "C:\SICAD09\conexion.txt"
        Directory.CreateDirectory(path:="C:\SICAD09\")

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("Server=" & server & ";Port=" & port & ";Database=" & database & ";UserId=" & user & ";Password=" & psw)
        fs.Write(info, 0, info.Length)
        fs.Close()

        Conectar()
        Me.Close()
    End Sub
End Class