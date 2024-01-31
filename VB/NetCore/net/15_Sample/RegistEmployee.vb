Imports GrapeCity.Win.Editors
Imports GrapeCity.Win.Editors.Fields
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace _15_Sample

    Public Class RegistEmployee
        Inherits InputManWin12_Demo.DemoBase

        Public Sub New()
            InitializeComponent()

            Clear()

            SetPropertyEmployeeNumber()
            SetPropertyEmployeeName()
            SetPropertyFurigana()
            SetPropertyDateOfBirth()
            SetPropertyTelephoneNumber()
            SetPropertyZipCode()
            SetPropertyAddress()
            SetPropertyDepartmentName()
            SetPropertyExtensionNumber()
            SetPropertyMessageColumn()

            SetPropertyFocus()

            GcNumber1.Focus()
        End Sub

        Private Sub SubmitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
            Submit()
        End Sub

        Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            Clear()
        End Sub

        ''' <summary>
        ''' 登録
        ''' </summary>
        Private Sub Submit()
            If Not ValidateControls() Then Return

            MessageBox.Show("登録しました。")
        End Sub

        ''' <summary>
        ''' 各コントロール検証
        ''' </summary>
        ''' <returns></returns>
        Private Function ValidateControls() As Boolean
            If GcCommonValidator1.GetInvalidControls().Contains(GcTextBox1) Then
                MessageBox.Show("社員名の入力値が不正です。")
                GcTextBox1.Focus()
                Return False
            End If

            If GcCustomValidator1.GetInvalidControls().Contains(GcDate1) Or
                GcDateValidator1.GetInvalidControls().Contains(GcDate1) Then
                MessageBox.Show("生年月日の入力値が不正です。")
                GcDate1.Focus()
                Return False
            End If

            If GcCustomValidator1.GetInvalidControls().Contains(GcMask1) Then
                MessageBox.Show("電話番号の入力値が不正です。")
                GcMask1.Focus()
                Return False
            End If

            If GcCustomValidator1.GetInvalidControls().Contains(GcPostal1) Then
                MessageBox.Show("郵便番号の入力値が不正です。")
                GcPostal1.Focus()
                Return False
            End If

            If GcCommonValidator1.GetInvalidControls().Contains(GcComboBox1) Then
                MessageBox.Show("部署名の入力値が不正です。")
                GcComboBox1.Focus()
                Return False
            End If

            Return True
        End Function

        ''' <summary>
        ''' コントロールクリア
        ''' </summary>
        Private Sub Clear()
            GcNumber1.Clear()
            GcTextBox1.Clear()
            GcTextBox2.Clear()
            GcPostal1.Clear()
            GcAddressBox1.Clear()
            GcMask1.Clear()
            GcDate1.Clear()
            GcComboBox1.Clear()
            GcMask2.Clear()
            GcTextBox3.Clear()
        End Sub

        ''' <summary>
        ''' 社員番号（GcNumber）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyEmployeeNumber()
            GcNumber1.DisplayFields.Clear()
            GcNumber1.Fields.SetFields("000000,,,,")
            GcNumber1.DisplayFields.AddRange("000000,,,,")
            GcNumber1.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        End Sub

        ''' <summary>
        ''' 社員名（GcTextBox）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyEmployeeName()
            GcTextBox1.MaxLength = 60
            GcTextBox1.MaxLengthUnit = GrapeCity.Win.Editors.LengthUnit.Char
            GcTextBox1.Format = "Ｚ"
            GcTextBox1.AlternateText.DisplayNull.Text = "全角文字を入力できます。"
            GcTextBox1.AlternateText.DisplayNull.ForeColor = Drawing.Color.Gray
            GcTextBox1.AllowSpace = GrapeCity.Win.Editors.AllowSpace.None
            GcIme1.SetInputScope(GcTextBox1, InputScopeNameValue.Hiragana)

            SetCommonValidate(GcTextBox1)
        End Sub

        ''' <summary>
        ''' フリガナ（GcTextBox）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyFurigana()
            GcIme1.SetReadingStringOutput(GcTextBox1, New ReadingStringOutput(GcTextBox2, ReadingStringOutputMode.Append))
            GcTextBox2.Format = "Ｋ"
            GcTextBox2.AlternateText.DisplayNull.Text = "カタカナを入力できます。"
            GcTextBox2.AlternateText.DisplayNull.ForeColor = Color.Gray
            GcTextBox2.AllowSpace = GrapeCity.Win.Editors.AllowSpace.None
            GcIme1.SetInputScope(GcTextBox2, InputScopeNameValue.KatakanaFullWidth)
        End Sub

        ''' <summary>
        ''' 郵便番号（GcPostal）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyZipCode()
            GcPostal1.Fields.ZipCodePrefix.Text = "〒"
            GcPostal1.SplitAreaDetails = True
            GcPostal1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            SetCommonValidate(GcPostal1)
        End Sub

        ''' <summary>
        ''' 住所（GcAddressBox）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyAddress()
            GcAddressBox1.AutoFilter = True
            Dim addressOutputSetting1 As AddressOutputSetting = New AddressOutputSetting With {
                .AddressOutput = GcAddressBox1
            }
            GcAddress1.SetAddressOutputSetting(GcPostal1, addressOutputSetting1)
        End Sub

        ''' <summary>
        ''' 電話番号（GcMask)へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyTelephoneNumber()
            GcMask1.Fields.AddRange(New MaskField() {
                                    New MaskLiteralField("℡ "),
                                    New MaskPatternField("\D", 3, 4),
                                    New MaskLiteralField("-"),
                                    New MaskPatternField("\D", 3, 4),
                                    New MaskLiteralField("-"),
                                    New MaskPatternField("\D", 4, 4)})
            GcMask1.ImeMode = ImeMode.Off
            SetCommonValidate(GcMask1)
        End Sub

        ''' <summary>
        ''' 生年月日（GcDate）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyDateOfBirth()
            Me.GcDate1.Fields.AddRange(New DateField() {
                                       New DateEraField(),
                                       New DateLiteralField(),
                                       New DateEraYearField(),
                                       New DateLiteralField() With {.Text = "年"},
                                       New DateMonthField(),
                                       New DateLiteralField() With {.Text = "月"},
                                       New DateDayField(),
                                       New DateLiteralField() With {.Text = "日"}})

            GcDate1.DropDownCalendar.HeaderFormat = "ggg e年 M月"
            GcDate1.DropDownCalendar.UseHeaderFormat = True
            Dim gcDateInvalidRange1 As GcDateValidator.InvalidRange = New GcDateValidator.InvalidRange With {
                .MaxValue = DateTime.Today,
                .MinValue = New DateTime(1926, 1, 1),
                .InvalidMessage = "昭和１年 ～ 本日の範囲の日付を入力できます。"
            }
            GcDateValidator1.GetValidateItems(GcDate1).AddRange(New Object() {gcDateInvalidRange1})
            GcDateValidator1.GetValidateActions(GcDate1).AddRange(New ValidateAction() {New IconNotify()})
            SetCommonValidate(GcDate1)
        End Sub

        ''' <summary>
        ''' 内線番号（GcMask）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyExtensionNumber()
            GcMask2.Fields.Add(New MaskPatternField("\D", 4, 4))
        End Sub


        ''' <summary>
        ''' 部署名（GcComboBox）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyDepartmentName()
            GcComboBox1.ListColumns.AddRange(New ListColumn() {
                                             New ListColumn("部名"),
                                             New ListColumn("課名"),
                                             New ListColumn("部課名"),
                                             New ListColumn("部課名コード")})
            GcComboBox1.TextSubItemIndex = 2
            GcComboBox1.DropDownStyle = ComboBoxStyle.DropDown
            GcComboBox1.IsEditable = False
            GcComboBox1.ListColumns(0).AutoWidth = True
            GcComboBox1.ListColumns(1).AutoWidth = True
            GcComboBox1.ListColumns(2).Visible = False
            GcComboBox1.ListColumns(3).Visible = False
            Dim list As List(Of ListItem) = New List(Of ListItem)()

            For Each item As Department In GetData()
                list.Add(New ListItem(New SubItem() {
                                      New SubItem(item.DepartmentName),
                                      New SubItem(item.DivisionName),
                                      New SubItem(item.Name),
                                      New SubItem(item.Code)}))
            Next

            GcComboBox1.Items.AddRange(list.ToArray())
            GcComboBox1.SelectedIndex = -1
            SetCommonValidate(GcComboBox1)
        End Sub

        ''' <summary>
        ''' 通信欄（GcTextBox)へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyMessageColumn()
            GcTextBox3.Multiline = True
            GcTextBox3.WrapMode = WrapMode.CharWrap
            GcTextBox3.LineSpace = 2
            GcTextBox3.MaxLineCount = 5
        End Sub

        ''' <summary>
        ''' 各コントロールのフォーカス移動の設定
        ''' </summary>
        Private Sub SetPropertyFocus()
            SetPropertyFocus(GcNumber1)
            SetPropertyFocus(GcTextBox1)
            SetPropertyFocus(GcTextBox2)
            SetPropertyFocus(GcPostal1)
            SetPropertyFocus(GcAddressBox1)
            SetPropertyFocus(GcMask1)
            SetPropertyFocus(GcDate1)
            SetPropertyFocus(GcComboBox1)
            SetPropertyFocus(GcMask2)
            SetPropertyFocus(GcTextBox3)
        End Sub

        ''' <summary>
        ''' フォーカス移動の設定
        ''' </summary>
        Private Sub SetPropertyFocus(control As EditBase)
            control.ExitOnLastChar = True
            control.ExitOnLeftRightKey = ExitOnLeftRightKey.Both
            GcShortcut1.SetShortcuts(control, New ShortcutCollection(New Keys() {Keys.Enter, Keys.Enter Or Keys.Shift},
                                     New Object() {GcShortcut1, GcShortcut1},
                                     New String() {"NextControl", "PreviousControl"}))
        End Sub

        ''' <summary>
        ''' 汎用検証（必須入力）の設定
        ''' </summary>
        ''' <param name="control"></param>
        Private Sub SetCommonValidate(control As EditBase)
            GcCommonValidator1.GetValidateItems(control).AddRange(New Object() {New EmptyText With {
                                                                  .InvalidMessage = "入力必須項目です",
                                                                  .FieldsExclude = True}})
            GcCommonValidator1.GetValidateActions(control).AddRange(New ValidateAction() {New IconNotify()})
        End Sub

