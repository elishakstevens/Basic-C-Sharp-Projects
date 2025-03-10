using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MathOpsProgram
{
    public class Operations
    {
        //Creating methods for Operations class
        public int Add(int num)
        {
            int number = num + 15;
            return number;
        }

        public int Multiply(int num)
        {
            int number = num * 15;
            return number;
        }

        public int Subtract(int num)
        {
            int number = num - 15;
            return number;
        }
    }
}
