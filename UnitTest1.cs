using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MumblingTest
{
    public class UnitTest1
    {
        public static string Accum(string s)
        {
            int counter = 0;
            string result = "";
            List<char> x = new List<char>();



            for (int i = 0; i < s.Length; i++)
            {
                foreach (var c in s)
                {
                    x.Add(c);
                }
                int position = i;
                
                counter++;

                result += x[i].ToString().ToUpperInvariant();

                while (position >= 1)
                {
                    result += x[i].ToString().ToLowerInvariant();
                    position--;
                }

                result += "-";

            }

            result = result.Remove(result.Length - 1);

            return result;




        }
        [Theory]
        [InlineData("ZpglnRxqenU", "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu")]
        public void AccumShould(string actual, string expected)
        {
            Assert.Equal(expected, Accum(actual));
        }
    }
}
