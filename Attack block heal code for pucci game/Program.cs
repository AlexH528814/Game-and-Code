﻿Random rnd = new Random();
string spawnMessage1;
string spawnMessage2;
string spawnMessage3;
string deathMessage1;
string deathMessage2;
string deathMessage3;
int enemyChance;
int Number;
int enemyHP = 0;
int playerHP = 100;
int enemydamage;
int playerblockchance;
int playerCritchance;
int enemyCritchance;
int Heals = 3;
int healthgain;
int playerStabDamage;
int playerThrustDamage;
int e;
Boolean blocking = false;

string answer = "n";
string movechoice = "";
string fightflight = "";


spawnMessage1 = "High Priest Pucci appeared before you";
spawnMessage2 = "The epic prison guard appeared before you";
spawnMessage3 = "The enemy prisoner appeared before you";
deathMessage1 = "High Priest Pucci has finally been eliminated";
deathMessage2 = "You deafeated the prison guard";
deathMessage3 = "You vanquished the enemy prisoner";

Boolean enemy1Spawned = false;
Boolean enemy2Spawned = false;
Boolean enemy3Spawned = false;

switch (fightflight)
{
    case "Fight":
        Console.WriteLine("You decided to fight the prisoner");
        enemyChance = 1;
        e = 1;
        break;

    case "Flee":
        enemyChance = 0;
        Console.WriteLine("You chose to flee from the prisoner");
        break;

}

switch (movechoice)
{
    case "Left":
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
        Console.WriteLine("A prisoner appears in your cell before you, what would you like to do? [Fight] [Flee]")
            fightflight = Console.ReadLine();
            
}

switch (e)
{
    case 1:
        enemy1Spawned = true;
        enemyHP = rnd.Next(150, 300);
        break;
    case 2:
        enemy2Spawned = true;
        enemyHP = rnd.Next(75, 125);
        break;
    case 3:
        enemy3Spawned = true;
        enemyHP = rnd.Next(50, 100);
        break;

}

void pucciMsg()
{
    Console.WriteLine($"High Priest Pucci has {enemyHP} Health");
    Thread.Sleep(2000);

    Console.WriteLine("What would you like to do? [Stab] [Thrust] [Block] [Heal]");
    Thread.Sleep(2000);
}

void pucciCrit()
{
    if (enemyCritchance == 1)
    {
       Console.WriteLine("High Priest Pucci has contolled his emotions and packed them into a single devastating punch!");
        Thread.Sleep(1000);
        enemydamage = enemydamage * 2;
        playerHP = playerHP - enemydamage;
        Console.WriteLine($"You now have {playerHP} Health Left ");
        Thread.Sleep(2000);
    }
}

void pucciCritless()
{
    if (enemyCritchance != 1)
    {
        Console.WriteLine($"High Priest Pucci dealt you {enemydamage} damage ");
        playerHP = playerHP - enemydamage;
        Console.WriteLine($"You now have {playerHP} Health Left ");
        Thread.Sleep(2000);
    }
}

void pucciAttack()
{
    Thread.Sleep(1000);
    Console.WriteLine($"High Priest Pucci has {enemyHP} Health");


    

    pucciCrit();

    pucciCritless();
}

void playerStabCrit()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Thread.Sleep(1000);
    Console.WriteLine("You get ready to release your anger upon your enemy!");
    Thread.Sleep(1000);
    Thread.Sleep(1000);

    playerStabDamage = playerStabDamage * 2;
    Console.WriteLine($"You managed to land your stab attack in your enemy's weak spot, it did {playerStabDamage} Damage!");

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
        Thread.Sleep(2000);

    }
}

void blockedPucciFail()
{
    if (playerblockchance == 1 && enemyCritchance == 1)
    {
        Console.WriteLine("High Priest Pucci has contolled his emotions and packed them into a single devastating punch!");
        Thread.Sleep(1000);
        Console.WriteLine("You attempted to block High Priest Pucci's attack, but he broke through your guard and hit you with his devastating punch!");
        enemydamage = enemydamage * 2;
        playerHP = playerHP - enemydamage;
        Console.WriteLine($"You now have {playerHP} Health Left ");
        Thread.Sleep(2000);
    }
}

void pucciKill()
{
    if (playerHP <= 0)
    {
        Console.WriteLine("High Priest Pucci has stolen your throne and defeated you");
    }    
}
void pucciDeath()
{
    if (enemyHP <= 0)
    {
        enemy1Spawned = false;
        Console.WriteLine(deathMessage1);
    }
}

void rndDam()
{
    playerCritchance = rnd.Next(0, 10);
    enemyCritchance = rnd.Next(0, 10);

    playerblockchance = rnd.Next(0, 6);
    playerStabDamage = rnd.Next(12, 50);
    playerThrustDamage = rnd.Next(2, 75);
    enemydamage = rnd.Next(9, 35);
}

Console.WriteLine(e);
if (enemyChance == 1 && e == 1)
{
    enemy1Spawned = true;
    Console.WriteLine(spawnMessage1);
    Thread.Sleep(1000);
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

else if (enemyChance != 1)
{
    enemy1Spawned = false;
    enemy2Spawned = false;
    enemy3Spawned = false;
}

if (enemy1Spawned == true)
{
    while (enemy1Spawned == true)
    {
        pucciMsg();
        answer = Console.ReadLine();

        if (answer == "Stab" ^ answer == "stab" ^ answer == "1" ^ answer == "s")
        {
            rndDam();

            if (playerCritchance == 1)
            {
                playerStabCrit();
            }

            else if (playerCritchance != 1)
            {
                Console.WriteLine($"You stabbed High Priest Pucci for {playerStabDamage} damage");
                enemyHP = enemyHP - playerStabDamage;
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
}

else if (enemyChance == 1 && e == 2)
{
    Console.WriteLine("Unfinished");
}

else if (enemyChance == 1 && e == 3)
{
    Console.WriteLine("Unfinished");
}