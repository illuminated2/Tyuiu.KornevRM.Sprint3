﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KornevRM.Sprint3.Task0.V6.Lib
{
    public class DataService : ISprint3Task0V6
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double proiz = 1;
            for (double i = startValue; i <= stopValue; i++)
            {
                proiz *= (1 / (Math.Pow(Math.Cos(5) + 1, 2)));
            }
            return Math.Round(proiz, 3);
        }
    }
}
