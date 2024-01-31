Namespace _12_Address
    Partial Public Class GcAddressBox
        Inherits InputManWin12_Demo.DemoBase_settings

        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期設定
            gcAddressBox1.AutoFilter = True
            gcComboBox1.SelectedIndex = 0
        End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            Select Case gcComboBox1.Text
                Case "指定なし"
                    gcAddressBox1.PrefectureFilter = ""
                    Exit Select
                Case "北海道地方"
                    gcAddressBox1.PrefectureFilter = "北海道"
                    Exit Select
                Case "東北地方"
                    gcAddressBox1.PrefectureFilter = "青森県,岩手県,秋田県,宮城県,山形県,福島県"
                    Exit Select
                Case "関東地方"
                    gcAddressBox1.PrefectureFilter = "茨城県,栃木県,群馬県,埼玉県,千葉県,東京都,神奈川県"
                    Exit Select
                Case "中部地方"
                    gcAddressBox1.PrefectureFilter = "新潟県,富山県,石川県,福井県,山梨県,長野県,岐阜県,静岡県,愛知県"
                    Exit Select
                Case "近畿地方"
                    gcAddressBox1.PrefectureFilter = "三重県,滋賀県,京都府,大阪府,兵庫県,奈良県,和歌山県"
                    Exit Select
                Case "中国地方"
                    gcAddressBox1.PrefectureFilter = "鳥取県,島根県,岡山県,広島県,山口県"
                    Exit Select
                Case "四国地方"
                    gcAddressBox1.PrefectureFilter = "徳島県,香川県,愛媛県,高知県"
                    Exit Select
                Case "九州地方"
                    gcAddressBox1.PrefectureFilter = "福岡県,佐賀県,長崎県,熊本県,大分県,宮崎県,鹿児島県,沖縄県"
                    Exit Select
            End Select
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' AutoFilterプロパティ
            gcAddressBox1.AutoFilter = checkBox1.Checked
        End Sub
    End Class
End Namespace
