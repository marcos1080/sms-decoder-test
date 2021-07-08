using System.Collections.Generic;
using System.Text;

namespace SmsKeyPressDecoder
{
    public class KeyList
    {
        private LinkedList<LetterKey> _keys = new LinkedList<LetterKey>();

        public LetterKey LastLetterKeyPressed = null;
        public bool IsEmpty => _keys.Last is null;
        public LetterKey LastLetterKey => _keys.Last?.Value;

        public void Add(LetterKey keyState) {
            _keys.AddLast(keyState);

            if (!Keys.IsSpace(keyState.Number))
            {
                LastLetterKeyPressed = keyState;
            }
        }

        public void RemoveLastKey()
        {
            _keys.RemoveLast();
        }

        public void PressLastKey()
        {
            LastLetterKey.Press();
        }

        public override string ToString()
        {
            var message = new StringBuilder();
            var nextKey = _keys.First;
            while (nextKey != null)
            {
                message.Append(nextKey.Value.Letter);
                nextKey = nextKey.Next;
            }

            return message.ToString();
        }
    }
}
