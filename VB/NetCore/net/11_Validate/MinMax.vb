Imports System.Collections.Generic

Namespace _11_Validate
    Partial Public Class MinMax
        Inherits InputManWin12_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            ' ***** 初期値
            gcDateTime1.MinDate = gcDateTime2.Value.Value
            gcDateTime1.MaxDate = gcDateTime3.Value.Value
            gcDate1.MinValue = gcDate2.Value.Value
            gcDate1.MaxValue = gcDate3.Value.Value
            gcTime1.MinValue = gcTime2.Value.Value
            gcTime1.MaxValue = gcTime3.Value.Value
            gcNumber1.MinValue = gcNumber2.Value.Value
            gcNumber1.MaxValue = gcNumber3.Value.Value
            gcTimeSpan1.MinValue = gcTimeSpan2.Value.Value
            gcTimeSpan1.MaxValue = gcTimeSpan3.Value.Value
            gcComboBox1.SelectedIndex = Convert.ToInt32(gcDateTime1.MaxMinBehavior)
        End Sub

        Private Sub gcDateTime2_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles gcDate2.Validated
            Dim invalidControlList1 As List(Of GrapeCity.Win.Editors.GcDateTime) = gcDateTimeValidator1.GetInvalidControls()
            If Not invalidControlList1.Contains(gcDateTime2) Then
                gcDateTime1.MinDate = gcDateTime2.Value.Value
            End If
        End Sub

        Private Sub gcDateTime3_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles gcDateTime3.Validated
            Dim invalidControlList1 As List(Of GrapeCity.Win.Editors.GcDateTime) = gcDateTimeValidator1.GetInvalidControls()
            If Not invalidControlList1.Contains(gcDateTime3) Then
                gcDateTime1.MaxDate = gcDateTime3.Value.Value
            End If
        End Sub

        Private Sub gcDate2_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles gcDate2.Validated
            Dim invalidControlList1 As List(Of GrapeCity.Win.Editors.GcDate) = gcDateValidator1.GetInvalidControls()
            If Not invalidControlList1.Contains(gcDate2) Then
                gcDate1.MinValue = gcDate2.Value.Value
            End If
        End Sub

        Private Sub gcDate3_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles gcDate3.Validated
            Dim invalidControlList1 As List(Of GrapeCity.Win.Editors.GcDate) = gcDateValidator1.GetInvalidControls()
            If Not invalidControlList1.Contains(gcDate3) Then
                gcDate1.MaxValue = gcDate3.Value.Value
            End If
        End Sub

        Private Sub gcTime2_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles gcTime2.Validated
            Dim invalidControlList1 As List(Of GrapeCity.Win.Editors.GcTime) = gcTimeValidator1.GetInvalidControls()
            If Not invalidControlList1.Contains(gcTime2) Then
                gcTime1.MinValue = gcTime2.Value.Value
            End If
        End Sub

        Private Sub gcTime3_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles gcTime3.Validated
            Dim invalidControlList1 As List(Of GrapeCity.Win.Editors.GcTime) = gcTimeValidator1.GetInvalidControls()
            If Not invalidControlList1.Contains(gcTime3) Then
                gcTime1.MaxValue = gcTime3.Value.Value
            End If
        End Sub

        Private Sub gcNumber2_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber2.Validated
            Dim invalidControlList1 As List(Of GrapeCity.Win.Editors.GcNumber) = gcNumberValidator1.GetInvalidControls()
            If Not invalidControlList1.Contains(gcNumber2) Then
                gcNumber1.MinValue = gcNumber2.Value.Value
            End If
        End Sub

        Private Sub gcNumber3_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles gcNumber3.Validated
            Dim invalidControlList1 As List(Of GrapeCity.Win.Editors.GcNumber) = gcNumberValidator1.GetInvalidControls()
            If Not invalidControlList1.Contains(gcNumber3) Then
                gcNumber1.MaxValue = gcNumber3.Value.Value
            End If
        End Sub

        Private Sub gcTimeSpan2_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles gcTimeSpan2.Validated
            Dim invalidControlList1 As List(Of GrapeCity.Win.Editors.GcTimeSpan) = gcTimeSpanValidator1.GetInvalidControls()
            If Not invalidControlList1.Contains(gcTimeSpan2) Then
                gcTimeSpan1.MinValue = gcTimeSpan2.Value.Value
            End If
        End Sub

        Private Sub gcTimeSpan3_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles gcTimeSpan3.Validated
            Dim invalidControlList1 As List(Of GrapeCity.Win.Editors.GcTimeSpan) = gcTimeSpanValidator1.GetInvalidControls()
            If Not invalidControlList1.Contains(gcTimeSpan3) Then
                gcTimeSpan1.MaxValue = gcTimeSpan3.Value.Value
            End If
        End Sub

        Private Sub gcComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gcComboBox1.SelectedIndexChanged
            gcDateTime1.MaxMinBehavior = CType(gcComboBox1.SelectedIndex, GrapeCity.Win.Editors.MaxMinBehavior)
            gcDate1.MaxMinBehavior = CType(gcComboBox1.SelectedIndex, GrapeCity.Win.Editors.MaxMinBehavior)
            gcTime1.MaxMinBehavior = CType(gcComboBox1.SelectedIndex, GrapeCity.Win.Editors.MaxMinBehavior)
            gcNumber1.MaxMinBehavior = CType(gcComboBox1.SelectedIndex, GrapeCity.Win.Editors.MaxMinBehavior)
            gcTimeSpan1.MaxMinBehavior = CType(gcComboBox1.SelectedIndex, GrapeCity.Win.Editors.MaxMinBehavior)
        End Sub
    End Class
End Namespace

