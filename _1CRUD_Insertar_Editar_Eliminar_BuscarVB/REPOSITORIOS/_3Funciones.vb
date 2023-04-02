Imports System.Data.SqlClient
Public Class _3Funciones
    Inherits _2RepositorioMaestro
    Public estado As _4Valores

    ''''Paciente 
    Private Id As Integer
    Private Nombres As String
    Private Apellidos As String
    Private Tipo As String
    Private Tratamiento As String
    Private Imagen As Byte()

#Region "GET - SET "
    Public Property Id1 As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property

    Public Property Nombres1 As String
        Get
            Return Nombres
        End Get
        Set(value As String)
            Nombres = value
        End Set
    End Property

    Public Property Apellidos1 As String
        Get
            Return Apellidos
        End Get
        Set(value As String)
            Apellidos = value
        End Set
    End Property

    Public Property Tipo1 As String
        Get
            Return Tipo
        End Get
        Set(value As String)
            Tipo = value
        End Set
    End Property

    Public Property Tratamiento1 As String
        Get
            Return Tratamiento
        End Get
        Set(value As String)
            Tratamiento = value
        End Set
    End Property

    Public Property Imagen1 As Byte()
        Get
            Return Imagen
        End Get
        Set(value As Byte())
            Imagen = value
        End Set
    End Property
#End Region

    Public Sub INSERTAR()
        Dim TransactSQL As String = (" insert into DBPacientes values (@Nombres, @Apellidos, @Tipo, @Tratamiento, @Imagen)")
        parametros = New List(Of SqlParameter)()
        parametros.Add(New SqlParameter("@Nombres", Nombres1))
        parametros.Add(New SqlParameter("@Apellidos", Apellidos1))
        parametros.Add(New SqlParameter("@Tipo", Tipo1))
        parametros.Add(New SqlParameter("@Tratamiento", Tratamiento1))
        parametros.Add(New SqlParameter("@Imagen", Imagen1))
        ExecuteNonQuery(TransactSQL)
    End Sub

    Public Sub EDITAR()
        Dim TransactSQL As String = (" UPDATE DBPacientes SET Nombres=@Nombres, Apellidos=@Apellidos, Tipo=@Tipo, Tratamiento=@Tratamiento, Imagen=@Imagen WHERE Id = @Id")
        parametros = New List(Of SqlParameter)()
        parametros.Add(New SqlParameter("@Nombres", Nombres1))
        parametros.Add(New SqlParameter("@Apellidos", Apellidos1))
        parametros.Add(New SqlParameter("@Tipo", Tipo1))
        parametros.Add(New SqlParameter("@Tratamiento", Tratamiento1))
        parametros.Add(New SqlParameter("@Imagen", Imagen1))
        parametros.Add(New SqlParameter("@Id", Id1))
        ExecuteNonQuery(TransactSQL)
    End Sub

    Public Sub ELIMINAR()
        Dim TrsnsactSQL As String = (" DELETE FROM DBPacientes WHERE Id = @Id")
        parametros = New List(Of SqlParameter)()
        parametros.Add(New SqlParameter("@Id", Id1))
        ExecuteNonQuery(TrsnsactSQL)
    End Sub

    Public Function MOSTRAR() As DataTable
        Dim TransactSQL As String = ("Select * from DBPacientes")
        Return ExecuteReader2(TransactSQL)
    End Function
    Public Sub Grabar_PACIENTE()
        Try
            Select Case estado
                Case _4Valores.Agregar
                    INSERTAR()
                    MessageBox.Show("Paciente grabado con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Select
                Case _4Valores.Editar
                    EDITAR()
                    MessageBox.Show("Paciente editado con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Select
                Case _4Valores.Borrar
                    ELIMINAR()
                    MessageBox.Show("Paciente borrado con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Select
            End Select
        Catch ex As Exception
        End Try
    End Sub
End Class
