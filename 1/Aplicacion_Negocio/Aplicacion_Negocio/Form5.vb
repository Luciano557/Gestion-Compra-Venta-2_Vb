Imports System.Data
Imports System.Data.OleDb
Public Class Ventas

    Dim cadena As New OleDbConnection
    Public conn As New OleDb.OleDbConnection
    Public conn1 As New OleDb.OleDbConnection
    Dim c, d As String
    Public comando As New OleDb.OleDbCommand
    Public comando1 As New OleDb.OleDbCommand
    Public comando2 As New OleDb.OleDbCommand
    Public adaptador As New OleDb.OleDbDataAdapter
    Public lector As OleDb.OleDbDataReader
    Dim consulta As String
    Public sql As String = ""
    Public sql1 As String = ""


    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        Try

            Timer2.Enabled = True
            Me.lblfecha.Visible = False
            Me.lblhora.Visible = False



            conn1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bd.accdb"
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bd.accdb"

            conn.Open()
            conn1.Open()

            cadena.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bd.accdb"
            cadena.Open()


        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos", MsgBoxStyle.Critical, "Advertencia")


        End Try

    End Sub



    Private Sub Mostrar()

        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "Select *From ventas"
        oda = New OleDbDataAdapter(consulta, cadena)
        ods.Tables.Add("ventas")
        oda.Fill(ods.Tables("ventas"))
        DataGridView1.DataSource = ods.Tables("ventas")


    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Mostrar()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label1.Text = Val(Label1.Text) - 1


        If Label1.Text = 0 Then

            Timer1.Enabled = False
            Mostrar()
            Label1.Text = "3"

        End If



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Label2.Text = DateTime.Now.ToString("hh:mm:ss")
        Me.Label3.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim condición As Integer


        condición = MsgBox("¿Esta seguro que desea salir de la aplicacion?", vbYesNo)
        If condición = vbYes Then
            End



        Else

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Visible = False
        Dim formConsulta As Form

        formConsulta = Menu1
        formConsulta.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        'consulta = "SELECT dia, hora FROM ventas WHERE dia='" & txtnombre.Text & "'AND contraseña='" & txtcontraseña.Text & "'"

        'comando = New OleDb.OleDbCommand(consulta, conn)
        'adaptador.SelectCommand = comando
        'lector = comando.ExecuteReader()


        Timer1.Enabled = True

        comando1.CommandType = CommandType.Text
        comando1.Connection = conn



        comando2.CommandType = CommandType.Text
        comando2.Connection = conn1








        sql = "INSERT INTO ventas (producto, marca, precio, peso, sabor, cantidad, comprador, fecha, hora) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & Label2.Text & "','" & Label3.Text & "')"
        'comando1.Parameters.AddWithValue("fecha", lblfecha.Text.ToUpper)
        'comando1.Parameters.AddWithValue("hora", lblhora.Text.ToUpper)


        comando1.CommandText = sql

        Try

            comando1.ExecuteNonQuery()



        Catch ex As Exception

            If ex.ToString.Contains("duplicate values") Then
                MsgBox("El usuario ya existe en la base de datos")

            Else
                MsgBox(ex.ToString)

            End If


        End Try



    End Sub


End Class