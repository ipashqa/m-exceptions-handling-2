using System;

namespace Exceptions_Handling_2_HW
{
    public static class IntParser
    {
        public static int Parse(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException("str");
            }

            if (str.Equals(string.Empty))
            {
                throw new ArgumentException("Input string is empty", "str");
            }

            int result = 0;
            int signCoefficient = 1;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]) == false)
                {
                    if (i == 0 && str[i].Equals('-') && str.Length > 1)
                    {
                        signCoefficient = -1;

                        continue;
                    }
                    else
                    {
                        throw new FormatException("Incorrect format of input string");
                    }
                }

                checked
                {
                    result = result * 10 + (signCoefficient * (int)char.GetNumericValue(str[i]));
                }
            }

            return result;
        }
    }
}
