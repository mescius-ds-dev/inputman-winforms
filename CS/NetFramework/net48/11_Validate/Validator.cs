using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GrapeCity.Win.Editors;

namespace InputManWin12_Demo._11_Validate
{
    public partial class Validator : InputManWin12_Demo.DemoBase_settings
    {
        public Validator()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcListBox1.ItemCheck += new ItemCheckEventHandler(GcListBox1_ItemCheck);
            checkBox1.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);

            // ***** 初期値
            gcListBox1.Items[5].Checked = true;
        }

        private void GcListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // 検証アクションのリセット
            GcTextBox[] gcTextBoxArray = { gcTextBox1, gcTextBox2, gcTextBox3, gcTextBox4 };
            ClearInvalidAction(gcCommonValidator1, gcTextBoxArray);
            ClearInvalidAction(gcDateTimeValidator1, gcDateTime1);
            ClearInvalidAction(gcNumberValidator1, gcNumber1);

            gcCommonValidator1.Validate();
            gcDateTimeValidator1.Validate();
            gcNumberValidator1.Validate();
            gcCommonValidator1.ResetValidationState();
            gcDateTimeValidator1.ResetValidationState();
            gcNumberValidator1.ResetValidationState();

            // 検証アクションの削除
            gcCommonValidator1.GetValidateActions(gcTextBox1).Clear();
            gcCommonValidator1.GetValidateActions(gcTextBox2).Clear();
            gcCommonValidator1.GetValidateActions(gcTextBox3).Clear();
            gcCommonValidator1.GetValidateActions(gcTextBox4).Clear();
            gcDateTimeValidator1.GetValidateActions(gcDateTime1).Clear();
            gcNumberValidator1.GetValidateActions(gcNumber1).Clear();

            // 検証アクションの追加
            var indexes = new List<int>();
            if (e.NewValue == CheckState.Checked)
            {
                indexes.Add(e.Index);
            }

            CheckedIndexCollection cic = gcListBox1.CheckedIndices;
            for (int i = 0; i < cic.Count; i++)
            {
                if (cic[i] != e.Index)
                {
                    indexes.Add(cic[i]);
                }
            }

            indexes.ForEach(x => SetValidateAction(x));

            // 再検証
            gcCommonValidator1.Validate();
            gcDateTimeValidator1.Validate();
            gcNumberValidator1.Validate();
            
            gcCustomValidator1.SetValidatingMethod(gcTextBox5, (context) =>
            {
                if (context.Control.Text.Length > 10)
                {
                    context.IsValid = false;

                    foreach (var index in indexes)
                    {
                        switch (index)
                        {
                            case 0:
                                // GcBalloonTipによる通知(GcBalloonTipNotify)
                                context.EnableGcBallonTipNotify = true;
                                context.GcBalloonTipNotify.BalloonTipInformation = GetGcBalloonTipNotify().BalloonTipInformation;
                                break;
                            case 1:
                                // ３段階のボーダーによる通知(ThreeStateBorderNotify)
                                context.EnableThreeStateBorderNotify = true;
                                var threeStateBorderNotify = GetThreeStateBorderNotify();
                                context.ThreeStateBorderNotify.ValidLineColor = threeStateBorderNotify.ValidLineColor;
                                context.ThreeStateBorderNotify.ValidLineStyle = threeStateBorderNotify.ValidLineStyle;
                                break;
                            case 2:
                                // ３段階のアイコンによる通知(ThreeStateIconNotify)
                                context.EnableThreeIconBorderNotify = true;
                                break;
                            case 3:
                                // フォーカス制御(FocusProcess)
                                context.EnableFocusProcess = true;
                                context.FocusProcess.PreventFocusLeave = GetFocusProcess().PreventFocusLeave;
                                break;
                            case 4:
                                // 値の制御(ValueProcess)
                                context.EnableValueProcess = true;
                                context.ValueProcess.ValueProcessOption = GetValueProcess().ValueProcessOption;
                                break;
                            case 5:
                                // アイコンによる通知(IconNotify)
                                context.EnableIconNotify = true;
                                break;
                            case 6:
                                // 音による通知(SoundNotify)
                                context.EnableSoundNotify = true;
                                break;
                            case 7:
                                // バルーンチップによる通知(TipNotify)
                                context.EnableTipNotify = true;
                                context.TipNotify.ToolTipIcon = GetTipNotify().ToolTipIcon;
                                context.TipNotify.ToolTipTitle = GetTipNotify().ToolTipTitle;
                                break;
                            case 8:
                                // 下線による通知(LineNotify)
                                context.EnableLineNotify = true;
                                break;
                            case 9:
                                // 色による通知(ColorNotify)
                                context.EnableColorNotify = true;
                                var colorNotify = GetColorNotify();

                                context.ColorNotify.ValidForeColor = colorNotify.ValidForeColor;
                                context.ColorNotify.ValidBackColor = colorNotify.ValidBackColor;
                                context.ColorNotify.InvalidForeColor = colorNotify.InvalidForeColor;
                                context.ColorNotify.InvalidBackColor = colorNotify.InvalidBackColor;
                                break;
                            case 10:
                                // GcBalloonTip(Windowsスタイル)による通知(GcBalloonTipNotify)
                                context.EnableGcBallonTipNotify = true;
                                context.GcBalloonTipNotify.BalloonTipInformation = GetGcBalloonTipNotifyWinStyle().BalloonTipInformation;
                                break;
                            default: break;
                        }
                    }
                }
                else
                {
                    context.IsValid = true;
                }
            });

            gcCustomValidator1.Validate();
        }
        
        private void ClearInvalidAction(GcCommonValidator v, GcTextBox[] gcc)
        {
            for (int i = 0; i < gcc.Length; i++)
            {
                foreach (ValidateAction action in v.GetValidateActions(gcc[i]))
                {
                    FocusProcess fp = action as FocusProcess;
                    if (fp != null)
                    {
                        fp.PreventFocusLeave = false;
                    }
                }
            }
        }
        private void ClearInvalidAction(GcDateTimeValidator v, GcDateTime gcc)
        {
            foreach (ValidateAction action in v.GetValidateActions(gcc))
            {
                FocusProcess fp = action as FocusProcess;
                if (fp != null)
                {
                    fp.PreventFocusLeave = false;
                }
            }
        }
        private void ClearInvalidAction(GcNumberValidator v, GcNumber gcc)
        {
            foreach (ValidateAction action in v.GetValidateActions(gcc))
            {
                FocusProcess fp = action as FocusProcess;
                if (fp != null)
                {
                    fp.PreventFocusLeave = false;
                }
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // リアルタイム検証
            gcCommonValidator1.SetSupportRealTimeValidating(gcTextBox1, checkBox1.Checked);
            gcCommonValidator1.SetSupportRealTimeValidating(gcTextBox2, checkBox1.Checked);
            gcCommonValidator1.SetSupportRealTimeValidating(gcTextBox3, checkBox1.Checked);
            gcCommonValidator1.SetSupportRealTimeValidating(gcTextBox4, checkBox1.Checked);
            gcDateTimeValidator1.SetSupportRealTimeValidating(gcDateTime1, checkBox1.Checked);
            gcNumberValidator1.SetSupportRealTimeValidating(gcNumber1, checkBox1.Checked);
            gcCustomValidator1.SetSupportRealTimeValidating(gcTextBox5, checkBox1.Checked);
        }

        private void SetValidateAction(int index)
        {
            var GetActionMethod = GetAction(index);

            if (GetActionMethod == null) return;

            gcCommonValidator1.GetValidateActions(gcTextBox1).Add(GetActionMethod());
            gcCommonValidator1.GetValidateActions(gcTextBox2).Add(GetActionMethod());
            gcCommonValidator1.GetValidateActions(gcTextBox3).Add(GetActionMethod());
            gcCommonValidator1.GetValidateActions(gcTextBox4).Add(GetActionMethod());
            gcDateTimeValidator1.GetValidateActions(gcDateTime1).Add(GetActionMethod());
            gcNumberValidator1.GetValidateActions(gcNumber1).Add(GetActionMethod());
        }

        private delegate ValidateAction ValidateActionMethod();

        private ValidateActionMethod GetAction(int index)
        {
            switch (index)
            {
                case 0:
                    // GcBalloonTipによる通知(GcBalloonTipNotify)
                    return GetGcBalloonTipNotify;
                case 1:
                    // ３段階のボーダーによる通知(ThreeStateBorderNotify)
                    return GetThreeStateBorderNotify;
                case 2:
                    // ３段階のアイコンによる通知(ThreeStateIconNotify)
                    return GetThreeStateIconNotify;
                case 3:
                    // フォーカス制御(FocusProcess)
                    return GetFocusProcess;
                case 4:
                    // 値の制御(ValueProcess)
                    return GetValueProcess;
                case 5:
                    // アイコンによる通知(IconNotify)
                    return GetIconNotify;
                case 6:
                    // 音による通知(SoundNotify)
                    return GetSoundNotify;
                case 7:
                    // バルーンチップによる通知(TipNotify)
                    return GetTipNotify;
                case 8:
                    // 下線による通知(LineNotify)
                    return GetLineNotify;
                case 9:
                    // 色による通知(ColorNotify)
                    return GetColorNotify;

                case 10:
                    // GcBalloonTip(Windowsスタイル)による通知(GcBalloonTipNotify)
                    return GetGcBalloonTipNotifyWinStyle;
                default:
                    return null;
            }
        }
        private GcBalloonTipNotify GetGcBalloonTipNotify()
        {
            return new GcBalloonTipNotify
            {
                BalloonTipInformation = new BalloonTipInformation
                {
                    IconType = IconType.Warning,
                    Shape = BalloonShape.Square,
                    Caption = "入力エラー",
                    CaptionForeColor = Color.Red,
                    TextFont = new Font("メイリオ", 10),
                    CaptionFont = new Font("メイリオ", 8),
                    UseVisualStyleBackColor = false,
                    BackColor = Color.AliceBlue
                }
            };
        }

        private GcBalloonTipNotify GetGcBalloonTipNotifyWinStyle()
        {
            return new GcBalloonTipNotify
            {
                BalloonTipInformation = new BalloonTipInformation { BalloonTipStyle = BalloonTipStyle.Windows }
            };
        }

        private ThreeStateBorderNotify GetThreeStateBorderNotify()
        {
            return new ThreeStateBorderNotify
            {
                ValidLineColor = Color.Blue,
                ValidLineStyle = LineDashStyle.Solid
            };
        }

        private ThreeStateIconNotify GetThreeStateIconNotify()
        {
            return new ThreeStateIconNotify();
        }

        private FocusProcess GetFocusProcess()
        {
            return new FocusProcess
            {
                PreventFocusLeave = true
            };
        }

        private ValueProcess GetValueProcess()
        {
            return new ValueProcess
            {
                ValueProcessOption = ValueProcessOption.Restore
            };
        }

        private IconNotify GetIconNotify()
        {
            return new IconNotify();
        }

        private SoundNotify GetSoundNotify()
        {
            return new SoundNotify();
        }

        private TipNotify GetTipNotify()
        {
            return new TipNotify
            {
                ToolTipIcon = ToolTipIcon.Warning,
                ToolTipTitle = "入力エラー"
            };
        }

        private LineNotify GetLineNotify()
        {
            return new LineNotify();
        }

        private ColorNotify GetColorNotify()
        {
            return new ColorNotify
            {
                ValidForeColor = gcNumber1.ForeColor,
                ValidBackColor = gcNumber1.BackColor,
                InvalidForeColor = Color.White,
                InvalidBackColor = Color.Red
            };
        }
    }
}
