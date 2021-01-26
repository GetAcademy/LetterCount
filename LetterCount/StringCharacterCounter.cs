using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LetterCount
{
    class StringCharacterCounter
    {
        private CharacterCount[] _counts;

        public StringCharacterCounter()
        {
            var range = 250;
            _counts = new CharacterCount[range];
            for (var characterInt = 0; characterInt < range; characterInt++)
            {
                _counts[characterInt] = new CharacterCount(characterInt);
            }
        }

        public void Count(string text)
        {
            foreach (var character in text ?? string.Empty)
            {
                //var characterCount = GetOrCreateCharacterCount(character);
                var index = CharacterCount.IntValueFromChar(character);
                _counts[index].Count();
            }
        }

        //private CharacterCount GetOrCreateCharacterCount(char character)
        //{
        //    var intValue = CharacterCount.IntValueFromChar(character);
        //    var characterCount = _counts[intValue];
        //    if (characterCount != null) return characterCount;
        //    characterCount = _counts[intValue] = new CharacterCount(character);
        //    return characterCount;
        //}

        public void Show()
        {
            //var txt = string.Join("", 
            //    _counts.Select(c => c.GetDescription()));
            //Console.WriteLine(txt);
            foreach (var counter in _counts)
            {
                counter.ShowIfGreatherThanZero();
            }
        }
    }
}
