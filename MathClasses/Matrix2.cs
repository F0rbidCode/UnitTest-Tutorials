using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public struct Matrix2
    {
        //initialise a struct for a 2x2 matrix of floats
        public float m00, m01;
        public float m10, m11;

        //create a constructor that takes individual floats to fill the Matrix2
        public Matrix2(float _m00, float _m01, float _m10, float _m11)
        {
            m00 = _m00;
            m01 = _m01;
            m10 = _m10;
            m11 = _m11;
        }

        //create a copy constructor
        public Matrix2(Matrix2 M)
        {
            m00 = M.m00; m01 = M.m01;
            m10 = M.m10; m11 = M.m11;
        }

        //create a function to construct a Matrix2 Identity Matrix
        public Matrix2 IdentityMatrix2()
        {
            Matrix2 IdentityM2 = new Matrix2(1, 0, 0, 1);
            return IdentityM2;
        }

        //create a function to multiply a Matrix2 by another Matrix2
        public static Matrix2 operator *(Matrix2 M1, Matrix2 M2)
        {
            return new Matrix2(
                M1.m00 * M2.m00 + M1.m01 * M2.m10, M1.m00 * M2.m01 + M1.m01,
                M1.m10 * M2.m00 + M1.m11 * M2.m10, M1.m10 * M2.m01 + M1.m11);
        }
    }
}
