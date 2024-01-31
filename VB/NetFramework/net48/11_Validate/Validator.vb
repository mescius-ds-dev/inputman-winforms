Imports GrapeCity.Win.Editors
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Namespace _11_Validate
    Partial Public Class Validator
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期値
            gcListBox1.Items(4).Checked = True
        End Sub

        Private Sub gcListBox1_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs) Handles gcListBox1.ItemCheck
            ' 検証アクションのリセット
            Dim gcTextBoxArray As GcTextBox() = {gcTextBox1, gcTextBox2, gcTextBox3, gcTextBox4}
            clearInvalidAction(gcCommonValidator1, gcTextBoxArray)
            clearInvalidAction(gcDateTimeValidator1, gcDateTime1)
            clearInvalidAction(gcNumberValidator1, gcNumber1)

            gcCommonValidator1.Validate()
            gcDateTimeValidator1.Validate()
            gcNumberValidator1.Validate()
            gcCommonValidator1.ResetValidationState()
            gcDateTimeValidator1.ResetValidationState()
            gcNumberValidator1.ResetValidationState()

            ' 検証アクションの削除
            gcCommonValidator1.GetValidateActions(gcTextBox1).Clear()
            gcCommonValidator1.GetValidateActions(gcTextBox2).Clear()
            gcCommonValidator1.GetValidateActions(gcTextBox3).Clear()
            gcCommonValidator1.GetValidateActions(gcTextBox4).Clear()
            gcDateTimeValidator1.GetValidateActions(gcDateTime1).Clear()
            gcNumberValidator1.GetValidateActions(gcNumber1).Clear()

            ' 検証アクションの追加
            Dim indexes As List(Of Integer) = New List(Of Integer)
            If e.NewValue = CheckState.Checked Then
                indexes.Add(e.Index)
            End If

            Dim cic As CheckedIndexCollection = gcListBox1.CheckedIndices
            For i As Integer = 0 To cic.Count - 1
                If cic(i) <> e.Index Then
                    indexes.Add(cic(i))
                End If
            Next

            indexes.ForEach(Sub(x) SetValidateAction(x))

            ' 再検証
            gcCommonValidator1.Validate()
            gcDateTimeValidator1.Validate()
            gcNumberValidator1.Validate()

            GcCustomValidator1.SetValidatingMethod(
                gcTextBox5,
                Sub(context)

                    If context.Control.Text.Length > 10 Then

                        context.IsValid = False

                        For Each index As Integer In indexes

                            Select Case index
                                Case 0
                                    ' GcBalloonTip(Windowsスタイル)による通知(GcBalloonTipNotify)
                                    context.EnableGcBallonTipNotify = True
                                    context.GcBalloonTipNotify.BalloonTipInformation = GetGcBalloonTipNotify().BalloonTipInformation
                                Case 1
                                    ' ３段階のボーダーによる通知(ThreeStateBorderNotify)
                                    context.EnableThreeStateBorderNotify = True
                                    Dim ThreeStateBorderNotify As ThreeStateBorderNotify = GetThreeStateBorderNotify()
                                    context.ThreeStateBorderNotify.ValidLineColor = ThreeStateBorderNotify.ValidLineColor
                                    context.ThreeStateBorderNotify.ValidLineStyle = ThreeStateBorderNotify.ValidLineStyle
                                Case 2 ' ３段階のアイコンによる通知(ThreeStateIconNotify)
                                    context.EnableThreeIconBorderNotify = True
                                Case 3 ' フォーカス制御(FocusProcess)
                                    context.EnableFocusProcess = True
                                    context.FocusProcess.PreventFocusLeave = GetFocusProcess().PreventFocusLeave
                                Case 4 ' 値の制御(ValueProcess)
                                    context.EnableValueProcess = True
                                    context.ValueProcess.ValueProcessOption = GetValueProcess().ValueProcessOption
                                Case 5 ' アイコンによる通知(IconNotify)
                                    context.EnableIconNotify = True
                                Case 6 ' 音による通知(SoundNotify)
                                    context.EnableSoundNotify = True
                                Case 7 ' バルーンチップによる通知(TipNotify)
                                    context.EnableTipNotify = True
                                    context.TipNotify.ToolTipIcon = GetTipNotify().ToolTipIcon
                                    context.TipNotify.ToolTipTitle = GetTipNotify().ToolTipTitle
                                Case 8
                                    ' 下線による通知(LineNotify)
                                    context.EnableLineNotify = True
                                Case 9 ' 色による通知(ColorNotify)
                                    context.EnableColorNotify = True
                                    Dim ColorNotify As ColorNotify = GetColorNotify()
                                    context.ColorNotify.ValidForeColor = ColorNotify.ValidForeColor
                                    context.ColorNotify.ValidBackColor = ColorNotify.ValidBackColor
                                    context.ColorNotify.InvalidForeColor = ColorNotify.InvalidForeColor
                                    context.ColorNotify.InvalidBackColor = ColorNotify.InvalidBackColor
                                Case 10
                                    ' GcBalloonTipによる通知(GcBalloonTipNotify)
                                    context.EnableGcBallonTipNotify = True
                                    context.GcBalloonTipNotify.BalloonTipInformation = GetGcBalloonTipNotifyWinStyle().BalloonTipInformation
                            End Select
                        Next
                    Else
                        context.IsValid = True
                    End If
                End Sub)

            GcCustomValidator1.Validate()
        End Sub

        Private Sub clearInvalidAction(ByVal v As GcCommonValidator, ByVal gcc As GcTextBox())
            For i As Integer = 0 To gcc.Length - 1
                For Each action As ValidateAction In v.GetValidateActions(gcc(i))
                    Dim fp As FocusProcess = TryCast(action, FocusProcess)
                    If fp IsNot Nothing Then
                        fp.PreventFocusLeave = False
                    End If
                Next
            Next
        End Sub
        Private Sub clearInvalidAction(ByVal v As GcDateTimeValidator, ByVal gcc As GcDateTime)
            For Each action As ValidateAction In v.GetValidateActions(gcc)
                Dim fp As FocusProcess = TryCast(action, FocusProcess)
                If fp IsNot Nothing Then
                    fp.PreventFocusLeave = False
                End If
            Next
        End Sub
        Private Sub clearInvalidAction(ByVal v As GcNumberValidator, ByVal gcc As GcNumber)
            For Each action As ValidateAction In v.GetValidateActions(gcc)
                Dim fp As FocusProcess = TryCast(action, FocusProcess)
                If fp IsNot Nothing Then
                    fp.PreventFocusLeave = False
                End If
            Next
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            ' リアルタイム検証
            gcCommonValidator1.SetSupportRealTimeValidating(gcTextBox1, checkBox1.Checked)
            gcCommonValidator1.SetSupportRealTimeValidating(gcTextBox2, checkBox1.Checked)
            gcCommonValidator1.SetSupportRealTimeValidating(gcTextBox3, checkBox1.Checked)
            gcCommonValidator1.SetSupportRealTimeValidating(gcTextBox4, checkBox1.Checked)
            gcDateTimeValidator1.SetSupportRealTimeValidating(gcDateTime1, checkBox1.Checked)
            gcNumberValidator1.SetSupportRealTimeValidating(gcNumber1, checkBox1.Checked)
            GcCustomValidator1.SetSupportRealTimeValidating(gcTextBox5, checkBox1.Checked)
        End Sub

        Private Sub SetValidateAction(index As Integer)
            Dim GetActionMethod As ValidateActionMethod = GetAction(index)

            If (GetActionMethod Is Nothing) Then Return

            gcCommonValidator1.GetValidateActions(gcTextBox1).Add(GetActionMethod())
            gcCommonValidator1.GetValidateActions(gcTextBox2).Add(GetActionMethod())
            gcCommonValidator1.GetValidateActions(gcTextBox3).Add(GetActionMethod())
            gcCommonValidator1.GetValidateActions(gcTextBox4).Add(GetActionMethod())
            gcDateTimeValidator1.GetValidateActions(gcDateTime1).Add(GetActionMethod())
            gcNumberValidator1.GetValidateActions(gcNumber1).Add(GetActionMethod())
        End Sub

        Private Delegate Function ValidateActionMethod() As ValidateAction

        Private Function GetAction(index As Integer) As ValidateActionMethod
            Select Case index

                Case 0
                    ' GcBalloonTipによる通知(GcBalloonTipNotify)
                    Return AddressOf GetGcBalloonTipNotify
                Case 1
                    ' ３段階のボーダーによる通知(ThreeStateBorderNotify)
                    Return AddressOf GetThreeStateBorderNotify
                Case 2
                    ' ３段階のアイコンによる通知(ThreeStateIconNotify)
                    Return AddressOf GetThreeStateIconNotify
                Case 3
                    ' フォーカス制御(FocusProcess)
                    Return AddressOf GetFocusProcess
                Case 4
                    ' 値の制御(ValueProcess)
                    Return AddressOf GetValueProcess
                Case 5
                    ' アイコンによる通知(IconNotify)
                    Return AddressOf GetIconNotify
                Case 6
                    ' 音による通知(SoundNotify)
                    Return AddressOf GetSoundNotify
                Case 7
                    ' バルーンチップによる通知(TipNotify)
                    Return AddressOf GetTipNotify
                Case 8
                    ' 下線による通知(LineNotify)
                    Return AddressOf GetLineNotify
                Case 9
                    ' 色による通知(ColorNotify)
                    Return AddressOf GetColorNotify
                Case 10
                    ' GcBalloonTip(Windowsスタイル)による通知(GcBalloonTipNotify)
                    Return AddressOf GetGcBalloonTipNotifyWinStyle
            End Select

            Return Nothing
        End Function

        Private Function GetGcBalloonTipNotify() As GcBalloonTipNotify
            Return New GcBalloonTipNotify With
            {
                .BalloonTipInformation = New BalloonTipInformation With
                {
                    .IconType = IconType.Warning,
                    .Shape = BalloonShape.Square,
                    .Caption = "入力エラー",
                    .CaptionForeColor = Color.Red,
                    .TextFont = New Font("メイリオ", 10),
                    .CaptionFont = New Font("メイリオ", 8),
                    .UseVisualStyleBackColor = False,
                    .BackColor = Color.AliceBlue
                }
            }
        End Function


        Private Function GetGcBalloonTipNotifyWinStyle() As GcBalloonTipNotify
            Return New GcBalloonTipNotify With
            {
                .BalloonTipInformation = New BalloonTipInformation With {.BalloonTipStyle = BalloonTipStyle.Windows}
            }
        End Function

        Private Function GetThreeStateBorderNotify() As ThreeStateBorderNotify
            Return New ThreeStateBorderNotify With
            {
                .ValidLineColor = Color.Blue,
                .ValidLineStyle = LineDashStyle.Solid
            }
        End Function

        Private Function GetThreeStateIconNotify() As ThreeStateIconNotify
            Return New ThreeStateIconNotify()
        End Function

        Private Function GetFocusProcess() As FocusProcess
            Return New FocusProcess With
            {
                .PreventFocusLeave = True
            }
        End Function

        Private Function GetValueProcess() As ValueProcess
            Return New ValueProcess With
            {
                .ValueProcessOption = ValueProcessOption.Restore
            }
        End Function

        Private Function GetIconNotify() As IconNotify
            Return New IconNotify()
        End Function

        Private Function GetSoundNotify() As SoundNotify
            Return New SoundNotify()
        End Function

        Private Function GetTipNotify() As TipNotify
            Return New TipNotify With
            {
                .ToolTipIcon = ToolTipIcon.Warning,
                .ToolTipTitle = "入力エラー"
            }
        End Function

        Private Function GetLineNotify() As LineNotify
            Return New LineNotify()
        End Function

        Private Function GetColorNotify() As ColorNotify

            Return New ColorNotify With
            {
                .ValidForeColor = gcNumber1.ForeColor,
                .ValidBackColor = gcNumber1.BackColor,
                .InvalidForeColor = Color.White,
                .InvalidBackColor = Color.Red
            }
        End Function

    End Class
End Namespace
