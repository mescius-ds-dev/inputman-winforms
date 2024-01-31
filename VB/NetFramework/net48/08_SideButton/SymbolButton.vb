Imports System.Windows.Forms

Namespace _08_SideButton
    Partial Public Class SymbolButton
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期値
            gcComboBox2.SelectedIndex = Convert.ToInt32(DirectCast(gcTextBox1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).Symbol) + 1
            gcComboBox3.SelectedIndex = Convert.ToInt32(DirectCast(gcTextBox1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).SymbolDirection)

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

        Private Sub gcComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            '  ボタンに表示するイメージ
            DirectCast(gcTextBox1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).Symbol = CType(gcComboBox2.SelectedIndex - 1, GrapeCity.Win.Editors.Symbols)
            DirectCast(gcMask1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).Symbol = CType(gcComboBox2.SelectedIndex - 1, GrapeCity.Win.Editors.Symbols)
            DirectCast(gcDateTime1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).Symbol = CType(gcComboBox2.SelectedIndex - 1, GrapeCity.Win.Editors.Symbols)
            DirectCast(gcDate1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).Symbol = CType(gcComboBox2.SelectedIndex - 1, GrapeCity.Win.Editors.Symbols)
            DirectCast(gcTime1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).Symbol = CType(gcComboBox2.SelectedIndex - 1, GrapeCity.Win.Editors.Symbols)
            DirectCast(gcTimeSpan1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).Symbol = CType(gcComboBox2.SelectedIndex - 1, GrapeCity.Win.Editors.Symbols)
            DirectCast(gcNumber1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).Symbol = CType(gcComboBox2.SelectedIndex - 1, GrapeCity.Win.Editors.Symbols)
            DirectCast(gcComboBox1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).Symbol = CType(gcComboBox2.SelectedIndex - 1, GrapeCity.Win.Editors.Symbols)
            DirectCast(GcMaskedComboBox1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).Symbol = CType(gcComboBox2.SelectedIndex - 1, GrapeCity.Win.Editors.Symbols)
        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            '  シンボルの表示方向
            DirectCast(gcTextBox1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).SymbolDirection = CType(gcComboBox3.SelectedIndex, GrapeCity.Win.Editors.SymbolDirection)
            DirectCast(gcMask1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).SymbolDirection = CType(gcComboBox3.SelectedIndex, GrapeCity.Win.Editors.SymbolDirection)
            DirectCast(gcDateTime1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).SymbolDirection = CType(gcComboBox3.SelectedIndex, GrapeCity.Win.Editors.SymbolDirection)
            DirectCast(gcDate1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).SymbolDirection = CType(gcComboBox3.SelectedIndex, GrapeCity.Win.Editors.SymbolDirection)
            DirectCast(gcTime1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).SymbolDirection = CType(gcComboBox3.SelectedIndex, GrapeCity.Win.Editors.SymbolDirection)
            DirectCast(gcTimeSpan1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).SymbolDirection = CType(gcComboBox3.SelectedIndex, GrapeCity.Win.Editors.SymbolDirection)
            DirectCast(gcNumber1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).SymbolDirection = CType(gcComboBox3.SelectedIndex, GrapeCity.Win.Editors.SymbolDirection)
            DirectCast(gcComboBox1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).SymbolDirection = CType(gcComboBox3.SelectedIndex, GrapeCity.Win.Editors.SymbolDirection)
            DirectCast(GcMaskedComboBox1.SideButtons(0), GrapeCity.Win.Editors.SymbolButton).SymbolDirection = CType(gcComboBox3.SelectedIndex, GrapeCity.Win.Editors.SymbolDirection)
        End Sub

        Private Sub symbolButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles symbolButton1.Click, symbolButton2.Click, symbolButton3.Click, symbolButton4.Click, symbolButton5.Click, symbolButton6.Click, symbolButton7.Click, symbolButton8.Click, symbolButton9.Click
            ' サイドボタンの動作
            Select Case DirectCast(sender, GrapeCity.Win.Editors.SymbolButton).Name
                Case "symbolButton1"
                    ' テキストコントロール
                    gcTextBox1.Clear()
                    Exit Select
                Case "symbolButton2"
                    ' マスクコントロール
                    gcMask1.Value = "99999999999"
                    Exit Select
                Case "symbolButton3"
                    ' 日付時刻コントロール
                    gcDateTime1.DroppedDown = Not gcDateTime1.DroppedDown
                    Exit Select
                Case "symbolButton4"
                    ' 日付コントロール
                    gcDate1.DroppedDown = Not gcDate1.DroppedDown
                    Exit Select
                Case "symbolButton5"
                    ' 時刻コントロール
                    gcTime1.Value = DateTime.Now.TimeOfDay
                    Exit Select
                Case "symbolButton6"
                    ' タイムスパンコントロール
                    gcTimeSpan1.Clear()
                    Exit Select
                Case "symbolButton7"
                    ' 数値コントロール
                    gcNumber1.Value = 999
                    Exit Select
                Case "symbolButton8"
                    ' コンボコントロール
                    gcComboBox1.DroppedDown = Not gcComboBox1.DroppedDown
                    Exit Select
                Case "symbolButton9"
                    ' マスクコンボコントロール
                    GcMaskedComboBox1.DroppedDown = Not GcMaskedComboBox1.DroppedDown
                    Exit Select
                Case Else
                    Exit Select
            End Select
        End Sub
    End Class
End Namespace
