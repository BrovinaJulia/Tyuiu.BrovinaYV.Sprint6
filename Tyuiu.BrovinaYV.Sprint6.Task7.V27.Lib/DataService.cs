using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.BrovinaYV.Sprint6.Task7.V27.Lib
{
    public class DataService : ISprint6Task7V27
    {
        public int[,] GetMatrix(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] values = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] lineRows = lines[i].Split(';');
                for (int j=0; j<columns; j++)
                {
                    values[i, j] = Convert.ToInt32(lineRows[j]);
                }
            }
            for (int i = 0; i < rows; i++)
            {
               
                for (int j = 0; j < columns; j++)
                {
                   if (values[4, j] < 0)
                    {
                        values[4, j] = -1;
                    }
                }
            }
            return values;


        }
    }
}
