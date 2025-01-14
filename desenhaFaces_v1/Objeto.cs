
//Desenho de Faces Poligonais - versão 2.0 - Aplicar translações e rotações aos objetos (o objeto deve ser definido centrado nos eixos coordenados) + leitura do objeto a partir de ficheiro

using System;
using System.Collections; //para usar o ArrayList
using System.Collections.Generic;
using System.Diagnostics; // para usar o Debug
using System.Drawing; //para usar a pen e o brush
using System.IO; //para usar as streams
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using metodosMatriz3D; //implementa a classe Matriz3D

namespace desenhaFaces_v1
{
    /*
    public class comparadorFacesZ : IComparer
    {
        public int Compare(object x, object y)
        {
            Face face1 = x as Face;
            Face face2 = y as Face;

            float mediaFace1Z = face1.getMediaZ();
            float mediaFace2Z = face2.getMediaZ();

            return mediaFace1Z.CompareTo(mediaFace2Z);
        }
    }
    */

    public class Objeto
    {
        private ArrayList vertices; // array para guardar os vértices 3D do objecto
        private ArrayList indicesFaces;// array para guardar os índices dos vértices das faces do objecto
        private ArrayList numvPorFace; // array para guardar o número de vértices por face (podemos ter faces com número diferente de vértices)

        private float larguraDesenho;// largura da janela usada para definir a largura da janela
        private float alturaDesenho; // altura da janela usada para definir a altura da janela de desenho

        private Pen penContorno; // pen usada para o contorno do objecto
        private SolidBrush brushPreenchimento; // brush usado para a cor de fundo do objecto

        private bool wireframe; // define se vai ser usado com preenchimento ou em linha de arame

        private Stream s; // stream para carregar os dados do ficheiro, no caso da estrutura do objeto ser lida a partir de um ficheiro

        public Objeto()
        {
            InicializaObjeto("cubo");
        }

        public Objeto(float largura, float altura, string raio, string alturaC, string faces)
        {
            InicializaObjetoCone( raio,  alturaC,  faces);
        }

        private void InicializaObjeto(string tipoModelo)
        {
            this.vertices = new ArrayList();
            this.indicesFaces = new ArrayList();
            this.numvPorFace = new ArrayList();

            penContorno = new Pen(Color.Black, 1);
            brushPreenchimento = new SolidBrush(Color.SteelBlue);

            this.wireframe = false; // no início é desenhado com preenchimento

            switch (tipoModelo)
            {

                case "cubo":
                    Cubo();
                    break;

                case "prismaPenta":
                    PrismaPentagonal();
                    break;

                case "piramideQuad":
                    PiramideQuadrangular();
                    break;

                case "piramideHexa":
                    TroncoPiramideHexagonal();
                    break;

                case "cone":
                    Cone(50, 100, 6);
                    break;

                    //Quadrado();
            }

        }

        private void InicializaObjetoCone(string raio, string altura, string faces)
        {
            this.vertices = new ArrayList();
            this.indicesFaces = new ArrayList();
            this.numvPorFace = new ArrayList();

            penContorno = new Pen(Color.Black, 1);
            brushPreenchimento = new SolidBrush(Color.SteelBlue);

            this.wireframe = false; // no início é desenhado com preenchimento
            Debug.WriteLine(raio + " ; " + altura + " ; " + faces);
            Cone(float.Parse(raio), float.Parse(altura), int.Parse(faces));

        }

        private void Quadrado()
        {
            //uma face quadrada

            vertices.Add(new Vector3D(-60, -60, 60));
            vertices.Add(new Vector3D(60, -60, 60));
            vertices.Add(new Vector3D(60, 60, 60));
            vertices.Add(new Vector3D(-60, 60, 60));

            indicesFaces.Add(0);
            indicesFaces.Add(1);
            indicesFaces.Add(2);
            indicesFaces.Add(3);

            numvPorFace.Add(4);

           // Debug.WriteLine("num vértices da face " + indicesFaces.Count);
        }

