using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDIO_CadastroSeries
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> ListaSerie = new List<Serie>();//NÃO FOI IMPLEMENTADA NA CLASSE MAIN, EVOLUINDO O CONCEITO DE CAMADAS. REPOSITÓRIO PATTERN
        
        public void Atualiza(int id, Serie arquivo)
        {
            ListaSerie[id] = arquivo;
        }

        public void Exclui(int Id)
        {
            ListaSerie[Id].Exclui();
        }

        public void Insere(Serie arquivo)
        {
            ListaSerie.Add(arquivo);
        }

        public List<Serie> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}
