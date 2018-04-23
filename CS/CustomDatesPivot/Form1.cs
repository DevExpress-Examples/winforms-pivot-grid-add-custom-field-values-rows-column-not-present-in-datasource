using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomDatesPivot
{
    public partial class Form1 : Form
    {
        DataTable Table;
        public Form1()
        {
            InitializeComponent();
        }
        private static DataTable CreatePivotTable(int RowCount)
        {
            Random rnd = new Random();

            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("Checked", typeof(bool));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Value", typeof(decimal));
            tbl.Columns.Add("AltValue", typeof(decimal));
            tbl.Columns.Add("Date", typeof(DateTime));


            for (int i = 0; i < RowCount; i++)
            {
                DataRow row = tbl.Rows.Add(new object[] { i, String.Format("Name{0}", i % 9), i % 2 == 0, rnd.Next(10), rnd.Next(100, 1000), rnd.Next(100, 1000), DateTime.Now.AddDays(rnd.Next(300)) });
            }
            return tbl;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now;
            dateEdit2.DateTime = DateTime.Now.AddMonths(12);
            Table = CreatePivotTable(100);
            pivotGridControl1.DataSource = Table;
        }

        private void pivotGridControl1_CustomFieldValueCells(object sender, DevExpress.XtraPivotGrid.PivotCustomFieldValueCellsEventArgs e)
        {
            int index = pivotGridControl1.GetRowIndex(new object[]{null});
            if (index!= -1)
            e.Remove(e.GetCell(false, index));
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<string> DateFields = new List<string>();
            DateFields.Add("Date");
            List<DateTime> CustomDates = new  List<DateTime>();
            DateTime date = dateEdit1.DateTime;
            while (date < dateEdit2.DateTime)
            {
                CustomDates.Add(date);
                switch (comboBoxEdit1.Text)
                {
                    case "Year": date = date.AddYears(1);
                        break;
                    case "Quarter": date = date.AddMonths(3);
                        break;
                    case "Month": date = date.AddMonths(1);
                        break;
                    default:
                        date = date.AddDays(1);
                        break;
                }
            }
            pivotGridControl1.DataSource = new DateDataSourceWrapper(Table.DefaultView, DateFields, CustomDates);
        }
    }
}
