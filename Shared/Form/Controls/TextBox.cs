namespace BPMS.Shared.Form.Controls
{
    public class TextBox : ControlData
    {
        public TextBox(string id, string caption, string placeholder = "")
        {
            Id = id;
            ControlType = ControlType.TextBox;
            IsContainer = false;
            Caption = caption;
            Placeholder = placeholder;
        }
    }
}
