using BPMS.Shared.Form;
using BPMS.Shared.Form.Controls;
using BPMS.Shared.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace BPMS.Shared.Services
{
    public class FormService : IFormService
    {
        public async Task<FormData> GetForm(string id)
        {
            var f = new FormData { Id = id, Title = "Test static form" };

            var row = new Row("row1");

            var col = new Column("col1", 6);
            col.SetControl(new TextBox("title", "Title"));
            f.FormObject["title"] = "My title";
            row.Columns.Add(col);

            var col2 = new Column("col2", 6);
            col2.SetControl(new TextBox("initiator", "Initiator","Enter data"));
            f.FormObject["initiator"] = "Developer";
            row.Columns.Add(col2);

            f.Rows.Add(row);

            var row2 = new Row("row2");

            var col3 = new Column("col3", 6);
            col3.SetControl(new CheckBox("active", "Active"));
            f.FormObject["active"] = true;
            row2.Columns.Add(col3);

            var col4 = new Column("col4", 6);
            col4.SetControl(new NumericBox("number", "Number", "N2"));
            f.FormObject["number"] = 25.17;
            row2.Columns.Add(col4);

            f.Rows.Add(row2);

            var row3 = new Row("row3");

            var col5 = new Column("col5", 6);
            col5.SetControl(new Label("label", "Very long label to test alignment"));
            row3.Columns.Add(col5);

            var col6 = new Column("col6", 6);
            col6.SetControl(new DateEdit("created", "Created at"));
            f.FormObject["created"] = new DateTime(2021, 3, 8, 21, 13, 24);
            row3.Columns.Add(col6);

            f.Rows.Add(row3);

            return f;
        }
    }
}
