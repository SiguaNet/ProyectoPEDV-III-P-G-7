﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionTickets
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionTickets))
        Me.PanelOpciones = New System.Windows.Forms.Panel()
        Me.btnRealizar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGestionar = New System.Windows.Forms.Button()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.btnRecursos = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnEstadoFinanciero = New System.Windows.Forms.Button()
        Me.btnGestionTickets = New System.Windows.Forms.Button()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.btnAvanzarMes = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.dgvTickets = New System.Windows.Forms.DataGridView()
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.TimerOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.PanelOpciones.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelContenido.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelOpciones
        '
        Me.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelOpciones.Controls.Add(Me.btnRealizar)
        Me.PanelOpciones.Controls.Add(Me.Panel1)
        Me.PanelOpciones.Controls.Add(Me.btnGestionar)
        Me.PanelOpciones.Controls.Add(Me.btnPersonal)
        Me.PanelOpciones.Controls.Add(Me.btnActualizar)
        Me.PanelOpciones.Controls.Add(Me.BtnClientes)
        Me.PanelOpciones.Controls.Add(Me.btnRecursos)
        Me.PanelOpciones.Controls.Add(Me.btnInventario)
        Me.PanelOpciones.Controls.Add(Me.btnEstadoFinanciero)
        Me.PanelOpciones.Controls.Add(Me.btnGestionTickets)
        Me.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOpciones.Location = New System.Drawing.Point(0, 0)
        Me.PanelOpciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelOpciones.Name = "PanelOpciones"
        Me.PanelOpciones.Size = New System.Drawing.Size(1377, 128)
        Me.PanelOpciones.TabIndex = 0
        '
        'btnRealizar
        '
        Me.btnRealizar.Location = New System.Drawing.Point(535, 135)
        Me.btnRealizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRealizar.Name = "btnRealizar"
        Me.btnRealizar.Size = New System.Drawing.Size(176, 34)
        Me.btnRealizar.TabIndex = 19
        Me.btnRealizar.Text = "Realizar"
        Me.btnRealizar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1377, 50)
        Me.Panel1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Gestión de tickets"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(1319, 2)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(43, 42)
        Me.btnCerrar.TabIndex = 17
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnGestionar
        '
        Me.btnGestionar.Location = New System.Drawing.Point(363, 135)
        Me.btnGestionar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestionar.Name = "btnGestionar"
        Me.btnGestionar.Size = New System.Drawing.Size(156, 34)
        Me.btnGestionar.TabIndex = 16
        Me.btnGestionar.Text = "Gestionar"
        Me.btnGestionar.UseVisualStyleBackColor = True
        '
        'btnPersonal
        '
        Me.btnPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPersonal.ForeColor = System.Drawing.Color.White
        Me.btnPersonal.Location = New System.Drawing.Point(887, 55)
        Me.btnPersonal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(191, 54)
        Me.btnPersonal.TabIndex = 12
        Me.btnPersonal.Text = "Personal"
        Me.btnPersonal.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(191, 135)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(156, 34)
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClientes.ForeColor = System.Drawing.Color.White
        Me.BtnClientes.Location = New System.Drawing.Point(121, 54)
        Me.BtnClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(187, 53)
        Me.BtnClientes.TabIndex = 14
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'btnRecursos
        '
        Me.btnRecursos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRecursos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRecursos.ForeColor = System.Drawing.Color.White
        Me.btnRecursos.Location = New System.Drawing.Point(1083, 55)
        Me.btnRecursos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRecursos.Name = "btnRecursos"
        Me.btnRecursos.Size = New System.Drawing.Size(191, 55)
        Me.btnRecursos.TabIndex = 13
        Me.btnRecursos.Text = "Recursos"
        Me.btnRecursos.UseVisualStyleBackColor = False
        '
        'btnInventario
        '
        Me.btnInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInventario.ForeColor = System.Drawing.Color.White
        Me.btnInventario.Location = New System.Drawing.Point(689, 55)
        Me.btnInventario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(191, 54)
        Me.btnInventario.TabIndex = 11
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.UseVisualStyleBackColor = False
        '
        'btnEstadoFinanciero
        '
        Me.btnEstadoFinanciero.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEstadoFinanciero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEstadoFinanciero.ForeColor = System.Drawing.Color.White
        Me.btnEstadoFinanciero.Location = New System.Drawing.Point(504, 55)
        Me.btnEstadoFinanciero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEstadoFinanciero.Name = "btnEstadoFinanciero"
        Me.btnEstadoFinanciero.Size = New System.Drawing.Size(180, 53)
        Me.btnEstadoFinanciero.TabIndex = 10
        Me.btnEstadoFinanciero.Text = "Pago de Facturas"
        Me.btnEstadoFinanciero.UseVisualStyleBackColor = False
        '
        'btnGestionTickets
        '
        Me.btnGestionTickets.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGestionTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGestionTickets.ForeColor = System.Drawing.Color.White
        Me.btnGestionTickets.Location = New System.Drawing.Point(315, 54)
        Me.btnGestionTickets.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestionTickets.Name = "btnGestionTickets"
        Me.btnGestionTickets.Size = New System.Drawing.Size(183, 53)
        Me.btnGestionTickets.TabIndex = 9
        Me.btnGestionTickets.Text = "Gestión de tickets"
        Me.btnGestionTickets.UseVisualStyleBackColor = False
        '
        'PanelContenido
        '
        Me.PanelContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelContenido.Controls.Add(Me.PictureBox1)
        Me.PanelContenido.Controls.Add(Me.lblMes)
        Me.PanelContenido.Controls.Add(Me.btnAvanzarMes)
        Me.PanelContenido.Controls.Add(Me.btnCerrarSesion)
        Me.PanelContenido.Controls.Add(Me.dgvTickets)
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(0, 128)
        Me.PanelContenido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Size = New System.Drawing.Size(1377, 672)
        Me.PanelContenido.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.InicioSiguaNet.My.Resources.Resources.SIGUANET
        Me.PictureBox1.Location = New System.Drawing.Point(0, -5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.BackColor = System.Drawing.Color.Transparent
        Me.lblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.ForeColor = System.Drawing.Color.White
        Me.lblMes.Location = New System.Drawing.Point(1067, 33)
        Me.lblMes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(0, 20)
        Me.lblMes.TabIndex = 7
        '
        'btnAvanzarMes
        '
        Me.btnAvanzarMes.Location = New System.Drawing.Point(1188, 22)
        Me.btnAvanzarMes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAvanzarMes.Name = "btnAvanzarMes"
        Me.btnAvanzarMes.Size = New System.Drawing.Size(173, 39)
        Me.btnAvanzarMes.TabIndex = 6
        Me.btnAvanzarMes.Text = "Avanzar Mes"
        Me.btnAvanzarMes.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(1192, 609)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(173, 39)
        Me.btnCerrarSesion.TabIndex = 5
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'dgvTickets
        '
        Me.dgvTickets.AllowUserToAddRows = False
        Me.dgvTickets.AllowUserToDeleteRows = False
        Me.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTickets.Location = New System.Drawing.Point(59, 81)
        Me.dgvTickets.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvTickets.Name = "dgvTickets"
        Me.dgvTickets.ReadOnly = True
        Me.dgvTickets.RowHeadersWidth = 51
        Me.dgvTickets.RowTemplate.Height = 24
        Me.dgvTickets.Size = New System.Drawing.Size(1256, 510)
        Me.dgvTickets.TabIndex = 0
        '
        'TimerMostrar
        '
        '
        'TimerOcultar
        '
        '
        'GestionTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1377, 800)
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.PanelOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "GestionTickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionTickets"
        Me.PanelOpciones.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelContenido.ResumeLayout(False)
        Me.PanelContenido.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelOpciones As Panel
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents dgvTickets As DataGridView
    Friend WithEvents BtnClientes As Button
    Friend WithEvents btnRecursos As Button
    Friend WithEvents btnPersonal As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents btnEstadoFinanciero As Button
    Friend WithEvents btnGestionTickets As Button
    Friend WithEvents btnGestionar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents TimerOcultar As Timer
    Friend WithEvents btnAvanzarMes As Button
    Friend WithEvents lblMes As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRealizar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
