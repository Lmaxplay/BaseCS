using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCS.Library
{
    public class TextUtils
    {
        /// <summary>
        /// Reverses text
        /// </summary>
        /// <example>
        /// <c>
        /// Console.WriteLine(TextUtils.Reverse("example")) //Should log elpmaxe
        /// </c>
        /// </example>
        /// <param name="text">Text to reverse</param>
        /// <returns>A flipped version of <paramref name="text"/></returns>
        public static string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Reverses text
        /// </summary>
        /// <example>
        /// <c>
        /// Console.WriteLine(TextUtils.Reverse("example")) //Should log elpmaxe
        /// </c>
        /// </example>
        /// <param name="text">Text to reverse</param>
        /// <returns>A flipped version of <paramref name="text"/></returns>
        public static string Reverse(char[] text)
        {
            char[] charArray = text;
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    public class NumberUtils
    {
        /// <summary>
        /// Converts <paramref name="number"/> to a hexadecimal uppercase string
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>Hexadecimal string of the number</returns>
        public static string ToHex(float number)
        {
            return number.ToString("X");
        }

        /// <summary>
        /// Converts <paramref name="number"/> to a hexadecimal uppercase string
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>Hexadecimal string of the number</returns>
        public static string ToHex(double number)
        {
            return number.ToString("X");
        }

        /// <summary>
        /// Converts <paramref name="number"/> to a hexadecimal uppercase string
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>Hexadecimal string of the number</returns>
        public static string ToHex(byte number)
        {
            return number.ToString("X");
        }

        /// <summary>
        /// Converts <paramref name="number"/> to a hexadecimal uppercase string
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>Hexadecimal string of the number</returns>
        public static string ToHex(sbyte number)
        {
            return number.ToString("X");
        }

        /// <summary>
        /// Converts <paramref name="number"/> to a hexadecimal uppercase string
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>Hexadecimal string of the number</returns>
        public static string ToHex(short number)
        {
            return number.ToString("X");
        }

        /// <summary>
        /// Converts <paramref name="number"/> to a hexadecimal uppercase string
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>Hexadecimal string of the number</returns>
        public static string ToHex(ushort number)
        {
            return number.ToString("X");
        }

        /// <summary>
        /// Converts <paramref name="number"/> to a hexadecimal uppercase string
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>Hexadecimal string of the number</returns>
        public static string ToHex(int number)
        {
            return number.ToString("X");
        }

        /// <summary>
        /// Converts <paramref name="number"/> to a hexadecimal uppercase string
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>Hexadecimal string of the number</returns>
        public static string ToHex(uint number)
        {
            return number.ToString("X");
        }

        /// <summary>
        /// Converts <paramref name="number"/> to a hexadecimal uppercase string
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>Hexadecimal string of the number</returns>
        public static string ToHex(long number)
        {
            return number.ToString("X");
        }

        /// <summary>
        /// Converts <paramref name="number"/> to a hexadecimal uppercase string
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>Hexadecimal string of the number</returns>
        public static string ToHex(ulong number)
        {
            return number.ToString("X");
        }
    }
}
