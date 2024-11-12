﻿using Entity;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;

namespace DAL
{
    public class EstudianteDAO
    {
        private CursoDAO cursoDAO = new CursoDAO();

        public void CargarEstudiante(Estudiante estudiante)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connection.GetConnectionString()))
                {
                    connect.Open();

                    string query = "Insert into Estudiante(NOMBRE,FECHA_NACIMIENTO,PROMEDIO_ACTUAL,ID_CURSO) VALUES(@nombre,@fechanacimiento,@promedioactual,@idcurso)";
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@nombre", estudiante.Nombre);
                        command.Parameters.AddWithValue("@fechanacimiento", estudiante.FechaNacimiento);
                        command.Parameters.AddWithValue("@promedioactual", estudiante.Promedio);
                        command.Parameters.AddWithValue("@idcurso", estudiante.Curso.IdCurso);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Estudiante> GetAll()
        {
            try
            {
                List<Estudiante> estudiantes = new List<Estudiante>();

                using (SqlConnection connect = new SqlConnection(Connection.GetConnectionString()))
                {
                    connect.Open();
                    string query = "select ID_ESTUDIANTE, NOMBRE, FECHA_NACIMIENTO, PROMEDIO_ACTUAL, ID_CURSO from ESTUDIANTE";
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idCurso = Convert.ToInt32(reader["ID_CURSO"].ToString());
                                Curso curso = cursoDAO.GetById(idCurso);
                                Estudiante estudiante = EstudianteMapper.Map(reader, curso);

                                estudiantes.Add(estudiante);
                            }
                        }
                    }
                }
                return estudiantes;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteById(int id)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connection.GetConnectionString()))
                {
                    connect.Open();

                    string query = "Delete from ESTUDIANTE where ID_ESTUDIANTE = @id";
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void Update(Estudiante estudiante)
        {
            try
            {
                using (SqlConnection)
            }
        }
    }
}
