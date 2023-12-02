using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BrovinaYV.Sprint6.Task1.V14.Lib
{
    public class DataService : ISprint6Task1V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[stopValue - startValue + 1];

            for (int x = startValue; x <= stopValue; x++ )
            {
                double proverka = Math.Cos(x) + x;
                if (Math.Abs(proverka) > Double.Epsilon) {
                    int count = x - startValue;
                    valueArray[count] = Math.Round(((2.0 * x + 6.0) / (proverka) - 3.0), 2);
                }
                else {
                    int count = x - startValue;
                    valueArray[count] = 0; }
            }
            return valueArray;
        }
    }
}
