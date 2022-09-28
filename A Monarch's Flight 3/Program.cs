using System;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{
    public static void Main(string[] args)
    {
        // I have not added comments all throughout the code yet, but I am planning on doing that soon

        Random rnd = new Random();
        string spawnMessage1;
        string spawnMessage2;
        string spawnMessage3;
        string deathMessage1;
        string deathMessage2;
        string deathMessage3;
        int enemyChance = 0;
        int enemyHP = 1;
        int playerHP = 10000;
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


        spawnMessage3 = "High Priest Pucci appeared before you";
        spawnMessage2 = "The Palace Chef appeared before you";
        spawnMessage1 = "The enemy prisoner appeared before you";
        deathMessage3 = "Congratulations, you have defeated High Priest Pucci";
        deathMessage2 = "You deafeated the Palace Chef, no more food for a while";
        deathMessage1 = "You vanquished the enemy prisoner";

        bool blocking = false;

        bool sword = true;
        bool fryingPan = false;
        bool knife = false;
        bool chefKilled = false;
        bool prisonerKilled = false;
        bool pucciKilled = false;



        void checkDeath()
        {
            if (playerHP <= 0)
            {
                playerHP = 0;
            }
        }

        void playerHeal()
        {
            if (Heals > 0)
            {
                healthgain = rnd.Next(10, 20);
                Console.ForegroundColor = ConsoleColor.Green;
                sleep(1);
                Console.WriteLine("You swiftly grab the red potion from you side and down it..");
                Heals = Heals - 1;
                sleep(1);
                Console.WriteLine($"You have {Heals} Potions left!");
                sleep(1);
                Console.WriteLine($"You Gain {healthgain} Health!");
                sleep(1);
                Console.ForegroundColor = ConsoleColor.White;

                playerHP = playerHP + healthgain;
                checkDeath();
                Console.WriteLine($"You have {playerHP} Health");
                sleep(1); 
            }

            else if (Heals! > 0)
            {
                if (Heals > 0)
                {
                    healthgain = rnd.Next(10, 20);
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("You swiftly grab the red potion from you side and down it..");
                    Heals = Heals - 1;
                    sleep(1);
                    Console.WriteLine($"You have {Heals} Potions left!");
                    sleep(1);
                    Console.WriteLine($"You Gain {healthgain} Health!");
                    sleep(1);
                    Console.ForegroundColor = ConsoleColor.White;

                    playerHP = playerHP + healthgain;
                    checkDeath();
                    Console.WriteLine($"You have {playerHP} Health");
                    sleep(2);
                }
            }
        }

        void pucciMsg()
        {
            Console.WriteLine($"High Priest Pucci has {enemyHP} Health");
            sleep(1);

            if (fryingPan != true)
            {
                Console.WriteLine("What would you like to do? [Slash] [Stab] [Block] [Heal]");

            }

            else
            {
                Console.WriteLine("What would you like to do [Smack] [Block] [Heal]");
            }
        }

        void prisonerMsg()
        {
            Console.WriteLine($"The enemy prisoner has {enemyHP} Health");
            sleep(1);

            if (fryingPan != true)
            {
                Console.WriteLine("What would you like to do? [Slash] [Stab] [Block] [Heal]");

            }

            else
            {
                Console.WriteLine("What would you like to do [Smack] [Block] [Heal]");
            }
        }

        void chefMsg()
        {
            Console.WriteLine($"The Palace Chef has {enemyHP} Health");
            sleep(1);

            if (fryingPan != true)
            {
                Console.WriteLine("What would you like to do? [Slash] [Stab] [Block] [Heal]");

            }

            else
            {
                Console.WriteLine("What would you like to do [Smack] [Block] [Heal]");
            }
        }

        void pucciCrit()
        {
            if (enemyCritchance == 1)
            {
                Console.WriteLine("High Priest Pucci has contolled his emotions and packed them into a single devastating punch!");
                sleep(1); 
                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                checkDeath();
                Console.WriteLine($"You now have {playerHP} Health Left ");
                sleep(1);
            }
        }

        void prisonerCrit()
        {
            if (enemyCritchance == 1)
            {
                Console.WriteLine("The prisoner was able to land a dangerous punch on you!");
                sleep(1);
                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                checkDeath();
                Console.WriteLine($"You now have {playerHP} Health Left ");
                sleep(1);
            }
        }

        void chefCrit()
        {
            if (enemyCritchance == 1)
            {
                Console.WriteLine("The Palace Chef has used his knowledge about food and cutlery to predict what your next move would be and strikes where it would hurt you most!");
                sleep(1);
                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                checkDeath();
                Console.WriteLine($"You now have {playerHP} Health Left ");
                sleep(1);
            }
        }

        void pucciCritless()
        {
            if (enemyCritchance != 1)
            {
                Console.WriteLine($"High Priest Pucci dealt you {enemydamage} damage ");
                playerHP = playerHP - enemydamage;
                checkDeath();
                Console.WriteLine($"You now have {playerHP} Health Left ");
                sleep(1);
            }
        }

        void prisonerCritless()
        {
            if (enemyCritchance != 1)
            {
                Console.WriteLine($"The prisoner dealt you {enemydamage} damage ");
                playerHP = playerHP - enemydamage;
                checkDeath();
                sleep(1);
                Console.WriteLine($"You now have {playerHP} Health Left ");
                sleep(1);
            }
        }

        void chefCritless()
        {
            if (enemyCritchance != 1)
            {
                Console.WriteLine($"The Palace Chef dealt you {enemydamage} damage ");
                sleep(1); 
                playerHP = playerHP - enemydamage;
                checkDeath();
                Console.WriteLine($"You now have {playerHP} Health Left ");
                sleep(1);
            }
        }

        void pucciAttack()
        {

            Console.WriteLine($"High Priest Pucci has {enemyHP} Health");
            sleep(1);
            pucciCrit();

            pucciCritless();
        }

        void prisonerAttack()
        {

            Console.WriteLine($"The prisoner has {enemyHP} Health");
            sleep(1);
            prisonerCrit();

            prisonerCritless();
        }

        void chefAttack()
        {

            Console.WriteLine($"The Palace Chef has {enemyHP} Health");
            sleep(1);
            chefCrit();

            chefCritless();
        }

        void playerSlashCrit()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("You get ready to release your anger upon your enemy!");
            sleep(1);

        playerSlashDamage = playerSlashDamage * 2;
            Console.WriteLine($"You were able to slash your enemy with your weapon {playerSlashDamage} Damage!");
            sleep(1);
            enemyHP = enemyHP - playerSlashDamage;
            Console.ForegroundColor = ConsoleColor.White;
        }

        void playerStabCrit()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("You get ready to release your anger upon your enemy!");
            sleep(1);

            playerStabDamage = playerStabDamage * 2;
            Console.WriteLine($"You managed to thrust your weapon into your enemy's body and dealt {playerStabDamage} Damage!");
            sleep(1);
            enemyHP = enemyHP - playerStabDamage;
            Console.ForegroundColor = ConsoleColor.White;
        }

        void playerFryCrit()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("You get ready to release your anger upon your enemy!");
            sleep(1);

            playerStabDamage = playerStabDamage * 2;
            Console.WriteLine($"You were able to smack your enemy in the head with your frying pan and dealt {playerStabDamage} Damage!");
            sleep(1);
            enemyHP = enemyHP - playerStabDamage;
            Console.ForegroundColor = ConsoleColor.White;
        }

        void blockedPucci()
        {
            if (playerblockchance == 1 && enemyCritchance != 1)
            {
                sleep(1);
                Console.WriteLine($"High Priest Pucci dealt you {enemydamage} damage ");
                sleep(1);
                Console.WriteLine("However, you were able to put your guard up in time, and Pucci hardly dealt any damage to you");
                sleep(1);
                playerHP = playerHP - 1;
                checkDeath();
                Console.WriteLine($"You now have {playerHP} Health Left ");
                sleep(1);

            }
        }

        void blockedPrisoner()
        {
            if (playerblockchance == 1 && enemyCritchance != 1)
            {
                sleep(1);
                Console.WriteLine($"The prisoner dealt you {enemydamage} damage ");
                sleep(1);
                Console.WriteLine("However, you were able to put your guard up in time, and the prisoner hardly dealt any damage to you");
                sleep(1);
                playerHP = playerHP - 1;
                checkDeath();
                Console.WriteLine($"You now have {playerHP} Health Left ");
                sleep(1);

            }
        }

        void blockedChef()
        {
            if (playerblockchance == 1 && enemyCritchance != 1)
            {
                sleep(1);
                Console.WriteLine($"The Palace Chef attempted to deal you {enemydamage} damage ");
                Console.WriteLine("However, you were able to put your guard up in time, and hardly dealt any damage to you");
                sleep(1);
                playerHP = playerHP - 1;
                checkDeath();
                Console.WriteLine($"You now have {playerHP} Health Left ");
                sleep(1);

            }
        }

        void blockedPucciFail()
        {
            if (playerblockchance == 1 && enemyCritchance == 1)
            {
                sleep(1);
                Console.WriteLine("High Priest Pucci has contolled his emotions and packed them into a single devastating punch!");
                sleep(1);
                Console.WriteLine("You attempted to block High Priest Pucci's attack, but he broke through your guard and hit you with his devastating punch!");
                sleep(1);
                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                checkDeath();
                Console.WriteLine($"You now have {playerHP} Health Left ");
                sleep(1);

            }
        }

        void blockedPrisonerFail()
        {
            if (playerblockchance == 1 && enemyCritchance == 1)
            {
                sleep(1);
                Console.WriteLine("The prisoner has contolled his emotions and packed them into a single devastating punch!");
                sleep(1);
                Console.WriteLine("You attempted to block the prisoner's attack, but he broke through your guard and hit you with his devastating punch!");
                sleep(1);
                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                checkDeath();
                Console.WriteLine($"You now have {playerHP} Health Left ");
                sleep(1);
            }
        }

        void blockedChefFail()
        {
            if (playerblockchance == 1 && enemyCritchance == 1)
            {
                sleep(1);
                Console.WriteLine("The Palace Chef has contolled their emotions and packed them into a single devastating punch!");
                sleep(1);
                Console.WriteLine("You attempted to block The Palace Chef's attack, but they broke through your guard and hit you with their devastating attack!");
                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                checkDeath();
                sleep(1);
        Console.WriteLine($"You now have {playerHP} Health Left ");

            }
        }

        void pucciKill()
        {
            if (playerHP <= 0)
            {
                sleep(1);
                Console.WriteLine("High Priest Pucci has defeated you and stolen your throne");
                
                sleep(1);
             }
        }

        void prisonerKill()
        {
            if (playerHP <= 0)
            {
                sleep(1);
                Console.WriteLine("The prisoner in your cell has defeated you and stolen your throne");
                sleep(1);
                Environment.Exit(0);
            }
        }



        void chefKill()
        {
            if (playerHP <= 0)
            {
                sleep(1);
                Console.WriteLine("The Palace Chef has defeated you and allowed High Priest Pucci to steal your throne");
                sleep(1);
                Environment.Exit(0);
            }
        }

        void pucciDeath()
        {
            if (enemyHP <= 0)
            {
                enemySpawned = 0;
                pucciKilled = true;
                sleep(1);
                Console.WriteLine(deathMessage3);
                sleep(1); ;
                Console.WriteLine("You have now regained your rightful seat on your throne.");
                sleep(1);
                throne();
                Console.WriteLine("Well Done");
                sleep(1);
                Environment.Exit(0);
            }
        }

        void prisonerDeath()
        {
            if (enemyHP <= 0)
            {
                enemySpawned = 0;
                prisonerKilled = true;
                Console.WriteLine(deathMessage1);
                
               


            }
        }



        void chefDeath()
        {
            if (enemyHP <= 0)
            {
                enemySpawned = 0;
                chefKilled = true;
                Console.WriteLine(deathMessage2);
            }
        }

        void rndDam()
        {
            playerCritchance = rnd.Next(0, 10);
            enemyCritchance = rnd.Next(0, 10);

            playerblockchance = rnd.Next(0, 6);
            if (sword == true && knife == false && fryingPan == false)
            {
                playerSlashDamage = rnd.Next(20, 90);
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

        void roomSwitch()
        {
            switch (room)
            {
                case "cell":
                    sleep(1);
                    Console.WriteLine("You woke up in your palace dungeon in a small cell with a light in it.");
                    cellroom();
                    e = 1;
                    Console.WriteLine("A prisoner appears in your cell before you, what would you like to do? [Fight] [Flee]");
                    sleep(1);
                    fightflight = Console.ReadLine();
                    break;

                case "Kitchen":
                    sleep(1);
                    kitchenroom();
                    e = 2;
                    Console.WriteLine("You chose to enter the kitchen, and the chef appears before you, what would you like to do? [Fight] [Flee]");
                    sleep(1);
                    fightflight = Console.ReadLine();
                    break;

                case "throneRoom":
                    sleep(1);
                    throneroom();
                    Console.WriteLine("You proceeded from the Kitchen to the throne room. You are now in the presence of the High Priest Pucci! What would you like to do? [Fight] [Flee]?");
                    sleep(1);
                    e = 3;
                    fightflight = Console.ReadLine();
                    break;
            }

        }

        void fightFlight()
        {
            switch (fightflight)
            {
                case "Fight":
                    sleep(1);
                    Console.WriteLine("You decided to fight the enemy in front of you");
                    sleep(1);
                    enemyChance = 1;
                    break;

                case "Flee":
                    enemyChance = 0;
                    sleep(1);
                    Console.WriteLine("You decided to flee from the enemy in front of you and run back down into the dungoen cell to lock yourself in.");
                    sleep(1);
                    Console.WriteLine("You are now living in the palace dungeon cell for the rest of your life");
                    sleep(1);
                    Environment.Exit(0);
                    break;

            }
        }

        void eswitch()
        {
            switch (e)
            {
                case 1:
                    enemySpawned = 1;
                    enemyHP = rnd.Next(50, 150);
                    break;
                case 2:
                    enemySpawned = 2;
                    enemyHP = rnd.Next(75, 250);
                    break;
                case 3:
                    enemySpawned = 3;
                    enemyHP = rnd.Next(250, 400);
                    break;

            }
        }

        roomSwitch();
        fightFlight();
        eswitch();
        checkDeath();

        if (enemyChance == 1)
        {

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
                        {
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

                            if (answer == "Thrust" ^ answer == "thrust" ^ answer == "2" ^ answer == "t")
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
                                    Console.WriteLine($"You thrust  your weapon into High Priest Pucci for {playerStabDamage} damage");
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
                        }

                        else if (fryingPan == true)
                        {
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
                                    Console.WriteLine($"You smacked the Prisoner for {playerFryDamage} damage");
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
                        Console.WriteLine("You have killed the prisoner and are now able to escape the prison cell, what would you like to do? [Leave] [Stay]");
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
                            Console.WriteLine("You decided that it would be better for you to stay in the mangy palace dungeon cell for the rest of your days");
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


                Console.WriteLine(spawnMessage2);
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
                        {
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
                                    Console.WriteLine($"You were able to slash the Palace Chef for {playerSlashDamage} damage");
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

                            if (answer == "Stab" ^ answer == "stab" ^ answer == "2" ^ answer == "t")
                            {
                                rndDam();
                                checkDeath();
                                if (playerCritchance == 1)
                                {
                                    playerStabCrit();
                                    checkDeath();
                                }

                                else if (playerCritchance != 1)
                                {
                                    Console.WriteLine($"You thrust  your weapon intothe Palace Chef for {playerStabDamage} damage");
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

                            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
                            {

                                rndDam();
                                playerblockchance = 1;
                                checkDeath();
                                blockedChef();
                                blockedChefFail();
                                chefKill();
                            }

                            else if (answer == "Heal" ^ answer == "heal" ^ answer == "3" ^ answer == "c")
                            {
                                rndDam();
                                checkDeath();
                                playerHeal();
                                checkDeath();
                                chefDeath();
                                checkDeath();
                                chefKill();
                            }
                        }

                        else if (fryingPan == true)
                        {
                            if (answer == "Smack" ^ answer == "smack" ^ answer == "1" ^ answer == "s")
                            {
                                checkDeath();
                                rndDam();

                                if (playerCritchance == 1)
                                {
                                    playerFryCrit();
                                }

                                else if (playerCritchance != 1)
                                {
                                    checkDeath();
                                    Console.WriteLine($"You were able to smack the Palace Chef for {playerFryDamage} damage");
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

                            else if (answer == "Heal" ^ answer == "heal" ^ answer == "3" ^ answer == "c")
                            {
                                rndDam();
                                checkDeath();
                                playerHeal();
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

                        Console.WriteLine("You see two weapons in the kitchen before you leave, a knife and a frying pan, which would you like to take? [Knife] [FryingPan]");
                        sleep(1);
                        string weaponChoice = Console.ReadLine();
                        if (weaponChoice == "Knife" ^ weaponChoice == "knife")
                        {
                            knife = true;
                            fryingPan = false;
                            sword = false;
                            checkDeath();
                            Console.WriteLine("You decided to choose the knife");
                            sleep(1);
                        }
                        else if (weaponChoice == "FryingPan" ^ weaponChoice == "Fryingpan" ^ weaponChoice == "fryingpan")
                        {
                            fryingPan = true;
                            knife = false;
                            sword = false;
                        }
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Now that you have killed the palace chef you are able to walk towards the throne room where High Priest Pucci resides on your rightful seat.");
                        sleep(1);
                        Console.WriteLine("However, while walking there you come to the realisation that maybe he could be a beteer leader than you");
                        sleep(1);
                        Console.WriteLine("After coming to this realisation, you notice that you are right next to the palace entranceway.");
                        sleep(1);
                        Console.WriteLine("You now have to decide whether to leave the palace forever, or continue forwards to kill High Priest Pucci and take back your throne");
                        sleep(1);
                        Console.WriteLine("Which do you decide to do? [Continue] [Leave]");
                        sleep(1);
                        Console.ForegroundColor = ConsoleColor.White;
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
                            Console.WriteLine("You decided that High Priest Pucci would be a better ruler of your kingdom than you would be, so you decided to leave the palace without killing him, and venture into the forests and live in a cabin");
                            sleep(1);
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
                            Environment.Exit(0);
                        }
                    }
                }

                fightFlight();
                eswitch();
                checkDeath();
            }


            if (prisonerKilled == true && chefKilled == true && e == 3)
            {

                checkDeath();
                Console.WriteLine(spawnMessage3);
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
                        {
                            checkDeath();
                            if (answer == "Slash" ^ answer == "slash" ^ answer == "1" ^ answer == "s")
                            {
                                checkDeath();
                                rndDam();

                                if (playerCritchance == 1)
                                {
                                    checkDeath();
                                    playerSlashCrit();
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

                            if (answer == "Stab" ^ answer == "stab" ^ answer == "2" ^ answer == "t")
                            {
                                rndDam();
                                checkDeath();
                                if (playerCritchance == 1)
                                {
                                    checkDeath();
                                    playerStabCrit();
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

                                pucciKill();
                            }

                            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
                            {
                                checkDeath();
                                rndDam();
                                playerblockchance = 1;
                                checkDeath();
                                blockedPucci();
                                blockedPucciFail();
                                pucciKill();
                            }
                        }

                        else if (fryingPan == true)
                        {
                            if (answer == "Smack" ^ answer == "smack" ^ answer == "1" ^ answer == "s")
                            {
                                checkDeath();
                                rndDam();

                                if (playerCritchance == 1)
                                {
                                    checkDeath();
                                    playerFryCrit();
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

                            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
                            {
                                checkDeath();
                                rndDam();
                                playerblockchance = 1;

                                blockedPucci();
                                blockedPucciFail();
                                pucciKill();

                            }

                            else if (answer == "Heal" ^ answer == "heal" ^ answer == "3" ^ answer == "c")
                            {
                                checkDeath();
                                rndDam();
                                playerHeal();

                                pucciDeath();
                                pucciKill();
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




        else if (enemyChance != 1)
        {
            enemySpawned = 0;
        }


        void sleep(int seconds)
        {
            sleep(1);

        }


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
        }

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
        }

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
        }

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
        }

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
        }

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
        }
    }
}