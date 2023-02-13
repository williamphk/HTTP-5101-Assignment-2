using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="m">number of sides of the first die</param>
        /// <param name="n">number of sides of the second die</param>
        /// <returns>
        /// A string containing the number of ways that can roll the value of 10.
        /// M:6 N:8 -> 5
        /// M:12 N:4 -> 4
        /// M:3 N:3 -> 0
        /// M:5 N:5 -> 1
        /// </returns>
        /// <example>
        /// GET: api/J2/DiceGame/6/8 -> "There are 5 ways to get the sum 10."
        /// GET: api/J2/DiceGame/12/4 -> "There are 4 ways to get the sum 10."
        /// GET: api/J2/DiceGame/3/3 -> "There are 0 ways to get the sum 10."
        /// GET: api/J2/Dicegame/5/5 -> "There is 1 way to get the sum 10."
        /// </example>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int numberOfWays = 0;
            string output = "";

            if (m <= 0 || n <= 0)
            {
                output += "Invalid dice";
            }
            else
            {
                for (int i = 1; i <= m; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (i + j == 10)
                        {
                            numberOfWays++;
                        }
                    }
                }
                if (numberOfWays > 1 || numberOfWays == 0)
                {
                    output += "There are " + numberOfWays + " ways to get the sum 10.";
                }
                else
                {
                    output += "There is " + numberOfWays + " way to get the sum 10.";
                }
            }
            return output;
        }
    }
}
