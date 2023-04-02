Imports System.IO
Public Class Mantenimiento
    Public Estado As _4Valores
    Public id As Integer = 0
    Private defaultPhoto As Image = My.Resources.userProfile
    Private Function ConvertirImg() As Byte()
        Dim ms As MemoryStream = New MemoryStream()
        PIB_Imagen.Image.Save(ms, Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.GetBuffer()
    End Function
    Private Sub BNT_Guardar_Click(sender As Object, e As EventArgs) Handles BNT_Guardar.Click
        If (TXT_Nombre.Text <> "" And TXT_Apellido.Text <> "" And CMB_Tipo.Text <> "" And TXT_Tratamiento.Text <> "") Then
            If MessageBox.Show("Se realizará el proceso, ¿Está seguro?", "Mensaje",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Pacinte_Ejecutar()
            End If
        Else
            MessageBox.Show("¡Error!, No Pueden Haber Campos Vacíos", "Llene Todos Los Campos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub Pacinte_Ejecutar()
        Try
            Select Case Estado
                Case _4Valores.Agregar
                    AGREGAR()
                    Exit Select
                Case _4Valores.Editar
                    EDITAR()
                    Exit Select
                Case _4Valores.Borrar
                    ELIMINAR()
                    Exit Select
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Public Sub AGREGAR()
        Try
            Dim obj As _3Funciones = New _3Funciones()
            Estado = _4Valores.Agregar
            obj.estado = Estado
            obj.Nombres1 = TXT_Nombre.Text
            obj.Apellidos1 = TXT_Apellido.Text
            obj.Tipo1 = CMB_Tipo.Text
            obj.Tratamiento1 = TXT_Tratamiento.Text
            obj.Imagen1 = ConvertirImg()
            obj.Grabar_PACIENTE()
            limpiar()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub EDITAR()
        Try
            Dim obj As _3Funciones = New _3Funciones()
            Estado = _4Valores.Editar
            obj.estado = Estado
            obj.Id1 = id
            obj.Nombres1 = TXT_Nombre.Text
            obj.Apellidos1 = TXT_Apellido.Text
            obj.Tipo1 = CMB_Tipo.Text
            obj.Tratamiento1 = TXT_Tratamiento.Text
            obj.Imagen1 = ConvertirImg()
            obj.Grabar_PACIENTE()
            limpiar()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ELIMINAR()
        Try
            Dim obj As _3Funciones = New _3Funciones()
            Estado = _4Valores.Borrar
            obj.estado = Estado
            obj.Id1 = id
            obj.Grabar_PACIENTE()
            limpiar()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Sub limpiar()
        TXT_Nombre.Text = ""
        TXT_Apellido.Text = ""
        CMB_Tipo.Text = ""
        TXT_Tratamiento.Text = ""
        PIB_Imagen.Image = defaultPhoto
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim openFile As OpenFileDialog = New OpenFileDialog()
        openFile.Filter = "Images(.jpg,.png)|*.png;*.jpg"
        If openFile.ShowDialog() = DialogResult.OK Then
            PIB_Imagen.Image = New Bitmap(openFile.FileName)
        End If
    End Sub
End Class