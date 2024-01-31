Imports System.Windows.Forms

Namespace _08_SideButton
	Public Partial Class SideButton
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
			InitializeComponent()
			InitializeForm()
		End Sub

		Private Sub InitializeForm()
			' ***** 初期値
			checkBox1.Checked = DirectCast(gcTextBox1.SideButtons(0), GrapeCity.Win.Editors.SideButton).CheckOnClick

			timer1.Interval = 1000

			' xmlファイルからデータ取得
			Dim filePath As System.String = Application.StartupPath
			Me.dataSet1.ReadXml(filePath & "\Resources\prefecture.xml")
			gcComboBox1.DataSource = dataSet1.Tables(0)
			gcComboBox1.SelectedIndex = -1

			For i As Integer = 1 To gcComboBox1.ListColumns.Count - 1
				gcComboBox1.ListColumns(i).AutoWidth = True
            Next

            ' xmlファイルからデータ取得(GcMaskedComboBox)
            Me.DataSet2.ReadXml(filePath & "\Resources\pref.xml")
            GcMaskedComboBox1.DataSource = DataSet2.Tables(0)
            GcMaskedComboBox1.SelectedIndex = -1

            For i As Integer = 1 To GcMaskedComboBox1.ListColumns.Count - 1
                GcMaskedComboBox1.ListColumns(i).AutoWidth = True
            Next

		End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' CheckOnClickプロパティ
            DirectCast(gcTextBox1.SideButtons(0), GrapeCity.Win.Editors.SideButton).CheckOnClick = checkBox1.Checked
            DirectCast(gcMask1.SideButtons(0), GrapeCity.Win.Editors.SideButton).CheckOnClick = checkBox1.Checked
            DirectCast(gcDateTime1.SideButtons(0), GrapeCity.Win.Editors.SideButton).CheckOnClick = checkBox1.Checked
            DirectCast(gcDate1.SideButtons(0), GrapeCity.Win.Editors.SideButton).CheckOnClick = checkBox1.Checked
            DirectCast(gcTimeSpan1.SideButtons(0), GrapeCity.Win.Editors.SideButton).CheckOnClick = checkBox1.Checked
            DirectCast(gcNumber1.SideButtons(0), GrapeCity.Win.Editors.SideButton).CheckOnClick = checkBox1.Checked
            DirectCast(gcNumber1.SideButtons(1), GrapeCity.Win.Editors.SideButton).CheckOnClick = checkBox1.Checked
            DirectCast(gcComboBox1.SideButtons(0), GrapeCity.Win.Editors.SideButton).CheckOnClick = checkBox1.Checked
            DirectCast(GcMaskedComboBox1.SideButtons(0), GrapeCity.Win.Editors.SideButton).CheckOnClick = checkBox1.Checked

            If Not checkBox1.Checked Then
                DirectCast(gcTextBox1.SideButtons(0), GrapeCity.Win.Editors.SideButton).Checked = False
                DirectCast(gcMask1.SideButtons(0), GrapeCity.Win.Editors.SideButton).Checked = False
                DirectCast(gcDateTime1.SideButtons(0), GrapeCity.Win.Editors.SideButton).Checked = False
                DirectCast(gcDate1.SideButtons(0), GrapeCity.Win.Editors.SideButton).Checked = False
                DirectCast(gcTimeSpan1.SideButtons(0), GrapeCity.Win.Editors.SideButton).Checked = False
                DirectCast(gcNumber1.SideButtons(0), GrapeCity.Win.Editors.SideButton).Checked = False
                DirectCast(gcNumber1.SideButtons(1), GrapeCity.Win.Editors.SideButton).Checked = False
                DirectCast(gcComboBox1.SideButtons(0), GrapeCity.Win.Editors.SideButton).Checked = False
                DirectCast(GcMaskedComboBox1.SideButtons(0), GrapeCity.Win.Editors.SideButton).Checked = False
            End If
        End Sub

        Private Sub sideButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sideButton1.Click
            ' テキストコントロールのサイドボタン
            MessageBox.Show("正解はTrueです！", "メッセージ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub sideButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sideButton2.Click
            ' マスクコントロールのサイドボタン
            MessageBox.Show("ここに住所検索処理を入れることができます")
        End Sub

        Private Sub sideButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sideButton3.Click
            ' 日付時刻コントロールのサイドボタン
            gcDateTime1.Value = DateTime.Now
        End Sub

        Private Sub sideButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sideButton4.Click
            ' 日付コントロールのサイドボタン
            gcDate1.Value = DateTime.Now
        End Sub

        Private Sub sideButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sideButton5.Click
            ' タイムスパンコントロールのサイドボタン
            If timer1.Enabled Then
                timer1.Enabled = False
                sideButton5.Text = "Start"
            Else
                timer1.Enabled = True
                sideButton5.Text = "Stop"
                If gcTimeSpan1.Value Is Nothing Then
                    gcTimeSpan1.Value = New TimeSpan(0)
                End If
                gcTimeSpan1.Value = gcTimeSpan1.Value + New TimeSpan(0, 0, 0, 1)
            End If
        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
            gcTimeSpan1.Value = gcTimeSpan1.Value + New TimeSpan(0, 0, 0, 1)
        End Sub

        Private Sub sideButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sideButton6.Click
            ' 数値コントロールのサイドボタン（下）
            If gcNumber1.Value > 0 Then
                gcNumber1.Value -= 1
            End If
        End Sub

        Private Sub sideButton7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sideButton7.Click
            ' 数値コントロールのサイドボタン（上）
            If gcNumber1.Value < 999 Then
                gcNumber1.Value += 1
            End If
        End Sub

        Private Sub sideButton8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sideButton8.Click
            ' コンボコントロールのサイドボタン
            gcComboBox1.SelectedIndex = -1
            gcComboBox1.Clear()
        End Sub

        Private Sub SideButton9_Click(sender As Object, e As EventArgs) Handles SideButton9.Click
            ' マスクコンボコントロールのサイドボタン
            GcMaskedComboBox1.SelectedIndex = -1
            GcMaskedComboBox1.Clear()
        End Sub
    End Class
End Namespace
