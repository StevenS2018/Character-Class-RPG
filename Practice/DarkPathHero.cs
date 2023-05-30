using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class DarkPathHero
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
        public float Health
        {
            get { return _health; }

            set { _health = value; }
        }
    
        public float Attack
        {
            get { return _attack; }

            set { _attack = value; }
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
        public void PrintHeroDetails()
        {
            DarkPathHero darkHero = new DarkPathHero("", 0.0f, 0.0f, 0,0f);
            Console.Write("Name of Hero: ");
            darkHero.DarkPathHeroName();
            darkHero.DarkPathHeroHealthStats();
            darkHero.DarkPathHeroAttackStats();
            darkHero.DarkPathHeroDefenseStats();
            darkHero.DarkPathHeroSpeedStats();
            darkHero.DamageTaken();
            darkHero.Death();
          




        }
        public string DarkPathHeroName()
        {
           string name = "Xenadu";
            return name;
        }
        public float DarkPathHeroHealthStats()
        {
            float health = 0.0f;
            return health;
        }
        public float DarkPathHeroAttackStats()
        {
           float attack = 0.0f;
            return attack;
        }
        public float DarkPathHeroDefenseStats()
        {
           float defense = 0.0f;
            return defense;
        }
        public float DarkPathHeroSpeedStats()
        {
           float speed = 0.0f;
            return speed;
        }
        public float DamageTaken()
        {
            DarkPathHero darkHero = new DarkPathHero("", 0.0f, 0.0f, 0, 0f);
            Enemy enemy = new Enemy();
            float damage = enemy.EnemyAttackStats() / darkHero.DarkPathHeroDefenseStats();
            float remainingHp = darkHero.DarkPathHeroHealthStats() - damage;
            return remainingHp;


        }
        public bool Death()
        {
            DarkPathHero darkHero = new DarkPathHero("", 0.0f, 0.0f, 0, 0f);
            bool isDead = false;
            if (darkHero.DamageTaken() == 0)
            {
                isDead = true;

            }
            else
            {
                isDead = false;
            }
            return isDead;
        }
        public DarkPathHero(string name, float health, float attack, float defense, float speed)
        {
            _name= name;
            _health= health;
            _attack= attack;
            _defense= defense;
            _speed = speed;
           
        }



    }
}
