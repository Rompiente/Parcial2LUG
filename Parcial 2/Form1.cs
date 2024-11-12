using BLL;
using Entity;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        private CursoBusiness cursoBusiness = new CursoBusiness();
        private EstudianteBusiness estudianteBusiness = new EstudianteBusiness();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void ActualizarCampos()
        {
            ActualizarComboBox();
            ActualizarDgv();
        }

        private void ActualizarComboBox()
        {
            cmbCurso.ValueMember = "IdCurso";
            cmbCurso.DisplayMember = "NombreCurso";
            cmbCurso.DataSource = cursoBusiness.GetAll();
        }

    }
}
