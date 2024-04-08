
using mentoria_filipe_rpg.src.Model;

internal class Program
{
    private static void Main(string[] args)
    {
         Ninja Kyo = new("Kyo",2,"Ninja","Humana"); 
         WizardWhite Kula = new("Kula",2,"Maga Branca","Humana");
         WizardBlack Frost = new("Frost",2,"Mago Negro","Humana");
         Knight Dante = new("Dante",2,"Guerreiro","Humana");

         Console.WriteLine("|==========|Descrição|=============|");
         Console.WriteLine(" Personagem:"+Dante.Name + "\n Level:"+Dante.level + "\n Categoria:"+Dante.CategoryType);
         Console.WriteLine(" Personagem:"+Kyo.Name + "\n Level:"+Kyo.level + "\n Categoria:"+Kyo.CategoryType);
         Console.WriteLine(" Personagem:"+Kula.Name + "\n Level:"+Kula.level + "\n Categoria:"+Kula.CategoryType);
         Console.WriteLine(" Personagem:"+Frost.Name + "\n Level:"+Frost.level + "\n Categoria:"+Frost.CategoryType);
         Console.WriteLine("|================================|\n");
        
        Console.WriteLine("Atque:"+ Dante.Attack());
        Console.WriteLine("Atque:"+ Dante.Attack(true,3)+"\n");
        Console.WriteLine("Personagem:"+Kyo.Name);
        Console.WriteLine("Atque:"+ Kyo.Attack());
        Console.WriteLine("Atque:"+ Kyo.Attack(true,4,3)+"\n");
        Console.WriteLine("Personagem:"+Kula.Name);
        Console.WriteLine("Atque:"+ Kula.Attack());
        Console.WriteLine("Atque:"+ Kula.Attack(true,5)+"\n");
        Console.WriteLine("Personagem:"+Frost.Name);
        Console.WriteLine("Atque:"+ Frost.Attack());
        Console.WriteLine("Atque:"+ Frost.Attack(true,5)+"\n");
    }
}