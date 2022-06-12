using System;
using ProjetoRPG;
using ProjetoRPG.src.Entities;

namespace PROJETORPG
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            Knigth arus = new Knigth("Arus", 469, 42, "Knight");
            Wizard jennica = new Wizard("Jennica", 325, 42, "Wizard");
            Ninja wedze = new Ninja("Wedze", 292, 42, "Ninja");

            Console.WriteLine(arus.Attack("Jessica",5));
            Console.WriteLine(jennica.Attack("Arus",6));
            Console.WriteLine(wedze.Attack("Arus",7));

        }
        
    }

}