Module funcionesdb
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=semana1_Datos.accdb;Persist Security Info=False")

    Public Sub conectarse()

        Try
            conn.Open()
            MsgBox("Conexion exitosa")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
