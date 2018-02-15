using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HeroMonsterClassesPart1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "George the Great";
            hero.Health = 100;
            hero.DamageMaximum = 20;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Harry the Terrible";
            monster.Health = 150;
            monster.DamageMaximum = 30;
            monster.AttackBonus = true;

            Dice myDice = new Dice();


            // battle to the death!
            while (hero.Health > 0 && monster.Health > 0)
            {
                int damage = hero.Attack(myDice);
                monster.Defend(damage);

                if (hero.AttackBonus == true)
                {
                    damage = hero.Attack(myDice);
                    monster.Defend(damage);
                }

                damage = monster.Attack(myDice);
                hero.Defend(damage);

                if (monster.AttackBonus == true)
                {
                    damage = monster.Attack(myDice);
                    hero.Defend(damage);
                }

                printer(hero);
                printer(monster);
            }

            displayResult(hero, monster);
            
        }

        private void displayResult(Character opponent1, Character opponent2)
        {
            if (opponent1.Health <= 0 && opponent2.Health <= 0)
            {
                resultLabel.Text += String.Format("<p>Both {0} and {1} have died.</p>", opponent1.Name, opponent2.Name);
            }
            else if (opponent2.Health <= 0)
            {
                resultLabel.Text += String.Format("<p>{0}, monster from the deep, has died.</p>", opponent2.Name);
            }
            else if (opponent1.Health <= 0)
            {
                resultLabel.Text += String.Format("<p>{0}, ever the weakest hero, has died.</p>", opponent1.Name);
            }
        }

        private void printer(Character character)
        {
            resultLabel.Text += String.Format("<p>Name: {0}, Health: {1}, Damage Max: {2}, Attack Bonus: {3}</p>", 
                character.Name, 
                character.Health.ToString(), 
                character.DamageMaximum.ToString(), 
                character.AttackBonus.ToString());
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice myDice)
        {
            int damage = 0;
            myDice.Sides = this.DamageMaximum;
            damage = myDice.Roll();
            return damage;
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }

    class Dice
    {
        public int Sides { get; set; }

        // New instance of random
        Random random = new Random();
        
        // Use number of sides to "roll" a random number
        public int Roll()
        {
            int randomNumber = random.Next(this.Sides);
            return randomNumber;
        }
    }
}