#Region "サンプル用データ"
        ''' <summary>
        ''' 部署クラス
        ''' </summary>
        Private Class Department
            Public Property DepartmentName As String
            Public Property DivisionName As String
            Public Property Name As String
            Public Property Code As String
        End Class

        ''' <summary>
        ''' 部署データ取得
        ''' </summary>
        ''' <returns></returns>
        Private Function GetData() As IEnumerable(Of Department)
            Return New List(Of Department) From {
                New Department() With {
                    .DepartmentName = "総務部",
                    .DivisionName = "総務課",
                    .Name = "総務部総務課",
                    .Code = "0101"
                },
                New Department() With {
                    .DepartmentName = "総務部",
                    .DivisionName = "人事課",
                    .Name = "総務部人事課",
                    .Code = "0102"
                },
                New Department() With {
                    .DepartmentName = "総務部",
                    .DivisionName = "福祉課",
                    .Name = "総務部福祉課",
                    .Code = "0103"
                },
                New Department() With {
                    .DepartmentName = "企画部",
                    .DivisionName = "総合企画課",
                    .Name = "企画部総合企画課",
                    .Code = "0201"
                },
                New Department() With {
                    .DepartmentName = "企画部",
                    .DivisionName = "事業計画課",
                    .Name = "企画部事業計画課",
                    .Code = "0202"
                },
                New Department() With {
                    .DepartmentName = "情報システム部",
                    .DivisionName = "システム管理課",
                    .Name = "情報システム部システム管理課",
                    .Code = "0301"
                },
                New Department() With {
                    .DepartmentName = "情報システム部",
                    .DivisionName = "情報システム課",
                    .Name = "情報システム部情報システム課",
                    .Code = "0302"
                }
        }
        End Function
#End Region

    End Class
End Namespace