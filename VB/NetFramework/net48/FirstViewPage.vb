Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Public Partial Class FirstViewPage
	Inherits UserControl
	Public Sub New()
		InitializeComponent()

		AddHandler Me.Load, New System.EventHandler(AddressOf Me.FirstViewPage_Load)
	End Sub

	Private Sub FirstViewPage_Load(sender As Object, e As EventArgs)
		' ラベルの背景をPictureBoxコントロールに対して透過にする
		mainvisual.Controls.Add(product1)
		mainvisual.Controls.Add(product2)
		mainvisual.Controls.Add(product3)
		mainvisual.Controls.Add(product_body)
		mainvisual.Controls.Add(product_title)
	End Sub
End Class
