
using mentoria_filipe_rpg.src.Model;

internal class Program
{
    private static void Main(string[] args)
    {
       Knight Dante = new("Dante",1,"Guerreiro","Humana");
        
       Console.WriteLine("|==========|Descrição|=============|");
       Console.WriteLine(" Personagem:"+Dante.Name + "\n Level:"+Dante.level + "\n Categoria:"+Dante.CategoryType);
       Console.WriteLine("|================================|\n");
        
        Console.WriteLine("Atque:"+ Dante.Attack());
        Console.WriteLine("Atque:"+ Dante.Attack(true,3));
        Console.WriteLine("Nivel Atual: "+Dante.UpLevel(false,10)+"\n");
       
    }
}