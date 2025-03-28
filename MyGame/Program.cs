using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int nEnemy = int.Parse(args[0]);
            Enemy[] enemies = new Enemy[nEnemy];
            for (int i = 0; i < nEnemy; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string enemyName = Console.ReadLine();
                enemies[i] = new Enemy(enemyName);
                enemies[i].TakeDamage(10);
            }
            for (int i = 0; i < nEnemy; i++)
            {
                Console.WriteLine($"{enemies[i].GetName()} {enemies[i].GetHealth()} {enemies[i].GetShield()}");
                enemies[i].PickupPowerUp(PowerUp.Health, 20);
                enemies[i].PickupPowerUp(PowerUp.Shield, 20);
                Console.WriteLine($"{enemies[i].GetName()} {enemies[i].GetHealth()} {enemies[i].GetShield()}");
            }
        }
    }
}
