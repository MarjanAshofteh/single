Imports System.ComponentModel
Imports System.Threading

Public Class Loading
    Dim stepo As Double = 0.01
    Dim positive As Boolean = False
    Public workCompleted As Boolean = False

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As Thread = New Thread(AddressOf dlgStart)
        t.SetApartmentState(ApartmentState.STA)
        t.IsBackground = True
        t.Start()

    End Sub

    Private Sub dlgStart()
        On Error Resume Next
        Do While workCompleted = False
            If Me.Opacity <= 0.7 Then
                positive = True
            ElseIf Me.Opacity >= 1
                positive = False
            End If
            Me.Invoke(New MethodInvoker(AddressOf SetOpacity))
            Threading.Thread.Sleep(20)
        Loop
            Me.Invoke(New MethodInvoker(AddressOf CloseMe))
    End Sub

    Private Sub SetOpacity()
        If positive Then
            Me.Opacity += stepo
        Else
            Me.Opacity -= stepo
        End If
    End Sub

    Private Sub CloseMe()
        Me.Close()
    End Sub

    Private Sub Loading_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        workCompleted = True
    End Sub
End Class