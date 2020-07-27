﻿Public Class FacturasTodas
    Dim Conexion As Conexion = New Conexion
    Private Sub FacturasTodas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.LlenarDGV(dgvFactuTodas, "select f.idFactura as 'ID Factura', f.numeroIdentidadC as 'Numero Identidad', CONCAT(dp.nombres, ' ', dp.primerApellido, ' ', dp.segundoApellido) as 'Nombre', 
			pli.nombrePaquete as 'Nombre Paquete', pli.precio as 'Precio', f.fechaPago, f.mesPago as 'Mes Pago'  from FACTURA f
			inner join CLIENTES cl on f.numeroIdentidadC = cl.numeroIdentidad
			inner join DATOS_PERSONAS dp on cl.numeroIdentidad = dp.numeroIdentidad
			inner join PLANES_INTERNET pli on cl.idPaquete = pli.idPaquete where cl.estadoC <> 'Eliminado'")
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
		Conexion.LlenarDGV(dgvFactuTodas, "select f.idFactura as 'ID Factura', f.numeroIdentidadC as 'Numero Identidad', CONCAT(dp.nombres, ' ', dp.primerApellido, ' ', dp.segundoApellido) as 'Nombre', 
			pli.nombrePaquete as 'Nombre Paquete', pli.precio as 'Precio', f.fechaPago, f.mesPago as 'Mes Pago'  from FACTURA f
			inner join CLIENTES cl on f.numeroIdentidadC = cl.numeroIdentidad
			inner join DATOS_PERSONAS dp on cl.numeroIdentidad = dp.numeroIdentidad
			inner join PLANES_INTERNET pli on cl.idPaquete = pli.idPaquete where cl.estadoC <> 'Eliminado'")
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Close()
	End Sub

	Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
		Me.Close()
		InicioSiguaNet.Show()

	End Sub

	Private Sub btnGestionTickets_Click(sender As Object, e As EventArgs) Handles btnGestionTickets.Click
		Me.Close()
		GestionTickets.Show()
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

    Private Sub btnEstadoFinanciero_Click(sender As Object, e As EventArgs) Handles btnEstadoFinanciero.Click
        'Por mientras
        If PanelOpciones.Height = 144 Then
            TimerOcultar.Enabled = True

        ElseIf PanelOpciones.Height = 104 Then
            TimerMostrar.Enabled = True

        End If

        'If (GradientPanel.Height = 55) Then

        '    GradientPanel.Visible = False
        '    GradientPanel.Height = 105
        '    PanelOpciones.Height = 108
        '    TransMostrar.Show(GradientPanel)

        'Else

        '    GradientPanel.Visible = False
        '    GradientPanel.Height = 55
        '    PanelOpciones.Height = 58
        '    TransOcultar.Show(GradientPanel)

        'End If
    End Sub
End Class