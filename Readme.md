<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581540/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4493)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DateDataSourceWrapper.cs](./CS/CustomDatesPivot/DateDataSourceWrapper.cs) (VB: [DateDataSourceWrapper.vb](./VB/CustomDatesPivot/DateDataSourceWrapper.vb))
* [Form1.cs](./CS/CustomDatesPivot/Form1.cs) (VB: [Form1.vb](./VB/CustomDatesPivot/Form1.vb))
* [Program.cs](./CS/CustomDatesPivot/Program.cs) (VB: [Program.vb](./VB/CustomDatesPivot/Program.vb))
<!-- default file list end -->
# How to Display Field Values Missing in the Original Data Source


The Pivot Grid control cannot display field values which are not present in the underlying data source. However, you can create a data source wrapper to add the missing values.

This example demonstrates how to create and use a data source wrapper. The _CustomDates_ collection is filled with DateTime values based on the actual Start/End DateTime range and the specified interval (e.g., Month). The **DateDataSourceWrapper** class merges the _CustomDates_ collection with the original data table. 

When PivotGridControl requests data using the common <a href="https://msdn.microsoft.com/en-us/library/system.collections.ilist(v=vs.110).aspx">IList</a> and <a href="https://msdn.microsoft.com/en-us/library/system.componentmodel.itypedlist(v=vs.110).aspx">ITypedList</a> interface methods, the data source wrapper returns data from the original collection or generates _EmptyObjectPropertyDescriptor_ objects to return rows with **null** "Date" field values.
