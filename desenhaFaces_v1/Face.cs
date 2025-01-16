using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desenhaFaces_v1
{

    // ordenação do z aqui
    internal class Face
    {
        private ArrayList vertices3D;

        public Face()
        {
            InicializaFace();

        }
        private void InicializaFace()
        {
            this.vertices3D = new ArrayList();


        }
        public Face(ArrayList vertices3D)
        {
            InicializaFace();
            this.vertices3D = vertices3D;
        }
        public ArrayList GetVerticesFace()
        {
            return this.vertices3D;
        }

        public void SaveVertice(Vector3D v)
        {
            Console.WriteLine(v.ToString());
            vertices3D.Add(v);
        }

        public PointF[] GetVertices2D(float largura, float altura)
        {
            PointF[] pontos2D = new PointF[vertices3D.Count];
            for (int i = 0; i < vertices3D.Count; i++)
            {
                Vector3D v = (Vector3D)vertices3D[i];
                pontos2D[i] = v.ConvertePontoJanelaToViewport(largura, altura);// converte o ponto da janela para o viewport
            }

            return pontos2D;
        }

        public float getMediaZ()
        {
            float somaZs = 0;

            foreach (Vector3D vertice in vertices3D)
            {
                somaZs += vertice.z;
            }

            float media = somaZs / vertices3D.Count;

            return media;
        }

        public float getZNormalizado()
        {
            Vector3D vetor1 = (Vector3D)vertices3D[1] - (Vector3D)vertices3D[0];
            Vector3D vetor2 = (Vector3D)vertices3D[2] - (Vector3D)vertices3D[1];

            Vector3D vetor3 = vetor1 ^ vetor2;
            vetor3.Normalize();
            return vetor3.z;
        }




    }
}
