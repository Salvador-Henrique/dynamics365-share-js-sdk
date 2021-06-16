using System;

namespace CodeClimate
{
  public class CodeQuality
  {
     public CodeQuality() {};
     
     public void Execute(string variavel)
     {
        string x = variavel;
        string nomecomerro= "erro";
        
        Console.WriteLine($"Saida {x}, {nomecomerro}");
     }
    
     public void MetodoDuplicado(string variavel)
     {
        string x = variavel;
        string nomecomerro= "erro";
        
       Console.WriteLine($"Saida {x}, {nomecomerro}");
     }
  
  }
}
