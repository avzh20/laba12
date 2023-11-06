using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
            using (StreamReader reader = new StreamReader("Inlet.in"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] lineNumbers = line.Split(' ');
                    foreach (string str in lineNumbers)
                    {
                        int number;
                        if (int.TryParse(str, out number))
                            numbers.Add(number);
                    }
                }
            }

            if (numbers.Any(x => x < 0))
            {
            int maxNumber = numbers.Where(x => x > 0).Max();
            int maxNegativeNumber = numbers.Where(x => x < 0).Max();
            int index = numbers.IndexOf(maxNumber) + 1;

                using (StreamWriter writer = new StreamWriter("Outlet.out"))
                {
                    writer.Write(maxNegativeNumber * index);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter("Outlet.out"))
                {
                    writer.Write(-1);
                }
            }
        Console.WriteLine("Результат был записан в Outlet.out");
    }
}
