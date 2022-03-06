namespace Testando_Dotnet.src.Entidades
{
    public class Ninja : Hero  
    {

        public Ninja(string Name, int Level, string HeroType, int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            
        }

        public override string Attack(){            
            return this.HeroType + " " + this.Name + " com level " + this.Level + " e com " + this.HP + " de HP, lança golpes de alta precisão contra seus adversários!";
       }

    }
}