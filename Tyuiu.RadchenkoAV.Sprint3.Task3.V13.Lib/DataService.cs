﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RadchenkoAV.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {

            string a = "";
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    a += c;
                }
            }

            return Int32.Parse(a);
        }
    }
}
