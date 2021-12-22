using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_variavel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname = "Ana ";
            string lastname = "Oliveira";
            string fullname = firstname + lastname;
            int age = 23;

            Console.WriteLine("\n Meu nome completo é {0}", fullname + ". \n"
                + "\n Minha idade é {0}", age
                );
            //dont use a lot of lines with code if you can do it better
        }
    }
}
