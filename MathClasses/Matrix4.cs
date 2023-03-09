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

        //create a copy constructer taking in annother Matrix4
        public Matrix4(Matrix4 m)
        {
            m00 = m.m00; m01 = m.m01; m02 = m.m02; m03 = m.m03;
            m10 = m.m10; m11 = m.m11; m12 = m.m12; m13 = m.m13;
            m20 = m.m20; m21 = m.m21; m22 = m.m22; m23 = m.m23;
            m30 = m.m30; m31 = m.m31; m32 = m.m32; m33 = m.m33;
        }

        //create a constructor to create a uniform scaling matrix
        public Matrix4(float uniformScale)
        {
            m00 = m11 = m22 = m33 = uniformScale;
            m01 = m02 = m03 = m10 = m12 = m13 = m20 = m21 = m23 = m30 = m31 = m32 = 0;
        }

        //create a function to create a scaled Matrix4 based on 3 passed in floats
        public void SetScaled(float x, float y, float z)
        {
            m00 = x; m01 = 0; m02 = 0; m03 = 0;
            m10 = 0; m11 = y; m12 = 0; m13 = 0;
            m20 = 0; m21 = 0; m22 = z; m23 = 0;
            m30 = 0; m31 = 0; m32 = 0; m33 = 1;
        }

        //create a function to create a rotation matrix3 to rotate around the X axis
        public void SetRotateX(double radians)
        {
            m00 = 1; m01 = 0; m02 = 0; m03 = 0;
            m10 = 0; m11 = (float)Math.Cos(radians); m12 = (float)Math.Sin(radians); m13 = 0;
            m20 = 0; m21 = (float)-Math.Sin(radians); m22 = (float)Math.Cos(radians); m23 = 0;
            m30 = 0; m31 = 0; m32= 0; m33 = 1;
        }

        //create a function to create a rotation matrix3 to rotate around the Y axis
        public void SetRotateY(double radians)
        {
            m00 = (float)Math.Cos(radians); m01 = 0; m02 = (float)-Math.Sin(radians); m03 = 0;
            m10 = 0; m11 = 1; m12 = 0; m13 = 0;
            m20 = (float)Math.Sin(radians); m21 = 0; m22 = (float)Math.Cos(radians); m23= 0;
            m30 = 0; m31 = 0; m32 = 0; m33 = 1;
        }


        //create a function to create a rotation matrix3 to rotate around the Z axis
        public void SetRotateZ(double radians)
        {
            m00 = (float)Math.Cos(radians); m01 = (float)Math.Sin(radians); m02 = 0; m03 = 0;
            m10 = (float)-Math.Sin(radians); m11 = (float)Math.Cos(radians); m12 = 0; m13 = 0;
            m20 = 0; m21 = 0; m22 = 1; m23 = 0;
            m30 = 0; m31 = 0; m32 = 0; m33 = 1;
        }

        //create a function to set stranslation information in Matrix4
        public void SetTranslation(float x, float y, float z)
        {
            m30 = x; m31 = y; m32 = z; m33 = 1;
        }

        //create a function to translate a Matrix4
        void Translate(float x, float y, float z)
        {
            m30 += x; m31 += y; m32 += z;
        }

        //create a function to multiply a Matrix4 by another Matrix4
        public static Matrix4 operator *(Matrix4 M1, Matrix4 M2)
        {
            return new Matrix4(
                M1.m00 * M2.m00 + M1.m01 * M2.m10 + M1.m02 * M2.m20 + M1.m03 * M2.m30, M1.m00 * M2.m01 + M1.m01 * M2.m11 + M1.m02 * M2.m21 + M1.m03 * M2.m31, M1.m00 * M2.m02 + M1.m01 * M2.m12 + M1.m02 * M2.m22 + M1.m03 * M2.m32, M1.m00 * M2.m03 + M1.m01 * M2.m13 + M1.m02 * M2.m23 + M1.m03 * M2.m33,
                M1.m10 * M2.m00 + M1.m11 * M2.m10 + M1.m12 * M2.m20 + M1.m13 * M2.m30, M1.m10 * M2.m01 + M1.m11 * M2.m11 + M1.m12 * M2.m21 + M1.m13 * M2.m31, M1.m10 * M2.m02 + M1.m11 * M2.m12 + M1.m12 * M2.m22 + M1.m13 * M2.m32, M1.m10 * M2.m03 + M1.m11 * M2.m13 + M1.m12 * M2.m23 + M1.m13 * M2.m33,
                M1.m20 * M2.m00 + M1.m21 * M2.m10 + M1.m22 * M2.m20 + M1.m23 * M2.m30, M1.m20 * M2.m01 + M1.m21 * M2.m11 + M1.m22 * M2.m21 + M1.m23 * M2.m31, M1.m20 * M2.m02 + M1.m21 * M2.m12 + M1.m22 * M2.m22 + M1.m23 + M2.m32, M1.m20 * M2.m03 + M1.m21 * M2.m13 + M1.m22 * M2.m23 + M1.m23 * M2.m33,
                M1.m30 * M2.m00 + M1.m31 * M2.m10 + M1.m32 * M2.m20 + M1.m33 * M2.m30, M1.m30 * M2.m01 + M1.m31 * M2.m11 + M1.m32 * M2.m21 + M1.m33 * M2.m31, M1.m30 * M2.m02 + M1.m31 * M2.m12 + M1.m32 * M2.m22 + M1.m33 + M2.m32, M1.m30 * M2.m03 + M1.m31 * M2.m13 + M1.m32 * M2.m23 + M1.m33 * M2.m33);
        }
    }
}
