using Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public string DarkName = string.Empty;
    public float Health;
    public float Attack;
    public float Defense;
    public float speed;
    public bool isDead;




    public static void Main(string[] args)
    {
        Program program = new Program();
        int wallet = 0;
        int funds = program.Wallet(wallet);


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

