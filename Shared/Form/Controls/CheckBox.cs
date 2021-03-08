namespace BPMS.Shared.Form.Controls
{
    public class CheckBox : ControlData
    {
        public CheckBox(string id, string caption)
        {
            Id = id;
            ControlType = ControlType.CheckBox;
            IsContainer = false;
            Caption = caption;
        }
    }
}
