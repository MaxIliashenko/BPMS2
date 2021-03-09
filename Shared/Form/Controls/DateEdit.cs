namespace BPMS.Shared.Form.Controls
{
    public class DateEdit : ControlData
    {
        public DateEdit(string id, string caption, bool isDateTimeWithTime = true)
        {
            Id = id;
            ControlType = ControlType.DateEdit;
            IsContainer = false;
            Caption = caption;
            IsDateTimeWithTime = isDateTimeWithTime;
        }
    }
}
