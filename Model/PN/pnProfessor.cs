using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.PN
{
    public static class pnProfessor
    {

        public static bool Inserir(Professor p)
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                db.Professors.Add(p);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Professor Primeiro()
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Professor pa = new Professor();
                pa = db.Professors.First();

                return pa;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
