using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReader {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Mensagem que vai para o terminal");
            TextReader leitor = Console.In;
            string linha = leitor.ReadLine();
            while (linha != null) {
                
                linha = leitor.ReadLine();
            }
        }
    }
}
