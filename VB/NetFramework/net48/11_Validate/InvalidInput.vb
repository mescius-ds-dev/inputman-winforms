Imports System.Windows.Forms

Namespace _11_Validate
	Public Partial Class InvalidInput
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
			InitializeComponent()
			InitializeForm()
		End Sub

		Private Sub InitializeForm()
			' ***** 初期値
			' xmlファイルからデータ取得
			Dim filePath As System.String = Application.StartupPath
			Me.dataSet1.ReadXml(filePath & "\Resources\prefecture.xml")
			gcComboBox1.DataSource = dataSet1.Tables(0)
			gcComboBox1.SelectedIndex = -1

			For i As Integer = 1 To gcComboBox1.ListColumns.Count - 1
				gcComboBox1.ListColumns(i).AutoWidth = True
            Next

            ' ***** 初期値
            ' xmlファイルからデータ取得（gcMaskedComboBox）
            Me.dataSet2.ReadXml(filePath & "\Resources\pref.xml")
            gcMaskedComboBox1.DataSource = dataSet2.Tables(0)
            gcMaskedComboBox1.SelectedIndex = -1

            For i As Integer = 1 To gcMaskedComboBox1.ListColumns.Count - 1
                gcMaskedComboBox1.ListColumns(i).AutoWidth = True
            Next
		End Sub

        Private Sub gcTextBox1_InvalidInput(ByVal sender As Object, ByVal e As EventArgs) Handles gcTextBox1.InvalidInput
            addInvalidInputEventArgs("テキストコントロール", e)
        End Sub

        Private Sub gcMask1_InvalidInput(ByVal sender As Object, ByVal e As EventArgs) Handles gcMask1.InvalidInput
            addInvalidInputEventArgs("マスクコントロール", e)
        End Sub

        Private Sub gcCharMask1_InvalidInput(ByVal sender As Object, ByVal e As EventArgs) Handles gcCharMask1.InvalidInput
            addInvalidInputEventArgs("キャラクタボックスコントロール", e)
        End Sub

        Private Sub gcDateTime1_InvalidInput(ByVal sender As Object, ByVal e As EventArgs) Handles gcDateTime1.InvalidInput
            addInvalidInputEventArgs("日付時刻コントロール", e)
        End Sub

        Private Sub gcDate1_InvalidInput(ByVal sender As Object, ByVal e As EventArgs) Handles gcDate1.InvalidInput
            addInvalidInputEventArgs("日付コントロール", e)
        End Sub

        Private Sub gcTime1_InvalidInput(ByVal sender As Object, ByVal e As EventArgs) Handles gcTime1.InvalidInput
            addInvalidInputEventArgs("時刻コントロール", e)
        End Sub

        Private Sub gcTimeSpan1_InvalidInput(ByVal sender As Object, ByVal e As EventArgs) Handles gcTimeSpan1.InvalidInput
            addInvalidInputEventArgs("タイムスパンコントロール", e)
        End Sub

        Private Sub gcNumber1_InvalidInput(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber1.InvalidInput
            addInvalidInputEventArgs("数値コントロール", e)
        End Sub

        Private Sub gcComboBox1_InvalidInput(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.InvalidInput
            addInvalidInputEventArgs("コンボコントロール", e)
        End Sub

        Private Sub gcMaskedComboBox1_InvalidInput(sender As Object, e As EventArgs) Handles gcMaskedComboBox1.InvalidInput
            addInvalidInputEventArgs("マスクコンボコントロール", e)
        End Sub

		Private Sub addInvalidInputEventArgs(str As String, e As EventArgs)
			Dim invalidInputEventArgs As GrapeCity.Win.Editors.InvalidInputEventArgs = TryCast(e, GrapeCity.Win.Editors.InvalidInputEventArgs)
			If invalidInputEventArgs Is Nothing Then
				Return
			End If

			' 入力された値が設定された書式に対して無効かどうか 
			If invalidInputEventArgs.HasInvalidChar Then
				gcListBox1.Items.Add(str & " に入力された値は設定された書式に対して無効です。")
			End If

			' 入力された値が設定された最大文字数を超えているかどうか 
			If invalidInputEventArgs.MeetsLengthLimit Then
				gcListBox1.Items.Add(str & " に入力された値は設定された最大文字数を超えています。")
			End If

			' 入力された値が設定された最大値よりも大きいかどうか 
			If invalidInputEventArgs.ExceedMaxValue Then
				gcListBox1.Items.Add(str & " に入力された値は設定された最大値よりも大きい値です。")
			End If

			' 入力された値が設定された最小値よりも小さいかどうか 
			If invalidInputEventArgs.BelowMinValue Then
				gcListBox1.Items.Add(str & " に入力された値は設定された最小値よりも小さい値です。")
			End If

			gcListBox1.SelectedIndex = gcListBox1.Items.Count - 1
		End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            gcListBox1.Items.Clear()
        End Sub



    End Class
End Namespace
