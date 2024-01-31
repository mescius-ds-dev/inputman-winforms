namespace InputManWin12_Demo._06_Display;

public partial class Alignment : InputManWin12_Demo.DemoBase_settings
{
    public Alignment()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定

        // ContentAlignmentプロパティ
        gcComboBox1.SelectedIndexChanged += (s, e) => SetContentAlignment();
        // DisplayAlignmentプロパティ
        gcComboBox2.SelectedIndexChanged += (s, e) => SetDisplayAlignment();
        // Paddingプロパティ
        gcNumber1.ValueChanged += (s, e) => SetPadding();
        gcNumber2.ValueChanged += (s, e) => SetPadding();
        gcNumber3.ValueChanged += (s, e) => SetPadding();
        gcNumber4.ValueChanged += (s, e) => SetPadding();

        // ***** 初期値
        gcComboBox1.SelectedIndex = 0;
        gcNumber1.Value = gcTextBox1.Padding.Top;
        gcNumber2.Value = gcTextBox1.Padding.Left;
        gcNumber3.Value = gcTextBox1.Padding.Right;
        gcNumber4.Value = gcTextBox1.Padding.Bottom;
        gcComboBox2.SelectedIndex = Convert.ToInt32(gcTextBox1.DisplayAlignment);
    }

    private void SetPadding()
    {
        gcTextBox1.Padding = new Padding((int)gcNumber2.Value.GetValueOrDefault()
                                       , (int)gcNumber1.Value.GetValueOrDefault()
                                       , (int)gcNumber3.Value.GetValueOrDefault()
                                       , (int)gcNumber4.Value.GetValueOrDefault());
    }

    private void SetContentAlignment()
    {
        gcTextBox1.ContentAlignment = GetContentAlignment();
    }

    private ContentAlignment GetContentAlignment() => gcComboBox1.SelectedIndex switch
    {
        0 => ContentAlignment.TopLeft,
        1 => ContentAlignment.TopCenter,
        2 => ContentAlignment.TopRight,
        3 => ContentAlignment.MiddleLeft,
        4 => ContentAlignment.MiddleCenter,
        5 => ContentAlignment.MiddleRight,
        6 => ContentAlignment.BottomLeft,
        7 => ContentAlignment.BottomCenter,
        8 => ContentAlignment.BottomRight,
        _ => throw new InvalidOperationException()
    };

    private void SetDisplayAlignment()
    {
        gcTextBox1.DisplayAlignment = (GrapeCity.Win.Editors.DisplayAlignment)gcComboBox2.SelectedIndex;
    }
}
