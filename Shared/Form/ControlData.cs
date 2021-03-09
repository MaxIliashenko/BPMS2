using System.Text.Json.Serialization;
using BPMS.Shared.Form.Controls;

namespace BPMS.Shared.Form
{
    public class ControlData
    {
        public string Id { get; set; }

        public ControlType ControlType { get; set; }
        public bool IsContainer { get; set; }
        public string ControlTypeName => ControlType.ToString();
        public string Caption { get; set; }
        public string Placeholder { get; set; }
        public string Format { get; set; }
        public bool IsDateTimeWithTime { get; set; }

        [JsonIgnore]
        public Column ParentColumn { get; set; }
        public int ParentColumnWidth { get; set; }
    }

    public enum ControlType
    {
        Row, Column, Label, TextBox, NumericBox, CheckBox, DateEdit
    }

}
