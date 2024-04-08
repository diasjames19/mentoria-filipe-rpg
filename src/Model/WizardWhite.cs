using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mentoria_filipe_rpg.src.Model
{
    public class WizardWhite : Wizard
    {


        public WizardWhite(string Name, int level, string CategoryType, string CharacterType) : 
        base(Name, level, CategoryType, CharacterType)
        {

            
        }
        public  string Attack(bool StaffSun, int Bonus)
        {
            if(StaffSun != true && Bonus < 1){
                
               return this.Name + " Ataque de Luz branca! "+Bonus+" Bonus de Atque!";
                
            }else{

                return this.Name + " Atque da Coroa do Sol! " + (Bonus+10)*Bonus+" Bonus de Atque!";

            }
            
            
        }


    }
}