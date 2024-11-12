using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CursoDAO
    {
        public List<Curso> GetAll()
        {
            try
            {
                List<Curso> cursos = new List<Curso>();
                using (SqlConnection connection = new SqlConnection(Connection.GetConnectionString()))
                {
                    connection.Open();
                    string query = "Select ID_CURSO, NOMBRE_CURSO from CURSO";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cursos.Add(CursoMapper.Map(reader));
                            }
                        }
                    }
                }
                return cursos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Curso GetById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.GetConnectionString()))
                {
                    connection.Open();
                    string query = "Select ID_CURSO, NOMBRE_CURSO from CURSO where ID_CURSO = @ID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return CursoMapper.Map(reader);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
