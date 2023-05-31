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
   
        public string DarkPathHeroName()
        {
           string name = Name;
            return name;
        }
        public float DarkPathHeroHealthStats()
        {
            
            float health = Health;

            return health;
        }
        public float DarkPathHeroAttackStats()
        {
           float attack = Attack;

            return attack;
        }
        public float DarkPathHeroDefenseStats()
        {
           float defense = Defense;
            return defense;
        }
        public float DarkPathHeroSpeedStats()
        {
           float speed = Speed;
            return speed;
        }
        public float HpDamageTaken()
        {
            DarkPathHero darkHero = new DarkPathHero("", 0.0f, 0.0f, 0.0f, 0.0f, 0f, false);
            Enemy enemy = new Enemy("", 0.0f, 0.0f, 0.0f, 0.0f, 0f);
            float health = DarkPathHeroHealthStats();
            float damage = enemy.EnemyAttackStats() / darkHero.DarkPathHeroDefenseStats();
            damage = darkHero.Damage;
            float remainingHp = health - damage;
            return remainingHp;
        }
        public bool Death()
        {

            DarkPathHero darkHero = new DarkPathHero("", 0.0f, 0.0f, 0.0f, 0.0f, 0f, IsDead);
            float health = DarkPathHeroHealthStats();
            float hpDamage = darkHero.HpDamageTaken() - darkHero.DarkPathHeroHealthStats();
           health -= hpDamage;
            float death = 0.0f;
            bool isDead = false;

            if(health <= death) 
            {
                isDead = true;
                return isDead;

            }
         
            return isDead;
        }
        public DarkPathHero(string name, float health, float attack, float damage, float defense, float speed, bool isDead)
        {
            _name= name;
            _health= health;
            _attack= attack;
            _damage = damage;
            _defense= defense;
            _speed = speed;
            _isDead = isDead;
           
        }



    }
}
