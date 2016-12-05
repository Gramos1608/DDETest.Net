Imports NDde.Client
Public Class DDETest
    Private Sub DDETest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BLeer_Click(sender As System.Object, e As System.EventArgs) Handles BLeer.Click
        Dim DDE As DdeClient = New DdeClient(TApp.Text, TTopico.Text)   'Para leer el PLC

        DDE.Connect()
        TDatoLectura.Text = DDE.Request(TItem.Text, 60000)

    End Sub

    Private Sub BEscribir_Click(sender As System.Object, e As System.EventArgs) Handles BEscribir.Click
        Dim DDE As DdeClient = New DdeClient(TApp.Text, TTopico.Text)   'Para leer el PLC

        DDE.Connect()
        DDE.Poke(TItem.Text, TDatoEscribir.Text, 60000)

    End Sub
End Class
