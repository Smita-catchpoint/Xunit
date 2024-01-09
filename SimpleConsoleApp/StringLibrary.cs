

namespace simpleconsoleapp
{
    public static class StringLibrary
    {
        //public static bool startswithupper(this string s)
        //{
        //    if (string.IsNullOrWhiteSpace(s))
        //        return false;

        //    return char.IsUpper(s[0]);
        //}
        public static bool StartsWithUpper(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;

            return char.IsUpper(s[0]);
        }

        public static bool StartsWithLower(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;

            return char.IsLower(s[0]);
        }

        public static bool HasEmbeddedSpaces(string s)
        {
            foreach (var ch in s.Trim())
            {
                if (ch == ' ')
                    return true;
            }
            return false;
        }
    }
}
