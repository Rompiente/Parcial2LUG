using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Curso
    {
        public int IdCurso;
        public string NombreCurso;
        public string Profesor;
        public string Horario;

        public int IdCurso1 { get => IdCurso; set => IdCurso = value; }
        public string NombreCurso1 { get => NombreCurso; set => NombreCurso = value; }
        public string Profesor1 { get => Profesor; set => Profesor = value; }
        public string Horario1 { get => Horario; set => Horario = value; }

        public static implicit operator Curso(string v)
        {
            throw new NotImplementedException();
        }
    }
}
