using AppLoterias.Formularios;

namespace AppLoterias
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnLotoFacil_Click(object sender, EventArgs e)
        {
            FormLotoFacil form = new FormLotoFacil();
            form.ShowDialog();
        }

        private void btnMegaSena_Click(object sender, EventArgs e)
        {
            FormMegaSena form = new FormMegaSena();
            form.ShowDialog();
        }

        private void btnLotomania_Click(object sender, EventArgs e)
        {
            FormLotoMania form = new FormLotoMania();
            form.ShowDialog();
        }

        private void btnQuina_Click(object sender, EventArgs e)
        {
            FormQuina form = new FormQuina();
            form.ShowDialog();
        }

        private void btnDiaDeSorte_Click(object sender, EventArgs e)
        {
            FormDiaDeSorte form = new FormDiaDeSorte();
            form.ShowDialog();
        }

        private void btnSuperSete_Click(object sender, EventArgs e)
        {
            FormSuperSete form = new FormSuperSete();
            form.ShowDialog();
        }
    }
}