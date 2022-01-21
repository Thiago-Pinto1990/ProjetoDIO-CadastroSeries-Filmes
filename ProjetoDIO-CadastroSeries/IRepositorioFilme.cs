using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDIO_CadastroSeries
{
    public interface IRepositorioFilme<T>//IMPLEMENTAÇÃO OBRIGATÓRIA DOS MÉTODOS ABAIXO NA CLASSE QUE HERDAR DESTA INTERFACE
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Exclui(int Id);

        void Atualiza(int id, T entidade);

        int ProximoId();
    }
}
