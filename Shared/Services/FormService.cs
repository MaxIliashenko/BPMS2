using BPMS.Shared.Form;
using BPMS.Shared.Form.Controls;
using BPMS.Shared.Interfaces.Services;
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
            col2.SetControl(new TextBox("initiator", "Initiator"));
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
            f.FormObject["number"] = 25;
            row2.Columns.Add(col4);

            f.Rows.Add(row2);

            return f;
        }
    }
}
