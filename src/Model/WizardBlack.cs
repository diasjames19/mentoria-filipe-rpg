using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mentoria_filipe_rpg.src.Model
{
    public class WizardBlack : Wizard
    {

        public WizardBlack(string Name, int level, string CategoryType, string CharacterType) : 
        base(Name, level, CategoryType, CharacterType)
        {
        }
         public  string Attack(bool StaffMoon, int Bonus)
        {
            if(StaffMoon != true && Bonus < 1){
                
               return this.Name + " Chuva de Meteoros "+Bonus;
                
            }else{

                return this.Name + " Esquife de Gelo! " + (Bonus+10)*Bonus;

            }
            
            
        }


    }
}