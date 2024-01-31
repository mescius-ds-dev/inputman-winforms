namespace InputManWin12_Demo._08_SideButton;

public partial class SpinButton : InputManWin12_Demo.DemoBase_settings
{
    public SpinButton()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        // AllowSpinプロパティ
        checkBox1.CheckedChanged += (s, e) => SetAllowSpin();
        // SpinOnKeysプロパティ
        checkBox2.CheckedChanged += (s, e) => SetSpinOnKeys();
        // Wrapプロパティ
        checkBox3.CheckedChanged += (s, e) => SetWrap();
        // SpinOnWheelプロパティ
        checkBox4.CheckedChanged += (s, e) => SetSpinOnWheel();
        // マスクのIncrementプロパティ
        gcNumber2.ValueChanged += (s, e) => gcMask1.Spin.Increment = Convert.ToInt32(gcNumber2.Value);
        // 日付時刻のIncrementプロパティ
        gcNumber3.ValueChanged += (s, e) => gcDateTime1.Spin.Increment = Convert.ToInt32(gcNumber3.Value);
        // 日付のIncrementプロパティ
        gcNumber4.ValueChanged += (s, e) => gcDate1.Spin.Increment = Convert.ToInt32(gcNumber4.Value);
        // 時刻のIncrementプロパティ
        gcNumber5.ValueChanged += (s, e) => gcTime1.Spin.Increment = Convert.ToInt32(gcNumber5.Value);
        // タイムスパンのIncrementプロパティ
        gcNumber6.ValueChanged += (s, e) => gcTimeSpan1.Spin.Increment = Convert.ToInt32(gcNumber6.Value);
        // 数値のIncrementプロパティ
        gcNumber7.ValueChanged += (s, e) => gcNumber1.Spin.Increment = Convert.ToInt32(gcNumber7.Value);
        // 数値のIncrementValueプロパティ
        gcNumber8.ValueChanged += (s, e) => gcNumber1.Spin.IncrementValue = Convert.ToInt32(gcNumber8.Value);
        // コンボのIncrementプロパティ
        gcNumber9.ValueChanged += (s, e) => SetIncrementToCombo();
        // 日付時刻のIncrementValueプロパティ
        gcTimeSpan2.ValueChanged += (s, e) => SetIncrementValueToDateTime();
        // 日付のIncrementValueプロパティ
        gcTimeSpan3.ValueChanged += (s, e) => SetTimeSpanToDate();
        // 時刻のIncrementValueプロパティ
        gcTimeSpan4.ValueChanged += (s, e) => SetIncrementValueToTime();
        // タイムスパンのIncrementValueプロパティ
        gcTimeSpan5.ValueChanged += (s, e) => SetIncrementValueToTimeSpan();
        // 日付時刻のSpinModeプロパティ
        gcComboBox4.SelectedIndexChanged += (s, e) =>
            gcDateTime1.Spin.SpinMode = (GrapeCity.Win.Editors.DateSpinMode)gcComboBox4.SelectedIndex;
        // 日付のSpinModeプロパティ
        gcComboBox5.SelectedIndexChanged += (s, e) =>
            gcDate1.Spin.SpinMode = (GrapeCity.Win.Editors.DateSpinMode)gcComboBox5.SelectedIndex;
        // 時刻のSpinModeプロパティ
        gcComboBox6.SelectedIndexChanged += (s, e) =>
            gcTime1.Spin.SpinMode = (GrapeCity.Win.Editors.DateSpinMode)gcComboBox6.SelectedIndex;
        // タイムスパンのSpinModeプロパティ
        gcComboBox7.SelectedIndexChanged += (s, e) =>
            gcTimeSpan1.Spin.SpinMode = (GrapeCity.Win.Editors.DateSpinMode)gcComboBox7.SelectedIndex;

        // ***** 初期値
        checkBox1.Checked = gcMask1.Spin.AllowSpin;
        checkBox2.Checked = gcMask1.Spin.SpinOnKeys;
        checkBox3.Checked = gcMask1.Spin.Wrap;
        checkBox4.Checked = gcMask1.Spin.SpinOnWheel;

        gcNumber2.Value = Convert.ToDecimal(gcMask1.Spin.Increment);

        gcComboBox4.SelectedIndex = Convert.ToInt32(gcDateTime1.Spin.SpinMode);
        gcNumber3.Value = Convert.ToInt32(gcDateTime1.Spin.Increment);
        gcTimeSpan2.Value = gcDateTime1.Spin.IncrementValue;

        gcComboBox5.SelectedIndex = Convert.ToInt32(gcDate1.Spin.SpinMode);
        gcNumber4.Value = Convert.ToInt32(gcDate1.Spin.Increment);
        gcTimeSpan3.Value = gcDate1.Spin.IncrementValue;

