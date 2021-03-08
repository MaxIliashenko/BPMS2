namespace BPMS.Shared.Form.Controls
{
    public class NumericBox : ControlData
    {
        public NumericBox(string id, string caption, string format = "n")
        {
            Id = id;
            ControlType = ControlType.NumericBox;
            IsContainer = false;
            Caption = caption;
            Format = format;
        }
    }
}
