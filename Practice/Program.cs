using Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        int wallet = 0;
        int funds = program.Wallet(wallet);
        DarkPathHero darkHero = new DarkPathHero("Xenadu", 100.0f, 30.0f,0.0f, 15.5f, 75.5f);
        Enemy enemy = new Enemy("Paradox Creature", 30.0f,20.0f,0.0f, 15.5f, 35.5f);
        Console.Write("Name of Hero: ");
        string name = darkHero.DarkPathHeroName();
        name = darkHero.Name;
        Console.WriteLine(name);
        float health = darkHero.DarkPathHeroHealthStats();
        health = darkHero.Health;
        Console.WriteLine($"{name}'s Health: {health}");
        float attack = darkHero.DarkPathHeroAttackStats();
        attack = darkHero.Attack;
        Console.WriteLine($"{name}'s Attack:{attack}");

        float defense = darkHero.DarkPathHeroDefenseStats();
        defense = darkHero.Defense;
        Console.WriteLine($"{name}'s Defense Stats: {defense}");
        float speed = darkHero.DarkPathHeroSpeedStats();
        speed = darkHero.Speed;
        Console.WriteLine($"{name}'s Speed Stats: {speed}");
        float enemyAttack = enemy.EnemyAttackStats();
        enemyAttack = enemy.Attack;
        float heroDamage = darkHero.DamageTaken();
        heroDamage = darkHero.Damage;
        heroDamage = defense / enemyAttack;
       
        health -= heroDamage;
        Console.WriteLine($"Damage taken: {heroDamage}");
        Console.WriteLine($"Remaining HP: {health}");


        bool isDead = darkHero.IsDead;
        Console.WriteLine(isDead);







        List<string> partyMembers = new List<string>()
        {
            {"Xen" },
            {"Yvonne" },
            {"Zanatar" },

             

        };

        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
           

            {"Potion", 20 }
            
            

        };
        foreach(KeyValuePair<string, int> kvp in itemInventory)
        {
            Console.WriteLine("{0} - {1}g", kvp.Key, kvp.Value);
           if(funds >= kvp.Value)
           {
                funds -= kvp.Value;
                Console.WriteLine(funds);
           }

        }


    }
    public int Wallet(int wallet)
    {
        wallet = 100;
        return wallet;
    }











    //Program program = new Program();
    //DarkPathHero dark = new DarkPathHero();
    //Enemy enemy = new Enemy();

    //string darkName = program.DarkName;
    //dark.DarkPathHeroName(darkName);
    //float hp = program.Health;

    // dark.DarkPathHeroHealthStats(hp);
    // float attack = program.Attack;

    // dark.DarkPathHeroAttackStats(attack);
    // float defense = program.Defense;

    // dark.DarkPathHeroDefenseStats(defense);
    // dark.PrintHeroDetails();












}

