using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// This method calculate the total calories of the meal
        /// </summary>
        /// <param name="burger">the index burger choice</param>
        /// <param name="drink">the index drink choice</param>
        /// <param name="side">the index side choice</param>
        /// <param name="dessert">the index dessert choice</param>
        /// <returns>
        /// A string that contain the total calories of the meal
        /// Burger:4 Drink:4 Side:4 Dessert:4 -> 0
        /// Burger:1 Drink:2 Side:3 Dessert:4 -> 691
        /// </returns>
        /// <example>
        /// GET: api/J1/Menu/4/4/4/4 -> "Your total calorie count is 0"
        /// GET: api/J1/Menu/1/2/3/4 -> "Your total calorie count is 691"
        /// </example>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            string output = "Your total calorie count is ";
            //default values
            int burgerCalories = 0;
            int drinkCalories = 0;
            int sideCalories = 0 ;
            int dessertCalories = 0;
            int totalCalories;

            if (burger < 1 || burger > 4 || drink < 1 || drink > 4 || side < 1 || side > 4 || dessert < 1 || dessert > 4) {
                output = "Invalid choice";
                return output;
             }
            else
            {
                if (burger == 1) burgerCalories = 461;
                if (burger == 2) burgerCalories = 431;
                if (burger == 3) burgerCalories = 420;

                if (drink == 1) drinkCalories = 130;
                if (drink == 2) drinkCalories = 160;
                if (drink == 3) drinkCalories = 118;

                if (side == 1) sideCalories = 100;
                if (side == 2) sideCalories = 57;
                if (side == 3) sideCalories = 70;

                if (dessert == 1) dessertCalories = 167;
                if (dessert == 2) dessertCalories = 266;
                if (dessert == 3) dessertCalories = 75;
 
                totalCalories = burgerCalories + drinkCalories + sideCalories + dessertCalories;
                return output + totalCalories;
            }
        }
    }
}
