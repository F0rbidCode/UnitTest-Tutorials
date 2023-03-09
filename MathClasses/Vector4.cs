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

        //create a fucntion to multiply a scaler by a  Vector4
        public static Vector4 operator *(float lhs, Vector4 rhs)
        {
            return new Vector4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        }

        //create a function to multiply a Vector4 by a Matrix4
        public static Vector4 operator *(Matrix4 M, Vector4 V)
        {
            return new Vector4(V.x * M.m00 + V.y * M.m01 + V.z * M.m02 + V.w * M.m03,
                               V.x * M.m10 + V.y * M.m11 + V.z * M.m12 + V.w * M.m13,
                               V.x * M.m20 + V.y * M.m21 + V.z * M.m22 + V.w * M.m23,
                               V.x * M.m30 + V.y * M.m31 + V.z * M.m32 + V.w * M.m33);
        }

        //create a function to divide a Vector4 by a scaler
        public static Vector4 operator /(Vector4 lhs, float rhs)
        {
            return new Vector4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        }

        //create a function to calculate magnitude of a Vector4
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z + w * w);
        }

        //create a function to calculate the squared magnitude of a Vector4
        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z + w *w);
        }

        //create a function to normalise the Vector4
        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m;
            this.y /= m;
            this.z /= m;
            this.w /= m;
        }

        //create a function that returns a normalised Vector4
        public Vector4 GetNormalised()
        {
            return (this / Magnitude());
        }

        //create a function to return the dot ptoduct of the Vector4
        public float Dot(Vector4 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z + w * rhs.w;
        }

        //create a function to return a Cross porduct of a Vector4
        public Vector4 Cross(Vector4 rhs)
        {
            return new Vector4(y * rhs.z - z * rhs.y,
                               z * rhs.x - x * rhs.z,
                               x * rhs.y - y * rhs.x,
                               0);
        }
    }
}
