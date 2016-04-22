using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DAO;

namespace Model.PN
{
    public static class pnAluno
    {

        public static bool Inserir(Aluno a)
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();

                a.situacao = 1; //quando aluno é cadastrado, o status deve se tornar imediatamente ativo.

                db.Alunoes.Add(a);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Alterar(Aluno a)
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Aluno al = new Aluno();

                al = db.Alunoes.Find(a.emaila);

                al.Nome = a.Nome;
                al.periodo = a.periodo;
                al.campus = a.campus;
                al.curso = a.curso;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool AlterarSenha(Aluno a)
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Aluno al = new Aluno();

                al = db.Alunoes.Find(a.emaila);

                al.senha = a.senha;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Desativar(Aluno a)
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Aluno al = new Aluno();

                al = db.Alunoes.Find(a.emaila);

                al.situacao = 0;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Excluir(Aluno a)
        {
            try
            {
                s2aeiDBEntities db = new s2aeiDBEntities();
                Aluno al = new Aluno();

                al = db.Alunoes.Find(a.emaila);

                al.senha = a.senha;

                db.Alunoes.Remove(al);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
