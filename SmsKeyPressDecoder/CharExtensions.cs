namespace SmsKeyPressDecoder
{
    public static class CharExtensions
    {
        public static  bool IsSpace(this char key)
        {
            return Keys.IsSpace(key);
        }

        public static bool IsEqualTo(this char key, LetterKey comparer)
        {
            return key == comparer?.Number;
        }

        public static bool IsValidLetterKey(this char key)
        {
            return Keys.IsValid(key);
        }
    }
}
