﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_Alyson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            string senha = "";
            Console.WriteLine("Informe uma senha: ");
            senha = Console.ReadLine();

            while (true)
            {
                
                if (!String.IsNullOrEmpty(senha))
                {
                    Console.Clear();

                    Console.WriteLine("----------------PAINEL------------------");
                    Console.WriteLine("1---------------ALTERAR SENHA-----------");
                    Console.WriteLine("2---------------FECHAR------------------");

                    string opcao = Console.ReadLine();
                    Console.Clear();


                    if (opcao != null && opcao != "2")
                    {
                        Console.WriteLine("Informe a Antiga Senha: ");
                        string old = Console.ReadLine();

                        

                        if(old != senha)
                        {
                            Console.WriteLine("Senha Antiga Incorreta.");
                        }
                        else
                        {
                            Console.WriteLine("Informe a Nova Senha: ");
                            string new1 = Console.ReadLine();

                            Console.WriteLine("Informe a Nova Senha Outra vez: ");
                            string new2 = Console.ReadLine();

                            if(new1 != new2)
                            {
                                Console.WriteLine("Nova Senha não condiz.");
                            }

                            senha = new1;
                        }

                    }

                    break;
                }
            }
            /*

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite a Senha padrão: ");
                string senhapadrao = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("----------------PAINEL------------------");
                Console.WriteLine("1------------ALTERAR SENHA--------------");
                Console.WriteLine("2---------------FECHAR------------------");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {

                    Console.WriteLine("Para redefinir a senha digite a sua senha anterior: ");
                    string senhadigitada1 = Console.ReadLine();
                    Console.Clear();
                    if (senhapadrao == senhadigitada1)
                    {
                        Console.WriteLine("Digite a nova senha: ");
                        string novasenha = Console.ReadLine();
                        Console.WriteLine("Confirme a senha nova: ");
                        string novasenha1 = Console.ReadLine();
                        if (novasenha == novasenha1)
                        {
                            Console.Clear();
                            Console.WriteLine("Senha Redefinida com sucesso! ");
                            senhapadrao = novasenha;
                            Console.WriteLine("Nova senha: " + senhapadrao);
                        }
                        else
                        {
                            Console.WriteLine("Senhas não conferem.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Senha Incorreta! ");
                    }

                    Console.WriteLine("Senha atual: " + senhapadrao);
                }
                else
                {
                    break;
                }
            }
            */
            
        }
    }
}


/*
 * 
 
  class Item
        {
            public int id;
            public string name;
            public int qtd;

            public Item(int id, string name, int qtd)
            {
                this.id = id;
                this.name = name;
                this.qtd = qtd;
            }
        }
  
  
  
  
 * 
            Console.WriteLine(Somar(1, 10));
            int a = 1;
            string b = "palavra";
            bool c = false;
            float d = 1.0f;
            decimal e = (decimal)3.17;
            int[] numero = { 1, 2, 3, 4 };
            int[,] matriz = new int[3, 3];
            int[,,] matrizmult = {
            {
                { 1, 2, 3 },
                { 2, 3, 4 },
                { 2, 2, 2 }
            },
            {
                { 1, 2, 3 },
                { 2, 3, 4 },
                { 2, 2, 2 }
            } };
            CTRL K + C PARA COMENTAR TUDO 

 List<Item> itens = new List<Item>();
            {

                new Item(1, "Arroz", 20); //CRIA A LISTA E JÁ ADICIONANDO OBJETOS NELA.

            };

            itens.Add(new Item(1, "Bolacha", 10)); // ADICIONA OBJETOS APÓS A LISTA TER SIDO CRIADA.
            itens.Add(new Item(2, "Queijo", 4));
            itens.Add(new Item(3, "Miojo", 7));

            int[] numeros = new int[5];

            for (int i = 0; i < itens.Count; i++)
            {
                Console.WriteLine("Quantidade: " + itens[i].qtd);
            }

            //itens.Clear(); LIMPA TODA A LISTA
            //itens.AddRange(); ADICIONA UMA LISTA DENTRO DE OUTRA LISTA
            //itens.RemoveAt(0); REMOVE UM OBJETO DENTRO DA LISTA UTILIZANDO O SEU ÍNDICE

            foreach (var item in itens)
            {
                Console.WriteLine($"Nome do produto: {item.name}");
            }

         static int Somar(int a, int b)
        {
            return a + b;
        }

        }
 
 
 */
