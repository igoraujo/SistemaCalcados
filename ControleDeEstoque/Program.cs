using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            //este bloco estabelece o tamanho do console
            Console.SetWindowSize(120, 30);// tamanho da tela
            Console.BufferHeight = 120; // buffer da tela
            Console.BufferWidth = 9001;// buffer da tela
            //------------------------------------------  

            Class classe = new Class();
            classe.Load(); // chama classe de carregamento da tela
            bool pararProgram = false;
            int leftOffSet = ((Console.WindowWidth / 2) - 27); //Orienta a posição do texto na tela largura
            int topOffSet = ((Console.WindowHeight / 2) - 12);//Orienta a posição do texto na tela altura
            Console.SetCursorPosition(leftOffSet, topOffSet);//Seta as posições na tela
            Console.Write("Precione Qualquer tecla para iniciar ou 'F12' para Sair");


            while (!pararProgram)
            {
                ConsoleKeyInfo tecla = Console.ReadKey();
                Console.Clear();
                if (tecla.Key != ConsoleKey.F12)
                {
                    classe.ValidaPassword(); //Chama classe de validar senha
                }
                else
                {
                    pararProgram = true;
                }
            }
        }
    }
}

