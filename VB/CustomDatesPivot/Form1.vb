Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace CustomDatesPivot

    Public Partial Class Form1
        Inherits Form

        Private Table As DataTable

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Shared Function CreatePivotTable(ByVal RowCount As Integer) As DataTable
            Dim rnd As Random = New Random()
            Dim tbl As DataTable = New DataTable()
            tbl.Columns.Add("ID", GetType(Integer))
            tbl.Columns.Add("Name", GetType(String))
            tbl.Columns.Add("Checked", GetType(Boolean))
            tbl.Columns.Add("Number", GetType(Integer))
            tbl.Columns.Add("Value", GetType(Decimal))
            tbl.Columns.Add("AltValue", GetType(Decimal))
            tbl.Columns.Add("Date", GetType(Date))
            For i As Integer = 0 To RowCount - 1
                Dim row As DataRow = tbl.Rows.Add(New Object() {i, String.Format("Name{0}", i Mod 9), i Mod 2 = 0, rnd.Next(10), rnd.Next(100, 1000), rnd.Next(100, 1000), Date.Now.AddDays(rnd.Next(300))})
            Next

            Return tbl
        End Function

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            dateEdit1.DateTime = Date.Now
            dateEdit2.DateTime = Date.Now.AddMonths(12)
            Table = CreatePivotTable(100)
            pivotGridControl1.DataSource = Table
        End Sub

        Private Sub pivotGridControl1_CustomFieldValueCells(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomFieldValueCellsEventArgs)
            Dim index As Integer = pivotGridControl1.GetRowIndex(New Object() {Nothing})
            If index <> -1 Then e.Remove(e.GetCell(False, index))
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim DateFields As List(Of String) = New List(Of String)()
            DateFields.Add("Date")
            Dim CustomDates As List(Of Date) = New List(Of Date)()
            Dim [date] As Date = dateEdit1.DateTime
            While [date] < dateEdit2.DateTime
                CustomDates.Add([date])
                Select Case comboBoxEdit1.Text
                    Case "Year"
                        [date] = [date].AddYears(1)
                    Case "Quarter"
                        [date] = [date].AddMonths(3)
                    Case "Month"
                        [date] = [date].AddMonths(1)
                    Case Else
                        [date] = [date].AddDays(1)
                End Select
            End While

            pivotGridControl1.DataSource = New DateDataSourceWrapper(Table.DefaultView, DateFields, CustomDates)
        End Sub
    End Class
End Namespace
