using System;
using System.Collections.Generic;
using System.Linq;

namespace SmsKeyPressDecoder
{
    public static class ValidKeys
    {
        public static Dictionary<char, char[]> KeyValues = new Dictionary<char, char[]>
        {
            { '0', new char[1] {' ' } },
            { '2', new char[3] {'A', 'B', 'C'} },
            { '3', new char[3] {'D', 'E', 'F'} },
            { '4', new char[3] {'G', 'H', 'I'} },
            { '5', new char[3] {'J', 'K', 'L'} },
            { '6', new char[3] {'M', 'N', 'O'} },
            { '7', new char[4] {'P', 'Q', 'R', 'S'} },
            { '8', new char[3] {'T', 'U', 'V'} },
            { '9', new char[4] {'W', 'X', 'Y', 'Z'} }
        };

        public static bool IsValidKey(char key)
        {
            return KeyValues.Keys.Contains(key);
        }

        public static bool IsSpace(char key)
        {
            return key == KeyValues.Keys.First();
        }
    }
}
