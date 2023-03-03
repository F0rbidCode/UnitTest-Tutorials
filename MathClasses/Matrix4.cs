using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MathClasses
{
    public struct Matrix4
    {
        public float m00, m01, m02, m03;
        public float m10, m11, m12, m13;
        public float m20, m21, m22, m23;
        public float m30, m31, m32, m33;

        //create a constructor taking individual elements and asigning them
        public Matrix4(float _m00, float _m01, float _m02, float _m03, float _m10, float _m11, float _m12, float _m13, float _m20, float _m21, float _m22, float _m23, float _m30, float _m31, float _m32, float _m33)
        {
            m00 = _m00;
            m01 = _m01;
            m02 = _m02;
            m03 = _m03;
            m10 = _m10;
            m11 = _m11;
            m12 = _m12;
            m13 = _m13;
            m20 = _m20;
            m21 = _m21;
            m22 = _m22;
            m23 = _m23;
            m30 = _m30;
            m31 = _m31;
            m32 = _m32;
            m33 = _m33;
        }
        //create a constructor taking in 4 Vectors
        public Matrix4(Vector4 X, Vector4 Y, Vector4 Z, Vector4 W)
        {
            m00 = X.x; m01 = X.y; m02 = X.z; m03 = X.w;
            m10 = Y.x; m11 = Y.y; m12 = Y.z; m13 = Y.w;
            m20 = Z.x; m21 = Z.y; m22 = Z.z; m23 = Z.w;
            m30 = W.x; m31 = W.y; m32 = W.z; m33 = W.w;
        }

        //create a constructor to create a uniform scaling matrix
        public Matrix4(float uniformScale)
        {
            m00 = m11 = m22 = m33 = uniformScale;
            m01 = m02 = m03 = m10 = m12 = m13 = m20 = m21 = m23 = m30 = m31 = m32 = 0;
        }
    }
}
