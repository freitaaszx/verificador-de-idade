using System ;
 namespace Verificador;
 public class Program
{
    public static void Main()
    {
        Console.WriteLine ("-------VERIFICADOR DE IDADE-----------") ; 


        Console.WriteLine("\n Qual é a seu nome: ") ;
        string nome= Console.ReadLine() ;  
        Console.WriteLine("\n Qual é a sua idade?") ; 
        int idade= Convert.ToInt32 (Console.ReadLine()) ; 

        // Condições 
        if (idade >= 18 )
        {
            Console.WriteLine ("\n Olá" + nome +  "Você pode se alistar.") ; 
        }
        else
        {
            Console.WriteLine ("\n Olá" + nome +  "Você não pode se alistar") ; 
        }

        
    }
}