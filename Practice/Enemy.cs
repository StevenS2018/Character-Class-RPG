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
        private string _name;
        private float _health;
        private float _attack;
        private float _damage;
        private float _defense;
        private float _speed;
        private bool _isDead;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public float Health {
            get { return _health; } 

            set { _health = value; }
        }
     
        public float Attack
        {
            get { return _attack; }

            set { _attack = value; }
        }
        public float Damage
        {
            get { return _damage; }
        }
        public float Defense
        {
            get { return _defense; }

            set { _defense = value; }
        }
        public float Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        public bool IsDead
        {
            get { return _isDead; }
        }




        public static void PrintEnemyDetails()
        {

            Enemy enemy = new Enemy("", 0.0f, 0.0f, 0.0f, 0, 0f);

            enemy.EnemyName();
            enemy.EnemyHealthStats();
            enemy.EnemyAttackStats();
            enemy.EnemyDefenseStats();
            enemy.EnemySpeedStats();
            float damage = enemy.DamageTaken();
            enemy.Death();
            if(enemy.HitLands() == 5)
            {
                enemy.HitMissed();
            }
            Console.WriteLine(damage);
            
        }
        public int HitLands()
        {
            Random random = new Random();
            int num1 = random.Next(1, 10);


            return num1;


        }

        public float EnemyHealthStats()
        {
          float  health = 0.0f;
            return health;
        }
        public string EnemyName()
        {
          string  name = "";
            return name;
        }
        public float EnemyAttackStats()
        {
           float  attack = 0.0f;
            return attack;
        }
        public float EnemyDefenseStats()
        {
           float  defense = 0.0f;
            return defense;
        }
        public float EnemySpeedStats()
        {
            float speed = 0.0f;
            return speed;
        }
        public float DamageTaken()
        {
            DarkPathHero darkPathHero = new DarkPathHero("", 0.0f, 0.0f, 0.0f, 0, 0f, false);
            Enemy enemy = new Enemy("", 0.0f,0.0f, 0.0f, 0, 0f);
            float damage = darkPathHero.DarkPathHeroAttackStats() / enemy.EnemyDefenseStats();
            float remainingHp = enemy.EnemyHealthStats() - damage;
            return remainingHp;
           

        }

        public bool HitMissed()
        {
            Enemy enemy = new Enemy("", 0.0f,0.0f, 0.0f, 0, 0f);
            DarkPathHero darkPathHero = new DarkPathHero("", 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, false);
            bool didMiss = false;
            darkPathHero.HpDamageTaken();
            int hitMiss = 5;
            if(enemy.HitLands() == hitMiss) 
            {
                didMiss = true;
            }
           
            return didMiss;
        }
        public bool Death()
        {
            Enemy enemy = new Enemy("", 0.0f,0.0f, 0.0f, 0, 0f);
            float hp = enemy.EnemyHealthStats();
            float attack = enemy.EnemyAttackStats();
            float def = enemy.EnemyDefenseStats();
    
            bool isDead = false;

            if (enemy.DamageTaken() == 0)
            {
                isDead = true;

            }
            else
            {
                isDead = false;
            }
            return isDead;
        }
        public Enemy(string name, float health,float attack, float damage, float defense, float speed)
        {
            _name = name;
            _health = health;
            _attack = attack;
            _damage = damage;
            _defense = defense;
            _speed = speed;

        }


    }
}
