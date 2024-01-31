using System;

namespace InputManWin12_Demo._08_SideButton
{
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
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            checkBox2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);
            checkBox3.CheckedChanged += new EventHandler(checkBox3_CheckedChanged);
            checkBox4.CheckedChanged += new EventHandler(checkBox4_CheckedChanged);
            gcNumber2.ValueChanged += new EventHandler(gcNumber2_ValueChanged);
            gcNumber3.ValueChanged += new EventHandler(gcNumber3_ValueChanged);
            gcNumber4.ValueChanged += new EventHandler(gcNumber4_ValueChanged);
            gcNumber5.ValueChanged += new EventHandler(gcNumber5_ValueChanged);
            gcNumber6.ValueChanged += new EventHandler(gcNumber6_ValueChanged);
            gcNumber7.ValueChanged += new EventHandler(gcNumber7_ValueChanged);
            gcNumber8.ValueChanged += new EventHandler(gcNumber8_ValueChanged);
            gcNumber9.ValueChanged += new EventHandler(gcNumber9_ValueChanged);
            gcTimeSpan2.ValueChanged += new EventHandler(gcTimeSpan2_ValueChanged);
            gcTimeSpan3.ValueChanged += new EventHandler(gcTimeSpan3_ValueChanged);
            gcTimeSpan4.ValueChanged += new EventHandler(gcTimeSpan4_ValueChanged);
            gcTimeSpan5.ValueChanged += new EventHandler(gcTimeSpan5_ValueChanged);
            gcComboBox4.SelectedIndexChanged += new EventHandler(gcComboBox4_SelectedIndexChanged);
            gcComboBox5.SelectedIndexChanged += new EventHandler(gcComboBox5_SelectedIndexChanged);
            gcComboBox6.SelectedIndexChanged += new EventHandler(gcComboBox6_SelectedIndexChanged);
            gcComboBox7.SelectedIndexChanged += new EventHandler(gcComboBox7_SelectedIndexChanged);

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // AllowSpinプロパティ
            gcMask1.Spin.AllowSpin = checkBox1.Checked;
            gcComboBox1.Spin.AllowSpin = checkBox1.Checked;
            gcDateTime1.Spin.AllowSpin = checkBox1.Checked;
            gcDate1.Spin.AllowSpin = checkBox1.Checked;
            gcTime1.Spin.AllowSpin = checkBox1.Checked;
            gcTimeSpan1.Spin.AllowSpin = checkBox1.Checked;
            gcNumber1.Spin.AllowSpin = checkBox1.Checked;
            gcMaskedComboBox1.Spin.AllowSpin = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // SpinOnKeysプロパティ
            gcMask1.Spin.SpinOnKeys = checkBox2.Checked;
            gcComboBox1.Spin.SpinOnKeys = checkBox2.Checked;
            gcDateTime1.Spin.SpinOnKeys = checkBox2.Checked;
            gcDate1.Spin.SpinOnKeys = checkBox2.Checked;
            gcTime1.Spin.SpinOnKeys = checkBox2.Checked;
            gcTimeSpan1.Spin.SpinOnKeys = checkBox2.Checked;
            gcNumber1.Spin.SpinOnKeys = checkBox2.Checked;
            gcMaskedComboBox1.Spin.SpinOnKeys = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // Wrapプロパティ
            gcMask1.Spin.Wrap = checkBox3.Checked;
            gcComboBox1.Spin.Wrap = checkBox3.Checked;
            gcDateTime1.Spin.Wrap = checkBox3.Checked;
            gcDate1.Spin.Wrap = checkBox3.Checked;
            gcTime1.Spin.Wrap = checkBox3.Checked;
            gcTimeSpan1.Spin.Wrap = checkBox3.Checked;
            gcNumber1.Spin.Wrap = checkBox3.Checked;
            gcMaskedComboBox1.Spin.Wrap = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // SpinOnWheelプロパティ
            gcMask1.Spin.SpinOnWheel = checkBox4.Checked;
            gcComboBox1.Spin.SpinOnWheel = checkBox4.Checked;
            gcDateTime1.Spin.SpinOnWheel = checkBox4.Checked;
            gcDate1.Spin.SpinOnWheel = checkBox4.Checked;
            gcTime1.Spin.SpinOnWheel = checkBox4.Checked;
            gcTimeSpan1.Spin.SpinOnWheel = checkBox4.Checked;
            gcNumber1.Spin.SpinOnWheel = checkBox4.Checked;
            gcMaskedComboBox1.Spin.SpinOnWheel = checkBox4.Checked;
        }

        private void gcNumber2_ValueChanged(object sender, EventArgs e)
        {
            // マスクのIncrementプロパティ
            gcMask1.Spin.Increment = Convert.ToInt32(gcNumber2.Value);
        }

        private void gcComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 日付時刻のSpinModeプロパティ
            gcDateTime1.Spin.SpinMode = (GrapeCity.Win.Editors.DateSpinMode)gcComboBox4.SelectedIndex;
        }

        private void gcNumber3_ValueChanged(object sender, EventArgs e)
        {
            // 日付時刻のIncrementプロパティ
            gcDateTime1.Spin.Increment = Convert.ToInt32(gcNumber3.Value);
        }

        private void gcTimeSpan2_ValueChanged(object sender, EventArgs e)
        {
            // 日付時刻のIncrementValueプロパティ
            if (gcTimeSpan2.Value != null)
            {
                gcDateTime1.Spin.IncrementValue = gcTimeSpan2.Value.Value;
            }
        }

        private void gcComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 日付のSpinModeプロパティ
            gcDate1.Spin.SpinMode = (GrapeCity.Win.Editors.DateSpinMode)gcComboBox5.SelectedIndex;
        }

        private void gcNumber4_ValueChanged(object sender, EventArgs e)
        {
            // 日付のIncrementプロパティ
            gcDate1.Spin.Increment = Convert.ToInt32(gcNumber4.Value);
        }

        private void gcTimeSpan3_ValueChanged(object sender, EventArgs e)
        {
            // 日付のIncrementValueプロパティ
            if (gcTimeSpan3.Value != null)
            {
                gcDate1.Spin.IncrementValue = gcTimeSpan3.Value.Value;
            }
        }

        private void gcComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 時刻のSpinModeプロパティ
            gcTime1.Spin.SpinMode = (GrapeCity.Win.Editors.DateSpinMode)gcComboBox6.SelectedIndex;
        }

        private void gcNumber5_ValueChanged(object sender, EventArgs e)
        {
            // 時刻のIncrementプロパティ
            gcTime1.Spin.Increment = Convert.ToInt32(gcNumber5.Value);
        }

        private void gcTimeSpan4_ValueChanged(object sender, EventArgs e)
        {
            // 時刻のIncrementValueプロパティ
            if (gcTimeSpan4.Value != null)
            {
                gcTime1.Spin.IncrementValue = gcTimeSpan4.Value.Value;
            }
        }

        private void gcComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            // タイムスパンのSpinModeプロパティ
            gcTimeSpan1.Spin.SpinMode = (GrapeCity.Win.Editors.DateSpinMode)gcComboBox7.SelectedIndex;
        }

        private void gcNumber6_ValueChanged(object sender, EventArgs e)
        {
            // タイムスパンのIncrementプロパティ
            gcTimeSpan1.Spin.Increment = Convert.ToInt32(gcNumber6.Value);
        }

        private void gcTimeSpan5_ValueChanged(object sender, EventArgs e)
        {
            // タイムスパンのIncrementValueプロパティ
            if (gcTimeSpan5.Value != null)
            {
                gcTimeSpan1.Spin.IncrementValue = gcTimeSpan5.Value.Value;
            }
        }

        private void gcComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 数値のSpinModeプロパティ
            gcNumber1.Spin.SpinMode = (GrapeCity.Win.Editors.NumberSpinMode)gcComboBox8.SelectedIndex;
        }

        private void gcNumber7_ValueChanged(object sender, EventArgs e)
        {
            // 数値のIncrementプロパティ
            gcNumber1.Spin.Increment = Convert.ToInt32(gcNumber7.Value);
        }

        private void gcNumber8_ValueChanged(object sender, EventArgs e)
        {
            // 数値のIncrementValueプロパティ
            gcNumber1.Spin.IncrementValue = Convert.ToInt32(gcNumber8.Value);
        }

        private void gcNumber9_ValueChanged(object sender, EventArgs e)
        {
            // コンボのIncrementプロパティ
            gcComboBox1.Spin.Increment = Convert.ToInt32(gcNumber9.Value);
            gcMaskedComboBox1.Spin.Increment = Convert.ToInt32(gcNumber9.Value);
        }
    }
}
