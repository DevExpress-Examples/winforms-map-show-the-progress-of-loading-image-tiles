Imports Microsoft.VisualBasic
Imports DevExpress.XtraMap
Imports System
Imports System.Windows.Forms

Namespace TilesLoaded
	Partial Public Class Form1
		Inherits Form
		Private requestsCounter As Integer = 0
		Private ReadOnly Property Layer() As ImageTilesLayer
			Get
				Return CType(mapControl1.Layers(0), ImageTilesLayer)
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			AddHandler Layer.RequestDataLoading, AddressOf Layer_RequestDataLoading
			AddHandler Layer.DataLoaded, AddressOf Layer_DataLoaded
		End Sub

		Private Sub Layer_RequestDataLoading(ByVal sender As Object, ByVal e As EventArgs)
			requestsCounter += 1
			UpdateProgressBar()
		End Sub

		Private Sub Layer_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs)
			progressBar1.Value = 100
			progressBar1.Visible = False
			label1.Visible = False
			requestsCounter = 0
		End Sub

		Private Sub UpdateProgressBar()
			If (Not progressBar1.Visible) Then
				progressBar1.Visible = True
			End If
			If (Not label1.Visible) Then
				label1.Visible = True
			End If
			progressBar1.Value = CInt(Fix(100.0 * (requestsCounter - 1) / requestsCounter))
		End Sub
	End Class
End Namespace
