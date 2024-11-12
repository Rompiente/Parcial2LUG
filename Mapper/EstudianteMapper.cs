using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class EstudianteMapper
    {
        public static Estudiante Map(SqlDataReader reader, Curso curso)
        {
            Estudiante estudiante = new Estudiante
            {
                IdEstudiante = Convert.ToInt32(reader["ID_ESTUDIANTE"].ToString()),
                Nombre = reader["NOMBRE"].ToString(),
                FechaNacimiento = DateTime.Parse(reader["FECHA_NACIMIENTO"].ToString()),
                Promedio = Convert.ToDecimal(reader["PROMEDIO_ACTUAL"]),
                Curso = curso
            };
            return estudiante;
        }
    }
}
