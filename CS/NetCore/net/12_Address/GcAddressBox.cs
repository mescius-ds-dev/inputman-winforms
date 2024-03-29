namespace InputManWin12_Demo._12_Address;

public partial class GcAddressBox : InputManWin12_Demo.DemoBase_settings
{
    public GcAddressBox()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        gcAddressBox1.AutoFilter = true;

        // AutoFilterプロパティ
        checkBox1.CheckedChanged += (s, e) => gcAddressBox1.AutoFilter = checkBox1.Checked;

        gcComboBox1.SelectedIndex = 0;
        // PrefectureFilterプロパティ
        gcComboBox1.SelectedIndexChanged += (s, e) => GetPrefectureFilter();
    }

    private void GetPrefectureFilter() => gcAddressBox1.PrefectureFilter = gcComboBox1.Text switch
    {
        "指定なし" => "",
        "北海道地方" => "北海道",
        "東北地方" => "青森県,岩手県,秋田県,宮城県,山形県,福島県",
        "関東地方" => "茨城県,栃木県,群馬県,埼玉県,千葉県,東京都,神奈川県",
        "中部地方" => "新潟県,富山県,石川県,福井県,山梨県,長野県,岐阜県,静岡県,愛知県",
        "近畿地方" => "三重県,滋賀県,京都府,大阪府,兵庫県,奈良県,和歌山県",
        "中国地方" => "鳥取県,島根県,岡山県,広島県,山口県",
        "四国地方" => "徳島県,香川県,愛媛県,高知県",
        "九州地方" => "福岡県,佐賀県,長崎県,熊本県,大分県,宮崎県,鹿児島県,沖縄県",
        _ => throw new InvalidOperationException()
    };
}
