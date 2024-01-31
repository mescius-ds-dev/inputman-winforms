Imports GrapeCity.Win.Editors

Namespace _14_GcSoftKeyboard
    Partial Public Class KeyLayout
        Inherits InputManWin12_Demo.DemoBase_settings

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub KeyLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' 初期設定
            gcComboBox1.SelectedIndex = 8
            gcComboBox2.SelectedIndex = 5
            gcComboBox3.SelectedIndex = 0
            gcComboBox4.SelectedIndex = 2
            gcComboBox5.SelectedIndex = 1
            gcComboBox6.SelectedIndex = 1
            gcComboBox7.SelectedIndex = 2
            gcComboBox7.Enabled = False
        End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            ' テキストコントロールのキーレイアウトを設定
            gcSoftKeyboard1.SetDefaultKeyboardLayout(gcTextBox1, CType(gcComboBox1.SelectedIndex, SoftKeyboardLayout))

        End Sub

        Private Sub gcComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox2.SelectedIndexChanged
            ' マスクコントロールのキーレイアウトを設定
            gcSoftKeyboard1.SetDefaultKeyboardLayout(gcMask1, CType(gcComboBox2.SelectedIndex, SoftKeyboardLayout))

        End Sub

        Private Sub gcComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox3.SelectedIndexChanged
            ' 日付コントロールのキーレイアウトを設定
            gcSoftKeyboard1.SetDefaultKeyboardLayout(gcDate1, CType(gcComboBox3.SelectedIndex, SoftKeyboardLayout))

        End Sub

        Private Sub gcComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox4.SelectedIndexChanged
            ' 数値コントロールのキーレイアウトを設定
            gcSoftKeyboard1.SetDefaultKeyboardLayout(gcNumber1, CType(gcComboBox4.SelectedIndex, SoftKeyboardLayout))

        End Sub

        Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged
            ' ひらがなレイアウトのキー配置を設定
            If checkBox1.Checked Then
                gcSoftKeyboard1.KanaInputLayout = SoftKeyboardKanaInputLayout.Syllabary
            Else
                gcSoftKeyboard1.KanaInputLayout = SoftKeyboardKanaInputLayout.TwelveButtons
            End If
        End Sub

        Private Sub gcComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox5.SelectedIndexChanged
            ' 表示モードを設定
            gcSoftKeyboard1.KeyboardPositioningMode = CType(gcComboBox5.SelectedIndex, SoftKeyboardPositioningMode)
            If gcComboBox5.SelectedIndex = 0 Then
                gcComboBox6.Enabled = False
                gcComboBox7.Enabled = True
            Else
                gcComboBox6.Enabled = True
                gcComboBox7.Enabled = False
            End If
        End Sub

        Private Sub gcComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox6.SelectedIndexChanged
            gcSoftKeyboard1.PopupPosition = CType(gcComboBox6.SelectedIndex, SoftKeyboardPopupPosition)
        End Sub

        Private Sub gcComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcComboBox7.SelectedIndexChanged
            gcSoftKeyboard1.DropDownDirection = CType(gcComboBox7.SelectedIndex, DropDownDirection)
        End Sub
    End Class
End Namespace
