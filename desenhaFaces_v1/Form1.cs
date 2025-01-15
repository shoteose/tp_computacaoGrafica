using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO; // para usar as streams
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace desenhaFaces_v1
{
    public partial class Form1 : Form
    {
        private Objeto obj;
        private Pen pen1;
        private SolidBrush brush1;
        private string nomeFicheiro;
        private string tipoModelo;


        public Form1()
        {
            InitializeComponent();
            
            obj = new Objeto(pb_desenho.Width, pb_desenho.Height);

            pen1 = new Pen(CorStroke_pb.BackColor, (float)Espessura_nud.Value);
            pen1.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;// arredonda a junção das linhas
            brush1 =new SolidBrush(CorFill_pb.BackColor);

            // atrbuir a pen e o brush ao objecto
            obj.SetCores(pen1, brush1);

        }

        private void pb_desenho_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (obj != null)
            {
                obj.Desenha(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value);
            }
        }

        private void SetCores() //para atualizar a classe objeto com os atributos da pen e brush que foram escolhidos no form
        {
            if (pen1 != null && brush1 != null)
            {
                pen1.Color = CorStroke_pb.BackColor;
                pen1.Width = (float)Espessura_nud.Value;
                brush1.Color = CorFill_pb.BackColor;
                obj.SetCores(pen1, brush1);//atribui as cores escolhidas no form às variáveis na classe
            }
        }

        private void cb_wireframe_CheckedChanged(object sender, EventArgs e)
        {
            if (obj != null)
            {
                obj.SetWireframe();
                this.pb_desenho.Invalidate();
            }
        }

        private void Espessura_nud_ValueChanged(object sender, EventArgs e)
        {
            if (obj != null)
            {
                SetCores();
                this.pb_desenho.Invalidate();

            }
        }

        private void CorStroke_btn_Click(object sender, EventArgs e)
        {
            ColorDialog dialogo = new ColorDialog();
            dialogo.Color = this.CorStroke_pb.BackColor;
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                this.CorStroke_pb.BackColor = dialogo.Color;
                if (obj != null)
                {
                    SetCores();
                    this.pb_desenho.Invalidate();
                }
            }
        }

        private void CorFill_btn_Click(object sender, EventArgs e)
        {
            ColorDialog dialogo = new ColorDialog();
            dialogo.Color = this.CorFill_pb.BackColor;
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                
                this.CorFill_pb.BackColor = dialogo.Color;
                if (obj != null)
                {
                    SetCores();
                    this.pb_desenho.Invalidate();
                }
            }
        }

        private void tb_transy_ValueChanged(object sender, EventArgs e)
        {
            this.pb_desenho.Invalidate();
        }

        private void tb_transx_ValueChanged(object sender, EventArgs e)
        {
            this.pb_desenho.Invalidate();
        }

        private void tb_transz_ValueChanged(object sender, EventArgs e)
        {
            this.pb_desenho.Invalidate();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Funcionalidade ainda não implementada!\n");

            Stream str;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)

                try
                {
                    if ((str = fileDialog.OpenFile()) != null)
                    {

                        using (str)
                        {
                            if (obj != null)
                            {
                                // se vamos querer usar o mesmo obj para os dados lidos a partir do ficheiro, temos de remover dos arraylist os dados do objeto anterior
                                
                                obj.GetVertices3D().Clear();
                                obj.GetIndicesFaces().Clear();
                                obj.GetNumvPorFace().Clear();
                                obj.SetObjeto(this.pb_desenho.Width, this.pb_desenho.Height, str); //lê o novo objeto a partir de ficheiro
                            }

                            nomeFicheiro = fileDialog.SafeFileName;

                            SetCores(); // atualizar a classe objeto com os atributos da pen e brush que foram escolhidos no form

                            if (cb_wireframe.Checked)
                            {
                                obj.SetWireframe();
                            }

                            this.pb_desenho.Invalidate();

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: Não foi possível ler o ficheiro\n" + ex.Message);
                }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenho de Faces Poligonais\n" + "Versão 2.0\n" + "João Paulo Martins Novo n25968\n");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (obj != null)
            {
                obj.SetJanela(this.pb_desenho.Width, this.pb_desenho.Height);
                this.pb_desenho.Invalidate();
            }
        }

        private void Rotx_tb_ValueChanged(object sender, EventArgs e)
        {
            this.pb_desenho.Invalidate();
        }

        private void Roty_tb_ValueChanged(object sender, EventArgs e)
        {
            this.pb_desenho.Invalidate();
        }

        private void Rotz_tb_ValueChanged(object sender, EventArgs e)
        {
            this.pb_desenho.Invalidate();
        }

        private void cuboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tipoModelo = "cubo";

            this.obj = new Objeto(pb_desenho.Width, pb_desenho.Height, this.tipoModelo);

            this.pb_desenho.Invalidate();
        }

        private void prismaPentagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tipoModelo = "prismaPenta";

            this.obj = new Objeto(pb_desenho.Width, pb_desenho.Height, this.tipoModelo);

            this.pb_desenho.Invalidate();
        }

        private void piramideQuadrangularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tipoModelo = "piramideQuad";

            this.obj = new Objeto(pb_desenho.Width, pb_desenho.Height, this.tipoModelo);

            this.pb_desenho.Invalidate();
        }

        private void piramideHexagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tipoModelo = "piramideHexa";

            this.obj = new Objeto(pb_desenho.Width, pb_desenho.Height, this.tipoModelo);

            this.pb_desenho.Invalidate();
        }

        private void coneToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (textBoxFaces.Text != "" && textBoxAltura.Text != "" && textBoxRaio.Text != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBoxFaces.Text, "[^0-9]") || System.Text.RegularExpressions.Regex.IsMatch(textBoxAltura.Text, "[^0-9]") || System.Text.RegularExpressions.Regex.IsMatch(textBoxRaio.Text, "[^0-9]"))
                {
                    MessageBox.Show("Apenas números são aceites");
                }
                else { 
                    this.tipoModelo = "cone";
                    this.obj = new Objeto(pb_desenho.Width, pb_desenho.Height, textBoxRaio.Text, textBoxAltura.Text, textBoxFaces.Text);
                    this.pb_desenho.Invalidate();
                }
            }
            else
            {
                MessageBox.Show("Necessário estarem preenchidos os dados");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (obj != null)
            {
                obj.SetProjecao();
                this.pb_desenho.Invalidate();
            }
        }

        private void distancia_ValueChanged(object sender, EventArgs e)
        {
            if (obj != null)
            {
                obj.SetDistanciaCamera((float)distancia.Value);
                this.pb_desenho.Invalidate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (obj != null)
            {
                tb_transx.Value = 0;
                tb_transy.Value = 0;
                tb_transz.Value = 0;
                Rotx_tb.Value = 0;
                Roty_tb.Value = 0;
                Rotz_tb.Value = 0;

                this.pb_desenho.Invalidate();
            }
        }
    }
}
