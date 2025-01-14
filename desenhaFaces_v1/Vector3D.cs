// classe Vector3D para representar pontos no espaço 3D -  versão 1.0 

using System;
using System.Drawing;
using System.IO;

public class Vector3D
{
    //------DADOS da classe ----------------------

    public float x, y, z, w; // neste caso vamos usá-los como públicos

    //--------- MÉTODOS --------------------------
    
    //construtor por omissão (sem parâmetros)
    public Vector3D()
    {
        this.x = 0.0f; this.y = 0.0f; this.z = 0.0f; this.w = 1.0f;
    }

    //construtor por cópia (o parâmetro é um objecto da mesma classe)
    public Vector3D(Vector3D v)
    {
        this.x = v.x;
        this.y = v.y;
        this.z = v.z;
        this.w = v.w;
    }

    //construtor com parâmetros (x,y e z)
    public Vector3D(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = 1.0f;
    }
    //construtor com parâmetros (x,y,z e w) para representação em coordenadas homogéneas
    public Vector3D(float x, float y, float z, float w)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }
  
    // para criar um objeto do tipo Vector3D com os mesmos dados da classe
    public Vector3D Clone()
    {
        return new Vector3D(this.x, this.y, this.z, this.w);
    }
     

    public float GetX()
	{
		return this.x;
	}
	
	public float GetY()
	{
		return this.y;
	}
	
	public float GetZ()
	{
		return this.z;
	}
	
	public void SetX(float x)
	{
		this.x = x;
	}
	
	public void SetY(float y)
	{
		this.y = y;
	}
	
	public void SetZ(float z)
	{
		this.z = z;
	}
	public void Set(float x, float y, float z)
	{
		this.x = x;
		this.y = y;
		this.z = z;
	}


    // Verifica se o ponto é igual a um ponto v
    public bool Equals(Vector3D v)
    {
        if (v.x == this.x && v.y == this.y && v.z == this.z && v.w == this.w)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Sobrecarga (overloading) de operador unário '+'  para objetos do tipo Vector3D
    public static Vector3D operator +(Vector3D v)
    {
        return v;
    }

    // Sobrecarga (overloading) de operador unário '-' para objetos do tipo Vector3D(simétrico do ponto)
    public static Vector3D operator -(Vector3D v) 
    {
        float x1, y1, z1, w1;
        x1 = -v.x;
        y1 = -v.y; 
        z1 = -v.z; 
        w1 = v.w; 
        return new Vector3D(x1, y1, z1, w1);
    }

    // Sobrecarga (overloading) do operador bnário '+' para soma de dois pontos em 3D; 
    public static Vector3D operator +(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z, v1.w);
    }

    // Sobrecarga (overloading) do operador operador binário '-' para subtracção dos dois pontos em 3D;
    public static Vector3D operator -(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z, v1.w);
    }

    // Sobrecarga (overloading)do operador '*' para multiplicação de ponto por uma constante
    public static Vector3D operator*(Vector3D v, float c)
    {
        float x1, y1, z1, w1;
        x1 = c * v.x;
        y1 = c * v.y;
        z1 = c * v.z;
        w1 = v.w;
        return new Vector3D(x1, y1, z1, w1);
    }

    // Sobrecarga (overloading)do operador '%' para multiplicação de 2 pontos componente a componente
    public static Vector3D operator %(Vector3D v1, Vector3D v2)
    {
        Vector3D r = new Vector3D();
        r.x = v1.x * v2.x;
        r.y = v1.y * v2.y;
        r.z = v1.z * v2.z;
        r.w = v1.w * v2.w;
        return r;

    }

    // Sobrecarga (overloading) do operador '/' para Divisão por uma contante
    public static Vector3D operator /(Vector3D v, float c)
    {
        float x1, y1, z1, w1;
        x1 = v.x/c;
        y1 = v.y/c;
        z1 = v.z/c;
        w1 = v.w;
        return new Vector3D(x1, y1, z1, w1);
    }

    // Produto escalar / Produto interno de dois pontos (dot product)
    public static float operator*(Vector3D v1, Vector3D v2)
    {
        float r;
        r = v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        return r;
    }

    // Produto vectorial / Produto externo dos 2 pontos (cross product) 
    public static Vector3D operator^(Vector3D v1, Vector3D v2)
    {
        Vector3D r = new Vector3D();
        r.x = (v1.y * v2.z - v2.y * v1.z);
        r.y = v1.z*v2.x-v1.x*v2.z;
        r.z = (v1.x * v2.y - v2.x * v1.y);
        r.w = v1.w;
        return r;
    }

    // Norma de um ponto
    public float Norm()
    {
        //return (float)Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
        return (float)Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2) );
    }

    // Normalização de um ponto
    public void Normalize()
    {
        float n = Norm();
        if (n != 0.0)
        {
            this.x = this.x / n;
            this.y = this.y / n;
            this.z = this.z / n;
        }
    }

    // Converte para string
    public override String ToString()
    {
        String res;
        res = "(" + this.x + ", " + this.y + ", " + this.z + ")";
        return res;

       // return String.Format("({0},{1},{2},{3})", x, y, z, w);
    }

    //novos

   public void MultiplicaporMatriz_coordHomogeneas(metodosMatriz3D.Matriz3D matriz)
    {
        float[] resultado=matriz.multiplicaVector(new float[4] {this.x, this.y, this.z, this.w});
        this.x = resultado[0];
        this.y = resultado[1];
        this.z = resultado[2];
        this.w = resultado[3];
    }

    public void MultiplicaporMatriz_coordCartesianas(metodosMatriz3D.Matriz3D matriz)
    {
        float[] resultado = matriz.multiplicaVector(new float[4] { this.x, this.y, this.z, this.w });
        this.x = resultado[0]/ resultado[3];
        this.y = resultado[1]/ resultado[3];
        this.z = resultado[2];// não dividimos por W para preservar o z.
        this.w = 1.0f;
    }

    public PointF ConvertePontoJanelaToViewport(float largura,float altura)
    {
        // Aqui faz-se a conversão de coordenadas mundo para coordenadas do dispositivo
        // largura/2 e altura/2 são o ponto de referência do objecto 
        // xv= xvmin + (xw-xwmin)*Sx, com Sx= (xvmax-xvmin)/(xwmax-xwmin)
        // yv= yvmin - (yw-ywmin)*Sy, com Sy= (yvmax-yvmin)/(ywmax-ywmin), uma vez que o Y está orientado para cima no mundo, vem com o sinal -
        // neste caso o tamanho do mundo e do viewport é o mesmo logo Sx e Sy são iguais a 1 pois não queremos distorcer o objeto
        // neste caso, xwmin e ywmin são zero pois o objeto está centrado na origem (o objeto é definido como centrado nos eixos x, y, e z)

        return new PointF(largura / 2 + this.x, altura / 2 - this.y);
    }

}