Imports GrapeCity.Win.Editors
Imports GrapeCity.Win.Editors.Fields
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView

Namespace _15_Sample
    Partial Public Class RegistEmployee
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

            gcNumber1.Focus()
        End Sub

        Private Sub SubmitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            Submit()
        End Sub

        Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
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
            If gcCommonValidator1.GetInvalidControls().Contains(gcTextBox1) Then
                MessageBox.Show("社員名の入力値が不正です。")
                gcTextBox1.Focus()
                Return False
            End If

            If gcCustomValidator1.GetInvalidControls().Contains(gcDate1) Or
                gcDateValidator1.GetInvalidControls().Contains(gcDate1) Then
                MessageBox.Show("生年月日の入力値が不正です。")
                gcDate1.Focus()
                Return False
            End If

            If gcCustomValidator1.GetInvalidControls().Contains(gcMask1) Then
                MessageBox.Show("電話番号の入力値が不正です。")
                gcMask1.Focus()
                Return False
            End If

            If gcCustomValidator1.GetInvalidControls().Contains(gcPostal1) Then
                MessageBox.Show("郵便番号の入力値が不正です。")
                gcPostal1.Focus()
                Return False
            End If

            If gcCommonValidator1.GetInvalidControls().Contains(gcComboBox1) Then
                MessageBox.Show("部署名の入力値が不正です。")
                gcComboBox1.Focus()
                Return False
            End If

            Return True
        End Function


        ''' <summary>
        ''' コントロールクリア
        ''' </summary>
        Private Sub Clear()
            gcNumber1.Clear()
            gcTextBox1.Clear()
            gcTextBox2.Clear()
            gcPostal1.Clear()
            gcAddressBox1.Clear()
            gcMask1.Clear()
            gcDate1.Clear()
            gcComboBox1.Clear()
            gcMask2.Clear()
            gcTextBox3.Clear()
        End Sub

        ''' <summary>
        ''' 社員番号（GcNumber）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyEmployeeNumber()
            gcNumber1.DisplayFields.Clear()
            gcNumber1.Fields.SetFields("000000,,,,")
            gcNumber1.DisplayFields.AddRange("000000,,,,")
            gcNumber1.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        End Sub

        ''' <summary>
        ''' 社員名（GcTextBox）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyEmployeeName()
            gcTextBox1.MaxLength = 60
            gcTextBox1.MaxLengthUnit = GrapeCity.Win.Editors.LengthUnit.Char
            gcTextBox1.Format = "Ｚ"
            gcTextBox1.AlternateText.DisplayNull.Text = "全角文字を入力できます。"
            gcTextBox1.AlternateText.DisplayNull.ForeColor = Drawing.Color.Gray
            gcTextBox1.AllowSpace = GrapeCity.Win.Editors.AllowSpace.None

            gcIme1.SetInputScope(gcTextBox1, InputScopeNameValue.Hiragana)

            SetCommonValidate(gcTextBox1)
        End Sub

        ''' <summary>
        ''' フリガナ（GcTextBox）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyFurigana()
            gcIme1.SetReadingStringOutput(gcTextBox1, New ReadingStringOutput(gcTextBox2, ReadingStringOutputMode.Append))
            gcTextBox2.Format = "Ｋ"
            gcTextBox2.AlternateText.DisplayNull.Text = "カタカナを入力できます。"
            gcTextBox2.AlternateText.DisplayNull.ForeColor = Color.Gray
            gcTextBox2.AllowSpace = GrapeCity.Win.Editors.AllowSpace.None
            gcIme1.SetInputScope(gcTextBox2, InputScopeNameValue.KatakanaFullWidth)
        End Sub

        ''' <summary>
        ''' 生年月日（GcDate）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyDateOfBirth()
            Me.gcDate1.Fields.AddRange(New DateField() {
                                       New DateEraField(),
                                       New DateLiteralField(),
                                       New DateEraYearField(),
                                       New DateLiteralField() With {.Text = "年"},
                                       New DateMonthField(),
                                       New DateLiteralField() With {.Text = "月"},
                                       New DateDayField(),
                                       New DateLiteralField() With {.Text = "日"}})

            gcDate1.DropDownCalendar.HeaderFormat = "ggg e年 M月"
            gcDate1.DropDownCalendar.UseHeaderFormat = True
            Dim gcDateInvalidRange1 As GcDateValidator.InvalidRange = New GcDateValidator.InvalidRange With {
                .MaxValue = DateTime.Today,
                .MinValue = New DateTime(1926, 1, 1),
                .InvalidMessage = "昭和１年 ～ 本日の範囲の日付を入力できます。"
            }
            gcDateValidator1.GetValidateItems(gcDate1).AddRange(New Object() {gcDateInvalidRange1})
            gcDateValidator1.GetValidateActions(gcDate1).AddRange(New ValidateAction() {New IconNotify()})
            SetCommonValidate(gcDate1)
        End Sub

        ''' <summary>
        ''' 電話番号（GcMask)へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyTelephoneNumber()
            gcMask1.Fields.AddRange(New MaskField() {
                                    New MaskLiteralField("℡ "),
                                    New MaskPatternField("\D", 3, 4),
                                    New MaskLiteralField("-"),
                                    New MaskPatternField("\D", 3, 4),
                                    New MaskLiteralField("-"),
                                    New MaskPatternField("\D", 4, 4)})
            gcMask1.ImeMode = ImeMode.Off
            SetCommonValidate(gcMask1)
        End Sub

        ''' <summary>
        ''' 郵便番号（GcPostal）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyZipCode()
            gcPostal1.Fields.ZipCodePrefix.Text = "〒"
            gcPostal1.SplitAreaDetails = True
            SetCommonValidate(gcPostal1)
        End Sub

        ''' <summary>
        ''' 住所（GcAddressBox）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyAddress()
            gcAddressBox1.AutoFilter = True
            Dim addressOutputSetting1 As AddressOutputSetting = New AddressOutputSetting With {
                .AddressOutput = gcAddressBox1
            }
            gcAddress1.SetAddressOutputSetting(gcPostal1, addressOutputSetting1)
        End Sub

        ''' <summary>
        ''' 内線番号（GcMask）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyExtensionNumber()
            gcMask2.Fields.Add(New MaskPatternField("\D", 4, 4))
        End Sub

        ''' <summary>
        ''' 部署名（GcComboBox）へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyDepartmentName()
            gcComboBox1.ListColumns.AddRange(New ListColumn() {
                                             New ListColumn("部名"),
                                             New ListColumn("課名"),
                                             New ListColumn("部課名"),
                                             New ListColumn("部課名コード")})
            gcComboBox1.TextSubItemIndex = 2
            gcComboBox1.DropDownStyle = ComboBoxStyle.DropDown
            gcComboBox1.IsEditable = False
            gcComboBox1.ListColumns(0).AutoWidth = True
            gcComboBox1.ListColumns(1).AutoWidth = True
            gcComboBox1.ListColumns(2).Visible = False
            gcComboBox1.ListColumns(3).Visible = False
            Dim list As List(Of ListItem) = New List(Of ListItem)()

            For Each item As Department In GetData()
                list.Add(New ListItem(New SubItem() {
                                      New SubItem(item.DepartmentName),
                                      New SubItem(item.DivisionName),
                                      New SubItem(item.Name),
                                      New SubItem(item.Code)}))
            Next

            gcComboBox1.Items.AddRange(list.ToArray())
            gcComboBox1.SelectedIndex = -1
            SetCommonValidate(gcComboBox1)
        End Sub

        ''' <summary>
        ''' 通信欄（GcTextBox)へのプロパティ設定
        ''' </summary>
        Private Sub SetPropertyMessageColumn()
            gcTextBox3.Multiline = True
            gcTextBox3.WrapMode = WrapMode.CharWrap
            gcTextBox3.LineSpace = 2
            gcTextBox3.MaxLineCount = 5
        End Sub

        ''' <summary>
        ''' 各コントロールのフォーカス移動の設定
        ''' </summary>
        Private Sub SetPropertyFocus()
            SetPropertyFocus(gcNumber1)
            SetPropertyFocus(gcTextBox1)
            SetPropertyFocus(gcTextBox2)
            SetPropertyFocus(gcPostal1)
            SetPropertyFocus(gcAddressBox1)
            SetPropertyFocus(gcMask1)
            SetPropertyFocus(gcDate1)
            SetPropertyFocus(gcComboBox1)
            SetPropertyFocus(gcMask2)
            SetPropertyFocus(gcTextBox3)
        End Sub

        ''' <summary>
        ''' フォーカス移動の設定
        ''' </summary>
        Private Sub SetPropertyFocus(control As EditBase)
            control.ExitOnLastChar = True
            control.ExitOnLeftRightKey = ExitOnLeftRightKey.Both
            gcShortcut1.SetShortcuts(control, New ShortcutCollection(New Keys() {Keys.Enter, Keys.Enter Or Keys.Shift},
                                     New Object() {gcShortcut1, gcShortcut1},
                                     New String() {"NextControl", "PreviousControl"}))
        End Sub

        ''' <summary>
        ''' 汎用検証（必須入力）の設定
        ''' </summary>
        ''' <param name="control"></param>
        Private Sub SetCommonValidate(control As EditBase)
            gcCommonValidator1.GetValidateItems(control).AddRange(New Object() {New GrapeCity.Win.Editors.EmptyText With {
                                                                  .InvalidMessage = "入力必須項目です",
                                                                  .FieldsExclude = True}})
            gcCommonValidator1.GetValidateActions(control).AddRange(New ValidateAction() {New IconNotify()})
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
