using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimuladorMedia.Formularios;

namespace SimuladorMedia
{
    public partial class FormSimuladorMedia : Form
    {
        public FormSimuladorMedia()
        {
            InitializeComponent();
        }

        private void btSimularMedia_Click(object sender, EventArgs e)
        {
            FormSimularMedia form = new FormSimularMedia();
            form.ShowDialog();
        }

        private void btNotaMinima_Click(object sender, EventArgs e)
        {
            FormNotaMinima form = new FormNotaMinima();
            form.ShowDialog();
        }

        private void btVerificarMedia_Click(object sender, EventArgs e)
        {
            FormExameFinal form = new FormExameFinal();
            form.ShowDialog();
        }
    }
}