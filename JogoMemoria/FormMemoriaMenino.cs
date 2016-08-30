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
    public partial class FormMemoriaMenino : Form
    {
        private EDificuldade _Dificuldade;
        public EDificuldade Dificuldade {
            get
            {
                return this._Dificuldade;
            }
            set
            {
                this._Dificuldade = value;

                switch(this._Dificuldade)
                {
                    case EDificuldade.Facil:
                        {
                            this.BackColor = Color.FromArgb(192, 255, 192);
                            break;
                        }
                    case EDificuldade.Normal:
                        {
                            this.BackColor = Color.FromArgb(255, 255, 192);
                            break;
                        }
                    case EDificuldade.Dificil:
                        {
                            this.BackColor = Color.FromArgb(255, 192, 192);
                            break;
                        }
                    default: break;
                }

            }
        }

        public FormMemoriaMenino(EDificuldade dificuldade)
        {
            this.Dificuldade = dificuldade;
            InitializeComponent();
        }
    }
}