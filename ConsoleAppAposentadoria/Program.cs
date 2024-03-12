using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAposentadoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anos de serviço: ");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Idade do funcionario: ");
            int idade = int.Parse(Console.ReadLine());

            if ( anos >= 30 || idade >= 65 || idade >= 60 && anos >=25)
            {
                Console.WriteLine("Tem direito a aposentadoria");
            }
            else 
            {
                Console.WriteLine("Não tem direito a aposentadoria");
            }
            Console.ReadKey();
        }
    }
}
