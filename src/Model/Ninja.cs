using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mentoria_filipe_rpg.src.Model
{
    public class Ninja : Characters
    {
         public Ninja(string Name, int level,string CategoryType,string CharacterType) :
         base(Name, level, CategoryType, CharacterType) 
        {

        }
        public override string Attack()
        {
            return this.Name + "\nAtacou com a Kunai";
        }

        public string Attack(bool Scrolls, int Jutsu,  int Bonus)
        {
            if(Scrolls != true && Jutsu == 0){
                return "\nFalta o pergaminho e sua quantidade Justsu é zero ";
            }else{

                switch(Jutsu){
                        case 1:
                        return this.Name + "\nArte Ninja!\nKunai dupla " + (Bonus+Jutsu);
                        case 2:
                        return this.Name + "\nArte Ninja!\nJustsu Clones das sombras\nCombo dos Múltiplos Ataques da Sombra " + Bonus*Jutsu;
                        case 3:
                        return this.Name + "\nArte Ninja!\nJutsu estilo bola de Fogo\nSopro do triplo! " + (Bonus+Jutsu)*Jutsu;
                        case 4:
                        return this.Name + "\nArte Ninja!\nJutsu estilo Raio\nEspada relâmpago Chidori! " + (Bonus+10+Jutsu)*Jutsu;
                    }
                

            }
            
                return "Atque Especial!";
            }
       
    }
}