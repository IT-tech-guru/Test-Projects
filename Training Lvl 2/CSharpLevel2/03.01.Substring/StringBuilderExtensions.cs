using System;
using System.Collections.Generic;
using System.Text;

namespace _03._01.Substring
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder someText, int startIndex)
        {
            StringBuilder substring = new StringBuilder();

            for (int i = startIndex; i < someText.Length; i++)
            {
                substring.Append(someText[i]);
            }

            return substring;
        }

        public static StringBuilder Substring(this StringBuilder someText, int startIndex, int length)
        {
            StringBuilder substring = new StringBuilder();

            for (int i = startIndex; i < startIndex + length; i++)
            {
                substring.Append(someText[i]);
            }

            return substring;
        }
    }
}
