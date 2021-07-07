namespace SmsKeyPressDecoder
{
    public class LetterKey
    {
        private int _index;

        public LetterKey(char number)
        {
            Number = number;
            _index = 0;
        }

        public char Number { get; }
        public char Letter => ValidKeys.KeyValues[Number][_index];

        public bool IsSpace()
        {
            return ValidKeys.IsSpace(Number);
        }

        public void Press()
        {
            _index++;
            if (_index == ValidKeys.KeyValues[Number].Length)
            {
                _index = 0;
            }
        }
    }
}
