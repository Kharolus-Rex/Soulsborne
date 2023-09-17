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
        public static void CombatLoop(Player player, Monster monster)
        {
            while (true)
            {
                //player turn
                int playerDamage = CalculateDamage(player.Weapons[0]);
                monster.HP -= playerDamage;
                Console.WriteLine($"{player.PlayerName} dealt {playerDamage} {player.Weapons[0].DamageType} damage to {monster.Name}.");
                if ( monster.HP <= 0 )
                {
                    Console.WriteLine($"{monster.Name} is slain.");
                    World.rooms[World.players[0].PlayerLocation].Monsters.RemoveAt(0);
                    return;
                }

                //monster turn
                int monsterDamage = CalculateDamage(monster.MonsterWeapon);
                player.PlayerHP -= monsterDamage;
                Console.WriteLine($"{monster.Name} deals {monsterDamage} {monster.MonsterWeapon.DamageType} damage to {player.PlayerName}.");
                if ( player.PlayerHP <= 0 )
                {
                    Console.WriteLine($"{player.PlayerName} is slain.");
                    ActiveGameplay.GameOver();
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
