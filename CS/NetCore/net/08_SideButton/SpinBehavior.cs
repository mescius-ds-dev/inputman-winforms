using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._08_SideButton;

public partial class SpinBehavior : InputManWin12_Demo.DemoBase_settings
{
    public SpinBehavior()
    {
        InitializeComponent();
        InitializeForm();
    }

    private void InitializeForm()
    {
        // ***** 初期設定
        gcComboBox2.SelectedIndex = 0;
        gcComboBox2.SelectedIndexChanged += (s, e) => ChangeButtonType();
        gcComboBox3.Enabled = false;
        gcComboBox3.SelectedIndex = 0;
        gcComboBox3.SelectedIndexChanged += (s, e) => SetButtonPositions();
        gcComboBox4.Enabled = false;
        gcComboBox4.SelectedIndex = 0;
        gcComboBox4.SelectedIndexChanged += (s, e) => SetButtons();

        gcMaskedComboBox1.SelectedIndex = 0;
    }

    private void ClearSideButton()
    {
        // サイドボタンをクリア
        gcMask1.SideButtons.Clear();
        gcDateTime1.SideButtons.Clear();
        gcDate1.SideButtons.Clear();
        gcTime1.SideButtons.Clear();
        gcTimeSpan1.SideButtons.Clear();
        gcNumber1.SideButtons.Clear();
        gcComboBox1.SideButtons.Clear();
        gcMaskedComboBox1.SideButtons.Clear();
    }

    private void AddSpinButtons()
    {
        // スピンボタンを追加
        gcMask1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
        gcDateTime1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
        gcDate1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
        gcTime1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
        gcTimeSpan1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
        gcNumber1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
        gcComboBox1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
        gcMaskedComboBox1.SideButtons.Add(new GrapeCity.Win.Editors.SpinButton());
    }

    private void ChangeButtonType()
    {
        SetEnabled();
        SetButtons();
    }

    private void SetEnabled()
    {
        if (gcComboBox2.SelectedIndex == 0)
        {
            gcComboBox3.Enabled = false;
            gcComboBox4.Enabled = false;
        }
        else if (gcComboBox2.SelectedIndex == 1)
        {
            gcComboBox3.Enabled = true;
            gcComboBox4.Enabled = true;
        }
        else if (gcComboBox2.SelectedIndex == 2)
        {
            gcComboBox3.Enabled = true;
            gcComboBox4.Enabled = true;
        }
    }

    private void SetButtons()
    {
        ClearSideButton();

        if (gcComboBox2.SelectedIndex == 0)
        {
            AddSpinButtons();
        }
        else if (gcComboBox2.SelectedIndex == 1)
        {
            AddSideButtons();
        }
        else if (gcComboBox2.SelectedIndex == 2)
        {
            AddSymbolButtons();
        }
    }

    void SetButtonPositions()
    {
        // ボタンの表示位置を変更
        ChangePosition(gcMask1.SideButtons[0], gcMask1.SideButtons[1]);
        ChangePosition(gcDateTime1.SideButtons[0], gcDateTime1.SideButtons[1]);
        ChangePosition(gcDate1.SideButtons[0], gcDate1.SideButtons[1]);
        ChangePosition(gcTime1.SideButtons[0], gcTime1.SideButtons[1]);
        ChangePosition(gcTimeSpan1.SideButtons[0], gcTimeSpan1.SideButtons[1]);
        ChangePosition(gcNumber1.SideButtons[0], gcNumber1.SideButtons[1]);
        ChangePosition(gcComboBox1.SideButtons[0], gcComboBox1.SideButtons[1]);
        ChangePosition(gcMaskedComboBox1.SideButtons[0], gcMaskedComboBox1.SideButtons[1]);
    }

    private void AddSideButtons()
    {
        // スピン機能を割り当てたサイドボタンを追加
        AddSideButton(gcMask1);
        AddSideButton(gcDateTime1);
        AddSideButton(gcDate1);
        AddSideButton(gcTime1);
        AddSideButton(gcTimeSpan1);
        AddSideButton(gcNumber1);
        AddSideButton(gcComboBox1);
        AddSideButton(gcMaskedComboBox1);
    }

