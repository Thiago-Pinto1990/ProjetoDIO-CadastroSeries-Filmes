using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDIO_CadastroSeries
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static FilmeRepositorio repositorioFilme = new FilmeRepositorio();
        
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();//TRABALHANDO ESCOLHA DO USUÁRIO
            while(opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {
                    case "0":
                        ListarSerie();
                        break;
                    case "1":
                        ListarFilme();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        InserirFilme();
                        break;
                    case "4":
                        AtualizarSerie();
                        break;
                    case "5":
                        AtualizarFilme();
                        break;
                    case "6":
                        ExcluirSerie();
                        break;
                    case "7":
                        ExcluirFilme();
                        break;
                    case "8":
                        VisualizarSeries();
                        break;
                    case "9":
                        VisualizarFilmes();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida !");
                        break;
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
            
        }

        private static void VisualizarSeries()//MÉTODO PARA VISUALIZAR SÉRIE
        {
            var lista = repositorio.Lista();
            Console.WriteLine("Visualizar Série");
            if(lista.Count == 0)//UTILIZEI ESTRUT. COND. PARA CORRIGIR UM POSSÍVEL ERRO, CASO NÃO TENHA SÉRIE CADASTRADA QUANDO ESCOLHER ESTA OPÇÃO
            {
                Console.WriteLine("Nenhuma Série Cadastrada\n");
            }
            else
            {
                Console.Write("Digite o Id da Série: ");
                int indiceSerie = int.Parse(Console.ReadLine());
                var serie = repositorio.RetornaPorId(indiceSerie);
                Console.WriteLine(serie);
            }
            
            
        }

        private static void VisualizarFilmes()//MÉTODO PARA VISUALIZAR FILME
        {
            var lista = repositorioFilme.Lista();
            Console.WriteLine("Visualizar Filme");
            if(lista.Count == 0)//UTILIZEI ESTRUT. COND. PARA CORRIGIR UM POSSÍVEL ERRO, CASO NÃO TENHA SÉRIE CADASTRADA QUANDO ESCOLHER ESTA OPÇÃO
            {
                Console.WriteLine("Nenhum Filme Cadastrado\n");
            }
            else
            {
                Console.Write("Digite o Id do Filme: ");
                int indiceFilme = int.Parse(Console.ReadLine());
                var filme = repositorioFilme.RetornaPorId(indiceFilme);
                Console.WriteLine(filme);
            }
            
            
        }

        private static void ExcluirSerie()//MÉTODO PARA EXCLUIR SÉRIE
        {
            var lista = repositorio.Lista();
            Console.WriteLine("Excluir Série");
            if(lista.Count == 0)//UTILIZEI ESTRUT. COND. PARA CORRIGIR UM POSSÍVEL ERRO, CASO NÃO TENHA SÉRIE CADASTRADA QUANDO ESCOLHER ESTA OPÇÃO
            {
                Console.WriteLine("Nenhuma Série Cadastrada\n");
            }
            else
            {
                Console.Write("Digite o Id da Série: ");
                int indiceSerie = int.Parse(Console.ReadLine());
                Console.Write($"Deseja Mesmo Excluir a Série {indiceSerie} [S] ou [N]: ");
                string resposta = Console.ReadLine().ToUpper();
                if (resposta == "S")
                {
                    repositorio.Exclui(indiceSerie);
                }
                else
                {
                    Console.WriteLine("Ok");
                }
            }
            
        }

        private static void ExcluirFilme()//MÉTODO PARA EXCLUIR FILME
        {
            var lista = repositorioFilme.Lista();
            Console.WriteLine("Excluir Filme");
            if(lista.Count == 0)//UTILIZEI ESTRUT. COND. PARA CORRIGIR UM POSSÍVEL ERRO, CASO NÃO TENHA SÉRIE CADASTRADA QUANDO ESCOLHER ESTA OPÇÃO
            {
                Console.WriteLine("Nenhum Filme Cadastrado\n");
            }
            else
            {
                Console.Write("Digite o Id do Filme: ");
                int indiceFilme = int.Parse(Console.ReadLine());
                Console.Write($"Deseja Mesmo Excluir o Filme {indiceFilme} [S] ou [N]: ");
                string resposta = Console.ReadLine().ToUpper();
                if (resposta == "S")
                {
                    repositorioFilme.Exclui(indiceFilme);
                }
                else
                {
                    Console.WriteLine("Ok");
                }
            }
            
            
        }

        private static void AtualizarSerie()//MÉTODO PARA ATUALIZAR SÉRIE
        {
            var lista = repositorio.Lista();
            Console.WriteLine("Atualizar Série");
            if(lista.Count == 0)//UTILIZEI ESTRUT. COND. PARA CORRIGIR UM POSSÍVEL ERRO, CASO NÃO TENHA SÉRIE CADASTRADA QUANDO ESCOLHER ESTA OPÇÃO
            {
                Console.WriteLine("Nenhuma Série Cadastrada\n");
            }
            else
            {
                Console.Write("Atualize o Id da Série: ");
                int indiceSerie = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserir Nova Série");
                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
                }
                Console.Write("Digite o Gênero Entre: ");
                int entradaGenero = int.Parse(Console.ReadLine());
                Console.Write("Digite o Título da Série: ");
                string entradaTitulo = Console.ReadLine();
                Console.Write("Digite o Ano de Lançamento da Série: ");
                int entradaAno = int.Parse(Console.ReadLine());
                Console.Write("Digite a Descrição da Série: ");
                string entradaDescricao = Console.ReadLine();

                Serie atualizaSerie = new Serie(id: indiceSerie,
                                                titulo: entradaTitulo,
                                                descricao: entradaDescricao,
                                                ano: entradaAno,
                                                genero: (Genero)entradaGenero);

                repositorio.Atualiza(indiceSerie, atualizaSerie);
            }
            
            

        }

        private static void AtualizarFilme()//MÉTODO PARA ATUALIZAR FILME
        {
            var lista = repositorioFilme.Lista();
            Console.WriteLine("Atualizar Filme");
            if (lista.Count == 0)//UTILIZEI ESTRUT. COND. PARA CORRIGIR UM POSSÍVEL ERRO, CASO NÃO TENHA SÉRIE CADASTRADA QUANDO ESCOLHER ESTA OPÇÃO
            {
                Console.WriteLine("Nenhum Filme Cadastrado\n");
            }
            else
            {
                Console.Write("Atualize o Id do Filme: ");
                int indiceFilme = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserir Novo Filme");
                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
                }
                Console.Write("Digite o Gênero Entre: ");
                int entradaGenero = int.Parse(Console.ReadLine());
                Console.Write("Digite o Título do Filme: ");
                string entradaTitulo = Console.ReadLine();
                Console.Write("Digite o Ano de Lançamento do Filme: ");
                int entradaAno = int.Parse(Console.ReadLine());
                Console.Write("Digite a Descrição do Filme: ");
                string entradaDescricao = Console.ReadLine();
                Console.Write("Digite a Duração do Filme: ");
                double entradaDuracao = double.Parse(Console.ReadLine());

                Filme atualizaFilme = new Filme(id: indiceFilme,
                                                titulo: entradaTitulo,
                                                descricao: entradaDescricao,
                                                ano: entradaAno,
                                                duracao: entradaDuracao,
                                                genero: (Genero)entradaGenero);


                repositorioFilme.Atualiza(indiceFilme, atualizaFilme);
            }
            
            
        }

        private static void InserirSerie()//MÉTODO PARA INSERIR SÉRIE
        {
            Console.WriteLine("Inserir Nova Série");
            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
            }
            Console.Write("Digite o Gênero Entre: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();
            Console.Write("Digite o Ano de Lançamento da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno,
                                        genero: (Genero)entradaGenero);

            repositorio.Insere(novaSerie);
                                        
        }

        private static void InserirFilme()//MÉTODO PARA INSERIR FILME
        {
            Console.WriteLine("Inserir Novo Filme");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
            }
            Console.Write("Digite o Gênero Entre: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();
            Console.Write("Digite o Ano de Lançamento do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite a Descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();
            Console.Write("Digite a Duração do Filme: ");
            double entradaDuracao = double.Parse(Console.ReadLine());

            Filme novoFilme = new Filme(id: repositorioFilme.ProximoId(),
                                            titulo: entradaTitulo,
                                            descricao: entradaDescricao,
                                            ano: entradaAno,
                                            duracao: entradaDuracao,
                                            genero: (Genero)entradaGenero);

            repositorioFilme.Insere(novoFilme);
        }

        private static void ListarSerie()//MÉTODO PARA LISTAR SÉRIE EXISTENTE
        {
            Console.WriteLine("Listar Série");
            var lista = repositorio.Lista();
            if(lista.Count == 0)//UTILIZEI ESTRUT. COND. PARA CORRIGIR UM POSSÍVEL ERRO, CASO NÃO TENHA SÉRIE CADASTRADA QUANDO ESCOLHER ESTA OPÇÃO
            {
                Console.WriteLine("Nenhuma Série Cadastrada\n");
            }

            foreach(var serie in lista)
            {
                var exluido = serie.RetornaExcluido();
                Console.WriteLine($"#ID {serie.RetornaId()}: - {serie.RetornaTitulo()} - {exluido}");
            }

        }

        private static void ListarFilme()//MÉTODO PARA LISTA FILMES EXISTENTES
        {
            Console.WriteLine("Listar Filmes");
            var lista = repositorioFilme.Lista();
            if(lista.Count == 0)//UTILIZEI ESTRUT. COND. PARA CORRIGIR UM POSSÍVEL ERRO, CASO NÃO TENHA SÉRIE CADASTRADA QUANDO ESCOLHER ESTA OPÇÃO
            {
                Console.WriteLine("Nenhum Filme Cadastrado\n");
            }

            foreach(var filme in lista)
            {
                var excluido = filme.RetornaExcluido();
                Console.WriteLine($"#ID {filme.RetornaId()}: - {filme.RetornaTitulo()} - {excluido}");
            }
        }

        //MÉTODO PARA APRESENTAR E RETORNAR ESCOLHA DO USUÁRIO
        private static string ObterOpcaoUsuario()
        {
            
            Console.WriteLine("0 - Listar Séries");
            Console.WriteLine("1 - Listar Filmes");
            Console.WriteLine("2 - Inserir Nova Série");
            Console.WriteLine("3 - Inserir Novo Filme");
            Console.WriteLine("4 - Atualizar Série");
            Console.WriteLine("5 - Atualizar Filme");
            Console.WriteLine("6 - Excluir Série");
            Console.WriteLine("7 - Excluir Filme");
            Console.WriteLine("8 - Visualizar Séries");
            Console.WriteLine("9 - Visualizar Filmes");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine("\n");
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine("\n");
            return opcaoUsuario;

        }
    }
}
