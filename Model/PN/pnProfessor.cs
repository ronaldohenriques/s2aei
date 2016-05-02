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

        public static bool Inserir(Professor p)
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Guid guid = Guid.NewGuid();
                p.IdProfessor = guid;
                db.Professors.Add(p);
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
                Professor pa = new Professor();
                pa = db.Professors.First();
                posicao = 0;

                return pa;
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
                Professor pa = new Professor();
                List<Professor> listProf = db.Professors.ToList();

                if (posicao > 0)
                {
                    posicao--;
                    pa = listProf.ElementAt(posicao);
                }
                else
                {
                    pa = listProf.ElementAt(0);
                }
                return pa;
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
                Professor pa = new Professor();
                List<Professor> listProf = db.Professors.ToList();

                if (posicao >= 0 && posicao < (listProf.Count() - 1))
                {
                    posicao++;
                    pa = listProf.ElementAt(posicao);
                }
                else
                {
                    pa = listProf.ElementAt(listProf.Count() - 1);
                }
                return pa;
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
                Professor pa = new Professor();
                List<Professor> listProf = db.Professors.ToList();
                posicao = listProf.Count() - 1;
                pa = listProf.ElementAt(posicao);

                return pa;
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
                Professor pa = new Professor();


                pa = db.Professors.Find(p.IdProfessor);
                pa.situacao = status;

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
