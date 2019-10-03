using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace interfaceIcomparable.Entities
{
    class Funcionario : IComparable
    {
        public string Name  { get; set; }
        public double Salary { get; set; }

        public Funcionario(string csvEmploye)
        {
            string[] vect = csvEmploye.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1],CultureInfo.InvariantCulture);

        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Funcionario))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");

            }

            Funcionario other = obj as Funcionario;

            return Name.CompareTo(other.Name);
        }
    }
}
