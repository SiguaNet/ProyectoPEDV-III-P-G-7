﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My

    'NOTA: Este archivo se genera automáticamente; no lo modifique directamente.  Para hacer cambios,
    ' o si detecta errores de compilación en este archivo, vaya al Diseñador de proyectos
    ' (vaya a Propiedades del proyecto o haga doble clic en el nodo My Project en el
    ' Explorador de soluciones) y realice cambios en la pestaña Aplicación.
    '
    Partial Friend Class MyApplication

        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Public Sub New()
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = False
            Me.EnableVisualStyles = True
            Me.SaveMySettingsOnExit = True
            Me.ShutDownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub

        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Global.InicioSiguaNet.inicioSesion
        End Sub
    End Class
End Namespace
