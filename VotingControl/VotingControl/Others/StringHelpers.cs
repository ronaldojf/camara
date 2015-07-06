using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VotingControl
{
    static class StringHelpers
    {
        public static string RemoverAcentos(this string text)
        {
            text = Regex.Replace(text, "(á|à|ã|â|ä)", "a");
            text = Regex.Replace(text, "(é|è|ê|ë)", "e");
            text = Regex.Replace(text, "(í|ì|î|ï)", "i");
            text = Regex.Replace(text, "(ó|ò|õ|ô|ö)", "o");
            text = Regex.Replace(text, "(ú|ù|û|ü)", "u");
            text = Regex.Replace(text, "(Á|À|Ã|Â|Ä)", "A");
            text = Regex.Replace(text, "(É|È|Ê|Ë)", "E");
            text = Regex.Replace(text, "(Í|Ì|Î|Ï)", "I");
            text = Regex.Replace(text, "(Ó|Ò|Õ|Ô|Ö)", "O");
            text = Regex.Replace(text, "(Ú|Ù|Û|Ü)", "U");
            text = Regex.Replace(text, "ñ", "n");
            text = Regex.Replace(text, "Ñ", "N");
            text = Regex.Replace(text, "ç", "c");
            text = Regex.Replace(text, "Ç", "C");
            return text;
        }
    }
}
