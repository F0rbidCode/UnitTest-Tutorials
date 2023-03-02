using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    //declair Vector3 as a struct
    public struct Vector3
    {
        public float x;
        public float y;
        public float z;

        //create a constructor that takes x y and z positions and sets them to the corrasponding positions in the struct
        public Vector3(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        //create a function to add 2 vector3s together
        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }

        //create a function to subtract a vector 3 from annother
        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }

        //create a fucntion to multiply a vector3 by a scaler
        public static Vector3 operator *(Vector3 lhs, float rhs)
        {
            return new Vector3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        }

        //create a fucntion to multiply a vector3 by a scaler
        public static Vector3 operator *(float lhs, Vector3 rhs)
        {
            return new Vector3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        }

        //create a function to divide a vector3 by a scaler
        public static Vector3 operator /(Vector3 lhs, float rhs)
        {
            return new Vector3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        }

        //create a function to calculate magnitude of a Vector3
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        //create a function to calculate the squared magnitude of a Vector3
        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z);
        }
    }

}
