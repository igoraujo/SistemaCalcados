using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    class Class
    {
        public void Load()
        {
            Random random = new Random();
            int percentualCarregamento = 0;
            int count = 0;
            string image = "█";//imagem de carregamento da página

            Console.Title = "Controle de vendas";

            for (int i = 1; percentualCarregamento < 100; i++) //enquanto o percentual for diferente de 100% roda (incrementa i++)
            {
                Console.Clear();//limpa a tela
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 7) + "}", " CARREGANDO...")); // formata o espacamento da tela, WindowWidth: calcula o tamanho da tela e o /2, a divide pela metade.

                image = "";

                Console.WriteLine(); //quebra uma linha
                count = percentualCarregamento; //iguala o percental com o contador para entrar no laço (while)

                while (count == percentualCarregamento) // enaquanto o contador for igual ao percentual faz ->
                {
                    for (int j = 0; j != count; j++) //-> enquanto o auxiliar j for diferente do contador, escreve na tela a imagem ("█")
                    {
                        Console.Write("█"); //imagem escrita na tela o numero de vezes de acordo com o numero expresso na porcentagem
                        image += "█"; //acumulador da imagem para ser expressa no final = 100 vezes.
                    }
                    count++; //incremento o laço(while)
                }

                Console.WriteLine();
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 5) + "}" + " ", percentualCarregamento + "% . . ."));
                System.Threading.Thread.Sleep(1500); // tempo(ms) em stand by a cada ciclo do (for)
                percentualCarregamento = random.Next(percentualCarregamento, 101); // estabelece o parametro para sair do laço (for)
            }

            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 4) + "}", "COMPLETO"));
            Console.WriteLine();
            Console.WriteLine(image);

            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 2) + "}" + " ", percentualCarregamento + "%"));
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 9) + "}", "--SEJA BEM VINDO--"));
            System.Threading.Thread.Sleep(2000);

        }

        // -------------------------METODO VALIDAR LOGIN E SENHA---------------------------------------------------------------
        public void ValidaPassword()
        {
            const string codigoGerennte = "ABCdef@#";

            string[] arrayLogin = { "igor", "adan", "mateus", "marlon" };
            string[] arraySenha = { "1", "2", "3", "4" };

            bool liberaSenha = false;
            bool senhaCorreta = false;
            bool loginCorreto = false;
            string login = "";
            string senha = "";

            int i = 0; //contador e comparador do login
            int j = 0; //contador e comparador da senha
            int auxLogin = 0;
            int count = 0;

            while (!loginCorreto) // enquanto o login não for um nome cadastrado, não entra.
            {
                i = 0;
                //Loop para validar login
                try
                {
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 9) + "}", "--FAÇA SEU LOGIN--"));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 25) + "}", "--------------------------------------------------"));
                    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) - 18) + "}", "Login: "));
                    login = Console.ReadLine().ToLower();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 25) + "}", "--------------------------------------------------"));
                    do
                    {
                        if (arrayLogin[i] != login) //se o valor de escrito na posicao [i] for diferente da senha digitada incrementa +1 para percorrer a proima posicao do arrayLogin
                        {
                            i++;
                        }

                        if (arrayLogin[i] == login)
                        {
                            loginCorreto = true;
                            liberaSenha = true;
                            auxLogin = i; //auxiliar de i guarda o ultimo valor de i;
                        }

                    } while (arrayLogin[i] != login);
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 9) + "}", "--FAÇA SEU LOGIN--"));
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) - 5) + "}", "LOGIN Não Cadastrado"));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) - 9) + "}", "-Tente novamente"));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 15) + "}", "-Precione qualquer teclar para continuar"));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }

            }

            while ((count != 3) && (!senhaCorreta)) // enquanto o contador for diferente de 3 e a senha incorreta repete a operação
            {
                //Loop para valizar senha com o senha
                if (liberaSenha)
                {
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 9) + "}", "--FAÇA SEU LOGIN--"));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 25) + "}", "--------------------------------------------------"));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) - 14) + "}", "Login: " + login));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 25) + "}", "--------------------------------------------------"));
                    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) - 18) + "}", "Senha: "));

                    //------------------------------------------BLOCO QUE ESCREVE O CARACTER DE SENHA DE FORMA OCULTA---------------------------------------------------
                    string pass = ""; // pass de password (senha)
                    ConsoleKeyInfo key;
                    do
                    {
                        key = Console.ReadKey(true);

                        // Backspace Should Not Work
                        if ((key.Key != ConsoleKey.Backspace) && (key.Key != ConsoleKey.Delete) && (key.Key != ConsoleKey.Enter))
                        {
                            pass += key.KeyChar;
                            Console.Write("*");
                        }
                        else if (key.Key == ConsoleKey.Backspace || key.Key == ConsoleKey.Delete) //apagar os caracteres digitados no campo senha
                        {
                            Console.Clear();
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 9) + "}", "--FAÇA SEU LOGIN--"));
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 25) + "}", "--------------------------------------------------"));
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) - 14) + "}", "Login: " + login));
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 25) + "}", "--------------------------------------------------"));
                            Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) - 18) + "}", "Senha: "));
                            pass = ""; // pass recebe vazio
                            Console.Write(""); // imprime-se na tela vazio
                        }
                    }
                    while (key.Key != ConsoleKey.Enter);
                    Console.WriteLine();
                    //----------------------------------------FIM DO BLOCO QUE ESCREVE O CARACTER DE SENHA DE FORMA OCULTA----------------------------------------------
                    senha = pass;
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 25) + "}", "--------------------------------------------------"));

                    try
                    {
                        do
                        {
                            if (j != auxLogin) //auxiliar de i
                            {
                                j++;

                                if (j == auxLogin) //se o contador j (contador da senha) = a ultima posição de i (contador do login)
                                {
                                    liberaSenha = true;
                                }

                            }
                            if (j == auxLogin)
                            {

                                if (arraySenha[j] == senha)
                                {
                                    senhaCorreta = true; // senha correta
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 9) + "}", "--FAÇA SEU LOGIN--"));
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 25) + "}", "--------------------------------------------------"));
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) - 5) + "}", "SENHA Não Cadastrado"));
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) - 9) + "}", "-Tente novamente"));
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 15) + "}", "-Precione qualquer teclar para continuar"));
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ReadKey();
                                }
                            }

                        } while (j != auxLogin);
                    }
                    catch
                    {
                        Console.WriteLine("SENHA Não Cadastrado");
                    }
                }
                count++;
            }
            if (senhaCorreta) //se senha está correta, inicia-se o programa
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 60) + "}", "ACESSO LIBERADO                                                    "));
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                System.Threading.Thread.Sleep(3000);

                Class IniciaPrograma = new Class();
                //IniciaPrograma.Load(); //Chama método de carregamento da tela
                IniciaPrograma.MetodoClientes();
                // por aqui, pois ja seta internamente os produtos pre-cadastrados internamente
            }
            else if (!senhaCorreta && loginCorreto)
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 9) + "}", "--FAÇA SEU LOGIN--"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 25) + "}", "--------------------------------------------------"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) - 2) + "}", "DESEJA RECUPERAR SENHA?"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) - 4) + "}", "-Se SIM precione 'S'."));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) - 4) + "}", "-Se NAO precione 'N'."));
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "Precione 'Enter' para confirmar sua opcao"));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 25) + "}", "--------------------------------------------------"));
                Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) - 24) + "}", ""));

                string opcao = Console.ReadLine().ToLower();

                if (opcao == "n") // opção de nao recuperar senha
                {
                    Console.Clear();
                    int leftOffSet = ((Console.WindowWidth / 2) - 42); //Orienta a posição do texto na tela largura
                    int topOffSet = ((Console.WindowHeight / 2) - 12);//Orienta a posição do texto na tela altura
                    Console.SetCursorPosition(leftOffSet, topOffSet);//Seta as posições na tela
                    Console.WriteLine("Para Sair do programa precione 'F12' ou Qualuqer outra tecla para reiniciar o programa");
                }

                else if (opcao == "s") // opção de recuperar senha
                {
                    string resposta = "";
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 25) + "}", "--------------------------------------------------"));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 8) + "}", "--RECUPER SENHA--"));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 25) + "}", "--------------------------------------------------"));
                    Console.WriteLine("-Digite o código padrão de recuperação de senhas fornecido pelo seu gerente: ");
                    Console.Write("--> ");

                    //------------------------------------------BLOCO QUE ESCREVE O CARACTER DE SENHA DE FORMA OCULTA---------------------------------------------------
                    string pass = ""; // pass de password (senha)
                    ConsoleKeyInfo key;
                    do
                    {
                        key = Console.ReadKey(true);

                        if ((key.Key != ConsoleKey.Backspace) && (key.Key != ConsoleKey.Delete) && (key.Key != ConsoleKey.Enter))
                        {
                            pass += key.KeyChar;
                            Console.Write("*");
                        }
                        else if (key.Key == ConsoleKey.Backspace || key.Key == ConsoleKey.Delete) //apagar os caracteres digitados no campo senha
                        {
                            Console.Clear();
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 9) + "}", "--FAÇA SEU LOGIN--"));
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 25) + "}", "--------------------------------------------------"));
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) - 14) + "}", "Login: " + login));
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 25) + "}", "--------------------------------------------------"));
                            Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) - 18) + "}", "Senha: "));
                            pass = ""; // pass recebe vazio
                            Console.Write(""); // imprime-se na tela vazio
                        }
                    }
                    while (key.Key != ConsoleKey.Enter);
                    //----------------------------------------FIM DO BLOCO QUE ESCREVE O CARACTER DE SENHA DE FORMA OCULTA----------------------------------------------
                    Console.WriteLine();
                    resposta = pass;

                    if (resposta == codigoGerennte)
                    {
                        Console.Write("Sua senha é: --> ");
                        Console.Write(arraySenha[auxLogin]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 9) + "}", "\nPrecione 'Enter' para continuar."));
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Código padrão de recuperação de senhas incorreto!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.Clear();
                    int leftOffSet = ((Console.WindowWidth / 2) - 60); //Orienta a posição do texto na tela largura
                    int topOffSet = ((Console.WindowHeight / 2) - 12);//Orienta a posição do texto na tela altura
                    Console.SetCursorPosition(leftOffSet, topOffSet);//Seta as posições na tela
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "Opcao Invalida! Reiniciando..."));
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(2000);
                    Load();
                }
            }
        }

        public void MetodoEstoque(List<Clientes> clientesLista)
        {
            List<Estoque> estoqueLista = new List<Estoque>();
            List<RelatorioVendas> totalVendas = new List<RelatorioVendas>();

            //Criando um objeto Estoque vazio.
            Estoque estoque1 = new Estoque();//estanciar a classe e nao a lista

            // Preenchendo um objeto Estoque
            estoque1.codigo = 0001;
            estoque1.nome = "Nike - Shox";
            estoque1.preço = 650.00;
            estoque1.QtdEstoque = 120;
            estoque1.Inventario = estoque1.preço * estoque1.QtdEstoque;

            Estoque estoque2 = new Estoque();//estanciar a classe e nao a lista
            estoque2.codigo = 0002;
            estoque2.nome = "Adidas - Springblade";
            estoque2.preço = 999.90;
            estoque2.QtdEstoque = 75;
            estoque2.Inventario = estoque2.preço * estoque2.QtdEstoque;

            Estoque estoque3 = new Estoque();//estanciar a classe e nao a lista
            estoque3.codigo = 0003;
            estoque3.nome = "Mizuno - Wave";
            estoque3.preço = 499.99;
            estoque3.QtdEstoque = 92;
            estoque3.Inventario = estoque3.preço * estoque3.QtdEstoque;

            Estoque estoque4 = new Estoque();//estanciar a classe e nao a lista
            estoque4.codigo = 004;
            estoque4.nome = "Puma - Disc";
            estoque4.preço = 749.90;
            estoque4.QtdEstoque = 53;
            estoque4.Inventario = estoque4.preço * estoque4.QtdEstoque;

            Estoque estoque5 = new Estoque();//estanciar a classe e nao a lista
            estoque5.codigo = 005;
            estoque5.nome = "Asics - FuseX";
            estoque5.preço = 499.99;
            estoque5.QtdEstoque = 27;
            estoque5.Inventario = estoque5.preço * estoque5.QtdEstoque;

            Estoque estoque6 = new Estoque();//estanciar a classe e nao a lista
            estoque6.codigo = 006;
            estoque6.nome = "Fila - Lugano 5.0";
            estoque6.preço = 149.99;
            estoque6.QtdEstoque = 1;
            estoque6.Inventario = estoque6.preço * estoque6.QtdEstoque;

            Estoque estoque7 = new Estoque();//estanciar a classe e nao a lista
            estoque7.codigo = 007;
            estoque7.nome = "Converse - All Star Ct Core";
            estoque7.preço = 119.99;
            estoque7.QtdEstoque = 84;
            estoque7.Inventario = estoque7.preço * estoque7.QtdEstoque;

            estoqueLista.Add(estoque1); //adicionar na lista os dados
            estoqueLista.Add(estoque2); //adicionar na lista os dados
            estoqueLista.Add(estoque3); //adicionar na lista os dados
            estoqueLista.Add(estoque4); //adicionar na lista os dados
            estoqueLista.Add(estoque5); //adicionar na lista os dados
            estoqueLista.Add(estoque6); //adicionar na lista os dados
            estoqueLista.Add(estoque7); //adicionar na lista os dados

            estoque1.Inventario = estoque1.preço * estoque1.QtdEstoque; //adicionar na lista do inventário
            estoque2.Inventario = estoque2.preço * estoque2.QtdEstoque; //adicionar na lista do inventário
            estoque3.Inventario = estoque3.preço * estoque3.QtdEstoque; //adicionar na lista do inventário
            estoque4.Inventario = estoque4.preço * estoque4.QtdEstoque; //adicionar na lista do inventário
            estoque5.Inventario = estoque5.preço * estoque5.QtdEstoque; //adicionar na lista do inventário
            estoque6.Inventario = estoque6.preço * estoque6.QtdEstoque; //adicionar na lista do inventário
            estoque7.Inventario = estoque7.preço * estoque7.QtdEstoque; //adicionar na lista do inventário

            Menu(estoqueLista, clientesLista, totalVendas);//chama o método de Menu
        }

        // MENU--------------------------------------------------------------------------------------------------
        static void Menu(List<Estoque> lista1, List<Clientes> listaClientes, List<RelatorioVendas> totalVendas)
        {

            bool condicao = true;
            do
            {

                Console.Clear();
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "-             MENU             -"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
                Console.WriteLine("\n\n");

                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "................................"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "|F1: Ajuda                     |"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "|..............................|"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "|F2: Cadastro de Clientes      |"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "|..............................|"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "|F3: Consulta de Clientes      |"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "|..............................|"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "|F5: Consulta de Estoque       |"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "|..............................|"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "|F6: Vendas de Produtos        |"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "|..............................|"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "|F7: Relatório de Vendas       |"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "|..............................|"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "|F12: Sair                     |"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "|..............................|"));

                ConsoleKeyInfo tecla = Console.ReadKey();

                if (tecla.Key == ConsoleKey.F1)
                {

                    MetodoAjuda ajuda = new MetodoAjuda();

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    ajuda.Ajuda();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else if (tecla.Key == ConsoleKey.F2)
                {
                    CadastroCliente(ref listaClientes);
                }

                else if (tecla.Key == ConsoleKey.F3)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    ConsultarClientes(ref listaClientes);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else if (tecla.Key == ConsoleKey.F5)
                {
                    MenuEstoque(lista1, listaClientes);
                }

                else if (tecla.Key == ConsoleKey.F6)
                {
                    Vendas(ref lista1, listaClientes, totalVendas);
                    Menu(lista1, listaClientes, totalVendas);
                }

                else if (tecla.Key == ConsoleKey.F7)
                {

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;

                    ConsultaTotalVendas(ref totalVendas);

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else if (tecla.Key == ConsoleKey.F12)
                {
                    condicao = false;
                    Console.Clear();
                    if (!condicao)
                    {
                        int leftOffSet = ((Console.WindowWidth / 2) - 17); //Orienta a posição do texto na tela largura
                        int topOffSet = ((Console.WindowHeight / 2) - 12);//Orienta a posição do texto na tela altura
                        Console.SetCursorPosition(leftOffSet, topOffSet);//Seta as posições na tela
                        Console.Write("Precione 'F12' novamente para Sair!");
                    }
                }

            } while (condicao); //Enquanto a condicao é verdadeira, menu fica em loop
        }

        static List<Estoque> op1(ref List<Estoque> estoqueLista)
        {

            Estoque estoque = new Estoque();//estanciar a classe
            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "-     CADASTRO DE PRODUTOS     -"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 19) + "}", "......................................"));
            Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + 8) + "}", "Digite O Codigo do produto:"));
            estoque.codigo = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 19) + "}", "......................................"));
            Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + 7) + "}", "Digite o nome do produto: "));
            estoque.nome = Console.ReadLine();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 19) + "}", "......................................"));
            Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + 8) + "}", "Digite o preço do produto :"));
            estoque.preço = double.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 19) + "}", "......................................"));
            Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + 18) + "}", "Digite a quantidade a ser cadastrada:"));
            estoque.QtdEstoque = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 19) + "}", "......................................"));
            estoque.Inventario = estoque.preço * estoque.QtdEstoque;

            estoqueLista.Add(estoque); //adicionar na lista os dados
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n");
            Console.WriteLine("PRODUTO CADASTRADO COM SUCESSO\n\n");
            Console.WriteLine("QUANTIDADE DE PRODUTOS CADASTRADAS <{0}>", estoqueLista.Count);
            Console.WriteLine("PRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU PRINCIPAL");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            return estoqueLista;

        }

        static List<Estoque> op2(ref List<Estoque> estoqueLista)
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "-       ESTOQUE FOOTSHOES      -"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            Console.Write("\n");
            foreach (Estoque x in estoqueLista)
            {

                Console.WriteLine("......................................");
                Console.WriteLine("CODIGO: " + x.codigo + "              ");

                Console.WriteLine("NOME: " + x.nome + "                  ");

                Console.WriteLine("PREÇO: " + x.preço + "                ");

                Console.WriteLine("QUANTIDADE EM ESTOQUE: " + x.QtdEstoque);
                Console.WriteLine("======================================");
                Console.WriteLine();
            }
            Console.ReadKey();
            return estoqueLista;
        }

        static int Procura(ref List<Estoque> estoqueLista, int achou)
        {
            int pos = -1;
            foreach (var x in estoqueLista)
            {
                if (x.codigo == achou)
                {
                    pos = estoqueLista.IndexOf(x);
                }
            }
            return pos;
        }
        static void op3(ref List<Estoque> estoqueLista)
        {
            Estoque estoque = new Estoque();
            int xcodigo;
            int pos;

            Console.Clear();
            Console.WriteLine("Digite o codigo do produto a ser excluido :");
            xcodigo = int.Parse(Console.ReadLine());
            pos = Procura(ref estoqueLista, xcodigo);

            if (pos != -1)
            {
                estoqueLista[pos].QtdEstoque--;
                Console.Write("Quantidade restante em estoque {0} ", estoqueLista[pos].QtdEstoque);

                Console.WriteLine("\n\n");
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "- PRODUTO REMOVIDO COM SUCESSO -"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));

            }
            else
            {
                Console.WriteLine("PRODUTO NAO CONFERE....");
            }
            estoque.Inventario = estoque.preço * estoque.QtdEstoque;
            Console.ReadKey();
        }
        static void op4(ref List<Estoque> estoqueLista)
        {
            Estoque estoque;
            int xcodigo, pos;

            Console.Clear();

            Console.WriteLine("Digite o codigo do produto a ser modificado :");
            xcodigo = int.Parse(Console.ReadLine());

            pos = Procura(ref estoqueLista, xcodigo);

            if (pos != -1)
            {
                estoque = estoqueLista.ElementAt(pos);

                Console.Write("Digite o novo codigo :");
                estoque.codigo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o novo Nome : ");
                estoque.nome = Console.ReadLine();

                Console.Write("Digite o novo preço :");
                estoque.preço = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Registro alterado com sucesso !!");
                Console.ReadKey();
            }
        }
        static void ExcluirProduto(ref List<Estoque> estoqueLista)
        {
            Estoque estoque = new Estoque();
            int xcodigo;
            int pos;

            Console.Clear();
            Console.WriteLine("Digite o codigo do produto a ser excluido :");
            xcodigo = int.Parse(Console.ReadLine());
            pos = Procura(ref estoqueLista, xcodigo);
            if (pos != -1)
            {
                estoqueLista.RemoveAt(pos);
                Console.WriteLine("\n\n");
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "- PRODUTO REMOVIDO COM SUCESSO -"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            }
            else
            {
                Console.WriteLine("PRODUTO NAO CONFERE....");
            }
            estoque.Inventario = estoque.preço * estoque.QtdEstoque;
            Console.ReadKey();
        }
        static void AdicionarQuantidade(ref List<Estoque> estoqueLista)
        {
            Estoque estoque = new Estoque();
            int xcodigo;
            int pos;

            Console.Clear();
            Console.WriteLine("Digite o codigo do produto a ser acresentado :");
            xcodigo = int.Parse(Console.ReadLine());

            pos = Procura(ref estoqueLista, xcodigo);


            if (pos != -1)
            {
                estoqueLista[pos].QtdEstoque++;
                Console.Write("Quantidade atualizada em estoque {0} ", estoqueLista[pos].QtdEstoque);

                Console.WriteLine("\n\n");
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "-PRODUTO ADICIONADO COM SUCESSO-"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));

            }
            else
            {
                Console.WriteLine("PRODUTO NAO CONFERE....");
            }

            estoque.Inventario = estoque.preço * estoque.QtdEstoque;
            Console.ReadKey();
        }
        static void Inventario(ref List<Estoque> estoqueLista)
        {
            Console.Clear();
            double total = 0;

            foreach (Estoque x in estoqueLista)
            {
                if (estoqueLista.Count >= 1)
                {
                    total = total + x.Inventario;
                }
            }

            Console.WriteLine("Inventario : R${0}", total);
            Console.ReadKey();
        }

        //MOSTRAR CLIENTES
        public void MetodoClientes()
        {
            //Criando uma lista do tipo Estoque
            List<Clientes> cadastroCliente = new List<Clientes>();

            //Criando um objeto Estoque vazio.
            Clientes estoque1 = new Clientes();//estanciar a classe e nao a lista

            // Preenchendo um objeto Estoque
            estoque1.nome = "Luiz";
            estoque1.cpf = "771.509.188-08";
            estoque1.cidade = "Belo Horizonte";

            Clientes estoque2 = new Clientes();//estanciar a classe e nao a lista
            estoque2.nome = "Joao";
            estoque2.cpf = "123.123.123-06";
            estoque2.cidade = "São Paulo";

            Clientes estoque3 = new Clientes();//estanciar a classe e nao a lista
            estoque3.nome = "Maria";
            estoque3.cpf = "312.312.876-10";
            estoque3.cidade = "Rio de Janeiro";

            Clientes estoque4 = new Clientes();//estanciar a classe e nao a lista
            estoque4.nome = "Walber";
            estoque4.cpf = "987.479.084-00";
            estoque4.cidade = "Jundiai";

            Clientes estoque5 = new Clientes();//estanciar a classe e nao a lista
            estoque5.nome = "Lucas";
            estoque5.cpf = "767.495.098-01";
            estoque5.cidade = "Belo Horizonte";

            cadastroCliente.Add(estoque1); //adicionar na lista os dados
            cadastroCliente.Add(estoque2); //adicionar na lista os dados
            cadastroCliente.Add(estoque3); //adicionar na lista os dados
            cadastroCliente.Add(estoque4); //adicionar na lista os dados
            cadastroCliente.Add(estoque5); //adicionar na lista os dados

            MetodoEstoque(cadastroCliente);
        }

        static List<Clientes> ConsultarClientes(ref List<Clientes> clientesLista)
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "-           CLIENTES           -"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            Console.Write("\n");
            foreach (Clientes x in clientesLista)
            {
                Console.WriteLine("CPF - {0}\nNOME - {1}\nCIDADE - {2}\n====================================\n", x.cpf, x.nome, x.cidade);
            }
            Console.ReadKey();
            return clientesLista;

        }

        static List<Clientes> CadastroCliente(ref List<Clientes> clienteLista)
        {
            Clientes cliente = new Clientes();//estanciar a classe
            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "-     CADASTRO DE CLIENTES     -"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            Console.WriteLine();

            ValidaCpf verificar = new ValidaCpf();


            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 19) + "}", "......................................"));
            Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + 6) + "}", "Digite o CPF do cliente: "));
            string cpf = Console.ReadLine();
            try
            {
                if ((verificar.validarCPF(cpf)))
                {
                    cliente.cpf = cpf;
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 19) + "}", "......................................"));
                    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + 7) + "}", "Digite o nome do cliente: "));
                    cliente.nome = Console.ReadLine();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 19) + "}", "......................................"));
                    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + 6) + "}", "Digite o nome da cidade: "));
                    cliente.cidade = Console.ReadLine();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 19) + "}", "......................................"));

                    clienteLista.Add(cliente); //adicionar na lista os dados

                    Console.WriteLine("\n\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Cliente cadastrado com Sucesso\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("QUANTIDADE DE CLIENTES CADASTRADAS <{0}>", clienteLista.Count);
                    Console.WriteLine("PRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU PRINCIPAL");
                    Console.ReadKey();

                    return clienteLista;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 15) + "}", "CPF inválido! tente novamente!"));
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(2000);

                }
            }

            catch

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 15) + "}", "CPF inválido! tente novamente!"));
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(2000);

            }
            return clienteLista;

        }

        static void MenuEstoque(List<Estoque> lista1, List<Clientes> clientesLista)
        {
            //Clientes clientesLista = new Clientes();//estanciar a classe
            List<RelatorioVendas> totalVendas = new List<RelatorioVendas>();

            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "-       ESTOQUE FOOTSHOES      -"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            Console.WriteLine("\n\n");
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "........................................"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|A: Cadastrar produto                  |"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|......................................|"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|B: Mostrar ESTOQUE                    |"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|......................................|"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|C: Excluir Quantidade do produto      |"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|......................................|"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|D: Alterar cadastro de itens          |"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|......................................|"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|E: Excluir produto do sistema         |"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|......................................|"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|F: Acresentar quantidade de um produto|"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|......................................|"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|G: Inventario ESTOQUE                 |"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|......................................|"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|F12: Sair                             |"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "|......................................|"));

            ConsoleKeyInfo op;
            op = Console.ReadKey(true);

            switch (op.Key)
            {
                case ConsoleKey.A://cadastro produto
                    op1(ref lista1);
                    MenuEstoque(lista1, clientesLista);
                    break;
                case ConsoleKey.B://mostrar o estoque

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;

                    op2(ref lista1);


                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    MenuEstoque(lista1, clientesLista);
                    break;
                case ConsoleKey.C://excluir produto
                    op3(ref lista1);
                    MenuEstoque(lista1, clientesLista);
                    break;
                case ConsoleKey.D://alterar cadastro de produto
                    op4(ref lista1);
                    MenuEstoque(lista1, clientesLista);
                    break;
                case ConsoleKey.E://excluir produto
                    ExcluirProduto(ref lista1);
                    MenuEstoque(lista1, clientesLista);
                    break;
                case ConsoleKey.F:///add qtd de produto em estoque
                    AdicionarQuantidade(ref lista1);
                    MenuEstoque(lista1, clientesLista);
                    break;
                case ConsoleKey.G:// inventário
                    Inventario(ref lista1);
                    MenuEstoque(lista1, clientesLista);
                    break;
                case ConsoleKey.F12:// inventário
                    Menu(lista1, clientesLista, totalVendas);
                    break;
                default:
                    MenuEstoque(lista1, clientesLista);
                    break;
            }
        }

        static void Vendas(ref List<Estoque> estoqueLista, List<Clientes> listaClientes, List<RelatorioVendas> totalVendas)
        {
            Estoque estoque;
            int xcodigo, pos;

            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "-       VENDA DE PRODUTOS      -"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 21) + "}", ".........................................."));
            Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + 21) + "}", "Digite o codigo do produto a ser vendido: "));
            xcodigo = Convert.ToInt32(Console.ReadLine());

            pos = Procura(ref estoqueLista, xcodigo);

            if (pos != -1)
            {
                estoque = estoqueLista.ElementAt(pos);


                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 21) + "}", ".........................................."));
                Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + 8) + "}", "Digite a quantidade vendida: "));
                int qtdVendido = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 21) + "}", ".........................................."));

                estoque.QtdEstoque = (estoque.QtdEstoque - qtdVendido); // calculo de venda dos produtos
                double total = (qtdVendido * estoque.preço);

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Voce vendeu: " + qtdVendido + " | " + estoque.nome + " num valor de: R$" + estoque.preço + " cada.");
                Console.WriteLine();
                Console.WriteLine("TOTAL DA VENDA: R$" + total + "");

                estoqueLista.Add(estoque); //adicionar na lista os dados

                RelatorioVendas vendido = new RelatorioVendas();//estanciar a classe
                vendido.codigo = xcodigo;
                vendido.QtdEstoque = estoque.QtdEstoque;
                vendido.QtdVendido = qtdVendido;
                vendido.nome = estoque.nome;
                vendido.preço = estoque.preço;
                vendido.Inventario = total;
                totalVendas.Add(vendido); //adicionar na lista os dados

                Console.ReadKey();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 20) + "}", "Codigo nao encontrado na base de dados!!"));
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(3000);
            }

        }
        static List<RelatorioVendas> ConsultaTotalVendas(ref List<RelatorioVendas> totalVendas)
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "-       RELATORIO VENDAS       -"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            Console.Write("\n");
            foreach (RelatorioVendas x in totalVendas)
            {

                Console.WriteLine("......................................");
                Console.WriteLine("CODIGO: " + x.codigo + "              ");

                Console.WriteLine("NOME: " + x.nome + "                  ");

                Console.WriteLine("PREÇO: " + x.preço + "                ");

                Console.WriteLine("QUANTIDADE EM ESTOQUE: " + x.QtdEstoque);

                Console.WriteLine("QUANTIDADE VENDIDA: " + x.QtdVendido);

                Console.WriteLine("TOTAL: " + x.Inventario + "            ");

                Console.WriteLine("======================================");
                Console.WriteLine();
            }


            Console.ReadKey();
            return totalVendas;
        }


    }
}