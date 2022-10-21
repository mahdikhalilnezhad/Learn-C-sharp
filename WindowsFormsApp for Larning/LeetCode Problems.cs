using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_for_Larning
{
    internal class LeetCode_Problems
    {
    }

    public class Solution
    {

        public string S { get; set; }  
        enum RomanNumber
        {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000
        }

        public int RomanToInt(string s)
        {
            int sum = 0 ;

            string[] stringA = new string[] { s };


            for (int i = 0; i <= stringA.Length; i++)
            {
               
                if      (stringA[i].ToString() == "I") { sum += int.Parse(RomanNumber.I.ToString()); }
                else if (stringA[i].ToString() == "V") { sum += int.Parse(RomanNumber.V.ToString()); }
                else if (stringA[i].ToString() == "X") { sum += int.Parse(RomanNumber.X.ToString()); }
                else if (stringA[i].ToString() == "L") { sum += int.Parse(RomanNumber.L.ToString()); }
                else if (stringA[i].ToString() == "C") { sum += int.Parse(RomanNumber.C.ToString()); }
                else if (stringA[i].ToString() == "D") { sum += int.Parse(RomanNumber.D.ToString()); }
                else if (stringA[i].ToString() == "M") { sum += int.Parse(RomanNumber.M.ToString()); }
                else { break; }
                return sum;
            }
           return sum;


        }
    }


}
