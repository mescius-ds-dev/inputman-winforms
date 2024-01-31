using GrapeCity.Win.Editors;
using System;

namespace InputManWin12_Demo._14_GcSoftKeyboard
{
    public partial class KeyLayout : InputManWin12_Demo.DemoBase_settings
    {
        public KeyLayout()
        {
            InitializeComponent();
        }

        private void KeyLayout_Load(object sender, EventArgs e)
        {
            // 初期設定
            gcComboBox1.SelectedIndex = 8;
            gcComboBox2.SelectedIndex = 5;
            gcComboBox3.SelectedIndex = 0;
            gcComboBox4.SelectedIndex = 2;
            gcComboBox5.SelectedIndex = 1;
            gcComboBox6.SelectedIndex = 1;
            gcComboBox7.SelectedIndex = 2;
            gcComboBox7.Enabled = false;
            
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // テキストコントロールのキーレイアウトを設定
            gcSoftKeyboard1.SetDefaultKeyboardLayout(gcTextBox1, (SoftKeyboardLayout)gcComboBox1.SelectedIndex);
        }

        private void gcComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // マスクコントロールのキーレイアウトを設定
            gcSoftKeyboard1.SetDefaultKeyboardLayout(gcMask1, (SoftKeyboardLayout)gcComboBox2.SelectedIndex);
        }

        private void gcComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 日付コントロールのキーレイアウトを設定
            gcSoftKeyboard1.SetDefaultKeyboardLayout(gcDate1, (SoftKeyboardLayout)gcComboBox3.SelectedIndex);
        }

        private void gcComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 数値コントロールのキーレイアウトを設定
            gcSoftKeyboard1.SetDefaultKeyboardLayout(gcNumber1, (SoftKeyboardLayout)gcComboBox4.SelectedIndex);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // ひらがなレイアウトのキー配置を設定
            gcSoftKeyboard1.KanaInputLayout = checkBox1.Checked ? SoftKeyboardKanaInputLayout.Syllabary : SoftKeyboardKanaInputLayout.TwelveButtons;
        }

        private void gcComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 表示モードを設定
            gcSoftKeyboard1.KeyboardPositioningMode = (SoftKeyboardPositioningMode)gcComboBox5.SelectedIndex;

            if (gcComboBox5.SelectedIndex == 0)
            {
                gcComboBox6.Enabled = false;
                gcComboBox7.Enabled = true;
            }
            else
            {
                gcComboBox6.Enabled = true;
                gcComboBox7.Enabled = false;
            }
        }

        private void gcComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            // スクリーンに対しての表示位置を設定
            gcSoftKeyboard1.PopupPosition = (SoftKeyboardPopupPosition)gcComboBox6.SelectedIndex;
        }

        private void gcComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            // コントロールに対しての表示位置を設定
            gcSoftKeyboard1.DropDownDirection = (DropDownDirection)gcComboBox7.SelectedIndex;
        }
    }
}
