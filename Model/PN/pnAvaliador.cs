using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.PN
{
    public static class pnAvaliador
    {
        public static bool Inserir(Avaliador a)
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Guid guid = Guid.NewGuid();
                a.IdAvaliador = guid;
                db.Avaliadors.Add(a);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
