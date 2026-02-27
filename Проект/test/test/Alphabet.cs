using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Alphabet
    {
        public char[] Chars { get; set; }
        public Alphabet(string language) 
        {
            switch(language)
            {
                case "ru":
                    {
                        char[] chars = new char[33];
                        chars = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
                        Chars = chars;

                        break;
                    }
                case "Ru":
                    {
                        char[] chars = new char[33];
                        chars = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
                        Chars = chars;
                        break;
                    }
                case "en":
                    {
                        char[] chars = new char[26];
                        chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                        Chars = chars;
                        break;
                    }
                case "En":
                    {
                        char[] chars = new char[26];
                        chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                        Chars = chars;
                        break;
                    }
                case "num":
                    {
                        char[] chars = new char[10];
                        chars = "0123456789".ToCharArray();
                        Chars = chars;
                        break;
                    }
                case "sp":
                    {
                        char[] chars = new char[50];
                        chars = ".,;:-=+_!&?/".ToCharArray(); //тут добавить все символы, которые могут быть в тексте, но изменяться не должны.
                        Chars = chars;
                        break;
                    }
            }

        }
    }
}
