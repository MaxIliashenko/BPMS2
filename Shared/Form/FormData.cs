using System.Collections.Generic;
using BPMS.Shared.Form.Controls;

namespace BPMS.Shared.Form
{
    public class FormData
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<Row> Rows { get; set; } = new();
        public Dictionary<string, object> FormObject { get; set; } = new();
    }
}
