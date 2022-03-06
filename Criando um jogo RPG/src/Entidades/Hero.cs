namespace Testando_Dotnet.src.Entidades
{
    public class Hero
    {   
        private string _Name;
        private int _Level;
        private string _HeroType;
        private int _HP;

        public string Name { get => _Name; set => _Name = value; }
        public int Level { get => _Level; set => _Level = value; }
        public string HeroType { get => _HeroType; set => _HeroType = value; }
        public int HP { get => _HP; set => _HP = value; }

        public Hero(){
            this._Name = string.Empty;
            this._Level = 0;
            this._HeroType = string.Empty;
            this._HP = 0;
        }
    
        public Hero(string Name, int Level, string HeroType, int HP)
        {
            this._Name = Name;
            this._Level = Level;
            this._HeroType = HeroType;
            this._HP = HP;
            
        }
      
        public override string ToString(){
            return this._Name + " " + this.Level + " " + this.HeroType + " ";
        }

        public virtual string Attack(){
            return this._Name + " Atacou seu adversário com um golpe!";
        }

    }
}