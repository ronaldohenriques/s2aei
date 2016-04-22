using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.PN
{

    public static class pnLogin
    {

        public static bool Valida(String strLogin)
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Administracao pa = new Administracao();
                //pa = db.Administracaos.Where(m => m.login == strLogin).FirstOrDefault();
              
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
