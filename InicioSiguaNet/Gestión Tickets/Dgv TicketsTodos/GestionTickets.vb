﻿Public Class GestionTickets
    Dim conexion As Conexion = New Conexion
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        conexion.LlenarDGV(dgvTickets, "consultaTicketsClientes")
    End Sub

    Private Sub GestionTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.LlenarDGV(dgvTickets, "consultaTicketsClientes")
        imprimirLabel()
    End Sub

    Private Sub dgvTickets_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTickets.CellContentDoubleClick
        variablesGlobales.numeroIdentidad = ""
        variablesGlobales.numeroIdentidad = dgvTickets.CurrentRow.Cells(3).Value.ToString()

        Me.Close()
        InicioGestion.Show()

    End Sub

    Private Sub btnGestionar_Click(sender As Object, e As EventArgs) Handles btnGestionar.Click
        Me.Close()
        InicioGestion.Show()

    End Sub
    Private Sub TimerOcultar_Tick(sender As Object, e As EventArgs) Handles TimerOcultar.Tick
        If PanelOpciones.Height <= 104 Then
            Me.TimerOcultar.Enabled = False
        Else
            Me.PanelOpciones.Height = PanelOpciones.Height - 20
        End If
    End Sub

    Private Sub TimerMostrar_Tick(sender As Object, e As EventArgs) Handles TimerMostrar.Tick
        If PanelOpciones.Height >= 140 Then
            Me.TimerMostrar.Enabled = False
        Else
            Me.PanelOpciones.Height = PanelOpciones.Height + 20
        End If
    End Sub
    Private Sub btnGestionTickets_Click(sender As Object, e As EventArgs) Handles btnGestionTickets.Click

        If PanelOpciones.Height = 144 Then
            TimerOcultar.Enabled = True

        ElseIf PanelOpciones.Height = 104 Then
            TimerMostrar.Enabled = True

        End If


    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End

    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Me.Close()
        InicioSiguaNet.Show()
    End Sub

    Private Sub btnAvanzarMes_Click(sender As Object, e As EventArgs) Handles btnAvanzarMes.Click
        If variablesGlobales.cantMesesG = 12 Then
            variablesGlobales.cantMesesG = 1
        Else
            variablesGlobales.cantMesesG += 1
        End If
        imprimirLabel()
        HcodigoHistorial = 1
        EstadosGenerales.Show()
        HcodigoHistorial = 2
    End Sub

    Sub imprimirLabel()
        Select Case variablesGlobales.cantMesesG
            Case 1
                lblMes.Text = "Enero"
            Case 2
                lblMes.Text = "Febrero"
            Case 3
                lblMes.Text = "Marzo"
            Case 4
                lblMes.Text = "Abril"
            Case 5
                lblMes.Text = "Mayo"
            Case 6
                lblMes.Text = "Junio"
            Case 7
                lblMes.Text = "Julio"
            Case 8
                lblMes.Text = "Agosto"
            Case 9
                lblMes.Text = "Septiembre"
            Case 10
                lblMes.Text = "Octubre"
            Case 11
                lblMes.Text = "Noviembre"
            Case 12
                lblMes.Text = "Diciembre"
        End Select
    End Sub

    Private Sub btnRealizar_Click(sender As Object, e As EventArgs)
        Me.Hide()
        RealizarTickets.Show()

    End Sub

    Private Sub PanelOpciones_Paint(sender As Object, e As PaintEventArgs) Handles PanelOpciones.Paint

    End Sub
    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        Me.Close()
        FacturasTodas.Show()
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Me.Close()
        AdministracionCRUD.Show()
    End Sub
End Class