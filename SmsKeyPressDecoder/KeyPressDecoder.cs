namespace SmsKeyPressDecoder
{
    public class KeyPressDecoder
    {
        /// <summary>
        /// Decodes a string representing key presses on a multi tap feature phone. See read me for more information.
        /// </summary>
        /// <param name="inputKeys">A string containing the numbers 0 to 9 representing key presses</param>
        /// <returns>The decoded message</returns>
        public string Decode(string inputKeys)
        {
            var message = new KeyList();

            foreach (char key in inputKeys)
            {
                // Case: Invalid number
                if (!key.IsValidLetterKey())
                {
                    continue;
                }

                // Case: Initialise or add space
                if (message.IsEmpty || key.IsSpace())
                {
                    message.Add(new LetterKey(key));
                    continue;
                }

                // Case: Space was pressed to change letter
                if (message.LastLetterKey.IsSpace() && key.IsEqualTo(message.LastLetterKeyPressed))
                {
                    message.RemoveLastKey();
                    message.Add(new LetterKey(key));
                    continue;
                }

                // Case: Same "letter" or different "letter" pressed
                if (key.IsEqualTo(message.LastLetterKey))
                {
                    message.PressLastKey();
                } else
                {
                    message.Add(new LetterKey(key));
                }
            }

            return message.ToString();
        }
    }
}
