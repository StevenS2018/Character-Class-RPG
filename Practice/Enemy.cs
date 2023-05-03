using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Enemy
    {
        public static void PrintEnemyDetails()
        {

            Enemy enemy = new Enemy();
            int num1 = 0;
            string name = string.Empty;
            enemy.EnemyName($"Name of Enemy: {name}");
            float health = 0.0f;
            enemy.EnemyHealthStats(health);
            float attack = 0.0f;
            enemy.EnemyAttackStats(attack);
            float defense = 0.0f;
            enemy.EnemyDefenseStats(defense);
            float speed = 0.0f;
            enemy.EnemySpeedStats(speed);
            float damage = enemy.DamageTaken(health, attack, defense);
            bool isDead = false;
            enemy.Death(health, attack, defense, isDead);
            bool hitMissed = false;
            if(enemy.HitLands(num1) == 5)
            {
                enemy.HitMissed(hitMissed, health, attack, defense);
            }
            
        }
        public int HitLands(int num1)
        {
            Random random = new Random();
            num1 = random.Next(1, 10);


            return num1;


        }

        public float EnemyHealthStats(float health)
        {
            health = 100.0f;
            return health;
        }
        public string EnemyName(string name)
        {
            name = "Paradox Creature";
            return name;
        }
        public float EnemyAttackStats(float attack)
        {
            attack = 75.0f;
            return attack;
        }
        public float EnemyDefenseStats(float defense)
        {
            defense = 50.0f;
            return defense;
        }
        public float EnemySpeedStats(float speed)
        {
            speed = 100.0f;
            return speed;
        }
        public float DamageTaken(float health, float attack, float defense)
        {
            DarkPathHero darkPathHero = new DarkPathHero();
            Enemy enemy = new Enemy();
            float damage = darkPathHero.DarkPathHeroAttackStats(attack) / enemy.EnemyDefenseStats(defense);
            float remainingHp = enemy.EnemyHealthStats(health) - damage;
            return remainingHp;
           

        }

        public bool HitMissed(bool hitLanded, float health, float attack, float defense)
        {
            Random random = new Random();
            Enemy enemy = new Enemy();
            Xentaru xentaru = new Xentaru();
            int num1 = random.Next(1,10);
            bool didMiss = false;
            xentaru.DamageTaken(health, attack, defense);
            int hitMiss = 5;
            if(enemy.HitLands(num1) == hitMiss) 
            {
                didMiss = true;
            }
           
            return didMiss;
        }
        public bool Death(float health, float attack, float defense, bool isDead)
        {
            Enemy enemy = new Enemy();
            float hp = enemy.EnemyHealthStats(health);
            health = hp;
            float attck = enemy.EnemyAttackStats(attack);
            attack = attck;
            float def = enemy.EnemyDefenseStats(defense);
            defense = def;
            isDead = false;
            if (enemy.DamageTaken(health, attack, defense) == 0)
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
