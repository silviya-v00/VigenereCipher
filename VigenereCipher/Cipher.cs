using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereCipher
{
    public class Cipher
	{
        private static string Algorithm(string alphabet, string input, string key, bool usePunctuation, bool encipher)
        {
            int j = 0;
            int alphabetLen = alphabet.Length;
            bool isUpper;
            char keyLetter;
            string newKey = "";
            foreach (char ch in key)
            {
                if (char.IsLetter(ch))
                    newKey += ch;
                else
                    newKey += "";
            }

            StringBuilder output = new StringBuilder(input.Length);
            
            char firstInputEl = new string(input.SkipWhile(c => !Char.IsLetter(c)).ToArray()).ToLower().FirstOrDefault();
            char firstKeyEl = new string(key.SkipWhile(c => !Char.IsLetter(c)).ToArray()).ToLower().FirstOrDefault();
            
            if (!alphabet.ToLower().Contains(firstInputEl) || !alphabet.ToLower().Contains(firstKeyEl))
                output.Append("Wrong alphabet!");
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    isUpper = char.IsUpper(input[i]);
                    keyLetter = isUpper ? char.ToUpper(newKey[j]) : char.ToLower(newKey[j]);
                    alphabet = isUpper ? alphabet.ToUpper() : alphabet.ToLower();
                    if (char.IsLetter(input[i]))
                    {
                        if (encipher)
                            output.Append(alphabet[(alphabet.IndexOf(input[i]) + alphabet.IndexOf(keyLetter)) % alphabetLen]);
                        else
                            output.Append(alphabet[(alphabet.IndexOf(input[i]) - alphabet.IndexOf(keyLetter) + alphabetLen) % alphabetLen]);
                        j = j + 1 == newKey.Length ? 0 : j + 1;
                    }
                    else
                    {
                        if (usePunctuation)
                            output.Append(input[i]);
                        else
                            output.Append("");
                    }
                }
            }
            return output.ToString();
        }

        public static string Encipher(string alphabet, string input, string key, bool usePunctuation)
        {
            return Algorithm(alphabet, input, key, usePunctuation, true);
        }

        public static string Decipher(string alphabet, string input, string key, bool usePunctuation)
        {
            return Algorithm(alphabet, input, key, usePunctuation, false);
        }
    }
}
