namespace InputManWin12_Demo._11_Validate;

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
        gcDateTime2.Validated += (s, e) => ValidategcDateTime2();
        gcDateTime3.Validated += (s, e) => ValidategcDateTime3();
        gcDate2.Validated += (s, e) => ValidateDate2();
        gcDate3.Validated += (s, e) => ValidateDate3();
        gcTime2.Validated += (s, e) => ValidatedTime2();
        gcTime3.Validated += (s, e) => ValidateTime3();
        gcNumber2.Validated += (s, e) => ValidateNumber2();
        gcNumber3.Validated += (s, e) => ValidateNumber3();
        gcTimeSpan2.Validated += (s, e) => ValidateTimeSpan2();
        gcTimeSpan3.Validated += (s, e) => ValidateTimeSpan3();
        gcComboBox1.SelectedIndexChanged += (s, e) => SetMaxMinBehavior();

        // ***** 初期値
        gcDateTime1.MinDate = gcDateTime2.Value.GetValueOrDefault();
        gcDateTime1.MaxDate = gcDateTime3.Value.GetValueOrDefault();
        gcDate1.MinValue = gcDate2.Value.GetValueOrDefault();
        gcDate1.MaxValue = gcDate3.Value.GetValueOrDefault();
        gcTime1.MinValue = gcTime2.Value.GetValueOrDefault();
        gcTime1.MaxValue = gcTime3.Value.GetValueOrDefault();
        gcNumber1.MinValue = gcNumber2.Value.GetValueOrDefault();
        gcNumber1.MaxValue = gcNumber3.Value.GetValueOrDefault();
        gcTimeSpan1.MinValue = gcTimeSpan2.Value.GetValueOrDefault();
        gcTimeSpan1.MaxValue = gcTimeSpan3.Value.GetValueOrDefault();
        gcComboBox1.SelectedIndex = Convert.ToInt32(gcDateTime1.MaxMinBehavior);
    }

    private void ValidategcDateTime2()
    {
        List<GrapeCity.Win.Editors.GcDateTime> invalidControlList1 = gcDateTimeValidator1.GetInvalidControls();
        if (!invalidControlList1.Contains(gcDateTime2))
        {
            gcDateTime1.MinDate = gcDateTime2.Value.GetValueOrDefault();
        }
    }

    private void ValidategcDateTime3()
    {
        List<GrapeCity.Win.Editors.GcDateTime> invalidControlList1 = gcDateTimeValidator1.GetInvalidControls();
        if (!invalidControlList1.Contains(gcDateTime3))
        {
            gcDateTime1.MaxDate = gcDateTime3.Value.GetValueOrDefault();
        }
    }

    private void ValidateDate2()
    {
        List<GrapeCity.Win.Editors.GcDate> invalidControlList1 = gcDateValidator1.GetInvalidControls();
        if (!invalidControlList1.Contains(gcDate2))
        {
            gcDate1.MinValue = gcDate2.Value.GetValueOrDefault();
        }
    }

    private void ValidateDate3()
    {
        List<GrapeCity.Win.Editors.GcDate> invalidControlList1 = gcDateValidator1.GetInvalidControls();
        if (!invalidControlList1.Contains(gcDate3))
        {
            gcDate1.MaxValue = gcDate3.Value.GetValueOrDefault();
        }
    }

    private void ValidatedTime2()
    {
        List<GrapeCity.Win.Editors.GcTime> invalidControlList1 = gcTimeValidator1.GetInvalidControls();
        if (!invalidControlList1.Contains(gcTime2))
        {
            gcTime1.MinValue = gcTime2.Value.GetValueOrDefault();
        }
    }

    private void ValidateTime3()
    {
        List<GrapeCity.Win.Editors.GcTime> invalidControlList1 = gcTimeValidator1.GetInvalidControls();
        if (!invalidControlList1.Contains(gcTime3))
        {
            gcTime1.MaxValue = gcTime3.Value.GetValueOrDefault();
        }
    }

    private void ValidateNumber2()
    {
        List<GrapeCity.Win.Editors.GcNumber> invalidControlList1 = gcNumberValidator1.GetInvalidControls();
        if (!invalidControlList1.Contains(gcNumber2))
        {
            gcNumber1.MinValue = gcNumber2.Value.GetValueOrDefault();
        }
    }

    private void ValidateNumber3()
    {
        List<GrapeCity.Win.Editors.GcNumber> invalidControlList1 = gcNumberValidator1.GetInvalidControls();
        if (!invalidControlList1.Contains(gcNumber3))
        {
            gcNumber1.MaxValue = gcNumber3.Value.GetValueOrDefault();
        }
    }

    private void ValidateTimeSpan2()
    {
        List<GrapeCity.Win.Editors.GcTimeSpan> invalidControlList1 = gcTimeSpanValidator1.GetInvalidControls();
        if (!invalidControlList1.Contains(gcTimeSpan2))
        {
            gcTimeSpan1.MinValue = gcTimeSpan2.Value.GetValueOrDefault();
        }
    }

    private void ValidateTimeSpan3()
    {
        List<GrapeCity.Win.Editors.GcTimeSpan> invalidControlList1 = gcTimeSpanValidator1.GetInvalidControls();
        if (!invalidControlList1.Contains(gcTimeSpan3))
        {
            gcTimeSpan1.MaxValue = gcTimeSpan3.Value.GetValueOrDefault();
        }
    }

    private void SetMaxMinBehavior()
    {
        gcDateTime1.MaxMinBehavior = (GrapeCity.Win.Editors.MaxMinBehavior)gcComboBox1.SelectedIndex;
        gcDate1.MaxMinBehavior = (GrapeCity.Win.Editors.MaxMinBehavior)gcComboBox1.SelectedIndex;
        gcTime1.MaxMinBehavior = (GrapeCity.Win.Editors.MaxMinBehavior)gcComboBox1.SelectedIndex;
        gcNumber1.MaxMinBehavior = (GrapeCity.Win.Editors.MaxMinBehavior)gcComboBox1.SelectedIndex;
        gcTimeSpan1.MaxMinBehavior = (GrapeCity.Win.Editors.MaxMinBehavior)gcComboBox1.SelectedIndex;
    }
}

