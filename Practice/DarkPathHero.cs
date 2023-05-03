using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class DarkPathHero
    {
        public void PrintHeroDetails()
        {
            DarkPathHero darkHero = new DarkPathHero();
            string name = string.Empty;
            darkHero.DarkPathHeroName($"Name of Dark Hero: {name}");
            float health = 0.0f;
            darkHero.DarkPathHeroHealthStats(health);
            float attack = 0.0f;
            darkHero.DarkPathHeroAttackStats(attack);
            float defense = 0.0f;
            darkHero.DarkPathHeroDefenseStats(defense);
            float speed = 0.0f;
            darkHero.DarkPathHeroSpeedStats(speed);
            darkHero.DamageTaken(health, attack, defense);
            bool isDead = false;
            darkHero.Death(health, attack, defense, isDead);
          




        }
        public string DarkPathHeroName(string name)
        {
            name = "Xenadu";
            return name;
        }
        public float DarkPathHeroHealthStats(float health)
        {
            health = 100.0f;
            return health;
        }
        public float DarkPathHeroAttackStats(float attack)
        {
            attack = 85.0f;
            return attack;
        }
        public float DarkPathHeroDefenseStats(float defense)
        {
            defense = 50.0f;
            return defense;
        }
        public float DarkPathHeroSpeedStats(float speed)
        {
            speed = 90.0f;
            return speed;
        }
        public float DamageTaken(float health, float attack, float defense)
        {
            DarkPathHero darkHero = new DarkPathHero();
            Enemy enemy = new Enemy();
            float damage = enemy.EnemyAttackStats(attack) / darkHero.DarkPathHeroDefenseStats(defense);
            float remainingHp = darkHero.DarkPathHeroHealthStats(health) - damage;
            return remainingHp;


        }
        public bool Death(float health,float attack,  float defense, bool isDead)
        {
            DarkPathHero darkHero = new DarkPathHero();
            float hp = darkHero.DarkPathHeroHealthStats(health);
            health = hp;
            float attck = darkHero.DarkPathHeroAttackStats(attack);
            attack = attck;
            float def = darkHero.DarkPathHeroDefenseStats(defense);
            defense = def;
            isDead = false;
            if (darkHero.DamageTaken(health, attack, defense) == 0)
            {
                isDead = true;

            }
            else
            {
                isDead = false;
            }
            return isDead;
        }



    }
}