        private void Cubo()
        {

            //vértices

            this.vertices.Add(new Vector3D(-70.0f, -70.0f, 70.0f));//v0
            this.vertices.Add(new Vector3D(70.0f, -70.0f, 70.0f));//v1
            this.vertices.Add(new Vector3D(-70.0f, 70.0f, 70.0f));//v2
            this.vertices.Add(new Vector3D(70.0f, 70.0f, 70.0f));//v3
            this.vertices.Add(new Vector3D(-70.0f, 70.0f, -70.0f));//v4
            this.vertices.Add(new Vector3D(70.0f, 70.0f, -70.0f));//v5
            this.vertices.Add(new Vector3D(-70.0f, -70.0f, -70.0f));//v6
            this.vertices.Add(new Vector3D(70.0f, -70.0f, -70.0f));//v7


            //indices face frente
            this.indicesFaces.Add(0);
            this.indicesFaces.Add(1);
            this.indicesFaces.Add(3);
            this.indicesFaces.Add(2);

            this.numvPorFace.Add(4);

            //indices face direita
            this.indicesFaces.Add(1);
            this.indicesFaces.Add(7);
            this.indicesFaces.Add(5);
            this.indicesFaces.Add(3);

            this.numvPorFace.Add(4);

            //indices face esquerda
            this.indicesFaces.Add(0);
            this.indicesFaces.Add(2);
            this.indicesFaces.Add(4);
            this.indicesFaces.Add(6);

            this.numvPorFace.Add(4);

            //indices face cima
            this.indicesFaces.Add(2);
            this.indicesFaces.Add(3);
            this.indicesFaces.Add(5);
            this.indicesFaces.Add(4);

            this.numvPorFace.Add(4);

            //indices face baixo
            this.indicesFaces.Add(0);
            this.indicesFaces.Add(6);
            this.indicesFaces.Add(7);
            this.indicesFaces.Add(1);

            this.numvPorFace.Add(4);

            //indices face trás
            this.indicesFaces.Add(6);
            this.indicesFaces.Add(4);
            this.indicesFaces.Add(5);
            this.indicesFaces.Add(7);

            this.numvPorFace.Add(4);


        }

        private void PrismaPentagonal()
        {
            // Vértices da base inferior
            vertices.Add(new Vector3D(-50, -50, -50));
            vertices.Add(new Vector3D(50, -50, -50));
            vertices.Add(new Vector3D(70, 0, -50));
            vertices.Add(new Vector3D(0, 50, -50));
            vertices.Add(new Vector3D(-70, 0, -50));

            // Vértices da base superior
            vertices.Add(new Vector3D(-50, -50, 50));
            vertices.Add(new Vector3D(50, -50, 50));
            vertices.Add(new Vector3D(70, 0, 50));
            vertices.Add(new Vector3D(0, 50, 50));
            vertices.Add(new Vector3D(-70, 0, 50));

            // Base inferior
            indicesFaces.Add(0); indicesFaces.Add(1); indicesFaces.Add(2); indicesFaces.Add(3); indicesFaces.Add(4);
            numvPorFace.Add(5);

            // Base superior
            indicesFaces.Add(5); indicesFaces.Add(6); indicesFaces.Add(7); indicesFaces.Add(8); indicesFaces.Add(9);
            numvPorFace.Add(5);

            // Laterais
            for (int i = 0; i < 5; i++)
            {
                indicesFaces.Add(i);
                indicesFaces.Add((i + 1) % 5);
                indicesFaces.Add(((i + 1) % 5) + 5);
                indicesFaces.Add(i + 5);
                numvPorFace.Add(4);
            }
        }

        private void PiramideQuadrangular()
        {
            // Base quadrada
            vertices.Add(new Vector3D(-50, -50, -50));
            vertices.Add(new Vector3D(50, -50, -50));
            vertices.Add(new Vector3D(50, 50, -50));
            vertices.Add(new Vector3D(-50, 50, -50));

            // Vértice superior (ápice)
            vertices.Add(new Vector3D(0, 0, 50));

            // Base
            indicesFaces.Add(0); indicesFaces.Add(1); indicesFaces.Add(2); indicesFaces.Add(3);
            numvPorFace.Add(4);

            // Faces laterais
            for (int i = 0; i < 4; i++)
            {
                indicesFaces.Add(i);
                indicesFaces.Add((i + 1) % 4);
                indicesFaces.Add(4);
                numvPorFace.Add(3);
            }
        }

        private void TroncoPiramideHexagonal()
        {
            // Base inferior (hexágono menor)
            float sizeSmall = 30.0f; // Tamanho do hexágono menor
            for (int i = 0; i < 6; i++)
            {
                float angle = (float)(Math.PI / 3 * i);
                vertices.Add(new Vector3D(sizeSmall * (float)Math.Cos(angle), sizeSmall * (float)Math.Sin(angle), -50));
            }

            // Base superior (hexágono maior)
            float sizeLarge = 50.0f; // Tamanho do hexágono maior
            for (int i = 0; i < 6; i++)
            {
                float angle = (float)(Math.PI / 3 * i);
                vertices.Add(new Vector3D(sizeLarge * (float)Math.Cos(angle), sizeLarge * (float)Math.Sin(angle), 50));
            }

            // Base inferior
            for (int i = 0; i < 6; i++) indicesFaces.Add(i);
            numvPorFace.Add(6);

            // Base superior
            for (int i = 6; i < 12; i++) indicesFaces.Add(i);
            numvPorFace.Add(6);

            // Faces laterais
            for (int i = 0; i < 6; i++)
            {
                int next = (i + 1) % 6;
                indicesFaces.Add(i);
                indicesFaces.Add(next);
                indicesFaces.Add(next + 6);
                indicesFaces.Add(i + 6);
                numvPorFace.Add(4);
            }
        }

