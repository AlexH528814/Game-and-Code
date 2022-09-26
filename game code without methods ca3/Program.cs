using System.Runtime.CompilerServices;

string SpawnMessage1;
string Choice;
int EnemyChance;
int Number;
int enemyHP;
int playerHP = 100;
int enemydamage;
int playerblockchance;
int playerCritchance;
int enemyCritchance;
int Heals = 3;
int healthgain;
int playerDamage;
int MonsterChance;
Boolean debouce = false;
Boolean blocking = false;



SpawnMessage1 = "High Priest Pucci appeared before you";
Boolean enemy1Spawned = false;
Boolean enemy2Spawned = false;
Boolean enemy3Spawned = false;
Random rnd = new Random();

void RndDam()
{
    playerCritchance = rnd.Next(0, 10);
    enemyCritchance = rnd.Next(0, 10);

    playerblockchance = rnd.Next(0, 6);
    playerDamage = rnd.Next(12, 50);
    enemydamage = rnd.Next(9, 35);
}
enemyHP = rnd.Next(100, 500);
MonsterChance = rnd.Next(1, 1);
if (MonsterChance == 1)
{
    enemy1Spawned = true;
    Console.WriteLine(SpawnMessage1);
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
else if (MonsterChance != 1)
{
    enemy1Spawned = false;
}
if (enemy1Spawned == true)
{
    while (enemy1Spawned == true && debouce == false)
    {
        debouce = true;
        Console.WriteLine($"High Priest Pucci has  {enemyHP} Health");
        Thread.Sleep(1000);

        Console.WriteLine("What would you like to do? [Attack] [Block] [Heal]");
        Thread.Sleep(1000);

        string answer = Console.ReadLine();

        if (answer == "Attack" ^ answer == "attack" ^ answer == "1")
        {
            RndDam();

            Thread.Sleep(1000);
            if (playerCritchance == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(1000);
                Console.WriteLine("You charge up  strong attack!");
                Thread.Sleep(1000);
                
               

                playerDamage = playerDamage * 2;
                Console.WriteLine($"Your Attack did {playerDamage} Damage, Critical!");
                Console.ForegroundColor = ConsoleColor.White; 
                Thread.Sleep(1000);
                enemyHP = enemyHP - playerDamage;
            }
            else if (playerCritchance != 1)
            {

                Console.WriteLine($"Your Attack did {playerDamage} Damage");
                enemyHP = enemyHP - playerDamage;

            }

            if (enemyHP <= 0)
            {
                Thread.Sleep(1000);

                enemy1Spawned = false;
                Console.WriteLine("You eliminated Father Pucci");
                Thread.Sleep(1000);

            }
            else if (enemyHP > 0 && playerHP > 0)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"High Priest Pucci has  {enemyHP} Health");


                Console.WriteLine("High Priest Pucci is getting ready to deal a hurtful blow!");
                Thread.Sleep(1000);

                if (enemyCritchance == 1)
                {
                    enemydamage = enemydamage * 2;
                    playerHP = playerHP - enemydamage;
                    Console.WriteLine($"You have {playerHP} Health Left ");
                    Thread.Sleep(2000);
                }

                else if (enemyCritchance != 1)
                {
                    Console.WriteLine($"High Priest Pucci dealt you {enemydamage} damage ");
                    playerHP = playerHP - enemydamage;
                    Console.WriteLine($"You have {playerHP} Health Left ");
                    Thread.Sleep(1000);
                }


                if (playerHP <= 0)
                {
                    Console.WriteLine("High Priest Pucci vanquished you!");
                    Thread.Sleep(1000);

                }
                else if (playerHP > 0)
                {
                    debouce = false;

                }


            }
        }
        else if (answer == "Block" ^ answer == "block")
        {
            RndDam();
            Thread.Sleep(1000);


            if (enemyHP <= 0)
            {
                Thread.Sleep(1000);

                enemy1Spawned = false;
                Console.WriteLine("The Monster has died");
                Thread.Sleep(1000);

            }
            else if (enemyHP > 0 && playerHP > 0)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"High Priest Pucci has {enemyHP} Health");

                if (playerblockchance != 1 && enemyCritchance != 1)
                {
                    Console.WriteLine("High Priest Pucci attempts to calm his nerves while sending a strike your way!");
                    Thread.Sleep(1000);

                    Console.WriteLine($"High Priest Pucci dealt you {enemydamage} damage, However you blocked it! ");
                    playerHP = playerHP;
                    Console.WriteLine($"You have {playerHP} Health Left. You remain intact!");
                    Thread.Sleep(1000);
                }
                else if (playerblockchance != 1 && enemyCritchance == 1)
                {
                    Console.WriteLine("High Priest Pucci counts the first first 10 digits of Pi, 3.1415926535 in order to stabalise his emotions for a violent punch");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Thread.Sleep(1000);
                    Console.WriteLine("High Priest Pucci is glowing with the energy of his releasing emotions");
                    Thread.Sleep(1000);

                    Console.ForegroundColor = ConsoleColor.White;

                    Thread.Sleep(1000);

                    Console.WriteLine($"High Priest Pucci dealt {enemydamage} damage, You atempted to block his attack but your guard was broken!");
                    playerHP = playerHP - enemydamage * 4 / 3;
                    

                }


                if (playerHP <= 0)
                {
                    Console.WriteLine("High Priest Pucci eliminated you!");
                    Thread.Sleep(1000);
                    playerHP = 0;
                }
                else if (playerHP > 0)
                {
                    debouce = false;

                }

                    Console.WriteLine($"you have {playerHP} Health Left.");
            }
        }
        else if (answer == "Heal" ^ answer == "heal")
        {
            RndDam();

            if (Heals > 0)
            {
                healthgain = rnd.Next(10, 15);
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("You swiftly grab the red potion from you side and down it..");
                Heals = Heals - 1;
                Thread.Sleep(1500);
                Console.WriteLine($"You have {Heals} Potions left!");

                Console.WriteLine($"You Gain {healthgain} Health!");
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.White;

                playerHP = playerHP + healthgain;
                Console.WriteLine($"You have {playerHP} Health");
            }
            else if (Heals <= 0)
            {
                Console.WriteLine("You put your hand to your side to grab a potion but..");

                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(1000);
                Console.WriteLine("Theres nothing there");

                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.White;



            }

            if (enemyHP > 0 && playerHP > 0)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"High Priest Pucci has  {playerHP} Health remaining");

                if (playerblockchance != 1 && enemyCritchance != 1)
                {
                    Console.WriteLine("High Priest Pucci is readying himself to strike you and it's fist extends and a fast speed!");
                    Thread.Sleep(1000);

                    Console.WriteLine($"High Priest Pucci dealt you {enemydamage} damage, However you managed to block it! ");
                 
                    Console.WriteLine($"You have {playerHP} Health Left. You remain intact!");
                    Thread.Sleep(1000);
                }
                else if (playerblockchance != 1 && enemyCritchance == 1)
                {
                    Console.WriteLine("High Priest Pucci gets ready to punch you");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Thread.Sleep(1000);
                    Console.WriteLine("High Priest Pucci has turned Red from the anger he is feeling towards you!");
                    Thread.Sleep(1000);

                    Console.ForegroundColor = ConsoleColor.White;

                    Thread.Sleep(1000);

                    Console.WriteLine($"High Priest Pucci has dealt {enemydamage} damage, you atempted to block his attack but your guard was broken!");
                    playerHP = playerHP - enemydamage * 4 / 3;
                    Console.WriteLine($"You have {playerHP} Health remaining.");

                }


                if (playerHP <= 0)
                {
                    Console.WriteLine("High Priest Pucci has vanquished you!");
                    Thread.Sleep(1000);
                    playerHP = 0;
                }
                else if (playerHP > 0)
                {
                    debouce = false;

                }
                    

            }
        }

    }
}