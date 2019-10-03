using System;
using System.Collections.Generic;
using System.IO;
using interfaceIcomparable.Entities;

namespace interfaceIcomparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\csharp\interfaceIcomparable\nomes.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Funcionario> list = new List<Funcionario>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionario(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Funcionario f in list)
                    {
                        Console.WriteLine(f);
                    }
                }


            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
