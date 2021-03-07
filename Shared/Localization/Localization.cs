using System;

namespace BPMS.Shared.Localization
{
    public static class lh
    {
        static lh() {}

        public static string fs(FormattableString s, string lang = null) => string.Format(s.Format.loc(lang), s.GetArguments());
        public static string loc(this string s, string lang = null) => lh.s(s, lang);
        public static string s(string s, string lang = null) => s;
    }
}
