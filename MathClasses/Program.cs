using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    class Program
    {
        static void Main(string[] args)
        {           

            Vector3 V1 = new Vector3(0, 4, 1);
            Vector3 V2 = new Vector3(1, 2, 1);
            Vector3 V3 = new Vector3();
            float F = 1.1f;

            V3 = (V1 + V2);
            Console.Write(V3.x + " ");
            Console.Write(V3.y + " ");
            Console.WriteLine(V3.z);

            V3 = (V1 - V2);
            Console.Write(V3.x + " ");
            Console.Write(V3.y + " ");
            Console.WriteLine(V3.z);
            V3 = (V1 * F);
            Console.Write(V3.x + " ");
            Console.Write(V3.y + " ");
            Console.WriteLine(V3.z);
            V3 = (F * V1);
            Console.Write(V3.x + " ");
            Console.Write(V3.y + " ");
            Console.WriteLine(V3.z);
            V3 = (V1 / F);
            Console.Write(V3.x + " ");
            Console.Write(V3.y + " ");
            Console.WriteLine(V3.z);


            Console.ReadKey();

        }
    }
}
