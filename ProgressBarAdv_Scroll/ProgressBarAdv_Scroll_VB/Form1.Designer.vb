Namespace ProgressBar_windows
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.progressBarAdv1 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
            Me.button1 = New System.Windows.Forms.Button()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            CType(Me.progressBarAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'progressBarAdv1
            '
            Me.progressBarAdv1.BackMultipleColors = New System.Drawing.Color() {System.Drawing.Color.Empty}
            Me.progressBarAdv1.BackSegments = False
            Me.progressBarAdv1.CustomText = Nothing
            Me.progressBarAdv1.CustomWaitingRender = False
            Me.progressBarAdv1.ForegroundImage = Nothing
            Me.progressBarAdv1.Location = New System.Drawing.Point(195, 112)
            Me.progressBarAdv1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.progressBarAdv1.MultipleColors = New System.Drawing.Color() {System.Drawing.Color.Empty}
            Me.progressBarAdv1.Name = "progressBarAdv1"
            Me.progressBarAdv1.SegmentWidth = 12
            Me.progressBarAdv1.Size = New System.Drawing.Size(359, 28)
            Me.progressBarAdv1.TabIndex = 0
            Me.progressBarAdv1.Text = "progressBarAdv1"
            Me.progressBarAdv1.WaitingGradientWidth = 400
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(253, 217)
            Me.button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(166, 37)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Click to scroll"
            Me.button1.UseVisualStyleBackColor = True
            '
            'timer1
            '
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(712, 361)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.progressBarAdv1)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ProgressBar_customization"
            CType(Me.progressBarAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private progressBarAdv1 As Syncfusion.Windows.Forms.Tools.ProgressBarAdv
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents timer1 As System.Windows.Forms.Timer
	End Class
End Namespace

