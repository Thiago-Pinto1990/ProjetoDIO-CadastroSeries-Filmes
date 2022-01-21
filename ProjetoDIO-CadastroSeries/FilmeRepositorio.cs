using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDIO_CadastroSeries
{
    public class FilmeRepositorio : IRepositorioFilme<Filme>//UTILIZANDO O CONCEITO DE REPOSITÓRIO PATTERN
    {
        private List<Filme> ListaFilme = new List<Filme>();

        //IMPLEMENTANDO OS MÉTODOS HERDADOS DA INTERFACE
        public void Atualiza(int id, Filme entidade)
        {
            ListaFilme[id] = entidade;
        }

        public void Exclui(int Id)
        {
            ListaFilme[Id].Exclui();
        }

        public void Insere(Filme entidade)
        {
            ListaFilme.Add(entidade);
        }

        public List<Filme> Lista()
        {
            return ListaFilme;
        }

        public int ProximoId()
        {
            return ListaFilme.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return ListaFilme[id];
        }
    }
}
