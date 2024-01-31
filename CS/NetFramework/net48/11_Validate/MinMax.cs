using System;
using System.Collections.Generic;

namespace InputManWin12_Demo._11_Validate
{
    public partial class MinMax : InputManWin12_Demo.DemoBase_settings
    {
        public MinMax()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcDateTime2.Validated += new EventHandler(gcDateTime2_Validated);
            gcDateTime3.Validated += new EventHandler(gcDateTime3_Validated);
            gcDate2.Validated += new EventHandler(gcDate2_Validated);
            gcDate3.Validated += new EventHandler(gcDate3_Validated);
            gcTime2.Validated += new EventHandler(gcTime2_Validated);
            gcTime3.Validated += new EventHandler(gcTime3_Validated);
            gcNumber2.Validated += new EventHandler(gcNumber2_Validated);
            gcNumber3.Validated += new EventHandler(gcNumber3_Validated);
            gcTimeSpan2.Validated += new EventHandler(gcTimeSpan2_Validated);
            gcTimeSpan3.Validated += new EventHandler(gcTimeSpan3_Validated);
            gcComboBox1.SelectedIndexChanged += new EventHandler(gcComboBox1_SelectedIndexChanged);

            // ***** 初期値
            gcDateTime1.MinDate = gcDateTime2.Value.Value;
            gcDateTime1.MaxDate = gcDateTime3.Value.Value;
            gcDate1.MinValue = gcDate2.Value.Value;
            gcDate1.MaxValue = gcDate3.Value.Value;
            gcTime1.MinValue = gcTime2.Value.Value;
            gcTime1.MaxValue = gcTime3.Value.Value;
            gcNumber1.MinValue = gcNumber2.Value.Value;
            gcNumber1.MaxValue = gcNumber3.Value.Value;
            gcTimeSpan1.MinValue = gcTimeSpan2.Value.Value;
            gcTimeSpan1.MaxValue = gcTimeSpan3.Value.Value;
            gcComboBox1.SelectedIndex = Convert.ToInt32(gcDateTime1.MaxMinBehavior);
        }

        private void gcDateTime2_Validated(object sender, EventArgs e)
        {
            List<GrapeCity.Win.Editors.GcDateTime> invalidControlList1 = gcDateTimeValidator1.GetInvalidControls();
            if (!invalidControlList1.Contains(gcDateTime2))
            {
                gcDateTime1.MinDate = gcDateTime2.Value.Value;
            }
        }

        private void gcDateTime3_Validated(object sender, EventArgs e)
        {
            List<GrapeCity.Win.Editors.GcDateTime> invalidControlList1 = gcDateTimeValidator1.GetInvalidControls();
            if (!invalidControlList1.Contains(gcDateTime3))
            {
                gcDateTime1.MaxDate = gcDateTime3.Value.Value;
            }
        }

        private void gcDate2_Validated(object sender, EventArgs e)
        {
            List<GrapeCity.Win.Editors.GcDate> invalidControlList1 = gcDateValidator1.GetInvalidControls();
            if (!invalidControlList1.Contains(gcDate2))
            {
                gcDate1.MinValue = gcDate2.Value.Value;
            }
        }

        private void gcDate3_Validated(object sender, EventArgs e)
        {
            List<GrapeCity.Win.Editors.GcDate> invalidControlList1 = gcDateValidator1.GetInvalidControls();
            if (!invalidControlList1.Contains(gcDate3))
            {
                gcDate1.MaxValue = gcDate3.Value.Value;
            }
        }

        private void gcTime2_Validated(object sender, EventArgs e)
        {
            List<GrapeCity.Win.Editors.GcTime> invalidControlList1 = gcTimeValidator1.GetInvalidControls();
            if (!invalidControlList1.Contains(gcTime2))
            {
                gcTime1.MinValue = gcTime2.Value.Value;
            }
        }

        private void gcTime3_Validated(object sender, EventArgs e)
        {
            List<GrapeCity.Win.Editors.GcTime> invalidControlList1 = gcTimeValidator1.GetInvalidControls();
            if (!invalidControlList1.Contains(gcTime3))
            {
                gcTime1.MaxValue = gcTime3.Value.Value;
            }
        }

        private void gcNumber2_Validated(object sender, EventArgs e)
        {
            List<GrapeCity.Win.Editors.GcNumber> invalidControlList1 = gcNumberValidator1.GetInvalidControls();
            if (!invalidControlList1.Contains(gcNumber2))
            {
                gcNumber1.MinValue = gcNumber2.Value.Value;
            }
        }

        private void gcNumber3_Validated(object sender, EventArgs e)
        {
            List<GrapeCity.Win.Editors.GcNumber> invalidControlList1 = gcNumberValidator1.GetInvalidControls();
            if (!invalidControlList1.Contains(gcNumber3))
            {
                gcNumber1.MaxValue = gcNumber3.Value.Value;
            }
        }

        private void gcTimeSpan2_Validated(object sender, EventArgs e)
        {
            List<GrapeCity.Win.Editors.GcTimeSpan> invalidControlList1 = gcTimeSpanValidator1.GetInvalidControls();
            if (!invalidControlList1.Contains(gcTimeSpan2))
            {
                gcTimeSpan1.MinValue = gcTimeSpan2.Value.Value;
            }
        }

        private void gcTimeSpan3_Validated(object sender, EventArgs e)
        {
            List<GrapeCity.Win.Editors.GcTimeSpan> invalidControlList1 = gcTimeSpanValidator1.GetInvalidControls();
            if (!invalidControlList1.Contains(gcTimeSpan3))
            {
                gcTimeSpan1.MaxValue = gcTimeSpan3.Value.Value;
            }
        }

        private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gcDateTime1.MaxMinBehavior = (GrapeCity.Win.Editors.MaxMinBehavior)gcComboBox1.SelectedIndex;
            gcDate1.MaxMinBehavior = (GrapeCity.Win.Editors.MaxMinBehavior)gcComboBox1.SelectedIndex;
            gcTime1.MaxMinBehavior = (GrapeCity.Win.Editors.MaxMinBehavior)gcComboBox1.SelectedIndex;
            gcNumber1.MaxMinBehavior = (GrapeCity.Win.Editors.MaxMinBehavior)gcComboBox1.SelectedIndex;
            gcTimeSpan1.MaxMinBehavior = (GrapeCity.Win.Editors.MaxMinBehavior)gcComboBox1.SelectedIndex;
        }
    }
}

