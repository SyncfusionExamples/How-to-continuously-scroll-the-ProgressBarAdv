Imports Syncfusion.Windows.Forms
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace ProgressBar_windows
	Partial Public Class Form1
		Inherits MetroForm

		Public Sub New()
			InitializeComponent()
		End Sub



		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			If Me.progressBarAdv1.Value < 100 Then

				Me.progressBarAdv1.Value += 1

			Else

				Me.progressBarAdv1.Value = 0
			End If
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Me.timer1.Enabled = True
		End Sub
	End Class
End Namespace
