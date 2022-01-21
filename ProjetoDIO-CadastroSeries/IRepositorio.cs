using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDIO_CadastroSeries
{
    public interface IRepositorio<T>//QUANDO ALGUÉM HERDAR, VAI TER QUE PASSAR UMA CLASSE COMO PARÂMETRO
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Exclui(int Id);

        void Atualiza(int id, T entidade);

        int ProximoId();
    }
}
