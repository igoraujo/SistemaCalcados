using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    class MetodoAjuda
    {
        public void Ajuda()
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "-             AJUDA            -"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 16) + "}", "================================"));
            string texto = @"Manual

1.0 – O programa se inicia a partir da digitação de qualquer tecla por parte do usuário

que estará operando, desta forma, pressione qualquer tecla para INICIAR, ou a

tecla F12 para sair.

2.0 - Nesta tela se encontra o espaço para acesso a ferramenta, sendo necessário a

informação das credencias de acesso para prosseguir.

2.1 – No campo “Login”, deve ser informado o dado que identifica o usuário

perante o programa.

2.2 - No campo “Senha”, deve ser informado o código que valida o acesso do

                usuário perante o programa.

                Obs.Todas as credencias de acesso ao “Monitor” devem ser solicitadas ao fornecedor

               para disponibilização ao usuário, respeitando o prazo acordado com a empresa para

envio.

3.0 – O “MENU” ou “Menu Principal” possui diversas opções que irá guiar o usuário

na etapa do processo que ele deseja realizar. As opções são: “Ajuda”, “Cadastro de

Cliente”, “Consulta de Clientes”, “Consulta de Estoque”, “Vendas de Produtos” e

“Relatório de Vendas”.

3.1 – Teclando o botão F1, o usuário será redirecionado ao Menu “Ajuda”,

obtendo informações que podem ser pertinentes na utilização da ferramenta

o dúvidas deste processo.

3.2 - Com o botão F2, o usuário será redirecionado a tela de “Cadastro de

Clientes”, caso ele pressione o botão F10, sua ação de cadastro prosseguirá,

mas caso ele tecle F9 o usuária será transportado novamente ao MENU.

3.2.1 – Três informações serão cobradas do usuário para o cadastro de

clientes, estas são CPF, NOME e CIDADE.Caso o CPF

informado seja inválido, será exibido uma mensagem

proporcionando ao usuário iniciar novamente um cadastro ou

retornar ao MENU. Ao término, todos os Cadastros executado

serão informados através de uma ficha ao usuário, retornando ao

MENU.

3.3 – Pressionando a tecla F3, é possível acessar todo o banco de cliente

cadastrados atualmente no sistema “Monitor”

3.4 - O botão F5 irá direcionar o cliente ao sub menu “Consulta de Estoques”.

3.4.1 – Pressionando a opção “A”, o usuário poderá cadastrar novos

produtos em sua loja.Os dados necessários são: “Código do

                Produto”, “O nome do Produto”, “O preço do produto” e “A

                quantidade a ser cadastrada”.

3.4.2 – Pressionando a opção “B”, o usuário obterá uma ficha

atualizada com todos os calçados cadastrados em seu sistema.

3.4.3 – Pressionando a opção “C”, o usuário terá acesso a exclusão de

suas mercadorias cadastradas, mas para isso, ele precisa de um

código em mãos.

3.4.4 - Pressionando a opção “D”, o usuário terá acesso a Alteração

nos itens cadastrados.Para isso, ele precisa de um código em

mãos.

3.4.5 - Pressionando a opção “E”, o usuário terá acesso a exclusão de

produtos já cadastrados em seus sistema, mas para isso, ele

precisa de um código em mãos.

3.4.6 – Pressionando a Letra “F”, o usuário terá a possibilidade de

adicionar uma mercadoria ao estoque do produto.Para isso, ele

precisa do Código do produto em mãos.

3.4.7 – Pressionando a Letra “G”, o usuário terá acesso ao inventário,

podendo obter em tempo real o valor acumulado de todas as

suas mercadorias.

3.4.8 – Pressionando a tecla F12, o usuário retornará ao MENU.";
            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}