        private void Cone(float radius, float height, int numFaces)
        {
            // Base circular
            vertices.Add(new Vector3D(0, 0, 0)); // Centro da base
            for (int i = 0; i < numFaces; i++)
            {
                float angle = (float)(2 * Math.PI / numFaces * i);
                vertices.Add(new Vector3D(radius * (float)Math.Cos(angle), radius * (float)Math.Sin(angle), 0));
            }

            // Vértice superior (ápice)
            vertices.Add(new Vector3D(0, 0, height));

            // Base
            for (int i = 1; i <= numFaces; i++)
            {
                indicesFaces.Add(0);
                indicesFaces.Add(i);
                indicesFaces.Add(i % numFaces + 1);
                numvPorFace.Add(3);
            }

            // Faces laterais
            for (int i = 1; i <= numFaces; i++)
            {
                indicesFaces.Add(i);
                indicesFaces.Add(i % numFaces + 1);
                indicesFaces.Add(numFaces + 1);
                numvPorFace.Add(3);
            }
        }

        //kinda default contrutor
        public Objeto(float largura, float altura)
        {
            SetJanela(largura, altura);
            InicializaObjeto("cubo");
        }

        public Objeto(float largura, float altura, string tipoModelo)
        {
            SetJanela(largura, altura);
            InicializaObjeto(tipoModelo);
        }

        public void SetJanela(float largura, float altura)
        {
            this.larguraDesenho = largura;
            this.alturaDesenho = altura;
        }


        public void SetWireframe()
        {
            this.wireframe = !this.wireframe;
        }

        public void SetCores(Pen penContorno, SolidBrush brushPreenchimento)
        {
            this.penContorno = penContorno;
            this.brushPreenchimento = brushPreenchimento;
        }

        public ArrayList GetVertices3D()
        {
            return this.vertices;
        }

        public ArrayList GetIndicesFaces()
        {
            return this.indicesFaces;
        }

        public ArrayList GetNumvPorFace()
        {
            return this.numvPorFace;
        }

        private ArrayList Transforma(float translacaoX, float translacaoY, float translacaoZ, float rotx, float roty, float rotz)
        {
            ArrayList res = new ArrayList(this.vertices.Count);

            foreach (Vector3D v in this.vertices)
            {
                res.Add(v.Clone());
            }

            metodosMatriz3D.Matriz3D mTrans = Matriz3D.translacao(translacaoX, translacaoY, translacaoZ);
            Matriz3D mRotX = Matriz3D.rotacaoX(rotx);
            Matriz3D mRotY = Matriz3D.rotacaoY(roty);
            Matriz3D mRotZ = Matriz3D.rotacaoZ(rotz);

            Matriz3D mProjParalela = Matriz3D.projParalela();

            float distToPlanoProj = 500.0f; //distância da câmara ao Plano Projeção
            Matriz3D mProjPerspetiva = Matriz3D.projPerspectiva(distToPlanoProj);

            for (int i = 0; i < res.Count; i++)
            {
                Vector3D v = (Vector3D)res[i];

                v.MultiplicaporMatriz_coordHomogeneas(mRotX);
                v.MultiplicaporMatriz_coordHomogeneas(mRotY);
                v.MultiplicaporMatriz_coordHomogeneas(mRotZ);
                v.MultiplicaporMatriz_coordHomogeneas(mTrans);
                //v.MultiplicaporMatriz_coordCartesianas(mProjParalela);
                v.MultiplicaporMatriz_coordCartesianas(mProjPerspetiva);
            }

            return res;
        }

        private ArrayList GeraFaces(ArrayList verticesTransf)
        {
            ArrayList faces = new ArrayList();
            int k = 0;
            Console.WriteLine(numvPorFace);
            for (int i = 0; i < numvPorFace.Count; i++)
            {
                Face f = new Face();

                for (int j = 0; j < (int)numvPorFace[i]; j++)
                {
                    Vector3D v = (Vector3D)verticesTransf[(int)indicesFaces[k++]];
                    f.SaveVertice(v);
                }
                faces.Add(f);
            }

            //faces.Sort(new comparadorFacesZ());

            // bubble sort aproveitado de https://www.geeksforgeeks.org/bubble-sort-algorithm/
            //bubble sort

            int n = faces.Count;
            bool trocou;

            for (int i = 0; i < n - 1; i++)
            {
                trocou = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    Face face1 = (Face)faces[j];
                    Face face2 = (Face)faces[j + 1];

                    if (face1.getMediaZ() > face2.getMediaZ())
                    {
                        // troca as posicoes
                        faces[j] = face2;
                        faces[j + 1] = face1;

                        trocou = true;
                    }
                }

                if (!trocou)
                    break;
            }

