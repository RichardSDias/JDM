using JogoMemoria.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class FormDificuldade : Form
    {
        internal EDificuldade DificuldadeSelecionada { get; set; }

        public FormDificuldade()
        {
            this.DificuldadeSelecionada = EDificuldade.Nenhuma;
            InitializeComponent();
        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            this.DificuldadeSelecionada = EDificuldade.Facil;
            this.Close();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.DificuldadeSelecionada = EDificuldade.Normal;
            this.Close();
        }

        private void btnDificil_Click(object sender, EventArgs e)
        {
            this.DificuldadeSelecionada = EDificuldade.Dificil;
            this.Close();
        }
    }
}