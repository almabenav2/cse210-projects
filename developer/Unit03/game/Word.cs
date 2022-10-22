using System;
using System.Collections.Generic;

namespace jumper.Game
{
    
    public class Word
    {

        List<string> _word;

        //create array of words to guess
        public Word()
        {
            _word = new List<string>{"program", "class", "parachute", "game", 
                                    "code", "list", "random", "terminal"};

        }

        //randomly chooses a word from the array.
        public string GetRandomWord()
                {
                    Random _randWord = new Random();
                    int index = _randWord.Next(_word.Count);
                    var _displayWord = _word[index];
                
                    return _displayWord;
                }
    }
}