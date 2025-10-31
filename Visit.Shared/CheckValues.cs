namespace Visit.Shared
{
    public static class CheckValues
    {
        public static bool IsDigit(this string text)
        {
            bool isDigit = true;
            foreach (var item in text)
            {
                if (!char.IsDigit(item))
                {
                    isDigit = false;
                    break;
                }
            }
            return isDigit;
        }
        public static bool IsPersian(this string text)
        {
            bool isParsian = true;
            foreach (var letter in text)
            {
                if (!((letter >= 'ا' && letter <= 'ی') || letter == ' '))
                {
                    isParsian = false;
                    break;
                }
            }
            return isParsian;
        }
        public static bool IsEnglish(this string text)
        {
            bool isEnglish = false;
            foreach (var letter in text)
            {
                if ((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z'))
                {
                    isEnglish = true;
                    break;
                }
            }
            return isEnglish;
        }
    }
}
