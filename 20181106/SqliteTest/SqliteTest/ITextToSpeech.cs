using System;
using System.Collections.Generic;
using System.Text;

namespace SqliteTest
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
