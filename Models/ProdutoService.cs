using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace papelariacanetas2.Models
{
    public class ProdutoService
    {
        public void Cadastro(Produto P)
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {

                Ap.Produto.Add(P);
                Ap.SaveChanges();

            }

        }

        public void Editar(Produto P)
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {

                Produto produto = Ap.Produto.Find(P.Id);
                produto.NomeProduto = P.NomeProduto;
                produto.TipoProduto = P.TipoProduto;
                produto.ValorUnitario = P.ValorUnitario;


                Ap.SaveChanges();

            }

        }

        public ICollection<Produto> ListarTodos(FiltroProduto filtro = null)
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {

                IQueryable<Produto> consulta;

                if (filtro != null)
                {

                    switch (filtro.TipoFiltro)
                    {

                        case "Produto":
                            consulta = Ap.Produto.Where(P => P.NomeProduto.Contains(filtro.Filtro));
                            break;

                        case "TipoProduto":
                            consulta = Ap.Produto.Where(P => P.TipoProduto.Contains(filtro.Filtro));
                            break;

                        default:
                            consulta = Ap.Produto;
                            break;
                    }

                }
                else
                {

                    consulta = Ap.Produto;

                }

                List<Produto> ListaConulta = consulta.OrderBy(P => P.NomeProduto).ToList();

                return ListaConulta;

            }

        }

        public List<Produto> Listar()
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {

                return Ap.Produto.ToList();

            }

        }

        public Produto Listar(int id)
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {

                return Ap.Produto.Find(id);

            }

        }

        public void Excluir(int id)
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {

                Ap.Produto.Remove(Ap.Produto.Find(id));
                Ap.SaveChanges();

            }

        }

        public Produto ObterPorId(int id)
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {

                return Ap.Produto.Find(id);

            }

        }

    }
}