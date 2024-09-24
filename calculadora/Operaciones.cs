using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Operaciones
    {
        public bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToInt32(num);
                return true;
            }catch (Exception)
            {
                return false;
            }




        }

        public int suma(int a, int b)
        {
            return a + b;
        }
        public int resta(int a, int b)
        {
            return a - b;
        }
        public int multiplicacion(int a, int b)
        {
            return a * b;
        }
        public int division(int a, int b)
        {
            return a / b;
        }
    }
}
