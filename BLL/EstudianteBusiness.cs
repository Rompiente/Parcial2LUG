using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class EstudianteBusiness
    {
        private EstudianteDAO estudianteDAO = new EstudianteDAO();

        public List<Estudiante> GetAll()
        {
            try
            {
                return estudianteDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public void CargarEstudiante(Estudiante estudiante)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    if (estudiante.Edad <= 16)
                    {
                        throw new Exception("La edad debe ser mayor o igual a 16");
                    }
                    if (estudiante.Edad >= 60)
                    {
                        throw new Exception("La edad debe ser menor o igual a 60");
                    }
                    if (estudiante.Nombre.Length <= 3)
                    {
                        throw new Exception("El nombre debe tener al menos 3 caracteres");
                    }
                    if (estudiante.Promedio != 0)
                    {
                        throw new Exception("El promedio de un nuevo estudiante debe ser cero");
                    }
                    estudianteDAO.CargarEstudiante(estudiante);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void CargarEstudiantesMultiples(List<Estudiante> estudiantes)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    foreach (var std in estudiantes)
                    {
                        CargarEstudiante(std);
                    }
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Update(int idEstudiante, string nombre, decimal promedio, string curso)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    Estudiante estudiante = estudianteDAO.GetById(idEstudiante);
                    if (estudiante == null) throw new Exception("Estudiante no encontrado");
                    estudiante.Nombre = nombre;
                    estudiante.Promedio = promedio;
                    estudiante.Curso = curso;
                    estudianteDAO.Update(estudiante);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteById(int idEstudiante)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    Estudiante estudiante = estudianteDAO.GetById(idEstudiante);
                    if (estudiante == null) throw new Exception("Estudiante no encontrado");
                    estudianteDAO.DeleteById(idEstudiante);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}