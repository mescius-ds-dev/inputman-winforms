using System;

namespace InputManWin12_Demo._12_Address
{
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
            checkBox1.CheckedChanged +=new EventHandler(checkBox1_CheckedChanged);
            gcComboBox1.SelectedIndex = 0;
            gcComboBox1.SelectedIndexChanged += new EventHandler(gcComboBox1_SelectedIndexChanged);
        }

        void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // PrefectureFilterプロパティ
            switch (gcComboBox1.Text)
            {
                case "指定なし":
                    gcAddressBox1.PrefectureFilter = "";
                    break;
                case "北海道地方":
                    gcAddressBox1.PrefectureFilter = "北海道";
                    break;
                case "東北地方":
                    gcAddressBox1.PrefectureFilter = "青森県,岩手県,秋田県,宮城県,山形県,福島県";
                    break;
                case "関東地方":
                    gcAddressBox1.PrefectureFilter = "茨城県,栃木県,群馬県,埼玉県,千葉県,東京都,神奈川県";
                    break;
                case "中部地方":
                    gcAddressBox1.PrefectureFilter = "新潟県,富山県,石川県,福井県,山梨県,長野県,岐阜県,静岡県,愛知県";
                    break;
                case "近畿地方":
                    gcAddressBox1.PrefectureFilter = "三重県,滋賀県,京都府,大阪府,兵庫県,奈良県,和歌山県";
                    break;
                case "中国地方":
                    gcAddressBox1.PrefectureFilter = "鳥取県,島根県,岡山県,広島県,山口県";
                    break;
                case "四国地方":
                    gcAddressBox1.PrefectureFilter = "徳島県,香川県,愛媛県,高知県";
                    break;
                case "九州地方":
                    gcAddressBox1.PrefectureFilter = "福岡県,佐賀県,長崎県,熊本県,大分県,宮崎県,鹿児島県,沖縄県";
                    break;
                default:
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // AutoFilterプロパティ
            gcAddressBox1.AutoFilter = checkBox1.Checked;
        }
    }
}
