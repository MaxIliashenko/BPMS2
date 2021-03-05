using System;

namespace BPMS.Shared.Layout
{
    public class HomeItem
    {
        public Guid Id { get; set; }
        public bool Enabled { get; set; }
        public bool Root { get; set; }
        public bool TopMenu { get; set; }
        public string Text { get; set; }
        public Guid ParentId { get; set; }
        public string TextPosition { get; set; }
        public string TextColor { get; set; }
        public string TextColorHover { get; set; }
        public string TextColorHighlight { get; set; }
        public bool HasChildren { get; set; }
        public bool IsMenu { get; set; }
        public string ImageUrl { get; set; }
        public string IconShape { get; set; }
        public bool IsFontAwesome { get; set; }
        public string FAIcon { get; set; }
    }
}
