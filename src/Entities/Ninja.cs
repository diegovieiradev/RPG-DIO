using System;

namespace ProjetoRPG.src.Entities
{
    public class Ninja : Character
    {
        public Ninja(string Name, int HP, int Level, string HeroType) : base(Name, HP, Level, HeroType)
        {
            this.Name = Name;
            this.HP = HP;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(string Opponent, int Damage)
        {
            return this.Name + " Lançou um feitiço em " + Opponent + ", com Força de " + Damage + " HP!";
        }

        public string Attack(string Opponent, int Damage, int Bonus)
        {
            if(Bonus > 20){
                return this.Name + " Lançou um feitiço em " + Opponent + ", com Força de " + Damage + ", teve um Bonus de " + Bonus + " HP!";
            }else{
                 return this.Name + " Lançou um feitiço em " + Opponent + ", com Força de " + Damage + " HP!";
            }
        }
        
    }
}