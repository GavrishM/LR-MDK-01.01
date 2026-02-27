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
            if (language == "ru")
            {
                char[] chars = new char[33];
                chars = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
                Chars = chars;
            }
            if (language == "Ru") 
            {
                char[] chars = new char[33];
                chars = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
                Chars = chars;
            }
            if (language == "en")
            {
                char[] chars = new char[26];
                chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                Chars = chars;
            }
            if (language == "En")
            {
                char[] chars = new char[26];
                chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                Chars = chars;
            }
            if (language == "num")
            {
                char[] chars = new char[10];
                chars = "0123456789".ToCharArray();
                Chars = chars;
            }
            if (language == "sp")
            {
                char[] chars = new char[50];
                chars = ".,;:-=+_!&?/".ToCharArray();
                Chars = chars;
            }
        }
    }
}
