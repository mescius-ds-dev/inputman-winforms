using System;
using System.Windows.Forms;

namespace InputManWin12_Demo._08_SideButton
{
    public partial class SymbolButton : InputManWin12_Demo.DemoBase_settings
    {
        public SymbolButton()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            //// ***** 初期設定
            gcComboBox2.SelectedIndexChanged += new EventHandler(gcComboBox2_SelectedIndexChanged);
            gcComboBox3.SelectedIndexChanged += new EventHandler(gcComboBox3_SelectedIndexChanged);
            symbolButton1.Click += new EventHandler(symbolButton_Click);
            symbolButton2.Click += new EventHandler(symbolButton_Click);
            symbolButton3.Click += new EventHandler(symbolButton_Click);
            symbolButton4.Click += new EventHandler(symbolButton_Click);
            symbolButton5.Click += new EventHandler(symbolButton_Click);
            symbolButton6.Click += new EventHandler(symbolButton_Click);
            symbolButton7.Click += new EventHandler(symbolButton_Click);
            symbolButton8.Click += new EventHandler(symbolButton_Click);
            symbolButton9.Click += new EventHandler(symbolButton_Click);

            // ***** 初期値
            gcComboBox2.SelectedIndex = Convert.ToInt32(((GrapeCity.Win.Editors.SymbolButton)gcTextBox1.SideButtons[0]).Symbol) + 1;
            gcComboBox3.SelectedIndex = Convert.ToInt32(((GrapeCity.Win.Editors.SymbolButton)gcTextBox1.SideButtons[0]).SymbolDirection);

            // xmlファイルからデータ取得
            System.String filePath = Application.StartupPath;
            this.dataSet1.ReadXml(filePath + "\\Resources\\prefecture.xml");
            gcComboBox1.DataSource = dataSet1.Tables[0];
            gcComboBox1.SelectedIndex = -1;

            for (int i = 1; i < gcComboBox1.ListColumns.Count; i++)
            {
                gcComboBox1.ListColumns[i].AutoWidth = true;
            }

            // xmlファイルからデータ取得（gcMaskedComboBox）
            this.dataSet2.ReadXml(filePath + "\\Resources\\pref.xml");
            gcMaskedComboBox1.DataSource = dataSet2.Tables[0];
            gcMaskedComboBox1.SelectedIndex = -1;

            for (int i = 1; i < gcMaskedComboBox1.ListColumns.Count; i++)
            {
                gcMaskedComboBox1.ListColumns[i].AutoWidth = true;
            }

        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  ボタンに表示するイメージ
            ((GrapeCity.Win.Editors.SymbolButton)gcTextBox1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
            ((GrapeCity.Win.Editors.SymbolButton)gcMask1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
            ((GrapeCity.Win.Editors.SymbolButton)gcDateTime1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
            ((GrapeCity.Win.Editors.SymbolButton)gcDate1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
            ((GrapeCity.Win.Editors.SymbolButton)gcTime1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
            ((GrapeCity.Win.Editors.SymbolButton)gcTimeSpan1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
            ((GrapeCity.Win.Editors.SymbolButton)gcNumber1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
            ((GrapeCity.Win.Editors.SymbolButton)gcComboBox1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
            ((GrapeCity.Win.Editors.SymbolButton)gcMaskedComboBox1.SideButtons[0]).Symbol = (GrapeCity.Win.Editors.Symbols)gcComboBox2.SelectedIndex - 1;
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  シンボルの表示方向
            ((GrapeCity.Win.Editors.SymbolButton)gcTextBox1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
            ((GrapeCity.Win.Editors.SymbolButton)gcMask1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
            ((GrapeCity.Win.Editors.SymbolButton)gcDateTime1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
            ((GrapeCity.Win.Editors.SymbolButton)gcDate1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
            ((GrapeCity.Win.Editors.SymbolButton)gcTime1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
            ((GrapeCity.Win.Editors.SymbolButton)gcTimeSpan1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
            ((GrapeCity.Win.Editors.SymbolButton)gcNumber1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
            ((GrapeCity.Win.Editors.SymbolButton)gcComboBox1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
            ((GrapeCity.Win.Editors.SymbolButton)gcMaskedComboBox1.SideButtons[0]).SymbolDirection = (GrapeCity.Win.Editors.SymbolDirection)gcComboBox3.SelectedIndex;
        }

        private void symbolButton_Click(object sender, EventArgs e)
        {
            // サイドボタンの動作
            switch (((GrapeCity.Win.Editors.SymbolButton)sender).Name)
            {
                case "symbolButton1":
                    // テキストコントロール
                    gcTextBox1.Clear();
                    break;
                case "symbolButton2":
                    // マスクコントロール
                    gcMask1.Value = "99999999999";
                    break;
                case "symbolButton3":
                    // 日付時刻コントロール
                    gcDateTime1.DroppedDown = !gcDateTime1.DroppedDown;
                    break;
                case "symbolButton4":
                    // 日付コントロール
                    gcDate1.DroppedDown = !gcDate1.DroppedDown;
                    break;
                case "symbolButton5":
                    // 時刻コントロール
                    gcTime1.Value = DateTime.Now.TimeOfDay;
                    break;
                case "symbolButton6":
                    // タイムスパンコントロール
                    gcTimeSpan1.Clear();
                    break;
                case "symbolButton7":
                    // 数値コントロール
                    gcNumber1.Value = 999;
                    break;
                case "symbolButton8":
                    // コンボコントロール
                    gcComboBox1.DroppedDown = !gcComboBox1.DroppedDown;
                    break;
                case "symbolButton9":
                    // マスクコンボコントロール
                    gcMaskedComboBox1.DroppedDown = !gcComboBox1.DroppedDown;
                    break;
                default:
                    break;
            }
        }
    }
}
