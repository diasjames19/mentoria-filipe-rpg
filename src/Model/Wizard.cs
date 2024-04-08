using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mentoria_filipe_rpg.src.Model
{
    public class Wizard
    {
         public Wizard(string Name, int level, string CategoryType, string CharacterType) : 
        base(Name, level, CategoryType, CharacterType)
        {

   
        }

        public override string Attack()
        {
            return this.Name + " Lançou uma Magia";
        }

    }
}