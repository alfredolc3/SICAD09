Imports System.IO


Public Class SICAD09
    Private Sub SICAD09_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideSubmenu()
        Conectar()
        Revision_membretes()
    End Sub
    Private Sub HideSubmenu()
        PanelIntegrarSubmenu.Visible = False
        PanelLocalizarSubmenu.Visible = False
        PanelEntradaSubmenu.Visible = False
        PanelConfiguracionSubmenu.Visible = False
    End Sub

    Private Sub ShowSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            HideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub BtnEntrada_Click(sender As Object, e As EventArgs) Handles BtnEntrada.Click
        ShowSubmenu(PanelEntradaSubmenu)
    End Sub

    Private Sub BtnLocalizar_Click(sender As Object, e As EventArgs) Handles BtnLocalizar.Click
        ShowSubmenu(PanelLocalizarSubmenu)
    End Sub

    Private Sub BtnIntegrar_Click(sender As Object, e As EventArgs) Handles BtnIntegrar.Click
        ShowSubmenu(PanelIntegrarSubmenu)
    End Sub

    Private Sub BtnConfiguracion_Click(sender As Object, e As EventArgs) Handles BtnConfiguracion.Click
        ShowSubmenu(PanelConfiguracionSubmenu)
    End Sub

    Private currenteForm As Form = Nothing

    Public Sub openChildForm(childForm As Form)
        If currenteForm IsNot Nothing Then currenteForm.Close()
        currenteForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub Btn_nuevo_nl_Click(sender As Object, e As EventArgs) Handles Btn_nuevo_nl.Click
        openChildForm(New Frm_01_nuevo_nl)
    End Sub

    Private Sub Btn_doc_nl_Click(sender As Object, e As EventArgs) Handles Btn_asignaciones.Click
        openChildForm(New Frm_02_asignacion)
    End Sub



    Private Sub Btn_usuarios_Click(sender As Object, e As EventArgs) Handles Btn_usuarios.Click
        openChildForm(New Frm_100_usuarios)
    End Sub
    Private Sub Btn_rangos_Click(sender As Object, e As EventArgs) Handles Btn_rangos.Click
        openChildForm(New Frm_102_rangos)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AboutBox1.Show()
    End Sub



    Public Sub Revision_membretes()

        Dim CarpetaDestino As String = ("C:\SICAD09\membretes")

        Try
            ':::Validamos si la carpeta existe
            If My.Computer.FileSystem.DirectoryExists(CarpetaDestino) Then
                Copiar_membretes()
            Else
                ':::Si la carpeta no existe la creamos
                My.Computer.FileSystem.CreateDirectory(CarpetaDestino)
                Copiar_membretes()
            End If
        Catch ex As Exception
            MsgBox("Error al realizar el proceso debido a: " & ex.Message)
        End Try
    End Sub

    Public Sub Copiar_membretes()
        'COPIAR EL ARCHIVO DEL PROYECTO AL EQUIPO
        Dim M_abajo As String = "C:\SICAD09\membretes\abajo"
        Dim M_derecho As String = "C:\SICAD09\membretes\derecho"
        Dim M_direccion As String = "C:\SICAD09\membretes\direccion"
        Dim M_izquierdo As String = "C:\SICAD09\membretes\izquierdo"


        Dim Path_abajo As New Bitmap(My.Resources.abajo)
        Path_abajo.Save(M_abajo + ".png", System.Drawing.Imaging.ImageFormat.Png)

        Dim Path_derecho As New Bitmap(My.Resources.derecho)
        Path_derecho.Save(M_derecho + ".png", System.Drawing.Imaging.ImageFormat.Png)

        Dim Path_izquierdo As New Bitmap(My.Resources.izquierdo)
        Path_izquierdo.Save(M_izquierdo + ".png", System.Drawing.Imaging.ImageFormat.Png)

        Dim Path_direccion As New Bitmap(My.Resources.direccion)
        Path_direccion.Save(M_direccion + ".png", System.Drawing.Imaging.ImageFormat.Png)


    End Sub

    Private Sub Btn_formato_4_Click(sender As Object, e As EventArgs) Handles Btn_formato_4.Click
        openChildForm(New Frm_03_formato_resultado_nl)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        openChildForm(New Frm_04_investigaciones_internas)
    End Sub
End Class
