using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declarations
            int age;
            string name;
            bool isAlive;
            char middleName;
            decimal backFlips;
            double frontFlips;

            //Variable initializations
            age = 27;
            name = "Jacob";
            isAlive = true;
            middleName = 'A';
            backFlips = 10.5m;
            frontFlips = 8.5;


            

            Console.WriteLine($"{name} {age} is he alive: {isAlive}");

            Console.WriteLine($"{name} has a middle initial of {middleName}. He can do {backFlips} back flips in a row and {frontFlips} front flips in a row.");


        }
    }
}
