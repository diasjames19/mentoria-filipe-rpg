using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mentoria_filipe_rpg.src.Model
{
    public class Knight : Characters
    {
        public Knight(string Name, int level,string CategoryType,string CharacterType) :
         base(Name, level, CategoryType, CharacterType)
        {
            
        
        }

         public override string Attack()
        {
           
                
               return this.Name + "\nAtacou com corte sim de espada!";
                
           
        }
        public  string Attack(bool DoubleSword, int Bonus)
        {
            if(DoubleSword != true && Bonus <= 1){
                
               return this.Name + "\nAtque em X com espada dupla simples! "+Bonus+" Bonus de Atque!";
                
            }else{

                return this.Name + "\nAtque em X com espada dupla! " + (Bonus+5)*Bonus+" Bonus de Atque!";

            }
            
            
        }
    }
}