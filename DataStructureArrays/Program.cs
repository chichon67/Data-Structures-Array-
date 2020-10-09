using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays array = new Arrays(10);
            array.Insert(0);
            array.Insert(5);
            array.Insert(1);
            array.Insert(3);
            array.Insert(9);

            array.Sort();

            array.Print();
            

           

        }

       

    }

   

}

