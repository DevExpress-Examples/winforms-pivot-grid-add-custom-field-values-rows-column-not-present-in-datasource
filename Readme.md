<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581540/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4493)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# How to Add Custom Field Values (Rows/Columns) that Are Not Present in a Data Source

Pivot Grid does not display field values in row and column areas if these values are not represented in the underlying data source. This example demonstrates how to create a data source wrapper that contains all required values on its level, and there is no need to modify original data source. In the example, the `CustomDates` collection is filled with DateTime values based on the actual Start/End DateTime range and the specified interval (for example, `Month`). This collection is passed to the `DateDataSourceWrapper` class instance along with the original data source collection (`Table.DefaultView`). `CustomDates` collection is merged with the original data table and you do not need to modify the data source. When Pivot Grid requests data with the common [IList](https://msdn.microsoft.com/en-us/library/system.collections.ilist(v=vs.110).aspx) and [ITypedList](https://msdn.microsoft.com/en-us/library/system.componentmodel.itypedlist(v=vs.110).aspx) interfaces methods, the `DateDataSourceWrapper` object returns data from the original collection or generates `EmptyObjectPropertyDescriptor` objects to return rows with null "Date" field values.

The following image illustrates Pivot Grid that displays the custom `March` field value from the `CustomDates` collection along with field values from the data source:

<!-- default file list -->
## Files to Look at
* [DateDataSourceWrapper.cs](./CS/CustomDatesPivot/DateDataSourceWrapper.cs) (VB: [DateDataSourceWrapper.vb](./VB/CustomDatesPivot/DateDataSourceWrapper.vb))
* [Form1.cs](./CS/CustomDatesPivot/Form1.cs) (VB: [Form1.vb](./VB/CustomDatesPivot/Form1.vb))
* [Program.cs](./CS/CustomDatesPivot/Program.cs) (VB: [Program.vb](./VB/CustomDatesPivot/Program.vb))
<!-- default file list end -->

## More Examples 

- [Pivot Grid for WPF](https://github.com/DevExpress-Examples/how-to-add-custom-field-values-rows-columns-that-are-not-present-in-a-datasource-t615806/tree/21.1.5+)
- [How to create a data source wrapper that adds an empty item to the lookup list](https://github.com/DevExpress-Examples/how-to-create-a-data-source-wrapper-that-adds-an-empty-item-to-the-lookup-list-e1180).
