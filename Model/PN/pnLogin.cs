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

        public static bool Valida(String strLogin, String strSenha)
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Administracao pa = new Administracao();
                pa = db.Administracaos.Where(m => m.login == strLogin).FirstOrDefault();
                if (pa.senha == strSenha)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
