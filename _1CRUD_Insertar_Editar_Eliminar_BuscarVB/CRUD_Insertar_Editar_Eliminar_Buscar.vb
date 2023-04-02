Imports System.Data.SqlClient
Imports System.IO
Public Class CRUD_Insertar_Editar_Eliminar_Buscar
    Private Sub CRUD_Insertar_Editar_Eliminar_Buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarDatos()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListarDatos()
        TextBox3.Clear()
    End Sub
    Private Sub ListarDatos()
        Dim obj As _3Funciones = New _3Funciones()
        DataGridView1.DataSource = obj.MOSTRAR
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New Mantenimiento
        frm.Estado = _4Valores.Agregar
        frm.BNT_Guardar.Text = "Insertar"
        frm.BNT_Guardar.BackColor = Color.FromArgb(0, 139, 139)
        ListarDatos()
        frm.ShowDialog()
        ListarDatos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (DataGridView1.SelectedRows.Count > 0) Then
            Dim frm As New Mantenimiento
            frm.Estado = _4Valores.Borrar
            frm.BNT_Guardar.Text = "Eliminar"
            frm.BNT_Guardar.BackColor = Color.FromArgb(255, 0, 0)
            frm.id = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value.ToString())
            frm.TXT_Nombre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            frm.TXT_Apellido.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            frm.CMB_Tipo.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            frm.TXT_Tratamiento.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
            Dim img As Byte()
            img = DataGridView1.CurrentRow.Cells(5).Value
            Dim ms As New MemoryStream(img)
            frm.PIB_Imagen.Image = Image.FromStream(ms)
            frm.ShowDialog()
            ListarDatos()
        Else
            MessageBox.Show("Por favor seleccione una fila...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (DataGridView1.SelectedRows.Count > 0) Then
            Dim frm As New Mantenimiento
            frm.Estado = _4Valores.Editar
            frm.BNT_Guardar.Text = "Editar"
            frm.BNT_Guardar.BackColor = Color.FromArgb(238, 175, 9)
            frm.id = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value.ToString())
            frm.TXT_Nombre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            frm.TXT_Apellido.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            frm.CMB_Tipo.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            frm.TXT_Tratamiento.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()

            Dim img As Byte()
            img = DataGridView1.CurrentRow.Cells(5).Value
            Dim ms As New MemoryStream(img)
            frm.PIB_Imagen.Image = Image.FromStream(ms)
            frm.ShowDialog()
            ListarDatos()
        Else
            MessageBox.Show("Por favor seleccione una fila...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        FilterData(TextBox3.Text)
    End Sub
    Public Sub FilterData(valueToSearch As String)
        Using cnn As New SqlConnection("Server=(local);DataBase=CRUD_Example; Integrated Security=true")
            cnn.Open()
            Dim ConsultaSQL As String = "Select * from DBPacientes WHERE CONCAT(id,Nombres,Apellidos) like '%" & valueToSearch & "%'"
            Dim cmd As New SqlCommand(ConsultaSQL, cnn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            cnn.Close()
        End Using
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If (DataGridView1.SelectedRows.Count > 0) Then
            TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
            TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value
            ComboBox1.Text = DataGridView1.CurrentRow.Cells(3).Value
            TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value
            Dim img As Byte()
            img = DataGridView1.CurrentRow.Cells(5).Value
            Dim ms As New MemoryStream(img)
            PictureBox1.Image = Image.FromStream(ms)
        Else
        End If
    End Sub
End Class