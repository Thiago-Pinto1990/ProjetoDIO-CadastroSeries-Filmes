using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDIO_CadastroSeries
{
    public class Serie : Base
    {
        //ESTA CLASSE JÁ ESTÁ HERDANDO O ATRIBUTO Id DE FORMA IMPLÍCITA
        //CRIANDO OUTROS ATRIBUTOS
        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private int ano;

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        private Genero genero;

        public Genero Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        private bool excluido;

        public bool Excluido
        {
            get { return excluido; }
            set { excluido = value; }
        }



        //CRIANDO CONSTRUTOR
        public Serie(int id = 0,string titulo = null,string descricao = null,int ano = 0, Genero genero = 0)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Genero = genero;
            this.Excluido = false;
        }

        //MÉTODO PARA RETORNAR INFORMAÇÕES DO OBJETO SÉRIE
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Estréia: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido + Environment.NewLine;
            return retorno;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public void Exclui()
        {
            this.Excluido = true;
        }

        public bool RetornaExcluido()
        {
            return this.Excluido;
        }













    }
}
