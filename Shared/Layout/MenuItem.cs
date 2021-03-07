using System.Collections.Generic;

namespace BPMS.Shared.Layout
{
    public class MenuItem
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public List<MenuItem> ChildItems { get; set; }
        public bool IsCategory { get; set; }
        public bool IsExternalLink { get; set; }
        public string Icon { get; set; }
        public string IconUrl { get; set; }
        public string CSSClass { get; set; }

        public MenuItem(string text = "", string url = "", bool isCategory = false, bool isExternalLink = false)
        {
            Text = text;
            Url = url;
            IsCategory = isCategory;
            IsExternalLink = isExternalLink;
            ChildItems = new List<MenuItem>();
        }
    }
}
