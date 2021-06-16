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
       
       //Validar Code QA complexidade
       if (x == variavel) variavel = nomecomerro;
       else if (nomecomerro == x) nomecomerro = x;
       else if (x == variavel && x == nomecomerro) x = string.empty;
       else 
         x = "nobody";
        
       Console.WriteLine($"Saida {x}, {nomecomerro}");
     }
  
  }
}
