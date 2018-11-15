<!-- default file list -->
*Files to look at*:

* **[DateDataSourceWrapper.cs](./CS/CustomDatesPivot/DateDataSourceWrapper.cs) (VB: [DateDataSourceWrapper.vb](./VB/CustomDatesPivot/DateDataSourceWrapper.vb))**
* [Form1.cs](./CS/CustomDatesPivot/Form1.cs) (VB: [Form1.vb](./VB/CustomDatesPivot/Form1.vb))
* [Program.cs](./CS/CustomDatesPivot/Program.cs) (VB: [Program.vb](./VB/CustomDatesPivot/Program.vb))
<!-- default file list end -->
# How to add custom Field Values (Rows/Columns) that are not present in a DataSource


<p>As described in the <a href="https://www.devexpress.com/Support/Center/p/CQ51572">Custom column/row values ( Show Field Values that are not present in the original data source )</a> ticket, PivotGridControl cannot display field values in row and column areas if these values are not represented in the underlying datasource. As a workaround you can add all required values to the original datosource or create a datasource wrapper that contains all required values on its level, and there is no need to modify original datasource. <br> This example illustrates how to create such a datasource wrapper. It is based on the <a href="https://www.devexpress.com/Support/Center/p/E1180">How to create a data source wrapper that adds an empty item to the lookup list</a> example.<br> To hide rows and columns with null field values, handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomFieldValueCellstopic"><u>CustomFieldValueCells</u></a> event.<br><br>In the example, the CustomDates collection is filled with DateTime values based on the actual Start/End DateTime range and the specified interval (e.g., Month). This collection is passed to the DateDataSourceWrapper class instance along with the original data source collection (<em>Table.DefaultView</em>). The main idea of creating a custom wrapper class is to merge the CustomDates collection with the original data table without modifying the latter one. So, when PivotGridControl requests data using the common <a href="https://msdn.microsoft.com/en-us/library/system.collections.ilist(v=vs.110).aspx">IList</a> and <a href="https://msdn.microsoft.com/en-us/library/system.componentmodel.itypedlist(v=vs.110).aspx">ITypedList</a> interface methods, wrapper returns data from the original collection or generates <em>EmptyObjectPropertyDescriptor</em> objects to return rows with null "Date" field values. For instance, check the DateDataSourceWrapper.this[int index] and DateDataSourceWrapper.GetItemProperties method implementations.<br><br>You can also check the following example that illustrates the ITypedList interface concept: <a href="https://docs.microsoft.com/en-us/dotnet/framework/winforms/how-to-implement-the-itypedlist-interface">How to: Implement the ITypedList Interface</a>.</p>

<br/>


