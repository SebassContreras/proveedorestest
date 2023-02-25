Imports MySql.Data.MySqlClient

Public Class Form1

    Private connection = New MySqlConnection
    Private connectionString As String = "server=127.0.0.1;Uid=Sebas;pwd=1234;database=testproveedores;SslMode=none;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()
            checconndb.Checked = True
            checconndb.Text = "Conectado"
        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
        End Try

        Try
            Dim query = "SELECT * FROM `proveedor`"
            Dim comando = New MySqlCommand(query, connection)
            Dim reader = comando.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    Dim n = dbProveedores.Rows.Add()
                    dbProveedores.Rows(n).Cells(0).Value = reader.GetString(0).ToString
                    dbProveedores.Rows(n).Cells(1).Value = reader.GetString(1).ToString
                    dbProveedores.Rows(n).Cells(2).Value = reader.GetString(2).ToString
                    dbProveedores.Rows(n).Cells(3).Value = reader.GetString(3).ToString
                    dbProveedores.Rows(n).Cells(4).Value = reader.GetString(4).ToString
                    dbProveedores.Rows(n).Cells(5).Value = reader.GetString(5).ToString
                End While
            Else
                Console.WriteLine("No hay Proveedores")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al buscar en la base de datos: " & ex.Message)
        End Try
        connection.Close()

    End Sub

    Private Sub ReloadTabla()
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()
            Dim query = "SELECT * FROM `proveedor`"
            Dim comando = New MySqlCommand(query, connection)
            Dim reader = comando.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    Dim n = dbProveedores.Rows.Add()
                    dbProveedores.Rows(n).Cells(0).Value = reader.GetString(0).ToString
                    dbProveedores.Rows(n).Cells(1).Value = reader.GetString(1).ToString
                    dbProveedores.Rows(n).Cells(2).Value = reader.GetString(2).ToString
                    dbProveedores.Rows(n).Cells(3).Value = reader.GetString(3).ToString
                    dbProveedores.Rows(n).Cells(4).Value = reader.GetString(4).ToString
                    dbProveedores.Rows(n).Cells(5).Value = reader.GetString(5).ToString
                End While
            Else
                Console.WriteLine("No hay Proveedores")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al buscar en la base de datos: " & ex.Message)
        End Try
    End Sub

    Private Sub AddProv_Click(sender As Object, e As EventArgs) Handles AddProv.Click

        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Dim mensajeError = ""
        If razontxt.Text = "" Then
            mensajeError = mensajeError & "Falta ingresar Razon Social " & vbLf
        End If
        If ciftxt.Text = "" Then
            mensajeError = mensajeError & "Falta ingresar Cif" & vbLf
        End If
        If cptxt.Text = "" Then
            mensajeError = mensajeError & "Falta ingresar Codigo Postal" & vbLf
        End If
        If locatxt.Text = "" Then
            mensajeError = mensajeError & "Falta ingresar Localidad" & vbLf
        End If
        If protxt.Text = "" Then
            mensajeError = mensajeError & "Falta ingresar Provincia" & vbLf
        End If
        If paistxt.Text = "" Then
            mensajeError = mensajeError & "Falta ingresar Pais" & vbLf
        End If
        If mensajeError = "" Then

            Dim query = "INSERT INTO `proveedor` (`RazonSocial`, `Cif`, `CodigoPostal`, `Localidad`, `Provincia`, `Pais`) 
                        VALUES ('" & razontxt.Text & "', '" & ciftxt.Text & "', '" & cptxt.Text & "', '" & locatxt.Text & "', '" & protxt.Text & "', '" & paistxt.Text & "');"

            Try
                Dim comando = New MySqlCommand(query, connection)
                Dim reader = comando.ExecuteReader()
                reader.Close()
                dbProveedores.Rows.Clear()
                dbProveedores.Refresh()
                ReloadTabla()
            Catch ex As Exception
                MessageBox.Show("Error al insertar en la base de datos: " & ex.Message)
            End Try
        Else
            MessageBox.Show(mensajeError)
        End If

        razontxt.Text = ""
        ciftxt.Text = ""
        cptxt.Text = ""
        locatxt.Text = ""
        protxt.Text = ""
        paistxt.Text = ""
    End Sub

    Private Sub buscarbtn_Click(sender As Object, e As EventArgs) Handles buscarbtn.Click

        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Dim where = " where 1=1 "
        If razontxt.Text <> "" Then
            where = where & " and RazonSocial like '%" & razontxt.Text & "%' "
        End If
        If ciftxt.Text <> "" Then
            where = where & " and Cif like '%" & ciftxt.Text & "%' "
        End If
        If cptxt.Text <> "" Then
            where = where & " and CodigoPostal like '%" & cptxt.Text & "%' "
        End If
        If locatxt.Text <> "" Then
            where = where & " and Localidad like '%" & locatxt.Text & "%' "
        End If
        If protxt.Text <> "" Then
            where = where & " and Provincia like '%" & protxt.Text & "%' "
        End If
        If paistxt.Text <> "" Then
            where = where & " and Pais like '%" & paistxt.Text & "%' "
        End If
        Try
            Dim query = "SELECT RazonSocial, Cif, CodigoPostal, Localidad, Provincia, Pais FROM proveedor " & where
            Dim comando = New MySqlCommand(query, connection)
            Dim reader = comando.ExecuteReader()
            dbProveedores.Rows.Clear()
            dbProveedores.Refresh()
            If reader.HasRows Then
                While reader.Read()
                    Dim n = dbProveedores.Rows.Add()
                    dbProveedores.Rows(n).Cells(0).Value = reader.GetString(0).ToString
                    dbProveedores.Rows(n).Cells(1).Value = reader.GetString(1).ToString
                    dbProveedores.Rows(n).Cells(2).Value = reader.GetString(2).ToString
                    dbProveedores.Rows(n).Cells(3).Value = reader.GetString(3).ToString
                    dbProveedores.Rows(n).Cells(4).Value = reader.GetString(4).ToString
                    dbProveedores.Rows(n).Cells(5).Value = reader.GetString(5).ToString
                End While
            Else
                Console.WriteLine("No hay Proveedores")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        razontxt.Text = ""
        ciftxt.Text = ""
        cptxt.Text = ""
        locatxt.Text = ""
        protxt.Text = ""
        paistxt.Text = ""
    End Sub
End Class
