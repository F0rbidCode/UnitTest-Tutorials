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

        //create a constructor to create a uniform scaling matrix
        public Matrix3(float uniformScale)
        {
            m00 = m11 = m22 = uniformScale;
            m01 = m02 = m10 = m12 = m20 = m21 = 0;
        }
    }
        
}