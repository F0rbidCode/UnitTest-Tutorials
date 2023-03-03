using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    //declair Vector4 as a struct
    public struct Vector4
    {
        public float x;
        public float y;
        public float z;
        public float w;

        //create a constructor that takes x y z and w positions and sets them to the corrasponding positions in the struct
        public Vector4(float _x, float _y, float _z, float _w)
        {
            x = _x;
            y = _y;
            z = _z;
            w = _w;
        }

        //create a function to add 2 Vector4s together
        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        }

        //create a function to subtract a vector4 from annother
        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        }

        //create a fucntion to multiply a Vector4 by a scaler
        public static Vector4 operator *(Vector4 lhs, float rhs)
        {
            return new Vector4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        }

        //create a fucntion to multiply a Vector4 by a scaler
        public static Vector4 operator *(float lhs, Vector4 rhs)
        {
            return new Vector4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        }

        //create a function to divide a Vector4 by a scaler
        public static Vector4 operator /(Vector4 lhs, float rhs)
        {
            return new Vector4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        }
        
    }
}
