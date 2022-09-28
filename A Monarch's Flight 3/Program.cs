using System;
using System.Runtime.InteropServices;

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
        int playerHP = 100;
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
        deathMessage3 = "High Priest Pucci has finally been eliminated and you have regained your throne";
        deathMessage2 = "You deafeated the Palace Chef, no more food for a while";
        deathMessage1 = "You vanquished the enemy prisoner";

        bool blocking = false;

        bool sword = true;
        bool fryingPan = false;
        bool knife = false;
        bool chefKilled = false;
        bool prisonerKilled = false;
        bool pucciKilled = false;




        void playerHeal()
        {
            if (Heals > 0)
            {
                healthgain = rnd.Next(10, 20);
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("You swiftly grab the red potion from you side and down it..");
                Heals = Heals - 1;
                ;
                Console.WriteLine($"You have {Heals} Potions left!");

                Console.WriteLine($"You Gain {healthgain} Health!");

                Console.ForegroundColor = ConsoleColor.White;

                playerHP = playerHP + healthgain;
                Console.WriteLine($"You have {playerHP} Health");
            }

            else if (Heals! > 0)
            {
                if (Heals > 0)
                {
                    healthgain = rnd.Next(10, 20);
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("You swiftly grab the red potion from you side and down it..");
                    Heals = Heals - 1;

                    Console.WriteLine($"You have {Heals} Potions left!");

                    Console.WriteLine($"You Gain {healthgain} Health!");

                    Console.ForegroundColor = ConsoleColor.White;

                    playerHP = playerHP + healthgain;
                    Console.WriteLine($"You have {playerHP} Health");
                }
            }
        }

        void pucciMsg()
        {
            Console.WriteLine($"High Priest Pucci has {enemyHP} Health");


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

                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                Console.WriteLine($"You now have {playerHP} Health Left ");

            }
        }

        void prisonerCrit()
        {
            if (enemyCritchance == 1)
            {
                Console.WriteLine("The prisoner was able to land a dangerous punch on you!");

                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                Console.WriteLine($"You now have {playerHP} Health Left ");

            }
        }

        void chefCrit()
        {
            if (enemyCritchance == 1)
            {
                Console.WriteLine("The Palace Chef has used his knowledge about food and cutlery to predict what your next move would be and strikes where it would hurt you most!");

                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                Console.WriteLine($"You now have {playerHP} Health Left ");

            }
        }

        void pucciCritless()
        {
            if (enemyCritchance != 1)
            {
                Console.WriteLine($"High Priest Pucci dealt you {enemydamage} damage ");
                playerHP = playerHP - enemydamage;
                Console.WriteLine($"You now have {playerHP} Health Left ");

            }
        }

        void prisonerCritless()
        {
            if (enemyCritchance != 1)
            {
                Console.WriteLine($"The prisoner dealt you {enemydamage} damage ");
                playerHP = playerHP - enemydamage;
                Console.WriteLine($"You now have {playerHP} Health Left ");

            }
        }

        void chefCritless()
        {
            if (enemyCritchance != 1)
            {
                Console.WriteLine($"The Palace Chef dealt you {enemydamage} damage ");
                playerHP = playerHP - enemydamage;
                Console.WriteLine($"You now have {playerHP} Health Left ");

            }
        }

        void pucciAttack()
        {

            Console.WriteLine($"High Priest Pucci has {enemyHP} Health");

            pucciCrit();

            pucciCritless();
        }

        void prisonerAttack()
        {

            Console.WriteLine($"The prisoner has {enemyHP} Health");

            prisonerCrit();

            prisonerCritless();
        }

        void chefAttack()
        {

            Console.WriteLine($"The Palace Chef has {enemyHP} Health");

            chefCrit();

            chefCritless();
        }

        void playerSlashCrit()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("You get ready to release your anger upon your enemy!");


            playerSlashDamage = playerSlashDamage * 2;
            Console.WriteLine($"You were able to slash your enemy with your weapon {playerSlashDamage} Damage!");

            enemyHP = enemyHP - playerSlashDamage;
            Console.ForegroundColor = ConsoleColor.White;
        }

        void playerStabCrit()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("You get ready to release your anger upon your enemy!");


            playerStabDamage = playerStabDamage * 2;
            Console.WriteLine($"You managed to thrust your weapon into your enemy's body and dealt {playerStabDamage} Damage!");

            enemyHP = enemyHP - playerStabDamage;
            Console.ForegroundColor = ConsoleColor.White;
        }

        void playerFryCrit()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("You get ready to release your anger upon your enemy!");


            playerStabDamage = playerStabDamage * 2;
            Console.WriteLine($"You were able to smack your enemy in the head with your frying pan and dealt {playerStabDamage} Damage!");

            enemyHP = enemyHP - playerStabDamage;
            Console.ForegroundColor = ConsoleColor.White;
        }

        void blockedPucci()
        {
            if (playerblockchance == 1 && enemyCritchance != 1)
            {
                Console.WriteLine($"High Priest Pucci dealt you {enemydamage} damage ");
                Console.WriteLine("However, you were able to put your guard up in time, and Pucci hardly dealt any damage to you");
                playerHP = playerHP - 1;
                Console.WriteLine($"You now have {playerHP} Health Left ");


            }
        }

        void blockedPrisoner()
        {
            if (playerblockchance == 1 && enemyCritchance != 1)
            {
                Console.WriteLine($"The prisoner dealt you {enemydamage} damage ");
                Console.WriteLine("However, you were able to put your guard up in time, and the prisoner hardly dealt any damage to you");
                playerHP = playerHP - 1;
                Console.WriteLine($"You now have {playerHP} Health Left ");


            }
        }

        void blockedChef()
        {
            if (playerblockchance == 1 && enemyCritchance != 1)
            {
                Console.WriteLine($"The Palace Chef attempted to deal you {enemydamage} damage ");
                Console.WriteLine("However, you were able to put your guard up in time, and hardly dealt any damage to you");
                playerHP = playerHP - 1;
                Console.WriteLine($"You now have {playerHP} Health Left ");


            }
        }

        void blockedPucciFail()
        {
            if (playerblockchance == 1 && enemyCritchance == 1)
            {
                Console.WriteLine("High Priest Pucci has contolled his emotions and packed them into a single devastating punch!");

                Console.WriteLine("You attempted to block High Priest Pucci's attack, but he broke through your guard and hit you with his devastating punch!");
                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                Console.WriteLine($"You now have {playerHP} Health Left ");

            }
        }

        void blockedPrisonerFail()
        {
            if (playerblockchance == 1 && enemyCritchance == 1)
            {
                Console.WriteLine("The prisoner has contolled his emotions and packed them into a single devastating punch!");

                Console.WriteLine("You attempted to block the prisoner's attack, but he broke through your guard and hit you with his devastating punch!");
                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                Console.WriteLine($"You now have {playerHP} Health Left ");

            }
        }

        void blockedChefFail()
        {
            if (playerblockchance == 1 && enemyCritchance == 1)
            {
                Console.WriteLine("The Palace Chef has contolled their emotions and packed them into a single devastating punch!");

                Console.WriteLine("You attempted to block The Palace Chef's attack, but they broke through your guard and hit you with their devastating attack!");
                enemydamage = enemydamage * 2;
                playerHP = playerHP - enemydamage;
                Console.WriteLine($"You now have {playerHP} Health Left ");

            }
        }

        void pucciKill()
        {
            if (playerHP <= 0)
            {
                Console.WriteLine("High Priest Pucci has defeated you and stolen your throne");
            }
        }

        void prisonerKill()
        {
            if (playerHP <= 0)
            {
                Console.WriteLine("The prisoner in your cell has defeated you and stolen your throne");
            }
        }

        void checkDeath()
        {
            if (playerHP <= 0)
            {
                playerHP = 0;
            }
        }

        void chefKill()
        {
            if (playerHP <= 0)
            {
                Console.WriteLine("The Palace Chef has defeated you and allowed High Priest Pucci to steal your throne");
            }
        }

        void pucciDeath()
        {
            if (enemyHP <= 0)
            {
                enemySpawned = 0;
                pucciKilled = true;
                Console.WriteLine(deathMessage3);
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
            playerSlashDamage = rnd.Next(10000, 150000);
            playerStabDamage = rnd.Next(2, 75);
            playerFryDamage = rnd.Next(0, 50);
            enemydamage = rnd.Next(9, 50);
        }

        void roomSwitch()
        {
            switch (room)
            {
                case "cell":
                    Console.WriteLine("You woke up in your palace dungeon in a small cell with a light in it.");
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
                    e = 1;
                    Console.WriteLine("A prisoner appears in your cell before you, what would you like to do? [Fight] [Flee]");
                    fightflight = Console.ReadLine();
                    break;

                case "Kitchen":
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
                    Console.WriteLine("You chose to enter the kitchen, and the chef appears before you, what would you like to do? [Fight] [Flee]");
                    e = 2;
                    fightflight = Console.ReadLine();
                    break;

                case "throneRoom":
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
                    Console.WriteLine("You proceeded from the Kitchen to the throne room. You are now in the presence of the High Priest Pucci! What would you like to do? [Fight] [Flee]?");
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
                    Console.WriteLine("You decided to fight the enemy in front of you");
                    enemyChance = 1;
                    break;

                case "Flee":
                    enemyChance = 0;
                    Console.WriteLine("You decided to flee from the enemy in front of you and run back down into the dungoen cell to lock yourself in.");
                    Console.WriteLine("You are now living in the palace dungeon cell for the rest of your life");
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
                    enemyHP = rnd.Next(150, 300);
                    break;
                case 2:
                    enemySpawned = 2;
                    enemyHP = rnd.Next(75, 125);
                    break;
                case 3:
                    enemySpawned = 3;
                    enemyHP = rnd.Next(50, 100);
                    break;

            }
        }

        roomSwitch();
        fightFlight();
        eswitch();

        if (enemyChance == 1)
        {

            if (enemySpawned == 1)
            {
                Console.WriteLine(spawnMessage1);

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

                if (enemySpawned == 1)
                {
                    while (enemySpawned == 1)
                    {
                        prisonerMsg();
                        answer = Console.ReadLine();

                        if (fryingPan != true)
                        {
                            if (answer == "Slash" ^ answer == "slash" ^ answer == "1" ^ answer == "s")
                            {
                                rndDam();

                                if (playerCritchance == 1)
                                {
                                    playerSlashCrit();
                                }

                                else if (playerCritchance != 1)
                                {
                                    Console.WriteLine($"You slashed your weapon at the Prisoner for {playerSlashDamage} damage");
                                    enemyHP = enemyHP - playerSlashDamage;
                                }

                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    prisonerAttack();
                                }

                                prisonerDeath();

                                prisonerKill();
                            }

                            if (answer == "Thrust" ^ answer == "thrust" ^ answer == "2" ^ answer == "t")
                            {
                                rndDam();

                                if (playerCritchance == 1)
                                {
                                    playerStabCrit();
                                }

                                else if (playerCritchance != 1)
                                {
                                    Console.WriteLine($"You thrust  your weapon into High Priest Pucci for {playerStabDamage} damage");
                                    enemyHP = enemyHP - playerSlashDamage;
                                }

                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    prisonerAttack();
                                }

                                prisonerDeath();

                                prisonerKill();
                            }

                            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
                            {

                                rndDam();
                                playerblockchance = 1;

                                blockedPrisoner();
                                blockedPrisonerFail();
                                prisonerKill();
                            }
                        }

                        else if (fryingPan == true)
                        {
                            if (answer == "Smack" ^ answer == "smack" ^ answer == "1" ^ answer == "s")
                            {
                                rndDam();

                                if (playerCritchance == 1)
                                {
                                    playerFryCrit();
                                }

                                else if (playerCritchance != 1)
                                {
                                    Console.WriteLine($"You smacked the Prisoner for {playerFryDamage} damage");
                                    enemyHP = enemyHP - playerFryDamage;
                                }

                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    prisonerAttack();
                                }

                                prisonerDeath();

                                prisonerKill();
                            }

                            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
                            {
                                rndDam();
                                playerblockchance = 1;

                                blockedPrisoner();
                                blockedPrisonerFail();
                                prisonerKill();

                            }

                            else if (answer == "Heal" ^ answer == "heal" ^ answer == "3" ^ answer == "c")
                            {
                                rndDam();
                                playerHeal();

                                prisonerDeath();
                                prisonerKill();
                            }

                        }
                    }
                    if (prisonerKilled == true)
                    {
                        Console.WriteLine("You have killed the prisoner and are now able to escape the prison cell, what would you like to do? [Leave] [Stay]");
                        answer = Console.ReadLine();
                        if (answer == "Leave")
                        {
                            room = "Kitchen";
                        }

                        else if (answer == "Stay")
                        {
                            Console.WriteLine("You decided that it would be better for you to stay in the mangy palace dungeon cell for the rest of your days");
                            Environment.Exit(0);
                        }
                    }
                    roomSwitch();
                    fightFlight();
                    eswitch();
                }
            }


            if (prisonerKilled == true && e == 2)
            {


                Console.WriteLine(spawnMessage2);

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

                if (enemySpawned == 2)
                {
                    while (enemySpawned == 2)
                    {
                        chefMsg();
                        answer = Console.ReadLine();

                        if (fryingPan != true)
                        {
                            if (answer == "Slash" ^ answer == "slash" ^ answer == "1" ^ answer == "s")
                            {
                                rndDam();

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
                                }

                                chefDeath();

                                chefKill();
                            }

                            if (answer == "Thrust" ^ answer == "thrust" ^ answer == "2" ^ answer == "t")
                            {
                                rndDam();

                                if (playerCritchance == 1)
                                {
                                    playerStabCrit();
                                }

                                else if (playerCritchance != 1)
                                {
                                    Console.WriteLine($"You thrust  your weapon into High Priest Pucci for {playerStabDamage} damage");
                                    enemyHP = enemyHP - playerSlashDamage;
                                }

                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    chefAttack();
                                }

                                chefDeath();

                                chefKill();
                            }

                            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
                            {

                                rndDam();
                                playerblockchance = 1;

                                blockedChef();
                                blockedChefFail();
                                chefKill();
                            }

                            else if (answer == "Heal" ^ answer == "heal" ^ answer == "3" ^ answer == "c")
                            {
                                rndDam();

                                playerHeal();

                                chefDeath();

                                chefKill();
                            }
                        }

                        else if (fryingPan == true)
                        {
                            if (answer == "Smack" ^ answer == "smack" ^ answer == "1" ^ answer == "s")
                            {
                                rndDam();

                                if (playerCritchance == 1)
                                {
                                    playerFryCrit();
                                }

                                else if (playerCritchance != 1)
                                {
                                    Console.WriteLine($"You were able to smack the Palace Chef for {playerFryDamage} damage");
                                    enemyHP = enemyHP - playerFryDamage;
                                }

                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    chefAttack();
                                }

                                chefDeath();

                                chefKill();
                            }

                            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
                            {

                                rndDam();
                                playerblockchance = 1;

                                blockedChef();
                                blockedChefFail();
                                chefKill();
                            }

                            else if (answer == "Heal" ^ answer == "heal" ^ answer == "3" ^ answer == "c")
                            {
                                rndDam();

                                playerHeal();

                                chefDeath();

                                chefKill();


                            }
                        }
                    }
                    if (chefKilled == true)
                    {
                        Console.WriteLine("Now that you have killed the palace chef you are able to walk towards the throne room where High Priest Pucci resides on your rightful seat. However, while walking there you come to the realisation that maybe he could be a beteer leader than you");
                        Console.WriteLine("After coming to this realisation, you notice that you are right next to the palace entranceway. You now have to decide whether to leave the palace forever, or continue forwards to kill High Priest Pucci and take back your throne");
                        Console.WriteLine("Which do you decide to do? [Continue] [Leave]");
                        answer = Console.ReadLine();
                        if (answer == "Continue")
                        {
                            room = "throneRoom";
                            roomSwitch();
                        }

                        else if (answer == "Leave")
                        {
                            Console.WriteLine("You decided that High Priest Pucci would be a better ruler of your kingdom than you would be, so you decided to leave the palace without killing him, and venture into the forests and live in a cabin");
                            Console.WriteLine(@"");
                            Environment.Exit(0);
                        }
                    }
                }
                roomSwitch();
                fightFlight();
                eswitch();
            }


            if (prisonerKilled == true && chefKilled == true && e == 3)
            {


                Console.WriteLine(spawnMessage3);

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


                if (enemySpawned == 3)
                {
                    while (enemySpawned == 3)
                    {
                        pucciMsg();
                        answer = Console.ReadLine();

                        if (fryingPan != true)
                        {
                            if (answer == "Slash" ^ answer == "slash" ^ answer == "1" ^ answer == "s")
                            {
                                rndDam();

                                if (playerCritchance == 1)
                                {
                                    playerSlashCrit();
                                }

                                else if (playerCritchance != 1)
                                {
                                    Console.WriteLine($"You slashed your weapon at High Priest Pucci for {playerSlashDamage} damage");
                                    enemyHP = enemyHP - playerSlashDamage;
                                }

                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    pucciAttack();
                                }

                                pucciDeath();

                                pucciKill();
                            }

                            if (answer == "Thrust" ^ answer == "thrust" ^ answer == "2" ^ answer == "t")
                            {
                                rndDam();

                                if (playerCritchance == 1)
                                {
                                    playerStabCrit();
                                }

                                else if (playerCritchance != 1)
                                {
                                    Console.WriteLine($"You thrust  your weapon into High Priest Pucci for {playerStabDamage} damage");
                                    enemyHP = enemyHP - playerSlashDamage;
                                }

                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    pucciAttack();
                                }

                                pucciDeath();

                                pucciKill();
                            }

                            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
                            {

                                rndDam();
                                playerblockchance = 1;

                                blockedPucci();
                                blockedPucciFail();
                                pucciKill();
                            }
                        }

                        else if (fryingPan == true)
                        {
                            if (answer == "Smack" ^ answer == "smack" ^ answer == "1" ^ answer == "s")
                            {
                                rndDam();

                                if (playerCritchance == 1)
                                {
                                    playerFryCrit();
                                }

                                else if (playerCritchance != 1)
                                {
                                    Console.WriteLine($"You smacked High Priest Pucci for {playerFryDamage} damage");
                                    enemyHP = enemyHP - playerFryDamage;
                                }

                                if (enemyHP > 0 && playerHP > 0)
                                {
                                    pucciAttack();
                                }

                                pucciDeath();

                                pucciKill();
                            }

                            else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
                            {
                                rndDam();
                                playerblockchance = 1;

                                blockedPucci();
                                blockedPucciFail();
                                pucciKill();

                            }

                            else if (answer == "Heal" ^ answer == "heal" ^ answer == "3" ^ answer == "c")
                            {
                                rndDam();
                                playerHeal();

                                pucciDeath();
                                pucciKill();
                            }

                        }
                    }


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







    }
}