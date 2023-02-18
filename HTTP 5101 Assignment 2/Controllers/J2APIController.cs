using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_2.Controllers
{
    public class J2APIController : ApiController
    {
        /// <summary>
        /// This method calculate the the number of ways that two dice can roll the value of 10
        /// </summary>
        /// <param name="m">number of sides of the first die</param>
        /// <param name="n">number of sides of the second die</param>
        /// <returns>
        /// The number of ways that can roll the value of 10
        /// M:6 N:8 -> 5
        /// M:12 N:4 -> 4
        /// M:3 N:3 -> 0
        /// M:5 N:5 -> 1
        /// </returns>
        /// <example>
        /// GET: api/J2API/GetWaysToRollTen/6/8 -> 5
        /// GET: api/J2API/GetWaysToRollTen/12/4 -> 4
        /// GET: api/J2API/GetWaysToRollTen/3/3 -> 0
        /// GET: api/J2API/GetWaysToRollTen/5/5 -> 1
        /// </example>
        [HttpGet]
        [Route("api/J2API/GetWaysToRollTen/{m}/{n}")]
        public int GetWaysToRollTen(int? m, int? n)
        {
            int numWaysToRollTen = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        numWaysToRollTen++;
                    }
                }
            }
            return numWaysToRollTen;
        }
    }
}
