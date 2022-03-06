namespace Testando_Dotnet.src.Entidades
{
    public class Wizard : Hero 
    {
     

        public Wizard(string Name, int Level, string HeroType, int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
        }
        
        public override string Attack(){            
            return this.HeroType + " " + this.Name + " com level " + this.Level + " e com " + this.HP + " de HP, lançou uma magia mediana!" ;
        }
        // Polimorfismo
        public string Attack(int Bonus){

            if (Bonus >= 6){
               return this.Name + " Lanço uma magia super efetiva de " + Bonus;
            }else{
                return this.Name + " Lançou uma magia com força fraca de " + Bonus;
            }

            
        }

    }
}