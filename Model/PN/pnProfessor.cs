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
        static int posicao;

        public static bool Inserir(Professor pf)
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Guid guid = Guid.NewGuid();
                pf.IdProfessor = guid;
                db.Professors.Add(pf);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Professor Primeiro()
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Professor pf = new Professor();
                pf = db.Professors.First();
                posicao = 0;

                return pf;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static Professor Anterior()
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Professor pf = new Professor();
                List<Professor> listProf = db.Professors.ToList();

                if (posicao > 0)
                {
                    posicao--;
                    pf = listProf.ElementAt(posicao);
                }
                else
                {
                    pf = listProf.ElementAt(0);
                }
                return pf;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static Professor Proximo()
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Professor pf = new Professor();
                List<Professor> listProf = db.Professors.ToList();

                if (posicao >= 0 && posicao < (listProf.Count() - 1))
                {
                    posicao++;
                    pf = listProf.ElementAt(posicao);
                }
                else
                {
                    pf = listProf.ElementAt(listProf.Count() - 1);
                }
                return pf;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static Professor Ultimo()
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Professor pf = new Professor();
                List<Professor> listProf = db.Professors.ToList();
                posicao = listProf.Count() - 1;
                pf = listProf.ElementAt(posicao);

                return pf;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool SetSituacao(Professor p, byte status)
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Professor pf = new Professor();


                pf = db.Professors.Find(p.IdProfessor);
                pf.situacao = status;

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
