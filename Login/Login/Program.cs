using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Login
{
    class Program
    {
        class beolvas
        {
            public string Felhasznalo { get; set; }
            public string Jelszo { get; set; }

            public beolvas(string ell)
            {
                var be = ell.Split(';');
                Felhasznalo = be[0];
                Jelszo = be[1];
            }
        }
        static void Main(string[] args)
        {
            
            if (File.Exists("Login.txt"))
            {
                var sr = new StreamReader("Login.txt");
                var lista = new List<beolvas>();
                while (!sr.EndOfStream)
                {
                    lista.Add(new beolvas(sr.ReadLine()));
                }
                
                
            }

            Console.WriteLine("Add meg a felhasználó nevet.");
            Console.ReadLine();
            string felh = Console.ReadLine();
            Console.WriteLine("Add meg a jelszavadat.");
            string fjelsz = Console.ReadLine();
            for (int i = 0; i < Lista.Count; i++)
            {

            }
            if (felh==)
            {
                if (fjelsz==)
                {
                    Console.WriteLine("Sikeres bejelentkezés");
                }
            }
            else
            {
                Console.WriteLine("Hibás felhasználó név vagy jelszó!");
            }
      
        }
    }
}
