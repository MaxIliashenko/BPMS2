namespace BPMS.Shared.Form.Controls
{
    public class Column : ControlData
    {
        public int Width { get; set; }
        public ControlData Control { get; set; }

        public Column(string id, int width = 12)
        {
            Id = id;
            ControlType = ControlType.Column;
            IsContainer = true;
            Width = width;
        }

        public ControlData SetControl(ControlData control)
        {
            Control = control;
            Control.ParentColumn = this;
            Control.ParentColumnWidth = Width;
            return control;
        }

    }
}
