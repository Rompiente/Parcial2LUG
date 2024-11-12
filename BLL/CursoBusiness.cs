using Entity;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class CursoBusiness
    {
        private CursoDAO cursoDAO = new CursoDAO();

        public List<Curso> GetAll()
        {
            try
            {
                return cursoDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
