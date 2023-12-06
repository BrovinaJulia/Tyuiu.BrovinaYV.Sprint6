using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BrovinaYV.Sprint6.Task4.V16.Lib
{
    public class DataService : ISprint6Task4V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {

            double[] valueArray = new double[stopValue - startValue + 1];

            for (int x = startValue; x <= stopValue; x++)
            {
                double proverka =x-0.4;
                if (Math.Abs(proverka) > Double.Epsilon)
                {
                    int count = x - startValue;
                    valueArray[count] = Math.Round(((Math.Cos(x)/proverka)+Math.Sin(x)*8*x+2), 2);
                }
                else
                {
                    int count = x - startValue;
                    valueArray[count] = 0+ Math.Sin(x) * 8 * x + 2;
                }
            }
            return valueArray;
        }
    }
}
