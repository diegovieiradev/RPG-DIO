using System;


namespace ProjetoRPG
{
    public class Character
    {
        public string Name;
        public int HP;
        public int Level;
        public string HeroType;

        public Character(string Name, int HP, int Level, string HeroType){
            this.Name = Name;
            this.HP = HP;
            this.Level = Level;
            this.HeroType = HeroType;
        }     

        public virtual string Attack(string Opponent, int Damage){
            return this.Name + " Atacou " + Opponent + ", Força " + Damage + " HP!";
        }    
        
        public override string ToString(){
            return "Name: " + this.Name + "\n"
                + "HP: " + this.HeroType + "\n"
                + "Level" + this.Level + "\n"
                + "Hero Type: " + this.HeroType + "\n"
                + "------------------------------------ \n";

        }               
        
    }
}