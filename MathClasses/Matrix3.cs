using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace MathClasses
{
   //declair Matrix3 as a struct
    public struct Matrix3
    {
        public float m00, m01, m02;
        public float m10, m11, m12;
        public float m20, m21, m22;

        //create a constructor taking individual elements and asigning them
        public Matrix3(float _m00, float _m01, float _m02, float _m10, float _m11, float _m12, float _m20, float _m21, float _m22)
        {
            m00 = _m00;
            m01 = _m01;
            m02 = _m02;
            m10 = _m10;
            m11 = _m11;
            m12 = _m12;
            m20 = _m20;
            m21 = _m21;
            m22 = _m22;
        }
        //create a constructor taking in 3 Vectors
        public Matrix3(Vector3 X, Vector3 Y, Vector3 Z)
        {
            m00 = X.x; m01 = X.y; m02 = X.z;
            m10 = Y.x; m11 = Y.y; m12 = Y.z;
            m20 = Z.x; m21 = Z.y; m22 = Z.z;
        }

        //create a copying constructor
        public Matrix3(Matrix3 m)
        {
            m00 = m.m00; m01 = m.m01; m02 = m.m02;
            m10 = m.m10; m11 = m.m11; m12 = m.m12;
            m20 = m.m20; m21 = m.m21; m22 = m.m22;
        }

        //create a constructor to create a uniform scaling matrix
        public Matrix3(float uniformScale)
        {
            m00 = m11 = m22 = uniformScale;
            m01 = m02 = m10 = m12 = m20 = m21 = 0;
        }

        //create a function to construct a Matrix2 Identity Matrix
        public Matrix3 IdentityMatrix3()
        {
            Matrix3 IdentityM3 = new Matrix3(1, 0, 0, 0, 1 , 0, 0, 0, 1);
            return IdentityM3;
        }

        //create a function to multiply a Matrix3 by another Matrix3
        public static Matrix3 operator *(Matrix3 M1, Matrix3 M2)
        {
            return new Matrix3(
                M1.m00 * M2.m00 + M1.m01 * M2.m10 + M1.m02 * M2.m20, M1.m00 * M2.m01 + M1.m01 * M2.m11 + M1.m02 * M2.m21, M1.m00 * M2.m02 + M1.m01 * M2.m12 + M1.m02 * M2.m22,
                M1.m10 * M2.m00 + M1.m11 * M2.m10 + M1.m12 * M2.m20, M1.m10 * M2.m01 + M1.m11 * M2.m11 + M1.m12 * M2.m21, M1.m10 * M2.m02 + M1.m11 * M2.m12 + M1.m12 * M2.m22,
                M1.m20 * M2.m00 + M1.m21 * M2.m10 + M1.m22 * M2.m20, M1.m20 * M2.m01 + M1.m21 * M2.m11 + M1.m22 * M2.m21, M1.m20 * M2.m02 + M1.m21 * M2.m12 + M1.m22 * M2.m22);
        }

        //create a function to transpose a Matrix3
        public Matrix3 Transpose(Matrix3 m)
        {
            //flip the Matrix on its diagonal
            Matrix3 newM = new Matrix3();
            newM.m00 = m.m00; newM.m01 = m.m10; newM.m02 = m.m20;
            newM.m10 = m.m01; newM.m11 = m.m11; newM.m12 = m.m21;
            newM.m20 = m.m02; newM.m21 = m.m12; newM.m22 = m.m22;

            return newM;
        }
    }
        
}