    // スピン機能を持つサイドボタンを追加
    private void AddSideButton(EditBase control)
    {
        var leftButton = new GrapeCity.Win.Editors.SideButton();
        var rightButton = new GrapeCity.Win.Editors.SideButton();

        // SideButtonBehaviorプロパティ
        if (gcComboBox4.SelectedIndex == 0)
        {
            leftButton.Behavior = SideButtonBehavior.SpinDown;
            rightButton.Behavior = SideButtonBehavior.SpinUp;
        }
        else
        {
            leftButton.Behavior = SideButtonBehavior.SpinUp;
            rightButton.Behavior = SideButtonBehavior.SpinDown;
        }
        AddButtons(leftButton, rightButton, control);
    }

    private void AddSymbolButtons()
    {
        // スピン機能を割り当てたシンボルボタンを追加
        AddSymbolButton(gcMask1);
        AddSymbolButton(gcDateTime1);
        AddSymbolButton(gcDate1);
        AddSymbolButton(gcTime1);
        AddSymbolButton(gcTimeSpan1);
        AddSymbolButton(gcNumber1);
        AddSymbolButton(gcComboBox1);
        AddSymbolButton(gcMaskedComboBox1);
    }

    // スピン機能を持つシンボルボタンを追加
    void AddSymbolButton(EditBase control)
    {
        var leftButton = new GrapeCity.Win.Editors.SymbolButton();
        var rightButton = new GrapeCity.Win.Editors.SymbolButton();

        // SideButtonBehaviorプロパティ
        if (gcComboBox4.SelectedIndex == 0)
        {
            leftButton.Behavior = SideButtonBehavior.SpinDown;
            rightButton.Behavior = SideButtonBehavior.SpinUp;
        }
        else
        {
            leftButton.Behavior = SideButtonBehavior.SpinUp;
            rightButton.Behavior = SideButtonBehavior.SpinDown;
        }
        AddButtons(leftButton, rightButton, control);
    }

    // コントロールにサイドボタンを追加
    void AddButtons(SideButtonBase leftButton, SideButtonBase rightButton, EditBase control)
    {
        ChangePosition(leftButton, rightButton);

        if (control is GcMask)
        {
            ((GcMask)control).SideButtons.Add(leftButton);
            ((GcMask)control).SideButtons.Add(rightButton);
        }
        else if (control is GcDateTime || control is GcDate || control is GcTime)
        {
            ((GcDateTime)control).SideButtons.Add(leftButton);
            ((GcDateTime)control).SideButtons.Add(rightButton);
        }
        else if (control is GcTimeSpan)
        {
            ((GcTimeSpan)control).SideButtons.Add(leftButton);
            ((GcTimeSpan)control).SideButtons.Add(rightButton);
        }
        else if (control is GcNumber)
        {
            ((GcNumber)control).SideButtons.Add(leftButton);
            ((GcNumber)control).SideButtons.Add(rightButton);
        }
        else if (control is GcComboBox)
        {
            ((GcComboBox)control).SideButtons.Add(leftButton);
            ((GcComboBox)control).SideButtons.Add(rightButton);
        }
        else if (control is GcMaskedComboBox)
        {
            ((GcMaskedComboBox)control).SideButtons.Add(leftButton);
            ((GcMaskedComboBox)control).SideButtons.Add(rightButton);
        }
    }

    // ボタンの表示位置
    void ChangePosition(SideButtonBase leftButton, SideButtonBase rightButton)
    {
        if (gcComboBox3.SelectedIndex == 0)
        {
            leftButton.Position = ButtonPosition.RightInside;
            rightButton.Position = ButtonPosition.RightInside;
        }
        else if (gcComboBox3.SelectedIndex == 1)
        {
            leftButton.Position = ButtonPosition.LeftInside;
            rightButton.Position = ButtonPosition.LeftInside;
        }
        else if (gcComboBox3.SelectedIndex == 2)
        {
            leftButton.Position = ButtonPosition.LeftInside;
            rightButton.Position = ButtonPosition.RightInside;
        }
    }
}
