using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mentoria_filipe_rpg.src.Model
{
   public abstract class  Characters
    {


        public Characters(string Name, int level ,string CategoryType,string CharacterType){
    
            this.Name = Name;
            this.CategoryType = CategoryType;
            this.CharacterType = CharacterType;
            this.level = level;
        
        }
        public string? CharacterType;
        public string? Name;

        public string? CategoryType;
        public int level;


          public string UpLevel(bool InimigoBoss,int Inimigo){
            
            if(InimigoBoss == false){
                 while(Inimigo != 0){
                if(Inimigo <= 9){
                     this.level = level*1;
                }else{
                    this.level = level*3;
                    
                }
                 Inimigo--;
                 }
                 return $"Leve Up: {this.level}";
            }else{
                return $"Leve Up: {this.level*6}";
            }
            
            
        }

        public virtual string Attack(){
            return this.Name + "Atacou o inimigo!";
        }
    }
}