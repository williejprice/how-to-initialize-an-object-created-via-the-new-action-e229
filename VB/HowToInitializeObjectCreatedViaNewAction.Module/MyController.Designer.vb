Imports Microsoft.VisualBasic
Imports System
Namespace HowToInitializeObjectCreatedViaNewAction.Module
    Partial Public Class MyController
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            ' 
            ' MyController
            ' 
            Me.TargetObjectType = GetType(DevExpress.Persistent.BaseImpl.Task)
            Me.TargetViewNesting = DevExpress.ExpressApp.Nesting.Root
'            Me.FrameAssigned += New System.EventHandler(Me.MyController_FrameAssigned);

        End Sub

        #End Region
    End Class
End Namespace
