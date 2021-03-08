using System.Collections.Generic;

namespace BPMS.Shared.Form.Controls
{
    public class Row : ControlData
    {
        public List<Column> Columns { get; set; }

        public Row(string id)
        {
            Id = id;
            ControlType = ControlType.Row;
            IsContainer = true;
            Columns = new List<Column>();
        }
    }
}
