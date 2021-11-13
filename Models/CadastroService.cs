using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace papelariacanetas2.Models
{
    public class CadastroService
    {

        public void Cadastro(Cadastro C)
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {

                Ap.Cadastro.Add(C);
                Ap.SaveChanges();

            }

        }

        public void Editar(Cadastro C)
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {

                Cadastro cadastro = Ap.Cadastro.Find(C.Id);
                cadastro.Nome = C.Nome;
                cadastro.Login = C.Login;
                cadastro.Senha = C.Senha;
                cadastro.Email = C.Email;

                Ap.SaveChanges();

            }

        }

        public void Excluir(int id)
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {

                Ap.Cadastro.Remove(Ap.Cadastro.Find(id));
                Ap.SaveChanges();

            }

        }

        public ICollection<Cadastro> ListarTodos(FiltroCadastro filtro = null)
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {

                IQueryable<Cadastro> consulta;

                if (filtro != null)
                {

                    switch (filtro.TipoFiltro)
                    {

                        case "Nome":
                            consulta = Ap.Cadastro.Where(C => C.Nome.Contains(filtro.Filtro));
                            break;

                        case "Login":
                            consulta = Ap.Cadastro.Where(C => C.Login.Contains(filtro.Filtro));
                            break;

                        default:
                            consulta = Ap.Cadastro;
                            break;
                    }

                }
                else
                {

                    consulta = Ap.Cadastro;

                }

                List<Cadastro> ListaConulta = consulta.OrderBy(C => C.Nome).ToList();

                return ListaConulta;

            }

        }

        public List<Cadastro> Listar()
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {


                return Ap.Cadastro.ToList();

            }

        }

        public Cadastro Listar(int id)
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {


                return Ap.Cadastro.Find(id);

            }

        }
        public Cadastro ObterPorId(int id)
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {

                return Ap.Cadastro.Find(id);

            }

        }

    }
}