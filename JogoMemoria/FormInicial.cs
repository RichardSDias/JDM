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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void btnGenero_MouseHover(object sender, EventArgs e)
        {
            //http://elandroidefeliz.com/8-bancos-audios-efectos-sonido-libres-derechos/
            //http://www.freesoundeffects.com/free-sounds/animals-10013/160/tot_sold/20/9/
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\users\richard.dias.multilog\documents\visual studio 2015\Projects\JogoMemoria\JogoMemoria\Audios\leopard7.wav");
            //player.Play();
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            var formDificuldade = new FormDificuldade();

            while (formDificuldade.DificuldadeSelecionada == Enumeradores.EDificuldade.Nenhuma)
            {
                formDificuldade.ShowDialog();
            }

            var genero = (sender as Button).Tag as string;

            Form formJogo = null;

            if (genero == "MENINO")
            {
                formJogo = new FormMemoriaMenino(formDificuldade.DificuldadeSelecionada);
            }
            else
            {
                formJogo = new FormMemoriaMenina(formDificuldade.DificuldadeSelecionada);
            }

            formJogo.Show();
        }
    }
}