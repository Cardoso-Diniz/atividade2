using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string nomePessoa = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());

           if (idade >=16)

           {
            Console.WriteLine("PARABÉNS, você possui a idade necessaria");
           }
           else
           {
               Console.WriteLine("Você não possui a idotnedade necessaria, você estará acompanhado com alguém maior de 18 anos sim/não?");
               string resposta = Console.ReadLine().ToLower();

               switch (resposta)
             {
                case "sim":
                Console.WriteLine($"Então vocÊ pode participar,porém esteja acompanhando");
                
                break;

                case "não":
                Console.WriteLine($"Você não pode participar!!");
                break;     

                default:
                break;
              }
            }
            {   
                }  
        }
    }
}
