using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDIO_CadastroSeries
{
    public abstract class Base//NÃO PODERÁ SER INSTANCIADA, É APENAS UM MOLDE, POIS SÉRIE E FILME POSSUEM O ATRIBUTO Id.
    {
        private int id;

        public int Id
        {
            get { return id; }
            protected set { id = value; }//SERÁ ACESSADO APENAS POR ESTA CLASSE OU POR SUAS DERIVADAS
        }

    }
}
