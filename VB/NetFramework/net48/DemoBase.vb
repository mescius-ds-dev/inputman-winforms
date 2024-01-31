Imports System.Windows.Forms

Public Partial Class DemoBase
	Inherits UserControl
	Public Sub New()
		InitializeComponent()
	End Sub

	Public Property Title() As String
		Get
			Return Me.lblTitle.Text
		End Get
		Set
			Me.lblTitle.Text = value
		End Set
	End Property

	Public Property Description() As String
		Get
			Return Me.lblDescription.Text
		End Get
		Set
			Me.lblDescription.Text = value
		End Set
	End Property
End Class
