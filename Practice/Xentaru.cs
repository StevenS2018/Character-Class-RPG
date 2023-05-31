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
    private float _attackBoost;
    private float _speedBoost;
    private float _nerfDefense;
    
    public float AttackUp
    {
        get { return _attackBoost; }
    }
    public float SpeedUp
    {
        get { return _nerfDefense; }
    }

    public float NerfDefense
    {
        get { return _nerfDefense; }
    }




    // CLASS PURPOSE: WHEN THE PLAYER AWAKENS HIS XENTARU FORM, IT GIVES YOU A GREAT STAT BOOST IN STRENGTH AND SPEED
    public void PrintInfo()
		{
           Xentaru xentaru = new Xentaru("", 0.0f, 0.0f, 0.0f, 0, 0f, false);
           DarkPathHero darkHero = new DarkPathHero("", 0.0f, 0.0f, 0.0f, 0, 0f, false);
           float hp = 0.0f;
		   float atck = 0.0f;
		   float def = 0.0f;
		   float spd = 0.0f;
           bool formDeath = false;
           float health = darkHero.DarkPathHeroHealthStats();
          if (health == 0)
          {
            formDeath = true;
            xentaru.FormDeath();

          }

          float attack = darkHero.DarkPathHeroAttackStats();
          float defense = darkHero.DarkPathHeroDefenseStats();
          float speed = darkHero.DarkPathHeroSpeedStats();
        

          xentaru.DarkPathHeroHealthStats();
          xentaru.AttackBoost();
          xentaru.DefenseNerf();
          xentaru.SpeedBoost();

     
     
        }
    public float FormHealthStats()
    {
        DarkPathHero darkHero = new DarkPathHero("", 0.0f, 0.0f, 0.0f, 0, 0f, false);
        float hp = darkHero.DarkPathHeroHealthStats();

        return hp;
    }
    public float AttackBoost()
    {
        DarkPathHero darkHero = new DarkPathHero("",0.0f, 0.0f, 0.0f, 0, 0f, false);
        float attck = darkHero.DarkPathHeroAttackStats();
        return attck;
    }
    public float DefenseNerf()
    {
        DarkPathHero darkHero = new DarkPathHero("",0.0f, 0.0f, 0.0f, 0, 0f, false);
        float def = darkHero.DarkPathHeroDefenseStats();
        return def;
    }
    public float SpeedBoost()
    {
        DarkPathHero darkHero = new DarkPathHero("",0.0f, 0.0f, 0.0f, 0, 0f, false);
        float spd = darkHero.DarkPathHeroSpeedStats();
       float speed = darkHero.DarkPathHeroSpeedStats();
        return spd;
    }
    public bool FormDeath()
    {
        DarkPathHero darkHero = new DarkPathHero("",0.0f, 0.0f, 0.0f, 0, 0f, false);
        float hp = darkHero.DarkPathHeroHealthStats();
       bool formDeath = false;
        if(darkHero.DarkPathHeroHealthStats() == 0)
        {

            formDeath = true;
        }
        return formDeath;

    }

    public Xentaru(string name, float health, float attack, float damage, float defense, float speed, bool isDead) : base(name, health, attack, damage, defense, speed, isDead)
    {
        _attackBoost = attack;
        _speedBoost = speed;
        _nerfDefense = defense;


    }




}
