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

            Matrix3 M1 = new Matrix3(1, 4, 7, 2, 5, 8, 3, 6, 9);
            Matrix3 M2 = new Matrix3(9, 6, 3, 8, 5, 2, 7, 4, 1);
            Matrix3 M3 = new Matrix3();

            M3 = M1 * M2;
            Console.WriteLine(M3.m00 + " " + M3.m01 + " " + M3.m02);
            Console.WriteLine(M3.m10 + " " + M3.m11 + " " + M3.m12);
            Console.WriteLine(M3.m20 + " " + M3.m21 + " " + M3.m22);

            Vector3 V4 = new Vector3(2, 4, 6);
            Vector3 V5 = new Vector3();

            V5 = M3 * V4;
            Console.WriteLine(V5.x);
            Console.WriteLine(V5.y);
            Console.WriteLine(V5.z);

            M3 = M3.Transpose(M3);
            Console.WriteLine(M3.m00 + " " + M3.m01 + " " + M3.m02);
            Console.WriteLine(M3.m10 + " " + M3.m11 + " " + M3.m12);
            Console.WriteLine(M3.m20 + " " + M3.m21 + " " + M3.m22);

            Console.ReadKey();

        }
    }
}
