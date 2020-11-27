using System;

namespace SistemaDeLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomesUser = new string [5];
            string[] passwordUser = new string [5];
            string[] emailUser = new string [5];
            string[] login = new string[5];
            string[] senha = new string[5];
            int i = 0; //cont
            int escolha = 0;

            Console.WriteLine("-----Sistema de Autenticação de Usuários-----");
            do
            {
                Console.Write("Digite seu username: ");
                login[i] = Console.ReadLine();
                Console.Write("Digite sua senha: ");
                senha[i] = Console.ReadLine();
                LoginADM(login[i], senha[i]);
            } while (login[i] != nomesUser[i] || senha[i] != passwordUser[i] || escolha == 0);
            


            void LoginADM(string login, string senha){
                if(login == "admin" && senha == "admin1234"){
                    Console.WriteLine("Bem Vindo Administrador!");
                    int cont = 0;
                    
                    do
                    {
                        Console.WriteLine("Menu Inicial");
                        Console.WriteLine("Selecione uma opção:");
                        Console.WriteLine("[1] - Cadastrar usuários");
                        Console.WriteLine("[2] - Listar Passagens");
                        Console.WriteLine("[0] - Sair");
                        escolha = int.Parse(Console.ReadLine());
                        switch (escolha)
                        {
                            case 1:
                            //Cadastro de Passagem
                            string resposta;
                            
                                do
                                {
                                    if (i < 5)
                                    {
                                        Console.Write($"Digite o nome do {i+1}° Usuário: ");
                                        nomesUser[i] = Console.ReadLine();
                                        
                                        Console.Write($"Digite e-mail do {i+1}° Usuário: ");
                                        emailUser[i] = Console.ReadLine();
                                        Console.Write($"Digite a senha do {i+1}° usuário: ");
                                        passwordUser[i] = Console.ReadLine();
                                        i++;
                                    }else{
                                    Console.WriteLine("Limite de usuários excedido"); 
                                    break;
                                    }
            
                                    

                                    Console.WriteLine("Gostaria de cadastrar um novo passageiro? (s/n)");
                                    resposta = Console.ReadLine();
                                }while(resposta == "s");
                                break;
                            case 2:
                            //Listar Passagens
                                for (cont = 0; cont < 5; cont++)
                                {
                                    Console.WriteLine($"Usuário: {nomesUser[cont]}");
                                    Console.WriteLine($"E-mail: {emailUser[cont]}");
                                    Console.WriteLine("----------------------------------------------");
                                }
                                break;
                            case 0:
                            //Sair
                                Console.WriteLine("Obrigado, Volte sempre!");
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");
                                break;
                        }
                

                    } while (escolha != 0);
                   
                }else{
                    Console.WriteLine("Perfil não cadastrado!");
                
            }
                

        }
    }
}}