            return faces;
        }


        public void Desenha(Graphics g, float translacaoX, float translacaoY, float translacaoZ, float rotacaoX, float rotacaoY, float rotacaoZ)
        {
            ArrayList verticesTransf = Transforma(translacaoX, translacaoY, translacaoZ, rotacaoX, rotacaoY, rotacaoZ);
            ArrayList faces = GeraFaces(verticesTransf);

            for (int i = 0; i < faces.Count; i++)
            {
                Face f = (Face)faces[i];
                if (!this.wireframe)
                {
                    g.FillPolygon(this.brushPreenchimento, f.GetVertices2D(this.larguraDesenho, alturaDesenho)); // se escolheu wireframe não preenche
                }
                g.DrawPolygon(penContorno, f.GetVertices2D(larguraDesenho, alturaDesenho));
            }

        }


        // métodos para a leitura do objeto a partir de um ficheiro .txt

        public Objeto(float largura, float altura, Stream s)
        {
            this.s = s;
            this.LeFicheiro();
            this.SetJanela(largura, altura);
        }
        public void SetObjeto(float largura, float altura, Stream s)
        {
            this.s = s;
            this.LeFicheiro();
            this.SetJanela(largura, altura);

        }

        private void LeFicheiro()
        {

            StreamReader readerObjeto = new StreamReader(this.s); //o StreamReader é usado em C# para definir uma stream para ler os dados do ficheiro para a aplicação 


            //colocar aqui a leitura do ficheiro que tem a estrutura do objeto (coordenadas dos vértices, índices faces, ..) para as estruturas de dados da classe Objeto

            string linha = "";
            ArrayList pontos = new ArrayList();
            ArrayList indices = new ArrayList();

            while (linha != null)
            {
                linha = readerObjeto.ReadLine();
                if (linha != null)
                {
                    if (linha.StartsWith("v ") && !linha.StartsWith("vt") && !linha.StartsWith("vn"))
                    {
                        Console.WriteLine(linha);
                        pontos.Add(linha);
                    }


                    if (linha.StartsWith("f"))
                    {
                        string[] coordenadasSemEspaco = linha.Split(' ');
                        string novaLinha = "f";
                        bool comecaEmZero;

                        if (int.Parse(coordenadasSemEspaco[1].Split('/')[0]) != 0)
                        {
                            comecaEmZero = true;
                        }
                        else
                        {
                            comecaEmZero= false;
                        }

                        for (int i = 1; i < coordenadasSemEspaco.Length; i++)
                        {
                            string[] coordenadasSemTraco = coordenadasSemEspaco[i].Split('/');
                            int index = int.Parse(coordenadasSemTraco[0]);

                            if (comecaEmZero)
                            {
                                index -= 1; 
                            }
                            novaLinha += " " + index;
                        }

                        Console.WriteLine(novaLinha);
                        indices.Add(novaLinha);
                    }
                }
            }

            readerObjeto.Close();

            // extrair as coordenadas individuais dos vértices das linhas guardadas nos arraylist

            char[] separador = { ' ' }; // definir o separador: caractere espaço

            string[] coordenadas;

            foreach (string l in pontos)
            {
                coordenadas = l.Split(separador);
                //Console.WriteLine("estou a adicionar o vetor3d dos pontos" + coordenadas[0] + " " + coordenadas[1] + " " + coordenadas[2] + " " + coordenadas[3]);
                this.vertices.Add(new Vector3D(float.Parse(coordenadas[1], System.Globalization.CultureInfo.InvariantCulture), float.Parse(coordenadas[2], System.Globalization.CultureInfo.InvariantCulture), float.Parse(coordenadas[3], System.Globalization.CultureInfo.InvariantCulture)));
            }

            // extrair os índices das faces, das linhas guardadas nos arraylist
            Console.WriteLine(indices.Count);

            string[] indicesVertices;
            foreach (string l in indices)
            {
                Console.WriteLine(l);
                indicesVertices = l.Split(separador);
                this.numvPorFace.Add(indicesVertices.Length - 1); //adicionar o nº de vértices/indices por face

                Console.WriteLine(indicesVertices.Length - 1);
                for (int i = 1; i < indicesVertices.Length; i++)
                {
                    this.indicesFaces.Add(int.Parse(indicesVertices[i]));
                }
            }

            Console.WriteLine($"Vértices carregados: {vertices.Count}");
            foreach (Vector3D v in vertices)
            {
                Console.WriteLine($"Vértice: {v}");
            }

            Console.WriteLine($"numvPorFace: {string.Join(", ", numvPorFace.Cast<int>())}");
            Console.WriteLine($"indicesFaces: {string.Join(", ", indicesFaces.Cast<int>())}");


        }








    }
}
