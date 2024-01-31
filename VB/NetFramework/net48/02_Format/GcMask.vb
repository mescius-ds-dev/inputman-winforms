Imports System.Windows.Forms
Imports GrapeCity.Win.Editors
Imports GrapeCity.Win.Editors.Fields

Namespace _02_Format
	Public Partial Class GcMask
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
			InitializeComponent()
			InitializeForm()
		End Sub

		Private Sub InitializeForm()
            ' ***** 初期設定
			radioButton1.Checked = True
			gcComboBox1.SelectedIndex = 0
			checkBox1.Checked = gcMask1.AutoConvert
			gcComboBox2.SelectedIndex = Convert.ToInt32(gcMask1.AcceptsCrLf)
			gcComboBox3.SelectedIndex = Convert.ToInt32(gcMask1.AcceptsTabChar)
		End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' 正規表現による書式設定
            gcMask1.Fields.Clear()
            gcMask1.Fields.AddRange(gcComboBox1.Text)
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' AutoConvertプロパティ
            gcMask1.AutoConvert = checkBox1.Checked
        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' AcceptsCrLfプロパティ
            gcMask1.AcceptsCrLf = CType(gcComboBox2.SelectedIndex, CrLfMode)
        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            ' AcceptsTabCharプロパティ
            gcMask1.AcceptsTabChar = CType(gcComboBox3.SelectedIndex, TabCharMode)
        End Sub

        Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton1.CheckedChanged
            If radioButton1.Checked Then
                ' 正規表現による書式設定
                gcMask1.Fields.Clear()
                gcMask1.Fields.AddRange(gcComboBox1.Text)

                groupBox1.Enabled = True
                groupBox2.Enabled = False
            Else
                ' 列挙型フィールドの設定
                setEnumField()

                groupBox1.Enabled = False
                groupBox2.Enabled = True
            End If
        End Sub

        Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton2.CheckedChanged
            ' 列挙型フィールドの設定
            setEnumField()
        End Sub

        Private Sub gcListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcListBox1.SelectedIndexChanged
            ' 列挙型フィールドの追加（職種）
            If gcListBox1.SelectedIndex > -1 Then
                gcTextBox1.Text = gcListBox1.Items(gcListBox1.SelectedIndex).Text
            End If
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            ' 列挙型フィールドの追加（職種）
            If gcTextBox1.TextLength > 0 Then
                gcListBox1.Items.Add(gcTextBox1.Text)
                setEnumField()
            End If
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
            ' 列挙型フィールドの削除（職種）
            If gcListBox1.FindStringExact(gcTextBox1.Text, -1, 0) > -1 Then
                gcListBox1.Items.RemoveAt(gcListBox1.FindStringExact(gcTextBox1.Text, -1, 0))
                setEnumField()
                gcTextBox1.Clear()
            End If
        End Sub

        Private Sub gcListBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcListBox2.SelectedIndexChanged
            ' 列挙型フィールドの追加（役職）
            If gcListBox2.SelectedIndex > -1 Then
                gcTextBox2.Text = gcListBox2.Items(gcListBox2.SelectedIndex).Text
            End If
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
            ' 列挙型フィールドの追加（役職）
            If gcTextBox2.TextLength > 0 Then
                gcListBox2.Items.Add(gcTextBox2.Text)
                setEnumField()
            End If
        End Sub

        Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
            ' 列挙型フィールドの削除（役職）
            If gcListBox2.FindStringExact(gcTextBox2.Text, -1, 0) > -1 Then
                gcListBox2.Items.RemoveAt(gcListBox2.FindStringExact(gcTextBox2.Text, -1, 0))
                setEnumField()
                gcTextBox2.Clear()
            End If
        End Sub

		Private Sub setEnumField()
			gcMask1.Fields.Clear()

			Dim item0 As String() = New String(gcListBox1.Items.Count - 1) {}
			For i As Int32 = 0 To gcListBox1.Items.Count - 1
				item0(i) = gcListBox1.Items(i).Text
			Next

			Dim item1 As String() = New String(gcListBox2.Items.Count - 1) {}
			For i As Int32 = 0 To gcListBox2.Items.Count - 1
				item1(i) = gcListBox2.Items(i).Text
			Next

			Dim mlf0 As New MaskLiteralField("職種：")
			Dim mlf1 As New MaskLiteralField(" 役職：")
			Dim mef0 As New MaskEnumerationField()
			Dim mef1 As New MaskEnumerationField()
			gcMask1.Fields.AddRange(New MaskField() {mlf0, mef0, mlf1, mef1})
			If item0.Length = 0 Then
				mef0.Items = New String() {" "}
			Else
				mef0.Items = item0
			End If
			If item1.Length = 0 Then
				mef1.Items = New String() {" "}
			Else
				mef1.Items = item1
			End If

			mef0.AutoDropDown = True
			mef0.DropDownEnabled = True
			mef1.AutoDropDown = True
			mef1.DropDownEnabled = True
		End Sub
	End Class
End Namespace
