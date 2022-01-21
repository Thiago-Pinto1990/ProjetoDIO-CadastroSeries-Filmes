using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDIO_CadastroSeries
{
    public class Filme : Serie//VAI HERDAR ATRIBUTOS DE SÉRIE(QUE POR SUA VEZ, ESTÁ HERDANDO DA CLASSE ABSTRATA BASE)
    {
        private double duracao;//ATRIBUTO EXCLUSIVO DE FILME

        public double Duracao
        {
            get { return duracao; }
            set { duracao = value; }
        }

        //CRIANDO CONSTRUTOR
        public Filme(int id = 0,string titulo = null,string descricao = null,int ano = 0, Genero genero = 0,double duracao = 0)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Genero = genero;
            this.Duracao = duracao;
            this.Excluido = false;
        }

        //MÉTODO PARA RETORNAR INFORMAÇÕES SOBRE O OBJETO FILME
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Estréia: " + this.Ano + Environment.NewLine;
            retorno += "Duração: " + this.Duracao + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido + Environment.NewLine;
            return retorno;
        }

        //ESTÁ HERDANDO OS SEGUINTES MÉTODOS: RetornaTitulo() - RetornaId() - Exclui() - RetornaExcluido()
    }
}