        gcComboBox6.SelectedIndex = Convert.ToInt32(gcTime1.Spin.SpinMode);
        gcNumber5.Value = Convert.ToInt32(gcTime1.Spin.Increment);
        gcTimeSpan4.Value = gcTime1.Spin.IncrementValue;

        gcComboBox7.SelectedIndex = Convert.ToInt32(gcTimeSpan1.Spin.SpinMode);
        gcNumber6.Value = Convert.ToInt32(gcTimeSpan1.Spin.Increment);
        gcTimeSpan5.Value = gcTimeSpan1.Spin.IncrementValue;

        gcComboBox8.SelectedIndex = Convert.ToInt32(gcNumber1.Spin.SpinMode);
        gcNumber7.Value = Convert.ToDecimal(gcNumber1.Spin.Increment);
        gcNumber8.Value = Convert.ToDecimal(gcNumber1.Spin.IncrementValue);

        gcNumber9.Value = Convert.ToDecimal(gcComboBox1.Spin.Increment);
        gcNumber9.Value = Convert.ToDecimal(gcMaskedComboBox1.Spin.Increment);
    }

    private void SetAllowSpin()
    {
        gcMask1.Spin.AllowSpin = checkBox1.Checked;
        gcComboBox1.Spin.AllowSpin = checkBox1.Checked;
        gcDateTime1.Spin.AllowSpin = checkBox1.Checked;
        gcDate1.Spin.AllowSpin = checkBox1.Checked;
        gcTime1.Spin.AllowSpin = checkBox1.Checked;
        gcTimeSpan1.Spin.AllowSpin = checkBox1.Checked;
        gcNumber1.Spin.AllowSpin = checkBox1.Checked;
        gcMaskedComboBox1.Spin.AllowSpin = checkBox1.Checked;
    }

    private void SetSpinOnKeys()
    {
        gcMask1.Spin.SpinOnKeys = checkBox2.Checked;
        gcComboBox1.Spin.SpinOnKeys = checkBox2.Checked;
        gcDateTime1.Spin.SpinOnKeys = checkBox2.Checked;
        gcDate1.Spin.SpinOnKeys = checkBox2.Checked;
        gcTime1.Spin.SpinOnKeys = checkBox2.Checked;
        gcTimeSpan1.Spin.SpinOnKeys = checkBox2.Checked;
        gcNumber1.Spin.SpinOnKeys = checkBox2.Checked;
        gcMaskedComboBox1.Spin.SpinOnKeys = checkBox2.Checked;
    }

    private void SetWrap()
    {
        gcMask1.Spin.Wrap = checkBox3.Checked;
        gcComboBox1.Spin.Wrap = checkBox3.Checked;
        gcDateTime1.Spin.Wrap = checkBox3.Checked;
        gcDate1.Spin.Wrap = checkBox3.Checked;
        gcTime1.Spin.Wrap = checkBox3.Checked;
        gcTimeSpan1.Spin.Wrap = checkBox3.Checked;
        gcNumber1.Spin.Wrap = checkBox3.Checked;
        gcMaskedComboBox1.Spin.Wrap = checkBox3.Checked;
    }

    private void SetSpinOnWheel()
    {
        gcMask1.Spin.SpinOnWheel = checkBox4.Checked;
        gcComboBox1.Spin.SpinOnWheel = checkBox4.Checked;
        gcDateTime1.Spin.SpinOnWheel = checkBox4.Checked;
        gcDate1.Spin.SpinOnWheel = checkBox4.Checked;
        gcTime1.Spin.SpinOnWheel = checkBox4.Checked;
        gcTimeSpan1.Spin.SpinOnWheel = checkBox4.Checked;
        gcNumber1.Spin.SpinOnWheel = checkBox4.Checked;
        gcMaskedComboBox1.Spin.SpinOnWheel = checkBox4.Checked;
    }

    private void SetIncrementToCombo()
    {
        gcComboBox1.Spin.Increment = Convert.ToInt32(gcNumber9.Value);
        gcMaskedComboBox1.Spin.Increment = Convert.ToInt32(gcNumber9.Value);
    }

    private void SetIncrementValueToDateTime()
    {
        if (gcTimeSpan2.Value != null)
        {
            gcDateTime1.Spin.IncrementValue = gcTimeSpan2.Value.Value;
        }
    }

    private void SetTimeSpanToDate()
    {
        if (gcTimeSpan3.Value != null)
        {
            gcDate1.Spin.IncrementValue = gcTimeSpan3.Value.Value;
        }
    }

    private void SetIncrementValueToTime()
    {
        if (gcTimeSpan4.Value != null)
        {
            gcTime1.Spin.IncrementValue = gcTimeSpan4.Value.Value;
        }
    }

    private void SetIncrementValueToTimeSpan()
    {
        if (gcTimeSpan5.Value != null)
        {
            gcTimeSpan1.Spin.IncrementValue = gcTimeSpan5.Value.Value;
        }
    }
}
