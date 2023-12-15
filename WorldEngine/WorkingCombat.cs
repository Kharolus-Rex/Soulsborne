using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    internal class WorkingCombat
    {
        private static Random random = new Random();
        //for use in combat and damage calculations
        public static void CombatLoop()
        {
            Player player = World.players[0]; // Always references current player data.
            Monster monster = World.rooms[World.players[0].PlayerLocation].Monsters[0]; // Always references current monster data.

            while (true)
            {
                //general dice variable. used for both player and monster.
                int diceRoll;
                //player turn
                int playerDamage;
                //roll to hit
                diceRoll = random.Next(1, 21);
                if (diceRoll >= monster.AC)
                {
                    playerDamage = CalculateDamage(player.Weapons[0]);
                    monster.HP -= playerDamage;
                    Console.WriteLine($"{player.Name} dealt {playerDamage} {player.Weapons[0].DamageType} damage to {monster.Name}.");
                    if (monster.HP <= 0)
                    {
                        Console.WriteLine($"{monster.Name} is slain.");
                        World.rooms[World.players[0].PlayerLocation].Monsters.RemoveAt(0);
                        return;
                    }
                }
                //if no hit
                else
                {
                    Console.WriteLine($"{player.Name} failed to hit {monster.Name}!");
                }

                //monster turn
                int monsterDamage;
                //roll to hit
                diceRoll = random.Next(1, 21);
                if (diceRoll >= player.AC)
                {
                    monsterDamage = CalculateDamage(monster.MonsterWeapon);
                    player.HP -= monsterDamage;
                    Console.WriteLine($"{monster.Name} deals {monsterDamage} {monster.MonsterWeapon.DamageType} damage to {player.Name}.");
                    if (player.HP <= 0)
                    {
                        Console.WriteLine($"{player.Name} is slain.");
                        ActiveGameplay.GameOver();
                    }
                }
                else
                {
                    Console.WriteLine($"{monster.Name} failed to hit {player.Name}!");
                }
            }
        }

        public static int CalculateDamage(Weapon weapon)
        {
            string[] damageTokens = weapon.Damage.Split('d');
            int numberOfDice = int.Parse(damageTokens[0]);
            int diceSize = int.Parse(damageTokens[1]);

            int totalDamage = 0;
            for (int i = 0; i < numberOfDice; i++)
            {
                totalDamage += random.Next(1, diceSize + 1);
            }
            return totalDamage;
        }


    }
}
