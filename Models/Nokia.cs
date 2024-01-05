using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
 
    public class Nokia : Smartphone
        {
            
        } 
   
    public override void InstalarAplicativo(string NomeApp )
       {
            Console.WriteLine($"Instalando o aplicativo {NomeApp} no Nokia");
       }
    }
}