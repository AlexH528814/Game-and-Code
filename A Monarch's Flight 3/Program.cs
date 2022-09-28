//The differnt using Systems are because some of the functions i created use different directives
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{
    //Main Function
    public static void Main(string[] args)
    {
        // 14 to 56 are the different variables for my code

        Random rnd = new Random();
        int enemyChance = 0;
        int enemyHP = 1;
        int playerHP = 2;
        int enemydamage;
        int playerblockchance;
        int playerCritchance;
        int enemyCritchance;
        int Heals = 3;
        int healthgain;
        int playerSlashDamage = 0;
        int playerStabDamage = 0;
        int playerFryDamage = 0;
        int e = 0;
        int enemySpawned = 0;
        string room = "cell";
        string answer = "n";
        string movechoice = "";
        string fightflight = "";
        string spawnMessage3;
        string spawnMessage1;
        string spawnMessage2;
        string deathMessage1;
        string deathMessage2;
        string deathMessage3;
        spawnMessage3 = "High Priest Pucci appeared before you";
        spawnMessage2 = "The Palace Chef appeared before you";
        spawnMessage1 = "The enemy prisoner appeared before you";
        deathMessage3 = "Congratulations, you have defeated High Priest Pucci";
        deathMessage2 = "You deafeated the Palace Chef, no more food for a while";
        deathMessage1 = "You vanquished the enemy prisoner";
        bool sword = true;
        bool fryingPan = false;
        bool knife = false;
        bool chefKilled = false;
        bool prisonerKilled = false;
        bool pucciKilled = false;

        // Function to type letter by letter

        void type(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i]);
                System.Threading.
                Thread.Sleep(25);
            }
            Console.WriteLine(" ");
        }
        // Function to check death
        void checkDeath()
        {
            if (playerHP <= 0)
            {
                playerHP = 0;

                if (prisonerKilled == false)
                {
                    prisonerKill();
                }

                else if (prisonerKilled == true && chefKilled == false)
                {
                    chefKill();
                }

                else if (chefKilled == true && prisonerKilled == true && pucciKilled == false)
                {
                    pucciKill();
                }
            }
        }
        // Function to heal player
        void playerHeal()
        {
            if (Heals > 0)
            {
                healthgain = rnd.Next(10, 20);
                Console.ForegroundColor = ConsoleColor.Green;
                sleep(1);
                type("You reach down into your pocket and pick out one of the few healing potions you have and down it in one big swig.");
                Heals = Heals - 1;
                sleep(1);
                type($"You have {Heals} Potions left!");
                sleep(1);
                type($"You gained {healthgain} health from the potion!");
                sleep(1);
                Console.ForegroundColor = ConsoleColor.White;
                playerHP = playerHP + healthgain;
                checkDeath();
                type($"You now have {playerHP} Health");
                sleep(1);
            }
            else if (Heals! > 0)
            {
              
                    Console.ForegroundColor = ConsoleColor.Green;

                    type("You reach down into your pocket to drink a potion in one big swig. However, when reaching into your pocket, you see that you have no potions left");
                    Heals = Heals - 1;
                    
                
            }
        }
        //Function for when Pucci spawns in
        void pucciMsg()
        {
            type($"High Priest Pucci has {enemyHP} Health");
            sleep(1);

            if (fryingPan != true)
            {
                type("What would you like to do? [Slash] [Stab] [Block] [Heal]");
            }

            else
            {
                type("What would you like to do [Smack] [Block] [Heal]");
            }
        }
        //Function for when Prisoner spawns in
        void prisonerMsg()
        {
            type($"The enemy prisoner has {enemyHP} Health");
            sleep(1);

            if (fryingPan != true)
            {
                type("What would you like to do? [Slash] [Stab] [Block] [Heal]");

            }

            else
            {
                type("What would you like to do [Smack] [Block] [Heal]");
            }
        }
        //Function for when Chef spawns in
        void chefMsg()
        {
            type($"The Palace Chef has {enemyHP} Health");
            sleep(1);

            if (fryingPan != true)
            {
                type("What would you like to do? [Slash] [Stab] [Block] [Heal]");

            }

            else
            {
                type("What would you like to do [Smack] [Block] [Heal]");
            }
        }
        //Function for when Pucci crits
        void pucciCrit()
        {
            if (enemyCritchance == 1)
            {
                type("High Priest Pucci has contolled his emotions and packed them into a single devastating punch!");
                sleep(1);
                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                checkDeath();
                type($"You now have {playerHP} Health Left ");
                sleep(1);
            }
        }
        //Function for when Prisoner Crits
        void prisonerCrit()
        {
            if (enemyCritchance == 1)
            {
                type("The prisoner was able to land a dangerous punch on you!");
                sleep(1);
                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                checkDeath();
                type($"You now have {playerHP} Health Left ");
                sleep(1);
            }
        }
        //Function for when Chef Crits
        void chefCrit()
        {
            if (enemyCritchance == 1)
            {
                type("The Palace Chef has used his knowledge about food and cutlery to predict what your next move would be and strikes where it would hurt you most!");
                sleep(1);
                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                checkDeath();
                type($"You now have {playerHP} Health Left ");
                sleep(1);
            }
        }
        //Function for when Pucci fails to crit
        void pucciCritless()
        {
            if (enemyCritchance != 1)
            {
                type($"High Priest Pucci dealt you {enemydamage} damage ");
                playerHP = playerHP - enemydamage;
                checkDeath();
                type($"You now have {playerHP} Health Left ");
                sleep(1);
            }
        }
        //Function for when Prisoner fails to crit
        void prisonerCritless()
        {
            if (enemyCritchance != 1)
            {
                type($"The prisoner dealt you {enemydamage} damage ");
                playerHP = playerHP - enemydamage;
                checkDeath();
                sleep(1);
                type($"You now have {playerHP} Health Left ");
                sleep(1);
            }
        }
        //Function for when Chef fails to crit
        void chefCritless()
        {
            if (enemyCritchance != 1)
            {
                type($"The Palace Chef dealt you {enemydamage} damage ");
                sleep(1);
                playerHP = playerHP - enemydamage;
                checkDeath();
                type($"You now have {playerHP} Health Left ");
                sleep(1);
            }
        }
        //Function for when Pucci attacks
        void pucciAttack()
        {

            type($"High Priest Pucci has {enemyHP} Health");
            sleep(1);
            pucciCrit();

            pucciCritless();
        }
        //Function for when Prisoner attacks
        void prisonerAttack()
        {

            type($"The prisoner has {enemyHP} Health");
            sleep(1);
            prisonerCrit();

            prisonerCritless();
        }
        //Function for when Chef attacks
        void chefAttack()
        {

            type($"The Palace Chef has {enemyHP} Health");
            sleep(1);
            chefCrit();

            chefCritless();
        }
        //Function for when Players crits with a slash
        void playerSlashCrit()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            type("You get ready to release your anger upon your enemy!");
            sleep(1);

            playerSlashDamage = playerSlashDamage * 2;
            type($"You were able to slash your enemy with your weapon {playerSlashDamage} Damage!");
            sleep(1);
            enemyHP = enemyHP - playerSlashDamage;
            Console.ForegroundColor = ConsoleColor.White;
        }
        //Function for when Players crits with a stab
        void playerStabCrit()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            type("You get ready to release your anger upon your enemy!");
            sleep(1);

            playerStabDamage = playerStabDamage * 2;
            type($"You managed to thrust your weapon into your enemy's body and dealt {playerStabDamage} Damage!");
            sleep(1);
            enemyHP = enemyHP - playerStabDamage;
            Console.ForegroundColor = ConsoleColor.White;
        }
        //Function for when Players crits with a smack
        void playerFryCrit()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            type("You get ready to release your anger upon your enemy!");
            sleep(1);

            playerStabDamage = playerStabDamage * 2;
            type($"You were able to smack your enemy in the head with your frying pan and dealt {playerStabDamage} Damage!");
            sleep(1);
            enemyHP = enemyHP - playerStabDamage;
            Console.ForegroundColor = ConsoleColor.White;
        }
        //Function for when Players blocks Puccis attack
        void blockedPucci()
        {
            if (playerblockchance == 1 && enemyCritchance != 1)
            {
                sleep(1);
                type($"High Priest Pucci dealt you {enemydamage} damage ");
                sleep(1);
                type("However, you were able to put your guard up in time, and Pucci hardly dealt any damage to you");
                sleep(1);
                playerHP = playerHP - 1;
                checkDeath();
                type($"You now have {playerHP} Health Left ");
                sleep(1);

            }
        }
        //Function for when Players blocks Prisoner's attack
        void blockedPrisoner()
        {
            if (playerblockchance == 1 && enemyCritchance != 1)
            {
                sleep(1);
                type($"The prisoner dealt you {enemydamage} damage ");
                sleep(1);
                type("However, you were able to put your guard up in time, and the prisoner hardly dealt any damage to you");
                sleep(1);
                playerHP = playerHP - 1;
                checkDeath();
                type($"You now have {playerHP} Health Left ");
                sleep(1);

            }
        }
        //Function for when Players blocks Chef attack
        void blockedChef()
        {
            if (playerblockchance == 1 && enemyCritchance != 1)
            {
                sleep(1);
                type($"The Palace Chef attempted to deal you {enemydamage} damage ");
                type("However, you were able to put your guard up in time, and hardly dealt any damage to you");
                sleep(1);
                playerHP = playerHP - 1;
                checkDeath();
                type($"You now have {playerHP} Health Left ");
                sleep(1);

            }
        }
        //Function for when Players fails to block Pucci's attack
        void blockedPucciFail()
        {
            if (playerblockchance == 1 && enemyCritchance == 1)
            {
                sleep(1);
                type("High Priest Pucci has contolled his emotions and packed them into a single devastating punch!");
                sleep(1);
                type("You attempted to block High Priest Pucci's attack, but he broke through your guard and hit you with his devastating punch!");
                sleep(1);
                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                checkDeath();
                type($"You now have {playerHP} Health Left ");
                sleep(1);

            }
        }
        //Function for when Players fails to block Prisoner's attack
        void blockedPrisonerFail()
        {
            if (playerblockchance == 1 && enemyCritchance == 1)
            {
                sleep(1);
                type("The prisoner has contolled his emotions and packed them into a single devastating punch!");
                sleep(1);
                type("You attempted to block the prisoner's attack, but he broke through your guard and hit you with his devastating punch!");
                sleep(1);
                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                checkDeath();
                type($"You now have {playerHP} Health Left ");
                sleep(1);
            }
        }
        //Function for when Players fails to block Chef's attack
        void blockedChefFail()
        {
            if (playerblockchance == 1 && enemyCritchance == 1)
            {
                sleep(1);
                type("The Palace Chef has contolled their emotions and packed them into a single devastating punch!");
                sleep(1);
                type("You attempted to block The Palace Chef's attack, but they broke through your guard and hit you with their devastating attack!");
                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                checkDeath();
                sleep(1);
                type($"You now have {playerHP} Health Left ");

            }
        }
        //Function for when Pucci kills player
        void pucciKill()
        {
            if (playerHP <= 0)
            {
                sleep(1);
                type("High Priest Pucci has defeated you and stolen your throne");
                sleep(1);
                Environment.Exit(0);
            }
        }
        //Function for when Prisoner kills player
        void prisonerKill()
        {
            if (playerHP <= 0)
            {
                sleep(1);
                type("The prisoner in your cell has defeated you and allowed High Priest Pucci to steal your throne");
                sleep(1);
                Environment.Exit(0);
            }
        }
        //Function for when Chef kills player
        void chefKill()
        {
            if (playerHP <= 0)
            {
                sleep(1);
                type("The Palace Chef has defeated you and allowed High Priest Pucci to steal your throne");
                sleep(1);
                Environment.Exit(0);
            }
        }
        //Function for when Pucci dies
        void pucciDeath()
        {
            if (enemyHP <= 0)
            {
                enemySpawned = 0;
                pucciKilled = true;
                sleep(1);
                Console.WriteLine(deathMessage3);
                sleep(1); 
                type("You have now regained your rightful seat on your throne.");
                sleep(1);
                throne();
                type("Well Done");
                sleep(1);
                Environment.Exit(0);
            }
        }
        //Function for when Prisoner dies
        void prisonerDeath()
        {
            if (enemyHP <= 0)
            {
                enemySpawned = 0;
                prisonerKilled = true;
                Console.WriteLine(deathMessage1);
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
        //Function for when Chef dies
        void chefDeath()
        {
            if (enemyHP <= 0)
            {
                enemySpawned = 0;
                chefKilled = true;
                Console.WriteLine(deathMessage2);
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
        }
        //Random Damage Function
        void rndDam()
        {
            playerCritchance = rnd.Next(0, 10);
            enemyCritchance = rnd.Next(0, 10);

            playerblockchance = rnd.Next(0, 6);
            if (sword == true && knife == false && fryingPan == false)
            {
                playerSlashDamage = rnd.Next(20, 9000);
                playerStabDamage = rnd.Next(2, 75);
            }

            else if (sword == false && knife == true && fryingPan == false)
            {
                playerSlashDamage = rnd.Next(30, 120);
                playerStabDamage = rnd.Next(7, 100);
            }

            playerFryDamage = rnd.Next(0, 50);
            enemydamage = rnd.Next(9, 50);
        }
        //Function for room switch
        void roomSwitch()
        {
            switch (room)
            {
                case "cell":
                    sleep(1);
                    type("You woke up in your palace dungeon in a small cell with a light in it.");
                    cellroom();
                    e = 1;
                    type("A prisoner appears in your cell before you, what would you like to do? [Fight] [Flee]");
                    sleep(1);
                    fightflight = Console.ReadLine();
                    break;

                case "Kitchen":
                    sleep(1);
                    kitchenroom();
                    e = 2;
                    type("You chose to enter the kitchen, and the see the Palace Chef, what would you like to do? [Fight] [Flee]");
                    sleep(1);
                    fightflight = Console.ReadLine();
                    break;

                case "throneRoom":
                    sleep(1);
                    throneroom();
                    type("You proceeded from the Kitchen to the throne room. You are now in the presence of the High Priest Pucci! What would you like to do? [Fight] [Flee]?");
                    sleep(1);
                    e = 3;
                    fightflight = Console.ReadLine();
                    break;
            }

        }
        //Function for attacking or running
        void fightFlight()
        {
            switch (fightflight)
            {
                case "Fight":
                    sleep(1);
                    type("You decided to fight the enemy in front of you");
                    sleep(1);
                    enemyChance = 1;
                    break;

                case "Flee":
                    if (prisonerKilled == true)
                    { 
                        enemyChance = 0;
                        sleep(1);
                        type("You decided to flee from the enemy in front of you and run back down into the dungoen cell to lock yourself in.");
                        sleep(1);
                        type("You are now living in the palace dungeon cell for the rest of your life");
                        sleep(1);
                        Environment.Exit(0);
                    } 

                    else if (prisonerKilled == false)
                    {
                        enemyChance = 0;
                        sleep(1);
                        type("You were unable to flee from the prisoner in your cell as you are both locked in, the prisoner got the jump on you and was able to kill you!");
                        sleep(1);
                        Environment.Exit(0);
                    }
                    break;

            }
        }
        //Function to switch enemy
        void eswitch()
        {
            switch (e)
            {
                case 1:
                    enemySpawned = 1;
                    enemyHP = rnd.Next(100, 150);
                    break;
                case 2:
                    enemySpawned = 2;
                    enemyHP = rnd.Next(150, 250);
                    break;
                case 3:
                    enemySpawned = 3;
                    enemyHP = rnd.Next(250, 400);
                    break;

            }
        }
        //Function to make thread ssleep better
        void sleep(int seconds)
        {
            Thread.Sleep(seconds);
        }

        roomSwitch();
        fightFlight();
        eswitch();
        checkDeath();
        //Enemy attack area
        if (enemyChance == 1)
        {
            //Prisoner attack area
            if (e == 1)
            {
                sleep(1);
                Console.WriteLine(spawnMessage1);
                sleep(1);
                prisoner();

                if (enemySpawned == 1)
                {
                    while (enemySpawned == 1)
                    {
                        prisonerMsg();
                        answer = Console.ReadLine();
                        checkDeath();
                        if (fryingPan != true)
                        {   //Player chose slash
                            if (answer == "Slash" ^ answer == "slash" ^ answer == "1" ^ answer == "s")
                            {
                                rndDam();
                                checkDeath();
                                if (playerCritchance == 1)
                                {
                                    playerSlashCrit();
                                }

                                else if (playerCritchance != 1)
                                {
                                    sleep(1);
                                    Console.WriteLine($"You slashed your weapon at the Prisoner for {playerSlashDamage} damage");
                                    sleep(1);
                                    enemyHP = enemyHP - playerSlashDamage;
                                }

                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    prisonerAttack();
                                }
                                checkDeath();
                                prisonerDeath();
                                checkDeath();
                                prisonerKill();
                            }
                            //Player chose Stab
                            if (answer == "Stab" ^ answer == "stab" ^ answer == "2" ^ answer == "t")
                            {
                                rndDam();
                                checkDeath();
                                if (playerCritchance == 1)
                                {
                                    playerStabCrit();
                                }

                                else if (playerCritchance != 1)
                                {
                                    sleep(1);
                                    Console.WriteLine($"You thrust your weapon into High Priest Pucci for {playerStabDamage} damage");
                                    sleep(1);
                                    enemyHP = enemyHP - playerSlashDamage;
                                }

                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    prisonerAttack();
                                }
                                checkDeath();
                                prisonerDeath();
                                checkDeath();
                                checkDeath();
                                prisonerKill();
                            }
                            //Player chose block
                            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
                            {

                                rndDam();
                                playerblockchance = 1;
                                checkDeath();
                                blockedPrisoner();
                                blockedPrisonerFail();
                                checkDeath();
                                prisonerKill();
                                checkDeath();
                            }
                            //Player chose heal
                            else if (answer == "Heal" ^ answer == "heal" ^ answer == "3" ^ answer == "c")
                            {
                                rndDam();
                                playerHeal();
                                checkDeath();
                                prisonerDeath();
                                checkDeath();
                                prisonerKill();
                            }
                        }

                        else if (fryingPan == true)
                        {   //Player chose Smack
                            if (answer == "Smack" ^ answer == "smack" ^ answer == "1" ^ answer == "s")
                            {
                                rndDam();
                                checkDeath();
                                if (playerCritchance == 1)
                                {
                                    playerFryCrit();
                                }

                                else if (playerCritchance != 1)
                                {
                                    type($"You smacked the Prisoner for {playerFryDamage} damage");
                                    enemyHP = enemyHP - playerFryDamage;
                                }
                                checkDeath();
                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    prisonerAttack();
                                }
                                checkDeath();
                                prisonerDeath();
                                checkDeath();
                                prisonerKill();
                            }
                            //Player chose Block
                            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
                            {
                                rndDam();
                                playerblockchance = 1;
                                checkDeath();
                                blockedPrisoner();
                                blockedPrisonerFail();
                                checkDeath();
                                prisonerKill();

                            }
                            //Player chose heal
                            else if (answer == "Heal" ^ answer == "heal" ^ answer == "3" ^ answer == "c")
                            {
                                rndDam();
                                playerHeal();
                                checkDeath();
                                prisonerDeath();
                                checkDeath();
                                prisonerKill();
                            }

                        }
                    }
                    if (prisonerKilled == true)
                    {
                        sleep(1);
                        type("You have killed the prisoner and are now able to escape the prison cell, what would you like to do? [Leave] [Stay]");
                        sleep(1);
                        answer = Console.ReadLine();
                        if (answer == "Leave")
                        {
                            sleep(1);
                            room = "Kitchen";
                        }

                        else if (answer == "Stay")
                        {
                            sleep(1);
                            type("You decided that it would be better for you to stay in the mangy palace dungeon cell for the rest of your days");
                            sleep(1);
                            Environment.Exit(0);
                        }
                    }
                    roomSwitch();
                    fightFlight();
                    checkDeath();
                    eswitch();
                }
            }


            if (prisonerKilled == true && e == 2)
            {


                type(spawnMessage2);
                checkDeath();
                Chef();

                if (enemySpawned == 2)
                {
                    while (enemySpawned == 2)
                    {
                        chefMsg();
                        answer = Console.ReadLine();
                        checkDeath();
                        if (fryingPan != true)
                        {   //Player chose slash
                            if (answer == "Slash" ^ answer == "slash" ^ answer == "1" ^ answer == "s")
                            {
                                rndDam();
                                checkDeath();
                                if (playerCritchance == 1)
                                {
                                    playerSlashCrit();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                }

                                else if (playerCritchance != 1)
                                {
                                    type($"You were able to slash the Palace Chef for {playerSlashDamage} damage");
                                    enemyHP = enemyHP - playerSlashDamage;
                                }

                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    chefAttack();
                                    checkDeath();
                                }

                                chefDeath();
                                checkDeath();
                                chefKill();
                            }
                            //Player chose Stab
                            if (answer == "Stab" ^ answer == "stab" ^ answer == "2" ^ answer == "t")
                            {
                                rndDam();
                                checkDeath();
                                if (playerCritchance == 1)
                                {
                                    playerStabCrit();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    checkDeath();
                                }

                                else if (playerCritchance != 1)
                                {
                                    type($"You thrust your weapon into the Palace Chef for {playerStabDamage} damage");
                                    enemyHP = enemyHP - playerSlashDamage;
                                }
                                checkDeath();
                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    chefAttack();
                                }
                                checkDeath();
                                chefDeath();

                                chefKill();
                            }
                            //Player chose Block
                            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
                            {

                                rndDam();
                                playerblockchance = 1;
                                checkDeath();
                                blockedChef();
                                blockedChefFail();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                chefKill();
                            }
                            //Player chose heal
                            else if (answer == "Heal" ^ answer == "heal" ^ answer == "3" ^ answer == "c")
                            {
                                rndDam();
                                checkDeath();
                                playerHeal();
                                checkDeath();
                                chefDeath();
                                checkDeath();
                                chefKill();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                        }

                        else if (fryingPan == true)
                        {   //Player chose Smack
                            if (answer == "Smack" ^ answer == "smack" ^ answer == "1" ^ answer == "s")
                            {
                                checkDeath();
                                rndDam();

                                if (playerCritchance == 1)
                                {
                                    playerFryCrit();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                }

                                else if (playerCritchance != 1)
                                {
                                    checkDeath();
                                    type($"You were able to smack the Palace Chef for {playerFryDamage} damage");
                                    enemyHP = enemyHP - playerFryDamage;
                                }

                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    checkDeath();
                                    chefAttack();
                                }
                                checkDeath();
                                chefDeath();
                                checkDeath();
                                chefKill();
                            }
                            //Player chose Block
                            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
                            {
                                checkDeath();
                                rndDam();
                                playerblockchance = 1;
                                checkDeath();
                                blockedChef();
                                blockedChefFail();
                                chefKill();
                                checkDeath();
                            }
                            //Player chose heal
                            else if (answer == "Heal" ^ answer == "heal" ^ answer == "3" ^ answer == "c")
                            {
                                rndDam();
                                checkDeath();
                                playerHeal();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                checkDeath();
                                chefDeath();
                                checkDeath();
                                chefKill();
                                checkDeath();

                            }
                        }
                    }
                    if (chefKilled == true)
                    {

                        type("You see two weapons in the kitchen before you leave, a knife and a frying pan, which would you like to take? [Knife] [FryingPan]");
                        sleep(1);
                        string weaponChoice = Console.ReadLine();
                        if (weaponChoice == "Knife" ^ weaponChoice == "knife")
                        {
                            knife = true;
                            fryingPan = false;
                            sword = false;
                            checkDeath();
                            type("You decided to choose the knife");
                            sleep(1);
                        }
                        else if (weaponChoice == "FryingPan" ^ weaponChoice == "Fryingpan" ^ weaponChoice == "fryingpan")
                        {
                            fryingPan = true;
                            knife = false;
                            sword = false;
                            checkDeath();
                            type("You decided to choose the frying pan");
                            sleep(1);
                        }
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        type("Now that you have killed the palace chef you are able to walk towards the throne room where High Priest Pucci resides on your rightful seat.");
                        sleep(1);
                        type("However, while walking there you come to the realisation that maybe he could be a better ruler for your country and people than you would end up being.");
                        sleep(1);
                        type("As you come to this realisation, you notice that you are right next to the palace entrance way.");
                        sleep(1);
                        type("You now have to decide whether to leave the palace forever, or continue forwards to kill High Priest Pucci and take back your throne");
                        sleep(1);
                        type("Which do you decide to do? [Continue] [Leave]");
                        sleep(1);
                        
                        answer = Console.ReadLine();
                        if (answer == "Continue")
                        {
                            sleep(1);
                            room = "throneRoom";
                            roomSwitch();
                        }

                        else if (answer == "Leave")
                        {
                            sleep(1);
                            type("You decided that High Priest Pucci would be a better ruler of your kingdom than you would be, so you decided to leave the palace without killing him, and venture into the forests and live in a cabin");
                            sleep(1);
                            Cabin();
                            Environment.Exit(0);
                        }
                    }
                }

                fightFlight();
                eswitch();
                checkDeath();
            }

            //Only Spawns if Prisoner and Chef are killed
            if (prisonerKilled == true && chefKilled == true && e == 3)
            {

                checkDeath();
                type(spawnMessage3);
                checkDeath();
                Pucci();


                if (enemySpawned == 3)
                {
                    checkDeath();
                    while (enemySpawned == 3)
                    {
                        checkDeath();
                        pucciMsg();
                        answer = Console.ReadLine();

                        if (fryingPan != true)
                        {   //Player chose slash                            
                            if (answer == "Slash" ^ answer == "slash" ^ answer == "1" ^ answer == "s")
                            {
                                checkDeath();
                                rndDam();

                                if (playerCritchance == 1)
                                {
                                    checkDeath();
                                    playerSlashCrit();
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                }

                                else if (playerCritchance != 1)
                                {
                                    checkDeath();
                                    Console.WriteLine($"You slashed your weapon at High Priest Pucci for {playerSlashDamage} damage");
                                    enemyHP = enemyHP - playerSlashDamage;
                                }

                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    checkDeath();
                                    pucciAttack();
                                }
                                checkDeath();
                                pucciDeath();
                                checkDeath();
                                pucciKill();
                            }
                            //Player chose Stab
                            if (answer == "Stab" ^ answer == "stab" ^ answer == "2" ^ answer == "t")
                            {
                                rndDam();
                                checkDeath();
                                if (playerCritchance == 1)
                                {
                                    checkDeath();
                                    playerStabCrit();
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                }

                                else if (playerCritchance != 1)
                                {
                                    checkDeath();
                                    Console.WriteLine($"You thrust  your weapon into High Priest Pucci for {playerStabDamage} damage");
                                    enemyHP = enemyHP - playerSlashDamage;
                                }

                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    checkDeath();
                                    pucciAttack();
                                }
                                checkDeath();
                                pucciDeath();
                                checkDeath();
                                pucciKill();
                                checkDeath();
                            }
                            //Player chose Block
                            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
                            {
                                checkDeath();
                                rndDam();
                                playerblockchance = 1;
                                checkDeath();
                                blockedPucci();
                                blockedPucciFail();
                                checkDeath();
                                pucciKill();
                                checkDeath();
                            }
                            //Player chose heal
                            else if (answer == "Heal" ^ answer == "heal" ^ answer == "3" ^ answer == "c")
                            {
                                checkDeath();
                                rndDam();
                                playerHeal();
                                checkDeath();
                                pucciDeath();
                                checkDeath();
                                pucciKill();
                                checkDeath();
                            }
                        }

                        else if (fryingPan == true)
                        {   //Player chose Smack
                            if (answer == "Smack" ^ answer == "smack" ^ answer == "1" ^ answer == "s")
                            {
                                checkDeath();
                                rndDam();

                                if (playerCritchance == 1)
                                {
                                    checkDeath();
                                    playerFryCrit();
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                }

                                else if (playerCritchance != 1)
                                {
                                    checkDeath();
                                    Console.WriteLine($"You smacked High Priest Pucci for {playerFryDamage} damage");
                                    enemyHP = enemyHP - playerFryDamage;
                                }

                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    checkDeath();
                                    pucciAttack();
                                }
                                checkDeath();
                                pucciDeath();
                                checkDeath();
                                pucciKill();
                            }
                            //Player chose Block
                            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
                            {
                                checkDeath();
                                rndDam();
                                playerblockchance = 1;

                                blockedPucci();
                                blockedPucciFail();
                                pucciKill();

                            }
                            //Player chose heal
                            else if (answer == "Heal" ^ answer == "heal" ^ answer == "3" ^ answer == "c")
                            {
                                checkDeath();
                                rndDam();
                                playerHeal();
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                pucciDeath();
                                checkDeath();
                                pucciKill();
                                checkDeath();
                            }

                        }
                    }

                    checkDeath();
                    roomSwitch();
                    fightFlight();
                    eswitch();

                }
            }
        }



        //If the enemy chance is not 1 then nothing will spawn
        else if (enemyChance != 1)
        {
            enemySpawned = 0;
        }




        //Function for the throne
        void throne()
        {
            Console.WriteLine(@"        ▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▓▒▒▓▓▓▓▓▓            
        ▒▒▓▓████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓            
        ░░▒▒▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██            
          ▓▓▓▓▓▓██▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒            
          ▓▓▓▓████▓▓▓▓▒▒▓▓▓▓▓▓▓▓████▓▓▓▓████▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒              
          ░░▓▓▓▓▓▓██▓▓▒▒▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▒▒██▓▓▓▓▒▒▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓██              
            ▓▓██▓▓██▓▓▒▒▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▒▒              
            ▓▓████▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▓▓▓██▓▓▓▓▓▓                
            ░░▓▓██▓▓██▓▓▓▓██████▒▒▓▓████▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▒▒▓▓                
              ▓▓██▓▓██▓▓▓▓▓▓██▓▓▓▓▓▓████▒▒▓▓████▓▓██████████▓▓▓▓▓▓                  
              ▓▓▓▓██▓▓██▒▒▓▓▓▓▓▓▒▒▓▓▓▓▓▓▒▒▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓██▓▓▒▒▒▒                  
              ░░▓▓██▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓██▒▒                    
                ▓▓██████▓▓▓▓▓▓▓▓████▓▓▓▓████▒▒▓▓██▒▒▓▓▓▓██▓▓▒▒▓▓                    
                ▓▓████████▓▓▓▓▓▓████▓▓▓▓▓▓██▓▓████▓▓▓▓▓▓▓▓██░░                      
                ░░▓▓██████▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓██▓▓▓▓▒▒                      
                  ▓▓██▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓                      
                  ▓▓████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▒▒░░                      
                  ░░████████▓▓▓▓▓▓▓▓████▒▒▓▓██▓▓▓▓▓▓██▓▓██▒▒                        
                    ████▓▓▓▓██▓▓▓▓▓▓▒▒▓▓▓▓▓▓▒▒▓▓▓▓▓▓██▓▓▓▓▓▓                        
                    ▓▓██▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░                        
                    ▓▓████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓██▓▓                          
                    ░░▓▓████████████▓▓██████▓▓██████▓▓██▓▓                          
                      ██████▓▓▓▓▒▒██▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▒▒                          
                      ████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░                          
                      ██████▓▓▓▓▒▒▓▓██▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓                            
                  ▓▓▓▓██████▓▓▓▓▓▓▓▓████▓▓████▓▓▓▓▓▓▓▓████▓▓                        
                  ▓▓████▓▓██▓▓▒▒▓▓▓▓▒▒▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓████                        
              ░░▒▒████▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████▓▓░░                    
        ░░▒▒▒▒▓▓▓▓██▓▓██▓▓██▓▓▓▓████▓▓████▓▓▓▓▓▓██▓▓████████▓▓▓▓▓▓▓▓▒▒▒▒░░          
      ▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓████████████▓▓████▓▓██████████▓▓▓▓▓▓▓▓▒▒▒▒▒▒░░      
    ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▒▒██▓▓██▓▓██▓▓▒▒██▓▓██████████████▓▓▓▓▓▓▓▓▓▓▓▓▒▒    
  ▓▓▓▓▓▓▒▒▒▒▒▒▒▒▓▓▓▓██████████▓▓▓▓▓▓████▓▓▓▓▓▓▓▓▓▓████████████████▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓  
  ▓▓▓▓▓▓████▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓████▓▓▓▓▓▓▓▓▓▓██████████████▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▒▒
░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓██████▓▓██▓▓▓▓▓▓████████████▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓
  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████████▓▓████████████▓▓████████████████▓▓▓▓▓▓██▓▓▒▒▓▓▓▓████
  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████████████████████████████████████████▓▓▓▓▓▓▓▓▓▓██▓▓██████
  ▒▒████▓▓████▓▓▓▓▓▓████████████████████████████████████████████▓▓▓▓▓▓██████████▓▓██
  ▒▒██████████████▓▓████████████████████████████████████████████▓▓▓▓██████████▓▓▓▓  
    ▓▓██▓▓▓▓████▓▓▓▓████████████████████████████████████████████▓▓▓▓▓▓██████▓▓▓▓    
      ▓▓▓▓████████▓▓████████████████████████▓▓██████████████████▓▓▓▓▓▓██████████    
      ▓▓████████▓▓▒▒████████████████████████▓▓██████████████████▓▓▓▓██▓▓████████▓▓  
    ▓▓████████▓▓▒▒▓▓████████████████████████▓▓████████████████████▓▓▓▓▓▓▓▓██▓▓▓▓▓▓  
    ▒▒▓▓▓▓▓▓▓▓██▒▒▓▓████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓██████████  
    ██▓▓▓▓▓▓██▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓▓▓▓▓██████▒▒  
    ▒▒██████▓▓▓▓▓▓██████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓██▓▓▓▓▓▓▓▓██████  
    ▒▒██▓▓██▓▓▓▓▓▓████▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓████████  
    ▓▓██████████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████▒▒████████  
    ████████▓▓████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████▓▓████████████▓▓██████    
    ▒▒████████▓▓██▓▓████████████████████████████████████████████▓▓▓▓▓▓▓▓██▓▓████    
      ██▓▓▒▒▓▓██▓▓██▓▓▓▓██▒▒▓▓▓▓▓▓▒▒▒▒▒▒▓▓▒▒██▓▓██▓▓▓▓▓▓████▓▓██████████████████    
      ▓▓██████████████▓▓██▓▓▓▓████▓▓▓▓▓▓▓▓▓▓██████████████████████▓▓▓▓██████████    
      ▓▓▓▓██████████████████████████████▓▓██████▓▓██████████▓▓████  ██████████▓▓    
      ▓▓████████░░░░░░████▓▓██▓▓▓▓▓▓██▓▓████▓▓▓▓██▓▓██████▒▒▓▓░░    ██▓▓▓▓██▓▓      
      ░░██▓▓▓▓██      ████▓▓▒▒████████▓▓████▓▓████▓▓▓▓▓▓██          ▓▓██████▓▓▒▒    
      ▒▒██▓▓▓▓▓▓              ░░████▒▒████████████▓▓████              ▓▓██▓▓██▓▓    
      ░░████████                  ▓▓▓▓░░  ▒▒██▒▒                      ▓▓▓▓▓▓▓▓      
      ▓▓████▓▓▓▓                                                      ▒▒████▓▓      
      ░░▓▓▓▓▓▓▒▒                                                        ██▓▓██▓▓    
        ▓▓████                                                          ▒▒▓▓▓▓      
      ░░▓▓▒▒▓▓                                                            ▒▒▒▒      
      ▒▒▓▓▓▓░░                                                                      
        ▓▓██░░                                                                      ");

        }
        //Function for the Prison Cell
        void cellroom()
        {
            Console.WriteLine(@"     \                  ###########                  /
                              \                  #########                  /
                               \                                           /
                                \                                         /
                                 \                                       /
                                  \                                     /
                                   \                                   /
                                    \_________________________________/
                                    |                                 |
                                    |                                 |
                                    |                                 |
                                    |            _________            |
                                    |           |         |           |
                                    |           |   ___   |           |
                                    |           I  |___|  |           |
                                    |           |         |           |
                                    |           |         |           |
                                    |           |        _|           |
                                    |           |       |#|           |  ;,
                            -- ___  |           |         |           |   ;'
                            H*/   ` |           |         |      _____|    .,`
                            */     )|           I         |     \_____\     ;'
                            /___.,';|           |         |     \\     \     .""`
                                    |     ; |___________|_________|______\\     \      ;:
                                    | ._,'  /                             \\     \      .
                                    |,'    /                               \\     \
                                    ||    /                                 \\_____\
                                    ||   /                                   \_____|
                                    ||  /              ___________                \
                                    || /              / =====o    |                \
                                    ||/              /  |   /-\   |                 \
                                    //              /   |         |                  \
                                   //              /    |   ____  |______             \
                                  //              /    (O) |    | |      \             \
                                 //              /         |____| |  0    \             \
                                //              /          o----  |________\             \
                                /              /                  |     |  |              \
                                              /                   |        |               \
                                             /                    |        |             leb
                                            /                     |        |

");
            sleep(1);
        }
        //Function for the Kitchen
        void kitchenroom()
        {
            Console.WriteLine(@"   ____________________________________________________________________    
 /|    |__I__I__I__I__I__I__I__I__I_|       _-       %       %         |\
  | _- |_I__I__I__I__I__I__I__I__I__|-_              %       %     _-  | 
  |    |__I__I__I__I__I__I__I__I__I_|                %       %         |
  |  - |_I__I__I__I__I__I__I__I__I__|               ,j,      %w ,      |
  | -  |__I__I__I__I__I__I__I__I__I_|  -_ -        / ) \    /%mMmMm.   |
  |    |_I__I__I__I__I__I__I__I__I__|             //|  |   ;  `.,,'    |
  |-_- /                            \             w |  |   `.,;`       |
  |   /                              \    -_       / ( |    ||         |
  |  /                                \           //\_'/    (.\    -_  |
  | /__________________________________\          w  \/   -  ``'       |
  | |__________________________________|                               |
  |    |   _______________________   |     _-            -             |
  |_-  |  |                       |  |                        _-       |
  |    |  |                     _ |  |  T  T  T  T  T                  |
  | _-_|  |    __.'`'`'`''`;__ /  |  |  |  |  |  |  |        _-     -  |
  |    |  | _/U  `'.'.,.,"".'  U   |  |  | (_) |  |  |                  |
  |    |  |   |               |   |  | / \    @ [_]d b    _@_     |    |   
  |    |  |   |      `', `,   |   |  | |_|   ____         [ ]     |    |
  |_-  |  |   |   `') ( )'    |   |  | ______\__/_________[_]__   |    | 
  |    |  |   |____(,`)(,(____|   |  |/________________________\  |    |
  |    |  |  /|   `@@(@@)@)'  |\  |  | ||            _____   ||   |    |
  |    |  | //!\  @@)@@)@@@( /!\\ |  | ||   _--      \   /   ||  /|\   |
  |__lc|__|/_____________________\|__|_||____________/###\___||_|||||__|
 / -_  _ -      _ -   _-_    -  _ - _ -|| -_    _  - \___/_- || |||||-_ \ ");
            sleep(1);
        }

        //Function for the throne room
        void throneroom()
        {
            Console.WriteLine(@"██████      ░░████████████████████████      ░░████████████████████████      ░░████████████████████████████████████████████████████████████████████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░████████████████████████████████████████████████████████████████████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░████████████████████████████████████████████████████████████████████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░████████████████████████████████████████████████████████████████████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░████████████████████████████████████████████████████████████████████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░████████████████████████████████████████████████████████████████████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░████████████████████████████████████████████████████████████████████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░████████████████████████████████████████████████████████████████████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░██████████████████████▓▓██████████████████████████████████████▓▓████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░██████████████████████▓▓▓▓████████████░░░░██████████████████▓▓▓▓████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░██████████████████████▓▓▓▓▓▓██████████  ██▓▓██████████████▓▓▓▓▓▓████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░██████████████████████▓▓▓▓▓▓▓▓████▒▒████░░▒▒██▒▒▒▒██████▓▓▓▓▓▓▓▓████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░██████████████████████▓▓▓▓▓▓▓▓██  ██▒▒▓▓▓▓░░▒▒██  ██████▓▓▓▓▓▓▓▓████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░██████████████████████▓▓▓▓▓▓▓▓  ██▒▒██▒▒████▒▒██  ██████▓▓▓▓▓▓▓▓████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░██████████████████████▓▓▓▓▓▓██▒▒██░░██████░░██░░████████▓▓▓▓▓▓▓▓████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░██████████████████████▓▓▓▓▓▓▒▒░░██▓▓▓▓▓▓▓▓▒▒░░░░▒▒██████▓▓▓▓▓▓▓▓████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░██████████████████████▓▓▓▓▓▓▒▒░░██░░▓▓▓▓▓▓▒▒██░░▒▒██████▓▓▓▓▓▓▓▓████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░██████████████████████▓▓▓▓██▒▒░░██████████▓▓██░░▒▒██████▓▓██▓▓██████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████      ░░████████████████████████      ░░████████████████████████      ░░██████████████████████▓▓████▒▒░░████▓▓▓▓██▓▓██░░▒▒██████████████████████████████      ░░████████████████████████      ░░████████████████████████      ░░██████
██████░░    ▓▓████████████████████████░░    ▓▓████████████████████████░░    ▓▓██████████████████▓▓████▒▒██▒▒░░██████  ██████░░▒▒██████████████████████████████░░    ▓▓████████████████████████░░    ▓▓████████████████████████░░    ▓▓██████
██████░░    ▒▒████████████████████████░░    ▒▒████████████████████████░░    ▒▒████████████████████▒▒██▒▒██▒▒░░██████████▒▒██░░▒▒██▒▒██▒▒▓▓████████████████████░░    ▒▒████████████████████████░░    ▒▒████████████████████████░░    ▒▒██████
██████      ░░▓▓██████████████████████      ░░▓▓██████████████████████      ░░▓▓██████████████████▓▓████▒▒▒▒░░████    ██████░░▒▒██████████▒▒██████████████████      ░░▓▓██████████████████████      ░░▓▓██████████████████████      ░░▓▓████
░░░░▒▒░░    ▒▒██░░░░░░░░░░░░░░░░░░░░▒▒░░    ▒▒██░░░░░░░░░░░░░░░░░░░░▒▒░░    ▒▒██░░░░░░░░░░░░░░░░██████████▒▒████░░██▓▓██▓▓██░░▒▒██▒▒▓▓██▒▒████░░░░░░░░░░░░░░▒▒░░    ▒▒██░░░░░░░░░░░░░░░░░░░░▒▒░░    ▒▒██░░░░░░░░░░░░░░░░░░░░▒▒░░    ▒▒██░░░░
▒▒▒▒          ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒          ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒          ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░▓▓██▒▒▒▒████    ▒▒██▓▓▓▓░░▒▒████▓▓▓▓▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒          ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒          ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒          ░░▒▒▒▒
▒▒▒▒          ░░▒▒▓▓░░░░░░░░░░░░▒▒▒▒          ░░▒▒▓▓░░░░░░░░░░░░▒▒▒▒          ░░▒▒▓▓░░░░░░░░░░▒▒██░░░░░░▓▓▒▒▓▓██  ░░████████▒▒▒▒██░░░░░░▒▒████▒▒░░░░░░░░▒▒▒▒          ░░▒▒▓▓░░░░░░░░░░░░▒▒▒▒          ░░▒▒▓▓░░░░░░░░░░░░▒▒▒▒          ░░▒▒▓▓
  ██░░        ░░▓▓                ██░░        ░░▓▓                ██░░        ░░▓▓        ░░▓▓▓▓▓▓██░░▒▒████████▓▓▓▓▓▓██████████▓▓▓▓░░░░▓▓▓▓▓▓▓▓          ██░░        ░░▓▓                ██░░        ░░▓▓                ██░░        ░░▓▓  
                                                                                          ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████▓▓▓▓██▓▓████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓                                                                                            
                                                                                                            ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓                                                                                                                
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓██████████████████▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
                                                                                                  ██░░░░▒▒██████████████████░░░░▒▒                                                                                                          
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████    ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓    ░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▓▓▓▓██████████████████████▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
████████████████████████████████████████████████████████████████████████████████████████████████▒▒▒▒▒▒██████████████████████▒▒▒▒▒▒██████████████████████████████████████████████████████████████████████████████████████████████████████████
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██████████████████████████████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒████████████████████████▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒██▒▒▒▒██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                                                                                          ██░░░░▒▒██████████████████████████░░░░▒▒                                                                                                          
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████    ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓    ░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▓▓▓▓██████████████████████████████▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
                                                                        ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒                                                                                          
                                                                      ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░                                                                                          
                                                                    ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░                                                                                          
                                                                  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░                                                                                          
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████████████████████████████████████████████████████████████████████████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            sleep(1);
        }
        //Function for the Prisoner
        void prisoner()
        {
            Console.WriteLine(@"                     ▄██████▄                       
                     ▐████████Γ                      
                      ▀▒░&░░▒                        
                      ╘▄░▓▓░▐C                       
                      .█▒▓▓▒▓▓Ω;╥,                   
                 ,⌐─╦╣▓║╟▓▓▀┤▐▓╢▓, ,2>═              
               ▄Æ▀▓▓█▀m╩W▓▀¢J╨Ñ,▀▀ ▐▄▄▓▓▓▌           
              ▐██▀ÑPMN▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▀  @N          
             ▐▌░░░░░░░½╩╦     ,╓▓█Hw╓,▄▄▓▓▓         
             ▐▌░░▓█▄▒▓▓█▄▄▄▄▄▓▄▓▓▒▓▄▄▓▓▓▓▀▀ j        
             Ü▓▄▄████████████████████▓, ╢>,▄▓▄       
            /▓▓▓▓▓█▒▒╜`╙╙`╙╩▓▒▒╢▒╢╢▓▀`╚▓█▓▓▓▓▄⌐      
            ▓▄""▓█▀▒█▓▓▓▓▓▓▓▓█▓▓▓███    ▄▓▄▄▓ ▀█      
             ▓▓█▓██▌ ╝`▀▀`      ▒▓   ,▄▄▓ ▓██╩       
              ▀▓▓▌`▐▓█▓▓█▓▓▓▓▓▓███ ,▄Z▀▓███╜         
                   [`^╙╩~=Ö▓Å╗╬M▒▓▄▒▓▀██╩            
                   ▓▓██▄█▄▄▄▄██▓██▀╗╣▌╝`             
                  ,:¬▓▓▀▀▀█▓▓█▌═╜╙▒▓▒▓               
                  ▀▀▀▓█▄   ƒ▓▓▄▄▄▄▓▌╙▀▓              
               ,▓▓▓▄▄║▒▀█▓▓███▓█▓▀▀T                 
              ,  ,▀▓▓██▄▓▀▐▒╢U╢U   ,                 
             ╓█▓▓▓▄░╨╓▀█▌ ▐██▓▓▓▓▓▓▓                 
              ╟░▀▀▓▓██▒▀  ║▒▌▀▀▌`                    
            ▓▓▓▓▄▄▌╣▒█    ▐█▓▄▄▓▄▓▓▓                 
              `║▀▀▀█▀      ▓▀▀▀▀                     
            ██████▓█µ      ▐██▄▄█▓▌                  
             ▀▒▒▓▒▓▒█▌      ▓▀▀▀▀▓                   
              '█████▀▒@     ██▄▄▄█                   
                ▓▒▒▒▒▓█     ╣▀▀▓▓▒                   
                 ▀███▀▒▄▄   ██▄▓▄█▌                  
         ╓███████▄ ▓▄▓████  ▀█████▌                  
        ▄██████████ ██████▌ █▓▒╣╟▄                   
        ███████████▄▄▀█▀▒▒▌ ▌▀█▓█▀                   
        ▀█████████▀  ║▒▒▒╢  ██▄▄▌                    
          ▀█████▀    ╟╢╢╫   ╢▓▓█▌                    
                    ,▓╢╢▓   █▓▓▀▌                    
                   ▀▓╢▓╩   ]▒▒╢░▒                    
                            ▐▌φ░░╡▓                  
                             ```                    ");
            sleep(1);
        }
        //Function for Pucci
        void Pucci()
        {
            Console.WriteLine(@"                                                                                                                                                                                  
                                                ▄█████▄                                   
                                             ▄█████████▓█                                 
                                             █▀███║▀███▒▀k                                
                                             ███║╣▓╢▓█▓▓▒▒                                
                                             ▀▀█Ü▒╣╣▓▓▌╫▒░                                
                                             ▒▒╪▓▓ÜÄ▒▓█┼▒▒                                
                                              ╙▓▒╣▓▓▓▓▓▒▒`                                
                                              ▌▒▓╣╫▓▓╝░░▒                                 
                                 ╓h╖,,,,,,≡rò░░▀▄▀▀▓╢@φ¢'                                 
                              ╓¢░░░░░░░, `░░░░░▐φ▒╓╓``¿g ░░                               
                               ░░`░░`░░░░░░░░░ ▐╣██╣  '`░░ ░░,                            
                            ░░░`░ `.░░█▀▒░░░░░▓▒▒▒▀░`░░░░'░`'░░░,                         
                        ,≡▒░───░░░░▀████▄░░░░█▀▒█▒░░░░░░░░,,    ░░k                       
                     ╓m░░░░░░░░░░░░½█▀▒▀▀████▒██╜░░░░g░░░░░░░░░░░░░░m┐                    
                  ┌░░░░░░░░░░░░░'░░░▀░░░░½█▀▒████▄┤░░██░░░░`░░ ░░░░░░░`                   
               «Ü░░░░░`     ░      ░░░░░░╫▀▒█▀░┤▀▀████▄░░░░ ░░░░░░░`                      
               ░ `░░░░░░        ]░░░░░░░█▒g▒░`░░░░▒█▒▀▀█▌░░`░░░░░░   ░                    
                ░░░░░░░         ░░░░` ░▒█▒█▌░░. '▀▀▒░░░░░░` ░ '░``,░░                     
                ░░░░░░░          ░░ ░░░█▒█▌░░░░░░           ` ░░░░░░                      
                ░░░░░░           ░░░░░▐▓▒█▒░░░░░░░░░░░░░'  ░,░,░░.`░                      
                 ░░░░░,         ░░░░░░▓▌▓▌` `░░░░░░'`  ░    ░░`░░`                        
                 ░░░░`░░        └░'░░░▓▒▓▒   `░░░░          ░░░░░░                        
                  ╞███▒@         ░  ░▐▌▒▓C    '            /░░░░░$@█                      
                   ██▀▒╜         ░  ░▓▒▓▒         ░        ░░░░░██▌█Ü▄                    
                    ░░░░░░     ]░░░ ░╜░▒~     ░░  ,        ¿░░░▐█║▒▒▒▓▄ ,▄,               
                     ░░░░░░,   ░░ ░▄▒░╢░     ░░  ░░        ░░░▓▓▀▒▒▒▒▒▒╝└╙""               
                      ░▄████▒▀░ ░░ ▒▒█▒,,░' ░░░░           ░░░░ÑH▒▒▒▒▒                    
                       ▒█▀▓▀█░░ ░░░░▒▒▒░  ░' ░             ░`   `'`                       
                       ▐▌ ▀▄,█¿░░ `▀▒Æ▌░░` ░░░░░            `░   ░                        
                       ▐▌  ▀▌░▀ ▒░ ▐▒▒▒`  ░ ░░░░░`   ░                                    
                        ▒   ░░░ ░▒`▓▒▓▌  ░  ░░░`░░                                        
                            `░░░'░░▓▒╟▌░░ ,░░░¿░░                                         
                            ░░░ ░░ ▒▒▐▒░░░,░░░░░░░                                        
                            ░░░░ ░ └▒▒░`░░▒░░░░░░                                         
                            ▒`░░░ ░░▒░░░░░░░░░░░░    ░                                    
                            ║░░░░  ▐░░░░░░░░░░`                                           
                            ]░`░░░ ░░░░░░░░░░░░░░`                                        
                             ▒░`░░░░░▒▒▒░░░░░░░░                                          
                             ]░░`░░▒░░░░░░░░░░                                            
                              ▒░░░░░░░░░░░░`                                              
                              ]░▒░░░░░░░                                                  
                               ░▒░░░░░      ░░                                            
                              ╓╣░░░░░░░'''    ░                                           
                              ▒▒░░░░░░                                                    
                                 `░░░░░░      `                                           
                                ░.  ░░░░░░,     '                                         
                               ░░,`░░░░░░░░░░░,,  ░»»,,,,,╖╖╖╖╖╖╖,,,                      
                             ]░░░░▒╖░░`░░░░░░░░░░░░    `'░░``'░░░░░░░░▒                   
                             ░░░░╘W░░░▒░,   `░░░░~,`              `░░░░░,                 
                          .░░░░▒░░░░╚╨φ▄░░░░░░░░░░░░░░░─,`              ░                 
                       ,ó░░░ ░█░░░░░   '▀▀N▄░░░░░░░░░░░░░░░░─, ░                          
                     ∩▒░ ░░░░█▌░░░░░░  ░   ""▀▀█φ░░░░░░░░░░░░░░░▒─,                        
                   ╓▒`  ░░░░▐█▒░░░░░░░  ░      ╙▀██▄░░░░░░░░░░░░░░░                       
                  ]░`  ░░░░░█▌░░░░░░░`   '        '▀▀█&▄░░░░░░░░░░░▒                      
                  ░░   ░░░░╟█▒╜` ▒░░h      ░          ╙▀██▄░░░░░░░░─                      
                  ░    ░░░░██`   ▒░░h   ░   ░         ░  ╙▀██▄░░░░░                       
                      ░░░░░█▌    ╙▒▒     ░   ░░             ▀▀██g░`                       
                      ┌░░░▐█▌                `░░              '▀██                        
                       ░░░▐█▌                 ░░        ░,       ""                        
                         `╙█▌                   ░        ░░░                              
                                               `  ░¿░   ░░░░╢▓                            
                                            ∩─     ░░,░░░░░║▒╩                            
                                             ░      \░░░░░]╙""                             
                                              ░░░   `░░░░░░                               
                                              ░░`    ║@░░░░K                              
                                            ╔╣▒░,    ║▒▒░░j                               
                                         ╓@▒▒▒░░░░░░░╢╜░░)                                
                                    ╓Ñ╜╙╜░░░░░░,░╛╢╢ß▒░░X                                 
                                   ╙┴═+~∞░░░░═`   ╙╜╜╙╜└                                  
                                                                                ");
            sleep(1);
        }
        //Function for the Chef
        void Chef()
        {
            Console.WriteLine(@"       .--,--.
                               `.  ,.'
                                |___|
                                :o o:   O    
                               _`~^~'_  |    
                             /'   ^   `\=)
                           .'  _______ '~|
                           `(<=|     |= /'
                               |     |
                               |_____|
                        ~~~~~~~ ===== ~~~~~~~~");
            sleep(1);
        }
        //Function for the Cabin
        void Cabin()
        {
            Console.WriteLine(@"
.
                           (   )
                          (    )
                           (    )
                          (    )
                            )  )
                           (  (                  /\
                            (_)                 /  \  /\
                    ________[_]________      /\/    \/  \
           /\      /\        ______    \    /   /\/\  /\/\
          /  \    //_\       \    /\    \  /\/\/    \/    \
   /\    / /\/\  //___\       \__/  \    \/
  /  \  /\/    \//_____\       \ |[]|     \
 /\/\/\/       //_______\       \|__|      \
/      \      /XXXXXXXXXX\                  \
        \    /_I_II  I__I_\__________________\
               I_I|  I__I_____[]_|_[]_____I
               I_II  I__I_____[]_|_[]_____I
               I II__I  I     XXXXXXX     I
            ~~~~~""   ""~~~~~~~~~~~~~~~~~~~~~~~~");
            sleep(1);
        }
    }
}