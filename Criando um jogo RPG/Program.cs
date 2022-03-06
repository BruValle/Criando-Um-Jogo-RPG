using System;
using Testando_Dotnet.src.Entidades;

namespace Testando_Dotnet
{
    class program
    {
        static void Main(string[] args)
        {
          Knight Knight = new Knight("Arus", 23, "Knight", 231 );
          Ninja Ninja = new Ninja ("Wedge", 52, "Ninja", 683);
          Wizard Wizard = new Wizard ("Jenica", 32, "White Wizard",463);
          BlackWizard BlackWizard = new BlackWizard ("Topapa", 72, "Black Wizard", 893);


          Console.WriteLine(Knight.Attack());
          Console.WriteLine(Wizard.Attack());
          Console.WriteLine(Ninja.Attack());
          Console.WriteLine(BlackWizard.Attack());
          
        }
    }
}