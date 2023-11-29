﻿using System.Text;

namespace RomanNumbers
{
    public class RomanNumbers
    {

        private IDictionary<char, int> romanNumbers = new Dictionary<char, int>() { {'I', 1} , {'V', 5 }, {'X' , 10} , {'L', 50}, {'C', 100}, {'D', 500} , {'M', 1000} };
        public string Convert(int amount)
        {
            if (amount <= 0 || amount >= 4000)
            {
                return "Invalid number";
            }


            return amount.ToString();
        }
    }
}