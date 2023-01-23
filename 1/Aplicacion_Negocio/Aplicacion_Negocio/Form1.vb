Imports System.Data
Imports System.Data.OleDb
Public Class Inicio_de_Sesion1
    Public conn As New OleDb.OleDbConnection
    Public conn1 As New OleDb.OleDbConnection
    Public comando As New OleDb.OleDbCommand
    Public comando1 As New OleDb.OleDbCommand
    Public comando2 As New OleDb.OleDbCommand
    Public comando3 As New OleDb.OleDbCommand
    Public adaptador As New OleDb.OleDbDataAdapter
    Public lector As OleDb.OleDbDataReader
    Public adaptador1 As New OleDb.OleDbDataAdapter
    Public lector1 As OleDb.OleDbDataReader
    Dim consulta As String
    Dim consulta1 As String
    Public sql As String = ""
    Public sql1 As String = ""

    Private Sub Inicio_de_Sesion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load





        Try
            Timer1.Enabled = True
            Me.lblfecha.Visible = False
            Me.lblhora.Visible = False
            Me.txtintento.Visible = False

            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bd1.accdb"



            conn.Open()



        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos", MsgBoxStyle.Critical, "Advertencia")


        End Try


    End Sub



    Private Sub btnsesion_Click(sender As Object, e As EventArgs) Handles btnsesion.Click





        Dim acceso As Boolean
        Dim intentos As Double
        Dim nombre As String = ""



        consulta = "SELECT nombre, contraseña FROM cuentasnormales WHERE nombre='" & txtnombre.Text & "'AND contraseña='" & txtcontraseña.Text & "'"

        comando = New OleDb.OleDbCommand(consulta, conn)
        adaptador.SelectCommand = comando
        lector = comando.ExecuteReader()











        comando2.CommandType = CommandType.Text
        comando2.Connection = conn
        comando1.CommandType = CommandType.Text
        comando1.Connection = conn


        acceso = False
        intentos = Val(txtcuenta.Text)



        If acceso = False Then
            If lector.HasRows = False Then
                MsgBox("Usuario o Contraseña incorrecto, le quedan " & intentos - 1 & " intentos", MsgBoxStyle.Critical, "Usuario o Contraseña incorrectos")
                intentos = intentos - 1

                txtintento.Text = intentos







            Else
                txtintento.Text = intentos






                acceso = True











                sql = "INSERT INTO tablainiciodesesion (nombre, contraseña, fecha, hora, intentosRestantes)" & Chr(13) & "VALUES(txtnombre, txtcontraseña, txtfecha, txthora, txtintento)"


                comando1.Parameters.AddWithValue("nombre", txtnombre.Text.ToUpper)
                comando1.Parameters.AddWithValue("contraseña", txtcontraseña.Text.ToUpper)
                comando1.Parameters.AddWithValue("fecha", lblfecha.Text.ToUpper)
                comando1.Parameters.AddWithValue("hora", lblhora.Text.ToUpper)
                comando1.Parameters.AddWithValue("intentosRestantes", txtintento.Text.ToUpper)





                comando1.CommandText = sql

                Dim formMenu As Form

                formMenu = Menu1
                formMenu.Visible = True
                Me.Visible = False

                Try

                    comando1.ExecuteNonQuery()



                Catch ex As Exception

                    If ex.ToString.Contains("duplicate values") Then
                        MsgBox("El usuario ya existe en la base de datos")

                    Else
                        MsgBox(ex.ToString)

                    End If


                End Try

                vaciar_focalizar()








            End If

        End If




        'msg box fallo 
        If (intentos = 0) And (acceso = False) Then

            sql1 = "INSERT INTO tablainiciodesesionfallido (nombre, contraseña, fecha, hora, intentosRestantes)" & Chr(13) & "VALUES(txtnombre, txtcontraseña, txtfecha, txthora, txtintento)"


            comando2.Parameters.AddWithValue("nombre", txtnombre.Text.ToUpper)
            comando2.Parameters.AddWithValue("contraseña", txtcontraseña.Text.ToUpper)
            comando2.Parameters.AddWithValue("fecha", lblfecha.Text.ToUpper)
            comando2.Parameters.AddWithValue("hora", lblhora.Text.ToUpper)
            comando2.Parameters.AddWithValue("intentosRestantes", txtintento.Text.ToUpper)

            comando2.CommandText = sql1




            Try

                comando2.ExecuteNonQuery()



            Catch ex As Exception

                If ex.ToString.Contains("duplicate values") Then
                    MsgBox("El usuario ya existe en la base de datos")

                Else
                    MsgBox(ex.ToString)

                End If


            End Try
            MessageBox.Show("Has ingresado la contraseña incorrectamente mas de 3 veces, la aplicacion se cerrara", "Inicio de Sesion Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            vaciar_focalizar()
            Me.Close()






        End If
        txtcuenta.Text = intentos


















    End Sub







    Private Sub vaciar_focalizar()
        txtnombre.Clear()
        txtcontraseña.Clear()
        txtnombre.Focus()


    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click

        Dim condición As Integer


        condición = MsgBox("¿Esta seguro que desea salir de la aplicacion?", vbYesNo)
        If condición = vbYes Then
            Me.Close()


        Else

        End If



    End Sub




















    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.lblhora.Text = DateTime.Now.ToString("hh:mm:ss")
        Me.lblfecha.Text = DateTime.Now.ToLongDateString()

    End Sub

End Class

