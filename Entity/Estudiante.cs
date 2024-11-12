using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Estudiante
    {
        private int idEstudiante;
        private string nombre;
        private DateTime fechaNacimiento;
        private Curso curso;
        private decimal promedio;

        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string NombreCurso { get => Curso.NombreCurso; }
        public Curso Curso { get => curso; set => curso = value; }
        public decimal Promedio { get => promedio; set => promedio = value; }

        public int Edad
        {
            get
            {
                var hoy = DateTime.Today;
                var edad = hoy.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
                return edad;
            }
        }
    }
}
