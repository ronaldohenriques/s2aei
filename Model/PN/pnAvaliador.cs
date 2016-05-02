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
        static int posicao;

        public static bool Inserir(Avaliador av)
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Guid guid = Guid.NewGuid();
                av.IdAvaliador = guid;
                db.Avaliadors.Add(av);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Avaliador Primeiro()
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Avaliador av = new Avaliador();
                av = db.Avaliadors.First();
                posicao = 0;

                return av;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static Avaliador Anterior()
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Avaliador av = new Avaliador();
                List<Avaliador> listProf = db.Avaliadors.ToList();

                if (posicao > 0)
                {
                    posicao--;
                    av = listProf.ElementAt(posicao);
                }
                else
                {
                    av = listProf.ElementAt(0);
                }
                return av;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static Avaliador Proximo()
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Avaliador av = new Avaliador();
                List<Avaliador> listProf = db.Avaliadors.ToList();

                if (posicao >= 0 && posicao < (listProf.Count() - 1))
                {
                    posicao++;
                    av = listProf.ElementAt(posicao);
                }
                else
                {
                    av = listProf.ElementAt(listProf.Count() - 1);
                }
                return av;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static Avaliador Ultimo()
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Avaliador av = new Avaliador();
                List<Avaliador> listProf = db.Avaliadors.ToList();
                posicao = listProf.Count() - 1;
                av = listProf.ElementAt(posicao);

                return av;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool SetSituacao(Avaliador a, byte status)
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Avaliador av = new Avaliador();

                av = db.Avaliadors.Find(a.IdAvaliador);
                av.situacao = status;

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
