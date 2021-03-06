﻿Imports System.ComponentModel

Public Class inicioSesion

    Dim Conexion As Conexion = New Conexion

    Private Sub inicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.abrirConexion()
        btnOcultarContra.Visible = False
        txtContrasena.PasswordChar = "●"
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        If Me.ValidateChildren And txtUsuario.Text <> String.Empty And txtContrasena.Text <> String.Empty Then

            If txtUsuario.Text = usuario And txtContrasena.Text = contrasena Then
                usuario = "?"
                contrasena = "?"
                MessageBox.Show("Esta es su primera vez iniciando el sistema, por favor cree un usuario/personal para continuar!", "Requisito de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                insertarPersonalLogin.Show()

            ElseIf Conexion.comprobarUsuario(txtUsuario.Text, Conexion.Encriptar(txtContrasena.Text)) = True Then
                '   Asignacion variable global para saber quien es el que esta accesando
                identidadPersonalEntro = txtUsuario.Text
                Bienvenida.Show()
                Me.Hide()
            Else
                MessageBox.Show("Usuario o Contraseña incorrectos!", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Introduzca Valores!", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        RecuperacionContrasena.Show()
    End Sub

    Private Sub btnMostrarContra_Click(sender As Object, e As EventArgs) Handles btnMostrarContra.Click
        btnMostrarContra.Visible = False
        btnOcultarContra.Visible = True
        txtContrasena.PasswordChar = ""
    End Sub

    Private Sub btnOcultarContra_Click(sender As Object, e As EventArgs) Handles btnOcultarContra.Click
        btnOcultarContra.Visible = False
        btnMostrarContra.Visible = True
        txtContrasena.PasswordChar = "●"
    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs) Handles txtUsuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtContrasena_Validating(sender As Object, e As CancelEventArgs) Handles txtContrasena.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        ToolTip1.SetToolTip(txtUsuario, "Introduzca el numero de identidad")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContrasena_MouseHover(sender As Object, e As EventArgs) Handles txtContrasena.MouseHover
        ToolTip1.SetToolTip(txtContrasena, "Introduzca su contrasña")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblOlvideContra.LinkClicked
        RecuperacionContrasena.Show()

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub
End Class