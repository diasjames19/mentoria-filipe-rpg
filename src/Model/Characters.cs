using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mentoria_filipe_rpg.src.Model
{
   public abstract class  Characters
    {


        public Characters(string Name, int level,string CategoryType,string CharacterType){
            this.Name = Name;
            this.CategoryType = CategoryType;
            this.CharacterType = CharacterType;
            this.level = level;
        
        }
        public string? CharacterType;
        public string? Name;

        public string? CategoryType;
        public int level;

        public virtual string Attack(){
            return this.Name + "Atacou o inimigo!";
        }
    }
}