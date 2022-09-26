Random rnd = new Random();
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
int playerDamage;
int e;
Boolean blocking = false;

string answer = "n";
string choice = "";


spawnMessage1 = "High Priest Pucci appeared before you";
spawnMessage2 = "The epic prison guard appeared before you";
spawnMessage3 = "The enemy prisoner appeared before you";
deathMessage1 = "High Priest Pucci has finally been eliminated";
deathMessage2 = "You deafeated the prison guard";
deathMessage3 = "You vanquished the enemy prisoner";

e = rnd.Next(1, 4);
Boolean enemy1Spawned = false;
Boolean enemy2Spawned = false;
Boolean enemy3Spawned = false;

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

    Console.WriteLine("What would you like to do? [Attack] [Block] [Heal]");
    Thread.Sleep(2000);

    

}

void pucciAttack()
{
    Thread.Sleep(1000);
    Console.WriteLine($"High Priest Pucci has  {enemyHP} Health");


    Console.WriteLine("High Priest Pucci has contolled his emotions and packed them into a single devastating punch!");
    Thread.Sleep(2000);

    if (enemyCritchance == 1)
    {
        enemydamage = enemydamage * 2;
        playerHP = playerHP - enemydamage;
        Console.WriteLine($"You now have {playerHP} Health Left ");
        Thread.Sleep(2000);
    }

    else if (enemyCritchance != 1)
    {
        Console.WriteLine($"High Priest Pucci dealt you {enemydamage} damage ");
        playerHP = playerHP - enemydamage;
        Console.WriteLine($"You now have {playerHP} Health Left ");
        Thread.Sleep(2000);
    }
}

void playerCrit()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Thread.Sleep(1000);
    Console.WriteLine("You get ready to release your anger upon your enemy!");
    Thread.Sleep(1000);
    Thread.Sleep(1000);

    playerDamage = playerDamage * 2;
    Console.WriteLine($"You managed to land your attack in your enemy's weak spot, it did {playerDamage} Damage!");

    enemyHP = enemyHP - playerDamage;
    Console.ForegroundColor = ConsoleColor.White;
}

void blockedPucci()
{

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
    playerDamage = rnd.Next(12, 50);
    enemydamage = rnd.Next(9, 35);
}

enemyChance = rnd.Next(1, 1);
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

        if (answer == "Attack" ^ answer == "attack" ^ answer == "1" ^ answer == "a")
        {
            rndDam();

            if (playerCritchance == 1)
            {
                playerCrit();
            }

            else if (playerCritchance != 1)
            {
                Console.WriteLine($"You attacked Pucci for {playerDamage} damage");
                enemyHP = enemyHP - playerDamage;
            }

            if (enemyHP <= 0)
            {
                enemy1Spawned = false;
                Console.WriteLine(deathMessage1);
            }

            else if (enemyHP > 0 && playerHP > 0)
            {
                pucciAttack();
            }

            pucciKill();
        }  
        
        else if (answer == "Block" ^ answer == "block" ^ answer == "2" ^ answer == "b")
        {
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