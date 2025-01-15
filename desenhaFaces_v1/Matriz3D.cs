using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desenhaFaces_v1
{
    public class Matriz3D
    {

        private float[,] m = new float[4, 4];

        public Matriz3D()
        {
            Identidade();
        }

        public Matriz3D(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
        {
            m[0, 0] = m00;
            m[0, 1] = m01;
            m[0, 2] = m02;
            m[0, 3] = m03;
            m[1, 0] = m10;
            m[1, 1] = m11;
            m[1, 2] = m12;
            m[1, 3] = m13;
            m[2, 0] = m20;
            m[2, 1] = m21;
            m[2, 2] = m22;
            m[2, 3] = m23;
            m[3, 0] = m30;
            m[3, 1] = m31;
            m[3, 2] = m32;
            m[3, 3] = m33;
        }

        public Matriz3D(float[,] m)
        {
            this.m = m;
        }

        public void Identidade()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        m[i, j] = 1f;
                    }
                    else
                    {
                        m[i, j] = 0f;
                    }
                }
            }
        }

        public static Matriz3D operator *(Matriz3D m1, Matriz3D m2)
        {
            Matriz3D matriz3D = new Matriz3D();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    float num = 0f;
                    for (int k = 0; k < 4; k++)
                    {
                        num += m1.m[i, k] * m2.m[k, j];
                    }

                    matriz3D.m[i, j] = num;
                }
            }

            return matriz3D;
        }

        public float[] multiplicaVector(float[] vector)
        {
            float[] array = new float[4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i] += m[i, j] * vector[j];
                }
            }

            return array;
        }

        public static Matriz3D escala(float sx, float sy, float sz)
        {
            Matriz3D matriz3D = new Matriz3D();
            matriz3D.m[0, 0] = sx;
            matriz3D.m[1, 1] = sy;
            matriz3D.m[2, 2] = sz;
            return matriz3D;
        }

        public static Matriz3D translacao(float tx, float ty, float tz)
        {
            Matriz3D matriz3D = new Matriz3D();
            matriz3D.m[0, 3] = tx;
            matriz3D.m[1, 3] = ty;
            matriz3D.m[2, 3] = tz;
            return matriz3D;
        }

        public static Matriz3D rotacaoX(float theta)
        {
            Matriz3D matriz3D = new Matriz3D();
            theta = theta * (float)Math.PI / 180f;
            float num = (float)Math.Sin(theta);
            float num2 = (float)Math.Cos(theta);
            matriz3D.m[1, 1] = num2;
            matriz3D.m[1, 2] = 0f - num;
            matriz3D.m[2, 1] = num;
            matriz3D.m[2, 2] = num2;
            return matriz3D;
        }

        public static Matriz3D rotacaoY(float theta)
        {
            Matriz3D matriz3D = new Matriz3D();
            theta = theta * (float)Math.PI / 180f;
            float num = (float)Math.Sin(theta);
            float num2 = (float)Math.Cos(theta);
            matriz3D.m[0, 0] = num2;
            matriz3D.m[0, 2] = num;
            matriz3D.m[2, 0] = 0f - num;
            matriz3D.m[2, 2] = num2;
            return matriz3D;
        }

        public static Matriz3D rotacaoZ(float theta)
        {
            Matriz3D matriz3D = new Matriz3D();
            theta = theta * (float)Math.PI / 180f;
            float num = (float)Math.Sin(theta);
            float num2 = (float)Math.Cos(theta);
            matriz3D.m[0, 0] = num2;
            matriz3D.m[0, 1] = 0f - num;
            matriz3D.m[1, 0] = num;
            matriz3D.m[1, 1] = num2;
            return matriz3D;
        }

        public static Matriz3D projParalela()
        {
            Matriz3D matriz3D = new Matriz3D();
            matriz3D.m[2, 2] = 0f;
            return matriz3D;
        }

        public static Matriz3D projPerspectiva(float d)
        {
            //nova matriz perpetiva
            Matriz3D matriz3D = new Matriz3D();
            matriz3D.m[0, 0] = 1f;
            matriz3D.m[1, 1] = 1f;
            matriz3D.m[2, 2] = 1f;
            matriz3D.m[3, 2] = -1f / d;
            matriz3D.m[3, 3] = 1f;
            return matriz3D;
        }

    }
}
