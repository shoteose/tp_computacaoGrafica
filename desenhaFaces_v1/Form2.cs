using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desenhaFaces_v1
{
    public partial class Form2 : Form
    {
        private Objeto obj;
        public bool ProjecaoPerspectiva;

        public event EventHandler StateChanged;

        public Form2(Objeto obj, bool ProjecaoPerspectiva)
        {
            InitializeComponent();

            // Clonar o objeto para evitar alterações diretas
            this.obj = obj.Clone();
            this.ProjecaoPerspectiva = ProjecaoPerspectiva;
        }

        public void UpdateDrawing(Objeto updatedObj)
        {
            this.obj = updatedObj.Clone();
            this.pb_desenho_2.Invalidate();
        }

        public void UpdateProjecao(bool isPerspectiva)
        {
            // Atualizar a projeção baseada no Form1
            ProjecaoPerspectiva = isPerspectiva;
            this.pb_desenho_2.Invalidate();
        }

        private void pb_desenho_2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (obj != null)
            {
                // Configurar a projeção baseada no estado atual
                obj.SetProjecao();

                // Desenhar o objeto
                obj.Desenha(g, 0, 0, 0, 0, 0, 0);
            }
        }
    }

}
