using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BrovinaYV.Sprint6.Task6.V23.Lib
{
    public class DataService : ISprint6Task6V23
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    
                    string[] words = line.Split(' ');
                    
                    foreach (string word in words)
                    {
                        if (word.Contains('s')) 
                        {
                            resStr += word + " ";
                        }
                        
                    }
                }
            }
            return resStr;
            
        }
    }
}
