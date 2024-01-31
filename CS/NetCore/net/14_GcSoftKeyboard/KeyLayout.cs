using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._14_GcSoftKeyboard;

public partial class KeyLayout : InputManWin12_Demo.DemoBase_settings
{
    public KeyLayout()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // 初期設定
        this.Load += (s, e) => InitSelectedIndex();


        gcComboBox1.SelectedIndexChanged += (s, e) =>
            // テキストコントロールのキーレイアウトを設定
            gcSoftKeyboard1.SetDefaultKeyboardLayout(gcTextBox1, (SoftKeyboardLayout)gcComboBox1.SelectedIndex);

        gcComboBox2.SelectedIndexChanged += (s, e) =>
             // マスクコントロールのキーレイアウトを設定
             gcSoftKeyboard1.SetDefaultKeyboardLayout(gcMask1, (SoftKeyboardLayout)gcComboBox2.SelectedIndex);

        gcComboBox3.SelectedIndexChanged += (s, e) =>
            // 日付コントロールのキーレイアウトを設定
            gcSoftKeyboard1.SetDefaultKeyboardLayout(gcDate1, (SoftKeyboardLayout)gcComboBox3.SelectedIndex);

        gcComboBox4.SelectedIndexChanged += (s, e) =>
            // 数値コントロールのキーレイアウトを設定
            gcSoftKeyboard1.SetDefaultKeyboardLayout(gcNumber1, (SoftKeyboardLayout)gcComboBox4.SelectedIndex);

        // ひらがなレイアウトのキー配置を設定
        checkBox1.CheckedChanged += (s, e) =>
            gcSoftKeyboard1.KanaInputLayout =
                checkBox1.Checked
                ? SoftKeyboardKanaInputLayout.Syllabary
                : SoftKeyboardKanaInputLayout.TwelveButtons;

        // 表示モードを設定
        gcComboBox5.SelectedIndexChanged += (s, e) => SetKeyboardPositioningMode();

        gcComboBox6.SelectedIndexChanged += (s, e) =>
            // スクリーンに対しての表示位置を設定
            gcSoftKeyboard1.PopupPosition = (SoftKeyboardPopupPosition)gcComboBox6.SelectedIndex;

        gcComboBox7.SelectedIndexChanged += (s, e) =>
            // コントロールに対しての表示位置を設定
            gcSoftKeyboard1.DropDownDirection = (DropDownDirection)gcComboBox7.SelectedIndex;
    }

    private void InitSelectedIndex()
    {
        gcComboBox1.SelectedIndex = 8;
        gcComboBox2.SelectedIndex = 5;
        gcComboBox3.SelectedIndex = 0;
        gcComboBox4.SelectedIndex = 2;
        gcComboBox5.SelectedIndex = 1;
        gcComboBox6.SelectedIndex = 1;
        gcComboBox7.SelectedIndex = 2;
        gcComboBox7.Enabled = false;
    }

    private void SetKeyboardPositioningMode()
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
}
