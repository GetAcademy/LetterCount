using System;
using System.Collections.Generic;
using System.Text;

namespace LetterCount
{
    class CharacterCount
    {
        private char _character;
        public int Quantity { get; private set; }
        public int IntValue => IntValueFromChar(_character);

        public CharacterCount(char character)
        {
            _character = character;
        }

        public CharacterCount(int c)
        {
            _character = (char)c;
        }

        public void Count()
        {
            Quantity++;
        }

        public static int IntValueFromChar(char c)
        {
            return (int) c;
        }

        public void ShowIfGreatherThanZero()
        {
            if (Quantity == 0) return;
            Console.WriteLine(_character + " - " + Quantity);
        }

        public string GetDescription()
        {
            if (Quantity == 0) return "";
            return _character + " - " + Quantity;
        }
    }
}
