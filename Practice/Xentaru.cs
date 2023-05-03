using Practice;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Xentaru : DarkPathHero
{
	// CLASS PURPOSE: WHEN THE PLAYER AWAKENS HIS XENTARU FORM, IT GIVES YOU A GREAT STAT BOOST IN STRENGTH AND SPEED
		public void PrintInfo()
		{
           Xentaru xentaru = new Xentaru();
           DarkPathHero darkHero = new DarkPathHero();
           float hp = 0.0f;
		   float atck = 0.0f;
		   float def = 0.0f;
		   float spd = 0.0f;
           bool formDeath = false;
           float health = darkHero.DarkPathHeroHealthStats(hp);
          if (health == 0)
          {
            formDeath = true;
            xentaru.FormDeath(health, formDeath);

          }

          float attack = darkHero.DarkPathHeroAttackStats(atck);
          float defense = darkHero.DarkPathHeroDefenseStats(def);
          float speed = darkHero.DarkPathHeroSpeedStats(spd);
        

          xentaru.DarkPathHeroHealthStats(health);
          xentaru.AttackBoost(attack);
          xentaru.DefenseNerf(defense);
          xentaru.SpeedBoost(speed);

     
     
        }
    public float FormHealthStats(float health)
    {
        DarkPathHero darkHero = new DarkPathHero();
        float hp = darkHero.DarkPathHeroHealthStats(health);

        return hp;
    }
    public float AttackBoost(float attack)
    {
        DarkPathHero darkHero = new DarkPathHero();
        float attck = darkHero.DarkPathHeroAttackStats(attack);
        attck = darkHero.DarkPathHeroAttackStats(attack * 2);
        return attck;
    }
    public float DefenseNerf(float defense)
    {
        DarkPathHero darkHero = new DarkPathHero();
        float def = darkHero.DarkPathHeroDefenseStats(defense);
        def = darkHero.DarkPathHeroDefenseStats(defense / 2);
        return def;
    }
    public float SpeedBoost(float speed)
    {
        DarkPathHero darkHero = new DarkPathHero();
        float spd = darkHero.DarkPathHeroSpeedStats(speed);
        speed = darkHero.DarkPathHeroSpeedStats(speed * 3);
        return spd;
    }
    public bool FormDeath(float health, bool formDeath)
    {
        DarkPathHero darkHero = new DarkPathHero();
        float hp = darkHero.DarkPathHeroHealthStats(health);
        formDeath = false;
        if(darkHero.DarkPathHeroHealthStats(hp) == 0)
        {

            formDeath = true;
        }
        return formDeath;

    }




}
