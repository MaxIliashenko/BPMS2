namespace BPMS.Shared.Form.Controls
{
    public class Label : ControlData
    {
        public Label(string id, string caption)
        {
            Id = id;
            ControlType = ControlType.Label;
            IsContainer = false;
            Caption = caption;
        }
    }
}
