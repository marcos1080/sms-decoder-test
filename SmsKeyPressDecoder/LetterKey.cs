namespace SmsKeyPressDecoder
{
    public class LetterKey
    {
        private int _index;

        public LetterKey(char key)
        {
            Number = key;
            _index = 0;
        }

        public char Number { get; }
        public char Letter => Keys.GetLetter(Number, _index);

        public bool IsSpace()
        {
            return Keys.IsSpace(Number);
        }

        public void Press()
        {
            _index++;
            if (_index == Keys.LetterCount(Number))
            {
                _index = 0;
            }
        }
    }
}
