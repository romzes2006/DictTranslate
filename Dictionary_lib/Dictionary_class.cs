using System;
using System.Collections.Generic;

namespace Dictionary_lib
{
    public class Dictionary_class
    {
        public Dictionary<string, string> _Vocabulary { get; }

        public Dictionary_class()
        {
            _Vocabulary = new Dictionary<string, string>();
        }

        public Dictionary_class(Dictionary<string, string> Vocabulary)
        {
            _Vocabulary = Vocabulary;
        }

        public string Translate(string word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                if (_Vocabulary.TryGetValue(word, out string valueTranslation))
                {
                    return valueTranslation;
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
    }
}