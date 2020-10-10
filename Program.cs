using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            string Usuário;
            
            DateTime horarioAtualDoSistema;

            horarioAtualDoSistema = DateTime.Now;

            Console.Write("Digite seu nome:");
            Usuário = Console.ReadLine();

            Console.WriteLine($"Olá {Usuário}\nA Sua Data e Horário Atual é!: \n{horarioAtualDoSistema}");
        
            


            
        }
    }
}
