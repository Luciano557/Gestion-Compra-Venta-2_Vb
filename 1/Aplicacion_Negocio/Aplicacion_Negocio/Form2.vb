Public Class Menu1
    Private Sub Menu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click


        Dim condición As Integer


        condición = MsgBox("¿Esta seguro que desea salir de la aplicacion?", vbYesNo)
        If condición = vbYes Then
            End



        Else

        End If

    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click


        Me.Visible = False
        Dim formConsulta As Form

        formConsulta = consulta
        formConsulta.Visible = True


    End Sub

    Private Sub btnañadir_Click(sender As Object, e As EventArgs) Handles btnañadir.Click

        Me.Visible = False
        Dim formConsulta As Form

        formConsulta = Añadir
        formConsulta.Visible = True

    End Sub

    Private Sub btnventas_Click(sender As Object, e As EventArgs) Handles btnventas.Click

        Me.Visible = False
        Dim form1 As Form

        form1 = Ventas
        form1.Visible = True



    End Sub

    Private Sub btncompras_Click(sender As Object, e As EventArgs) Handles btncompras.Click


        Me.Visible = False
        Dim form63 As Form

        form63 = Form6
        form63.Visible = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class