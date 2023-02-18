using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace HTTP_5101_Assignment_2.Controllers
{
    public class J3APIController : ApiController
    {
        /// <summary>
        /// This function calculate the total number of letters of the longest palindrome contained in the input
        /// </summary>
        /// <param name="word"></param>
        /// <returns>
        /// Return the total number of letters of the longest palindrome
        /// Word: banana -> 5
        /// Word: abracadabra -> 3
        /// Word: abba -> 4
        /// </returns>
        /// <example>
        /// GET: api/J3API/GetMaxPalidrome/banana -> 5
        /// GET: api/J3API/GetMaxPalidrome/abracadabra -> 3
        /// GET: api/J3API/GetMaxPalidrome/abba -> 4
        /// </example>
        [HttpGet]
        [Route("api/J3API/GetMaxPalidrome/{word}")]
        public int GetMaxPalidrome(string word)
        {
            //default value
            int max = 0;

            for (int i = 0; i < word.Count(); i++)
            {
                for (int j = 1; j <= word.Count() - i; j++)
                {
                    string substr = word.Substring(i, j);
                    if (CheckIsPalindrome(substr))
                    {
                        max = Math.Max(max, substr.Count());
                    }
                }
            }
            return max;
        }
        /// <summary>
        /// This function check if a string is palindrome
        /// </summary>
        /// <param name="word">The string input</param>
        /// <returns>
        /// Return true if the string is palindrome, false if not
        /// Word:banana -> false
        /// Word:anana -> true
        /// </returns>
        /// <example>
        /// GET: api/J3API/CheckIsPalindrome/banana -> false
        /// GET: api/J3API/CheckIsPalindrome/anana -> true
        /// </example>
        [HttpGet]
        [Route("api/J3API/CheckIsPalindrome/{word}")]
        public bool CheckIsPalindrome(string word)
        {
            //return true if {word} equal to reversed {word}
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return word.Equals(new string(charArray));
        }
    }
}
