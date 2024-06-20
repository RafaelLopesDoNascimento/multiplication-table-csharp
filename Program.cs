using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTres
{
    internal class Program
    {
        static void Main(string[] args)
        {

          

            List<string> MultiplicationTable(int numberParam)
            {
                List<string> listResults = new List<string>();
                int times = 10;
                for (int i = 1; i <= times; i++)
                {
                    listResults.Add(i + " x " + numberParam + " = " + i * numberParam);
                }

                return listResults;
            }
            try
            {
                int number = int.Parse(Console.ReadLine());
                foreach (var item in MultiplicationTable(number))
            {
                Console.WriteLine(item);
            }
            } catch (FormatException)
            {
                Console.WriteLine("Please, use only numbers in this application");
            }
            
        }
    }
}
