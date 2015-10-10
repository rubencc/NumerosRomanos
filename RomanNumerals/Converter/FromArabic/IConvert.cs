using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.Converter.FromArabic
{
    public interface IConvert
    {
        string ToRoman(int number);
    }
}
