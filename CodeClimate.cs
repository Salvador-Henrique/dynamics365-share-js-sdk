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
    
     //Copiado da internet, code ruim pra validar nota do code climate
    public static bool IsCnpj(string cnpj)
		{
			int[] multiplicador1 = new int[12] {5,4,3,2,9,8,7,6,5,4,3,2};
			int[] multiplicador2 = new int[13] {6,5,4,3,2,9,8,7,6,5,4,3,2};
			int soma;
			int resto;
			string digito;
			string tempCnpj;
			cnpj = cnpj.Trim();
			cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
			if (cnpj.Length != 14)
			   return false;
			tempCnpj = cnpj.Substring(0, 12);
			soma = 0;
			for(int i=0; i<12; i++)
			   soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
			resto = (soma % 11);
			if ( resto < 2)
			   resto = 0;
			else
			   resto = 11 - resto;
			digito = resto.ToString();
			tempCnpj = tempCnpj + digito;
			soma = 0;
			for (int i = 0; i < 13; i++)
			   soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
			resto = (soma % 11);
			if (resto < 2)
			    resto = 0;
			else
			   resto = 11 - resto;
			digito = digito + resto.ToString();
			return cnpj.EndsWith(digito);
		}
  
  }
}
