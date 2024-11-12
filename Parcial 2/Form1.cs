using BLL;
using Entity;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        private CursoBusiness cursoBusiness = new CursoBusiness();
        private EstudianteBusiness estudianteBusiness = new EstudianteBusiness();

        private List<Estudiante> listaEstudiantes = new List<Estudiante>();

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
            List<Curso> cursos = cursoBusiness.GetAll();

 
                if (cursos.Count > 0)
                {
                    cmbCurso.DataSource = null;
                    cmbNuevoCurso.DataSource = null;
                    cmbCurso.DataSource = cursos;
                    cmbCurso.ValueMember = "IdCurso";
                    cmbCurso.DisplayMember = "NombreCurso";
                    cmbNuevoCurso.DataSource = cursos;
                    cmbNuevoCurso.ValueMember = "IdCurso";
                    cmbNuevoCurso.DisplayMember = "NombreCurso";
                }
                else
                {
                    MessageBox.Show("No hay cursos");
                }
        }

        private void ActualizarDgv()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = estudianteBusiness.GetAll();
        }

        private void btnCargarUno_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = GetStdFromForm();
            try
            {
                estudianteBusiness.CargarEstudiante(estudiante);
                ActualizarDgv();
                MessageBox.Show("Estudiante cargado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Estudiante GetStdFromForm()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = txtNombre.Text;
            estudiante.FechaNacimiento = dtpFechaNac.Value;
            estudiante.Promedio = decimal.Parse(txtPromedio.Text);
            estudiante.Curso = new Curso();
            estudiante.Curso.IdCurso = Convert.ToInt32(cmbCurso.SelectedValue);
            return estudiante;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = GetStdFromForm();
            listaEstudiantes.Add(estudiante);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                estudianteBusiness.CargarEstudiantesMultiples(listaEstudiantes);
                ActualizarDgv();
                MessageBox.Show("Estudiantes cargados con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Curso cursoSeleccionado = cmbNuevoCurso.SelectedItem as Curso;

                estudianteBusiness.Update(Convert.ToInt32(txtIdModificar.Text), txtNuevoNombre.Text, Convert.ToDecimal(txtNuevoPromedio.Text), cursoSeleccionado);
                ActualizarDgv();
                MessageBox.Show("Estudiante modificado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                estudianteBusiness.DeleteById(Convert.ToInt32(txtEliminar.Text));
                ActualizarDgv();
                MessageBox.Show("Estudiante eliminado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
