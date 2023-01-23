Imports System.Data
Imports System.Data.OleDb
Public Class consulta

    Public conn As New OleDb.OleDbConnection

    Dim c, d, r As String
    Public comando As New OleDb.OleDbCommand
    Public comando1 As New OleDb.OleDbCommand
    Public comando2 As New OleDb.OleDbCommand
    Public adaptador As New OleDb.OleDbDataAdapter
    Public lector As OleDb.OleDbDataReader
    Dim consulta As String
    Public sql As String = ""
    Public sql1 As String = ""

    Private Sub consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim txt As String

        txt = TextBox1.Text

        Try


            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bd.accdb"

            conn.Open()


        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos", MsgBoxStyle.Critical, "Advertencia")


        End Try



        If TextBox1.Text = "" Then

                Button1.Visible = False

            Else
                Button1.Visible = True

            End If






    End Sub


    Friend Function ObtenerTablas(ByVal nombreInicio As String) As String()
        Dim dt As DataTable = Nothing
     
        dt = conn.GetSchema("TABLES")


        Return (From row As DataRow In dt.Rows.Cast(Of DataRow)() _
                Where CStr(row("TABLE_TYPE")) = "TABLE" AndAlso CStr(row("TABLE_NAME")) Like nombreInicio _
                Order By row("TABLE_NAME") _
                Select CStr(row("TABLE_NAME"))).ToArray()
    End Function



 


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        d = ComboBox1.Text
        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM  " & d & "  ", conn)
        Dim DS As New DataSet
        DA.Fill(DS, "d")
        DataGridView1.DataSource = DS.Tables("d")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim condición As Integer


        condición = MsgBox("¿Esta seguro que desea salir de la aplicacion?", vbYesNo)
        If condición = vbYes Then
            End



        Else

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        Me.Visible = False
        Dim formConsulta As Form

        formConsulta = Añadir
        formConsulta.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Visible = False
        Dim formConsulta As Form

        formConsulta = Menu1
        formConsulta.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = LCase$(TextBox1.Text)

        c = TextBox1.Text

        Try


            ComboBox1.DataSource = ObtenerTablas("" & c & "*")


            If ComboBox1.Text = "" Then

                Button1.Visible = False

            Else
                Button1.Visible = True

            End If
        Catch ex As Exception


            MessageBox.Show(ex.Message)
        End Try





        If TextBox1.Text = "todos" Then
            Try

                ComboBox1.DataSource = ObtenerTablas("" & r & "*")


                If ComboBox1.Text = "" Then

                    Button1.Visible = False

                Else
                    Button1.Visible = True

                End If
            Catch ex As Exception


                MessageBox.Show(ex.Message)
            End Try

        End If






    End Sub
End Class