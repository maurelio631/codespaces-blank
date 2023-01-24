﻿using System;

namespace EditorDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Seja bem-vindo ao seu editor de texto!!");
            Console.WriteLine("");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");

            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {

        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite o texto desejado (ESC para sair do modo de edição)");
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
                Console.Write(texto);
        }
        
        static void Salvar(string texto){
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            
            var caminho = Console.ReadLine();

            using(StreamWriter arquivo = new StreamWriter(caminho)){
                arquivo.Write(texto);
            }
        }
    }
}