using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._12_Address;

public partial class GcAddress : InputManWin12_Demo.DemoBase_settings
{
    public GcAddress()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        gcComboBox1.SelectedIndexChanged += (s, e) => SetSearchTarget();


        checkBox1.CheckedChanged += (s, e) =>
            // ClearTargetプロパティ
            gcAddress1.GetAddressOutputSetting(gcCharMask1).ClearTarget = checkBox1.Checked;

        // SplitAreaDetailsプロパティ
        checkBox2.CheckedChanged += (s, e) => SetSplitAreaDetails();

        // GenerateCompanyAddressKanaプロパティ
        checkBox3.CheckedChanged += (s, e) => SetGenerateCompanyAddressKana();

        // ***** 初期値
        checkBox1.Checked = gcAddress1.GetAddressOutputSetting(gcCharMask1).ClearTarget;
        gcComboBox1.SelectedIndex = ((Int32)gcAddress1.GetAddressOutputSetting(gcCharMask1).AddressQuerymode) - 1;
        checkBox3.Enabled = false;

        gcTextBox1.Enabled = false;
        gcTextBox2.Enabled = false;
        gcTextBox3.Enabled = false;
        gcTextBox4.Enabled = false;
        gcTextBox5.Enabled = false;
        gcTextBox1.DisabledForeColor = Color.Black;
        gcTextBox2.DisabledForeColor = Color.Black;
        gcTextBox3.DisabledForeColor = Color.Black;
        gcTextBox4.DisabledForeColor = Color.Black;
        gcTextBox5.DisabledForeColor = Color.Black;
    }

    private void SetSearchTarget()
    {
        // AddressQueryMode プロパティ
        gcAddress1.GetAddressOutputSetting(gcCharMask1).AddressQuerymode = (AddressQuerymode)gcComboBox1.SelectedIndex + 1;

        gcCharMask1.CharBoxes.Clear();
        gcCharMask1.AutoSize = true;

        var borderSingle = new CharBoxBorder(new Line(LineStyle.Single, Color.Black));
        var borderNone = new CharBoxBorder(new Line(LineStyle.None, Color.Empty));

        // 郵便番号の前の3桁用の枠を作成します。  
        var aInputBoxl = new InputBox
        {
            AutoSize = false,
            Size = new System.Drawing.Size(17, 20),
            Border = borderSingle,
            Margin = new System.Windows.Forms.Padding(2)
        };

        // ハイフンを作成します。  
        var aSeparatorBox = new SeparatorBox
        {
            AutoSize = false,
            Size = new System.Drawing.Size(8, 20),
            Border = borderNone,
            Margin = new System.Windows.Forms.Padding(0, 2, 0, 2),
        };
        aSeparatorBox.ResetFont();

        // 郵便番号の後の4桁用の枠を作成します。  
        var aInputBoxs = new InputBox
        {
            AutoSize = false,
            Size = new System.Drawing.Size(15, 17),
            Border = borderSingle,
            Margin = new System.Windows.Forms.Padding(2)
        };

        switch (gcComboBox1.SelectedIndex)
        {
            case 0:
            case 1:
            case 2:
                // 郵便番号
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxl.Clone());
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxl.Clone());
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxl.Clone());
                gcCharMask1.CharBoxes.Add(aSeparatorBox);
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxs.Clone());
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxs.Clone());
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxs.Clone());
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxs.Clone());
                break;
            case 3:
                // 市外局番
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxl.Clone());
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxl.Clone());
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxl.Clone());
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxl.Clone());
                break;
            case 4:
                // 全国地方公共団体コード
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxl.Clone());
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxl.Clone());
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxl.Clone());
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxl.Clone());
                gcCharMask1.CharBoxes.Add((CharBox)aInputBoxl.Clone());
                break;
            default:
                break;
        }

        switch (gcComboBox1.SelectedIndex)
        {
            case 0:
                label2.Text = "住所の郵便番号：";
                break;
            case 1:
                label2.Text = "事業所の個別郵便番号：";
                break;
            case 2:
                label2.Text = "住所の郵便番号／事業所の個別郵便番号：";
                break;
            case 3:
                label2.Text = "市外局番：";
                break;
            case 4:
                label2.Text = "全国地方公共団体コード：";
                break;
            default:
                break;
        }

        // 出力／未出力対象のコントロールの色を変えます。
        Color cOut = gcTextBox1.DisabledBackColor;
        Color cNon = Color.Silver;
        switch (gcComboBox1.SelectedIndex)
        {
            case 0:
            case 1:
            case 2:
                gcTextBox1.DisabledBackColor = cOut;
                gcTextBox2.DisabledBackColor = cOut;
                gcTextBox3.DisabledBackColor = cOut;
                gcTextBox4.DisabledBackColor = cOut;
                gcTextBox5.DisabledBackColor = cNon;
                break;
            case 3:
                gcTextBox1.DisabledBackColor = cOut;
                gcTextBox2.DisabledBackColor = cNon;
                gcTextBox3.DisabledBackColor = cNon;
                gcTextBox4.DisabledBackColor = cNon;
                gcTextBox5.DisabledBackColor = cOut;
                break;
            case 4:
                gcTextBox1.DisabledBackColor = cOut;
                gcTextBox2.DisabledBackColor = cOut;
                gcTextBox3.DisabledBackColor = cNon;
                gcTextBox4.DisabledBackColor = cOut;
                gcTextBox5.DisabledBackColor = cNon;
                break;
            default:
                break;
        }

        if (gcComboBox1.SelectedIndex == 1 || gcComboBox1.SelectedIndex == 2)
        {
            checkBox3.Enabled = true;
            checkBox3.Checked = gcAddress1.GetAddressOutputSetting(gcCharMask1).GenerateCompanyAddressKana;
        }
        else
        {
            checkBox3.Enabled = false;
        }

        gcTextBox1.Clear();
        gcTextBox2.Clear();
        gcTextBox3.Clear();
        gcTextBox4.Clear();
        gcTextBox5.Clear();
    }

    private void SetSplitAreaDetails()
    {
        string val = gcCharMask1.Value;

        gcAddress1.GetAddressOutputSetting(gcCharMask1).SplitAreaDetails = checkBox2.Checked;

        gcCharMask1.Clear();
        gcCharMask1.Value = val;
    }

    private void SetGenerateCompanyAddressKana()
    {
        string val = gcCharMask1.Value;

        gcAddress1.GetAddressOutputSetting(gcCharMask1).GenerateCompanyAddressKana = checkBox3.Checked;

        gcCharMask1.Clear();
        gcCharMask1.Value = val;
    }
}
